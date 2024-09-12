Option Explicit On

Imports ForecastIO

Public Class frmNetChecker

    'Const MAXTEMP_SUMMER = 74   'Keep the max closer to target
    'Const MINTEMP_SUMMER = 71
    'Const MAXTEMP_WINTER = 73
    'Const MINTEMP_WINTER = 70   'Keep the min closer to target
    'Const SUMMER = 73
    'Const WINTER = 68
    Const LAMPTIMEOUT = 4000

    Dim lblVents(6) As Label
    Dim lblVentStatus(6) As Label
    Dim lblTempVal(6) As Label
    Dim iVentCurrentState(6) As Integer
    Dim iEthanLampState, iSydneyLampState As Integer
    Dim iBrineTankLevel As Integer = 0
    Dim strExpectedTargetTemp, strTempLastMode As String
    Dim strActualTargetTemp As String
    Dim oTempLastRowID As Object

    Private Sub frmNetChecker_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dim FILE_NAME As String = "WDNetCheckerParameter.xml"
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            Dim strOutput As String

            strOutput = "<Parameter><Mute>"
            If chkMute.Checked Then
                strOutput = strOutput & "True</Mute>"
            Else
                strOutput = strOutput & "False</Mute>"
            End If
            strOutput = strOutput & "</Parameter>"

            objWriter.Write(strOutput)
            objWriter.Close()

            Event_HistoryTableAdapter.InsertQuery("9020")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub frmNetChecker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim i As Integer
        Dim xmlData As DataSet = New DataSet()

        btnStop.Enabled = False
        Me.Visible = True
        Me.Refresh()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        Event_HistoryTableAdapter.InsertQuery("9019")

        lblVents(0) = lblPlayRoomVent
        lblVents(1) = lblLivingRoomVent
        lblVents(2) = lblGreatRoomNVent
        lblVents(3) = lblGreatRoomSVent
        lblVents(4) = lblKitchenNVent
        lblVents(5) = lblKitchenSVent

        lblVentStatus(0) = lblPlayRoomVentStatus
        lblVentStatus(1) = lblLivingRoomVentStatus
        lblVentStatus(2) = lblGreatRoomNStatus
        lblVentStatus(3) = lblGreatRoomSStatus
        lblVentStatus(4) = lblKitchenNStatus
        lblVentStatus(5) = lblKitchenSStatus

        lblTempVal(0) = Play_RoomLabel1
        lblTempVal(1) = Living_RoomLabel1
        lblTempVal(2) = GreatRmLabel1
        lblTempVal(3) = GreatRmLabel2
        lblTempVal(4) = KitchenLabel1
        lblTempVal(5) = KitchenLabel2

        'Initialize Vents
        'For i = 0 To 5
        'iVentCurrentState(i) = 0
        'ChangeVent(i, 0)
        'Next

        'GetGreatRmTemp()
        'If lblGreatRmTempStatus.Text <> "X" And lblGreatRmTemp.Text <> "00" And lblGreatRmTemp.Text <> "" Then
        'Temp_Current_StateTableAdapter.Update_GreatRmTemp(lblGreatRmTemp.Text)
        'End If

        'UpdateVents()
        'GetLizardHabitatInfo()
        CheckSevereWeather2()
        'iBrineTankLevel = GetBrineTankLevel()
        Event_Current_StateTableAdapter.HourlyUpdate(80, GetInternetConnectStatus())
        Event_Current_StateTableAdapter.FiveMinUpdate(0, 0, GetStairLightsStatus())

        Me.Event_Current_StateTableAdapter.Fill(Me.WatchdogDataSet.Event_Current_State) 'Get Data written DB to refresh screen

        lblLastDaily.Text = Now.ToString
        lblLastHourly.Text = Now.ToString
        lblLast30Min.Text = Now.ToString
        lblLast5min.Text = Now.ToString
        lblLast1min.Text = Now.ToString
        lblLast1sec.Text = Now.ToString

        'Initialize Thermostat
        'QueryThermostat()
        'strExpectedTargetTemp = strActualTargetTemp
        'VerifyTemp()

        'Read Parameters from XML
        Try
            xmlData.ReadXml("WDNetCheckerParameter.xml")
            If xmlData.Tables(0).Rows(0).ItemArray(0).ToString = "True" Then
                chkMute.Checked = True
            Else
                chkMute.Checked = False
            End If

        Catch ex As Exception
            'ignore
        End Try

        btnStop.Enabled = True
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        't1Sec is started by QueryThermostat
        't1Min.Start()
        Thread.Sleep(2000)
        t5Min.Start()
        Thread.Sleep(2000)
        tHourly.Interval = ((59 - Now.Minute) * 60000) + ((60 - Now.Second) * 1000)
        tHourly.Start()
        't30Min.Interval = ((59 - Now.Minute) * 60000) + ((60 - Now.Second) * 1000) + 5000
        't30Min.Start()


    End Sub

#Region "Checkers"
    Private Function GetInternetConnectStatus() As Integer
        Dim ICSSend As New Ping
        Dim ICSReply As PingReply
        Dim bTest1, bTest2, bTest3 As Boolean
        Dim bSecondary As Boolean = False

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        bTest1 = False
        bTest2 = False
        bTest3 = False

        Try
            Dim ipv4Addr As Net.IPAddress = Net.IPAddress.Parse("174.101.192.1")
            ICSReply = ICSSend.Send(ipv4Addr)   'Default Gateway
            If ICSReply.Status = IPStatus.Success Then
                bTest1 = True
            End If
            Thread.Sleep(250)

            Dim ipv4Addr2 As Net.IPAddress = Net.IPAddress.Parse("209.18.47.61")
            ICSReply = ICSSend.Send(ipv4Addr2)   'Primary DNS
            If ICSReply.Status = IPStatus.Success Then
                bTest2 = True
            End If
            Thread.Sleep(250)

            Dim ipv4Addr3 As Net.IPAddress = Net.IPAddress.Parse("209.18.47.62")
            ICSReply = ICSSend.Send(ipv4Addr3)     'Secondary DNS
            If ICSReply.Status = IPStatus.Success Then
                bTest3 = True
            End If

            If Not bTest1 And Not bTest2 And Not bTest3 Then     'If Neither is successful, try secondary
                bSecondary = True
                Dim webFeed1 As HttpWebRequest = WebRequest.Create("http://www.google.com")

                Try
                    If webFeed1.ToString.Length > 0 Then
                        bTest1 = True
                    Else
                        bTest1 = False
                    End If
                Catch ex2 As Exception
                    bTest1 = False
                End Try

                If bTest1 = False Then
                    Thread.Sleep(250)
                    Dim webFeed2 As HttpWebRequest = WebRequest.Create("http://www.amazon.com")

                    Try
                        If webFeed2.ToString.Length > 0 Then
                            bTest2 = True
                        Else
                            bTest2 = False
                        End If
                    Catch ex2 As Exception
                        bTest2 = False
                    End Try
                End If
            End If
        Catch ex As Exception
            'Do nothing
        End Try

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        If (bTest1 Or bTest2 Or bTest3) And Not bSecondary Then
            lblInternetLinkStatus.Text = "."
            Return 1
        ElseIf (bTest1 Or bTest2 Or bTest3) And bSecondary Then
            lblInternetLinkStatus.Text = "-"
            Return 1
        Else
            lblInternetLinkStatus.Text = "X"
            Event_HistoryTableAdapter.InsertQuery("9965")  'Error
            Return 0
        End If

    End Function

    Private Function GetBrineTankLevel() As Integer
        Dim Arduino As TcpClient
        Dim myNetworkStream As NetworkStream
        Dim myStreamReader As StreamReader
        Dim myStreamWriter As StreamWriter
        Dim iDone As Integer = 0

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        iBrineTankLevel = 0
        While (iBrineTankLevel = 0 And iDone <= 3)
            Arduino = New TcpClient
            Try
                Arduino.Connect("192.168.1.199", 8888)
            Catch ex As Exception
                Exit While
            End Try

            myNetworkStream = Arduino.GetStream()
            myNetworkStream.ReadTimeout = 800

            myStreamWriter = New StreamWriter(myNetworkStream)
            Try
                myStreamWriter.WriteLine(Chr(13))
                myStreamWriter.Flush()

                myStreamReader = New StreamReader(myNetworkStream)
                iBrineTankLevel = Int(myStreamReader.ReadLine())
            Catch ex As Exception
                Exit While
            End Try
            myStreamReader.Close()
            myStreamWriter.Close()
            Arduino.Close()
            iDone = iDone + 1
            Thread.Sleep(100 * iDone)
        End While

        If iBrineTankLevel > 0 Then
            lblBrineTankStatus.Text = "."
        Else
            lblBrineTankStatus.Text = "X"
            Event_HistoryTableAdapter.InsertQuery("9966")  'Error
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Return iBrineTankLevel

    End Function

    Private Function GetStairLightsStatus() As Integer
        If (Hour(Now) >= 19 Or Hour(Now) < 7) Then  ' On between 7pm and 7am
            Return 1
        Else
            Return 0
        End If

        'Dim Arduino As TcpClient
        'Dim myNetworkStream As NetworkStream
        'Dim myStreamReader As StreamReader
        'Dim myStreamWriter As StreamWriter
        'Dim iDone As Integer = 0
        'Dim bDone As Boolean
        'Dim iStairlights As Integer

        'System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        'iStairLights = 0
        'bDone = False
        'While (Not bDone And iDone <= 3)
        '    Arduino = New TcpClient
        '    Try
        '        Arduino.Connect("192.168.1.197", 8888)
        '    Catch ex As Exception
        '        Exit While
        '    End Try

        '    myNetworkStream = Arduino.GetStream()
        '    myNetworkStream.ReadTimeout = 800

        '    myStreamWriter = New StreamWriter(myNetworkStream)
        '    Try
        '        myStreamWriter.WriteLine(Chr(13))
        '        myStreamWriter.Flush()

        '        myStreamReader = New StreamReader(myNetworkStream)
        '        iStairLights = Int(myStreamReader.ReadLine())
        '        bDone = True
        '    Catch ex As Exception
        '        Exit While
        '    End Try
        '    myStreamReader.Close()
        '    myStreamWriter.Close()
        '    Arduino.Close()
        '    iDone = iDone + 1
        '    Thread.Sleep(100 * iDone)
        'End While

        'If bDone Then
        '    lblStairLightStatus.Text = "."
        'Else
        '    lblStairLightStatus.Text = "X"
        '    Event_HistoryTableAdapter.InsertQuery("9967")  'Error
        'End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        'Return iStairLights

    End Function

    'Private Sub GetLizardHabitatInfo()
    '    Dim Arduino As TcpClient
    '    Dim myNetworkStream As NetworkStream
    '    Dim myStreamReader As StreamReader
    '    Dim myStreamWriter As StreamWriter
    '    Dim iDone As Integer = 0
    '    Dim iLizardFedHolder As Integer

    '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

    '    iLizardHabitatTemp = 0
    '    iLizardFedHolder = 0

    '    While (iLizardHabitatTemp = 0 And iDone <= 3)
    '        Arduino = New TcpClient
    '        Try
    '            Arduino.Connect("192.168.1.198", 8888)
    '        Catch ex As Exception
    '            iDone = 4
    '            Exit While
    '        End Try

    '        myNetworkStream = Arduino.GetStream()
    '        myNetworkStream.ReadTimeout = 700

    '        myStreamWriter = New StreamWriter(myNetworkStream)
    '        Try
    '            myStreamWriter.WriteLine(Chr(13))
    '            myStreamWriter.Flush()

    '            myStreamReader = New StreamReader(myNetworkStream)
    '            iLizardHabitatTemp = Int(myStreamReader.ReadLine())
    '            iLizardFedHolder = Int(myStreamReader.ReadLine())
    '            myStreamReader.Close()
    '            myStreamWriter.Close()
    '            Arduino.Close()
    '        Catch ex As Exception
    '            iDone = 4
    '            Exit While
    '        End Try
    '        If iLizardHabitatTemp = 0 Then
    '            iDone = iDone + 1
    '            Thread.Sleep(100 * iDone)
    '        End If
    '    End While

    '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

    'End Sub

    Private Sub GetGreatRmTemp()
        Dim Arduino As TcpClient
        Dim myNetworkStream As NetworkStream
        Dim myStreamReader As StreamReader
        Dim myStreamWriter As StreamWriter
        Dim bError As Boolean = False
        Dim strResult As String

        Arduino = New TcpClient
        Try
            strResult = ""
            Arduino.Connect("192.168.1.196", 8888)
            myNetworkStream = Arduino.GetStream()
            myNetworkStream.ReadTimeout = 500

            myStreamWriter = New StreamWriter(myNetworkStream)
            myStreamWriter.Write(6)
            myStreamWriter.Flush()

            myStreamReader = New StreamReader(myNetworkStream)
            strResult = myStreamReader.ReadLine()
            myStreamReader.Close()
            myStreamWriter.Close()
            Arduino.Close()
            lblGreatRmTempStatus.Text = "."
            If strResult <> "" And Int(strResult) < 100 And Int(strResult) > 40 Then
                lblGreatRmTemp.Text = Math.Truncate(CType(strResult, Double))
            Else
                lblGreatRmTempStatus.Text = "X"
                Event_HistoryTableAdapter.InsertQuery("9969")  'Error
            End If
        Catch ex As Exception
            strResult = ""
            Arduino.Close()
            lblGreatRmTempStatus.Text = "X"
            Event_HistoryTableAdapter.InsertQuery("9969")  'Error
        End Try


    End Sub

    'Private Sub CheckSevereWeather()
    '    'NO LONGER SUPPORTED API
    '    Dim bSevereWeather As Boolean

    '    Try
    '        Dim request = New ForecastIORequest("95a75eee24600535ad7515bbad576c89", 39.367003, -84.475208, Unit.us)
    '        Dim response = request.Get()

    '        bSevereWeather = False
    '        lblSevereWeather.Text = "0"

    '        If response.alerts.Count > 0 Then
    '            For i = 0 To response.alerts.Count - 1
    '                Dim strAlertText As String = response.alerts.Item(i).title.ToUpper
    '                If strAlertText.IndexOf("TORNADO WARNING") > 0 Or strAlertText.IndexOf("SEVERE THUNDERSTORM WARNING") > 0 Then
    '                    lblSevereWeather.Text = "1"
    '                    bSevereWeather = True
    '                End If
    '            Next
    '        End If

    '    Catch ex As Exception
    '        lblSevereWeatherStatus.Text = "X"
    '        Exit Sub
    '    End Try

    '    If bSevereWeather And chkMute.Checked = False Then
    '        SpeakIt("Warning.  The weather is not looking too good.  You may want to move to the basement as soon as possible.")
    '        Event_HistoryTableAdapter.InsertQuery("5033")
    '    End If
    'End Sub

    Private Sub CheckSevereWeather2()
        Dim strHazzard, strData As String
        Dim iIndex As Integer = 0
        Dim iTempIndex As Integer = 0
        Dim bSevereWeather As Boolean

        Try
            Dim xmlData As New System.Net.WebClient
            xmlData.Headers(HttpRequestHeader.UserAgent) = "Greg/1.0"
            strData = xmlData.DownloadString("http://forecast.weather.gov/MapClick.php?lat=39.3665&lon=-84.4743&unit=0&lg=english&FcstType=dwml")

            bSevereWeather = False
            lblSevereWeather.Text = "0"

            While iIndex <> -1 And bSevereWeather = False
                iIndex = strData.IndexOf("<hazard headline=", iIndex)
                If iIndex <> -1 Then
                    iIndex = iIndex + 18
                    iTempIndex = strData.IndexOf(""">", iIndex)
                    strHazzard = ""
                    For i As Integer = iIndex To iTempIndex - 1
                        strHazzard = strHazzard & strData(i)
                    Next i
                    If strHazzard = "Severe Thunderstorm Warning" Or strHazzard = "Tornado Warning" Then
                        bSevereWeather = True
                        lblSevereWeather.Text = "1"
                    End If
                    iIndex = iTempIndex
                End If
            End While
            lblSevereWeatherStatus.Text = "."

        Catch ex As Exception
            lblSevereWeatherStatus.Text = "X"
            Exit Sub
        End Try

        If bSevereWeather And chkMute.Checked = False Then
            SpeakIt("Warning.  The weather is not looking too good.  You may want to move to the basement as soon as possible.")
            Event_HistoryTableAdapter.InsertQuery("5033")
        End If
    End Sub

    Private Sub CheckSevereWeather1()
        Dim strDescription As String
        Dim bSevereWeather As Boolean
        Dim xsltFile As String = "alerts.xsl"
        Dim myTransform As New XslCompiledTransform()
        Dim strAlerts As String = "alerts.txt"
        Dim xmlAlerts As DataSet = New DataSet()
        Dim i As Integer
        Dim rowAlert As Object()

        lblSevereWeather.Text = "0"
        Try
            myTransform.Load(xsltFile)
            myTransform.Transform("http://forecast.weather.gov/MapClick.php?lat=39.36324&lon=-84.46907&FcstType=dwml", strAlerts)
            'myTransform.Transform("http://forecast.weather.gov/MapClick.php?lat=41.88168&lon=-90.73720&FcstType=dwml", strAlerts)
            strDescription = ""
            bSevereWeather = False

            'Read File
            xmlAlerts.ReadXml(strAlerts)
            For i = 0 To xmlAlerts.Tables(0).Rows.Count - 1
                rowAlert = xmlAlerts.Tables(0).Rows(i).ItemArray
                If rowAlert.GetValue(0).ToString = "Severe Thunderstorm Warning" Or rowAlert.GetValue(0).ToString = "Tornado Warning" Then
                    bSevereWeather = True
                    lblSevereWeather.Text = "1"
                End If
            Next

            xmlAlerts = Nothing
            My.Computer.FileSystem.DeleteFile(strAlerts)
            lblSevereWeatherStatus.Text = "."

        Catch ex As Exception
            lblSevereWeatherStatus.Text = "X"
            Exit Sub
        End Try

        If bSevereWeather And chkMute.Checked = False Then
            SpeakIt("Warning.  The weather is not looking too good.  You may want to move to the basement as soon as possible.")
            Event_HistoryTableAdapter.InsertQuery("5033")
        End If

    End Sub


    Private Sub CheckFans()
        'Check MBR Temp
        'If Temp_Current_StateTableAdapter.GetMasterBRTemp() > MAXTEMP_SUMMER Then
        '    Insteon_ControlTableAdapter.Request_State_Change(1, "2A.39.F6") 'MBR Fan
        'End If

        ''Check Sydney Bedroom Temp
        'If Temp_Current_StateTableAdapter.GetSydneyBRTemp() > MAXTEMP_SUMMER Then
        '    Insteon_ControlTableAdapter.Request_State_Change(1, "2A.3D.80") 'Sydney BR Fan
        'End If

        ''Check Ethan Bedroom Temp
        'If Temp_Current_StateTableAdapter.GetEthanBRTemp() > MAXTEMP_SUMMER Then
        '    Insteon_ControlTableAdapter.Request_State_Change(1, "2A.3B.F0") 'Ethan BR Fan
        'End If


    End Sub

#End Region

#Region "Vents"
    Private Sub UpdateVents()
        'Dim dtNow As Date
        'Dim i As Integer

        'Me.Temp_Current_StateTableAdapter.Fill(Me.WatchdogDataSet.Temp_Current_State)
        'dtNow = Now()
        'If Hour(dtNow) >= 21 Or Hour(dtNow) <= 5 Then
        '    For i = 0 To 5
        '        'Set to closed at night - force air upstairs
        '        If iVentCurrentState(i) <> 0 Then
        '            ChangeVent(i, 0)
        '        Else
        '            lblVents(i).Text = "Closed"
        '            iVentCurrentState(i) = 0
        '        End If
        '    Next
        'Else
        '    If Int(GarageLabel1.Text) > SUMMER Then  'Summer
        '        lblSeason.Text = "Summer"
        '        For i = 0 To 5
        '            If Int(lblTempVal(i).Text) > MAXTEMP_SUMMER And iVentCurrentState(i) <> 2 Then
        '                ChangeVent(i, 2)
        '            ElseIf Int(lblTempVal(i).Text) < MINTEMP_SUMMER And iVentCurrentState(i) <> 0 Then
        '                ChangeVent(i, 0)
        '            ElseIf (Int(lblTempVal(i).Text) <= MAXTEMP_SUMMER And Int(lblTempVal(i).Text) >= MINTEMP_SUMMER) And iVentCurrentState(i) <> 1 Then
        '                ChangeVent(i, 1)
        '            End If
        '        Next

        '    ElseIf Int(GarageLabel1.Text) < WINTER Then   'Winter
        '        lblSeason.Text = "Winter"
        '        For i = 0 To 5
        '            If Int(lblTempVal(i).Text) > MAXTEMP_WINTER And iVentCurrentState(i) <> 0 Then
        '                ChangeVent(i, 0)
        '            ElseIf Int(lblTempVal(i).Text) < MINTEMP_WINTER And iVentCurrentState(i) <> 2 Then
        '                ChangeVent(i, 2)
        '            ElseIf (Int(lblTempVal(i).Text) <= MAXTEMP_WINTER And Int(lblTempVal(i).Text) >= MINTEMP_WINTER) And iVentCurrentState(i) <> 1 Then
        '                ChangeVent(i, 1)
        '            End If
        '        Next

        '    Else
        '        'Transition season, could be heat or AC;  Open all vents to half
        '        lblSeason.Text = "-"
        '        For i = 0 To 5
        '            If iVentCurrentState(i) <> 1 Then
        '                ChangeVent(i, 1)
        '            End If
        '        Next
        '    End If

        'End If

    End Sub

    Private Sub ChangeVent(ByRef iVentID As Integer, ByRef iVentState As Integer)
        Dim Arduino As TcpClient
        Dim myNetworkStream As NetworkStream = Nothing
        Dim myStreamReader As StreamReader
        Dim myStreamWriter As StreamWriter
        Dim bError As Boolean = False
        Dim iResult As Integer = 0

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If (iVentID >= 0 And iVentID <= 5) And (iVentState >= 0 And iVentState <= 2) Then
            Arduino = New TcpClient
            Try
                Arduino.Connect("192.168.1.196", 8888)
                myNetworkStream = Arduino.GetStream()
                myNetworkStream.ReadTimeout = 500

                myStreamWriter = New StreamWriter(myNetworkStream)
                myStreamWriter.Write(iVentID)
                myStreamWriter.Write(iVentState)
                myStreamWriter.Flush()

                myStreamReader = New StreamReader(myNetworkStream)
                iResult = Int(myStreamReader.ReadLine())
                myStreamReader.Close()
                myStreamWriter.Close()
                Arduino.Close()
            Catch ex As Exception
                iResult = 1
                Arduino.Close()
            End Try

            If iResult = 0 Or iResult = 3 Then  'Arduino completed the move, or thinks the vent is already in the requested state
                Select Case iVentState
                    Case 0 : lblVents(iVentID).Text = "Closed"
                    Case 1 : lblVents(iVentID).Text = "Half"
                    Case 2 : lblVents(iVentID).Text = "Open"
                End Select
                iVentCurrentState(iVentID) = iVentState

                If iResult = 0 Then
                    lblVentStatus(iVentID).Text = "."
                Else
                    lblVentStatus(iVentID).Text = "-"
                End If

                Vent_HistoryTableAdapter.InsertQuery("0" & iVentID.ToString, "0" & iVentState.ToString)
            Else
                lblVentStatus(iVentID).Text = "X"
                Event_HistoryTableAdapter.InsertQuery("9970")  'Error
            End If

            Thread.Sleep(2100)
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub
#End Region

    Public Sub SpeakIt(ByVal SpeakText As String)
        Dim SpeakIt As System.Diagnostics.Process = New System.Diagnostics.Process

        SpeakIt.StartInfo.UseShellExecute = False
        SpeakIt.StartInfo.CreateNoWindow = True
        SpeakIt.StartInfo.FileName = "WDPlay_Voice.exe"
        SpeakIt.StartInfo.Arguments = SpeakText
        Try
            SpeakIt.Start()
        Catch ex As Exception
        End Try
    End Sub


#Region "Buttons"
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Try
            'iBrineTankLevel = GetBrineTankLevel()
            Event_Current_StateTableAdapter.HourlyUpdate(80, GetInternetConnectStatus())
            'GetLizardHabitatInfo()
            CheckSevereWeather2()
            Event_Current_StateTableAdapter.FiveMinUpdate(0, 0, GetStairLightsStatus())
            Me.Event_Current_StateTableAdapter.Fill(Me.WatchdogDataSet.Event_Current_State)

            'GetGreatRmTemp()
            'If lblGreatRmTempStatus.Text <> "X" And lblGreatRmTemp.Text <> "00" And lblGreatRmTemp.Text <> "" Then
            'Temp_Current_StateTableAdapter.Update_GreatRmTemp(lblGreatRmTemp.Text)
            'End If

            UpdateVents()

            lblLastDaily.Text = Now.ToString
            lblLastHourly.Text = Now.ToString
            lblLast30Min.Text = Now.ToString
            lblLast5min.Text = Now.ToString
            lblLast1min.Text = Now.ToString
            lblLast1sec.Text = Now.ToString

            btnStop.Enabled = True

            't1Min.Start()
            Thread.Sleep(2000)
            t5Min.Start()
            tHourly.Interval = ((59 - Now.Minute) * 60000) + ((60 - Now.Second) * 1000)
            tHourly.Start()
            't30Min.Interval = ((59 - Now.Minute) * 60000) + ((60 - Now.Second) * 1000) + 5000
            't30Min.Start()

            btnStart.Enabled = False
            btnStop.Enabled = True
        Catch ex As Exception
            't1Min.Stop()
            t5Min.Stop()
            't30Min.Stop()
            tHourly.Stop()
            btnStart.Enabled = True
            btnStop.Enabled = False
        End Try
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        t1Min.Stop()
        t5Min.Stop()
        t30Min.Stop()
        tHourly.Stop()
        btnStop.Enabled = False
        btnStart.Enabled = True
    End Sub

#End Region

#Region "Timers"
    Private Sub tHourly_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tHourly.Tick
        Try
            tHourly.Interval = 3600000

            If Hour(Now) = 1 Then  'only update once daily at 1AM
                Insteon_ControlTableAdapter.Request_State_Change(0, "33.67.22") 'FD Coach Light off
                Event_HistoryTableAdapter.InsertQuery("5036")  'Insteon State Change Requested
                Thread.Sleep(100)
                Insteon_ControlTableAdapter.Request_State_Change(0, "17.A6.A9") 'GD Coach Light off
                Event_HistoryTableAdapter.InsertQuery("5036")  'Insteon State Change Requested
                Thread.Sleep(100)
                Insteon_ControlTableAdapter.Request_State_Change(0, "23.DB.10")  'Kids Bathroom
                Event_HistoryTableAdapter.InsertQuery("5036")  'Insteon State Change Requested
            End If

            If Hour(Now) = 10 Then  'only update once daily at 10AM
                Insteon_ControlTableAdapter.Request_State_Change(0, "23.C5.30")  'Sydney's Bedroom
                Event_HistoryTableAdapter.InsertQuery("5036")  'Insteon State Change Requested
                Thread.Sleep(100)
                Insteon_ControlTableAdapter.Request_State_Change(0, "23.B6.EB")  'Ethan's Bedroom
                Event_HistoryTableAdapter.InsertQuery("5036")  'Insteon State Change Requested
                Thread.Sleep(100)
                Insteon_ControlTableAdapter.Request_State_Change(0, "29.2A.B9")  'Kids Hallway
                Event_HistoryTableAdapter.InsertQuery("5036")  'Insteon State Change Requested
                Thread.Sleep(100)
                Insteon_ControlTableAdapter.Request_State_Change(0, "23.DB.10")  'Kids Bathroom
                Event_HistoryTableAdapter.InsertQuery("5036")  'Insteon State Change Requested
            End If

            'Dim TransitionMonths() As Integer = {4, 5, 9, 10}
            'Dim CheckTime() As Integer = {6, 9, 12, 15, 18, 21}
            'If CheckTime.Contains(Hour(Now)) And TransitionMonths.Contains(Month(Now)) Then
            ' 3 Or Month(Now) = 4, Or Month(Now) = 5, Or Month(Now) = 9, Or Month(Now) = 10, Or Month(Now) = 11) Then
            'If Temp_Current_StateTableAdapter.GetMasterBRTemp() > MAXTEMP_SUMMER And lblTempMode.Text = "HEAT" Then  'Adjust Heat/Cool 
            'Temp_ControlTableAdapter.Request_Temp_Change("C", "+", 0)
            'Event_HistoryTableAdapter.InsertQuery("5027")
            'End If
            'If Temp_Current_StateTableAdapter.GetGarageTemp() < MINTEMP_WINTER And lblTempMode.Text = "COOL" Then
            'Temp_ControlTableAdapter.Request_Temp_Change("H", "+", 0)
            'Event_HistoryTableAdapter.InsertQuery("5027")
            'End If
            'End If

            'If Hour(Now) = 10 Or Hour(Now) = 14 Then  'only update once daily at 10AM and 2PM
            'CheckFans()
            'End If

            If Hour(Now) = 17 Then  'only update once daily at 5PM
                Insteon_ControlTableAdapter.Request_State_Change(1, "29.2A.B9")  'Kids Hallway
                Event_HistoryTableAdapter.InsertQuery("5036")  'Insteon State Change Requested
            End If

            If Hour(Now) = 21 Then  'only update once daily at 9PM
                'iBrineTankLevel = GetBrineTankLevel()
                lblLastDaily.Text = Now.ToString
            End If

            If Hour(Now) = 23 Then  'only update once daily at 11PM
                'Insteon_ControlTableAdapter.Request_State_Change(30, "23.B6.EB")  'Ethan's Bedroom
                'Event_HistoryTableAdapter.InsertQuery("5036")  'Insteon State Change Requested
                'Insteon_ControlTableAdapter.Request_State_Change(0, "23.DB.10")  'Kids Bathroom
                'Event_HistoryTableAdapter.InsertQuery("5036")  'Insteon State Change Requested
            End If

            Event_Current_StateTableAdapter.HourlyUpdate(80, GetInternetConnectStatus())
            Me.Event_Current_StateTableAdapter.Fill(Me.WatchdogDataSet.Event_Current_State)
            CheckSevereWeather2()

            lblLastHourly.Text = Now.ToString
        Catch ex As Exception
        End Try

    End Sub

    Private Sub t30Min_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t30Min.Tick
        Try
            t30Min.Interval = 1800000
            'GetGreatRmTemp()  -- Done in t5Min_Tick two seconds earlier
            'If lblGreatRmTempStatus.Text <> "X" And lblGreatRmTemp.Text <> "00" And lblGreatRmTemp.Text <> "" Then
            'Temp_Current_StateTableAdapter.Update_GreatRmTemp(lblGreatRmTemp.Text)
            'End If
            'UpdateVents()

            lblLast30Min.Text = Now.ToString

        Catch ex As Exception
        End Try
    End Sub

    Private Sub t5Min_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t5Min.Tick
        Dim iStairLight As Integer
        Try
            'GetLizardHabitatInfo()
            iStairLight = GetStairLightsStatus()

            Event_Current_StateTableAdapter.FiveMinUpdate(0, 0, iStairLight)
            Me.Event_Current_StateTableAdapter.Fill(Me.WatchdogDataSet.Event_Current_State)

            'GetGreatRmTemp()  'Refresh, but do not write to Database

            lblLast5min.Text = Now.ToString
        Catch ex As Exception
        End Try

    End Sub

    Private Sub t1Min_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1Min.Tick

        'QueryThermostat()
        'Thread.Sleep(500)
        'VerifyTemp()

        lblLast1min.Text = Now.ToString

    End Sub

    Private Sub tRefreshTemp_Tick(sender As Object, e As EventArgs) Handles tRefreshTemp.Tick
        'Runs every 5 seconds

        'Dim strMode, strDirection As String
        'Dim iDegrees As Integer
        'Dim i As Integer

        'Try
        'Dim tNewRequests As WatchdogDataSet.Temp_ControlDataTable
        'tNewRequests = Temp_ControlTableAdapter.GetData

        'If tNewRequests.Rows.Count > 0 Then
        'For i = 0 To tNewRequests.Rows.Count - 1
        'oTempLastRowID = tNewRequests.Rows(i).Item(0)
        'strMode = tNewRequests.Rows(i).Item(1)
        'strDirection = tNewRequests.Rows(i).Item(2)
        'iDegrees = tNewRequests.Rows(i).Item(3)

        'QueryThermostat()
        'Thread.Sleep(250)
        'SetTemp(strMode, strDirection, iDegrees)
        'Thread.Sleep(500)
        'QueryThermostat()
        'Thread.Sleep(250)
        'VerifyTemp()
        'Next
        'End If
        'Catch ex As Exception
        'tRefreshTemp.Stop()
        'lblThermostatStatus.Text = "X"
        'Event_HistoryTableAdapter.InsertQuery("9905")  'Error
        'End Try
    End Sub

#End Region

#Region "Thermostat"

    Private Sub QueryThermostat()
        Dim Thermostat As HttpWebRequest
        Dim i As Integer
        Dim strRead, strCurrentTemp, strTargetTemp, strMode As String

        tRefreshTemp.Stop()
        Try
            Thermostat = WebRequest.Create("http://192.168.1.201/tstat")
            Thermostat.Timeout = 10000
            Thermostat.Method = "GET"
            Dim httpResponse As HttpWebResponse = Thermostat.GetResponse

            Dim receiveStream As Stream = httpResponse.GetResponseStream()
            Dim encode As Encoding = System.Text.Encoding.GetEncoding("utf-8")
            Dim readStream As New StreamReader(receiveStream, encode)
            Dim read(300) As [Char]
            readStream.Read(read, 0, 300)
            receiveStream.Close()
            readStream.Close()
            Thermostat = Nothing
            httpResponse = Nothing

            strRead = ""
            For i = 1 To read.Length - 1
                strRead = strRead & read(i)
            Next

            strCurrentTemp = ""

            'Get Curent Temperature
            i = strRead.LastIndexOf("""temp"":")
            If i = -1 Then
                Throw New ArgumentException("Exception Occured")
            Else
                i = i + 8
            End If
            While (read(i) <> ",")
                If (read(i) >= "0" And read(i) <= "9") Or read(i) = "." Then
                    strCurrentTemp = strCurrentTemp & read(i).ToString
                End If
                i = i + 1
            End While
            lblCurrentTemp.Text = strCurrentTemp


            'Get Temperature Mode
            i = strRead.LastIndexOf("""tmode"":")
            If i = -1 Then
                Throw New ArgumentException("Exception Occured")
            Else
                i = i + 9
            End If
            strMode = read(i).ToString

            Select Case strMode
                Case "0"
                    lblTempMode.Text = "OFF"
                Case "1"
                    lblTempMode.Text = "HEAT"
                Case "2"
                    lblTempMode.Text = "COOL"
                Case "3"
                    lblTempMode.Text = "AUTO"
                Case Else
                    lblTempMode.Text = ""
                    Throw New ArgumentException("Exception Occured")
            End Select

            'Get Target Temperature
            strTargetTemp = ""
            If strRead.Contains("""t_heat"":") Then
                i = strRead.LastIndexOf("""t_heat"":")
                If i = -1 Then
                    Throw New ArgumentException("Exception Occured")
                Else
                    i = i + 10
                End If
                While (read(i) <> ",")
                    If (read(i) >= "0" And read(i) <= "9") Or read(i) = "." Then
                        strTargetTemp = strTargetTemp & read(i).ToString
                    End If
                    i = i + 1
                End While
            ElseIf strRead.Contains("""t_cool"":") Then
                i = strRead.LastIndexOf("""t_cool"":")
                If i = -1 Then
                    Throw New ArgumentException("Exception Occured")
                Else
                    i = i + 10
                End If
                While (read(i) <> ",")
                    If (read(i) >= "0" And read(i) <= "9") Or read(i) = "." Then
                        strTargetTemp = strTargetTemp & read(i).ToString
                    End If
                    i = i + 1
                End While
            Else
                Throw New ArgumentException("Exception Occured")
            End If
            lblTargetTemp.Text = CStr(CInt(strTargetTemp))
            strActualTargetTemp = CStr(CInt(strTargetTemp))
            lblThermostatStatus.Text = "."
            Thread.Sleep(100)

        Catch ex As Exception
            lblCurrentTemp.Text = "00"
            lblTargetTemp.Text = "00"
            strActualTargetTemp = "00"
            lblTempMode.Text = "_"
            lblThermostatStatus.Text = "X"
            Event_HistoryTableAdapter.InsertQuery("9974")  'Error
        End Try
        tRefreshTemp.Start()

    End Sub

    Private Function SetTemp(strMode As String, strDirection As String, iDegrees As Integer) As Boolean
        Dim Thermostat As WebClient = New WebClient
        Dim strResult, strParam As String
        Dim iNewTarget As Integer

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            If CInt(strActualTargetTemp) = 0 Then
                Return False
            Else
                If strMode = "H" Then
                    strParam = "{""tmode"":1,""hold"": 1,""t_heat"":"
                ElseIf strMode = "C" Then
                    strParam = "{""tmode"":2,""hold"": 1,""t_cool"":"
                Else
                    Throw New ArgumentException("Exception Occured")
                End If
                strTempLastMode = strMode

                iNewTarget = Int(lblTargetTemp.Text)
                If strDirection = "+" Then
                    iNewTarget = iNewTarget + iDegrees
                Else
                    iNewTarget = iNewTarget - iDegrees
                End If

                strExpectedTargetTemp = iNewTarget.ToString
                strParam = strParam & iNewTarget.ToString & "}"

                strResult = Thermostat.UploadString("http://192.168.1.201/tstat/", "POST", strParam)

                Me.Cursor = System.Windows.Forms.Cursors.Default
                If strResult.Substring(0, 9) = "{""success" Then
                    Temp_ControlTableAdapter.Delete_Temp_Change_Request(oTempLastRowID)
                    Thermostat_HistoryTableAdapter.InsertQuery(strDirection, iDegrees, strMode, iNewTarget)
                    Event_HistoryTableAdapter.InsertQuery("5028")  'Temp Change Verified
                    oTempLastRowID = Nothing
                    lblThermostatStatus.Text = "."
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            lblThermostatStatus.Text = "-"
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return False
        End Try

    End Function

    Private Function SetTemp2(strMode As String, iDegrees As Integer) As Boolean
        Dim Thermostat As WebClient = New WebClient
        Dim strResult, strParam As String
        Dim iNewTarget As Integer

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            If CInt(strActualTargetTemp) = 0 Then
                lblThermostatStatus.Text = "-"
                Return False
            Else
                If strMode = "H" Then
                    strParam = "{""tmode"":1,""hold"": 1,""t_heat"":"
                ElseIf strMode = "C" Then
                    strParam = "{""tmode"":2,""hold"": 1,""t_cool"":"
                Else
                    Throw New ArgumentException("Exception Occured")
                End If

                iNewTarget = iDegrees
                strParam = strParam & iNewTarget.ToString & "}"

                strResult = Thermostat.UploadString("http://192.168.1.201/tstat/", "POST", strParam)

                Me.Cursor = System.Windows.Forms.Cursors.Default
                If strResult.Substring(0, 9) = "{""success" Then
                    Temp_ControlTableAdapter.Delete_Temp_Change_Request(oTempLastRowID)
                    Thermostat_HistoryTableAdapter.InsertQuery2(strMode, iNewTarget)
                    Event_HistoryTableAdapter.InsertQuery("5028")  'Temp Change Verified
                    oTempLastRowID = Nothing
                    lblThermostatStatus.Text = "."
                    Return True
                    Thread.Sleep(100)
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            lblThermostatStatus.Text = "-"
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return False
        End Try

    End Function

    Private Sub VerifyTemp()
        Dim i As Integer


        Try
            QueryThermostat()
            i = 0
            While strActualTargetTemp = "00"
                QueryThermostat()
                If strActualTargetTemp = "00" Then
                    i = i + 1
                    Thread.Sleep(500)
                Else
                    Exit While
                End If
                If i = 5 Then
                    'Try 5 times, then give up and wait until next refresh
                    lblThermostatStatus.Text = "-"
                    Event_HistoryTableAdapter.InsertQuery("5029")   'Temp Change Retry
                    Exit While
                End If
            End While

            i = 0
            While strExpectedTargetTemp <> strActualTargetTemp And strActualTargetTemp <> "00"
                'If the actual target does not equal the expected target, then make a change
                If CInt(strExpectedTargetTemp) = 0 Or CInt(strActualTargetTemp) = 0 Then
                    Throw New ArgumentException("Exception Occured")
                End If
                'Event_HistoryTableAdapter.InsertQuery("5029")  'Thermostat Change Retry

                If SetTemp2(strTempLastMode, CInt(strExpectedTargetTemp)) Then
                    QueryThermostat()   'Get update after change
                    If strExpectedTargetTemp = strActualTargetTemp Then
                        lblThermostatStatus.Text = "."
                        Exit While
                    End If
                Else
                    i = i + 1
                    Thread.Sleep(5000)
                End If

                If i = 5 Then
                    'Try 5 times, then give up and wait until next refresh
                    Event_HistoryTableAdapter.InsertQuery("5029")   'Temp Change Retry
                    Exit While
                End If

            End While
        Catch ex As Exception
            Thread.Sleep(500)
            lblThermostatStatus.Text = "-"
        End Try

    End Sub

#End Region


End Class

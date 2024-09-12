<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNetChecker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim Internet_LinkLabel As System.Windows.Forms.Label
        Dim Stair_LightsLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label31 As System.Windows.Forms.Label
        Dim Label33 As System.Windows.Forms.Label
        Dim Label34 As System.Windows.Forms.Label
        Dim Label44 As System.Windows.Forms.Label
        Dim Label35 As System.Windows.Forms.Label
        Dim Label36 As System.Windows.Forms.Label
        Dim Label37 As System.Windows.Forms.Label
        Dim Label38 As System.Windows.Forms.Label
        Dim Label41 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNetChecker))
        Me.lblTempMode = New System.Windows.Forms.Label()
        Me.tHourly = New System.Windows.Forms.Timer(Me.components)
        Me.Event_HistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Event_HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WatchdogDataSet = New WDNetChecker3.WatchdogDataSet()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblLastHourly = New System.Windows.Forms.Label()
        Me.t5Min = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSevereWeather = New System.Windows.Forms.Label()
        Me.lblSevereWeatherStatus = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblGreatRmTemp = New System.Windows.Forms.Label()
        Me.lblGreatRmTempStatus = New System.Windows.Forms.Label()
        Me.lblInternetLinkStatus = New System.Windows.Forms.Label()
        Me.Internet_LinkLabel1 = New System.Windows.Forms.Label()
        Me.Event_Current_StateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblStairLightStatus = New System.Windows.Forms.Label()
        Me.Stair_LightsLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblSeason = New System.Windows.Forms.Label()
        Me.KitchenLabel2 = New System.Windows.Forms.Label()
        Me.Temp_Current_StateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KitchenLabel1 = New System.Windows.Forms.Label()
        Me.lblKitchenSVent = New System.Windows.Forms.Label()
        Me.lblKitchenNVent = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblKitchenSStatus = New System.Windows.Forms.Label()
        Me.lblKitchenNStatus = New System.Windows.Forms.Label()
        Me.lblGreatRoomSVent = New System.Windows.Forms.Label()
        Me.lblGreatRoomNVent = New System.Windows.Forms.Label()
        Me.lblLivingRoomVent = New System.Windows.Forms.Label()
        Me.lblPlayRoomVent = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GreatRmLabel2 = New System.Windows.Forms.Label()
        Me.GreatRmLabel1 = New System.Windows.Forms.Label()
        Me.GarageLabel1 = New System.Windows.Forms.Label()
        Me.Play_RoomLabel1 = New System.Windows.Forms.Label()
        Me.Living_RoomLabel1 = New System.Windows.Forms.Label()
        Me.lblGreatRoomSStatus = New System.Windows.Forms.Label()
        Me.lblGreatRoomNStatus = New System.Windows.Forms.Label()
        Me.lblLivingRoomVentStatus = New System.Windows.Forms.Label()
        Me.lblPlayRoomVentStatus = New System.Windows.Forms.Label()
        Me.Vent_HistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vent_HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblLast5min = New System.Windows.Forms.Label()
        Me.lblLast30Min = New System.Windows.Forms.Label()
        Me.t30Min = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblThermostatStatus = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblTargetTemp = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lblCurrentTemp = New System.Windows.Forms.Label()
        Me.lblLast1min = New System.Windows.Forms.Label()
        Me.t1Min = New System.Windows.Forms.Timer(Me.components)
        Me.chkMute = New System.Windows.Forms.CheckBox()
        Me.lblLastDaily = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblBrineTankStatus = New System.Windows.Forms.Label()
        Me.Brine_TankLabel1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tRefreshTemp = New System.Windows.Forms.Timer(Me.components)
        Me.Temp_ControlDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Temp_ControlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Insteon_ControlDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Insteon_ControlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Thermostat_HistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thermostat_HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblLast1sec = New System.Windows.Forms.Label()
        Me.Call_CurrentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_Current_StateTableAdapter = New WDNetChecker3.WatchdogDataSetTableAdapters.Event_Current_StateTableAdapter()
        Me.TableAdapterManager = New WDNetChecker3.WatchdogDataSetTableAdapters.TableAdapterManager()
        Me.Event_HistoryTableAdapter = New WDNetChecker3.WatchdogDataSetTableAdapters.Event_HistoryTableAdapter()
        Me.Temp_Current_StateTableAdapter = New WDNetChecker3.WatchdogDataSetTableAdapters.Temp_Current_StateTableAdapter()
        Me.Vent_HistoryTableAdapter = New WDNetChecker3.WatchdogDataSetTableAdapters.Vent_HistoryTableAdapter()
        Me.Temp_ControlTableAdapter = New WDNetChecker3.WatchdogDataSetTableAdapters.Temp_ControlTableAdapter()
        Me.Insteon_ControlTableAdapter = New WDNetChecker3.WatchdogDataSetTableAdapters.Insteon_ControlTableAdapter()
        Me.Thermostat_HistoryTableAdapter = New WDNetChecker3.WatchdogDataSetTableAdapters.Thermostat_HistoryTableAdapter()
        Me.Call_CurrentTableAdapter = New WDNetChecker3.WatchdogDataSetTableAdapters.Call_CurrentTableAdapter()
        Label1 = New System.Windows.Forms.Label()
        Internet_LinkLabel = New System.Windows.Forms.Label()
        Stair_LightsLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label31 = New System.Windows.Forms.Label()
        Label33 = New System.Windows.Forms.Label()
        Label34 = New System.Windows.Forms.Label()
        Label44 = New System.Windows.Forms.Label()
        Label35 = New System.Windows.Forms.Label()
        Label36 = New System.Windows.Forms.Label()
        Label37 = New System.Windows.Forms.Label()
        Label38 = New System.Windows.Forms.Label()
        Label41 = New System.Windows.Forms.Label()
        CType(Me.Event_HistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WatchdogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Event_Current_StateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Temp_Current_StateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vent_HistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vent_HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Temp_ControlDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Temp_ControlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Insteon_ControlDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Insteon_ControlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Thermostat_HistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Thermostat_HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_CurrentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(255, 225)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 9)
        Label1.TabIndex = 11
        Label1.Text = "Last Hourly:"
        '
        'Internet_LinkLabel
        '
        Internet_LinkLabel.AutoSize = True
        Internet_LinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Internet_LinkLabel.Location = New System.Drawing.Point(6, 16)
        Internet_LinkLabel.Name = "Internet_LinkLabel"
        Internet_LinkLabel.Size = New System.Drawing.Size(59, 12)
        Internet_LinkLabel.TabIndex = 9
        Internet_LinkLabel.Text = "Internet Link:"
        '
        'Stair_LightsLabel
        '
        Stair_LightsLabel.AutoSize = True
        Stair_LightsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Stair_LightsLabel.Location = New System.Drawing.Point(6, 16)
        Stair_LightsLabel.Name = "Stair_LightsLabel"
        Stair_LightsLabel.Size = New System.Drawing.Size(54, 12)
        Stair_LightsLabel.TabIndex = 15
        Stair_LightsLabel.Text = "Stair Lights:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(6, 49)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(67, 12)
        Label5.TabIndex = 18
        Label5.Text = "Great Room N:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(6, 32)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(60, 12)
        Label7.TabIndex = 17
        Label7.Text = "Living Room:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(6, 16)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(53, 12)
        Label9.TabIndex = 15
        Label9.Text = "Play Room:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(6, 65)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(66, 12)
        Label12.TabIndex = 24
        Label12.Text = "Great Room S:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(6, 121)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(40, 12)
        Label6.TabIndex = 27
        Label6.Text = "Outside:"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label19.Location = New System.Drawing.Point(6, 98)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(47, 12)
        Label19.TabIndex = 43
        Label19.Text = "Kitchen S:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label21.Location = New System.Drawing.Point(6, 82)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(48, 12)
        Label21.TabIndex = 41
        Label21.Text = "Kitchen N:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(255, 238)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(55, 9)
        Label3.TabIndex = 18
        Label3.Text = "Last 30min:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(6, 33)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(73, 12)
        Label2.TabIndex = 13
        Label2.Text = "Great Rm Temp:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label18.Location = New System.Drawing.Point(255, 251)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(50, 9)
        Label18.TabIndex = 20
        Label18.Text = "Last 5min:"
        '
        'Label31
        '
        Label31.AutoSize = True
        Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label31.Location = New System.Drawing.Point(255, 264)
        Label31.Name = "Label31"
        Label31.Size = New System.Drawing.Size(50, 9)
        Label31.TabIndex = 24
        Label31.Text = "Last 1min:"
        '
        'Label33
        '
        Label33.AutoSize = True
        Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label33.Location = New System.Drawing.Point(6, 51)
        Label33.Name = "Label33"
        Label33.Size = New System.Drawing.Size(75, 12)
        Label33.TabIndex = 39
        Label33.Text = "Severe Weather:"
        '
        'Label34
        '
        Label34.AutoSize = True
        Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label34.Location = New System.Drawing.Point(255, 212)
        Label34.Name = "Label34"
        Label34.Size = New System.Drawing.Size(52, 9)
        Label34.TabIndex = 26
        Label34.Text = "Last Daily:"
        '
        'Label44
        '
        Label44.AutoSize = True
        Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label44.Location = New System.Drawing.Point(6, 14)
        Label44.Name = "Label44"
        Label44.Size = New System.Drawing.Size(61, 12)
        Label44.TabIndex = 7
        Label44.Text = "Brine Tank %:"
        '
        'Label35
        '
        Label35.AutoSize = True
        Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label35.Location = New System.Drawing.Point(6, 20)
        Label35.Name = "Label35"
        Label35.Size = New System.Drawing.Size(62, 12)
        Label35.TabIndex = 73
        Label35.Text = "Thermostat"
        '
        'Label36
        '
        Label36.AutoSize = True
        Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label36.Location = New System.Drawing.Point(93, 20)
        Label36.Name = "Label36"
        Label36.Size = New System.Drawing.Size(31, 12)
        Label36.TabIndex = 74
        Label36.Text = "Temp:"
        '
        'Label37
        '
        Label37.AutoSize = True
        Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label37.Location = New System.Drawing.Point(183, 20)
        Label37.Name = "Label37"
        Label37.Size = New System.Drawing.Size(59, 12)
        Label37.TabIndex = 75
        Label37.Text = "Target Temp:"
        '
        'Label38
        '
        Label38.AutoSize = True
        Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label38.Location = New System.Drawing.Point(299, 20)
        Label38.Name = "Label38"
        Label38.Size = New System.Drawing.Size(32, 12)
        Label38.TabIndex = 80
        Label38.Text = "Mode:"
        '
        'Label41
        '
        Label41.AutoSize = True
        Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label41.Location = New System.Drawing.Point(255, 277)
        Label41.Name = "Label41"
        Label41.Size = New System.Drawing.Size(49, 9)
        Label41.TabIndex = 29
        Label41.Text = "Last 1sec:"
        '
        'lblTempMode
        '
        Me.lblTempMode.AutoSize = True
        Me.lblTempMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempMode.Location = New System.Drawing.Point(335, 20)
        Me.lblTempMode.Name = "lblTempMode"
        Me.lblTempMode.Size = New System.Drawing.Size(10, 12)
        Me.lblTempMode.TabIndex = 81
        Me.lblTempMode.Text = "_"
        '
        'tHourly
        '
        Me.tHourly.Interval = 3600000
        '
        'Event_HistoryDataGridView
        '
        Me.Event_HistoryDataGridView.AutoGenerateColumns = False
        Me.Event_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_HistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Event_HistoryDataGridView.DataSource = Me.Event_HistoryBindingSource
        Me.Event_HistoryDataGridView.Location = New System.Drawing.Point(372, 194)
        Me.Event_HistoryDataGridView.Name = "Event_HistoryDataGridView"
        Me.Event_HistoryDataGridView.Size = New System.Drawing.Size(16, 11)
        Me.Event_HistoryDataGridView.TabIndex = 8
        Me.Event_HistoryDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Event_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Event_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Event_HistoryBindingSource
        '
        Me.Event_HistoryBindingSource.DataMember = "Event_History"
        Me.Event_HistoryBindingSource.DataSource = Me.WatchdogDataSet
        '
        'WatchdogDataSet
        '
        Me.WatchdogDataSet.DataSetName = "WatchdogDataSet"
        Me.WatchdogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(12, 262)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(71, 22)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(89, 262)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(70, 22)
        Me.btnStop.TabIndex = 10
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblLastHourly
        '
        Me.lblLastHourly.AutoSize = True
        Me.lblLastHourly.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastHourly.Location = New System.Drawing.Point(314, 225)
        Me.lblLastHourly.Name = "lblLastHourly"
        Me.lblLastHourly.Size = New System.Drawing.Size(75, 9)
        Me.lblLastHourly.TabIndex = 12
        Me.lblLastHourly.Text = "01/01/2011 12:00 PM"
        '
        't5Min
        '
        Me.t5Min.Interval = 300000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSevereWeather)
        Me.GroupBox1.Controls.Add(Me.lblSevereWeatherStatus)
        Me.GroupBox1.Controls.Add(Label33)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lblGreatRmTemp)
        Me.GroupBox1.Controls.Add(Me.lblGreatRmTempStatus)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.lblInternetLinkStatus)
        Me.GroupBox1.Controls.Add(Internet_LinkLabel)
        Me.GroupBox1.Controls.Add(Me.Internet_LinkLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 71)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hourly"
        '
        'lblSevereWeather
        '
        Me.lblSevereWeather.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSevereWeather.Location = New System.Drawing.Point(102, 52)
        Me.lblSevereWeather.Name = "lblSevereWeather"
        Me.lblSevereWeather.Size = New System.Drawing.Size(29, 13)
        Me.lblSevereWeather.TabIndex = 41
        Me.lblSevereWeather.Text = "1"
        Me.lblSevereWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSevereWeatherStatus
        '
        Me.lblSevereWeatherStatus.AutoSize = True
        Me.lblSevereWeatherStatus.Location = New System.Drawing.Point(146, 51)
        Me.lblSevereWeatherStatus.Name = "lblSevereWeatherStatus"
        Me.lblSevereWeatherStatus.Size = New System.Drawing.Size(9, 12)
        Me.lblSevereWeatherStatus.TabIndex = 40
        Me.lblSevereWeatherStatus.Text = "!"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(118, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 12)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "F"
        '
        'lblGreatRmTemp
        '
        Me.lblGreatRmTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreatRmTemp.Location = New System.Drawing.Point(97, 32)
        Me.lblGreatRmTemp.Name = "lblGreatRmTemp"
        Me.lblGreatRmTemp.Size = New System.Drawing.Size(23, 15)
        Me.lblGreatRmTemp.TabIndex = 15
        Me.lblGreatRmTemp.Text = "00"
        Me.lblGreatRmTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGreatRmTempStatus
        '
        Me.lblGreatRmTempStatus.AutoSize = True
        Me.lblGreatRmTempStatus.Location = New System.Drawing.Point(146, 33)
        Me.lblGreatRmTempStatus.Name = "lblGreatRmTempStatus"
        Me.lblGreatRmTempStatus.Size = New System.Drawing.Size(9, 12)
        Me.lblGreatRmTempStatus.TabIndex = 14
        Me.lblGreatRmTempStatus.Text = "!"
        '
        'lblInternetLinkStatus
        '
        Me.lblInternetLinkStatus.AutoSize = True
        Me.lblInternetLinkStatus.Location = New System.Drawing.Point(146, 16)
        Me.lblInternetLinkStatus.Name = "lblInternetLinkStatus"
        Me.lblInternetLinkStatus.Size = New System.Drawing.Size(9, 12)
        Me.lblInternetLinkStatus.TabIndex = 12
        Me.lblInternetLinkStatus.Text = "!"
        '
        'Internet_LinkLabel1
        '
        Me.Internet_LinkLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_Current_StateBindingSource, "Internet_Link", True))
        Me.Internet_LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Internet_LinkLabel1.Location = New System.Drawing.Point(102, 16)
        Me.Internet_LinkLabel1.Name = "Internet_LinkLabel1"
        Me.Internet_LinkLabel1.Size = New System.Drawing.Size(29, 13)
        Me.Internet_LinkLabel1.TabIndex = 10
        Me.Internet_LinkLabel1.Text = "1"
        Me.Internet_LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Event_Current_StateBindingSource
        '
        Me.Event_Current_StateBindingSource.DataMember = "Event_Current_State"
        Me.Event_Current_StateBindingSource.DataSource = Me.WatchdogDataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblStairLightStatus)
        Me.GroupBox2.Controls.Add(Stair_LightsLabel)
        Me.GroupBox2.Controls.Add(Me.Stair_LightsLabel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 68)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "5 Minutes"
        '
        'lblStairLightStatus
        '
        Me.lblStairLightStatus.AutoSize = True
        Me.lblStairLightStatus.Location = New System.Drawing.Point(146, 16)
        Me.lblStairLightStatus.Name = "lblStairLightStatus"
        Me.lblStairLightStatus.Size = New System.Drawing.Size(9, 12)
        Me.lblStairLightStatus.TabIndex = 21
        Me.lblStairLightStatus.Text = "!"
        '
        'Stair_LightsLabel1
        '
        Me.Stair_LightsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_Current_StateBindingSource, "Stair_Lights", True))
        Me.Stair_LightsLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stair_LightsLabel1.Location = New System.Drawing.Point(102, 16)
        Me.Stair_LightsLabel1.Name = "Stair_LightsLabel1"
        Me.Stair_LightsLabel1.Size = New System.Drawing.Size(29, 12)
        Me.Stair_LightsLabel1.TabIndex = 16
        Me.Stair_LightsLabel1.Text = "1"
        Me.Stair_LightsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblSeason)
        Me.GroupBox3.Controls.Add(Me.KitchenLabel2)
        Me.GroupBox3.Controls.Add(Me.KitchenLabel1)
        Me.GroupBox3.Controls.Add(Me.lblKitchenSVent)
        Me.GroupBox3.Controls.Add(Me.lblKitchenNVent)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lblKitchenSStatus)
        Me.GroupBox3.Controls.Add(Label19)
        Me.GroupBox3.Controls.Add(Me.lblKitchenNStatus)
        Me.GroupBox3.Controls.Add(Label21)
        Me.GroupBox3.Controls.Add(Me.lblGreatRoomSVent)
        Me.GroupBox3.Controls.Add(Me.lblGreatRoomNVent)
        Me.GroupBox3.Controls.Add(Me.lblLivingRoomVent)
        Me.GroupBox3.Controls.Add(Me.lblPlayRoomVent)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.GreatRmLabel2)
        Me.GroupBox3.Controls.Add(Me.GreatRmLabel1)
        Me.GroupBox3.Controls.Add(Me.GarageLabel1)
        Me.GroupBox3.Controls.Add(Me.Play_RoomLabel1)
        Me.GroupBox3.Controls.Add(Me.Living_RoomLabel1)
        Me.GroupBox3.Controls.Add(Label6)
        Me.GroupBox3.Controls.Add(Me.lblGreatRoomSStatus)
        Me.GroupBox3.Controls.Add(Label12)
        Me.GroupBox3.Controls.Add(Me.lblGreatRoomNStatus)
        Me.GroupBox3.Controls.Add(Me.lblLivingRoomVentStatus)
        Me.GroupBox3.Controls.Add(Me.lblPlayRoomVentStatus)
        Me.GroupBox3.Controls.Add(Label5)
        Me.GroupBox3.Controls.Add(Label7)
        Me.GroupBox3.Controls.Add(Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(188, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 141)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Air Vents (30 Min)"
        '
        'lblSeason
        '
        Me.lblSeason.AutoSize = True
        Me.lblSeason.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeason.Location = New System.Drawing.Point(131, 122)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.Size = New System.Drawing.Size(9, 12)
        Me.lblSeason.TabIndex = 53
        Me.lblSeason.Text = "-"
        '
        'KitchenLabel2
        '
        Me.KitchenLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Temp_Current_StateBindingSource, "Kitchen", True))
        Me.KitchenLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KitchenLabel2.Location = New System.Drawing.Point(81, 98)
        Me.KitchenLabel2.Name = "KitchenLabel2"
        Me.KitchenLabel2.Size = New System.Drawing.Size(20, 12)
        Me.KitchenLabel2.TabIndex = 52
        Me.KitchenLabel2.Text = "00"
        Me.KitchenLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Temp_Current_StateBindingSource
        '
        Me.Temp_Current_StateBindingSource.DataMember = "Temp_Current_State"
        Me.Temp_Current_StateBindingSource.DataSource = Me.WatchdogDataSet
        '
        'KitchenLabel1
        '
        Me.KitchenLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Temp_Current_StateBindingSource, "Kitchen", True))
        Me.KitchenLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KitchenLabel1.Location = New System.Drawing.Point(79, 82)
        Me.KitchenLabel1.Name = "KitchenLabel1"
        Me.KitchenLabel1.Size = New System.Drawing.Size(22, 16)
        Me.KitchenLabel1.TabIndex = 51
        Me.KitchenLabel1.Text = "00"
        Me.KitchenLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblKitchenSVent
        '
        Me.lblKitchenSVent.AutoSize = True
        Me.lblKitchenSVent.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKitchenSVent.Location = New System.Drawing.Point(131, 98)
        Me.lblKitchenSVent.Name = "lblKitchenSVent"
        Me.lblKitchenSVent.Size = New System.Drawing.Size(34, 12)
        Me.lblKitchenSVent.TabIndex = 50
        Me.lblKitchenSVent.Text = "Closed"
        '
        'lblKitchenNVent
        '
        Me.lblKitchenNVent.AutoSize = True
        Me.lblKitchenNVent.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKitchenNVent.Location = New System.Drawing.Point(131, 82)
        Me.lblKitchenNVent.Name = "lblKitchenNVent"
        Me.lblKitchenNVent.Size = New System.Drawing.Size(34, 12)
        Me.lblKitchenNVent.TabIndex = 49
        Me.lblKitchenNVent.Text = "Closed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 12)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "F"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(100, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 12)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "F"
        '
        'lblKitchenSStatus
        '
        Me.lblKitchenSStatus.AutoSize = True
        Me.lblKitchenSStatus.Location = New System.Drawing.Point(182, 98)
        Me.lblKitchenSStatus.Name = "lblKitchenSStatus"
        Me.lblKitchenSStatus.Size = New System.Drawing.Size(9, 12)
        Me.lblKitchenSStatus.TabIndex = 44
        Me.lblKitchenSStatus.Text = "!"
        '
        'lblKitchenNStatus
        '
        Me.lblKitchenNStatus.AutoSize = True
        Me.lblKitchenNStatus.Location = New System.Drawing.Point(182, 82)
        Me.lblKitchenNStatus.Name = "lblKitchenNStatus"
        Me.lblKitchenNStatus.Size = New System.Drawing.Size(9, 12)
        Me.lblKitchenNStatus.TabIndex = 42
        Me.lblKitchenNStatus.Text = "!"
        '
        'lblGreatRoomSVent
        '
        Me.lblGreatRoomSVent.AutoSize = True
        Me.lblGreatRoomSVent.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreatRoomSVent.Location = New System.Drawing.Point(131, 65)
        Me.lblGreatRoomSVent.Name = "lblGreatRoomSVent"
        Me.lblGreatRoomSVent.Size = New System.Drawing.Size(34, 12)
        Me.lblGreatRoomSVent.TabIndex = 40
        Me.lblGreatRoomSVent.Text = "Closed"
        '
        'lblGreatRoomNVent
        '
        Me.lblGreatRoomNVent.AutoSize = True
        Me.lblGreatRoomNVent.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreatRoomNVent.Location = New System.Drawing.Point(131, 49)
        Me.lblGreatRoomNVent.Name = "lblGreatRoomNVent"
        Me.lblGreatRoomNVent.Size = New System.Drawing.Size(34, 12)
        Me.lblGreatRoomNVent.TabIndex = 39
        Me.lblGreatRoomNVent.Text = "Closed"
        '
        'lblLivingRoomVent
        '
        Me.lblLivingRoomVent.AutoSize = True
        Me.lblLivingRoomVent.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLivingRoomVent.Location = New System.Drawing.Point(131, 32)
        Me.lblLivingRoomVent.Name = "lblLivingRoomVent"
        Me.lblLivingRoomVent.Size = New System.Drawing.Size(34, 12)
        Me.lblLivingRoomVent.TabIndex = 38
        Me.lblLivingRoomVent.Text = "Closed"
        '
        'lblPlayRoomVent
        '
        Me.lblPlayRoomVent.AutoSize = True
        Me.lblPlayRoomVent.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayRoomVent.Location = New System.Drawing.Point(131, 16)
        Me.lblPlayRoomVent.Name = "lblPlayRoomVent"
        Me.lblPlayRoomVent.Size = New System.Drawing.Size(34, 12)
        Me.lblPlayRoomVent.TabIndex = 22
        Me.lblPlayRoomVent.Text = "Closed"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(100, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 12)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "F"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(100, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 12)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "F"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(100, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 12)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "F"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(100, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 12)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "F"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(100, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 12)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "F"
        '
        'GreatRmLabel2
        '
        Me.GreatRmLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Temp_Current_StateBindingSource, "Great_Room", True))
        Me.GreatRmLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreatRmLabel2.Location = New System.Drawing.Point(77, 65)
        Me.GreatRmLabel2.Name = "GreatRmLabel2"
        Me.GreatRmLabel2.Size = New System.Drawing.Size(24, 12)
        Me.GreatRmLabel2.TabIndex = 32
        Me.GreatRmLabel2.Text = "00"
        Me.GreatRmLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GreatRmLabel1
        '
        Me.GreatRmLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Temp_Current_StateBindingSource, "Great_Room", True))
        Me.GreatRmLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreatRmLabel1.Location = New System.Drawing.Point(77, 48)
        Me.GreatRmLabel1.Name = "GreatRmLabel1"
        Me.GreatRmLabel1.Size = New System.Drawing.Size(24, 13)
        Me.GreatRmLabel1.TabIndex = 31
        Me.GreatRmLabel1.Text = "00"
        Me.GreatRmLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GarageLabel1
        '
        Me.GarageLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Temp_Current_StateBindingSource, "Garage", True))
        Me.GarageLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GarageLabel1.Location = New System.Drawing.Point(77, 121)
        Me.GarageLabel1.Name = "GarageLabel1"
        Me.GarageLabel1.Size = New System.Drawing.Size(24, 12)
        Me.GarageLabel1.TabIndex = 30
        Me.GarageLabel1.Text = "00"
        Me.GarageLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Play_RoomLabel1
        '
        Me.Play_RoomLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Temp_Current_StateBindingSource, "Play_Room", True))
        Me.Play_RoomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play_RoomLabel1.Location = New System.Drawing.Point(77, 17)
        Me.Play_RoomLabel1.Name = "Play_RoomLabel1"
        Me.Play_RoomLabel1.Size = New System.Drawing.Size(24, 15)
        Me.Play_RoomLabel1.TabIndex = 29
        Me.Play_RoomLabel1.Text = "00"
        Me.Play_RoomLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Living_RoomLabel1
        '
        Me.Living_RoomLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Temp_Current_StateBindingSource, "Living_Room", True))
        Me.Living_RoomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Living_RoomLabel1.Location = New System.Drawing.Point(77, 32)
        Me.Living_RoomLabel1.Name = "Living_RoomLabel1"
        Me.Living_RoomLabel1.Size = New System.Drawing.Size(24, 12)
        Me.Living_RoomLabel1.TabIndex = 28
        Me.Living_RoomLabel1.Text = "00"
        Me.Living_RoomLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGreatRoomSStatus
        '
        Me.lblGreatRoomSStatus.AutoSize = True
        Me.lblGreatRoomSStatus.Location = New System.Drawing.Point(182, 65)
        Me.lblGreatRoomSStatus.Name = "lblGreatRoomSStatus"
        Me.lblGreatRoomSStatus.Size = New System.Drawing.Size(9, 12)
        Me.lblGreatRoomSStatus.TabIndex = 26
        Me.lblGreatRoomSStatus.Text = "!"
        '
        'lblGreatRoomNStatus
        '
        Me.lblGreatRoomNStatus.AutoSize = True
        Me.lblGreatRoomNStatus.Location = New System.Drawing.Point(182, 49)
        Me.lblGreatRoomNStatus.Name = "lblGreatRoomNStatus"
        Me.lblGreatRoomNStatus.Size = New System.Drawing.Size(9, 12)
        Me.lblGreatRoomNStatus.TabIndex = 23
        Me.lblGreatRoomNStatus.Text = "!"
        '
        'lblLivingRoomVentStatus
        '
        Me.lblLivingRoomVentStatus.AutoSize = True
        Me.lblLivingRoomVentStatus.Location = New System.Drawing.Point(182, 32)
        Me.lblLivingRoomVentStatus.Name = "lblLivingRoomVentStatus"
        Me.lblLivingRoomVentStatus.Size = New System.Drawing.Size(9, 12)
        Me.lblLivingRoomVentStatus.TabIndex = 22
        Me.lblLivingRoomVentStatus.Text = "!"
        '
        'lblPlayRoomVentStatus
        '
        Me.lblPlayRoomVentStatus.AutoSize = True
        Me.lblPlayRoomVentStatus.Location = New System.Drawing.Point(182, 16)
        Me.lblPlayRoomVentStatus.Name = "lblPlayRoomVentStatus"
        Me.lblPlayRoomVentStatus.Size = New System.Drawing.Size(9, 12)
        Me.lblPlayRoomVentStatus.TabIndex = 21
        Me.lblPlayRoomVentStatus.Text = "!"
        '
        'Vent_HistoryDataGridView
        '
        Me.Vent_HistoryDataGridView.AutoGenerateColumns = False
        Me.Vent_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vent_HistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Vent_HistoryDataGridView.DataSource = Me.Vent_HistoryBindingSource
        Me.Vent_HistoryDataGridView.Location = New System.Drawing.Point(291, 196)
        Me.Vent_HistoryDataGridView.Name = "Vent_HistoryDataGridView"
        Me.Vent_HistoryDataGridView.Size = New System.Drawing.Size(16, 10)
        Me.Vent_HistoryDataGridView.TabIndex = 17
        Me.Vent_HistoryDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Vent_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Vent_ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Vent_State"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Vent_State"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Vent_HistoryBindingSource
        '
        Me.Vent_HistoryBindingSource.DataMember = "Vent_History"
        Me.Vent_HistoryBindingSource.DataSource = Me.WatchdogDataSet
        '
        'lblLast5min
        '
        Me.lblLast5min.AutoSize = True
        Me.lblLast5min.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast5min.Location = New System.Drawing.Point(314, 251)
        Me.lblLast5min.Name = "lblLast5min"
        Me.lblLast5min.Size = New System.Drawing.Size(75, 9)
        Me.lblLast5min.TabIndex = 19
        Me.lblLast5min.Text = "01/01/2011 12:00 PM"
        '
        'lblLast30Min
        '
        Me.lblLast30Min.AutoSize = True
        Me.lblLast30Min.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast30Min.Location = New System.Drawing.Point(314, 238)
        Me.lblLast30Min.Name = "lblLast30Min"
        Me.lblLast30Min.Size = New System.Drawing.Size(75, 9)
        Me.lblLast30Min.TabIndex = 21
        Me.lblLast30Min.Text = "01/01/2011 12:00 PM"
        '
        't30Min
        '
        Me.t30Min.Interval = 1800000
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTempMode)
        Me.GroupBox4.Controls.Add(Label38)
        Me.GroupBox4.Controls.Add(Me.lblThermostatStatus)
        Me.GroupBox4.Controls.Add(Me.Label40)
        Me.GroupBox4.Controls.Add(Me.lblTargetTemp)
        Me.GroupBox4.Controls.Add(Me.Label39)
        Me.GroupBox4.Controls.Add(Me.lblCurrentTemp)
        Me.GroupBox4.Controls.Add(Label37)
        Me.GroupBox4.Controls.Add(Label36)
        Me.GroupBox4.Controls.Add(Label35)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(379, 47)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "1 Minute"
        '
        'lblThermostatStatus
        '
        Me.lblThermostatStatus.AutoSize = True
        Me.lblThermostatStatus.Location = New System.Drawing.Point(74, 20)
        Me.lblThermostatStatus.Name = "lblThermostatStatus"
        Me.lblThermostatStatus.Size = New System.Drawing.Size(9, 12)
        Me.lblThermostatStatus.TabIndex = 29
        Me.lblThermostatStatus.Text = "!"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(265, 20)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(11, 12)
        Me.Label40.TabIndex = 79
        Me.Label40.Text = "F"
        '
        'lblTargetTemp
        '
        Me.lblTargetTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetTemp.Location = New System.Drawing.Point(243, 17)
        Me.lblTargetTemp.Name = "lblTargetTemp"
        Me.lblTargetTemp.Size = New System.Drawing.Size(24, 19)
        Me.lblTargetTemp.TabIndex = 78
        Me.lblTargetTemp.Text = "100"
        Me.lblTargetTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(153, 20)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(11, 12)
        Me.Label39.TabIndex = 77
        Me.Label39.Text = "F"
        '
        'lblCurrentTemp
        '
        Me.lblCurrentTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTemp.Location = New System.Drawing.Point(120, 17)
        Me.lblCurrentTemp.Name = "lblCurrentTemp"
        Me.lblCurrentTemp.Size = New System.Drawing.Size(35, 19)
        Me.lblCurrentTemp.TabIndex = 76
        Me.lblCurrentTemp.Text = "100"
        Me.lblCurrentTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLast1min
        '
        Me.lblLast1min.AutoSize = True
        Me.lblLast1min.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast1min.Location = New System.Drawing.Point(314, 264)
        Me.lblLast1min.Name = "lblLast1min"
        Me.lblLast1min.Size = New System.Drawing.Size(75, 9)
        Me.lblLast1min.TabIndex = 23
        Me.lblLast1min.Text = "01/01/2011 12:00 PM"
        '
        't1Min
        '
        Me.t1Min.Interval = 60000
        '
        'chkMute
        '
        Me.chkMute.AutoSize = True
        Me.chkMute.Location = New System.Drawing.Point(172, 262)
        Me.chkMute.Name = "chkMute"
        Me.chkMute.Size = New System.Drawing.Size(50, 17)
        Me.chkMute.TabIndex = 25
        Me.chkMute.Text = "Mute"
        Me.chkMute.UseVisualStyleBackColor = True
        '
        'lblLastDaily
        '
        Me.lblLastDaily.AutoSize = True
        Me.lblLastDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastDaily.Location = New System.Drawing.Point(314, 212)
        Me.lblLastDaily.Name = "lblLastDaily"
        Me.lblLastDaily.Size = New System.Drawing.Size(75, 9)
        Me.lblLastDaily.TabIndex = 27
        Me.lblLastDaily.Text = "01/01/2011 12:00 PM"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.lblBrineTankStatus)
        Me.GroupBox5.Controls.Add(Label44)
        Me.GroupBox5.Controls.Add(Me.Brine_TankLabel1)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 200)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(237, 37)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Daily"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(118, 14)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 12)
        Me.Label32.TabIndex = 40
        Me.Label32.Text = "%"
        '
        'lblBrineTankStatus
        '
        Me.lblBrineTankStatus.AutoSize = True
        Me.lblBrineTankStatus.Location = New System.Drawing.Point(146, 13)
        Me.lblBrineTankStatus.Name = "lblBrineTankStatus"
        Me.lblBrineTankStatus.Size = New System.Drawing.Size(9, 12)
        Me.lblBrineTankStatus.TabIndex = 11
        Me.lblBrineTankStatus.Text = "!"
        '
        'Brine_TankLabel1
        '
        Me.Brine_TankLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_Current_StateBindingSource, "Brine_Tank", True))
        Me.Brine_TankLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Brine_TankLabel1.Location = New System.Drawing.Point(91, 11)
        Me.Brine_TankLabel1.Name = "Brine_TankLabel1"
        Me.Brine_TankLabel1.Size = New System.Drawing.Size(29, 16)
        Me.Brine_TankLabel1.TabIndex = 8
        Me.Brine_TankLabel1.Text = "100"
        Me.Brine_TankLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Light1_on"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Light1_on"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Light1_off"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Light1_off"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Light2_on"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Light2_on"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Light2_off"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Light2_off"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Light3_on"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Light3_on"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Light3_off"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Light3_off"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Light4_on"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Light4_on"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Light4_off"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Light4_off"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Temp_Up_1"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Temp_Up_1"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Temp_Down_1"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Temp_Down_1"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Temp_Up_3"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Temp_Up_3"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Temp_Down_3"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Temp_Down_3"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Zone1_on"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Zone1_on"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Zone1_off"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Zone1_off"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Zone2_on"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Zone2_on"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Zone2_off"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Zone2_off"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Zone3_on"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Zone3_on"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Zone3_off"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Zone3_off"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Zone4_on"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Zone4_on"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Zone4_off"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Zone4_off"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Doorbell"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Doorbell"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'tRefreshTemp
        '
        Me.tRefreshTemp.Interval = 20000
        '
        'Temp_ControlDataGridView
        '
        Me.Temp_ControlDataGridView.AllowUserToAddRows = False
        Me.Temp_ControlDataGridView.AllowUserToDeleteRows = False
        Me.Temp_ControlDataGridView.AutoGenerateColumns = False
        Me.Temp_ControlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Temp_ControlDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30})
        Me.Temp_ControlDataGridView.DataSource = Me.Temp_ControlBindingSource
        Me.Temp_ControlDataGridView.Location = New System.Drawing.Point(349, 195)
        Me.Temp_ControlDataGridView.Name = "Temp_ControlDataGridView"
        Me.Temp_ControlDataGridView.ReadOnly = True
        Me.Temp_ControlDataGridView.Size = New System.Drawing.Size(17, 10)
        Me.Temp_ControlDataGridView.TabIndex = 28
        Me.Temp_ControlDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Row_ID"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Row_ID"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Temp_Mode"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Temp_Mode"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Temp_Direction"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Temp_Direction"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Temp_Degrees"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Temp_Degrees"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'Temp_ControlBindingSource
        '
        Me.Temp_ControlBindingSource.DataMember = "Temp_Control"
        Me.Temp_ControlBindingSource.DataSource = Me.WatchdogDataSet
        '
        'Insteon_ControlDataGridView
        '
        Me.Insteon_ControlDataGridView.AllowUserToAddRows = False
        Me.Insteon_ControlDataGridView.AllowUserToDeleteRows = False
        Me.Insteon_ControlDataGridView.AutoGenerateColumns = False
        Me.Insteon_ControlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Insteon_ControlDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35})
        Me.Insteon_ControlDataGridView.DataSource = Me.Insteon_ControlBindingSource
        Me.Insteon_ControlDataGridView.Location = New System.Drawing.Point(313, 195)
        Me.Insteon_ControlDataGridView.Name = "Insteon_ControlDataGridView"
        Me.Insteon_ControlDataGridView.ReadOnly = True
        Me.Insteon_ControlDataGridView.Size = New System.Drawing.Size(14, 10)
        Me.Insteon_ControlDataGridView.TabIndex = 28
        Me.Insteon_ControlDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Row_ID"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Row_ID"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Device_Name"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Device_Name"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Device_ID"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Device_ID"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Device_Current_State"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Device_Current_State"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "Device_Request_State"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Device_Request_State"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'Insteon_ControlBindingSource
        '
        Me.Insteon_ControlBindingSource.DataMember = "Insteon_Control"
        Me.Insteon_ControlBindingSource.DataSource = Me.WatchdogDataSet
        '
        'Thermostat_HistoryDataGridView
        '
        Me.Thermostat_HistoryDataGridView.AllowUserToAddRows = False
        Me.Thermostat_HistoryDataGridView.AllowUserToDeleteRows = False
        Me.Thermostat_HistoryDataGridView.AutoGenerateColumns = False
        Me.Thermostat_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Thermostat_HistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40})
        Me.Thermostat_HistoryDataGridView.DataSource = Me.Thermostat_HistoryBindingSource
        Me.Thermostat_HistoryDataGridView.Location = New System.Drawing.Point(333, 195)
        Me.Thermostat_HistoryDataGridView.Name = "Thermostat_HistoryDataGridView"
        Me.Thermostat_HistoryDataGridView.ReadOnly = True
        Me.Thermostat_HistoryDataGridView.Size = New System.Drawing.Size(10, 11)
        Me.Thermostat_HistoryDataGridView.TabIndex = 28
        Me.Thermostat_HistoryDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Change_Direction"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Change_Direction"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "Change_Quantity"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Change_Quantity"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Heat_Cool"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Heat_Cool"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "New_Target_Temp"
        Me.DataGridViewTextBoxColumn40.HeaderText = "New_Target_Temp"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        '
        'Thermostat_HistoryBindingSource
        '
        Me.Thermostat_HistoryBindingSource.DataMember = "Thermostat_History"
        Me.Thermostat_HistoryBindingSource.DataSource = Me.WatchdogDataSet
        '
        'lblLast1sec
        '
        Me.lblLast1sec.AutoSize = True
        Me.lblLast1sec.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast1sec.Location = New System.Drawing.Point(314, 277)
        Me.lblLast1sec.Name = "lblLast1sec"
        Me.lblLast1sec.Size = New System.Drawing.Size(75, 9)
        Me.lblLast1sec.TabIndex = 30
        Me.lblLast1sec.Text = "01/01/2011 12:00 PM"
        '
        'Call_CurrentBindingSource
        '
        Me.Call_CurrentBindingSource.DataMember = "Call_Current"
        Me.Call_CurrentBindingSource.DataSource = Me.WatchdogDataSet
        '
        'Event_Current_StateTableAdapter
        '
        Me.Event_Current_StateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Call_CurrentTableAdapter = Nothing
        Me.TableAdapterManager.Event_Current_StateTableAdapter = Me.Event_Current_StateTableAdapter
        Me.TableAdapterManager.Event_HistoryTableAdapter = Me.Event_HistoryTableAdapter
        Me.TableAdapterManager.Insteon_ControlTableAdapter = Nothing
        Me.TableAdapterManager.Temp_ControlTableAdapter = Nothing
        Me.TableAdapterManager.Temp_Current_StateTableAdapter = Nothing
        Me.TableAdapterManager.Thermostat_HistoryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WDNetChecker3.WatchdogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vent_HistoryTableAdapter = Nothing
        '
        'Event_HistoryTableAdapter
        '
        Me.Event_HistoryTableAdapter.ClearBeforeFill = True
        '
        'Temp_Current_StateTableAdapter
        '
        Me.Temp_Current_StateTableAdapter.ClearBeforeFill = True
        '
        'Vent_HistoryTableAdapter
        '
        Me.Vent_HistoryTableAdapter.ClearBeforeFill = True
        '
        'Temp_ControlTableAdapter
        '
        Me.Temp_ControlTableAdapter.ClearBeforeFill = True
        '
        'Insteon_ControlTableAdapter
        '
        Me.Insteon_ControlTableAdapter.ClearBeforeFill = True
        '
        'Thermostat_HistoryTableAdapter
        '
        Me.Thermostat_HistoryTableAdapter.ClearBeforeFill = True
        '
        'Call_CurrentTableAdapter
        '
        Me.Call_CurrentTableAdapter.ClearBeforeFill = True
        '
        'frmNetChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 293)
        Me.Controls.Add(Me.lblLast1sec)
        Me.Controls.Add(Label41)
        Me.Controls.Add(Me.Thermostat_HistoryDataGridView)
        Me.Controls.Add(Me.Insteon_ControlDataGridView)
        Me.Controls.Add(Me.Temp_ControlDataGridView)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.lblLastDaily)
        Me.Controls.Add(Label34)
        Me.Controls.Add(Me.chkMute)
        Me.Controls.Add(Label31)
        Me.Controls.Add(Me.lblLast1min)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblLast30Min)
        Me.Controls.Add(Label18)
        Me.Controls.Add(Me.lblLast5min)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.Vent_HistoryDataGridView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblLastHourly)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Event_HistoryDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNetChecker"
        Me.Text = "Net Checker 3"
        CType(Me.Event_HistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WatchdogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Event_Current_StateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Temp_Current_StateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vent_HistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vent_HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Temp_ControlDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Temp_ControlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Insteon_ControlDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Insteon_ControlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Thermostat_HistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Thermostat_HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Call_CurrentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tHourly As System.Windows.Forms.Timer
    Friend WithEvents WatchdogDataSet As WDNetChecker3.WatchdogDataSet
    Friend WithEvents Event_Current_StateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_Current_StateTableAdapter As WDNetChecker3.WatchdogDataSetTableAdapters.Event_Current_StateTableAdapter
    Friend WithEvents TableAdapterManager As WDNetChecker3.WatchdogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Event_HistoryTableAdapter As WDNetChecker3.WatchdogDataSetTableAdapters.Event_HistoryTableAdapter
    Friend WithEvents Event_HistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_HistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents lblLastHourly As System.Windows.Forms.Label
    Friend WithEvents t5Min As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Internet_LinkLabel1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Stair_LightsLabel1 As System.Windows.Forms.Label
    Friend WithEvents lblInternetLinkStatus As System.Windows.Forms.Label
    Friend WithEvents lblStairLightStatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblGreatRoomSStatus As System.Windows.Forms.Label
    Friend WithEvents lblGreatRoomNStatus As System.Windows.Forms.Label
    Friend WithEvents lblLivingRoomVentStatus As System.Windows.Forms.Label
    Friend WithEvents lblPlayRoomVentStatus As System.Windows.Forms.Label
    Friend WithEvents Temp_Current_StateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Temp_Current_StateTableAdapter As WDNetChecker3.WatchdogDataSetTableAdapters.Temp_Current_StateTableAdapter
    Friend WithEvents Play_RoomLabel1 As System.Windows.Forms.Label
    Friend WithEvents Living_RoomLabel1 As System.Windows.Forms.Label
    Friend WithEvents GreatRmLabel2 As System.Windows.Forms.Label
    Friend WithEvents GreatRmLabel1 As System.Windows.Forms.Label
    Friend WithEvents GarageLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblPlayRoomVent As System.Windows.Forms.Label
    Friend WithEvents lblGreatRoomSVent As System.Windows.Forms.Label
    Friend WithEvents lblGreatRoomNVent As System.Windows.Forms.Label
    Friend WithEvents lblLivingRoomVent As System.Windows.Forms.Label
    Friend WithEvents Vent_HistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vent_HistoryTableAdapter As WDNetChecker3.WatchdogDataSetTableAdapters.Vent_HistoryTableAdapter
    Friend WithEvents Vent_HistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KitchenLabel1 As System.Windows.Forms.Label
    Friend WithEvents lblKitchenSVent As System.Windows.Forms.Label
    Friend WithEvents lblKitchenNVent As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblKitchenSStatus As System.Windows.Forms.Label
    Friend WithEvents lblKitchenNStatus As System.Windows.Forms.Label
    Friend WithEvents KitchenLabel2 As System.Windows.Forms.Label
    Friend WithEvents lblLast5min As System.Windows.Forms.Label
    Friend WithEvents lblGreatRmTemp As System.Windows.Forms.Label
    Friend WithEvents lblGreatRmTempStatus As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblSeason As System.Windows.Forms.Label
    Friend WithEvents lblLast30Min As System.Windows.Forms.Label
    Friend WithEvents t30Min As System.Windows.Forms.Timer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLast1min As System.Windows.Forms.Label
    Friend WithEvents t1Min As System.Windows.Forms.Timer
    Friend WithEvents lblSevereWeatherStatus As System.Windows.Forms.Label
    Friend WithEvents lblSevereWeather As System.Windows.Forms.Label
    Friend WithEvents chkMute As System.Windows.Forms.CheckBox
    Friend WithEvents lblLastDaily As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBrineTankStatus As System.Windows.Forms.Label
    Friend WithEvents Brine_TankLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblThermostatStatus As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents lblTargetTemp As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentTemp As System.Windows.Forms.Label
    Friend WithEvents tRefreshTemp As System.Windows.Forms.Timer
    Friend WithEvents Temp_ControlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Temp_ControlTableAdapter As WDNetChecker3.WatchdogDataSetTableAdapters.Temp_ControlTableAdapter
    Friend WithEvents Temp_ControlDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTempMode As System.Windows.Forms.Label
    Friend WithEvents Insteon_ControlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Insteon_ControlTableAdapter As WDNetChecker3.WatchdogDataSetTableAdapters.Insteon_ControlTableAdapter
    Friend WithEvents Insteon_ControlDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thermostat_HistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Thermostat_HistoryTableAdapter As WDNetChecker3.WatchdogDataSetTableAdapters.Thermostat_HistoryTableAdapter
    Friend WithEvents Thermostat_HistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblLast1sec As System.Windows.Forms.Label
    Friend WithEvents Call_CurrentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Call_CurrentTableAdapter As WDNetChecker3.WatchdogDataSetTableAdapters.Call_CurrentTableAdapter

End Class

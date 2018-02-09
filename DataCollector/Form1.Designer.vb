<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Status = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.SQLStat = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Grid1 = New AxMSFlexGridLib.AxMSFlexGrid()
        Me.DisconnectButton = New System.Windows.Forms.Button()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.LastPoll = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ServerStat = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Settings = New System.Windows.Forms.TabPage()
        Me.AutoStart = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.CSVRoot = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.CSVDestination = New System.Windows.Forms.TextBox()
        Me.MoveCSV = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Diagnostics = New System.Windows.Forms.TextBox()
        Me.SqlStatus = New System.Windows.Forms.TextBox()
        Me.TestSql = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SqlPass = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.SqlUser = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SQLServer = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cbbServerList = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OPCServerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FileList2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ResultsGrid = New AxMSFlexGridLib.AxMSFlexGrid()
        Me.FileList = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ItemSelect = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FileList4 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FileList3 = New System.Windows.Forms.ComboBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.Status.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Settings.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ResultsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(606, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(328, 55)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Data Collector"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Status)
        Me.TabControl1.Controls.Add(Me.Settings)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 87)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1448, 542)
        Me.TabControl1.TabIndex = 19
        '
        'Status
        '
        Me.Status.Controls.Add(Me.Button8)
        Me.Status.Controls.Add(Me.Button7)
        Me.Status.Controls.Add(Me.Button6)
        Me.Status.Controls.Add(Me.Button5)
        Me.Status.Controls.Add(Me.Delete)
        Me.Status.Controls.Add(Me.SQLStat)
        Me.Status.Controls.Add(Me.Label6)
        Me.Status.Controls.Add(Me.Label1)
        Me.Status.Controls.Add(Me.Button3)
        Me.Status.Controls.Add(Me.Grid1)
        Me.Status.Controls.Add(Me.DisconnectButton)
        Me.Status.Controls.Add(Me.ConnectButton)
        Me.Status.Controls.Add(Me.LastPoll)
        Me.Status.Controls.Add(Me.Label11)
        Me.Status.Controls.Add(Me.ServerStat)
        Me.Status.Controls.Add(Me.Label9)
        Me.Status.Location = New System.Drawing.Point(4, 22)
        Me.Status.Name = "Status"
        Me.Status.Padding = New System.Windows.Forms.Padding(3)
        Me.Status.Size = New System.Drawing.Size(1440, 516)
        Me.Status.TabIndex = 0
        Me.Status.Text = "Status And Values"
        Me.Status.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(794, 39)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 37
        Me.Button8.Text = "All TO CSV"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(713, 39)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 36
        Me.Button7.Text = "All To SQL"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(429, 39)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 35
        Me.Button6.Text = "Duplicate"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(348, 39)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(511, 39)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 33
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'SQLStat
        '
        Me.SQLStat.AutoSize = True
        Me.SQLStat.ForeColor = System.Drawing.Color.Red
        Me.SQLStat.Location = New System.Drawing.Point(668, 13)
        Me.SQLStat.Name = "SQLStat"
        Me.SQLStat.Size = New System.Drawing.Size(120, 13)
        Me.SQLStat.TabIndex = 32
        Me.SQLStat.Text = "Database Server Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(519, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "DataBase Server Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Tags-"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(267, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Grid1
        '
        Me.Grid1.Location = New System.Drawing.Point(6, 68)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.OcxState = CType(resources.GetObject("Grid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Grid1.Size = New System.Drawing.Size(1428, 442)
        Me.Grid1.TabIndex = 28
        '
        'DisconnectButton
        '
        Me.DisconnectButton.Enabled = False
        Me.DisconnectButton.Location = New System.Drawing.Point(87, 39)
        Me.DisconnectButton.Name = "DisconnectButton"
        Me.DisconnectButton.Size = New System.Drawing.Size(75, 23)
        Me.DisconnectButton.TabIndex = 27
        Me.DisconnectButton.Text = "Disconnect"
        Me.DisconnectButton.UseVisualStyleBackColor = True
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(6, 39)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(75, 23)
        Me.ConnectButton.TabIndex = 26
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'LastPoll
        '
        Me.LastPoll.AllowDrop = True
        Me.LastPoll.AutoSize = True
        Me.LastPoll.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LastPoll.Location = New System.Drawing.Point(1089, 13)
        Me.LastPoll.Name = "LastPoll"
        Me.LastPoll.Size = New System.Drawing.Size(33, 13)
        Me.LastPoll.TabIndex = 23
        Me.LastPoll.Text = "None"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(996, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Last Poll Time"
        '
        'ServerStat
        '
        Me.ServerStat.AutoSize = True
        Me.ServerStat.ForeColor = System.Drawing.Color.Red
        Me.ServerStat.Location = New System.Drawing.Point(140, 13)
        Me.ServerStat.Name = "ServerStat"
        Me.ServerStat.Size = New System.Drawing.Size(96, 13)
        Me.ServerStat.TabIndex = 21
        Me.ServerStat.Text = "OPC Server Status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "OPC Server Status"
        '
        'Settings
        '
        Me.Settings.Controls.Add(Me.AutoStart)
        Me.Settings.Controls.Add(Me.Label4)
        Me.Settings.Controls.Add(Me.Button10)
        Me.Settings.Controls.Add(Me.CSVRoot)
        Me.Settings.Controls.Add(Me.Button9)
        Me.Settings.Controls.Add(Me.CSVDestination)
        Me.Settings.Controls.Add(Me.MoveCSV)
        Me.Settings.Controls.Add(Me.Label3)
        Me.Settings.Controls.Add(Me.Diagnostics)
        Me.Settings.Controls.Add(Me.SqlStatus)
        Me.Settings.Controls.Add(Me.TestSql)
        Me.Settings.Controls.Add(Me.Button2)
        Me.Settings.Controls.Add(Me.SqlPass)
        Me.Settings.Controls.Add(Me.Label19)
        Me.Settings.Controls.Add(Me.SqlUser)
        Me.Settings.Controls.Add(Me.Label18)
        Me.Settings.Controls.Add(Me.SQLServer)
        Me.Settings.Controls.Add(Me.Label17)
        Me.Settings.Controls.Add(Me.Button4)
        Me.Settings.Controls.Add(Me.cbbServerList)
        Me.Settings.Controls.Add(Me.Button1)
        Me.Settings.Controls.Add(Me.OPCServerName)
        Me.Settings.Controls.Add(Me.Label2)
        Me.Settings.Location = New System.Drawing.Point(4, 22)
        Me.Settings.Name = "Settings"
        Me.Settings.Padding = New System.Windows.Forms.Padding(3)
        Me.Settings.Size = New System.Drawing.Size(1440, 516)
        Me.Settings.TabIndex = 2
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'AutoStart
        '
        Me.AutoStart.AutoSize = True
        Me.AutoStart.Location = New System.Drawing.Point(1017, 40)
        Me.AutoStart.Name = "AutoStart"
        Me.AutoStart.Size = New System.Drawing.Size(118, 17)
        Me.AutoStart.TabIndex = 73
        Me.AutoStart.Text = "Connect on Startup"
        Me.AutoStart.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(628, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "CSV Root Folder"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(1098, 238)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(74, 24)
        Me.Button10.TabIndex = 71
        Me.Button10.Text = "Browse"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'CSVRoot
        '
        Me.CSVRoot.Location = New System.Drawing.Point(724, 239)
        Me.CSVRoot.Name = "CSVRoot"
        Me.CSVRoot.Size = New System.Drawing.Size(368, 20)
        Me.CSVRoot.TabIndex = 70
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(1098, 267)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(74, 24)
        Me.Button9.TabIndex = 69
        Me.Button9.Text = "Browse"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'CSVDestination
        '
        Me.CSVDestination.Location = New System.Drawing.Point(724, 268)
        Me.CSVDestination.Name = "CSVDestination"
        Me.CSVDestination.Size = New System.Drawing.Size(368, 20)
        Me.CSVDestination.TabIndex = 68
        '
        'MoveCSV
        '
        Me.MoveCSV.AutoSize = True
        Me.MoveCSV.Location = New System.Drawing.Point(540, 270)
        Me.MoveCSV.Name = "MoveCSV"
        Me.MoveCSV.Size = New System.Drawing.Size(178, 17)
        Me.MoveCSV.TabIndex = 67
        Me.MoveCSV.Text = "Move Non Current CSV to folder"
        Me.MoveCSV.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Event Log"
        '
        'Diagnostics
        '
        Me.Diagnostics.Location = New System.Drawing.Point(0, 294)
        Me.Diagnostics.Multiline = True
        Me.Diagnostics.Name = "Diagnostics"
        Me.Diagnostics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Diagnostics.Size = New System.Drawing.Size(1439, 222)
        Me.Diagnostics.TabIndex = 54
        '
        'SqlStatus
        '
        Me.SqlStatus.Location = New System.Drawing.Point(541, 198)
        Me.SqlStatus.Name = "SqlStatus"
        Me.SqlStatus.Size = New System.Drawing.Size(283, 20)
        Me.SqlStatus.TabIndex = 53
        '
        'TestSql
        '
        Me.TestSql.Location = New System.Drawing.Point(541, 169)
        Me.TestSql.Name = "TestSql"
        Me.TestSql.Size = New System.Drawing.Size(281, 23)
        Me.TestSql.TabIndex = 50
        Me.TestSql.Text = "Test Sql "
        Me.TestSql.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(11, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 29)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Save Changes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SqlPass
        '
        Me.SqlPass.Location = New System.Drawing.Point(541, 133)
        Me.SqlPass.Name = "SqlPass"
        Me.SqlPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SqlPass.Size = New System.Drawing.Size(283, 20)
        Me.SqlPass.TabIndex = 48
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(538, 117)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 13)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "SQL Password"
        '
        'SqlUser
        '
        Me.SqlUser.Location = New System.Drawing.Point(541, 84)
        Me.SqlUser.Name = "SqlUser"
        Me.SqlUser.Size = New System.Drawing.Size(283, 20)
        Me.SqlUser.TabIndex = 46
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(538, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "SQL Username"
        '
        'SQLServer
        '
        Me.SQLServer.Location = New System.Drawing.Point(541, 37)
        Me.SQLServer.Name = "SQLServer"
        Me.SQLServer.Size = New System.Drawing.Size(283, 20)
        Me.SQLServer.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(538, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "SQL Server"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(38, 595)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 29)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Save Changes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cbbServerList
        '
        Me.cbbServerList.FormattingEnabled = True
        Me.cbbServerList.Location = New System.Drawing.Point(135, 62)
        Me.cbbServerList.Name = "cbbServerList"
        Me.cbbServerList.Size = New System.Drawing.Size(283, 173)
        Me.cbbServerList.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 36)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "List Servers"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OPCServerName
        '
        Me.OPCServerName.Location = New System.Drawing.Point(135, 21)
        Me.OPCServerName.Name = "OPCServerName"
        Me.OPCServerName.Size = New System.Drawing.Size(283, 20)
        Me.OPCServerName.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "OPC Server "
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button12)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.FileList2)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.ResultsGrid)
        Me.TabPage1.Controls.Add(Me.FileList)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1440, 516)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Results"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(897, 6)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 31
        Me.Button12.Text = "Refresh"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(474, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Historical Values"
        '
        'FileList2
        '
        Me.FileList2.FormattingEnabled = True
        Me.FileList2.Location = New System.Drawing.Point(590, 6)
        Me.FileList2.Name = "FileList2"
        Me.FileList2.Size = New System.Drawing.Size(283, 21)
        Me.FileList2.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Current Values"
        '
        'ResultsGrid
        '
        Me.ResultsGrid.Location = New System.Drawing.Point(7, 34)
        Me.ResultsGrid.Name = "ResultsGrid"
        Me.ResultsGrid.OcxState = CType(resources.GetObject("ResultsGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ResultsGrid.Size = New System.Drawing.Size(1427, 476)
        Me.ResultsGrid.TabIndex = 1
        '
        'FileList
        '
        Me.FileList.FormattingEnabled = True
        Me.FileList.Location = New System.Drawing.Point(133, 6)
        Me.FileList.Name = "FileList"
        Me.FileList.Size = New System.Drawing.Size(283, 21)
        Me.FileList.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button11)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.ItemSelect)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.FileList4)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.FileList3)
        Me.TabPage2.Controls.Add(Me.Chart1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1440, 516)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Graphs"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(449, 34)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 30
        Me.Button11.Text = "Refresh"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Item"
        '
        'ItemSelect
        '
        Me.ItemSelect.FormattingEnabled = True
        Me.ItemSelect.Location = New System.Drawing.Point(134, 36)
        Me.ItemSelect.Name = "ItemSelect"
        Me.ItemSelect.Size = New System.Drawing.Size(283, 21)
        Me.ItemSelect.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(475, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Historical Values"
        '
        'FileList4
        '
        Me.FileList4.FormattingEnabled = True
        Me.FileList4.Location = New System.Drawing.Point(591, 9)
        Me.FileList4.Name = "FileList4"
        Me.FileList4.Size = New System.Drawing.Size(283, 21)
        Me.FileList4.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Current Values"
        '
        'FileList3
        '
        Me.FileList3.FormattingEnabled = True
        Me.FileList3.Location = New System.Drawing.Point(134, 9)
        Me.FileList3.Name = "FileList3"
        Me.FileList3.Size = New System.Drawing.Size(283, 21)
        Me.FileList3.TabIndex = 24
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Gray
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(6, 63)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.Red
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Series1"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(935, 423)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BackgroundImage = Global.DataCollector.My.Resources.Resources.banner
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(12, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1448, 73)
        Me.Panel1.TabIndex = 20
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 60000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 48)
        Me.ContextMenuStrip1.Text = "Menu"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem1.Text = "Show"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem2.Text = "Close"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1472, 641)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Elite Data Collector"
        Me.TabControl1.ResumeLayout(False)
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Settings.ResumeLayout(False)
        Me.Settings.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ResultsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Grid1 As AxMSFlexGridLib.AxMSFlexGrid
    Friend WithEvents DisconnectButton As Button
    Friend WithEvents ConnectButton As Button
    Friend WithEvents LastPoll As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ServerStat As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Settings As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents SqlPass As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents SqlUser As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents SQLServer As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents cbbServerList As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OPCServerName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TestSql As Button
    Friend WithEvents SqlStatus As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Delete As Button
    Friend WithEvents SQLStat As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Public WithEvents Status As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Diagnostics As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents CSVDestination As TextBox
    Friend WithEvents MoveCSV As CheckBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents CSVRoot As TextBox
    Friend WithEvents AutoStart As CheckBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ResultsGrid As AxMSFlexGridLib.AxMSFlexGrid
    Friend WithEvents FileList As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FileList2 As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label13 As Label
    Friend WithEvents ItemSelect As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents FileList4 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents FileList3 As ComboBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
End Class

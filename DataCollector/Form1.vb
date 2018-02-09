Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO


Public Class Form1
    'Main Class Of form   
    Dim WithEvents GlobalOPCServer As GBDAAutomation.OPCServerClass
    Dim WithEvents ConnectedOPCServer As GBDAAutomation.OPCServerClass
    Dim WithEvents ConnectedGroup As GBDAAutomation.OPCGroupClass
    Dim OPCMyItems As GBDAAutomation.OPCItems
    Dim ITEMMAX As Integer = 100
    Dim sItemName(ITEMMAX) As String
    Dim cH(ITEMMAX) As Integer
    Dim sH(ITEMMAX) As Integer
    Dim oVal(ITEMMAX) As Object
    Dim dTime(ITEMMAX) As Date
    Dim wQuality(ITEMMAX) As Short
    Dim ItemLines(ITEMMAX) As Integer
    Dim Startup As Boolean
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private SQLConnected As Boolean
    Private LastSQLConnected As Boolean
    Private SQLPurgeRequired
    Private DatabaseItemCount
    Private retrytime
    Private LastLogTime As String
    Private NumSqlItems As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'when form loads

        Me.Text = "Elite Data Collector " & Application.ProductVersion
        ConnectedOPCServer = New GBDAAutomation.OPCServer
        Diagnostics.AppendText(Date.Now & vbTab & "Application startup " & vbCrLf)
        Initialise()
        If My.Settings.AutoStart Then Connect()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            GlobalOPCServer = New GBDAAutomation.OPCServerClass()
            Dim ServerList As Object = GlobalOPCServer.GetOPCServers
            For index As Short = LBound(ServerList) To UBound(ServerList)
                cbbServerList.Items.Add(ServerList(index))
            Next
            If cbbServerList.Items.Count > 0 Then
                cbbServerList.SelectedIndex = 0
            End If
            GlobalOPCServer = Nothing
        Catch Ex As Exception
            MessageBox.Show("List OPC servers failed: " + Ex.Message, "OPCSample", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cbbServerList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbServerList.SelectedIndexChanged
        OPCServerName.Text = cbbServerList.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.OPCServer = OPCServerName.Text
        My.Settings.SQLServer = SQLServer.Text
        My.Settings.SQLUser = SqlUser.Text
        My.Settings.SQLPass = SqlPass.Text
        My.Settings.MoveCSV = MoveCSV.Checked
        My.Settings.CSVDestination = CSVDestination.Text
        My.Settings.CSVPath = CSVRoot.Text
        My.Settings.AutoStart = AutoStart.Checked
    End Sub

    Private Sub TestSql_Click(sender As Object, e As EventArgs) Handles TestSql.Click
        Dim ConnStr
        On Error Resume Next
        SqlStatus.Text = "Testing..."
        ConnStr = "Server=" & SQLServer.Text & ";User Id=" & SqlUser.Text & ";Password=" & SqlPass.Text & ";"
        myConn = New SqlConnection(ConnStr)

        'Open the connection.
        myConn.Open()
        If myConn.State = ConnectionState.Open Then
            SqlStatus.Text = "Connection Successful"
        Else
            SqlStatus.Text = "Connection Failed"
        End If


    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ConnectedOPCServer.ServerState = 1 Then
            MsgBox("Please Disconnect Before Editing Items")
        Else
            Dim dlg As Form2 = New Form2(0, 0)
            dlg.ShowDialog()
        End If


    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        On Error Resume Next
        TabControl1.Width = Me.Width - 35
        TabControl1.Height = Me.Height - 130
        Grid1.Width = Me.Width - 55
        Grid1.Height = Me.Height - 245
        Panel1.Width = Me.Width - 35
        Diagnostics.Width = Me.Width - 50
        Diagnostics.Height = Me.Height - 450
        ResultsGrid.Width = Me.Width - 55
        ResultsGrid.Height = Me.Height - 245
        Chart1.Width = Me.Width - 50
        Chart1.Height = Me.Height - 245
    End Sub



    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Grid1.set_ColWidth(0, IIf(My.Settings.Col1Size > 0, My.Settings.Col1Size, 3000))
        Grid1.set_ColWidth(1, IIf(My.Settings.Col2Size > 0, My.Settings.Col2Size, 3000))
        Grid1.set_ColWidth(2, IIf(My.Settings.Col3Size > 0, My.Settings.Col3Size, 3000))
        Grid1.set_ColWidth(3, IIf(My.Settings.Col4Size > 0, My.Settings.Col4Size, 3000))
        Grid1.set_ColWidth(4, IIf(My.Settings.Col5Size > 0, My.Settings.Col5Size, 3000))
        Grid1.set_ColWidth(5, IIf(My.Settings.Col6Size > 0, My.Settings.Col6Size, 3000))
        Grid1.set_ColWidth(6, IIf(My.Settings.Col7Size > 0, My.Settings.Col7Size, 3000))
        Grid1.set_ColWidth(7, IIf(My.Settings.Col8Size > 0, My.Settings.Col8Size, 3000))
        Grid1.set_ColWidth(8, IIf(My.Settings.Col9Size > 0, My.Settings.Col9Size, 3000))
        Grid1.set_ColWidth(9, IIf(My.Settings.Col10Size > 0, My.Settings.Col10Size, 3000))
        Grid1.set_ColWidth(10, IIf(My.Settings.Col11Size > 0, My.Settings.Col11Size, 3000))
        Grid1.set_ColWidth(11, IIf(My.Settings.Col12Size > 0, My.Settings.Col12Size, 3000))
        Grid1.set_ColWidth(12, IIf(My.Settings.Col12Size > 0, My.Settings.Col13Size, 3000))
        Grid1.set_ColWidth(13, IIf(My.Settings.Col13Size > 0, My.Settings.Col14Size, 3000))


        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        My.Settings.Col1Size = Grid1.get_ColWidth(0)
        My.Settings.Col2Size = Grid1.get_ColWidth(1)
        My.Settings.Col3Size = Grid1.get_ColWidth(2)
        My.Settings.Col4Size = Grid1.get_ColWidth(3)
        My.Settings.Col5Size = Grid1.get_ColWidth(4)
        My.Settings.Col6Size = Grid1.get_ColWidth(5)
        My.Settings.Col7Size = Grid1.get_ColWidth(6)
        My.Settings.Col8Size = Grid1.get_ColWidth(7)
        My.Settings.Col9Size = Grid1.get_ColWidth(8)
        My.Settings.Col10Size = Grid1.get_ColWidth(9)
        My.Settings.Col11Size = Grid1.get_ColWidth(10)
        My.Settings.Col12Size = Grid1.get_ColWidth(11)
        My.Settings.Col13Size = Grid1.get_ColWidth(12)
        My.Settings.Col14Size = Grid1.get_ColWidth(13)

        Me.WindowState = FormWindowState.Minimized

        e.Cancel = True


        Me.Visible = False
        NotifyIcon1.Visible = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim result As Integer = MessageBox.Show("Delete This Tag ? ", "Confirm Deletion", MessageBoxButtons.YesNo)
        Dim rowtext
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            For n = 1 To Grid1.Rows
                If Grid1.RowSel = n Then
                    Grid1.RemoveItem(n)
                    Diagnostics.AppendText(Date.Now & vbTab & "Item Removed From Table")
                End If
            Next
            SaveDat()

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ConnectedOPCServer.ServerState = 1 Then
            MsgBox("Please Disconnect Before Editing Items")
        Else
            Dim dlg As Form2 = New Form2(Grid1.Row, 0)
            dlg.ShowDialog()
        End If



    End Sub

    Private Sub Grid1_DblClick(sender As Object, e As EventArgs) Handles Grid1.DblClick
        If ConnectedOPCServer.ServerState = 1 Then
            MsgBox("Please Disconnect Before Editing Items")
        Else
            Dim dlg As Form2 = New Form2(Grid1.Row, 0)
            dlg.ShowDialog()
        End If

    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        Connect()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim Time
        Time = DateAndTime.DateString & " " & DateAndTime.TimeString
        LastPoll.Text = Time

        Dim i, numtags, item
        Dim ItemValues As Array
        Dim Qualities As Array
        Dim TimeStamps As Array
        Dim Errors As Array

        Dim TimeMatch, HourMatch, MinMatch, SecMatch, Interval


        numtags = 0
        TimeMatch = False
        HourMatch = False
        MinMatch = False
        SecMatch = False
        For i = 1 To Grid1.Rows - 1
            If Grid1.get_TextMatrix(i, 2) <> "Disabled" Then numtags = numtags + 1
        Next

        Try
            ConnectedGroup.SyncRead(GBDAAutomation.OPCDataSource.OPCDevice, numtags, sH, ItemValues, Errors, Qualities, TimeStamps)
        Catch err As System.AccessViolationException
            Timer1.Enabled = False
            Disconnect()
            MsgBox("There Was A Problem reading items from The OPC Server")

        Catch err As System.ArgumentException
            Timer1.Enabled = False
            Disconnect()
            MsgBox("There Was A Problem reading items from The OPC Server")

        End Try


        For i = 1 To numtags
            item = ItemLines(i)
            oVal(i) = ItemValues(i)
            dTime(i) = TimeStamps(i)
            wQuality(i) = Qualities(i)
            Grid1.set_TextMatrix(item, 10, oVal(i))
            Interval = Grid1.get_TextMatrix(item, 2)
            If oVal(i) = Nothing Then oVal(i) = 0

            ' Log to SQL if Connected --------------------------------------------------

            Dim thistime As New DateTime
            Dim lasttime As New DateTime

            thistime = Now


            If Grid1.get_TextMatrix(item, 11) = "Never" Or Grid1.get_TextMatrix(item, 11) = "" Then
                lasttime = Now

            Else
                lasttime = Grid1.get_TextMatrix(item, 11)
            End If


            Dim duration = thistime - lasttime
            If (Interval = "Every Second") Or (Interval = "Every Minute" And duration.Minutes >= 1) Or (Interval = "Every Hour" And duration.Hours >= 1) Or (Interval = "Every Day" And duration.Days >= 1) Or (Interval = "Every Week" And duration.Days >= 7) Or Grid1.get_TextMatrix(i, 11) = "Never" Then
                'is this a database item and is the server connected
                If SQLConnected = True And Grid1.get_TextMatrix(item, 3) = "Database" Then
                    If LogSQL(Grid1.get_TextMatrix(item, 0), Grid1.get_TextMatrix(item, 1), Grid1.get_TextMatrix(item, 4), Grid1.get_TextMatrix(item, 5), oVal(i).ToString, Now().ToString("yyyy-MM-dd hh:mm:ss"), Grid1.get_TextMatrix(item, 13)) Then
                        Grid1.set_TextMatrix(item, 11, Now())
                        Grid1.set_TextMatrix(item, 12, oVal(i))
                        If Grid1.get_TextMatrix(item, 11) = "YES" Then SQLPurgeRequired = True
                    Else
                        'If Grid1.get_TextMatrix(item,)
                    End If


                End If
                ' is this item a CSV item then lets log it 
                If Grid1.get_TextMatrix(item, 3) = "CSV" Or (Grid1.get_TextMatrix(item, 3) = "Database" And SQLConnected = False And Grid1.get_TextMatrix(item, 8) = "YES") Then
                    If LogCSV(Grid1.get_TextMatrix(item, 6), Grid1.get_TextMatrix(item, 0), Grid1.get_TextMatrix(item, 1), oVal(i).ToString, Grid1.get_TextMatrix(item, 13)) Then
                        Grid1.set_TextMatrix(item, 11, Now())
                        Grid1.set_TextMatrix(item, 12, oVal(i))
                    End If
                End If

            End If
        Next
        If SQLConnected = False And NumSqlItems > 0 Then
            SQLStat.Text = "Connecting in " & retrytime
            SQLStat.ForeColor = Color.Red
            If retrytime = 0 Then
                retrytime = 60
                Dim InsertingThread As New System.Threading.Thread(AddressOf ConnectSQL)
                InsertingThread.Start()
            End If
            retrytime = retrytime - 1
        End If
        If SQLConnected = True Then
            If LastSQLConnected = False Then
                SQLStat.Text = "Connected"
                Diagnostics.AppendText(Date.Now & vbTab & "Connected To SQL Server  " & SQLServer.Text & vbCrLf)
                SQLStat.ForeColor = Color.Green
                LastSQLConnected = True
                SQLPurgeRequired = True

            End If
        End If

    End Sub

    Private Sub DisconnectButton_Click(sender As Object, e As EventArgs) Handles DisconnectButton.Click
        Disconnect()

    End Sub


    Sub ConnectSQL()
        Dim ConnStr
        On Error Resume Next
        ConnStr = "Server=" & SQLServer.Text & ";User Id=" & SqlUser.Text & ";Password=" & SqlPass.Text & ";"
        myConn = New SqlConnection(ConnStr)
        'Open the connection.
        LastSQLConnected = False
        myConn.Open()
        If myConn.State = ConnectionState.Open Then
            SQLConnected = True


        Else
            SQLConnected = False

        End If

    End Sub
    Function LogSQL(Name As String, Tag As String, Database As String, Table As String, Value As String, sqldate As String, Units As String)
        Dim sql
        Dim SQLCode
        'On Error Resume Next
        'sqlDate = Now().ToString("yyyy-MM-dd hh:mm:ss")

        sql = "insert into " & Database & ".dbo." & Table & " Values('" & sqldate & "','" & Name & "','" & Tag & "','" & Value & "','" & Units & "')"
        Dim Command = New SqlCommand(sql, myConn)
        Try
            SQLCode = Command.ExecuteNonQuery
            If SQLCode Then Return 1
        Catch ex As Exception
            If InStr(ex.Message, "Invalid object") Then
                sql = "CREATE TABLE " & Database & ".dbo." & Table & " (Date DateTime,Name varchar(255),Tag varchar(255),Value varchar(255),Units varchar(255)); "

                Command.CommandText = sql
                SQLCode = Command.ExecuteNonQuery()
            End If
            If InStr(ex.Message, "closed") Then
                SQLConnected = False
            End If

        End Try


        Return 0

    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error Resume Next
        If ConnectedOPCServer.ServerState = 1 Then
            MsgBox("Please Disconnect Before Editing Items")
        Else
            Dim dlg As Form2 = New Form2(Grid1.Row, 1)
            dlg.ShowDialog()
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        NumSqlItems = 0
        For n = 1 To Grid1.Rows - 1
            Grid1.set_TextMatrix(n, 3, "Database")
            NumSqlItems = NumSqlItems + 1
        Next
        SaveDat()
        Dim InsertingThread As New System.Threading.Thread(AddressOf ConnectSQL)
        InsertingThread.Start()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For n = 1 To Grid1.Rows - 1
            Grid1.set_TextMatrix(n, 3, "CSV")
        Next
        NumSqlItems = 0
        SaveDat()
        If SQLStat.Text <> "Disconnected" Then
            myConn.Close()
            SQLStat.ForeColor = Color.Red
            Diagnostics.AppendText(Date.Now & vbTab & "Disconnected From SQL Server  " & vbCrLf)
            LastSQLConnected = False
            SQLConnected = False
            SQLStat.Text = "Disconnected"

        End If

    End Sub
    Function LogCSV(CSVFileName As String, Name As String, Tag As String, Value As String, Units As String)
        On Error Resume Next
        Dim csvHeader, Csv, fileprefix, opening, closing, tempfilename
        opening = InStr(CSVFileName, "{")
        closing = InStr(CSVFileName, "}")
        If closing - opening - 1 > 0 Then fileprefix = Mid(CSVFileName, opening + 1, closing - opening - 1)
        If Len(fileprefix) > 0 Then
            tempfilename = Microsoft.VisualBasic.Left(CSVFileName, opening - 1)
            fileprefix = Replace(fileprefix, "yyyy", Now.Year)
            fileprefix = Replace(fileprefix, "mm", Format(Now.Month, "00"))
            fileprefix = Replace(fileprefix, "dd", Format(Now.Day, "00"))
            fileprefix = Replace(fileprefix, "/", "-")
            tempfilename = tempfilename & fileprefix & Mid(CSVFileName, closing + 1)

            CSVFileName = tempfilename
        End If


        If My.Computer.FileSystem.FileExists(CSVFileName) = False Then
            csvHeader = "Time,Name,Tag,Value,Units"
            My.Computer.FileSystem.WriteAllText(CSVFileName, csvHeader & vbCrLf, False)
        End If
        csvHeader = Now().ToString("dd/MM/yyyy hh:mm:ss") & "," & Name & "," & Tag & "," & Value & "," & Units
        My.Computer.FileSystem.WriteAllText(CSVFileName, csvHeader & vbCrLf, True)

        Return True
    End Function
    Function Initialise()
        Dim Vars, index
        Dim tfr, StringRead, items()

        OPCServerName.Text = My.Settings.OPCServer
        SQLServer.Text = My.Settings.SQLServer
        SqlUser.Text = My.Settings.SQLUser
        SqlPass.Text = My.Settings.SQLPass
        MoveCSV.Checked = My.Settings.MoveCSV
        CSVDestination.Text = My.Settings.CSVDestination
        CSVRoot.Text = My.Settings.CSVPath
        AutoStart.Checked = My.Settings.AutoStart

        Grid1.Clear()
        Grid1.Rows = 1
        Grid1.Cols = 14
        Grid1.set_TextMatrix(0, 0, "Log Name")
        Grid1.set_TextMatrix(0, 1, "Tag")
        Grid1.set_TextMatrix(0, 2, "Freqency")
        Grid1.set_TextMatrix(0, 3, "Destination")
        Grid1.set_TextMatrix(0, 4, "Database")
        Grid1.set_TextMatrix(0, 5, "Table")
        Grid1.set_TextMatrix(0, 6, "CSV File")
        Grid1.set_TextMatrix(0, 7, "Hour")
        Grid1.set_TextMatrix(0, 8, "Fallback")
        Grid1.set_TextMatrix(0, 9, "Purge")
        Grid1.set_TextMatrix(0, 10, "Last Polled Value")
        Grid1.set_TextMatrix(0, 11, "Last Logged Time")
        Grid1.set_TextMatrix(0, 12, "Last Logged Value")
        Grid1.set_TextMatrix(0, 13, "Units")



        If My.Computer.FileSystem.FileExists("OPCLog.dat") Then
            tfr = My.Computer.FileSystem.OpenTextFileReader("OPCLog.dat")

            StringRead = tfr.ReadLine()
            While tfr.EndOfStream <> True
                StringRead = tfr.ReadLine()
                items = StringRead.Split(",")
                Grid1.AddItem(items(0) & vbTab & items(1) & vbTab & items(2) & vbTab & items(3) & vbTab & items(4) & vbTab & items(5) & vbTab & items(6) & vbTab & items(7) & vbTab & items(8) & vbTab & items(9) & vbTab & "0" & vbTab & "Never" & vbTab & "Never" & vbTab & items(12))
                If items(3) = "Database" Then NumSqlItems = NumSqlItems + 1
            End While
            tfr.Close()
        End If
        ServerStat.Text = "Disconnected"
        SQLStat.Text = "Disconnected"
    End Function

    Function Connect()
        Dim ServerHandles As Array
        Dim Errors As Array
        Dim i, index, tagcount As Integer

        On Error Resume Next
        If OPCServerName.Text <> "" Then


            ConnectedOPCServer.Connect(OPCServerName.Text)
            'Set property for Group connection
            ConnectedOPCServer.OPCGroups.DefaultGroupIsActive = True
            ConnectedOPCServer.OPCGroups.DefaultGroupDeadband = 0
            'Add group
            ConnectedGroup = ConnectedOPCServer.OPCGroups.Add("Group1")
            ConnectedGroup.UpdateRate = 1000
            ConnectedGroup.IsSubscribed = True
            ConnectedGroup.IsActive = False
            'Add items

            tagcount = Grid1.Rows - 1
            index = 1
            For i = 1 To tagcount
                If Grid1.get_TextMatrix(i, 2) <> "Disabled" Then
                    sItemName(index) = Grid1.get_TextMatrix(i, 1)
                    cH(index) = index
                    ItemLines(index) = i
                    index = index + 1
                End If

            Next

            OPCMyItems = ConnectedGroup.OPCItems
            OPCMyItems.AddItems(index - 1, sItemName, cH, ServerHandles, Errors)
            index = 1
            For i = 1 To tagcount
                If Grid1.get_TextMatrix(i, 2) <> "Disabled" Then
                    If Errors(index) = 0 Then
                        sH(index) = ServerHandles(index)

                        index = index + 1
                    Else

                        Grid1.set_TextMatrix(i, 2, "Disabled")

                    End If
                End If

            Next
            If ConnectedOPCServer.ServerState = 1 Then
                ServerStat.Text = "Connected to " & ConnectedOPCServer.ServerName
                ServerStat.ForeColor = Color.Green
                Diagnostics.AppendText(Date.Now & vbTab & "Connected To OPC Server  " & ConnectedOPCServer.ServerName & vbCrLf)
                DisconnectButton.Enabled = True
                ConnectButton.Enabled = False
                Timer1.Interval = 1000
                Timer1.Enabled = True
                If My.Settings.MoveCSV = -1 Then Timer2.Enabled = True
                LastSQLConnected = False
                DisconnectButton.Enabled = True
                ConnectButton.Enabled = False
                If NumSqlItems > 0 Then
                    Dim InsertingThread As New System.Threading.Thread(AddressOf ConnectSQL)
                    InsertingThread.Start()
                End If

            End If



        End If
    End Function
    Function Disconnect()
        DisconnectButton.Enabled = False
        ConnectButton.Enabled = True

        Timer1.Enabled = False
        Timer2.Enabled = False
        If ServerStat.Text <> "Disconnected" Then
            ConnectedOPCServer.Disconnect()

            ServerStat.Text = "Disconnected"
            ServerStat.ForeColor = Color.Red
            Diagnostics.AppendText(Date.Now & vbTab & "Disconnected From OPC Server  " & vbCrLf)
        End If
        If SQLStat.Text <> "Disconnected" Then
            myConn.Close()
            SQLStat.ForeColor = Color.Red
            Diagnostics.AppendText(Date.Now & vbTab & "Disconnected From SQL Server  " & vbCrLf)
            LastSQLConnected = False


        End If

    End Function

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim fd As FolderBrowserDialog = New FolderBrowserDialog()

        If fd.ShowDialog() = DialogResult.OK Then

            CSVDestination.Text = fd.SelectedPath
        End If
    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim fd As FolderBrowserDialog = New FolderBrowserDialog()




        If fd.ShowDialog() = DialogResult.OK Then

            CSVRoot.Text = fd.SelectedPath
        End If
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        On Error Resume Next
        ' timer comment 
        Dim CsvFileName, fileprefix, opening, closing, tempfilename, currentfile, ip, tfr
        Dim StringRead, items, tag, table, itemdate, value, name, Database, Units



        If SQLConnected And SQLPurgeRequired Then
            For Each foundFile In My.Computer.FileSystem.GetFiles(
              My.Settings.CSVPath)

                tfr = My.Computer.FileSystem.OpenTextFileReader(foundFile)
                StringRead = tfr.ReadLine()
                While tfr.EndOfStream <> True
                    StringRead = tfr.ReadLine()
                    items = StringRead.Split(",")
                    itemdate = items(0)
                    name = items(1)
                    tag = items(2)
                    value = items(3)
                    Units = items(12)
                    For n = 1 To Grid1.Rows - 1
                        If tag = Grid1.get_TextMatrix(n, 1) Then
                            Database = Grid1.get_TextMatrix(n, 4)
                            table = Grid1.get_TextMatrix(n, 5)
                            LogSQL(name, tag, Database, table, value, itemdate, Units)
                        End If
                    Next

                End While
                tfr.close()
                My.Computer.FileSystem.DeleteFile(foundFile)



            Next
            SQLPurgeRequired = False

        End If
        For Each foundFile In My.Computer.FileSystem.GetFiles(
  My.Settings.CSVPath)
            currentfile = 0
            For n = 1 To Grid1.Rows - 1
                CsvFileName = Grid1.get_TextMatrix(n, 6)
                'this is a feature branth test

                opening = InStr(CsvFileName, "{")
                closing = InStr(CsvFileName, "}")
                fileprefix = Mid(CsvFileName, opening + 1, closing - opening - 1)
                If Len(fileprefix) > 0 Then

                    tempfilename = Microsoft.VisualBasic.Left(CsvFileName, opening - 1)
                    fileprefix = Replace(fileprefix, "yyyy", Now.Year)
                    fileprefix = Replace(fileprefix, "mm", Format(Now.Month, "00"))
                    fileprefix = Replace(fileprefix, "dd", Format(Now.Day, "00"))
                    fileprefix = Replace(fileprefix, "/", "-")
                    tempfilename = tempfilename & fileprefix & Mid(CsvFileName, closing + 1)

                    CsvFileName = tempfilename


                End If
                If tempfilename = foundFile Then currentfile = 1

            Next
            If currentfile = 0 Then
                If File.Exists(foundFile) Then
                    ip = foundFile.LastIndexOf("\")
                    CsvFileName = Microsoft.VisualBasic.Strings.Right(foundFile, Len(foundFile) - ip)
                    File.Move(foundFile, My.Settings.CSVDestination & CsvFileName)

                End If
            End If

        Next
    End Sub
    Function SaveDat()
        Dim rowtext
        My.Computer.FileSystem.WriteAllText("OPCLog.dat", "Name,Tag,Database,Table,CSV,Freqency,Hour,Destination,FallBack,Purge,Units" & vbCrLf, False)
        For n = 1 To Grid1.Rows - 1
            rowtext = ""
            For a = 0 To Grid1.Cols - 3
                rowtext = rowtext & Grid1.get_TextMatrix(n, a) & ","
            Next

            rowtext = rowtext & Grid1.get_TextMatrix(n, 13)
            My.Computer.FileSystem.WriteAllText("OPCLog.dat", rowtext & vbCrLf, True)
        Next
    End Function

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        NotifyIcon1.Visible = False

        Me.WindowState = FormWindowState.Maximized

        Me.Visible = True
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub



    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        NotifyIcon1.Visible = False

        Me.WindowState = FormWindowState.Maximized

        Me.Visible = True
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        Application.Exit()


    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        Dim foundFile
        FileList.Items.Clear()
        FileList2.Items.Clear()

        For Each foundFile In My.Computer.FileSystem.GetFiles(
             My.Settings.CSVPath)
            FileList.Items.Add(foundFile)
        Next
        For Each foundFile In My.Computer.FileSystem.GetFiles(
            My.Settings.CSVDestination)
            FileList2.Items.Add(foundFile)
        Next
    End Sub

    Private Sub FileList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileList.SelectedIndexChanged
        Dim tfr, StringRead, itemdate, items, value
        FileList2.Text = ""
        ResultsGrid.Clear()
        ResultsGrid.Rows = 1
        ResultsGrid.Cols = 4
        ResultsGrid.set_TextMatrix(0, 0, "Time")
        ResultsGrid.set_TextMatrix(0, 1, "Name")
        ResultsGrid.set_TextMatrix(0, 2, "Tag")
        ResultsGrid.set_TextMatrix(0, 3, "Value")
        ResultsGrid.set_ColWidth(0, 4000)
        ResultsGrid.set_ColWidth(1, 4000)
        ResultsGrid.set_ColWidth(2, 4000)
        ResultsGrid.set_ColWidth(3, 4000)


        tfr = My.Computer.FileSystem.OpenTextFileReader(FileList.Text)
        StringRead = tfr.ReadLine()
        While tfr.EndOfStream <> True
            StringRead = tfr.ReadLine()
            items = StringRead.Split(",")
            itemdate = items(0)
            Name = items(1)
            Tag = items(2)
            value = items(3)
            ResultsGrid.AddItem(itemdate & vbTab & Name & vbTab & Tag & vbTab & value)
        End While
        tfr.Close()


    End Sub

    Private Sub FileList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileList2.SelectedIndexChanged
        Dim tfr, StringRead, itemdate, items, value


        FileList.Text = ""
        ResultsGrid.Clear()
        ResultsGrid.Rows = 1
        ResultsGrid.Cols = 4
        ResultsGrid.set_TextMatrix(0, 0, "Time")
        ResultsGrid.set_TextMatrix(0, 1, "Name")
        ResultsGrid.set_TextMatrix(0, 2, "Tag")
        ResultsGrid.set_TextMatrix(0, 3, "Value")
        ResultsGrid.set_ColWidth(0, 4000)
        ResultsGrid.set_ColWidth(1, 4000)
        ResultsGrid.set_ColWidth(2, 4000)
        ResultsGrid.set_ColWidth(3, 4000)
        ResultsGrid.set_ColAlignment(0, 1)


        tfr = My.Computer.FileSystem.OpenTextFileReader(FileList2.Text)
        StringRead = tfr.ReadLine()
        While tfr.EndOfStream <> True
            StringRead = tfr.ReadLine()
            items = StringRead.Split(",")
            itemdate = items(0)
            Name = items(1)
            Tag = items(2)
            value = items(3)
            ResultsGrid.AddItem(itemdate & vbTab & Name & vbTab & Tag & vbTab & value)
        End While
        tfr.Close()
    End Sub


    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        Dim foundFile
        FileList3.Items.Clear()
        FileList4.Items.Clear()

        For Each foundFile In My.Computer.FileSystem.GetFiles(
             My.Settings.CSVPath)
            FileList3.Items.Add(foundFile)
        Next
        For Each foundFile In My.Computer.FileSystem.GetFiles(
            My.Settings.CSVDestination)
            FileList4.Items.Add(foundFile)
        Next
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileList3.SelectedIndexChanged
        Dim tfr, StringRead, itemdate, items, value
        Dim Taglist(1), notags, foundtag
        notags = 0

        Taglist(0) = ""


        FileList4.Text = ""
        ItemSelect.Items.Clear()
        ItemSelect.Text = ""


        tfr = My.Computer.FileSystem.OpenTextFileReader(FileList3.Text)
        StringRead = tfr.ReadLine()

        While tfr.EndOfStream <> True
            StringRead = tfr.ReadLine()
            items = StringRead.Split(",")
            foundtag = 0
            Name = items(1)
            For n = 0 To notags - 1
                If Name = Taglist(n) Then foundtag = 1
            Next
            If foundtag = 0 Then
                Taglist(notags) = Name
                notags = notags + 1
                ReDim Preserve Taglist(notags)
            End If




        End While
        For n = 0 To notags - 1
            ItemSelect.Items.Add(Taglist(n))

        Next
        tfr.close()

    End Sub

    Private Sub FileList4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileList4.SelectedIndexChanged
        Dim tfr, StringRead, itemdate, items, value
        Dim Taglist(1), notags, foundtag
        notags = 0

        Taglist(0) = ""


        FileList3.Text = ""
        ItemSelect.Text = ""
        ItemSelect.Items.Clear()


        tfr = My.Computer.FileSystem.OpenTextFileReader(FileList4.Text)
        StringRead = tfr.ReadLine()

        While tfr.EndOfStream <> True
            StringRead = tfr.ReadLine()
            items = StringRead.Split(",")
            foundtag = 0
            Name = items(1)
            For n = 0 To notags - 1
                If Name = Taglist(n) Then foundtag = 1
            Next
            If foundtag = 0 Then
                Taglist(notags) = Name
                notags = notags + 1
                ReDim Preserve Taglist(notags)
            End If




        End While
        For n = 0 To notags - 1
            ItemSelect.Items.Add(Taglist(n))

        Next
        tfr.Close()

    End Sub

    Private Sub ItemSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemSelect.SelectedIndexChanged
        Dim Filename, item, tfr, Stringread, items, Value, tm
        Chart1.Series(0).Points.Clear()

        If FileList3.Text <> "" Then Filename = FileList3.Text
        If FileList4.Text <> "" Then Filename = FileList4.Text
        item = ItemSelect.Text
        Chart1.Series(0).LegendText = item
        tfr = My.Computer.FileSystem.OpenTextFileReader(Filename)
        Stringread = tfr.ReadLine()

        While tfr.EndOfStream <> True
            StringRead = tfr.ReadLine()
            items = Stringread.Split(",")
            Name = items(1)
            Value = items(3)
            tm = items(0)
            If Name = ItemSelect.Text Then
                Chart1.Series(0).Points.AddXY(tm, Value)
            End If
        End While
        tfr.close

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim Filename, item, tfr, Stringread, items, Value, tm
        Chart1.Series(0).Points.Clear()
        If FileList3.Text <> "" Then Filename = FileList3.Text
        If FileList4.Text <> "" Then Filename = FileList4.Text
        item = ItemSelect.Text
        Chart1.Series(0).LegendText = item
        If Filename <> "" Then
            tfr = My.Computer.FileSystem.OpenTextFileReader(Filename)
            Stringread = tfr.ReadLine()

            While tfr.EndOfStream <> True
                Stringread = tfr.ReadLine()
                items = Stringread.Split(",")
                Name = items(1)
                tm = items(0)
                Value = items(3)
                If Name = ItemSelect.Text Then

                    Chart1.Series(0).Points.AddXY(tm, Value)

                End If
            End While
            tfr.close
        End If


    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim tfr, StringRead, itemdate, items, value, Filename
        If FileList.Text <> "" Then Filename = FileList.Text
        If FileList2.Text <> "" Then Filename = FileList2.Text

        ResultsGrid.Clear()
        ResultsGrid.Rows = 1
        ResultsGrid.Cols = 4
        ResultsGrid.set_TextMatrix(0, 0, "Time")
        ResultsGrid.set_TextMatrix(0, 1, "Name")
        ResultsGrid.set_TextMatrix(0, 2, "Tag")
        ResultsGrid.set_TextMatrix(0, 3, "Value")
        ResultsGrid.set_ColWidth(0, 4000)
        ResultsGrid.set_ColWidth(1, 4000)
        ResultsGrid.set_ColWidth(2, 4000)
        ResultsGrid.set_ColWidth(3, 4000)

        If Filename <> "" Then
            tfr = My.Computer.FileSystem.OpenTextFileReader(Filename)
            StringRead = tfr.ReadLine()
            While tfr.EndOfStream <> True
                StringRead = tfr.ReadLine()
                items = StringRead.Split(",")
                itemdate = items(0)
                Name = items(1)
                Tag = items(2)
                value = items(3)
                ResultsGrid.AddItem(itemdate & vbTab & Name & vbTab & Tag & vbTab & value)
            End While
            tfr.Close()
        End If

    End Sub
End Class

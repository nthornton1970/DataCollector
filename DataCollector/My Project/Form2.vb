Public Class Form2
    Dim edited As Integer
    Dim newitem As Boolean
    Public Sub New(ByVal ID As String, ByVal newi As Boolean)
        InitializeComponent()
        edited = ID
        newitem = newi
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim fd As SaveFileDialog = New SaveFileDialog()


        fd.Title = "Select CSV File "
        fd.InitialDirectory = My.Settings.CSVPath
        fd.Filter = "(*.CSV)|*.CSV"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then

            CsvFileName.Text = fd.FileName
        End If
    End Sub

    Private Sub AddTag_Click(sender As Object, e As EventArgs) Handles AddTag.Click
        Dim rowtext, rownum
        If edited And newitem = 0 Then
            rownum = edited
        Else
            Form1.Grid1.Rows = Form1.Grid1.Rows + 1
        rownum = Form1.Grid1.Rows - 1
        End If


        Form1.Grid1.set_TextMatrix(rownum, 0, TagName.Text)
        Form1.Grid1.set_TextMatrix(rownum, 1, Tag.Text)
        Form1.Grid1.set_TextMatrix(rownum, 4, SQLDatabase.Text)
        Form1.Grid1.set_TextMatrix(rownum, 5, SQLTable.Text)
        Form1.Grid1.set_TextMatrix(rownum, 6, CsvFileName.Text)
        Form1.Grid1.set_TextMatrix(rownum, 2, LogFreq.Text)
        Form1.Grid1.set_TextMatrix(rownum, 7, LogHour.Text)
        Form1.Grid1.set_TextMatrix(rownum, 11, "Never")
        Form1.Grid1.set_TextMatrix(rownum, 3, IIf(DestSQL.Checked, "Database", "CSV"))
        Form1.Grid1.set_TextMatrix(rownum, 8, IIf(Fallback.Checked, "YES", "NO"))
        Form1.Grid1.set_TextMatrix(rownum, 9, IIf(Purge.Checked, "YES", "NO"))
        Form1.Grid1.set_TextMatrix(rownum, 13, Units.Text)



        My.Computer.FileSystem.WriteAllText("OPCLog.dat", "Name,Tag,Database,Table,CSV,Freqency,Hour,Destination,FallBack,Purge,Units" & vbCrLf, False)
        For n = 1 To Form1.Grid1.Rows - 1
            rowtext = ""
            For a = 0 To Form1.Grid1.Cols - 3
                rowtext = rowtext & Form1.Grid1.get_TextMatrix(n, a) & ","
            Next
            rowtext = rowtext & Form1.Grid1.get_TextMatrix(n, 13)
            ' rowtext = Microsoft.VisualBasic.Left(rowtext, Len(rowtext) - 1)


            My.Computer.FileSystem.WriteAllText("OPCLog.dat", rowtext & vbCrLf, True)
        Next
        If edited > 0 Then Form1.Diagnostics.AppendText(Date.Today & vbTab & "Tag Modified " & vbCrLf)
        If edited = 0 Then Form1.Diagnostics.AppendText(Date.Today & vbTab & "Tag Added" & vbCrLf)

        Me.Close()

    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If edited > 0 Then
            TagName.Text = Form1.Grid1.get_TextMatrix(edited, 0)
            Tag.Text = Form1.Grid1.get_TextMatrix(edited, 1)
            SQLDatabase.Text = Form1.Grid1.get_TextMatrix(edited, 4)
            SQLTable.Text = Form1.Grid1.get_TextMatrix(edited, 5)
            CsvFileName.Text = Form1.Grid1.get_TextMatrix(edited, 6)
            LogFreq.Text = Form1.Grid1.get_TextMatrix(edited, 2)
            LogHour.Text = Form1.Grid1.get_TextMatrix(edited, 7)
            Units.Text = Form1.Grid1.get_TextMatrix(edited, 13)
            DestSQL.Checked = IIf(Form1.Grid1.get_TextMatrix(edited, 3) = "Database", True, False)
            DestCSV.Checked = IIf(Form1.Grid1.get_TextMatrix(edited, 3) = "CSV", False, True)
            Fallback.Checked = IIf(Form1.Grid1.get_TextMatrix(edited, 8) = "YES", True, False)
            Purge.Checked = IIf(Form1.Grid1.get_TextMatrix(edited, 9) = "YES", True, False)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub LogFreq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LogFreq.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class
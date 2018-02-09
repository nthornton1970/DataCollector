<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.CsvFileName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tag = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AddTag = New System.Windows.Forms.Button()
        Me.TagName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SQLDatabase = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SQLTable = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LogFreq = New System.Windows.Forms.ComboBox()
        Me.LogHour = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Purge = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Fallback = New System.Windows.Forms.CheckBox()
        Me.DestCSV = New System.Windows.Forms.RadioButton()
        Me.DestSQL = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Units = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Logging Item"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(594, 178)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(74, 24)
        Me.Button6.TabIndex = 40
        Me.Button6.Text = "Browse"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'CsvFileName
        '
        Me.CsvFileName.Location = New System.Drawing.Point(105, 178)
        Me.CsvFileName.Name = "CsvFileName"
        Me.CsvFileName.Size = New System.Drawing.Size(465, 20)
        Me.CsvFileName.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "CSV File"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Tag"
        '
        'Tag
        '
        Me.Tag.Location = New System.Drawing.Point(105, 66)
        Me.Tag.Name = "Tag"
        Me.Tag.Size = New System.Drawing.Size(465, 20)
        Me.Tag.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Name"
        '
        'AddTag
        '
        Me.AddTag.Location = New System.Drawing.Point(44, 413)
        Me.AddTag.Name = "AddTag"
        Me.AddTag.Size = New System.Drawing.Size(115, 24)
        Me.AddTag.TabIndex = 42
        Me.AddTag.Text = "Save"
        Me.AddTag.UseVisualStyleBackColor = True
        '
        'TagName
        '
        Me.TagName.Location = New System.Drawing.Point(105, 36)
        Me.TagName.Name = "TagName"
        Me.TagName.Size = New System.Drawing.Size(465, 20)
        Me.TagName.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 24)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Database"
        '
        'SQLDatabase
        '
        Me.SQLDatabase.Location = New System.Drawing.Point(105, 124)
        Me.SQLDatabase.Name = "SQLDatabase"
        Me.SQLDatabase.Size = New System.Drawing.Size(465, 20)
        Me.SQLDatabase.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Table"
        '
        'SQLTable
        '
        Me.SQLTable.Location = New System.Drawing.Point(105, 150)
        Me.SQLTable.Name = "SQLTable"
        Me.SQLTable.Size = New System.Drawing.Size(465, 20)
        Me.SQLTable.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Log Frequency"
        '
        'LogFreq
        '
        Me.LogFreq.FormattingEnabled = True
        Me.LogFreq.Items.AddRange(New Object() {"Disabled", "Every Second", "Every Minute", "Every Hour", "Every Day", "Every Week"})
        Me.LogFreq.Location = New System.Drawing.Point(139, 216)
        Me.LogFreq.Name = "LogFreq"
        Me.LogFreq.Size = New System.Drawing.Size(156, 21)
        Me.LogFreq.TabIndex = 52
        Me.LogFreq.Text = "Disabled"
        '
        'LogHour
        '
        Me.LogHour.Location = New System.Drawing.Point(508, 216)
        Me.LogHour.Name = "LogHour"
        Me.LogHour.Size = New System.Drawing.Size(62, 20)
        Me.LogHour.TabIndex = 53
        Me.LogHour.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Purge)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Fallback)
        Me.GroupBox1.Controls.Add(Me.DestCSV)
        Me.GroupBox1.Controls.Add(Me.DestSQL)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 258)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 123)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Destination"
        '
        'Purge
        '
        Me.Purge.AutoSize = True
        Me.Purge.Location = New System.Drawing.Point(254, 91)
        Me.Purge.Name = "Purge"
        Me.Purge.Size = New System.Drawing.Size(139, 17)
        Me.Purge.TabIndex = 64
        Me.Purge.Text = "Purge CSV to Database"
        Me.Purge.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(251, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(329, 39)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "If Sql Server is Selected then Select if you want to fallback to CSV" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IF FallBack" &
    " is Selected , then Select if you want to update Database" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " on connection Re-Est" &
    "ablished" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Fallback
        '
        Me.Fallback.AutoSize = True
        Me.Fallback.Location = New System.Drawing.Point(254, 68)
        Me.Fallback.Name = "Fallback"
        Me.Fallback.Size = New System.Drawing.Size(107, 17)
        Me.Fallback.TabIndex = 62
        Me.Fallback.Text = "FallBack To CSV"
        Me.Fallback.UseVisualStyleBackColor = True
        '
        'DestCSV
        '
        Me.DestCSV.AutoSize = True
        Me.DestCSV.Checked = True
        Me.DestCSV.Location = New System.Drawing.Point(145, 16)
        Me.DestCSV.Name = "DestCSV"
        Me.DestCSV.Size = New System.Drawing.Size(65, 17)
        Me.DestCSV.TabIndex = 61
        Me.DestCSV.TabStop = True
        Me.DestCSV.Text = "CSV File"
        Me.DestCSV.UseVisualStyleBackColor = True
        '
        'DestSQL
        '
        Me.DestSQL.AutoSize = True
        Me.DestSQL.Location = New System.Drawing.Point(65, 16)
        Me.DestSQL.Name = "DestSQL"
        Me.DestSQL.Size = New System.Drawing.Size(74, 17)
        Me.DestSQL.TabIndex = 60
        Me.DestSQL.Text = "Sql Server"
        Me.DestSQL.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(445, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Base Hour"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(353, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(218, 26)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "For Daily logged items select the hour of day " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Units"
        '
        'Units
        '
        Me.Units.Location = New System.Drawing.Point(105, 92)
        Me.Units.Name = "Units"
        Me.Units.Size = New System.Drawing.Size(465, 20)
        Me.Units.TabIndex = 66
        '
        'Form2
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 453)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Units)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LogHour)
        Me.Controls.Add(Me.LogFreq)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SQLTable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SQLDatabase)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Tag)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AddTag)
        Me.Controls.Add(Me.TagName)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.CsvFileName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = " Logged Tag"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents CsvFileName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Tag As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AddTag As Button
    Friend WithEvents TagName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents SQLDatabase As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SQLTable As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LogFreq As ComboBox
    Friend WithEvents LogHour As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Purge As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Fallback As CheckBox
    Friend WithEvents DestCSV As RadioButton
    Friend WithEvents DestSQL As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Units As TextBox
End Class

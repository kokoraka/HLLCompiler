<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.RichTextBoxSource = New System.Windows.Forms.RichTextBox()
        Me.ButtonScanner = New System.Windows.Forms.Button()
        Me.ButtonParser = New System.Windows.Forms.Button()
        Me.ComboBoxLanguage = New System.Windows.Forms.ComboBox()
        Me.ProgressBarLoader = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelSourceCode = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerLoader = New System.Windows.Forms.Timer(Me.components)
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.RichTextBoxResult = New System.Windows.Forms.RichTextBox()
        Me.ButtonCopy = New System.Windows.Forms.Button()
        Me.ComboBoxTestCase = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBoxShowLog = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStepByStep = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBoxSource
        '
        Me.RichTextBoxSource.Location = New System.Drawing.Point(12, 97)
        Me.RichTextBoxSource.Name = "RichTextBoxSource"
        Me.RichTextBoxSource.Size = New System.Drawing.Size(353, 352)
        Me.RichTextBoxSource.TabIndex = 0
        Me.RichTextBoxSource.Text = ""
        '
        'ButtonScanner
        '
        Me.ButtonScanner.Location = New System.Drawing.Point(12, 455)
        Me.ButtonScanner.Name = "ButtonScanner"
        Me.ButtonScanner.Size = New System.Drawing.Size(86, 33)
        Me.ButtonScanner.TabIndex = 2
        Me.ButtonScanner.Text = "&Scan"
        Me.ButtonScanner.UseVisualStyleBackColor = True
        '
        'ButtonParser
        '
        Me.ButtonParser.Location = New System.Drawing.Point(104, 455)
        Me.ButtonParser.Name = "ButtonParser"
        Me.ButtonParser.Size = New System.Drawing.Size(86, 33)
        Me.ButtonParser.TabIndex = 3
        Me.ButtonParser.Text = "&Parse"
        Me.ButtonParser.UseVisualStyleBackColor = True
        '
        'ComboBoxLanguage
        '
        Me.ComboBoxLanguage.AutoCompleteCustomSource.AddRange(New String() {"Pascal", "C", "C++"})
        Me.ComboBoxLanguage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxLanguage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLanguage.FormattingEnabled = True
        Me.ComboBoxLanguage.Items.AddRange(New Object() {"Pascal", "C", "C++"})
        Me.ComboBoxLanguage.Location = New System.Drawing.Point(12, 47)
        Me.ComboBoxLanguage.Name = "ComboBoxLanguage"
        Me.ComboBoxLanguage.Size = New System.Drawing.Size(212, 21)
        Me.ComboBoxLanguage.TabIndex = 4
        '
        'ProgressBarLoader
        '
        Me.ProgressBarLoader.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBarLoader.Location = New System.Drawing.Point(0, 494)
        Me.ProgressBarLoader.Name = "ProgressBarLoader"
        Me.ProgressBarLoader.Size = New System.Drawing.Size(735, 14)
        Me.ProgressBarLoader.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Choose Language"
        '
        'LabelSourceCode
        '
        Me.LabelSourceCode.AutoSize = True
        Me.LabelSourceCode.Location = New System.Drawing.Point(12, 81)
        Me.LabelSourceCode.Name = "LabelSourceCode"
        Me.LabelSourceCode.Size = New System.Drawing.Size(69, 13)
        Me.LabelSourceCode.TabIndex = 7
        Me.LabelSourceCode.Text = "Source Code"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScanToolStripMenuItem, Me.ParseToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ScanToolStripMenuItem
        '
        Me.ScanToolStripMenuItem.Name = "ScanToolStripMenuItem"
        Me.ScanToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ScanToolStripMenuItem.Text = "Scan"
        '
        'ParseToolStripMenuItem
        '
        Me.ParseToolStripMenuItem.Name = "ParseToolStripMenuItem"
        Me.ParseToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ParseToolStripMenuItem.Text = "Parse"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LicenseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.LicenseToolStripMenuItem.Text = "License"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TimerLoader
        '
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(368, 81)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(37, 13)
        Me.LabelResult.TabIndex = 10
        Me.LabelResult.Text = "Result"
        '
        'RichTextBoxResult
        '
        Me.RichTextBoxResult.Location = New System.Drawing.Point(371, 97)
        Me.RichTextBoxResult.Name = "RichTextBoxResult"
        Me.RichTextBoxResult.ReadOnly = True
        Me.RichTextBoxResult.Size = New System.Drawing.Size(353, 352)
        Me.RichTextBoxResult.TabIndex = 11
        Me.RichTextBoxResult.Text = ""
        '
        'ButtonCopy
        '
        Me.ButtonCopy.Location = New System.Drawing.Point(637, 455)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(86, 33)
        Me.ButtonCopy.TabIndex = 12
        Me.ButtonCopy.Text = "&Copy"
        Me.ButtonCopy.UseVisualStyleBackColor = True
        '
        'ComboBoxTestCase
        '
        Me.ComboBoxTestCase.AutoCompleteCustomSource.AddRange(New String() {"Test 1 - Variable Change Program", "Test 2 - Sorting Program"})
        Me.ComboBoxTestCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTestCase.FormattingEnabled = True
        Me.ComboBoxTestCase.Items.AddRange(New Object() {"Test 1 - Variable Change Program", "Test 2 - Date Count Program", "Test 3 - Bubble Sort Program"})
        Me.ComboBoxTestCase.Location = New System.Drawing.Point(230, 47)
        Me.ComboBoxTestCase.Name = "ComboBoxTestCase"
        Me.ComboBoxTestCase.Size = New System.Drawing.Size(212, 21)
        Me.ComboBoxTestCase.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Choose Test Case"
        '
        'CheckBoxShowLog
        '
        Me.CheckBoxShowLog.AutoSize = True
        Me.CheckBoxShowLog.Enabled = False
        Me.CheckBoxShowLog.Location = New System.Drawing.Point(465, 49)
        Me.CheckBoxShowLog.Name = "CheckBoxShowLog"
        Me.CheckBoxShowLog.Size = New System.Drawing.Size(44, 17)
        Me.CheckBoxShowLog.TabIndex = 15
        Me.CheckBoxShowLog.Text = "Log"
        Me.CheckBoxShowLog.UseVisualStyleBackColor = True
        '
        'CheckBoxStepByStep
        '
        Me.CheckBoxStepByStep.AutoSize = True
        Me.CheckBoxStepByStep.Enabled = False
        Me.CheckBoxStepByStep.Location = New System.Drawing.Point(515, 49)
        Me.CheckBoxStepByStep.Name = "CheckBoxStepByStep"
        Me.CheckBoxStepByStep.Size = New System.Drawing.Size(87, 17)
        Me.CheckBoxStepByStep.TabIndex = 16
        Me.CheckBoxStepByStep.Text = "Step by Step"
        Me.CheckBoxStepByStep.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        Me.OpenFileDialog.Title = "Choose source code"
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(196, 455)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(86, 33)
        Me.ButtonClear.TabIndex = 17
        Me.ButtonClear.Text = "&Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'ToolsToolStripMenuItem1
        '
        Me.ToolsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScanToolStripMenuItem1, Me.ParseToolStripMenuItem1})
        Me.ToolsToolStripMenuItem1.Name = "ToolsToolStripMenuItem1"
        Me.ToolsToolStripMenuItem1.Size = New System.Drawing.Size(102, 22)
        Me.ToolsToolStripMenuItem1.Text = "Tools"
        '
        'ScanToolStripMenuItem1
        '
        Me.ScanToolStripMenuItem1.Name = "ScanToolStripMenuItem1"
        Me.ScanToolStripMenuItem1.Size = New System.Drawing.Size(102, 22)
        Me.ScanToolStripMenuItem1.Text = "Scan"
        '
        'ParseToolStripMenuItem1
        '
        Me.ParseToolStripMenuItem1.Name = "ParseToolStripMenuItem1"
        Me.ParseToolStripMenuItem1.Size = New System.Drawing.Size(102, 22)
        Me.ParseToolStripMenuItem1.Text = "Parse"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(102, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LicenseToolStripMenuItem1, Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'LicenseToolStripMenuItem1
        '
        Me.LicenseToolStripMenuItem1.Name = "LicenseToolStripMenuItem1"
        Me.LicenseToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.LicenseToolStripMenuItem1.Text = "License"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.HelpToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(735, 24)
        Me.MenuStrip.TabIndex = 9
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 508)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.CheckBoxStepByStep)
        Me.Controls.Add(Me.CheckBoxShowLog)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxTestCase)
        Me.Controls.Add(Me.ButtonCopy)
        Me.Controls.Add(Me.RichTextBoxResult)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.LabelSourceCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBarLoader)
        Me.Controls.Add(Me.ComboBoxLanguage)
        Me.Controls.Add(Me.ButtonParser)
        Me.Controls.Add(Me.ButtonScanner)
        Me.Controls.Add(Me.RichTextBoxSource)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "High Level Language Scanner & Parser"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBoxSource As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonScanner As System.Windows.Forms.Button
    Friend WithEvents ButtonParser As System.Windows.Forms.Button
    Friend WithEvents ComboBoxLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents ProgressBarLoader As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelSourceCode As System.Windows.Forms.Label
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LicenseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerLoader As System.Windows.Forms.Timer
    Friend WithEvents LabelResult As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxResult As System.Windows.Forms.RichTextBox
    Friend WithEvents ScanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonCopy As System.Windows.Forms.Button
    Friend WithEvents ComboBoxTestCase As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxShowLog As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxStepByStep As System.Windows.Forms.CheckBox
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LicenseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ScanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class

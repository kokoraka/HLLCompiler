﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ButtonScanner = New System.Windows.Forms.Button()
        Me.ButtonParser = New System.Windows.Forms.Button()
        Me.ComboBoxLanguage = New System.Windows.Forms.ComboBox()
        Me.ProgressBarLoader = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerLoader = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 111)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(324, 274)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'ButtonScanner
        '
        Me.ButtonScanner.Location = New System.Drawing.Point(12, 406)
        Me.ButtonScanner.Name = "ButtonScanner"
        Me.ButtonScanner.Size = New System.Drawing.Size(86, 33)
        Me.ButtonScanner.TabIndex = 2
        Me.ButtonScanner.Text = "&Scan"
        Me.ButtonScanner.UseVisualStyleBackColor = True
        '
        'ButtonParser
        '
        Me.ButtonParser.Location = New System.Drawing.Point(104, 406)
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
        Me.ComboBoxLanguage.Location = New System.Drawing.Point(12, 55)
        Me.ComboBoxLanguage.Name = "ComboBoxLanguage"
        Me.ComboBoxLanguage.Size = New System.Drawing.Size(244, 21)
        Me.ComboBoxLanguage.TabIndex = 4
        '
        'ProgressBarLoader
        '
        Me.ProgressBarLoader.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBarLoader.Location = New System.Drawing.Point(0, 455)
        Me.ProgressBarLoader.Name = "ProgressBarLoader"
        Me.ProgressBarLoader.Size = New System.Drawing.Size(675, 14)
        Me.ProgressBarLoader.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Choose Language"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Program Code"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(675, 24)
        Me.MenuStrip.TabIndex = 9
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScanToolStripMenuItem, Me.ParseToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LicenseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Result"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(342, 111)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(324, 274)
        Me.RichTextBox3.TabIndex = 11
        Me.RichTextBox3.Text = ""
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 469)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBarLoader)
        Me.Controls.Add(Me.ComboBoxLanguage)
        Me.Controls.Add(Me.ButtonParser)
        Me.Controls.Add(Me.ButtonScanner)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "High Level Language Scanner & Parser"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonScanner As System.Windows.Forms.Button
    Friend WithEvents ButtonParser As System.Windows.Forms.Button
    Friend WithEvents ComboBoxLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents ProgressBarLoader As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LicenseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerLoader As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents ScanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

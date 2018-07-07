Public Class MainForm

    Dim SourceCode As String

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerLoader.Enabled = True
        ComboBoxLanguage.Text = "Pascal"
    End Sub

    Private Sub TimerLoader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerLoader.Tick
        If (ProgressBarLoader.Value < 100) Then
            ProgressBarLoader.Value += 1
        Else
            TimerLoader.Enabled = False
            ProgressBarLoader.Value = 0
        End If
    End Sub

    Private Sub ScanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanToolStripMenuItem.Click
        ButtonScanner.PerformClick()
    End Sub

    Private Sub ParseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParseToolStripMenuItem.Click
        ButtonParser.PerformClick()
    End Sub

    Private Sub ButtonScanner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonScanner.Click
        If (validateInput()) Then
            SourceCode = RichTextBoxSource.Text
            RichTextBoxResult.Text = scanInput(SourceCode)
        End If
    End Sub

    Private Sub ButtonParser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonParser.Click
        If (validateInput()) Then

        End If
    End Sub

    Private Sub ButtonCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCopy.Click
        If (RichTextBoxResult.Text <> "") Then
            Clipboard.SetText(RichTextBoxResult.Text)
            MsgBox("Result copied to clipboard", MsgBoxStyle.Information, "Gurisa Devs")
        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.OpenFileDialog.Filter = "Pascal Source Code (*.pas)|*.pas|Text Documents (*.txt)|*.txt"
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBoxSource.LoadFile(OpenFileDialog.FileName, RichTextBoxStreamType.PlainText)
            LabelSourceCode.Text = "Source Code: " & System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        RichTextBoxSource.Text = ""
        LabelSourceCode.Text = "Source Code"
    End Sub

    Private Sub ComboBoxTestCase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTestCase.SelectedIndexChanged
        RichTextBoxSource.Text = testCase(ComboBoxTestCase.SelectedIndex + 1)
    End Sub

    Private Sub ScanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanToolStripMenuItem1.Click
        ButtonScanner.PerformClick()
    End Sub

    Private Sub ParseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParseToolStripMenuItem1.Click
        ButtonParser.PerformClick()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        If (MsgBox("Are you sure want to close the HLLCompiler?", MsgBoxStyle.YesNo, "Gurisa Devs") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutForm.Show()
    End Sub

    Private Sub LicenseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LicenseToolStripMenuItem1.Click
        MsgBox("Copyrighted (c) Gurisa.Com", MsgBoxStyle.Information, "Gurisa Devs")
    End Sub
End Class

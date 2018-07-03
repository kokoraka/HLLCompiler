Public Class MainForm

    Dim SourceCode As String

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If (MsgBox("Are you sure want to close the HLLCompiler?", MsgBoxStyle.YesNo, "Gurisa Devs") = vbOK) Then
            Me.Close()
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
    End Sub

    Private Sub LicenseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LicenseToolStripMenuItem.Click
        MsgBox("Copyrighted (c) Gurisa.Com", MsgBoxStyle.Information, "Gurisa Devs")
    End Sub

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
            SourceCode = RichTextBoxSource.Text.ToLower

            RichTextBoxResult.Text = SourceCode
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

End Class

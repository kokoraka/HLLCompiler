Public Class MainForm

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
    End Sub

    Private Sub LicenseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LicenseToolStripMenuItem.Click
        MsgBox("Copyrighted (c) Gurisa.Com", MsgBoxStyle.Information, "Gurisa Devs")
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerLoader.Enabled = True
    End Sub

    Private Sub TimerLoader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerLoader.Tick
        If (ProgressBarLoader.Value < 100) Then
            ProgressBarLoader.Value += 1
        Else
            TimerLoader.Enabled = False
            ProgressBarLoader.Value = 0
        End If
    End Sub
End Class

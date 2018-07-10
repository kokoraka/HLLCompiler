Public Class MainForm

    Dim SourceCode As String

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerLoader.Enabled = True
        ComboBoxLanguage.SelectedIndex = 0
        ComboBoxTestCase.SelectedIndex = 0
        ComboBoxResultMode.SelectedIndex = 1
        RichTextBoxResult.Visible = False
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
            DataGridViewResult.Rows.Clear()

            Dim construct As String = ""
            Dim result = scanInput(SourceCode).Select(Function(x) New String() {x.Item1, x.Item2, x.Item3, x.Item4}).ToArray()

            For Each data As String() In result
                construct &= "[" & data(0) & ", " & data(1) & "] "
                construct &= data(2) & " = "
                construct &= data(3) & vbCrLf
                DataGridViewResult.Rows.Add(If(data(1) = data(0), 1, data(1) - If(data(0) = 0, 1, data(0))), data(2), data(3))
            Next

            RichTextBoxResult.Text = construct
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
        DataGridViewResult.Rows.Clear()
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

    Private Sub ComboBoxResultMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxResultMode.SelectedIndexChanged
        If (ComboBoxResultMode.Text = "Text Mode") Then
            RichTextBoxResult.Visible = True
            DataGridViewResult.Visible = False
        ElseIf (ComboBoxResultMode.Text = "Table Mode") Then
            DataGridViewResult.Visible = True
            RichTextBoxResult.Visible = False
        End If
    End Sub

End Class

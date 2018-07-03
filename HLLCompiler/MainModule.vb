Module MainModule

    Public Function testCase(ByVal test) As String
        If (test = 1) Then

        End If
        Return ""
    End Function

    Public Function validateInput() As Boolean
        If (MainForm.ComboBoxLanguage.Text <> "Pascal") Then
            MsgBox("Sorry, we currently support only pascal language", MsgBoxStyle.Exclamation, "Gurisa Devs")
            Return False
        Else
            If (MainForm.RichTextBoxSource.TextLength = 0) Then
                MsgBox("Please place source code program", MsgBoxStyle.Exclamation, "Gurisa Devs")
                Return False
            End If
        End If

        Return True
    End Function

    Public Function scanInput() As String
        Return ""
    End Function

    Public Function parseInput() As String
        Return ""
    End Function

End Module

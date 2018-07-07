Imports System.Text.RegularExpressions

Module MainPascalModule

    Public Function testCase(ByVal test) As String
        If (test = 1) Then
            Return My.Resources.menukar_variabel_xyz.ToString
        ElseIf (test = 2) Then
            Return My.Resources.jumlah_tahun_bulan_hari.ToString
        ElseIf (test = 3) Then
            Return My.Resources.bubble_sort_data_array.ToString
        End If
        Return "Invalid Test Case"
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

    Public Function removeComments(ByVal data As String) As String
        Return Regex.Replace(data, "{([\w\r\n\t.,:() ])*}", "")
    End Function

    Public Function removeSpaces(ByVal data As String) As String
        Return data.Trim
    End Function

    Public Function removeLines(ByVal data As String) As String
        Return Regex.Replace(data, System.Environment.NewLine, "")
    End Function

    Public Function getKeywords() As Array
        Return My.Resources.keywords_pascal.ToString.ToLower.Split(System.Environment.NewLine)
    End Function

    Public Function scanInput(ByVal data As String) As String
        Dim keywords() As String = getKeywords()
        Dim sourceCode() As String

        Dim result As String = ""
        Dim index As Integer = 0

        data = removeComments(data)
        data = removeLines(data)
        data = removeSpaces(data)

        sourceCode = data.ToString.ToLower.Split(" ")

        For Each code As String In sourceCode
            index = index + 1
            result &= "[" & index & "] " & removeSpaces(code) & vbCrLf
        Next

        'For Each keyword As String In keywords
        'index = index + 1
        'result &= "[" & index & "] " & removeSpaces(keyword) & vbCrLf
        'Next

        Return data
    End Function

    Public Function parseInput() As String
        Return ""
    End Function

End Module

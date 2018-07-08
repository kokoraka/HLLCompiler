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

    Public Function writeCode(ByVal data As String, ByVal low As Integer, ByVal high As Integer) As String
        Dim result As String = ""
        If (low >= 0 And high < data.Length) Then
            For i As Integer = low To high
                result &= data(i)
            Next
        End If
        Return result
    End Function

    Public Function compare(ByVal a, ByVal b) As Boolean
        Return (a = b)
    End Function

    Public Function scanInput(ByVal data As String) As String
        Dim sourceCode As String = data
        Dim keywords() As String = getKeywords()
        Dim alphabets() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_".ToCharArray()
        Dim numbers() As Char = "0123456789".ToCharArray()
        Dim operators() As String = {"+", "-", "*", "/", ":=", "<", ">", "<=", ">=", "=", "<>"}
        Dim delimiters() As Char = "()[]^:;,.".ToCharArray()
        Dim token As String = ""
        Dim result As String = ""
        Dim i, j As Integer

        For i = 0 To data.Length - 1
            If (data(i) = "{") Then 'Komentar
                j = If(i < data.Length, i + 1, i)
                Do Until (data(j) = "}" And j < data.Length)
                    j += 1
                Loop
                token = writeCode(data, i, j) & " = Komentar"
                result &= token & vbCrLf
                i = j
            End If

            If (data(i) = "'") Then 'Petik Satu
                j = If(i < data.Length, i + 1, i)
                Do Until (data(j) = "'" And j < data.Length)
                    j += 1
                Loop
                token = writeCode(data, i, j) & " = Konstanta"
                result &= token & vbCrLf
                i = j
            End If

            If (Array.Exists(alphabets, Function(s) s = data(i))) Then 'Alphabet dan Underscore | Keywords
                j = If(i < data.Length, i + 1, i)
                Do Until (Not Array.Exists(alphabets, Function(s) s = data(j)) And j < data.Length)
                    j += 1
                Loop
                token = writeCode(data, i, j) & " = Variabel"
                result &= token & vbCrLf
                i = j
                'cek apakah keyword atau bukan juga
            End If

            If (Array.Exists(numbers, Function(s) s = data(i))) Then 'Bilangan
                j = If(i < data.Length, i + 1, i)
                Do Until (Not Array.Exists(numbers, Function(s) s = data(j)) And j < data.Length)
                    j += 1
                Loop
                token = writeCode(data, i, j) & " = Bilangan"
                result &= token & vbCrLf
                i = j
            End If

            If (Array.Exists(operators, Function(s) s = data(i))) Then 'Operator
                j = If(i < data.Length, i + 1, i)
                Do Until (Not Array.Exists(operators, Function(s) s = data(j)) And j < data.Length)
                    j += 1
                Loop
                token = writeCode(data, i, j) & " = Operator"
                result &= token & vbCrLf
                i = j
            End If

            If (Array.Exists(delimiters, Function(s) s = data(i))) Then 'Delimiter
                j = If(i < data.Length, i + 1, i)
                Do Until (Not Array.Exists(delimiters, Function(s) s = data(j)) And j < data.Length)
                    j += 1
                Loop
                token = writeCode(data, i, j) & " = Delimiter"
                result &= token & vbCrLf
                i = j
            End If

        Next

        Return result
    End Function

    Public Function parseInput() As String
        Return ""
    End Function

End Module

Imports System.Text.RegularExpressions

Module MainPascalModule
    Dim alphabets() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_".ToCharArray()
    Dim numbers() As Char = "0123456789".ToCharArray()
    Dim operators() As String = {"+", "-", "*", "/", ":=", "<", ">", "<=", ">=", "=", "<>"}
    Dim delimiters() As Char = "()[]^:;,.".ToCharArray()

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

    Public Function inRange(ByVal range As Array, ByVal data As String) As Boolean
        For i As Integer = 0 To range.Length - 1
            If (range(i) = removeLines(data.Trim)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function isKeyword(ByVal data As String) As Boolean
        Dim keywords() As String = getKeywords()
        For i As Integer = 0 To keywords.Length - 1
            If (removeLines(keywords(i).Trim) = removeLines(data.Trim)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function scanInput(ByVal source As String) As List(Of Tuple(Of Integer, Integer, String, String))
        Dim word As String = ""
        Dim scanResult As New List(Of Tuple(Of Integer, Integer, String, String))
        Dim i As Integer = 0
        Dim j As Integer = 0

        Dim data() As Char = source.ToCharArray()

        Do While (i < data.Length - 1)
            If (data(i) = "{") Then 'Komentar
                j = If(i + 1 < data.Length, i + 1, i)
                Do While (data(j) <> "}" And j < data.Length - 1)
                    j += 1
                Loop
                scanResult.Add(Tuple.Create(i, j, writeCode(data, i, j), "Komentar"))
                i = j
            End If

            If (data(i) = "'") Then 'Petik Satu
                j = If(i + 1 < data.Length, i + 1, i)
                Do While (data(j) <> "'" And j < data.Length - 1)
                    j += 1
                Loop
                scanResult.Add(Tuple.Create(i, j, writeCode(data, i, j), "Konstanta"))
                i = j
            End If

            If (inRange(alphabets, data(i))) Then 'Alphabet dan Underscore | Keywords
                j = i
                Do While (inRange(alphabets, data(j)) And j < data.Length - 1)
                    word &= data(j)
                    j += 1
                Loop
                scanResult.Add(Tuple.Create(i, j - 1, writeCode(data, i, j - 1), If(isKeyword(word), "Keyword", "Variabel")))
                i = j
                word = ""
            End If

            If (Array.Exists(numbers, Function(s) s = data(i))) Then 'Bilangan
                j = i
                Do While (Array.Exists(numbers, Function(s) s = data(j)) And j < data.Length - 1)
                    j += 1
                Loop
                scanResult.Add(Tuple.Create(i, j - 1, writeCode(data, i, j - 1), "Bilangan"))
                i = j
            End If

            If (Array.Exists(operators, Function(s) s = data(i))) Then 'Operator
                j = i
                Do While (Array.Exists(operators, Function(s) s = data(j)) And j < data.Length - 1)
                    j += 1
                Loop
                scanResult.Add(Tuple.Create(i, j, writeCode(data, i, j - 1), "Operator"))
                i = j
            End If

            If (Array.Exists(delimiters, Function(s) s = data(i))) Then 'Delimiter
                scanResult.Add(Tuple.Create(i, i, writeCode(data, i, i), "Delimiter"))
            End If
            i += 1
        Loop

        Return scanResult
    End Function

    Public Function parseInput() As String
        Return ""
    End Function

End Module

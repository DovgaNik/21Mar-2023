Public Class Form1

    Public nmDigits, nmConsonants, nmVowels, nmOther As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String
        str = TextBox1.Text

        Dim words As String()
        Dim separators As Char() = " ,.?/\|}{[]/*+-=&^%$#@!" + vbNewLine
        words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries)

        Dim word As String
        Dim formList As New Form3

        For Each word In words
            formList.ListBox1.Items.Add(word)
        Next
        formList.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        nmDigits = 0
        nmConsonants = 0
        nmConsonants = 0
        nmOther = 0
        Dim str As String
        Dim chr As Char

        str = TextBox1.Text
        For index = 0 To str.Length - 1
            chr = str(index)
            Select Case chr
                Case "1" To "9"
                    nmDigits += 1
                Case "A", "E", "I", "O", "U", "a", "e", "i", "u", "o"
                    nmVowels += 1
                Case "A" To "z"
                    nmConsonants += 1
                Case Else
                    nmOther += 1
            End Select
        Next

        Dim form2 As New Form2
        form2.ShowDialog()


    End Sub
End Class

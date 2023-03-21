Public Class Form3
    Dim amount As Integer

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item As String
        Dim longestItem As String
        Dim longest As Integer = 0
        For Each item In ListBox1.Items
            If item.Length > longest Then
                longest = item.Length
                longestItem = item
            End If
        Next
        Label1.Text = "The amount of words is: " + ListBox1.Items.Count.ToString + ", the longest word is " + longestItem
    End Sub
End Class
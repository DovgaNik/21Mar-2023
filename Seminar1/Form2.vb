Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.nmDigits.ToString
        TextBox2.Text = Form1.nmVowels.ToString
        TextBox3.Text = Form1.nmConsonants.ToString
        TextBox4.Text = Form1.nmOther.ToString
    End Sub
End Class
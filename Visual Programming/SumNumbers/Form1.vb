Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number1 As Integer
        Dim number2 As Integer
        Dim answer As Integer

        number1 = Val(txtNumber1.Text)
        number2 = Val(txtNumber2.Text)

        answer = number1 + number2

        ' MessageBox.Show(answer) show the message like tooltip

        Label3.Text = (answer)

    End Sub
End Class

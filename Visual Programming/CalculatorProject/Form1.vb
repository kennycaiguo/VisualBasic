Public Class calculator
    'DECLARE THE VARIABLES'
    Dim result As Integer
    Dim number As Integer

    ' CODE FOR THE EQUALS BUTTON '
    Private Sub btn_equals_Click(sender As Object, e As EventArgs) Handles btn_equals.Click
        result = number + Val(txtDisplay.Text)
        txtDisplay.Text = result

    End Sub

    'CODE FOR THE PLUS BUTTON ' 
    Private Sub btn_sum_Click(sender As Object, e As EventArgs) Handles btn_sum.Click
        number = number + Val(txtDisplay.Text)
        txtDisplay.Clear()
    End Sub

    ' CODE FOR THE CLEAR BUTTON ' 
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        txtDisplay.Clear()
    End Sub

    ' CODE FOR THE 0-9 BUTTON '
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtDisplay.Text = txtDisplay.Text & btn0.Text
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtDisplay.Text = txtDisplay.Text & btn1.Text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtDisplay.Text = txtDisplay.Text & btn2.Text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtDisplay.Text = txtDisplay.Text & btn3.Text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtDisplay.Text = txtDisplay.Text & btn4.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtDisplay.Text = txtDisplay.Text & btn5.Text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtDisplay.Text = txtDisplay.Text & btn6.Text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtDisplay.Text = txtDisplay.Text & btn7.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtDisplay.Text = txtDisplay.Text & btn8.Text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtDisplay.Text = txtDisplay.Text & btn9.Text
    End Sub
End Class

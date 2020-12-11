Public Class frmVariables
    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        Dim LabelContents As String
        Dim TextBoxContents As String

        TextBoxContents = txtVariables.Text
        LabelTransfer.Text = TextBoxContents

        ' LabelContents = LabelTransfer.Text 'label in the form
        'txtVariables.Text = LabelContents 'textbox in the form


    End Sub
End Class

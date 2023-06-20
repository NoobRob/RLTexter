Public Class Form1
    Private Sub tbSpeed_Scroll(sender As Object, e As EventArgs) Handles tbSpeed.Scroll
        mtbSpeed.Text = tbSpeed.Value
    End Sub

    Private Sub mtbSpeed_TextChanged(sender As Object, e As EventArgs) Handles mtbSpeed.TextChanged
        If mtbSpeed.Text = "" Then
            tbSpeed.Value = 0
        Else
            tbSpeed.Value = mtbSpeed.Text
        End If

    End Sub

    Private Sub cmdGo_Click(sender As Object, e As EventArgs) Handles cmdGo.Click
        Content = txtText.Text
        Speed = tbSpeed.Value

        Dim r As New frmText
        r.ShowDialog()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class frmText

    Private texter As RLTexter



    Private Sub frmText_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click

        Content = Content.Replace("  ", " ").Replace(vbCrLf, " ")

        texter = New RLTexter(Content.Split(" "), lblText, lblstatus)
        tbSpeed.Value = Speed
        texter.Start(Speed)
    End Sub

    Private Sub cmdPause_Click(sender As Object, e As EventArgs) Handles cmdPause.Click
        texter.StopAnimation()
    End Sub

    Private Sub tbSpeed_Scroll(sender As Object, e As EventArgs) Handles tbSpeed.Scroll
        texter.UpdateInterval(tbSpeed.Value)

    End Sub

    Private Sub lblstatus_Click(sender As Object, e As EventArgs) Handles lblstatus.Click
        Me.Text = lblstatus.Text
    End Sub
End Class
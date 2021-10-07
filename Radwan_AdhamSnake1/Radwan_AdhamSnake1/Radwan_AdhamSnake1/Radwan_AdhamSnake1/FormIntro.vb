Public Class FormIntro

    Private Sub btnInstruction_Click(sender As System.Object, e As System.EventArgs) Handles btnInstruction.Click
        Instructions.Show()
        Me.Hide()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Me.Hide()
        Game.Show()
    End Sub
End Class

Public Class frmBonus

    Private Sub frmBonus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlBonus.Height = 35
        Label1.Height = 25
    End Sub

    Private Sub btnClosePnl_Click(sender As Object, e As EventArgs) Handles btnClosePnl.Click
        Me.Close()
    End Sub
End Class
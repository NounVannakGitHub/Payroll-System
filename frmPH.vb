Public Class frmPH
    Private Sub frmPH_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Height = 25
        PanelEx1.Height = 35
        btnClose.Width = 52
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
Public Class frmEmployeeLoan

    Private Sub frmEmployeeLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelEx1.Height = 35
        Label1.Height = 25
        btnClose.Width = 40
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmAddEmployeeLoan.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmAddEmployeeLoan.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
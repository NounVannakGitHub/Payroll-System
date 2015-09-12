Public Class frmEmployeeInformation
    Private Sub frmEmployeeInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlEmployeeInfo.Height = 30
        btnClosePanel.Width = 40
        AddNewLabel.Height = 25
    End Sub
    Private Sub btnClosePanel_Click(sender As Object, e As EventArgs) Handles btnClosePanel.Click
        Me.Close()
    End Sub

    Private Sub tBtnAdd_Click(sender As Object, e As EventArgs) Handles tBtnAdd.Click
        frmAddEmployee.ShowDialog()
    End Sub


End Class
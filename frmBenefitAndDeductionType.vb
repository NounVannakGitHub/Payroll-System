Public Class frmBenefitAndDeductionType
    Private Sub frmBenefitAndDeductionType_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlBenefitAndDeduction.Height = 30
        Label2.Height = 25
        Label1.Height = 25
    End Sub
    Private Sub btnClosePanel_Click(sender As Object, e As EventArgs) Handles btnClosePanel.Click
        Me.Close()
    End Sub
End Class
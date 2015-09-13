Public Class frmBenefitAndDeductionType
    Private Sub frmBenefitAndDeductionType_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlBenefitAndDeduction.Height = 30
        Label2.Height = 25
        Label1.Height = 25
    End Sub
    Private Sub btnClosePanel_Click(sender As Object, e As EventArgs) Handles btnClosePanel.Click
        Me.Close()
    End Sub

    Private Sub tbtnNew_Click(sender As Object, e As EventArgs) Handles tbtnNew.Click
        frmBenefitType.ShowDialog()
    End Sub

    Private Sub tbtnEdit_Click(sender As Object, e As EventArgs) Handles tbtnEdit.Click
        frmEditBenefitType.ShowDialog()
    End Sub

    Private Sub tbtnNewDeductionType_Click(sender As Object, e As EventArgs) Handles tbtnNewDeductionType.Click
        frmAddDeductionType.ShowDialog()
    End Sub

    Private Sub tbtnEditDeductionType_Click(sender As Object, e As EventArgs) Handles tbtnEditDeductionType.Click
        frmEditDeductionType.ShowDialog()
    End Sub
End Class
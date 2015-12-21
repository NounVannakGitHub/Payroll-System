Public Class frmBenefitAndDeductionType
    Private Sub frmBenefitAndDeductionType_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlBenefitAndDeduction.Height = 30
        Label2.Height = 25
        Label1.Height = 25
        TabControl1.ItemSize = New Size(72, 20)
        btnClosePanel.Width = 40
    End Sub
    Private Sub btnClosePanel_Click(sender As Object, e As EventArgs) Handles btnClosePanel.Click
        Me.Close()
    End Sub

    Private Sub tbNewBenefit_Click(sender As Object, e As EventArgs) Handles tbNewBenefit.Click
        'If ALLOW_ACTION_PERMISSION(USERCODE, "Supplier Information", "V", "New Supplier") = False Then Exit Sub
        With frmBenefitType
            .Tag = "New"
            '.Text = IIf(LANGUAGE = "en", "Add New Supplier Information", "បន្ថែមព័ត៌មានអ្នកផ្គត់ផ្គង់ថ្មី")
            '.Title_Label.Text = IIf(LANGUAGE = "en", "Add New Supplier", "បន្ថែមព័ត៌មានអ្នកផ្គត់ផ្គង់ថ្មី")
            '.SuppCode_TextBox.Enabled = True
            'CLEARE_TEXTBOX()
            '.Status_ComboBox.SelectedIndex = 0
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                'INSERT_DATA()
            End If
            .Close()
        End With
    End Sub

    Private Sub btnEditBenefit_Click(sender As Object, e As EventArgs) Handles btnEditBenefit.Click
        frmBenefitType.ShowDialog()
    End Sub

    Private Sub btnAddDeduction_Click(sender As Object, e As EventArgs) Handles btnAddDeduction.Click
        frmDeductionType.ShowDialog()
    End Sub

    Private Sub btnEditDeduction_Click(sender As Object, e As EventArgs) Handles btnEditDeduction.Click
        frmDeductionType.ShowDialog()
    End Sub
End Class
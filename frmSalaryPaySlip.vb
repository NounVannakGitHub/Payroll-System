Public Class frmSalaryPaySlip
    Dim salary As New TaxForSalary
    Dim iSalary As ISalary = New SalaryImpl
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub frmSalaryPaySlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetComboBox(cboEmpId, "tblTaxEmployee", "EmployeeID")
    End Sub

    Private Sub cboEmpId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpId.SelectedIndexChanged
        DoSet0(gbAllowance)
        DoSet0(gbNetBase)
        DoSet0(gbSalary)
        txtLastName.Text = GetFieldValue("tblTaxEmployee", "EmpLName", cboEmpId.Text)
        txtFirstName.Text = GetFieldValue("tblTaxEmployee", "EmpFName", cboEmpId.Text)
        txtBasicSalary.Text = GetFieldValue("tblTaxEmployee", "EmpSalary", cboEmpId.Text)
        txtTaxSpouse.Text = GetFieldValue("tblTaxEmployee", "SpouseTax", cboEmpId.Text)
        txtTaxChild.Text = GetFieldValue("tblTaxEmployee", "ChildTaxTotal", cboEmpId.Text)
        txtBasicSalary2.Text = salary.CreateBasicSalary(txtBasicSalary.Text, txtTaxSpouse.Text, txtTaxChild.Text)
        txtNetBase.Text = txtBasicSalary2.Text
        txtSalaryBeforeTax.Text = txtBasicSalary2.Text
    End Sub
    Private Sub txtAnnualAward_TextChanged(sender As Object, e As EventArgs) Handles txtAnnualAward.TextChanged
        txtNetBase.Text = salary.CreateNetBase(txtBasicSalary2.Text, txtAnnualAward.Text, txtAdjust.Text, txtIncre.Text, txtDecre.Text, txtSalary13.Text, txtSalary14.Text, chbIncre)
        txtSalaryBeforeTax.Text = txtNetBase.Text
    End Sub

    Private Sub txtAdjust_TextChanged(sender As Object, e As EventArgs) Handles txtSalary14.TextChanged, txtSalary13.TextChanged, txtIncre.TextChanged, txtDecre.TextChanged, txtAdjust.TextChanged
        txtNetBase.Text = salary.CreateNetBase(txtBasicSalary2.Text, txtAnnualAward.Text, txtAdjust.Text, txtIncre.Text, txtDecre.Text, txtSalary13.Text, txtSalary14.Text, chbIncre)
        txtSalaryBeforeTax.Text = txtNetBase.Text
    End Sub

    Private Sub txtIncentive_TextChanged(sender As Object, e As EventArgs) Handles txtTransport.TextChanged, txtReginal.TextChanged, txtOverTime.TextChanged, txtIncentive.TextChanged
        txtSalaryBeforeTax.Text = salary.CreateSalaryBeforeTax(txtNetBase.Text, txtIncentive.Text, txtReginal.Text, txtTransport.Text, txtOverTime.Text)
    End Sub

    Private Sub txtSalaryBeforeTax_TextChanged(sender As Object, e As EventArgs) Handles txtSalaryBeforeTax.TextChanged
        txtTax.Text = SetPersent(txtSalaryBeforeTax.Text)
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txtSubTotal.Text = salary.CreateSubTotal(txtSalaryBeforeTax.Text, txtTax.Text)
        btnSave.Enabled = True
    End Sub

    Private Sub chbDecre_CheckedChanged(sender As Object, e As EventArgs) Handles chbDecre.CheckedChanged
        DoCheckBox(chbDecre, txtDecre)
    End Sub

    Private Sub chb13_CheckedChanged(sender As Object, e As EventArgs) Handles chb13.CheckedChanged
        DoCheckBox(chb13, txtSalary13)
    End Sub

    Private Sub chbIncre_CheckedChanged(sender As Object, e As EventArgs) Handles chbIncre.CheckedChanged
        DoCheckBox(chbIncre, txtIncre)
    End Sub

    Private Sub chb14_CheckedChanged(sender As Object, e As EventArgs) Handles chb14.CheckedChanged
        DoCheckBox(chb14, txtSalary14)
    End Sub

    Private Sub txtAnnualAward_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTransport.KeyPress, txtSalary14.KeyPress, txtSalary13.KeyPress, txtReginal.KeyPress, txtOverTime.KeyPress, txtIncre.KeyPress, txtIncentive.KeyPress, txtDecre.KeyPress, txtAnnualAward.KeyPress, txtAdjust.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        iSalary.Insert(New Salary(cboEmpId.Text, txtLastName.Text, txtFirstName.Text, txtBasicSalary.Text, txtTaxChild.Text, txtTaxSpouse.Text, txtBasicSalary2.Text, txtAnnualAward.Text, txtAdjust.Text, txtIncre.Text, txtDecre.Text, txtSalary13.Text, txtSalary14.Text, txtNetBase.Text, txtIncentive.Text, txtReginal.Text, txtTransport.Text, txtOverTime.Text, txtSalaryBeforeTax.Text, txtTax.Text, txtSubTotal.Text, dtpFrom.Text, dtpTo.Text))
        iSalary.Insert("tblSalarySpouse", New Salary(cboEmpId.Text, txtTaxSpouse.Text, dtpTo.Text))
        iSalary.Insert("tblSalaryChild", New Salary(cboEmpId.Text, txtTaxChild.Text, dtpTo.Text))
        btnPrint.Enabled = True
        btnSave.Enabled = False
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmPrintSalaryPaySlip.ShowDialog()
    End Sub
End Class
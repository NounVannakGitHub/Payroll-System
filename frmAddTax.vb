Public Class frmAddTax
    Dim iTaxEmp As ITaxEmployee = New TaxEmployeeImpl
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub frmAddTax_Load(sender As Object, e As EventArgs) Handles Me.Load
        If frmTax.btnAddNew.Pressed Then
            btnSaveTaxEmployee.Enabled = True
            btnEditTaxEmployee.Enabled = False
            ClearForm(gbTaxEmployee)
            ClearForm(gbTaxSpouse)
            txtTaxId.Text = SetAutoID(GetID("tblTaxEmployee"), "TAX-0000")
            SetComboBox(cboEmpId, "tblEmployee", "EmployeeID")
        Else
            btnSaveTaxEmployee.Enabled = False
            btnEditTaxEmployee.Enabled = True
            Dim control() As Control = {txtTaxId, cboEmpId, txtEmpLName, txtEmpFName, txtEmpGender, txtEmpStatus, txtEmpDepartment, txtEmpPosition, txtEmpSalary, txtEmpTaxPersent, txtEmpSpouseLName, txtEmpSpouseFName, txtEmpSpouseGender, txtEmpSpouseJob, txtEmpChild, txtEmpChildQty, txtEmpTaxForSpouse, txtEmpTaxForChild, txtEmpTaxForChildTotal}
            GetValueFromDataGridView(control, frmTax.dgvTax, 1)
            imgEmployee.ImageLocation = GetImagePathFromDB(cboEmpId.Text)
        End If
    End Sub

    Private Sub cboEmpId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpId.SelectedIndexChanged
        imgEmployee.ImageLocation = GetImagePathFromDB(cboEmpId.Text)
        txtEmpLName.Text = GetFieldValue("tblEmployee", "LastName", cboEmpId.Text)
        txtEmpFName.Text = GetFieldValue("tblEmployee", "FirstName", cboEmpId.Text)
        txtEmpGender.Text = GetFieldValue("tblEmployee", "Gender", cboEmpId.Text)
        txtEmpStatus.Text = GetFieldValue("tblEmployee", "PersonalStatus", cboEmpId.Text)
        txtEmpGender.Text = GetFieldValue("tblEmployee", "Gender", cboEmpId.Text)
        txtEmpDepartment.Text = GetFieldValue("tblWorkInformation", "Department", cboEmpId.Text)
        txtEmpPosition.Text = GetFieldValue("tblWorkInformation", "Position", cboEmpId.Text)
        txtEmpSalary.Text = GetFieldValue("tblWorkInformation", "Salary", cboEmpId.Text)
        txtEmpTaxPersent.Text = SetPersent(txtEmpSalary.Text)
        txtEmpSpouseLName.Text = GetFieldValue("tblSpouse", "LastName", cboEmpId.Text)
        txtEmpSpouseFName.Text = GetFieldValue("tblSpouse", "FirstName", cboEmpId.Text)
        txtEmpSpouseGender.Text = GetFieldValue("tblSpouse", "Gender", cboEmpId.Text)
        txtEmpSpouseJob.Text = GetFieldValue("tblSpouse", "Job", cboEmpId.Text)
        txtEmpChild.Text = GetFieldValue("tblSpouse", "Child", cboEmpId.Text)
        txtEmpChildQty.Text = GetFieldValue("tblSpouse", "ChildTotal", cboEmpId.Text)
        DoCheckJobSpouse(txtEmpSpouseJob, txtEmpTaxForSpouse) 
    End Sub

    Private Sub txtEmpTaxForChild_TextChanged(sender As Object, e As EventArgs) Handles txtEmpTaxForChild.TextChanged
        txtEmpTaxForChildTotal.Text = DoTotalTaxChild(txtEmpChildQty.Text, txtEmpTaxForChild.Text)
    End Sub

    Private Sub btnSaveTaxEmployee_Click(sender As Object, e As EventArgs) Handles btnSaveTaxEmployee.Click
        DoSetNA(gbTaxSpouse)
        iTaxEmp.Insert(New TaxEmployee(txtTaxId.Text, cboEmpId.Text, txtEmpLName.Text, txtEmpFName.Text, txtEmpGender.Text, txtEmpStatus.Text, txtEmpDepartment.Text, txtEmpPosition.Text, txtEmpSalary.Text, txtEmpTaxPersent.Text, txtEmpSpouseLName.Text, txtEmpSpouseFName.Text, txtEmpSpouseGender.Text, txtEmpSpouseJob.Text, txtEmpChild.Text, txtEmpChildQty.Text, txtEmpTaxForSpouse.Text, txtEmpTaxForChild.Text, txtEmpTaxForChildTotal.Text))
        ClearForm(gbTaxEmployee)
        ClearForm(gbTaxSpouse)
        txtTaxId.Text = SetAutoID(GetID("tblTaxEmployee"), "TAX-0000")
        SetComboBox(cboEmpId, "tblEmployee", "EmployeeID")
    End Sub

    Private Sub btnEditTaxEmployee_Click(sender As Object, e As EventArgs) Handles btnEditTaxEmployee.Click
        DoSetNA(gbTaxSpouse)
        iTaxEmp.Update(txtTaxId.Text, New TaxEmployee(txtTaxId.Text, cboEmpId.Text, txtEmpLName.Text, txtEmpFName.Text, txtEmpGender.Text, txtEmpStatus.Text, txtEmpDepartment.Text, txtEmpPosition.Text, txtEmpSalary.Text, txtEmpTaxPersent.Text, txtEmpSpouseLName.Text, txtEmpSpouseFName.Text, txtEmpSpouseGender.Text, txtEmpSpouseJob.Text, txtEmpChild.Text, txtEmpChildQty.Text, txtEmpTaxForSpouse.Text, txtEmpTaxForChild.Text, txtEmpTaxForChildTotal.Text))
        gbTaxEmpButton.Enabled = False
    End Sub

    Private Sub txtEmpStatus_TextChanged(sender As Object, e As EventArgs) Handles txtEmpStatus.TextChanged
        DoCheckStatus(txtEmpStatus.Text, gbTaxSpouse)
    End Sub

    Private Sub txtEmpChild_TextChanged(sender As Object, e As EventArgs) Handles txtEmpChild.TextChanged
        DoCheckChild(txtEmpChild, txtEmpTaxForChild)
        DoCheckChild(txtEmpChild, txtEmpTaxForChildTotal)
    End Sub
End Class
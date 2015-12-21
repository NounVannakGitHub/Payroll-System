Public Class frmAddEmployee
    Dim iEmp As IEmployee = New EmployeeImpl
    Dim child As IChild = New ChildImpl
    Dim iWork As IWorkInfomation = New WorkImpl
    Dim iEdu As IEducation = New EducationImpl
    Dim iSpouse As ISpouse = New SpouseImpl
    Dim iParent As IParent = New ParentImpl
    Dim null As TextBox

    Private Sub frmAddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim employee() As Control = {txtEmpLName, txtEmpFName, txtEmpLatinName, cboSex, txtEmpAge, txtNationality, dtpDOB, cboEmpStatus, txtEmpPhone, txtEmpIdCard}
        Dim pob() As Control = {txtEmpBHome, txtEmpBStreet, cboEmpBCity, cboEmpBDistrict, cboEmpBCommune, cboEmpBVillage}
        Dim address() As Control = {txtEmpCHome, txtEmpCStreet, cboEmpCCity, cboEmpCDistrict, cboEmpCCommune, cboEmpCVillage}
        Dim spouse() As Control = {txtSAge, cboSJob, cboSChild, txtChildQty, txtSPhone, txtSHome, txtSStreet, cboSCity, cboSDistrict, cboSCommune, cboSVillage}
        If frmEmployeeInformation.tBtnEdit.Pressed Then
            PanelEx1.Height = 35
            TabControl1.ItemSize = New Size(72, 20)
            txtEmpId.Text = PayrollUtils.GetValue.ToString
            DoSetValueFromDBToControls(employee, txtEmpId.Text, "tblEmployee", 2)
            DoSetValueFromDBToControls(pob, txtEmpId.Text, "tblPlaceOfBirth", 2)
            DoSetValueFromDBToControls(address, txtEmpId.Text, "tblAddress", 2)
            txtSLName.Text = GetFieldValue("tblSpouse", "LastName", txtEmpId.Text)
            txtSFName.Text = GetFieldValue("tblSpouse", "FirstName", txtEmpId.Text)
            DoSetValueFromDBToControls(spouse, txtEmpId.Text, "tblSpouse", 5)
            imgEmployee.ImageLocation = GetImagePathFromDB(txtEmpId.Text)
            SetComboBox(cboEmpBCity, "tblCity", "City")
            SetComboBox(cboEmpCCity, "tblCity", "City")
            SetComboBox(cboFCity, "tblCity", "City")
            SetComboBox(cboMCity, "tblCity", "City")
            SetComboBox(cboCCity, "tblCity", "City")
            SetComboBox(cboSCity, "tblCity", "City")
            SetComboBox(cboSJob, "tblJob", "FullName")
            SetComboBox(txtFJob, "tblJob", "FullName")
            SetComboBox(txtMJob, "tblJob", "FullName")
            SetComboBox(cboDepartment, "tblDepartment", "Department")
            SetComboBox(cboPosition, "tblPosition", "Position")
            iWork.Show(txtEmpId.Text, dgvWork)
            iEdu.Show(txtEmpId.Text, dgvEducation)
            iParent.Show(txtEmpId.Text, "tblMother", dgvMom)
            iParent.Show(txtEmpId.Text, "tblFather", dgvDad)
            child.Show(txtEmpId.Text, dgvChild)
            btnEditSpouse.Enabled = True
            btnUpdate.Enabled = True
        Else
            PanelEx1.Height = 35
            TabControl1.ItemSize = New Size(72, 20)
            ClearForm(gpEmployee)
            ClearForm(gbAddress)
            ClearForm(gbPOB)
            txtEmpId.Text = iEmp.SetAutoID(iEmp.GetID)
            txtEmpLName.Select()
            SetComboBox(cboEmpBCity, "tblCity", "City")
            SetComboBox(cboEmpCCity, "tblCity", "City")
            SetComboBox(cboFCity, "tblCity", "City")
            SetComboBox(cboMCity, "tblCity", "City")
            SetComboBox(cboCCity, "tblCity", "City")
            SetComboBox(cboSCity, "tblCity", "City")
            SetComboBox(cboSJob, "tblJob", "FullName")
            SetComboBox(txtFJob, "tblJob", "FullName")
            SetComboBox(txtMJob, "tblJob", "FullName")
            SetComboBox(cboDepartment, "tblDepartment", "Department")
            SetComboBox(cboPosition, "tblPosition", "Position")
            iWork.Show(txtEmpId.Text, dgvWork)
            iEdu.Show(txtEmpId.Text, dgvEducation)
            iParent.Show(txtEmpId.Text, "tblMother", dgvMom)
            iParent.Show(txtEmpId.Text, "tblFather", dgvDad)
            child.Show(txtEmpId.Text, dgvChild)
            btnSave.Enabled = True
            btnSaveSpouseAndChild.Enabled = True
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        imgEmployee.ImageLocation = PayrollUtils.DoSelectPictureBackground(OpenFileDialog1)
    End Sub

    Private Sub cboEmpBCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpBCity.SelectedIndexChanged
        SetComboBox(cboEmpBDistrict, cboEmpBCity, "tblDistrict", "District", "CityID")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub cboEmpStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpStatus.SelectedIndexChanged
        DoControlPersonalStatus(cboEmpStatus, PanelSpouse)
    End Sub

    Private Sub cboSChild_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSChild.SelectedIndexChanged
        DoControlChildCondition(cboSChild, gbChild)
        DoControlChildCondition(cboSChild, gpButtonOfChild)
    End Sub

    Private Sub cboEmpBDistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpBDistrict.SelectedIndexChanged
        SetComboBox(cboEmpBCommune, cboEmpBDistrict, "tblCommune", "Commune", "DistrictID")
    End Sub

    Private Sub cboEmpBCommune_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpBCommune.SelectedIndexChanged
        SetComboBox(cboEmpBVillage, cboEmpBCommune, "tblVillage", "Village", "CommuneID")
    End Sub

    Private Sub cboEmpCCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpCCity.SelectedIndexChanged
        SetComboBox(cboEmpCDistrict, cboEmpCCity, "tblDistrict", "District", "CityID")
    End Sub

    Private Sub cboEmpCDistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpCDistrict.SelectedIndexChanged
        SetComboBox(cboEmpCCommune, cboEmpCDistrict, "tblCommune", "Commune", "DistrictID")
    End Sub

    Private Sub cboEmpCCommune_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpCCommune.SelectedIndexChanged
        SetComboBox(cboEmpCVillage, cboEmpCCommune, "tblVillage", "Village", "CommuneID")
    End Sub

    Private Sub cboFCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFCity.SelectedIndexChanged
        SetComboBox(cboFDistrict, cboFCity, "tblDistrict", "District", "CityID")
    End Sub

    Private Sub cboFDistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFDistrict.SelectedIndexChanged
        SetComboBox(cboFCommune, cboFDistrict, "tblCommune", "Commune", "DistrictID")
    End Sub

    Private Sub cboFCommune_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFCommune.SelectedIndexChanged
        SetComboBox(cboFVillage, cboFCommune, "tblVillage", "Village", "CommuneID")
    End Sub

    Private Sub cboMCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMCity.SelectedIndexChanged
        SetComboBox(cboMDistrict, cboMCity, "tblDistrict", "District", "CityID")
    End Sub

    Private Sub cboMDistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMDistrict.SelectedIndexChanged
        SetComboBox(cboMCommune, cboMDistrict, "tblCommune", "Commune", "DistrictID")
    End Sub

    Private Sub cboMCommune_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMCommune.SelectedIndexChanged
        SetComboBox(cboMVillage, cboMCommune, "tblVillage", "Village", "CommuneID")
    End Sub

    Private Sub cboSCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSCity.SelectedIndexChanged
        SetComboBox(cboSDistrict, cboSCity, "tblDistrict", "District", "CityID")
    End Sub

    Private Sub cboSDistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSDistrict.SelectedIndexChanged
        SetComboBox(cboSCommune, cboSDistrict, "tblCommune", "Commune", "DistrictID")
    End Sub

    Private Sub cboSCommune_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSCommune.SelectedIndexChanged
        SetComboBox(cboSVillage, cboSCommune, "tblVillage", "Village", "CommuneID")
    End Sub

    Private Sub cboCCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCCity.SelectedIndexChanged
        SetComboBox(cboCDistrict, cboCCity, "tblDistrict", "District", "CityID")
    End Sub

    Private Sub cboCDistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCDistrict.SelectedIndexChanged
        SetComboBox(cboCCommune, cboCDistrict, "tblCommune", "Commune", "DistrictID")
    End Sub

    Private Sub cboCCommune_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCCommune.SelectedIndexChanged
        SetComboBox(cboCVillage, cboCCommune, "tblVillage", "Village", "CommuneID")
    End Sub

    Private Sub cboEducationLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEducationLevel.SelectedIndexChanged
        ShowFormInsidePanel(panelEducation, frmSchool, frmUniversity, cboEducationLevel)
    End Sub

    Private Sub btnAddChild_Click(sender As Object, e As EventArgs) Handles btnAddChild.Click
        DoSetNA(gbChild)
        child.Insert(New Child(txtEmpId.Text, txtChildNo.Text, txtCLastName.Text, txtCFirstName.Text, txtCAge.Text, cboCGender.Text, New ChildAddress(txtCHome.Text, txtCStreet.Text, cboCCity.Text, cboCDistrict.Text, cboCCommune.Text, cboCVillage.Text)))
        child.Show(txtEmpId.Text, dgvChild)
        txtChildNo.Text = AutoNo(txtChildQty.Text, txtChildNo.Text, gbChild)
        ClearForm(gbChild)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DoSetNA(gpEmployee)
        DoSetNA(gbAddress)
        DoSetNA(gbPOB)
        iEmp.Insert(New Employee(txtEmpId.Text, txtEmpLName.Text, txtEmpFName.Text, txtEmpLatinName.Text, cboSex.Text, txtEmpAge.Text, txtNationality.Text, dtpDOB.Text, cboEmpStatus.Text, txtEmpPhone.Text, txtEmpIdCard.Text, imgEmployee.ImageLocation))
        iEmp.Insert(New EmployeeAddress(txtEmpId.Text, txtEmpCHome.Text, txtEmpCStreet.Text, cboEmpCCity.Text, cboEmpCDistrict.Text, cboEmpCCommune.Text, cboEmpCVillage.Text))
        iEmp.Insert(New PlaceOfBirth(txtEmpId.Text, txtEmpBHome.Text, txtEmpBStreet.Text, cboEmpBCity.Text, cboEmpBDistrict.Text, cboEmpBCommune.Text, cboEmpBVillage.Text))
        ClearForm(gpEmployee)
        ClearForm(gbAddress)
        ClearForm(gbPOB)
        txtEmpId.Text = iEmp.SetAutoID(iEmp.GetID)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        DoSetNA(gpEmployee)
        DoSetNA(gbAddress)
        DoSetNA(gbPOB)
        iEmp.Update(txtEmpId.Text, New Employee(txtEmpId.Text, txtEmpLName.Text, txtEmpFName.Text, txtEmpLatinName.Text, cboSex.Text, txtEmpAge.Text, txtNationality.Text, dtpDOB.Text, cboEmpStatus.Text, txtEmpPhone.Text, txtEmpIdCard.Text, imgEmployee.ImageLocation))
        iEmp.Update(txtEmpId.Text, New EmployeeAddress(txtEmpId.Text, txtEmpCHome.Text, txtEmpCStreet.Text, cboEmpCCity.Text, cboEmpCDistrict.Text, cboEmpCCommune.Text, cboEmpCVillage.Text))
        iEmp.Update(txtEmpId.Text, New PlaceOfBirth(txtEmpId.Text, txtEmpBHome.Text, txtEmpBStreet.Text, cboEmpBCity.Text, cboEmpBDistrict.Text, cboEmpBCommune.Text, cboEmpBVillage.Text))
    End Sub

    Private Sub btnSaveWork_Click(sender As Object, e As EventArgs) Handles btnSaveWork.Click
        DoSetNA(gbWork)
        iWork.Insert(New WorkInformation(txtEmpId.Text, startDateWork.Text, startDateContract.Text, endDateContract.Text, cboDepartment.Text, cboContractType.Text, cboDuration.Text, cboPosition.Text, txtBaseSalary.Text))
        iWork.Show(txtEmpId.Text, dgvWork)
        ClearForm(gbWork)
    End Sub
    Private Sub btnEditWork_Click(sender As Object, e As EventArgs) Handles btnEditWork.Click
        DoSetNA(gbWork)
        iWork.Update(txtEmpId.Text, New WorkInformation(txtEmpId.Text, startDateWork.Text, startDateContract.Text, endDateContract.Text, cboDepartment.Text, cboContractType.Text, cboDuration.Text, cboPosition.Text, txtBaseSalary.Text))
        iWork.Show(txtEmpId.Text, dgvWork)
        ClearForm(gbWork)
    End Sub

    Private Sub btnAddEducation_Click(sender As Object, e As EventArgs) Handles btnAddEducation.Click
        Dim education As Education = ControlEducationCondition(cboEducationLevel, frmUniversity, frmSchool)
        education.EmployeeID = txtEmpId.Text
        education.EducationQty = txtEducationQty.Text
        education.EductionNo = txtEducationNo.Text
        iEdu.Insert(education)
        iEdu.Show(txtEmpId.Text, dgvEducation)
        txtEducationNo.Text = AutoNo(txtEducationQty.Text, txtEducationNo.Text, gbEducation)
    End Sub

    Private Sub btnEditEducation_Click(sender As Object, e As EventArgs) Handles btnEditEducation.Click
        DoSetNA(gbEducation)
        iEdu.Update(txtEmpId.Text, txtEducationNo.Text, ControlEducationCondition(cboEducationLevel, frmUniversity, frmSchool))
        iEdu.Show(txtEmpId.Text, dgvEducation)
        txtEducationNo.Text = AutoNo(txtEducationQty.Text, txtEducationNo.Text, gbEducation)
    End Sub

    Private Sub dgvEducation_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        GetValue = GetIndexFromDataGridView(0, dgvEducation) + 1
    End Sub

    Private Sub btnDeleteEducation_Click(sender As Object, e As EventArgs) Handles btnDeleteEducation.Click
        iEdu.Delete(txtEmpId.Text, txtEducationNo.Text)
        iEdu.Show(txtEmpId.Text, dgvEducation)
    End Sub

    Private Sub btnSaveSpouseAndChild_Click(sender As Object, e As EventArgs) Handles btnSaveSpouseAndChild.Click
        DoSetNA(gbSpouse)
        iSpouse.Insert(New Spouses(txtEmpId.Text, txtSLName.Text, txtSFName.Text, SetAutoGender(cboSex), txtSAge.Text, cboSJob.Text, cboSChild.Text, txtChildQty.Text, txtSPhone.Text, txtSHome.Text, txtSStreet.Text, cboSCity.Text, cboSDistrict.Text, cboSCommune.Text, cboSVillage.Text))
        ClearForm(gbSpouse)
    End Sub

    Private Sub btnEditChild_Click(sender As Object, e As EventArgs) Handles btnEditChild.Click
        DoSetNA(gbChild)
        child.Update(New Child(txtEmpId.Text, txtChildNo.Text, txtCLastName.Text, txtCFirstName.Text, txtCAge.Text, cboCGender.Text, New ChildAddress(txtCHome.Text, txtCStreet.Text, cboCVillage.Text, cboCCommune.Text, cboCDistrict.Text, cboCCity.Text)), txtEmpId.Text, txtChildNo.Text)
        child.Show(txtEmpId.Text, dgvChild)
        txtChildNo.Text = AutoNo(txtChildQty.Text, txtChildNo.Text, gbChild)
        ClearForm(gbChild)
    End Sub

    Private Sub btnSaveFamily_Click(sender As Object, e As EventArgs) Handles btnSaveFamily.Click
        DoSetNA(gbFather)
        DoSetNA(gbMother)
        iParent.Insert(New Father(txtEmpId.Text, txtFLName.Text, txtFFName.Text, txtFAge.Text, cboFLife.Text, txtFJob.Text, txtFPhone.Text, txtFHome.Text, txtFStreet.Text, cboFCity.Text, cboFDistrict.Text, cboFCommune.Text, cboFVillage.Text))
        iParent.Insert(New Mother(txtEmpId.Text, txtMLName.Text, txtMFName.Text, txtMAge.Text, cboMLife.Text, txtMJob.Text, txtMPhone.Text, txtMHome.Text, txtMStreet.Text, cboMCity.Text, cboMDistrict.Text, cboMCommune.Text, cboMVillage.Text))
        iParent.Show(txtEmpId.Text, "tblFather", dgvDad)
        iParent.Show(txtEmpId.Text, "tblMother", dgvMom)
    End Sub

    Private Sub btnEditFamily_Click(sender As Object, e As EventArgs) Handles btnEditFamily.Click
        DoSetNA(gbFather)
        DoSetNA(gbMother)
        iParent.Update(txtEmpId.Text, New Father(txtEmpId.Text, txtFLName.Text, txtFFName.Text, txtFAge.Text, cboFLife.Text, txtFJob.Text, txtFPhone.Text, txtFHome.Text, txtFStreet.Text, cboFCity.Text, cboFDistrict.Text, cboFCommune.Text, cboFVillage.Text))
        iParent.Update(txtEmpId.Text, New Mother(txtEmpId.Text, txtMLName.Text, txtMFName.Text, txtMAge.Text, cboMLife.Text, txtMJob.Text, txtMPhone.Text, txtMHome.Text, txtMStreet.Text, cboMCity.Text, cboMDistrict.Text, cboMCommune.Text, cboMVillage.Text))
        iParent.Show(txtEmpId.Text, "tblFather", dgvDad)
        iParent.Show(txtEmpId.Text, "tblMother", dgvMom)
    End Sub

    Private Sub btnDeleteChlid_Click(sender As Object, e As EventArgs) Handles btnDeleteChlid.Click
        child.Delete(txtEmpId.Text, txtChildNo.Text)
        child.Show(txtEmpId.Text, dgvChild)
        ClearForm(gbChild)
    End Sub

    Private Sub dgvChild_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChild.CellClick
        Dim controls() As Control = {txtChildNo, txtCLastName, txtCFirstName, cboCGender, txtCAge, txtCHome, txtCStreet, cboCCity, cboCDistrict, cboCCommune, cboCVillage}
        GetValueFromDataGridView(controls, dgvChild, 2)
    End Sub

    Private Sub txtEmpIdCard_GotFocus(sender As Object, e As EventArgs) Handles txtEmpIdCard.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtEmpIdCard_TextChanged(sender As Object, e As EventArgs) Handles txtEmpIdCard.TextChanged
        lblBarCodeIdCard.Text = txtEmpIdCard.Text
    End Sub

    Private Sub txtEducationQty_GotFocus(sender As Object, e As EventArgs) Handles txtEducationQty.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtEducationQty_TextChanged(sender As Object, e As EventArgs) Handles txtEducationQty.TextChanged
        txtEducationNo.Text = 1
    End Sub

    Private Sub txtChildQty_GotFocus(sender As Object, e As EventArgs) Handles txtChildQty.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtChildQty_TextChanged(sender As Object, e As EventArgs) Handles txtChildQty.TextChanged
        txtChildNo.Text = 1
    End Sub

    Private Sub dgvDad_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDad.CellClick
        Dim control() As Control = {txtFLName, txtFFName, txtFAge, cboFLife, txtFJob, txtFPhone, txtFHome, txtFStreet, cboFCity, cboFDistrict, cboFCommune, cboFVillage}
        GetValueFromDataGridView(control, dgvDad, 2)
        btnEditFamily.Enabled = True
    End Sub

    Private Sub dgvMom_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMom.CellClick
        Dim control() As Control = {txtMLName, txtMFName, txtMAge, cboMLife, txtMJob, txtMPhone, txtMHome, txtMStreet, cboMCity, cboMDistrict, cboMCommune, cboMVillage}
        GetValueFromDataGridView(control, dgvMom, 2)
        btnEditFamily.Enabled = True
    End Sub

    Private Sub dgvWork_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWork.CellClick
        Dim control() As Control = {startDateWork, startDateContract, endDateContract, cboDepartment, cboContractType, cboDuration, cboPosition, txtBaseSalary}
        GetValueFromDataGridView(control, dgvWork, 2)
        btnEditWork.Enabled = True
    End Sub

    Private Sub dgvEducation_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEducation.CellClick
        Dim control() As Control = {txtEducationQty, cboEducationLevel, txtEducationNo}
        GetValueFromDataGridView(control, dgvEducation, 2)
        DoChangeEducationPanel(cboEducationLevel, frmSchool, panelEducation, frmUniversity, dgvEducation)
        btnEditEducation.Enabled = True
        btnDeleteEducation.Enabled = True
    End Sub

    Private Sub txtBaseSalary_GotFocus(sender As Object, e As EventArgs) Handles txtBaseSalary.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtCAge_GotFocus(sender As Object, e As EventArgs) Handles txtCAge.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtCFirstName_GotFocus(sender As Object, e As EventArgs) Handles txtCFirstName.GotFocus
        SwitchLanguage("kh")
    End Sub

    Private Sub txtCHome_GotFocus(sender As Object, e As EventArgs) Handles txtCHome.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtCLastName_GotFocus(sender As Object, e As EventArgs) Handles txtCLastName.GotFocus
        SwitchLanguage("kh")
    End Sub

    Private Sub txtCStreet_GotFocus(sender As Object, e As EventArgs) Handles txtCStreet.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtEmpAge_GotFocus(sender As Object, e As EventArgs) Handles txtEmpAge.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtEmpBHome_GotFocus(sender As Object, e As EventArgs) Handles txtEmpBHome.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtEmpBStreet_GotFocus(sender As Object, e As EventArgs) Handles txtEmpBStreet.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtEmpCHome_GotFocus(sender As Object, e As EventArgs) Handles txtEmpCHome.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtEmpCStreet_GotFocus(sender As Object, e As EventArgs) Handles txtEmpCStreet.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtEmpFName_GotFocus(sender As Object, e As EventArgs) Handles txtEmpFName.GotFocus
        SwitchLanguage("kh")
    End Sub

    Private Sub txtEmpLatinName_GotFocus(sender As Object, e As EventArgs) Handles txtEmpLatinName.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtEmpLName_GotFocus(sender As Object, e As EventArgs) Handles txtEmpLName.GotFocus
        SwitchLanguage("kh")
    End Sub

    Private Sub txtEmpPhone_GotFocus(sender As Object, e As EventArgs) Handles txtEmpPhone.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtFAge_GotFocus(sender As Object, e As EventArgs) Handles txtFAge.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtFFName_GotFocus(sender As Object, e As EventArgs) Handles txtFFName.GotFocus
        SwitchLanguage("kh")
    End Sub

    Private Sub txtFHome_GotFocus(sender As Object, e As EventArgs) Handles txtFHome.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtFLName_GotFocus(sender As Object, e As EventArgs) Handles txtFLName.GotFocus
        SwitchLanguage("kh")
    End Sub

    Private Sub txtFPhone_GotFocus(sender As Object, e As EventArgs) Handles txtFPhone.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtFStreet_GotFocus(sender As Object, e As EventArgs) Handles txtFStreet.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtMAge_GotFocus(sender As Object, e As EventArgs) Handles txtMAge.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtMFName_GotFocus(sender As Object, e As EventArgs) Handles txtMFName.GotFocus
        SwitchLanguage("kh")
    End Sub

    Private Sub txtMHome_GotFocus(sender As Object, e As EventArgs) Handles txtMHome.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtMLName_GotFocus(sender As Object, e As EventArgs) Handles txtMLName.GotFocus
        SwitchLanguage("kh")
    End Sub

    Private Sub txtMPhone_GotFocus(sender As Object, e As EventArgs) Handles txtMPhone.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtMStreet_GotFocus(sender As Object, e As EventArgs) Handles txtMStreet.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtNationality_GotFocus(sender As Object, e As EventArgs) Handles txtNationality.GotFocus
        SwitchLanguage("kh")
    End Sub

    Private Sub txtSAge_GotFocus(sender As Object, e As EventArgs) Handles txtSAge.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtSFName_GotFocus(sender As Object, e As EventArgs) Handles txtSFName.GotFocus
        SwitchLanguage("kh")
    End Sub

    Private Sub txtSHome_GotFocus(sender As Object, e As EventArgs) Handles txtSHome.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtSLName_GotFocus(sender As Object, e As EventArgs) Handles txtSLName.GotFocus
        SwitchLanguage("kh")
    End Sub

    Private Sub txtSPhone_GotFocus(sender As Object, e As EventArgs) Handles txtSPhone.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub txtSStreet_GotFocus(sender As Object, e As EventArgs) Handles txtSStreet.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        frmCapture.ShowDialog()
    End Sub

    Private Sub cboEmpStatus_TextChanged(sender As Object, e As EventArgs) Handles cboEmpStatus.TextChanged
        DoCheckStatus(cboEmpStatus.Text, gbSpouse)
    End Sub

    Private Sub cboSChild_TextChanged(sender As Object, e As EventArgs) Handles cboSChild.TextChanged
        DoCheckChild(cboSChild.Text, gbChild)
    End Sub

    Private Sub btnEditSpouse_Click(sender As Object, e As EventArgs) Handles btnEditSpouse.Click
        DoSetNA(gbSpouse)
        iSpouse.Update(txtEmpId.Text, New Spouses(txtEmpId.Text, txtSLName.Text, txtSFName.Text, SetAutoGender(cboSex), txtSAge.Text, cboSJob.Text, cboSChild.Text, txtChildQty.Text, txtSPhone.Text, txtSHome.Text, txtSStreet.Text, cboSCity.Text, cboSDistrict.Text, cboSCommune.Text, cboSVillage.Text))
    End Sub

    Private Sub txtEmpPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpPhone.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub txtFPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMPhone.KeyPress, txtFPhone.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub txtSPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSPhone.KeyPress
        NumberOnly(e)
    End Sub
End Class
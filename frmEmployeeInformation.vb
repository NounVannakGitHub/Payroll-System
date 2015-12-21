Public Class frmEmployeeInformation
    Dim emp As IEmployee = New EmployeeImpl
    Dim iChild As IChild = New ChildImpl
    Dim iEdu As IEducation = New EducationImpl
    Dim iWork As IWorkInfomation = New WorkImpl
    Dim iParent As IParent = New ParentImpl
    Dim iSpouse As ISpouse = New SpouseImpl
    Private Sub frmEmployeeInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlEmployeeInfo.Height = 35
        btnClosePanel.Width = 40
        AddNewLabel.Height = 25
        emp.Show(dgvEmployee)
    End Sub
    Private Sub btnClosePanel_Click(sender As Object, e As EventArgs) Handles btnClosePanel.Click
        Me.Close()
    End Sub
    Private Sub tBtnAdd_Click(sender As Object, e As EventArgs) Handles tBtnAdd.Click
        frmAddEmployee.ShowDialog()
    End Sub
    Private Sub tBtnEdit_Click(sender As Object, e As EventArgs) Handles tBtnEdit.Click
        frmAddEmployee.ShowDialog()
    End Sub

    Private Sub tBtnRefresh_Click(sender As Object, e As EventArgs) Handles tBtnRefresh.Click
        emp.Show(dgvEmployee)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        emp.Search(txtSearch.Text, dgvEmployee)
    End Sub

    Private Sub dgvEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        PayrollUtils.GetValue = PayrollUtils.GetIndexFromDataGridView(1, dgvEmployee)
        tBtnDelete.Enabled = True
        tBtnEdit.Enabled = True
    End Sub

    Private Sub tBtnDelete_Click(sender As Object, e As EventArgs) Handles tBtnDelete.Click
        emp.Delete(PayrollUtils.GetValue.ToString)
        emp.Delete(PayrollUtils.GetValue.ToString, "tblAddress")
        emp.Delete(PayrollUtils.GetValue.ToString, "tblPlaceOfBirth")
        iChild.Delete(PayrollUtils.GetValue.ToString)
        iEdu.Delete(PayrollUtils.GetValue.ToString)
        iWork.Delete(PayrollUtils.GetValue.ToString)
        iSpouse.Delete(PayrollUtils.GetValue.ToString)
        iParent.Delete(PayrollUtils.GetValue.ToString, "tblMother")
        iParent.Delete(PayrollUtils.GetValue.ToString, "tblFather")
        SetProcessStatus("Employee information was deleted !")
        emp.Show(dgvEmployee)
    End Sub

    Private Sub tBtnExcel_Click(sender As Object, e As EventArgs) Handles tBtnExcel.Click
        DoGenerateExcel(dgvEmployee)
    End Sub
End Class
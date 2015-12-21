Public Class frmAddEvaluationStaff
    Dim eva As New Evaluation
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub frmAddEvaluationStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetComboBox(cboEmpID, "tblEmployee", "EmployeeID")
        If frmEvaluationStaff.btnNew.Pressed = True Then
            btnSave.Enabled = True
            btnUpdate.Enabled = False
        Else
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        End If
    End Sub

    Private Sub cboEmpID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpID.SelectedIndexChanged
        txtFName.Text = GetFieldValue("tblEmployee", "FirstName", cboEmpID.Text)
        txtLName.Text = GetFieldValue("tblEmployee", "LastName", cboEmpID.Text)
        txtPosition.Text = GetFieldValue("tblWorkInformation", "Position", cboEmpID.Text)
    End Sub

    Private Sub cboEvaluationType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEvaluationType.SelectedIndexChanged
        doCalculateDate(cboEvaluationType, txtHired, txtExpired)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        eva.Insert(cboEmpID.Text, txtLName.Text, txtFName.Text, txtPosition.Text, cboEvaluationType.Text, txtHired.Text, txtExpired.Text)
        eva.Insert(cboEmpID.Text, txtLName.Text, txtFName.Text, txtPosition.Text, cboEvaluationType.Text, txtHired.Text, txtExpired.Text, "inserted", frmMenu.lblUser.Text)
        btnSave.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        eva.Update(cboEmpID.Text, cboEvaluationType.Text, txtHired.Text, txtExpired.Text)
        eva.Insert(cboEmpID.Text, txtLName.Text, txtFName.Text, txtPosition.Text, cboEvaluationType.Text, txtHired.Text, txtExpired.Text, "updated", frmMenu.lblUser.Text)
        btnUpdate.Enabled = False
    End Sub
End Class
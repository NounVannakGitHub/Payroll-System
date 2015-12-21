Public Class frmReportLeaveOfEmployee

    Private Sub frmReportLeaveOfEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetComboBox(cboEmpId, "tblEmployee", "EmployeeID")
    End Sub

    Private Sub cboEmpId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpId.SelectedIndexChanged
        DoShowReport(rptLeaveOfEmployee, "rptLeave.rpt", "EmpID", cboEmpId.Text)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class
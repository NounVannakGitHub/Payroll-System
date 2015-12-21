Public Class frmAttendence
    Dim att As New Attendance
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub frmAttendence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetComboBox(cboEmpID, "tblEmployee", "EmployeeID")
        att.Show("select * from tblLate where EmployeeID='" & cboEmpID.Text & "'", dgvLate)
        att.Show("select * from tblWork where EmployeeID='" & cboEmpID.Text & "'", dgvWork)
        txtTotalLate.Text = att.Sum("tblLate", "Late", cboEmpID.Text)
        txtTotalWork.Text = att.Sum("tblWork", "WorkDay", cboEmpID.Text)
    End Sub

    Private Sub btnWork_Click(sender As Object, e As EventArgs) Handles btnSetIn.Click
        att.Insert(cboEmpID.Text, txtIn.Text, txtOut.Text, DateTime.Now.ToString("dd\MM\yyyy"), txtTotalWork.Text, txtTotalLate.Text)
        att.Work(cboEmpID.Text, 1, DateTime.Now.ToString("dd\MM\yyyy"))
        btnSetOut.Enabled = True
        att.Show("select * from tblLate where EmployeeID='" & cboEmpID.Text & "'", dgvLate)
        att.Show("select * from tblWork where EmployeeID='" & cboEmpID.Text & "'", dgvWork)
        txtTotalLate.Text = att.Sum("tblLate", "Late", cboEmpID.Text)
        txtTotalWork.Text = att.Sum("tblWork", "WorkDay", cboEmpID.Text)
    End Sub

    Private Sub cboEmpID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpID.SelectedIndexChanged
        btnSetIn.Enabled = True
        btnLate.Enabled = True
        att.Show("select * from tblLate where EmployeeID='" & cboEmpID.Text & "'", dgvLate)
        att.Show("select * from tblWork where EmployeeID='" & cboEmpID.Text & "'", dgvWork)
        txtTotalLate.Text = att.Sum("tblLate", "Late", cboEmpID.Text)
        txtTotalWork.Text = att.Sum("tblWork", "WorkDay", cboEmpID.Text)
    End Sub

    Private Sub btnSetOut_Click(sender As Object, e As EventArgs) Handles btnSetOut.Click
        att.Update(cboEmpID.Text, txtOut.Text)
        btnSetOut.Enabled = False
        att.Show("select * from tblLate where EmployeeID='" & cboEmpID.Text & "'", dgvLate)
        att.Show("select * from tblWork where EmployeeID='" & cboEmpID.Text & "'", dgvWork)
        txtTotalLate.Text = att.Sum("tblLate", "Late", cboEmpID.Text)
        txtTotalWork.Text = att.Sum("tblWork", "WorkDay", cboEmpID.Text)
    End Sub

    Private Sub btnLate_Click(sender As Object, e As EventArgs) Handles btnLate.Click
        att.Late(cboEmpID.Text, 1, DateTime.Now.ToString("dd\MM\yyyy"))
        btnLate.Enabled = True
        att.Show("select * from tblLate where EmployeeID='" & cboEmpID.Text & "'", dgvLate)
        att.Show("select * from tblWork where EmployeeID='" & cboEmpID.Text & "'", dgvWork)
        txtTotalLate.Text = att.Sum("tblLate", "Late", cboEmpID.Text)
        txtTotalWork.Text = att.Sum("tblWork", "WorkDay", cboEmpID.Text)
    End Sub
End Class
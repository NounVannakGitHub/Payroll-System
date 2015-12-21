Public Class frmAttEmployee
    Dim att As New AttEmp

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub frmAttEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetComboBox(cboIn, "tblEmployee", "EmployeeID")
        SetComboBox(cboOut, "tblEmployee", "EmployeeID")
        btnIn.Enabled = False
        btnOut.Enabled = False
    End Sub

    Private Sub cboIn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIn.SelectedIndexChanged
        imgIN.ImageLocation = GetImagePathFromDB(cboIn.Text)
        btnIn.Enabled = True
        btnOut.Enabled = False
    End Sub

    Private Sub cboOut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOut.SelectedIndexChanged
        imgOut.ImageLocation = GetImagePathFromDB(cboOut.Text)
        btnIn.Enabled = False
        btnOut.Enabled = True
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        att.WriteIn(cboIn.Text)
        btnIn.Enabled = False
        btnOut.Enabled = False
        ClearForm(GroupBox1)
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        att.WriteOut(cboOut.Text)
        btnIn.Enabled = False
        btnOut.Enabled = False
        ClearForm(GroupBox2)
    End Sub
End Class
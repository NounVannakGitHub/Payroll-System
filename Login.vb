Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        frmMenu.Show()
        Me.Hide()
    End Sub
    Dim bl As Boolean, y, x As Integer
    Private Sub PanelEx1_MouseMove(sender As Object, e As MouseEventArgs)
        If bl Then
            Me.Top = Windows.Forms.Cursor.Position.Y - y
            Me.Left = Windows.Forms.Cursor.Position.X - x
        End If
    End Sub

    Private Sub PanelEx1_MouseDown(sender As Object, e As MouseEventArgs)
        bl = True
        x = Windows.Forms.Cursor.Position.X - Me.Left
        y = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PanelEx1_MouseUp(sender As Object, e As MouseEventArgs)
        bl = False
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged
        imgUser.ImageLocation = GetFieldValue("tblUser", "Photo", "UserName", txtUser.Text)
        Dim myB As Boolean = DoImageEnabled(txtUser.Text, "tblUser", "UserName")
        txtPassword.Enabled = myB
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        btnLogin.Enabled = DoImageEnabled(DoEncode(MyByte(txtPassword.Text)), "tblUser", "Password")
    End Sub

    Private Sub btnLogin_Click_2(sender As Object, e As EventArgs) Handles btnLogin.Click
        If IsLogin(txtUser.Text, DoEncode(MyByte(txtPassword.Text))) Then
            With frmMenu
                Dim controls() As ToolStripMenuItem = {.ProToolStripMenuItem, .CToolStripMenuItem, .LoToolStripMenuItem, .btnLogout, .AdminToolStripMenuItem, .AddEmployeeToolStripMenuItem, .DepartmentToolStripMenuItem, .PositionToolStripMenuItem, .EmployeeInoutToolStripMenuItem, .EmployeeEntryToolStripMenuItem, .EmployeeLoanToolStripMenuItem, .HolidayToolStripMenuItem, .TaxToolStripMenuItem, .btnUserManagement, .PermissionToolStripMenuItem, .PasswordStripMenuItem, .TransactionToolStripMenuItem, .BonusToolStripMenuItem, .btnSalary, .ReportToolStripMenuItem, .ConfigurationToolStripMenuItem, .btnAddress, .btnDatabase, .btnBackup, .btnRestore, .HelpToolStripMenuItem1, .ReToolStripMenuItem, .LeaveToolStripMenuItem}
                .lblUser.Text = txtUser.Text
                .imgUser.ImageLocation = GetFieldValue("tblUser", "Photo", "UserName", txtUser.Text)
                ''MessageBox.Show(SetPosition(txtUser.Text, DoEncode(MyByte(txtPassword.Text))))
                DoPermission(controls, SetPosition(txtUser.Text, DoEncode(MyByte(txtPassword.Text))))
                .LoToolStripMenuItem.Enabled = False
                .CToolStripMenuItem.Enabled = False
            End With
            Me.Close()
        Else
            Me.ShowDialog()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = ""
        txtPassword.Text = ""
        frmMenu.lblUser.Text = ""
        frmMenu.imgUser.ImageLocation = ""
        With frmMenu
            Dim controls() As ToolStripMenuItem = {.CToolStripMenuItem, .AdminToolStripMenuItem, .AddEmployeeToolStripMenuItem, .DepartmentToolStripMenuItem, .PositionToolStripMenuItem, .EmployeeInoutToolStripMenuItem, .EmployeeEntryToolStripMenuItem, .EmployeeLoanToolStripMenuItem, .HolidayToolStripMenuItem, .TaxToolStripMenuItem, .btnUserManagement, .PermissionToolStripMenuItem, .PasswordStripMenuItem, .TransactionToolStripMenuItem, .BonusToolStripMenuItem, .btnSalary, .ReportToolStripMenuItem, .ConfigurationToolStripMenuItem, .btnAddress, .btnDatabase, .btnBackup, .btnRestore, .HelpToolStripMenuItem1, .ReToolStripMenuItem, .LeaveToolStripMenuItem}
            For i As Integer = 0 To controls.Length - 1
                controls(i).Tag = "0"
                controls(i).Enabled = False
            Next
        End With
    End Sub
End Class
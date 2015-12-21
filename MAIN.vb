Public Class frmMenu
    Private Sub BonusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BonusToolStripMenuItem.Click
        With frmBonus
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub BenefitDeductionTypeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        With frmBenefitAndDeductionType
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub EmployeeInoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeInoutToolStripMenuItem.Click
        With frmAttendance
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub
    Private Sub EmployeeEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeEntryToolStripMenuItem.Click
        With frmEmployeeInformation
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        With frmDepartment
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub
    Private Sub PositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PositionToolStripMenuItem.Click
        With frmPosition
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub HolidayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HolidayToolStripMenuItem.Click
        With frmHoliday
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub EmployeeLoanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeLoanToolStripMenuItem.Click
        With frmEmployeeLoan
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub TaxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaxToolStripMenuItem.Click
        With frmTax
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        'With frmStartup
        '    .MdiParent = Me
        '    .Dock = DockStyle.Fill
        '    .Show()
        '    .Activate()
        'End With
        Dim lic As ILicense = New LicenseImpl
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        menuBarUser.Show()
        Timer1.Enabled = True
        If lic.IsLicensed(DoGetServerName, GetSerialNumberHDD, DoEncode(MyByte(GetSerialNumberHDD()))) Then
            SetProcessStatus("system is registered")
        Else
            frmRegister.ShowDialog()
        End If
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        frmConnect.ShowDialog()
    End Sub

    Private Sub LoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DoAutoDateAndTime(lblDate, lblTime)
    End Sub

    Private Sub ReToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReToolStripMenuItem.Click
        frmRegister.ShowDialog()
    End Sub

    Private Sub btnSalary_Click(sender As Object, e As EventArgs) Handles btnSalary.Click
        With frmSalary
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        With frmUser
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub btnAddress_Click(sender As Object, e As EventArgs) Handles btnAddress.Click
        With frmAddress
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        frmBackup.ShowDialog()
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        frmRestore.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ClearForm(Login.txtPassword)
        ClearForm(Login.txtUser)
        Login.btnLogin.Enabled = False
        Login.ShowDialog()
    End Sub
    Dim bl As Boolean, y, x As Integer
    Private Sub menuBarUser_MouseMove(sender As Object, e As MouseEventArgs) Handles menuBarUser.MouseMove
        If bl Then
            Me.Top = Windows.Forms.Cursor.Position.Y - y
            Me.Left = Windows.Forms.Cursor.Position.X - x
        End If
    End Sub

    Private Sub menuBarUser_MouseDown(sender As Object, e As MouseEventArgs) Handles menuBarUser.MouseDown
        bl = True
        x = Windows.Forms.Cursor.Position.X - Me.Left
        y = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub menuBarUser_MouseUp(sender As Object, e As MouseEventArgs) Handles menuBarUser.MouseUp
        bl = False
    End Sub

    Private Sub PermissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermissionToolStripMenuItem.Click
        frmPermission.ShowDialog()
    End Sub

    Private Sub PasswordStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasswordStripMenuItem.Click
        frmPasswordEmergency.ShowDialog()
    End Sub

    Private Sub MinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinToolStripMenuItem.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub LeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeaveToolStripMenuItem.Click
        With frmLeave
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub

    Private Sub LeaveOfEmployeeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LeaveOfEmployeeToolStripMenuItem1.Click
        frmReportLeaveOfEmployee.ShowDialog()
    End Sub

    Private Sub EvaluaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluaToolStripMenuItem.Click
        With frmEvaluationStaff
            .MdiParent = Me
            .Dock = DockStyle.Fill
            .Show()
            .Activate()
        End With
    End Sub
End Class
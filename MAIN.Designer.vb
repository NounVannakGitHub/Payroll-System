<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeInoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeLoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvaluaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolidayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUserManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswordStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BonusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSalary = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveOfEmployeeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddress = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBarUser = New DevComponents.DotNetBar.ContextMenuBar()
        Me.lblNotification = New System.Windows.Forms.Label()
        Me.imgUser = New System.Windows.Forms.PictureBox()
        Me.lblUser = New DevComponents.DotNetBar.LabelX()
        Me.lblTime = New DevComponents.DotNetBar.LabelX()
        Me.lblDate = New DevComponents.DotNetBar.LabelX()
        Me.btnNotification = New DevComponents.DotNetBar.ButtonItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProgressBarMain = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblProcessStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.menuBarUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuBarUser.SuspendLayout()
        CType(Me.imgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProToolStripMenuItem, Me.AdminToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ConfigurationToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1020, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.MinToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MinToolStripMenuItem
        '
        Me.MinToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources._1445954833_minimize
        Me.MinToolStripMenuItem.Name = "MinToolStripMenuItem"
        Me.MinToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.MinToolStripMenuItem.Text = "Minimized"
        '
        'ProToolStripMenuItem
        '
        Me.ProToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CToolStripMenuItem, Me.LoToolStripMenuItem, Me.btnLogout})
        Me.ProToolStripMenuItem.Name = "ProToolStripMenuItem"
        Me.ProToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ProToolStripMenuItem.Tag = "1"
        Me.ProToolStripMenuItem.Text = "Process"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources._1443388911_connect_to_database
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.CToolStripMenuItem.Tag = "1"
        Me.CToolStripMenuItem.Text = "Connect"
        '
        'LoToolStripMenuItem
        '
        Me.LoToolStripMenuItem.Enabled = False
        Me.LoToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources._1443388853_login
        Me.LoToolStripMenuItem.Name = "LoToolStripMenuItem"
        Me.LoToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.LoToolStripMenuItem.Tag = "1"
        Me.LoToolStripMenuItem.Text = "Login"
        '
        'btnLogout
        '
        Me.btnLogout.Enabled = False
        Me.btnLogout.Image = Global.Payroll_Management_System.My.Resources.Resources.logout
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(119, 22)
        Me.btnLogout.Tag = "1"
        Me.btnLogout.Text = "Logout"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem, Me.HolidayToolStripMenuItem, Me.TaxToolStripMenuItem, Me.btnUserManagement, Me.PermissionToolStripMenuItem, Me.PasswordStripMenuItem})
        Me.AdminToolStripMenuItem.Enabled = False
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AdminToolStripMenuItem.Tag = "1"
        Me.AdminToolStripMenuItem.Text = "Maintains"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentToolStripMenuItem, Me.PositionToolStripMenuItem, Me.EmployeeInoutToolStripMenuItem, Me.EmployeeEntryToolStripMenuItem, Me.EmployeeLoanToolStripMenuItem, Me.EvaluaToolStripMenuItem})
        Me.AddEmployeeToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources.add
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AddEmployeeToolStripMenuItem.Tag = "1"
        Me.AddEmployeeToolStripMenuItem.Text = "Employee Setup"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.CheckOnClick = True
        Me.DepartmentToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources._1445954494_office_building
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DepartmentToolStripMenuItem.Tag = "1"
        Me.DepartmentToolStripMenuItem.Text = "Department"
        '
        'PositionToolStripMenuItem
        '
        Me.PositionToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources._1445954529_vector_65_16
        Me.PositionToolStripMenuItem.Name = "PositionToolStripMenuItem"
        Me.PositionToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PositionToolStripMenuItem.Tag = "1"
        Me.PositionToolStripMenuItem.Text = "Position"
        '
        'EmployeeInoutToolStripMenuItem
        '
        Me.EmployeeInoutToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources.attendance
        Me.EmployeeInoutToolStripMenuItem.Name = "EmployeeInoutToolStripMenuItem"
        Me.EmployeeInoutToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EmployeeInoutToolStripMenuItem.Tag = "1"
        Me.EmployeeInoutToolStripMenuItem.Text = "Employee In/out"
        '
        'EmployeeEntryToolStripMenuItem
        '
        Me.EmployeeEntryToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources.user
        Me.EmployeeEntryToolStripMenuItem.Name = "EmployeeEntryToolStripMenuItem"
        Me.EmployeeEntryToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EmployeeEntryToolStripMenuItem.Tag = "1"
        Me.EmployeeEntryToolStripMenuItem.Text = "Employee Entry"
        '
        'EmployeeLoanToolStripMenuItem
        '
        Me.EmployeeLoanToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources.loan
        Me.EmployeeLoanToolStripMenuItem.Name = "EmployeeLoanToolStripMenuItem"
        Me.EmployeeLoanToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EmployeeLoanToolStripMenuItem.Tag = "1"
        Me.EmployeeLoanToolStripMenuItem.Text = "Employee Loan"
        '
        'EvaluaToolStripMenuItem
        '
        Me.EvaluaToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources.edit
        Me.EvaluaToolStripMenuItem.Name = "EvaluaToolStripMenuItem"
        Me.EvaluaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EvaluaToolStripMenuItem.Text = "Evaluation Staff"
        '
        'HolidayToolStripMenuItem
        '
        Me.HolidayToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources._1445954454_calendar_clock
        Me.HolidayToolStripMenuItem.Name = "HolidayToolStripMenuItem"
        Me.HolidayToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.HolidayToolStripMenuItem.Tag = "1"
        Me.HolidayToolStripMenuItem.Text = "Holiday"
        '
        'TaxToolStripMenuItem
        '
        Me.TaxToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources.tax
        Me.TaxToolStripMenuItem.Name = "TaxToolStripMenuItem"
        Me.TaxToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TaxToolStripMenuItem.Tag = "1"
        Me.TaxToolStripMenuItem.Text = "Tax"
        '
        'btnUserManagement
        '
        Me.btnUserManagement.Image = Global.Payroll_Management_System.My.Resources.Resources.user
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.Size = New System.Drawing.Size(171, 22)
        Me.btnUserManagement.Tag = "1"
        Me.btnUserManagement.Text = "User Management"
        '
        'PermissionToolStripMenuItem
        '
        Me.PermissionToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources._1445954419_application_pgp_signature
        Me.PermissionToolStripMenuItem.Name = "PermissionToolStripMenuItem"
        Me.PermissionToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PermissionToolStripMenuItem.Text = "Permission"
        '
        'PasswordStripMenuItem
        '
        Me.PasswordStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources.emergency2
        Me.PasswordStripMenuItem.Name = "PasswordStripMenuItem"
        Me.PasswordStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PasswordStripMenuItem.Text = "Password Recure"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BonusToolStripMenuItem, Me.btnSalary, Me.LeaveToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Enabled = False
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.TransactionToolStripMenuItem.Tag = "1"
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'BonusToolStripMenuItem
        '
        Me.BonusToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources.bonus
        Me.BonusToolStripMenuItem.Name = "BonusToolStripMenuItem"
        Me.BonusToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BonusToolStripMenuItem.Tag = "1"
        Me.BonusToolStripMenuItem.Text = "Bonus"
        '
        'btnSalary
        '
        Me.btnSalary.Image = Global.Payroll_Management_System.My.Resources.Resources.salary
        Me.btnSalary.Name = "btnSalary"
        Me.btnSalary.Size = New System.Drawing.Size(152, 22)
        Me.btnSalary.Tag = "1"
        Me.btnSalary.Text = "Salary"
        '
        'LeaveToolStripMenuItem
        '
        Me.LeaveToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources._1446147698_leave
        Me.LeaveToolStripMenuItem.Name = "LeaveToolStripMenuItem"
        Me.LeaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LeaveToolStripMenuItem.Text = "Leave"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Enabled = False
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Tag = "1"
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'EmployeeReportToolStripMenuItem
        '
        Me.EmployeeReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeaveReportToolStripMenuItem})
        Me.EmployeeReportToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources.employee
        Me.EmployeeReportToolStripMenuItem.Name = "EmployeeReportToolStripMenuItem"
        Me.EmployeeReportToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.EmployeeReportToolStripMenuItem.Text = "Employee"
        '
        'LeaveReportToolStripMenuItem
        '
        Me.LeaveReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeaveOfEmployeeToolStripMenuItem1})
        Me.LeaveReportToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources._1446147698_leave
        Me.LeaveReportToolStripMenuItem.Name = "LeaveReportToolStripMenuItem"
        Me.LeaveReportToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.LeaveReportToolStripMenuItem.Text = "Leave"
        '
        'LeaveOfEmployeeToolStripMenuItem1
        '
        Me.LeaveOfEmployeeToolStripMenuItem1.Image = Global.Payroll_Management_System.My.Resources.Resources.send1
        Me.LeaveOfEmployeeToolStripMenuItem1.Name = "LeaveOfEmployeeToolStripMenuItem1"
        Me.LeaveOfEmployeeToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.LeaveOfEmployeeToolStripMenuItem1.Text = "Leave Of Employee"
        '
        'ConfigurationToolStripMenuItem
        '
        Me.ConfigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddress, Me.btnDatabase})
        Me.ConfigurationToolStripMenuItem.Enabled = False
        Me.ConfigurationToolStripMenuItem.Name = "ConfigurationToolStripMenuItem"
        Me.ConfigurationToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ConfigurationToolStripMenuItem.Tag = "1"
        Me.ConfigurationToolStripMenuItem.Text = "Configuration"
        '
        'btnAddress
        '
        Me.btnAddress.Image = Global.Payroll_Management_System.My.Resources.Resources._1445721741_home
        Me.btnAddress.Name = "btnAddress"
        Me.btnAddress.Size = New System.Drawing.Size(122, 22)
        Me.btnAddress.Tag = "1"
        Me.btnAddress.Text = "Address"
        '
        'btnDatabase
        '
        Me.btnDatabase.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBackup, Me.btnRestore})
        Me.btnDatabase.Image = Global.Payroll_Management_System.My.Resources.Resources._1445721419_accept_database
        Me.btnDatabase.Name = "btnDatabase"
        Me.btnDatabase.Size = New System.Drawing.Size(122, 22)
        Me.btnDatabase.Tag = "1"
        Me.btnDatabase.Text = "Database"
        '
        'btnBackup
        '
        Me.btnBackup.Image = Global.Payroll_Management_System.My.Resources.Resources._1445721438_download_database
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(113, 22)
        Me.btnBackup.Tag = "1"
        Me.btnBackup.Text = "Backup"
        '
        'btnRestore
        '
        Me.btnRestore.Image = Global.Payroll_Management_System.My.Resources.Resources._1445721383_Database_Upload
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(113, 22)
        Me.btnRestore.Tag = "1"
        Me.btnRestore.Text = "Restore"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources.Information
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReToolStripMenuItem})
        Me.HelpToolStripMenuItem1.Enabled = False
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Tag = "1"
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'ReToolStripMenuItem
        '
        Me.ReToolStripMenuItem.Image = Global.Payroll_Management_System.My.Resources.Resources.License1
        Me.ReToolStripMenuItem.Name = "ReToolStripMenuItem"
        Me.ReToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ReToolStripMenuItem.Tag = "1"
        Me.ReToolStripMenuItem.Text = "Register"
        '
        'menuBarUser
        '
        Me.menuBarUser.CanAutoHide = False
        Me.menuBarUser.Controls.Add(Me.lblNotification)
        Me.menuBarUser.Controls.Add(Me.imgUser)
        Me.menuBarUser.Controls.Add(Me.lblUser)
        Me.menuBarUser.Controls.Add(Me.lblTime)
        Me.menuBarUser.Controls.Add(Me.lblDate)
        Me.menuBarUser.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnNotification})
        Me.menuBarUser.Location = New System.Drawing.Point(532, 657)
        Me.menuBarUser.Name = "menuBarUser"
        Me.menuBarUser.Size = New System.Drawing.Size(476, 41)
        Me.menuBarUser.Stretch = True
        Me.menuBarUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.menuBarUser.TabIndex = 2
        Me.menuBarUser.TabStop = False
        '
        'lblNotification
        '
        Me.lblNotification.AutoSize = True
        Me.lblNotification.BackColor = System.Drawing.Color.Transparent
        Me.lblNotification.ForeColor = System.Drawing.Color.Red
        Me.lblNotification.Location = New System.Drawing.Point(21, 4)
        Me.lblNotification.Name = "lblNotification"
        Me.lblNotification.Size = New System.Drawing.Size(0, 15)
        Me.lblNotification.TabIndex = 4
        '
        'imgUser
        '
        Me.imgUser.BackColor = System.Drawing.Color.Transparent
        Me.imgUser.Location = New System.Drawing.Point(432, 3)
        Me.imgUser.Name = "imgUser"
        Me.imgUser.Size = New System.Drawing.Size(37, 35)
        Me.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgUser.TabIndex = 3
        Me.imgUser.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUser.Location = New System.Drawing.Point(329, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(97, 23)
        Me.lblUser.TabIndex = 2
        Me.lblUser.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(213, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(110, 23)
        Me.lblTime.TabIndex = 1
        Me.lblTime.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(52, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(155, 23)
        Me.lblDate.TabIndex = 0
        Me.lblDate.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnNotification
        '
        Me.btnNotification.AutoExpandOnClick = True
        Me.btnNotification.Image = Global.Payroll_Management_System.My.Resources.Resources.notification1
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.Text = "ButtonItem1"
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBarMain, Me.ToolStripStatusLabel1, Me.lblProcessStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 719)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1020, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProgressBarMain
        '
        Me.ProgressBarMain.Name = "ProgressBarMain"
        Me.ProgressBarMain.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(85, 17)
        Me.ToolStripStatusLabel1.Text = "Process Status:"
        '
        'lblProcessStatus
        '
        Me.lblProcessStatus.Name = "lblProcessStatus"
        Me.lblProcessStatus.Size = New System.Drawing.Size(0, 17)
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1020, 741)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.menuBarUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 8, 4, 8)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.menuBarUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuBarUser.ResumeLayout(False)
        Me.menuBarUser.PerformLayout()
        CType(Me.imgUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BonusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeInoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PositionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolidayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeLoanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuBarUser As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents btnNotification As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblDate As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTime As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblUser As DevComponents.DotNetBar.LabelX
    Friend WithEvents imgUser As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ReToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ProgressBarMain As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblProcessStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSalary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUserManagement As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAddress As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswordStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveOfEmployeeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EvaluaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNotification As System.Windows.Forms.Label
End Class

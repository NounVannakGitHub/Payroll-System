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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolBonus = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PHDayStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagemantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BenefitDeductionTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolAttendance = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AdminToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.AttendanceToolStripMenuItem, Me.WindowsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserManagemantToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem, Me.BenefitDeductionTypeToolStripMenuItem, Me.toolAttendance, Me.PHDayStatusToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AdminToolStripMenuItem.Text = "Maintains"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolBonus})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'toolBonus
        '
        Me.toolBonus.Name = "toolBonus"
        Me.toolBonus.Size = New System.Drawing.Size(107, 22)
        Me.toolBonus.Text = "Bonus"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.AttendanceToolStripMenuItem.Text = "Report"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.WindowsToolStripMenuItem.Text = "Windows"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'PHDayStatusToolStripMenuItem
        '
        Me.PHDayStatusToolStripMenuItem.Name = "PHDayStatusToolStripMenuItem"
        Me.PHDayStatusToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.PHDayStatusToolStripMenuItem.Text = "PH && Day status"
        '
        'UserManagemantToolStripMenuItem
        '
        Me.UserManagemantToolStripMenuItem.Image = CType(resources.GetObject("UserManagemantToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserManagemantToolStripMenuItem.Name = "UserManagemantToolStripMenuItem"
        Me.UserManagemantToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.UserManagemantToolStripMenuItem.Text = "User Managemant"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Image = CType(resources.GetObject("AddEmployeeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AddEmployeeToolStripMenuItem.Text = "Employee Setup"
        '
        'BenefitDeductionTypeToolStripMenuItem
        '
        Me.BenefitDeductionTypeToolStripMenuItem.Image = CType(resources.GetObject("BenefitDeductionTypeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BenefitDeductionTypeToolStripMenuItem.Name = "BenefitDeductionTypeToolStripMenuItem"
        Me.BenefitDeductionTypeToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.BenefitDeductionTypeToolStripMenuItem.Text = "Benefit/Deduction Type"
        '
        'toolAttendance
        '
        Me.toolAttendance.Image = CType(resources.GetObject("toolAttendance.Image"), System.Drawing.Image)
        Me.toolAttendance.Name = "toolAttendance"
        Me.toolAttendance.Size = New System.Drawing.Size(200, 22)
        Me.toolAttendance.Text = "Attendance"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1264, 749)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolBonus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BenefitDeductionTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolAttendance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManagemantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PHDayStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

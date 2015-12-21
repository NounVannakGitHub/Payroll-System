<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUser
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.cboEmpId = New System.Windows.Forms.ComboBox()
        Me.imgPhoto = New System.Windows.Forms.PictureBox()
        Me.btnSaveUser = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtConPassword = New System.Windows.Forms.TextBox()
        Me.gbUser = New System.Windows.Forms.GroupBox()
        Me.cbShowPassword = New System.Windows.Forms.CheckBox()
        Me.PanelEx1.SuspendLayout()
        CType(Me.imgPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.PictureBox2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Khmer OS Muol Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(491, 40)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.PaleGreen
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "លេខអ្នកប្រើប្រាស់"
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(130, 23)
        Me.txtUserId.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(136, 35)
        Me.txtUserId.TabIndex = 14
        '
        'cboEmpId
        '
        Me.cboEmpId.FormattingEnabled = True
        Me.cboEmpId.Location = New System.Drawing.Point(130, 61)
        Me.cboEmpId.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.cboEmpId.Name = "cboEmpId"
        Me.cboEmpId.Size = New System.Drawing.Size(136, 35)
        Me.cboEmpId.TabIndex = 15
        '
        'imgPhoto
        '
        Me.imgPhoto.BackgroundImage = Global.Payroll_Management_System.My.Resources.Resources._1442135434_Neon_Line_Social_Circles_50Icon_10px_grid_13
        Me.imgPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgPhoto.Image = Global.Payroll_Management_System.My.Resources.Resources.avatar
        Me.imgPhoto.Location = New System.Drawing.Point(272, 23)
        Me.imgPhoto.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.imgPhoto.Name = "imgPhoto"
        Me.imgPhoto.Size = New System.Drawing.Size(187, 219)
        Me.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPhoto.TabIndex = 16
        Me.imgPhoto.TabStop = False
        '
        'btnSaveUser
        '
        Me.btnSaveUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSaveUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSaveUser.Image = Global.Payroll_Management_System.My.Resources.Resources._1443380808_save
        Me.btnSaveUser.Location = New System.Drawing.Point(342, 275)
        Me.btnSaveUser.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.Size = New System.Drawing.Size(49, 48)
        Me.btnSaveUser.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "បន្ថែមអ្នកប្រើប្រាស់"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Payroll_Management_System.My.Resources.Resources._1442135746_close_red
        Me.PictureBox2.Location = New System.Drawing.Point(444, 2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 27)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "លេខបុគ្គលិក"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 27)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "គោត្តនាម"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(130, 99)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(136, 35)
        Me.txtLastName.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 27)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "នាម"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(130, 137)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(136, 35)
        Me.txtFirstName.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 27)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "មុខតំណែង"
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(130, 175)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(136, 35)
        Me.txtPosition.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 27)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ឈ្មោះប្រើប្រាស់"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(130, 212)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(136, 35)
        Me.txtUserName.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 27)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "លេខសំងាត់"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(130, 250)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(136, 35)
        Me.txtPassword.TabIndex = 14
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 27)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "បញ្ជាក់លេខសំងាត់"
        '
        'txtConPassword
        '
        Me.txtConPassword.Location = New System.Drawing.Point(130, 287)
        Me.txtConPassword.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtConPassword.Name = "txtConPassword"
        Me.txtConPassword.Size = New System.Drawing.Size(136, 35)
        Me.txtConPassword.TabIndex = 14
        Me.txtConPassword.UseSystemPasswordChar = True
        '
        'gbUser
        '
        Me.gbUser.Controls.Add(Me.btnSaveUser)
        Me.gbUser.Controls.Add(Me.cbShowPassword)
        Me.gbUser.Controls.Add(Me.cboEmpId)
        Me.gbUser.Controls.Add(Me.Label1)
        Me.gbUser.Controls.Add(Me.imgPhoto)
        Me.gbUser.Controls.Add(Me.txtUserId)
        Me.gbUser.Controls.Add(Me.Label3)
        Me.gbUser.Controls.Add(Me.txtConPassword)
        Me.gbUser.Controls.Add(Me.Label4)
        Me.gbUser.Controls.Add(Me.txtUserName)
        Me.gbUser.Controls.Add(Me.txtLastName)
        Me.gbUser.Controls.Add(Me.Label9)
        Me.gbUser.Controls.Add(Me.Label5)
        Me.gbUser.Controls.Add(Me.Label7)
        Me.gbUser.Controls.Add(Me.txtFirstName)
        Me.gbUser.Controls.Add(Me.txtPassword)
        Me.gbUser.Controls.Add(Me.Label6)
        Me.gbUser.Controls.Add(Me.Label8)
        Me.gbUser.Controls.Add(Me.txtPosition)
        Me.gbUser.Location = New System.Drawing.Point(12, 49)
        Me.gbUser.Name = "gbUser"
        Me.gbUser.Size = New System.Drawing.Size(468, 332)
        Me.gbUser.TabIndex = 18
        Me.gbUser.TabStop = False
        Me.gbUser.Text = "បំពេញព័ត៌មានអ្នកប្រើប្រាស់"
        '
        'cbShowPassword
        '
        Me.cbShowPassword.AutoSize = True
        Me.cbShowPassword.Location = New System.Drawing.Point(287, 246)
        Me.cbShowPassword.Name = "cbShowPassword"
        Me.cbShowPassword.Size = New System.Drawing.Size(133, 31)
        Me.cbShowPassword.TabIndex = 17
        Me.cbShowPassword.Text = "បង្ហាញលេខសំងាត់"
        Me.cbShowPassword.UseVisualStyleBackColor = True
        '
        'frmAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(491, 394)
        Me.Controls.Add(Me.gbUser)
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddUser"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.imgPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUser.ResumeLayout(False)
        Me.gbUser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents cboEmpId As System.Windows.Forms.ComboBox
    Friend WithEvents imgPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnSaveUser As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtConPassword As System.Windows.Forms.TextBox
    Friend WithEvents gbUser As System.Windows.Forms.GroupBox
    Friend WithEvents cbShowPassword As System.Windows.Forms.CheckBox
End Class

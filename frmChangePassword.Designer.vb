<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConNewPassword = New System.Windows.Forms.TextBox()
        Me.cboUserId = New System.Windows.Forms.ComboBox()
        Me.cbShowPassword = New System.Windows.Forms.CheckBox()
        Me.imgOldPassword = New System.Windows.Forms.PictureBox()
        Me.imgNewPassword = New System.Windows.Forms.PictureBox()
        Me.gbChange = New System.Windows.Forms.GroupBox()
        Me.btnChangePassword = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgOldPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNewPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbChange.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Khmer OS Muol Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(437, 36)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.PaleGreen
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Payroll_Management_System.My.Resources.Resources._1442135746_close_red
        Me.PictureBox1.Location = New System.Drawing.Point(393, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ផ្លាស់ប្តូរលេខសំងាត់"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 27)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "លេខអ្នកប្រើប្រាស់"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Enabled = False
        Me.txtOldPassword.Location = New System.Drawing.Point(140, 74)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.Size = New System.Drawing.Size(220, 35)
        Me.txtOldPassword.TabIndex = 15
        Me.txtOldPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 27)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "លេខសំងាត់ចាស់"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 27)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "លេខសំងាត់ថ្មី"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Enabled = False
        Me.txtNewPassword.Location = New System.Drawing.Point(140, 115)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(220, 35)
        Me.txtNewPassword.TabIndex = 15
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 27)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "បញ្ជាក់លេខសំងាត់ថ្មី"
        '
        'txtConNewPassword
        '
        Me.txtConNewPassword.Enabled = False
        Me.txtConNewPassword.Location = New System.Drawing.Point(140, 156)
        Me.txtConNewPassword.Name = "txtConNewPassword"
        Me.txtConNewPassword.Size = New System.Drawing.Size(220, 35)
        Me.txtConNewPassword.TabIndex = 15
        Me.txtConNewPassword.UseSystemPasswordChar = True
        '
        'cboUserId
        '
        Me.cboUserId.FormattingEnabled = True
        Me.cboUserId.Location = New System.Drawing.Point(140, 33)
        Me.cboUserId.Name = "cboUserId"
        Me.cboUserId.Size = New System.Drawing.Size(220, 35)
        Me.cboUserId.TabIndex = 16
        '
        'cbShowPassword
        '
        Me.cbShowPassword.AutoSize = True
        Me.cbShowPassword.Location = New System.Drawing.Point(24, 197)
        Me.cbShowPassword.Name = "cbShowPassword"
        Me.cbShowPassword.Size = New System.Drawing.Size(133, 31)
        Me.cbShowPassword.TabIndex = 17
        Me.cbShowPassword.Text = "បង្ហាញលេខសំងាត់"
        Me.cbShowPassword.UseVisualStyleBackColor = True
        '
        'imgOldPassword
        '
        Me.imgOldPassword.Image = Global.Payroll_Management_System.My.Resources.Resources.tick
        Me.imgOldPassword.Location = New System.Drawing.Point(366, 76)
        Me.imgOldPassword.Name = "imgOldPassword"
        Me.imgOldPassword.Size = New System.Drawing.Size(35, 34)
        Me.imgOldPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgOldPassword.TabIndex = 18
        Me.imgOldPassword.TabStop = False
        Me.imgOldPassword.Visible = False
        '
        'imgNewPassword
        '
        Me.imgNewPassword.Image = Global.Payroll_Management_System.My.Resources.Resources.tick
        Me.imgNewPassword.Location = New System.Drawing.Point(366, 157)
        Me.imgNewPassword.Name = "imgNewPassword"
        Me.imgNewPassword.Size = New System.Drawing.Size(35, 34)
        Me.imgNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgNewPassword.TabIndex = 18
        Me.imgNewPassword.TabStop = False
        Me.imgNewPassword.Visible = False
        '
        'gbChange
        '
        Me.gbChange.Controls.Add(Me.btnChangePassword)
        Me.gbChange.Controls.Add(Me.Label3)
        Me.gbChange.Controls.Add(Me.imgOldPassword)
        Me.gbChange.Controls.Add(Me.Label2)
        Me.gbChange.Controls.Add(Me.imgNewPassword)
        Me.gbChange.Controls.Add(Me.txtOldPassword)
        Me.gbChange.Controls.Add(Me.cbShowPassword)
        Me.gbChange.Controls.Add(Me.Label4)
        Me.gbChange.Controls.Add(Me.cboUserId)
        Me.gbChange.Controls.Add(Me.txtNewPassword)
        Me.gbChange.Controls.Add(Me.txtConNewPassword)
        Me.gbChange.Controls.Add(Me.Label5)
        Me.gbChange.Location = New System.Drawing.Point(12, 45)
        Me.gbChange.Name = "gbChange"
        Me.gbChange.Size = New System.Drawing.Size(415, 272)
        Me.gbChange.TabIndex = 19
        Me.gbChange.TabStop = False
        Me.gbChange.Text = "បំពេញការផ្លាស់ប្តូរ"
        '
        'btnChangePassword
        '
        Me.btnChangePassword.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnChangePassword.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnChangePassword.Image = Global.Payroll_Management_System.My.Resources.Resources._1443380808_save
        Me.btnChangePassword.Location = New System.Drawing.Point(185, 215)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(52, 51)
        Me.btnChangePassword.TabIndex = 19
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(437, 330)
        Me.Controls.Add(Me.gbChange)
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePassword"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password User"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgOldPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNewPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbChange.ResumeLayout(False)
        Me.gbChange.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtConNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents cboUserId As System.Windows.Forms.ComboBox
    Friend WithEvents cbShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents imgNewPassword As System.Windows.Forms.PictureBox
    Friend WithEvents imgOldPassword As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gbChange As System.Windows.Forms.GroupBox
    Friend WithEvents btnChangePassword As DevComponents.DotNetBar.ButtonX
End Class

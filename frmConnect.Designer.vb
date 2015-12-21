<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnect
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
        Me.cboDatabase = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnConnect = New DevComponents.DotNetBar.ButtonX()
        Me.txtUser = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cboServer = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chbShowPassword = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDatabase
        '
        Me.cboDatabase.DisplayMember = "Text"
        Me.cboDatabase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDatabase.FormattingEnabled = True
        Me.cboDatabase.ItemHeight = 14
        Me.cboDatabase.Location = New System.Drawing.Point(260, 47)
        Me.cboDatabase.Name = "cboDatabase"
        Me.cboDatabase.Size = New System.Drawing.Size(158, 20)
        Me.cboDatabase.TabIndex = 0
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(168, 99)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Password:"
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Location = New System.Drawing.Point(260, 99)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(158, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnConnect
        '
        Me.btnConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnConnect.Location = New System.Drawing.Point(303, 125)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 3
        Me.btnConnect.Text = "Connect"
        '
        'txtUser
        '
        '
        '
        '
        Me.txtUser.Border.Class = "TextBoxBorder"
        Me.txtUser.Location = New System.Drawing.Point(260, 73)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(158, 20)
        Me.txtUser.TabIndex = 5
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(168, 73)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "User:"
        '
        'LabelX3
        '
        Me.LabelX3.Location = New System.Drawing.Point(168, 47)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Database:"
        '
        'LabelX4
        '
        Me.LabelX4.Location = New System.Drawing.Point(168, 21)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Server:"
        '
        'cboServer
        '
        Me.cboServer.DisplayMember = "Text"
        Me.cboServer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboServer.FormattingEnabled = True
        Me.cboServer.ItemHeight = 14
        Me.cboServer.Location = New System.Drawing.Point(260, 21)
        Me.cboServer.Name = "cboServer"
        Me.cboServer.Size = New System.Drawing.Size(158, 20)
        Me.cboServer.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Payroll_Management_System.My.Resources.Resources.connectdatabase
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'chbShowPassword
        '
        Me.chbShowPassword.AutoSize = True
        Me.chbShowPassword.Location = New System.Drawing.Point(168, 128)
        Me.chbShowPassword.Name = "chbShowPassword"
        Me.chbShowPassword.Size = New System.Drawing.Size(102, 17)
        Me.chbShowPassword.TabIndex = 11
        Me.chbShowPassword.Text = "Show Password"
        Me.chbShowPassword.UseVisualStyleBackColor = True
        '
        'frmConnect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 168)
        Me.Controls.Add(Me.chbShowPassword)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.cboServer)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.cboDatabase)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnect"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connect to Server"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboDatabase As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnConnect As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtUser As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboServer As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chbShowPassword As System.Windows.Forms.CheckBox
End Class

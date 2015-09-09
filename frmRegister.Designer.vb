<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Me.txtLicenseName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnRegister = New DevComponents.DotNetBar.ButtonX()
        Me.txtLicenseKey = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLicenseName
        '
        '
        '
        '
        Me.txtLicenseName.Border.Class = "TextBoxBorder"
        Me.txtLicenseName.Location = New System.Drawing.Point(224, 12)
        Me.txtLicenseName.Name = "txtLicenseName"
        Me.txtLicenseName.Size = New System.Drawing.Size(296, 41)
        Me.txtLicenseName.TabIndex = 1
        '
        'btnRegister
        '
        Me.btnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRegister.Location = New System.Drawing.Point(224, 112)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(152, 34)
        Me.btnRegister.TabIndex = 2
        Me.btnRegister.Text = "ចុះកិច្ចសន្យា"
        '
        'txtLicenseKey
        '
        '
        '
        '
        Me.txtLicenseKey.Border.Class = "TextBoxBorder"
        Me.txtLicenseKey.Location = New System.Drawing.Point(224, 65)
        Me.txtLicenseKey.Name = "txtLicenseKey"
        Me.txtLicenseKey.Size = New System.Drawing.Size(296, 41)
        Me.txtLicenseKey.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Location = New System.Drawing.Point(382, 112)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(138, 34)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "បោះបង់ចោល"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Payroll_Management_System.My.Resources.Resources.License
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 34)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "អ្នកប្រើៈ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 34)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "សោរៈ"
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 168)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtLicenseKey)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtLicenseName)
        Me.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4, 8, 4, 8)
        Me.Name = "frmRegister"
        Me.Text = "ចុះកិច្ចសន្យាប្រើប្រាស់ប្រព័ន្ធគ្រប់គ្រង"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLicenseName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnRegister As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtLicenseKey As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

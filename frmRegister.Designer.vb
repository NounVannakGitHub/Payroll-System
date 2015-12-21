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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnGenerateName = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtToken = New System.Windows.Forms.TextBox()
        Me.btnGenerateKey = New DevComponents.DotNetBar.ButtonX()
        Me.btnRegister = New DevComponents.DotNetBar.ButtonX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(44, 33)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(367, 26)
        Me.txtName.TabIndex = 1
        '
        'btnGenerateName
        '
        Me.btnGenerateName.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGenerateName.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGenerateName.Enabled = False
        Me.btnGenerateName.Location = New System.Drawing.Point(428, 33)
        Me.btnGenerateName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGenerateName.Name = "btnGenerateName"
        Me.btnGenerateName.Size = New System.Drawing.Size(89, 26)
        Me.btnGenerateName.TabIndex = 2
        Me.btnGenerateName.Text = "Generate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Key"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(44, 81)
        Me.txtKey.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(367, 26)
        Me.txtKey.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Token"
        '
        'txtToken
        '
        Me.txtToken.Location = New System.Drawing.Point(44, 128)
        Me.txtToken.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtToken.Multiline = True
        Me.txtToken.Name = "txtToken"
        Me.txtToken.Size = New System.Drawing.Size(367, 65)
        Me.txtToken.TabIndex = 1
        '
        'btnGenerateKey
        '
        Me.btnGenerateKey.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGenerateKey.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGenerateKey.Enabled = False
        Me.btnGenerateKey.Location = New System.Drawing.Point(428, 81)
        Me.btnGenerateKey.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGenerateKey.Name = "btnGenerateKey"
        Me.btnGenerateKey.Size = New System.Drawing.Size(89, 26)
        Me.btnGenerateKey.TabIndex = 2
        Me.btnGenerateKey.Text = "Generate"
        '
        'btnRegister
        '
        Me.btnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRegister.Enabled = False
        Me.btnRegister.Location = New System.Drawing.Point(428, 128)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(89, 26)
        Me.btnRegister.TabIndex = 2
        Me.btnRegister.Text = "Register"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Location = New System.Drawing.Point(428, 167)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(89, 26)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 214)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnGenerateKey)
        Me.Controls.Add(Me.btnGenerateName)
        Me.Controls.Add(Me.txtToken)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegister"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ចុះកិច្ចសន្យាប្រើប្រាស់ប្រព័ន្ធគ្រប់គ្រង"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerateName As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtToken As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerateKey As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRegister As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
End Class

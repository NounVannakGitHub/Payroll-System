<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddLeave
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
        Me.gbLeave = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.txtMaternity = New System.Windows.Forms.TextBox()
        Me.txtSpecial = New System.Windows.Forms.TextBox()
        Me.txtSick = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAnnual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboEmployeeId = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.កូដបុគ្គលិក = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLeave.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(603, 43)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = "Add Leave"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Payroll_Management_System.My.Resources.Resources._1442135746_close_red
        Me.PictureBox1.Location = New System.Drawing.Point(561, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'gbLeave
        '
        Me.gbLeave.Controls.Add(Me.btnEdit)
        Me.gbLeave.Controls.Add(Me.btnSave)
        Me.gbLeave.Controls.Add(Me.txtMaternity)
        Me.gbLeave.Controls.Add(Me.txtSpecial)
        Me.gbLeave.Controls.Add(Me.txtSick)
        Me.gbLeave.Controls.Add(Me.Label6)
        Me.gbLeave.Controls.Add(Me.txtAnnual)
        Me.gbLeave.Controls.Add(Me.Label5)
        Me.gbLeave.Controls.Add(Me.txtRemark)
        Me.gbLeave.Controls.Add(Me.txtDay)
        Me.gbLeave.Controls.Add(Me.txtName)
        Me.gbLeave.Controls.Add(Me.Label4)
        Me.gbLeave.Controls.Add(Me.cboEmployeeId)
        Me.gbLeave.Controls.Add(Me.Label3)
        Me.gbLeave.Controls.Add(Me.CheckBox4)
        Me.gbLeave.Controls.Add(Me.CheckBox3)
        Me.gbLeave.Controls.Add(Me.Label8)
        Me.gbLeave.Controls.Add(Me.CheckBox2)
        Me.gbLeave.Controls.Add(Me.Label7)
        Me.gbLeave.Controls.Add(Me.CheckBox1)
        Me.gbLeave.Controls.Add(Me.Label2)
        Me.gbLeave.Controls.Add(Me.កូដបុគ្គលិក)
        Me.gbLeave.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLeave.Location = New System.Drawing.Point(12, 49)
        Me.gbLeave.Name = "gbLeave"
        Me.gbLeave.Size = New System.Drawing.Size(577, 350)
        Me.gbLeave.TabIndex = 0
        Me.gbLeave.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Enabled = False
        Me.btnEdit.Image = Global.Payroll_Management_System.My.Resources.Resources._1443478611_edit_notes
        Me.btnEdit.Location = New System.Drawing.Point(305, 293)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(56, 51)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Enabled = False
        Me.btnSave.Image = Global.Payroll_Management_System.My.Resources.Resources._1443380808_save
        Me.btnSave.Location = New System.Drawing.Point(243, 293)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(55, 51)
        Me.btnSave.TabIndex = 3
        Me.btnSave.TabStop = False
        '
        'txtMaternity
        '
        Me.txtMaternity.Enabled = False
        Me.txtMaternity.Location = New System.Drawing.Point(100, 239)
        Me.txtMaternity.Name = "txtMaternity"
        Me.txtMaternity.Size = New System.Drawing.Size(158, 35)
        Me.txtMaternity.TabIndex = 2
        Me.txtMaternity.TabStop = False
        '
        'txtSpecial
        '
        Me.txtSpecial.Enabled = False
        Me.txtSpecial.Location = New System.Drawing.Point(100, 198)
        Me.txtSpecial.Name = "txtSpecial"
        Me.txtSpecial.Size = New System.Drawing.Size(158, 35)
        Me.txtSpecial.TabIndex = 2
        Me.txtSpecial.TabStop = False
        '
        'txtSick
        '
        Me.txtSick.Enabled = False
        Me.txtSick.Location = New System.Drawing.Point(100, 157)
        Me.txtSick.Name = "txtSick"
        Me.txtSick.Size = New System.Drawing.Size(158, 35)
        Me.txtSick.TabIndex = 2
        Me.txtSick.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 27)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Maternity"
        '
        'txtAnnual
        '
        Me.txtAnnual.Enabled = False
        Me.txtAnnual.Location = New System.Drawing.Point(100, 116)
        Me.txtAnnual.Name = "txtAnnual"
        Me.txtAnnual.Size = New System.Drawing.Size(158, 35)
        Me.txtAnnual.TabIndex = 2
        Me.txtAnnual.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 27)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Special"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(381, 75)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(182, 199)
        Me.txtRemark.TabIndex = 2
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(381, 34)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(182, 35)
        Me.txtDay.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(100, 75)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(182, 35)
        Me.txtName.TabIndex = 2
        Me.txtName.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sick"
        '
        'cboEmployeeId
        '
        Me.cboEmployeeId.FormattingEnabled = True
        Me.cboEmployeeId.Location = New System.Drawing.Point(100, 34)
        Me.cboEmployeeId.Name = "cboEmployeeId"
        Me.cboEmployeeId.Size = New System.Drawing.Size(182, 35)
        Me.cboEmployeeId.TabIndex = 1
        Me.cboEmployeeId.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Annual"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(264, 249)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox4.TabIndex = 1
        Me.CheckBox4.TabStop = False
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(264, 208)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 1
        Me.CheckBox3.TabStop = False
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(298, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 27)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "មូលហេតុ"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(264, 167)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.TabStop = False
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(298, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 27)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ចំនួនថ្ងៃ"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(264, 128)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ឈ្មោះ"
        '
        'កូដបុគ្គលិក
        '
        Me.កូដបុគ្គលិក.AutoSize = True
        Me.កូដបុគ្គលិក.Location = New System.Drawing.Point(17, 37)
        Me.កូដបុគ្គលិក.Name = "កូដបុគ្គលិក"
        Me.កូដបុគ្គលិក.Size = New System.Drawing.Size(71, 27)
        Me.កូដបុគ្គលិក.TabIndex = 0
        Me.កូដបុគ្គលិក.Text = "កូដបុគ្គលិក"
        '
        'frmAddLeave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(601, 411)
        Me.Controls.Add(Me.gbLeave)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddLeave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddLeave"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLeave.ResumeLayout(False)
        Me.gbLeave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents gbLeave As System.Windows.Forms.GroupBox
    Friend WithEvents កូដបុគ្គលិក As System.Windows.Forms.Label
    Friend WithEvents cboEmployeeId As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAnnual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSick As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSpecial As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaternity As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
End Class

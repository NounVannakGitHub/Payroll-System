<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddTax
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
        Me.txtTaxId = New System.Windows.Forms.TextBox()
        Me.cboEmpId = New System.Windows.Forms.ComboBox()
        Me.btnSaveTaxEmployee = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmpLName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmpGender = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmpSalary = New System.Windows.Forms.TextBox()
        Me.gbTaxEmployee = New System.Windows.Forms.GroupBox()
        Me.imgEmployee = New System.Windows.Forms.PictureBox()
        Me.txtEmpPosition = New System.Windows.Forms.TextBox()
        Me.txtEmpTaxPersent = New System.Windows.Forms.TextBox()
        Me.txtEmpDepartment = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmpFName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmpStatus = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbTaxSpouse = New System.Windows.Forms.GroupBox()
        Me.txtEmpSpouseGender = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEmpSpouseLName = New System.Windows.Forms.TextBox()
        Me.txtEmpSpouseFName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEmpTaxForChildTotal = New System.Windows.Forms.TextBox()
        Me.txtEmpChildQty = New System.Windows.Forms.TextBox()
        Me.txtEmpSpouseJob = New System.Windows.Forms.TextBox()
        Me.txtEmpTaxForChild = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmpTaxForSpouse = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmpChild = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.gbTaxEmpButton = New System.Windows.Forms.GroupBox()
        Me.btnEditTaxEmployee = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTaxEmployee.SuspendLayout()
        CType(Me.imgEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTaxSpouse.SuspendLayout()
        Me.gbTaxEmpButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Khmer OS Muol Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(834, 40)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.SpringGreen
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = "បន្ថែមព័ន្ធបុគ្គលិក"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Payroll_Management_System.My.Resources.Resources._1442135746_close_red
        Me.PictureBox1.Location = New System.Drawing.Point(785, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 27)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "លេខពន្ធ"
        '
        'txtTaxId
        '
        Me.txtTaxId.Location = New System.Drawing.Point(94, 24)
        Me.txtTaxId.Name = "txtTaxId"
        Me.txtTaxId.Size = New System.Drawing.Size(100, 35)
        Me.txtTaxId.TabIndex = 1
        '
        'cboEmpId
        '
        Me.cboEmpId.FormattingEnabled = True
        Me.cboEmpId.Location = New System.Drawing.Point(94, 63)
        Me.cboEmpId.Name = "cboEmpId"
        Me.cboEmpId.Size = New System.Drawing.Size(100, 35)
        Me.cboEmpId.TabIndex = 2
        '
        'btnSaveTaxEmployee
        '
        Me.btnSaveTaxEmployee.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSaveTaxEmployee.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSaveTaxEmployee.Enabled = False
        Me.btnSaveTaxEmployee.Image = Global.Payroll_Management_System.My.Resources.Resources._1443380808_save
        Me.btnSaveTaxEmployee.Location = New System.Drawing.Point(141, 28)
        Me.btnSaveTaxEmployee.Name = "btnSaveTaxEmployee"
        Me.btnSaveTaxEmployee.Size = New System.Drawing.Size(49, 45)
        Me.btnSaveTaxEmployee.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 27)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "គោត្តនាម"
        '
        'txtEmpLName
        '
        Me.txtEmpLName.Location = New System.Drawing.Point(94, 103)
        Me.txtEmpLName.Name = "txtEmpLName"
        Me.txtEmpLName.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpLName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 27)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "ភេទ"
        '
        'txtEmpGender
        '
        Me.txtEmpGender.Location = New System.Drawing.Point(94, 181)
        Me.txtEmpGender.Name = "txtEmpGender"
        Me.txtEmpGender.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpGender.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 27)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "ប្រាក់ខែ"
        '
        'txtEmpSalary
        '
        Me.txtEmpSalary.Location = New System.Drawing.Point(94, 304)
        Me.txtEmpSalary.Name = "txtEmpSalary"
        Me.txtEmpSalary.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpSalary.TabIndex = 23
        '
        'gbTaxEmployee
        '
        Me.gbTaxEmployee.Controls.Add(Me.imgEmployee)
        Me.gbTaxEmployee.Controls.Add(Me.txtEmpPosition)
        Me.gbTaxEmployee.Controls.Add(Me.txtEmpTaxPersent)
        Me.gbTaxEmployee.Controls.Add(Me.txtEmpDepartment)
        Me.gbTaxEmployee.Controls.Add(Me.txtEmpSalary)
        Me.gbTaxEmployee.Controls.Add(Me.cboEmpId)
        Me.gbTaxEmployee.Controls.Add(Me.Label14)
        Me.gbTaxEmployee.Controls.Add(Me.Label1)
        Me.gbTaxEmployee.Controls.Add(Me.txtTaxId)
        Me.gbTaxEmployee.Controls.Add(Me.Label13)
        Me.gbTaxEmployee.Controls.Add(Me.Label2)
        Me.gbTaxEmployee.Controls.Add(Me.txtEmpFName)
        Me.gbTaxEmployee.Controls.Add(Me.txtEmpLName)
        Me.gbTaxEmployee.Controls.Add(Me.Label11)
        Me.gbTaxEmployee.Controls.Add(Me.Label3)
        Me.gbTaxEmployee.Controls.Add(Me.txtEmpStatus)
        Me.gbTaxEmployee.Controls.Add(Me.Label10)
        Me.gbTaxEmployee.Controls.Add(Me.txtEmpGender)
        Me.gbTaxEmployee.Controls.Add(Me.Label5)
        Me.gbTaxEmployee.Controls.Add(Me.Label9)
        Me.gbTaxEmployee.Controls.Add(Me.Label4)
        Me.gbTaxEmployee.Location = New System.Drawing.Point(12, 50)
        Me.gbTaxEmployee.Name = "gbTaxEmployee"
        Me.gbTaxEmployee.Size = New System.Drawing.Size(404, 352)
        Me.gbTaxEmployee.TabIndex = 26
        Me.gbTaxEmployee.TabStop = False
        Me.gbTaxEmployee.Text = "អំពីបុគ្គលិក"
        '
        'imgEmployee
        '
        Me.imgEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgEmployee.Image = Global.Payroll_Management_System.My.Resources.Resources.avatar
        Me.imgEmployee.Location = New System.Drawing.Point(210, 24)
        Me.imgEmployee.Name = "imgEmployee"
        Me.imgEmployee.Size = New System.Drawing.Size(178, 228)
        Me.imgEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEmployee.TabIndex = 25
        Me.imgEmployee.TabStop = False
        '
        'txtEmpPosition
        '
        Me.txtEmpPosition.Location = New System.Drawing.Point(288, 263)
        Me.txtEmpPosition.Name = "txtEmpPosition"
        Me.txtEmpPosition.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpPosition.TabIndex = 23
        '
        'txtEmpTaxPersent
        '
        Me.txtEmpTaxPersent.Location = New System.Drawing.Point(288, 304)
        Me.txtEmpTaxPersent.Name = "txtEmpTaxPersent"
        Me.txtEmpTaxPersent.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpTaxPersent.TabIndex = 23
        '
        'txtEmpDepartment
        '
        Me.txtEmpDepartment.Location = New System.Drawing.Point(94, 263)
        Me.txtEmpDepartment.Name = "txtEmpDepartment"
        Me.txtEmpDepartment.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpDepartment.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 27)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "លេខបុគ្គលិក"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 27)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "នាម"
        '
        'txtEmpFName
        '
        Me.txtEmpFName.Location = New System.Drawing.Point(94, 142)
        Me.txtEmpFName.Name = "txtEmpFName"
        Me.txtEmpFName.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpFName.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 225)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 27)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "ស្ថានភាព"
        '
        'txtEmpStatus
        '
        Me.txtEmpStatus.Location = New System.Drawing.Point(94, 222)
        Me.txtEmpStatus.Name = "txtEmpStatus"
        Me.txtEmpStatus.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpStatus.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(200, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 27)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "មុខតំណែង"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 27)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "ផ្នែក"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(200, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 27)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "ពន្ធប្រាក់ខែ(%)"
        '
        'gbTaxSpouse
        '
        Me.gbTaxSpouse.Controls.Add(Me.txtEmpSpouseGender)
        Me.gbTaxSpouse.Controls.Add(Me.Label15)
        Me.gbTaxSpouse.Controls.Add(Me.Label16)
        Me.gbTaxSpouse.Controls.Add(Me.txtEmpSpouseLName)
        Me.gbTaxSpouse.Controls.Add(Me.txtEmpSpouseFName)
        Me.gbTaxSpouse.Controls.Add(Me.Label17)
        Me.gbTaxSpouse.Controls.Add(Me.Label18)
        Me.gbTaxSpouse.Controls.Add(Me.txtEmpTaxForChildTotal)
        Me.gbTaxSpouse.Controls.Add(Me.txtEmpChildQty)
        Me.gbTaxSpouse.Controls.Add(Me.txtEmpSpouseJob)
        Me.gbTaxSpouse.Controls.Add(Me.txtEmpTaxForChild)
        Me.gbTaxSpouse.Controls.Add(Me.Label8)
        Me.gbTaxSpouse.Controls.Add(Me.txtEmpTaxForSpouse)
        Me.gbTaxSpouse.Controls.Add(Me.Label6)
        Me.gbTaxSpouse.Controls.Add(Me.Label7)
        Me.gbTaxSpouse.Controls.Add(Me.txtEmpChild)
        Me.gbTaxSpouse.Controls.Add(Me.Label19)
        Me.gbTaxSpouse.Controls.Add(Me.Label20)
        Me.gbTaxSpouse.Location = New System.Drawing.Point(422, 50)
        Me.gbTaxSpouse.Name = "gbTaxSpouse"
        Me.gbTaxSpouse.Size = New System.Drawing.Size(399, 269)
        Me.gbTaxSpouse.TabIndex = 27
        Me.gbTaxSpouse.TabStop = False
        Me.gbTaxSpouse.Text = "អំពីប្តី​ /​ ប្រពន្ធ"
        '
        'txtEmpSpouseGender
        '
        Me.txtEmpSpouseGender.Location = New System.Drawing.Point(91, 63)
        Me.txtEmpSpouseGender.Name = "txtEmpSpouseGender"
        Me.txtEmpSpouseGender.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpSpouseGender.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 27)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "គោត្តនាម"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(197, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 27)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "នាម"
        '
        'txtEmpSpouseLName
        '
        Me.txtEmpSpouseLName.Location = New System.Drawing.Point(91, 24)
        Me.txtEmpSpouseLName.Name = "txtEmpSpouseLName"
        Me.txtEmpSpouseLName.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpSpouseLName.TabIndex = 23
        '
        'txtEmpSpouseFName
        '
        Me.txtEmpSpouseFName.Location = New System.Drawing.Point(280, 24)
        Me.txtEmpSpouseFName.Name = "txtEmpSpouseFName"
        Me.txtEmpSpouseFName.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpSpouseFName.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 66)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 27)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "ភេទ"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(197, 66)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 27)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "មុខរបរ"
        '
        'txtEmpTaxForChildTotal
        '
        Me.txtEmpTaxForChildTotal.Enabled = False
        Me.txtEmpTaxForChildTotal.Location = New System.Drawing.Point(280, 186)
        Me.txtEmpTaxForChildTotal.Name = "txtEmpTaxForChildTotal"
        Me.txtEmpTaxForChildTotal.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpTaxForChildTotal.TabIndex = 23
        Me.txtEmpTaxForChildTotal.Text = "0"
        '
        'txtEmpChildQty
        '
        Me.txtEmpChildQty.Location = New System.Drawing.Point(280, 104)
        Me.txtEmpChildQty.Name = "txtEmpChildQty"
        Me.txtEmpChildQty.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpChildQty.TabIndex = 23
        '
        'txtEmpSpouseJob
        '
        Me.txtEmpSpouseJob.Location = New System.Drawing.Point(280, 63)
        Me.txtEmpSpouseJob.Name = "txtEmpSpouseJob"
        Me.txtEmpSpouseJob.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpSpouseJob.TabIndex = 23
        '
        'txtEmpTaxForChild
        '
        Me.txtEmpTaxForChild.Enabled = False
        Me.txtEmpTaxForChild.Location = New System.Drawing.Point(91, 186)
        Me.txtEmpTaxForChild.Name = "txtEmpTaxForChild"
        Me.txtEmpTaxForChild.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpTaxForChild.TabIndex = 23
        Me.txtEmpTaxForChild.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 27)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "ប្រាក់លើកូន"
        '
        'txtEmpTaxForSpouse
        '
        Me.txtEmpTaxForSpouse.Enabled = False
        Me.txtEmpTaxForSpouse.Location = New System.Drawing.Point(116, 145)
        Me.txtEmpTaxForSpouse.Name = "txtEmpTaxForSpouse"
        Me.txtEmpTaxForSpouse.Size = New System.Drawing.Size(264, 35)
        Me.txtEmpTaxForSpouse.TabIndex = 23
        Me.txtEmpTaxForSpouse.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 27)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "ប្រាក់លើប្តី/ប្រពន្ធ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(197, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 27)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "សរុបលើកូន"
        '
        'txtEmpChild
        '
        Me.txtEmpChild.Location = New System.Drawing.Point(91, 104)
        Me.txtEmpChild.Name = "txtEmpChild"
        Me.txtEmpChild.Size = New System.Drawing.Size(100, 35)
        Me.txtEmpChild.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 107)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 27)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "អំពីកូន"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(197, 107)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 27)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "ចំនួនកូន"
        '
        'gbTaxEmpButton
        '
        Me.gbTaxEmpButton.Controls.Add(Me.btnEditTaxEmployee)
        Me.gbTaxEmpButton.Controls.Add(Me.btnSaveTaxEmployee)
        Me.gbTaxEmpButton.Location = New System.Drawing.Point(422, 313)
        Me.gbTaxEmpButton.Name = "gbTaxEmpButton"
        Me.gbTaxEmpButton.Size = New System.Drawing.Size(399, 89)
        Me.gbTaxEmpButton.TabIndex = 28
        Me.gbTaxEmpButton.TabStop = False
        '
        'btnEditTaxEmployee
        '
        Me.btnEditTaxEmployee.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEditTaxEmployee.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEditTaxEmployee.Enabled = False
        Me.btnEditTaxEmployee.Image = Global.Payroll_Management_System.My.Resources.Resources._1443478611_edit_notes
        Me.btnEditTaxEmployee.Location = New System.Drawing.Point(205, 28)
        Me.btnEditTaxEmployee.Name = "btnEditTaxEmployee"
        Me.btnEditTaxEmployee.Size = New System.Drawing.Size(49, 45)
        Me.btnEditTaxEmployee.TabIndex = 25
        '
        'frmAddTax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(834, 416)
        Me.Controls.Add(Me.gbTaxSpouse)
        Me.Controls.Add(Me.gbTaxEmpButton)
        Me.Controls.Add(Me.gbTaxEmployee)
        Me.Controls.Add(Me.PanelEx1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddTax"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTaxEmployee.ResumeLayout(False)
        Me.gbTaxEmployee.PerformLayout()
        CType(Me.imgEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTaxSpouse.ResumeLayout(False)
        Me.gbTaxSpouse.PerformLayout()
        Me.gbTaxEmpButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTaxId As System.Windows.Forms.TextBox
    Friend WithEvents cboEmpId As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveTaxEmployee As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmpLName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmpGender As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmpSalary As System.Windows.Forms.TextBox
    Friend WithEvents gbTaxEmployee As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmpTaxPersent As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEmpFName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEmpStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gbTaxSpouse As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmpSpouseGender As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtEmpSpouseLName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpSpouseFName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtEmpChildQty As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpSpouseJob As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpChild As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtEmpTaxForSpouse As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmpTaxForChildTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpTaxForChild As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents imgEmployee As System.Windows.Forms.PictureBox
    Friend WithEvents gbTaxEmpButton As System.Windows.Forms.GroupBox
    Friend WithEvents btnEditTaxEmployee As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtEmpPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpDepartment As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

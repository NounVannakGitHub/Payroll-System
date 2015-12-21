<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalaryPaySlip
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.cboEmpId = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBasicSalary = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTaxSpouse = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTaxChild = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBasicSalary2 = New System.Windows.Forms.TextBox()
        Me.gbMain = New System.Windows.Forms.GroupBox()
        Me.gbNetBase = New System.Windows.Forms.GroupBox()
        Me.chb14 = New System.Windows.Forms.CheckBox()
        Me.chb13 = New System.Windows.Forms.CheckBox()
        Me.chbDecre = New System.Windows.Forms.CheckBox()
        Me.chbIncre = New System.Windows.Forms.CheckBox()
        Me.txtAnnualAward = New System.Windows.Forms.TextBox()
        Me.txtAdjust = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNetBase = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIncre = New System.Windows.Forms.TextBox()
        Me.txtSalary14 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDecre = New System.Windows.Forms.TextBox()
        Me.txtSalary13 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gbAllowance = New System.Windows.Forms.GroupBox()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.txtIncentive = New System.Windows.Forms.TextBox()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnCalculate = New DevComponents.DotNetBar.ButtonX()
        Me.txtReginal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTransport = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtOverTime = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSalaryBeforeTax = New System.Windows.Forms.TextBox()
        Me.gbSalary = New System.Windows.Forms.GroupBox()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMain.SuspendLayout()
        Me.gbNetBase.SuspendLayout()
        Me.gbAllowance.SuspendLayout()
        Me.gbSalary.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Font = New System.Drawing.Font("Khmer OS Muol Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(884, 42)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Payroll_Management_System.My.Resources.Resources._1442135746_close_red1
        Me.PictureBox1.Location = New System.Drawing.Point(845, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(368, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "បើកប្រាក់ខែបុគ្គលិក"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "លេខបុគ្គលិក"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(695, 22)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(150, 35)
        Me.txtSubTotal.TabIndex = 2
        Me.txtSubTotal.TabStop = False
        Me.txtSubTotal.Text = "0"
        '
        'cboEmpId
        '
        Me.cboEmpId.FormattingEnabled = True
        Me.cboEmpId.Location = New System.Drawing.Point(117, 26)
        Me.cboEmpId.Name = "cboEmpId"
        Me.cboEmpId.Size = New System.Drawing.Size(150, 35)
        Me.cboEmpId.TabIndex = 0
        Me.cboEmpId.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 27)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "គោត្តនាម"
        '
        'txtLastName
        '
        Me.txtLastName.Enabled = False
        Me.txtLastName.Location = New System.Drawing.Point(117, 67)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(150, 35)
        Me.txtLastName.TabIndex = 2
        Me.txtLastName.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 27)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "នាម"
        '
        'txtFirstName
        '
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Location = New System.Drawing.Point(117, 108)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(150, 35)
        Me.txtFirstName.TabIndex = 2
        Me.txtFirstName.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 27)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ប្រាក់ខែគោល"
        '
        'txtBasicSalary
        '
        Me.txtBasicSalary.Enabled = False
        Me.txtBasicSalary.Location = New System.Drawing.Point(117, 149)
        Me.txtBasicSalary.Name = "txtBasicSalary"
        Me.txtBasicSalary.Size = New System.Drawing.Size(150, 35)
        Me.txtBasicSalary.TabIndex = 2
        Me.txtBasicSalary.TabStop = False
        Me.txtBasicSalary.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 27)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ប្រាក់លើប្តី/ប្រព័ន្ធ"
        '
        'txtTaxSpouse
        '
        Me.txtTaxSpouse.Enabled = False
        Me.txtTaxSpouse.Location = New System.Drawing.Point(117, 190)
        Me.txtTaxSpouse.Name = "txtTaxSpouse"
        Me.txtTaxSpouse.Size = New System.Drawing.Size(150, 35)
        Me.txtTaxSpouse.TabIndex = 2
        Me.txtTaxSpouse.TabStop = False
        Me.txtTaxSpouse.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 27)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "ប្រាក់លើកូន"
        '
        'txtTaxChild
        '
        Me.txtTaxChild.Enabled = False
        Me.txtTaxChild.Location = New System.Drawing.Point(117, 231)
        Me.txtTaxChild.Name = "txtTaxChild"
        Me.txtTaxChild.Size = New System.Drawing.Size(150, 35)
        Me.txtTaxChild.TabIndex = 2
        Me.txtTaxChild.TabStop = False
        Me.txtTaxChild.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 27)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "ប្រាក់ប្រតិបត្តិ"
        '
        'txtBasicSalary2
        '
        Me.txtBasicSalary2.Enabled = False
        Me.txtBasicSalary2.Location = New System.Drawing.Point(117, 272)
        Me.txtBasicSalary2.Name = "txtBasicSalary2"
        Me.txtBasicSalary2.Size = New System.Drawing.Size(150, 35)
        Me.txtBasicSalary2.TabIndex = 2
        Me.txtBasicSalary2.TabStop = False
        Me.txtBasicSalary2.Text = "0"
        '
        'gbMain
        '
        Me.gbMain.Controls.Add(Me.txtLastName)
        Me.gbMain.Controls.Add(Me.cboEmpId)
        Me.gbMain.Controls.Add(Me.Label1)
        Me.gbMain.Controls.Add(Me.Label3)
        Me.gbMain.Controls.Add(Me.txtBasicSalary2)
        Me.gbMain.Controls.Add(Me.Label4)
        Me.gbMain.Controls.Add(Me.Label8)
        Me.gbMain.Controls.Add(Me.txtFirstName)
        Me.gbMain.Controls.Add(Me.txtTaxChild)
        Me.gbMain.Controls.Add(Me.Label5)
        Me.gbMain.Controls.Add(Me.Label7)
        Me.gbMain.Controls.Add(Me.txtBasicSalary)
        Me.gbMain.Controls.Add(Me.txtTaxSpouse)
        Me.gbMain.Controls.Add(Me.Label6)
        Me.gbMain.Location = New System.Drawing.Point(12, 48)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Size = New System.Drawing.Size(284, 323)
        Me.gbMain.TabIndex = 0
        Me.gbMain.TabStop = False
        '
        'gbNetBase
        '
        Me.gbNetBase.Controls.Add(Me.chb14)
        Me.gbNetBase.Controls.Add(Me.chb13)
        Me.gbNetBase.Controls.Add(Me.chbDecre)
        Me.gbNetBase.Controls.Add(Me.chbIncre)
        Me.gbNetBase.Controls.Add(Me.txtAnnualAward)
        Me.gbNetBase.Controls.Add(Me.txtAdjust)
        Me.gbNetBase.Controls.Add(Me.Label9)
        Me.gbNetBase.Controls.Add(Me.Label10)
        Me.gbNetBase.Controls.Add(Me.txtNetBase)
        Me.gbNetBase.Controls.Add(Me.Label11)
        Me.gbNetBase.Controls.Add(Me.Label12)
        Me.gbNetBase.Controls.Add(Me.txtIncre)
        Me.gbNetBase.Controls.Add(Me.txtSalary14)
        Me.gbNetBase.Controls.Add(Me.Label13)
        Me.gbNetBase.Controls.Add(Me.Label14)
        Me.gbNetBase.Controls.Add(Me.txtDecre)
        Me.gbNetBase.Controls.Add(Me.txtSalary13)
        Me.gbNetBase.Controls.Add(Me.Label15)
        Me.gbNetBase.Location = New System.Drawing.Point(302, 48)
        Me.gbNetBase.Name = "gbNetBase"
        Me.gbNetBase.Size = New System.Drawing.Size(282, 323)
        Me.gbNetBase.TabIndex = 0
        Me.gbNetBase.TabStop = False
        '
        'chb14
        '
        Me.chb14.AutoSize = True
        Me.chb14.Location = New System.Drawing.Point(246, 241)
        Me.chb14.Name = "chb14"
        Me.chb14.Size = New System.Drawing.Size(15, 14)
        Me.chb14.TabIndex = 3
        Me.chb14.TabStop = False
        Me.chb14.UseVisualStyleBackColor = True
        '
        'chb13
        '
        Me.chb13.AutoSize = True
        Me.chb13.Location = New System.Drawing.Point(246, 200)
        Me.chb13.Name = "chb13"
        Me.chb13.Size = New System.Drawing.Size(15, 14)
        Me.chb13.TabIndex = 3
        Me.chb13.TabStop = False
        Me.chb13.UseVisualStyleBackColor = True
        '
        'chbDecre
        '
        Me.chbDecre.AutoSize = True
        Me.chbDecre.Location = New System.Drawing.Point(246, 159)
        Me.chbDecre.Name = "chbDecre"
        Me.chbDecre.Size = New System.Drawing.Size(15, 14)
        Me.chbDecre.TabIndex = 3
        Me.chbDecre.TabStop = False
        Me.chbDecre.UseVisualStyleBackColor = True
        '
        'chbIncre
        '
        Me.chbIncre.AutoSize = True
        Me.chbIncre.Location = New System.Drawing.Point(246, 118)
        Me.chbIncre.Name = "chbIncre"
        Me.chbIncre.Size = New System.Drawing.Size(15, 14)
        Me.chbIncre.TabIndex = 3
        Me.chbIncre.TabStop = False
        Me.chbIncre.UseVisualStyleBackColor = True
        '
        'txtAnnualAward
        '
        Me.txtAnnualAward.Location = New System.Drawing.Point(117, 26)
        Me.txtAnnualAward.Name = "txtAnnualAward"
        Me.txtAnnualAward.Size = New System.Drawing.Size(150, 35)
        Me.txtAnnualAward.TabIndex = 1
        Me.txtAnnualAward.Text = "0"
        '
        'txtAdjust
        '
        Me.txtAdjust.Location = New System.Drawing.Point(117, 67)
        Me.txtAdjust.Name = "txtAdjust"
        Me.txtAdjust.Size = New System.Drawing.Size(150, 35)
        Me.txtAdjust.TabIndex = 2
        Me.txtAdjust.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 27)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "ប្រាក់រង្វាន់"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 27)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "ប្រាក់មុខតំណែង"
        '
        'txtNetBase
        '
        Me.txtNetBase.Enabled = False
        Me.txtNetBase.Location = New System.Drawing.Point(117, 272)
        Me.txtNetBase.Name = "txtNetBase"
        Me.txtNetBase.Size = New System.Drawing.Size(150, 35)
        Me.txtNetBase.TabIndex = 2
        Me.txtNetBase.TabStop = False
        Me.txtNetBase.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 27)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "បន្ថែមប្រាក់ខែ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 27)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "ប្រាក់ខែសរុប"
        '
        'txtIncre
        '
        Me.txtIncre.Enabled = False
        Me.txtIncre.Location = New System.Drawing.Point(117, 108)
        Me.txtIncre.Name = "txtIncre"
        Me.txtIncre.Size = New System.Drawing.Size(123, 35)
        Me.txtIncre.TabIndex = 3
        Me.txtIncre.Text = "0"
        '
        'txtSalary14
        '
        Me.txtSalary14.Enabled = False
        Me.txtSalary14.Location = New System.Drawing.Point(117, 231)
        Me.txtSalary14.Name = "txtSalary14"
        Me.txtSalary14.Size = New System.Drawing.Size(123, 35)
        Me.txtSalary14.TabIndex = 6
        Me.txtSalary14.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 27)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "កាត់ប្រាក់ខែ"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 234)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 27)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "ប្រាក់ខែទី១៤"
        '
        'txtDecre
        '
        Me.txtDecre.Enabled = False
        Me.txtDecre.Location = New System.Drawing.Point(117, 149)
        Me.txtDecre.Name = "txtDecre"
        Me.txtDecre.Size = New System.Drawing.Size(123, 35)
        Me.txtDecre.TabIndex = 4
        Me.txtDecre.Text = "0"
        '
        'txtSalary13
        '
        Me.txtSalary13.Enabled = False
        Me.txtSalary13.Location = New System.Drawing.Point(117, 190)
        Me.txtSalary13.Name = "txtSalary13"
        Me.txtSalary13.Size = New System.Drawing.Size(123, 35)
        Me.txtSalary13.TabIndex = 5
        Me.txtSalary13.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 193)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 27)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "ប្រាក់ខែទី១៣"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(592, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 27)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "ប្រាក់ខែត្រូវបើក"
        '
        'gbAllowance
        '
        Me.gbAllowance.Controls.Add(Me.dtpTo)
        Me.gbAllowance.Controls.Add(Me.dtpFrom)
        Me.gbAllowance.Controls.Add(Me.txtIncentive)
        Me.gbAllowance.Controls.Add(Me.btnPrint)
        Me.gbAllowance.Controls.Add(Me.btnSave)
        Me.gbAllowance.Controls.Add(Me.btnCalculate)
        Me.gbAllowance.Controls.Add(Me.txtReginal)
        Me.gbAllowance.Controls.Add(Me.Label17)
        Me.gbAllowance.Controls.Add(Me.Label18)
        Me.gbAllowance.Controls.Add(Me.Label19)
        Me.gbAllowance.Controls.Add(Me.txtTransport)
        Me.gbAllowance.Controls.Add(Me.Label22)
        Me.gbAllowance.Controls.Add(Me.Label20)
        Me.gbAllowance.Controls.Add(Me.Label21)
        Me.gbAllowance.Controls.Add(Me.txtOverTime)
        Me.gbAllowance.Location = New System.Drawing.Point(590, 48)
        Me.gbAllowance.Name = "gbAllowance"
        Me.gbAllowance.Size = New System.Drawing.Size(282, 323)
        Me.gbAllowance.TabIndex = 0
        Me.gbAllowance.TabStop = False
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(117, 231)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(150, 35)
        Me.dtpTo.TabIndex = 3
        Me.dtpTo.TabStop = False
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(117, 190)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(150, 35)
        Me.dtpFrom.TabIndex = 11
        Me.dtpFrom.TabStop = False
        '
        'txtIncentive
        '
        Me.txtIncentive.Location = New System.Drawing.Point(117, 26)
        Me.txtIncentive.Name = "txtIncentive"
        Me.txtIncentive.Size = New System.Drawing.Size(150, 35)
        Me.txtIncentive.TabIndex = 7
        Me.txtIncentive.Text = "0"
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrint.Enabled = False
        Me.btnPrint.Image = Global.Payroll_Management_System.My.Resources.Resources._1444907035_print
        Me.btnPrint.Location = New System.Drawing.Point(194, 272)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(73, 45)
        Me.btnPrint.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Enabled = False
        Me.btnSave.Image = Global.Payroll_Management_System.My.Resources.Resources._1443380808_save
        Me.btnSave.Location = New System.Drawing.Point(106, 272)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 45)
        Me.btnSave.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCalculate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCalculate.Image = Global.Payroll_Management_System.My.Resources.Resources._1444907193_calculator
        Me.btnCalculate.Location = New System.Drawing.Point(18, 272)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(73, 45)
        Me.btnCalculate.TabIndex = 3
        '
        'txtReginal
        '
        Me.txtReginal.Location = New System.Drawing.Point(117, 67)
        Me.txtReginal.Name = "txtReginal"
        Me.txtReginal.Size = New System.Drawing.Size(150, 35)
        Me.txtReginal.TabIndex = 8
        Me.txtReginal.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 27)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "ប្រាក់លើកទឹកចិត្ត"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 27)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "ប្រាក់តំបន់"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(13, 111)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 27)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "ប្រាក់ធ្វើដំណើរ"
        '
        'txtTransport
        '
        Me.txtTransport.Location = New System.Drawing.Point(117, 108)
        Me.txtTransport.Name = "txtTransport"
        Me.txtTransport.Size = New System.Drawing.Size(150, 35)
        Me.txtTransport.TabIndex = 9
        Me.txtTransport.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(13, 237)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 27)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "ដល់ថ្ងៃទី"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(14, 196)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 27)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "ចាប់គិតពីថ្ងៃទី"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 152)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 27)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "ប្រាក់ថែមម៉ោង"
        '
        'txtOverTime
        '
        Me.txtOverTime.Location = New System.Drawing.Point(117, 149)
        Me.txtOverTime.Name = "txtOverTime"
        Me.txtOverTime.Size = New System.Drawing.Size(150, 35)
        Me.txtOverTime.TabIndex = 10
        Me.txtOverTime.Text = "0"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(303, 25)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(132, 27)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "បង់ពន្ធលើប្រាក់ខែ​ (%)"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(434, 22)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(123, 35)
        Me.txtTax.TabIndex = 2
        Me.txtTax.TabStop = False
        Me.txtTax.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(17, 25)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(99, 27)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "ប្រាក់ខែអតិបរមា"
        '
        'txtSalaryBeforeTax
        '
        Me.txtSalaryBeforeTax.Location = New System.Drawing.Point(117, 22)
        Me.txtSalaryBeforeTax.Name = "txtSalaryBeforeTax"
        Me.txtSalaryBeforeTax.Size = New System.Drawing.Size(150, 35)
        Me.txtSalaryBeforeTax.TabIndex = 2
        Me.txtSalaryBeforeTax.TabStop = False
        Me.txtSalaryBeforeTax.Text = "0"
        '
        'gbSalary
        '
        Me.gbSalary.Controls.Add(Me.txtTax)
        Me.gbSalary.Controls.Add(Me.Label16)
        Me.gbSalary.Controls.Add(Me.Label23)
        Me.gbSalary.Controls.Add(Me.Label24)
        Me.gbSalary.Controls.Add(Me.txtSalaryBeforeTax)
        Me.gbSalary.Controls.Add(Me.txtSubTotal)
        Me.gbSalary.Enabled = False
        Me.gbSalary.Location = New System.Drawing.Point(12, 363)
        Me.gbSalary.Name = "gbSalary"
        Me.gbSalary.Size = New System.Drawing.Size(860, 66)
        Me.gbSalary.TabIndex = 0
        Me.gbSalary.TabStop = False
        '
        'frmSalaryPaySlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 440)
        Me.Controls.Add(Me.gbMain)
        Me.Controls.Add(Me.gbNetBase)
        Me.Controls.Add(Me.gbAllowance)
        Me.Controls.Add(Me.gbSalary)
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "frmSalaryPaySlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSalaryPaySlip"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMain.ResumeLayout(False)
        Me.gbMain.PerformLayout()
        Me.gbNetBase.ResumeLayout(False)
        Me.gbNetBase.PerformLayout()
        Me.gbAllowance.ResumeLayout(False)
        Me.gbAllowance.PerformLayout()
        Me.gbSalary.ResumeLayout(False)
        Me.gbSalary.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboEmpId As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBasicSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTaxSpouse As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTaxChild As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBasicSalary2 As System.Windows.Forms.TextBox
    Friend WithEvents gbMain As System.Windows.Forms.GroupBox
    Friend WithEvents gbNetBase As System.Windows.Forms.GroupBox
    Friend WithEvents txtAdjust As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNetBase As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtIncre As System.Windows.Forms.TextBox
    Friend WithEvents txtSalary14 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDecre As System.Windows.Forms.TextBox
    Friend WithEvents txtSalary13 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAnnualAward As System.Windows.Forms.TextBox
    Friend WithEvents chbIncre As System.Windows.Forms.CheckBox
    Friend WithEvents chbDecre As System.Windows.Forms.CheckBox
    Friend WithEvents chb13 As System.Windows.Forms.CheckBox
    Friend WithEvents chb14 As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents gbAllowance As System.Windows.Forms.GroupBox
    Friend WithEvents txtIncentive As System.Windows.Forms.TextBox
    Friend WithEvents txtReginal As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTransport As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtOverTime As System.Windows.Forms.TextBox
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtSalaryBeforeTax As System.Windows.Forms.TextBox
    Friend WithEvents gbSalary As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
End Class

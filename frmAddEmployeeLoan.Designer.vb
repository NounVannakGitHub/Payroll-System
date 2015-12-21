<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployeeLoan
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
        Me.txtCodeLoan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtLoan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtLoanAmount = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtRate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DateLoan = New System.Windows.Forms.DateTimePicker()
        Me.DateEndLoan = New System.Windows.Forms.DateTimePicker()
        Me.cboLoanType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboEmployee = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveNew = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodeLoan
        '
        '
        '
        '
        Me.txtCodeLoan.Border.Class = "TextBoxBorder"
        Me.txtCodeLoan.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeLoan.Location = New System.Drawing.Point(237, 56)
        Me.txtCodeLoan.Name = "txtCodeLoan"
        Me.txtCodeLoan.Size = New System.Drawing.Size(215, 32)
        Me.txtCodeLoan.TabIndex = 0
        '
        'txtLoan
        '
        '
        '
        '
        Me.txtLoan.Border.Class = "TextBoxBorder"
        Me.txtLoan.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoan.Location = New System.Drawing.Point(237, 91)
        Me.txtLoan.Name = "txtLoan"
        Me.txtLoan.Size = New System.Drawing.Size(215, 32)
        Me.txtLoan.TabIndex = 1
        '
        'txtLoanAmount
        '
        '
        '
        '
        Me.txtLoanAmount.Border.Class = "TextBoxBorder"
        Me.txtLoanAmount.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.Location = New System.Drawing.Point(237, 129)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(215, 32)
        Me.txtLoanAmount.TabIndex = 2
        '
        'txtRate
        '
        '
        '
        '
        Me.txtRate.Border.Class = "TextBoxBorder"
        Me.txtRate.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(237, 166)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(215, 32)
        Me.txtRate.TabIndex = 3
        '
        'DateLoan
        '
        Me.DateLoan.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLoan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateLoan.Location = New System.Drawing.Point(237, 202)
        Me.DateLoan.Name = "DateLoan"
        Me.DateLoan.Size = New System.Drawing.Size(215, 32)
        Me.DateLoan.TabIndex = 4
        '
        'DateEndLoan
        '
        Me.DateEndLoan.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEndLoan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateEndLoan.Location = New System.Drawing.Point(237, 239)
        Me.DateEndLoan.Name = "DateEndLoan"
        Me.DateEndLoan.Size = New System.Drawing.Size(215, 32)
        Me.DateEndLoan.TabIndex = 5
        '
        'cboLoanType
        '
        Me.cboLoanType.DisplayMember = "Text"
        Me.cboLoanType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboLoanType.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoanType.FormattingEnabled = True
        Me.cboLoanType.ItemHeight = 26
        Me.cboLoanType.Location = New System.Drawing.Point(237, 275)
        Me.cboLoanType.Name = "cboLoanType"
        Me.cboLoanType.Size = New System.Drawing.Size(215, 32)
        Me.cboLoanType.TabIndex = 6
        '
        'cboEmployee
        '
        Me.cboEmployee.DisplayMember = "Text"
        Me.cboEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEmployee.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmployee.FormattingEnabled = True
        Me.cboEmployee.ItemHeight = 26
        Me.cboEmployee.Location = New System.Drawing.Point(237, 314)
        Me.cboEmployee.Name = "cboEmployee"
        Me.cboEmployee.Size = New System.Drawing.Size(215, 32)
        Me.cboEmployee.TabIndex = 7
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(36, 55)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(113, 32)
        Me.LabelX1.TabIndex = 8
        Me.LabelX1.Text = "លេខកូដកម្ចី"
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(36, 89)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(113, 31)
        Me.LabelX2.TabIndex = 9
        Me.LabelX2.Text = "ចំនួនកម្ចី"
        '
        'LabelX3
        '
        Me.LabelX3.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(36, 127)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(113, 35)
        Me.LabelX3.TabIndex = 11
        Me.LabelX3.Text = "បានបង់"
        '
        'LabelX4
        '
        Me.LabelX4.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(36, 165)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(113, 31)
        Me.LabelX4.TabIndex = 10
        Me.LabelX4.Text = "កាប្រាក់"
        '
        'LabelX5
        '
        Me.LabelX5.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(36, 314)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(113, 32)
        Me.LabelX5.TabIndex = 15
        Me.LabelX5.Text = "ឈ្មោះបុគ្គលិក"
        '
        'LabelX6
        '
        Me.LabelX6.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(36, 239)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(113, 32)
        Me.LabelX6.TabIndex = 14
        Me.LabelX6.Text = "ថ្ងៃបញ្ចប់"
        '
        'LabelX7
        '
        Me.LabelX7.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(36, 277)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(113, 34)
        Me.LabelX7.TabIndex = 13
        Me.LabelX7.Text = "ប្រភេទកម្ចី"
        '
        'LabelX8
        '
        Me.LabelX8.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(36, 202)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(113, 35)
        Me.LabelX8.TabIndex = 12
        Me.LabelX8.Text = "ថ្ងៃខ្វី"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSaveNew, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(237, 364)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(215, 37)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'btnSaveNew
        '
        Me.btnSaveNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSaveNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSaveNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveNew.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNew.Location = New System.Drawing.Point(3, 3)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(106, 31)
        Me.btnSaveNew.TabIndex = 17
        Me.btnSaveNew.Text = "រក្សារទុក​ ថ្មី"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(115, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(97, 31)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "បិទ"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Khmer OS Muol Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(490, 35)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 17
        Me.PanelEx1.Text = "បថ្ថែមបុគ្គលិកកម្ចី"
        '
        'frmAddEmployeeLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 427)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.cboEmployee)
        Me.Controls.Add(Me.cboLoanType)
        Me.Controls.Add(Me.DateEndLoan)
        Me.Controls.Add(Me.DateLoan)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtLoanAmount)
        Me.Controls.Add(Me.txtLoan)
        Me.Controls.Add(Me.txtCodeLoan)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddEmployeeLoan"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCodeLoan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtLoan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtLoanAmount As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DateLoan As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateEndLoan As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboLoanType As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboEmployee As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSaveNew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
End Class

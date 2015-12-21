<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditAttendance
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
        Me.dateWork = New System.Windows.Forms.DateTimePicker()
        Me.timeOut = New System.Windows.Forms.DateTimePicker()
        Me.timeIn = New System.Windows.Forms.DateTimePicker()
        Me.txtTotalLate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBoxX7 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtTotalWorkDay = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dateWork
        '
        Me.dateWork.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateWork.Location = New System.Drawing.Point(143, 120)
        Me.dateWork.Name = "dateWork"
        Me.dateWork.Size = New System.Drawing.Size(234, 32)
        Me.dateWork.TabIndex = 51
        '
        'timeOut
        '
        Me.timeOut.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeOut.Location = New System.Drawing.Point(143, 74)
        Me.timeOut.Name = "timeOut"
        Me.timeOut.Size = New System.Drawing.Size(234, 32)
        Me.timeOut.TabIndex = 50
        '
        'timeIn
        '
        Me.timeIn.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeIn.Location = New System.Drawing.Point(143, 28)
        Me.timeIn.Name = "timeIn"
        Me.timeIn.Size = New System.Drawing.Size(234, 32)
        Me.timeIn.TabIndex = 49
        '
        'txtTotalLate
        '
        '
        '
        '
        Me.txtTotalLate.Border.Class = "TextBoxBorder"
        Me.txtTotalLate.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLate.Location = New System.Drawing.Point(143, 209)
        Me.txtTotalLate.Name = "txtTotalLate"
        Me.txtTotalLate.Size = New System.Drawing.Size(234, 32)
        Me.txtTotalLate.TabIndex = 47
        '
        'TextBoxX7
        '
        '
        '
        '
        Me.TextBoxX7.Border.Class = "TextBoxBorder"
        Me.TextBoxX7.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX7.Location = New System.Drawing.Point(143, 255)
        Me.TextBoxX7.Name = "TextBoxX7"
        Me.TextBoxX7.Size = New System.Drawing.Size(234, 32)
        Me.TextBoxX7.TabIndex = 46
        '
        'txtTotalWorkDay
        '
        '
        '
        '
        Me.txtTotalWorkDay.Border.Class = "TextBoxBorder"
        Me.txtTotalWorkDay.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalWorkDay.Location = New System.Drawing.Point(143, 164)
        Me.txtTotalWorkDay.Name = "txtTotalWorkDay"
        Me.txtTotalWorkDay.Size = New System.Drawing.Size(234, 32)
        Me.txtTotalWorkDay.TabIndex = 45
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.btnCancel.Location = New System.Drawing.Point(120, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 35)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "បិទ"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 35)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "រក្សាទុក"
        '
        'LabelX9
        '
        Me.LabelX9.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX9.Location = New System.Drawing.Point(22, 251)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(115, 41)
        Me.LabelX9.TabIndex = 39
        Me.LabelX9.Text = "ឈ្មោះបុគ្គលិក"
        '
        'LabelX7
        '
        Me.LabelX7.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX7.Location = New System.Drawing.Point(22, 203)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(94, 41)
        Me.LabelX7.TabIndex = 35
        Me.LabelX7.Text = "មកយឺត"
        '
        'LabelX5
        '
        Me.LabelX5.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX5.Location = New System.Drawing.Point(22, 161)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(115, 41)
        Me.LabelX5.TabIndex = 31
        Me.LabelX5.Text = "ចំនូនថ្ងៃធ្វើការ"
        '
        'LabelX3
        '
        Me.LabelX3.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX3.Location = New System.Drawing.Point(22, 113)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(115, 41)
        Me.LabelX3.TabIndex = 27
        Me.LabelX3.Text = "ថ្ងៃទី"
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX2.Location = New System.Drawing.Point(22, 66)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(115, 41)
        Me.LabelX2.TabIndex = 25
        Me.LabelX2.Text = "ម៉ោងចេញ"
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX1.Location = New System.Drawing.Point(22, 19)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(115, 41)
        Me.LabelX1.TabIndex = 23
        Me.LabelX1.Text = "ម៉ោងចូល"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Khmer OS Muol Light", 10.0!)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(452, 35)
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.PaleGreen
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.Style.MarginLeft = 10
        Me.PanelEx1.TabIndex = 21
        Me.PanelEx1.Text = "កែប្រែវត្តមានបុគ្គលិក"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.dateWork)
        Me.GroupBox1.Controls.Add(Me.timeOut)
        Me.GroupBox1.Controls.Add(Me.timeIn)
        Me.GroupBox1.Controls.Add(Me.txtTotalLate)
        Me.GroupBox1.Controls.Add(Me.TextBoxX7)
        Me.GroupBox1.Controls.Add(Me.txtTotalWorkDay)
        Me.GroupBox1.Controls.Add(Me.LabelX9)
        Me.GroupBox1.Controls.Add(Me.LabelX7)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 371)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(143, 303)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(234, 41)
        Me.TableLayoutPanel1.TabIndex = 52
        '
        'frmEditAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 439)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.GroupBox1)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditAttendance"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dateWork As System.Windows.Forms.DateTimePicker
    Friend WithEvents timeOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents timeIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTotalLate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX7 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTotalWorkDay As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class

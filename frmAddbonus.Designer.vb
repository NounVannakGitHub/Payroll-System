<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddbonus
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.timeOut = New System.Windows.Forms.DateTimePicker()
        Me.timeIn = New System.Windows.Forms.DateTimePicker()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX7 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cboBonusType = New System.Windows.Forms.ComboBox()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboBonusType)
        Me.GroupBox1.Controls.Add(Me.TextBoxX2)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.TextBoxX1)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.timeOut)
        Me.GroupBox1.Controls.Add(Me.timeIn)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.TextBoxX7)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.LabelX9)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 417)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'timeOut
        '
        Me.timeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeOut.Location = New System.Drawing.Point(157, 129)
        Me.timeOut.Name = "timeOut"
        Me.timeOut.Size = New System.Drawing.Size(215, 24)
        Me.timeOut.TabIndex = 50
        '
        'timeIn
        '
        Me.timeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeIn.Location = New System.Drawing.Point(157, 84)
        Me.timeIn.Name = "timeIn"
        Me.timeIn.Size = New System.Drawing.Size(215, 24)
        Me.timeIn.TabIndex = 49
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(224, 348)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(91, 33)
        Me.ButtonX1.TabIndex = 48
        Me.ButtonX1.Text = "រក្សាទុក ថ្មី"
        '
        'TextBoxX7
        '
        '
        '
        '
        Me.TextBoxX7.Border.Class = "TextBoxBorder"
        Me.TextBoxX7.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.TextBoxX7.Location = New System.Drawing.Point(157, 287)
        Me.TextBoxX7.Name = "TextBoxX7"
        Me.TextBoxX7.Size = New System.Drawing.Size(215, 41)
        Me.TextBoxX7.TabIndex = 46
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.btnCancel.Location = New System.Drawing.Point(321, 348)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(74, 33)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "បិទ"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.btnSave.Location = New System.Drawing.Point(135, 348)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 33)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "រក្សាទុក"
        '
        'LabelX9
        '
        Me.LabelX9.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX9.Location = New System.Drawing.Point(17, 287)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(115, 41)
        Me.LabelX9.TabIndex = 39
        Me.LabelX9.Text = "ឈ្មោះបុគ្គលិក"
        '
        'LabelX5
        '
        Me.LabelX5.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX5.Location = New System.Drawing.Point(17, 225)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(134, 41)
        Me.LabelX5.TabIndex = 31
        Me.LabelX5.Text = "ប្រភេទប្រាក់បន្ថែម"
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX2.Location = New System.Drawing.Point(17, 121)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(115, 41)
        Me.LabelX2.TabIndex = 25
        Me.LabelX2.Text = "ដល់ថ្ងៃទី"
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX1.Location = New System.Drawing.Point(17, 73)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(115, 41)
        Me.LabelX1.TabIndex = 23
        Me.LabelX1.Text = "ចាប់ពីថ្ងៃទី"
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.TextBoxX1.Location = New System.Drawing.Point(157, 25)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(215, 41)
        Me.TextBoxX1.TabIndex = 53
        '
        'LabelX4
        '
        Me.LabelX4.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX4.Location = New System.Drawing.Point(17, 24)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(115, 41)
        Me.LabelX4.TabIndex = 52
        Me.LabelX4.Text = "លេខកូដ"
        '
        'TextBoxX2
        '
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.TextBoxX2.Location = New System.Drawing.Point(157, 171)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.Size = New System.Drawing.Size(215, 41)
        Me.TextBoxX2.TabIndex = 55
        '
        'LabelX3
        '
        Me.LabelX3.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX3.Location = New System.Drawing.Point(17, 170)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(115, 41)
        Me.LabelX3.TabIndex = 54
        Me.LabelX3.Text = "ចំនួនប្រាក់បថ្ថែម"
        '
        'cboBonusType
        '
        Me.cboBonusType.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBonusType.FormattingEnabled = True
        Me.cboBonusType.Location = New System.Drawing.Point(157, 228)
        Me.cboBonusType.Name = "cboBonusType"
        Me.cboBonusType.Size = New System.Drawing.Size(215, 42)
        Me.cboBonusType.TabIndex = 56
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Khmer OS Muol Light", 11.25!)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(459, 68)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.StyleMouseDown.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.PanelEx1.StyleMouseDown.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.PanelEx1.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.PanelEx1.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText
        Me.PanelEx1.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.StyleMouseOver.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground
        Me.PanelEx1.StyleMouseOver.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground2
        Me.PanelEx1.StyleMouseOver.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder
        Me.PanelEx1.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText
        Me.PanelEx1.TabIndex = 20
        Me.PanelEx1.Text = "បន្ថែមប្រាក់បន្ថែម"
        '
        'frmAddbonus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 518)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.GroupBox1)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddbonus"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents timeOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents timeIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX7 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboBonusType As System.Windows.Forms.ComboBox
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
End Class

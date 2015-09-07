<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.txtID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtfName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.male = New DevComponents.Editors.ComboItem()
        Me.female = New DevComponents.Editors.ComboItem()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBoxEx2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.st_single = New DevComponents.Editors.ComboItem()
        Me.st_married = New DevComponents.Editors.ComboItem()
        Me.st_devide = New DevComponents.Editors.ComboItem()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX6 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DateTimeInput1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        '
        '
        '
        Me.txtID.Border.Class = "TextBoxBorder"
        Me.txtID.Location = New System.Drawing.Point(258, 99)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(261, 41)
        Me.txtID.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(137, 99)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(115, 41)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "លេខសំគាល់"
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(137, 154)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(115, 41)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "នាមត្រកូល"
        '
        'txtfName
        '
        '
        '
        '
        Me.txtfName.Border.Class = "TextBoxBorder"
        Me.txtfName.Location = New System.Drawing.Point(258, 154)
        Me.txtfName.Name = "txtfName"
        Me.txtfName.Size = New System.Drawing.Size(261, 41)
        Me.txtfName.TabIndex = 3
        '
        'LabelX3
        '
        Me.LabelX3.Location = New System.Drawing.Point(137, 210)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(115, 41)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "នាមខ្លូន"
        '
        'TextBoxX3
        '
        '
        '
        '
        Me.TextBoxX3.Border.Class = "TextBoxBorder"
        Me.TextBoxX3.Location = New System.Drawing.Point(258, 210)
        Me.TextBoxX3.Name = "TextBoxX3"
        Me.TextBoxX3.Size = New System.Drawing.Size(261, 41)
        Me.TextBoxX3.TabIndex = 5
        '
        'LabelX4
        '
        Me.LabelX4.Location = New System.Drawing.Point(137, 268)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(115, 41)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "ឈ្មោះឡាតាំង"
        '
        'TextBoxX4
        '
        '
        '
        '
        Me.TextBoxX4.Border.Class = "TextBoxBorder"
        Me.TextBoxX4.Location = New System.Drawing.Point(258, 268)
        Me.TextBoxX4.Name = "TextBoxX4"
        Me.TextBoxX4.Size = New System.Drawing.Size(261, 41)
        Me.TextBoxX4.TabIndex = 7
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 35
        Me.ComboBoxEx1.Items.AddRange(New Object() {Me.male, Me.female})
        Me.ComboBoxEx1.Location = New System.Drawing.Point(258, 324)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(261, 41)
        Me.ComboBoxEx1.TabIndex = 9
        '
        'male
        '
        Me.male.Text = "ប្រុស"
        '
        'female
        '
        Me.female.Text = "ស្រី"
        '
        'LabelX5
        '
        Me.LabelX5.Location = New System.Drawing.Point(137, 324)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(115, 41)
        Me.LabelX5.TabIndex = 10
        Me.LabelX5.Text = "ភេទ"
        '
        'LabelX6
        '
        Me.LabelX6.Location = New System.Drawing.Point(137, 380)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(115, 41)
        Me.LabelX6.TabIndex = 12
        Me.LabelX6.Text = "អាយុ"
        '
        'TextBoxX5
        '
        '
        '
        '
        Me.TextBoxX5.Border.Class = "TextBoxBorder"
        Me.TextBoxX5.Location = New System.Drawing.Point(258, 380)
        Me.TextBoxX5.Name = "TextBoxX5"
        Me.TextBoxX5.Size = New System.Drawing.Size(261, 41)
        Me.TextBoxX5.TabIndex = 11
        '
        'LabelX7
        '
        Me.LabelX7.Location = New System.Drawing.Point(137, 437)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(115, 41)
        Me.LabelX7.TabIndex = 14
        Me.LabelX7.Text = "ស្ថានភាព"
        '
        'ComboBoxEx2
        '
        Me.ComboBoxEx2.DisplayMember = "Text"
        Me.ComboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx2.FormattingEnabled = True
        Me.ComboBoxEx2.ItemHeight = 35
        Me.ComboBoxEx2.Items.AddRange(New Object() {Me.st_single, Me.st_married, Me.st_devide})
        Me.ComboBoxEx2.Location = New System.Drawing.Point(258, 437)
        Me.ComboBoxEx2.Name = "ComboBoxEx2"
        Me.ComboBoxEx2.Size = New System.Drawing.Size(261, 41)
        Me.ComboBoxEx2.TabIndex = 13
        '
        'st_single
        '
        Me.st_single.Text = "នៅលីវ"
        '
        'st_married
        '
        Me.st_married.Text = "រៀបការ"
        '
        'st_devide
        '
        Me.st_devide.Text = "លែងលះ"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1053, 70)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 15
        Me.PanelEx1.Text = "PanelEx1"
        '
        'LabelX8
        '
        Me.LabelX8.Location = New System.Drawing.Point(137, 493)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(115, 41)
        Me.LabelX8.TabIndex = 17
        Me.LabelX8.Text = "សញ្ជាតិ"
        '
        'TextBoxX6
        '
        '
        '
        '
        Me.TextBoxX6.Border.Class = "TextBoxBorder"
        Me.TextBoxX6.Location = New System.Drawing.Point(258, 493)
        Me.TextBoxX6.Name = "TextBoxX6"
        Me.TextBoxX6.Size = New System.Drawing.Size(261, 41)
        Me.TextBoxX6.TabIndex = 16
        '
        'DateTimeInput1
        '
        '
        '
        '
        Me.DateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimeInput1.ButtonDropDown.Visible = True
        Me.DateTimeInput1.Location = New System.Drawing.Point(258, 549)
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DateTimeInput1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimeInput1.MonthCalendar.DisplayMonth = New Date(2015, 9, 1, 0, 0, 0, 0)
        Me.DateTimeInput1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DateTimeInput1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimeInput1.MonthCalendar.TodayButtonVisible = True
        Me.DateTimeInput1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DateTimeInput1.Name = "DateTimeInput1"
        Me.DateTimeInput1.Size = New System.Drawing.Size(261, 41)
        Me.DateTimeInput1.TabIndex = 18
        '
        'LabelX9
        '
        Me.LabelX9.Location = New System.Drawing.Point(137, 549)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(115, 41)
        Me.LabelX9.TabIndex = 19
        Me.LabelX9.Text = "ថ្ងៃចូលធ្វើការ"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.Payroll_Management_System.My.Resources.Resources._1441551327_vector_66_04
        Me.ButtonX1.Location = New System.Drawing.Point(639, 291)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(175, 39)
        Me.ButtonX1.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Payroll_Management_System.My.Resources.Resources.avatar
        Me.PictureBox1.Location = New System.Drawing.Point(639, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1053, 624)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelX9)
        Me.Controls.Add(Me.DateTimeInput1)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.TextBoxX6)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.ComboBoxEx2)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.TextBoxX5)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.ComboBoxEx1)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.TextBoxX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.TextBoxX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.txtfName)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtID)
        Me.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 8, 4, 8)
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtfName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents male As DevComponents.Editors.ComboItem
    Friend WithEvents female As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents st_single As DevComponents.Editors.ComboItem
    Friend WithEvents st_married As DevComponents.Editors.ComboItem
    Friend WithEvents st_devide As DevComponents.Editors.ComboItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX6 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DateTimeInput1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class

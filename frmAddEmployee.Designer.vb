<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEmployee))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnSaveNew = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.DateTimeInput1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX6 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBoxEx2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.st_single = New DevComponents.Editors.ComboItem()
        Me.st_married = New DevComponents.Editors.ComboItem()
        Me.st_devide = New DevComponents.Editors.ComboItem()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.male = New DevComponents.Editors.ComboItem()
        Me.female = New DevComponents.Editors.ComboItem()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        resources.ApplyResources(Me.PanelEx1, "PanelEx1")
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelEx1.Style.GradientAngle = 90
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnSaveNew)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.LabelX9)
        Me.GroupBox1.Controls.Add(Me.DateTimeInput1)
        Me.GroupBox1.Controls.Add(Me.LabelX8)
        Me.GroupBox1.Controls.Add(Me.TextBoxX6)
        Me.GroupBox1.Controls.Add(Me.LabelX7)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEx2)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Controls.Add(Me.TextBoxX5)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEx1)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.TextBoxX4)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.TextBoxX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.TextBoxX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.TextBoxX1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Name = "btnCancel"
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Name = "btnSave"
        '
        'btnSaveNew
        '
        resources.ApplyResources(Me.btnSaveNew, "btnSaveNew")
        Me.btnSaveNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSaveNew.AntiAlias = True
        Me.btnSaveNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSaveNew.Name = "btnSaveNew"
        '
        'LabelX9
        '
        resources.ApplyResources(Me.LabelX9, "LabelX9")
        Me.LabelX9.Name = "LabelX9"
        '
        'DateTimeInput1
        '
        resources.ApplyResources(Me.DateTimeInput1, "DateTimeInput1")
        '
        '
        '
        Me.DateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimeInput1.ButtonClear.DisplayPosition = CType(resources.GetObject("DateTimeInput1.ButtonClear.DisplayPosition"), Integer)
        Me.DateTimeInput1.ButtonClear.Image = CType(resources.GetObject("DateTimeInput1.ButtonClear.Image"), System.Drawing.Image)
        Me.DateTimeInput1.ButtonClear.Text = resources.GetString("DateTimeInput1.ButtonClear.Text")
        Me.DateTimeInput1.ButtonCustom.DisplayPosition = CType(resources.GetObject("DateTimeInput1.ButtonCustom.DisplayPosition"), Integer)
        Me.DateTimeInput1.ButtonCustom.Image = CType(resources.GetObject("DateTimeInput1.ButtonCustom.Image"), System.Drawing.Image)
        Me.DateTimeInput1.ButtonCustom.Text = resources.GetString("DateTimeInput1.ButtonCustom.Text")
        Me.DateTimeInput1.ButtonCustom2.DisplayPosition = CType(resources.GetObject("DateTimeInput1.ButtonCustom2.DisplayPosition"), Integer)
        Me.DateTimeInput1.ButtonCustom2.Image = CType(resources.GetObject("DateTimeInput1.ButtonCustom2.Image"), System.Drawing.Image)
        Me.DateTimeInput1.ButtonCustom2.Text = resources.GetString("DateTimeInput1.ButtonCustom2.Text")
        Me.DateTimeInput1.ButtonDropDown.DisplayPosition = CType(resources.GetObject("DateTimeInput1.ButtonDropDown.DisplayPosition"), Integer)
        Me.DateTimeInput1.ButtonDropDown.Image = CType(resources.GetObject("DateTimeInput1.ButtonDropDown.Image"), System.Drawing.Image)
        Me.DateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimeInput1.ButtonDropDown.Text = resources.GetString("DateTimeInput1.ButtonDropDown.Text")
        Me.DateTimeInput1.ButtonDropDown.Visible = True
        Me.DateTimeInput1.ButtonFreeText.DisplayPosition = CType(resources.GetObject("DateTimeInput1.ButtonFreeText.DisplayPosition"), Integer)
        Me.DateTimeInput1.ButtonFreeText.Image = CType(resources.GetObject("DateTimeInput1.ButtonFreeText.Image"), System.Drawing.Image)
        Me.DateTimeInput1.ButtonFreeText.Text = resources.GetString("DateTimeInput1.ButtonFreeText.Text")
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.AnnuallyMarkedDates = CType(resources.GetObject("DateTimeInput1.MonthCalendar.AnnuallyMarkedDates"), Date())
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DateTimeInput1.MonthCalendar.Category = resources.GetString("DateTimeInput1.MonthCalendar.Category")
        Me.DateTimeInput1.MonthCalendar.ClearButtonVisible = True
        Me.DateTimeInput1.MonthCalendar.CommandParameter = CType(resources.GetObject("DateTimeInput1.MonthCalendar.CommandParameter"), Object)
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimeInput1.MonthCalendar.DayNames = CType(resources.GetObject("DateTimeInput1.MonthCalendar.DayNames"), String())
        Me.DateTimeInput1.MonthCalendar.Description = resources.GetString("DateTimeInput1.MonthCalendar.Description")
        Me.DateTimeInput1.MonthCalendar.DisplayMonth = New Date(2015, 9, 1, 0, 0, 0, 0)
        Me.DateTimeInput1.MonthCalendar.MarkedDates = CType(resources.GetObject("DateTimeInput1.MonthCalendar.MarkedDates"), Date())
        Me.DateTimeInput1.MonthCalendar.MonthlyMarkedDates = CType(resources.GetObject("DateTimeInput1.MonthCalendar.MonthlyMarkedDates"), Date())
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimeInput1.MonthCalendar.Tag = resources.GetString("DateTimeInput1.MonthCalendar.Tag")
        Me.DateTimeInput1.MonthCalendar.Text = resources.GetString("DateTimeInput1.MonthCalendar.Text")
        Me.DateTimeInput1.MonthCalendar.TodayButtonVisible = True
        Me.DateTimeInput1.MonthCalendar.Tooltip = resources.GetString("DateTimeInput1.MonthCalendar.Tooltip")
        Me.DateTimeInput1.MonthCalendar.WeeklyMarkedDays = CType(resources.GetObject("DateTimeInput1.MonthCalendar.WeeklyMarkedDays"), System.DayOfWeek())
        Me.DateTimeInput1.Name = "DateTimeInput1"
        '
        'LabelX8
        '
        resources.ApplyResources(Me.LabelX8, "LabelX8")
        Me.LabelX8.Name = "LabelX8"
        '
        'TextBoxX6
        '
        resources.ApplyResources(Me.TextBoxX6, "TextBoxX6")
        '
        '
        '
        Me.TextBoxX6.Border.Class = "TextBoxBorder"
        Me.TextBoxX6.ButtonCustom.DisplayPosition = CType(resources.GetObject("TextBoxX6.ButtonCustom.DisplayPosition"), Integer)
        Me.TextBoxX6.ButtonCustom.Image = CType(resources.GetObject("TextBoxX6.ButtonCustom.Image"), System.Drawing.Image)
        Me.TextBoxX6.ButtonCustom.Text = resources.GetString("TextBoxX6.ButtonCustom.Text")
        Me.TextBoxX6.ButtonCustom2.DisplayPosition = CType(resources.GetObject("TextBoxX6.ButtonCustom2.DisplayPosition"), Integer)
        Me.TextBoxX6.ButtonCustom2.Image = CType(resources.GetObject("TextBoxX6.ButtonCustom2.Image"), System.Drawing.Image)
        Me.TextBoxX6.ButtonCustom2.Text = resources.GetString("TextBoxX6.ButtonCustom2.Text")
        Me.TextBoxX6.Name = "TextBoxX6"
        '
        'LabelX7
        '
        resources.ApplyResources(Me.LabelX7, "LabelX7")
        Me.LabelX7.Name = "LabelX7"
        '
        'ComboBoxEx2
        '
        resources.ApplyResources(Me.ComboBoxEx2, "ComboBoxEx2")
        Me.ComboBoxEx2.DisplayMember = "Text"
        Me.ComboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx2.FormattingEnabled = True
        Me.ComboBoxEx2.Items.AddRange(New Object() {Me.st_single, Me.st_married, Me.st_devide})
        Me.ComboBoxEx2.Name = "ComboBoxEx2"
        '
        'st_single
        '
        resources.ApplyResources(Me.st_single, "st_single")
        '
        'st_married
        '
        resources.ApplyResources(Me.st_married, "st_married")
        '
        'st_devide
        '
        resources.ApplyResources(Me.st_devide, "st_devide")
        '
        'LabelX6
        '
        resources.ApplyResources(Me.LabelX6, "LabelX6")
        Me.LabelX6.Name = "LabelX6"
        '
        'TextBoxX5
        '
        resources.ApplyResources(Me.TextBoxX5, "TextBoxX5")
        '
        '
        '
        Me.TextBoxX5.Border.Class = "TextBoxBorder"
        Me.TextBoxX5.ButtonCustom.DisplayPosition = CType(resources.GetObject("TextBoxX5.ButtonCustom.DisplayPosition"), Integer)
        Me.TextBoxX5.ButtonCustom.Image = CType(resources.GetObject("TextBoxX5.ButtonCustom.Image"), System.Drawing.Image)
        Me.TextBoxX5.ButtonCustom.Text = resources.GetString("TextBoxX5.ButtonCustom.Text")
        Me.TextBoxX5.ButtonCustom2.DisplayPosition = CType(resources.GetObject("TextBoxX5.ButtonCustom2.DisplayPosition"), Integer)
        Me.TextBoxX5.ButtonCustom2.Image = CType(resources.GetObject("TextBoxX5.ButtonCustom2.Image"), System.Drawing.Image)
        Me.TextBoxX5.ButtonCustom2.Text = resources.GetString("TextBoxX5.ButtonCustom2.Text")
        Me.TextBoxX5.Name = "TextBoxX5"
        '
        'LabelX5
        '
        resources.ApplyResources(Me.LabelX5, "LabelX5")
        Me.LabelX5.Name = "LabelX5"
        '
        'ComboBoxEx1
        '
        resources.ApplyResources(Me.ComboBoxEx1, "ComboBoxEx1")
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.Items.AddRange(New Object() {Me.male, Me.female})
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        '
        'male
        '
        resources.ApplyResources(Me.male, "male")
        '
        'female
        '
        resources.ApplyResources(Me.female, "female")
        '
        'LabelX4
        '
        resources.ApplyResources(Me.LabelX4, "LabelX4")
        Me.LabelX4.Name = "LabelX4"
        '
        'TextBoxX4
        '
        resources.ApplyResources(Me.TextBoxX4, "TextBoxX4")
        '
        '
        '
        Me.TextBoxX4.Border.Class = "TextBoxBorder"
        Me.TextBoxX4.ButtonCustom.DisplayPosition = CType(resources.GetObject("TextBoxX4.ButtonCustom.DisplayPosition"), Integer)
        Me.TextBoxX4.ButtonCustom.Image = CType(resources.GetObject("TextBoxX4.ButtonCustom.Image"), System.Drawing.Image)
        Me.TextBoxX4.ButtonCustom.Text = resources.GetString("TextBoxX4.ButtonCustom.Text")
        Me.TextBoxX4.ButtonCustom2.DisplayPosition = CType(resources.GetObject("TextBoxX4.ButtonCustom2.DisplayPosition"), Integer)
        Me.TextBoxX4.ButtonCustom2.Image = CType(resources.GetObject("TextBoxX4.ButtonCustom2.Image"), System.Drawing.Image)
        Me.TextBoxX4.ButtonCustom2.Text = resources.GetString("TextBoxX4.ButtonCustom2.Text")
        Me.TextBoxX4.Name = "TextBoxX4"
        '
        'LabelX3
        '
        resources.ApplyResources(Me.LabelX3, "LabelX3")
        Me.LabelX3.Name = "LabelX3"
        '
        'TextBoxX3
        '
        resources.ApplyResources(Me.TextBoxX3, "TextBoxX3")
        '
        '
        '
        Me.TextBoxX3.Border.Class = "TextBoxBorder"
        Me.TextBoxX3.ButtonCustom.DisplayPosition = CType(resources.GetObject("TextBoxX3.ButtonCustom.DisplayPosition"), Integer)
        Me.TextBoxX3.ButtonCustom.Image = CType(resources.GetObject("TextBoxX3.ButtonCustom.Image"), System.Drawing.Image)
        Me.TextBoxX3.ButtonCustom.Text = resources.GetString("TextBoxX3.ButtonCustom.Text")
        Me.TextBoxX3.ButtonCustom2.DisplayPosition = CType(resources.GetObject("TextBoxX3.ButtonCustom2.DisplayPosition"), Integer)
        Me.TextBoxX3.ButtonCustom2.Image = CType(resources.GetObject("TextBoxX3.ButtonCustom2.Image"), System.Drawing.Image)
        Me.TextBoxX3.ButtonCustom2.Text = resources.GetString("TextBoxX3.ButtonCustom2.Text")
        Me.TextBoxX3.Name = "TextBoxX3"
        '
        'LabelX2
        '
        resources.ApplyResources(Me.LabelX2, "LabelX2")
        Me.LabelX2.Name = "LabelX2"
        '
        'TextBoxX2
        '
        resources.ApplyResources(Me.TextBoxX2, "TextBoxX2")
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.ButtonCustom.DisplayPosition = CType(resources.GetObject("TextBoxX2.ButtonCustom.DisplayPosition"), Integer)
        Me.TextBoxX2.ButtonCustom.Image = CType(resources.GetObject("TextBoxX2.ButtonCustom.Image"), System.Drawing.Image)
        Me.TextBoxX2.ButtonCustom.Text = resources.GetString("TextBoxX2.ButtonCustom.Text")
        Me.TextBoxX2.ButtonCustom2.DisplayPosition = CType(resources.GetObject("TextBoxX2.ButtonCustom2.DisplayPosition"), Integer)
        Me.TextBoxX2.ButtonCustom2.Image = CType(resources.GetObject("TextBoxX2.ButtonCustom2.Image"), System.Drawing.Image)
        Me.TextBoxX2.ButtonCustom2.Text = resources.GetString("TextBoxX2.ButtonCustom2.Text")
        Me.TextBoxX2.Name = "TextBoxX2"
        '
        'LabelX1
        '
        resources.ApplyResources(Me.LabelX1, "LabelX1")
        Me.LabelX1.Name = "LabelX1"
        '
        'TextBoxX1
        '
        resources.ApplyResources(Me.TextBoxX1, "TextBoxX1")
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.ButtonCustom.DisplayPosition = CType(resources.GetObject("TextBoxX1.ButtonCustom.DisplayPosition"), Integer)
        Me.TextBoxX1.ButtonCustom.Image = CType(resources.GetObject("TextBoxX1.ButtonCustom.Image"), System.Drawing.Image)
        Me.TextBoxX1.ButtonCustom.Text = resources.GetString("TextBoxX1.ButtonCustom.Text")
        Me.TextBoxX1.ButtonCustom2.DisplayPosition = CType(resources.GetObject("TextBoxX1.ButtonCustom2.DisplayPosition"), Integer)
        Me.TextBoxX1.ButtonCustom2.Image = CType(resources.GetObject("TextBoxX1.ButtonCustom2.Image"), System.Drawing.Image)
        Me.TextBoxX1.ButtonCustom2.Text = resources.GetString("TextBoxX1.ButtonCustom2.Text")
        Me.TextBoxX1.Name = "TextBoxX1"
        '
        'ButtonX1
        '
        resources.ApplyResources(Me.ButtonX1, "ButtonX1")
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.Payroll_Management_System.My.Resources.Resources._1441551327_vector_66_04
        Me.ButtonX1.Name = "ButtonX1"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Image = Global.Payroll_Management_System.My.Resources.Resources.avatar
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'frmEmployee
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployee"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DateTimeInput1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX6 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents st_single As DevComponents.Editors.ComboItem
    Friend WithEvents st_married As DevComponents.Editors.ComboItem
    Friend WithEvents st_devide As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents male As DevComponents.Editors.ComboItem
    Friend WithEvents female As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSaveNew As DevComponents.DotNetBar.ButtonX
End Class

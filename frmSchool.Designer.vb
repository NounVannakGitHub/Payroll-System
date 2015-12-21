<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchool
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
        Me.LabelX36 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX28 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX27 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX26 = New DevComponents.DotNetBar.LabelX()
        Me.cboGrade = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.pnTitle = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtEndYear = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtStartYear = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSchool = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.pnTitle.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX36
        '
        Me.LabelX36.BackColor = System.Drawing.Color.Transparent
        Me.LabelX36.Location = New System.Drawing.Point(51, 190)
        Me.LabelX36.Name = "LabelX36"
        Me.LabelX36.Size = New System.Drawing.Size(75, 35)
        Me.LabelX36.TabIndex = 9
        Me.LabelX36.Text = "Grade:"
        '
        'LabelX28
        '
        Me.LabelX28.BackColor = System.Drawing.Color.Transparent
        Me.LabelX28.Location = New System.Drawing.Point(51, 149)
        Me.LabelX28.Name = "LabelX28"
        Me.LabelX28.Size = New System.Drawing.Size(75, 35)
        Me.LabelX28.TabIndex = 10
        Me.LabelX28.Text = "End:"
        '
        'LabelX27
        '
        Me.LabelX27.BackColor = System.Drawing.Color.Transparent
        Me.LabelX27.Location = New System.Drawing.Point(51, 108)
        Me.LabelX27.Name = "LabelX27"
        Me.LabelX27.Size = New System.Drawing.Size(75, 35)
        Me.LabelX27.TabIndex = 11
        Me.LabelX27.Text = "Start:"
        '
        'LabelX26
        '
        Me.LabelX26.BackColor = System.Drawing.Color.Transparent
        Me.LabelX26.Location = New System.Drawing.Point(51, 67)
        Me.LabelX26.Name = "LabelX26"
        Me.LabelX26.Size = New System.Drawing.Size(75, 35)
        Me.LabelX26.TabIndex = 12
        Me.LabelX26.Text = "School:"
        '
        'cboGrade
        '
        Me.cboGrade.DisplayMember = "Text"
        Me.cboGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboGrade.FormattingEnabled = True
        Me.cboGrade.ItemHeight = 29
        Me.cboGrade.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5})
        Me.cboGrade.Location = New System.Drawing.Point(136, 190)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(194, 35)
        Me.cboGrade.TabIndex = 4
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "A"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "B"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "C"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "D"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "E"
        '
        'pnTitle
        '
        Me.pnTitle.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnTitle.Controls.Add(Me.PictureBox5)
        Me.pnTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnTitle.Name = "pnTitle"
        Me.pnTitle.Size = New System.Drawing.Size(388, 39)
        Me.pnTitle.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnTitle.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnTitle.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnTitle.Style.GradientAngle = 90
        Me.pnTitle.TabIndex = 13
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.Payroll_Management_System.My.Resources.Resources._1442135746_close_red
        Me.PictureBox5.Location = New System.Drawing.Point(343, 1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(42, 35)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 23
        Me.PictureBox5.TabStop = False
        '
        'txtEndYear
        '
        '
        '
        '
        Me.txtEndYear.Border.Class = "TextBoxBorder"
        Me.txtEndYear.Location = New System.Drawing.Point(137, 149)
        Me.txtEndYear.Name = "txtEndYear"
        Me.txtEndYear.Size = New System.Drawing.Size(194, 20)
        Me.txtEndYear.TabIndex = 3
        '
        'txtStartYear
        '
        '
        '
        '
        Me.txtStartYear.Border.Class = "TextBoxBorder"
        Me.txtStartYear.Location = New System.Drawing.Point(137, 108)
        Me.txtStartYear.Name = "txtStartYear"
        Me.txtStartYear.Size = New System.Drawing.Size(194, 20)
        Me.txtStartYear.TabIndex = 3
        '
        'txtSchool
        '
        '
        '
        '
        Me.txtSchool.Border.Class = "TextBoxBorder"
        Me.txtSchool.Location = New System.Drawing.Point(137, 67)
        Me.txtSchool.Name = "txtSchool"
        Me.txtSchool.Size = New System.Drawing.Size(194, 20)
        Me.txtSchool.TabIndex = 3
        '
        'frmSchool
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(389, 271)
        Me.Controls.Add(Me.pnTitle)
        Me.Controls.Add(Me.LabelX36)
        Me.Controls.Add(Me.LabelX28)
        Me.Controls.Add(Me.LabelX27)
        Me.Controls.Add(Me.LabelX26)
        Me.Controls.Add(Me.cboGrade)
        Me.Controls.Add(Me.txtSchool)
        Me.Controls.Add(Me.txtStartYear)
        Me.Controls.Add(Me.txtEndYear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSchool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmSchool"
        Me.pnTitle.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX36 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX28 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX27 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboGrade As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents pnTitle As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents txtEndYear As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtStartYear As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSchool As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
End Class

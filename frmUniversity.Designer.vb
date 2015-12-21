<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUniversity
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
        Me.pnUniversityTitle = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.LabelX36 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX28 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX27 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX26 = New DevComponents.DotNetBar.LabelX()
        Me.cboUniversity = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cboMajor = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtGPA = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUniEndYear = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUniStartYear = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.pnUniversityTitle.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnUniversityTitle
        '
        Me.pnUniversityTitle.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnUniversityTitle.Controls.Add(Me.PictureBox5)
        Me.pnUniversityTitle.Location = New System.Drawing.Point(1, 1)
        Me.pnUniversityTitle.Name = "pnUniversityTitle"
        Me.pnUniversityTitle.Size = New System.Drawing.Size(387, 41)
        Me.pnUniversityTitle.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnUniversityTitle.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnUniversityTitle.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnUniversityTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnUniversityTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnUniversityTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnUniversityTitle.Style.GradientAngle = 90
        Me.pnUniversityTitle.TabIndex = 0
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.Payroll_Management_System.My.Resources.Resources._1442135746_close_red
        Me.PictureBox5.Location = New System.Drawing.Point(342, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(42, 35)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'LabelX36
        '
        Me.LabelX36.BackColor = System.Drawing.Color.Transparent
        Me.LabelX36.Location = New System.Drawing.Point(48, 221)
        Me.LabelX36.Name = "LabelX36"
        Me.LabelX36.Size = New System.Drawing.Size(75, 35)
        Me.LabelX36.TabIndex = 17
        Me.LabelX36.Text = "GPA:"
        '
        'LabelX28
        '
        Me.LabelX28.BackColor = System.Drawing.Color.Transparent
        Me.LabelX28.Location = New System.Drawing.Point(48, 180)
        Me.LabelX28.Name = "LabelX28"
        Me.LabelX28.Size = New System.Drawing.Size(75, 35)
        Me.LabelX28.TabIndex = 18
        Me.LabelX28.Text = "End:"
        '
        'LabelX27
        '
        Me.LabelX27.BackColor = System.Drawing.Color.Transparent
        Me.LabelX27.Location = New System.Drawing.Point(48, 139)
        Me.LabelX27.Name = "LabelX27"
        Me.LabelX27.Size = New System.Drawing.Size(75, 35)
        Me.LabelX27.TabIndex = 19
        Me.LabelX27.Text = "Start:"
        '
        'LabelX26
        '
        Me.LabelX26.BackColor = System.Drawing.Color.Transparent
        Me.LabelX26.Location = New System.Drawing.Point(48, 98)
        Me.LabelX26.Name = "LabelX26"
        Me.LabelX26.Size = New System.Drawing.Size(75, 35)
        Me.LabelX26.TabIndex = 20
        Me.LabelX26.Text = "Major:"
        '
        'cboUniversity
        '
        Me.cboUniversity.DisplayMember = "Text"
        Me.cboUniversity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboUniversity.DropDownHeight = 100
        Me.cboUniversity.FormattingEnabled = True
        Me.cboUniversity.IntegralHeight = False
        Me.cboUniversity.ItemHeight = 14
        Me.cboUniversity.Location = New System.Drawing.Point(133, 57)
        Me.cboUniversity.Name = "cboUniversity"
        Me.cboUniversity.Size = New System.Drawing.Size(194, 20)
        Me.cboUniversity.TabIndex = 16
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(48, 57)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 35)
        Me.LabelX1.TabIndex = 17
        Me.LabelX1.Text = "University:"
        '
        'cboMajor
        '
        Me.cboMajor.DisplayMember = "Text"
        Me.cboMajor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMajor.DropDownHeight = 100
        Me.cboMajor.FormattingEnabled = True
        Me.cboMajor.IntegralHeight = False
        Me.cboMajor.ItemHeight = 14
        Me.cboMajor.Location = New System.Drawing.Point(133, 98)
        Me.cboMajor.Name = "cboMajor"
        Me.cboMajor.Size = New System.Drawing.Size(194, 20)
        Me.cboMajor.TabIndex = 16
        '
        'txtGPA
        '
        '
        '
        '
        Me.txtGPA.Border.Class = "TextBoxBorder"
        Me.txtGPA.Location = New System.Drawing.Point(134, 221)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(194, 20)
        Me.txtGPA.TabIndex = 15
        '
        'txtUniEndYear
        '
        '
        '
        '
        Me.txtUniEndYear.Border.Class = "TextBoxBorder"
        Me.txtUniEndYear.Location = New System.Drawing.Point(134, 180)
        Me.txtUniEndYear.Name = "txtUniEndYear"
        Me.txtUniEndYear.Size = New System.Drawing.Size(194, 20)
        Me.txtUniEndYear.TabIndex = 15
        '
        'txtUniStartYear
        '
        '
        '
        '
        Me.txtUniStartYear.Border.Class = "TextBoxBorder"
        Me.txtUniStartYear.Location = New System.Drawing.Point(134, 139)
        Me.txtUniStartYear.Name = "txtUniStartYear"
        Me.txtUniStartYear.Size = New System.Drawing.Size(194, 20)
        Me.txtUniStartYear.TabIndex = 14
        '
        'frmUniversity
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(389, 271)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.LabelX36)
        Me.Controls.Add(Me.LabelX28)
        Me.Controls.Add(Me.LabelX27)
        Me.Controls.Add(Me.LabelX26)
        Me.Controls.Add(Me.cboMajor)
        Me.Controls.Add(Me.cboUniversity)
        Me.Controls.Add(Me.txtUniStartYear)
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.txtUniEndYear)
        Me.Controls.Add(Me.pnUniversityTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUniversity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmUniversity"
        Me.pnUniversityTitle.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnUniversityTitle As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX36 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX28 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX27 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboUniversity As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboMajor As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents txtGPA As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUniEndYear As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUniStartYear As DevComponents.DotNetBar.Controls.TextBoxX
End Class

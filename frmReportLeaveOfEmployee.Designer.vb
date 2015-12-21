<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportLeaveOfEmployee
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboEmpId = New System.Windows.Forms.ComboBox()
        Me.កូដបុគ្គលិក = New System.Windows.Forms.Label()
        Me.rptLeaveOfEmployee = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Location = New System.Drawing.Point(-1, 1)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(902, 42)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = "Employee Monthy Leave Record"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Payroll_Management_System.My.Resources.Resources._1442135746_close_red
        Me.PictureBox1.Location = New System.Drawing.Point(855, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.កូដបុគ្គលិក)
        Me.Panel1.Controls.Add(Me.cboEmpId)
        Me.Panel1.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 43)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rptLeaveOfEmployee)
        Me.Panel2.Location = New System.Drawing.Point(12, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(878, 591)
        Me.Panel2.TabIndex = 2
        '
        'cboEmpId
        '
        Me.cboEmpId.DropDownHeight = 100
        Me.cboEmpId.FormattingEnabled = True
        Me.cboEmpId.IntegralHeight = False
        Me.cboEmpId.Location = New System.Drawing.Point(247, 3)
        Me.cboEmpId.Name = "cboEmpId"
        Me.cboEmpId.Size = New System.Drawing.Size(273, 35)
        Me.cboEmpId.TabIndex = 0
        '
        'កូដបុគ្គលិក
        '
        Me.កូដបុគ្គលិក.AutoSize = True
        Me.កូដបុគ្គលិក.Location = New System.Drawing.Point(170, 6)
        Me.កូដបុគ្គលិក.Name = "កូដបុគ្គលិក"
        Me.កូដបុគ្គលិក.Size = New System.Drawing.Size(71, 27)
        Me.កូដបុគ្គលិក.TabIndex = 1
        Me.កូដបុគ្គលិក.Text = "កូដបុគ្គលិក"
        '
        'rptLeaveOfEmployee
        '
        Me.rptLeaveOfEmployee.ActiveViewIndex = -1
        Me.rptLeaveOfEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptLeaveOfEmployee.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptLeaveOfEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptLeaveOfEmployee.Location = New System.Drawing.Point(0, 0)
        Me.rptLeaveOfEmployee.Name = "rptLeaveOfEmployee"
        Me.rptLeaveOfEmployee.Size = New System.Drawing.Size(878, 591)
        Me.rptLeaveOfEmployee.TabIndex = 0
        Me.rptLeaveOfEmployee.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReportLeaveOfEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(902, 695)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReportLeaveOfEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportLeaveOfEmployee"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboEmpId As System.Windows.Forms.ComboBox
    Friend WithEvents កូដបុគ្គលិក As System.Windows.Forms.Label
    Friend WithEvents rptLeaveOfEmployee As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

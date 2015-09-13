<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBenefitAndDeductionType
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
<<<<<<< HEAD
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBenefitAndDeductionType))
=======
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBenefitAndDeductionType))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
>>>>>>> origin/payroll
        Me.pnlBenefitAndDeduction = New DevComponents.DotNetBar.PanelEx()
        Me.btnClosePanel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.xtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
<<<<<<< HEAD
        Me.tbtnNew = New System.Windows.Forms.ToolStripButton()
        Me.tbtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tbtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.tbtnNewDeductionType = New System.Windows.Forms.ToolStripButton()
        Me.tbtnEditDeductionType = New System.Windows.Forms.ToolStripButton()
        Me.tbtnDeleteDeductionType = New System.Windows.Forms.ToolStripButton()
        Me.btnSearchDeduction = New System.Windows.Forms.ToolStripButton()
=======
>>>>>>> origin/payroll
        Me.pnlBenefitAndDeduction.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBenefitAndDeduction
        '
        Me.pnlBenefitAndDeduction.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlBenefitAndDeduction.Controls.Add(Me.btnClosePanel)
        Me.pnlBenefitAndDeduction.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBenefitAndDeduction.Location = New System.Drawing.Point(0, 0)
        Me.pnlBenefitAndDeduction.Name = "pnlBenefitAndDeduction"
        Me.pnlBenefitAndDeduction.Size = New System.Drawing.Size(1019, 40)
        Me.pnlBenefitAndDeduction.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlBenefitAndDeduction.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.pnlBenefitAndDeduction.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.pnlBenefitAndDeduction.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.pnlBenefitAndDeduction.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.pnlBenefitAndDeduction.Style.GradientAngle = 90
        Me.pnlBenefitAndDeduction.TabIndex = 1
        '
        'btnClosePanel
        '
        Me.btnClosePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClosePanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClosePanel.Location = New System.Drawing.Point(966, 0)
        Me.btnClosePanel.Name = "btnClosePanel"
        Me.btnClosePanel.Size = New System.Drawing.Size(53, 40)
        Me.btnClosePanel.TabIndex = 0
        Me.btnClosePanel.Text = "x"
        Me.btnClosePanel.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(2, 2)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1019, 407)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 20)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1011, 383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Benefit Type"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridViewX2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1005, 377)
        Me.SplitContainer1.SplitterDistance = 165
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView2
        '
        Me.TreeView2.Dock = System.Windows.Forms.DockStyle.Fill
<<<<<<< HEAD
        Me.TreeView2.Location = New System.Drawing.Point(0, 25)
=======
        Me.TreeView2.Location = New System.Drawing.Point(0, 23)
>>>>>>> origin/payroll
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(165, 352)
        Me.TreeView2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewX2
        '
        Me.DataGridViewX2.AllowUserToAddRows = False
        Me.DataGridViewX2.AllowUserToDeleteRows = False
        Me.DataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
<<<<<<< HEAD
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX2.DefaultCellStyle = DataGridViewCellStyle4
=======
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX2.DefaultCellStyle = DataGridViewCellStyle3
>>>>>>> origin/payroll
        Me.DataGridViewX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX2.Location = New System.Drawing.Point(0, 25)
        Me.DataGridViewX2.Name = "DataGridViewX2"
        Me.DataGridViewX2.ReadOnly = True
<<<<<<< HEAD
        Me.DataGridViewX2.Size = New System.Drawing.Size(836, 352)
=======
        Me.DataGridViewX2.Size = New System.Drawing.Size(836, 350)
>>>>>>> origin/payroll
        Me.DataGridViewX2.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtnNew, Me.tbtnEdit, Me.tbtnDelete, Me.btnSearch, Me.xtSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(836, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'xtSearch
        '
        Me.xtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.xtSearch.Name = "xtSearch"
        Me.xtSearch.Size = New System.Drawing.Size(100, 25)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 20)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1011, 383)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Deductoion Type"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridViewX1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1005, 377)
        Me.SplitContainer2.SplitterDistance = 181
        Me.SplitContainer2.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 23)
        Me.TreeView1.Name = "TreeView1"
<<<<<<< HEAD
        Me.TreeView1.Size = New System.Drawing.Size(181, 354)
=======
        Me.TreeView1.Size = New System.Drawing.Size(181, 352)
>>>>>>> origin/payroll
        Me.TreeView1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 23)
        Me.Label2.TabIndex = 1
<<<<<<< HEAD
=======
        Me.Label2.Text = "New Added"
>>>>>>> origin/payroll
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtnNewDeductionType, Me.tbtnEditDeductionType, Me.tbtnDeleteDeductionType, Me.btnSearchDeduction, Me.txtSearch})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(820, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 25)
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
<<<<<<< HEAD
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle3
=======
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle4
>>>>>>> origin/payroll
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.Size = New System.Drawing.Size(820, 377)
        Me.DataGridViewX1.TabIndex = 0
        '
<<<<<<< HEAD
        'tbtnNew
        '
        Me.tbtnNew.Image = CType(resources.GetObject("tbtnNew.Image"), System.Drawing.Image)
        Me.tbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnNew.Name = "tbtnNew"
        Me.tbtnNew.Size = New System.Drawing.Size(51, 22)
        Me.tbtnNew.Text = "New"
        '
        'tbtnEdit
        '
        Me.tbtnEdit.Image = CType(resources.GetObject("tbtnEdit.Image"), System.Drawing.Image)
        Me.tbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnEdit.Name = "tbtnEdit"
        Me.tbtnEdit.Size = New System.Drawing.Size(47, 22)
        Me.tbtnEdit.Text = "Edit"
        '
        'tbtnDelete
        '
        Me.tbtnDelete.Image = CType(resources.GetObject("tbtnDelete.Image"), System.Drawing.Image)
        Me.tbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnDelete.Name = "tbtnDelete"
        Me.tbtnDelete.Size = New System.Drawing.Size(60, 22)
        Me.tbtnDelete.Text = "Delete"
        Me.tbtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSearch
        '
        Me.btnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        Me.btnSearch.Text = "ToolStripButton4"
        '
        'tbtnNewDeductionType
        '
        Me.tbtnNewDeductionType.Image = CType(resources.GetObject("tbtnNewDeductionType.Image"), System.Drawing.Image)
        Me.tbtnNewDeductionType.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnNewDeductionType.Name = "tbtnNewDeductionType"
        Me.tbtnNewDeductionType.Size = New System.Drawing.Size(51, 22)
        Me.tbtnNewDeductionType.Text = "New"
        '
        'tbtnEditDeductionType
        '
        Me.tbtnEditDeductionType.Image = CType(resources.GetObject("tbtnEditDeductionType.Image"), System.Drawing.Image)
        Me.tbtnEditDeductionType.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnEditDeductionType.Name = "tbtnEditDeductionType"
        Me.tbtnEditDeductionType.Size = New System.Drawing.Size(47, 22)
        Me.tbtnEditDeductionType.Text = "Edit"
        '
        'tbtnDeleteDeductionType
        '
        Me.tbtnDeleteDeductionType.Image = CType(resources.GetObject("tbtnDeleteDeductionType.Image"), System.Drawing.Image)
        Me.tbtnDeleteDeductionType.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnDeleteDeductionType.Name = "tbtnDeleteDeductionType"
        Me.tbtnDeleteDeductionType.Size = New System.Drawing.Size(60, 22)
        Me.tbtnDeleteDeductionType.Text = "Delete"
        '
        'btnSearchDeduction
        '
        Me.btnSearchDeduction.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSearchDeduction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearchDeduction.Image = CType(resources.GetObject("btnSearchDeduction.Image"), System.Drawing.Image)
        Me.btnSearchDeduction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearchDeduction.Name = "btnSearchDeduction"
        Me.btnSearchDeduction.Size = New System.Drawing.Size(23, 22)
        Me.btnSearchDeduction.Text = "ToolStripButton8"
        '
=======
>>>>>>> origin/payroll
        'frmBenefitAndDeductionType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 447)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnlBenefitAndDeduction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBenefitAndDeductionType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBenefitAndDeductionType"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlBenefitAndDeduction.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBenefitAndDeduction As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tbtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents xtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tbtnNewDeductionType As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnEditDeductionType As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnDeleteDeductionType As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearchDeduction As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents DataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClosePanel As System.Windows.Forms.Button
End Class

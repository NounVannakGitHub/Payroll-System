<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddress
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddress))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridViewX3 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridViewX4 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.btnAddNewP = New System.Windows.Forms.ToolStripButton()
        Me.btnEditP = New System.Windows.Forms.ToolStripButton()
        Me.btnDeleteP = New System.Windows.Forms.ToolStripButton()
        Me.btnRefreshP = New System.Windows.Forms.ToolStripButton()
        Me.btnAddNewD = New System.Windows.Forms.ToolStripButton()
        Me.btnEditD = New System.Windows.Forms.ToolStripButton()
        Me.btnDeleteD = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnSaveNewC = New System.Windows.Forms.ToolStripButton()
        Me.btnEditC = New System.Windows.Forms.ToolStripButton()
        Me.btnDeleteC = New System.Windows.Forms.ToolStripButton()
        Me.btnRefreshC = New System.Windows.Forms.ToolStripButton()
        Me.btnSaveNewV = New System.Windows.Forms.ToolStripButton()
        Me.btnEditV = New System.Windows.Forms.ToolStripButton()
        Me.btnDeleteV = New System.Windows.Forms.ToolStripButton()
        Me.btnRefreshV = New System.Windows.Forms.ToolStripButton()
        Me.PanelEx1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridViewX3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridViewX4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.btnClose)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Khmer OS Muol Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1264, 35)
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.PaleGreen
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.Style.MarginLeft = 10
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = "ព័ត៏មានអាស័យដ្ឋាន"
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Khmer OS Muol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1224, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 35)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(45, 25)
        Me.TabControl1.Location = New System.Drawing.Point(0, 35)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1264, 706)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage1.Controls.Add(Me.DataGridViewX1)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1256, 673)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ព័ត៏មានខេត្ត"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(3, 28)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.Size = New System.Drawing.Size(1250, 642)
        Me.DataGridViewX1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddNewP, Me.btnEditP, Me.btnDeleteP, Me.btnRefreshP})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1250, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage2.Controls.Add(Me.DataGridViewX2)
        Me.TabPage2.Controls.Add(Me.ToolStrip2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1256, 673)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ព័ត៏មានស្រុក"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewX2
        '
        Me.DataGridViewX2.AllowUserToAddRows = False
        Me.DataGridViewX2.AllowUserToDeleteRows = False
        Me.DataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX2.Location = New System.Drawing.Point(3, 28)
        Me.DataGridViewX2.Name = "DataGridViewX2"
        Me.DataGridViewX2.ReadOnly = True
        Me.DataGridViewX2.Size = New System.Drawing.Size(1250, 642)
        Me.DataGridViewX2.TabIndex = 3
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddNewD, Me.btnEditD, Me.btnDeleteD, Me.btnRefresh})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1250, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage3.Controls.Add(Me.DataGridViewX3)
        Me.TabPage3.Controls.Add(Me.ToolStrip3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1256, 673)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ព័ត៏មានឃុំ"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridViewX3
        '
        Me.DataGridViewX3.AllowUserToAddRows = False
        Me.DataGridViewX3.AllowUserToDeleteRows = False
        Me.DataGridViewX3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX3.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewX3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX3.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX3.Location = New System.Drawing.Point(0, 25)
        Me.DataGridViewX3.Name = "DataGridViewX3"
        Me.DataGridViewX3.ReadOnly = True
        Me.DataGridViewX3.Size = New System.Drawing.Size(1256, 648)
        Me.DataGridViewX3.TabIndex = 3
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSaveNewC, Me.btnEditC, Me.btnDeleteC, Me.btnRefreshC})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1256, 25)
        Me.ToolStrip3.TabIndex = 2
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage4.Controls.Add(Me.DataGridViewX4)
        Me.TabPage4.Controls.Add(Me.ToolStrip4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1256, 673)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "ព័ត៏មានភូមិ"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridViewX4
        '
        Me.DataGridViewX4.AllowUserToAddRows = False
        Me.DataGridViewX4.AllowUserToDeleteRows = False
        Me.DataGridViewX4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewX4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX4.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX4.Location = New System.Drawing.Point(0, 25)
        Me.DataGridViewX4.Name = "DataGridViewX4"
        Me.DataGridViewX4.ReadOnly = True
        Me.DataGridViewX4.Size = New System.Drawing.Size(1256, 648)
        Me.DataGridViewX4.TabIndex = 3
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSaveNewV, Me.btnEditV, Me.btnDeleteV, Me.btnRefreshV})
        Me.ToolStrip4.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(1256, 25)
        Me.ToolStrip4.TabIndex = 2
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'btnAddNewP
        '
        Me.btnAddNewP.Image = CType(resources.GetObject("btnAddNewP.Image"), System.Drawing.Image)
        Me.btnAddNewP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddNewP.Name = "btnAddNewP"
        Me.btnAddNewP.Size = New System.Drawing.Size(51, 22)
        Me.btnAddNewP.Text = "New"
        '
        'btnEditP
        '
        Me.btnEditP.Image = CType(resources.GetObject("btnEditP.Image"), System.Drawing.Image)
        Me.btnEditP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditP.Name = "btnEditP"
        Me.btnEditP.Size = New System.Drawing.Size(47, 22)
        Me.btnEditP.Text = "Edit"
        '
        'btnDeleteP
        '
        Me.btnDeleteP.Image = CType(resources.GetObject("btnDeleteP.Image"), System.Drawing.Image)
        Me.btnDeleteP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeleteP.Name = "btnDeleteP"
        Me.btnDeleteP.Size = New System.Drawing.Size(60, 22)
        Me.btnDeleteP.Text = "Delete"
        '
        'btnRefreshP
        '
        Me.btnRefreshP.Image = CType(resources.GetObject("btnRefreshP.Image"), System.Drawing.Image)
        Me.btnRefreshP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefreshP.Name = "btnRefreshP"
        Me.btnRefreshP.Size = New System.Drawing.Size(66, 22)
        Me.btnRefreshP.Text = "Refresh"
        '
        'btnAddNewD
        '
        Me.btnAddNewD.Image = CType(resources.GetObject("btnAddNewD.Image"), System.Drawing.Image)
        Me.btnAddNewD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddNewD.Name = "btnAddNewD"
        Me.btnAddNewD.Size = New System.Drawing.Size(51, 22)
        Me.btnAddNewD.Text = "New"
        '
        'btnEditD
        '
        Me.btnEditD.Image = CType(resources.GetObject("btnEditD.Image"), System.Drawing.Image)
        Me.btnEditD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditD.Name = "btnEditD"
        Me.btnEditD.Size = New System.Drawing.Size(47, 22)
        Me.btnEditD.Text = "Edit"
        '
        'btnDeleteD
        '
        Me.btnDeleteD.Image = CType(resources.GetObject("btnDeleteD.Image"), System.Drawing.Image)
        Me.btnDeleteD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeleteD.Name = "btnDeleteD"
        Me.btnDeleteD.Size = New System.Drawing.Size(60, 22)
        Me.btnDeleteD.Text = "Delete"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(66, 22)
        Me.btnRefresh.Text = "Refresh"
        '
        'btnSaveNewC
        '
        Me.btnSaveNewC.Image = CType(resources.GetObject("btnSaveNewC.Image"), System.Drawing.Image)
        Me.btnSaveNewC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveNewC.Name = "btnSaveNewC"
        Me.btnSaveNewC.Size = New System.Drawing.Size(51, 22)
        Me.btnSaveNewC.Text = "New"
        '
        'btnEditC
        '
        Me.btnEditC.Image = CType(resources.GetObject("btnEditC.Image"), System.Drawing.Image)
        Me.btnEditC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditC.Name = "btnEditC"
        Me.btnEditC.Size = New System.Drawing.Size(47, 22)
        Me.btnEditC.Text = "Edit"
        '
        'btnDeleteC
        '
        Me.btnDeleteC.Image = CType(resources.GetObject("btnDeleteC.Image"), System.Drawing.Image)
        Me.btnDeleteC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeleteC.Name = "btnDeleteC"
        Me.btnDeleteC.Size = New System.Drawing.Size(60, 22)
        Me.btnDeleteC.Text = "Delete"
        '
        'btnRefreshC
        '
        Me.btnRefreshC.Image = CType(resources.GetObject("btnRefreshC.Image"), System.Drawing.Image)
        Me.btnRefreshC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefreshC.Name = "btnRefreshC"
        Me.btnRefreshC.Size = New System.Drawing.Size(66, 22)
        Me.btnRefreshC.Text = "Refresh"
        '
        'btnSaveNewV
        '
        Me.btnSaveNewV.Image = CType(resources.GetObject("btnSaveNewV.Image"), System.Drawing.Image)
        Me.btnSaveNewV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveNewV.Name = "btnSaveNewV"
        Me.btnSaveNewV.Size = New System.Drawing.Size(51, 22)
        Me.btnSaveNewV.Text = "New"
        '
        'btnEditV
        '
        Me.btnEditV.Image = CType(resources.GetObject("btnEditV.Image"), System.Drawing.Image)
        Me.btnEditV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditV.Name = "btnEditV"
        Me.btnEditV.Size = New System.Drawing.Size(47, 22)
        Me.btnEditV.Text = "Edit"
        '
        'btnDeleteV
        '
        Me.btnDeleteV.Image = CType(resources.GetObject("btnDeleteV.Image"), System.Drawing.Image)
        Me.btnDeleteV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeleteV.Name = "btnDeleteV"
        Me.btnDeleteV.Size = New System.Drawing.Size(60, 22)
        Me.btnDeleteV.Text = "Delete"
        '
        'btnRefreshV
        '
        Me.btnRefreshV.Image = CType(resources.GetObject("btnRefreshV.Image"), System.Drawing.Image)
        Me.btnRefreshV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefreshV.Name = "btnRefreshV"
        Me.btnRefreshV.Size = New System.Drawing.Size(66, 22)
        Me.btnRefreshV.Text = "Refresh"
        '
        'frmAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 741)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddress"
        Me.ShowIcon = False
        Me.PanelEx1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridViewX3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridViewX4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAddNewP As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditP As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeleteP As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefreshP As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAddNewD As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditD As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeleteD As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewX3 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSaveNewC As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditC As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeleteC As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefreshC As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewX4 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSaveNewV As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditV As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeleteV As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefreshV As System.Windows.Forms.ToolStripButton
End Class

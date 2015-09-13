<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAttendance))
        Me.pnlAttendenceInformation = New DevComponents.DotNetBar.PanelEx()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.tbtnNew = New System.Windows.Forms.ToolStripButton()
        Me.tbtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tbtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.tbtnExcel = New System.Windows.Forms.ToolStripButton()
        Me.tbtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAttendenceInformation
        '
        Me.pnlAttendenceInformation.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlAttendenceInformation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAttendenceInformation.Location = New System.Drawing.Point(0, 0)
        Me.pnlAttendenceInformation.Name = "pnlAttendenceInformation"
        Me.pnlAttendenceInformation.Size = New System.Drawing.Size(1003, 40)
        Me.pnlAttendenceInformation.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlAttendenceInformation.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.pnlAttendenceInformation.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.pnlAttendenceInformation.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.pnlAttendenceInformation.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.pnlAttendenceInformation.Style.GradientAngle = 90
        Me.pnlAttendenceInformation.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 40)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridViewX1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1003, 368)
        Me.SplitContainer1.SplitterDistance = 212
        Me.SplitContainer1.TabIndex = 1
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 25)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.Size = New System.Drawing.Size(787, 343)
        Me.DataGridViewX1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtnNew, Me.tbtnEdit, Me.tbtnDelete, Me.tbtnExcel, Me.tbtnRefresh, Me.btnSearch, Me.txtSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(787, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 25)
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Added"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 25)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(212, 343)
        Me.TreeView1.TabIndex = 1
        '
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
        '
        'tbtnExcel
        '
        Me.tbtnExcel.Image = CType(resources.GetObject("tbtnExcel.Image"), System.Drawing.Image)
        Me.tbtnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnExcel.Name = "tbtnExcel"
        Me.tbtnExcel.Size = New System.Drawing.Size(53, 22)
        Me.tbtnExcel.Text = "Excel"
        '
        'tbtnRefresh
        '
        Me.tbtnRefresh.Image = CType(resources.GetObject("tbtnRefresh.Image"), System.Drawing.Image)
        Me.tbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnRefresh.Name = "tbtnRefresh"
        Me.tbtnRefresh.Size = New System.Drawing.Size(66, 22)
        Me.tbtnRefresh.Text = "Refresh"
        '
        'btnSearch
        '
        Me.btnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        Me.btnSearch.Text = "ToolStripButton1"
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 408)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlAttendenceInformation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAttendance"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAttendenceInformation As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tbtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeInformation))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.AddNewLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tBtnAdd = New System.Windows.Forms.ToolStripButton()
        Me.tBtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tBtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.tBtnExcel = New System.Windows.Forms.ToolStripButton()
        Me.tBtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.btnClosePanel = New System.Windows.Forms.Button()
        Me.pnlEmployeeInfo = New DevComponents.DotNetBar.PanelEx()
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlEmployeeInfo.SuspendLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 35)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AddNewLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvEmployee)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1019, 412)
        Me.SplitContainer1.SplitterDistance = 204
        Me.SplitContainer1.TabIndex = 3
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 25)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(204, 387)
        Me.TreeView1.TabIndex = 1
        '
        'AddNewLabel
        '
        Me.AddNewLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddNewLabel.Location = New System.Drawing.Point(0, 0)
        Me.AddNewLabel.Name = "AddNewLabel"
        Me.AddNewLabel.Size = New System.Drawing.Size(204, 25)
        Me.AddNewLabel.TabIndex = 0
        Me.AddNewLabel.Text = "New Added"
        Me.AddNewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tBtnAdd, Me.tBtnEdit, Me.tBtnDelete, Me.tBtnExcel, Me.tBtnRefresh, Me.btnSearch, Me.txtSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(811, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tBtnAdd
        '
        Me.tBtnAdd.Image = CType(resources.GetObject("tBtnAdd.Image"), System.Drawing.Image)
        Me.tBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tBtnAdd.Name = "tBtnAdd"
        Me.tBtnAdd.Size = New System.Drawing.Size(51, 22)
        Me.tBtnAdd.Text = "New"
        '
        'tBtnEdit
        '
        Me.tBtnEdit.Enabled = False
        Me.tBtnEdit.Image = CType(resources.GetObject("tBtnEdit.Image"), System.Drawing.Image)
        Me.tBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tBtnEdit.Name = "tBtnEdit"
        Me.tBtnEdit.Size = New System.Drawing.Size(47, 22)
        Me.tBtnEdit.Text = "Edit"
        '
        'tBtnDelete
        '
        Me.tBtnDelete.Enabled = False
        Me.tBtnDelete.Image = CType(resources.GetObject("tBtnDelete.Image"), System.Drawing.Image)
        Me.tBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tBtnDelete.Name = "tBtnDelete"
        Me.tBtnDelete.Size = New System.Drawing.Size(60, 22)
        Me.tBtnDelete.Text = "Delete"
        '
        'tBtnExcel
        '
        Me.tBtnExcel.Image = CType(resources.GetObject("tBtnExcel.Image"), System.Drawing.Image)
        Me.tBtnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tBtnExcel.Name = "tBtnExcel"
        Me.tBtnExcel.Size = New System.Drawing.Size(53, 22)
        Me.tBtnExcel.Text = "Excel"
        '
        'tBtnRefresh
        '
        Me.tBtnRefresh.Image = CType(resources.GetObject("tBtnRefresh.Image"), System.Drawing.Image)
        Me.tBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tBtnRefresh.Name = "tBtnRefresh"
        Me.tBtnRefresh.Size = New System.Drawing.Size(66, 22)
        Me.tBtnRefresh.Text = "Refresh"
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
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 25)
        '
        'btnClosePanel
        '
        Me.btnClosePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClosePanel.FlatAppearance.BorderSize = 0
        Me.btnClosePanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClosePanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClosePanel.Location = New System.Drawing.Point(979, 0)
        Me.btnClosePanel.Name = "btnClosePanel"
        Me.btnClosePanel.Size = New System.Drawing.Size(40, 35)
        Me.btnClosePanel.TabIndex = 0
        Me.btnClosePanel.Text = "x"
        Me.btnClosePanel.UseVisualStyleBackColor = True
        '
        'pnlEmployeeInfo
        '
        Me.pnlEmployeeInfo.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlEmployeeInfo.Controls.Add(Me.btnClosePanel)
        Me.pnlEmployeeInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEmployeeInfo.Font = New System.Drawing.Font("Khmer OS Muol Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlEmployeeInfo.Location = New System.Drawing.Point(0, 0)
        Me.pnlEmployeeInfo.Name = "pnlEmployeeInfo"
        Me.pnlEmployeeInfo.Size = New System.Drawing.Size(1019, 35)
        Me.pnlEmployeeInfo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.pnlEmployeeInfo.Style.BackColor2.Color = System.Drawing.Color.PaleGreen
        Me.pnlEmployeeInfo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.pnlEmployeeInfo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.pnlEmployeeInfo.Style.GradientAngle = 90
        Me.pnlEmployeeInfo.Style.MarginLeft = 10
        Me.pnlEmployeeInfo.TabIndex = 2
        Me.pnlEmployeeInfo.Text = "ព័ត៏មានរបស់បុគ្គលិក"
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AllowUserToAddRows = False
        Me.dgvEmployee.AllowUserToDeleteRows = False
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmployee.Location = New System.Drawing.Point(0, 25)
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.ReadOnly = True
        Me.dgvEmployee.Size = New System.Drawing.Size(811, 387)
        Me.dgvEmployee.TabIndex = 1
        '
        'frmEmployeeInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlEmployeeInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployeeInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlEmployeeInfo.ResumeLayout(False)
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AddNewLabel As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tBtnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tBtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tBtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tBtnExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tBtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnClosePanel As System.Windows.Forms.Button
    Friend WithEvents pnlEmployeeInfo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dgvEmployee As System.Windows.Forms.DataGridView
End Class

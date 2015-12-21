<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapture
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgCapture = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCapture = New System.Windows.Forms.ToolStripButton()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.sBar = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.imgCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FToolStripMenuItem, Me.CaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(590, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FToolStripMenuItem
        '
        Me.FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExit})
        Me.FToolStripMenuItem.Name = "FToolStripMenuItem"
        Me.FToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FToolStripMenuItem.Text = "File"
        '
        'btnExit
        '
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 22)
        Me.btnExit.Text = "Exit"
        '
        'CaToolStripMenuItem
        '
        Me.CaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnStart, Me.btnStop, Me.btnReset})
        Me.CaToolStripMenuItem.Name = "CaToolStripMenuItem"
        Me.CaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.CaToolStripMenuItem.Text = "Camera"
        '
        'btnStart
        '
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(152, 22)
        Me.btnStart.Text = "Start"
        '
        'btnStop
        '
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(152, 22)
        Me.btnStop.Text = "Stop"
        '
        'btnReset
        '
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(152, 22)
        Me.btnReset.Text = "Reset"
        '
        'imgCapture
        '
        Me.imgCapture.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.imgCapture.Location = New System.Drawing.Point(0, 27)
        Me.imgCapture.Name = "imgCapture"
        Me.imgCapture.Size = New System.Drawing.Size(590, 426)
        Me.imgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCapture.TabIndex = 1
        Me.imgCapture.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCapture})
        Me.ToolStrip1.Location = New System.Drawing.Point(105, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(35, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCapture
        '
        Me.btnCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCapture.Image = Global.Payroll_Management_System.My.Resources.Resources._1441551327_vector_66_04
        Me.btnCapture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(23, 22)
        Me.btnCapture.Text = "ToolStripButton1"
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 500
        '
        'sBar
        '
        Me.sBar.AutoSize = True
        Me.sBar.Location = New System.Drawing.Point(224, 5)
        Me.sBar.Name = "sBar"
        Me.sBar.Size = New System.Drawing.Size(0, 13)
        Me.sBar.TabIndex = 3
        '
        'frmCapture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 453)
        Me.Controls.Add(Me.sBar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.imgCapture)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCapture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCapture"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.imgCapture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnStart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnStop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imgCapture As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCapture As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents sBar As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendence
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLate = New System.Windows.Forms.DateTimePicker()
        Me.txtOut = New System.Windows.Forms.DateTimePicker()
        Me.txtIn = New System.Windows.Forms.DateTimePicker()
        Me.btnSetOut = New DevComponents.DotNetBar.ButtonX()
        Me.btnSetIn = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnLate = New DevComponents.DotNetBar.ButtonX()
        Me.cboEmpID = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvWork = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvLate = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalWork = New System.Windows.Forms.TextBox()
        Me.txtTotalLate = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvWork, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvLate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLate)
        Me.GroupBox1.Controls.Add(Me.txtOut)
        Me.GroupBox1.Controls.Add(Me.txtIn)
        Me.GroupBox1.Controls.Add(Me.btnSetOut)
        Me.GroupBox1.Controls.Add(Me.btnSetIn)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.btnLate)
        Me.GroupBox1.Controls.Add(Me.cboEmpID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 268)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "វត្តមាន"
        '
        'txtLate
        '
        Me.txtLate.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtLate.Location = New System.Drawing.Point(87, 156)
        Me.txtLate.Name = "txtLate"
        Me.txtLate.Size = New System.Drawing.Size(225, 35)
        Me.txtLate.TabIndex = 4
        '
        'txtOut
        '
        Me.txtOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtOut.Location = New System.Drawing.Point(87, 116)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(225, 35)
        Me.txtOut.TabIndex = 4
        '
        'txtIn
        '
        Me.txtIn.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txtIn.Location = New System.Drawing.Point(87, 76)
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(225, 35)
        Me.txtIn.TabIndex = 4
        '
        'btnSetOut
        '
        Me.btnSetOut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSetOut.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSetOut.Enabled = False
        Me.btnSetOut.Location = New System.Drawing.Point(318, 116)
        Me.btnSetOut.Name = "btnSetOut"
        Me.btnSetOut.Size = New System.Drawing.Size(44, 36)
        Me.btnSetOut.TabIndex = 3
        Me.btnSetOut.Text = "Set"
        '
        'btnSetIn
        '
        Me.btnSetIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSetIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSetIn.Enabled = False
        Me.btnSetIn.Location = New System.Drawing.Point(318, 77)
        Me.btnSetIn.Name = "btnSetIn"
        Me.btnSetIn.Size = New System.Drawing.Size(44, 36)
        Me.btnSetIn.TabIndex = 3
        Me.btnSetIn.Text = "Set"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(318, 77)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(44, 36)
        Me.ButtonX1.TabIndex = 3
        Me.ButtonX1.Text = "Late"
        '
        'btnLate
        '
        Me.btnLate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLate.Enabled = False
        Me.btnLate.Location = New System.Drawing.Point(318, 156)
        Me.btnLate.Name = "btnLate"
        Me.btnLate.Size = New System.Drawing.Size(44, 36)
        Me.btnLate.TabIndex = 3
        Me.btnLate.Text = "Set"
        '
        'cboEmpID
        '
        Me.cboEmpID.FormattingEnabled = True
        Me.cboEmpID.Location = New System.Drawing.Point(87, 37)
        Me.cboEmpID.Name = "cboEmpID"
        Me.cboEmpID.Size = New System.Drawing.Size(225, 35)
        Me.cboEmpID.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "មកយឺត"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ម៉ោងចេញ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "កូដបុគ្គលិក"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ម៉ោងធ្វើការ"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Location = New System.Drawing.Point(-2, -3)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(895, 54)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        Me.PanelEx1.Text = "Attendance Control"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Payroll_Management_System.My.Resources.Resources._1442135746_close_red
        Me.PictureBox1.Location = New System.Drawing.Point(839, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvWork)
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(386, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 268)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ទិន្នន័យធ្វើការ"
        '
        'dgvWork
        '
        Me.dgvWork.AllowUserToAddRows = False
        Me.dgvWork.AllowUserToDeleteRows = False
        Me.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWork.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWork.Location = New System.Drawing.Point(3, 31)
        Me.dgvWork.Name = "dgvWork"
        Me.dgvWork.ReadOnly = True
        Me.dgvWork.Size = New System.Drawing.Size(241, 234)
        Me.dgvWork.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvLate)
        Me.GroupBox3.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(639, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(247, 268)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ទិន្នន័យមកយឺត"
        '
        'dgvLate
        '
        Me.dgvLate.AllowUserToAddRows = False
        Me.dgvLate.AllowUserToDeleteRows = False
        Me.dgvLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLate.Location = New System.Drawing.Point(3, 31)
        Me.dgvLate.Name = "dgvLate"
        Me.dgvLate.ReadOnly = True
        Me.dgvLate.Size = New System.Drawing.Size(241, 234)
        Me.dgvLate.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(461, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 27)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "សរុប"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(719, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 27)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "សរុប"
        '
        'txtTotalWork
        '
        Me.txtTotalWork.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalWork.Location = New System.Drawing.Point(506, 331)
        Me.txtTotalWork.Name = "txtTotalWork"
        Me.txtTotalWork.Size = New System.Drawing.Size(127, 35)
        Me.txtTotalWork.TabIndex = 1
        '
        'txtTotalLate
        '
        Me.txtTotalLate.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLate.Location = New System.Drawing.Point(759, 331)
        Me.txtTotalLate.Name = "txtTotalLate"
        Me.txtTotalLate.Size = New System.Drawing.Size(127, 35)
        Me.txtTotalLate.TabIndex = 1
        '
        'frmAttendence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(893, 378)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalLate)
        Me.Controls.Add(Me.txtTotalWork)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAttendence"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "y"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvWork, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvLate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboEmpID As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvWork As System.Windows.Forms.DataGridView
    Friend WithEvents dgvLate As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtTotalWork As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalLate As System.Windows.Forms.TextBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSetIn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSetOut As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLate As System.Windows.Forms.DateTimePicker
End Class

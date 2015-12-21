<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAttEmployee))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblResultIn = New System.Windows.Forms.Label()
        Me.btnIn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgIN = New System.Windows.Forms.PictureBox()
        Me.cboIn = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblResultOut = New System.Windows.Forms.Label()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.imgOut = New System.Windows.Forms.PictureBox()
        Me.cboOut = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imgIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.imgOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResultIn)
        Me.GroupBox1.Controls.Add(Me.btnIn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.imgIN)
        Me.GroupBox1.Controls.Add(Me.cboIn)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "កត់ម៉ោងចូល"
        '
        'lblResultIn
        '
        Me.lblResultIn.AutoSize = True
        Me.lblResultIn.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultIn.ForeColor = System.Drawing.Color.Red
        Me.lblResultIn.Location = New System.Drawing.Point(138, 234)
        Me.lblResultIn.Name = "lblResultIn"
        Me.lblResultIn.Size = New System.Drawing.Size(0, 47)
        Me.lblResultIn.TabIndex = 4
        '
        'btnIn
        '
        Me.btnIn.Location = New System.Drawing.Point(173, 137)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(190, 60)
        Me.btnIn.TabIndex = 3
        Me.btnIn.Text = "កត់ម៉ោងចូល"
        Me.btnIn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "លេខកូដបុគ្គលិក"
        '
        'imgIN
        '
        Me.imgIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgIN.Image = CType(resources.GetObject("imgIN.Image"), System.Drawing.Image)
        Me.imgIN.Location = New System.Drawing.Point(15, 34)
        Me.imgIN.Name = "imgIN"
        Me.imgIN.Size = New System.Drawing.Size(140, 163)
        Me.imgIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgIN.TabIndex = 2
        Me.imgIN.TabStop = False
        '
        'cboIn
        '
        Me.cboIn.FormattingEnabled = True
        Me.cboIn.Location = New System.Drawing.Point(173, 76)
        Me.cboIn.Name = "cboIn"
        Me.cboIn.Size = New System.Drawing.Size(190, 35)
        Me.cboIn.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblResultOut)
        Me.GroupBox2.Controls.Add(Me.btnOut)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.imgOut)
        Me.GroupBox2.Controls.Add(Me.cboOut)
        Me.GroupBox2.Location = New System.Drawing.Point(418, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 217)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "កត់ចេញ"
        '
        'lblResultOut
        '
        Me.lblResultOut.AutoSize = True
        Me.lblResultOut.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultOut.ForeColor = System.Drawing.Color.Red
        Me.lblResultOut.Location = New System.Drawing.Point(153, 234)
        Me.lblResultOut.Name = "lblResultOut"
        Me.lblResultOut.Size = New System.Drawing.Size(0, 47)
        Me.lblResultOut.TabIndex = 4
        '
        'btnOut
        '
        Me.btnOut.Location = New System.Drawing.Point(177, 137)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(190, 60)
        Me.btnOut.TabIndex = 3
        Me.btnOut.Text = "កត់ម៉ោងចេញ"
        Me.btnOut.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 27)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "លេខកូដបុគ្គលិក"
        '
        'imgOut
        '
        Me.imgOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgOut.Image = CType(resources.GetObject("imgOut.Image"), System.Drawing.Image)
        Me.imgOut.Location = New System.Drawing.Point(19, 34)
        Me.imgOut.Name = "imgOut"
        Me.imgOut.Size = New System.Drawing.Size(140, 163)
        Me.imgOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgOut.TabIndex = 6
        Me.imgOut.TabStop = False
        '
        'cboOut
        '
        Me.cboOut.FormattingEnabled = True
        Me.cboOut.Location = New System.Drawing.Point(177, 76)
        Me.cboOut.Name = "cboOut"
        Me.cboOut.Size = New System.Drawing.Size(190, 35)
        Me.cboOut.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(819, 58)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Payroll_Management_System.My.Resources.Resources._1442135746_close_red
        Me.PictureBox1.Location = New System.Drawing.Point(742, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmAttEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(817, 298)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "frmAttEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAttEmployee"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.imgIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.imgOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnIn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents imgIN As System.Windows.Forms.PictureBox
    Friend WithEvents cboIn As System.Windows.Forms.ComboBox
    Friend WithEvents btnOut As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents imgOut As System.Windows.Forms.PictureBox
    Friend WithEvents cboOut As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblResultIn As System.Windows.Forms.Label
    Friend WithEvents lblResultOut As System.Windows.Forms.Label
End Class

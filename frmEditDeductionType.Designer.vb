<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditDeductionType
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
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtDeduction = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodeDeduction = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(340, 156)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(97, 33)
        Me.btnCancel.TabIndex = 66
        Me.btnCancel.Text = "បិទ"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(222, 156)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 33)
        Me.btnSave.TabIndex = 65
        Me.btnSave.Text = "រក្សាទុក"
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX2.Location = New System.Drawing.Point(41, 96)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(143, 36)
        Me.LabelX2.TabIndex = 64
        Me.LabelX2.Text = "ប្រភេទប្រាក់ត្រូវកាត់"
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.LabelX1.Location = New System.Drawing.Point(41, 37)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 35)
        Me.LabelX1.TabIndex = 63
        Me.LabelX1.Text = "លេខកូដ"
        '
        'txtDeduction
        '
        '
        '
        '
        Me.txtDeduction.Border.Class = "TextBoxBorder"
        Me.txtDeduction.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.txtDeduction.Location = New System.Drawing.Point(222, 93)
        Me.txtDeduction.Name = "txtDeduction"
        Me.txtDeduction.Size = New System.Drawing.Size(213, 41)
        Me.txtDeduction.TabIndex = 62
        '
        'txtCodeDeduction
        '
        '
        '
        '
        Me.txtCodeDeduction.Border.Class = "TextBoxBorder"
        Me.txtCodeDeduction.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 11.25!)
        Me.txtCodeDeduction.Location = New System.Drawing.Point(222, 32)
        Me.txtCodeDeduction.Name = "txtCodeDeduction"
        Me.txtCodeDeduction.Size = New System.Drawing.Size(213, 41)
        Me.txtCodeDeduction.TabIndex = 61
        '
        'frmEditDeductionType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 220)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtDeduction)
        Me.Controls.Add(Me.txtCodeDeduction)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditDeductionType"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDeduction As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCodeDeduction As DevComponents.DotNetBar.Controls.TextBoxX
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddVillage
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveNew = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.cboProvince = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboDistrict = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtVillage = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.cboCommune = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.70414!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.29586!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSaveNew, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(158, 220)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(251, 38)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'btnSaveNew
        '
        Me.btnSaveNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSaveNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSaveNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveNew.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNew.Location = New System.Drawing.Point(3, 3)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(78, 32)
        Me.btnSaveNew.TabIndex = 0
        Me.btnSaveNew.Text = "រក្សារទុក ថ្មី"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(87, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 32)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "រក្សារទុក"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(172, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "បិទ"
        '
        'cboProvince
        '
        Me.cboProvince.DisplayMember = "Text"
        Me.cboProvince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboProvince.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.ItemHeight = 26
        Me.cboProvince.Location = New System.Drawing.Point(158, 53)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(251, 32)
        Me.cboProvince.TabIndex = 23
        '
        'cboDistrict
        '
        Me.cboDistrict.DisplayMember = "Text"
        Me.cboDistrict.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDistrict.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDistrict.FormattingEnabled = True
        Me.cboDistrict.ItemHeight = 26
        Me.cboDistrict.Location = New System.Drawing.Point(158, 94)
        Me.cboDistrict.Name = "cboDistrict"
        Me.cboDistrict.Size = New System.Drawing.Size(251, 32)
        Me.cboDistrict.TabIndex = 25
        '
        'LabelX3
        '
        Me.LabelX3.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(46, 95)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(101, 43)
        Me.LabelX3.TabIndex = 24
        Me.LabelX3.Text = "ឈ្នោះស្រុក"
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(48, 54)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(101, 43)
        Me.LabelX2.TabIndex = 22
        Me.LabelX2.Text = "ឈ្នោះខេត្ត"
        '
        'txtVillage
        '
        '
        '
        '
        Me.txtVillage.Border.Class = "TextBoxBorder"
        Me.txtVillage.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVillage.Location = New System.Drawing.Point(158, 176)
        Me.txtVillage.Name = "txtVillage"
        Me.txtVillage.Size = New System.Drawing.Size(251, 32)
        Me.txtVillage.TabIndex = 20
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(42, 172)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(101, 43)
        Me.LabelX1.TabIndex = 19
        Me.LabelX1.Text = "ឈ្នោះភូមិ"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Khmer OS Muol Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(454, 35)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.PaleGreen
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 18
        Me.PanelEx1.Text = "បន្ថែមភូមិ"
        '
        'cboCommune
        '
        Me.cboCommune.DisplayMember = "Text"
        Me.cboCommune.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCommune.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCommune.FormattingEnabled = True
        Me.cboCommune.ItemHeight = 26
        Me.cboCommune.Location = New System.Drawing.Point(158, 135)
        Me.cboCommune.Name = "cboCommune"
        Me.cboCommune.Size = New System.Drawing.Size(251, 32)
        Me.cboCommune.TabIndex = 27
        '
        'LabelX4
        '
        Me.LabelX4.Font = New System.Drawing.Font("Khmer OS Metal Chrieng", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(46, 128)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(101, 43)
        Me.LabelX4.TabIndex = 26
        Me.LabelX4.Text = "ឈ្នោះឃុំ"
        '
        'frmAddVillage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 289)
        Me.Controls.Add(Me.cboCommune)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.cboProvince)
        Me.Controls.Add(Me.cboDistrict)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.txtVillage)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.PanelEx1)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddVillage"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSaveNew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboProvince As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboDistrict As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtVillage As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cboCommune As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
End Class

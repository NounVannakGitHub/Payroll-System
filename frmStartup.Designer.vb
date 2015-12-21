<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartup
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ExpandablePanel3 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.ExpandablePanel2 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Chart1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1264, 741)
        Me.SplitContainer1.SplitterDistance = 262
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.ExpandablePanel3)
        Me.Panel1.Controls.Add(Me.ExpandablePanel2)
        Me.Panel1.Controls.Add(Me.ExpandablePanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 741)
        Me.Panel1.TabIndex = 0
        '
        'ExpandablePanel3
        '
        Me.ExpandablePanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.ExpandablePanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.ExpandablePanel3.Location = New System.Drawing.Point(0, 429)
        Me.ExpandablePanel3.Name = "ExpandablePanel3"
        Me.ExpandablePanel3.Size = New System.Drawing.Size(262, 311)
        Me.ExpandablePanel3.Style.BackColor1.Color = System.Drawing.Color.DarkSeaGreen
        Me.ExpandablePanel3.Style.BackColor2.Color = System.Drawing.Color.DarkSeaGreen
        Me.ExpandablePanel3.Style.BorderColor.Color = System.Drawing.Color.White
        Me.ExpandablePanel3.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.ExpandablePanel3.Style.BorderWidth = 0
        Me.ExpandablePanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel3.Style.GradientAngle = 90
        Me.ExpandablePanel3.TabIndex = 2
        Me.ExpandablePanel3.TitleHeight = 35
        Me.ExpandablePanel3.TitleStyle.BackColor1.Color = System.Drawing.Color.MediumSeaGreen
        Me.ExpandablePanel3.TitleStyle.BackColor2.Color = System.Drawing.Color.MediumSeaGreen
        Me.ExpandablePanel3.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel3.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel3.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.ExpandablePanel3.TitleStyle.BorderWidth = 0
        Me.ExpandablePanel3.TitleStyle.Font = New System.Drawing.Font("Khmer OS Muol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpandablePanel3.TitleStyle.ForeColor.Color = System.Drawing.Color.White
        Me.ExpandablePanel3.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel3.TitleStyle.MarginLeft = 10
        Me.ExpandablePanel3.TitleText = "បង្កើតបុគ្គលិក"
        '
        'ExpandablePanel2
        '
        Me.ExpandablePanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.ExpandablePanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.ExpandablePanel2.Location = New System.Drawing.Point(0, 204)
        Me.ExpandablePanel2.Name = "ExpandablePanel2"
        Me.ExpandablePanel2.Size = New System.Drawing.Size(262, 225)
        Me.ExpandablePanel2.Style.BackColor1.Color = System.Drawing.Color.DarkSeaGreen
        Me.ExpandablePanel2.Style.BackColor2.Color = System.Drawing.Color.DarkSeaGreen
        Me.ExpandablePanel2.Style.BorderColor.Color = System.Drawing.Color.White
        Me.ExpandablePanel2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.ExpandablePanel2.Style.BorderWidth = 0
        Me.ExpandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel2.Style.GradientAngle = 90
        Me.ExpandablePanel2.TabIndex = 1
        Me.ExpandablePanel2.TitleHeight = 35
        Me.ExpandablePanel2.TitleStyle.BackColor1.Color = System.Drawing.Color.MediumSeaGreen
        Me.ExpandablePanel2.TitleStyle.BackColor2.Color = System.Drawing.Color.MediumSeaGreen
        Me.ExpandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel2.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.ExpandablePanel2.TitleStyle.BorderWidth = 0
        Me.ExpandablePanel2.TitleStyle.Font = New System.Drawing.Font("Khmer OS Muol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpandablePanel2.TitleStyle.ForeColor.Color = System.Drawing.Color.White
        Me.ExpandablePanel2.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel2.TitleStyle.MarginLeft = 10
        Me.ExpandablePanel2.TitleText = "បង្កើតបុគ្គលិក"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ExpandablePanel1.Location = New System.Drawing.Point(0, 0)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(262, 204)
        Me.ExpandablePanel1.Style.BackColor1.Color = System.Drawing.Color.DarkSeaGreen
        Me.ExpandablePanel1.Style.BackColor2.Color = System.Drawing.Color.DarkSeaGreen
        Me.ExpandablePanel1.Style.BorderColor.Color = System.Drawing.Color.White
        Me.ExpandablePanel1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.ExpandablePanel1.Style.BorderWidth = 0
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 0
        Me.ExpandablePanel1.TitleHeight = 35
        Me.ExpandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.MediumSeaGreen
        Me.ExpandablePanel1.TitleStyle.BackColor2.Color = System.Drawing.Color.MediumSeaGreen
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.ExpandablePanel1.TitleStyle.BorderWidth = 0
        Me.ExpandablePanel1.TitleStyle.Font = New System.Drawing.Font("Khmer OS Muol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.White
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleStyle.MarginLeft = 10
        Me.ExpandablePanel1.TitleText = "បង្កើតបុគ្គលិក"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(998, 741)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'frmStartup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 741)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStartup"
        Me.ShowIcon = False
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ExpandablePanel3 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents ExpandablePanel2 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class

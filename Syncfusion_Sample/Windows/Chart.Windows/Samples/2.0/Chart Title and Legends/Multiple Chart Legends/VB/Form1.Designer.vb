<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits Syncfusion.Windows.Forms.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
        Me.SuspendLayout()
        '
        'chartControl1
        '
        Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.chartControl1.Legend.IsWindowLess = False
        Me.chartControl1.Legend.Location = New System.Drawing.Point(265, 10)
        Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
        Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
        Me.chartControl1.Legend.TabIndex = 1
        Me.chartControl1.LegendPosition = Syncfusion.Windows.Forms.Chart.ChartDock.Top
        Me.chartControl1.Legends.Add(Me.chartControl1.Legend)
        Me.chartControl1.Location = New System.Drawing.Point(0, 0)
        Me.chartControl1.Name = "chartControl1"
        Me.chartControl1.ShadowColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer)))
        Me.chartControl1.Size = New System.Drawing.Size(620, 415)
        Me.chartControl1.TabIndex = 1
        '
        '
        '
        Me.chartControl1.Title.Name = "Def_title"
        Me.chartControl1.Title.Size = New System.Drawing.Size(8, 8)
        Me.chartControl1.Title.TabIndex = 2
        Me.chartControl1.Title.Visible = False
        Me.chartControl1.Titles.Add(Me.chartControl1.Title)
        Me.chartControl1.ToolBar.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 415)
        Me.Controls.Add(Me.chartControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple chart legends"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl

End Class

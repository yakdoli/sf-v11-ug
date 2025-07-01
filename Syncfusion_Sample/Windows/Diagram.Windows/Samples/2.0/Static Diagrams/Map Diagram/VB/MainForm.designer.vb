Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Tools
Imports System.Drawing
Imports Syncfusion.SVG.IO
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms
Imports System.Reflection
Imports System.IO
Imports System.Drawing.Drawing2D
Imports DemoCommon.Diagram

Namespace Map
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub


		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
			Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
			Me.groupBarItemTestSymbols = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.panel1 = New DemoCommon.Diagram.TitlePanel()
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' saveFileDialog1
			' 
			Me.saveFileDialog1.Filter = "Essential Diagram Files|*.edp|All files|*.*"
			' 
			' groupBarItemTestSymbols
			' 
			Me.groupBarItemTestSymbols.Client = Nothing
			Me.groupBarItemTestSymbols.ForeColor = System.Drawing.SystemColors.ControlText
			Me.groupBarItemTestSymbols.Text = "Test Symbols"
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.panel1.ControlBox = False
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Form = Me
			Me.panel1.Location = New System.Drawing.Point(2, 2)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1150, 70)
			Me.panel1.TabIndex = 0
			Me.panel1.TitleText = "Map Demo"
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.HScroll = True
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(2, 72)
			Me.diagram1.MetroScrollBars = True
			Me.diagram1.Model = Me.model1
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(1150, 610)
			Me.diagram1.SmartSizeBox = False
			Me.diagram1.TabIndex = 1
			Me.diagram1.Text = "diagram1"
			' 
			' 
			' 
			Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
			Me.diagram1.View.Controller = Me.diagram1.Controller
			Me.diagram1.View.Grid.MinPixelSpacing = 4F
			Me.diagram1.View.Grid.Visible = False
			Me.diagram1.View.ScrollVirtualBounds = (CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.VScroll = True
			' 
			' model1
			' 
			Me.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
			Me.model1.DocumentScale.DisplayName = "No Scale"
			Me.model1.DocumentScale.Height = 1F
			Me.model1.DocumentScale.Width = 1F
			Me.model1.DocumentSize.Height = 1169F
			Me.model1.DocumentSize.Width = 827F
			Me.model1.LineStyle.DashPattern = Nothing
			Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
			Me.model1.LineStyle.LineWidth = 0F
			Me.model1.LogicalSize = New System.Drawing.SizeF(827F, 1169F)
			Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			' 
			' MainForm
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
			Me.BackColor = System.Drawing.SystemColors.Control
			Me.ClientSize = New System.Drawing.Size(1154, 684)
			Me.Controls.Add(Me.diagram1)
			Me.Controls.Add(Me.panel1)
			Me.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "MainForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Map Demo"
'			Me.Load += New System.EventHandler(Me.MainForm_Load)
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region


		Private openFileDialog1 As OpenFileDialog
		Private saveFileDialog1 As SaveFileDialog
		Private groupBarItemTestSymbols As GroupBarItem
		Private globelNode As Node
		Private toolTip1 As New ToolTip()
		Private defaultColor As Color
		Private PolygonNode As Polygon
		Private panel1 As TitlePanel
		Private diagram1 As Diagram
		Private model1 As Model

	End Class
End Namespace
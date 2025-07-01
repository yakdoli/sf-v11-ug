Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
'
'  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
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
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Partial Public Class MainForm
		Inherits DemoForm

		#Region "Class initialize/finalize methods"
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Me.diagram1.Model = Me.model1

		End Sub

		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New MainForm())
		End Sub

		#Region "Class Event handlers"


		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.diagram1.MetroScrollBars = True
			AddHandler diagram1.EventSink.NodeMouseEnter, AddressOf EventSink_NodeMouseEnter
			AddHandler diagram1.EventSink.NodeMouseLeave, AddressOf EventSink_NodeMouseLeave

			'Loading the diagram file
			Me.diagram1.LoadBinary("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\HighLightDiagram.edd")

			For Each n As Node In Me.diagram1.Model.Nodes
				n.EditStyle.AllowSelect = False
			Next n
			Me.diagram1.AllowDrop = False
		End Sub



		#Region "Event Handlers"
		Private Sub EventSink_NodeMouseLeave(ByVal evtArgs As NodeMouseEventArgs)
			Dim poly As Polygon = TryCast(evtArgs.Node, Polygon)
			If poly IsNot Nothing Then
				poly.FillStyle.Color = defaultColor
			End If
		End Sub

		Private Sub EventSink_NodeMouseEnter(ByVal evtArgs As NodeMouseEventArgs)
			Dim poly As Polygon = TryCast(evtArgs.Node, Polygon)
			If poly IsNot Nothing Then
				defaultColor = poly.FillStyle.Color
				poly.FillStyle.Color = Color.White
				toolTip1.SetToolTip(diagram1, poly.Name)
				toolTip1.Active = True
			End If
		End Sub
		#End Region

	   #End Region
	End Class
End Namespace

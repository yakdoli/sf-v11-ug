Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Drawing.Printing
Imports System.Drawing.Imaging
Imports Syncfusion.SVG.IO
Imports Syncfusion.Windows.Forms
Imports System.Collections
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Imports Syncfusion
Imports DemoCommon.Diagram


Namespace SeatReservation
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Members"
		Public fileName As String
		Private seatsReserved As New Hashtable()

		Private selectedSeats As ArrayList = Nothing
		Private seats As New NodeCollection()
		Private newSelection As Boolean = False
		#End Region

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
			diagram1.BeginUpdate()
			diagram1.Model.BoundaryConstraintsEnabled = False
			Dim palette As SymbolPalette = Me.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\SeatReservationSymbols.edp")
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.Model.DocumentSize = New PageSize(1169, 1269)
            Me.diagram1.Model.BoundaryConstraintsEnabled = False
            Me.diagram1.Controller.InPlaceEditing = False
			InitializeDiagram(palette)
			DiagramAppearance()
			diagram1.EndUpdate()

			AddHandler diagram1.EventSink.NodeMouseEnter, AddressOf EventSink_NodeMouseEnter
			AddHandler diagram1.EventSink.NodeMouseLeave, AddressOf EventSink_NodeMouseLeave
			AddHandler diagram1.EventSink.NodeClick, AddressOf EventSink_NodeClick

		End Sub
		#End Region

		#Region "Initialize Diagram"
		Private Sub InitializeDiagram(ByVal palette As SymbolPalette)
			Dim x As Single = 150
			Dim y As Single = 150
			Dim rowNodeCnt As Integer = 1, j As Integer = 0
			Dim strRow() As String = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" }

			Dim txtNode As New TextNode("View and Change Seats", New RectangleF(250, 20, 400, 70))
			txtNode.FontColorStyle.Color = Color.White
			txtNode.FontStyle.Family = "Arial"
			txtNode.FontStyle.Size = 17
			txtNode.HorizontalAlignment = StringAlignment.Center
			txtNode.FontStyle.Bold = True
			txtNode.LineStyle.LineColor = Color.Transparent
			txtNode.EditStyle.AllowSelect = False
			diagram1.Model.AppendChild(txtNode)

			Dim availSeats As New Group(TryCast(palette.Nodes("Seat"), Group))
            availSeats.Name = "availSeats"
			availSeats.PinPoint = New PointF(250, 80)
			availSeats.Size = New SizeF(20, 20)
			availSeats.EditStyle.AllowSelect = False
			diagram1.Model.AppendChild(availSeats)
			Dim availTNode As New TextNode("Available Seats", New RectangleF(265, 70, 90, 20))
			availTNode.FontStyle.Family = "Arial"
			availTNode.FontColorStyle.Color = Color.White
			availTNode.FontStyle.Size = 8
			availTNode.VerticalAlignment = StringAlignment.Center
			availTNode.LineStyle.LineColor = Color.Transparent
			availTNode.EditStyle.AllowSelect = False
			diagram1.Model.AppendChild(availTNode)

			Dim bookedSeats As New Group(TryCast(palette.Nodes("Seat"), Group))
            bookedSeats.Name = "bookedSeats"
			bookedSeats.PinPoint = New PointF(380, 80)
			bookedSeats.Size = New SizeF(20, 20)
			bookedSeats.EditStyle.AllowSelect = False
			For Each node As Node In bookedSeats.Nodes
				If TypeOf node Is FilledPath Then
					CType(node, FilledPath).FillStyle.Color = Color.FromArgb(134, 134, 134)
					CType(node, FilledPath).FillStyle.ForeColor = Color.FromArgb(163, 163, 163)
					node.LineStyle.LineColor = Color.DarkGray
				End If
			Next node
			diagram1.Model.AppendChild(bookedSeats)
			Dim bookedTNode As New TextNode("Booked Seats", New RectangleF(395, 70, 90, 20))
			bookedTNode.FontStyle.Family = "Arial"
			bookedTNode.FontColorStyle.Color = Color.White
			bookedTNode.FontStyle.Size = 8
			bookedTNode.VerticalAlignment = StringAlignment.Center
			bookedTNode.LineStyle.LineColor = Color.Transparent
			bookedTNode.EditStyle.AllowSelect = False
			diagram1.Model.AppendChild(bookedTNode)

			Dim curSelSeats As New Group(TryCast(palette.Nodes("Seat"), Group))
			curSelSeats.PinPoint = New PointF(500, 80)
			curSelSeats.Size = New SizeF(20, 20)
			curSelSeats.EditStyle.AllowSelect = False
			For Each node As Node In curSelSeats.Nodes
				If TypeOf node Is FilledPath Then
					CType(node, FilledPath).FillStyle.Color = Color.FromArgb(0, 155, 0)
					CType(node, FilledPath).FillStyle.ForeColor = Color.FromArgb(80, 255, 89)
					node.LineStyle.LineColor = Color.Black
				End If
			Next node
			diagram1.Model.AppendChild(curSelSeats)
			Dim CurSelTNode As New TextNode("Current Selection", New RectangleF(515, 70, 90, 20))
			CurSelTNode.FontStyle.Family = "Arial"
			CurSelTNode.FontColorStyle.Color = Color.White
			CurSelTNode.FontStyle.Size = 8
			CurSelTNode.VerticalAlignment = StringAlignment.Center
			CurSelTNode.LineStyle.LineColor = Color.Transparent
			CurSelTNode.EditStyle.AllowSelect = False
			diagram1.Model.AppendChild(CurSelTNode)

			For i As Integer = 1 To 105
				Dim seatNode As New Group(TryCast(palette.Nodes("Seat"), Group))
				Dim lbl As New Syncfusion.Windows.Forms.Diagram.Label(seatNode, i.ToString())
				lbl.FontStyle.Family = "Arial"
				lbl.FontColorStyle.Color = Color.White
				seatNode.Labels.Add(lbl)
				seatNode.Size = New SizeF(30, 30)
				seatNode.PinPoint = New PointF(x, y)
				seatNode.EditStyle.AllowMoveX = False
				seatNode.EditStyle.AllowMoveY = False
				seatNode.EditStyle.AllowChangeHeight = False
				seatNode.EditStyle.AllowChangeWidth = False
				seatNode.EditStyle.DefaultHandleEditMode = HandleEditMode.None
				diagram1.Model.AppendChild(seatNode)
				seats.Add(seatNode)

				If rowNodeCnt = 10 Then
					x = x + 80
				Else
					x = x + 40
				End If

				If rowNodeCnt = 15 Then
					Dim rowNode As New Syncfusion.Windows.Forms.Diagram.Rectangle(100, y - 10, 20, 20)
					rowNode.FillStyle.Color = Color.Goldenrod
					rowNode.FillStyle.ForeColor = Color.Yellow
					rowNode.FillStyle.Type = FillStyleType.LinearGradient
					rowNode.LineStyle.LineColor = Color.Goldenrod
					rowNode.EditStyle.AllowSelect = False
					Dim lbl1 As New Syncfusion.Windows.Forms.Diagram.Label(rowNode, strRow(j))
					lbl1.FontStyle.Family = "Arial"
					lbl1.FontColorStyle.Color = Color.Black
					rowNode.Labels.Add(lbl1)
					diagram1.Model.AppendChild(rowNode)
					x = 150
					y = y + 40
					rowNodeCnt = 0
					j += 1
				End If
				rowNodeCnt += 1
			Next i

            Dim rect As New Syncfusion.Windows.Forms.Diagram.Rectangle(150, y + 40, 600, 50)
            rect.FillStyle.Color = Color.WhiteSmoke
            rect.LineStyle.LineColor = Color.LightGray
            Dim label As New Syncfusion.Windows.Forms.Diagram.Label(rect, "Screen this way")
            label.FontStyle.Bold = True
            label.FontStyle.Size = 16
            label.FontStyle.Family = "Segoe UI"
            rect.Labels.Add(label)
            diagram1.Model.AppendChild(rect)
			diagram1.BeginUpdate()
			ReserveSeats()
			diagram1.EndUpdate()
		End Sub

		Private Sub ReserveSeats()
			Dim rand As New Random()
			Dim updated As Boolean = False
			'Randomly select some seats and mark them as "Reserved".
			Dim count As Integer = 0
			Do While count < 15
				Dim grp As Group = TryCast(seats(rand.Next(1, 50)), Group)
				If grp IsNot Nothing Then
					For Each node1 As Node In grp.Nodes
						If (node1 IsNot Nothing) AndAlso (node1.Name <> "BitmapNode") AndAlso ((Not node1.Name.StartsWith("Exit"))) AndAlso (Not node1.Name.StartsWith("Group")) Then

							If TypeOf node1 Is FilledPath Then
								updated = True
								CType(node1, FilledPath).FillStyle.Color = Color.FromArgb(134, 134, 134)
								CType(node1, FilledPath).FillStyle.ForeColor = Color.FromArgb(163, 163, 163)
								node1.LineStyle.LineColor = Color.DarkGray
							End If
						End If
					Next node1
					If (Not seatsReserved.ContainsKey(grp.Name)) AndAlso updated Then
						seatsReserved.Add(grp.Name, "Reserved")
						count += 1
					End If
					updated = False
				End If
			Loop


			selectedSeats = New ArrayList()
			Me.textBox2.Text = ""
		End Sub

		' Get the SymbolPalette by deserializing the SymbolPalette file
		Public Function LoadPalette(ByVal filepath As String) As SymbolPalette
			Dim curSymbolPalette As SymbolPalette = Nothing
			Dim iStream As New FileStream(filepath, FileMode.Open, FileAccess.Read)
			If iStream IsNot Nothing Then
				Dim formatter As IFormatter = New BinaryFormatter()
				formatter.Binder = New OldToNewDeserializationBinder()
				Try
					AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf DiagramBaseAssembly.AssemblyResolver
					curSymbolPalette = CType(formatter.Deserialize(iStream), SymbolPalette)
				Catch e1 As SerializationException
					Try
						formatter = New BinaryFormatter()
						formatter.Binder = New OldToNewDeserializationBinder()
						iStream.Position = 0
						curSymbolPalette = CType(formatter.Deserialize(iStream), SymbolPalette)
					Catch se As Exception
						' To get the version from the edp file
						Dim strRegex As String = "version\w*=\w*\d+\.\d+\.\d+(\.\d+)+\w*,"
						Dim regex As New System.Text.RegularExpressions.Regex(strRegex, System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.Singleline)
						Dim sr As StreamReader = File.OpenText(filepath)
						Dim strFileContent As String = sr.ReadToEnd()
						Dim version As System.Text.RegularExpressions.Match = regex.Match(strFileContent)
						Dim strVersion As String = version.Value

						If String.IsNullOrEmpty(strVersion) Then
							Throw New System.Exception("Incompatible with older version." & Constants.vbLf & "Please use the converter utility to make it compatible with newer version", se)
						Else
							Throw New System.Exception("Unable to parse the palette file " & strVersion, se)
						End If
					End Try
				Finally
					iStream.Close()
					RemoveHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf DiagramBaseAssembly.AssemblyResolver
				End Try
			End If
			Return curSymbolPalette
		End Function

		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Change's the appearance of Diagram Control
		''' </summary>        
		Private Sub DiagramAppearance()
			Me.diagram1.View.Grid.GridStyle = GridStyle.Line
			Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.diagram1.View.Grid.Color = Color.LightGray
			Me.diagram1.View.Grid.VerticalSpacing = 15
			Me.diagram1.View.Grid.HorizontalSpacing = 15
			Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.View.SelectionList.Clear()
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub EventSink_NodeClick(ByVal evtArgs As NodeMouseEventArgs)
            diagram1.BeginUpdate()
            If newSelection Then
                Me.textBox2.Text = ""
                Me.textBox1.Text = ""
            End If
            If TypeOf evtArgs.Node Is Group AndAlso seats.Contains(evtArgs.Node) Then
                Dim alreadySelected As Boolean = False
                Dim seatNode As Group = TryCast(evtArgs.Node, Group)
                For Each val As String In selectedSeats
                    If val = seatNode.Name Then
                        alreadySelected = True
                    End If
                Next val
                If seatsReserved.ContainsKey(seatNode.Name) Then
                    MessageBoxAdv.Show("This seat is already reserved", "Reservation Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    If alreadySelected Then
                        selectedSeats.Remove(seatNode.Name)
                    End If
                Else
                    If Not selectedSeats.Contains(seatNode.Name) Then
                        For Each node As Node In seatNode.Nodes
                            If TypeOf node Is FilledPath Then
                                CType(node, FilledPath).FillStyle.Color = Color.FromArgb(0, 155, 0)
                                CType(node, FilledPath).FillStyle.ForeColor = Color.FromArgb(80, 255, 89)
                                node.LineStyle.LineColor = Color.Black
                            End If
                        Next node
                        selectedSeats.Add(seatNode.Name)
                        If textBox1.Text = "" Then
                            textBox1.Text = ""
                        End If
                        textBox1.Text += seatNode.Name & ", "
                        newSelection = False
                    End If
                End If
            End If
            diagram1.EndUpdate()
		End Sub

		Private Sub EventSink_NodeMouseLeave(ByVal evtArgs As NodeMouseEventArgs)
			diagram1.Controller.ActiveTool.ActionCursor = Cursors.Default
		End Sub

		Private Sub EventSink_NodeMouseEnter(ByVal evtArgs As NodeMouseEventArgs)
			diagram1.Controller.ActiveTool.ActionCursor = Cursors.Hand
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			diagram1.BeginUpdate()
			Me.textBox2.Text = ""
			For Each val As Object In selectedSeats
				Dim node1 As Node = diagram1.Model.Nodes.FindNodeByName(val.ToString())
				seatsReserved.Add(node1.Name, "Reserved")
				Dim grp As Group = TryCast(node1, Group)
				For Each gnode As Node In grp.Nodes
					If TypeOf gnode Is FilledPath Then
						CType(gnode, FilledPath).FillStyle.Color = Color.FromArgb(134, 134, 134)
						CType(gnode, FilledPath).FillStyle.ForeColor = Color.FromArgb(163, 163, 163)
						gnode.LineStyle.LineColor = Color.DarkGray
					End If
				Next gnode
				If Me.textBox2.Text <> "" Then
					textBox2.Text &= ", " & node1.Name
				Else
					textBox2.Text = node1.Name
				End If
			Next val
			textBox1.Text = ""
			selectedSeats.Clear()
			diagram1.EndUpdate()
			newSelection = True
		End Sub


		#End Region

		#Region "Helper Methods"

		#End Region
	End Class
End Namespace

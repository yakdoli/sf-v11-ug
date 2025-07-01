Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Collections
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Tools
Imports System.Drawing.Drawing2D
Imports System.IO
Imports Syncfusion.SVG.IO
Imports System.Drawing.Imaging
Imports Syncfusion.Windows.Forms
Imports System.Data.SqlServerCe

Namespace SaveDiagramAsBinary
	Partial Public Class Form1
		Inherits Form
		#Region "Members"
		Public fileName As String
		Private strCon As String
		Private saveMode As String = "ADD"
		#End Region

		#Region "Form initialize"
		Public Sub New()
			InitializeComponent()
			strCon = "Data Source=..\..\..\..\..\..\..\..\..\Common\Data\Diagram\DiagramDB.sdf"
			'upgrade the db to make it compatible
			Try
				Dim dbEngine As SqlCeEngine = New SqlCeEngine(strCon)
				dbEngine.Upgrade()
			Catch e1 As Exception
			End Try
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.diagram1.BeginUpdate()

			'Loads the diagram names into the diagramToolStripComboBox.
			LoadDiagramNames()
			Dim path As String = "..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Flowchart Symbols.edp"
			Me.paletteGroupBar1.LoadPalette(path)
			DiagramAppearance()
            GroupBarAppearance()
            If comboOpen.Items.Count > 0 Then
                comboOpen.SelectedIndex = 0
                LoadDiagram()
            End If
			Me.diagram1.EndUpdate()
		End Sub
		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Changes the appearance of the Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.HorizontalRuler.BackgroundColor = Color.White
			Me.diagram1.VerticalRuler.BackgroundColor = Color.White
			Me.diagram1.View.Grid.GridStyle = GridStyle.Line
			Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.diagram1.View.Grid.Color = Color.LightGray
			Me.diagram1.View.Grid.VerticalSpacing = 15
			Me.diagram1.View.Grid.HorizontalSpacing = 15
			Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.View.BackgroundColor = Color.White
			Me.diagram1.View.SelectionList.Clear()
		End Sub

		''' <summary>
		''' Change's the appearance of GroupBar
		''' </summary>
		Private Sub GroupBarAppearance()
			Me.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA")
			For Each item As GroupBarItem In paletteGroupBar1.GroupBarItems
				'palette view settings
				If TypeOf item.Client Is PaletteGroupView Then
					Dim view As PaletteGroupView = TryCast(item.Client, PaletteGroupView)
					view.Font = New Font("Segoe UI", 9, System.Drawing.FontStyle.Regular)
					view.ForeColor = Color.Black
					view.FlowView = True
					view.ShowToolTips = True
					view.ShowFlowViewItemText = True
					view.SelectedItemColor = Color.FromArgb(255, 219, 118)
					view.HighlightItemColor = Color.FromArgb(255, 227, 149)
					view.SelectingItemColor = Color.FromArgb(255, 238, 184)
					view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115)
					view.FlowViewItemTextLength = 80
					view.BackColor = Color.White
					view.TextWrap = True
					view.FlatLook = True
					view.BorderStyle = BorderStyle.FixedSingle
				End If
			Next item
		End Sub
		#End Region

		#Region "InitializeDiagram"

		''' <summary>
		''' Loads the Diagram 
		''' </summary>
		Private Sub LoadDiagram()
			'Create an instance of connection and command object.
			Dim con As New SqlCeConnection(strCon)
			Dim cmd As New SqlCeCommand("SELECT Diagram FROM DiagramContent WHERE DiagramName = @DiagramName", con)

			'Set parameter value.
			cmd.Parameters.AddWithValue("@DiagramName", comboOpen.Text)

			'Execute the command.
			con.Open()
			Dim dBinary() As Byte = CType(cmd.ExecuteScalar(), Byte())
			con.Close()

			'Load the stream.
			Dim dStream As New MemoryStream(dBinary, 0, dBinary.Length)
			dStream.Position = 0
			diagram1.LoadBinary(dStream)
			dStream.Close()
		End Sub

		''' <summary>
		''' Create New Diagram
		''' </summary>
		Private Sub AddNewDiagram()
			Dim dStream As New MemoryStream()
			'Create an instance of the save form.
			Dim saveDiagram As New SaveDialog()
			Dim strDiagramName As String = String.Empty

			'Display the save form.
			If saveDiagram.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				strDiagramName = saveDiagram.DiagramName
			Else
				Return
			End If

			'Save the diagram content to stream.
			diagram1.SaveBinary(dStream)
			Dim dBinary() As Byte = dStream.ToArray()

			'Create an instance of the connection and command object.
			Dim con As New SqlCeConnection(strCon)
			Dim cmd As New SqlCeCommand("INSERT INTO DiagramContent (DiagramName, Diagram) VALUES (@DiagramName, @Diagram)", con)

			'Set parameter values
			cmd.Parameters.AddWithValue("@DiagramName", strDiagramName)
			cmd.Parameters.AddWithValue("@Diagram", dBinary)

			'Execute the command.
			con.Open()
			cmd.ExecuteNonQuery()
			con.Close()

			'Reload the diagramToolStripComboBox control.
			LoadDiagramNames()

			comboOpen.SelectedItem = strDiagramName
		End Sub

		''' <summary>
		''' Updates the diagram in the database
		''' </summary>
		Private Sub UpdateDiagram()
			Dim dStream As New MemoryStream()
			'Save the diagram content to stream.
			diagram1.SaveBinary(dStream)
			Dim dBinary() As Byte = dStream.ToArray()

			'Create an instance of the connection and command object.
			Dim con As New SqlCeConnection(strCon)
			Dim cmd As New SqlCeCommand("UPDATE DiagramContent SET Diagram = @Diagram WHERE DiagramName = @DiagramName", con)

			'Set parameter value
			cmd.Parameters.AddWithValue("@Diagram", dBinary)
			cmd.Parameters.AddWithValue("@DiagramName", comboOpen.Text)

			'Execute the command.
			con.Open()
			cmd.ExecuteNonQuery()
			con.Close()
		End Sub

		''' <summary>
		''' Deletes the Diagram from database
		''' </summary>
		Private Sub DeleteDiagram()
			'Create an instance of the connection and command object.
			Dim con As New SqlCeConnection(strCon)
			Dim cmd As New SqlCeCommand("DELETE FROM DiagramContent WHERE DiagramName =@DiagramName", con)

			'Set parameter value
			cmd.Parameters.AddWithValue("@DiagramName", comboOpen.Text)

			'Execute the command.
			con.Open()
			cmd.ExecuteNonQuery()
			con.Close()
		End Sub

		''' <summary>
		''' Clears the diagram
		''' </summary>
		Private Sub ClearDiagram()
			Me.diagram1.Model.Clear()
			saveMode = "ADD"
			comboOpen.SelectedIndex = -1
		End Sub

		''' <summary>
		''' Loads the Diagram Names into the Combo box.
		''' </summary>
		Private Sub LoadDiagramNames()
			Dim selectedIndex As Integer = -1
			If comboOpen.SelectedIndex <> -1 Then
				selectedIndex = comboOpen.SelectedIndex
			End If

			'Clear combobox items.
			comboOpen.Items.Clear()

			'Create an instance of datatable, connection and command object.
			Dim dt As New DataTable()
			Dim con As New SqlCeConnection(strCon)
			Dim cmd As New SqlCeCommand("SELECT DiagramName FROM DiagramContent ORDER BY DiagramName", con)

			'Add items to the diagramToolStripComboBox control.
			con.Open()
			Dim dr As SqlCeDataReader = cmd.ExecuteReader()
			Do While dr.Read()
				comboOpen.Items.Add(dr("DiagramName"))
			Loop
			con.Close()

			comboOpen.SelectedIndex = selectedIndex
		End Sub
		#End Region

		#Region "Event Handlers"


		#Region "MenuTools"

		Private Sub newToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles newToolStripButton.Click
			'Clears all the nodes in diagram
			ClearDiagram()
		End Sub

		Private Sub openToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles openToolStripButton.Click
			'Validation
			If String.IsNullOrEmpty(Me.comboOpen.Text) Then
				Return
			End If

			saveMode = "UPDATE"
			'Loads the diagram from the database
			LoadDiagram()
		End Sub

		Private Sub saveToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveToolStripButton.Click
			If saveMode = "ADD" Then
				AddNewDiagram()
			Else
				UpdateDiagram()
			End If
		End Sub

		Private Sub deleteToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles deleteToolStripButton.Click
			'Deletes the specified Diagram.
			DeleteDiagram()

			'Clears all the nodes in diagram
			ClearDiagram()

			'Reload the diagramToolStripComboBox control.
			LoadDiagramNames()

		End Sub

		Private Sub lineConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lineConnectorToolStripMenuItem.Click
			SetActiveTool("LineLinkTool")
		End Sub

		Private Sub directedLineConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles directedLineConnectorToolStripMenuItem.Click
			SetActiveTool("DirectedLineLinkTool")
		End Sub

		Private Sub orthogonalConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles orthogonalConnectorToolStripMenuItem.Click
			SetActiveTool("OrthogonalLinkTool")
		End Sub

		Private Sub polylineConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles polylineConnectorToolStripMenuItem.Click
			SetActiveTool("PolylineLinkTool")
		End Sub

		Private Sub bezierConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bezierConnectorToolStripMenuItem.Click
			SetActiveTool("BezierTool")
		End Sub

		Private Sub splineConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles splineConnectorToolStripMenuItem.Click
			SetActiveTool("SplineTool")
		End Sub

		#End Region

		#End Region      

		#Region "Helper Methods"
		''' <summary>
		''' Finds the given diagram from database
		''' </summary>
		''' <param name="mdfFileName">Name of the diagram</param>
		''' <returns>returns the diagram name if found </returns>
		Private Function FindDatabase(ByVal mdfFileName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(mdfFileName) Then
					Return mdfFileName
				End If
				mdfFileName = "..\" & mdfFileName
			Next n
			Return ""
		End Function

		''' <summary>
		''' Activate the given tool
		''' </summary>
		''' <param name="toolName">Tool name to be activated</param>
		Private Sub SetActiveTool(ByVal toolName As String)
			Me.diagram1.Controller.ActivateTool(toolName)
		End Sub
		#End Region      


	End Class
End Namespace



Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Specialized
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing
Imports Syncfusion.Styles
Imports System.Drawing.Drawing2D
Imports Syncfusion.Diagnostics
Imports Syncfusion.GridHelperClasses

Namespace Enhanced_VisualStyle_In_GDBG
	Partial Public Class Form1
		Inherits Form
		Private gridBoundColumn1 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
		Private gridBoundColumn2 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
		Private gridBoundColumn3 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
		Private gridBoundColumn4 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
		Private gridBoundColumn5 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
		Private gridBoundColumn6 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
		Public Sub New()
			InitializeComponent()

			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
				Me.Icon = ico
			Catch
			End Try

			AddHandler gridDataBoundGrid1.CellButtonClicked, AddressOf gridDataBoundGrid1_CellButtonClicked
			Me.gridBoundColumn1 = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
			Me.gridBoundColumn1.HeaderText = "Column1"
			Me.gridBoundColumn1.MappingName = "Column1"
			Me.gridBoundColumn2 = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
			Me.gridBoundColumn2.HeaderText = "Column2"
			Me.gridBoundColumn2.MappingName = "Column2"

			Me.gridBoundColumn3 = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
			Me.gridBoundColumn3.HeaderText = "Column3"
			Me.gridBoundColumn3.MappingName = "Column3"

			Me.gridDataBoundGrid1.GridBoundColumns.AddRange(New Syncfusion.Windows.Forms.Grid.GridBoundColumn() { Me.gridBoundColumn1, Me.gridBoundColumn2, Me.gridBoundColumn3 }) ', this.gridBoundColumn3, this.gridBoundColumn4, this.gridBoundColumn5, this.gridBoundColumn6 });
			Me.gridDataBoundGrid1.Model.EnableLegacyStyle = False
			Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2010Black

		End Sub

		Private Sub gridDataBoundGrid1_CellButtonClicked(ByVal sender As Object, ByVal e As GridCellButtonClickedEventArgs)
			If e.RowIndex = 4 Then
				MessageBox.Show("You have Clicked a Button")
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			Dim dt As New DataTable()
			Dim nCols As Integer = 6
			Dim nRows As Integer = 35

			For i As Integer = 0 To nRows - 1
				Dim col As New DataColumn()
				Dim dr As DataRow = dt.NewRow()
				dt.Rows.Add(dr)

			Next i
			For j As Integer = 0 To nCols - 1
				dt.Columns.Add()
			Next j
			Me.gridDataBoundGrid1.DataSource = dt

			AddHandler gridDataBoundGrid1.PrepareViewStyleInfo, AddressOf gridDataBoundGrid1_PrepareViewStyleInfo
			Me.gridDataBoundGrid1.ThemesEnabled = True
			Me.gridDataBoundGrid1.DefaultColWidth = 135
			Me.gridDataBoundGrid1(2, 1).Text = "ComboBox"
			Me.gridDataBoundGrid1(4, 1).Text = "Push Button"
			Me.gridDataBoundGrid1(6, 1).Text = "Check Box"
			Me.gridDataBoundGrid1(8, 1).Text = "NumericUpDown"
			Me.gridDataBoundGrid1(10, 1).Text = "DropDownGrid"
			Me.gridDataBoundGrid1(12, 1).Text = "GridListControl"
			Me.gridDataBoundGrid1(14, 1).Text = "Header"
			Me.gridDataBoundGrid1.Model.EnableGridListControlInComboBox = False
		End Sub

		Private Function CreateList() As ArrayList
			Dim USStates As New ArrayList()
			USStates.Add(New USState("Alabama", "AL", 0))
			USStates.Add(New USState("Alaska", "AK", 1))
			USStates.Add(New USState("Arizona", "AZ", 2))
			USStates.Add(New USState("Arkansas", "AK", 4))
			USStates.Add(New USState("California", "CA", 4))
			Return USStates
		End Function

		Private Sub gridDataBoundGrid1_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As GridPrepareViewStyleInfoEventArgs)

				If e.ColIndex = 2 Then
					If e.RowIndex = 2 Then
						e.Style.CellType = "ComboBox"
						e.Style.DataSource = CreateList()
						e.Style.DisplayMember = "LongName"
						e.Style.ValueMember = "ShortName"
						e.Style.Text = "Select Your Choice"
					End If
					If e.RowIndex = 4 Then
						e.Style.CellType = "PushButton"
						e.Style.Description = "Click Me"
						e.Style.HorizontalAlignment = GridHorizontalAlignment.Center
						e.Style.VerticalAlignment = GridVerticalAlignment.Middle
					End If
					If e.RowIndex = 6 Then
						e.Style.CellType = "CheckBox"
					End If

					If e.RowIndex = 8 Then
						e.Style.CellType = "NumericUpDown"
					End If
					If e.RowIndex = 10 Then
						e.Style.CellType = "DropDownGrid"

					End If
					If e.RowIndex = 12 Then
						e.Style.CellType = "GridListControl"
						e.Style.DataSource = CreateList()
						e.Style.DisplayMember = "ShortName"
						e.Style.ValueMember = "LongName"
					End If
					If e.RowIndex = 14 Then
						e.Style.CellType = "Header"
						e.Style.Text = "HeaderText"
					End If

				End If

		End Sub

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		Private Sub pictureBox1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureBox5.MouseClick, pictureBox3.MouseClick, pictureBox4.MouseClick, pictureBox7.MouseClick, pictureBox2.MouseClick, pictureBox6.MouseClick, pictureBox1.MouseClick
			Dim pBox As PictureBox = CType(sender, PictureBox)

			Select Case pBox.Name
				Case "pictureBox1"
					Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Metro
				Case "pictureBox2"
					Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
					gridDataBoundGrid1.Office2007ScrollBars = True
					gridDataBoundGrid1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue
				Case "pictureBox3"
					Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Black
					gridDataBoundGrid1.Office2007ScrollBars = True
					gridDataBoundGrid1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black
				Case "pictureBox4"
					Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Silver
					gridDataBoundGrid1.Office2007ScrollBars = True
					gridDataBoundGrid1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver
				Case "pictureBox5"
					Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2010Blue
					gridDataBoundGrid1.Office2007ScrollBars = False
					gridDataBoundGrid1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Blue
				Case "pictureBox6"
					Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2010Black
					gridDataBoundGrid1.Office2007ScrollBars = False
					gridDataBoundGrid1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black
				Case "pictureBox7"
					Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2010Silver
					gridDataBoundGrid1.Office2007ScrollBars = False
					gridDataBoundGrid1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Silver

			End Select

			label6.Text = gridDataBoundGrid1.GridVisualStyles.ToString()
			label4.Text = label6.Text

			panel1.Location = New Point(pBox.Location.X + 3, panel2.Location.Y)
			panel1.Visible = True

			Me.gridDataBoundGrid1.Refresh()
		End Sub

		Private Sub pictureBox1_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox5.MouseHover, pictureBox3.MouseHover, pictureBox4.MouseHover, pictureBox7.MouseHover, pictureBox2.MouseHover, pictureBox6.MouseHover, pictureBox1.MouseHover
			Me.SuspendLayout()
			Dim pBox As PictureBox = CType(sender, PictureBox)
			panel2.Location = New Point(pBox.Location.X + 3, panel2.Location.Y)
			panel2.Visible = True
			WriteStyles(pBox)
			Me.ResumeLayout(True)
		End Sub

		Private Sub pictureBox1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox5.MouseLeave, pictureBox3.MouseLeave, pictureBox4.MouseLeave, pictureBox7.MouseLeave, pictureBox2.MouseLeave, pictureBox6.MouseLeave, pictureBox1.MouseLeave
			panel2.Visible = False
			label1.Visible = False
		End Sub

		Private Sub WriteStyles(ByVal pBox As PictureBox)
			Select Case pBox.Name
				Case "pictureBox1"
					label1.Text = "GridVisualStyles : Metro"
				Case "pictureBox2"
					label1.Text = "GridVisualStyles : Office2007Blue"
				Case "pictureBox3"
					label1.Text = "GridVisualStyles : Office2007Black"
				Case "pictureBox4"
					label1.Text = "GridVisualStyles : Office2007Silver"
				Case "pictureBox5"
					label1.Text = "GridVisualStyles : Office2010Blue"
				Case "pictureBox6"
					label1.Text = "GridVisualStyles : Office2010Black"
				Case "pictureBox7"
					label1.Text = "GridVisualStyles : Office2010Silver"
			End Select
			label1.Visible = True
		End Sub

	End Class
	#Region "USState Class"

	Public Class USState
		Private myShortName As String
		Private myLongName As String
		Private _imageIndex As Integer

		Public Sub New(ByVal strLongName As String, ByVal strShortName As String, ByVal _imageIndex As Integer)
			Me.myShortName = strShortName
			Me.myLongName = strLongName
			Me._imageIndex = _imageIndex
		End Sub

		Public ReadOnly Property ShortName() As String
			Get
				Return myShortName
			End Get
		End Property

		Public ReadOnly Property LongName() As String
			Get
				Return myLongName
			End Get
		End Property

		Public Property ImageIndex() As Integer
			Get
				Return _imageIndex
			End Get
			Set(ByVal value As Integer)
				_imageIndex = value
			End Set
		End Property

		Public Overrides Function ToString() As String
			Return Me.ShortName & " - " & Me.LongName
		End Function
	End Class
	#End Region
End Namespace

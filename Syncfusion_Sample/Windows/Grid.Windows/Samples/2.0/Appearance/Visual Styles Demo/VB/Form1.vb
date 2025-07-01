Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System.Collections.Specialized
Imports System.Collections
Imports Syncfusion.Windows.Forms.Tools

Namespace VisualStyle_Demo
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			InitializeComponent()
			Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
			Catch
			End Try

			InitializeGrid()


		End Sub

		#Region "Icon and Image Handlers"
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		'private Image GetImage(string bitmapName)
		'{
		'    Image bitmap = null;

		'    try
		'    {
		'        Assembly ass = typeof(Form1).Assembly;
		'        string name = ass.GetName().Name;
		'        Stream stream = ass.GetManifestResourceStream(name + "." + bitmapName);
		'        bitmap = Image.FromStream(stream);
		'    }
		'    catch (Exception ex)
		'    {
		'        TraceUtil.TraceExceptionCatched(ex);
		'    }

		'    return bitmap;
		'}
		#End Region

		#Region "EventHandlers"

		Private Sub pictureBox_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureBox1.MouseClick, pictureBox2.MouseClick, pictureBox3.MouseClick, pictureBox4.MouseClick, pictureBox5.MouseClick, pictureBox6.MouseClick, pictureBox7.MouseClick

			Dim pBox As PictureBox = CType(sender, PictureBox)

			Select Case pBox.Name
				Case "pictureBox1"
					Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
				Case "pictureBox2"
					Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Blue
					gridControl1.Office2007ScrollBars = True
					gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue
				Case "pictureBox3"
					Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Black
					gridControl1.Office2007ScrollBars = True
					gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black
				Case "pictureBox4"
					Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Silver
					gridControl1.Office2007ScrollBars = True
					gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver
				Case "pictureBox5"
					Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2010Blue
					gridControl1.Office2007ScrollBars = False
					gridControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Blue
				Case "pictureBox6"
					Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2010Black
					gridControl1.Office2007ScrollBars = False
					gridControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black
				Case "pictureBox7"
					Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2010Silver
					gridControl1.Office2007ScrollBars = False
					gridControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Silver

			End Select

			label6.Text = gridControl1.GridVisualStyles.ToString()
			label4.Text = label6.Text

			panel1.Location = New Point(pBox.Location.X + 3, panel2.Location.Y)
			panel1.Visible = True

			Me.gridControl1.Refresh()
		End Sub

		Private Sub pictureBox_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox1.MouseHover, pictureBox2.MouseHover, pictureBox3.MouseHover, pictureBox4.MouseHover, pictureBox5.MouseHover, pictureBox6.MouseHover, pictureBox7.MouseHover
			Me.SuspendLayout()
			Dim pBox As PictureBox = CType(sender, PictureBox)
			panel2.Location = New Point(pBox.Location.X + 3, panel2.Location.Y)
			panel2.Visible = True
			WriteStyles(pBox)
			Me.ResumeLayout(True)
		End Sub

		Private Sub pictureBox_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox1.MouseLeave, pictureBox2.MouseLeave, pictureBox3.MouseLeave, pictureBox4.MouseLeave, pictureBox5.MouseLeave, pictureBox6.MouseLeave, pictureBox7.MouseLeave
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

		Private Sub gridControl1_CheckBoxClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs) Handles gridControl1.CheckBoxClick
			Me.gridControl1.BeginUpdate()
			Select Case e.RowIndex
				Case 10
					For i As Integer = 11 To 14
						gridControl1.HideRows(i) = Not gridControl1.HideRows(i)
					Next i
			End Select
			Me.gridControl1.EndUpdate(True)
			Me.gridControl1.Refresh()
		End Sub
		#End Region

		Private Sub InitializeGrid()
'			#Region "Style declaration"
			Me.gridControl1.DefaultRowHeight = 18
			Dim headerstyle As New GridStyleInfo()
			headerstyle.Font.Size = 12
			headerstyle.Font.Bold = True
			headerstyle.TextColor = Color.Black
			headerstyle.VerticalAlignment = GridVerticalAlignment.Middle
			headerstyle.HorizontalAlignment = GridHorizontalAlignment.Center
			headerstyle.CellType = GridCellTypeName.Static

			Dim subheaderstyle As New GridStyleInfo()
			subheaderstyle.Font.Bold = True
			subheaderstyle.VerticalAlignment = GridVerticalAlignment.Middle
			subheaderstyle.HorizontalAlignment = GridHorizontalAlignment.Center
			subheaderstyle.CellType = GridCellTypeName.Static

			Dim valuestyle As New GridStyleInfo()
			valuestyle.BackColor = SystemColors.Menu
			valuestyle.TextColor = Color.Black
			valuestyle.VerticalAlignment = GridVerticalAlignment.Middle
			valuestyle.HorizontalAlignment = GridHorizontalAlignment.Center

			gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation
			gridControl1.Model.EnableLegacyStyle = True
			Dim rowIndex As Integer = 1, colIndex As Integer = 2
'			#End Region

'			#Region "ComboBoxCell (1 to 15)"
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "DropDown Cells"

			rowIndex += 3

			Dim USStates As New ArrayList()
			USStates.Add(New USState("Alabama", "AL", 0))
			USStates.Add(New USState("Alaska", "AK", 1))
			USStates.Add(New USState("Arizona", "AZ", 2))
			USStates.Add(New USState("Arkansas", "AS", 3))
			USStates.Add(New USState("California", "CA", 4))
			USStates.Add(New USState("NewJersey", "NJ", 5))
			USStates.Add(New USState("Seattle", "ST", 6))

			gridControl1(rowIndex, colIndex).FloatCell = True
			gridControl1.Model.ColWidths(5) = 120
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 4))
			gridControl1(rowIndex, 3).Text = "ComboBox Cells"
			gridControl1(rowIndex, 3).TextColor = Color.Black
			gridControl1(rowIndex, 3).CellType = GridCellTypeName.Static
			gridControl1(rowIndex, 5).Text = "Select your choice"
			gridControl1(rowIndex, 5).CellType = GridCellTypeName.ComboBox
			gridControl1(rowIndex, 5).DataSource = USStates
			gridControl1(rowIndex, 5).DisplayMember = "LongName"
			gridControl1(rowIndex, 5).ValueMember = "ShortName"

			rowIndex += 1
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 4))
			gridControl1(rowIndex, 3).Text = "GridListControl Cells"
			gridControl1(rowIndex, 3).TextColor = Color.Black
			gridControl1(rowIndex, 3).CellType = GridCellTypeName.Static
			gridControl1(rowIndex, 5).Text = "Select your choice"
			gridControl1(rowIndex, 5).CellType = GridCellTypeName.GridListControl
			gridControl1(rowIndex, 5).DataSource = USStates
			gridControl1(rowIndex, 5).DisplayMember = "LongName"
			gridControl1(rowIndex, 5).ValueMember = "ShortName"

			rowIndex += 1
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 4))
			gridControl1(rowIndex, 3).Text = "DropDown Grid Cells"
			gridControl1(rowIndex, 3).TextColor = Color.Black
			gridControl1(rowIndex, 3).CellType = GridCellTypeName.Static
			gridControl1(rowIndex, 5).CellType = GridCellTypeName.DropDownGrid
			'gridControl1[rowIndex, 5].DataSource = USStates;
			'gridControl1[rowIndex, 5].DisplayMember = "LongName";
			'gridControl1[rowIndex, 5].ValueMember = "ShortName";
			rowIndex += 2
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 7))
			gridControl1(rowIndex, 3).CellType = GridCellTypeName.CheckBox
			gridControl1(rowIndex, 3).Description = "For themed scrollbars in DropDown"
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex + 3, 7))
			gridControl1(rowIndex, 3).TextColor = Color.Black
			gridControl1(rowIndex, 3).CellType = GridCellTypeName.Static
			gridControl1(rowIndex, 3).Text = "Dropdown can use the themed scrollbars only when. " & Constants.vbLf + Constants.vbLf & " 1. LegacyStyles should be disabled which will applies the ColorStyles " & Constants.vbLf & " 2. ""EnableGridListControlInComboBox"" property should be enabled."
			gridControl1(rowIndex, 3).FloatCell = True

			For i As Integer = rowIndex To rowIndex + 3
				gridControl1.HideRows(i) = True
			Next i

			rowIndex = 14
'			#End Region

'			#Region "RadioButtons ( 16 to 18)"
			rowIndex += 2
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Radio Buttons"

			rowIndex += 2
			Dim sc As New StringCollection()
			sc.AddRange(New String(){ "Button 0", "Disabled/disabled", "Button 2", "Button 3"})
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount - 1))
			Me.gridControl1(rowIndex, 1).ChoiceList = sc
			Me.gridControl1(rowIndex, 1).CellType = "RadioButton"
			Me.gridControl1(rowIndex, 1).Font.Bold = True
			Me.gridControl1(rowIndex, 1).CellValue = 0 'selected button
			Me.gridControl1(rowIndex, 1).TextAlign = GridTextAlign.Left 'where descriptions are
			Me.gridControl1(rowIndex, 1).TextMargins.Left = 5
			Me.gridControl1(rowIndex, 1).TextMargins.Right = 5
'			#End Region

'			#Region "PushButtons 20 to 23"
			rowIndex += 2
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex+1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Push Buttons"

			rowIndex += 3
			gridControl1.RowHeights(rowIndex) = 22
			gridControl1(rowIndex, colIndex).Description = "Raised"
			gridControl1(rowIndex, colIndex).CellType = GridCellTypeName.PushButton
			gridControl1(rowIndex, colIndex).CellAppearance = GridCellAppearance.Raised
			gridControl1(rowIndex, colIndex).Font.Size = 8
			gridControl1(rowIndex, colIndex + 2).Description = "Flat"
			gridControl1(rowIndex, colIndex + 2).CellType = GridCellTypeName.PushButton
			gridControl1(rowIndex, colIndex + 2).Font.Size = 8
			gridControl1(rowIndex, colIndex + 4).Description = "Sunken"
			gridControl1(rowIndex, colIndex + 4).CellType = GridCellTypeName.PushButton
			gridControl1(rowIndex, colIndex + 4).Font.Size = 8
			gridControl1(rowIndex, colIndex + 4).CellAppearance = GridCellAppearance.Sunken
'			#End Region

'			#Region "CheckBox cells"
			rowIndex += 2
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "CheckBox Cells"

			rowIndex += 3

			gridControl1.TableStyle.CheckBoxOptions = New GridCheckBoxCellInfo("True", "False", "", False)
			gridControl1(rowIndex, colIndex).CellValue = False
			gridControl1(rowIndex, colIndex).Description = "Click Me"
			gridControl1(rowIndex, colIndex).CellType = "CheckBox"
			gridControl1(rowIndex, colIndex).TriState = False
			gridControl1(rowIndex, colIndex + 2).CellValue = True
			gridControl1(rowIndex, colIndex + 2).CellType = "CheckBox"
			gridControl1(rowIndex, colIndex + 2).TriState = True
			gridControl1(rowIndex, colIndex + 2).Description = "TriState"
			gridControl1(rowIndex, colIndex + 2).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1(rowIndex, colIndex + 4).Text = "True"
			gridControl1(rowIndex, colIndex + 4).CellType = "CheckBox"
			gridControl1(rowIndex, colIndex + 4).TriState = False
			gridControl1(rowIndex, colIndex + 4).Description = "Disabled"
			gridControl1(rowIndex, colIndex + 4).Enabled = False
			gridControl1(rowIndex, colIndex + 4).VerticalAlignment = GridVerticalAlignment.Bottom
'			#End Region

'			#Region "Header cells"
			rowIndex += 2
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "CheckBox Cells"

			rowIndex += 3

			gridControl1(rowIndex, colIndex).Text = "Header"
			gridControl1(rowIndex, colIndex).CellType = GridCellTypeName.Header
			gridControl1(rowIndex, colIndex + 2).Text = "Column Header"
			gridControl1(rowIndex, colIndex + 2).CellType = GridCellTypeName.Header
			gridControl1(rowIndex, colIndex + 4).Text = "Row Header"
			gridControl1(rowIndex, colIndex + 4).CellType = GridCellTypeName.Header

			gridControl1.ColWidths(4) = 90
			gridControl1.ColWidths(6) = 90
			'gridControl1.ColWidths[8] = 90;
'			#End Region
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

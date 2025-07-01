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

'			#Region "Datasources"
			Dim USStates As New ArrayList()
			USStates.Add(New USState("Alaska", "AK", 1))
			USStates.Add(New USState("Arizona", "AZ", 2))
			USStates.Add(New USState("Arkansas", "AK", 3))
			USStates.Add(New USState("California", "CA", 4))
			USStates.Add(New USState("Colorado", "CO", 5))
			USStates.Add(New USState("Connecticut", "CT", 6))
			USStates.Add(New USState("Delaware", "DE", 3))
			USStates.Add(New USState("Florida", "FL", 4))
			USStates.Add(New USState("Georgia", "GA", 1))
			USStates.Add(New USState("Hawaii", "HI", 0))
			USStates.Add(New USState("Idaho", "ID", 3))
			USStates.Add(New USState("Illinois", "IL", 2))
			USStates.Add(New USState("Indiana", "IN", 6))
			USStates.Add(New USState("Iowa", "IA", 5))
			USStates.Add(New USState("Kansas", "KA", 5))
			USStates.Add(New USState("Kentucky", "KY", 4))
			USStates.Add(New USState("Louisiana", "LA", 3))
			USStates.Add(New USState("Maine", "ME", 0))
			USStates.Add(New USState("Maryland", "MD", 0))
			USStates.Add(New USState("Massachusetts", "MA", 2))
			USStates.Add(New USState("Michigan", "MI", 1))
			USStates.Add(New USState("Minnesota", "MN", 6))
			USStates.Add(New USState("Mississippi", "MS", 5))
			USStates.Add(New USState("Missouri", "MO", 2))
			USStates.Add(New USState("Montana", "MT", 1))
			USStates.Add(New USState("Nebraska", "NE", 4))
			USStates.Add(New USState("Nevada", "NV", 0))
			USStates.Add(New USState("New Hampshire", "NH", 3))
			USStates.Add(New USState("New Jersey", "NJ", 3))
			USStates.Add(New USState("New Mexico", "NM", 2))
			USStates.Add(New USState("New York", "NY", 5))
			USStates.Add(New USState("North Carolina", "NC", 4))
			USStates.Add(New USState("North Dakota", "ND", 4))
			USStates.Add(New USState("Ohio", "OH", 1))
			USStates.Add(New USState("Oklahoma", "OK", 2))
			USStates.Add(New USState("Oregon", "OR", 5))
			USStates.Add(New USState("Pennsylvania", "PA", 0))
			USStates.Add(New USState("Rhode Island", "RI", 6))
			USStates.Add(New USState("South Carolina", "SC", 5))
			USStates.Add(New USState("South Dakota", "SD", 4))
			USStates.Add(New USState("Tennessee", "TN", 3))
			USStates.Add(New USState("Texas", "TX", 2))
			USStates.Add(New USState("Utah", "UT", 0))
			USStates.Add(New USState("Vermont", "VT", 1))
			USStates.Add(New USState("Virginia", "VA", 0))
			USStates.Add(New USState("Washington", "WA", 2))
			USStates.Add(New USState("West Virginia", "WV", 0))
			USStates.Add(New USState("Wisconsin", "WI", 3))
			USStates.Add(New USState("Wyoming", "WY", 5))
'			#End Region

'			#Region "Initialization settings"
			Me.gridControl1.DataSource = USStates
			Me.gridControl1.ShowColumnHeader = True
			Me.gridControl1.MultiColumn = True
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.Grid.Model.EnableLegacyStyle = False
			Me.gridControl1.DataSource = USStates
			Me.gridControl1.DisplayMember = "ShortName"
			Me.gridControl1.ValueMember = "LongName"
			Me.gridControl1.Grid.Model.ColWidths(1) = 150
			Me.gridControl1.Grid.Model.ColWidths(2) = 150
			Me.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2010Black
			Me.gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2010
			Me.gridControl1.Grid.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black
'			#End Region


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
					Me.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Metro
					gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Metro
				Case "pictureBox2"
					Me.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2007Blue
					gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2007
					gridControl1.Grid.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue
				Case "pictureBox3"
					Me.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2007Black
					gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2007
					gridControl1.Grid.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black
				Case "pictureBox4"
					Me.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2007Silver
					gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2007
					gridControl1.Grid.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver
				Case "pictureBox5"
					Me.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2010Blue
					gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2010
					gridControl1.Grid.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Blue
				Case "pictureBox6"
					Me.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2010Black
					gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2010
					gridControl1.Grid.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black
				Case "pictureBox7"
					Me.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2010Silver
					gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2010
					gridControl1.Grid.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Silver

			End Select

			label6.Text = gridControl1.Grid.GridVisualStyles.ToString()
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


#End Region
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

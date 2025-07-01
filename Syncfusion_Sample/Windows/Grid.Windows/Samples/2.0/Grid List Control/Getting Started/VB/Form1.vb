Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms

Namespace GridListControlSample


	Public Class ListBoxSample3
		Inherits MetroForm
		Private ListBox1 As New GridListControl()
		Private textBox1 As New TextBox()
		Private selectionComboBox As New ComboBoxAdv()
		Private widthListBox As Integer = 600
		Private heightListBox As Integer = 800

		#Region "Form Handlers"
		<STAThread> _
		Public Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
			Application.EnableVisualStyles()
#End If
			Application.Run(New ListBoxSample3())
		End Sub
		#End Region

		Public Sub New()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try


'			#Region "Form and control settings"
			Me.AutoScaleBaseSize = New Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(700, 330)
			Me.Text = "Getting Started"

			ListBox1.Location = New Point(55, 50)
			ListBox1.Name = "ListBox1"
			ListBox1.TabIndex = 1
			ListBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
			ListBox1.Grid.DefaultGridBorderStyle = GridBorderStyle.Solid
			ListBox1.Properties.GridLineColor = Color.FromArgb(208, 215, 229)

			Me.selectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
			Me.selectionComboBox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.selectionComboBox.MetroColor = Color.FromArgb(27, 161, 226)
			Me.selectionComboBox.Location = New System.Drawing.Point(ListBox1.Location.X, ListBox1.Location.Y - 30)
			Me.selectionComboBox.Name = "selectionComboBox"
			Me.selectionComboBox.Size = New System.Drawing.Size(widthListBox\3, 21)
			Me.selectionComboBox.TabIndex = 0
			selectionComboBox.Items.Add("Single Selection")
			selectionComboBox.Items.Add("Simple Multiple Selection")
			selectionComboBox.Items.Add("Extended Multiple Selection")
			selectionComboBox.Text = "Single Selection"

			selectionComboBox.Anchor = AnchorStyles.Top
			AddHandler selectionComboBox.SelectedIndexChanged, AddressOf OnSelectedIndexChanged


			heightListBox = 10 * (ListBox1.ItemHeight + 1)


			ListBox1.Size = New Size(widthListBox, heightListBox)
			'this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(239)))));
			textBox1.Location = New Point(55, 251)
			textBox1.Name = "textBox1"
			textBox1.Size = New Size(widthListBox, 24)
			textBox1.Anchor = AnchorStyles.Bottom
			Me.Controls.AddRange(New Control() {ListBox1, textBox1, selectionComboBox})

			' Populates the list box using DataSource. 
			' DisplayMember is used to display just the long name of each state.
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



			Dim imageList2 As New ImageList()
			imageList2.ImageSize = New Size(15, 15)
			imageList2.Images.Add(New Bitmap(FindImageFile("common\Images\Grid\GridListControlDemo\ImageList\add2.png")))
			imageList2.Images.Add(New Bitmap(FindImageFile("common\Images\Grid\GridListControlDemo\ImageList\bug_green.png")))
			imageList2.Images.Add(New Bitmap(FindImageFile("common\Images\Grid\GridListControlDemo\ImageList\star_blue.png")))
			imageList2.Images.Add(New Bitmap(FindImageFile("common\Images\Grid\GridListControlDemo\ImageList\navigate_check.png")))
			imageList2.Images.Add(New Bitmap(FindImageFile("common\Images\Grid\GridListControlDemo\ImageList\jar_bean_delete.png")))
			imageList2.Images.Add(New Bitmap(FindImageFile("common\Images\Grid\GridListControlDemo\ImageList\console.png")))
			imageList2.Images.Add(New Bitmap(FindImageFile("common\Images\Grid\GridListControlDemo\ImageList\delete2.png")))
			imageList2.Images.Add(New Bitmap(FindImageFile("common\Images\Grid\GridListControlDemo\ImageList\layout_horizontal.png")))

			ListBox1.ImageList = imageList2

			AddHandler ListBox1.SelectedValueChanged, AddressOf ListBox1_SelectedValueChanged
			ListBox1.BeginUpdate()
			ListBox1.DataSource = USStates
			ListBox1.DisplayMember = "LongName"
			ListBox1.ValueMember = "ShortName"
			ListBox1.MultiColumn = True
			ListBox1.ShowColumnHeader = True
			ListBox1.SelectionMode = SelectionMode.One
			ListBox1.ThemesEnabled = True
			ListBox1.Grid.VerticalThumbTrack = True

			ListBox1.FillLastColumn = True
			ListBox1.EndUpdate()

			textBox1.ReadOnly = True
			Me.Controls.AddRange(New Control() {ListBox1, textBox1, selectionComboBox})
			Me.ListBox1.Grid.RowHeights.ResizeToFit(GridRangeInfo.Table())
			ListBox1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			ListBox1.Properties.GridLineColor = System.Drawing.Color.FromArgb((CByte(208)), (CByte(215)), (CByte(229)))
			ListBox1.BorderStyle = BorderStyle.FixedSingle
			ListBox1.ForeColor = System.Drawing.Color.MidnightBlue
			ListBox1.BackColor = SystemColors.Window
			ListBox1.Font = New System.Drawing.Font("Verdana", 8.5F)
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.DropShadow = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
'			#End Region
		End Sub

		#Region "HelperMethods"
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


		Private Function FindImageFile(ByVal bitmapName As String) As String
			Dim bitmappath As String = ""
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					bitmappath = bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n
			Return bitmappath
		End Function


		Private Sub InitializeComponent()
			Me.SuspendLayout()
			' 
			' ListBoxSample3
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(239))))))
			Me.ClientSize = New System.Drawing.Size(505, 345)
			Me.Name = "ListBoxSample3"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
'			Me.Load += New System.EventHandler(Me.ListBoxSample3_Load)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "EventHandlers"
		Private Sub OnSelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
			Select Case selectionComboBox.SelectedIndex
				Case 0
					ListBox1.SelectionMode = SelectionMode.One
				Case 1
					ListBox1.SelectionMode = SelectionMode.MultiSimple
				Case Else
					ListBox1.SelectionMode = SelectionMode.MultiExtended
			End Select

			ListBox1.ClearSelected()
		End Sub

		Private Sub ListBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If ListBox1.SelectedIndex <> -1 Then
				textBox1.Text = ListBox1.SelectedValue.ToString()
			End If
		End Sub

		Private Sub ListBoxSample3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ListBox1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue

			ListBox1.Properties.BackgroundColor = System.Drawing.Color.FromArgb((CByte(227)), (CByte(239)), (CByte(255)))
			ListBox1.Properties.GridLineColor = System.Drawing.Color.FromArgb((CByte(208)), (CByte(215)), (CByte(229)))
			ListBox1.BorderStyle = BorderStyle.FixedSingle
			ListBox1.ForeColor = System.Drawing.Color.MidnightBlue
			ListBox1.Font = New System.Drawing.Font("Verdana", 8.5F)
			ListBox1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue

		End Sub
		#End Region
	End Class


	#Region "USState Class"
	Public Class USState
		Private myShortName As String
		Private myLongName As String
		Private imgIndex As Integer

		Public Sub New(ByVal strLongName As String, ByVal strShortName As String, ByVal imageIndex As Integer)
			Me.myShortName = strShortName
			Me.myLongName = strLongName
			Me.imgIndex = imageIndex
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
				Return imgIndex
			End Get
			Set(ByVal value As Integer)
				imgIndex = value
			End Set
		End Property


		Public Overrides Function ToString() As String
			Return Me.ShortName & " - " & Me.LongName
		End Function
	End Class
	#End Region
End Namespace


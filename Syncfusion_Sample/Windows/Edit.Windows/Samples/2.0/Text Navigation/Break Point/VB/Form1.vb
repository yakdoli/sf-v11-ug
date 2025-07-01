#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO


Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Enums
Imports Syncfusion.Windows.Forms.Edit.Dialogs
Imports Syncfusion.Windows.Forms.Edit.Implementation
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Utils

Namespace BreakPointDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
		Private menuItem4 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
		Private menuItem7 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
        Private imagePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Glyphs\breakpoint3.png"
        Private filePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Form1.vb"

		Private color As Color
		Private image As Image

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Me.editControl1.MarkerAreaWidth = 20

			color = ColorTranslator.FromHtml("#FFBF34")
			image = New Bitmap(imagePath)

			Me.editControl1.LoadFile(filePath)
		End Sub


		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
			Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
			Me.mainMenu1 = New System.Windows.Forms.MainMenu()
			Me.menuItem1 = New System.Windows.Forms.MenuItem()
			Me.menuItem2 = New System.Windows.Forms.MenuItem()
			Me.menuItem3 = New System.Windows.Forms.MenuItem()
			Me.menuItem4 = New System.Windows.Forms.MenuItem()
			Me.menuItem5 = New System.Windows.Forms.MenuItem()
			Me.menuItem6 = New System.Windows.Forms.MenuItem()
			Me.menuItem7 = New System.Windows.Forms.MenuItem()
			Me.menuItem9 = New System.Windows.Forms.MenuItem()
			Me.menuItem8 = New System.Windows.Forms.MenuItem()
			Me.menuItem10 = New System.Windows.Forms.MenuItem()
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' editControl1
			' 
			Me.editControl1.BackColor = System.Drawing.SystemColors.Window
			Me.editControl1.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
			Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.editControl1.CurrentColumn = 1
			Me.editControl1.CurrentLine = 1
			Me.editControl1.CurrentPosition = New System.Drawing.Point(1, 1)
			Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.editControl1.FileOpened = Nothing
			Me.editControl1.GraphicsCompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default
			Me.editControl1.GraphicsInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default
			Me.editControl1.GraphicsSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default
			Me.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
			Me.editControl1.IndentBlockHighlightingColor = System.Drawing.Color.LightBlue
			Me.editControl1.IndentLineColor = System.Drawing.Color.Gray
			Me.editControl1.Name = "editControl1"
			Me.editControl1.SelectionMarginBackgroundColor = System.Drawing.Color.Empty
			Me.editControl1.SelectionMarginForegroundColor = System.Drawing.Color.Red
			Me.editControl1.ShowCollapse = True
			Me.editControl1.ShowHorizontalSplitters = True
			Me.editControl1.ShowIndentationGuidelines = True
			Me.editControl1.ShowIndicatorMargin = True
			Me.editControl1.ShowLineNumbers = True
			Me.editControl1.ShowMarkers = True
			Me.editControl1.ShowOutliningCollapsers = True
			Me.editControl1.ShowVerticalSplitters = True
			Me.editControl1.ShowWhitespaces = False
			Me.editControl1.Size = New System.Drawing.Size(512, 433)
			Me.editControl1.TabIndex = 0
			Me.editControl1.TabSize = 2
			Me.editControl1.TabStopsArray = New Integer() { 8, 16, 24, 32, 40}
			Me.editControl1.Text = "editControl1"
			Me.editControl1.TextAreaWidth = 600
			Me.editControl1.TransferFocusOnTab = True
			Me.editControl1.UserMarginBackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BurlyWood)
            Me.editControl1.UserMarginWidth = 100
			Me.editControl1.UserMarginTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.editControl1.WordWrap = True
			Me.editControl1.WordWrapMarginBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BlanchedAlmond)
			Me.editControl1.WordWrapMarginLineColor = System.Drawing.Color.Black
			Me.editControl1.WordWrapMarginLineStyle = System.Drawing.Drawing2D.DashStyle.Dot
            AddHandler Me.editControl1.IndicatorMarginClick, AddressOf Me.editControl1_IndicatorMarginClick
			' 
			' mainMenu1
			' 
			Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem1, Me.menuItem10})
			' 
			' menuItem1
			' 
			Me.menuItem1.Index = 0
			Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem9, Me.menuItem8})
			Me.menuItem1.Text = "File"
			' 
			' menuItem2
			' 
			Me.menuItem2.Index = 0
			Me.menuItem2.Text = "New"
'			Me.menuItem2.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem3
			' 
			Me.menuItem3.Index = 1
			Me.menuItem3.Text = "Open"
'			Me.menuItem3.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem4
			' 
			Me.menuItem4.Index = 2
			Me.menuItem4.Text = "-"
			' 
			' menuItem5
			' 
			Me.menuItem5.Index = 3
			Me.menuItem5.Text = "Save"
'			Me.menuItem5.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem6
			' 
			Me.menuItem6.Index = 4
			Me.menuItem6.Text = "SaveAs"
'			Me.menuItem6.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem7
			' 
			Me.menuItem7.Index = 5
			Me.menuItem7.Text = "-"
			' 
			' menuItem9
			' 
			Me.menuItem9.Index = 6
			Me.menuItem9.Text = "Close"
'			Me.menuItem9.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem8
			' 
			Me.menuItem8.Index = 7
			Me.menuItem8.Text = "Exit"
'			Me.menuItem8.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem10
			' 
			Me.menuItem10.Index = 1
			Me.menuItem10.Text = "Customize"
'			Me.menuItem10.Click += New System.EventHandler(Me.menuItem10_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(512, 433)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.editControl1})
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Menu = Me.mainMenu1
			Me.Name = "Form1"
            Me.Text = "Break Point"
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub

		Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem9.Click, menuItem8.Click
			Dim mi As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)

			Select Case mi.Text
				Case "New" 
					Me.editControl1.NewFile()
				Case "Open" 
					Me.editControl1.LoadFile()
				Case "Save" 
					Me.editControl1.Save()
				Case "SaveAs" 
					Me.editControl1.SaveAs()
				Case "Close" 
					Me.editControl1.Close()
				Case "Exit" 
					Me.Close()
			End Select
		End Sub

		Private Sub editControl1_IndicatorMarginClick(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Edit.IndicatorClickEventArgs)
			' Set breakpoint indicator
            Me.editControl1.SetCustomBookmark(e.LineIndex, New BookmarkPaintEventHandler(AddressOf CustomBookmarkPainter))

			' Highlight the relevant line
            Dim format As IBackgroundFormat = Me.editControl1.RegisterBackColorFormat(color, Drawing.Color.Transparent)
			Me.editControl1.SetLineBackColor(Me.editControl1.CurrentLine, True, format)
		End Sub

		' Display the customization editor
		Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click
			Dim form As CustomizeForm = New CustomizeForm()
			AddHandler form.Accepted, AddressOf AcceptedEventHandler
			form.ShowDialog()
		End Sub

		' Get the selected color and image
		Private Sub AcceptedEventHandler(ByVal sender As Object, ByVal e As EventArgs)
			Dim cf As CustomizeForm = CType(IIf(TypeOf sender Is CustomizeForm, sender, Nothing), CustomizeForm)
			color = cf.BackColor
			image = cf.Image
		End Sub

		' Paint the breakpoint indicator
		Private Sub CustomBookmarkPainter(ByVal sender As Object, ByVal args As BookmarkPaintEventArgs)
			args.Graphics.DrawImage(image, args.ClipRectangle.Left, args.ClipRectangle.Top, 19, 19)
		End Sub
	End Class
End Namespace

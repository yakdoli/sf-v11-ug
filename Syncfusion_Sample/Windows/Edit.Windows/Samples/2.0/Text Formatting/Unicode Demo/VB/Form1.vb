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

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization


Namespace UnicodeDemo
    '/ <summary>
    '/ Summary description for Form1.
    '/ </summary>

    Public Class Form1
        Inherits System.Windows.Forms.Form
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
        Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem11 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem12 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem13 As System.Windows.Forms.MenuItem
        Private menuItem14 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem15 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem16 As System.Windows.Forms.MenuItem '/ <summary>
        Private WithEvents menuItem17 As System.Windows.Forms.MenuItem
        '/ Required designer variable.
        '/ </summary>
        Private components As System.ComponentModel.Container = Nothing

        Private ChinesePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\Chinese.txt"
        Private ArabicPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\Arabic.txt"
        Private GreekPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\Greek.txt"
        Private HindiPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\Hindi.txt"
        Private RussianPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\Russian.txt"
        Private JapanesePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\Japanese.txt"
        Private HebrewPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\Hebrew.txt"



        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            Me.editControl1.StatusBarSettings.TextPanel.Panel.Alignment = HorizontalAlignment.Left
            Me.editControl1.StatusBarSettings.TextPanel.Panel.Text = "Note that the required fonts must be installed on your machine for EditControl to display it correctly."

            Me.editControl1.LoadFile(RussianPath)
        End Sub 'New


        '/ <summary>
        '/ Clean up any resources being used.
        '/ </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub 'Dispose

#Region "Windows Form Designer generated code"

        '/ <summary>
        '/ Required method for Designer support - do not modify
        '/ the contents of this method with the code editor.
        '/ </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.Resources.ResourceManager(GetType(Form1))
            Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
            Me.mainMenu1 = New System.Windows.Forms.MainMenu()
            Me.menuItem1 = New System.Windows.Forms.MenuItem()
            Me.menuItem2 = New System.Windows.Forms.MenuItem()
            Me.menuItem3 = New System.Windows.Forms.MenuItem()
            Me.menuItem4 = New System.Windows.Forms.MenuItem()
            Me.menuItem5 = New System.Windows.Forms.MenuItem()
            Me.menuItem6 = New System.Windows.Forms.MenuItem()
            Me.menuItem7 = New System.Windows.Forms.MenuItem()
            Me.menuItem8 = New System.Windows.Forms.MenuItem()
            Me.menuItem14 = New System.Windows.Forms.MenuItem()
            Me.menuItem9 = New System.Windows.Forms.MenuItem()
            Me.menuItem13 = New System.Windows.Forms.MenuItem()
            Me.menuItem10 = New System.Windows.Forms.MenuItem()
            Me.menuItem12 = New System.Windows.Forms.MenuItem()
            Me.menuItem11 = New System.Windows.Forms.MenuItem()
            Me.menuItem15 = New System.Windows.Forms.MenuItem()
            Me.menuItem16 = New System.Windows.Forms.MenuItem()
            Me.menuItem17 = New System.Windows.Forms.MenuItem()
            CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' editControl1
            ' 
            Me.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart
            Me.editControl1.BackColor = System.Drawing.SystemColors.Window
            Me.editControl1.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
            Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.editControl1.ColumnGuideItems = New Syncfusion.Windows.Forms.Edit.Utils.ColumnGuideItem(-1) {}
            Me.editControl1.ColumnGuidesMeasuringFont = New System.Drawing.Font("Courier New", 10.0F)
            Me.editControl1.ContextChoiceSize = New System.Drawing.Size(176, 88)
            Me.editControl1.ContextPromptBackgroundBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.LemonChiffon)
            Me.editControl1.ContextPromptCustomSize = New System.Drawing.Size(400, 50)
            Me.editControl1.ContextTooltipBackgroundBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.LemonChiffon)
            Me.editControl1.CurrentColumn = 1
            Me.editControl1.CurrentLine = 1
            Me.editControl1.CurrentPosition = New System.Drawing.Point(1, 1)
            Me.editControl1.CustomLineWrappingMarkingImage = Nothing
            Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.editControl1.FileOpened = Nothing
            Me.editControl1.GraphicsCompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default
            Me.editControl1.GraphicsInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default
            Me.editControl1.GraphicsSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default
            Me.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.editControl1.IndentBlockHighlightingColor = System.Drawing.Color.LightBlue
            Me.editControl1.IndentLineColor = System.Drawing.Color.Gray
            Me.editControl1.LineNumbersColor = System.Drawing.Color.DarkBlue
            Me.editControl1.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, System.Byte))
            Me.editControl1.Name = "editControl1"
            Me.editControl1.SelectionMarginBackgroundColor = System.Drawing.Color.Empty
            Me.editControl1.SelectionMarginForegroundColor = System.Drawing.Color.Red
            Me.editControl1.ShowCollapse = False
            Me.editControl1.ShowHorizontalSplitters = True
            Me.editControl1.ShowIndentationGuidelines = True
            Me.editControl1.ShowIndicatorMargin = False
            Me.editControl1.ShowLineNumbers = False
            Me.editControl1.ShowMarkers = False
            Me.editControl1.ShowOutliningCollapsers = False
            Me.editControl1.ShowVerticalSplitters = True
            Me.editControl1.ShowWhitespaces = False
            Me.editControl1.Size = New System.Drawing.Size(542, 466)
            Me.editControl1.StatusBarSettings.CoordsPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
            Me.editControl1.StatusBarSettings.CoordsPanel.MinWidth = 10
            Me.editControl1.StatusBarSettings.CoordsPanel.Visible = False
            Me.editControl1.StatusBarSettings.CoordsPanel.Width = 148
            Me.editControl1.StatusBarSettings.EncodingPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
            Me.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
            Me.editControl1.StatusBarSettings.EncodingPanel.Visible = False
            Me.editControl1.StatusBarSettings.EncodingPanel.Width = 165
            Me.editControl1.StatusBarSettings.InsertPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
            Me.editControl1.StatusBarSettings.InsertPanel.MinWidth = 10
            Me.editControl1.StatusBarSettings.InsertPanel.Visible = False
            Me.editControl1.StatusBarSettings.InsertPanel.Width = 33
            Me.editControl1.StatusBarSettings.StatusPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
            Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
            Me.editControl1.StatusBarSettings.StatusPanel.Visible = False
            Me.editControl1.StatusBarSettings.StatusPanel.Width = 70
            Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
            Me.editControl1.StatusBarSettings.TextPanel.MinWidth = 10
            Me.editControl1.StatusBarSettings.TextPanel.Visible = True
            Me.editControl1.StatusBarSettings.TextPanel.Width = 522
            Me.editControl1.StatusBarSettings.Visible = True
            Me.editControl1.TabIndex = 0
            Me.editControl1.TabSize = 2
            Me.editControl1.TabStopsArray = New Integer() {8, 16, 24, 32, 40}
            Me.editControl1.Text = ""
            Me.editControl1.TextAreaWidth = 600
            Me.editControl1.UserMarginBackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BurlyWood)
            Me.editControl1.UserMarginTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, System.Byte))
            Me.editControl1.UserMarginWidth = 100
            Me.editControl1.WordWrap = True
            Me.editControl1.WordWrapMarginBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BlanchedAlmond)
            Me.editControl1.WordWrapMarginLineColor = System.Drawing.Color.Black
            Me.editControl1.WordWrapMarginLineStyle = System.Drawing.Drawing2D.DashStyle.Dot
            ' 
            ' mainMenu1
            ' 
            Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem14})
            ' 
            ' menuItem1
            ' 
            Me.menuItem1.Index = 0
            Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem17, Me.menuItem8})
            Me.menuItem1.Text = "File"
            ' 
            ' menuItem2
            ' 
            Me.menuItem2.Index = 0
            Me.menuItem2.Text = "New"
            ' 
            ' menuItem3
            ' 
            Me.menuItem3.Index = 1
            Me.menuItem3.Text = "Open"
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
            ' 
            ' menuItem6
            ' 
            Me.menuItem6.Index = 4
            Me.menuItem6.Text = "SaveAs"
            ' 
            ' menuItem7
            ' 
            Me.menuItem7.Index = 5
            Me.menuItem7.Text = "-"
            ' 
            ' menuItem8
            ' 
            Me.menuItem8.Index = 7
            Me.menuItem8.Text = "Exit"
            ' 
            ' menuItem14
            ' 
            Me.menuItem14.Index = 1
            Me.menuItem14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem9, Me.menuItem13, Me.menuItem10, Me.menuItem12, Me.menuItem11, Me.menuItem15, Me.menuItem16})
            Me.menuItem14.Text = "LanguagesMenu"
            ' 
            ' menuItem9
            ' 
            Me.menuItem9.Index = 0
            Me.menuItem9.Text = "Chinese"
            ' 
            ' menuItem13
            ' 
            Me.menuItem13.Index = 1
            Me.menuItem13.Text = "Greek"
            ' 
            ' menuItem10
            ' 
            Me.menuItem10.Index = 2
            Me.menuItem10.Text = "Arabic"
            ' 
            ' menuItem12
            ' 
            Me.menuItem12.Index = 3
            Me.menuItem12.Text = "Russian"
            ' 
            ' menuItem11
            ' 
            Me.menuItem11.Index = 4
            Me.menuItem11.Text = "Hindi"
            ' 
            ' menuItem15
            ' 
            Me.menuItem15.Index = 5
            Me.menuItem15.Text = "Japanese"
            ' 
            ' menuItem16
            ' 
            Me.menuItem16.Index = 6
            Me.menuItem16.Text = "Hebrew"
            ' 
            ' menuItem17
            ' 
            Me.menuItem17.Index = 6
            Me.menuItem17.Text = "Close"
            ' 
            ' Form1
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(542, 466)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.editControl1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Menu = Me.mainMenu1
            Me.Name = "Form1"
            Me.Text = "Unicode Demo"
            CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub 'InitializeComponent 
#End Region


        '/ <summary>
        '/ The main entry point for the application.
        '/ </summary>
        <STAThread()> _
        Shared Sub Main()
Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub 'Main


        Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem8.Click, menuItem17.Click
            Dim mi As MenuItem = sender 

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
        End Sub 'MainMenuClick


        Private Sub LanguageMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem9.Click, menuItem13.Click, menuItem10.Click, menuItem12.Click, menuItem11.Click, menuItem15.Click, menuItem16.Click
            Dim mi As MenuItem = sender 

            Select Case mi.Text
                Case "Hindi"
                    Me.editControl1.LoadFile(HindiPath)
                Case "Russian"
                    Me.editControl1.LoadFile(RussianPath)
                Case "Chinese"
                    Me.editControl1.LoadFile(ChinesePath)
                Case "Arabic"
                    Me.editControl1.LoadFile(ArabicPath)
                Case "Japanese"
                    Me.editControl1.LoadFile(JapanesePath)
                Case "Hebrew"
                    Me.editControl1.LoadFile(HebrewPath)
                Case "Greek"
                    Me.editControl1.LoadFile(GreekPath)
            End Select
        End Sub 'LanguageMenuClick
    End Class 'Form1
End Namespace 'editcontrol_basic
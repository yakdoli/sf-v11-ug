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
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO

Imports Syncfusion.Windows.Forms.Edit.Enums
Imports Syncfusion.Windows.Forms.Edit.Utils


Namespace ColumnGuidesDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
		Private columnGuideItem As Syncfusion.Windows.Forms.Edit.Utils.ColumnGuideItem()
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
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
        Private filePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "..\..\..\Form1.vb"

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Me.editControl1.LoadFile(filePath)
            Me.editControl1.ApplyConfiguration(KnownLanguages.VBNET)
			Me.editControl1.ColumnGuidesMeasuringFont = New Font("Microsoft Sans Serif",12)
			Me.editControl1.ShowColumnGuides = True

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
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
            Me.menuItem8 = New System.Windows.Forms.MenuItem()
            Me.menuItem9 = New System.Windows.Forms.MenuItem()
            Me.menuItem10 = New System.Windows.Forms.MenuItem()
            CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'editControl1
            '
            Me.editControl1.ChangedLinesMarkingLineColor = System.Drawing.Color.Yellow
            Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.editControl1.Name = "editControl1"
            Me.editControl1.Size = New System.Drawing.Size(542, 445)
            Me.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
            Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
            Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
            Me.editControl1.TabIndex = 0
            Me.editControl1.Text = ""
            '
            'mainMenu1
            '
            Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem10})
            '
            'menuItem1
            '
            Me.menuItem1.Index = 0
            Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem8, Me.menuItem9})
            Me.menuItem1.Text = "File"
            '
            'menuItem2
            '
            Me.menuItem2.Index = 0
            Me.menuItem2.Text = "&New"
            '
            'menuItem3
            '
            Me.menuItem3.Index = 1
            Me.menuItem3.Text = "&Open"
            '
            'menuItem4
            '
            Me.menuItem4.Index = 2
            Me.menuItem4.Text = "-"
            '
            'menuItem5
            '
            Me.menuItem5.Index = 3
            Me.menuItem5.Text = "&Save"
            '
            'menuItem6
            '
            Me.menuItem6.Index = 4
            Me.menuItem6.Text = "Save &As"
            '
            'menuItem7
            '
            Me.menuItem7.Index = 5
            Me.menuItem7.Text = "-"
            '
            'menuItem8
            '
            Me.menuItem8.Index = 6
            Me.menuItem8.Text = "Close"
            '
            'menuItem9
            '
            Me.menuItem9.Index = 7
            Me.menuItem9.Text = "E&xit"
            '
            'menuItem10
            '
            Me.menuItem10.Index = 1
            Me.menuItem10.Text = "SetColumnGuides"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(542, 445)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.editControl1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Menu = Me.mainMenu1
            Me.Name = "Form1"
            Me.Text = "Column Guides"
            CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub

		Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem8.Click, menuItem9.Click
			Dim mi As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)

			Select Case mi.Text
				Case "&New" 
					Me.editControl1.NewFile()
				Case "&Open" 
					Me.editControl1.LoadFile()
				Case "&Save" 
					Me.editControl1.Save()
				Case "Save&As" 
					Me.editControl1.SaveAs()
				Case "Close" 
					Me.editControl1.Close()
				Case "E&xit" 
					Me.Close()
			End Select
		End Sub

		Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click
			Dim cgEditor As ColumnGuidesEditor = New ColumnGuidesEditor()
            If cgEditor.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If (Not ColumnGuidesEditor.invalidinput) Then
                    CreateColumnGuideItems()
                End If
            End If
		End Sub
        Private Sub CreateColumnGuideItems()
            Try
                columnGuideItem = New ColumnGuideItem(ColumnGuidesEditor.columncount - 1) {}
                Dim i As Integer = 0
                Do While i < ColumnGuidesEditor.columncount

                    Dim enumValue As KnownColor
                    For enumValue = KnownColor.YellowGreen To 0 Step -1
                        Dim somecolor As System.Drawing.Color = Color.FromKnownColor(enumValue)
                        Dim s As String = enumValue.ToString()

                        If (s.CompareTo(ColumnGuidesEditor.color(i))) = 0 Then
                            columnGuideItem(i) = New ColumnGuideItem(Integer.Parse(ColumnGuidesEditor.columnnumber(i)), somecolor)
                        End If


                    Next enumValue

                    i += 1
                Loop

                Me.editControl1.ColumnGuideItems = columnGuideItem
            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Enter the known colors")
            End Try

        End Sub
	End Class
End Namespace

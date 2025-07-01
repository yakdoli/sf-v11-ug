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
Imports System.IO
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Implementation.Formatting
Imports Syncfusion.Windows.Forms.Edit.Implementation.IO
Imports Syncfusion.Windows.Forms.Edit.Implementation.Config
Imports Syncfusion.Windows.Forms.Edit.Implementation.Parser
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Utils
Imports Syncfusion.Windows.Forms.Edit.Enums

Namespace BordersDemo
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
		Private menuItem10 As System.Windows.Forms.MenuItem
		Private menuItem11 As System.Windows.Forms.MenuItem
		Private menuItem12 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem13 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem14 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem15 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem16 As System.Windows.Forms.MenuItem
		Private menuItem17 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem18 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem19 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem20 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem21 As System.Windows.Forms.MenuItem
        Private WithEvents menuItem22 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem23 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem24 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem25 As System.Windows.Forms.MenuItem
		Private menuItem26 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem27 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem28 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem29 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem30 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem31 As System.Windows.Forms.MenuItem

		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

        Private filePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Form1.vb"

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

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
			Me.menuItem31 = New System.Windows.Forms.MenuItem()
			Me.menuItem8 = New System.Windows.Forms.MenuItem()
			Me.menuItem12 = New System.Windows.Forms.MenuItem()
			Me.menuItem13 = New System.Windows.Forms.MenuItem()
			Me.menuItem21 = New System.Windows.Forms.MenuItem()
			Me.menuItem14 = New System.Windows.Forms.MenuItem()
			Me.menuItem15 = New System.Windows.Forms.MenuItem()
			Me.menuItem16 = New System.Windows.Forms.MenuItem()
			Me.menuItem22 = New System.Windows.Forms.MenuItem()
			Me.menuItem17 = New System.Windows.Forms.MenuItem()
			Me.menuItem18 = New System.Windows.Forms.MenuItem()
			Me.menuItem19 = New System.Windows.Forms.MenuItem()
			Me.menuItem20 = New System.Windows.Forms.MenuItem()
			Me.menuItem26 = New System.Windows.Forms.MenuItem()
			Me.menuItem27 = New System.Windows.Forms.MenuItem()
			Me.menuItem28 = New System.Windows.Forms.MenuItem()
			Me.menuItem29 = New System.Windows.Forms.MenuItem()
			Me.menuItem30 = New System.Windows.Forms.MenuItem()
			Me.menuItem10 = New System.Windows.Forms.MenuItem()
			Me.menuItem9 = New System.Windows.Forms.MenuItem()
			Me.menuItem23 = New System.Windows.Forms.MenuItem()
			Me.menuItem11 = New System.Windows.Forms.MenuItem()
			Me.menuItem24 = New System.Windows.Forms.MenuItem()
			Me.menuItem25 = New System.Windows.Forms.MenuItem()
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' editControl1
			' 
			Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.editControl1.Name = "editControl1"
			Me.editControl1.Size = New System.Drawing.Size(542, 445)
			Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
			Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
			Me.editControl1.TabIndex = 0
			Me.editControl1.Text = "edtCode"
			' 
			' mainMenu1
			' 
			Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem1, Me.menuItem12, Me.menuItem17, Me.menuItem26, Me.menuItem10, Me.menuItem11})
			' 
			' menuItem1
			' 
			Me.menuItem1.Index = 0
			Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem31, Me.menuItem8})
			Me.menuItem1.Text = "&File"
			' 
			' menuItem2
			' 
			Me.menuItem2.Index = 0
			Me.menuItem2.Text = "&New"
'			Me.menuItem2.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem3
			' 
			Me.menuItem3.Index = 1
			Me.menuItem3.Text = "&Open"
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
			Me.menuItem5.Text = "&Save"
'			Me.menuItem5.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem6
			' 
			Me.menuItem6.Index = 4
			Me.menuItem6.Text = "Save&As"
'			Me.menuItem6.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem7
			' 
			Me.menuItem7.Index = 5
			Me.menuItem7.Text = "-"
			' 
			' menuItem31
			' 
			Me.menuItem31.Index = 6
			Me.menuItem31.Text = "Close"
'			Me.menuItem31.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem8
			' 
			Me.menuItem8.Index = 7
			Me.menuItem8.Text = "E&xit"
'			Me.menuItem8.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem12
			' 
			Me.menuItem12.Index = 1
			Me.menuItem12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem13, Me.menuItem21, Me.menuItem14, Me.menuItem15, Me.menuItem16, Me.menuItem22})
			Me.menuItem12.Text = "BorderStyle"
			' 
			' menuItem13
			' 
			Me.menuItem13.Index = 0
			Me.menuItem13.Text = "Dash"
'			Me.menuItem13.Click += New System.EventHandler(Me.BorderStyle_Click);
			' 
			' menuItem21
			' 
			Me.menuItem21.Index = 1
			Me.menuItem21.Text = "Dot"
'			Me.menuItem21.Click += New System.EventHandler(Me.BorderStyle_Click);
			' 
			' menuItem14
			' 
			Me.menuItem14.Index = 2
			Me.menuItem14.Text = "DotDash"
'			Me.menuItem14.Click += New System.EventHandler(Me.BorderStyle_Click);
			' 
			' menuItem15
			' 
			Me.menuItem15.Index = 3
			Me.menuItem15.Text = "Solid"
'			Me.menuItem15.Click += New System.EventHandler(Me.BorderStyle_Click);
			' 
			' menuItem16
			' 
			Me.menuItem16.Index = 4
			Me.menuItem16.Text = "Wave"
'			Me.menuItem16.Click += New System.EventHandler(Me.BorderStyle_Click);
			' 
			' menuItem22
			' 
			Me.menuItem22.Index = 5
			Me.menuItem22.Text = "None"
			' 
			' menuItem17
			' 
			Me.menuItem17.Index = 2
			Me.menuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem18, Me.menuItem19, Me.menuItem20})
			Me.menuItem17.Text = "BorderWeight"
			' 
			' menuItem18
			' 
			Me.menuItem18.Index = 0
			Me.menuItem18.Text = "Thin"
'			Me.menuItem18.Click += New System.EventHandler(Me.BorderWeight_Click);
			' 
			' menuItem19
			' 
			Me.menuItem19.Index = 1
			Me.menuItem19.Text = "Double"
'			Me.menuItem19.Click += New System.EventHandler(Me.BorderWeight_Click);
			' 
			' menuItem20
			' 
			Me.menuItem20.Index = 2
			Me.menuItem20.Text = "Bold"
'			Me.menuItem20.Click += New System.EventHandler(Me.BorderWeight_Click);
			' 
			' menuItem26
			' 
			Me.menuItem26.Index = 3
			Me.menuItem26.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem27, Me.menuItem28, Me.menuItem29, Me.menuItem30})
			Me.menuItem26.Text = "BorderColor"
			' 
			' menuItem27
			' 
			Me.menuItem27.Index = 0
			Me.menuItem27.Text = "Aqua"
'			Me.menuItem27.Click += New System.EventHandler(Me.BorderColor_Click);
			' 
			' menuItem28
			' 
			Me.menuItem28.Index = 1
			Me.menuItem28.Text = "Navy"
'			Me.menuItem28.Click += New System.EventHandler(Me.BorderColor_Click);
			' 
			' menuItem29
			' 
			Me.menuItem29.Index = 2
			Me.menuItem29.Text = "Khaki"
'			Me.menuItem29.Click += New System.EventHandler(Me.BorderColor_Click);
			' 
			' menuItem30
			' 
			Me.menuItem30.Index = 3
			Me.menuItem30.Text = "Salmon"
'			Me.menuItem30.Click += New System.EventHandler(Me.BorderColor_Click);
			' 
			' menuItem10
			' 
			Me.menuItem10.Index = 4
			Me.menuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem9, Me.menuItem23})
			Me.menuItem10.Text = "SetTextBorder"
			' 
			' menuItem9
			' 
			Me.menuItem9.Index = 0
			Me.menuItem9.Text = "Selected Text"
'			Me.menuItem9.Click += New System.EventHandler(Me.menuItem9_Click_1);
			' 
			' menuItem23
			' 
			Me.menuItem23.Index = 1
			Me.menuItem23.Text = "Specify Text Range"
'			Me.menuItem23.Click += New System.EventHandler(Me.menuItem23_Click);
			' 
			' menuItem11
			' 
			Me.menuItem11.Index = 5
			Me.menuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem24, Me.menuItem25})
			Me.menuItem11.Text = "RemoveTextBorder"
			' 
			' menuItem24
			' 
			Me.menuItem24.Index = 0
			Me.menuItem24.Text = "Selected Text"
'			Me.menuItem24.Click += New System.EventHandler(Me.menuItem24_Click);
			' 
			' menuItem25
			' 
			Me.menuItem25.Index = 1
			Me.menuItem25.Text = "Specify Text Range"
'			Me.menuItem25.Click += New System.EventHandler(Me.menuItem25_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(542, 445)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.editControl1})
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Menu = Me.mainMenu1
			Me.Name = "Form1"
			Me.Text = "Borders Demo"
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub



		Private borderstyle As FrameBorderStyle = FrameBorderStyle.Dash
        Private Sub BorderStyle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem13.Click, menuItem21.Click, menuItem14.Click, menuItem15.Click, menuItem16.Click, menuItem22.Click
            Dim mi As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)

            Select Case mi.Text
                Case "Dash"
                    Me.borderstyle = FrameBorderStyle.Dash
                Case "DotDash"
                    Me.borderstyle = FrameBorderStyle.DashDot
                Case "Dot"
                    Me.borderstyle = FrameBorderStyle.Dot
                Case "Solid"
                    Me.borderstyle = FrameBorderStyle.Solid
                Case "Wave"
                    Me.borderstyle = FrameBorderStyle.Wave
                Case "None"
                    Me.borderstyle = FrameBorderStyle.None
            End Select
        End Sub

        Private weight As BorderWeight = BorderWeight.Thin
        Private Sub BorderWeight_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem18.Click, menuItem19.Click, menuItem20.Click
            Dim mi As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)

            Select Case mi.Text
                Case "Thin"
                    Me.weight = BorderWeight.Thin
                Case "Bold"
                    Me.weight = BorderWeight.Bold
                Case "Double"
                    Me.weight = BorderWeight.Double
            End Select
        End Sub

        Private Sub menuItem9_Click_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem9.Click
            If Not Me.editControl1.Selection Is Nothing Then
                ' Set borders to the selected text
                Me.editControl1.SetTextBorder(Me.editControl1.Selection.Top, Me.editControl1.Selection.Bottom, color, Me.borderstyle, Me.weight)
            Else
                MessageBox.Show("Please select some text")
            End If
        End Sub

        Private Sub menuItem23_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem23.Click
            Dim dialog As Form2 = New Form2(Me)
            If DialogResult.OK = dialog.ShowDialog() Then

                Dim startline As Integer = dialog.startLine
                Dim startcolumn As Integer = dialog.startColumn


                Dim endline As Integer = dialog.endLine
                Dim endcolumn As Integer = dialog.endColumn
                If (startline < Me.editControl1.PhysicalLineCount) AndAlso (endline < Me.editControl1.PhysicalLineCount AndAlso endline > startline) Then
                    If (endcolumn < Me.editControl1.GetLine(endline).LineLength) AndAlso (startcolumn < Me.editControl1.GetLine(startline).LineLength) Then
                        ' Creating the associated CoordinatePoints that indicate the text range
                        Dim startCoordinatePoint As CoordinatePoint = Me.editControl1.ConvertVirtualPointToCoordinatePoint(startcolumn, startline)
                        Dim endCoordinatePoint As CoordinatePoint = Me.editControl1.ConvertVirtualPointToCoordinatePoint(endcolumn, endline)

                        ' Set borders to the specified text range
                        Me.editControl1.SetTextBorder(startCoordinatePoint, endCoordinatePoint, color, Me.borderstyle, Me.weight)
                    Else
                        MessageBox.Show(Me, "Starting or Ending column number is greater than the number of Columns in the line", "Wrong Column Number", MessageBoxButtons.OK)
                    End If

                Else
                    MessageBox.Show(Me, "Starting or Ending line number is greater than the number of lines in EditControl", "Wrong Line Number", MessageBoxButtons.OK)
                End If
            End If

        End Sub
        Public ReadOnly Property PhysicalLineCount() As Integer
            Get
                Return Me.editControl1.PhysicalLineCount
            End Get
        End Property
        Public Function GetLineLength(ByVal line As Integer) As Integer
            Return Me.editControl1.GetLine(line).LineLength
        End Function
        Private Sub menuItem24_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem24.Click
            ' Remove borders from the selected text
            Me.editControl1.RemoveTextBorder(Me.editControl1.Selection.Top, Me.editControl1.Selection.Bottom)
        End Sub

        Private Sub menuItem25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem25.Click
            Dim dialog As Form2 = New Form2(Me)
            If DialogResult.OK = dialog.ShowDialog() Then

                Dim startline As Integer = dialog.startLine
                Dim startcolumn As Integer = dialog.startColumn


                Dim endline As Integer = dialog.endLine
                Dim endcolumn As Integer = dialog.endColumn
                If (startline < Me.editControl1.PhysicalLineCount) AndAlso (endline < Me.editControl1.PhysicalLineCount) Then
                    If (endcolumn < Me.editControl1.GetLine(endline).LineLength) AndAlso (startcolumn < Me.editControl1.GetLine(startline).LineLength) Then
                        ' Creating the associated CoordinatePoints that indicate the text range
                        Dim startCoordinatePoint As CoordinatePoint = Me.editControl1.ConvertVirtualPointToCoordinatePoint(startcolumn, startline)
                        Dim endCoordinatePoint As CoordinatePoint = Me.editControl1.ConvertVirtualPointToCoordinatePoint(endcolumn, endline)

                        ' Remove borders to the specified text range
                        Me.editControl1.RemoveTextBorder(startCoordinatePoint, endCoordinatePoint)
                    Else
                        MessageBox.Show(Me, "Starting or Ending column number is greater than the number of Columns in the line", "Wrong Column Number", MessageBoxButtons.OK)
                    End If

                Else
                    MessageBox.Show(Me, "Starting or Ending line number is greater than the number of lines in EditControl", "Wrong Line Number", MessageBoxButtons.OK)
                End If
            End If
        End Sub

        Private color As color = color.Aqua
        Private Sub BorderColor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem27.Click, menuItem28.Click, menuItem29.Click, menuItem30.Click
            Dim mi As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)

            Select Case mi.Text
                Case "Aqua"
                    Me.color = color.Aqua
                Case "Navy"
                    Me.color = color.Navy
                Case "Khaki"
                    Me.color = color.Khaki
                Case "Salmon"
                    Me.color = color.Salmon
            End Select
        End Sub

        Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem31.Click, menuItem8.Click
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
    End Class
End Namespace

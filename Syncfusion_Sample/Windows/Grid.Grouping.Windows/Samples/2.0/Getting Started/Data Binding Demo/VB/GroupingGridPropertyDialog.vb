Imports Microsoft.VisualBasic
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

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Styles
Imports Syncfusion.ComponentModel
Imports Syncfusion.Windows.Forms

Public Class GroupingGridPropertyDialog
	Inherits System.Windows.Forms.Form
	Friend propertyGrid As System.Windows.Forms.PropertyGrid
	Private components As System.ComponentModel.Container = Nothing
	Private pgMenu As PropertyGridContextMenu

	Private grid As GridGroupingControl

	Public Sub New(ByVal grid As GridGroupingControl)
		InitializeComponent()

		Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
		Me.Icon = ico

		Me.grid = grid
		Me.grid.FilterRuntimeProperties = True
		propertyGrid.SelectedObject = grid

		If propertyGrid IsNot Nothing Then
			Me.pgMenu = New PropertyGridContextMenu(Me.propertyGrid)
		End If

		AddHandler grid.PropertyChanged, AddressOf grid_PropertyChanged
		AddHandler grid.TableDescriptor.PropertyChanged, AddressOf TableDescriptor_PropertyChanged
		AddHandler grid.Engine.SourceListChanged, AddressOf Engine_SourceListChanged
		AddHandler Application.Idle, AddressOf Application_Idle
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

	Private needRefresh As Boolean = False

	Private Sub grid_PropertyChanged(ByVal sender As Object, ByVal e As DescriptorPropertyChangedEventArgs)
		needRefresh = True
	End Sub

	Private Sub TableDescriptor_PropertyChanged(ByVal sender As Object, ByVal e As DescriptorPropertyChangedEventArgs)
		needRefresh = True
	End Sub

	Private Sub Engine_SourceListChanged(ByVal sender As Object, ByVal e As EventArgs)
		needRefresh = True
	End Sub

	Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
		If Me.needRefresh AndAlso propertyGrid IsNot Nothing AndAlso propertyGrid.Parent IsNot Nothing Then
			needRefresh = False
			propertyGrid.Refresh()
		End If
	End Sub

	Protected Overrides Sub OnClosed(ByVal e As EventArgs)
		RemoveHandler Application.Idle, AddressOf Application_Idle
		MyBase.OnClosed (e)
	End Sub


	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub

	Protected Overrides Sub WndProc(ByRef m As Message)
		MyBase.WndProc (m)

	End Sub


	#Region "Windows Form Designer generated code"
	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
		Me.SuspendLayout()
		' 
		' propertyGrid
		' 
		Me.propertyGrid.CommandsVisibleIfAvailable = True
		Me.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
		Me.propertyGrid.LargeButtons = False
		Me.propertyGrid.LineColor = System.Drawing.SystemColors.ScrollBar
		Me.propertyGrid.Location = New System.Drawing.Point(0, 0)
		Me.propertyGrid.Name = "propertyGrid"
		Me.propertyGrid.Size = New System.Drawing.Size(432, 606)
		Me.propertyGrid.TabIndex = 0
		Me.propertyGrid.Text = "propertyGrid"
		Me.propertyGrid.ViewBackColor = System.Drawing.SystemColors.Window
		Me.propertyGrid.ViewForeColor = System.Drawing.SystemColors.WindowText
		' 
		' GroupingGridPropertyDialog
		' 
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(432, 606)
		Me.Controls.Add(Me.propertyGrid)
		Me.Name = "GroupingGridPropertyDialog"
		Me.Text = "Grid Properties"
		Me.ResumeLayout(False)

	End Sub
	#End Region


End Class

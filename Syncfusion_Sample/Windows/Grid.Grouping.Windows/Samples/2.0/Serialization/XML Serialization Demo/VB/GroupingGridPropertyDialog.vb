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

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Styles
Imports Syncfusion.ComponentModel
Imports Syncfusion.Windows.Forms

Public Class GroupingGridPropertyDialog : Inherits System.Windows.Forms.Form
	Friend propertyGrid As System.Windows.Forms.PropertyGrid
	Private components As System.ComponentModel.Container = Nothing
	Private pgMenu As PropertyGridContextMenu

	Private grid As GridGroupingControl

	Public Sub New(ByVal grid As GridGroupingControl)
		InitializeComponent()

		Me.grid = grid
		Me.grid.FilterRuntimeProperties = True
		propertyGrid.SelectedObject = grid

		If Not propertyGrid Is Nothing Then
			Me.pgMenu = New PropertyGridContextMenu(Me.propertyGrid)
		End If

		AddHandler grid.PropertyChanged, AddressOf grid_PropertyChanged
		AddHandler grid.TableDescriptor.PropertyChanged, AddressOf TableDescriptor_PropertyChanged
		AddHandler grid.Engine.SourceListChanged, AddressOf Engine_SourceListChanged
		AddHandler Application.Idle, AddressOf Application_Idle
        Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
		Me.Icon = ico
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
		If Me.needRefresh AndAlso Not propertyGrid Is Nothing AndAlso Not propertyGrid.Parent Is Nothing Then
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
			If Not components Is Nothing Then
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
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid
        Me.SuspendLayout()
        '
        'propertyGrid
        '
        Me.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.propertyGrid.LineColor = System.Drawing.SystemColors.ScrollBar
        Me.propertyGrid.Location = New System.Drawing.Point(0, 0)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(292, 266)
        Me.propertyGrid.TabIndex = 0
        '
        'GroupingGridPropertyDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.propertyGrid)
        Me.Name = "GroupingGridPropertyDialog"
        Me.Text = "Grouping Grid Property Dialog"
        Me.ResumeLayout(False)

    End Sub
	#End Region


End Class

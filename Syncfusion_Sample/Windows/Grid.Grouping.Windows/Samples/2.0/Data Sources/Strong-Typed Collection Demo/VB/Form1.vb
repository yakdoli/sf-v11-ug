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
Imports System.Data
Imports System.Text
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Grouping

Imports Syncfusion.Collections
Imports Syncfusion.Drawing
Imports Syncfusion.ComponentModel
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid.Grouping

Namespace StrongTypedCollectionSample
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private groupingGrid1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private propertyGrid1 As PropertyGrid
		Private panel1 As Panel

		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			InitializeComponent()
			Try
				Dim ico As New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			Dim customers As CustomerCollection = PopulateCustomers.CreateCustomers()

			Me.groupingGrid1.ShowNavigationBar = True
			Me.groupingGrid1.TableControl.HorizontalScrollTips = False
			Me.groupingGrid1.BorderStyle = BorderStyle.FixedSingle
			Me.groupingGrid1.FilterRuntimeProperties = True

			Me.groupingGrid1.DataSource = customers

			Dim engine As GridEngine = Me.groupingGrid1.Engine
			engine.TopLevelGroupOptions.ShowCaption = True

			Dim relations As New GridRelationDescriptorCollection()

			' First level
			Dim rd As GridRelationDescriptor = AddRelation("Level_0", relations)

			' Subsequent levels
			For level As Integer = 1 To 4
				rd = AddRelation("Level_" & level.ToString(), rd.ChildTableDescriptor.Relations)
			Next level

			Me.groupingGrid1.TableDescriptor.Relations = relations

			Me.groupingGrid1.TableOptions.ShowRecordPlusMinus = True
			Me.groupingGrid1.NestedTableGroupOptions.ShowCaptionPlusMinus = False
			Me.groupingGrid1.Table.ExpandAllRecords()
			Syncfusion.Grouping.Diagnostics.IterateThroughNestedDisplayElement(Me.groupingGrid1.Table)
			Me.groupingGrid1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
			Me.groupingGrid1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
			Me.groupingGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.groupingGrid1.TopLevelGroupOptions.ShowCaption = False
			Me.groupingGrid1.Appearance.AnyCell.Font.Facename = "Verdana"
			Me.groupingGrid1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			Me.BackColor = Color.White
			Me.propertyGrid1.SelectedObject = Me.groupingGrid1
			Me.propertyGrid1.BackColor = Color.White
			Me.DropShadow = True
			Me.groupingGrid1.GridVisualStyles = GridVisualStyles.Metro


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

		Private Function AddRelation(ByVal name As String, ByVal relations As GridRelationDescriptorCollection) As GridRelationDescriptor
			Dim children As New GridRelationDescriptor()
			children.RelationKind = RelationKind.UniformChildList
			children.MappingName = "Children"
			children.Name = name
			relations.Add(children)
			Return children
		End Function

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

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.groupingGrid1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.panel1 = New System.Windows.Forms.Panel
            CType(Me.groupingGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'groupingGrid1
            '
            Me.groupingGrid1.BackColor = System.Drawing.SystemColors.Window
            Me.groupingGrid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.groupingGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.groupingGrid1.Location = New System.Drawing.Point(21, 23)
            Me.groupingGrid1.Name = "groupingGrid1"
            Me.groupingGrid1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.groupingGrid1.NestedTableGroupOptions.ShowCaption = True
            Me.groupingGrid1.Size = New System.Drawing.Size(536, 392)
            Me.groupingGrid1.TabIndex = 1
            Me.groupingGrid1.TableDescriptor.AllowNew = False
            Me.groupingGrid1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
            Me.groupingGrid1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
            Me.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.groupingGrid1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.groupingGrid1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
            Me.groupingGrid1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
            Me.groupingGrid1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
            Me.groupingGrid1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.groupingGrid1.TableDescriptor.TableOptions.RecordRowHeight = 20
            Me.groupingGrid1.Text = "groupingGrid1"
            Me.groupingGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.groupingGrid1.TopLevelGroupOptions.ShowCaption = False
            '
            'propertyGrid1
            '
            Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
            Me.propertyGrid1.LineColor = System.Drawing.Color.White
            Me.propertyGrid1.Location = New System.Drawing.Point(598, 23)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(229, 392)
            Me.propertyGrid1.TabIndex = 2
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.DimGray
            Me.panel1.Location = New System.Drawing.Point(577, 38)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1, 364)
            Me.panel1.TabIndex = 3
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(845, 440)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.groupingGrid1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Strong-Typed Collection Demo"
            CType(Me.groupingGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub

	End Class
End Namespace
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
Imports System.IO
Imports System.Drawing.Imaging
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS
Imports System.Collections.Generic
Imports Syncfusion.GridHelperClasses
Imports Syncfusion.Windows.Forms

Namespace PrintGroupingGrid
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private components As IContainer=Nothing
		Private WithEvents buttonAdv1 As ButtonAdv
		Private WithEvents buttonAdv2 As ButtonAdv
		Private groupBox1 As GroupBox
		Private WithEvents button1 As ButtonAdv

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Try
				Dim ico As New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
			Me.InitializeDataSet()
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

		Private Sub InitializeDataSet()
			Dim parentTable As DataTable = GetParentTable()
			Dim childTable As DataTable = GetChildTable()
			Dim grandChildTable As DataTable = GetGrandChildTable()
			' Manually specify relations in grouping engine. The DataSet does not need to have any DataRelations.
			' This is the same approach that should be used if you want to set up relation ships
			' between independent IList.
			Dim parentToChildRelationDescriptor As New GridRelationDescriptor()
			parentToChildRelationDescriptor.ChildTableName = "MyChildTable" ' same as SourceListSetEntry.Name for childTable (see below)
			parentToChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails
			parentToChildRelationDescriptor.RelationKeys.Add("parentID", "ParentID")

			' Add relation to ParentTable 
			gridGroupingControl1.TableDescriptor.Relations.Add(parentToChildRelationDescriptor)

			Dim childToGrandChildRelationDescriptor As New GridRelationDescriptor()
			childToGrandChildRelationDescriptor.ChildTableName = "MyGrandChildTable" ' same as SourceListSetEntry.Name for grandChhildTable (see below)
			childToGrandChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails
			childToGrandChildRelationDescriptor.RelationKeys.Add("childID", "ChildID")

			' Add relation to ChildTable 
			parentToChildRelationDescriptor.ChildTableDescriptor.Relations.Add(childToGrandChildRelationDescriptor)

			' Register any DataTable/IList with SourceListSet, so that RelationDescriptor can resolve the name
			Me.gridGroupingControl1.Engine.SourceListSet.Add("MyParentTable", parentTable)
			Me.gridGroupingControl1.Engine.SourceListSet.Add("MyChildTable", childTable)
			Me.gridGroupingControl1.Engine.SourceListSet.Add("MyGrandChildTable", grandChildTable)

			Me.gridGroupingControl1.DataSource = parentTable
		End Sub

		#Region "DataTables"

		Private numberParentRows As Integer = 5
		Private numberChildRows As Integer = 20
		Private numberGrandChildRows As Integer = 50
		Private Function GetParentTable() As DataTable
			Dim dt As New DataTable("ParentTable")


			dt.Columns.Add(New DataColumn("parentID")) 'lower case p
			dt.Columns.Add(New DataColumn("ParentName"))
			dt.Columns.Add(New DataColumn("ParentDec"))

			For i As Integer = 0 To numberParentRows - 1
				Dim dr As DataRow = dt.NewRow()
				dr(0) = i '.ToString();
				dr(1) = String.Format("parentName{0}", i)
				dr(2) = String.Format("parentDec{0}", i)
				dt.Rows.Add(dr)
			Next i

			Return dt
		End Function

		Private Function GetChildTable() As DataTable
			Dim dt As New DataTable("ChildTable")

			dt.Columns.Add(New DataColumn("childID")) 'lower case c
			dt.Columns.Add(New DataColumn("Name"))
			dt.Columns.Add(New DataColumn("ParentID")) 'upper case P

			For i As Integer = 0 To numberChildRows - 1
				Dim dr As DataRow = dt.NewRow()
				dr(0) = i.ToString()
				dr(1) = String.Format("ChildName{0}", i)
				dr(2) = (i Mod numberParentRows).ToString()
				dt.Rows.Add(dr)
			Next i

			Return dt
		End Function

		Private Function GetGrandChildTable() As DataTable
			Dim dt As New DataTable("GrandChildTable")

			dt.Columns.Add(New DataColumn("GrandChildID"))
			dt.Columns.Add(New DataColumn("Name"))
			dt.Columns.Add(New DataColumn("ChildID")) 'upper case C

			For i As Integer = 0 To numberGrandChildRows - 1
				Dim dr As DataRow = dt.NewRow()
				dr(0) = i.ToString()
				dr(1) = String.Format("GrandChildName{0}", i)
				dr(2) = (i Mod numberChildRows).ToString()
				dt.Rows.Add(dr)
			Next i

			Return dt
		End Function
		#End Region

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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.ChildGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridGroupingControl1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.gridGroupingControl1.Location = New System.Drawing.Point(10, 12)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Size = New System.Drawing.Size(480, 436)
			Me.gridGroupingControl1.TabIndex = 0
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255)))))))
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
			Me.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle
			' 
			' button1
			' 
			Me.button1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.White
			Me.button1.Location = New System.Drawing.Point(512, 217)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(160, 34)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Export to Word Document"
			Me.button1.UseVisualStyle = True
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' buttonAdv1
			' 
			Me.buttonAdv1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.buttonAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv1.ForeColor = System.Drawing.Color.White
			Me.buttonAdv1.Location = New System.Drawing.Point(12, 87)
			Me.buttonAdv1.Name = "buttonAdv1"
			Me.buttonAdv1.Size = New System.Drawing.Size(154, 31)
			Me.buttonAdv1.TabIndex = 2
			Me.buttonAdv1.Text = "Collapse All"
			Me.buttonAdv1.UseVisualStyle = True
			Me.buttonAdv1.UseVisualStyleBackColor = True
'			Me.buttonAdv1.Click += New System.EventHandler(Me.buttonAdv1_Click)
			' 
			' buttonAdv2
			' 
			Me.buttonAdv2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.buttonAdv2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv2.ForeColor = System.Drawing.Color.White
			Me.buttonAdv2.Location = New System.Drawing.Point(12, 33)
			Me.buttonAdv2.Name = "buttonAdv2"
			Me.buttonAdv2.Size = New System.Drawing.Size(154, 31)
			Me.buttonAdv2.TabIndex = 3
			Me.buttonAdv2.Text = "Expand All"
			Me.buttonAdv2.UseVisualStyle = True
			Me.buttonAdv2.UseVisualStyleBackColor = True
'			Me.buttonAdv2.Click += New System.EventHandler(Me.buttonAdv2_Click)
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.buttonAdv2)
			Me.groupBox1.Controls.Add(Me.buttonAdv1)
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.Location = New System.Drawing.Point(503, 22)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(175, 148)
			Me.groupBox1.TabIndex = 4
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Expand Options"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
			Me.BackColor = System.Drawing.Color.White
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(687, 460)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.gridGroupingControl1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Word Converter Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()

			#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
				Application.EnableVisualStyles()
			#End If
			Application.Run(New Form1())
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim converter As New GroupingGridWordConverter(True, True)
			AddHandler converter.DrawHeader, AddressOf converter_DrawHeader
			AddHandler converter.DrawFooter, AddressOf converter_DrawFooter
			converter.GroupingGridToWord("Sample.doc", gridGroupingControl1)
			System.Diagnostics.Process.Start("Sample.doc")
		End Sub

		Private Sub converter_DrawFooter(ByVal sender As Object, ByVal e As DocHeaderFooterEventArgs)
			Dim txt As IWTextRange = e.Footer.AddParagraph().AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab & "Copyright Syncfusion Inc. 2001 - 2008")
			txt.CharacterFormat.Font = New Font("verdana", 12f, FontStyle.Bold)
		End Sub

		Private Sub converter_DrawHeader(ByVal sender As Object, ByVal e As DocHeaderFooterEventArgs)
			Dim txt As IWTextRange = e.Header.AddParagraph().AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab & "Syncfusion Inc." & Constants.vbLf)
			txt.CharacterFormat.Font = New Font("verdana", 12f, FontStyle.Bold)
		End Sub

		Private Sub buttonAdv2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv2.Click
			Me.gridGroupingControl1.Table.ExpandAllRecords()
		End Sub

		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click
			Me.gridGroupingControl1.Table.CollapseAllRecords()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.gridGroupingControl1.Table.ExpandAllRecords()
		End Sub

	End Class
End Namespace
#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms

Namespace NestedTables
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private propertyGrid1 As PropertyGrid
		Private panel1 As Panel
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Me.gridGroupingControl1.TableModel.Properties.RowHeaders = False
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
			Me.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			Me.BackColor = Color.White
			Me.DropShadow = True
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
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
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.panel1 = New System.Windows.Forms.Panel
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(27, 18)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.Size = New System.Drawing.Size(485, 393)
            Me.gridGroupingControl1.TabIndex = 0
            Me.gridGroupingControl1.TableDescriptor.AllowNew = False
            Me.gridGroupingControl1.TableDescriptor.Appearance.AlternateRecordFieldCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(111, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(81, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
            Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
            Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
            Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Silver)
            Me.gridGroupingControl1.TableOptions.ShowTreeLines = False
            Me.gridGroupingControl1.TableOptions.TreeLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.SystemColors.ControlDark)
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.VersionInfo = "3.0.1.0"
            '
            'propertyGrid1
            '
            Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
            Me.propertyGrid1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
            Me.propertyGrid1.LineColor = System.Drawing.Color.White
            Me.propertyGrid1.Location = New System.Drawing.Point(543, 18)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(217, 393)
            Me.propertyGrid1.TabIndex = 1
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.DimGray
            Me.panel1.Location = New System.Drawing.Point(527, 27)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1, 373)
            Me.panel1.TabIndex = 2
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(786, 445)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Array List Demo"
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			'some data
			Dim cl1 As ChildList = New ChildList()
			cl1.Add(New Data("1", "Condiments", "Sweets", ""))
			Dim cl2 As ChildList = New ChildList()
			cl2.Add(New Data("2", "Confections", "Deserts", ""))
			cl2.Add(New Data("2", "Confections", "Candies", ""))
			Dim cl3 As ChildList = New ChildList()
			cl3.Add(New Data("3", "Grains/Cereals", "Breads", ""))
			cl3.Add(New Data("3", "Grains/Cereals", "Pasta", ""))
			cl3.Add(New Data("3", "Grains/Cereals", "Cereal", ""))
			Dim cl4 As ChildList = New ChildList()
			cl4.Add(New Data("4", "Meat/Poultry", "Prepared meats", ""))
			Dim cl5 As ChildList = New ChildList()
			cl5.Add(New Data("5", "Produce", "Dried fruit", ""))
			cl5.Add(New Data("5", "Produce", "Bean curd", ""))
			Dim cl6 As ChildList = New ChildList()
			cl6.Add(New Data("6", "Seafood", "Fish", ""))
			cl6.Add(New Data("6", "Seafood", "Seeweed", ""))

			Dim al As ArrayList = New ArrayList()
			al.Add(New ParentItem("Condiments", "Charlotte Cooper","Bigfoot Breweries",cl1))
			al.Add(New ParentItem("Confections","Regina Murphy","Grandma Kelly's Homestead",cl2))
			al.Add(New ParentItem("Grains/Cereals","Jean-Guy Lauzon","Ma Maison",cl3))
			al.Add(New ParentItem("Meat/Poultry","Shelley Burke","New Orleans Cajun Delights",cl4))
			al.Add(New ParentItem("Produce","Mayumi Ohno","Mayumi's",cl5))
			al.Add(New ParentItem("Seafood","Robb Merchant","New England Seafood Cannery",cl6))

			Me.gridGroupingControl1.DataSource = al
			Me.gridGroupingControl1.Engine.SetSourceList(al)

			 Dim grd As GridRelationDescriptor = New GridRelationDescriptor()
			 grd.RelationKind = RelationKind.UniformChildList
			 grd.MappingName = "Child" 'name of property with child arraylist

			 Me.gridGroupingControl1.Engine.SourceListSet.Clear()
			Me.gridGroupingControl1.TableDescriptor.Columns.Clear()
			Me.gridGroupingControl1.TableDescriptor.Columns.Add("CategoryName")
			Me.gridGroupingControl1.TableDescriptor.Columns.Add("SupplierName")
			Me.gridGroupingControl1.TableDescriptor.Columns.Add("CompanyName")
			Me.gridGroupingControl1.TableDescriptor.Relations.Add(grd)
            Dim td As GridTableDescriptor
            For Each td In Me.gridGroupingControl1.Engine.EnumerateTableDescriptor()
                td.Appearance.AnyCell.ReadOnly = True
                td.AllowNew = False
            Next td
		End Sub
	End Class

	Public Class ChildList : Inherits ArrayList : Implements ITypedList
		#Region "ITypedList Members"

		Public Function GetItemProperties(ByVal listAccessors As PropertyDescriptor()) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
			Return TypeDescriptor.GetProperties(GetType(Data))
		End Function

		Public Function GetListName(ByVal listAccessors As PropertyDescriptor()) As String Implements ITypedList.GetListName
			Return "Data"
		End Function

		#End Region
	End Class

	Public Class ParentItem
		Private name, supplier_name, company_name As String
		Private child_Renamed As ChildList
		Public Property CategoryName() As String
			Get
				Return name
			End Get
			Set
				name = Value
			End Set
		End Property
		Public Property SupplierName() As String
			Get
				Return supplier_name
			End Get
			Set
				supplier_name = Value
			End Set
		End Property
		Public Property CompanyName() As String
			Get
				Return company_name
			End Get
			Set
				company_name = Value
			End Set
		End Property

		Public Property Child() As ChildList
			Get
				Return child_Renamed
			End Get
			Set
				child_Renamed = Value
			End Set
		End Property

		Public Sub New()
			Me.New("","","",Nothing)
		End Sub
		Public Sub New(ByVal name As String, ByVal sname As String, ByVal cname As String, ByVal dt As ChildList)
			Me.name = name
			Me.supplier_name=sname
			Me.company_name=cname
			Me.child_Renamed = dt
		End Sub
	End Class
End Namespace

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

Namespace SortByDisplayMember
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private panel1 As Panel
		Private propertyGrid1 As PropertyGrid
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
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
            Me.panel1 = New System.Windows.Forms.Panel
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.gridGroupingControl1.BackColor = System.Drawing.Color.White
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 6)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.Size = New System.Drawing.Size(608, 350)
            Me.gridGroupingControl1.TabIndex = 0
            Me.gridGroupingControl1.TableDescriptor.AllowNew = False
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
            Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
            Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
            Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Silver)
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
            Me.gridGroupingControl1.VersionInfo = "3.201.1.0"
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.DimGray
            Me.panel1.ForeColor = System.Drawing.Color.DimGray
            Me.panel1.Location = New System.Drawing.Point(625, 24)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1, 324)
            Me.panel1.TabIndex = 20
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.propertyGrid1.BackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
            Me.propertyGrid1.LineColor = System.Drawing.Color.White
            Me.propertyGrid1.Location = New System.Drawing.Point(632, 6)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
            Me.propertyGrid1.Size = New System.Drawing.Size(203, 350)
            Me.propertyGrid1.TabIndex = 19
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(846, 373)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Sort By Display Member Demo"
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
			'set up the main table
			Dim dt As DataTable = GetMainDataTable()
			Dim ds As New DataSet("Main")
			ds.Tables.Add(dt)

			Me.gridGroupingControl1.DataSource = ds
			Me.gridGroupingControl1.DataMember = dt.TableName

			'remember the location of lookupcol so it can be swapped out later
			Dim td As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
			td.VisibleColumns.LoadDefault()
			Dim lookUpIndex As Integer = td.VisibleColumns.IndexOf("Customer")

			'get the lookup table
			Dim lookUpDataTable As DataTable = Me.GetForeignTable()

			Dim ds2 As New DataSet("LookUp")
			ds2.Tables.Add(lookUpDataTable)

			'add it to the grouping engine
			Me.gridGroupingControl1.Engine.SourceListSet.Add(lookUpDataTable.TableName, lookUpDataTable.DefaultView)

			'set up relation descriptor that defines mapping between main table and foreign table
			Dim rd As New GridRelationDescriptor()
			rd.Name = "CustomerColDisplay" 'just some unique name
			rd.RelationKind = RelationKind.ForeignKeyReference 'foreign key look up
			rd.ChildTableName = lookUpDataTable.TableName ' SourceListSet name for lookup

			'get foreign key for col "CustomerID" in foreign table
			rd.RelationKeys.Add("Customer", "CustomerID") 'col in main table, foreign key col

			'Set any optional properties on the relation
			' dropdown only shows CustomerName
			rd.ChildTableDescriptor.VisibleColumns.Add("CustomerName") 'display column
			rd.ChildTableDescriptor.SortedColumns.Add("CustomerName") 'sort it for dropdown display
			rd.ChildTableDescriptor.AllowEdit = False 'no editing of foreign table
			rd.ChildTableDescriptor.AllowNew = False 'no new items added to foreign table
			rd.ChildTableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(&Hff, &Hbf, &H34)

			'add relation descriptor to main tabledescriptor
			td.Relations.Add(rd)

			'Replace maintable.LookUpCol with foreigntable.DisplayCol
			Dim foreignPrefix As String = rd.Name & "_"

			'get the hashed name of foreign col
			Dim foreignDisplayColInMainTable As String = foreignPrefix & "CustomerName"
			td.VisibleColumns.Insert(lookUpIndex, foreignDisplayColInMainTable)

			'set its headertext to something other than default hashedname
			td.Columns(foreignDisplayColInMainTable).HeaderText = "Customer"
			td.Columns(foreignDisplayColInMainTable).Appearance.AnyCell.BackColor = Color.FromArgb(218, 229, 245)
		End Sub

		#Region "datatables"
		Private Function GetMainDataTable() As DataTable
			Dim dt As New DataTable("MainTable")

			dt.Columns.Add(New DataColumn("OrderID", GetType(Integer)))
			dt.Columns.Add(New DataColumn("CompanyName", GetType(String)))
			dt.Columns.Add(New DataColumn("ShipName", GetType(String)))
			dt.Columns.Add(New DataColumn("Customer", GetType(String)))

			dt.Rows.Add(New Object(){1020,"Antonio Moreno Taquer�a","Vins et alcools Chevalier",100})
			dt.Rows.Add(New Object(){1021,"Berglunds snabbk�p","Toms Spezialit�ten",101})
			dt.Rows.Add(New Object(){1022,"Around the Horn","Hanari Carnes",102})
			dt.Rows.Add(New Object(){1023,"Blauer See Delikatessen","Victuailles en stock",103})
			dt.Rows.Add(New Object(){1024,"Drachenblut Delikatessen","Supr�mes d�lices",104})
			dt.Rows.Add(New Object(){1025,"Consolidated Holdings","Wellington Importadora",105})
			dt.Rows.Add(New Object(){1026,"Folies gourmandes","Ottilies K�seladen:",106})
			dt.Rows.Add(New Object(){1027,"Ernst Handel","White Clover Markets",107})
			dt.Rows.Add(New Object(){1028,"Bon app'","White Clover Markets",108})
			dt.Rows.Add(New Object(){1029,"B's Beverages","Buchanan",109})
			dt.Rows.Add(New Object(){1030,"Folk och f� HB","Suyama",110})
			dt.Rows.Add(New Object(){1031,"Folies gourmandes","Peacock",111})
			dt.Rows.Add(New Object(){1032,"Eastern Connection","Leverling",112})
			dt.Rows.Add(New Object(){1033,"Let's Stop N Shop","Dodsworth",113})
			dt.Rows.Add(New Object(){1034,"QUICK-Stop","Davolio",114})
			dt.Rows.Add(New Object(){1035,"Toms Spezialit�ten","Callahan",115})
			dt.Rows.Add(New Object(){1036,"Wilman Kala","Peacock",116})
			dt.Rows.Add(New Object(){1037,"Wartian Herkku","Leverling",117})

			Return dt
		End Function

		Private Function GetForeignTable() As DataTable
			Dim dt As New DataTable("ForeignTable")

			dt.Columns.Add(New DataColumn("CustomerID",GetType(Integer)))
			dt.Columns.Add(New DataColumn("CustomerName",GetType(String)))

			dt.Rows.Add(New Object(){100,"Fr�d�rique Citeaux"})
			dt.Rows.Add(New Object(){101,"Laurence Lebihan"})
			dt.Rows.Add(New Object(){102,"Christina Berglund"})
			dt.Rows.Add(New Object(){103,"Victoria Ashworth"})
			dt.Rows.Add(New Object(){104,"Elizabeth Brown"})
			dt.Rows.Add(New Object(){105,"Eduardo Saavedra"})
			dt.Rows.Add(New Object(){106,"Janine Labrune"})
			dt.Rows.Add(New Object(){107,"Catherine Dewey"})
			dt.Rows.Add(New Object(){108,"Helvetius Nagy"})
			dt.Rows.Add(New Object(){109,"Palle Ibsen"})
			dt.Rows.Add(New Object(){110,"Rita M�ller"})
			dt.Rows.Add(New Object(){111,"Anabela Domingues"})
			dt.Rows.Add(New Object(){112,"Zbyszek Piestrzeniewicz"})
			dt.Rows.Add(New Object(){113,"Matti Karttunen"})
			dt.Rows.Add(New Object(){114,"Pirkko Koskitalo"})
			dt.Rows.Add(New Object(){115,"Karl Jablonski"})
			dt.Rows.Add(New Object(){116,"Anne Granger"})
			dt.Rows.Add(New Object(){117,"Paula Parente"})

			dt.Rows.Add(New Object(){107,"Catherine Dewey"})

			Return dt
		End Function
		#End Region
	End Class
End Namespace

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
Imports Syncfusion.GridHelperClasses
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO
Imports Syncfusion.Windows.Forms

Namespace DynamicFilter
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private dataSet11 As DynamicFilter.DataSet1
		Private components As IContainer
		Private imageList1 As ImageList
		Private filter As New GridDynamicFilter()
		Private gridGroupingControl1 As GridGroupingControl
		Private propertyGrid1 As PropertyGrid
		Private panel1 As Panel
        Private WithEvents checkBox8 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents checkBox7 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents checkBox6 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents checkBox5 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents checkBox4 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents checkBox3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents checkBox2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Public ReadOnly Shared connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")

		Public Sub New()
			LocalizationProvider.Provider = New Localizer()
			InitializeComponent()
			GridGroupingSettings()
		End Sub

		Public Sub GridGroupingSettings()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

			Dim commandstring1 As String = "select * from Customers"
			Dim commandstring2 As String = "select * from Orders"

			Dim da1 As New SqlCeDataAdapter(commandstring1, connString)
			Dim da2 As New SqlCeDataAdapter(commandstring2, connString)
			da1.Fill(dataSet11, "Customers")
			da1.Fill(dataSet11, "Orders")

			Me.gridGroupingControl1.DataSource = Me.dataSet11.Tables("Customers")

			If Me.gridGroupingControl1.GetTableControl("Orders").GroupDropArea Is Nothing Then
				Me.gridGroupingControl1.AddGroupDropArea("Orders")
			End If

			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
			Me.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle
	
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TableModel.TableStyle.Font.Facename = "Verdana"
			Me.gridGroupingControl1.TableModel.TableStyle.TextColor = Color.MidnightBlue


			Me.gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = True
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowFilterBar = True
			Me.gridGroupingControl1.ChildGroupOptions.ShowFilterBar = True
			'Enable the filter for each columns 
			For i As Integer = 0 To gridGroupingControl1.TableDescriptor.Columns.Count - 1
				gridGroupingControl1.TableDescriptor.Columns(i).AllowFilter = True
			Next i

			Dim childDesc As GridTableDescriptor = gridGroupingControl1.GetTableDescriptor("Orders")
			For j As Integer = 0 To childDesc.Columns.Count - 1
				childDesc.Columns(j).AllowFilter = True
			Next j

			'Enable dynamic filter.
			filter.WireGrid(gridGroupingControl1)
			Me.gridGroupingControl1.ShowNavigationBar = True
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro


		End Sub

		Private Shared Function FindFile(ByVal fileName As String) As String
			' Check both in parent folder and Parent\Data folders.
			Dim dataFileName As String = "Common\Data\" & fileName
			For n As Integer = 0 To 11
				If System.IO.File.Exists(fileName) Then
					Return New FileInfo(fileName).FullName
				End If
				If System.IO.File.Exists(dataFileName) Then
					Return New FileInfo(dataFileName).FullName
				End If
				fileName = "..\" & fileName
				dataFileName = "..\" & dataFileName
			Next n

			Return fileName
		End Function

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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.dataSet11 = New DynamicFilter.DataSet1
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.panel1 = New System.Windows.Forms.Panel
            Me.checkBox8 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox7 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox6 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox5 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox4 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.checkBox8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dataSet11
            '
            Me.dataSet11.DataSetName = "DataSet1"
            Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "filter_delete.png")
            Me.imageList1.Images.SetKeyName(1, "filter.png")
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.DataSource = Me.dataSet11.Customers
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gridGroupingControl1.Location = New System.Drawing.Point(9, 8)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.ShowGroupDropArea = True
            Me.gridGroupingControl1.Size = New System.Drawing.Size(732, 483)
            Me.gridGroupingControl1.TabIndex = 14
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.VersionInfo = "4.201.0.37"
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.propertyGrid1.BackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
            Me.propertyGrid1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
            Me.propertyGrid1.LineColor = System.Drawing.Color.White
            Me.propertyGrid1.Location = New System.Drawing.Point(755, 187)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
            Me.propertyGrid1.Size = New System.Drawing.Size(262, 304)
            Me.propertyGrid1.TabIndex = 16
            '
            'panel1
            '
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.checkBox8)
            Me.panel1.Controls.Add(Me.checkBox7)
            Me.panel1.Controls.Add(Me.checkBox6)
            Me.panel1.Controls.Add(Me.checkBox5)
            Me.panel1.Controls.Add(Me.checkBox4)
            Me.panel1.Controls.Add(Me.checkBox3)
            Me.panel1.Controls.Add(Me.checkBox2)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panel1.Location = New System.Drawing.Point(756, 8)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(260, 172)
            Me.panel1.TabIndex = 17
            '
            'checkBox8
            '
            Me.checkBox8.DrawFocusRectangle = False
            Me.checkBox8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox8.ForeColor = System.Drawing.Color.DimGray
            Me.checkBox8.Location = New System.Drawing.Point(10, 128)
            Me.checkBox8.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox8.Name = "checkBox8"
            Me.checkBox8.Size = New System.Drawing.Size(247, 17)
            Me.checkBox8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox8.TabIndex = 23
            Me.checkBox8.Text = "Enable Localization in RecordNavigationBar"
            Me.checkBox8.ThemesEnabled = False
            '
            'checkBox7
            '
            Me.checkBox7.DrawFocusRectangle = False
            Me.checkBox7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox7.ForeColor = System.Drawing.Color.DimGray
            Me.checkBox7.Location = New System.Drawing.Point(10, 108)
            Me.checkBox7.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox7.Name = "checkBox7"
            Me.checkBox7.Size = New System.Drawing.Size(206, 17)
            Me.checkBox7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox7.TabIndex = 22
            Me.checkBox7.Text = "Enable Localization in FieldChooser"
            Me.checkBox7.ThemesEnabled = False
            '
            'checkBox6
            '
            Me.checkBox6.DrawFocusRectangle = False
            Me.checkBox6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox6.ForeColor = System.Drawing.Color.DimGray
            Me.checkBox6.Location = New System.Drawing.Point(10, 88)
            Me.checkBox6.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox6.Name = "checkBox6"
            Me.checkBox6.Size = New System.Drawing.Size(222, 17)
            Me.checkBox6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox6.TabIndex = 21
            Me.checkBox6.Text = "Enable Localization in Office2007 Filter"
            Me.checkBox6.ThemesEnabled = False
            '
            'checkBox5
            '
            Me.checkBox5.DrawFocusRectangle = False
            Me.checkBox5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox5.ForeColor = System.Drawing.Color.DimGray
            Me.checkBox5.Location = New System.Drawing.Point(10, 148)
            Me.checkBox5.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Size = New System.Drawing.Size(217, 17)
            Me.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox5.TabIndex = 20
            Me.checkBox5.Text = "Enable Localization in Filter Comparer"
            Me.checkBox5.ThemesEnabled = False
            '
            'checkBox4
            '
            Me.checkBox4.Checked = True
            Me.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox4.DrawFocusRectangle = False
            Me.checkBox4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox4.ForeColor = System.Drawing.Color.DimGray
            Me.checkBox4.Location = New System.Drawing.Point(10, 8)
            Me.checkBox4.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(95, 17)
            Me.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox4.TabIndex = 19
            Me.checkBox4.Text = "Dynamic Filter"
            Me.checkBox4.ThemesEnabled = False
            '
            'checkBox3
            '
            Me.checkBox3.Checked = True
            Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox3.DrawFocusRectangle = False
            Me.checkBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox3.ForeColor = System.Drawing.Color.DimGray
            Me.checkBox3.Location = New System.Drawing.Point(10, 69)
            Me.checkBox3.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(172, 17)
            Me.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox3.TabIndex = 18
            Me.checkBox3.Text = "Add FilterBar to ChildGroups"
            Me.checkBox3.ThemesEnabled = False
            '
            'checkBox2
            '
            Me.checkBox2.Checked = True
            Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox2.DrawFocusRectangle = False
            Me.checkBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox2.ForeColor = System.Drawing.Color.DimGray
            Me.checkBox2.Location = New System.Drawing.Point(10, 29)
            Me.checkBox2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(161, 17)
            Me.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox2.TabIndex = 17
            Me.checkBox2.Text = "Add FilterBar to ChildTable"
            Me.checkBox2.ThemesEnabled = False
            '
            'checkBox1
            '
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.DrawFocusRectangle = False
            Me.checkBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.ForeColor = System.Drawing.Color.DimGray
            Me.checkBox1.Location = New System.Drawing.Point(10, 49)
            Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(167, 17)
            Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox1.TabIndex = 16
            Me.checkBox1.Text = "Add FilterBar to ParentTable"
            Me.checkBox1.ThemesEnabled = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1028, 503)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Localization Demo"
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.checkBox8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckStateChanged
            gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = checkBox1.Checked
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckStateChanged
            gridGroupingControl1.NestedTableGroupOptions.ShowFilterBar = checkBox2.Checked
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckStateChanged
            gridGroupingControl1.ChildGroupOptions.ShowFilterBar = checkBox3.Checked
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckStateChanged
            If checkBox4.Checked Then
                filter.WireGrid(gridGroupingControl1)
            Else
                filter.UnWireGrid(gridGroupingControl1)
            End If
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Loads the saved compareoperator states in dynamicfilter' button in respective columns
            If filter IsNot Nothing Then
                filter.LoadCompareOperator()
            End If
        End Sub

        Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            ' Saves the compareoperator states in dynamicfilter' button of respective columns
            If filter IsNot Nothing Then
                filter.SaveCompareOperator()
            End If
        End Sub

        Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox5.CheckStateChanged
            Dim loc As New Localizer()
            loc.getstring(checkBox5.Checked, checkBox8.Checked, checkBox6.Checked, checkBox7.Checked)
            LocalizationProvider.Provider = loc
            GridGroupingSettings()
        End Sub

        Private Sub checkBox8_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox8.CheckStateChanged
            Dim loc As New Localizer()
            loc.getstring(checkBox5.Checked, checkBox8.Checked, checkBox6.Checked, checkBox7.Checked)
            LocalizationProvider.Provider = loc
            GridGroupingSettings()
        End Sub

        Private Sub checkBox6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox6.CheckStateChanged
            Dim filter As New GridExcelFilter()

            Dim loc As New Localizer()
            loc.getstring(checkBox5.Checked, checkBox8.Checked, checkBox6.Checked, checkBox7.Checked)
            LocalizationProvider.Provider = loc
            If checkBox6.Checked Then
                'To wire grid with filter
                filter.WireGrid(Me.gridGroupingControl1)
            Else
                filter.UnWireGrid(Me.gridGroupingControl1)
            End If

            GridGroupingSettings()
        End Sub

        Private Sub checkBox7_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox7.CheckStateChanged
            Dim loc As New Localizer()
            loc.getstring(checkBox5.Checked, checkBox8.Checked, checkBox6.Checked, checkBox7.Checked)
            LocalizationProvider.Provider = loc
            Dim fieldChooserObj As New FieldChooser(Me.gridGroupingControl1)
            GridGroupingSettings()
        End Sub
	End Class



End Namespace

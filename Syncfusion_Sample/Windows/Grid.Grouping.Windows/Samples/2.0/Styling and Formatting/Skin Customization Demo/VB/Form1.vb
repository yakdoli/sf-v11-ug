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


Namespace EnhancedVisualStyleInGGC_Demo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		#Region "Private Members"
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private dataSet11 As EnhancedVisualStyleInGGCDemo_2005.DataSet1
		Private components As IContainer
		Private imageList1 As ImageList
		Private filter As New GridDynamicFilter()
		Private label5 As Label
		Private comboBox2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private comboBox3 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private panel1 As Panel
		Private panel2 As Panel
		Private comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private label8 As Label
		Private label7 As Label
		Private label6 As Label
		Private groupBox3 As GroupBox
		Private label9 As Label
		Private panel3 As Panel
		Private WithEvents pictureBox5 As PictureBox
		Private panel4 As Panel
		Private WithEvents pictureBox3 As PictureBox
		Private WithEvents pictureBox4 As PictureBox
		Private WithEvents pictureBox7 As PictureBox
		Private WithEvents pictureBox2 As PictureBox
		Private WithEvents pictureBox6 As PictureBox
		Private WithEvents pictureBox1 As PictureBox
		Private groupBox2 As GroupBox
		Private label10 As Label
		Private label11 As Label
		Private label12 As Label
		Private label13 As Label
		Public ReadOnly Shared connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
		#End Region

		Public Sub New()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

			InitializeComponent()
			Dim commandstring1 As String = "select * from Customers"
			Dim commandstring2 As String = "select * from Orders"
			Me.dataSet11 = New EnhancedVisualStyleInGGCDemo_2005.DataSet1()
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			Dim da1 As New SqlCeDataAdapter(commandstring1, connString)
			Dim da2 As New SqlCeDataAdapter(commandstring2, connString)
			da1.Fill(dataSet11, "Customers")
			da1.Fill(dataSet11, "Orders")

			Me.gridGroupingControl1.DataSource = Me.dataSet11.Customers
			Me.gridGroupingControl1.DataSource = Me.dataSet11.Tables("Customers")
			Me.gridGroupingControl1.AddGroupDropArea("Orders")

			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False


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
			Me.gridGroupingControl1.TableModel.EnableLegacyStyle = False
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			'Enable dynamic filter.
			filter.WireGrid(gridGroupingControl1)
		End Sub

		#Region "Form Handlers"
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.label5 = New System.Windows.Forms.Label()
			Me.comboBox2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.comboBox3 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.label8 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.label9 = New System.Windows.Forms.Label()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.pictureBox5 = New System.Windows.Forms.PictureBox()
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.pictureBox3 = New System.Windows.Forms.PictureBox()
			Me.pictureBox4 = New System.Windows.Forms.PictureBox()
			Me.pictureBox7 = New System.Windows.Forms.PictureBox()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.pictureBox6 = New System.Windows.Forms.PictureBox()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.label10 = New System.Windows.Forms.Label()
			Me.label11 = New System.Windows.Forms.Label()
			Me.label12 = New System.Windows.Forms.Label()
			Me.label13 = New System.Windows.Forms.Label()
			Me.panel2 = New System.Windows.Forms.Panel()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 7)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.ShowGroupDropArea = True
			Me.gridGroupingControl1.Size = New System.Drawing.Size(562, 530)
			Me.gridGroupingControl1.TabIndex = 0
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.VersionInfo = "4.201.0.37"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "filter_delete.png")
			Me.imageList1.Images.SetKeyName(1, "filter.png")
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.label5.ForeColor = System.Drawing.Color.DimGray
			Me.label5.Location = New System.Drawing.Point(33, 70)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(0, 13)
			Me.label5.TabIndex = 9
			Me.label5.Visible = False
			' 
			' comboBox2
			' 
			Me.comboBox2.BackColor = System.Drawing.Color.White
			Me.comboBox2.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.comboBox2.ForeColor = System.Drawing.Color.DimGray
			Me.comboBox2.Location = New System.Drawing.Point(23, 16)
			Me.comboBox2.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.comboBox2.Name = "comboBox2"
			Me.comboBox2.Size = New System.Drawing.Size(186, 21)
			Me.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.comboBox2.TabIndex = 13
			' 
			' comboBoxAdv1
			' 
			Me.comboBoxAdv1.BackColor = System.Drawing.Color.White
			Me.comboBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.comboBoxAdv1.ForeColor = System.Drawing.Color.DimGray
			Me.comboBoxAdv1.Location = New System.Drawing.Point(23, 112)
			Me.comboBoxAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.comboBoxAdv1.Name = "comboBoxAdv1"
			Me.comboBoxAdv1.Size = New System.Drawing.Size(186, 21)
			Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.comboBoxAdv1.TabIndex = 16
			' 
			' comboBox3
			' 
			Me.comboBox3.BackColor = System.Drawing.Color.White
			Me.comboBox3.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.comboBox3.ForeColor = System.Drawing.Color.DimGray
			Me.comboBox3.Location = New System.Drawing.Point(23, 65)
			Me.comboBox3.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.comboBox3.Name = "comboBox3"
			Me.comboBox3.Size = New System.Drawing.Size(186, 21)
			Me.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.comboBox3.TabIndex = 14
			' 
			' panel1
			' 
			Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel1.Controls.Add(Me.label8)
			Me.panel1.Controls.Add(Me.label7)
			Me.panel1.Controls.Add(Me.label6)
			Me.panel1.Controls.Add(Me.groupBox3)
			Me.panel1.Controls.Add(Me.groupBox2)
			Me.panel1.Location = New System.Drawing.Point(591, 7)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(274, 530)
			Me.panel1.TabIndex = 15
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Font = New System.Drawing.Font("Segoe UI", 8.25F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle)), System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label8.Location = New System.Drawing.Point(16, 355)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(243, 13)
			Me.label8.TabIndex = 23
			Me.label8.Text = """Grid.TableModel.EnableLegacyStyle = false"""
			' 
			' label7
			' 
			Me.label7.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label7.Location = New System.Drawing.Point(8, 255)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(261, 90)
			Me.label7.TabIndex = 22
			Me.label7.Text = Constants.vbCrLf & "The existing ColorStyles property is marked as deprecated, " & Constants.vbCrLf & Constants.vbCrLf & "So the colorsche" & "me used by ColorStyles will be applied to the Grid just by disabling its LegacyS" & "tyles."
			' 
			' label6
			' 
			Me.label6.Font = New System.Drawing.Font("Segoe UI", 8.25F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle)), System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label6.Location = New System.Drawing.Point(8, 214)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(261, 41)
			Me.label6.TabIndex = 21
			Me.label6.Text = "This sample features the GridGroupingControl with the new colorscheme used for th" & "e ColorStyles. "
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.label9)
			Me.groupBox3.Controls.Add(Me.panel3)
			Me.groupBox3.Controls.Add(Me.pictureBox5)
			Me.groupBox3.Controls.Add(Me.panel4)
			Me.groupBox3.Controls.Add(Me.pictureBox3)
			Me.groupBox3.Controls.Add(Me.pictureBox4)
			Me.groupBox3.Controls.Add(Me.pictureBox7)
			Me.groupBox3.Controls.Add(Me.pictureBox2)
			Me.groupBox3.Controls.Add(Me.pictureBox6)
			Me.groupBox3.Controls.Add(Me.pictureBox1)
			Me.groupBox3.Location = New System.Drawing.Point(7, 3)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(259, 86)
			Me.groupBox3.TabIndex = 20
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Styles"
			' 
			' label9
			' 
			Me.label9.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label9.Location = New System.Drawing.Point(59, 69)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(176, 13)
			Me.label9.TabIndex = 13
			Me.label9.Text = "GridVisualStyles.Metro"
			Me.label9.Visible = False
			' 
			' panel3
			' 
			Me.panel3.BackColor = System.Drawing.Color.DimGray
			Me.panel3.Location = New System.Drawing.Point(190, 60)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(26, 4)
			Me.panel3.TabIndex = 12
			' 
			' pictureBox5
			' 
			Me.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox5.Image = (CType(resources.GetObject("pictureBox5.Image"), System.Drawing.Image))
			Me.pictureBox5.Location = New System.Drawing.Point(151, 24)
			Me.pictureBox5.Name = "pictureBox5"
			Me.pictureBox5.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox5.TabIndex = 4
			Me.pictureBox5.TabStop = False
'			Me.pictureBox5.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox5.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox5.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' panel4
			' 
			Me.panel4.BackColor = System.Drawing.Color.Orange
			Me.panel4.Location = New System.Drawing.Point(13, 60)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(26, 4)
			Me.panel4.TabIndex = 7
			Me.panel4.Visible = False
			' 
			' pictureBox3
			' 
			Me.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox3.Image = (CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image))
			Me.pictureBox3.Location = New System.Drawing.Point(81, 24)
			Me.pictureBox3.Name = "pictureBox3"
			Me.pictureBox3.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox3.TabIndex = 2
			Me.pictureBox3.TabStop = False
'			Me.pictureBox3.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox3.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox3.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' pictureBox4
			' 
			Me.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox4.Image = (CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image))
			Me.pictureBox4.Location = New System.Drawing.Point(116, 24)
			Me.pictureBox4.Name = "pictureBox4"
			Me.pictureBox4.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox4.TabIndex = 3
			Me.pictureBox4.TabStop = False
'			Me.pictureBox4.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox4.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox4.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' pictureBox7
			' 
			Me.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox7.Image = (CType(resources.GetObject("pictureBox7.Image"), System.Drawing.Image))
			Me.pictureBox7.Location = New System.Drawing.Point(221, 24)
			Me.pictureBox7.Name = "pictureBox7"
			Me.pictureBox7.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox7.TabIndex = 4
			Me.pictureBox7.TabStop = False
'			Me.pictureBox7.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox7.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox7.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' pictureBox2
			' 
			Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox2.Image = (CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image))
			Me.pictureBox2.Location = New System.Drawing.Point(46, 24)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox2.TabIndex = 1
			Me.pictureBox2.TabStop = False
'			Me.pictureBox2.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox2.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox2.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' pictureBox6
			' 
			Me.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox6.Image = (CType(resources.GetObject("pictureBox6.Image"), System.Drawing.Image))
			Me.pictureBox6.Location = New System.Drawing.Point(186, 24)
			Me.pictureBox6.Name = "pictureBox6"
			Me.pictureBox6.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox6.TabIndex = 5
			Me.pictureBox6.TabStop = False
'			Me.pictureBox6.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox6.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox6.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox1.Image = (CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image))
			Me.pictureBox1.Location = New System.Drawing.Point(11, 24)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
'			Me.pictureBox1.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox1.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox1.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.label10)
			Me.groupBox2.Controls.Add(Me.label11)
			Me.groupBox2.Controls.Add(Me.label12)
			Me.groupBox2.Controls.Add(Me.label13)
			Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox2.ForeColor = System.Drawing.Color.Black
			Me.groupBox2.Location = New System.Drawing.Point(7, 103)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(259, 89)
			Me.groupBox2.TabIndex = 19
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Applied Changes"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
			Me.label10.Location = New System.Drawing.Point(133, 32)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(91, 15)
			Me.label10.TabIndex = 10
			Me.label10.Text = "Office2010Black"
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.ForeColor = System.Drawing.Color.DimGray
			Me.label11.Location = New System.Drawing.Point(23, 32)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(101, 15)
			Me.label11.TabIndex = 9
			Me.label11.Text = "Active Style          :"
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
			Me.label12.Location = New System.Drawing.Point(132, 56)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(91, 15)
			Me.label12.TabIndex = 8
			Me.label12.Text = "Office2010Black"
			' 
			' label13
			' 
			Me.label13.AutoSize = True
			Me.label13.ForeColor = System.Drawing.Color.DimGray
			Me.label13.Location = New System.Drawing.Point(23, 56)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(100, 15)
			Me.label13.TabIndex = 7
			Me.label13.Text = "Active Scrollbars :"
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.DimGray
			Me.panel2.Location = New System.Drawing.Point(581, 19)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(1, 504)
			Me.panel2.TabIndex = 16
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(877, 549)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.gridGroupingControl1)
			Me.Controls.Add(Me.label5)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Skin Customization Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.Form1_FormClosing)
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.groupBox3.ResumeLayout(False)
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		#End Region

		#Region "Event Hanlders"
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

		Private Sub pictureBox1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureBox5.MouseClick, pictureBox3.MouseClick, pictureBox4.MouseClick, pictureBox7.MouseClick, pictureBox2.MouseClick, pictureBox6.MouseClick, pictureBox1.MouseClick

			Dim pBox As PictureBox = CType(sender, PictureBox)

			Select Case pBox.Name
				Case "pictureBox1"
					Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
				Case "pictureBox2"
					Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Blue
					gridGroupingControl1.Office2007ScrollBars = True
					gridGroupingControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue
				Case "pictureBox3"
					Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Black
					gridGroupingControl1.Office2007ScrollBars = True
					gridGroupingControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black
				Case "pictureBox4"
					Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Silver
					gridGroupingControl1.Office2007ScrollBars = True
					gridGroupingControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver
				Case "pictureBox5"
					Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2010Blue
					gridGroupingControl1.Office2007ScrollBars = False
					gridGroupingControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Blue
				Case "pictureBox6"
					Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2010Black
					gridGroupingControl1.Office2007ScrollBars = False
					gridGroupingControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black
				Case "pictureBox7"
					Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2010Silver
					gridGroupingControl1.Office2007ScrollBars = False
					gridGroupingControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Silver

			End Select

			label10.Text = gridGroupingControl1.GridVisualStyles.ToString()
			label12.Text = label10.Text

			panel3.Location = New Point(pBox.Location.X + 3, panel4.Location.Y)
			panel3.Visible = True
		End Sub

		Private Sub pictureBox1_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox5.MouseHover, pictureBox3.MouseHover, pictureBox4.MouseHover, pictureBox7.MouseHover, pictureBox2.MouseHover, pictureBox6.MouseHover, pictureBox1.MouseHover
			Me.SuspendLayout()
			Dim pBox As PictureBox = CType(sender, PictureBox)
			panel4.Location = New Point(pBox.Location.X + 3, panel4.Location.Y)
			panel4.Visible = True
			WriteStyles(pBox)
			Me.ResumeLayout(True)
		End Sub

		Private Sub pictureBox1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox5.MouseLeave, pictureBox3.MouseLeave, pictureBox4.MouseLeave, pictureBox7.MouseLeave, pictureBox2.MouseLeave, pictureBox6.MouseLeave, pictureBox1.MouseLeave
			panel4.Visible = False
			label9.Visible = False
		End Sub

		Private Sub WriteStyles(ByVal pBox As PictureBox)
			Select Case pBox.Name
				Case "pictureBox1"
					label9.Text = "GridVisualStyles : Metro"
				Case "pictureBox2"
					label9.Text = "GridVisualStyles : Office2007Blue"
				Case "pictureBox3"
					label9.Text = "GridVisualStyles : Office2007Black"
				Case "pictureBox4"
					label9.Text = "GridVisualStyles : Office2007Silver"
				Case "pictureBox5"
					label9.Text = "GridVisualStyles : Office2010Blue"
				Case "pictureBox6"
					label9.Text = "GridVisualStyles : Office2010Black"
				Case "pictureBox7"
					label9.Text = "GridVisualStyles : Office2010Silver"
			End Select
			label9.Visible = True
		End Sub
		#End Region

	End Class
End Namespace

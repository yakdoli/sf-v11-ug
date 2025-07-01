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

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO
Imports Syncfusion.Windows.Forms

Namespace NestedTableGroupOptions
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		#Region "Private Members"
		Private panel1 As System.Windows.Forms.Panel
		Private panel2 As System.Windows.Forms.Panel
		Private panel3 As System.Windows.Forms.Panel
		Private panel4 As System.Windows.Forms.Panel
		Private label1 As System.Windows.Forms.Label
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private dataSet11 As NestedTableGroupOptions.DataSet1
        Private WithEvents ShowCaptionPlus As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents showCaption As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents beforeDetails As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents captionText As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents afterDetails As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private lblProperty As System.Windows.Forms.Label
		Private lblProp As System.Windows.Forms.Label
		Private components As IContainer
		Private tipDesc As ToolTip
		Public ReadOnly Shared connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
#End Region

		Public Sub New()
'			#Region "Grid Settings"
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI"
			Dim commandstring1 As String = "select * from Customers"
			Dim commandstring2 As String = "select * from Orders"

			Dim da1 As New SqlCeDataAdapter(commandstring1, connString)
			Dim da2 As New SqlCeDataAdapter(commandstring2, connString)
			Try
				da1.Fill(dataSet11, "Customers")
				da2.Fill(dataSet11, "Orders")
			Catch ex As SqlException
				ShowErrorMessage(ex)
			End Try

			oldStyle = Me.gridGroupingControl1.NestedTableGroupOptions.CaptionText
			Me.gridGroupingControl1.Table.Records(2).IsExpanded = True
			Me.gridGroupingControl1.Table.Records(1).IsExpanded = True
			Me.SetStyle(ControlStyles.UserPaint, True)
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
'			#End Region
		End Sub
		#Region "Icon and Data Files"
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

		#End Region

		#Region "Form Settings"
		Private Shared Sub ShowErrorMessage(ByVal ex As SqlException)
			If ex.Number = 11001 Then
				MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
			If ex.Number = 208 Then
				MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
			If ex.Number = 156 OrElse ex.Number = 102 Then
				MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If

		End Sub

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
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label2 = New System.Windows.Forms.Label
            Me.afterDetails = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.beforeDetails = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.captionText = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.showCaption = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.ShowCaptionPlus = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.dataSet11 = New NestedTableGroupOptions.DataSet1
            Me.panel3 = New System.Windows.Forms.Panel
            Me.lblProp = New System.Windows.Forms.Label
            Me.lblProperty = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.panel4 = New System.Windows.Forms.Panel
            Me.tipDesc = New System.Windows.Forms.ToolTip(Me.components)
            Me.panel1.SuspendLayout()
            CType(Me.afterDetails, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.beforeDetails, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.captionText, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.showCaption, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ShowCaptionPlus, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            Me.panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.afterDetails)
            Me.panel1.Controls.Add(Me.beforeDetails)
            Me.panel1.Controls.Add(Me.captionText)
            Me.panel1.Controls.Add(Me.showCaption)
            Me.panel1.Controls.Add(Me.ShowCaptionPlus)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.ForeColor = System.Drawing.Color.DimGray
            Me.panel1.Location = New System.Drawing.Point(507, 8)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(200, 285)
            Me.panel1.TabIndex = 0
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(24, 152)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(152, 23)
            Me.label2.TabIndex = 15
            Me.label2.Text = "Add New Record Field"
            '
            'afterDetails
            '
            Me.afterDetails.DrawFocusRectangle = False
            Me.afterDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.afterDetails.Location = New System.Drawing.Point(40, 210)
            Me.afterDetails.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.afterDetails.Name = "afterDetails"
            Me.afterDetails.Size = New System.Drawing.Size(104, 24)
            Me.afterDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.afterDetails.TabIndex = 14
            Me.afterDetails.Text = "After Details"
            Me.afterDetails.ThemesEnabled = False
            '
            'beforeDetails
            '
            Me.beforeDetails.Checked = True
            Me.beforeDetails.CheckState = System.Windows.Forms.CheckState.Checked
            Me.beforeDetails.DrawFocusRectangle = False
            Me.beforeDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.beforeDetails.Location = New System.Drawing.Point(40, 178)
            Me.beforeDetails.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.beforeDetails.Name = "beforeDetails"
            Me.beforeDetails.Size = New System.Drawing.Size(104, 24)
            Me.beforeDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.beforeDetails.TabIndex = 13
            Me.beforeDetails.Text = "Before Details"
            Me.beforeDetails.ThemesEnabled = False
            '
            'captionText
            '
            Me.captionText.DrawFocusRectangle = False
            Me.captionText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.captionText.Location = New System.Drawing.Point(40, 104)
            Me.captionText.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.captionText.Name = "captionText"
            Me.captionText.Size = New System.Drawing.Size(136, 32)
            Me.captionText.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.captionText.TabIndex = 12
            Me.captionText.Text = "Modify Caption Text"
            Me.captionText.ThemesEnabled = False
            '
            'showCaption
            '
            Me.showCaption.Checked = True
            Me.showCaption.CheckState = System.Windows.Forms.CheckState.Checked
            Me.showCaption.DrawFocusRectangle = False
            Me.showCaption.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.showCaption.Location = New System.Drawing.Point(40, 72)
            Me.showCaption.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.showCaption.Name = "showCaption"
            Me.showCaption.Size = New System.Drawing.Size(136, 24)
            Me.showCaption.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.showCaption.TabIndex = 11
            Me.showCaption.Text = "Show Caption"
            Me.showCaption.ThemesEnabled = False
            '
            'ShowCaptionPlus
            '
            Me.ShowCaptionPlus.Checked = True
            Me.ShowCaptionPlus.CheckState = System.Windows.Forms.CheckState.Checked
            Me.ShowCaptionPlus.DrawFocusRectangle = False
            Me.ShowCaptionPlus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ShowCaptionPlus.Location = New System.Drawing.Point(40, 40)
            Me.ShowCaptionPlus.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ShowCaptionPlus.Name = "ShowCaptionPlus"
            Me.ShowCaptionPlus.Size = New System.Drawing.Size(136, 24)
            Me.ShowCaptionPlus.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.ShowCaptionPlus.TabIndex = 10
            Me.ShowCaptionPlus.Text = "Show Caption +/-"
            Me.ShowCaptionPlus.ThemesEnabled = False
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(16, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(176, 23)
            Me.label1.TabIndex = 9
            Me.label1.Text = "Nested Table Group Options"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.gridGroupingControl1)
            Me.panel2.Location = New System.Drawing.Point(10, 9)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(490, 284)
            Me.panel2.TabIndex = 2
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.DataSource = Me.dataSet11.Customers
            Me.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.Size = New System.Drawing.Size(490, 284)
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
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.VersionInfo = "4.201.0.37"
            '
            'dataSet11
            '
            Me.dataSet11.DataSetName = "DataSet1"
            Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'panel3
            '
            Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel3.Controls.Add(Me.lblProp)
            Me.panel3.Controls.Add(Me.lblProperty)
            Me.panel3.Controls.Add(Me.label4)
            Me.panel3.Controls.Add(Me.label3)
            Me.panel3.ForeColor = System.Drawing.Color.DimGray
            Me.panel3.Location = New System.Drawing.Point(10, 299)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(697, 128)
            Me.panel3.TabIndex = 4
            '
            'lblProp
            '
            Me.lblProp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProp.Location = New System.Drawing.Point(236, 73)
            Me.lblProp.Name = "lblProp"
            Me.lblProp.Size = New System.Drawing.Size(436, 40)
            Me.lblProp.TabIndex = 3
            '
            'lblProperty
            '
            Me.lblProperty.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProperty.Location = New System.Drawing.Point(236, 16)
            Me.lblProperty.Name = "lblProperty"
            Me.lblProperty.Size = New System.Drawing.Size(436, 32)
            Me.lblProperty.TabIndex = 2
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(16, 73)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(232, 23)
            Me.label4.TabIndex = 1
            Me.label4.Text = "Changed Property :"
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(16, 16)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(232, 32)
            Me.label3.TabIndex = 0
            Me.label3.Text = "Changed NestedTableGroupOptions Property :"
            '
            'panel4
            '
            Me.panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel4.BackColor = System.Drawing.Color.White
            Me.panel4.Controls.Add(Me.panel2)
            Me.panel4.Controls.Add(Me.panel3)
            Me.panel4.Controls.Add(Me.panel1)
            Me.panel4.Location = New System.Drawing.Point(0, 6)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(716, 435)
            Me.panel4.TabIndex = 6
            '
            'tipDesc
            '
            Me.tipDesc.BackColor = System.Drawing.Color.White
            Me.tipDesc.ForeColor = System.Drawing.Color.Black
            Me.tipDesc.IsBalloon = True
            Me.tipDesc.ShowAlways = True
            Me.tipDesc.UseFading = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(718, 442)
            Me.Controls.Add(Me.panel4)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(730, 505)
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Nested-Table Group Options Demo"
            Me.panel1.ResumeLayout(False)
            CType(Me.afterDetails, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.beforeDetails, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.captionText, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.showCaption, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ShowCaptionPlus, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel4.ResumeLayout(False)
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
		#End Region

#Region "Event Handlers"
        Private Sub ShowCaptionPlus_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowCaptionPlus.CheckStateChanged
            Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus = Not Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus
            Me.lblProperty.Text = ""
            Me.lblProperty.Text = "gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus = " & Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus
            Me.gridGroupingControl1.Refresh()
        End Sub

        Private Sub showCaption_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showCaption.CheckStateChanged
            Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaption = Not Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaption
            Me.lblProperty.Text = ""
            Me.lblProperty.Text = "gridGroupingControl1.NestedTableGroupOptions.ShowCaption = " & Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaption
            Me.gridGroupingControl1.Refresh()
        End Sub
        Private oldStyle As String = ""
        Private Sub captionText_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles captionText.CheckStateChanged
            Me.lblProperty.Text = ""
            If Me.captionText.Checked Then
                Me.gridGroupingControl1.NestedTableGroupOptions.CaptionText = "There are {RecordCount} items under {CategoryName} : {Category}"
                Me.lblProperty.Text = "gridGroupingControl1.NestedTableGroupOptions.CaptionText = ""There are {RecordCount} items under {CategoryName} : {Category}"""
            ElseIf Not Me.captionText.Checked Then
                Me.gridGroupingControl1.NestedTableGroupOptions.CaptionText = oldStyle
                Me.lblProperty.Text = "gridGroupingControl1.NestedTableGroupOptions.CaptionText = """ & oldStyle & """"
            End If
        End Sub

        Private Sub beforeDetails_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beforeDetails.CheckStateChanged
            Me.lblProp.Text = ""
            Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = Not Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails
            Me.lblProp.Text = "gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = " & Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails
        End Sub

        Private Sub afterDetails_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles afterDetails.CheckStateChanged
            Me.lblProp.Text = ""
            Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails = Not Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails
            Me.lblProp.Text = "gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails = " & Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails
        End Sub
#End Region
    End Class
End Namespace

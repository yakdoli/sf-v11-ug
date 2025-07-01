Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Drawing
Imports Syncfusion.Styles
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.GridHelperClasses.Zoom
Imports Syncfusion.Windows.Forms

Namespace ZoomGrid
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		#Region "Private Members"
		Private WithEvents trackBar1 As TrackBar
        Private WithEvents comboBox1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Private WithEvents checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private groupBox1 As GroupBox
		Private groupBox3 As GroupBox
		Private groupBox2 As GroupBox
		Private label4 As Label
		Private label3 As Label
		Private components As IContainer
		Private panel2 As Panel
		Private tipDesc As ToolTip
		Private zoom As ZoomGroupingGrid
		#End Region

		Public Sub New()
'			#Region "Grid Settings"
			InitializeComponent()

			Dim parentTable As DataTable = GetTable()
			Dim childTable As DataTable = GetChildTable()
			Dim grandChildTable As DataTable = GetGrandChildTable()

			Dim parentToChildRelationDescriptor As New GridRelationDescriptor()
			parentToChildRelationDescriptor.ChildTableName = "MyChildTable"
			parentToChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails
			parentToChildRelationDescriptor.RelationKeys.Add("parentID", "ParentID")

			gridGroupingControl1.TableDescriptor.Relations.Add(parentToChildRelationDescriptor)

			Dim childToGrandChildRelationDescriptor As New GridRelationDescriptor()
			childToGrandChildRelationDescriptor.ChildTableName = "MyGrandChildTable"
			childToGrandChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails
			childToGrandChildRelationDescriptor.RelationKeys.Add("childID", "ChildID")

			parentToChildRelationDescriptor.ChildTableDescriptor.Relations.Add(childToGrandChildRelationDescriptor)

			Me.gridGroupingControl1.Engine.SourceListSet.Add("MyParentTable", parentTable)
			Me.gridGroupingControl1.Engine.SourceListSet.Add("MyChildTable", childTable)
			Me.gridGroupingControl1.Engine.SourceListSet.Add("MyGrandChildTable", grandChildTable)
			Me.gridGroupingControl1.DataSource = GetTable()
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
			Me.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle


			Me.SetStyle(ControlStyles.UserPaint, True)
            Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
            Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch
            End Try
'#End Region

'			#Region "Zooming"
			zoom = New ZoomGroupingGrid(Me.gridGroupingControl1)
			ZoomGroupingGrid.zoomCell = True
'			#End Region
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
		#Region "Form Settings"
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
            Me.trackBar1 = New System.Windows.Forms.TrackBar
            Me.comboBox1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.groupBox3 = New System.Windows.Forms.GroupBox
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.label4 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.tipDesc = New System.Windows.Forms.ToolTip(Me.components)
            CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'trackBar1
            '
            Me.trackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.trackBar1.AutoSize = False
            Me.trackBar1.BackColor = System.Drawing.Color.White
            Me.trackBar1.Location = New System.Drawing.Point(106, 93)
            Me.trackBar1.Maximum = 250
            Me.trackBar1.Minimum = 20
            Me.trackBar1.Name = "trackBar1"
            Me.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.trackBar1.Size = New System.Drawing.Size(117, 28)
            Me.trackBar1.TabIndex = 12
            Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None
            Me.trackBar1.Value = 100
            '
            'comboBox1
            '
            Me.comboBox1.BackColor = System.Drawing.Color.White
            Me.comboBox1.Items.AddRange(New Object() {"50", "75", "100", "125"})
            Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "50"))
            Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "75"))
            Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "100"))
            Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "125"))
            Me.comboBox1.Location = New System.Drawing.Point(113, 37)
            Me.comboBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(104, 21)
            Me.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
            Me.comboBox1.TabIndex = 14
            '
            'checkBox1
            '
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.DrawFocusRectangle = False
            Me.checkBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.checkBox1.ForeColor = System.Drawing.Color.Black
            Me.checkBox1.Location = New System.Drawing.Point(73, 40)
            Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(84, 24)
            Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox1.TabIndex = 11
            Me.checkBox1.Text = "Zoom Cell"
            Me.checkBox1.ThemesEnabled = False
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridGroupingControl1.ApplyVisualStyles = True
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gridGroupingControl1.Location = New System.Drawing.Point(20, 20)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.Size = New System.Drawing.Size(299, 330)
            Me.gridGroupingControl1.TabIndex = 16
            Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.None
            Me.gridGroupingControl1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
            '
            'groupBox1
            '
            Me.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.groupBox1.Controls.Add(Me.groupBox3)
            Me.groupBox1.Controls.Add(Me.groupBox2)
            Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(340, 20)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(243, 330)
            Me.groupBox1.TabIndex = 17
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Zooming Options"
            '
            'groupBox3
            '
            Me.groupBox3.Controls.Add(Me.checkBox1)
            Me.groupBox3.Location = New System.Drawing.Point(9, 213)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(223, 92)
            Me.groupBox3.TabIndex = 1
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Cell Level"
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.label4)
            Me.groupBox2.Controls.Add(Me.label3)
            Me.groupBox2.Controls.Add(Me.comboBox1)
            Me.groupBox2.Controls.Add(Me.trackBar1)
            Me.groupBox2.Location = New System.Drawing.Point(9, 39)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(226, 136)
            Me.groupBox2.TabIndex = 0
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Grid Level"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(12, 93)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(92, 13)
            Me.label4.TabIndex = 16
            Me.label4.Text = "Zoom Frequency"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(12, 40)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(64, 13)
            Me.label3.TabIndex = 15
            Me.label3.Text = "Zoom Level"
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.White
            Me.panel2.Controls.Add(Me.groupBox1)
            Me.panel2.Controls.Add(Me.gridGroupingControl1)
            Me.panel2.Location = New System.Drawing.Point(0, 4)
            Me.panel2.Margin = New System.Windows.Forms.Padding(0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(600, 370)
            Me.panel2.TabIndex = 19
            '
            'tipDesc
            '
            Me.tipDesc.BackColor = System.Drawing.Color.White
            Me.tipDesc.IsBalloon = True
            Me.tipDesc.OwnerDraw = True
            Me.tipDesc.ShowAlways = True
            Me.tipDesc.StripAmpersands = True
            Me.tipDesc.UseFading = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.SystemColors.Window
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(601, 368)
            Me.Controls.Add(Me.panel2)
            Me.DropShadow = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Zooming Demo"
            CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox3.ResumeLayout(False)
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.panel2.ResumeLayout(False)
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

		#Region "DataTable"
		Private numberParentRows As Integer = 5
		Private numberChildRows As Integer = 20
		Private numberGrandChildRows As Integer = 50
		Private Function GetTable() As DataTable
			Dim dt As New DataTable("ParentTable")


			dt.Columns.Add(New DataColumn("parentID"))
			dt.Columns.Add(New DataColumn("ParentName"))
			dt.Columns.Add(New DataColumn("ParentDec"))
			dt.Columns.Add(New DataColumn("ParentRel"))
			For i As Integer = 0 To numberParentRows - 1
				Dim dr As DataRow = dt.NewRow()
				dr(0) = i '.ToString();
				dr(1) = String.Format("parentName{0}", i)
				dr(2) = String.Format("parentName{0}", i)
				dr(3) = String.Format("parentName{0}", i)
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

		#Region "Zooming Handlers"
        Private Sub checkBox1_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox1.CheckStateChanged
            ZoomGroupingGrid.zoomCell = Me.checkBox1.Checked
            If Me.checkBox1.Checked Then
                Me.trackBar1.Value = 100
            End If
        End Sub
        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
            If comboBox1.SelectedItem IsNot Nothing Then
                zoom.zoomGrid(Me.comboBox1.SelectedItem.ToString())
                Me.checkBox1.Checked = False
            End If
        End Sub
        Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar1.ValueChanged
            If zoom IsNot Nothing Then

                zoom.zoomGrid(Me.trackBar1.Value.ToString())
                Me.comboBox1.Text = Me.trackBar1.Value.ToString()
                Me.checkBox1.Checked = False
            End If

        End Sub
		#End Region
    End Class
End Namespace

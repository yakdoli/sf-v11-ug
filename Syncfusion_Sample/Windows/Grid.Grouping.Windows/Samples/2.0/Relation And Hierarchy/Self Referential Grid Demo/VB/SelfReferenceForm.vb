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
Imports System.Data.SqlServerCe
Imports Syncfusion.Windows.Forms.Grid
Imports TreeGridHelper
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.MetroForm
Imports System.Data.OleDb

Namespace WindowsApplication1
	''' <summary>
	''' Summary description for SelfReferenceForm.
	''' </summary>
    Public Class SelfReferenceForm : Inherits Syncfusion.Windows.Forms.MetroForm
        Private gridGroupingControl1 As GridGroupingControl
        Private colorDialog1 As ColorDialog
        Private components As System.ComponentModel.IContainer
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private WithEvents GridGroupingControl2 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents checkBox2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents checkBox3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents panel1 As System.Windows.Forms.Panel
        Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents button2 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents radioButton1 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Private WithEvents radioButton2 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Public Shared ReadOnly connString As String = "Data Source=" & FindFile("Department.sdf")

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Try
                Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico

            Catch ex As Exception

            End Try
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro



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
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
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
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog
            Me.GridGroupingControl2 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.checkBox2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.panel1 = New System.Windows.Forms.Panel
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.radioButton1 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButton2 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridGroupingControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            CType(Me.radioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.Location = New System.Drawing.Point(7, 12)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.Size = New System.Drawing.Size(555, 370)
            Me.gridGroupingControl1.TabIndex = 10
            Me.gridGroupingControl1.TableOptions.AllowDragColumns = False
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.VersionInfo = "6.102.0.34"
            '
            'GridGroupingControl2
            '
            Me.GridGroupingControl2.BackColor = System.Drawing.SystemColors.Window
            Me.GridGroupingControl2.Location = New System.Drawing.Point(91, 11)
            Me.GridGroupingControl2.Name = "GridGroupingControl2"
            Me.GridGroupingControl2.Size = New System.Drawing.Size(555, 370)
            Me.GridGroupingControl2.TabIndex = 11
            Me.GridGroupingControl2.TableOptions.AllowDragColumns = False
            Me.GridGroupingControl2.Text = "GridGroupingControl2"
            Me.GridGroupingControl2.VersionInfo = "6.102.0.34"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.checkBox2)
            Me.groupBox1.Controls.Add(Me.checkBox3)
            Me.groupBox1.Controls.Add(Me.checkBox1)
            Me.groupBox1.Location = New System.Drawing.Point(15, 22)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(153, 145)
            Me.groupBox1.TabIndex = 23
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "TreeCell Settings"
            '
            'checkBox2
            '
            Me.checkBox2.DrawFocusRectangle = False
            Me.checkBox2.Location = New System.Drawing.Point(8, 39)
            Me.checkBox2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(144, 19)
            Me.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox2.TabIndex = 14
            Me.checkBox2.Text = "Show TreeCell Borders"
            Me.checkBox2.ThemesEnabled = False
            '
            'checkBox3
            '
            Me.checkBox3.DrawFocusRectangle = False
            Me.checkBox3.Location = New System.Drawing.Point(8, 66)
            Me.checkBox3.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(107, 19)
            Me.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox3.TabIndex = 15
            Me.checkBox3.Text = "Hide Tree Lines"
            Me.checkBox3.ThemesEnabled = False
            '
            'checkBox1
            '
            Me.checkBox1.DrawFocusRectangle = False
            Me.checkBox1.Location = New System.Drawing.Point(8, 94)
            Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(107, 22)
            Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox1.TabIndex = 13
            Me.checkBox1.Text = "Color Levels..."
            Me.checkBox1.ThemesEnabled = False
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.groupBox2)
            Me.panel1.Controls.Add(Me.groupBox1)
            Me.panel1.Location = New System.Drawing.Point(564, 10)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(173, 372)
            Me.panel1.TabIndex = 24
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.button2)
            Me.groupBox2.Controls.Add(Me.radioButton1)
            Me.groupBox2.Controls.Add(Me.radioButton2)
            Me.groupBox2.Location = New System.Drawing.Point(15, 189)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(153, 156)
            Me.groupBox2.TabIndex = 23
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Control Settings"
            '
            'button2
            '
            Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.ForeColor = System.Drawing.Color.White
            Me.button2.Location = New System.Drawing.Point(11, 107)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(126, 27)
            Me.button2.TabIndex = 22
            Me.button2.Text = "Clear Sort"
            Me.button2.UseVisualStyle = True
            Me.button2.UseVisualStyleBackColor = True
            '
            'radioButton1
            '
            Me.radioButton1.DrawFocusRectangle = False
            Me.radioButton1.Location = New System.Drawing.Point(12, 33)
            Me.radioButton1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(95, 24)
            Me.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButton1.TabIndex = 19
            Me.radioButton1.Text = "Expand All"
            Me.radioButton1.ThemesEnabled = False
            '
            'radioButton2
            '
            Me.radioButton2.DrawFocusRectangle = False
            Me.radioButton2.Location = New System.Drawing.Point(12, 63)
            Me.radioButton2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(95, 29)
            Me.radioButton2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButton2.TabIndex = 20
            Me.radioButton2.Text = "Collapse All"
            Me.radioButton2.ThemesEnabled = False
            '
            'SelfReferenceForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(736, 392)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "SelfReferenceForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Self Referential Grid Demo"
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridGroupingControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            CType(Me.radioButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButton2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region


        Private treeGrid As TreeGridHelper.TreeGridHelper
        Private accessor As SelfReferenceDataSourceAccessor


        Private Sub SelfReferenceForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Dim commandstring As String = "select DEPTNO,ID,MGR,DEPTNAME,LOCATION,ADMRDEBT from DEPT"

            Dim ds As DataSet = New DataSet()

            Dim da As SqlCeDataAdapter = New SqlCeDataAdapter(commandstring, connString)
            Try
                da.Fill(ds, "DEPT")
            Catch ex As SqlClient.SqlException
                ShowErrorMessage(ex)
            End Try
            Dim flatTable As DataTable = ds.Tables(0)

            'set the datasource as a flat datatable
            Me.gridGroupingControl1.DataSource = flatTable

            'make it so cell does not become active when clicked
            Me.gridGroupingControl1.TableModel.Options.ActivateCurrentCellBehavior = GridCellActivateAction.None

            'set the row selection mode
            Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended
            Me.gridGroupingControl1.TableOptions.ListBoxSelectionCurrentCellOptions = GridListBoxSelectionCurrentCellOptions.HideCurrentCell


            'hide the row headers
            Me.gridGroupingControl1.TableOptions.ShowRowHeader = False

            Me.gridGroupingControl1.TableDescriptor.VisibleColumns.RemoveAt(2)
            Me.gridGroupingControl1.TableDescriptor.Columns("ID").HeaderText = "DEPT. ID"
            Me.gridGroupingControl1.TableDescriptor.Columns("ADMRDEBT").HeaderText = "HEADER DEPT. ID"
            Me.gridGroupingControl1.TableDescriptor.Columns("DEPTNO").HeaderText = "DEPT CODE"
            Me.gridGroupingControl1.TableDescriptor.Columns("DEPTNAME").HeaderText = "DEPT. NAME"


            'create the treeGridHelper and wire the grid to it...
            Me.treeGrid = New TreeGridHelper.TreeGridHelper()


            Me.treeGrid.ColorCodeSiblings = False 'dont show colors

            Me.accessor = Me.treeGrid.WireSelfReferenceGrid(Me.gridGroupingControl1, flatTable, "ADMRDEBT", "ID", "DEPTNO")

            'allow editing type properties
            'treeGrid.EditingEnabled = true;
            'this.gridGroupingControl1.TableOptions.ListBoxSelectionCurrentCellOptions = GridListBoxSelectionCurrentCellOptions.None;
            'this.gridGroupingControl1.TableModel.Options.ActivateCurrentCellBehavior = GridCellActivateAction.ClickOnCell;

            treeGrid.ExpandAll()
            radioButton1.Select()
        End Sub
        Private Shared Function FindFile(ByVal fileName As String) As String
            ' Check both in parent folder and Parent\Data folders.
            Dim dataFileName As String = "Common\Data\" & fileName
            For n As Integer = 0 To 11
                If System.IO.File.Exists(fileName) Then
                    Return New IO.FileInfo(fileName).FullName
                End If
                If System.IO.File.Exists(dataFileName) Then
                    Return New IO.FileInfo(dataFileName).FullName
                End If
                fileName = "..\" & fileName
                dataFileName = "..\" & dataFileName
            Next n

            Return fileName
        End Function
        Private Shared Sub ShowErrorMessage(ByVal ex As SqlClient.SqlException)
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

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton1.Click
            treeGrid.ExpandAll()
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton2.Click
            treeGrid.CollapseAll()
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckStateChanged
            Me.treeGrid.ColorCodeSiblings = checkBox1.Checked
            Me.treeGrid.ColorCodeList = New Color() {Color.FromArgb(152, 192, 244), Color.FromArgb(194, 220, 255), Color.FromArgb(216, 232, 255), Color.FromArgb(237, 245, 255)}
            gridGroupingControl1.Refresh()
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckStateChanged
            Me.treeGrid.ShowCellBorderInTreeCell = checkBox2.Checked
            gridGroupingControl1.Refresh()
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckStateChanged
            Me.treeGrid.ShowTreeLines = Not checkBox3.Checked
            gridGroupingControl1.Refresh()
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            treeGrid.Sort("") 'clear the sort...
        End Sub

       
    End Class
End Namespace

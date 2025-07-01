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
Imports System.Data.SqlClient

Imports System.Data.SqlServerCe
Imports System.IO
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports System.Collections.Specialized

Namespace SortingMethods_2003
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits MetroForm
        Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
        Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents button2 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents button3 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents button4 As Syncfusion.Windows.Forms.ButtonAdv
        Private components As IContainer
        Private dataset11 As SortingMethods_2003.Dataset1
        Private panel1 As Panel
        Private WithEvents checkBoxAdv1 As CheckBoxAdv
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Public Shared ReadOnly connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch
            End Try
            Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
            Dim ar As New StringCollection()
            ar.Add("Left Align")
            ar.Add("Center Align")
            ar.Add("Right Align")
            comboBoxAdv1.DataSource = ar
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
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.dataset11 = New SortingMethods_2003.Dataset1
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.button3 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.button4 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.panel1 = New System.Windows.Forms.Panel
            Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataset11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.DataSource = Me.dataset11.Customers
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 12)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.Size = New System.Drawing.Size(515, 347)
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
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
            Me.gridGroupingControl1.VersionInfo = "4.201.0.37"
            '
            'dataset11
            '
            Me.dataset11.DataSetName = "Dataset1"
            Me.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'button1
            '
            Me.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(540, 278)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(137, 25)
            Me.button1.TabIndex = 1
            Me.button1.Text = "SortByContactName"
            Me.button1.UseVisualStyle = True
            Me.button1.UseVisualStyleBackColor = True
            '
            'button2
            '
            Me.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.button2.ForeColor = System.Drawing.Color.White
            Me.button2.Location = New System.Drawing.Point(540, 247)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(137, 25)
            Me.button2.TabIndex = 2
            Me.button2.Text = "SortByCity"
            Me.button2.UseVisualStyle = True
            Me.button2.UseVisualStyleBackColor = True
            '
            'button3
            '
            Me.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.button3.ForeColor = System.Drawing.Color.White
            Me.button3.Location = New System.Drawing.Point(540, 216)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(137, 25)
            Me.button3.TabIndex = 3
            Me.button3.Text = "SortByCountry"
            Me.button3.UseVisualStyle = True
            Me.button3.UseVisualStyleBackColor = True
            '
            'button4
            '
            Me.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.button4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.button4.ForeColor = System.Drawing.Color.White
            Me.button4.Location = New System.Drawing.Point(540, 309)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(137, 25)
            Me.button4.TabIndex = 4
            Me.button4.Text = "ClearSorting"
            Me.button4.UseVisualStyle = True
            Me.button4.UseVisualStyleBackColor = True
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.DimGray
            Me.panel1.ForeColor = System.Drawing.Color.DimGray
            Me.panel1.Location = New System.Drawing.Point(533, 24)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1, 324)
            Me.panel1.TabIndex = 21
            '
            'checkBoxAdv1
            '
            Me.checkBoxAdv1.DrawFocusRectangle = False
            Me.checkBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.checkBoxAdv1.Location = New System.Drawing.Point(540, 170)
            Me.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv1.Name = "checkBoxAdv1"
            Me.checkBoxAdv1.Size = New System.Drawing.Size(134, 30)
            Me.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv1.TabIndex = 22
            Me.checkBoxAdv1.Text = "Allow Sorting"
            Me.checkBoxAdv1.ThemesEnabled = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.buttonAdv1)
            Me.GroupBox1.Controls.Add(Me.comboBoxAdv1)
            Me.GroupBox1.Location = New System.Drawing.Point(540, 42)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(147, 110)
            Me.GroupBox1.TabIndex = 23
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Align Sort Icon"
            '
            'comboBoxAdv1
            '
            Me.comboBoxAdv1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.comboBoxAdv1.BackColor = System.Drawing.Color.White
            Me.comboBoxAdv1.Location = New System.Drawing.Point(15, 30)
            Me.comboBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.comboBoxAdv1.Name = "comboBoxAdv1"
            Me.comboBoxAdv1.Size = New System.Drawing.Size(110, 21)
            Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
            Me.comboBoxAdv1.TabIndex = 25
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.buttonAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv1.ForeColor = System.Drawing.Color.White
            Me.buttonAdv1.Location = New System.Drawing.Point(15, 68)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(110, 23)
            Me.buttonAdv1.TabIndex = 26
            Me.buttonAdv1.Text = "Align Icon"
            Me.buttonAdv1.UseVisualStyle = True
            Me.buttonAdv1.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(689, 371)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.checkBoxAdv1)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.button4)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Sorting Demo"
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataset11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim commandstring As String = "select * from Customers"

            Dim da As New SqlCeDataAdapter(commandstring, connString)
            Try
                da.Fill(dataset11, "Customers")
            Catch ex As SqlException
                ShowErrorMessage(ex)
            End Try

            Me.gridGroupingControl1.TableDescriptor.AllowNew = False
            AddHandler gridGroupingControl1.TableControlQueryAllowSortColumn, AddressOf gridGroupingControl1_TableControlQueryAllowSortColumn
        End Sub

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

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            If Me.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Contains("ContactName") Then
                Me.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Clear()
            End If
            If Me.gridGroupingControl1.TableOptions.AllowSortColumns Then
                Me.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Add("ContactName", ListSortDirection.Ascending)
            End If
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
            If Me.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Contains("City") Then
                Me.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Clear()
            End If
            If Me.gridGroupingControl1.TableOptions.AllowSortColumns Then
                Me.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Add("City", ListSortDirection.Ascending)
            End If
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
            If Me.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Contains("Country") Then
                Me.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Clear()
            End If
            If Me.gridGroupingControl1.TableOptions.AllowSortColumns Then
                Me.gridGroupingControl1.Engine.TableDescriptor.SortedColumns.Add("Country", ListSortDirection.Ascending)
            End If
        End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button4.Click
            Me.gridGroupingControl1.Engine.TableDescriptor.ResetSortedColumns()
        End Sub

        Private Sub gridGroupingControl1_TableControlQueryAllowSortColumn(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.Grouping.GridQueryAllowSortColumnEventArgs)
            If e.Column.GetName() = "Region" Then
                e.AllowSort = False
            End If
        End Sub

        Private Sub checkBoxAdv1_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles checkBoxAdv1.CheckedChanged
            Dim chkBox As CheckBoxAdv = TryCast(sender, CheckBoxAdv)
            If chkBox.Checked Then
                Me.gridGroupingControl1.TableOptions.AllowSortColumns = True
            Else
                Me.gridGroupingControl1.TableOptions.AllowSortColumns = False
            End If
        End Sub

        Private Sub buttonAdv1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAdv1.Click
            If comboBoxAdv1.SelectedIndex = 0 Then
                Me.gridGroupingControl1.SortIconPlacement = SortIconPlacement.Left
            ElseIf comboBoxAdv1.SelectedIndex = 1 Then
                Me.gridGroupingControl1.SortIconPlacement = SortIconPlacement.Top
            ElseIf comboBoxAdv1.SelectedIndex = 2 Then
                Me.gridGroupingControl1.SortIconPlacement = SortIconPlacement.Right
            End If
        End Sub
    End Class
End Namespace

#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
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
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms

Namespace CustomersSample
    
   Public Class Form1
      Inherits System.Windows.Forms.Form
      Private gridRecordNavigationControl1 As Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl
      Private gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Private dataGrid1 As System.Windows.Forms.DataGrid
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents _cancelButton As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents okButton As Syncfusion.Windows.Forms.ButtonAdv

        Private components As System.ComponentModel.Container = Nothing


        Public Sub New()

            InitializeComponent()
            Try
                Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
                Me.Icon = ico
            Catch ex As Exception
            End Try
            'Listen to the IBindingList.ListChanged events instead of the 
            'CurrencyManager events.
            Me.gridDataBoundGrid1.UseListChangedEvent = True
            Me.gridDataBoundGrid1.OptimizeInsertRemoveCells = True
            Me.gridDataBoundGrid1.AllowDragSelectedCols = False
            Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
            Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
            Me.gridDataBoundGrid1.Model.Properties.BackgroundColor = SystemColors.Window
            Dim style As GridStyleInfo = gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Verdana"
            Me.BackColor = Color.FromArgb(223, 227, 239)
            Me.StartPosition = FormStartPosition.CenterScreen
        End Sub 'New


        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub 'Dispose

#Region "Windows Form Designer generated code"

        '/ <summary>
        '/ Required method for Designer support - do not modify
        '/ the contents of this method with the code editor.
        '/ </summary>
        Private Sub InitializeComponent()
            Me.gridRecordNavigationControl1 = New Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl
            Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
            Me.dataGrid1 = New System.Windows.Forms.DataGrid
            Me.panel1 = New System.Windows.Forms.Panel
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
            Me._cancelButton = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.okButton = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.gridRecordNavigationControl1.SuspendLayout()
            CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridRecordNavigationControl1
            '
            Me.gridRecordNavigationControl1.AllowAddNew = False
            Me.gridRecordNavigationControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridRecordNavigationControl1.BackColor = System.Drawing.SystemColors.Control
            Me.gridRecordNavigationControl1.Controls.Add(Me.gridDataBoundGrid1)
            Me.gridRecordNavigationControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
            Me.gridRecordNavigationControl1.Location = New System.Drawing.Point(24, 20)
            Me.gridRecordNavigationControl1.MaxRecord = 0
            Me.gridRecordNavigationControl1.Name = "gridRecordNavigationControl1"
            Me.gridRecordNavigationControl1.ShowToolTips = True
            Me.gridRecordNavigationControl1.Size = New System.Drawing.Size(512, 209)
            Me.gridRecordNavigationControl1.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
            Me.gridRecordNavigationControl1.TabIndex = 0
            Me.gridRecordNavigationControl1.Text = "gridRecordNavigationControl1"
            Me.gridRecordNavigationControl1.ThemesEnabled = True
            '
            'gridDataBoundGrid1
            '
            Me.gridDataBoundGrid1.AllowDragSelectedCols = True
            Me.gridDataBoundGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridDataBoundGrid1.DefaultColWidth = 70
            Me.gridDataBoundGrid1.DefaultRowHeight = 18
            Me.gridDataBoundGrid1.FillSplitterPane = True
            Me.gridDataBoundGrid1.Location = New System.Drawing.Point(0, 0)
            Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
            Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
            Me.gridDataBoundGrid1.Size = New System.Drawing.Size(491, 188)
            Me.gridDataBoundGrid1.SmartSizeBox = False
            Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
            Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
            Me.gridDataBoundGrid1.ThemesEnabled = True
            '
            'dataGrid1
            '
            Me.dataGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dataGrid1.DataMember = ""
            Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dataGrid1.Location = New System.Drawing.Point(23, 243)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.Size = New System.Drawing.Size(512, 149)
            Me.dataGrid1.TabIndex = 4
            '
            'panel1
            '
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.button1)
            Me.panel1.Controls.Add(Me._cancelButton)
            Me.panel1.Controls.Add(Me.okButton)
            Me.panel1.Controls.Add(Me.dataGrid1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(552, 438)
            Me.panel1.TabIndex = 5
            '
            'button1
            '
            Me.button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.Location = New System.Drawing.Point(23, 401)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(104, 24)
            Me.button1.TabIndex = 10
            Me.button1.Text = "Test"
            Me.button1.UseVisualStyle = True
            '
            '_cancelButton
            '
            Me._cancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me._cancelButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me._cancelButton.CausesValidation = False
            Me._cancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._cancelButton.Location = New System.Drawing.Point(463, 399)
            Me._cancelButton.Name = "_cancelButton"
            Me._cancelButton.Size = New System.Drawing.Size(72, 24)
            Me._cancelButton.TabIndex = 9
            Me._cancelButton.Text = "&Cancel"
            Me._cancelButton.UseVisualStyle = True
            '
            'okButton
            '
            Me.okButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.okButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.okButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.okButton.Location = New System.Drawing.Point(379, 399)
            Me.okButton.Name = "okButton"
            Me.okButton.Size = New System.Drawing.Size(72, 24)
            Me.okButton.TabIndex = 8
            Me.okButton.Text = "&OK"
            Me.okButton.UseVisualStyle = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(552, 438)
            Me.Controls.Add(Me.gridRecordNavigationControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Customers Demo"
            Me.gridRecordNavigationControl1.ResumeLayout(False)
            CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub 'InitializeComponent 
#End Region

        <STAThread()> _
        Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
            Application.EnableVisualStyles()
#End If
            Application.Run(New Form1())
        End Sub 'Main

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim customers As CustomerCollection = PopulateCustomers.CreateCustomers()
            Me.gridDataBoundGrid1.Binder.SetDataBinding(customers, "")
            Dim childrenLevel As GridHierarchyLevel = Me.gridDataBoundGrid1.Binder.AddRelation("Children")
            childrenLevel.ShowHeaders = False
            Me.gridDataBoundGrid1.Binder.RootHierarchyLevel.ShowHeaders = True
            Me.gridDataBoundGrid1.Binder.RootHierarchyLevel.RowStyle.BackColor = SystemColors.Window
            childrenLevel.RowStyle.BackColor = SystemColors.Window
            Me.dataGrid1.DataSource = customers
            Me.dataGrid1.BackgroundColor = SystemColors.Window
            Me.gridDataBoundGrid1.DefaultRowHeight = 18
            Me.gridDataBoundGrid1.DefaultColWidth = 70
            Me.gridDataBoundGrid1.Model.Properties.GridLineColor = System.Drawing.Color.Silver
            Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        End Sub 'Form1_Load

        Private Function GetIconFile(ByVal bitmapName As String) As String
            For n As Integer = 0 To 9
                If System.IO.File.Exists(bitmapName) Then
                    Return bitmapName
                End If

                bitmapName = "..\" & bitmapName
            Next n

            Return bitmapName
        End Function

        Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
            Me.gridDataBoundGrid1.ExpandAll()
            Me.dataGrid1.Expand(-1)
            Me.gridDataBoundGrid1.Refresh()
        End Sub

        Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
            Me.gridDataBoundGrid1.CollapseAll()
            Me.dataGrid1.Collapse(-1)
            Me.gridDataBoundGrid1.Refresh()
        End Sub

        Private Sub _cancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cancelButton.Click
            Close()
        End Sub
    End Class 'Form1 
End Namespace 'CustomersSample
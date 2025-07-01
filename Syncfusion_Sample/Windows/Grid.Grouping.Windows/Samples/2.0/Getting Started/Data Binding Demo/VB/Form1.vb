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
Imports System.Data.OleDb

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools


''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits MetroForm
    Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private components As IContainer
    Private WithEvents combobox As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Private propertyGrid1 As PropertyGrid
    Private WithEvents button2 As ButtonAdv
    Private panel1 As Panel
    Private label1 As Label
    Public Shared ReadOnly connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")

    Public Sub New()
        ' Debug helpers to see when objects are created and destroyed (work only for debug builds
        ' of libraries).
        Syncfusion.Grouping.RelationDescriptorCollection.VerboseEnsureInitialized = True
        Syncfusion.Grouping.Engine.VerboseEnsureObjectLifeTime = True
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try
        Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
        Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1

        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
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
        Me.components = New System.ComponentModel.Container()
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.combobox = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combobox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' gridGroupingControl1
        ' 
        Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.ChildGroupOptions.ShowCaption = True
        Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 22)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.Size = New System.Drawing.Size(495, 446)
        Me.gridGroupingControl1.TabIndex = 0
        Me.gridGroupingControl1.TableDescriptor.AllowNew = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235)))))))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))))
        Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
        Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
        Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
        Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
        Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(215))))), (CInt(Fix((CByte(229)))))))
        Me.gridGroupingControl1.Text = "gridGroupingControl1"
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        ' 
        ' combobox
        ' 
        Me.combobox.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
        Me.combobox.BackColor = System.Drawing.Color.White
        Me.combobox.Items.AddRange(New Object() {"Products", "Customer Order", "Customer Order Details"})
        Me.combobox.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.combobox, "Products"))
        Me.combobox.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.combobox, "Customer Order"))
        Me.combobox.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.combobox, "Customer Order Details"))
        Me.combobox.Location = New System.Drawing.Point(80, 12)
        Me.combobox.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
        Me.combobox.Name = "combobox"
        Me.combobox.Size = New System.Drawing.Size(152, 23)
        Me.combobox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.combobox.TabIndex = 2
        Me.combobox.Text = "Products"
        ' 
        ' propertyGrid1
        ' 
        Me.propertyGrid1.BackColor = System.Drawing.Color.White
        Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
        Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
        Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
        Me.propertyGrid1.LineColor = System.Drawing.Color.White
        Me.propertyGrid1.Location = New System.Drawing.Point(532, 122)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(255, 346)
        Me.propertyGrid1.TabIndex = 15
        ' 
        ' button2
        ' 
        Me.button2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.button2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
        Me.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.button2.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.button2.ForeColor = System.Drawing.Color.White
        Me.button2.Location = New System.Drawing.Point(80, 52)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(158, 27)
        Me.button2.TabIndex = 16
        Me.button2.Text = "Reset DataSource"
        Me.button2.UseVisualStyle = True
        Me.button2.UseVisualStyleBackColor = True
        '			Me.button2.Click += New System.EventHandler(Me.menuItem9_Click)
        ' 
        ' panel1
        ' 
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.combobox)
        Me.panel1.Location = New System.Drawing.Point(532, 22)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(255, 94)
        Me.panel1.TabIndex = 18
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.label1.Location = New System.Drawing.Point(3, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 15)
        Me.label1.TabIndex = 17
        Me.label1.Text = "DataSource"
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.ClientSize = New System.Drawing.Size(799, 480)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.propertyGrid1)
        Me.Controls.Add(Me.gridGroupingControl1)
        Me.DropShadow = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Binding Demo"
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combobox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub

    Private Function queryOleDb(ByVal name As String, ByVal query As String) As DataSet
        Dim ds As New DataSet()
        Dim commandstring As String = query

        Dim da As New SqlCeDataAdapter(commandstring, connString)
        da.Fill(ds, name)
        Return ds
    End Function

    Private Sub BindData(ByVal ds As DataSet)
        Me.gridGroupingControl1.SuspendLayout()

        If ds Is Nothing Then
            Me.gridGroupingControl1.DataSource = Nothing
        Else
            Me.gridGroupingControl1.DataSource = ds.Tables(0)
        End If

        ' Making columns marked readonly below, marks the schema as modified. Once 
        ' a schema is marked modified, its setting stay even when the source list is changed.
        ' This is by design and allows users to swap the datasource at runtime without having
        ' to worry that manual changes to the schema are lost.
        '
        ' In order to Reset the main table descriptor and also the nested relations
        ' use the following two lines:
        Me.gridGroupingControl1.ResetTableDescriptor()
        Me.gridGroupingControl1.TableDescriptor.Relations.Reset()

        ' Show group area
        Me.gridGroupingControl1.ShowGroupDropArea = True

        ' Additionial table descriptors currently habe to be added manually. We
        ' plan to provide a TableDescriptor.ShowInGroupDropArea property later
        ' to make this easier.
        AddGroupDropAreas(Me.gridGroupingControl1.Table)

        ' Make changes to schema. See above notes how to reset changes.
        SetReadOnly(Me.gridGroupingControl1.Table)

        Me.gridGroupingControl1.ResumeLayout(True)
    End Sub

    Private Sub AddGroupDropAreas(ByVal table As GridTable)
        Dim rd As Syncfusion.Grouping.RelationDescriptor = table.TableDescriptor.ParentRelation
        If rd IsNot Nothing AndAlso rd.RelationKind <> Syncfusion.Grouping.RelationKind.RelatedMasterDetails Then
            Return
        End If

        For Each t As GridTable In table.RelatedTables
            Console.WriteLine("AddGroupDropArea " & t.Info)

            gridGroupingControl1.AddGroupDropArea(t)
            'recurse...
            AddGroupDropAreas(t)
        Next t
    End Sub

    Private Sub SetReadOnly(ByVal table As GridTable)
        table.TableDescriptor.AllowNew = False
        table.TableDescriptor.AllowEdit = False
        table.TableDescriptor.AllowRemove = False

        'recurse...
        For Each t As GridTable In table.RelatedTables
            SetReadOnly(t)
        Next t
    End Sub

    Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ds As DataSet = queryOleDb("Products", "SELECT * FROM PRODUCTS")
        If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
            BindData(ds)
        End If
    End Sub

    Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ds As DataSet = queryOleDb("Customers", "SELECT * FROM CUSTOMERS")
        Dim ds2 As DataSet = queryOleDb("Orders", "SELECT * FROM ORDERS")
        If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds2 IsNot Nothing AndAlso ds2.Tables.Count > 0 Then
            ds.Merge(ds2.Tables(0))

            Dim relation As New DataRelation("CustomerOrders", ds.Tables("Customers").Columns("CustomerID"), ds.Tables("Orders").Columns("CustomerID"))
            ds.Relations.Add(relation)

            BindData(ds)
        End If
    End Sub

    Private Sub menuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ds As DataSet = queryOleDb("Customers", "SELECT * FROM CUSTOMERS")
        Dim ds2 As DataSet = queryOleDb("Orders", "SELECT * FROM ORDERS")
        Dim ds3 As DataSet = queryOleDb("OrderDetails", "SELECT * FROM [ORDER DETAILS]")
        If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds2 IsNot Nothing AndAlso ds2.Tables.Count > 0 AndAlso ds3 IsNot Nothing AndAlso ds3.Tables.Count > 0 Then
            ds.Merge(ds2.Tables(0))
            ds.Merge(ds3.Tables(0))

            Dim relation As New DataRelation("CustomerOrders", ds.Tables("Customers").Columns("CustomerID"), ds.Tables("Orders").Columns("CustomerID"))
            ds.Relations.Add(relation)

            Dim relation2 As New DataRelation("OrderOrderDetails", ds.Tables("Orders").Columns("OrderID"), ds.Tables("OrderDetails").Columns("OrderID"))
            ds.Relations.Add(relation2)

            BindData(ds)
        End If
    End Sub

    Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub menuItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dlg As New GroupingGridPropertyDialog(Me.gridGroupingControl1)
        dlg.Show()
    End Sub

    Private Sub menuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        BindData(Nothing)
    End Sub

    Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim abtForm As New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
        abtForm.ShowDialog()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = queryOleDb("Products", "SELECT * FROM PRODUCTS")
        If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
            BindData(ds)
        End If
    End Sub

    Private Sub combobox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combobox.SelectedIndexChanged
        Dim cb As ComboBoxAdv = CType(sender, ComboBoxAdv)
        If cb.Text = "Products" Then
            menuItem2_Click(cb, e)
        ElseIf cb.Text = "Customer Order" Then
            menuItem3_Click(cb, e)

        ElseIf cb.Text = "Customer Order Details" Then
            menuItem4_Click(cb, e)
        End If
    End Sub


End Class

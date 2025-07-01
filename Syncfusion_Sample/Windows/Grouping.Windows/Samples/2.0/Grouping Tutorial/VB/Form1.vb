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
Imports Syncfusion.Grouping

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private WithEvents rawList As System.Windows.Forms.Button
    Private textBox1 As System.Windows.Forms.TextBox
    Private WithEvents listSortedOnB As System.Windows.Forms.Button
    Private WithEvents listSortedOnBcomparer As System.Windows.Forms.Button
    Private WithEvents groupByC As System.Windows.Forms.Button
    Private WithEvents groupByCD As System.Windows.Forms.Button
    Private itemCount As System.Windows.Forms.NumericUpDown
    Private WithEvents clearText As System.Windows.Forms.Button
    Private WithEvents filter As System.Windows.Forms.Button
    Private filterString As System.Windows.Forms.TextBox
    Private WithEvents reset As System.Windows.Forms.Button
    Private WithEvents displayElements As System.Windows.Forms.Button
    Private WithEvents elements As System.Windows.Forms.Button
    Private WithEvents filteredRecords As System.Windows.Forms.Button
    Private WithEvents expandGroups As System.Windows.Forms.Button
    Private WithEvents collapseAll As System.Windows.Forms.Button
    Private WithEvents summaries As System.Windows.Forms.Button
    Private summaryMappingName As System.Windows.Forms.ComboBox
    Private summaryType As System.Windows.Forms.ComboBox
    Private WithEvents ClearSortsFiltersEtc As System.Windows.Forms.Button
    Private WithEvents sortedRecords As System.Windows.Forms.Button

    Private components As System.ComponentModel.Container = Nothing


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        InitializeComponent()
        Dim ico As System.Drawing.Icon = New System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "sfgrid.ico"))
        Me.Icon = ico

    End Sub 'New

    <STAThread()> _
    Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New Form1())
    End Sub 'Main

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
        Me.rawList = New System.Windows.Forms.Button
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.listSortedOnB = New System.Windows.Forms.Button
        Me.clearText = New System.Windows.Forms.Button
        Me.listSortedOnBcomparer = New System.Windows.Forms.Button
        Me.groupByC = New System.Windows.Forms.Button
        Me.groupByCD = New System.Windows.Forms.Button
        Me.itemCount = New System.Windows.Forms.NumericUpDown
        Me.filter = New System.Windows.Forms.Button
        Me.filterString = New System.Windows.Forms.TextBox
        Me.reset = New System.Windows.Forms.Button
        Me.displayElements = New System.Windows.Forms.Button
        Me.elements = New System.Windows.Forms.Button
        Me.filteredRecords = New System.Windows.Forms.Button
        Me.sortedRecords = New System.Windows.Forms.Button
        Me.expandGroups = New System.Windows.Forms.Button
        Me.collapseAll = New System.Windows.Forms.Button
        Me.summaries = New System.Windows.Forms.Button
        Me.summaryMappingName = New System.Windows.Forms.ComboBox
        Me.summaryType = New System.Windows.Forms.ComboBox
        Me.ClearSortsFiltersEtc = New System.Windows.Forms.Button
        CType(Me.itemCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rawList
        '
        Me.rawList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rawList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rawList.Location = New System.Drawing.Point(504, 152)
        Me.rawList.Name = "rawList"
        Me.rawList.Size = New System.Drawing.Size(160, 23)
        Me.rawList.TabIndex = 0
        Me.rawList.Text = "Display Raw Data"
        '
        'textBox1
        '
        Me.textBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox1.Location = New System.Drawing.Point(24, 80)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(456, 408)
        Me.textBox1.TabIndex = 1
        Me.textBox1.WordWrap = False
        '
        'listSortedOnB
        '
        Me.listSortedOnB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.listSortedOnB.Location = New System.Drawing.Point(32, 8)
        Me.listSortedOnB.Name = "listSortedOnB"
        Me.listSortedOnB.Size = New System.Drawing.Size(176, 23)
        Me.listSortedOnB.TabIndex = 2
        Me.listSortedOnB.Text = "Sorted on B using Default Sort"
        '
        'clearText
        '
        Me.clearText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clearText.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.clearText.Location = New System.Drawing.Point(504, 112)
        Me.clearText.Name = "clearText"
        Me.clearText.Size = New System.Drawing.Size(160, 23)
        Me.clearText.TabIndex = 3
        Me.clearText.Text = "Clear the Display Text"
        '
        'listSortedOnBcomparer
        '
        Me.listSortedOnBcomparer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.listSortedOnBcomparer.Location = New System.Drawing.Point(32, 40)
        Me.listSortedOnBcomparer.Name = "listSortedOnBcomparer"
        Me.listSortedOnBcomparer.Size = New System.Drawing.Size(176, 23)
        Me.listSortedOnBcomparer.TabIndex = 4
        Me.listSortedOnBcomparer.Text = "Sorted on B using Custom Sort"
        '
        'groupByC
        '
        Me.groupByC.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.groupByC.Location = New System.Drawing.Point(232, 8)
        Me.groupByC.Name = "groupByC"
        Me.groupByC.Size = New System.Drawing.Size(168, 23)
        Me.groupByC.TabIndex = 5
        Me.groupByC.Text = "Group by property C"
        '
        'groupByCD
        '
        Me.groupByCD.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.groupByCD.Location = New System.Drawing.Point(232, 40)
        Me.groupByCD.Name = "groupByCD"
        Me.groupByCD.Size = New System.Drawing.Size(168, 23)
        Me.groupByCD.TabIndex = 6
        Me.groupByCD.Text = "Group by properties C and D"
        '
        'itemCount
        '
        Me.itemCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.itemCount.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.itemCount.Location = New System.Drawing.Point(504, 192)
        Me.itemCount.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.itemCount.Name = "itemCount"
        Me.itemCount.Size = New System.Drawing.Size(40, 20)
        Me.itemCount.TabIndex = 8
        Me.itemCount.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'filter
        '
        Me.filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.filter.Location = New System.Drawing.Point(424, 8)
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(80, 23)
        Me.filter.TabIndex = 11
        Me.filter.Text = "Filter"
        '
        'filterString
        '
        Me.filterString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.filterString.Location = New System.Drawing.Point(424, 32)
        Me.filterString.Name = "filterString"
        Me.filterString.Size = New System.Drawing.Size(80, 20)
        Me.filterString.TabIndex = 12
        Me.filterString.Text = "D like d0*"
        '
        'reset
        '
        Me.reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.reset.Location = New System.Drawing.Point(544, 192)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(120, 24)
        Me.reset.TabIndex = 7
        Me.reset.Text = "Reset Raw Data"
        '
        'displayElements
        '
        Me.displayElements.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.displayElements.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.displayElements.Location = New System.Drawing.Point(504, 264)
        Me.displayElements.Name = "displayElements"
        Me.displayElements.Size = New System.Drawing.Size(160, 24)
        Me.displayElements.TabIndex = 9
        Me.displayElements.Text = "Iterate Thru DisplayElements"
        '
        'elements
        '
        Me.elements.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.elements.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.elements.Location = New System.Drawing.Point(504, 304)
        Me.elements.Name = "elements"
        Me.elements.Size = New System.Drawing.Size(160, 23)
        Me.elements.TabIndex = 10
        Me.elements.Text = "Iterate Thru Elements"
        '
        'filteredRecords
        '
        Me.filteredRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filteredRecords.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filteredRecords.Location = New System.Drawing.Point(504, 344)
        Me.filteredRecords.Name = "filteredRecords"
        Me.filteredRecords.Size = New System.Drawing.Size(160, 23)
        Me.filteredRecords.TabIndex = 13
        Me.filteredRecords.Text = "Iterate Thru FilteredRecords"
        '
        'sortedRecords
        '
        Me.sortedRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sortedRecords.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.sortedRecords.Location = New System.Drawing.Point(504, 384)
        Me.sortedRecords.Name = "sortedRecords"
        Me.sortedRecords.Size = New System.Drawing.Size(160, 23)
        Me.sortedRecords.TabIndex = 14
        Me.sortedRecords.Text = "Iterate Thru Records"
        '
        'expandGroups
        '
        Me.expandGroups.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.expandGroups.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.expandGroups.Location = New System.Drawing.Point(504, 424)
        Me.expandGroups.Name = "expandGroups"
        Me.expandGroups.Size = New System.Drawing.Size(72, 23)
        Me.expandGroups.TabIndex = 16
        Me.expandGroups.Text = "ExpandAll"
        '
        'collapseAll
        '
        Me.collapseAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.collapseAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.collapseAll.Location = New System.Drawing.Point(592, 424)
        Me.collapseAll.Name = "collapseAll"
        Me.collapseAll.Size = New System.Drawing.Size(75, 23)
        Me.collapseAll.TabIndex = 17
        Me.collapseAll.Text = "CollapseAll"
        '
        'summaries
        '
        Me.summaries.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.summaries.Location = New System.Drawing.Point(536, 8)
        Me.summaries.Name = "summaries"
        Me.summaries.Size = New System.Drawing.Size(128, 23)
        Me.summaries.TabIndex = 18
        Me.summaries.Text = "Summary"
        '
        'summaryMappingName
        '
        Me.summaryMappingName.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.summaryMappingName.Location = New System.Drawing.Point(536, 32)
        Me.summaryMappingName.Name = "summaryMappingName"
        Me.summaryMappingName.Size = New System.Drawing.Size(32, 21)
        Me.summaryMappingName.TabIndex = 19
        Me.summaryMappingName.Text = "D"
        '
        'summaryType
        '
        Me.summaryType.Location = New System.Drawing.Point(568, 32)
        Me.summaryType.Name = "summaryType"
        Me.summaryType.Size = New System.Drawing.Size(96, 21)
        Me.summaryType.TabIndex = 20
        '
        'ClearSortsFiltersEtc
        '
        Me.ClearSortsFiltersEtc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearSortsFiltersEtc.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ClearSortsFiltersEtc.Location = New System.Drawing.Point(504, 80)
        Me.ClearSortsFiltersEtc.Name = "ClearSortsFiltersEtc"
        Me.ClearSortsFiltersEtc.Size = New System.Drawing.Size(160, 23)
        Me.ClearSortsFiltersEtc.TabIndex = 21
        Me.ClearSortsFiltersEtc.Text = "Clear Sorts/Filters/Groups"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 518)
        Me.Controls.Add(Me.ClearSortsFiltersEtc)
        Me.Controls.Add(Me.summaryType)
        Me.Controls.Add(Me.summaryMappingName)
        Me.Controls.Add(Me.summaries)
        Me.Controls.Add(Me.collapseAll)
        Me.Controls.Add(Me.expandGroups)
        Me.Controls.Add(Me.sortedRecords)
        Me.Controls.Add(Me.filteredRecords)
        Me.Controls.Add(Me.filterString)
        Me.Controls.Add(Me.filter)
        Me.Controls.Add(Me.elements)
        Me.Controls.Add(Me.displayElements)
        Me.Controls.Add(Me.itemCount)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.groupByCD)
        Me.Controls.Add(Me.groupByC)
        Me.Controls.Add(Me.listSortedOnBcomparer)
        Me.Controls.Add(Me.clearText)
        Me.Controls.Add(Me.listSortedOnB)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.rawList)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grouping Tutorial"
        CType(Me.itemCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'InitializeComponent 
#End Region


    'the initial number of objects in the IList datasource
    Private nItems As Integer = 10

    'used for display indentation
    Private indentSize As Integer = 8
    Private indentChar As Char = " "c

    'grouping support objects 
    Private theTable As Syncfusion.Grouping.Table
    Private engine As Syncfusion.Grouping.Engine


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'create a new grouping engine and assign it a IList datasource
        engine = New Engine()
        engine.SetSourceList(CreateADataSource())
        engine.RecordAsDisplayElements = True

        'get a reference to the underlying grouping Table
        theTable = engine.Table

        'set up the summary combobox with enums..(leaving out custom)
        Dim i As Integer

        For i = 0 To 10
            Me.summaryType.Items.Add(CType(i, SummaryType).ToString())
        Next
        Me.summaryType.SelectedItem = "Count"
    End Sub 'Form1_Load

#Region "Display buttons"

    Private Sub displayElements_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayElements.Click
        ShowList("DisplayElements", theTable.DisplayElements)
    End Sub 'displayElements_Click


    Private Sub elements_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles elements.Click
        ShowList("Elements", theTable.Elements)
    End Sub 'elements_Click


    Private Sub filteredRecords_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles filteredRecords.Click
        ShowList("FilteredRecords", theTable.FilteredRecords)
    End Sub 'filteredRecords_Click


    Private Sub sortedRecords_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sortedRecords.Click
        ShowList("SortedRecords", theTable.Records)
    End Sub 'sortedRecords_Click

    Private Sub expandGroups_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles expandGroups.Click
        Me.theTable.ExpandAllGroups()
        SetTitleLine("ExpandAllGroups")
    End Sub 'expandGroups_Click
    'this.theTable.ExpandAllRecords();

    Private Sub collapseAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles collapseAll.Click
        CollapseGroup(theTable.TopLevelGroup)
        SetTitleLine("CollapseAllGroups")
    End Sub 'collapseAll_Click


    'called recursively
    Private Sub CollapseGroup(ByVal aGroup As Group)
        Dim g As Group
        For Each g In aGroup.Groups
            CollapseGroup(g)
            g.isExpanded = False
        Next g
    End Sub 'CollapseGroup


    Private Sub ShowList(ByVal title As String, ByVal list As IList)
        SetTitleLine(title)
        Dim indent As String = ""
        Dim [text] As String = ""
        Dim o As Element
        For Each o In list
            Dim indents As Integer = IIf(TypeOf o Is CaptionSection, o.GroupLevel, o.GroupLevel + 1)
            indent = New String(indentChar, indents * indentSize)

            If TypeOf o Is Record Then
                Dim r As Record = o '
                [text] += String.Format("       " + ControlChars.Tab + " {0}", r.GetData()) + Environment.NewLine

            Else
                [text] += String.Format("{1}{0}", o, indent) + Environment.NewLine
            End If
        Next o

        Me.textBox1.Text += [text]
        Me.textBox1.SelectionStart = Me.textBox1.Text.Length
        Me.textBox1.SelectionLength = 0
        Me.textBox1.ScrollToCaret()
    End Sub 'Show 
#End Region

#Region "Data Creation"

    Private Function CreateADataSource() As IList
        'create a datasource - an arraylist of MyObject's
        Dim r As New Random()
        Dim dataSource As New ArrayList()
        Dim i As Integer

        While i < nItems
            dataSource.Add(New MyObject(r.Next(100)))
            i += 1
        End While

        Return dataSource
    End Function 'CreateADataSource
#End Region

#Region "Sorting "

    Private lsd As ListSortDirection = ListSortDirection.Descending

    Private Function GetSortDirection() As ListSortDirection
        If lsd = ListSortDirection.Descending Then
            lsd = ListSortDirection.Ascending
        Else
            lsd = ListSortDirection.Descending
        End If
        Return lsd
    End Function 'GetSortDirection




    Private Sub listSortedOnB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles listSortedOnB.Click
        'listSortedOnB
        Dim dir As ListSortDirection = GetSortDirection()
        theTable.TableDescriptor.SortedColumns.Clear()
        theTable.TableDescriptor.SortedColumns.Add("B", dir)

        SetTitleLine(("Sorted On B using default " + dir.ToString()))
    End Sub 'listSortedOnB_Click




    Private Sub listSortedOnBcomparer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles listSortedOnBcomparer.Click
        'listSortedOnBcomparer
        SetTitleLine("Sorted On B using custom Comparer")

        theTable.TableDescriptor.SortedColumns.Clear()
        theTable.TableDescriptor.SortedColumns.Add("B")
        theTable.TableDescriptor.SortedColumns("B").Comparer = New BComparer()
    End Sub 'listSortedOnBcomparer_Click 

#End Region

#Region "Grouping"


    Private Sub groupByC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles groupByC.Click
        'groupByC
        SetTitleLine("GroupBy C")

        theTable.TableDescriptor.GroupedColumns.Clear()
        theTable.TableDescriptor.GroupedColumns.Add("C", GetSortDirection())
    End Sub 'groupByC_Click

    '	ShowGrouping();

    Private Sub groupByCD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles groupByCD.Click
        'groupByC
        SetTitleLine("GroupBy CD")

        theTable.TableDescriptor.GroupedColumns.Clear()
        theTable.TableDescriptor.GroupedColumns.Add("C", GetSortDirection())
        theTable.TableDescriptor.GroupedColumns.Add("D", GetSortDirection())
    End Sub 'groupByCD_Click

    ' ShowGrouping();

    Private Sub SetTitleLine(ByVal title As String)
        Me.textBox1.Text += New String("-"c, 40) + title + Environment.NewLine
        Me.textBox1.SelectionStart = Me.textBox1.Text.Length
        Me.textBox1.SelectionLength = 0
        Me.textBox1.ScrollToCaret()
    End Sub 'SetTitleLine 



#End Region

#Region "Filtering"

    Private Sub filter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles filter.Click
        'Filter
        Dim s As String = Me.filterString.Text
        Dim op As FilterCompareOperator
        Dim name As String = ""
        Dim compareValue As String = ""
        If ParseFilter(s, name, op, compareValue) Then
            theTable.TableDescriptor.RecordFilters.Clear()
            theTable.TableDescriptor.RecordFilters.Add(name, op, compareValue)
            SetTitleLine(("Filter by: " + name + " " + op.ToString() + " " + compareValue.ToString()))
        End If
    End Sub 'filter_Click

#Region "Code to parse filter string entry"
    Private ops As New ArrayList(New Char() {"="c, ">"c, "^"c, "<"c, "%"c, "~"c, "!"c, "-"c})
    Private swapFrom() As String = {">=", "<=", "like", "match", "<>"}
    Private swapTo() As String = {"^", "%", "~", "!", "-"}


    Private Function ParseFilter(ByVal inputString As String, ByRef name As String, ByRef op As FilterCompareOperator, ByRef compareValue As String) As Boolean
        name = ""
        op = FilterCompareOperator.Custom
        compareValue = ""
        Dim s As String = inputString.ToLower()
        Dim b As Boolean = True
        Try
            Dim i As Integer

            While i < swapFrom.GetLength(0)
                s = s.Replace(swapFrom(i), swapTo(i))
                i += 1
            End While

            Dim locOp As Integer = s.IndexOfAny(CType(ops.ToArray(GetType(Char)), Char()))
            name = inputString.Substring(0, locOp).Trim()
            Dim x As Char = s.Substring(locOp, 1)
            op = CType(ops.IndexOf(x) + 1, FilterCompareOperator)
            Dim len As Integer = s.Length - locOp - 1
            Dim start As Integer = inputString.Length - len
            compareValue = inputString.Substring(start).Trim()
        Catch
            b = False
        End Try
        Return b
    End Function 'ParseFilter 
#End Region

#End Region

#Region "Summaries"


    Private Sub summaries_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles summaries.Click
        Dim mappingName As String = Me.summaryMappingName.SelectedItem.ToString()
        Dim name As String = mappingName
        Me.theTable.TableDescriptor.Summaries.Add(name, mappingName, CType(Me.summaryType.SelectedIndex, SummaryType))
    End Sub 'summaries_Click

#End Region

#Region "Miscellaneous ButtonHandlers "


    Private Sub ClearSortsFiltersEtc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearSortsFiltersEtc.Click
        Me.theTable.TableDescriptor.Summaries.Clear()
        Me.theTable.TableDescriptor.GroupedColumns.Clear()
        Me.theTable.TableDescriptor.SortedColumns.Clear()
        Me.theTable.TableDescriptor.RecordFilters.Clear()
    End Sub 'ClearSortsFiltersEtc_Click


    Private Sub rawList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rawList.Click
        'rawList
        SetTitleLine("Raw List")

        'A.commented code shows particular property
        'PropertyDescriptorCollection pdc = theTable.GetItemProperties();
        'PropertyDescriptor pd = pdc["B"];
        Dim i As Integer = 0
        Dim r As Record
        For Each r In theTable.UnsortedRecords
            'this.textBox1.Text += string.Format("[{0}]  \t {1}", i, r.GetData()) + Environment.NewLine;
            Me.textBox1.Text += String.Format("       " + ControlChars.Tab + " {1}", i, r.GetData()) + Environment.NewLine

            'B.commented code shows particular property
            'this.textBox1.Text += pd.GetValue(r.Data).ToString() + Environment.NewLine;
            i += 1
        Next r
    End Sub 'rawList_Click


    Private Sub clear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clearText.Click
        Me.textBox1.Text = ""
    End Sub 'clear_Click


    Private Sub reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.Click
        nItems = Fix(Me.itemCount.Value)
        engine.SetSourceList(CreateADataSource())
        theTable = engine.Table
    End Sub 'reset_Click

#End Region
End Class 'Form1 


#Region "custom Comparer class"


Public Class BComparer
    Implements IComparer 'ToDo: Add Implements Clauses for implementation methods of these interface(s)
#Region "Implementation of IComparer"

    Public Function [Compare](ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        If x Is Nothing AndAlso y Is Nothing Then
            Return 0
        ElseIf x Is Nothing Then
            Return -1
        ElseIf y Is Nothing Then
            Return 1
        Else
            Dim sx As Integer = 0
            Dim sy As Integer = 0
            Try
                sx = Integer.Parse(x.ToString().Substring(1))
                sy = Integer.Parse(y.ToString().Substring(1))
                Return sy - sx
            Catch
                Throw New ArgumentException("B must be in the form 'bnnnn'")
            End Try
        End If
    End Function 'Compare 

#End Region
End Class 'BComparer

#End Region

#Region "the Object class"

Public Class MyObject
    Private aValue As String
    Private bValue As String
    Private cValue As String
    Private dValue As String

    Public Sub New(ByVal i As Integer)
        aValue = String.Format("a{0}", i)
        bValue = String.Format("b{0}", i)
        cValue = String.Format("c{0}", i Mod 3)
        dValue = String.Format("d{0}", i Mod 2)
    End Sub 'New '	this.list = null;

    Public Property A() As String
        Get
            Return aValue
        End Get
        Set(ByVal Value As String)
            aValue = Value
        End Set
    End Property

    Public Property B() As String
        Get
            Return bValue
        End Get
        Set(ByVal Value As String)
            bValue = Value
        End Set
    End Property

    Public Property C() As String
        Get
            Return cValue
        End Get
        Set(ByVal Value As String)
            cValue = Value
        End Set
    End Property

    Public Property D() As String
        Get
            Return dValue
        End Get
        Set(ByVal Value As String)
            dValue = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return A + ControlChars.Tab + B + ControlChars.Tab + C + ControlChars.Tab + D
    End Function 'ToString
End Class 'MyObject

#End Region


 
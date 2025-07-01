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
Imports System.IO
Imports System.Text
Imports System.Diagnostics

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping


'/ <summary>
'/ GroupingEngineFactory provides a trimmed down GridGroup
'/ which eliminates overhead of not needed preview rows, header and footer cells.
'/ </summary>

Public Class GroupingEngineFactory
    Inherits GridEngineFactoryBase
    
    ' Add this line in your forms ctor:
    ' GroupingEngineFactory provides a modified GridChildTable that adds an extra section
    ' GridEngineFactory.Factory = new GroupingEngineFactory();
    Public Overrides Function CreateEngine() As GridEngine
        Return New GroupingEngine()
    End Function 'CreateEngine
End Class 'GroupingEngineFactory


Public Class GroupingEngine
    Inherits GridEngine
    
    Public Overrides Function CreateChildTable(parent As Element) As ChildTable
        Return New GroupingChildTable(parent)
    End Function 'CreateChildTable
    
    
    Public Overrides Function CreateGroup(parent As Section) As Group
        Return New GroupingGroup(parent)
    End Function 'CreateGroup
End Class 'GroupingEngine


Public Class ExtraSection
    Inherits EmptySection
    
    Public Sub New(parent As Group)
        MyBase.New(parent)
    End Sub 'New
    
    
    Public Overrides ReadOnly Property Kind() As DisplayElementKind
        Get
            Return DisplayElementKind.None
        End Get
    End Property
     
    Public Overrides Function GetElementCount() As Integer
        Return 1
    End Function 'GetElementCount
    
    
    Public Overrides Function GetVisibleCount() As Integer
        Return 1
    End Function 'GetVisibleCount
    
    
    Public Overrides Function GetYAmountCount() As Double
        Return 22 ' Row Height
    End Function 'GetYAmountCount
End Class 'ExtraSection


Public Class GroupingChildTable
    Inherits ChildTable
    Implements IGridGroupOptionsSource
    
    Public Sub New(parent As Element)
        MyBase.New(parent)
    End Sub 'New
    
    
    Protected Overrides Sub OnInitializeSections(hasRecords As Boolean, fields As SortColumnDescriptorCollection)
        ' Caption
        Me.Sections.Add(Me.ParentTableDescriptor.CreateCaptionSection(Me))
        
        ' Column Headers
        Me.Sections.Add(Me.ParentTableDescriptor.CreateColumnHeaderSection(Me))
        
        ' Extra section
        Me.Sections.Add(New ExtraSection(Me))
        
        ' AddNewRecord
        Dim addNewRecordSectionBeforeDetails As AddNewRecordSection = Me.ParentTableDescriptor.CreateAddNewRecordSection(Me)
        addNewRecordSectionBeforeDetails.IsBeforeDetails = True
        Me.Sections.Add(addNewRecordSectionBeforeDetails)
        
        ' Details (Records or Groups)
        If hasRecords Then
            Me.Sections.Add(Me.ParentTableDescriptor.CreateRecordsDetails(Me, fields))
        Else
            Me.Sections.Add(Me.ParentTableDescriptor.CreateGroupsDetails(Me, fields))
        End If 
        ' Summary
        Me.Sections.Add(Me.ParentTableDescriptor.CreateSummarySection(Me))
    End Sub 'OnInitializeSections
    
    
    Public Overrides Function IsChildVisible(el As Element) As Boolean
        If Me.IsTopLevelGroup Then
            Return True
        End If 
        If TypeOf el Is ExtraSection Then
            Return el.ParentGroup.IsExpanded ' here you can specify when the extra section is visible.
        ElseIf TypeOf el Is CaptionSection OrElse TypeOf el Is ColumnHeaderSection Then
            Return True
        
        Else
            Return el.ParentGroup.IsExpanded
        End If
    End Function 'IsChildVisible 
    #Region "IGridGroupOptionsSource Members"
    
    Private _groupOptions As GridGroupOptionsStyleInfo
    
    
    Public Sub RaiseGroupOptionsChanging(ByVal e As GridGroupOptionsChangedEventArgs) Implements IGridGroupOptionsSource.RaiseGroupOptionsChanging
    End Sub 'RaiseGroupOptionsChanging


    Public Sub RaiseGroupOptionsChanged(ByVal e As GridGroupOptionsChangedEventArgs) Implements IGridGroupOptionsSource.RaiseGroupOptionsChanged
        Me.InvalidateCounterTopDown(True)
    End Sub 'RaiseGroupOptionsChanged


    Public ReadOnly Property HasGroupOptions() As Boolean Implements IGridGroupOptionsSource.HasGroupOptions
        Get
            Return Not (_groupOptions Is Nothing)
        End Get
    End Property

    '/ <override/>

    Public Shadows ReadOnly Property Engine() As GridEngine Implements IGridGroupOptionsSource.Engine
        Get
            Return CType(MyBase.Engine, GridEngine)
        End Get
    End Property

    '/ <summary>
    '/ Lets you control the look of inner groups like whether the Caption Row is visible, or what CaptionText is.
    '/ </summary>

    <DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content), Browsable(True)> _
    Public ReadOnly Property GroupOptions() As GridGroupOptionsStyleInfo Implements IGridGroupOptionsSource.GroupOptions
        Get
            If _groupOptions Is Nothing Then
                Dim t As GridGroupOptionsType = GridGroupOptionsType.Groups
                If Me.IsTopLevelGroup Then
                    t = GridGroupOptionsType.TopLevelGroup
                    'if (this is ChildTable)
                Else
                    t = GridGroupOptionsType.ChildTable
                End If
                _groupOptions = New GridGroupOptionsStyleInfo(New GridGroupOptionsStyleInfoIdentity(CType(Me, IGridGroupOptionsSource), t))
            End If
            Return _groupOptions
        End Get
    End Property


    Public Function GetParentGroupOptionsSource() As IGridGroupOptionsSource Implements IGridGroupOptionsSource.GetParentGroupOptionsSource
        If Me.CategoryColumns.Count > 0 Then
            Dim column As GridColumnDescriptor = CType(Me.ParentTableDescriptor, GridTableDescriptor).Columns(Me.CategoryColumns(0).Name)
            If Not (column Is Nothing) Then
                Return column
            End If
        End If
        Return CType(Me.ParentTableDescriptor, IGridGroupOptionsSource)
    End Function 'GetParentGroupOptionsSource

#End Region
End Class 'GroupingChildTable


Public Class GroupingGroup
    Inherits Group
    Implements IGridGroupOptionsSource
    Public Sub New(ByVal parent As Section)
        MyBase.New(parent)
    End Sub 'New


    Protected Overrides Sub OnInitializeSections(ByVal hasRecords As Boolean, ByVal fields As SortColumnDescriptorCollection)
        ' Caption
        Me.Sections.Add(Me.ParentTableDescriptor.CreateCaptionSection(Me))

        ' Extra section
        Me.Sections.Add(New ExtraSection(Me))

        ' Summary
        Me.Sections.Add(Me.ParentTableDescriptor.CreateSummarySection(Me))

        ' AddNewRecord
        Dim addNewRecordSectionBeforeDetails As AddNewRecordSection = Me.ParentTableDescriptor.CreateAddNewRecordSection(Me)
        addNewRecordSectionBeforeDetails.IsBeforeDetails = True
        Me.Sections.Add(addNewRecordSectionBeforeDetails)

        ' Details (Records or Groups)
        If hasRecords Then
            Me.Sections.Add(Me.ParentTableDescriptor.CreateRecordsDetails(Me, fields))
        Else
            Me.Sections.Add(Me.ParentTableDescriptor.CreateGroupsDetails(Me, fields))
        End If
    End Sub 'OnInitializeSections


    Public Overrides Function IsChildVisible(ByVal el As Element) As Boolean
        If TypeOf el Is ExtraSection Then
            Return el.ParentGroup.isExpanded ' here you can specify when the extra section is visible.
        ElseIf TypeOf el Is CaptionSection Then
            Return True

        Else
            Return el.ParentGroup.isExpanded
        End If
    End Function 'IsChildVisible 
#Region "IGridGroupOptionsSource Members"

    Private _groupOptions As GridGroupOptionsStyleInfo


    Public Sub RaiseGroupOptionsChanging(ByVal e As GridGroupOptionsChangedEventArgs) Implements IGridGroupOptionsSource.RaiseGroupOptionsChanging
    End Sub 'RaiseGroupOptionsChanging


    Public Sub RaiseGroupOptionsChanged(ByVal e As GridGroupOptionsChangedEventArgs) Implements IGridGroupOptionsSource.RaiseGroupOptionsChanged
        Me.InvalidateCounterTopDown(True)
    End Sub 'RaiseGroupOptionsChanged


    Public ReadOnly Property HasGroupOptions() As Boolean Implements IGridGroupOptionsSource.HasGroupOptions
        Get
            Return Not (_groupOptions Is Nothing)
        End Get
    End Property

    '/ <override/>

    Public Shadows ReadOnly Property Engine() As GridEngine Implements IGridGroupOptionsSource.Engine
        Get
            Return CType(MyBase.Engine, GridEngine)
        End Get
    End Property

    '/ <summary>
    '/ Lets you control the look of inner groups like whether the Caption Row is visible, or what CaptionText is.
    '/ </summary>

    <DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content), Browsable(True)> _
    Public ReadOnly Property GroupOptions() As GridGroupOptionsStyleInfo Implements IGridGroupOptionsSource.GroupOptions
        Get
            If _groupOptions Is Nothing Then
                Dim t As GridGroupOptionsType = GridGroupOptionsType.Groups
                If Me.IsTopLevelGroup Then
                    t = GridGroupOptionsType.TopLevelGroup
                    'if (this is ChildTable)
                Else
                    t = GridGroupOptionsType.ChildTable
                End If
                _groupOptions = New GridGroupOptionsStyleInfo(New GridGroupOptionsStyleInfoIdentity(CType(Me, IGridGroupOptionsSource), t))
            End If
            Return _groupOptions
        End Get
    End Property


    Public Function GetParentGroupOptionsSource() As IGridGroupOptionsSource Implements IGridGroupOptionsSource.GetParentGroupOptionsSource
        If Me.CategoryColumns.Count > 0 Then
            Dim column As GridColumnDescriptor = CType(Me.ParentTableDescriptor, GridTableDescriptor).Columns(Me.CategoryColumns(0).Name)
            If Not (column Is Nothing) Then
                Return column
            End If
        End If
        Return CType(Me.ParentTableDescriptor, IGridGroupOptionsSource)
    End Function 'GetParentGroupOptionsSource

#End Region
End Class 'GroupingGroup 
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


Imports Microsoft.VisualBasic
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

Namespace RecursiveNestedCollection
    ''' <summary>
    ''' GroupingEngineFactory
    ''' </summary>
    Public Class GroupingEngineFactory : Inherits GridEngineFactoryBase
        ' Add this line in your forms ctor:
        ' GroupingEngineFactory provides a modified GridChildTable that adds an extra section
        ' GridEngineFactory.Factory = new GroupingEngineFactory();

        Public Overrides Function CreateEngine() As GridEngine
            Return New GroupingEngine()
        End Function
    End Class

    Public Class GroupingEngine : Inherits GridEngine

        Public Overrides Function CreateChildTable(ByVal parent As Element) As ChildTable
            Return New GroupingChildTable(parent)
        End Function
    End Class



    ''' <summary>
    ''' Derived GridChildTable that gets hidden when it has no records to show.
    ''' </summary>
    Public Class GroupingChildTable : Inherits GridChildTable : Implements IGridGroupOptionsSource
        Public Sub New(ByVal parent As Element)
            MyBase.New(parent)
        End Sub

        ''' <override/>
        Public Overrides Function GetVisibleCount() As Integer
            'INSTANT VB NOTE: Embedded comments are not maintained by Instant VB
            'ORIGINAL LINE: if (this.Details == null || this.Records.Count == 0 /*|| Name=="ChildTables"*/)
            If Me.Details Is Nothing OrElse Me.Records.Count = 0 Then
                Return 0
            End If

            Return MyBase.GetVisibleCount()
        End Function

        ''' <override/>
        Public Overrides Function GetYAmountCount() As Double
            'INSTANT VB NOTE: Embedded comments are not maintained by Instant VB
            'ORIGINAL LINE: if (this.Details == null || this.Records.Count == 0 /*|| Name == "ChildTables"*/)
            If Me.Details Is Nothing OrElse Me.Records.Count = 0 Then
                Return 0
            End If

            Return MyBase.GetYAmountCount()
        End Function

        ''' <override/>
        Public Overrides Function GetVisibleCustomCount() As Double
            'INSTANT VB NOTE: Embedded comments are not maintained by Instant VB
            'ORIGINAL LINE: if (this.Details == null || this.Records.Count == 0 /*|| Name == "ChildTables"*/)
            If Me.Details Is Nothing OrElse Me.Records.Count = 0 Then
                Return 0
            End If

            Return MyBase.GetVisibleCustomCount()
        End Function
    End Class
End Namespace

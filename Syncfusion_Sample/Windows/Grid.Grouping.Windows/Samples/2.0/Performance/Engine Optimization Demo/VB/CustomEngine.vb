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
Imports System.Diagnostics
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping

Namespace TestEngineOptimizations
	''' <summary>
	''' GroupingEngineFactory provides a trimmed down GridGroup
	''' which eliminates overhead of not needed preview rows, header and footer cells.
	''' </summary>
	Public Class GroupingEngineFactory : Inherits GridEngineFactoryBase
		Public Overrides Function CreateEngine() As GridEngine
			Return New GroupingEngine()
		End Function
	End Class

	Public Class GroupingEngine : Inherits GridEngine
		Public Overrides Function CreateGroup(ByVal parent As Section) As Group
			Return New GroupingGroup(parent)
		End Function

	End Class

	Public Class GroupingGroup : Inherits Group
		Public Sub New(ByVal parent As Section)
			MyBase.New(parent)
		End Sub

		Protected Overrides Sub OnInitializeSections(ByVal hasRecords As Boolean, ByVal fields As SortColumnDescriptorCollection)
			Me.Sections.Add(Me.ParentTableDescriptor.CreateCaptionSection(Me))
			If hasRecords Then
				Me.Sections.Add(Me.ParentTableDescriptor.CreateRecordsDetails(Me, fields))
			Else
				Me.Sections.Add(Me.ParentTableDescriptor.CreateGroupsDetails(Me, fields))
			End If
			Me.Sections.Add(Me.ParentTableDescriptor.CreateSummarySection(Me))
		End Sub

		Public Overrides Function IsChildVisible(ByVal el As Element) As Boolean
			If TypeOf el Is CaptionSection Then
				Return True
			Else If TypeOf el Is DetailsSection Then
				Return Me.IsExpanded
			Else If TypeOf el Is GridSummarySection Then
				Return Me.IsExpanded
			End If
			Return True
		End Function
	End Class

End Namespace

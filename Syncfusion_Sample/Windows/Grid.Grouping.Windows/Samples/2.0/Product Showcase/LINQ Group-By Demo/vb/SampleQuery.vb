#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
#Region "Directives"

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Syncfusion.Windows.Forms.Grid.Grouping

#End Region

Namespace LinqGroupBy
	Public MustInherit Class SampleQuery
		#Region "Public Method"

		Public MustOverride Sub InitializeGrid(ByVal grid As GridGroupingControl, ByVal db As NorthwindwithImage)

		#End Region
	End Class
End Namespace

#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace I58680b
	Public Class Employee
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property

		Private privateStatus As Status
		<TypeConverter(GetType(StatusConverter))> _
		Public Property Status() As Status
			Get
				Return privateStatus
			End Get
			Set(ByVal value As Status)
				privateStatus = value
			End Set
		End Property

		Private privateContext As Context
		<Browsable(True)> _
		Public Property Context() As Context
			Get
				Return privateContext
			End Get
			Set(ByVal value As Context)
				privateContext = value
			End Set
		End Property

		Public Sub New(ByVal name As String, ByVal status As Status, ByVal context As Context)
			Me.Name = name
			Me.Status = status
			Me.Context = context
		End Sub

	End Class

	Public Enum Status
		Married
		[Single]
		Divorced
		Widow
	End Enum

	Public Enum Context
		Employed
		Retired
		OnVacation
		Sick
	End Enum
End Namespace

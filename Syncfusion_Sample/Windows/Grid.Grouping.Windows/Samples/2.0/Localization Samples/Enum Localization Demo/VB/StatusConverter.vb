#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace I58680b
	Public Class StatusConverter
		Inherits EnumConverter
		Public Sub New(ByVal propertyType As Type)
			MyBase.New(propertyType)

		End Sub

		Public Overrides Overloads Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal sourceType As Type) As Boolean
			If sourceType Is GetType(String) Then
				Return True
			End If


			Return MyBase.CanConvertFrom(context, sourceType)
		End Function

		Public Overrides Overloads Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destinationType As Type) As Boolean
			If destinationType Is GetType(String) Then
				Return True
			End If

			Return MyBase.CanConvertTo(context, destinationType)
		End Function

		Public Overrides Overloads Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object

			If TypeOf value Is String Then
				Return ConvertFromString(context, culture, value)
			End If

			Return MyBase.ConvertFrom(context, culture, value)
		End Function

		Private Overloads Function ConvertFromString(ByVal context As ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
			Select Case CStr(value)
				Case "geschieden"
					Return Status.Divorced
				Case "verheiratet"
					Return Status.Married
				Case "Einzel"
					Return Status.Single
				Case "Witwe"
					Return Status.Widow
				Case Else
					Return Nothing
			End Select
		End Function
		Public Overrides Overloads Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As Type) As Object

			If destinationType Is GetType(String) Then
				Return ConverToString(context,culture, value)
			End If

			Return MyBase.ConvertTo(context, culture, value, destinationType)
		End Function

		Public Function ConverToString(ByVal context As ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
			Select Case CType(value, Status)
				Case Status.Divorced
					Return "geschieden"
				Case Status.Married
					Return "verheiratet"
				Case Status.Single
					Return "Einzel"
				Case Status.Widow
					Return "Witwe"
				Case Else
					Return String.Empty
			End Select
		End Function


		Public Overrides Overloads Function GetStandardValues(ByVal context As ITypeDescriptorContext) As StandardValuesCollection
			If context IsNot Nothing AndAlso context.Instance IsNot Nothing AndAlso TypeOf context.Instance Is Employee Then
				Dim employeeContext = (CType(context.Instance, Employee)).Context
				Return New StandardValuesCollection(GetContextualCollection(employeeContext))
			End If
			Return MyBase.GetStandardValues(context)
		End Function

		Private Function GetContextualCollection(ByVal employeeContext As Context) As System.Collections.ICollection
			Select Case employeeContext
				Case Context.Employed
					Return New Collection(Of Status)(New Status() {Status.Married, Status.Single, Status.Widow})
				Case Context.OnVacation
					Return New Collection(Of Status)(New Status() {Status.Married})
				Case Context.Retired
					Return New Collection(Of Status)(New Status() {Status.Single, Status.Divorced})
				Case Context.Sick
					Return New Collection(Of Status)(New Status() {Status.Widow})
				Case Else
					Return New Collection(Of Status)(New Status() {Status.Married, Status.Single, Status.Widow, Status.Divorced})
			End Select
		End Function

	End Class
End Namespace

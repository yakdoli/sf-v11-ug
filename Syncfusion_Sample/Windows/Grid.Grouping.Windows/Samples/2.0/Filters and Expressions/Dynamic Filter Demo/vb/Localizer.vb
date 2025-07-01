Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.GridHelperClasses
Imports System.Threading

Namespace DynamicFilter
	Friend Class Localizer
		Implements ILocalizationProvider
		#Region "ILocalizationProvider Members"

		Private str As String = String.Empty
		Public Sub getstring(ByVal s As String)
			str = s
		End Sub
		Public Function GetLocalizedString(ByVal culture As System.Globalization.CultureInfo, ByVal name As String, ByVal obj As Object) As String Implements ILocalizationProvider.GetLocalizedString
			If str = "True" Then
				Select Case name
'					#Region "Menu Package"
					Case DynamicFilterResourceIdentifiers.StartsWith
						Return "empieza con"
					Case DynamicFilterResourceIdentifiers.EndsWith
						Return "termina con"
					Case DynamicFilterResourceIdentifiers.Equal
						Return "es igual a"
					Case DynamicFilterResourceIdentifiers.GreaterThan
						Return "mayor que"
					Case DynamicFilterResourceIdentifiers.GreaterThanOrEqualTo
						Return "Mayor o igual a"
					Case DynamicFilterResourceIdentifiers.LessThan
						Return "menos que"
					Case DynamicFilterResourceIdentifiers.LessThanOrEqualTo
						Return "Menor o igual a"
					Case DynamicFilterResourceIdentifiers.Like
						Return "como"
					Case DynamicFilterResourceIdentifiers.Match
						Return "partido"
					Case DynamicFilterResourceIdentifiers.NotEquals
						Return "no es igual"
					Case DynamicFilterResourceIdentifiers.ExpressionMATCH
						Return "expresión de coincidencia"
'					#End Region

					Case Else
						Return String.Empty
				End Select
			Else
				Select Case name
'					#Region "Menu Package"
					Case DynamicFilterResourceIdentifiers.StartsWith
						Return "StartsWith"
					Case DynamicFilterResourceIdentifiers.EndsWith
						Return "EndsWith"
					Case DynamicFilterResourceIdentifiers.Equal
						Return "Equals"
					Case DynamicFilterResourceIdentifiers.GreaterThan
						Return "GreaterThan"
					Case DynamicFilterResourceIdentifiers.GreaterThanOrEqualTo
						Return "GreaterThanOrEqualTo"
					Case DynamicFilterResourceIdentifiers.LessThan
						Return "LessThan"
					Case DynamicFilterResourceIdentifiers.LessThanOrEqualTo
						Return "LessThanOrEqualTo"
					Case DynamicFilterResourceIdentifiers.Like
						Return "Like"
					Case DynamicFilterResourceIdentifiers.Match
						Return "Match"
					Case DynamicFilterResourceIdentifiers.NotEquals
						Return "NotEquals"
					Case DynamicFilterResourceIdentifiers.ExpressionMATCH
                        Return "Expression MATCH"
'					#End Region

					Case Else
						Return String.Empty
				End Select
			End If
		End Function
		#End Region
	End Class
End Namespace

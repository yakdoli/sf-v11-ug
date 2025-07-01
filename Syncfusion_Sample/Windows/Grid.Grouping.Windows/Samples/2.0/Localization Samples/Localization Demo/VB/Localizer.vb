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
Imports Syncfusion.Windows.Forms.Grid.Grouping.Localization
Namespace DynamicFilter
	Friend Class Localizer
		Implements ILocalizationProvider
		Private comparerList As Boolean = False
		Private recordNavigBar As Boolean = False
		Private office2007Filter As Boolean = False
		Private fieldChooserDialog As Boolean = False
		Public Sub getstring(ByVal s As Boolean, ByVal recordNavig As Boolean, ByVal office2007 As Boolean, ByVal fieldChooser As Boolean)
			comparerList = s
			recordNavigBar = recordNavig
			office2007Filter = office2007
			fieldChooserDialog = fieldChooser
		End Sub
		Public Function GetLocalizedString(ByVal culture As System.Globalization.CultureInfo, ByVal name As String, ByVal obj As Object) As String Implements ILocalizationProvider.GetLocalizedString
			Select Case name
				Case DynamicFilterResourceIdentifiers.StartsWith
					If comparerList Then
						Return "empieza con"
					Else
						Return "StartsWith"
					End If
				Case DynamicFilterResourceIdentifiers.EndsWith
					If comparerList Then
						Return "termina con"
					Else
						Return "EndsWith"
					End If
                Case DynamicFilterResourceIdentifiers.Equal
                    If comparerList Then
                        Return "es igual a"
                    Else
                        Return "Equals"
                    End If
				Case DynamicFilterResourceIdentifiers.GreaterThan
					If comparerList Then
						Return "mayor que"
					Else
						Return "GreaterThan"
					End If
				Case DynamicFilterResourceIdentifiers.GreaterThanOrEqualTo
					If comparerList Then
						Return "Mayor o igual a"
					Else
						Return "GreaterThanOrEqualTo"
					End If
				Case DynamicFilterResourceIdentifiers.LessThan
					If comparerList Then
						Return "menos que"
					Else
						Return "LessThan"
					End If
				Case DynamicFilterResourceIdentifiers.LessThanOrEqualTo
					If comparerList Then
						Return "Menor o igual a"
					Else
						Return "LessThanOrEqualTo"
					End If
				Case DynamicFilterResourceIdentifiers.Like
					If comparerList Then
						Return "como"
					Else
						Return "Like"
					End If
				Case DynamicFilterResourceIdentifiers.Match
					If comparerList Then
						Return "partido"
					Else
						Return "Match"
					End If
				Case DynamicFilterResourceIdentifiers.NotEquals
					If comparerList Then
						Return "no es igual"
					Else
						Return "NotEqual"
					End If
				Case DynamicFilterResourceIdentifiers.ExpressionMATCH
					If comparerList Then
						Return "expresión de coincidencia"
					Else
						Return "ExpressionMATCH"
					End If

				Case GroupingResourceIdentifiers.RecordNavigatorOF
					If recordNavigBar Then
						Return "von"
					Else
						Return "Of"
					End If

				' DropDown filter item 

				Case DynamicFilterResourceIdentifiers.All
					Return "(todo)"
				Case DynamicFilterResourceIdentifiers.Custom
					Return "(costumbre)"
				Case DynamicFilterResourceIdentifiers.Empty
					Return "(vacío)"

				'Drag group column
				Case GroupingResourceIdentifiers.DragColumnHeaderHereText
					Return "Ziehen Sie die Spaltenüberschrift"

				Case DynamicFilterResourceIdentifiers.FieldDialogBox
					If fieldChooserDialog Then
						Return "Dialogfeld Feld"
					Else
						Return "FieldChooser"
					End If
				Case DynamicFilterResourceIdentifiers.FieldTreeDialogBox
					If fieldChooserDialog Then
						Return "Feld Baum Dialogfeld"
					Else
						Return "FieldChooser"
					End If

				Case DynamicFilterResourceIdentifiers.SelectAll
					If office2007Filter Then
						Return "Alle auswählen"
					Else
						Return "SelectAll"
					End If
				Case DynamicFilterResourceIdentifiers.SortAtoZ
					If office2007Filter Then
						Return "&SortierenAbisZ"
					Else
						Return "&SortAtoZ"
					End If
				Case DynamicFilterResourceIdentifiers.SortZtoA
					If office2007Filter Then
						Return "S&ortierenZbisA"
					Else
						Return "S&ortZtoA"
					End If
				Case DynamicFilterResourceIdentifiers.TextFilters
					If office2007Filter Then
						Return "&Text-Filter"
					Else
						Return "TextFilters"
					End If
				Case DynamicFilterResourceIdentifiers.ClearFilterFrom
					If office2007Filter Then
						Return "&Von Filterstundenzähler"
					Else
						Return "ClearFilterFrom"
					End If
				Case DynamicFilterResourceIdentifiers.Office2007FilterOK
					If office2007Filter Then
						Return "Ok"
					Else
						Return "Ok"
					End If
				Case DynamicFilterResourceIdentifiers.Office2007FilterCancel
					If office2007Filter Then
						Return "Stornieren"
					Else
						Return "Cancel"
					End If
				Case DynamicFilterResourceIdentifiers.showstherowswhere
					If office2007Filter Then
						Return "Zeigt die Zeilen, in denen"
					Else
						Return "Shows the rows where:"
					End If
				Case DynamicFilterResourceIdentifiers.CustomAutoFilter
					If office2007Filter Then
						Return "Benutzerdefinierte Auto Filter"
					Else
						Return "CustomAutoFilter"
					End If
				Case DynamicFilterResourceIdentifiers.CustomAutoFilterLessthan
					If office2007Filter Then
						Return "Kleiner als"
					Else
						Return "LessThan"
					End If
				Case DynamicFilterResourceIdentifiers.CustomAutoFilterEqual
					If office2007Filter Then
						Return "Equal"
					Else
						Return "Equal"
					End If
				Case DynamicFilterResourceIdentifiers.CustomAutoFilterNotequal
					If office2007Filter Then
						Return "notEqual"
					Else
						Return "NotEqual"
					End If
				Case DynamicFilterResourceIdentifiers.CustomAutoFilterGreaterthan
					If office2007Filter Then
						Return "Größer als"
					Else
						Return "Greaterthan"
					End If
				Case DynamicFilterResourceIdentifiers.CustomAutoFilterGreaterthanOrEqual
					If office2007Filter Then
						Return "Größer oder gleich"
					Else
						Return "GreaterthanOrEqual"
					End If
				Case DynamicFilterResourceIdentifiers.CustomAutoFilterlessthanOrEqual
					If office2007Filter Then
						Return "LessThan oder-gleich-"
					Else
						Return "LessthanOrEqual"
					End If
				Case DynamicFilterResourceIdentifiers.CustomAutoFilterLike
					If office2007Filter Then
						Return "wie"
					Else
						Return "Like"
					End If
				Case DynamicFilterResourceIdentifiers.CustomAutoFilterMatch
					If office2007Filter Then
						Return "Spiel"
					Else
						Return "Match"
					End If
				Case DynamicFilterResourceIdentifiers.CustomAutoFilterBeginsWith
					If office2007Filter Then
						Return "Beginntmit"
					Else
						Return "BeginsWith"
					End If
				Case DynamicFilterResourceIdentifiers.CustomAutoFilterEndsWith
					If office2007Filter Then
						Return "Endetmit"
					Else
						Return "EndsWith"
					End If
				Case DynamicFilterResourceIdentifiers.CustomAutoFilterCancel
					If office2007Filter Then
						Return "stornieren"
					Else
						Return "Cancel"
					End If
				Case DynamicFilterResourceIdentifiers.CustomAutoFilterOK
					If office2007Filter Then
						Return "OK"
					Else
						Return "Ok"
					End If
				Case DynamicFilterResourceIdentifiers.Office2007FilterEquals
					If office2007Filter Then
						Return "Equals"
					Else
						Return "Equals"
					End If
				Case DynamicFilterResourceIdentifiers.Office2007FilterNotEquals
					If office2007Filter Then
						Return "NotEqual"
					Else
						Return "NotEqual"
					End If
				Case DynamicFilterResourceIdentifiers.Office2007FilterBeginswith
					If office2007Filter Then
						Return "Beginntmit"
					Else
						Return "BeginsWith"
					End If
				Case DynamicFilterResourceIdentifiers.Office2007FilterEndswith
					If office2007Filter Then
						Return "Endetmit"
					Else
						Return "Endswith"
					End If
				Case DynamicFilterResourceIdentifiers.Office2007FilterContains
					If office2007Filter Then
						Return "enthält"
					Else
						Return "Contains"
					End If
				Case DynamicFilterResourceIdentifiers.Office2007FilterCustomFilter
					If office2007Filter Then
						Return "Benutzerdefinierte Filter"
					Else
						Return "CustomFilter"
					End If
				Case DynamicFilterResourceIdentifiers.Office2007FilterCustomFilterand
					If office2007Filter Then
						Return "und"
					Else
						Return "And"
					End If
				Case DynamicFilterResourceIdentifiers.Office2007FilterCustomFilteror
					If office2007Filter Then
						Return "oder"
					Else
						Return "Or"
					End If
				Case Else
					Return String.Empty
			End Select
		End Function
	End Class
End Namespace




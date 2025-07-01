Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2011"
' Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
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

Imports System.Threading


Friend Class Localizer
    Implements ILocalizationProvider
#Region "ILocalizationProvider Members"

    Private messageBoxLoc As Boolean = False
    Public Sub getstring(ByVal s As Boolean)
        messageBoxLoc = s
    End Sub
    Public Function GetLocalizedString(ByVal culture As System.Globalization.CultureInfo, ByVal name As String, ByVal obj As Object) As String Implements ILocalizationProvider.GetLocalizedString
        If messageBoxLoc Then
            Select Case name
                '					#Region "Menu Package"

                Case GridResourceIdentifiers.Cannotchangepartofamergedcell
                    Return "Kann nicht von einer verbundenen Zelle changepart"
                Case ResourceIdentifiers.OK
                    Return "Ok"

                Case ResourceIdentifiers.Cancel
                    Return "stornieren"
                    '					#End Region

                Case Else
                    Return String.Empty
            End Select
        Else
            Select Case name
                '					#Region "Menu Package"

                Case GridResourceIdentifiers.Cannotchangepartofamergedcell
                    Return "Cannot change part of a mergedcell "
                Case ResourceIdentifiers.OK
                    Return "OK"

                Case ResourceIdentifiers.Cancel
                    Return "Cancel"
                    '					#End Region

                Case Else
                    Return String.Empty
            End Select
        End If

    End Function
#End Region
End Class


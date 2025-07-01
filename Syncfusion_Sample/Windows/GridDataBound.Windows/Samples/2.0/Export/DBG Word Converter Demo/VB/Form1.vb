Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2008"
'
'  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.GridHelperClasses

Namespace DBGWordConverter_2005
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Partial Public Class Form1
        Inherits Form
        Private ds As DataSet
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Try
                Dim ico As New Icon(GetIconFile("Common\Images\Grid\Icon\sfgrid1.ico"))
				Me.Icon = ico
			Catch
			End Try
		End Sub

		''' <summary>
		''' Get the path of the icon file.
		''' </summary>
		''' <param name="bitmapName">IconFile name.</param>
		''' <returns>Icon file location.</returns>
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		''' <summary>
		''' Loads the 'northwindDataSet.Customers' table into the form1.
		''' </summary>
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ds = New DataSet()
            ReadXml(ds, "Common\Data\GDBDdata.XML")
            Me.gridDataBoundGrid1.DataSource = ds.Tables("Customers")
        End Sub


		''' <summary>
		''' Export the grid contents to word file.
		''' </summary>
		Private Sub btn_Export(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim converter As New GridWordConverter(True,True)
			AddHandler converter.DrawFooter, AddressOf converter_DrawFooter
			AddHandler converter.DrawHeader, AddressOf converter_DrawHeader
			converter.GridToWord("Sample.doc", gridDataBoundGrid1)
			System.Diagnostics.Process.Start("Sample.doc")
        End Sub
        ''' <summary>
        ''' Get the path of xml file.
        ''' </summary>
        ''' <param name="bitmapName">XmlFile name.</param>
        ''' <returns>XmlFile location.</returns>
        Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
            Dim n As Integer
            For n = 0 To 10
                If System.IO.File.Exists(xmlFileName) Then
                    ds.ReadXml(xmlFileName)
                    Exit For
                End If
                xmlFileName = "..\" + xmlFileName
            Next n
        End Sub 'ReadXml

		''' <summary>
		''' Header Event to create an header that will display on each page.
		''' </summary>
		Private Sub converter_DrawHeader(ByVal sender As Object, ByVal e As DocHeaderFooterEventArgs)
			e.Header.AddParagraph().AppendText("Syncfusion Inc.")
		End Sub

		''' <summary>
		''' Footer Event to create a footer that will display on each page.
		''' </summary>
		Private Sub converter_DrawFooter(ByVal sender As Object, ByVal e As DocHeaderFooterEventArgs)
			e.Footer.AddParagraph().AppendText("Copyright 2001-2008")
		End Sub
	End Class
End Namespace
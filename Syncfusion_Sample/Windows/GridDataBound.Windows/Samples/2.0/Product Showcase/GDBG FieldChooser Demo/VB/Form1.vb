#Region "Copyright Syncfusion Inc. 2001 - 2011"
' Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlServerCe
Imports Syncfusion.GridHelperClasses

Namespace GDBGFieldChooserDemo
    Partial Class Form1 : Inherits Form
        Public Sub New()
            InitializeComponent()
            Try
                Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
                Me.Icon = ico
            Catch ex As Exception

            End Try

            AddHandler Me.Load, AddressOf Form1_Load
        End Sub

        Private Function GetIconFile(ByVal bitmapName As String) As String
            For n As Integer = 0 To 9
                If System.IO.File.Exists(bitmapName) Then
                    Return bitmapName
                End If

                bitmapName = "..\" & bitmapName
            Next n

            Return bitmapName
        End Function
        Public Shared ReadOnly connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")


        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim commandstring As String = "select * from Products"
            Dim da As SqlCeDataAdapter = New SqlCeDataAdapter(commandstring, connString)


            Dim ds As DataSet = New DataSet()

            da.Fill(ds, "Customers")

            Me.GridDataBoundGrid1.ThemesEnabled = True
            Me.GridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue


            GridDataBoundGrid1.DataSource = ds.Tables(0)
            Dim fchooser As GridDataBoundFieldChooser = New GridDataBoundFieldChooser()
            fchooser.WireGrid(Me.GridDataBoundGrid1)
        End Sub
        Private Shared Function FindFile(ByVal fileName As String) As String
            ' Check both in parent folder and Parent\Data folders.
            Dim dataFileName As String = "Common\Data\" & fileName
            For n As Integer = 0 To 11
                If System.IO.File.Exists(fileName) Then
                    Return New IO.FileInfo(fileName).FullName
                End If
                If System.IO.File.Exists(dataFileName) Then
                    Return New IO.FileInfo(dataFileName).FullName
                End If
                fileName = "..\" & fileName
                dataFileName = "..\" & dataFileName
            Next n

            Return fileName
        End Function

        Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace

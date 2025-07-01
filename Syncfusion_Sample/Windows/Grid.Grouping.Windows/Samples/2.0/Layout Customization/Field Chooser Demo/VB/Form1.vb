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
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.GridHelperClasses
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO

Partial Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Public Sub New()
        InitializeComponent()
        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch ex As Exception

        End Try
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False

    End Sub
    Public Shared ReadOnly connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
    Private Function GetIconFile(ByVal bitmapName As String) As String
        For n As Integer = 0 To 9
            If System.IO.File.Exists(bitmapName) Then
                Return bitmapName
            End If

            bitmapName = "..\" & bitmapName
        Next n

        Return bitmapName
    End Function


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim commandstring As String = "select * from Products"
        Dim da As New SqlCeDataAdapter(commandstring, connString)

        Dim ds As New DataSet()

        da.Fill(ds, "Customers")


        gridGroupingControl1.DataSource = ds.Tables(0)

        Dim fchooser As New FieldChooser(Me.gridGroupingControl1)
    End Sub
    Private Shared Function FindFile(ByVal fileName As String) As String
        ' Check both in parent folder and Parent\Data folders.
        Dim dataFileName As String = "Common\Data\" & fileName
        For n As Integer = 0 To 11
            If System.IO.File.Exists(fileName) Then
                Return New FileInfo(fileName).FullName
            End If
            If System.IO.File.Exists(dataFileName) Then
                Return New FileInfo(dataFileName).FullName
            End If
            fileName = "..\" & fileName
            dataFileName = "..\" & dataFileName
        Next n

        Return fileName
    End Function

End Class


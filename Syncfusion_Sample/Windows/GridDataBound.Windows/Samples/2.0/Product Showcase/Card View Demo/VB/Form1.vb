Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System.IO
Imports Syncfusion.GridHelperClasses

Namespace CardViewDemo
	Partial Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private ds As DataSet
		Private card As New GridCardView()
		Public Sub New()
			InitializeComponent()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			Me.gridDataBoundGrid1.DefaultRowHeight = 18
			Me.gridDataBoundGrid1.DefaultColWidth = 70
			ds = New DataSet()
            ReadXml(ds, "Common\Data\GDBDdata.XML")
            Me.gridDataBoundGrid1.DataSource = ds.Tables("Products")
            Me.gridDataBoundGrid1.Model.EnableLegacyStyle = False
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.gridDataBoundGrid1.BackColor = Color.White
			Me.comboBoxAdv2.SelectedIndex = 1
			Me.ComboBoxAdv1.SelectedIndex = 0

			card.CaptionField = "ProductName"
			card.CardSpacingWidth = 10
			card.CardSpacingHeight = 10
			card.MaxCardCols = 5
            card.CaptionHeight = 35
            card.CardBackColor = Color.Lavender
            card.WireGrid(Me.gridDataBoundGrid1)
            Me.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Table())
			Me.gridDataBoundGrid1.Refresh()
            Settings()
        End Sub

		Private Sub Settings()
			card.ShowCardCellBorders = If(checkBox1.Checked, True, False)
			card.ApplyRoundedCorner = If(checkBox3.Checked, True, False)
			card.BrowseOnly = If(checkBox4.Checked, True, False)
			card.ShowCaption = If(checkBox2.Checked, True, False)
			AutoFit()
		End Sub
		Private Sub AutoFit()
			Me.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Table())
			Me.gridDataBoundGrid1.Refresh()
        End Sub


		Private Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Exit For
				End If
				xmlFileName = "..\" & xmlFileName
			Next n
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
        Private Sub ComboBoxAdv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBoxAdv1.SelectedIndexChanged
            Select Case Me.ComboBoxAdv1.SelectedItem.ToString()
                Case "Office2010Blue"
                    card.VisualStyle = CardVisualStyles.Office2010Blue
                Case "Office2010Black"
                    card.VisualStyle = CardVisualStyles.Office2010Black
                Case "Office2010Silver"
                    card.VisualStyle = CardVisualStyles.Office2010Silver
                Case "Office2007Blue"
                    card.VisualStyle = CardVisualStyles.Office2007Blue
                Case "Office2007Black"
                    card.VisualStyle = CardVisualStyles.Office2007Black
                Case "Office2007Silver"
                    card.VisualStyle = CardVisualStyles.Office2007Silver
                Case "Metro"
                    card.VisualStyle = CardVisualStyles.Metro
                Case "System"
                    card.VisualStyle = CardVisualStyles.System
                Case Else
                    card.VisualStyle = CardVisualStyles.None
            End Select
            AutoFit()
        End Sub

		Private Sub comboBoxAdv2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxAdv2.SelectedIndexChanged
			Select Case Me.comboBoxAdv2.SelectedItem.ToString()
				Case "MergedLabels"
					card.CardStyle = CardStyle.MergedLabels
				Case "StandardLabels"
                    card.CardStyle = CardStyle.StandardLabels
                    Me.gridDataBoundGrid1.Model.ColWidths(2) = 25
			End Select
			AutoFit()
		End Sub


        Private Sub CheckChanged(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox4.CheckedChanged, checkBox3.CheckedChanged, checkBox2.CheckedChanged, checkBox1.CheckedChanged
            Settings()
        End Sub
    End Class
End Namespace
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools.XPMenus

Namespace TabbedMDI_2005
	Partial Public Class Document1
		Inherits Office2007Form
		Private fontSize As Single = 12F

		Public Sub New(ByVal docName As String)
			MyBase.New()
			InitializeComponent()
			Me.Text = docName
			Me.Name = docName
		End Sub

		Private Class FontSizes
			Public Shared Small As Single
			Public Shared Medium As Single
			Public Shared Large As Single
			Shared Sub New()
				Small = 8f
				Medium = 12f
				Large = 24f
			End Sub
		End Class

		Private fontFamily As FontFamily
		Private checkedItem As String = ""
		Private Sub FormatFont_Clicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_SansSerif.Click, barItem_times.Click, barItem_courier.Click, barItem4.Click, barItem5.Click, barItem6.Click
			Dim miClicked As BarItem = CType(sender, BarItem)
			miClicked.Checked = True
			For Each item As BarItem In Me.parentBarItem1.Items
				If item.Text <> miClicked.Text Then
					item.Checked = False
				End If
			Next item
			For Each item As BarItem In Me.parentBarItem2.Items
				If item.Text <> miClicked.Text Then
					item.Checked = False
				End If
			Next item

			fontSize = CurrentFontSize(miClicked)
			For Each item As BarItem In Me.parentBarItem1.Items
				If item.Checked Then
					checkedItem = item.Text
				End If
			Next item
			fontFamily = CurrentFont(checkedItem)
			Me.richTextBox1.Font = New Font(fontFamily, fontSize)
		End Sub

		Private common As FontFamily
		Private Function CurrentFont(ByVal currentBarItem As String) As FontFamily
			If currentBarItem = Me.barItem_SansSerif.Text Then
				common = New FontFamily("Microsoft Sans Serif")
			ElseIf currentBarItem = Me.barItem_courier.Text Then
				common = New FontFamily("Courier New")
			Else
				common = New FontFamily("Times New Roman")
			End If
			Return common
		End Function

		Private Function CurrentFontSize(ByVal currentBarItem As BarItem) As Single
			Dim fontCurrent As Single = 0F
			If currentBarItem.Text.Equals("Small") Then
				fontCurrent = FontSizes.Small
			ElseIf currentBarItem.Text.Equals("Medium") Then
				fontCurrent = FontSizes.Medium
			ElseIf currentBarItem.Text.Equals("Large") Then
				fontCurrent = FontSizes.Large
			Else
				fontCurrent = fontSize
			End If
			Return fontCurrent
		End Function
	End Class
End Namespace
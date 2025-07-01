Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Grid
Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms

Namespace PivotGridLibrary
	#Region "CellModel"

	Public Class PivotButtonCellModel
		Inherits GridStaticCellModel
		Public Sub New(ByVal grid As GridModel)
			MyBase.New(grid)
		End Sub

		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New PivotButtonCellRenderer(control, Me)
		End Function
	End Class
	#End Region

	#Region "Cell Renderer"

	Public Class PivotButtonCellRenderer
		Inherits GridStaticCellRenderer
		Private pushButton As GridCellButton

		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
            pushButton = New GridCellButton(Me)
            AddButton(pushButton)
			'AddButton(pushButton = new GridDataBoundTreeCellButton(this));
			Me.ForceRefreshOnActivateCell = True
		End Sub

		Protected Overrides Function OnLayout(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo, ByVal innerBounds As Rectangle, ByVal buttonsBounds As Rectangle()) As Rectangle
			Dim buttonWidth As Integer = 11
			Dim buttonHeight As Integer = 10
			buttonsBounds(0) = GridUtil.CenterInRect(New Rectangle(innerBounds.X, innerBounds.Y, buttonWidth + 5, buttonHeight + 5), New Size(buttonWidth, buttonHeight))
			pushButton.Text = style.Description
			innerBounds = New Rectangle(innerBounds.X + buttonWidth + 2, innerBounds.Y, innerBounds.Width - buttonWidth, innerBounds.Height)
			Return innerBounds
		End Function

		''' <override/>
'INSTANT VB NOTE: Embedded comments are not maintained by Instant VB
'ORIGINAL LINE: protected /*internal*/ override void OnOutlineCurrentCell(Graphics g, Rectangle r)
		Protected Overrides Sub OnOutlineCurrentCell(ByVal g As Graphics, ByVal r As Rectangle)
			' do nothing
		End Sub

		''' <override/>
		Protected Overrides Function OnQueryShowButtons(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo) As Boolean
			Return True
		End Function

		Protected Overrides Sub OnDrawCellButton(ByVal button As GridCellButton, ByVal g As Graphics, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal bActive As Boolean, ByVal style As GridStyleInfo)

			'directly call the draw to avoid base class and focus rectangle...
			button.Text = ""
			button.Draw(g, rowIndex, colIndex, False, style)

			Dim faceRect As Rectangle = button.Bounds
			faceRect.Inflate(-2, -1)
			Dim text As String = style.Description
			If Not text Is Nothing AndAlso text.Length > 0 Then
				Using font As Font = New Font(style.Font.Facename, CSng(7.0))

					Dim format As StringFormat = New StringFormat()
					format.Alignment = StringAlignment.Center
					format.LineAlignment = StringAlignment.Center
					format.HotkeyPrefix = style.HotkeyPrefix
					format.Trimming = style.Trimming
					If (Not style.WrapText) Then
						format.FormatFlags = StringFormatFlags.NoWrap
					End If

					Dim textColor As Color
					If Grid.PrintingMode AndAlso Grid.Model.Properties.BlackWhite Then
						textColor = Color.Black
					Else
						textColor = style.TextColor
					End If

					g.DrawString(text, font, New SolidBrush(textColor), faceRect, format)
				End Using
			End If
			'base.OnDrawCellButton(button, g, rowIndex, colIndex, false, style);
		End Sub
		''' <override/>
		Protected Overrides Sub OnButtonClicked(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal button As Integer)
			MyBase.OnButtonClicked(rowIndex, colIndex, button)
			OnPushButtonClick(rowIndex, colIndex)
		End Sub


		''' <summary>
		''' Raises <see cref="GridControlBase.PushButtonClick"/> event when the user presses the PushButton.
		''' </summary>
		''' <param name="rowIndex">Specifies the row id.</param>
		''' <param name="colIndex">Specifies the column id.</param>
		Protected Overridable Sub OnPushButtonClick(ByVal rowIndex As Integer, ByVal colIndex As Integer)
			Grid.RaisePushButtonClick(rowIndex, colIndex)
		End Sub
	End Class
	#End Region
End Namespace

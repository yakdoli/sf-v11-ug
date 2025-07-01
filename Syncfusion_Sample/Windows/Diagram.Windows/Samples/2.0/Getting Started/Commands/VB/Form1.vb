Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace Commands
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			AddHandler Application.Idle, AddressOf Application_Idle
		End Sub

		Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
			cutToolStripButton.Enabled = diagram1.CanCut
			copyToolStripButton.Enabled = diagram1.CanCopy
			alignLeftToolStripButton.Enabled = diagram1.View.SelectionList.Count >= 2
			alignMiddleToolStripButton.Enabled = alignLeftToolStripButton.Enabled
			alignRightToolStripButton.Enabled = alignLeftToolStripButton.Enabled
			alignTopToolStripButton.Enabled = alignLeftToolStripButton.Enabled
			alignBottomToolStripButton.Enabled = alignLeftToolStripButton.Enabled
			alignCenterToolStripButton.Enabled = alignLeftToolStripButton.Enabled
			flipHorizontalToolStripButton.Enabled = diagram1.View.SelectionList.Count > 0
			flipVerticalToolStripButton.Enabled = flipHorizontalToolStripButton.Enabled
			rotateLeftToolStripButton.Enabled = flipHorizontalToolStripButton.Enabled
			rotateRightToolStripButton.Enabled = flipHorizontalToolStripButton.Enabled
			spaceAcrossToolStripButton.Enabled = alignLeftToolStripButton.Enabled
			spaceDownToolStripButton.Enabled = alignLeftToolStripButton.Enabled
			sameWidthToolStripButton.Enabled = alignLeftToolStripButton.Enabled
			sameHeightToolStripButton.Enabled = alignLeftToolStripButton.Enabled
			sameSizeToolStripButton.Enabled = alignLeftToolStripButton.Enabled

		End Sub



		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.diagram1.LoadBinary("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Commands.edd")
		End Sub

		Private Sub toolStrip1_ItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles toolStrip1.ItemClicked
			Select Case e.ClickedItem.Text
				Case "Cut"
					diagram1.Controller.Cut()
					pasteToolStripButton.Enabled = True
				Case "Copy"
					diagram1.Controller.Copy()
					pasteToolStripButton.Enabled = True
				Case "Paste"
					diagram1.Controller.Paste()
					pasteToolStripButton.Enabled = False
				Case "Align" & Constants.vbLf & "Left"
					diagram1.AlignLeft()
				Case "Align" & Constants.vbLf & "Center"
					diagram1.AlignCenter()
				Case "Align" & Constants.vbLf & "Right"
					diagram1.AlignRight()
				Case "Align" & Constants.vbLf & "Top"
					diagram1.AlignTop()
				Case "Align" & Constants.vbLf & "Middle"
					diagram1.AlignMiddle()
				Case "Align" & Constants.vbLf & "Bottom"
					diagram1.AlignBottom()
				Case "Rotate" & Constants.vbLf & "Left"
					diagram1.Rotate(90)
				Case "Rotate" & Constants.vbLf & "Right"
					diagram1.Rotate(-90)
				Case "Flip" & Constants.vbLf & "Vertical"
					diagram1.FlipVertical()
				Case "Flip" & Constants.vbLf & "Horizontal"
					diagram1.FlipHorizontal()
				Case "Space" & Constants.vbLf & "Across"
					diagram1.SpaceAcross()
				Case "Space" & Constants.vbLf & "Down"
					diagram1.SpaceDown()
				Case "Same" & Constants.vbLf & "Width"
					diagram1.SameWidth()
				Case "Same" & Constants.vbLf & "Height"
					diagram1.SameHeight()
				Case "Same" & Constants.vbLf & "Size"
					diagram1.SameSize()

			End Select
		End Sub
	End Class
End Namespace
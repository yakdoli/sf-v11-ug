#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace PopupsInDepth
    ' Implementing IPopupParent gives more control over the alignment and 
    ' activation/deactivation of the popup.
    Public Class TextBoxWithPopup
        Inherits TextBox
        Implements IPopupParent
        Private WithEvents popupContainer As PopupControlContainer
        Private WithEvents popupTextBox_ As TextBox
        Public WithEvents friendlyControl_ As Control
        'Fields
        'Constructors
        'Events
        'Methods
        Public Sub New()
            'Warning: Implementation not found
        End Sub
        Public Property PopupControlContainer() As PopupControlContainer
            Get

                Return Me.popupContainer

            End Get
            Set(ByVal Value As PopupControlContainer)

                If (Me.popupContainer Is Value) = False Then
                    Me.popupContainer = Value
                    Me.popupContainer.PopupParent = Me
                    AddHandler Me.popupContainer.BeforePopup, New CancelEventHandler(AddressOf BeforePopup)
                    AddHandler Me.popupContainer.Popup, New EventHandler(AddressOf AfterPopup)
                    ' Make sure to unsubscribe somewhere in your application.
                End If

            End Set
        End Property
        ' The text box in the popup.
        Public Property PopupTextBox() As TextBox
            Get

                Return Me.popupTextBox_

            End Get
            Set(ByVal Value As TextBox)

                Me.popupTextBox_ = Value

            End Set
        End Property
        ' Control which when selected will not close the popup.
        Public Property FriendlyControl() As Control
            Get

                Return Me.friendlyControl_

            End Get
            Set(ByVal Value As Control)

                Me.friendlyControl_ = Value

            End Set
        End Property
        Public Overridable Overloads Function IsRelatedControl(ByVal control As Control, ByVal askPopupParent As Boolean) As Boolean Implements Syncfusion.Windows.Forms.IPopupItem.IsRelatedControl

            ' The popup will then not lose focus automatically when Controls below
            ' get the focus.
            If ((control Is Me.friendlyControl_) _
                        OrElse (control Is Me)) Then
                Return True
            Else
                Return False
            End If

        End Function
        Public Overridable Overloads Function GetPopupParentControl() As Control Implements Syncfusion.Windows.Forms.IPopupItem.GetPopupParentControl

            ' Popup will align around this control if GetLocationForPopupAlignment\
            ' returned Point.Empty.
            Return Me

        End Function
        Public Overridable Overloads Function GetBorderOverlapCue(ByVal relativeAlignment As PopupRelativeAlignment) As Point() Implements Syncfusion.Windows.Forms.IPopupParent.GetBorderOverlapCue

            Dim bounds As Rectangle
            bounds = Me.Bounds
            ' This utility fucntion takes a rectangular bounds and relative alignemnt
            ' and returns a line (array of 2 points) that represet the boundary
            ' for the specified alignemnt.
            Return PopupUtils.ComputeDefaultBorderOverlapCue(relativeAlignment, Me.RectangleToScreen(bounds))

        End Function
        ' Lets you provide a preferred location for popup.
        Public Overridable Overloads Function GetLocationForPopupAlignment(ByVal prevAlignment As PopupRelativeAlignment, ByRef newAlignment As PopupRelativeAlignment) As Point Implements Syncfusion.Windows.Forms.IPopupParent.GetLocationForPopupAlignment

            Dim bounds As Rectangle
            bounds = Me.Bounds
            ' This utility method takes a rectangle and returns the 8 positions around
            ' it 1 at a time. It will start with the alignment specified in the 3rd argument.
            Dim pos As Point
            pos = PopupUtils.ComputeDefaultPopupAlignment(prevAlignment, newAlignment, PopupRelativeAlignment.RightTop, PopupRelativeAlignment.RightTop, bounds)
            Return Me.Parent.PointToScreen(pos)

        End Function
        Public Overridable Overloads Sub ChildClosing(ByVal childUI As IPopupChild, ByVal popupCloseType As PopupCloseType) Implements Syncfusion.Windows.Forms.IPopupParent.ChildClosing

            ' Transfer data from the popup.
            ' Set focus back to textbox.
            If (popupCloseType = popupCloseType.Done) Then
                Me.Text = Me.PopupTextBox.Text
            End If
            If ((popupCloseType = popupCloseType.Done) _
                        OrElse (popupCloseType = popupCloseType.Canceled)) Then
                Me.Focus()
            End If

        End Sub

        ' Open/Close popup.
        Protected Overloads Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)

            ' If user pressed key down, then show the popup.
            ' Escape should close the popup.
            If ((e.Alt _
                        AndAlso (e.KeyCode = Keys.Down)) _
                        AndAlso Not (Me.PopupControlContainer.IsShowing)) Then
                ' Let the popup align around the source textBox.
                Me.PopupControlContainer.ParentControl = Me.popupTextBox_
                ' Passing Point.Empty will align it automatically around the above ParentControl.
                Me.PopupControlContainer.ShowPopup(Point.Empty)
                e.Handled = True
            End If
            If ((e.KeyCode = Keys.Escape) _
                        AndAlso Me.PopupControlContainer.IsShowing) Then
                Me.PopupControlContainer.HidePopup(PopupCloseType.Canceled)
            End If
            MyBase.OnKeyDown(e)

        End Sub
        Private Sub BeforePopup(ByVal sender As Object, ByVal args As CancelEventArgs)

            ' Set the text to be edited with the text in the form text box.
            Me.PopupTextBox.Text = Me.Text

        End Sub
        Private Sub AfterPopup(ByVal sender As Object, ByVal args As EventArgs)

            ' Set the focus on the text box inside the popup after its open.
            Me.PopupTextBox.Focus()
            Me.PopupTextBox.SelectionStart = 0
            Me.PopupTextBox.SelectionLength = 0

        End Sub

        Public ReadOnly Property IsRightToLeft() As Boolean Implements Syncfusion.Windows.Forms.IPopupParent.IsRightToLeft
            Get
                Return Me.RightToLeft = RightToLeft.Yes
            End Get
        End Property
    End Class
End Namespace

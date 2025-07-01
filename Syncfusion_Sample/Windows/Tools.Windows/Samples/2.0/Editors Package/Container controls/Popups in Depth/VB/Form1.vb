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
	Imports System
	Imports System.Drawing
	Imports System.Collections
	Imports System.ComponentModel
	Imports System.Windows.Forms
	Imports System.Data
	Imports Syncfusion.Windows.Forms
	Imports Syncfusion.Windows.Forms.Tools
	Imports Syncfusion.Windows.Forms.Tools.XPMenus
Namespace PopupsInDepth

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private WithEvents popupControlContainer1 As Syncfusion.Windows.Forms.PopupControlContainer
		Private label1 As System.Windows.Forms.Label
		Private WithEvents sourceTextBox As TextBoxWithPopup
		Private popupTextBox_ As System.Windows.Forms.TextBox
		Private WithEvents OK As System.Windows.Forms.Button
		Private WithEvents cancelButton_ As System.Windows.Forms.Button
		Private WithEvents popupInvokeButton As System.Windows.Forms.Button
		Private WithEvents popupMenuButton As System.Windows.Forms.Button
		Private popupMenu As PopupMenu
		Private imageList1 As System.Windows.Forms.ImageList
		Private imageList2 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer()
            Me.cancelButton_ = New System.Windows.Forms.Button()
            Me.OK = New System.Windows.Forms.Button()
            Me.popupTextBox_ = New System.Windows.Forms.TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.sourceTextBox = New PopupsInDepth.TextBoxWithPopup()
            Me.popupInvokeButton = New System.Windows.Forms.Button()
            Me.popupMenuButton = New System.Windows.Forms.Button()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.popupControlContainer1.SuspendLayout()
            Me.SuspendLayout()
            '
            'popupControlContainer1
            '
            Me.popupControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.popupControlContainer1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cancelButton_, Me.OK, Me.popupTextBox_})
            Me.popupControlContainer1.Location = New System.Drawing.Point(152, 112)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.Size = New System.Drawing.Size(120, 136)
            Me.popupControlContainer1.TabIndex = 0
            Me.popupControlContainer1.Visible = False
            '
            'cancelButton_
            '
            Me.cancelButton_.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
            Me.cancelButton_.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cancelButton_.Location = New System.Drawing.Point(64, 104)
            Me.cancelButton_.Name = "cancelButton_"
            Me.cancelButton_.Size = New System.Drawing.Size(48, 24)
            Me.cancelButton_.TabIndex = 2
            Me.cancelButton_.Text = "Cancel"
            '
            'OK
            '
            Me.OK.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
            Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.OK.Location = New System.Drawing.Point(8, 104)
            Me.OK.Name = "OK"
            Me.OK.Size = New System.Drawing.Size(48, 24)
            Me.OK.TabIndex = 1
            Me.OK.Text = "OK"
            '
            'popupTextBox_
            '
            Me.popupTextBox_.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.popupTextBox_.Multiline = True
            Me.popupTextBox_.Name = "popupTextBox_"
            Me.popupTextBox_.Size = New System.Drawing.Size(118, 90)
            Me.popupTextBox_.TabIndex = 0
            Me.popupTextBox_.Text = ""
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Bitmap)
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label1.ImageIndex = 0
            Me.label1.ImageList = Me.imageList2
            Me.label1.Location = New System.Drawing.Point(8, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(280, 72)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Popup here will overlap with the Edit control to give a seamless appearance."
            '
            'imageList2
            '
            Me.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.imageList2.ImageSize = New System.Drawing.Size(32, 32)
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
            '
            'sourceTextBox
            '
            Me.sourceTextBox.FriendlyControl = Nothing
            Me.sourceTextBox.Location = New System.Drawing.Point(16, 88)
            Me.sourceTextBox.Name = "sourceTextBox"
            Me.sourceTextBox.PopupControlContainer = Nothing
            Me.sourceTextBox.PopupTextBox = Nothing
            Me.sourceTextBox.Size = New System.Drawing.Size(200, 20)
            Me.sourceTextBox.TabIndex = 2
            Me.sourceTextBox.Text = "Alt+DownArrow or button click for popup"
            '
            'popupInvokeButton
            '
            Me.popupInvokeButton.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.popupInvokeButton.Location = New System.Drawing.Point(16, 112)
            Me.popupInvokeButton.Name = "popupInvokeButton"
            Me.popupInvokeButton.Size = New System.Drawing.Size(48, 24)
            Me.popupInvokeButton.TabIndex = 3
            Me.popupInvokeButton.Text = "Popup"
            '
            'popupMenuButton
            '
            Me.popupMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.popupMenuButton.Location = New System.Drawing.Point(16, 144)
            Me.popupMenuButton.Name = "popupMenuButton"
            Me.popupMenuButton.Size = New System.Drawing.Size(96, 24)
            Me.popupMenuButton.TabIndex = 4
            Me.popupMenuButton.Text = "Popup Menu"
            '
            'imageList1
            '
            Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(200, Byte), CType(219, Byte))
            Me.ClientSize = New System.Drawing.Size(402, 280)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.popupMenuButton, Me.popupInvokeButton, Me.sourceTextBox, Me.label1, Me.popupControlContainer1})
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Popups in Depth"
            Me.popupControlContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region


		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main()
			Application.Run(New Form1())
		End Sub


		Private Sub textBoxPopupParent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sourceTextBox.KeyDown
			' If user pressed key down, then show the popup.
			If e.Alt AndAlso e.KeyCode = Keys.Down AndAlso (Not Me.popupControlContainer1.IsShowing()) Then
				' Let the popup align around the source textBox.
				Me.popupControlContainer1.ParentControl = Me.sourceTextBox
				' Passing Point.Empty will align it automatically around the above ParentControl.
				Me.popupControlContainer1.ShowPopup(Point.Empty)

				e.Handled = True
			End If
			' Escape should close the popup.
			If e.KeyCode = Keys.Escape AndAlso Me.popupControlContainer1.IsShowing() Then
				Me.popupControlContainer1.HidePopup(PopupCloseType.Canceled)
			End If

		End Sub

		Private Sub OK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.Click
			Me.popupControlContainer1.HidePopup(PopupCloseType.Done)
		End Sub

		Private Sub cancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cancelButton_.Click
			Me.popupControlContainer1.HidePopup(PopupCloseType.Canceled)
		End Sub


		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

			' Initialize the custom TextBox
			Me.sourceTextBox.PopupControlContainer = Me.popupControlContainer1
			Me.sourceTextBox.PopupTextBox = Me.popupTextBox_
			' The popup will then not close when clicking on this FriendlyControl.
			Me.sourceTextBox.FriendlyControl = Me.popupInvokeButton


			' Create a popup menu
			Me.popupMenu = New PopupMenu()
			Me.popupMenu.ParentBarItem = New ParentBarItem()

			' Init the menu with 2 items.

			Dim v As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.popupMenu.ParentBarItem.Items.Add (v)

			v.Text ="Menu Item1 "
            v.ImageList = Me.imageList1
			v.ImageIndex =0

			Dim v1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.popupMenu.ParentBarItem.Items.Add (v1)

			v1.Text ="Menu Item2 "
			v1.ImageList =Me.imageList1
			v1.ImageIndex =1


		End Sub
			#Region "ShowPopup"
		Private Sub popupInvoke_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popupInvokeButton.Click
			' Toggle popup.
			If Me.popupControlContainer1.IsShowing() Then
				Me.popupControlContainer1.HidePopup(PopupCloseType.Canceled)
			Else
				Me.popupControlContainer1.ShowPopup(Point.Empty)
			End If
		End Sub
		#End Region
			#Region "popupMenu"
		Private Sub popupMenuButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popupMenuButton.Click
			If Me.popupMenu.IsShowing() Then
				Return
			End If

			' Hide the popup if already open
			Me.popupControlContainer1.HidePopup(PopupCloseType.Canceled)

			' Show the menu now.
			' Use this method instead of the Show method in the PopupMenu
			' to allow the sourceTextBox to provide popup layout info.
			Me.popupMenu.ShowChildrenUI(Point.Empty, Me.sourceTextBox)
		End Sub
		#End Region

        ' <samplecodeblock name="Resizable Popup sample">
        ' The PopupControlContainer's BeforePopup event handler
        Private Sub popupControlContainer1_BeforePopup(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles popupControlContainer1.BeforePopup
            ' Create a reziable Popup

            ' Make the popup host's border style resizable.
            Me.popupControlContainer1.PopupHost.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.popupControlContainer1.PopupHost.BackColor = Me.BackColor

            ' Necessary to set the host's client size every time, especially since the
            ' popup's Dock style is set to DockStyle.Fill.
            If Not (Me.popupControlContainer1.PopupHost.Size.Width >= 140) Then
                Me.popupControlContainer1.PopupHost.Size = New System.Drawing.Size(140, 150)
            End If

            ' So that the popup container will Fill the entire popup host when resized.
            Me.popupControlContainer1.Dock = DockStyle.Fill
        End Sub
        ' </samplecodeblock>

       
    End Class


#Region "Implementing IPopupParent"
    ' Implementing IPopupParent gives more control over the alignment and 
    ' activation/deactivation of the popup.
    Public Class TextBoxWithPopup
        Inherits TextBox
        Implements IPopupParent
        Private popupContainer As PopupControlContainer
        Private popupTextBox_ As TextBox

        Public friendlyControl_ As Control

        Public Property PopupControlContainer() As PopupControlContainer
            Get
                Return Me.popupContainer
            End Get
            Set(ByVal Value As PopupControlContainer)
                If Not Me.popupContainer Is Value Then
                    Me.popupContainer = Value
                    Me.popupContainer.PopupParent = Me
                    AddHandler popupContainer.BeforePopup, AddressOf BeforePopup
                    AddHandler popupContainer.Popup, AddressOf AfterPopup
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

        ' Open/Close popup.
        Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
            ' If user pressed key down, then show the popup.
            If e.Alt AndAlso e.KeyCode = Keys.Down AndAlso (Not Me.PopupControlContainer.IsShowing()) Then
                ' Let the popup align around the source textBox.
                Me.PopupControlContainer.ParentControl = Me.popupTextBox_
                ' Passing Point.Empty will align it automatically around the above ParentControl.
                Me.PopupControlContainer.ShowPopup(Point.Empty)

                e.Handled = True
            End If
            ' Escape should close the popup.
            If e.KeyCode = Keys.Escape AndAlso Me.PopupControlContainer.IsShowing() Then
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


        Public Overridable Overloads Function GetPopupParentControl() As Control Implements Syncfusion.Windows.Forms.IPopupItem.GetPopupParentControl

            ' Popup will align around this control if GetLocationForPopupAlignment\
            ' returned Point.Empty.
            Return Me
        End Function
        Public Overridable Overloads Function IsRelatedControl(ByVal control As Control, ByVal askPopupParent As Boolean) As Boolean Implements Syncfusion.Windows.Forms.IPopupItem.IsRelatedControl
            ' The popup will then not lose focus automatically when Controls below
            ' get the focus.
            If control Is Me.friendlyControl_ OrElse control Is Me Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Sub ChildClosing(ByVal childUI As IPopupChild, ByVal popupCloseType As PopupCloseType) Implements IPopupParent.ChildClosing
            ' Transfer data from the popup.
            If popupCloseType = popupCloseType.Done Then
                Me.Text = Me.PopupTextBox.Text
            End If
            ' Set focus back to textbox.
            If popupCloseType = popupCloseType.Done OrElse popupCloseType = popupCloseType.Canceled Then
                Me.Focus()
            End If
        End Sub
        ' Lets you provide a preferred location for popup.
        Public Function GetLocationForPopupAlignment(ByVal prevAlignment As PopupRelativeAlignment, <System.Runtime.InteropServices.Out()> ByRef newAlignment As PopupRelativeAlignment) As Point Implements IPopupParent.GetLocationForPopupAlignment
            Dim bounds As Rectangle = Me.Bounds
            ' This utility method takes a rectangle and returns the 8 positions around
            ' it 1 at a time. It will start with the alignment specified in the 3rd argument.
            Dim pos As Point = PopupUtils.ComputeDefaultPopupAlignment(prevAlignment, newAlignment, PopupRelativeAlignment.RightTop, PopupRelativeAlignment.RightTop, bounds)

            Return Me.Parent.PointToScreen(pos)
        End Function

        Public Function GetBorderOverlapCue(ByVal relativeAlignment As PopupRelativeAlignment) As Point() Implements IPopupParent.GetBorderOverlapCue
            Dim bounds As Rectangle = Me.Bounds

            ' This utility fucntion takes a rectangular bounds and relative alignemnt
            ' and returns a line (array of 2 points) that represet the boundary
            ' for the specified alignemnt.
            Return PopupUtils.ComputeDefaultBorderOverlapCue(relativeAlignment, Me.RectangleToScreen(bounds))
        End Function
        Public ReadOnly Property IsRightToLeft() As Boolean Implements IPopupParent.IsRightToLeft
            Get
                Return Me.RightToLeft = Windows.Forms.RightToLeft.Yes
            End Get
        End Property

    End Class
#End Region
End Namespace

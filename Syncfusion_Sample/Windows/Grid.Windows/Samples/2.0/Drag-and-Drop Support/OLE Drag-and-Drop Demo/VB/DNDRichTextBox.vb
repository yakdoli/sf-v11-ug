#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace OleDragDrop
    Public Class DNDRichTextBox
        Inherits RichTextBox
        'Fields
        'Constructors
        'Events
        'Methods
        Public Sub New()
            MyBase.New()
            AddHandler Me.DragEnter, New System.Windows.Forms.DragEventHandler(AddressOf Handle_DragEnter)
            AddHandler Me.DragDrop, New System.Windows.Forms.DragEventHandler(AddressOf Handle_DragDrop)
            AddHandler Me.MouseDown, New MouseEventHandler(AddressOf Handle_MouseDown)
        End Sub
        Private Sub Handle_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If (Me.SelectionLength > 0) Then
                DoDragDrop(Me.SelectedText, DragDropEffects.Copy)
            End If
        End Sub
        Private Sub Handle_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)

            If e.Data.GetDataPresent(DataFormats.Text) Then
                e.Effect = (DragDropEffects.Move Or DragDropEffects.Copy)
            Else
                e.Effect = DragDropEffects.None
            End If

        End Sub
        Private Sub InitializeComponent()


        End Sub
        Private Sub Handle_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)

            ' Get start position to drop the text.
            Dim i As Integer = Me.SelectionStart
            Dim s As String = Me.Text.Substring(i)
            Me.Text = Me.Text.Substring(0, i)
            ' Drop the text on to the RichTextBox.
            Me.Text = Me.Text + CStr(e.Data.GetData(DataFormats.Text)) + s

            ' Loads the file into the control. 
            ' LoadFile(CType(e.Data.GetData("Text"), [String]), System.Windows.Forms.RichTextBoxStreamType.RichText)

        End Sub
    End Class
End Namespace

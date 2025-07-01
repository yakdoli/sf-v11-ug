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
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Public Class GridDropDownImageCellRenderer
    Inherits GridDropDownCellRenderer
    Private WithEvents pictureBox As pictureBox
    Private pictureWidth As Integer
    Private pictureHeight As Integer
    Private picImage As Image
    'Fields
    'Constructors
    'Methods
    Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
        MyBase.New(grid, cellModel)
        DropDownButton = New GridCellComboBoxButton(Me)

    End Sub
    Public Overloads Overrides Sub DropDownContainerShowingDropDown(ByVal sender As Object, ByVal e As CancelEventArgs)

        Me.DropDownContainer.PopupHost.FormBorderStyle = FormBorderStyle.Sizable
        Me.DropDownContainer.Dock = DockStyle.Fill
        Me.DropDownContainer.PopupHost.Width = Me.pictureWidth
        Me.DropDownContainer.PopupHost.Height = Me.pictureHeight
        Me.DropDownContainer.IgnoreDialogKey = True
        MyBase.DropDownContainerShowingDropDown(sender, e)

    End Sub
    Public Overloads Overrides Sub DropDownContainerShowedDropDown(ByVal sender As Object, ByVal e As EventArgs)

        Me.pictureBox.Focus()

    End Sub
    Public Overloads Overrides Sub DropDownContainerCloseDropDown(ByVal sender As Object, ByVal e As PopupClosedEventArgs)

        If (e.PopupCloseType = PopupCloseType.Done) Then
            'nothing...
        End If
        Me.DropDownContainer.Dock = DockStyle.None
        Me.DropDownContainer.IgnoreDialogKey = False
        MyBase.DropDownContainerCloseDropDown(sender, e)

    End Sub
    Protected Overloads Overrides Sub InitializeDropDownContainer()

        MyBase.InitializeDropDownContainer()
        pictureBox = New PictureBox()
        pictureBox.Dock = DockStyle.Fill
        pictureBox.BorderStyle = BorderStyle.Fixed3D
        pictureBox.Visible = True
        pictureBox.Image = Me.picImage
        DropDownContainer.Controls.Add(pictureBox)
        pictureBox.Focus()

    End Sub
    Protected Overloads Overrides Sub OnInitialize(ByVal rowIndex As Integer, ByVal colIndex As Integer)

        Dim style As GridStyleInfo
        style = Grid.Model(rowIndex, colIndex)
        Dim pict() As [Byte]
        pict = CType(style.CellValue, [Byte]())
        If (Not (pict) Is Nothing) Then
            Dim PictOffSet As Integer
            PictOffSet = 78
            '((GridImageCellModel)this.Model).PictureBufferOffset;
            Dim buffer As MemoryStream
            buffer = New MemoryStream(pict, PictOffSet, (pict.Length - PictOffSet))
            Me.picImage = Image.FromStream(buffer, True)
            Dim gu As System.Drawing.GraphicsUnit
            gu = System.Drawing.GraphicsUnit.Point
            Dim srcRect As RectangleF
            srcRect = Me.picImage.GetBounds(gu)
            Me.pictureWidth = CType(srcRect.Width, Integer)
            Me.pictureHeight = CType(srcRect.Height, Integer)
            If (Not (Me.pictureBox) Is Nothing) Then
                pictureBox.Image = Me.picImage
            End If
        End If

    End Sub
    Protected Overloads Overrides Sub OnDraw(ByVal g As Graphics, ByVal clientRectangle As Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo)

        '	base.OnDraw(g, clientRectangle, rowIndex, colIndex, style);
        '	this.DrawBackground(g, clientRectangle, style, true);

    End Sub
    Public Sub PictureBoxKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)

        CurrentCell.CloseDropDown(PopupCloseType.Done)

    End Sub
End Class


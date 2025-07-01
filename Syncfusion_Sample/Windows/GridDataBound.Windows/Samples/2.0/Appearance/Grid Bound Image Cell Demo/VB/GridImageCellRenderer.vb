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
Imports Syncfusion.Windows.Forms.Grid
Imports System
Imports System.Drawing
Imports System.IO


Public Class GridImageCellRenderer
    Inherits GridStaticCellRenderer
    'Fields
    'Constructors
    'Methods
    Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
        MyBase.New(grid, cellModel)

    End Sub
    Protected Overloads Overrides Sub OnDraw(ByVal g As Graphics, ByVal clientRectangle As Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo)

        If clientRectangle.IsEmpty Then
            Return
        End If
        Try
            Dim pict() As [Byte]
            pict = CType(style.CellValue, [Byte]())
            If (Not (pict) Is Nothing) Then
                Dim PictOffSet As Integer
               PictOffSet = CType(Me.Model, GridImageCellModel).PictureBufferOffset
                Dim buffer As MemoryStream
                buffer = New MemoryStream(pict, PictOffSet, (pict.Length - PictOffSet))
                Dim image As Image
                image = System.Drawing.Image.FromStream(buffer, True)
                Dim cellDrawOption As GridImageCellDrawOption
                cellDrawOption = CType(Me.Model, GridImageCellModel).CellDrawOption
                Dim gu As System.Drawing.GraphicsUnit
                gu = System.Drawing.GraphicsUnit.Point
                Dim srcRect As RectangleF
                srcRect = image.GetBounds(gu)
                Dim destRect As Rectangle
                destRect = Rectangle.Empty
                Dim saveRegion As [Region]
                saveRegion = g.Clip
                 Select Case cellDrawOption
                    Case GridImageCellDrawOption.FitToCell
                        destRect = clientRectangle
                        'End Section
                    Case GridImageCellDrawOption.NoResize
                        destRect = New Rectangle(clientRectangle.X, clientRectangle.Y, CType(srcRect.Width, Integer), CType(srcRect.Height, Integer))
                        g.Clip = New [Region](clientRectangle)
                        'End Section
                    Case GridImageCellDrawOption.FitProportionally
                        Dim srcRatio As Single
                        srcRatio = (srcRect.Width / srcRect.Height)
                        Dim tarRatio As Single
                        tarRatio = (CType(clientRectangle.Width, Single) / clientRectangle.Height)
                        destRect = clientRectangle
                        If (tarRatio < srcRatio) Then
                            destRect.Height = CType((destRect.Width * srcRatio), Integer)
                        Else
                            destRect.Width = CType((destRect.Height * srcRatio), Integer)
                        End If
                        'End Section
                    Case Else
                        'End Section
                End Select
                If Not (destRect.IsEmpty) Then
                    Dim dest As RectangleF = New RectangleF(destRect.X, destRect.Y, destRect.Width, destRect.Height)
                    g.DrawImage(image, dest, srcRect, gu)
                End If
                g.Clip = saveRegion
                
            End If
        Catch ex As System.Exception
        End Try

    End Sub
End Class


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

Namespace LayoutManagers
    Public Class ImageUtil
        Private baseImage As Image
        'Fields
        'Constructors
        'Methods
        Public Sub New()
            'Warning: Implementation not found
        End Sub
        Private Sub InitBaseImage(ByVal baseImage As Image)

            Me.baseImage = CType(baseImage.Clone, Image)

        End Sub
        Private Function ApplyNewColorOnImage(ByVal newColor As Color) As Image

            ' Create a new bitmap off the base image.
            Dim newImage As Image
            newImage = CType(Me.baseImage.Clone, Image)
            Dim newBitmap As Bitmap
            newBitmap = New Bitmap(newImage)
            ' Set the Color cue pixels to the appropriate color.
            ' This logic of course, depends on the actual bitmap.
            Dim i As Integer
            i = 12

            Do While (i <= 14)
                Dim j As Integer
                j = 2

                Do While (j <= 14)
                    newBitmap.SetPixel(j, i, newColor)
                    j = (j + 1)

                Loop
                i = (i + 1)

            Loop
            Return newImage

        End Function
    End Class
End Namespace

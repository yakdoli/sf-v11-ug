Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace ImageListAdv_Demo
	Partial Public Class Docking1
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			Dim imgList As ImageList = Me.imageListAdv1.ToImageList()
			imgList.ColorDepth = ColorDepth.Depth32Bit
			Me.dockingManager1.ImageList = imgList

		End Sub
	End Class
End Namespace

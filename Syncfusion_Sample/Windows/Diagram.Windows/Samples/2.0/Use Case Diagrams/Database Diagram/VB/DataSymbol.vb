Imports Microsoft.VisualBasic
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Drawing.Printing
Imports System.Drawing.Imaging
Imports Syncfusion.Windows.Forms
Imports System.Collections
Imports System
Imports System.Drawing



Namespace DatabaseDiagram
    <Serializable(), System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Assert, Name:="FullTrust")> _
    Public Class DataSymbol
        Inherits Group
        Public Sub New(ByVal strColumnName As ArrayList, ByVal strTableName As String, ByVal primaryKey As String)
            MyBase.New()
            Me.Name = strTableName
            Dim rectHeight As Single = (strColumnName.Count * 20) + 40
            Dim rect As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 150, rectHeight)
            rect.FillStyle.Color = Color.WhiteSmoke
            rect.Name = "BaseNode"
            Dim lbl As New Syncfusion.Windows.Forms.Diagram.Label(rect, strTableName)
            lbl.FontStyle.Family = "Arial"
            lbl.FontStyle.Size = 9
            lbl.FontStyle.Bold = True
            lbl.Position = Position.TopLeft
            lbl.OffsetX = 65
            lbl.OffsetY = 18
            lbl.UpdatePosition = True
            rect.Labels.Add(lbl)
            Me.AppendChild(rect)
            Dim z As Single = 30
            For i As Integer = 0 To strColumnName.Count - 1
                Dim txtNode As New TextNode(strColumnName(i).ToString(), New RectangleF(30, z, 110, 20))
                txtNode.FontStyle.Family = "Arial"
                txtNode.FontStyle.Size = 7
                txtNode.VerticalAlignment = StringAlignment.Center
                txtNode.BackgroundStyle.Color = Color.White
                txtNode.LineStyle.LineColor = Color.LightGray

                Dim symRect As New Syncfusion.Windows.Forms.Diagram.Rectangle(10, z, 20, 20)
                symRect.FillStyle.Color = Color.WhiteSmoke
                symRect.FillStyle.Type = FillStyleType.LinearGradient
                symRect.LineStyle.LineColor = Color.LightGray
                symRect.EditStyle.AllowSelect = False

                Me.AppendChild(txtNode)
                Me.AppendChild(symRect)
                If primaryKey = txtNode.Text Then
                    Dim bmp As New Bitmap("..//..//Data//PrimaryKey.png")
                    Dim bmpNode As New BitmapNode(bmp, New RectangleF(symRect.BoundingRectangle.X + 5, symRect.BoundingRectangle.Y + 5, symRect.BoundingRectangle.Width - 10, symRect.BoundingRectangle.Height - 10))
                    bmpNode.LineStyle.LineColor = Color.Transparent
                    bmpNode.EditStyle.AllowSelect = False
                    Me.AppendChild(bmpNode)
                End If

                z = z + 20
            Next i

        End Sub

    End Class
End Namespace

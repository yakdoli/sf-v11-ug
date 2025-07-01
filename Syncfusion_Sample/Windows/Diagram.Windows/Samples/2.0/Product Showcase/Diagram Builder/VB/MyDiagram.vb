Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

Imports System.ComponentModel
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.Serialization
Imports Syncfusion.Documentation
Imports Syncfusion.Runtime.InteropServices.WinAPI


Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Windows.Forms

Namespace Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool
    Friend Class MyDiagram : Inherits Syncfusion.Windows.Forms.Diagram.Controls.Diagram

        Public Overrides Function CreateView() As Syncfusion.Windows.Forms.Diagram.View
            Return New MyView()
        End Function
    End Class
    <Serializable()> _
    Public Class MyView : Inherits Syncfusion.Windows.Forms.Diagram.View : Implements ISerializable, IDeserializationCallback, IPropertyContainer
#Region "Fields"


        ''' <summary>
        ''' Horizontal resolution of the device.
        ''' </summary>
        Private dpiX As Single
        ''' <summary>
        ''' Vertical resolution of the device.
        ''' </summary>
        Private dpiY As Single
        ''' <summary>
        ''' Object that renders grid.
        ''' </summary>
        Private m_grid As LayoutGrid
        ''' <summary>
        '''  Page border style.
        ''' </summary>       
        Private m_fMagnification As Single
        ''' <summary>
        '''  Page border style.
        ''' </summary>
        Private m_stylePageBorder As PageBorderStyle
        ''' <summary>
        ''' Indicates whether Mouse Tracking is enabled.
        ''' </summary>
        Private m_bTrackingEnabled As Boolean
        ''' <summary>
        ''' Color to clear the background with.
        ''' </summary>
        Private backgroundColor As Color

#End Region

        Public Sub New()

        End Sub

        ''' <summary>
        ''' Serialization constructor for views.
        ''' </summary>
        ''' <param name="info">Serialization state information.</param>
        ''' <param name="context">Streaming context information.</param>
        Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            Me.dpiX = 96
            Me.dpiY = 96
            m_ptOrigin = CType(info.GetValue("origin", GetType(PointF)), PointF)
            m_fMagnification = info.GetSingle("magnification")
            m_stylePageBorder = CType(info.GetValue("pageborderstyle", GetType(PageBorderStyle)), PageBorderStyle)
            m_grid = CType(info.GetValue("m_grid", GetType(LayoutGrid)), LayoutGrid)

            Try
                backgroundColor = CType(info.GetValue("backcolor", GetType(Color)), Color)
            Catch e1 As SerializationException
                ResetBackgroundColor()
                m_grid.Visible = False
            End Try

            If Not m_grid Is Nothing Then
                m_grid.ContainerView = Me
                m_grid.UpdateServiceReferences(Me)
            End If
        End Sub

        Private Sub ResetBackgroundColor()
            Me.backgroundColor = Color.DarkGray
        End Sub

#Region "Serialization"


        ''' <summary>
        ''' Called when deserialization is complete.
        ''' </summary>
        ''' <param name="sender">Object performing the deserialization.</param>
        Protected Overrides Sub OnDeserialization(ByVal sender As Object) Implements IDeserializationCallback.OnDeserialization
            '  Me.OnDeserialization(sender)
        End Sub

        ''' <summary>
        ''' Populates a SerializationInfo with the data needed to
        ''' serialize the target object.
        ''' </summary>
        ''' <param name="info">SerializationInfo object to populate.</param>
        ''' <param name="context">Destination streaming context.</param>
        Protected Overrides Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext) Implements ISerializable.GetObjectData
            info.AddValue("origin", m_ptOrigin)
            info.AddValue("magnification", m_fMagnification)
            info.AddValue("pageborderstyle", m_stylePageBorder)
            info.AddValue("m_grid", Me.Grid)
            info.AddValue("backcolor", backgroundColor)
        End Sub
        'Protected Overrides Sub OnDeserialization(ByVal sender As Object) Implements IDeserializationCallback.OnDeserialization
        'End Sub
#End Region

#Region "DrawHandles"

        Protected Overrides Sub DrawHandles(ByVal grfx As System.Drawing.Graphics, ByVal nodesSelected As NodeCollection)
            ' Draw handles around nodes in selection list.
            If Not nodesSelected Is Nothing AndAlso nodesSelected.Count > 0 Then
                For Each nodeCur As Node In nodesSelected
                    If nodeCur.Visible Then
                        Dim resultHandleEditMode As HandleEditMode = nodeCur.EditStyle.DefaultHandleEditMode

                        ' get cur node parent's transformations 
                        Dim matrixParentsTransorm As Matrix = GetParentsTransform(nodeCur)
                        ' save graphics state
                        Dim stateSave As GraphicsState = grfx.Save()
                        ' append parents transforms on given graphics
                        grfx.MultiplyTransform(matrixParentsTransorm)

                        Select Case resultHandleEditMode
                            Case HandleEditMode.Resize
                                If TypeOf nodeCur Is IEndPointContainer Then
                                    HandleRenderer.DrawEndPoints(grfx, nodeCur)
                                    MyHandleRenderer.MyOutlineBoundingRectangle(grfx, nodeCur)
                                Else
                                    ' This method is used to Draw a custom Bounding outline 
                                    MyHandleRenderer.MyOutlineBoundingRectangle(grfx, nodeCur)
                                    HandleRenderer.DrawRotationHandles(grfx, nodeCur)
                                    'This method is used to customize the selection point colors.
                                    MyHandleRenderer.DrawMySelectionHandles(grfx, nodeCur)
                                End If
                            Case HandleEditMode.Vertex
                                Dim pathNode As PathNode = CType(IIf(TypeOf nodeCur Is PathNode, nodeCur, Nothing), PathNode)
                                If TypeOf nodeCur Is IEndPointContainer Then
                                    HandleRenderer.DrawEndPoints(grfx, nodeCur)
                                    MyHandleRenderer.MyOutlineBoundingRectangle(grfx, nodeCur)

                                    If pathNode.CanDrawControlPoints() Then
                                        pathNode.DrawControlPoints(grfx)
                                    End If
                                ElseIf Not pathNode Is Nothing AndAlso (pathNode.CanChangePath OrElse pathNode.IsVertexEditable) Then
                                    MyHandleRenderer.MyOutlineBoundingRectangle(grfx, pathNode)

                                    ' Draw control points if can.
                                    If pathNode.CanDrawControlPoints() Then
                                        pathNode.DrawControlPoints(grfx)
                                    Else
                                        HandleRenderer.DrawVertexHandles(grfx, pathNode)
                                    End If
                                End If
                        End Select

                        ' restore graphics state
                        grfx.Restore(stateSave)
                    End If
                Next nodeCur
            End If
        End Sub

        Private Function GetParentsTransform(ByVal node As Node) As Matrix
            ' return unitary matrix
            If TypeOf node Is PseudoGroup Then
                Return New Matrix()
            End If

            If node Is Nothing OrElse node.Parent Is Nothing Then
                Throw New ArgumentNullException("node + parent")
            End If

            Dim matrixToReturn As Matrix = New Matrix()
            Dim matrixTemp As Matrix
            Dim nodeParent As ICompositeNode = node.Parent

            ' iterate through given node parents multiplying their transformations
            Do While Not (TypeOf nodeParent Is Model)
                matrixTemp = (CType(nodeParent, Node)).GetTransformations()
                CType(nodeParent, Node).AppendFlipTransforms(matrixTemp)
                matrixToReturn.Multiply(matrixTemp, MatrixOrder.Append)

                nodeParent = (CType(nodeParent, Node)).Parent
            Loop

            Return matrixToReturn
        End Function
#End Region
    End Class

    Public Class MyHandleRenderer : Inherits HandleRenderer
        Private Shared m_sbrushHandle As SolidBrush = New SolidBrush(Color.GreenYellow)
        Private Shared m_spenHandleOutline As Pen = New Pen(Color.Black, 0.0F)

#Region "Custom Handles"

        Public Shared Sub MyOutlineBoundingRectangle(ByVal gfx As Graphics, ByVal node As Node)
            ' 1 - Save Graphics state
            Dim save As GraphicsState = gfx.Save()
            gfx.PixelOffsetMode = PixelOffsetMode.HighQuality
            gfx.SmoothingMode = SmoothingMode.AntiAlias

            ' 2 - append parent's transformations on given graphics - WITHOUT ROTATIONS
            Dim matrixTemp As Matrix = node.GetTransformations()
            ' append flip transforms
            node.AppendFlipTransforms(matrixTemp)
            ' apply transform matrix
            gfx.MultiplyTransform(matrixTemp)

            ' 4 - Outline shape's bounding rectangle
            Dim szUnitIndependent As SizeF = (CType(node, IUnitIndependent)).GetSize(MeasureUnits.Pixel)

            ' static pen is not used here as OutOfMemoryExceptions might occur some times


            Dim pen As Pen = New Pen(Color.Gray, 1.0F / gfx.PageScale)
            Try
                pen.DashStyle = DashStyle.Solid
                gfx.DrawRectangle(pen, 0, 0, szUnitIndependent.Width, szUnitIndependent.Height)
            Finally
                Dim disp As IDisposable = pen
                disp.Dispose()
            End Try


            ' 5 - Restore graphics state
            gfx.Restore(save)
        End Sub

        Public Shared Sub DrawMySelectionHandles(ByVal gfx As Graphics, ByVal node As Node)
            ' Save Graphics state
            Dim save As GraphicsState = gfx.Save()
            gfx.PixelOffsetMode = PixelOffsetMode.HighQuality
            gfx.SmoothingMode = SmoothingMode.AntiAlias

            ' apply node transformations to graphics
            Dim matrixTemp As Matrix = CreateParentMatrix(node)
            gfx.MultiplyTransform(matrixTemp)

            ' get node local transformations
            Dim matrixLocalTransform As Matrix = node.GetLocalTransformations()
            node.AppendLocalFlipTransforms(matrixLocalTransform)

            ' reset matrix
            matrixTemp.Reset()
            ' append node local transformations               
            matrixTemp.Multiply(matrixLocalTransform)

            DrawMyResizeHandles(gfx, node, matrixTemp)

            ' Restore graphics state
            gfx.Restore(save)
        End Sub
        Private Shared Function CreateParentMatrix(ByVal node As Node) As Matrix
            ' get node's dimensions in unit independent values
            Dim ptUnitIndependentPinPoint As PointF = (CType(node, IUnitIndependent)).GetPinPoint(MeasureUnits.Pixel)
            Dim szUnitIndependentPinOffset As SizeF = (CType(node, IUnitIndependent)).GetPinPointOffset(MeasureUnits.Pixel)
            Dim sztransf As SizeF = New SizeF(ptUnitIndependentPinPoint.X - szUnitIndependentPinOffset.Width, ptUnitIndependentPinPoint.Y - szUnitIndependentPinOffset.Height)

            ' Create matrix.
            Dim matrixTemp As Matrix = New Matrix()

            ' Translate to pinPoint.
            matrixTemp.Translate(sztransf.Width, sztransf.Height)

            Return matrixTemp
        End Function
        Private Shared Sub DrawMyResizeHandles(ByVal gfx As Graphics, ByVal node As Node, ByVal matrixTransform As Matrix)
            ' Handles are immutable to scale
            Dim fPageScale As Single = gfx.PageScale
            Dim fHandleSize As Single = CommonUsedValues.RESIZE_HANDLE_SIZE / fPageScale

            ' Draw handles
            'INSTANT VB NOTE: The local variable handles was renamed since it is a keyword in VB:
            Dim handles_Renamed As Array = System.Enum.GetValues(GetType(BoxPosition))
            Dim rectHandle As RectangleF
            ' PointF array for transforming.
            Dim pts As PointF() = New PointF(0) {}
            Dim matrixParentRotate As Matrix
            Dim fParentsRotation As Single = HandlesHitTesting.GetParentsRotation(node)


            For Each handle As BoxPosition In handles_Renamed
                If handle <> BoxPosition.Center Then
                    ' Get handle position
                    pts(0) = GetHandlePosition(handle, node)

                    ' Transform points
                    matrixTransform.TransformPoints(pts)

                    ' Create handle's bounding rectangle.
                    rectHandle = Geometry.CreateRect(pts(0), New SizeF(fHandleSize + 1, fHandleSize + 1))

                    matrixParentRotate = New Matrix()
                    matrixParentRotate.RotateAt(-fParentsRotation, pts(0))

                    Dim stateSave As GraphicsState = gfx.Save()
                    gfx.MultiplyTransform(matrixParentRotate, MatrixOrder.Prepend)

                    DrawResizeHandle(gfx, handle, node, rectHandle)

                    gfx.Restore(stateSave)
                End If
            Next handle
        End Sub
        Private Shared Sub DrawResizeHandle(ByVal gfx As Graphics, ByVal handle As BoxPosition, ByVal node As Node, ByVal rectHandle As RectangleF)

            m_spenHandleOutline.Width = 1.0F / gfx.PageScale
            m_spenHandleOutline.DashStyle = DashStyle.Solid
            m_spenHandleOutline.Color = Color.Gray

            ' Check handle state
            If (Not Enabled(handle, node)) Then
                m_sbrushHandle.Color = Color.Gray

                ' Customizing Square BoxPosition handles.
            ElseIf handle = BoxPosition.BottomCenter OrElse handle = BoxPosition.TopCenter OrElse handle = BoxPosition.MiddleLeft OrElse handle = BoxPosition.MiddleRight Then
                gfx.DrawRectangle(m_spenHandleOutline, rectHandle.X, rectHandle.Y, rectHandle.Width, rectHandle.Height)
                gfx.FillRectangle(m_sbrushHandle, rectHandle)

                ' Customizing Round BoxPosition handles.
            Else
                If m_sbrushHandle.Color <> Color.Gray Then
                    m_sbrushHandle.Color = Color.FromArgb(209, 248, 250)
                End If

                ' Fill handle interiors
                gfx.DrawEllipse(m_spenHandleOutline, rectHandle.X, rectHandle.Y, rectHandle.Width, rectHandle.Height)
                gfx.FillEllipse(m_sbrushHandle, rectHandle)
            End If
        End Sub
        Private Shared Function Enabled(ByVal handle As BoxPosition, ByVal node As Node) As Boolean
            Dim bValueToReturn As Boolean = True
            Select Case handle
                Case BoxPosition.TopLeft, BoxPosition.TopRight, BoxPosition.BottomLeft, BoxPosition.BottomRight
                    bValueToReturn = EditStyle.CanChangeWidth(node) AndAlso EditStyle.CanChangeHeight(node)
                Case BoxPosition.MiddleLeft, BoxPosition.MiddleRight
                    bValueToReturn = EditStyle.CanChangeWidth(node)
                Case BoxPosition.TopCenter, BoxPosition.BottomCenter
                    bValueToReturn = EditStyle.CanChangeHeight(node)
            End Select
            Return bValueToReturn
        End Function

#End Region
    End Class
End Namespace
Imports Microsoft.VisualBasic
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

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.Serialization
Imports System.Windows.Forms
Imports System.IO

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Styles


Namespace ContentCellDemo
	Public Class PictureBoxCellModel
		Inherits GridGenericControlCellModel
		Public Sub New(ByVal grid As GridModel)
			MyBase.New(grid)
			PictureBoxStyleProperties.Initialize()
		End Sub

		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub

		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New PictureBoxCellRenderer(control, Me)
		End Function

		Protected Overrides Function OnQueryPrefferedClientSize(ByVal g As Graphics, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo, ByVal queryBounds As GridQueryBounds) As Size
			Dim sp As New PictureBoxStyleProperties(style)
			Dim img As Image = sp.Image
			If img IsNot Nothing Then
				Return img.Size
			End If
			Return MyBase.OnQueryPrefferedClientSize(g, rowIndex, colIndex, style, queryBounds)
		End Function

		Public Shared Sub InitializePictureBox(ByVal c As PictureBox, ByVal style As GridStyleInfo)
			Dim sp As New PictureBoxStyleProperties(style)
			c.SizeMode = sp.SizeMode
			c.Image = sp.Image
			c.BackColor = style.BackColor
		End Sub
	End Class

	Public Class PictureBoxCellRenderer
		Inherits GridGenericControlCellRenderer
		Private drawPictureBox As New PictureBox()
		Private cm As PictureBoxCellModel

		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
			cm = CType(cellModel, PictureBoxCellModel)
			SupportsFocusControl = False
			FixControlParent(drawPictureBox)
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				drawPictureBox.Dispose()
				drawPictureBox = Nothing
				cm = Nothing
			End If

			MyBase.Dispose (disposing)
		End Sub

		Protected Overrides Sub OnDraw(ByVal g As Graphics, ByVal clientRectangle As Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo)
			style.Control = drawPictureBox
			PictureBoxCellModel.InitializePictureBox(drawPictureBox, style)
			MyBase.OnDraw (g, clientRectangle, rowIndex, colIndex, style)
		End Sub

		Protected Overrides Function OnLayout(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo, ByVal innerBounds As Rectangle, ByVal buttonsBounds() As Rectangle) As Rectangle
			Dim r As Rectangle = MyBase.OnLayout (rowIndex, colIndex, style, innerBounds, buttonsBounds)

			r.Inflate(-1, -1)

			Return r

			' center windows forms trackBar inside cell.
			'return GridUtil.CenterInRect(r, cm.trackBarControlSize);
		End Function
	End Class

	''' <summary>
	''' Provides custom properties specific for PictureBox control. All properties
	''' support the style inheritance mechanism. You can change these propeties
	''' in the property grid.
	''' </summary>
	Public Class PictureBoxStyleProperties
		Inherits GridStyleInfoCustomProperties
		' static initialization of property descriptors
		Private Shared t As Type = GetType(PictureBoxStyleProperties)

		Private ReadOnly Shared ImageProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "Image")
		Private ReadOnly Shared SizeModeProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "SizeMode")

		' default settings for all properties this object holds
		Private Shared defaultObject As PictureBoxStyleProperties

		' initialize default settings for all properties in static ctor
		Shared Sub New()
			' all properties must be initialized for the Default property
			defaultObject = New PictureBoxStyleProperties(GridStyleInfo.Default)
			defaultObject.SizeMode = PictureBoxSizeMode.Normal
			defaultObject.Image = Nothing
		End Sub

		''' <summary>
		''' Provides access to default values for this type
		''' </summary>
		Public Shared ReadOnly Property [Default]() As PictureBoxStyleProperties
			Get
				Return defaultObject
			End Get
		End Property

		''' <summary>
		''' Force static ctor being called at least once
		''' </summary>
		Public Shared Sub Initialize()
		End Sub

		' explicit cast from GridStyleInfo to PictureBoxStyleProperties
		' (Note: this will only work for C#, Visual Basic does not support dynamic casts)

		''' <summary>
		''' Explicit cast from GridStyleInfo to this custom propety object
		''' </summary>
		''' <returns>A new custom properties object.</returns>
		Public Shared Narrowing Operator CType(ByVal style As GridStyleInfo) As PictureBoxStyleProperties
			Return New PictureBoxStyleProperties(style)
		End Operator

		''' <summary>
		''' Initializes a PictureBoxStyleProperties object with a style object that holds all data
		''' </summary>
		Public Sub New(ByVal style As GridStyleInfo)
			MyBase.New(style)
		End Sub

		''' <summary>
		''' Initializes a PictureBoxStyleProperties object with an empty style object. Design
		''' time environment will use this ctor and later copy the values to a style object
		''' by calling style.CustomProperties.Add(gridExcelTipStyleProperties1)
		''' </summary>
		Public Sub New()
			MyBase.New()
		End Sub

		''' <summary>
		''' Indicates how the image is displayed.
		''' </summary>
		''' <remarks>
		''' Valid values for this property are taken from the PictureBoxSizeMode
		''' enumeration. By default, in PictureBoxSizeMode.Normal mode, the Image 
		''' is placed in the upper left corner of the PictureBox, and any part of 
		''' the image too big for the PictureBox is clipped. Using the 
		''' PictureBoxSizeMode.StretchImage value causes the image to stretch to 
		''' fit the PictureBox.
		''' <para/>
		''' Using the PictureBoxSizeMode.AutoSize value causes the control to resize 
		''' to always fit the image. Using the PictureBoxSizeMode.CenterImage value
		''' causes the image to be centered in the client area.
		''' <para/>
		''' </remarks>
		<Description("Indicates how the image is displayed."), Browsable(True), Category("PictureBox")> _
		Public Property SizeMode() As PictureBoxSizeMode
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CType(style.GetValue(SizeModeProperty), PictureBoxSizeMode)
			End Get
			Set(ByVal value As PictureBoxSizeMode)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(SizeModeProperty, value)
			End Set
		End Property
		''' <summary>
		''' Resets SizeMode state
		''' </summary>
		Public Sub ResetSizeMode()
			style.ResetValue(SizeModeProperty)
		End Sub
		<EditorBrowsableAttribute(EditorBrowsableState.Never)> _
		Private Function ShouldSerializeSizeMode() As Boolean
			Return style.HasValue(SizeModeProperty)
		End Function
		''' <summary>
		''' Gets if SizeMode state has been initialized for the current object.
		''' </summary>
		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property HasSizeMode() As Boolean
			Get
				Return style.HasValue(SizeModeProperty)
			End Get
		End Property
		''' <summary>
		''' Gets or sets the image that the PictureBox displays.
		''' </summary>
		<Description("Gets or sets the image that the PictureBox displays."), Browsable(True), Category("PictureBox")> _
		Public Property Image() As Image
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CType(style.GetValue(ImageProperty), Image)
			End Get
			Set(ByVal value As Image)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(ImageProperty, value)
			End Set
		End Property
		''' <summary>
		''' Resets Image state
		''' </summary>
		Public Sub ResetImage()
			style.ResetValue(ImageProperty)
		End Sub
		<EditorBrowsableAttribute(EditorBrowsableState.Never)> _
		Private Function ShouldSerializeImage() As Boolean
			Return style.HasValue(ImageProperty)
		End Function
		''' <summary>
		''' Gets if Image state has been initialized for the current object.
		''' </summary>
		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property HasImage() As Boolean
			Get
				Return style.HasValue(ImageProperty)
			End Get
		End Property
	End Class
End Namespace

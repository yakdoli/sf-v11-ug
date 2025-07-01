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


Namespace InteractiveCellDemo
	Public Class SliderCellModel
		Inherits GridGenericControlCellModel
		Public Sub New(ByVal grid As GridModel)
			MyBase.New(grid)
			SliderStyleProperties.Initialize()
		End Sub

		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub

		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New SliderCellRenderer(control, Me)
		End Function

		Public trackBarControlSize As Size = Size.Empty

		Protected Overrides Function OnQueryPrefferedClientSize(ByVal g As Graphics, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo, ByVal queryBounds As GridQueryBounds) As Size
			If trackBarControlSize.IsEmpty Then
				Dim drawSlider As New TrackBar()
				trackBarControlSize = drawSlider.Size
				trackBarControlSize.Width += 24
				trackBarControlSize.Height += 10
			End If
			Return trackBarControlSize
		End Function

		Public Shared Sub InitializeSlider(ByVal c As TrackBar, ByVal style As GridStyleInfo)
			Dim sp As New SliderStyleProperties(style)
			c.Minimum = sp.Minimum
			c.Maximum = sp.Maximum
			c.LargeChange = sp.LargeChange
			c.SmallChange = sp.SmallChange
			c.TickFrequency = sp.TickFrequency
			c.TickStyle = sp.TickStyle
			c.Orientation = sp.Orientation
			c.AutoSize = False
			c.BackColor = style.BackColor
			InitializeSlider(c, style.CellValue)
		End Sub

		Public Shared Sub InitializeSlider(ByVal c As TrackBar, ByVal controlValue As Object)
			If TypeOf controlValue Is Integer Then
				c.Value = CInt(Fix(controlValue))
			ElseIf TypeOf controlValue Is String AndAlso (CStr(controlValue)).Length > 0 Then
				c.Value = Integer.Parse(CStr(controlValue))
			Else
				c.Value = c.Minimum
			End If
		End Sub

	End Class

	Public Class SliderCellRenderer
		Inherits GridGenericControlCellRenderer
		Private drawSlider As New TrackBar()
		Private editSlider As New TrackBar()
		Private cm As SliderCellModel

		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
			cm = CType(cellModel, SliderCellModel)
			SupportsFocusControl = True
			FixControlParent(drawSlider)
			SetControl(editSlider)
			editSlider.AutoSize = False
			AddHandler editSlider.ValueChanged, AddressOf trackBar_ValueChanged
			cm.trackBarControlSize = drawSlider.Size
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				RemoveHandler editSlider.ValueChanged, AddressOf trackBar_ValueChanged
				editSlider.Dispose()
				editSlider = Nothing
				drawSlider.Dispose()
				drawSlider = Nothing
				cm = Nothing
			End If

			MyBase.Dispose (disposing)
		End Sub

		Protected Overrides Function OnSaveChanges() As Boolean 'internal
			Me.Grid.Model(RowIndex, ColIndex).CellValue = editSlider.Value
			Return True
		End Function

		Protected Overrides Sub OnDraw(ByVal g As Graphics, ByVal clientRectangle As Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo)
			If Me.ShouldDrawFocused(rowIndex, colIndex) Then
				style.Control = editSlider
			Else
				style.Control = drawSlider
				SliderCellModel.InitializeSlider(drawSlider, style)
			End If
			MyBase.OnDraw (g, clientRectangle, rowIndex, colIndex, style)
		End Sub

		Protected Overrides Sub OnInitialize(ByVal rowIndex As Integer, ByVal colIndex As Integer)
			SliderCellModel.InitializeSlider(editSlider, Grid.GetViewStyleInfo(rowIndex, colIndex))
		End Sub

		Protected Overrides Sub InitializeControlText(ByVal controlValue As Object)
			SliderCellModel.InitializeSlider(Me.editSlider, controlValue)
		End Sub

		Protected Overrides Function OnLayout(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo, ByVal innerBounds As Rectangle, ByVal buttonsBounds() As Rectangle) As Rectangle
			Dim r As Rectangle = MyBase.OnLayout (rowIndex, colIndex, style, innerBounds, buttonsBounds)

			r.Inflate(-2, -2)

			Return r

			' center windows forms trackBar inside cell.
			'return GridUtil.CenterInRect(r, cm.trackBarControlSize);
		End Function

		Private Sub trackBar_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			' Raise CurrentCellChanging event and set CurrentCell.Modified = true
			If MyBase.NotifyCurrentCellChanging() Then
				ControlValue = editSlider.Value
				MyBase.NotifyCurrentCellChanged()
			End If
		End Sub
	End Class

	''' <summary>
	''' Provides custom properties specific for slider control. All properties
	''' support the style inheritance mechanism. You can change these propeties
	''' in the property grid.
	''' </summary>
	Public Class SliderStyleProperties
		Inherits GridStyleInfoCustomProperties
		' static initialization of property descriptors
		Private Shared t As Type = GetType(SliderStyleProperties)

		Private ReadOnly Shared MinimumProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "Minimum")
		Private ReadOnly Shared MaximumProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "Maximum")
		Private ReadOnly Shared SmallChangeProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "SmallChange")
		Private ReadOnly Shared LargeChangeProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "LargeChange")
		Private ReadOnly Shared OrientationProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "Orientation")
		Private ReadOnly Shared TickFrequencyProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "TickFrequency")
		Private ReadOnly Shared TickStyleProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "TickStyle")

		' default settings for all properties this object holds
		Private Shared defaultObject As SliderStyleProperties

		' initialize default settings for all properties in static ctor
		Shared Sub New()
			' all properties must be initialized for the Default property
			defaultObject = New SliderStyleProperties(GridStyleInfo.Default)
			Dim tb As New TrackBar()
			defaultObject.Minimum = tb.Minimum
			defaultObject.Maximum = tb.Maximum
			defaultObject.SmallChange = tb.SmallChange
			defaultObject.LargeChange = tb.LargeChange
			defaultObject.TickFrequency = tb.TickFrequency
			defaultObject.TickStyle = tb.TickStyle
			defaultObject.Orientation = tb.Orientation
		End Sub

		''' <summary>
		''' Provides access to default values for this type
		''' </summary>
		Public Shared ReadOnly Property [Default]() As SliderStyleProperties
			Get
				Return defaultObject
			End Get
		End Property

		''' <summary>
		''' Force static ctor being called at least once
		''' </summary>
		Public Shared Sub Initialize()
		End Sub

		' explicit cast from GridStyleInfo to SliderStyleProperties
		' (Note: this will only work for C#, Visual Basic does not support dynamic casts)

		''' <summary>
		''' Explicit cast from GridStyleInfo to this custom propety object
		''' </summary>
		''' <returns>A new custom properties object.</returns>
		Public Shared Narrowing Operator CType(ByVal style As GridStyleInfo) As SliderStyleProperties
			Return New SliderStyleProperties(style)
		End Operator

		''' <summary>
		''' Initializes a SliderStyleProperties object with a style object that holds all data
		''' </summary>
		Public Sub New(ByVal style As GridStyleInfo)
			MyBase.New(style)
		End Sub

		''' <summary>
		''' Initializes a SliderStyleProperties object with an empty style object. Design
		''' time environment will use this ctor and later copy the values to a style object
		''' by calling style.CustomProperties.Add(gridExcelTipStyleProperties1)
		''' </summary>
		Public Sub New()
			MyBase.New()
		End Sub

		''' <summary>
		''' Gets or sets Minimum state
		''' </summary>
		<Description("Provides the Minimum for this cell"), Browsable(True), Category("Slider")> _
		Public Property Minimum() As Integer
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CInt(Fix(style.GetValue(MinimumProperty)))
			End Get
			Set(ByVal value As Integer)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(MinimumProperty, value)
			End Set
		End Property
		''' <summary>
		''' Resets Minimum state
		''' </summary>
		Public Sub ResetMinimum()
			style.ResetValue(MinimumProperty)
		End Sub
		<EditorBrowsableAttribute(EditorBrowsableState.Never)> _
		Private Function ShouldSerializeMinimum() As Boolean
			Return style.HasValue(MinimumProperty)
		End Function
		''' <summary>
		''' Gets if Minimum state has been initialized for the current object.
		''' </summary>
		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property HasMinimum() As Boolean
			Get
				Return style.HasValue(MinimumProperty)
			End Get
		End Property
		''' <summary>
		''' Gets or sets Maximum state
		''' </summary>
		<Description("Provides the Maximum for this cell"), Browsable(True), Category("Slider")> _
		Public Property Maximum() As Integer
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CInt(Fix(style.GetValue(MaximumProperty)))
			End Get
			Set(ByVal value As Integer)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(MaximumProperty, value)
			End Set
		End Property
		''' <summary>
		''' Resets Maximum state
		''' </summary>
		Public Sub ResetMaximum()
			style.ResetValue(MaximumProperty)
		End Sub
		<EditorBrowsableAttribute(EditorBrowsableState.Never)> _
		Private Function ShouldSerializeMaximum() As Boolean
			Return style.HasValue(MaximumProperty)
		End Function
		''' <summary>
		''' Gets if Maximum state has been initialized for the current object.
		''' </summary>
		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property HasMaximum() As Boolean
			Get
				Return style.HasValue(MaximumProperty)
			End Get
		End Property
		''' <summary>
		''' Gets or sets SmallChange state
		''' </summary>
		<Description("Provides the SmallChange for this cell"), Browsable(True), Category("Slider")> _
		Public Property SmallChange() As Integer
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CInt(Fix(style.GetValue(SmallChangeProperty)))
			End Get
			Set(ByVal value As Integer)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(SmallChangeProperty, value)
			End Set
		End Property
		''' <summary>
		''' Resets SmallChange state
		''' </summary>
		Public Sub ResetSmallChange()
			style.ResetValue(SmallChangeProperty)
		End Sub
		<EditorBrowsableAttribute(EditorBrowsableState.Never)> _
		Private Function ShouldSerializeSmallChange() As Boolean
			Return style.HasValue(SmallChangeProperty)
		End Function
		''' <summary>
		''' Gets if SmallChange state has been initialized for the current object.
		''' </summary>
		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property HasSmallChange() As Boolean
			Get
				Return style.HasValue(SmallChangeProperty)
			End Get
		End Property
		''' <summary>
		''' Gets or sets LargeChange state
		''' </summary>
		<Description("Provides the LargeChange for this cell"), Browsable(True), Category("Slider")> _
		Public Property LargeChange() As Integer
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CInt(Fix(style.GetValue(LargeChangeProperty)))
			End Get
			Set(ByVal value As Integer)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(LargeChangeProperty, value)
			End Set
		End Property
		''' <summary>
		''' Resets LargeChange state
		''' </summary>
		Public Sub ResetLargeChange()
			style.ResetValue(LargeChangeProperty)
		End Sub
		<EditorBrowsableAttribute(EditorBrowsableState.Never)> _
		Private Function ShouldSerializeLargeChange() As Boolean
			Return style.HasValue(LargeChangeProperty)
		End Function
		''' <summary>
		''' Gets if LargeChange state has been initialized for the current object.
		''' </summary>
		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property HasLargeChange() As Boolean
			Get
				Return style.HasValue(LargeChangeProperty)
			End Get
		End Property
		''' <summary>
		''' Gets or sets Orientation state
		''' </summary>
		<Description("Provides the Orientation for this cell"), Browsable(True), Category("Slider")> _
		Public Property Orientation() As Orientation
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CType(style.GetValue(OrientationProperty), Orientation)
			End Get
			Set(ByVal value As Orientation)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(OrientationProperty, value)
			End Set
		End Property
		''' <summary>
		''' Resets Orientation state
		''' </summary>
		Public Sub ResetOrientation()
			style.ResetValue(OrientationProperty)
		End Sub
		<EditorBrowsableAttribute(EditorBrowsableState.Never)> _
		Private Function ShouldSerializeOrientation() As Boolean
			Return style.HasValue(OrientationProperty)
		End Function
		''' <summary>
		''' Gets if Orientation state has been initialized for the current object.
		''' </summary>
		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property HasOrientation() As Boolean
			Get
				Return style.HasValue(OrientationProperty)
			End Get
		End Property
		''' <summary>
		''' Gets or sets TickFrequency state
		''' </summary>
		<Description("Provides the TickFrequency for this cell"), Browsable(True), Category("Slider")> _
		Public Property TickFrequency() As Integer
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CInt(Fix(style.GetValue(TickFrequencyProperty)))
			End Get
			Set(ByVal value As Integer)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(TickFrequencyProperty, value)
			End Set
		End Property
		''' <summary>
		''' Resets TickFrequency state
		''' </summary>
		Public Sub ResetTickFrequency()
			style.ResetValue(TickFrequencyProperty)
		End Sub
		<EditorBrowsableAttribute(EditorBrowsableState.Never)> _
		Private Function ShouldSerializeTickFrequency() As Boolean
			Return style.HasValue(TickFrequencyProperty)
		End Function
		''' <summary>
		''' Gets if TickFrequency state has been initialized for the current object.
		''' </summary>
		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property HasTickFrequency() As Boolean
			Get
				Return style.HasValue(TickFrequencyProperty)
			End Get
		End Property
		''' <summary>
		''' Gets or sets TickStyle state
		''' </summary>
		<Description("Provides the TickStyle for this cell"), Browsable(True), Category("Slider")> _
		Public Property TickStyle() As TickStyle
			Get
				'TraceUtil.TraceCurrentMethodInfo();
				Return CType(style.GetValue(TickStyleProperty), TickStyle)
			End Get
			Set(ByVal value As TickStyle)
				'TraceUtil.TraceCurrentMethodInfo(value);
				style.SetValue(TickStyleProperty, value)
			End Set
		End Property
		''' <summary>
		''' Resets TickStyle state
		''' </summary>
		Public Sub ResetTickStyle()
			style.ResetValue(TickStyleProperty)
		End Sub
		<EditorBrowsableAttribute(EditorBrowsableState.Never)> _
		Private Function ShouldSerializeTickStyle() As Boolean
			Return style.HasValue(TickStyleProperty)
		End Function
		''' <summary>
		''' Gets if TickStyle state has been initialized for the current object.
		''' </summary>
		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property HasTickStyle() As Boolean
			Get
				Return style.HasValue(TickStyleProperty)
			End Get
		End Property
	End Class
End Namespace

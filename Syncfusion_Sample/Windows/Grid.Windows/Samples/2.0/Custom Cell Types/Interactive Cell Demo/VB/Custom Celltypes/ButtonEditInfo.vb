Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.Serialization
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing.Imaging
Imports System.ComponentModel

Imports Syncfusion.Diagnostics
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Styles


Namespace InteractiveCellDemo
	#Region "CustomProperties_with expandable objects"

	''' <summary>
	''' Provides custom properties for button edit cell. All properties
	''' support the style inheritance mechanism. You can change these propeties
	''' in the property grid.
	''' </summary>
	''' 

	Public Class ButtonEditStyleProperties
		Inherits GridStyleInfoCustomProperties
		' static initialization of property descriptors
		Private Shared t As Type = GetType(ButtonEditStyleProperties)

		Private ReadOnly Shared ButtonEditInfoProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "ButtonEditInfo")

		' default settings for all properties this object holds
		Private Shared defaultObject As ButtonEditStyleProperties

		' initialize default settings for all properties in static ctor
		Shared Sub New()
			' all properties must be initialized for the Default property
			defaultObject = New ButtonEditStyleProperties(GridStyleInfo.Default)
			defaultObject.ButtonEditInfo = ButtonEditInfo.Default
		End Sub

		''' <summary>
		''' Provides access to default values for this type
		''' </summary>
		Public Shared ReadOnly Property [Default]() As ButtonEditStyleProperties
			Get
				Return defaultObject
			End Get
		End Property

		''' <summary>
		''' Force static ctor being called at least once
		''' </summary>
		Public Shared Sub Initialize()
		End Sub


		''' <summary>
		''' Explicit cast from GridStyleInfo to this custom propety object
		''' </summary>
		''' <returns>A new custom properties object.</returns>
		Public Shared Narrowing Operator CType(ByVal style As GridStyleInfo) As ButtonEditStyleProperties
			Return New ButtonEditStyleProperties(style)
		End Operator

		''' <summary>
		''' Initializes a ButtonEditStyleProperties object with a style object that holds all data
		''' </summary>
		Public Sub New(ByVal style As GridStyleInfo)
			MyBase.New(style)
		End Sub

		''' <summary>
		''' Initializes a ButtonEditStyleProperties object with an empty style object. Design
		''' time environment will use this ctor and later copy the values to a style object
		''' by calling style.CustomProperties.Add(gridExcelTipStyleProperties1)
		''' </summary>
		Public Sub New()
			MyBase.New()
		End Sub

		''' <summary>
		''' Specifies whether button should be shown at the left of textbox
		''' </summary>
		'''
		<Description("Button Edit properties"), Browsable(True), Category("Custom")> _
		Public Property ButtonEditInfo() As ButtonEditInfo
			Get
				Return CType(style.GetValue(ButtonEditInfoProperty), ButtonEditInfo)
			End Get
			Set(ByVal value As ButtonEditInfo)
				style.SetValue(ButtonEditInfoProperty, value)
			End Set
		End Property
	End Class
	''' <summary>
	''' Specifies the image for the ButtonEdit CellType
	''' </summary>
	Public Enum ButtonType
		None = 0
		Browse = 1
		Check = 2
		Down = 3
		Left = 4
		Leftend = 5
		Redo = 6
		Right = 7
		Rightend = 8
		Undo = 9
		Up = 10
		Image = 11
	End Enum
	#End Region

	''' <summary>
	''' Implements the data store for the <see cref="ButtonEditInfo"/> object.
	''' </summary>
	''' <seealso cref="StyleInfoStore"/>
	<Serializable, StaticDataField("sd")> _
	Public Class ButtonEditInfoStore
		Inherits StyleInfoStore
		Private Shared sd As New StaticData(GetType(ButtonEditInfoStore), GetType(ButtonEditInfo), True)

		''' <summary>
		''' Provides information about the <see cref="ButtonEditInfo.IsLeft"/> property
		''' </summary>
		Public ReadOnly Shared ButtonEditIsLeftProperty As StyleInfoProperty = sd.CreateStyleInfoProperty(GetType(Boolean), "ButtonEditIsLeft")

		''' <summary>
		''' Provides information about the <see cref="ButtonEditInfo.ButtonType"/> property
		''' </summary>
		Public ReadOnly Shared ButtonEditTypeProperty As StyleInfoProperty = sd.CreateStyleInfoProperty(GetType(Integer), "ButtonEditType")

		''' <summary>
		''' Provides information about the <see cref="ButtonEditInfo.Width"/> property
		''' </summary>
		Public ReadOnly Shared ButtonEditWidthProperty As StyleInfoProperty = sd.CreateStyleInfoProperty(GetType(Integer), "ButtonEditWidth")

		''' <summary>
		''' Provides information about the <see cref="ButtonEditInfo.Text"/> property
		''' </summary>
		Public ReadOnly Shared ButtonEditTextProperty As StyleInfoProperty = sd.CreateStyleInfoProperty(GetType(String), "ButtonEditText")

		''' <summary>
		''' Provides information about the <see cref="ButtonEditInfo.TextColor"/> property
		''' </summary>
		Public ReadOnly Shared ButtonEditTextColorProperty As StyleInfoProperty = sd.CreateStyleInfoProperty(GetType(System.Drawing.Color), "ButtonEditTextColor")

		''' <summary>
		''' Provides information about the <see cref="ButtonEditInfo.BackColor"/> property
		''' </summary>
		Public ReadOnly Shared ButtonEditBackColorProperty As StyleInfoProperty = sd.CreateStyleInfoProperty(GetType(System.Drawing.Color), "ButtonEditBackColor")

		''' <summary>
		''' Provides information about the <see cref="ButtonEditInfo.Enabled"/> property
		''' </summary>
		Public ReadOnly Shared ButtonEditEnabledProperty As StyleInfoProperty = sd.CreateStyleInfoProperty(GetType(Boolean), "ButtonEditEnabled")

		''' <summary>
		''' Provides information about the <see cref="ButtonEditInfo.Image"/> property
		''' </summary>
		Public ReadOnly Shared ButtonEditImageProperty As StyleInfoProperty = sd.CreateStyleInfoProperty(GetType(Image), "ButtonEditImage")


		''' <summary>
		''' Provides information about the <see cref="ButtonEditInfo.ForceBackColor"></see>
		''' </summary>
		Public ReadOnly Shared ButtonEditForceBackColorProperty As StyleInfoProperty = sd.CreateStyleInfoProperty(GetType(Boolean), "ButtonEditForceBackColor")


		''' <summary>
		''' Provides information about the <see cref="ButtonEditInfo.HorizontalAlignment"/> property.
		''' </summary>
		Public ReadOnly Shared ButtonEditTextHorizontalAlignmentProperty As StyleInfoProperty = sd.CreateStyleInfoProperty(GetType(GridHorizontalAlignment), "HorizontalAlignment", 3, True)

		''' <summary>
		''' Provides information about the <see cref="ButtonEditInfo.VerticalAlignment"/> property.
		''' </summary>
		Public ReadOnly Shared ButtonEditTextVerticalAlignmentProperty As StyleInfoProperty = sd.CreateStyleInfoProperty(GetType(GridVerticalAlignment), "VerticalAlignment", 3, True)


		''' <override/>
		Protected Overrides ReadOnly Property StaticDataStore() As StaticData
			Get
				Return sd
			End Get
		End Property

		''' <overload>
		''' Initializes a <see cref="ButtonEditInfoStore"/>
		''' </overload>
		''' <summary>
		''' Initializes an empty <see cref="ButtonEditInfoStore"/>.
		''' </summary>
		Public Sub New()
		End Sub

		''' <summary>
		''' Initializes a new <see cref="ButtonEditInfoStore"/> from a serialization stream.
		''' </summary>
		''' <param name="info">An object that holds all the data needed to serialize or deserialize this instance.</param>
		''' <param name="context">Describes the source and destination of the serialized stream specified by info. </param>
		Private Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub

		' Base class implementation of this method calls Activator.CreateInstance to achieve the same result.
		' I assume calling new directly is more efficient. Otherwise this override is obsolete.
		''' <override/>
		Public Overrides Function Clone() As Object
			Dim target As StyleInfoStore = New ButtonEditInfoStore()
			CopyTo(target)
			Return target
		End Function
	End Class

	''' <summary>
	''' provides a <see cref="GridStyleInfoSubObject"/> object for button edit properties in a cell.
	''' <para/>Each property in this sub object can be configured individually. Properties that
	''' have not been initialized will inherit default values from a base style.
	''' </summary>
	<TypeConverter(GetType(StyleInfoBaseConverter))> _
	Public Class ButtonEditInfo
		Inherits GridStyleInfoSubObject
		' Static Fields
		Private Shared defaultButtonEditInfo As ButtonEditInfo

		Friend Shared Function CreateObject(ByVal identity As StyleInfoSubObjectIdentity, ByVal store As Object) As Object
			If store IsNot Nothing Then
				Return New ButtonEditInfo(identity, TryCast(store, ButtonEditInfoStore))
			End If
			Return New ButtonEditInfo(identity)
		End Function

		''' <summary>
		''' Releases the all resources used by the Component.
		''' </summary>
		Public Overrides Sub Dispose()
			MyBase.Dispose()
		End Sub

		' Constructors
		''' <overload>
		''' Initializes a <see cref="ButtonEditInfo"/>
		''' </overload>
		''' <summary>
		''' Initializes a <see cref="ButtonEditInfo"/>
		''' </summary>
		<DebuggerStepThrough()> _
		Public Sub New()
			MyBase.New(New ButtonEditInfoStore())
		End Sub

		''' <summary>
		''' Initalizes a new <see cref="ButtonEditInfo"/>  object and associates it with an existing <see cref="GridStyleInfoSubObjectIdentity"/>.
		''' </summary>
		''' <param name="identity">A <see cref="GridStyleInfoSubObjectIdentity"/> that holds the indentity for this <see cref="ButtonEditInfo"/>.
		''' </param>
		<DebuggerStepThrough()> _
		Public Sub New(ByVal identity As StyleInfoSubObjectIdentity)
			MyBase.New(identity, New ButtonEditInfoStore())

		End Sub

		''' <summary>
		''' Initalizes a new <see cref="ButtonEditInfo"/>  object and associates it with an existing <see cref="GridStyleInfoSubObjectIdentity"/>.
		''' </summary>
		''' <param name="identity">A <see cref="GridStyleInfoSubObjectIdentity"/> that holds the indentity for this <see cref="GridFontInfo"/>.
		''' <param name="store">A <see cref="ButtonEditInfoStore"/> that holds data for this <see cref="GridFontInfo"/>.
		''' All changes in this style object will saved in the <see cref="ButtonEditInfoStore"/> object.</param>
		''' </param>
		<DebuggerStepThrough()> _
		Public Sub New(ByVal identity As StyleInfoSubObjectIdentity, ByVal store As ButtonEditInfoStore)
			MyBase.New(identity, store)
		End Sub

		''' <summary>
		''' Initalizes a new <see cref="ButtonEditInfo"/>  object and initializes its IsLeft, ButtonEditType, Width, Text, TextColor, Enabled and
		''' BackColor properties
		''' </summary>
		<DebuggerStepThrough()> _
		Public Sub New(ByVal font As Font)
			MyBase.New(New ButtonEditInfoStore())
			IsLeft = False
			ButtonEditType = InteractiveCellDemo.ButtonType.Browse
			Width = 20
			Text = Nothing
			TextColor = Color.Black
			Enabled = True
			BackColor = Control.DefaultBackColor
			Image = Nothing
			HorizontalAlignment = GridHorizontalAlignment.Center
			VerticalAlignment = GridVerticalAlignment.Middle
		End Sub

		' Base class implementation of this method calls Activator.CreateInstance to achieve the same result.
		' I assume calling new directly is more efficient. Otherwise this override is obsolete.

		''' <override/>
		<DebuggerStepThrough()> _
		Public Overrides Function MakeCopy(ByVal newOwner As StyleInfoBase, ByVal sip As StyleInfoProperty) As IStyleInfoSubObject
			Return New ButtonEditInfo(newOwner.CreateSubObjectIdentity(sip), CType(Store.Clone(), ButtonEditInfoStore))
		End Function

		''' <summary>
		''' Returns a default <see cref="ButtonEditInfo"/> to be used with a default style.
		''' </summary>
		''' <remarks>
		'''	<para/>
		'''	Default settings are:<para/>
		'''	<list type="table">
		'''	<listheader><term>Property</term><description>Value</description></listheader>
		'''	<item><term><see cref="IsLeft"/></term><description>False</description></item>
		'''	<item><term><see cref="ButtonEditType"/></term><description>ButtonEditType.Browse</description></item>
		'''	<item><term><see cref="Width"/></term><description>20</description></item>
		'''	<item><term><see cref="Text"/></term><description>""</description></item>
		'''	<item><term><see cref="TextColor"/></term><description>Color.Black</description></item>
		'''	<item><term><see cref="BackColor"/></term><description>Control.DefaultBackColor</description></item>
		'''	<item><term><see cref="Enabled"/></term><description>True</description></item>
		'''	<item><term><see cref="Image"/></term><description>null</description></item>
		'''	</list>
		''' </remarks>
		Public Shared ReadOnly Property [Default]() As ButtonEditInfo
			<DebuggerStepThrough()> _
			Get
				If defaultButtonEditInfo Is Nothing Then
					defaultButtonEditInfo = New ButtonEditInfo()
					defaultButtonEditInfo.IsLeft = False
					defaultButtonEditInfo.ButtonEditType = InteractiveCellDemo.ButtonType.Browse
					defaultButtonEditInfo.Width = 20
					defaultButtonEditInfo.Text = Nothing
					defaultButtonEditInfo.TextColor = Color.Black
					defaultButtonEditInfo.Enabled = True
					defaultButtonEditInfo.BackColor = Control.DefaultBackColor
					defaultButtonEditInfo.Image = Nothing

					'If the themes are enabled, setting this forces to draw the button color
					defaultButtonEditInfo.ForceBackColor = False

					defaultButtonEditInfo.HorizontalAlignment = GridHorizontalAlignment.Center
					defaultButtonEditInfo.VerticalAlignment = GridVerticalAlignment.Middle
				End If
				Return defaultButtonEditInfo
			End Get
		End Property

		''' <override/>
		Protected Overrides Sub OnStyleChanged(ByVal sip As StyleInfoProperty)
			MyBase.OnStyleChanged(sip)
		End Sub

		''' <override/>
		Protected Overrides Function GetDefaultStyle() As StyleInfoBase
			Return [Default]
		End Function


		'Properties
		#Region "IsLeft"
		''' <summary>
		''' This Property specifies whether the button should be positioned in the left side of the cell
		''' </summary>
		''' 
		<Description("specifies if the button should be positioned to the left."), Browsable(True), Category("Custom"), NotifyParentProperty(True)> _
		Public Property IsLeft() As Boolean
			Get
				Return CBool(GetValue(ButtonEditInfoStore.ButtonEditIsLeftProperty))
			End Get
			Set(ByVal value As Boolean)
				SetValue(ButtonEditInfoStore.ButtonEditIsLeftProperty, value)
			End Set
		End Property
		#End Region

		#Region "ButtonEditType"
		''' <summary>
		''' This property specifies the type of the Image to be drawn in the button
		''' </summary>
		''' 
		<Description("Specifies the type of the Image to be drawn in the button."), Browsable(True), Category("Custom"), NotifyParentProperty(True)> _
		Public Property ButtonEditType() As ButtonType
			Get
				Return CType(GetValue(ButtonEditInfoStore.ButtonEditTypeProperty), ButtonType)
			End Get
			Set(ByVal value As ButtonType)
				SetValue(ButtonEditInfoStore.ButtonEditTypeProperty, value)

				If ButtonEditType <> ButtonType.Image Then
					Image = Nothing
				End If
			End Set
		End Property
#End Region

		#Region "Width"
		''' <summary>
		'''This property specifies the width of the button
		''' </summary>
		<Description("Specifies the width of the button"), Browsable(True), Category("Custom"), NotifyParentProperty(True)> _
		Public Property Width() As Integer
			Get
				Return CInt(Fix(GetValue(ButtonEditInfoStore.ButtonEditWidthProperty)))
			End Get
			Set(ByVal value As Integer)
				SetValue(ButtonEditInfoStore.ButtonEditWidthProperty, value)
			End Set
		End Property
		#End Region

		#Region "Text"
		''' <summary>
		''' This property specifies the text to be shown in the button
		''' </summary>
		<Description("Specifies the text to be shown in the button"), Browsable(True), Category("Custom"), NotifyParentProperty(True)> _
		Public Property Text() As String
			Get
				Return CStr(GetValue(ButtonEditInfoStore.ButtonEditTextProperty))
			End Get
			Set(ByVal value As String)
				SetValue(ButtonEditInfoStore.ButtonEditTextProperty, value)
			End Set
		End Property
		#End Region

		#Region "TextColor"
		''' <summary>
		''' This property specifies the text color
		''' </summary>
		<Description("Specifies the text color"), Browsable(True), Category("Custom"), NotifyParentProperty(True)> _
		Public Property TextColor() As Color
			Get
				Return CType(GetValue(ButtonEditInfoStore.ButtonEditTextColorProperty), Color)
			End Get
			Set(ByVal value As Color)
				SetValue(ButtonEditInfoStore.ButtonEditTextColorProperty, value)
			End Set
		End Property
		#End Region

		#Region "Enabled"
		''' <summary>
		''' This property specifies if the button should be enabled
		''' </summary>
		<Description("Specifies if the button should be enabled"), Browsable(True), Category("Custom"), NotifyParentProperty(True)> _
		Public Property Enabled() As Boolean
			Get
				Return CBool(GetValue(ButtonEditInfoStore.ButtonEditEnabledProperty))
			End Get
			Set(ByVal value As Boolean)
				SetValue(ButtonEditInfoStore.ButtonEditEnabledProperty, value)
			End Set
		End Property
		#End Region

		#Region "BackColor"
		''' <summary>
		''' This property specifies the BackColor of the button
		''' </summary>
		<Description("Specifies the BackColor of the button"), Browsable(True), Category("Custom"), NotifyParentProperty(True)> _
		Public Property BackColor() As Color
			Get
				Return CType(GetValue(ButtonEditInfoStore.ButtonEditBackColorProperty), Color)
			End Get
			Set(ByVal value As Color)
				SetValue(ButtonEditInfoStore.ButtonEditBackColorProperty, value)
			End Set
		End Property
		#End Region

		#Region "Image"
		''' <summary>
		''' This property specifies the Image to be displayed in the button
		''' </summary>
		<Description("Specifies the image to be displayed in the button"), Browsable(True), Category("Custom"), NotifyParentProperty(True)> _
		Public Property Image() As Image
			Get
				Return CType(GetValue(ButtonEditInfoStore.ButtonEditImageProperty), Image)
			End Get
			Set(ByVal value As Image)
				If Me.ButtonEditType = ButtonType.Image Then
					SetValue(ButtonEditInfoStore.ButtonEditImageProperty, value)
				End If
			End Set
		End Property
		#End Region

		#Region "ForceBackColor"
		''' <summary>
		''' This Property specifies whether the button should be colored with the <see cref="ButtonEditInfo.BackColor"></see> 
		''' if themes are enabled
		''' </summary>
		''' 
		<Description("specifies whether the button should be colored neglecting the themes"), Browsable(True), Category("Custom"), NotifyParentProperty(True)> _
		Public Property ForceBackColor() As Boolean
			Get
				Return CBool(GetValue(ButtonEditInfoStore.ButtonEditForceBackColorProperty))
			End Get
			Set(ByVal value As Boolean)
				SetValue(ButtonEditInfoStore.ButtonEditForceBackColorProperty, value)
			End Set
		End Property
		#End Region

		#Region "VerticalAlignment"
		<Description("Specifies vertical alignment of text in the Button."), Browsable(True), Category("Custom"), NotifyParentProperty(True)> _
		Public Property VerticalAlignment() As GridVerticalAlignment
			Get
				Return CType(GetShortValue(ButtonEditInfoStore.ButtonEditTextVerticalAlignmentProperty), GridVerticalAlignment)
			End Get
			Set(ByVal value As GridVerticalAlignment)
				SetValue(ButtonEditInfoStore.ButtonEditTextVerticalAlignmentProperty, CShort(Fix(value)))
			End Set
		End Property
		#End Region

		#Region "HorizontalAlignment"
		<Description("Specifies horizontal alignment of text in the Button."), Browsable(True), Category("Custom"), NotifyParentProperty(True)> _
		Public Property HorizontalAlignment() As GridHorizontalAlignment
			Get
				Return CType(GetShortValue(ButtonEditInfoStore.ButtonEditTextHorizontalAlignmentProperty), GridHorizontalAlignment)
			End Get
			Set(ByVal value As GridHorizontalAlignment)
				SetValue(ButtonEditInfoStore.ButtonEditTextHorizontalAlignmentProperty, CShort(Fix(value)))
			End Set
		End Property
		#End Region
	End Class
End Namespace
Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
'
'  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.Runtime.Serialization

Namespace Syncfusion.Windows.Forms.Diagram.Samples
	''' <summary>
	''' Specifically symbol class for CustomSymbol sample.
	''' </summary>
	<Serializable(), TypeConverter(GetType(MySymbolConverter))> _
	Public Class MySymbol
		Inherits Group
		#Region "Class members"
'INSTANT VB NOTE: The variable clickCount was renamed since Visual Basic does not allow class members with the same name:
		Private clickCount_Renamed As Integer
		#End Region

		#Region "Class Initialize/Finalize methods"
		''' <summary>
		''' Default constructor.
		''' </summary>
		Public Sub New()
			'////////////////////////////////////////////////////////////////
			' Add child nodes to the symbol programmatically
			'////////////////////////////////////////////////////////////////

			' Add an outer rectangle
			Dim outerRect As New Rectangle(100, 100, 96, 72)
			outerRect.Name = "Rectangle"
			outerRect.FillStyle.Type = FillStyleType.LinearGradient
			outerRect.FillStyle.ForeColor = Color.GhostWhite
			outerRect.FillStyle.Color = Color.LightSkyBlue
			outerRect.EditStyle.AllowSelect = False
			Me.AppendChild(outerRect)
			' Add a polygon
			Dim pts() As PointF= { New Point(6, 36), New Point(48, 6), New Point(90, 36), New Point(48, 66) }

			Dim polygon As New Polygon(pts)
			polygon.Name = "Polygon"
			polygon.FillStyle.Type = FillStyleType.LinearGradient
			polygon.FillStyle.ForeColor = Color.DarkSeaGreen
			polygon.FillStyle.Color = Color.White
			polygon.EditStyle.AllowSelect = False
			Me.AppendChild(polygon)


		End Sub

		''' <summary>
		''' Copy constructor.
		''' </summary>
		''' <param name="src"></param>
		Public Sub New(ByVal src As MySymbol)
			MyBase.New(src)
		End Sub

		''' <summary>
		''' Serialization constructor for the MySymbol class.
		''' </summary>
		''' <param name="info">Serialization state information</param>
		''' <param name="context">Streaming context information</param>
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
			' The Serialization constructor is invoked during deserialization or during a drag & drop operation.
			' If the MySymbol type has serializable members, then initialize them with the serialized data 
			' obtained from the SerializationInfo param
		End Sub
		#End Region

		#Region "Class properties"
		''' <summary>
		''' Get mouse click count.
		''' </summary>
		Public ReadOnly Property ClickCount() As Integer
			Get
				Return clickCount_Renamed
			End Get
		End Property
		#End Region

		#Region "Class overrides"
		''' <summary>
		''' Increase mouse click count.
		''' </summary>
		''' <param name="evtArgs"></param>
		<EventHandlerPriority(True)> _
		Protected Overrides Sub OnMouseClick(ByVal e As EventArgs)
			clickCount_Renamed = clickCount_Renamed + 1
		End Sub
		''' <summary>
		''' Creates a new object that is a copy of the current instance.
		''' </summary>
		''' <returns>Copy of the object this method is invoked against</returns>
		Public Overrides Function Clone() As Object
			Return New MySymbol(Me)
		End Function
		#End Region
	End Class

	''' <summary>
	''' Serialize helper class for MySymbol.
	''' </summary>
	Public Class MySymbolConverter
		Inherits TypeConverter
		''' <summary>
		''' 
		''' </summary>
		''' <param name="context"></param>
		''' <param name="culture"></param>
		''' <param name="value"></param>
		''' <param name="destinationType"></param>
		''' <returns></returns>
		Public Overrides Overloads Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object, ByVal destinationType As Type) As Object
			Return MyBase.ConvertTo(context, culture, value, destinationType)
		End Function

		''' <summary>
		''' 
		''' </summary>
		''' <param name="context"></param>
		''' <returns></returns>
		Public Overrides Overloads Function GetPropertiesSupported(ByVal context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		''' <summary>
		''' 
		''' </summary>
		''' <param name="context"></param>
		''' <param name="value"></param>
		''' <param name="attributes"></param>
		''' <returns></returns>
		Public Overrides Overloads Function GetProperties(ByVal context As ITypeDescriptorContext, ByVal value As Object, ByVal attributes() As Attribute) As PropertyDescriptorCollection
			Dim attrs() As Attribute = { New BrowsableAttribute(True) }

			' This code returns only the specified properties. It can be used to filter out
			' properties that you do not wish to expose to in property grid.
			Dim props(1) As PropertyDescriptor
			props(0) = TypeDescriptor.CreateProperty(GetType(MySymbol), "Name", GetType(String), attrs)
			props(1) = TypeDescriptor.CreateProperty(GetType(MySymbol), "ClickCount", GetType(Integer), attrs)
			Return New PropertyDescriptorCollection(props)
		End Function
	End Class
End Namespace

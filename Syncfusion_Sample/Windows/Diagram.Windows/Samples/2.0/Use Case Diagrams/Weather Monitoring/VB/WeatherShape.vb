Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.Serialization
Imports System.Drawing

Namespace Syncfusion.Windows.Forms.Diagram.Samples
	''' <summary>
	''' Renders a weather node
	''' </summary>
	<Serializable> _
	Public Class WeatherNode
		Inherits Group
		#Region "Members"
		Private m_weatherCondition As WeatherCondition
		Private m_fTemperature As Decimal
		Private m_strState As String
		Private m_imageNode As BitmapNode
		#End Region

		#Region "Initialization"
		''' <summary>
		''' Initializes a new instance of the <see cref="WeatherNode"/> class.
		''' </summary>        
		Public Sub New()
			MyBase.New()
			m_imageNode = New BitmapNode(New Bitmap(Image.FromFile("..//..//Data//Sunny.png")))
			m_imageNode.Size = New SizeF(32, 32)
			m_imageNode.LineStyle.LineWidth = 0
			Me.EditStyle.AllowSelect = False
			Me.AppendChild(m_imageNode)
			Dim lbl As New Label()
			lbl.FontStyle.Family = "Arial"
			lbl.Position = Position.TopCenter
			lbl.FontColorStyle.Color = Color.White
			Me.Labels.Add(lbl)
			lbl = New Label()
			lbl.FontStyle.Family = "Arial"
			lbl.Position = Position.MiddleRight
			lbl.FontColorStyle.Color = Color.White
			Me.Labels.Add(lbl)
		End Sub

		''' <summary>
		''' Initializes a new instance of the <see cref="WeatherNode"/> class.
		''' </summary>
		''' <param name="src">Object to copy.</param>
		Public Sub New(ByVal src As WeatherNode)
			MyBase.New(src)
			m_weatherCondition = src.m_weatherCondition
			m_strState = src.m_strState
			m_fTemperature = src.m_fTemperature
		End Sub

		''' <summary>
		''' Initializes a new instance of the <see cref="WeatherNode"/> class.
		''' </summary>
		''' <param name="info">Serialization state information.</param>
		''' <param name="context">Streaming context information.</param>
		Public Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
			For Each entry As SerializationEntry In info
				Select Case entry.Name
					Case "state"
						m_strState = entry.Value.ToString()
					Case "temperature"
						m_fTemperature = CDec(entry.Value)
					Case "weatherCondition"
						m_weatherCondition = CType(entry.Value, WeatherCondition)
				End Select
			Next entry
		End Sub
		#End Region

		#Region "Properties"
		''' <summary>
		''' Gets or sets the weather condition.
		''' </summary>        
		Public Property WeatherCondition() As WeatherCondition
			Get
				Return m_weatherCondition
			End Get
			Set(ByVal value As WeatherCondition)
				If value <> m_weatherCondition Then
					m_weatherCondition = value
					If value = WeatherCondition.Rain Then
						m_imageNode.Image = CType(Image.FromFile("..//..//Data//Rain.png"), Bitmap)
					ElseIf value = WeatherCondition.ThunderStorm Then
						m_imageNode.Image = CType(Image.FromFile("..//..//Data//Thunder.png"), Bitmap)
					ElseIf value = WeatherCondition.Snow Then
						m_imageNode.Image = CType(Image.FromFile("..//..//Data//Snow.png"), Bitmap)
					ElseIf value = WeatherCondition.None Then
						m_imageNode.Image = CType(Image.FromFile("..//..//Data//Sunny.png"), Bitmap)
					End If
					OnPropertyChanged(Me.FullContainerName, "WeatherCondition")
				End If
			End Set
		End Property

		''' <summary>
		''' Gets or sets the temperature.
		''' </summary>
		Public Property Temperature() As Decimal
			Get
				Return m_fTemperature
			End Get
			Set(ByVal value As Decimal)
				If value <> m_fTemperature Then
					m_fTemperature = value
					Me.Labels(0).Text = value & " F"
					OnPropertyChanged(Me.FullContainerName, "Temperature")
				End If
			End Set
		End Property

		''' <summary>
		''' Gets or sets state name.
		''' </summary>
		Public Property State() As String
			Get
				Return m_strState
			End Get
			Set(ByVal value As String)
				If value <> m_strState Then
					m_strState = value
					Me.Labels(1).Text = value & ""
					OnPropertyChanged(Me.FullContainerName, "State")
				End If
			End Set
		End Property
		#End Region

		#Region "Overrides"
		''' <summary>
		''' Creates a new object that is a copy of the current instance.
		''' </summary>
		''' <returns>Copy of the object this method is invoked against.</returns>
		Public Overrides Function Clone() As Object
			Return New WeatherNode(Me)
		End Function

		''' <summary>
		''' Populates a SerializationInfo with the data needed to
		''' serialize the target object.
		''' </summary>
		''' <param name="info">SerializationInfo object to populate.</param>
		''' <param name="context">Destination streaming context.</param>
		Protected Overrides Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.GetObjectData(info, context)
			info.AddValue("state", m_strState)
			info.AddValue("temperature", m_fTemperature)
			info.AddValue("weatherCondition", m_weatherCondition)
		End Sub
		#End Region

		#Region "Helper methods"
		#End Region
	End Class

	''' <summary>
	''' Specifies the weather condition
	''' </summary>
	Public Enum WeatherCondition
		None
		Rain
		Snow
		ThunderStorm
	End Enum

	''' <summary>
	''' State class which holds its name, latitude and longitude
	''' </summary>
	Public Class State
		Private dLatitude As Decimal
		Private dLongitude As Decimal
		Private strName As String
		Public ReadOnly Property Latitude() As Decimal
			Get
				Return dLatitude
			End Get
		End Property

		Public ReadOnly Property Longitude() As Decimal
			Get
				Return dLongitude
			End Get
		End Property

		Public ReadOnly Property Name() As String
			Get
				Return strName
			End Get
		End Property

		Public Sub New(ByVal name As String, ByVal latitude As Decimal, ByVal longtitude As Decimal)
			dLatitude = latitude
			dLongitude = longtitude
			strName = name
		End Sub
	End Class
End Namespace

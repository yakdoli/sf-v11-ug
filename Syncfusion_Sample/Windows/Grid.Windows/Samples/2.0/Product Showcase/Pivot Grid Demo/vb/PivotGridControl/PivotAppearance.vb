Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Drawing
Imports System.ComponentModel
Imports System.IO
Imports System.Xml.Serialization
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml

Imports Syncfusion.Windows.Forms.Grid

Namespace PivotGridLibrary
	''' <summary>
	''' Specifies the colors and fonts used in a PivotGridControl
	''' </summary>
	<TypeConverter(GetType(ExpandableObjectConverter)), Serializable> _
	Public Class PivotAppearance
		Implements ISerializable
		''' <summary>
		''' Default Constructor. Only present to support XML serialization.
		''' </summary>
		Public Sub New()

		End Sub

		''' <summary>
		''' Constructor
		''' </summary>
		''' <param name="Pivot">The PivotGridControl associated with this appearance object.</param>
		Public Sub New(ByVal PivotGridControl As PivotGridControl)
			Me.PivotGridControl = PivotGridControl
		End Sub

		#Region "Serialization Support"
		''' <summary>
		''' Initializes a new <see cref="PivotAppearance"/> from a serialization stream.
		''' </summary>
		''' <param name="info">An object that holds all the data needed to serialize or deserialize this instance.</param>
		''' <param name="context">Describes the source and destination of the serialized stream specified by info. </param>
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			Me.version = CInt(Fix(info.GetValue("version", GetType(Integer))))

			Me.totalString_Renamed = CStr(info.GetValue("totalString", GetType(String)))
			Me.grandTotalString_Renamed = CStr(info.GetValue("grandTotalString", GetType(String)))
			Me.allString_Renamed = CStr(info.GetValue("allString", GetType(String)))

			Me.valueCell_Renamed = CType(info.GetValue("valueCell", GetType(GridStyleInfo)), GridStyleInfo)
			Me.rowTotalCell_Renamed = CType(info.GetValue("rowTotalCell", GetType(GridStyleInfo)), GridStyleInfo)
			Me.rowExpandCell_Renamed = CType(info.GetValue("rowExpandCell", GetType(GridStyleInfo)), GridStyleInfo)
			Me.rowCell_Renamed = CType(info.GetValue("rowCell", GetType(GridStyleInfo)), GridStyleInfo)
			Me.columnExpandCell_Renamed = CType(info.GetValue("columnExpandCell", GetType(GridStyleInfo)), GridStyleInfo)
			Me.columnTotalCell_Renamed = CType(info.GetValue("columnTotalCell", GetType(GridStyleInfo)), GridStyleInfo)
			Me.columnCell_Renamed = CType(info.GetValue("columnCell", GetType(GridStyleInfo)), GridStyleInfo)
			Me.calculationNameCell_Renamed = CType(info.GetValue("calculationNameCell", GetType(GridStyleInfo)), GridStyleInfo)
			Me.topLeftCell_Renamed = CType(info.GetValue("topLeftCell", GetType(GridStyleInfo)), GridStyleInfo)


			'addproperty  - need to add code here when you add a property to PivotAppearance
		End Sub

		' //version = 0  - orignal version release as 5.2.0.xx
		Private version As Integer = 0

		''' <summary>
		''' Attaches an Appearance object to a particular PivotGridControl.
		''' </summary>
		''' <param name="Pivot">The Appearance object.</param>
		Public Sub AttachPivot(ByVal PivotGridControl As PivotGridControl)
			Me.PivotGridControl = PivotGridControl
			Me.PivotGridControl.SetAppearance(Me)

			If Not TotalStringChangedEvent Is Nothing Then
			RaiseEvent TotalStringChanged(Me, EventArgs.Empty)
			End If
			If Not GrandTotalStringChangedEvent Is Nothing Then
			RaiseEvent GrandTotalStringChanged(Me, EventArgs.Empty)
			End If
			If Not AllStringChangedEvent Is Nothing Then
			RaiseEvent AllStringChanged(Me, EventArgs.Empty)
			End If

			If Not ValueCellChangedEvent Is Nothing Then
			RaiseEvent ValueCellChanged(Me, EventArgs.Empty)
			End If
			If Not RowCellChangedEvent Is Nothing Then
			RaiseEvent RowCellChanged(Me, EventArgs.Empty)
			End If
			If Not RowExpandCellChangedEvent Is Nothing Then
			RaiseEvent RowExpandCellChanged(Me, EventArgs.Empty)
			End If
			If Not RowTotalCellChangedEvent Is Nothing Then
			RaiseEvent RowTotalCellChanged(Me, EventArgs.Empty)
			End If

			If Not ColumnExpandCellChangedEvent Is Nothing Then
			RaiseEvent ColumnExpandCellChanged(Me, EventArgs.Empty)
			End If
			If Not ColumnTotalCellChangedEvent Is Nothing Then
			RaiseEvent ColumnTotalCellChanged(Me, EventArgs.Empty)
			End If
			If Not ColumnCellChangedEvent Is Nothing Then
			RaiseEvent ColumnCellChanged(Me, EventArgs.Empty)
			End If
			If Not CalculationNameCellChangedEvent Is Nothing Then
			RaiseEvent CalculationNameCellChanged(Me, EventArgs.Empty)
			End If
			If Not TopLeftCellChangedEvent Is Nothing Then
			RaiseEvent TopLeftCellChanged(Me, EventArgs.Empty)
			End If

			'addproperty - need to add code here when you add a property to PivotAppearance
		End Sub

		Private PivotGridControl As PivotGridControl



		''' <summary>
		''' Creates an instance of <see cref="PivotAppearance"/> that was
		''' previously serialized as a XML file.
		''' </summary>
		''' <param name="fileName">The serialized filename.</param>
		''' <returns>A PivotAppearance.</returns>
		Public Shared Function LoadXML(ByVal fileName As String) As PivotAppearance
			Dim appearance As PivotAppearance = Nothing
			Dim s As Stream = File.OpenRead(fileName)

			Try
				Dim serializer As XmlSerializer = New XmlSerializer(GetType(PivotAppearance))
				appearance = TryCast(serializer.Deserialize(s), PivotAppearance)
			Finally
				s.Close()
			End Try
			Return appearance
		End Function

		''' <summary>
		''' Saves this Appearance object in an XML file 
		''' with the specified filename.
		''' </summary>
		Public Sub SaveXML(ByVal fileName As String)
			Try
				Dim serializer As XmlSerializer = New XmlSerializer(GetType(PivotAppearance))
				Dim textWriter As TextWriter = New StreamWriter(fileName)

				Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(textWriter)
				xmlTextWriter.Formatting = Formatting.Indented
				serializer.Serialize(xmlTextWriter, Me)
				textWriter.Close()
			Catch

			End Try

		End Sub



		#Region "ISerializable Members"

		''' <summary>
		''' Implements the ISerializable interface and returns the data needed to serialize the Appearance object.
		''' </summary>
		''' <param name="info">A SerializationInfo object containing the information required to serialize the Appearance object.</param>
		''' <param name="context">A StreamingContext object containing the source and destination of the serialized stream.</param>
		Public Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext) Implements ISerializable.GetObjectData
			info.AddValue("version", version)
			info.AddValue("totalString", totalString_Renamed)
			info.AddValue("grandTotalString", grandTotalString_Renamed)
			info.AddValue("allString", allString_Renamed)
			info.AddValue("valueCell", valueCell_Renamed)
			info.AddValue("rowCell", rowCell_Renamed)
			info.AddValue("rowExpandCell", rowExpandCell_Renamed)
			info.AddValue("rowTotalCell", rowTotalCell_Renamed)
			info.AddValue("columnExpandCell", columnExpandCell_Renamed)
			info.AddValue("columnTotalCell", columnTotalCell_Renamed)
			info.AddValue("columnCell", columnCell_Renamed)
			info.AddValue("calculationNameCell", calculationNameCell_Renamed)
			info.AddValue("topLeftCell", topLeftCell_Renamed)

			'addproperty  - need to add code here when you add a property to PivotAppearance
		End Sub

		#End Region
		#End Region

		#Region "Properties"

		#Region "strings"

		#Region "Total"

		Private totalString_Renamed As String = "Total"

		''' <summary>
		''' Gets or sets the generic text for the word 'Total' used in summary cells. 
		''' </summary>
		<Browsable(True), Description("The generic text for the word 'Total' used in summary cells."), DefaultValue("Total"), Category("Strings")> _
		Public Property TotalString() As String
			Get
				Return totalString_Renamed
			End Get
			Set(ByVal value As String)
				If value <> totalString_Renamed Then
					totalString_Renamed = value
					If Not TotalStringChangedEvent Is Nothing Then
						RaiseEvent TotalStringChanged(Me, EventArgs.Empty)
					End If
				End If
			End Set
		End Property
		''' <summary>
		''' A notification event that is raised after TimeFormat is modified. 
		''' </summary>
		Public Event TotalStringChanged As EventHandler
		#End Region

		#Region "GrandTotal"

		Private grandTotalString_Renamed As String = "GrandTotal"

		''' <summary>
		''' Gets or sets the generic text for the word 'GrandTotal' used in summary cells. 
		''' </summary>
		<Browsable(True), Description("The generic text for the word 'GrandTotal' used in summary cells."), DefaultValue("GrandTotal"), Category("Strings")> _
		Public Property GrandTotalString() As String
			Get
				Return grandTotalString_Renamed
			End Get
			Set(ByVal value As String)
				If value <> grandTotalString_Renamed Then
					grandTotalString_Renamed = value
					If Not GrandTotalStringChangedEvent Is Nothing Then
						RaiseEvent GrandTotalStringChanged(Me, EventArgs.Empty)
					End If
				End If
			End Set
		End Property
		''' <summary>
		''' A notification event that is raised after GrandTotalString is modified. 
		''' </summary>
		Public Event GrandTotalStringChanged As EventHandler
		#End Region

		#Region "All"

		Private allString_Renamed As String = "(all)"

		''' <summary>
		''' Gets or sets the generic text for the word '(all)' used in in filter dropdowns. 
		''' </summary>
		<Browsable(True), Description("The generic text for the word '(all)' used in in filter dropdowns"), DefaultValue("(all)"), Category("Strings")> _
		Public Property AllString() As String
			Get
				Return allString_Renamed
			End Get
			Set(ByVal value As String)
				If value <> allString_Renamed Then
					allString_Renamed = value
					If Not AllStringChangedEvent Is Nothing Then
						RaiseEvent AllStringChanged(Me, EventArgs.Empty)
					End If
				End If
			End Set
		End Property
		''' <summary>
		''' A notification event that is raised after AllString is modified. 
		''' </summary>
		Public Event AllStringChanged As EventHandler
		#End Region

		#End Region


		#Region "ValueCell"
		Private valueCell_Renamed As GridStyleInfo = Nothing

		''' <summary>
		''' Gets or sets the GridStyleInfo properties for value cells. 
		''' </summary>
		<Browsable(True), Description("The GridStyleInfo properties for value cells")> _
		Public Property ValueCell() As GridStyleInfo
			Get
				If valueCell_Renamed Is Nothing Then
					valueCell_Renamed = New GridStyleInfo()
				End If
				Return valueCell_Renamed
			End Get
			Set(ByVal value As GridStyleInfo)
				valueCell_Renamed = value
			End Set
		End Property
		''' <summary>
		''' A notification event that is raised after ValueCell is modified. 
		''' </summary>
		Public Event ValueCellChanged As EventHandler
		#End Region

		#Region "CalculationNameCell"
		Private calculationNameCell_Renamed As GridStyleInfo = Nothing

		''' <summary>
		''' Gets or sets the GridStyleInfo properties for calculation name cells. 
		''' </summary>
		<Browsable(True), Description("The GridStyleInfo properties for calcualtion name cells")> _
		Public Property CalculationNameCell() As GridStyleInfo
			Get
				If calculationNameCell_Renamed Is Nothing Then
					calculationNameCell_Renamed = New GridStyleInfo()
				End If
				Return calculationNameCell_Renamed
			End Get
			Set(ByVal value As GridStyleInfo)
				calculationNameCell_Renamed = value
			End Set
		End Property
		''' <summary>
		''' A notification event that is raised after CalculationNameCell is modified. 
		''' </summary>
		Public Event CalculationNameCellChanged As EventHandler
		#End Region

		#Region "TopLeftCell"
		Private topLeftCell_Renamed As GridStyleInfo = Nothing

		''' <summary>
		''' Gets or sets the GridStyleInfo properties for topleft cell. 
		''' </summary>
		<Browsable(True), Description("The GridStyleInfo properties for topleft cells")> _
		Public Property TopLeftCell() As GridStyleInfo
			Get
				If topLeftCell_Renamed Is Nothing Then
					topLeftCell_Renamed = New GridStyleInfo()
				End If
				Return topLeftCell_Renamed
			End Get
			Set(ByVal value As GridStyleInfo)
				topLeftCell_Renamed = value
			End Set
		End Property
		''' <summary>
		''' A notification event that is raised after TopLeftCell is modified. 
		''' </summary>
		Public Event TopLeftCellChanged As EventHandler
		#End Region

		#Region "RowCell"
		Private rowCell_Renamed As GridStyleInfo = Nothing

		''' <summary>
		''' Gets or sets the GridStyleInfo properties for row grid cells. 
		''' </summary>
		<Browsable(True), Description("The GridStyleInfo properties for row grid cells")> _
		Public Property RowCell() As GridStyleInfo
			Get
				If rowCell_Renamed Is Nothing Then
					rowCell_Renamed = New GridStyleInfo()
				End If
				Return rowCell_Renamed
			End Get
			Set(ByVal value As GridStyleInfo)
				rowCell_Renamed = value
			End Set
		End Property
		''' <summary>
		''' A notification event that is raised after RowCell is modified. 
		''' </summary>
		Public Event RowCellChanged As EventHandler
		#End Region

		#Region "RowExpandCell"
		Private rowExpandCell_Renamed As GridStyleInfo = Nothing

		''' <summary>
		''' Gets or sets the GridStyleInfo properties for row grid expand cells. 
		''' </summary>
		<Browsable(True), Description("The GridStyleInfo properties for row expandgrid cells")> _
		Public Property RowExpandCell() As GridStyleInfo
			Get
				If rowExpandCell_Renamed Is Nothing Then
					rowExpandCell_Renamed = New GridStyleInfo()
				End If
				Return rowExpandCell_Renamed
			End Get
			Set(ByVal value As GridStyleInfo)
				rowExpandCell_Renamed = value
			End Set
		End Property
		''' <summary>
		''' A notification event that is raised after RowExpandCell is modified. 
		''' </summary>
		Public Event RowExpandCellChanged As EventHandler
		#End Region

		#Region "RowTotalCell"
		Private rowTotalCell_Renamed As GridStyleInfo = Nothing

		''' <summary>
		''' Gets or sets the GridStyleInfo properties for row grid total cells. 
		''' </summary>
		<Browsable(True), Description("The GridStyleInfo properties for row grid total cells")> _
		Public Property RowTotalCell() As GridStyleInfo
			Get
				If rowTotalCell_Renamed Is Nothing Then
					rowTotalCell_Renamed = New GridStyleInfo()
				End If
				Return rowTotalCell_Renamed
			End Get
			Set(ByVal value As GridStyleInfo)
				rowTotalCell_Renamed = value
			End Set
		End Property
		''' <summary>
		''' A notification event that is raised after RowExpandCell is modified. 
		''' </summary>
		Public Event RowTotalCellChanged As EventHandler
		#End Region

		#Region "ColumnExpandCell"
		Private columnExpandCell_Renamed As GridStyleInfo = Nothing

		''' <summary>
		''' Gets or sets the GridStyleInfo properties for column grid expand cells. 
		''' </summary>
		<Browsable(True), Description("The GridStyleInfo properties for column grid expand cells")> _
		Public Property ColumnExpandCell() As GridStyleInfo
			Get
				If columnExpandCell_Renamed Is Nothing Then
					columnExpandCell_Renamed = New GridStyleInfo()
				End If
				Return columnExpandCell_Renamed
			End Get
			Set(ByVal value As GridStyleInfo)
				columnExpandCell_Renamed = value
			End Set
		End Property
		''' <summary>
		''' A notification event that is raised after ColumnExpandCell is modified. 
		''' </summary>
		Public Event ColumnExpandCellChanged As EventHandler
		#End Region

		#Region "ColumnTotalCell"
		Private columnTotalCell_Renamed As GridStyleInfo = Nothing

		''' <summary>
		''' Gets or sets the GridStyleInfo properties for column grid total cells. 
		''' </summary>
		<Browsable(True), Description("The GridStyleInfo properties for column grid total cells")> _
		Public Property ColumnTotalCell() As GridStyleInfo
			Get
				If columnTotalCell_Renamed Is Nothing Then
					columnTotalCell_Renamed = New GridStyleInfo()
				End If
				Return columnTotalCell_Renamed
			End Get
			Set(ByVal value As GridStyleInfo)
				columnTotalCell_Renamed = value
			End Set
		End Property
		''' <summary>
		''' A notification event that is raised after ColumnTotaldCell is modified. 
		''' </summary>
		Public Event ColumnTotalCellChanged As EventHandler
		#End Region

		#Region "ColumnCell"
		Private columnCell_Renamed As GridStyleInfo = Nothing

		''' <summary>
		''' Gets or sets the GridStyleInfo properties for column grid cells. 
		''' </summary>
		<Browsable(True), Description("The GridStyleInfo properties for column grid cells")> _
		Public Property ColumnCell() As GridStyleInfo
			Get
				If columnCell_Renamed Is Nothing Then
					columnCell_Renamed = New GridStyleInfo()
				End If
				Return columnCell_Renamed
			End Get
			Set(ByVal value As GridStyleInfo)
				columnCell_Renamed = value
			End Set
		End Property
		''' <summary>
		''' A notification event that is raised after ColumnCell is modified. 
		''' </summary>
		Public Event ColumnCellChanged As EventHandler
		#End Region

		#End Region

		''' <override />
		Public Overrides Function ToString() As String
			Return ""
		End Function

	End Class

		''' <summary>
	''' Specifies the colors and fonts used in a PivotGridControl
	''' </summary>
	<TypeConverter(GetType(ExpandableObjectConverter)), Serializable> _
	Public Class PivotSchema
		Implements ISerializable

		   ''' <summary>
		''' Default Constructor. Only present to support XML serialization.
		''' </summary>
		Public Sub New()

		End Sub

		Public Sub ApplySchemaToPivotControl(ByVal pivotControl As PivotGridControl)
			pivotControl.ApplySchema(Me)
		End Sub

		Public Sub InitSchemaFromPivotControl(ByVal pivotControl As PivotGridControl)

		End Sub

		''' <summary>
		''' Creates an instance of <see cref="PivotSchema"/> that was
		''' previously serialized as a XML file.
		''' </summary>
		''' <param name="fileName">The serialized filename.</param>
		''' <returns>A PivotSchema.</returns>
		Public Shared Function LoadXML(ByVal fileName As String) As PivotSchema
			Dim schema As PivotSchema = Nothing
			Dim s As Stream = File.OpenRead(fileName)

			Try
				Dim serializer As XmlSerializer = New XmlSerializer(GetType(PivotSchema))
				schema = TryCast(serializer.Deserialize(s), PivotSchema)
			Finally
				s.Close()
			End Try
			Return schema
		End Function

		#Region "XML Serialization Support"
		''' <summary>
		''' Saves this PivotSchema object in an XML file 
		''' with the specified filename.
		''' </summary>
		Public Sub SaveXML(ByVal fileName As String)
			Try
				Dim serializer As XmlSerializer = New XmlSerializer(GetType(PivotSchema))
				Dim textWriter As TextWriter = New StreamWriter(fileName)

				Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(textWriter)
				xmlTextWriter.Formatting = Formatting.Indented
				serializer.Serialize(xmlTextWriter, Me)
				textWriter.Close()
			Catch

			End Try

		End Sub

		#End Region

		#Region "Binary Serialization Support"
		''' <summary>
		''' Initializes a new <see cref="PivotSchema"/> from a serialization stream.
		''' </summary>
		''' <param name="info">An object that holds all the data needed to serialize or deserialize this instance.</param>
		''' <param name="context">Describes the source and destination of the serialized stream specified by info. </param>
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			Me.version = CInt(Fix(info.GetValue("version", GetType(Integer))))
			Me.fields_Renamed = CType(info.GetValue("fields", GetType(String())), String())
			Me.rowFields_Renamed = CType(info.GetValue("rowFields", GetType(String())), String())
			Me.columnFields_Renamed = CType(info.GetValue("columnFields", GetType(String())), String())
			Me.filterFields_Renamed = CType(info.GetValue("filterFields", GetType(String())), String())
			Me.filterValues_Renamed = CType(info.GetValue("filterValues", GetType(String())), String())
			Me.valueComputations_Renamed = CType(info.GetValue("valueComputations", GetType(PivotComputationInfo())), PivotComputationInfo())

			 'addproperty  - need to add code here when you add a property to PivotAppearance
		End Sub


		''' <summary>
		''' Implements the ISerializable interface and returns the data needed to serialize the Appearance object.
		''' </summary>
		''' <param name="info">A SerializationInfo object containing the information required to serialize the Appearance object.</param>
		''' <param name="context">A StreamingContext object containing the source and destination of the serialized stream.</param>
		Public Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext) Implements ISerializable.GetObjectData
			info.AddValue("version", version)
			info.AddValue("fields", fields_Renamed)
			info.AddValue("rowFields", rowFields_Renamed)
			info.AddValue("columnFields", columnFields_Renamed)
			info.AddValue("filterFields", filterFields_Renamed)
			info.AddValue("filterValues", filterValues_Renamed)
			info.AddValue("valueComputations", valueComputations_Renamed)

			'addproperty  - need to add code here when you add a property to PivotAppearance
		End Sub

		 #End Region

		#Region "Properties"

		' //version = 0  - orignal version release as 5.2.0.xx
		Private version As Integer = 0



		Private fields_Renamed As String() = Nothing

		Public Property Fields() As String()
			Get
				Return fields_Renamed
			End Get
			Set(ByVal value As String())
				fields_Renamed = value
			End Set
		End Property

		Private rowFields_Renamed As String() = Nothing

		Public Property RowFields() As String()
			Get
				Return rowFields_Renamed
			End Get
			Set(ByVal value As String())
				rowFields_Renamed = value
			End Set
		End Property

		Private columnFields_Renamed As String() = Nothing

		Public Property ColumnFields() As String()
			Get
				Return columnFields_Renamed
			End Get
			Set(ByVal value As String())
				columnFields_Renamed = value
			End Set
		End Property

		Private valueComputations_Renamed As PivotComputationInfo() = Nothing

		Public Property ValueComputations() As PivotComputationInfo()
			Get
				Return valueComputations_Renamed
			End Get
			Set(ByVal value As PivotComputationInfo())
				valueComputations_Renamed = value
			End Set
		End Property

		Private filterFields_Renamed As String() = Nothing

		Public Property FilterFields() As String()
			Get
				Return filterFields_Renamed
			End Get
			Set(ByVal value As String())
				filterFields_Renamed = value
			End Set
		End Property

		Private filterValues_Renamed As String() = Nothing

		Public Property FilterValues() As String()
			Get
				Return filterValues_Renamed
			End Get
			Set(ByVal value As String())
				filterValues_Renamed = value
			End Set
		End Property





		#End Region
	End Class

End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization

Imports Syncfusion.Windows.Forms.Schedule
Imports Syncfusion.Schedule

Namespace OutlookDemo
	''' <summary>
	''' Summary description for SimpleScheduleDataProvider.
	''' </summary>
	#Region "DataProvider"
	''' <summary>
	''' Derives <see cref="ScheduleDataProvider"/> to implement <see cref="IScheduleDataProvider"/>.
	''' </summary>
	''' <remarks>
	''' This implementation of IScheduleDataProvider uses a collection of <see cref="SimpleScheduleItem"/>
	''' objects to hold the items displayed in the schedule. This collection is serialized to disk as a 
	''' binary file. The serialization is restricted to the SimpleScheduleDataProvider.MasterList and the
	''' SimpleScheduleItem objects that it holds. 
	''' </remarks>
	Public Class SimpleScheduleDataProvider : Inherits ScheduleDataProvider
		''' <summary>
		''' Default constructor.
		''' </summary>
		Public Sub New()
			MyBase.New()
		End Sub

		Private fileName_Renamed As String

		Public Property FileName() As String
			Get
				Return fileName_Renamed
			End Get
			Set
				fileName_Renamed = Value
			End Set
		End Property

		Private masterList_Renamed As SimpleScheduleItemList

		''' <summary>
		''' Get or sets an IScheduleItemList collection that holds the IScheduleItems. 
		''' </summary>
		Public Property MasterList() As SimpleScheduleItemList
			Get
				If masterList_Renamed Is Nothing Then
					masterList_Renamed = New SimpleScheduleItemList()
				End If

				Return masterList_Renamed
			End Get
			Set
				masterList_Renamed = Value
			End Set
		End Property

		#Region "random data"

		''' <summary>
		''' A static method that provides random data, not really a part of the implementations.
		''' </summary>
		''' <returns>A SimpleScheduleItemList object holding sample data.</returns>
		Public Shared Function InitializeRandomData() As SimpleScheduleItemList
			'int tc = Environment.TickCount;
			'int tc = 26260100;// simple spread 
			Dim tc As Integer = 28882701 ' split the appointment across midnight & 3 items at 8am on 2 days ago

			'Console.WriteLine("Random seed: {0}", tc);
			Dim r As Random = New Random(tc)
			Dim r1 As Random = New Random(tc)

			' set the number of sample items you want in this list.
			'int count = r.Next(20) + 4;
			Dim count As Integer = 400 '1000;//200;//30;

'INSTANT VB NOTE: The local variable masterList was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
			Dim masterList_Renamed As SimpleScheduleItemList = New SimpleScheduleItemList()
			Dim now As DateTime = DateTime.Now.Date

			Dim i As Integer = 0
'ORIGINAL LINE: for (int i = 0; i < count; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < count
				Dim item As ScheduleAppointment = CType(IIf(TypeOf masterList_Renamed.NewScheduleAppointment() Is ScheduleAppointment, masterList_Renamed.NewScheduleAppointment(), Nothing), ScheduleAppointment)

				'int dayOffSet = 0;
				'int hourOffSet = 8 - r.Next(16);

				'int dayOffSet = 3 - r.Next(6);
				Dim dayOffSet As Integer = 30 - r.Next(60)
				'int dayOffSet = 100 - r.Next(200);
				Dim hourOffSet As Integer = 24 - r.Next(48)

				Dim len As Integer = 30 * (r.Next(4) + 1)
				item.StartTime = now.AddDays(CDbl(dayOffSet)).AddHours(CDbl(hourOffSet))

				item.EndTime = item.StartTime.AddMinutes(CDbl(len))
				item.Subject = String.Format("subject{0}", i)
				item.Content = String.Format("content{0}", i)
				If r1.Next(10) < 3 Then
					item.LabelValue = 0
				Else
					item.LabelValue = r1.Next(10)
				End If
				item.LocationValue = String.Format("location{0}", r1.Next(5))

				If r1.Next(10) < 5 Then
					item.ReminderValue = 0
				Else
					item.ReminderValue = r1.Next(12)
				End If
				item.Reminder = r1.Next(10) > 1
				item.AllDay = r1.Next(10) < 1


				item.MarkerValue = r1.Next(4)
				item.Dirty = False
				masterList_Renamed.Add(item)
				i += 1
			Loop

			'//set explicit values if needed for testing...
			'masterList[142].Reminder = true;
			'masterList[142].ReminderValue = 9;//  hrs; // 7;//3 hrs


			'DisplayList("Before Sort", masterList);
			masterList_Renamed.SortStartTime()
			'DisplayList("After Sort", masterList);

			Return masterList_Renamed
		End Function

		Private Shared Sub DisplayList(ByVal title As String, ByVal list As ScheduleAppointmentList)
#If console Then
			Console.WriteLine("*************" & title)
			For Each item As ScheduleItem In list
				Console.WriteLine(item)
			Next item
#End If
		End Sub
		#End Region

		#Region "base class overrides"

		''' <summary>
		''' Returns a the subset of MasterList between the 2 dates.
		''' </summary>
		''' <param name="startDate">Starting date limit for the returned items.</param>
		''' <param name="endDate">Ending date limit for the returned items.</param>
		''' <returns>Returns a the subset of MasterList.</returns>
		Public Overrides Function GetSchedule(ByVal startDate As DateTime, ByVal endDate As DateTime) As IScheduleAppointmentList
			Dim list As ScheduleAppointmentList = New ScheduleAppointmentList()
			Dim start As DateTime = startDate.Date
'INSTANT VB NOTE: The local variable end was renamed since it is a keyword in VB:
			Dim end_Renamed As DateTime = endDate.Date
			For Each item As ScheduleAppointment In Me.MasterList
				'item.EndTime.AddMinutes(-1) is to make sure an item that ends at 
				'midnight is not shown on the next days calendar

				If (item.StartTime.Date >= start AndAlso item.StartTime.Date <= end_Renamed) OrElse (item.EndTime.AddMinutes(-1).Date > start AndAlso item.EndTime.Date <= end_Renamed) Then
					list.Add(item)
				End If
			Next item
			list.SortStartTime()
			'DisplayList(string.Format("************dates between {0} and {1}", startDate, endDate), list);
			Return list
		End Function

		''' <summary>
		''' Returns a the subset of MasterList between the 2 dates.
		''' </summary>
		''' <param name="day">Date for the returned items.</param>
		''' <returns>Returns a the subset of MasterList.</returns>
		Public Overrides Function GetScheduleForDay(ByVal day As DateTime) As IScheduleAppointmentList
			Dim list As ScheduleAppointmentList = New ScheduleAppointmentList()
			day = day.Date
			For Each item As ScheduleAppointment In Me.MasterList
				'do not want anything that ends at 12AM on the day
				If item.StartTime.Date = day OrElse (item.EndTime.Date = day AndAlso item.EndTime > day) Then
					list.Add(item)
				End If
			Next item

			'DisplayList(string.Format("*************day {0}", day), list);
			Return list
		End Function

		''' <summary>
		''' Saves the MasterList as a diskfile.
		''' </summary>
		Public Overrides Sub CommitChanges()
			If FileName.ToLower().EndsWith(".schedule") Then
				SaveBinary(FileName)
			Else
				SaveXML(FileName)
			End If
			Me.IsDirty = False
		End Sub

		''' <summary>
		''' Gets or sets whether the MasterList has been modified.
		''' </summary>
		Public Overrides Property IsDirty() As Boolean
			Get
				Dim val As Boolean = MyBase.IsDirty
				If (Not val) Then 'if no global setting marked list as dirty, check individual items
					For Each item As IScheduleAppointment In Me.MasterList
						If item.Dirty Then
							val = True
							Exit For
						End If
					Next item
				End If
				Return val
			End Get
			Set
				MyBase.IsDirty = Value
			End Set
		End Property


		''' <summary>
		''' Saves the current <see cref="MasterList"/> object in an XML file 
		''' with the specified filename.
		''' </summary>
'INSTANT VB NOTE: The parameter fileName was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Sub SaveXML(ByVal fileName_Renamed As String)
			Dim a As SimpleScheduleItem() = CType(Me.MasterList.ItemList.ToArray(GetType(SimpleScheduleItem)), SimpleScheduleItem())
			Dim serializer As XmlSerializer = New XmlSerializer(a.GetType()) 'typeof(SimpleScheduleItem));
			Dim writer As TextWriter = New StreamWriter(fileName_Renamed)
			serializer.Serialize(writer, a)
			writer.Close()
			a = Nothing
		End Sub

		''' <summary>
		''' Saves the current <see cref="MasterList"/> object to a disfile in binary format.
		''' </summary>
'INSTANT VB NOTE: The parameter fileName was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Sub SaveBinary(ByVal fileName_Renamed As String)
			Dim s As Stream = File.Open(fileName_Renamed, FileMode.OpenOrCreate)
			SaveBinary(s)
		End Sub

		''' <summary>
		''' Saves the current <see cref="MasterList"/> object to a stream in binary format.
		''' </summary>
		Public Sub SaveBinary(ByVal s As Stream)
			Dim b As BinaryFormatter = New BinaryFormatter()
			b.AssemblyFormat = FormatterAssemblyStyle.Simple
			b.Serialize(s, Me.MasterList)
		End Sub

		''' <summary>
		''' Creates an instance of <see cref="SimpleScheduleDataProvider"/> and loads 
		''' a previously serialized MasterList into the instance from an XML file.
		''' </summary>
		''' <param name="fileName">The serialized filename.</param>
		''' <returns>A SimpleScheduleDataProvider.</returns>
'INSTANT VB NOTE: The parameter fileName was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Shared Function LoadXML(ByVal fileName_Renamed As String) As SimpleScheduleDataProvider
			Dim t As SimpleScheduleDataProvider = New SimpleScheduleDataProvider()
			Dim s As Stream = File.OpenRead(fileName_Renamed)

			Try
				Dim serializer As XmlSerializer = New XmlSerializer(GetType(SimpleScheduleItem() )) 'typeof(SimpleScheduleItem));
                Dim a As SimpleScheduleItem() = CType(serializer.Deserialize(s), SimpleScheduleItem())
				For Each item As SimpleScheduleItem In a
					t.MasterList.ItemList.Add(item)
				Next item
				a = Nothing
			Finally
				s.Close()
			End Try
			Return t
		End Function

		''' <summary>
		''' Creates an instance of <see cref="SimpleScheduleDataProvider"/> and loads 
		''' a previously serialized MasterList into the instance from a binary file.
		''' </summary>
		''' <param name="fileName">The serialized filename.</param>
		''' <returns>A SimpleScheduleDataProvider.</returns>
		''' <remarks>
		''' This method uses <see cref="AppDomain.CurrentDomain.AssemblyResolve"/> to 
		''' avoid versioning issues with the binary serialization of the MasterList.
		''' </remarks>
'INSTANT VB NOTE: The parameter fileName was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Shared Function LoadBinary(ByVal fileName_Renamed As String) As SimpleScheduleDataProvider
			Dim t As SimpleScheduleDataProvider = New SimpleScheduleDataProvider()
			Dim s As Stream = File.OpenRead(fileName_Renamed)
			Try
				AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf Syncfusion.ScheduleWindowsAssembly.AssemblyResolver
				Dim b As BinaryFormatter = New BinaryFormatter()
				b.AssemblyFormat = FormatterAssemblyStyle.Simple
				Dim obj As Object = b.Deserialize(s)
				t.MasterList = CType(IIf(TypeOf obj Is SimpleScheduleItemList, obj, Nothing), SimpleScheduleItemList)
			Finally
				s.Close()
				RemoveHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf Syncfusion.ScheduleWindowsAssembly.AssemblyResolver
			End Try

			Return t
		End Function


		Public Overrides Function NewScheduleAppointment() As IScheduleAppointment
			Return New SimpleScheduleItem()
		End Function

		''' <summary>
		''' Overridden to add the item to the MasterList.
		''' </summary>
		''' <param name="item">IScheduleItem item to be added.</param>
		Public Overrides Sub AddItem(ByVal item As IScheduleAppointment)
			Me.MasterList.Add(item)
		End Sub

		''' <summary>
		''' Overridden to remove the item from the MasterList.
		''' </summary>
		''' <param name="item">IScheduleItem item to be removed.</param>
		Public Overrides Sub RemoveItem(ByVal item As IScheduleAppointment)
			Me.MasterList.Remove(item)
		End Sub
		#End Region
	End Class
	#End Region

	#Region "ScheduleItemList"

	''' <summary>
	''' Derives <see cref="ScheduleItemList"/> to implement IScheduleItemList.
	''' </summary>
	<Serializable> _
	Public Class SimpleScheduleItemList : Inherits ScheduleAppointmentList : Implements ISerializable
		#Region "ISerializable Members"


		''' <summary>
		''' Override to control serialization.
		''' </summary>
		''' <param name="info"> The SerializationInfo.</param>
		''' <param name="context">The StreamingContext.</param>
		Protected Overridable Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext) Implements ISerializable.GetObjectData
			info.AddValue("List", Me.List)
		End Sub

		''' <summary>
		''' Gets the embedded list. Exposed for XML serialization support.
		''' </summary>
		Public ReadOnly Property ItemList() As ArrayList
			Get
				Return Me.List
			End Get
		End Property


		#End Region

		''' <summary>
		''' Used in serialization.
		''' </summary>
		''' <param name="info"> The SerializationInfo.</param>
		''' <param name="context">The StreamingContext.</param>
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			Me.List = CType(info.GetValue("List", GetType(ArrayList)), ArrayList)
		End Sub

		''' <summary>
		''' Default constructor.
		''' </summary>
		Public Sub New()
			MyBase.New()

		End Sub

		Public Overrides Function NewScheduleAppointment() As IScheduleAppointment
			Return New SimpleScheduleItem()
		End Function

	End Class
	#End Region

	#Region "ScheduleItem"

	''' <summary>
	''' Derives <see cref="ScheduleItem"/> to implement IScheduleItem.
	''' </summary>
	<Serializable> _
	Public Class SimpleScheduleItem : Inherits ScheduleAppointment : Implements ISerializable
		#Region "ISerializable Members"

		''' <summary>
		''' Default constructor.
		''' </summary>
		Public Sub New()
			MyBase.New()
		End Sub

		''' <summary>
		''' Overridden to handle serilaization.
		''' </summary>
		''' <param name="info">The SerialazationInfo.</param>
		''' <param name="context">The StreamingContext.</param>
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			Me.UniqueID = CInt(info.GetValue("UniqueID", GetType(Integer)))
			Me.Subject = CStr(info.GetValue("Subject", GetType(String)))
			Me.StartTime = CDate(info.GetValue("StartTime", GetType(DateTime)))
			Me.ReminderValue = CInt(info.GetValue("ReminderValue", GetType(Integer)))
			Me.Reminder = CBool(info.GetValue("Reminder", GetType(Boolean)))
			Me.Owner = CInt(info.GetValue("Owner", GetType(Integer)))
			Me.MarkerValue = CInt(info.GetValue("MarkerValue", GetType(Integer)))
			Me.LocationValue = CStr(info.GetValue("LocationValue", GetType(String)))
			Me.LabelValue = CInt(info.GetValue("LabelValue", GetType(Integer)))
			Me.EndTime = CDate(info.GetValue("EndTime", GetType(DateTime)))
			Me.Content = CStr(info.GetValue("Content", GetType(String)))
			Me.AllDay = CBool(info.GetValue("AllDay", GetType(Boolean)))

			Me.Dirty = False
		End Sub

		''' <summary>
		''' Handle serilaization.
		''' </summary>
		''' <param name="info">The SerialazationInfo.</param>
		''' <param name="context">The StreamingContext.</param>
		Public Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext) Implements ISerializable.GetObjectData
			info.AddValue("UniqueID", Me.UniqueID)
			info.AddValue("Subject", Me.Subject)
			info.AddValue("StartTime", Me.StartTime)
			info.AddValue("ReminderValue", Me.ReminderValue)
			info.AddValue("Reminder", Me.Reminder)
			info.AddValue("Owner", Me.Owner)
			info.AddValue("MarkerValue", Me.MarkerValue)
			info.AddValue("LocationValue", Me.LocationValue)
			info.AddValue("LabelValue", Me.LabelValue)
			info.AddValue("EndTime", Me.EndTime)
			info.AddValue("Content", Me.Content)
			info.AddValue("AllDay", Me.AllDay)

			'info.AddValue("Tag", this.Tag); assume Tag not serializable in this implemetation
		End Sub

		#End Region

	End Class
	#End Region
End Namespace

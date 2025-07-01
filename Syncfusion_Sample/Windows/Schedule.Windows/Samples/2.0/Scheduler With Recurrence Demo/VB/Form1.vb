'#define console


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
Imports System.Xml

Imports Syncfusion.Windows.Forms.Schedule
Imports Syncfusion.Schedule
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System.Xml.Serialization


Namespace GridScheduleSample
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private scheduleControl1 As Syncfusion.Windows.Forms.Schedule.ScheduleControl
		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
		Private menuItem6 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem7 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
		Private menuItem11 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem12 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem13 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem14 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem15 As System.Windows.Forms.MenuItem
		Private menuItem16 As System.Windows.Forms.MenuItem
		Private menuItem17 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem18 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem20 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem21 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem22 As System.Windows.Forms.MenuItem
		Private menuItem23 As System.Windows.Forms.MenuItem
		Private menuItem24 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem25 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem26 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem27 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem28 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem29 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem30 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem31 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem32 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem33 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem34 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem35 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem36 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem37 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem38 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem39 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem40 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem19 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem41 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem42 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem43 As MenuItem
		Private WithEvents menuItem44 As MenuItem
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "Suite.ico"))
            Me.Icon = ico
			'initialize the data somehow - specific to your implementation
			Dim scheduleProvider As ArrayListDataProvider
			Dim fileName As String = "default.XML"
			If FindFile(fileName) Then
				scheduleProvider = ArrayListDataProvider.LoadXML(fileName)
				scheduleProvider.FileName = fileName
				OffSetSampleData(scheduleProvider)
				scheduleProvider.IsDirty = False
			Else
				scheduleProvider = New ArrayListDataProvider()
				scheduleProvider.MasterList = New ArrayListAppointmentList()
				scheduleProvider.FileName = "default.XML"
			End If

			'Set the display date before setting the ScheduleType to avoid default current date being set.
			'bring up Nov 2006 since it has some appointments in the default.schedule file
			'this.scheduleControl1.Calendar.DateValue = new DateTime(2006, 11, 15);

			Me.scheduleControl1.Calendar.DateValue = DateTime.Now

			Me.scheduleControl1.ScheduleType = ScheduleViewType.Month 'ScheduleViewType.Day;//.WorkWeek;//.Week;//ScheduleViewType.WorkWeek;// ScheduleViewType.Day;//.WorkWeek;
			'set the data source
			Me.scheduleControl1.DataSource = scheduleProvider

			'subscribe to item click event
			AddHandler scheduleControl1.ScheduleAppointmentClick, AddressOf scheduleControl1_ScheduleAppointmentClick

			AddHandler menuItem6.Popup, AddressOf menuItem6_Popup

			' display Office2007Blue look
			Me.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Blue

			Me.scheduleControl1.NavigationPanelFillWithCalendar = True

		End Sub

		Private Sub OffSetSampleData(ByVal scheduleProvider As ArrayListDataProvider)
			If scheduleProvider.MasterList.Count > 0 AndAlso scheduleProvider.MasterList(0).StartTime.Date = New DateTime(2006, 11, 3) Then
				Dim offSet As Integer = (CType(DateTime.Now - New DateTime(2006, 11, 15), TimeSpan)).Days
				For Each item As ScheduleAppointment In scheduleProvider.MasterList
					item.StartTime = item.StartTime.AddDays(offSet)
					item.EndTime = item.EndTime.AddDays(offSet)
				Next item
				scheduleProvider.MasterList.SortStartTime()
			End If
		End Sub

		'utility that looks for the file in the project folder up from the exe folder
		Private Function FindFile(ByRef fileName As String) As Boolean
			Dim i As Integer = 0
			Do While i < 4 AndAlso Not File.Exists(fileName)
				fileName = "..\" & fileName
				i += 1
			Loop
			Return File.Exists(fileName)
		End Function

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		'overridden to close propertyForm if opened.
		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			If Me.propertyForm IsNot Nothing Then
				Me.propertyForm.Hide()
				RemoveHandler propertyForm.AppearancePropertyGrid1.PropertyValueChanged, AddressOf AppearancePropertyGrid1_PropertyValueChanged
				RemoveHandler propertyForm.Closing, AddressOf propertyForm_Closing
				propertyForm.Close()
			End If

			MyBase.OnClosing (e)
		End Sub


		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.scheduleControl1 = New Syncfusion.Windows.Forms.Schedule.ScheduleControl
            Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
            Me.menuItem1 = New System.Windows.Forms.MenuItem
            Me.menuItem2 = New System.Windows.Forms.MenuItem
            Me.menuItem4 = New System.Windows.Forms.MenuItem
            Me.menuItem3 = New System.Windows.Forms.MenuItem
            Me.menuItem25 = New System.Windows.Forms.MenuItem
            Me.menuItem27 = New System.Windows.Forms.MenuItem
            Me.menuItem26 = New System.Windows.Forms.MenuItem
            Me.menuItem5 = New System.Windows.Forms.MenuItem
            Me.menuItem6 = New System.Windows.Forms.MenuItem
            Me.menuItem7 = New System.Windows.Forms.MenuItem
            Me.menuItem8 = New System.Windows.Forms.MenuItem
            Me.menuItem9 = New System.Windows.Forms.MenuItem
            Me.menuItem10 = New System.Windows.Forms.MenuItem
            Me.menuItem11 = New System.Windows.Forms.MenuItem
            Me.menuItem12 = New System.Windows.Forms.MenuItem
            Me.menuItem13 = New System.Windows.Forms.MenuItem
            Me.menuItem14 = New System.Windows.Forms.MenuItem
            Me.menuItem15 = New System.Windows.Forms.MenuItem
            Me.menuItem16 = New System.Windows.Forms.MenuItem
            Me.menuItem17 = New System.Windows.Forms.MenuItem
            Me.menuItem19 = New System.Windows.Forms.MenuItem
            Me.menuItem41 = New System.Windows.Forms.MenuItem
            Me.menuItem42 = New System.Windows.Forms.MenuItem
            Me.menuItem18 = New System.Windows.Forms.MenuItem
            Me.menuItem32 = New System.Windows.Forms.MenuItem
            Me.menuItem33 = New System.Windows.Forms.MenuItem
            Me.menuItem34 = New System.Windows.Forms.MenuItem
            Me.menuItem35 = New System.Windows.Forms.MenuItem
            Me.menuItem36 = New System.Windows.Forms.MenuItem
            Me.menuItem37 = New System.Windows.Forms.MenuItem
            Me.menuItem22 = New System.Windows.Forms.MenuItem
            Me.menuItem29 = New System.Windows.Forms.MenuItem
            Me.menuItem30 = New System.Windows.Forms.MenuItem
            Me.menuItem31 = New System.Windows.Forms.MenuItem
            Me.menuItem28 = New System.Windows.Forms.MenuItem
            Me.menuItem38 = New System.Windows.Forms.MenuItem
            Me.menuItem39 = New System.Windows.Forms.MenuItem
            Me.menuItem40 = New System.Windows.Forms.MenuItem
            Me.menuItem20 = New System.Windows.Forms.MenuItem
            Me.menuItem44 = New System.Windows.Forms.MenuItem
            Me.menuItem21 = New System.Windows.Forms.MenuItem
            Me.menuItem43 = New System.Windows.Forms.MenuItem
            Me.menuItem23 = New System.Windows.Forms.MenuItem
            Me.menuItem24 = New System.Windows.Forms.MenuItem
            Me.SuspendLayout()
            '
            'scheduleControl1
            '
            Me.scheduleControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.scheduleControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(219, Byte), Integer))
            Me.scheduleControl1.Culture = New System.Globalization.CultureInfo("")
            Me.scheduleControl1.DataSource = Nothing
            Me.scheduleControl1.Location = New System.Drawing.Point(32, 24)
            Me.scheduleControl1.Name = "scheduleControl1"
            Me.scheduleControl1.NavigationPanelPosition = Syncfusion.Schedule.CalendarNavigationPanelPosition.Left
            Me.scheduleControl1.Size = New System.Drawing.Size(816, 581)
            Me.scheduleControl1.TabIndex = 3
            '
            'mainMenu1
            '
            Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem6, Me.menuItem11, Me.menuItem16, Me.menuItem23})
            '
            'menuItem1
            '
            Me.menuItem1.Index = 0
            Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem4, Me.menuItem3, Me.menuItem25, Me.menuItem27, Me.menuItem26, Me.menuItem5})
            Me.menuItem1.Text = "File"
            '
            'menuItem2
            '
            Me.menuItem2.Index = 0
            Me.menuItem2.Text = "Open Calendar..."
            '
            'menuItem4
            '
            Me.menuItem4.Index = 1
            Me.menuItem4.Text = "New Calendar..."
            '
            'menuItem3
            '
            Me.menuItem3.Index = 2
            Me.menuItem3.Text = "Save Calendar"
            '
            'menuItem25
            '
            Me.menuItem25.Index = 3
            Me.menuItem25.Text = "Save Calendar as..."
            '
            'menuItem27
            '
            Me.menuItem27.Index = 4
            Me.menuItem27.Text = "Merge Calendar..."
            '
            'menuItem26
            '
            Me.menuItem26.Index = 5
            Me.menuItem26.Text = "Random Data"
            '
            'menuItem5
            '
            Me.menuItem5.Index = 6
            Me.menuItem5.Text = "Exit"
            '
            'menuItem6
            '
            Me.menuItem6.Index = 1
            Me.menuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem7, Me.menuItem8, Me.menuItem9, Me.menuItem10})
            Me.menuItem6.Text = "Edit"
            '
            'menuItem7
            '
            Me.menuItem7.Index = 0
            Me.menuItem7.Text = "New Item"
            '
            'menuItem8
            '
            Me.menuItem8.Index = 1
            Me.menuItem8.Text = "New AllDay Item"
            '
            'menuItem9
            '
            Me.menuItem9.Index = 2
            Me.menuItem9.Text = "Edit Item"
            '
            'menuItem10
            '
            Me.menuItem10.Index = 3
            Me.menuItem10.Text = "Delete Item"
            '
            'menuItem11
            '
            Me.menuItem11.Index = 2
            Me.menuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem12, Me.menuItem13, Me.menuItem14, Me.menuItem15})
            Me.menuItem11.Text = "View"
            '
            'menuItem12
            '
            Me.menuItem12.Index = 0
            Me.menuItem12.Text = "Day"
            '
            'menuItem13
            '
            Me.menuItem13.Index = 1
            Me.menuItem13.Text = "Workweek"
            '
            'menuItem14
            '
            Me.menuItem14.Index = 2
            Me.menuItem14.Text = "Week"
            '
            'menuItem15
            '
            Me.menuItem15.Index = 3
            Me.menuItem15.Text = "Month"
            '
            'menuItem16
            '
            Me.menuItem16.Index = 3
            Me.menuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem17, Me.menuItem18, Me.menuItem22, Me.menuItem28, Me.menuItem20, Me.menuItem44, Me.menuItem21, Me.menuItem43})
            Me.menuItem16.Text = "Options"
            '
            'menuItem17
            '
            Me.menuItem17.Index = 0
            Me.menuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem19, Me.menuItem41, Me.menuItem42})
            Me.menuItem17.Text = "Appearance..."
            '
            'menuItem19
            '
            Me.menuItem19.Index = 0
            Me.menuItem19.Text = "Change..."
            '
            'menuItem41
            '
            Me.menuItem41.Index = 1
            Me.menuItem41.Text = "Load..."
            '
            'menuItem42
            '
            Me.menuItem42.Index = 2
            Me.menuItem42.Text = "Save..."
            '
            'menuItem18
            '
            Me.menuItem18.Index = 1
            Me.menuItem18.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem32, Me.menuItem33, Me.menuItem34, Me.menuItem35, Me.menuItem36, Me.menuItem37})
            Me.menuItem18.Text = "Culture"
            '
            'menuItem32
            '
            Me.menuItem32.Index = 0
            Me.menuItem32.Text = "Invariant"
            '
            'menuItem33
            '
            Me.menuItem33.Index = 1
            Me.menuItem33.Text = "Application"
            '
            'menuItem34
            '
            Me.menuItem34.Index = 2
            Me.menuItem34.Text = "fr-FR"
            '
            'menuItem35
            '
            Me.menuItem35.Index = 3
            Me.menuItem35.Text = "it-IT"
            '
            'menuItem36
            '
            Me.menuItem36.Index = 4
            Me.menuItem36.Text = "en-US"
            '
            'menuItem37
            '
            Me.menuItem37.Index = 5
            Me.menuItem37.Text = "de-DE"
            '
            'menuItem22
            '
            Me.menuItem22.Index = 2
            Me.menuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem29, Me.menuItem30, Me.menuItem31})
            Me.menuItem22.Text = "Navigation Panel"
            '
            'menuItem29
            '
            Me.menuItem29.Index = 0
            Me.menuItem29.Text = "Hidden"
            '
            'menuItem30
            '
            Me.menuItem30.Index = 1
            Me.menuItem30.Text = "Left"
            '
            'menuItem31
            '
            Me.menuItem31.Index = 2
            Me.menuItem31.Text = "Right"
            '
            'menuItem28
            '
            Me.menuItem28.Index = 3
            Me.menuItem28.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem38, Me.menuItem39, Me.menuItem40})
            Me.menuItem28.Text = "Save on Close"
            '
            'menuItem38
            '
            Me.menuItem38.Index = 0
            Me.menuItem38.Text = "Do Not Save"
            '
            'menuItem39
            '
            Me.menuItem39.Index = 1
            Me.menuItem39.Text = "Prompt Before Saving"
            '
            'menuItem40
            '
            Me.menuItem40.Index = 2
            Me.menuItem40.Text = "Save Without Prompt"
            '
            'menuItem20
            '
            Me.menuItem20.Checked = True
            Me.menuItem20.Index = 4
            Me.menuItem20.Text = "Week Numbers"
            '
            'menuItem44
            '
            Me.menuItem44.Index = 5
            Me.menuItem44.Text = "Alerts"
            '
            'menuItem21
            '
            Me.menuItem21.Index = 6
            Me.menuItem21.Text = "Additional Panel"
            '
            'menuItem43
            '
            Me.menuItem43.Index = 7
            Me.menuItem43.Text = "Test"
            '
            'menuItem23
            '
            Me.menuItem23.Index = 4
            Me.menuItem23.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem24})
            Me.menuItem23.Text = "Help"
            '
            'menuItem24
            '
            Me.menuItem24.Index = 0
            Me.menuItem24.Text = "About..."
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(888, 638)
            Me.Controls.Add(Me.scheduleControl1)
            Me.Menu = Me.mainMenu1
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Scheduler With Recurrence Demo"
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			'Application.EnableVisualStyles();
			Application.Run(New Form1())
		End Sub

		'sample event handler to catch clicks on the schedule control.
		Private Sub scheduleControl1_ScheduleAppointmentClick(ByVal sender As Object, ByVal e As ScheduleAppointmentClickEventArgs)
			Console.WriteLine("scheduleControl1_ScheduleAppointmentClick: {0} {1}", e.ClickType, e.ClickDateTime)
		End Sub

		#Region "utility methods"
		Private Sub CheckAndSaveIfNeeded(ByVal prompt As Boolean)
			Dim name As String = (CType(Me.scheduleControl1.DataSource, ArrayListDataProvider)).FileName
			Dim i As Integer = name.LastIndexOf("\"c)
			If i > -1 Then
				name = name.Substring(i + 1)
			End If
            If Me.scheduleControl1.DataSource.IsDirty AndAlso ((Not prompt) OrElse MessageBox.Show("Save changes?", name & " changed.", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes) Then
                Me.scheduleControl1.DataSource.CommitChanges()
            End If
        End Sub

		#End Region

		#Region "menu handlers"

		#Region "File Menu"

		#Region "file|open calendar"
		Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
			CheckAndSaveIfNeeded(True)

			Dim dlg As OpenFileDialog = New OpenFileDialog()
			dlg.Title = "Open Schedule file"
			dlg.InitialDirectory = Environment.CurrentDirectory
			dlg.Filter = "Schedule XML files (*.XML)|*.XML|Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*"

			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Try
					If dlg.FileName.ToUpper().EndsWith(".XML") Then
						Me.scheduleControl1.DataSource = ArrayListDataProvider.LoadXML(dlg.FileName)
						CType(Me.scheduleControl1.DataSource, ArrayListDataProvider).FileName = dlg.FileName
					Else
						Me.scheduleControl1.DataSource = ArrayListDataProvider.LoadBinary(dlg.FileName)
						CType(Me.scheduleControl1.DataSource, ArrayListDataProvider).FileName = dlg.FileName
					End If
					Me.scheduleControl1.DataSource.IsDirty = False
				Catch ex As Exception
					MessageBox.Show(ex.Message)
				End Try
			End If
		End Sub
		#End Region

		#Region "file|save calendar"
		Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
			If (CType(Me.scheduleControl1.DataSource, ArrayListDataProvider)).FileName = "newScheduleFile.XML" Then
				'do a saveas for new file
				Me.menuItem25.PerformClick()
			Else
				CheckAndSaveIfNeeded(False)
			End If
		End Sub

		#End Region

		#Region "file|new calendar"
		Private Sub menuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem4.Click
			CheckAndSaveIfNeeded(True)

			Dim scheduleProvider As ArrayListDataProvider = New ArrayListDataProvider()
			scheduleProvider.MasterList = New ArrayListAppointmentList()
			scheduleProvider.FileName = "newScheduleFile.XML"
			scheduleProvider.IsDirty = True
			Me.scheduleControl1.DataSource = scheduleProvider

		End Sub

		#End Region

		#Region "File|Random data..."
		Private Sub menuItem26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem26.Click
			CheckAndSaveIfNeeded(True)

			Dim dataProvider As ArrayListDataProvider = New ArrayListDataProvider()
			dataProvider.MasterList = ArrayListDataProvider.InitializeRandomData()
			dataProvider.FileName = "random.XML"

			Me.scheduleControl1.DataSource = dataProvider
		End Sub

		#End Region

		#Region "File|SaveAs"
		Private Sub menuItem25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem25.Click
			Dim saveFile As SaveFileDialog = New SaveFileDialog()
			saveFile.DefaultExt = "*.XML"
			saveFile.FileName = (CType(Me.scheduleControl1.DataSource, ArrayListDataProvider)).FileName
			saveFile.Filter = "Schedule XML Files|*.XML|Schedule Files|*.schedule"

			' get a file name from the user
			If saveFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Try
					If saveFile.FileName.ToUpper().EndsWith(".XML") Then
						CType(Me.scheduleControl1.DataSource, ArrayListDataProvider).SaveXML(saveFile.FileName)
					Else
						CType(Me.scheduleControl1.DataSource, ArrayListDataProvider).SaveBinary(saveFile.FileName)
					End If
					Me.scheduleControl1.DataSource.IsDirty = False
				Catch ex As Exception
					MessageBox.Show(ex.Message)
				End Try
			End If
		End Sub

		#End Region

		#Region "File|Merge"
		Private Sub menuItem27_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem27.Click
			Dim dlg As OpenFileDialog = New OpenFileDialog()
			dlg.Title = "Merge Schedule file"
			dlg.InitialDirectory = Environment.CurrentDirectory
			dlg.Filter = "Schedule XML files (*.XML)|*.XML|Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*"

			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Try
					Dim mergeProvider As ArrayListDataProvider = ArrayListDataProvider.LoadBinary(dlg.FileName)
					Dim dataProvider As ArrayListDataProvider = TryCast(Me.scheduleControl1.DataSource, ArrayListDataProvider)
					Me.scheduleControl1.Calendar.BeginUpdate()
					For Each item As ArrayListAppointment In mergeProvider.MasterList
						dataProvider.AddItem(item)
					Next item
					dataProvider.MasterList.SortStartTime()
					Me.scheduleControl1.Calendar.EndUpdate()
					Me.scheduleControl1.ResetProvider(Me.scheduleControl1.ScheduleType)
				Catch ex As Exception
					MessageBox.Show(ex.Message)
				End Try
			End If
		End Sub
		#End Region

		#Region "file|exit"
		Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem5.Click
			CheckAndSaveIfNeeded(True)
			Me.Close()
		End Sub

		#End Region
		#End Region

		#Region "Edit Menu"

		#Region "handle enabling menus"

		Private Sub menuItem6_Popup(ByVal sender As Object, ByVal e As EventArgs)
			'enable or disable the menu item depending upon a 
			'selected schedule item like Edit and Delete
			Me.menuItem9.Enabled = Me.scheduleControl1.ItemSelected
			Me.menuItem10.Enabled = Me.scheduleControl1.ItemSelected
		End Sub

		#End Region

		#Region "Edit|NewItem"
		Private Sub menuItem7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem7.Click
			Me.scheduleControl1.PerformNewItemClick()
		End Sub

		#End Region

		#Region "Edit New AllDay Item"
		Private Sub menuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem8.Click
			Me.scheduleControl1.PerformNewAllDayItemClick()
		End Sub

		#End Region

		#Region "Edit|Edit Item"
		Private Sub menuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem9.Click
			Me.scheduleControl1.PerformEditItemClick()
		End Sub

		#End Region

		#Region "Edit|Delete Item"
		Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click
			Me.scheduleControl1.PerformDeleteItemClick()
		End Sub

		#End Region

		#End Region

		#Region "View Menu"

		#Region "View|Day"
		Private Sub menuItem12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem12.Click
			If Me.scheduleControl1.ScheduleType <> ScheduleViewType.Day Then
				Me.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Day)
			End If
		End Sub

		#End Region

		#Region "View|WorkWeek"
		Private Sub menuItem13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem13.Click
			If Me.scheduleControl1.ScheduleType <> ScheduleViewType.WorkWeek Then
				Me.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.WorkWeek)
			End If
		End Sub
		#End Region

		#Region "View|Week"
		Private Sub menuItem14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem14.Click
			If Me.scheduleControl1.ScheduleType <> ScheduleViewType.Week Then
				Me.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Week)
			End If
		End Sub
		#End Region

		#Region "View|Month"

		Private Sub menuItem15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem15.Click
			If Me.scheduleControl1.ScheduleType <> ScheduleViewType.Month Then
				Me.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Month)
			End If
		End Sub
		#End Region

		#End Region

		#Region "Options Menu"

		#Region "Options | Appearance"

		Private propertyForm As PropertyGridForm = Nothing
		'Options|Appearance|Edit
		Private Sub menuItem19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem19.Click
			If propertyForm Is Nothing Then
				propertyForm = New PropertyGridForm()
				AddHandler propertyForm.Closing, AddressOf propertyForm_Closing
				propertyForm.AppearancePropertyGrid1.SelectedObject = Me.scheduleControl1.Appearance
				AddHandler propertyForm.AppearancePropertyGrid1.PropertyValueChanged, AddressOf AppearancePropertyGrid1_PropertyValueChanged
			End If
			If (Not propertyForm.Visible) Then
				propertyForm.Show()
			End If
		End Sub
		Private Sub propertyForm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
			propertyForm.Hide()
			e.Cancel = True
		End Sub
		Private Sub AppearancePropertyGrid1_PropertyValueChanged(ByVal s As Object, ByVal e As PropertyValueChangedEventArgs)
			'Console.WriteLine("{0}  {1}", e.ChangedItem.GridItemType, e.ChangedItem.Value);
			e.ChangedItem.PropertyDescriptor.SetValue(Me.scheduleControl1.Appearance, e.ChangedItem.Value)
			Me.scheduleControl1.Refresh()
		End Sub

		'Options|Appearance|Load
		Private Sub menuItem41_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem41.Click
			Dim dlg As OpenFileDialog = New OpenFileDialog()
			dlg.Title = "Open Appearance file"
			dlg.InitialDirectory = Environment.CurrentDirectory
			dlg.Filter = "Appearance files (*.appearance)|*.appearance|Appearance XML files (*.appearance.xml)|*.appearance.xml|All files(*.*)|*.*"

			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Try
					Dim appearance As ScheduleAppearance = Nothing
					If dlg.FileName.ToLower().EndsWith(".xml") Then
						appearance = ScheduleAppearance.LoadXML(dlg.FileName)
					Else
						appearance = ScheduleAppearance.LoadBinary(dlg.FileName)
					End If
					appearance.AttachSchedule(Me.scheduleControl1)
				Catch ex As Exception
					MessageBox.Show(ex.Message)
				End Try
			End If
		End Sub
		'Options|Appearance|Save
		Private Sub menuItem42_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem42.Click
			Dim saveFile As SaveFileDialog = New SaveFileDialog()
			saveFile.DefaultExt = "*.appearance"
			saveFile.FileName = ""
			saveFile.Filter = "Appearance files|*.appearance|Appearance XML files|*.appearance.xml"

			' get a file name from the user
			If saveFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Try
					If saveFile.FileName.ToLower().EndsWith(".xml") Then
						Me.scheduleControl1.Appearance.SaveXML(saveFile.FileName)
					Else
						Me.scheduleControl1.Appearance.SaveBinary(saveFile.FileName)
					End If
				Catch ex As Exception
					MessageBox.Show(ex.Message)
				End Try
			End If
		End Sub

		#End Region

		#Region " Options|Week Numbers"
		Private Sub menuItem20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem20.Click
			Me.scheduleControl1.Calendar.ShowWeekNumbers = Not Me.scheduleControl1.Calendar.ShowWeekNumbers
			Me.menuItem20.Checked = Me.scheduleControl1.Calendar.ShowWeekNumbers
		End Sub

		#End Region

		#Region " Options|Show Additional Panel"
		Private p As Panel
		Private Sub menuItem21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem21.Click
			Me.menuItem21.Checked = Not Me.menuItem21.Checked
			If Me.menuItem21.Checked Then
				p = New Panel()
				p.BackColor = Color.Blue
				p.Dock = DockStyle.Fill
				Me.scheduleControl1.NavigationPanel.Controls.Add(p)
			Else
				Me.scheduleControl1.NavigationPanel.Controls.Remove(p)
				p.Dispose()
				p = Nothing
			End If
		End Sub

		#Region "Options|NavigationPanel"

		Private Sub menuItem22_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem22.Popup
			menuItem29.Checked = False
			menuItem30.Checked = False
			menuItem31.Checked = False
			Select Case Me.scheduleControl1.NavigationPanelPosition
				Case CalendarNavigationPanelPosition.Hidden
					menuItem29.Checked = True
				Case CalendarNavigationPanelPosition.Left
					menuItem30.Checked = True
				Case CalendarNavigationPanelPosition.Right
					menuItem31.Checked = True
			End Select
		End Sub


		'Options|NavigationPanel|Hidden
		Private Sub menuItem29_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem29.Click
			Me.scheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Hidden)
		End Sub
		'Options|NavigationPanel|Left
		Private Sub menuItem30_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem30.Click
			Me.scheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Left)
		End Sub
		'Options|NavigationPanel|Right
		Private Sub menuItem31_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem31.Click
			Me.scheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Right)
		End Sub

		#End Region

		#Region "Options|Alerts"
		Private Sub menuItem44_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuItem44.Click
			Me.scheduleControl1.EnableAlerts = Not Me.scheduleControl1.EnableAlerts
			Me.menuItem44.Checked = Me.scheduleControl1.EnableAlerts

			' change the look of the AlertWindow....
'            if (this.scheduleControl1.EnableAlerts)
'            {
'                this.scheduleControl1.AlertWindow.BackColor = Color.FromArgb(240, 240, 255);
'                this.scheduleControl1.AlertWindow.Grid.TableStyle.BackColor = Color.FromArgb(100, 240, 240, 255);
'                this.scheduleControl1.AlertWindow.Grid.Properties.BackgroundColor = Color.FromArgb(100, Color.Blue);
'                Syncfusion.Windows.Forms.Grid.GridStyleInfo headerStyle =
'                   this.scheduleControl1.AlertWindow.Grid.BaseStylesMap["Header"].StyleInfo;
'                headerStyle.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Color.Blue, Color.White);
'                this.scheduleControl1.AlertWindow.Grid.Refresh();
'            }
		End Sub
		#End Region

		#Region "Options|Culture"
		'set checks on popup
		Private Sub menuItem18_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem18.Popup
			menuItem32.Checked = False
			menuItem33.Checked = False
			menuItem34.Checked = False
			menuItem35.Checked = False
			menuItem36.Checked = False
			menuItem37.Checked = False

			If Me.scheduleControl1.Culture.DisplayName = CultureInfo.InvariantCulture.DisplayName Then
				menuItem32.Checked = True
			ElseIf Me.scheduleControl1.Culture.Name = Application.CurrentCulture.Name Then
				menuItem33.Checked = True
			End If

			If Me.scheduleControl1.Culture.Name = "fr-FR" Then
				menuItem34.Checked = True
			ElseIf Me.scheduleControl1.Culture.Name = "it-IT" Then
				menuItem35.Checked = True
			ElseIf Me.scheduleControl1.Culture.Name = "en-US" Then
				menuItem36.Checked = True
			ElseIf Me.scheduleControl1.Culture.Name = "de-DE" Then
				menuItem37.Checked = True
			End If
		End Sub

		'Options|Culture|Invariant
		Private Sub menuItem32_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem32.Click
			Me.scheduleControl1.Culture = CultureInfo.InvariantCulture
		End Sub

		'Options|Culture|Application
		Private Sub menuItem33_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem33.Click
			Me.scheduleControl1.Culture = Application.CurrentCulture
		End Sub

		'Options|Culture|IT
		Private Sub menuItem34_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem34.Click
			Me.scheduleControl1.Culture = CultureInfo.CreateSpecificCulture("fr-FR")
		End Sub

		'Options|Culture|FR
		Private Sub menuItem35_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem35.Click
			Me.scheduleControl1.Culture = CultureInfo.CreateSpecificCulture("it-IT")
		End Sub

		'Options|Culture|US
		Private Sub menuItem36_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem36.Click
			Me.scheduleControl1.Culture = CultureInfo.CreateSpecificCulture("en-US")
		End Sub
		'Options|Culture|DE
		Private Sub menuItem37_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem37.Click
			Me.scheduleControl1.Culture = CultureInfo.CreateSpecificCulture("de-DE")
		End Sub
		#End Region

		#Region "Options | Save On Close Behavior"

		'display check
		Private Sub menuItem28_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem28.Popup
			menuItem38.Checked = False
			menuItem39.Checked = False
			menuItem40.Checked = False
			Select Case Me.scheduleControl1.DataSource.SaveOnCloseBehaviorAction
				Case SaveOnCloseBehavior.DoNotSave
					menuItem38.Checked = True
				Case SaveOnCloseBehavior.PromptBeforeSave
					menuItem39.Checked = True
				Case SaveOnCloseBehavior.SaveWithoutPrompt
					menuItem40.Checked = True
			End Select
		End Sub

		'Options|SaveOnCloseBehavior|Do Not Save
		Private Sub menuItem38_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem38.Click
			Me.scheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.DoNotSave
		End Sub
		'Options|SaveOnCloseBehavior|Propmt Before Saving
		Private Sub menuItem39_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem39.Click
			Me.scheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.PromptBeforeSave
		End Sub
		'Options|SaveOnCloseBehavior|Save Without Prompt
		Private Sub menuItem40_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem40.Click
			Me.scheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.SaveWithoutPrompt
		End Sub
		#End Region


		'used for testing 
		Private Sub menuItem43_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuItem43.Click

		  'this.scheduleControl1.NavigationPanelFillWithCalendar = true;

			' change the look of the AlertWindow....
			'this.scheduleControl1.AlertWindow.BackColor = Color.FromArgb(240, 240, 255);
			'this.scheduleControl1.AlertWindow.Grid.TableStyle.BackColor = Color.FromArgb(100, 240, 240, 255);
			'this.scheduleControl1.AlertWindow.Grid.Properties.BackgroundColor = Color.FromArgb(100, Color.Blue);
			'Syncfusion.Windows.Forms.Grid.GridStyleInfo headerStyle =
			'   this.scheduleControl1.AlertWindow.Grid.BaseStylesMap["Header"].StyleInfo;
			'headerStyle.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Color.Blue, Color.White);
			'this.scheduleControl1.AlertWindow.Grid.Refresh();

		End Sub

		Private Sub Options_OptionsChanged(ByVal sender As Object, ByVal e As EventArgs)
			Throw New Exception("The method or operation is not implemented.")
		End Sub



		#End Region





		#End Region

		#End Region

        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace




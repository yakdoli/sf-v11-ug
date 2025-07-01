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
Imports Syncfusion.Schedule
Imports Syncfusion.Windows.Forms.Schedule


Namespace GridScheduleSample
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private ScheduleControl1 As Syncfusion.Windows.Forms.Schedule.ScheduleControl
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
        Private components As System.ComponentModel.IContainer
		''' <summary>
		''' Required designer variable.
		''' </summary>

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'initialize the data somehow - specific to your implementation
			Dim scheduleProvider As SimpleScheduleDataProvider
			If File.Exists("default.schedule") Then
				scheduleProvider = SimpleScheduleDataProvider.LoadBinary("default.schedule")
				scheduleProvider.FileName = "default.schedule"
			Else
				scheduleProvider = New SimpleScheduleDataProvider()
                scheduleProvider.MasterList = New SimpleScheduleAppointmentList()
                scheduleProvider.FileName = "default.schedule"
            End If

            Me.ScheduleControl1.ScheduleType = ScheduleViewType.Month 'ScheduleViewType.Day;//.WorkWeek;//.Week;//ScheduleViewType.WorkWeek;// ScheduleViewType.Day;//.WorkWeek;
            'set the data source
            Me.ScheduleControl1.DataSource = scheduleProvider
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "Suite.ico"))
            Me.Icon = ico
            'subscibe to item click event
            AddHandler ScheduleControl1.ScheduleAppointmentClick, AddressOf ScheduleControl1_ScheduleAppointmentClick

            AddHandler menuItem6.Popup, AddressOf menuItem6_Popup
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'overridden to close propertyForm if opened.
        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            If Not Me.propertyForm Is Nothing Then
                Me.propertyForm.Hide()
                RemoveHandler propertyForm.AppearancePropertyGrid1.PropertyValueChanged, AddressOf AppearancePropertyGrid1_PropertyValueChanged
                RemoveHandler propertyForm.Closing, AddressOf propertyForm_Closing
                propertyForm.Close()
            End If

            MyBase.OnClosing(e)
        End Sub


#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.ScheduleControl1 = New Syncfusion.Windows.Forms.Schedule.ScheduleControl
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
            Me.MenuItem43 = New System.Windows.Forms.MenuItem
            Me.menuItem21 = New System.Windows.Forms.MenuItem
            Me.MenuItem44 = New System.Windows.Forms.MenuItem
            Me.menuItem23 = New System.Windows.Forms.MenuItem
            Me.menuItem24 = New System.Windows.Forms.MenuItem
            Me.SuspendLayout()
            '
            'ScheduleControl1
            '
            Me.ScheduleControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ScheduleControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(219, Byte), Integer))
            Me.ScheduleControl1.Culture = New System.Globalization.CultureInfo("")
            Me.ScheduleControl1.DataSource = Nothing
            Me.ScheduleControl1.Location = New System.Drawing.Point(32, 24)
            Me.ScheduleControl1.Name = "ScheduleControl1"
            Me.ScheduleControl1.NavigationPanelPosition = Syncfusion.Schedule.CalendarNavigationPanelPosition.Left
            Me.ScheduleControl1.Size = New System.Drawing.Size(816, 576)
            Me.ScheduleControl1.TabIndex = 3
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
            Me.menuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem17, Me.menuItem18, Me.menuItem22, Me.menuItem28, Me.menuItem20, Me.MenuItem43, Me.menuItem21, Me.MenuItem44})
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
            'MenuItem43
            '
            Me.MenuItem43.Index = 5
            Me.MenuItem43.Text = "Alerts"
            '
            'menuItem21
            '
            Me.menuItem21.Index = 6
            Me.menuItem21.Text = "Additional Panel"
            '
            'MenuItem44
            '
            Me.MenuItem44.Index = 7
            Me.MenuItem44.Text = "Test"
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
            Me.Controls.Add(Me.ScheduleControl1)
            Me.Menu = Me.mainMenu1
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Scheduler Demo"
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            'Application.EnableVisualStyles();
            Application.Run(New Form1())
        End Sub



        'sample event handler to catch clicks on the schedule control.
        Private Sub ScheduleControl1_ScheduleAppointmentClick(ByVal sender As Object, ByVal e As ScheduleAppointmentClickEventArgs)
            Console.WriteLine("ScheduleControl1_ScheduleAppointmentClick: {0} {1}", e.ClickType, e.ClickDateTime)
        End Sub

		#Region "utility methods"
		Private Sub CheckAndSaveIfNeeded(ByVal prompt As Boolean)
			Dim name As String = (CType(Me.ScheduleControl1.DataSource, SimpleScheduleDataProvider)).FileName
			Dim i As Integer = name.LastIndexOf("\"c)
			If i > -1 Then
				name = name.Substring(i + 1)
			End If
            If Me.ScheduleControl1.DataSource.IsDirty AndAlso ((Not prompt) OrElse MessageBox.Show("Save changes?", name & " changed.", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                Me.ScheduleControl1.DataSource.CommitChanges()
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
			dlg.Filter = "Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*"

            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Me.ScheduleControl1.DataSource = SimpleScheduleDataProvider.LoadBinary(dlg.FileName)
                    CType(Me.ScheduleControl1.DataSource, SimpleScheduleDataProvider).FileName = dlg.FileName
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
		End Sub
		#End Region

		#Region "file|save calendar"
		Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
			If (CType(Me.ScheduleControl1.DataSource, SimpleScheduleDataProvider)).FileName = "newScheduleFile.schedule" Then
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

			Dim scheduleProvider As SimpleScheduleDataProvider = New SimpleScheduleDataProvider()
            scheduleProvider.MasterList = New SimpleScheduleAppointmentList()
            scheduleProvider.FileName = "newScheduleFile.schedule"
            scheduleProvider.IsDirty = True
            Me.ScheduleControl1.DataSource = scheduleProvider

        End Sub

#End Region

#Region "File|Random data..."
        Private Sub menuItem26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem26.Click
            CheckAndSaveIfNeeded(True)

            Dim dataProvider As SimpleScheduleDataProvider = New SimpleScheduleDataProvider()
            dataProvider.MasterList = SimpleScheduleDataProvider.InitializeRandomData()
            dataProvider.FileName = "random.schedule"

            Me.ScheduleControl1.DataSource = dataProvider
        End Sub

#End Region

#Region "File|SaveAs"
        Private Sub menuItem25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem25.Click
            Dim saveFile As SaveFileDialog = New SaveFileDialog()
            saveFile.DefaultExt = "*.schedule"
            saveFile.FileName = (CType(Me.ScheduleControl1.DataSource, SimpleScheduleDataProvider)).FileName
            saveFile.Filter = "Schedule Files|*.schedule"

            ' get a file name from the user
            If saveFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    CType(Me.ScheduleControl1.DataSource, SimpleScheduleDataProvider).SaveBinary(saveFile.FileName)
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
            dlg.Filter = "Schedule files (*.schedule)|*.schedule|All files (*.*)|*.*"

            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Dim mergeProvider As SimpleScheduleDataProvider = SimpleScheduleDataProvider.LoadBinary(dlg.FileName)
                    Dim dataProvider As SimpleScheduleDataProvider = CType(IIf(TypeOf Me.ScheduleControl1.DataSource Is SimpleScheduleDataProvider, Me.ScheduleControl1.DataSource, Nothing), SimpleScheduleDataProvider)
                    Me.ScheduleControl1.Calendar.BeginUpdate()
                    Dim item As SimpleScheduleAppointment
                    For Each item In mergeProvider.MasterList
                        dataProvider.AddItem(item)
                    Next item
                    dataProvider.MasterList.SortStartTime()
                    Me.ScheduleControl1.Calendar.EndUpdate()
                    Me.ScheduleControl1.ResetProvider(Me.ScheduleControl1.ScheduleType)
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
			Me.menuItem9.Enabled = Me.ScheduleControl1.ItemSelected
			Me.menuItem10.Enabled = Me.ScheduleControl1.ItemSelected
		End Sub

		#End Region

		#Region "Edit|NewItem"
		Private Sub menuItem7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem7.Click
			Me.ScheduleControl1.PerformNewItemClick()
		End Sub

		#End Region

		#Region "Edit New AllDay Item"
		Private Sub menuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem8.Click
			Me.ScheduleControl1.PerformNewAllDayItemClick()
		End Sub

		#End Region

		#Region "Edit|Edit Item"
		Private Sub menuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem9.Click
			Me.ScheduleControl1.PerformEditItemClick()
		End Sub

		#End Region

		#Region "Edit|Delete Item"
		Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click
			Me.ScheduleControl1.PerformDeleteItemClick()
		End Sub

		#End Region

		#End Region

		#Region "View Menu"

		#Region "View|Day"
		Private Sub menuItem12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem12.Click
			If Me.ScheduleControl1.ScheduleType <> ScheduleViewType.Day Then
				Me.ScheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Day)
			End If
		End Sub

		#End Region

		#Region "View|WorkWeek"
		Private Sub menuItem13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem13.Click
			If Me.ScheduleControl1.ScheduleType <> ScheduleViewType.WorkWeek Then
				Me.ScheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.WorkWeek)
			End If
		End Sub
		#End Region

		#Region "View|Week"
		Private Sub menuItem14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem14.Click
			If Me.ScheduleControl1.ScheduleType <> ScheduleViewType.Week Then
				Me.ScheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Week)
			End If
		End Sub
		#End Region

		#Region "View|Month"

		Private Sub menuItem15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem15.Click
			If Me.ScheduleControl1.ScheduleType <> ScheduleViewType.Month Then
				Me.ScheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Month)
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
				propertyForm.AppearancePropertyGrid1.SelectedObject = Me.ScheduleControl1.Appearance
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
			Console.WriteLine("{0}  {1}", e.ChangedItem.GridItemType, e.ChangedItem.Value)
			e.ChangedItem.PropertyDescriptor.SetValue(Me.ScheduleControl1.Appearance, e.ChangedItem.Value)
			Me.ScheduleControl1.Refresh()
		End Sub

		'Options|Appearance|Load
		Private Sub menuItem41_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem41.Click
			Dim dlg As OpenFileDialog = New OpenFileDialog()
			dlg.Title = "Open Appearance file"
			dlg.InitialDirectory = Environment.CurrentDirectory
			dlg.Filter = "Appearance files (*.appearance)|*.appearance|All files (*.*)|*.*"

            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Dim appearance As ScheduleAppearance = ScheduleAppearance.LoadBinary(dlg.FileName)
                    appearance.AttachSchedule(Me.ScheduleControl1)
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
			saveFile.Filter = "Appearance Files|*.appearance"

			' get a file name from the user
            If saveFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Me.ScheduleControl1.Appearance.SaveBinary(saveFile.FileName)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
		End Sub

		#End Region

		#Region " Options|Week Numbers"
		Private Sub menuItem20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem20.Click
			Me.ScheduleControl1.Calendar.ShowWeekNumbers = Not Me.ScheduleControl1.Calendar.ShowWeekNumbers
			Me.menuItem20.Checked = Me.ScheduleControl1.Calendar.ShowWeekNumbers
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
				Me.ScheduleControl1.NavigationPanel.Controls.Add(p)
			Else
				Me.ScheduleControl1.NavigationPanel.Controls.Remove(p)
				p.Dispose()
				p = Nothing
			End If
		End Sub

		#Region "Options|NavigationPanel"

		Private Sub menuItem22_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem22.Popup
			menuItem29.Checked = False
			menuItem30.Checked = False
			menuItem31.Checked = False
			Select Case Me.ScheduleControl1.NavigationPanelPosition
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
			Me.ScheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Hidden)
		End Sub
		'Options|NavigationPanel|Left
		Private Sub menuItem30_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem30.Click
			Me.ScheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Left)
		End Sub
		'Options|NavigationPanel|Right
		Private Sub menuItem31_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem31.Click
			Me.ScheduleControl1.SetNavigationPanelPosition(CalendarNavigationPanelPosition.Right)
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

			If Me.ScheduleControl1.Culture.DisplayName = CultureInfo.InvariantCulture.DisplayName Then
				menuItem32.Checked = True
			Else If Me.ScheduleControl1.Culture.Name = Application.CurrentCulture.Name Then
				menuItem33.Checked = True
			End If

			If Me.ScheduleControl1.Culture.Name = "fr-FR" Then
				menuItem34.Checked = True
			Else If Me.ScheduleControl1.Culture.Name = "it-IT" Then
				menuItem35.Checked = True
			Else If Me.ScheduleControl1.Culture.Name = "en-US" Then
				menuItem36.Checked = True
			Else If Me.ScheduleControl1.Culture.Name = "de-DE" Then
				menuItem37.Checked = True
			End If
		End Sub

		'Options|Culture|Invariant
		Private Sub menuItem32_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem32.Click
			Me.ScheduleControl1.Culture = CultureInfo.InvariantCulture
		End Sub

		'Options|Culture|Application
		Private Sub menuItem33_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem33.Click
			Me.ScheduleControl1.Culture = Application.CurrentCulture
		End Sub

		'Options|Culture|IT
		Private Sub menuItem34_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem34.Click
			Me.ScheduleControl1.Culture = CultureInfo.CreateSpecificCulture("fr-FR")
		End Sub

		'Options|Culture|FR
		Private Sub menuItem35_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem35.Click
			Me.ScheduleControl1.Culture = CultureInfo.CreateSpecificCulture("it-IT")
		End Sub

		'Options|Culture|US
		Private Sub menuItem36_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem36.Click
			Me.ScheduleControl1.Culture = CultureInfo.CreateSpecificCulture("en-US")
		End Sub
		'Options|Culture|DE
		Private Sub menuItem37_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem37.Click
			Me.ScheduleControl1.Culture = CultureInfo.CreateSpecificCulture("de-DE")
		End Sub
		#End Region

		#Region "Options | Save On Close Behavior"

		'display check
		Private Sub menuItem28_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem28.Popup
			menuItem38.Checked = False
			menuItem39.Checked = False
			menuItem40.Checked = False
			Select Case Me.ScheduleControl1.DataSource.SaveOnCloseBehaviorAction
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
			Me.ScheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.DoNotSave
		End Sub
		'Options|SaveOnCloseBehavior|Propmt Before Saving
		Private Sub menuItem39_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem39.Click
			Me.ScheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.PromptBeforeSave
		End Sub
		'Options|SaveOnCloseBehavior|Save Without Prompt
		Private Sub menuItem40_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem40.Click
			Me.ScheduleControl1.DataSource.SaveOnCloseBehaviorAction = SaveOnCloseBehavior.SaveWithoutPrompt
		End Sub
		#End Region



		#End Region



		#End Region



		#End Region

        Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
            Me.ScheduleControl1.EnableAlerts = Not Me.ScheduleControl1.EnableAlerts
            Me.MenuItem43.Checked = Me.ScheduleControl1.EnableAlerts
        End Sub

        Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
            Dim dataProvider As SimpleScheduleDataProvider = Me.ScheduleControl1.DataSource
            If dataProvider Is Nothing Or dataProvider.MasterList.Count < 4 Then
                Me.menuItem26.PerformClick()
            End If
            'change to day
            Me.ScheduleControl1.SwitchToScheduleViewTypeDay(DateTime.Now)


            'enable alerts
            Me.ScheduleControl1.EnableAlerts = True
        End Sub
    End Class
End Namespace




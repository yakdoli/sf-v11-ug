#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.IO
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Schedule
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Schedule

Namespace OutlookDemo
	''' <summary>
	''' Summary description for CalanderForm.
	''' </summary>
	Public Class CalendarForm
		Inherits System.Windows.Forms.UserControl
		Friend scheduleControl1 As ScheduleControl
		#Region "Declaration"

		Private scheduleProvider As SimpleScheduleDataProvider = Nothing
		Friend WithEvents btnDay As ButtonAdv
		Friend WithEvents btnWeek As ButtonAdv
		Friend WithEvents btnMonth As ButtonAdv
		Friend WithEvents radWorkWeek As RadioButton
		Friend WithEvents radFullWeek As RadioButton
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		#End Region

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

'			#Region "SetData"

			Dim fileName As String = "default.xml"
			If FindFile(fileName) Then
				scheduleProvider = SimpleScheduleDataProvider.LoadXML(fileName)
				scheduleProvider.FileName = fileName
				OffsetData()
			Else
				scheduleProvider = New SimpleScheduleDataProvider()
				scheduleProvider.MasterList = New SimpleScheduleItemList()
				scheduleProvider.FileName = "default.xml"
			End If

			scheduleControl1.ScheduleType=ScheduleViewType.Day

			scheduleControl1.DataSource=scheduleProvider

'			#End Region

'			#Region "Style Settings"
			Me.scheduleControl1.EnableAlerts = True
			Me.scheduleControl1.Appearance.ShowCaptionButtons = True
			Me.radWorkWeek.Visible = False
			Me.radFullWeek.Visible = False
'			#End Region


			'need to size a padding panel...
			For Each c As Control In scheduleControl1.CaptionPanel.Controls
				If c.Name = "panelSpacer" Then
					c.Width = 40
				End If
			Next c
			Me.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Blue
		End Sub

		'used to center sample data around the current date.
		Private Sub OffsetData()
			Dim offSet As Integer = (CType(DateTime.Now - New DateTime(2006, 11, 6), TimeSpan)).Days - 2
			For Each item As ScheduleAppointment In scheduleProvider.MasterList
				item.StartTime = item.StartTime.AddDays(offSet)
				item.EndTime = item.EndTime.AddDays(offSet)
			Next item
			scheduleProvider.MasterList.SortStartTime()
		End Sub

		Private Function FindFile(ByRef fileName As String) As Boolean
			Dim i As Integer = 0
			Do While i < 4 AndAlso Not File.Exists(fileName)
				fileName = "..\" & fileName
				i += 1
			Loop
			Return File.Exists(fileName)
		End Function

		Public ReadOnly Property Scheduler() As ScheduleControl
			Get
				Return Me.scheduleControl1
			End Get
		End Property

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

		#Region "Component Designer generated code"
		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.scheduleControl1 = New Syncfusion.Windows.Forms.Schedule.ScheduleControl()
			Me.btnDay = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.btnWeek = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.btnMonth = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.radWorkWeek = New System.Windows.Forms.RadioButton()
			Me.radFullWeek = New System.Windows.Forms.RadioButton()
			Me.SuspendLayout()
			' 
			' scheduleControl1
			' 
			Me.scheduleControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.scheduleControl1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(189))))), (CInt(Fix((CByte(215))))), (CInt(Fix((CByte(252))))))
			Me.scheduleControl1.Culture = New System.Globalization.CultureInfo("")
			Me.scheduleControl1.DataSource = Nothing
			Me.scheduleControl1.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.scheduleControl1.Location = New System.Drawing.Point(0, 34)
			Me.scheduleControl1.Name = "scheduleControl1"
			Me.scheduleControl1.NavigationPanelPosition = Syncfusion.Schedule.CalendarNavigationPanelPosition.Hidden
			Me.scheduleControl1.Size = New System.Drawing.Size(600, 326)
			Me.scheduleControl1.TabIndex = 0
			' 
			' btnDay
			' 
			Me.btnDay.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.btnDay.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Solid
			Me.btnDay.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnDay.KeepFocusRectangle = False
			Me.btnDay.Location = New System.Drawing.Point(1, 0)
			Me.btnDay.Name = "btnDay"
			Me.btnDay.Size = New System.Drawing.Size(75, 33)
			Me.btnDay.TabIndex = 1
			Me.btnDay.Text = "Day"
			Me.btnDay.UseVisualStyle = True
'			Me.btnDay.Click += New System.EventHandler(Me.buttonAdv1_Click)
			' 
			' btnWeek
			' 
			Me.btnWeek.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.btnWeek.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Solid
			Me.btnWeek.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnWeek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.btnWeek.KeepFocusRectangle = False
			Me.btnWeek.Location = New System.Drawing.Point(76, 0)
			Me.btnWeek.Name = "btnWeek"
			Me.btnWeek.Size = New System.Drawing.Size(75, 33)
			Me.btnWeek.TabIndex = 2
			Me.btnWeek.Text = "Week"
			Me.btnWeek.UseVisualStyle = True
'			Me.btnWeek.Click += New System.EventHandler(Me.buttonAdv2_Click)
			' 
			' btnMonth
			' 
			Me.btnMonth.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.btnMonth.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat
			Me.btnMonth.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.btnMonth.KeepFocusRectangle = False
			Me.btnMonth.Location = New System.Drawing.Point(151, 0)
			Me.btnMonth.Name = "btnMonth"
			Me.btnMonth.Size = New System.Drawing.Size(75, 33)
			Me.btnMonth.TabIndex = 3
			Me.btnMonth.Text = "Month"
			Me.btnMonth.UseVisualStyle = True
'			Me.btnMonth.Click += New System.EventHandler(Me.buttonAdv3_Click)
			' 
			' radWorkWeek
			' 
			Me.radWorkWeek.AutoSize = True
			Me.radWorkWeek.BackColor = System.Drawing.Color.Transparent
			Me.radWorkWeek.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radWorkWeek.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radWorkWeek.Location = New System.Drawing.Point(261, 8)
			Me.radWorkWeek.Name = "radWorkWeek"
			Me.radWorkWeek.Size = New System.Drawing.Size(120, 20)
			Me.radWorkWeek.TabIndex = 4
			Me.radWorkWeek.TabStop = True
			Me.radWorkWeek.Text = "Show work week"
			Me.radWorkWeek.UseVisualStyleBackColor = False
'			Me.radWorkWeek.CheckedChanged += New System.EventHandler(Me.radioButton1_CheckedChanged)
			' 
			' radFullWeek
			' 
			Me.radFullWeek.AutoSize = True
			Me.radFullWeek.BackColor = System.Drawing.Color.Transparent
			Me.radFullWeek.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radFullWeek.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radFullWeek.Location = New System.Drawing.Point(435, 8)
			Me.radFullWeek.Name = "radFullWeek"
			Me.radFullWeek.Size = New System.Drawing.Size(112, 20)
			Me.radFullWeek.TabIndex = 5
			Me.radFullWeek.TabStop = True
			Me.radFullWeek.Text = "Show full week"
			Me.radFullWeek.UseVisualStyleBackColor = False
'			Me.radFullWeek.CheckedChanged += New System.EventHandler(Me.radioButton2_CheckedChanged)
			' 
			' CalendarForm
			' 
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(173))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(255))))))
			Me.Controls.Add(Me.radFullWeek)
			Me.Controls.Add(Me.radWorkWeek)
			Me.Controls.Add(Me.btnMonth)
			Me.Controls.Add(Me.btnWeek)
			Me.Controls.Add(Me.btnDay)
			Me.Controls.Add(Me.scheduleControl1)
			Me.Name = "CalendarForm"
			Me.Size = New System.Drawing.Size(600, 360)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		#Region "Event Handlers"

		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDay.Click
			Me.radWorkWeek.Visible = False
			Me.radFullWeek.Visible = False
			If Me.scheduleControl1.ScheduleType <> ScheduleViewType.Day Then
				Me.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Day)
			End If
		End Sub

		Private Sub buttonAdv2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnWeek.Click
			Me.radWorkWeek.Visible = True
			Me.radFullWeek.Visible = True
			Me.radWorkWeek.Checked = True
			If Me.scheduleControl1.ScheduleType <> ScheduleViewType.WorkWeek Then
				Me.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.WorkWeek)
			End If
		End Sub

		Private Sub buttonAdv3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMonth.Click
			Me.radWorkWeek.Visible = False
			Me.radFullWeek.Visible = False
			If Me.scheduleControl1.ScheduleType <> ScheduleViewType.Month Then
				Me.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Month)
			End If
		End Sub

		Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radWorkWeek.CheckedChanged
			If Me.scheduleControl1.ScheduleType <> ScheduleViewType.WorkWeek Then
				Me.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.WorkWeek)
			End If
		End Sub

		Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radFullWeek.CheckedChanged
			If Me.scheduleControl1.ScheduleType <> ScheduleViewType.Week Then
				Me.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Week)
			End If
		End Sub
		#End Region

	End Class
End Namespace

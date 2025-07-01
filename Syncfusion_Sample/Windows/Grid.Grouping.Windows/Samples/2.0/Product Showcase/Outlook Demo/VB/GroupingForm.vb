
#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region
Imports Microsoft.VisualBasic
Imports System
Imports System.Xml
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text
Imports System.Data.OleDb
Imports System.IO
Imports Syncfusion.Collections
Imports Syncfusion.Drawing
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping

Namespace OutlookDemo
	#Region "delegates"
	' A delegate type for hooking up change notifications.
	Public Delegate Sub ChangedEventHandler(ByVal sender As Object, ByVal e As EventArgs)
	#End Region

	#Region "enums"
	Public Enum days
		Today = 1
		Yesterday = 2
		Thursday = 3
		Wednesday = 4
		Tuesday = 5
		Monday = 6
		Sunday = 7
		LastWeek = 8
		TwoWeeksAgo = 9
		ThreeWeeksAgo = 10
		LastMonth = 11
		Older = 12
	End Enum

	Public Enum flags
		Clear = 0
		Red = 1
		Blue = 2
		Yellow = 3
		Green = 4
		Orange = 5
		Purple = 6
		Complete = 7
		HighPriority = 8
		LowPriority = 9
		ShowClip = 11
	End Enum

	Public Enum categories
		Red = 0
		Blue = 1
		Green = 2
		Orange = 3
		Purple = 4
		Yellow = 5
	End Enum

	Public Enum mail
		Unread = 0
		Read = 1
	End Enum
	Friend Enum headerImage
		Priority = 10
		Attachment = 11
		Mail = 12
		ReadState = 13
		Flag = 0
		Up = 15
		Down = 16
	End Enum

	#End Region

	#Region "Class"
	''' <summary>
	''' Summary description for GroupingPanel.
	''' </summary>
	Public Class GroupingPanel
		Inherits System.Windows.Forms.Panel

		#Region "Declarations"

		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private groupingConfig1 As Syncfusion.Grouping.GroupingConfig
		Private components As System.ComponentModel.IContainer
		Private CSVHeader As ColumnSetViewHeader
		Private i1 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "flag_clear.png"))
		Private i2 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "today.png"))
		Private i3 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "tomorrow.png"))
		Private i4 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "thisweek.png"))
		Private i5 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "thisweek.png"))
		Private i6 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "today.png"))
		Private i7 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "today.png"))
		Private i8 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "alert.png"))
		Private i9 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "priority.png"))
		Private i10 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "LowPriority.png"))
		Private i11 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "priority_black.png"))
		Private i12 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "clip_32.png")) 'attach_icon.ico
		Private i13 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "mailHeader.ico"))
		Private i14 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "readStateHeader.ico"))
		Private i15 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "plus.png"))
		Private i16 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"))
		Private i17 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "flag_complete.png"))

		Private m1 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "Mail_S.ico"))
		Private m2 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "mail_open.png"))
		Private m3 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "reply.png"))
		Private m4 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "forward.png"))
		Private m5 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "replyall.png"))

		Private u1 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "TBPrint_S.ico"))
		Private u2 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "TBDelete_S.ico"))
		Private u3 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "TBMoveToFolder_S.ico"))
		Private u4 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "TBCreateRule_S.ico"))

		Private h1 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "sortasc.bmp"))
		Private h2 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "sortdesc.bmp"))
		Private h3 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "grp.bmp"))
		Private h4 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "groupByBox.png"))
		Private h5 As Image = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "fldChooser.png"))

		Private parentBarItem_ArrangeBy As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem_Date As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_From As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_Subject As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_Size As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private normalViewPopUpMenu As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private barItem_To As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_SortAscending As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_sortDescending As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_GroupByThisField As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_GroupByBox As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_RemoveThisColumn As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_FieldChooser As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem_BestFit As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem_FormatColumns As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_CustomizeCurrentView As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_Conversation As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem_Folder As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_Type As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_Flag As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_Attachments As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_EmailAccounts As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_Importance As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_Categories As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem_Custom As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_ShowInGroups As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private flagPopupMenu As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private WithEvents todayBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents tomoBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents thisweekFlagBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents nextweekFlagBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents nodateFlagBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents customFlagBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents addReminderBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents markcompleteFlagBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents redAsDefaultBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents blueAsDefaultBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents yellowAsDefaultBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents greenAsDefaultBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents orangeAsDefaultBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents purpleAsDefaultBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents setquickclickBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private flagMenusParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private clearflagParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private CaptionPopupMenu As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private parentBarItemForCaption As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Public WithEvents collapseAllGroupsBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Public WithEvents ExpandAllGroupsBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private OpenItemsBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private PrintfromCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private ForwardfromCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private categoriesBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents MarkAsReadfromCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents MarkAsUnreadfromCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private DeletefromCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private MovetoFolderfromCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private FollowUpParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents todayCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents nextweekCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents tomoCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents thisweekfromCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents nodateCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents customCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents addreminderCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents markcompletefromCaptionBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private RecordPopupMenu As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private RecordsParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private OpenfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private PrintfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private ReplyfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private ReplyToAllfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private ForwardfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private RecordFollowUpParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents todayRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents tomoRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents thisweekRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents nextweekRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents nodateRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents customRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents addreminderRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents ClearFlagfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents BlueasDefaultfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents YellowasDefaultfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents GreenasDefaultfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents OrangeasDefaultfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents PurpleasDefaultfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents RedAsDefaultfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents MarkfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private CategoriesfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private CreateRulefromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private FindAllfromRecordparentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private MessagesfromsenderBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private RelatedMessagesBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private JunkEmailsfromRecordParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private AddSendertoBlockedSendersListBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private AddSendertoSafeSendersListBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private AddSendersDomaintoSafeSendersListBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private AddRecipienttoSafeRecipientsListBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private MarkasNotJunkBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private JunkEmailOptionsBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents DeletefromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private MoveToFolderfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private OptionsfromRecordBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private markcompleteRecordItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private headerParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private iList As System.Windows.Forms.ImageList
		Private headerPopUpMenu As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private mailList As ImageList
		Private UtilIconList As ImageList
		Private fList, hmenuList As ImageList
		Private clearflagCaptionBarItem As BarItem
		Private setBarItem As BarItem
		Private setRecordBarItem1 As BarItem
		Private categoryPopUpMenu As PopupMenu
		Private categoryParentBarItem As ParentBarItem
		Private clearallcategBarItem As BarItem
		Private categsearchBarItem As BarItem
		Private WithEvents redcategBarItem As BarItem
		Private WithEvents blueBarItem As BarItem
		Private WithEvents greenBarItem As BarItem
		Private WithEvents orangeBarItem As BarItem
		Private WithEvents purpleBarItem As BarItem
		Private WithEvents yellowBarItem As BarItem
		Private allcategBarItem As BarItem
		Private setcategBarItem As BarItem
		Private imageList1 As ImageList
		Private visibleCols() As String

		#End Region

		#Region "events"

		Public Event Changed As ChangedEventHandler
		Public Event ShowViewChanged As ChangedEventHandler

		' Invoke the Changed event, called whenever the NormalView property changes
		Protected Overridable Sub OnChanged(ByVal e As EventArgs)
			RaiseEvent Changed(Me, e)
		End Sub

		#End Region

		#Region "Properties"
		Public PreviewSelected As Boolean
'INSTANT VB NOTE: The variable normalView was renamed since Visual Basic does not allow class members with the same name:
		Private normalView_Renamed As Boolean
		''' <summary>
		''' Indicates the Normal view..
		''' </summary>
		Public Property NormalView() As Boolean
			Get
				Return normalView_Renamed
			End Get
			Set(ByVal value As Boolean)
				If normalView_Renamed <> value Then
					OnChanged(EventArgs.Empty)
				End If
				normalView_Renamed = value
			End Set
		End Property
		Private groupedBy As String = ""
'INSTANT VB NOTE: The variable columnAtBottom was renamed since Visual Basic does not allow class members with the same name:
		Private columnAtBottom_Renamed As String
		''' <summary>
		''' To know the column which is at the bottom 
		''' useful for column set view
		''' </summary>
		Public ReadOnly Property ColumnAtBottom() As String
			Get
				Return columnAtBottom_Renamed
			End Get
		End Property
'INSTANT VB NOTE: The variable columnAtTop was renamed since Visual Basic does not allow class members with the same name:
		Private columnAtTop_Renamed As String
		''' <summary>
		''' To know the column which is at the top/first 
		''' useful for column set view
		''' </summary>
		Public ReadOnly Property ColumnAtTop() As String
			Get
				Return columnAtTop_Renamed
			End Get
		End Property
		' to check and allow to set for the available columns
'INSTANT VB NOTE: The variable numberOfLayers was renamed since Visual Basic does not allow class members with the same name:
		Private numberOfLayers_Renamed As Integer = 2
		''' <summary>
		''' Number of Layers/MultiLine required 
		''' Minimum 2 lines and the update is fetched from the field chooser..
		''' </summary>
		Public Property NumberOfLayers() As Integer
			Get
				Return numberOfLayers_Renamed
			End Get
			Set(ByVal value As Integer)
				numberOfLayers_Renamed = value
			End Set
		End Property
'INSTANT VB NOTE: The variable groupColumn was renamed since Visual Basic does not allow class members with the same name:
		Private groupColumn_Renamed As String
		''' <summary>
		''' The column that is to be grouped in the normal view
		''' </summary>
		Public Property GroupColumn() As String
			Get
				Return groupColumn_Renamed
			End Get
			Set(ByVal value As String)
				groupColumn_Renamed = value
			End Set
		End Property
'INSTANT VB NOTE: The variable secondColumnSetSize was renamed since Visual Basic does not allow class members with the same name:
		Private secondColumnSetSize_Renamed As Integer
		Public ReadOnly Property SecondColumnSetSize() As Integer
			Get
				Return secondColumnSetSize_Renamed
			End Get
		End Property
'INSTANT VB NOTE: The variable secondRowColumn was renamed since Visual Basic does not allow class members with the same name:
		Private secondRowColumn_Renamed As String
		Public Property SecondRowColumn() As String
			Get
				Return secondRowColumn_Renamed
			End Get
			Set(ByVal value As String)
				secondRowColumn_Renamed = value
			End Set
		End Property

		Public ReadOnly Property Grid() As GridGroupingControl
			Get
				Return Me.gridGroupingControl1
			End Get
		End Property
'INSTANT VB NOTE: The variable defaultFlag was renamed since Visual Basic does not allow class members with the same name:
		Private defaultFlag_Renamed As flags = flags.Red
		Public Property DefaultFlag() As flags
			Get
				Return defaultFlag_Renamed
			End Get
			Set(ByVal value As flags)
				defaultFlag_Renamed = value
			End Set
		End Property

		Public ReadOnly Property HeaderForeColor() As Color
			Get
				Select Case Me.gridGroupingControl1.TableOptions.GridVisualStyles
					Case GridVisualStyles.Office2007Black
						Return Color.FromArgb(248, 248, 248)
					Case GridVisualStyles.Office2007Silver
						Return Color.FromArgb(241, 243, 243)
					Case Else
						Return Color.FromArgb(249, 252, 255)
				End Select
			End Get
		End Property

		Public ReadOnly Property HeaderBackColor() As Color
			Get
				Select Case Me.gridGroupingControl1.TableOptions.GridVisualStyles
					Case GridVisualStyles.Office2007Black
						Return Color.FromArgb(223, 223, 223)
					Case GridVisualStyles.Office2007Silver
						Return Color.FromArgb(200, 201, 202)
					Case Else
						Return Color.FromArgb(197, 222, 255)
				End Select
			End Get
		End Property

		Public ReadOnly Property SortIconColor() As Color
			Get
				Select Case Me.gridGroupingControl1.TableOptions.GridVisualStyles
					Case GridVisualStyles.Office2007Black
						Return Color.FromArgb(145, 153, 164)
					Case GridVisualStyles.Office2007Silver
						Return Color.FromArgb(110, 109, 143)
					Case Else
						Return Color.FromArgb(154, 198, 255)
				End Select
			End Get
		End Property

		#End Region

		#Region "dataTable"
		Private Function GetTable() As DataTable
			Dim dt As New DataTable()

			'	DataColumn dcDate = new DataColumn("Date");
			Dim dcAttachment As New DataColumn("Attachment")
			Dim dcFrom As New DataColumn("From")
			Dim dcSubject As New DataColumn("Subject")
			Dim dcReceived As New DataColumn("Received", GetType(DateTime))

			Dim dcMails As New DataColumn("mails", GetType(Integer))
			Dim dcReadState As New DataColumn("ReadState", GetType(Integer))
			Dim dcTo As New DataColumn("To")
			Dim dcContent As New DataColumn("Content")
			'DataColumn dcflag = new DataColumn("flag", typeof(int));
			Dim dcSize As New DataColumn("Size", GetType(Double))
			Dim dcPriority As New DataColumn("Priority")
			Dim dcCategory As New DataColumn("Category", GetType(String))
			Dim dcFlag As New DataColumn("flag", GetType(Integer))

			dt.Columns.Add(dcAttachment)
			'dt.Columns.Add(dcDate);
			dt.Columns.Add(dcFrom)
			dt.Columns.Add(dcSubject)
			dt.Columns.Add(dcReceived)
			'
			dt.Columns.Add(dcMails)
			dt.Columns.Add(dcReadState)
			dt.Columns.Add(dcTo)
			dt.Columns.Add(dcContent)
			'dt.Columns.Add(dcflag);
			dt.Columns.Add(dcSize)
			dt.Columns.Add(dcPriority)
			dt.Columns.Add(dcCategory)
			dt.Columns.Add(dcFlag)

			dt.Rows.Add(New Object() { String.Empty, "Tindale", "Eval version Key", DateTime.Now, 0, 0, "Jake", "Please provide me the key to the new version", 5010, String.Empty, "Red Category", CInt(flags.Red) })
			dt.Rows.Add(New Object() { String.Empty, "Tony", "Re: Tool Missing ", DateTime.Now.AddMinutes(-2), 0, 0, "Jake", "Thanks Jake, Now it works", 29300, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Brown", "Essential Grid ", DateTime.Now.AddHours(-1), 0, 0, "Jake", "Will you help me in purchasing Essential Grid", 5010, String.Empty, "Purple Category", CInt(flags.Yellow) })
			dt.Rows.Add(New Object() { String.Empty, "Sam", "Re:Latest Version", DateTime.Now.AddHours(-3), 0, 0, "Jake", "You can download the latest version now", 293000, 1, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Ted", "UserAccount", DateTime.Now.AddHours(-3), 0, 0, "Jake", "User accounts have been created", 55000, 1, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "George", "Re: Solution", DateTime.Now.AddDays(-1), 0, 0, "Jake", "Thanks! This sorted the problem", 1025, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { 1, "Paul", "New Image", DateTime.Now.AddDays(-10), 0, 0, "Jake", "Please have a look at this", 3453454, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { 1, "Donald", "Re: icons", DateTime.Now.AddDays(-12), 2, 1, "Jake", "Please modify them", 3434100, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Jerry", "Re: ", DateTime.Now.AddDays(-21), 2, 1, "Jake", "The feature is added now. It is ready for testing", 2033, -1, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "George", "Installaion Procedure", DateTime.Now.AddDays(-42), 2, 1, "Jake", "It is uploaded in server. Please go through this", 20400, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { 1, "Paul", "Report Format", DateTime.Now.AddDays(-50), 3, 1, "Jake", "Please have a look at this", 3453440, 1, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Donald", "Code Optimizer tool", DateTime.Now.AddDays(-63), 2, 1, "Jake", "Where can I found the complete documentation", 34341, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Bob", "FeatureList", DateTime.Now.AddDays(-75), 2, 1, "Jake", "Could you please send me the list of new features ", 5010, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { 1, "Sam", "Re: redraw issue", DateTime.Now.AddDays(-98), 1, 1, "Jake", "It is fixed", 293000, 1, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Ted", "Re: Helper tool", DateTime.Now.AddDays(-100), 2, 1, "Jake", "This works great!!", 55000, 1, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Babu", "Re:Defects", DateTime.Now.AddDays(-101), 1, 1, "Jake", "All Defects have been fixed.", 5010, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { 1, "Domnique", "Code file missing", DateTime.Now.AddDays(-113), 2, 1, "Jake", "Could you please resend it again", 293000, -1, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Haddok", "Re: resize problem", DateTime.Now.AddDays(-120), 2, 1, "Jake", "Thanks for your solution", 55000, 1, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "George", "Re: ReleaseDates", DateTime.Now.AddDays(-128), 3, 1, "Jake", "It will be announced tommorrow", 1025, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { 1, "Paul", "Icons", DateTime.Now.AddDays(-199), 2, 1, "Jake", "Here is a list of icons", 3453454, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { 1, "Donald", "Re: FeatureList", DateTime.Now.AddDays(-200), 1, 1, "Jake", "Please find the attachment for details", 3434100, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Jerry", "Re:Latest Version", DateTime.Now.AddDays(-208), 2, 1, "Jake", "You can download the latest version now", 2033, -1, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "George", "Re: scrolling issue", DateTime.Now.AddDays(-259), 2, 1, "Jake", "It is fixed", 20400, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { 1, "Paul", "New sample", DateTime.Now.AddDays(-270), 1, 1, "Jake", "Please test this", 3454540, 1, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Don", "Re: Evaluation Keys", DateTime.Now.AddDays(-295), 2, 1, "Jake", "Hello, Finally decided purchasing Essential Grid.", 34341, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "George", "New website ", DateTime.Now.AddDays(-300), 1, 1, "Jake", "Please send me the link", 20400, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Paul", "Refresh issues", DateTime.Now.AddDays(-350), 1, 1, "Jake", "Please check them", 3453540, 1, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { 1, "Don", "Re: UI design", DateTime.Now.AddDays(-351), 2, 1, "Jake", "Thanks for your pointers! we came up with solution", 34341, String.Empty, "Green Category", CInt(flags.Green) })
			dt.Rows.Add(New Object() { String.Empty, "Neal Culiner", "Kudos Folks!!!", DateTime.Now.AddDays(-355), 2, 1, "Jake", "All I can say is WOW! Beautiful works!", 1025, String.Empty, "Purple Category", CInt(flags.Purple) })
			dt.Rows.Add(New Object() { String.Empty, "Paul", "Re: License issue", DateTime.Now.AddDays(-356), 3, 1, "Jake", "Thanks!!", 3453454, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { 1, "Don", "UI design", DateTime.Now.AddDays(-357), 3, 1, "Jake", "Will it be possible to tune grids as in the attachment.", 3434100, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Jerry", "Evalutation", DateTime.Now.AddDays(-358), 2, 1, "Jake", "Testing is completed. This product works fine", 2033, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Patrick", "Feedback", DateTime.Now.AddDays(-359), 2, 1, "Jake", "Thanks for your extraordinary support.", 20400, String.Empty, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Paul", "License issue", DateTime.Now.AddDays(-360), 3, 1, "Jake", "How do I enable license to my customers?", 344540, 1, Nothing, CInt(flags.Clear) })
			dt.Rows.Add(New Object() { String.Empty, "Don", "Evaluation Keys", DateTime.Now.AddDays(-365), 1, 1, "Jake", "Can you send the keys to test your produts.", 34341, String.Empty, Nothing, CInt(flags.Complete) })
			Return dt
		End Function
		#End Region

		#Region "Constructor"

		Public Sub New()
			' GroupingEngineFactory provides a modified GridChildTable that adds an extra section
			GridEngineFactory.Factory = New GroupingEngineFactory()

			InitializeComponent()

			CSVHeader = New ColumnSetViewHeader()
			Me.gridGroupingControl1.DataSource = GetTable()
			Me.gridGroupingControl1.TableDescriptor.Columns.Clear()
			Me.gridGroupingControl1.TableDescriptor.Columns.Add("Priority")
			Me.gridGroupingControl1.TableDescriptor.Columns.Add("mails")
			Me.gridGroupingControl1.TableDescriptor.Columns.Add("Attachment")
			Me.gridGroupingControl1.TableDescriptor.Columns.Add("Subject")
			Me.gridGroupingControl1.TableDescriptor.Columns.Add("From")
			Me.gridGroupingControl1.TableDescriptor.Columns.Add("Received")
			Me.gridGroupingControl1.TableDescriptor.Columns.Add("Size")
			Me.gridGroupingControl1.TableDescriptor.Columns.Add("Category")
			Me.gridGroupingControl1.TableDescriptor.Columns.Add("flag")

			visibleCols = New String(Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Count - 1){}
			For i As Integer = 0 To visibleCols.Length - 1
				visibleCols(i) = Me.gridGroupingControl1.TableDescriptor.VisibleColumns(i).Name
			Next i

			Me.gridGroupingControl1.TableOptions.RecordPreviewRowHeight = 40

			fList = New ImageList()
			fList.Images.Add(i1)
			fList.Images.Add(i2)
			fList.Images.Add(i3)
			fList.Images.Add(i4)
			fList.Images.Add(i5)
			fList.Images.Add(i6)
			fList.Images.Add(i7)
			fList.Images.Add(i8)
			fList.Images.Add(i17)
			fList.ColorDepth = ColorDepth.Depth32Bit

			iList = New ImageList()
			iList.Images.Add(i1)
			iList.Images.Add(i2)
			iList.Images.Add(i3)
			iList.Images.Add(i4)
			iList.Images.Add(i5)
			iList.Images.Add(i6)
			iList.Images.Add(i7)
			iList.Images.Add(i8)
			iList.Images.Add(i9)
			iList.Images.Add(i10)
			iList.Images.Add(i11)
			iList.Images.Add(i12)
			iList.Images.Add(i13)
			iList.Images.Add(i14)
			iList.Images.Add(i15)
			iList.Images.Add(i16)


			mailList = New ImageList()
			mailList.Images.Add(m1)
			mailList.Images.Add(m2)
			mailList.Images.Add(m3)
			mailList.Images.Add(m4)
			mailList.Images.Add(m5)


			UtilIconList = New ImageList()
			UtilIconList.Images.Add(u1)
			UtilIconList.Images.Add(u2)
			UtilIconList.Images.Add(u3)
			UtilIconList.Images.Add(u4)

			hmenuList = New ImageList()
			hmenuList.Images.Add(h1)
			hmenuList.Images.Add(h2)
			hmenuList.Images.Add(h3)
			hmenuList.Images.Add(h4)
			hmenuList.Images.Add(h5)

			'HeaderPopMenuImageList
			For h As Integer = 0 To Me.headerParentBarItem.Items.Count - 1
				Me.headerParentBarItem.Items(h).ImageList = Me.hmenuList
			Next h
			Me.barItem_SortAscending.ImageIndex = 0
			Me.barItem_sortDescending.ImageIndex = 1
			Me.barItem_GroupByThisField.ImageIndex = 2
			Me.barItem_GroupByBox.ImageIndex = 3
			Me.barItem_FieldChooser.ImageIndex = 4

			'Flag Item
			Me.markcompleteFlagBarItem.ImageList = Me.fList
			Me.todayBarItem.ImageList = Me.fList
			Me.tomoBarItem.ImageList = Me.fList
			Me.thisweekFlagBarItem.ImageList = Me.fList
			Me.nextweekFlagBarItem.ImageList = Me.fList
			Me.nodateFlagBarItem.ImageList = Me.fList
			Me.customFlagBarItem.ImageList = Me.fList
			Me.addReminderBarItem.ImageList = Me.fList
			Me.markcompleteFlagBarItem.ImageList = Me.fList

			' Flag of caption
			Me.todayCaptionBarItem.ImageList = Me.fList
			Me.tomoCaptionBarItem.ImageList = Me.fList
			Me.thisweekfromCaptionBarItem.ImageList = Me.fList
			Me.nextweekCaptionBarItem.ImageList = Me.fList
			Me.nodateCaptionBarItem.ImageList = Me.fList
			Me.customCaptionBarItem.ImageList = Me.fList
			Me.addreminderCaptionBarItem.ImageList = Me.fList
			Me.markcompletefromCaptionBarItem.ImageList = Me.fList

			' Flag of Records
			Me.todayRecordBarItem.ImageList = Me.fList
			Me.tomoRecordBarItem.ImageList = Me.fList
			Me.thisweekRecordBarItem.ImageList = Me.fList
			Me.nextweekRecordBarItem.ImageList = Me.fList
			Me.nodateRecordBarItem.ImageList = Me.fList
			Me.customRecordBarItem.ImageList = Me.fList
			Me.addreminderRecordBarItem.ImageList = Me.fList
			Me.markcompleteRecordItem.ImageList = Me.fList

			' Default Flag
			Me.redAsDefaultBarItem.ImageList = Me.fList
			Me.blueAsDefaultBarItem.ImageList = Me.fList
			Me.yellowAsDefaultBarItem.ImageList = Me.fList
			Me.greenAsDefaultBarItem.ImageList = Me.fList
			Me.orangeAsDefaultBarItem.ImageList = Me.fList
			Me.purpleAsDefaultBarItem.ImageList = Me.fList


			' Default flag of Caption
			Me.todayCaptionBarItem.ImageList = Me.fList
			Me.tomoCaptionBarItem.ImageList = Me.fList
			Me.thisweekfromCaptionBarItem.ImageList = Me.fList
			Me.nextweekCaptionBarItem.ImageList = Me.fList
			Me.markcompletefromCaptionBarItem.ImageList = Me.fList
			Me.clearflagCaptionBarItem.ImageList = Me.fList

			' Default flag of Records
			Me.RedAsDefaultfromRecordBarItem.ImageList = Me.fList
			Me.BlueasDefaultfromRecordBarItem.ImageList = Me.fList
			Me.YellowasDefaultfromRecordBarItem.ImageList = Me.fList
			Me.GreenasDefaultfromRecordBarItem.ImageList = Me.fList
			Me.OrangeasDefaultfromRecordBarItem.ImageList = Me.fList
			Me.PurpleasDefaultfromRecordBarItem.ImageList = Me.fList

			' Caption Menu
			Me.PrintfromCaptionBarItem.ImageList = Me.UtilIconList
			Me.PrintfromCaptionBarItem.ImageIndex = 0
			Me.ForwardfromCaptionBarItem.ImageList = Me.mailList
			Me.ForwardfromCaptionBarItem.ImageIndex = 3
			Me.MarkAsReadfromCaptionBarItem.ImageList = Me.mailList
			Me.MarkAsReadfromCaptionBarItem.ImageIndex = 1
			Me.MarkAsUnreadfromCaptionBarItem.ImageList = Me.mailList
			Me.MarkAsUnreadfromCaptionBarItem.ImageIndex = 0
			Me.DeletefromCaptionBarItem.ImageList = Me.UtilIconList
			Me.DeletefromCaptionBarItem.ImageIndex = 1
			Me.MovetoFolderfromCaptionBarItem.ImageList = Me.UtilIconList
			Me.MovetoFolderfromCaptionBarItem.ImageIndex = 2

			' Record Menu
			Me.PrintfromRecordBarItem.ImageList = Me.UtilIconList
			Me.PrintfromRecordBarItem.ImageIndex = 0
			Me.ReplyfromRecordBarItem.ImageList = Me.mailList
			Me.ReplyfromRecordBarItem.ImageIndex = 2
			Me.ReplyToAllfromRecordBarItem.ImageList = Me.mailList
			Me.ReplyToAllfromRecordBarItem.ImageIndex = 4
			Me.ForwardfromRecordBarItem.ImageList = Me.mailList
			Me.ForwardfromRecordBarItem.ImageIndex = 3
			Me.MarkfromRecordBarItem.ImageList = Me.mailList
			Me.MarkfromRecordBarItem.ImageIndex = 0
			Me.CreateRulefromRecordBarItem.ImageList = Me.UtilIconList
			Me.CreateRulefromRecordBarItem.ImageIndex = 3
			Me.DeletefromRecordBarItem.ImageList = Me.UtilIconList
			Me.DeletefromRecordBarItem.ImageIndex = 1
			Me.MoveToFolderfromRecordBarItem.ImageList = Me.UtilIconList
			Me.MoveToFolderfromRecordBarItem.ImageIndex = 2
			'option

'			#Region "Settings"

			Me.gridGroupingControl1.ThemesEnabled = False
			Me.gridGroupingControl1.TableControl.VScrollPixel = True
			Me.gridGroupingControl1.GroupDropPanel.BackColor = Color.FromArgb(Form1.r, Form1.g, Form1.b)
			Me.gridGroupingControl1.GroupDropPanel.Height = 30
			Me.gridGroupingControl1.Splitter.BackColor = Color.FromArgb(Form1.r, Form1.g, Form1.b)
			Me.gridGroupingControl1.Splitter.Height = 1
			Me.gridGroupingControl1.Appearance.GroupCaptionCell.CellType = "Static"


			AddHandler gridGroupingControl1.GroupExpanded, AddressOf gridGroupingControl1_GroupExpanded
			AddHandler gridGroupingControl1.GroupCollapsed, AddressOf gridGroupingControl1_GroupCollapsed

			' Removing some unnecessary elements
			Me.gridGroupingControl1.TableOptions.ShowRowHeader = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.BorderMargins.Top = 12
			Me.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.CellType = "Image"
			Me.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"))
			Me.gridGroupingControl1.TableModel.Properties.DisplayVertLines = False
			' setting required settings
			Me.gridGroupingControl1.Appearance.GroupIndentCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableOptions.CaptionRowHeight = 34
			Me.gridGroupingControl1.TableOptions.ColumnHeaderRowHeight = 22
			Me.gridGroupingControl1.TableOptions.IndentWidth = 20
			Me.gridGroupingControl1.TableOptions.RecordRowHeight = 22
			Me.gridGroupingControl1.TableModel.TableStyle.Trimming = StringTrimming.EllipsisCharacter
			'this.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Bold = true;
			'this.gridGroupingControl1.Appearance.RecordFieldCell.Font.Facename = "Corbel";

			' selections
			Me.gridGroupingControl1.TableOptions.ListBoxSelectionCurrentCellOptions = GridListBoxSelectionCurrentCellOptions.None
			Me.gridGroupingControl1.TableModel.Options.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.HideAlways
			Me.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.Any
			Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One
			Me.gridGroupingControl1.TableModel.Options.AlphaBlendSelectionColor = SystemColors.InactiveCaptionText

			Me.gridGroupingControl1.TableDescriptor.Columns("Priority").Width = 12
			Me.gridGroupingControl1.TableDescriptor.Columns("mails").Width = 12
			Me.gridGroupingControl1.TableDescriptor.Columns("Attachment").Width = 12

			Me.CSVHeader.wire(Me)
'			#End Region

'			#Region "Unbound Fields"

			Dim [date] As New FieldDescriptor("date", "date", False, "")
			Me.gridGroupingControl1.TableDescriptor.UnboundFields.Add([date])
			Dim cddate As New GridColumnDescriptor([date])
			cddate.HeaderText = "Date"
			Me.gridGroupingControl1.TableDescriptor.Columns.Add(cddate)
			Me.gridGroupingControl1.TableDescriptor.Columns("date").Width = 0

			Dim customSize As New FieldDescriptor("customSize", "customSize", False, "")
			Me.gridGroupingControl1.TableDescriptor.UnboundFields.Add(customSize)
			Dim cdcustomSize As New GridColumnDescriptor(customSize)
			cdcustomSize.HeaderText = "Size"
			Me.gridGroupingControl1.TableDescriptor.Columns.Add(cdcustomSize)
			Me.gridGroupingControl1.TableDescriptor.Columns("customSize").Width = 0

			Dim DummyCol As New FieldDescriptor("DummyCol", "DummyCol", True, "")
			Me.gridGroupingControl1.TableDescriptor.UnboundFields.Add(DummyCol)
			Dim cdDummyCol As New GridColumnDescriptor(DummyCol)
			cdDummyCol.HeaderText = ""

			' mails column are in the left side
			Dim src As Integer = Me.gridGroupingControl1.TableDescriptor.Columns.IndexOf("mails")
			Me.gridGroupingControl1.TableDescriptor.Columns.Move(src, 0)

'			#End Region

'			#Region "event subscribed"

			AddHandler gridGroupingControl1.TableModel.QueryColWidth, AddressOf TableModel_QueryColWidth
			AddHandler gridGroupingControl1.TableModel.ColWidthsChanging, AddressOf TableModel_ColWidthsChanging
			AddHandler gridGroupingControl1.TableModel.ColWidthsChanged, AddressOf TableModel_ColWidthsChanged
			AddHandler gridGroupingControl1.SizeChanged, AddressOf gridGroupingControl1_SizeChanged
			AddHandler gridGroupingControl1.QueryCellStyleInfo, AddressOf gridGroupingControl1_QueryCellStyleInfo
			AddHandler gridGroupingControl1.TableControlCellClick, AddressOf gridGroupingControl1_TableControlCellClick
			AddHandler gridGroupingControl1.QueryValue, AddressOf gridGroupingControl1_QueryValue
			AddHandler gridGroupingControl1.TableModel.QueryCoveredRange, AddressOf TableModel_QueryCoveredRange
			AddHandler gridGroupingControl1.GridGroupDropArea.Model.QueryColWidth, AddressOf Model_QueryColWidth
			AddHandler gridGroupingControl1.TableControlCurrentCellActivating, AddressOf gridGroupingControl1_TableControlCurrentCellActivating
			AddHandler gridGroupingControl1.TableDescriptor.GroupedColumns.Changed, AddressOf GroupedColumns_Changed
			AddHandler gridGroupingControl1.TableControlKeyDown, AddressOf gridGroupingControl1_TableControlKeyDown
			AddHandler gridGroupingControl1.Resize, AddressOf gridGroupingControl1_Resize
			AddHandler gridGroupingControl1.TableControl.PrepareViewStyleInfo, AddressOf TableControl_PrepareViewStyleInfo
			AddHandler Changed, AddressOf GroupingPanel_Changed
			AddHandler ShowViewChanged, AddressOf GroupingPanel_ShowViewChanged
			AddHandler gridGroupingControl1.TableControl.Model.SelectionChanging, AddressOf Model_SelectionChanging
			'this.gridGroupingControl1.GridGroupDropArea.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(GridGroupDropArea_PrepareViewStyleInfo);
			AddHandler gridGroupingControl1.TableControlCellDrawn, AddressOf gridGroupingControl1_TableControlCellDrawn

'			#End Region

			' Assuming when the Grouping Grid is resized less than the width of 400, column set view is good 
			CreateColumnSetView(numberOfLayers_Renamed)
			Me.gridGroupingControl1.TableControl.HScrollBehavior = GridScrollbarMode.Disabled
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("date")
			Me.barItem_Date.Checked = True
			Me.gridGroupingControl1.TableDescriptor.Columns("Size").AllowGroupByColumn = False
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Blue
		End Sub

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

		#End Region

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(GroupingPanel))
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.groupingConfig1 = New Syncfusion.Grouping.GroupingConfig()
			Me.normalViewPopUpMenu = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
			Me.headerParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.parentBarItem_ArrangeBy = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem_Date = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_Conversation = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_From = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_To = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_Folder = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_Size = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_Subject = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_Type = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_Flag = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_Attachments = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_EmailAccounts = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_Importance = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_Categories = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_Custom = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_ShowInGroups = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_SortAscending = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_sortDescending = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_GroupByThisField = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_GroupByBox = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_RemoveThisColumn = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_FieldChooser = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_BestFit = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_FormatColumns = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_CustomizeCurrentView = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.headerPopUpMenu = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
			Me.flagPopupMenu = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
			Me.flagMenusParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.todayBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.tomoBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.thisweekFlagBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.nextweekFlagBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.nodateFlagBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.customFlagBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.addReminderBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.markcompleteFlagBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.clearflagParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.redAsDefaultBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.blueAsDefaultBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.yellowAsDefaultBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.greenAsDefaultBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.orangeAsDefaultBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.purpleAsDefaultBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.setquickclickBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.CaptionPopupMenu = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
			Me.parentBarItemForCaption = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.collapseAllGroupsBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.ExpandAllGroupsBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.OpenItemsBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.PrintfromCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.ForwardfromCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.FollowUpParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.todayCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.tomoCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.thisweekfromCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.nextweekCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.nodateCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.customCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.addreminderCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.markcompletefromCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.clearflagCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.setBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.categoriesBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.MarkAsReadfromCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.MarkAsUnreadfromCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.DeletefromCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.MovetoFolderfromCaptionBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.RecordPopupMenu = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
			Me.RecordsParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.OpenfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.PrintfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.ReplyfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.ReplyToAllfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.ForwardfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.RecordFollowUpParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.todayRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.tomoRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.thisweekRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.nextweekRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.nodateRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.customRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.addreminderRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.markcompleteRecordItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.ClearFlagfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.setRecordBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.MarkfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.CategoriesfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.FindAllfromRecordparentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.RelatedMessagesBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.MessagesfromsenderBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.CreateRulefromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.JunkEmailsfromRecordParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.AddSendertoBlockedSendersListBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.AddSendertoSafeSendersListBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.AddSendersDomaintoSafeSendersListBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.AddRecipienttoSafeRecipientsListBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.MarkasNotJunkBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.JunkEmailOptionsBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.DeletefromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.MoveToFolderfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.OptionsfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.RedAsDefaultfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.BlueasDefaultfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.YellowasDefaultfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.GreenasDefaultfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.OrangeasDefaultfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.PurpleasDefaultfromRecordBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.categoryPopUpMenu = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
			Me.categoryParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.clearallcategBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.categsearchBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.redcategBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.blueBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.greenBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.orangeBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.purpleBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.yellowBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.allcategBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.setcategBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.BackColor = System.Drawing.Color.White
			Me.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridGroupingControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.Size = New System.Drawing.Size(688, 353)
			Me.gridGroupingControl1.TabIndex = 0
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			' 
			' normalViewPopUpMenu
			' 
			Me.normalViewPopUpMenu.ParentBarItem = Me.headerParentBarItem
			' 
			' headerParentBarItem
			' 
			Me.headerParentBarItem.CustomTextFont = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.headerParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem_ArrangeBy, Me.barItem_SortAscending, Me.barItem_sortDescending, Me.barItem_GroupByThisField, Me.barItem_GroupByBox, Me.barItem_RemoveThisColumn, Me.barItem_FieldChooser, Me.barItem_BestFit, Me.barItem_FormatColumns, Me.barItem_CustomizeCurrentView})
			Me.headerParentBarItem.SeparatorIndices.AddRange(New Integer() { 1, 3, 5, 9})
			Me.headerParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
			' 
			' parentBarItem_ArrangeBy
			' 
			Me.parentBarItem_ArrangeBy.ID = "ArrangeBy"
			Me.parentBarItem_ArrangeBy.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem_Date, Me.barItem_Conversation, Me.barItem_From, Me.barItem_To, Me.barItem_Folder, Me.barItem_Size, Me.barItem_Subject, Me.barItem_Type, Me.barItem_Flag, Me.barItem_Attachments, Me.barItem_EmailAccounts, Me.barItem_Importance, Me.barItem_Categories, Me.barItem_Custom, Me.barItem_ShowInGroups})
			Me.parentBarItem_ArrangeBy.SeparatorIndices.AddRange(New Integer() { 13, 14})
			Me.parentBarItem_ArrangeBy.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
			Me.parentBarItem_ArrangeBy.Text = "ArrangeBy"
			' 
			' barItem_Date
			' 
			Me.barItem_Date.Checked = True
			Me.barItem_Date.ID = "Date"
			Me.barItem_Date.Text = "Date"
'			Me.barItem_Date.Click += New System.EventHandler(Me.barItem_Date_Click)
			' 
			' barItem_Conversation
			' 
			Me.barItem_Conversation.ID = "Conversation"
			Me.barItem_Conversation.ShortcutText = "C"
			Me.barItem_Conversation.Text = "Conversation"
'			Me.barItem_Conversation.Click += New System.EventHandler(Me.barItem_Conversation_Click)
			' 
			' barItem_From
			' 
			Me.barItem_From.ID = "From"
			Me.barItem_From.Text = "From"
'			Me.barItem_From.Click += New System.EventHandler(Me.barItem_From_Click)
			' 
			' barItem_To
			' 
			Me.barItem_To.ID = "Received"
			Me.barItem_To.ShortcutText = "T"
			Me.barItem_To.Text = "To"
			' 
			' barItem_Folder
			' 
			Me.barItem_Folder.Enabled = False
			Me.barItem_Folder.ID = "Folder"
			Me.barItem_Folder.ShortcutText = "l"
			Me.barItem_Folder.Text = "Folder"
			' 
			' barItem_Size
			' 
			Me.barItem_Size.ID = "Size"
			Me.barItem_Size.Text = "Size"
'			Me.barItem_Size.Click += New System.EventHandler(Me.barItem_Size_Click)
			' 
			' barItem_Subject
			' 
			Me.barItem_Subject.ID = "Subject"
			Me.barItem_Subject.Text = "Subject"
'			Me.barItem_Subject.Click += New System.EventHandler(Me.barItem_Subject_Click)
			' 
			' barItem_Type
			' 
			Me.barItem_Type.ID = "Type"
			Me.barItem_Type.ShortcutText = "y"
			Me.barItem_Type.Text = "Type"
'			Me.barItem_Type.Click += New System.EventHandler(Me.barItem_Type_Click)
			' 
			' barItem_Flag
			' 
			Me.barItem_Flag.ID = "Flag"
			Me.barItem_Flag.ShortcutText = "g"
			Me.barItem_Flag.Text = "Flag"
'			Me.barItem_Flag.Click += New System.EventHandler(Me.barItem_Flag_Click)
			' 
			' barItem_Attachments
			' 
			Me.barItem_Attachments.ID = "Attachments"
			Me.barItem_Attachments.ShortcutText = "A"
			Me.barItem_Attachments.ShowMnemonicUnderlinesAlways = True
			Me.barItem_Attachments.Text = "&Attachments"
'			Me.barItem_Attachments.Click += New System.EventHandler(Me.barItem_Attachments_Click)
			' 
			' barItem_EmailAccounts
			' 
			Me.barItem_EmailAccounts.ID = "E-mail Accounts"
			Me.barItem_EmailAccounts.ShortcutText = "o"
			Me.barItem_EmailAccounts.Text = "E-mail Accounts"
'			Me.barItem_EmailAccounts.Click += New System.EventHandler(Me.barItem_EmailAccounts_Click)
			' 
			' barItem_Importance
			' 
			Me.barItem_Importance.ID = "Importance"
			Me.barItem_Importance.ShortcutText = "I"
			Me.barItem_Importance.Text = "Importance"
'			Me.barItem_Importance.Click += New System.EventHandler(Me.barItem_Importance_Click)
			' 
			' barItem_Categories
			' 
			Me.barItem_Categories.ID = "Categories"
			Me.barItem_Categories.ShortcutText = "e"
			Me.barItem_Categories.Text = "Categories"
'			Me.barItem_Categories.Click += New System.EventHandler(Me.barItem_Categories_Click)
			' 
			' barItem_Custom
			' 
			Me.barItem_Custom.ID = "Custom"
			Me.barItem_Custom.ShortcutText = "m"
			Me.barItem_Custom.Text = "Custom"
			' 
			' barItem_ShowInGroups
			' 
			Me.barItem_ShowInGroups.Checked = True
			Me.barItem_ShowInGroups.ID = "Show in Groups"
			Me.barItem_ShowInGroups.ShortcutText = "w"
			Me.barItem_ShowInGroups.Text = "Show in Groups"
'			Me.barItem_ShowInGroups.Click += New System.EventHandler(Me.barItem_ShowInGroups_Click)
			' 
			' barItem_SortAscending
			' 
			Me.barItem_SortAscending.ID = "Sort Ascending"
			Me.barItem_SortAscending.Text = "Sort Ascending"
'			Me.barItem_SortAscending.Click += New System.EventHandler(Me.barItem_SortAscending_Click)
			' 
			' barItem_sortDescending
			' 
			Me.barItem_sortDescending.ID = "Sort Descending"
			Me.barItem_sortDescending.Text = "Sort Descending"
'			Me.barItem_sortDescending.Click += New System.EventHandler(Me.barItem_sortDescending_Click)
			' 
			' barItem_GroupByThisField
			' 
			Me.barItem_GroupByThisField.ID = "Group By this Field"
			Me.barItem_GroupByThisField.ShortcutText = "G"
			Me.barItem_GroupByThisField.Text = "Group By this Field"
'			Me.barItem_GroupByThisField.Click += New System.EventHandler(Me.barItem_GroupByThisField_Click)
			' 
			' barItem_GroupByBox
			' 
			Me.barItem_GroupByBox.ID = "Show in Groups"
			Me.barItem_GroupByBox.ShortcutText = "B"
			Me.barItem_GroupByBox.Text = "Group By Box"
'			Me.barItem_GroupByBox.Click += New System.EventHandler(Me.barItem_GroupByBox_Click)
			' 
			' barItem_RemoveThisColumn
			' 
			Me.barItem_RemoveThisColumn.ID = "Remove This Column"
			Me.barItem_RemoveThisColumn.ShortcutText = "R"
			Me.barItem_RemoveThisColumn.Text = "Remove This Column"
'			Me.barItem_RemoveThisColumn.Click += New System.EventHandler(Me.barItem_RemoveThisColumn_Click)
			' 
			' barItem_FieldChooser
			' 
			Me.barItem_FieldChooser.ID = "Field Chooser"
			Me.barItem_FieldChooser.ShortcutText = "C"
			Me.barItem_FieldChooser.Text = "Field Chooser"
'			Me.barItem_FieldChooser.Click += New System.EventHandler(Me.barItem_FieldChooser_Click)
			' 
			' barItem_BestFit
			' 
			Me.barItem_BestFit.Enabled = False
			Me.barItem_BestFit.ID = "Best Fit"
			Me.barItem_BestFit.ShortcutText = "F"
			Me.barItem_BestFit.Text = "Best Fit"
			' 
			' barItem_FormatColumns
			' 
			Me.barItem_FormatColumns.Enabled = False
			Me.barItem_FormatColumns.ID = "Format Columns..."
			Me.barItem_FormatColumns.ShortcutText = "m"
			Me.barItem_FormatColumns.Text = "Format Columns..."
			' 
			' barItem_CustomizeCurrentView
			' 
			Me.barItem_CustomizeCurrentView.ID = "Customize Current View"
			Me.barItem_CustomizeCurrentView.Text = "Customize Current View"
			Me.barItem_CustomizeCurrentView.Tooltip = "C"
'			Me.barItem_CustomizeCurrentView.Click += New System.EventHandler(Me.barItem_CustomizeCurrentView_Click)
			' 
			' headerPopUpMenu
			' 
			Me.headerPopUpMenu.ParentBarItem = Me.headerParentBarItem
			' 
			' flagPopupMenu
			' 
			Me.flagPopupMenu.ParentBarItem = Me.flagMenusParentBarItem
			' 
			' flagMenusParentBarItem
			' 
			Me.flagMenusParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.todayBarItem, Me.tomoBarItem, Me.thisweekFlagBarItem, Me.nextweekFlagBarItem, Me.nodateFlagBarItem, Me.customFlagBarItem, Me.addReminderBarItem, Me.markcompleteFlagBarItem, Me.clearflagParentBarItem, Me.setquickclickBarItem})
			Me.flagMenusParentBarItem.SeparatorIndices.AddRange(New Integer() { 6, 9})
			Me.flagMenusParentBarItem.ShowMnemonicUnderlinesAlways = True
			Me.flagMenusParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
			' 
			' todayBarItem
			' 
			Me.todayBarItem.ID = "&Red Flag"
			Me.todayBarItem.ImageIndex = 1
			Me.todayBarItem.ShowMnemonicUnderlinesAlways = True
			Me.todayBarItem.Text = "&Today"
'			Me.todayBarItem.Click += New System.EventHandler(Me.redFlagBarItem_Click)
			' 
			' tomoBarItem
			' 
			Me.tomoBarItem.ID = "&Blue Flag"
			Me.tomoBarItem.ImageIndex = 2
			Me.tomoBarItem.ShowMnemonicUnderlinesAlways = True
			Me.tomoBarItem.Text = "T&ommorrow"
'			Me.tomoBarItem.Click += New System.EventHandler(Me.blueFlagBarItem_Click)
			' 
			' thisweekFlagBarItem
			' 
			Me.thisweekFlagBarItem.ID = "Yellow Flag"
			Me.thisweekFlagBarItem.ImageIndex = 3
			Me.thisweekFlagBarItem.ShowMnemonicUnderlinesAlways = True
			Me.thisweekFlagBarItem.Text = "This &Week"
'			Me.thisweekFlagBarItem.Click += New System.EventHandler(Me.yellowFlagBarItem_Click)
			' 
			' nextweekFlagBarItem
			' 
			Me.nextweekFlagBarItem.ID = "&Green Flag"
			Me.nextweekFlagBarItem.ImageIndex = 4
			Me.nextweekFlagBarItem.ShowMnemonicUnderlinesAlways = True
			Me.nextweekFlagBarItem.Text = "&Next Week"
'			Me.nextweekFlagBarItem.Click += New System.EventHandler(Me.greenFlagBarItem_Click)
			' 
			' nodateFlagBarItem
			' 
			Me.nodateFlagBarItem.ID = "&Orange Flag"
			Me.nodateFlagBarItem.ImageIndex = 5
			Me.nodateFlagBarItem.ShowMnemonicUnderlinesAlways = True
			Me.nodateFlagBarItem.Text = "No D&ate"
'			Me.nodateFlagBarItem.Click += New System.EventHandler(Me.orangeFlagBarItem_Click)
			' 
			' customFlagBarItem
			' 
			Me.customFlagBarItem.ID = "P&urple Flag"
			Me.customFlagBarItem.ImageIndex = 6
			Me.customFlagBarItem.ShowMnemonicUnderlinesAlways = True
			Me.customFlagBarItem.Text = "&Custom..."
'			Me.customFlagBarItem.Click += New System.EventHandler(Me.purpleFlagBarItem_Click)
			' 
			' addReminderBarItem
			' 
			Me.addReminderBarItem.ID = "&Add Reminder"
			Me.addReminderBarItem.ImageIndex = 7
			Me.addReminderBarItem.ShowMnemonicUnderlinesAlways = True
			Me.addReminderBarItem.Text = "Add &Reminder..."
'			Me.addReminderBarItem.Click += New System.EventHandler(Me.addReminderBarItem_Click)
			' 
			' markcompleteFlagBarItem
			' 
			Me.markcompleteFlagBarItem.ID = "Clear Flag"
			Me.markcompleteFlagBarItem.ImageIndex = 8
			Me.markcompleteFlagBarItem.ShowMnemonicUnderlinesAlways = True
			Me.markcompleteFlagBarItem.Text = "&Mark Complete"
'			Me.markcompleteFlagBarItem.Click += New System.EventHandler(Me.clearFlagBarItem_Click)
			' 
			' clearflagParentBarItem
			' 
			Me.clearflagParentBarItem.Enabled = False
			Me.clearflagParentBarItem.ID = "&Set Default Flag"
			Me.clearflagParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.redAsDefaultBarItem, Me.blueAsDefaultBarItem, Me.yellowAsDefaultBarItem, Me.greenAsDefaultBarItem, Me.orangeAsDefaultBarItem, Me.purpleAsDefaultBarItem})
			Me.clearflagParentBarItem.ShowMnemonicUnderlinesAlways = True
			Me.clearflagParentBarItem.Text = "Cl&ear Flag"
			' 
			' redAsDefaultBarItem
			' 
			Me.redAsDefaultBarItem.ID = "&Red Flag as Default"
			Me.redAsDefaultBarItem.ImageIndex = 1
			Me.redAsDefaultBarItem.ShowMnemonicUnderlinesAlways = True
			Me.redAsDefaultBarItem.Text = "&Red Flag as Default"
'			Me.redAsDefaultBarItem.Click += New System.EventHandler(Me.redAsDefaultBarItem_Click)
			' 
			' blueAsDefaultBarItem
			' 
			Me.blueAsDefaultBarItem.ID = "&Blue Flag as Default"
			Me.blueAsDefaultBarItem.ImageIndex = 2
			Me.blueAsDefaultBarItem.ShowMnemonicUnderlinesAlways = True
			Me.blueAsDefaultBarItem.Text = "&Blue Flag as Default"
'			Me.blueAsDefaultBarItem.Click += New System.EventHandler(Me.blueAsDefaultBarItem_Click)
			' 
			' yellowAsDefaultBarItem
			' 
			Me.yellowAsDefaultBarItem.ID = "&Yellow Flag as Default"
			Me.yellowAsDefaultBarItem.ImageIndex = 3
			Me.yellowAsDefaultBarItem.ShowMnemonicUnderlinesAlways = True
			Me.yellowAsDefaultBarItem.Text = "&Yellow Flag as Default"
'			Me.yellowAsDefaultBarItem.Click += New System.EventHandler(Me.yellowAsDefaultBarItem_Click)
			' 
			' greenAsDefaultBarItem
			' 
			Me.greenAsDefaultBarItem.ID = "&Green Flag as Default"
			Me.greenAsDefaultBarItem.ImageIndex = 4
			Me.greenAsDefaultBarItem.ShowMnemonicUnderlinesAlways = True
			Me.greenAsDefaultBarItem.Text = "&Green Flag as Default"
'			Me.greenAsDefaultBarItem.Click += New System.EventHandler(Me.greenAsDefaultBarItem_Click)
			' 
			' orangeAsDefaultBarItem
			' 
			Me.orangeAsDefaultBarItem.ID = "&Orange Flag as Default"
			Me.orangeAsDefaultBarItem.ImageIndex = 5
			Me.orangeAsDefaultBarItem.ShowMnemonicUnderlinesAlways = True
			Me.orangeAsDefaultBarItem.Text = "&Orange Flag as Default"
'			Me.orangeAsDefaultBarItem.Click += New System.EventHandler(Me.orangeAsDefaultBarItem_Click)
			' 
			' purpleAsDefaultBarItem
			' 
			Me.purpleAsDefaultBarItem.ID = "P&urple Flag as Default"
			Me.purpleAsDefaultBarItem.ImageIndex = 6
			Me.purpleAsDefaultBarItem.ShowMnemonicUnderlinesAlways = True
			Me.purpleAsDefaultBarItem.Text = "P&urple Flag as Default"
'			Me.purpleAsDefaultBarItem.Click += New System.EventHandler(Me.purpleAsDefaultBarItem_Click)
			' 
			' setquickclickBarItem
			' 
			Me.setquickclickBarItem.ID = "Flag Complete"
			Me.setquickclickBarItem.ImageIndex = 7
			Me.setquickclickBarItem.ShowMnemonicUnderlinesAlways = True
			Me.setquickclickBarItem.Text = "Set &Quick Click..."
'			Me.setquickclickBarItem.Click += New System.EventHandler(Me.flagCompleteBarItem_Click)
			' 
			' CaptionPopupMenu
			' 
			Me.CaptionPopupMenu.ParentBarItem = Me.parentBarItemForCaption
			' 
			' parentBarItemForCaption
			' 
			Me.parentBarItemForCaption.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.collapseAllGroupsBarItem, Me.ExpandAllGroupsBarItem, Me.OpenItemsBarItem, Me.PrintfromCaptionBarItem, Me.ForwardfromCaptionBarItem, Me.FollowUpParentBarItem, Me.categoriesBarItem, Me.MarkAsReadfromCaptionBarItem, Me.MarkAsUnreadfromCaptionBarItem, Me.DeletefromCaptionBarItem, Me.MovetoFolderfromCaptionBarItem})
			Me.parentBarItemForCaption.SeparatorIndices.AddRange(New Integer() { 2, 4, 5, 9})
			Me.parentBarItemForCaption.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
			' 
			' collapseAllGroupsBarItem
			' 
			Me.collapseAllGroupsBarItem.ID = "Co&llapse All Groups"
			Me.collapseAllGroupsBarItem.ShowMnemonicUnderlinesAlways = True
			Me.collapseAllGroupsBarItem.Text = "Co&llapse All Groups"
'			Me.collapseAllGroupsBarItem.Click += New System.EventHandler(Me.collapseAllGroupsBarItem_Click)
			' 
			' ExpandAllGroupsBarItem
			' 
			Me.ExpandAllGroupsBarItem.ID = "&Expand All Groups"
			Me.ExpandAllGroupsBarItem.ShowMnemonicUnderlinesAlways = True
			Me.ExpandAllGroupsBarItem.Text = "&Expand All Groups"
'			Me.ExpandAllGroupsBarItem.Click += New System.EventHandler(Me.ExpandAllGroupsBarItem_Click)
			' 
			' OpenItemsBarItem
			' 
			Me.OpenItemsBarItem.ID = "&Open Items"
			Me.OpenItemsBarItem.ShowMnemonicUnderlinesAlways = True
			Me.OpenItemsBarItem.Text = "&Open Items"
			' 
			' PrintfromCaptionBarItem
			' 
			Me.PrintfromCaptionBarItem.ID = "&Print"
			Me.PrintfromCaptionBarItem.ShowMnemonicUnderlinesAlways = True
			Me.PrintfromCaptionBarItem.Text = "&Print"
			' 
			' ForwardfromCaptionBarItem
			' 
			Me.ForwardfromCaptionBarItem.Enabled = False
			Me.ForwardfromCaptionBarItem.ID = "&Forward Items"
			Me.ForwardfromCaptionBarItem.ShowMnemonicUnderlinesAlways = True
			Me.ForwardfromCaptionBarItem.Text = "&Forward Items"
			' 
			' FollowUpParentBarItem
			' 
			Me.FollowUpParentBarItem.ID = "Follow &Up"
			Me.FollowUpParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.todayCaptionBarItem, Me.tomoCaptionBarItem, Me.thisweekfromCaptionBarItem, Me.nextweekCaptionBarItem, Me.nodateCaptionBarItem, Me.customCaptionBarItem, Me.addreminderCaptionBarItem, Me.markcompletefromCaptionBarItem, Me.clearflagCaptionBarItem, Me.setBarItem})
			Me.FollowUpParentBarItem.SeparatorIndices.AddRange(New Integer() { 6, 9})
			Me.FollowUpParentBarItem.ShowMnemonicUnderlinesAlways = True
			Me.FollowUpParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
			Me.FollowUpParentBarItem.Text = "Follow &Up"
			' 
			' todayCaptionBarItem
			' 
			Me.todayCaptionBarItem.ID = "&Red Flag"
			Me.todayCaptionBarItem.ImageIndex = 1
			Me.todayCaptionBarItem.ShowMnemonicUnderlinesAlways = True
			Me.todayCaptionBarItem.Text = "&Today"
'			Me.todayCaptionBarItem.Click += New System.EventHandler(Me.RedfromCaptionBarItem_Click)
			' 
			' tomoCaptionBarItem
			' 
			Me.tomoCaptionBarItem.ID = "&Blue Flag"
			Me.tomoCaptionBarItem.ImageIndex = 2
			Me.tomoCaptionBarItem.ShowMnemonicUnderlinesAlways = True
			Me.tomoCaptionBarItem.Text = "T&ommorrow"
'			Me.tomoCaptionBarItem.Click += New System.EventHandler(Me.BluefromCaptionBarItem_Click)
			' 
			' thisweekfromCaptionBarItem
			' 
			Me.thisweekfromCaptionBarItem.ID = "&Yellow Flag"
			Me.thisweekfromCaptionBarItem.ImageIndex = 3
			Me.thisweekfromCaptionBarItem.ShowMnemonicUnderlinesAlways = True
			Me.thisweekfromCaptionBarItem.Text = "This &Week"
'			Me.thisweekfromCaptionBarItem.Click += New System.EventHandler(Me.YellowfromCaptionBarItem_Click)
			' 
			' nextweekCaptionBarItem
			' 
			Me.nextweekCaptionBarItem.ID = "&Green Flag"
			Me.nextweekCaptionBarItem.ImageIndex = 4
			Me.nextweekCaptionBarItem.ShowMnemonicUnderlinesAlways = True
			Me.nextweekCaptionBarItem.Text = "&Next Week"
'			Me.nextweekCaptionBarItem.Click += New System.EventHandler(Me.GreenfromCaptionBarItem_Click)
			' 
			' nodateCaptionBarItem
			' 
			Me.nodateCaptionBarItem.ID = "&Orange Flag"
			Me.nodateCaptionBarItem.ImageIndex = 5
			Me.nodateCaptionBarItem.ShowMnemonicUnderlinesAlways = True
			Me.nodateCaptionBarItem.Text = "No D&ate"
'			Me.nodateCaptionBarItem.Click += New System.EventHandler(Me.OrangefromCaptionBarItem_Click)
			' 
			' customCaptionBarItem
			' 
			Me.customCaptionBarItem.ID = "P&urple Flag"
			Me.customCaptionBarItem.ImageIndex = 6
			Me.customCaptionBarItem.ShowMnemonicUnderlinesAlways = True
			Me.customCaptionBarItem.Text = "&Custom..."
'			Me.customCaptionBarItem.Click += New System.EventHandler(Me.PurplefromCaptionBarItem_Click)
			' 
			' addreminderCaptionBarItem
			' 
			Me.addreminderCaptionBarItem.ID = "Flag Complete"
			Me.addreminderCaptionBarItem.ImageIndex = 7
			Me.addreminderCaptionBarItem.Text = "Add &Reminder..."
'			Me.addreminderCaptionBarItem.Click += New System.EventHandler(Me.FlagCompletefromCaptionBarItem_Click)
			' 
			' markcompletefromCaptionBarItem
			' 
			Me.markcompletefromCaptionBarItem.ID = "&Clear Flag"
			Me.markcompletefromCaptionBarItem.ImageIndex = 8
			Me.markcompletefromCaptionBarItem.ShowMnemonicUnderlinesAlways = True
			Me.markcompletefromCaptionBarItem.Text = "&Mark Complete"
'			Me.markcompletefromCaptionBarItem.Click += New System.EventHandler(Me.ClearFlagfromCaptionBarItem_Click)
			' 
			' clearflagCaptionBarItem
			' 
			Me.clearflagCaptionBarItem.ID = "Cl&ear Flag"
			Me.clearflagCaptionBarItem.Text = "Cl&ear Flag"
			' 
			' setBarItem
			' 
			Me.setBarItem.ID = "Set &Quick Click..."
			Me.setBarItem.Text = "Set &Quick Click..."
			' 
			' categoriesBarItem
			' 
			Me.categoriesBarItem.ID = "Catego&ries..."
			Me.categoriesBarItem.ShowMnemonicUnderlinesAlways = True
			Me.categoriesBarItem.Text = "Catego&ries..."
			' 
			' MarkAsReadfromCaptionBarItem
			' 
			Me.MarkAsReadfromCaptionBarItem.ID = "Mar&k as Read"
			Me.MarkAsReadfromCaptionBarItem.ShowMnemonicUnderlinesAlways = True
			Me.MarkAsReadfromCaptionBarItem.Text = "Mar&k as Read"
'			Me.MarkAsReadfromCaptionBarItem.Click += New System.EventHandler(Me.MarkAsReadfromCaptionBarItem_Click)
			' 
			' MarkAsUnreadfromCaptionBarItem
			' 
			Me.MarkAsUnreadfromCaptionBarItem.ID = "Mark As U&nread"
			Me.MarkAsUnreadfromCaptionBarItem.ShowMnemonicUnderlinesAlways = True
			Me.MarkAsUnreadfromCaptionBarItem.Text = "Mark As U&nread"
'			Me.MarkAsUnreadfromCaptionBarItem.Click += New System.EventHandler(Me.MarkAsUnreadfromCaptionBarItem_Click)
			' 
			' DeletefromCaptionBarItem
			' 
			Me.DeletefromCaptionBarItem.ID = "D&elete"
			Me.DeletefromCaptionBarItem.ShowMnemonicUnderlinesAlways = True
			Me.DeletefromCaptionBarItem.Text = "D&elete"
			' 
			' MovetoFolderfromCaptionBarItem
			' 
			Me.MovetoFolderfromCaptionBarItem.ID = "&Move to Folder"
			Me.MovetoFolderfromCaptionBarItem.ShowMnemonicUnderlinesAlways = True
			Me.MovetoFolderfromCaptionBarItem.Text = "&Move to Folder"
			' 
			' RecordPopupMenu
			' 
			Me.RecordPopupMenu.ParentBarItem = Me.RecordsParentBarItem
			' 
			' RecordsParentBarItem
			' 
			Me.RecordsParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.OpenfromRecordBarItem, Me.PrintfromRecordBarItem, Me.ReplyfromRecordBarItem, Me.ReplyToAllfromRecordBarItem, Me.ForwardfromRecordBarItem, Me.RecordFollowUpParentBarItem, Me.MarkfromRecordBarItem, Me.CategoriesfromRecordBarItem, Me.FindAllfromRecordparentBarItem, Me.CreateRulefromRecordBarItem, Me.JunkEmailsfromRecordParentBarItem, Me.DeletefromRecordBarItem, Me.MoveToFolderfromRecordBarItem, Me.OptionsfromRecordBarItem})
			Me.RecordsParentBarItem.SeparatorIndices.AddRange(New Integer() { 2, 5, 8, 11, 13})
			Me.RecordsParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
			' 
			' OpenfromRecordBarItem
			' 
			Me.OpenfromRecordBarItem.ID = "&Open"
			Me.OpenfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.OpenfromRecordBarItem.Text = "&Open"
			' 
			' PrintfromRecordBarItem
			' 
			Me.PrintfromRecordBarItem.ID = "&Print"
			Me.PrintfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.PrintfromRecordBarItem.Text = "&Print"
			' 
			' ReplyfromRecordBarItem
			' 
			Me.ReplyfromRecordBarItem.ID = "&Reply"
			Me.ReplyfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.ReplyfromRecordBarItem.Text = "&Reply"
			' 
			' ReplyToAllfromRecordBarItem
			' 
			Me.ReplyToAllfromRecordBarItem.ID = "Reply to &All"
			Me.ReplyToAllfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.ReplyToAllfromRecordBarItem.Text = "Reply to &All"
			' 
			' ForwardfromRecordBarItem
			' 
			Me.ForwardfromRecordBarItem.ID = "For&ward"
			Me.ForwardfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.ForwardfromRecordBarItem.Text = "For&ward"
			' 
			' RecordFollowUpParentBarItem
			' 
			Me.RecordFollowUpParentBarItem.ID = "Follow &Up"
			Me.RecordFollowUpParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.todayRecordBarItem, Me.tomoRecordBarItem, Me.thisweekRecordBarItem, Me.nextweekRecordBarItem, Me.nodateRecordBarItem, Me.customRecordBarItem, Me.addreminderRecordBarItem, Me.markcompleteRecordItem, Me.ClearFlagfromRecordBarItem, Me.setRecordBarItem1})
			Me.RecordFollowUpParentBarItem.SeparatorIndices.AddRange(New Integer() { 6, 9})
			Me.RecordFollowUpParentBarItem.ShowMnemonicUnderlinesAlways = True
			Me.RecordFollowUpParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
			Me.RecordFollowUpParentBarItem.Text = "Follow &Up"
			' 
			' todayRecordBarItem
			' 
			Me.todayRecordBarItem.ID = "&Red Flag"
			Me.todayRecordBarItem.ImageIndex = 1
			Me.todayRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.todayRecordBarItem.Text = "&Today"
'			Me.todayRecordBarItem.Click += New System.EventHandler(Me.redFlagBarItem_Click)
			' 
			' tomoRecordBarItem
			' 
			Me.tomoRecordBarItem.ID = "&Blue Flag"
			Me.tomoRecordBarItem.ImageIndex = 2
			Me.tomoRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.tomoRecordBarItem.Text = "T&ommorrow"
'			Me.tomoRecordBarItem.Click += New System.EventHandler(Me.blueFlagBarItem_Click)
			' 
			' thisweekRecordBarItem
			' 
			Me.thisweekRecordBarItem.ID = "&Yellow Flag"
			Me.thisweekRecordBarItem.ImageIndex = 3
			Me.thisweekRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.thisweekRecordBarItem.Text = "This &Week"
'			Me.thisweekRecordBarItem.Click += New System.EventHandler(Me.yellowFlagBarItem_Click)
			' 
			' nextweekRecordBarItem
			' 
			Me.nextweekRecordBarItem.ID = "&Green Flag"
			Me.nextweekRecordBarItem.ImageIndex = 4
			Me.nextweekRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.nextweekRecordBarItem.Text = "&Next Week"
'			Me.nextweekRecordBarItem.Click += New System.EventHandler(Me.greenFlagBarItem_Click)
			' 
			' nodateRecordBarItem
			' 
			Me.nodateRecordBarItem.ID = "&Orange Flag"
			Me.nodateRecordBarItem.ImageIndex = 5
			Me.nodateRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.nodateRecordBarItem.Text = "No D&ate"
'			Me.nodateRecordBarItem.Click += New System.EventHandler(Me.orangeFlagBarItem_Click)
			' 
			' customRecordBarItem
			' 
			Me.customRecordBarItem.ID = "&Purple Flag"
			Me.customRecordBarItem.ImageIndex = 6
			Me.customRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.customRecordBarItem.Text = "&Custom..."
'			Me.customRecordBarItem.Click += New System.EventHandler(Me.purpleFlagBarItem_Click)
			' 
			' addreminderRecordBarItem
			' 
			Me.addreminderRecordBarItem.ID = "Flag Com&plete"
			Me.addreminderRecordBarItem.ImageIndex = 7
			Me.addreminderRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.addreminderRecordBarItem.Text = "Add &Reminder..."
'			Me.addreminderRecordBarItem.Click += New System.EventHandler(Me.flagCompleteBarItem_Click)
			' 
			' markcompleteRecordItem
			' 
			Me.markcompleteRecordItem.ID = "&Add Reminder..."
			Me.markcompleteRecordItem.ImageIndex = 8
			Me.markcompleteRecordItem.ShowMnemonicUnderlinesAlways = True
			Me.markcompleteRecordItem.Text = "&Mark Complete"
			' 
			' ClearFlagfromRecordBarItem
			' 
			Me.ClearFlagfromRecordBarItem.ID = "&Clear Flag"
			Me.ClearFlagfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.ClearFlagfromRecordBarItem.Text = "Cl&ear Flag"
'			Me.ClearFlagfromRecordBarItem.Click += New System.EventHandler(Me.clearFlagBarItem_Click)
			' 
			' setRecordBarItem1
			' 
			Me.setRecordBarItem1.ID = "Set &Quick Click..."
			Me.setRecordBarItem1.Text = "Set &Quick Click..."
			' 
			' MarkfromRecordBarItem
			' 
			Me.MarkfromRecordBarItem.ID = "Mark as U&nread"
			Me.MarkfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.MarkfromRecordBarItem.Text = "Mark as U&nread"
'			Me.MarkfromRecordBarItem.Click += New System.EventHandler(Me.MarkfromRecordBarItem_Click)
			' 
			' CategoriesfromRecordBarItem
			' 
			Me.CategoriesfromRecordBarItem.ID = "Catego&ries..."
			Me.CategoriesfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.CategoriesfromRecordBarItem.Text = "Catego&ries..."
			' 
			' FindAllfromRecordparentBarItem
			' 
			Me.FindAllfromRecordparentBarItem.ID = "Find &All"
			Me.FindAllfromRecordparentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.RelatedMessagesBarItem, Me.MessagesfromsenderBarItem})
			Me.FindAllfromRecordparentBarItem.ShowMnemonicUnderlinesAlways = True
			Me.FindAllfromRecordparentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
			Me.FindAllfromRecordparentBarItem.Text = "Find &All"
			' 
			' RelatedMessagesBarItem
			' 
			Me.RelatedMessagesBarItem.ID = "&Related Messages"
			Me.RelatedMessagesBarItem.ShowMnemonicUnderlinesAlways = True
			Me.RelatedMessagesBarItem.Text = "&Related Messages"
			' 
			' MessagesfromsenderBarItem
			' 
			Me.MessagesfromsenderBarItem.ID = "&Messages from Sender"
			Me.MessagesfromsenderBarItem.ShowMnemonicUnderlinesAlways = True
			Me.MessagesfromsenderBarItem.Text = "&Messages from Sender"
			' 
			' CreateRulefromRecordBarItem
			' 
			Me.CreateRulefromRecordBarItem.ID = "&Create Rule..."
			Me.CreateRulefromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.CreateRulefromRecordBarItem.Text = "&Create Rule..."
			' 
			' JunkEmailsfromRecordParentBarItem
			' 
			Me.JunkEmailsfromRecordParentBarItem.ID = "&Junk E-mail"
			Me.JunkEmailsfromRecordParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.AddSendertoBlockedSendersListBarItem, Me.AddSendertoSafeSendersListBarItem, Me.AddSendersDomaintoSafeSendersListBarItem, Me.AddRecipienttoSafeRecipientsListBarItem, Me.MarkasNotJunkBarItem, Me.JunkEmailOptionsBarItem})
			Me.JunkEmailsfromRecordParentBarItem.SeparatorIndices.AddRange(New Integer() { 4, 5})
			Me.JunkEmailsfromRecordParentBarItem.ShowMnemonicUnderlinesAlways = True
			Me.JunkEmailsfromRecordParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
			Me.JunkEmailsfromRecordParentBarItem.Text = "&Junk E-mail"
			' 
			' AddSendertoBlockedSendersListBarItem
			' 
			Me.AddSendertoBlockedSendersListBarItem.ID = "Add Sender to &Blocked Senders List"
			Me.AddSendertoBlockedSendersListBarItem.ShowMnemonicUnderlinesAlways = True
			Me.AddSendertoBlockedSendersListBarItem.Text = "Add Sender to &Blocked Senders List"
			' 
			' AddSendertoSafeSendersListBarItem
			' 
			Me.AddSendertoSafeSendersListBarItem.ID = "Add &Sender to Safe Senders List"
			Me.AddSendertoSafeSendersListBarItem.ShowMnemonicUnderlinesAlways = True
			Me.AddSendertoSafeSendersListBarItem.Text = "Add &Sender to Safe Senders List"
			' 
			' AddSendersDomaintoSafeSendersListBarItem
			' 
			Me.AddSendersDomaintoSafeSendersListBarItem.ID = "Add Sender's Domain (@example.com) to Safe Senders List"
			Me.AddSendersDomaintoSafeSendersListBarItem.ShowMnemonicUnderlinesAlways = True
			Me.AddSendersDomaintoSafeSendersListBarItem.Text = "Add Sender's Domain (@example.com) to Safe Senders List"
			' 
			' AddRecipienttoSafeRecipientsListBarItem
			' 
			Me.AddRecipienttoSafeRecipientsListBarItem.ID = "Add &Recipient to Safe Recipients List"
			Me.AddRecipienttoSafeRecipientsListBarItem.ShowMnemonicUnderlinesAlways = True
			Me.AddRecipienttoSafeRecipientsListBarItem.Text = "Add &Recipient to Safe Recipients List"
			' 
			' MarkasNotJunkBarItem
			' 
			Me.MarkasNotJunkBarItem.ID = "&Mark as Not Junk"
			Me.MarkasNotJunkBarItem.ShowMnemonicUnderlinesAlways = True
			Me.MarkasNotJunkBarItem.Text = "&Mark as Not Junk"
			' 
			' JunkEmailOptionsBarItem
			' 
			Me.JunkEmailOptionsBarItem.ID = "&Junk Email Options"
			Me.JunkEmailOptionsBarItem.ShowMnemonicUnderlinesAlways = True
			Me.JunkEmailOptionsBarItem.Text = "&Junk Email Options"
			' 
			' DeletefromRecordBarItem
			' 
			Me.DeletefromRecordBarItem.ID = "&Delete"
			Me.DeletefromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.DeletefromRecordBarItem.Text = "&Delete"
'			Me.DeletefromRecordBarItem.Click += New System.EventHandler(Me.DeletefromRecordBarItem_Click)
			' 
			' MoveToFolderfromRecordBarItem
			' 
			Me.MoveToFolderfromRecordBarItem.ID = "&Move to Folder..."
			Me.MoveToFolderfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.MoveToFolderfromRecordBarItem.Text = "&Move to Folder..."
			' 
			' OptionsfromRecordBarItem
			' 
			Me.OptionsfromRecordBarItem.ID = "O&ptions"
			Me.OptionsfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.OptionsfromRecordBarItem.Text = "O&ptions"
			' 
			' RedAsDefaultfromRecordBarItem
			' 
			Me.RedAsDefaultfromRecordBarItem.ID = "&Red as Default Flag"
			Me.RedAsDefaultfromRecordBarItem.ImageIndex = 1
			Me.RedAsDefaultfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.RedAsDefaultfromRecordBarItem.Text = "&Red as Default Flag"
'			Me.RedAsDefaultfromRecordBarItem.Click += New System.EventHandler(Me.redAsDefaultBarItem_Click)
			' 
			' BlueasDefaultfromRecordBarItem
			' 
			Me.BlueasDefaultfromRecordBarItem.ID = "&Blue as Default Flag"
			Me.BlueasDefaultfromRecordBarItem.ImageIndex = 2
			Me.BlueasDefaultfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.BlueasDefaultfromRecordBarItem.Text = "&Blue as Default Flag"
'			Me.BlueasDefaultfromRecordBarItem.Click += New System.EventHandler(Me.blueAsDefaultBarItem_Click)
			' 
			' YellowasDefaultfromRecordBarItem
			' 
			Me.YellowasDefaultfromRecordBarItem.ID = "&Yellow as Default Flag"
			Me.YellowasDefaultfromRecordBarItem.ImageIndex = 3
			Me.YellowasDefaultfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.YellowasDefaultfromRecordBarItem.Text = "&Yellow as Default Flag"
'			Me.YellowasDefaultfromRecordBarItem.Click += New System.EventHandler(Me.yellowAsDefaultBarItem_Click)
			' 
			' GreenasDefaultfromRecordBarItem
			' 
			Me.GreenasDefaultfromRecordBarItem.ID = "&Green as Default Flag"
			Me.GreenasDefaultfromRecordBarItem.ImageIndex = 4
			Me.GreenasDefaultfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.GreenasDefaultfromRecordBarItem.Text = "&Green as Default Flag"
'			Me.GreenasDefaultfromRecordBarItem.Click += New System.EventHandler(Me.greenAsDefaultBarItem_Click)
			' 
			' OrangeasDefaultfromRecordBarItem
			' 
			Me.OrangeasDefaultfromRecordBarItem.ID = "&Orange as Default Flag"
			Me.OrangeasDefaultfromRecordBarItem.ImageIndex = 5
			Me.OrangeasDefaultfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.OrangeasDefaultfromRecordBarItem.Text = "&Orange as Default Flag"
'			Me.OrangeasDefaultfromRecordBarItem.Click += New System.EventHandler(Me.orangeAsDefaultBarItem_Click)
			' 
			' PurpleasDefaultfromRecordBarItem
			' 
			Me.PurpleasDefaultfromRecordBarItem.ID = "P&urple as Default Flag"
			Me.PurpleasDefaultfromRecordBarItem.ImageIndex = 6
			Me.PurpleasDefaultfromRecordBarItem.ShowMnemonicUnderlinesAlways = True
			Me.PurpleasDefaultfromRecordBarItem.Text = "P&urple as Default Flag"
'			Me.PurpleasDefaultfromRecordBarItem.Click += New System.EventHandler(Me.purpleAsDefaultBarItem_Click)
			' 
			' categoryPopUpMenu
			' 
			Me.categoryPopUpMenu.ParentBarItem = Me.categoryParentBarItem
			' 
			' categoryParentBarItem
			' 
			Me.categoryParentBarItem.ImageList = Me.imageList1
			Me.categoryParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.clearallcategBarItem, Me.categsearchBarItem, Me.redcategBarItem, Me.blueBarItem, Me.greenBarItem, Me.orangeBarItem, Me.purpleBarItem, Me.yellowBarItem, Me.allcategBarItem, Me.setcategBarItem})
			Me.categoryParentBarItem.SeparatorIndices.AddRange(New Integer() { 1, 2, 9})
			Me.categoryParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
			' 
			' imageList1
			' 
            'Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
            'Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            'Me.imageList1.Images.SetKeyName(0, "red_square.gif")
            'Me.imageList1.Images.SetKeyName(1, "blue_square.gif")
            'Me.imageList1.Images.SetKeyName(2, "green_square.gif")
            'Me.imageList1.Images.SetKeyName(3, "orange_square.gif")
            'Me.imageList1.Images.SetKeyName(4, "violet_square.gif")
            'Me.imageList1.Images.SetKeyName(5, "yellow_square.gif")
            'Me.imageList1.Images.SetKeyName(6, "square.gif")
			' 
			' clearallcategBarItem
			' 
			Me.clearallcategBarItem.ID = "&Clear All Categories"
			Me.clearallcategBarItem.Text = "&Clear All Categories"
			' 
			' categsearchBarItem
			' 
			Me.categsearchBarItem.ID = "Category &Search Folder..."
			Me.categsearchBarItem.Text = "Category &Search Folder..."
			' 
			' redcategBarItem
			' 
			Me.redcategBarItem.ID = "Red Category"
			Me.redcategBarItem.ImageIndex = 0
			Me.redcategBarItem.ImageList = Me.imageList1
			Me.redcategBarItem.Text = "Red Category"
'			Me.redcategBarItem.Click += New System.EventHandler(Me.redcategBarItem_Click)
			' 
			' blueBarItem
			' 
			Me.blueBarItem.ID = "Blue Category"
			Me.blueBarItem.ImageIndex = 1
			Me.blueBarItem.ImageList = Me.imageList1
			Me.blueBarItem.Text = "Blue Category"
'			Me.blueBarItem.Click += New System.EventHandler(Me.blueBarItem_Click)
			' 
			' greenBarItem
			' 
			Me.greenBarItem.ID = "Blue Category"
			Me.greenBarItem.ImageIndex = 2
			Me.greenBarItem.ImageList = Me.imageList1
			Me.greenBarItem.Text = "Green Category"
'			Me.greenBarItem.Click += New System.EventHandler(Me.greenBarItem_Click)
			' 
			' orangeBarItem
			' 
			Me.orangeBarItem.ID = "Orange Category"
			Me.orangeBarItem.ImageIndex = 3
			Me.orangeBarItem.ImageList = Me.imageList1
			Me.orangeBarItem.Text = "Orange Category"
'			Me.orangeBarItem.Click += New System.EventHandler(Me.orangeBarItem_Click)
			' 
			' purpleBarItem
			' 
			Me.purpleBarItem.ID = "Purple Category"
			Me.purpleBarItem.ImageIndex = 4
			Me.purpleBarItem.ImageList = Me.imageList1
			Me.purpleBarItem.Text = "Purple Category"
'			Me.purpleBarItem.Click += New System.EventHandler(Me.purpleBarItem_Click)
			' 
			' yellowBarItem
			' 
			Me.yellowBarItem.ID = "Yellow Category"
			Me.yellowBarItem.ImageIndex = 5
			Me.yellowBarItem.ImageList = Me.imageList1
			Me.yellowBarItem.Text = "Yellow Category"
'			Me.yellowBarItem.Click += New System.EventHandler(Me.yellowBarItem_Click)
			' 
			' allcategBarItem
			' 
			Me.allcategBarItem.ID = "&All Categories"
			Me.allcategBarItem.ImageIndex = 6
			Me.allcategBarItem.ImageList = Me.imageList1
			Me.allcategBarItem.Text = "&All Categories"
			' 
			' setcategBarItem
			' 
			Me.setcategBarItem.ID = "Set &Quick Click..."
			Me.setcategBarItem.Text = "Set &Quick Click..."
			' 
			' GroupingPanel
			' 
			Me.Controls.Add(Me.gridGroupingControl1)
			Me.Size = New System.Drawing.Size(688, 353)
			Me.Text = "GroupingPanel"
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		#Region "Class helper functions"

		''' <summary>
		''' CreateColumnSetView creates columns columnSetDescriptor to implement
		''' the ColumnSet view or Card view while narrowing the grid..
		''' </summary>
		''' <param name="rows">Number of required rows in the ColumnSet or card view </param>
		Public Sub CreateColumnSetView(ByVal rows As Integer)
			'There are four column sets needs to be created
			' Wherein  2nd column set appends dynamically the extra layers of column needed

			CreateFirstColumnSet("First", rows)
			CreateSecondColumnSet("Second", rows)
			CreateThirdColumnSet("Third", rows)
			CreateFourthColumnSet("Fourth", rows)
			OtherCols()
		End Sub

		''' <summary>
		''' Dynamically creates column spans for this column set
		''' </summary>
		''' <param name="name">The name of the column set</param>
		''' <param name="rows">Number of required rows in the ColumnSet or card view</param>
		Private Sub CreateFirstColumnSet(ByVal name As String, ByVal rows As Integer)
			'The mails column is the first column set and is mandatory.. 
			Dim csd1 As New GridColumnSetDescriptor(name) ' Mails Icon column
			Dim range As String = RangeGenarator(0, 0, rows - 1, 0)
			csd1.ColumnSpans.Add(New GridColumnSpanDescriptor("mails", range))
			Me.gridGroupingControl1.TableDescriptor.Columns("mails").Width = 24
			Me.gridGroupingControl1.TableDescriptor.ColumnSets.Add(csd1)
		End Sub
		''' <summary>
		''' Dynamically creates column spans for this column set
		''' </summary>
		''' <param name="name">The name of the column set</param>
		''' <param name="rows">Number of required rows in the ColumnSet or card view</param>
		Private Sub CreateSecondColumnSet(ByVal name As String, ByVal rows As Integer)
			Dim csd2 As New GridColumnSetDescriptor(name)

			Dim i As Integer = 0 'counts the added columns to the column set
			For Each cd As GridColumnDescriptor In Me.gridGroupingControl1.TableDescriptor.Columns
				Dim ColumnName As String = cd.Name
				'this.gridGroupingControl1.TableDescriptor.VisibleColumns[i].Name;
				If i = rows Then
					Exit For
				End If
				' Should have been added in the first column set
				If ColumnName = "mails" Then
					Continue For
				End If

				' Reserved for 3rd column set..
				If ColumnName = "Received" OrElse ColumnName = "Attachment" OrElse ColumnName = "Priority" Then
					Continue For
				End If

				Dim range As String = RangeGenarator(i, 0, i, 0)
				csd2.ColumnSpans.Add(New GridColumnSpanDescriptor(cd.Name, range))
				i += 1
			Next cd

			Me.gridGroupingControl1.TableDescriptor.ColumnSets.Add(csd2)

			'Make a note of the column at the first row, second row and last row
			columnAtTop_Renamed = csd2.ColumnSpans(0).Name
			secondRowColumn_Renamed = csd2.ColumnSpans(1).Name
			columnAtBottom_Renamed = csd2.ColumnSpans(csd2.ColumnSpans.Count - 1).Name
		End Sub

		''' <summary>
		''' Dynamically creates column spans for this column set
		''' </summary>
		''' <param name="name">The name of the column set</param>
		''' <param name="rows">Number of required rows in the ColumnSet or card view</param>
		Private Sub CreateThirdColumnSet(ByVal name As String, ByVal rows As Integer)
			Dim csd3 As New GridColumnSetDescriptor(name)

			' If Received is not taken into account then Provide a dummy column to have the column set view undisturbed..
			Dim range As String = RangeGenarator(0, 0, 0, 1)
			If Me.gridGroupingControl1.TableDescriptor.Columns.Contains("Received") Then
				csd3.ColumnSpans.Add(New GridColumnSpanDescriptor("Received", range))
			Else
				If Not Me.gridGroupingControl1.TableDescriptor.Columns.Contains("DummyCol") Then
					Me.gridGroupingControl1.TableDescriptor.Columns.Add("DummyCol")
				End If

				csd3.ColumnSpans.Add(New GridColumnSpanDescriptor("DummyCol", range))
			End If
			range = RangeGenarator(1, 0, rows - 1, 0)
			csd3.ColumnSpans.Add(New GridColumnSpanDescriptor("Priority", range))
			Me.gridGroupingControl1.TableDescriptor.Columns("Priority").Width = 68
			range = RangeGenarator(1, 1, rows - 1, 1)
			csd3.ColumnSpans.Add(New GridColumnSpanDescriptor("Attachment", range))
			Me.gridGroupingControl1.TableDescriptor.ColumnSets.Add(csd3)
			Me.gridGroupingControl1.TableDescriptor.Columns("Attachment").Width = 12
		End Sub

		''' <summary>
		''' Dynamically creates column spans for this column set
		''' </summary>
		''' <param name="name">The name of the column set</param>
		''' <param name="rows">Number of required rows in the ColumnSet or card view</param>
		Private Sub CreateFourthColumnSet(ByVal name As String, ByVal rows As Integer)
			' flag column (Optional)
			Dim csd4 As New GridColumnSetDescriptor(name)
			Dim range As String = RangeGenarator(0, 0, rows - 1, 1)
			If Me.gridGroupingControl1.TableDescriptor.Columns.Contains("flag") Then
				csd4.ColumnSpans.Add(New GridColumnSpanDescriptor("flag", range))
				Me.gridGroupingControl1.TableDescriptor.Columns("flag").Width = 24
				Me.gridGroupingControl1.TableDescriptor.ColumnSets.Add(csd4)
			End If
		End Sub

		Private Ht_ColWidth As Hashtable
		Private Sub OtherCols()
			Ht_ColWidth = New Hashtable()
			Dim columnPresent As Boolean
			'for each columns that are not in the column set are to be reduced to 0..
			For Each cd As GridColumnDescriptor In Me.gridGroupingControl1.TableDescriptor.Columns
				columnPresent = False
				For Each csd As GridColumnSetDescriptor In Me.gridGroupingControl1.TableDescriptor.ColumnSets
					columnPresent = columnPresent Or csd.ColumnSpans.Contains(cd.Name)
				Next csd
				If Not columnPresent Then
					Ht_ColWidth.Add(cd.Name, cd.Width)
					cd.Width = 0
				End If
			Next cd
		End Sub

		Private Sub RollBackSizeChanges()
			Me.gridGroupingControl1.TableDescriptor.Columns("Priority").Width = 15
			Me.gridGroupingControl1.TableDescriptor.Columns("Attachment").Width = 15
			Me.gridGroupingControl1.TableDescriptor.Columns("flag").Width = 15
			Me.gridGroupingControl1.TableDescriptor.Columns("mails").Width = 15

			For Each keys As String In Ht_ColWidth.Keys
				Me.gridGroupingControl1.TableDescriptor.Columns(keys).Width = CInt(Fix(Ht_ColWidth(keys)))
			Next keys
		End Sub
		''' <summary>
		''' Creates ranges when CreateColumnSetView requires
		''' </summary>
		''' <param name="top"></param>
		''' <param name="left"></param>
		''' <param name="bottom"></param>
		''' <param name="right"></param>
		''' <returns>range in string format</returns>
		Private Function RangeGenarator(ByVal top As Integer, ByVal left As Integer, ByVal bottom As Integer, ByVal right As Integer) As String
			Return GridRangeInfo.Auto(top, left, bottom, right).ToString()
		End Function

		''' <summary>
		''' Controls the display of the custom section..
		''' </summary>
		''' <param name="value">true to enable, false othervise</param>
		Public Sub EnableCustomSection(ByVal value As Boolean)
			' Enable the custom section
			GroupingChildTable.SectionRequired = value
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Fake")
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Remove("Fake")
		End Sub

		Public Sub Close()
			'			XmlTextWriter xw = new XmlTextWriter("GridSchema.Xml", System.Text.Encoding.UTF8);
			'			this.gridGroupingControl1.WriteXmlSchema(xw);
			'			xw.Close();
		End Sub

		''' <summary>
		''' The total col width of the grid is known
		''' </summary>
		''' <returns></returns>
		Private Function GetTotalColumnWidth() As Integer
			Dim actualSize As Integer = 0
			For Each vcd As GridColumnDescriptor In Me.gridGroupingControl1.TableDescriptor.Columns
				If vcd.Name = "flag" AndAlso vcd.Name = "mails" Then 'fixed cols
					FixedColumnWidths += vcd.Width
				Else
					actualSize += vcd.Width
				End If
			Next vcd
			Return actualSize
		End Function
		Private FixedColumnWidths As Integer


		Private Function ComputePeriodReceived(ByVal dateReceivedInTotalDays As Integer) As Integer
			Dim TodaysDate As DateTime = DateTime.Today
			Dim age As Integer = dateReceivedInTotalDays
			Dim nDay As Integer = CInt(Fix(TodaysDate.DayOfWeek))
			Dim noOfDaysInWeekSoFar As Integer = nDay + 1
			Dim val As String = " "
			If age = 0 Then
				Return Convert.ToInt32(days.Today)
			ElseIf age = 1 Then
				Return Convert.ToInt32(days.Yesterday)
			ElseIf age < noOfDaysInWeekSoFar Then
				val = GetDayOfWeek(nDay - age)
			End If
			Select Case val
				Case "Sunday"
					Return Convert.ToInt32(days.Sunday)
				Case "Monday"
					Return Convert.ToInt32(days.Monday)
				Case "Tuesday"
					Return Convert.ToInt32(days.Tuesday)
				Case "Wednesday"
					Return Convert.ToInt32(days.Wednesday)
				Case "Thursday"
					Return Convert.ToInt32(days.Thursday)
			End Select

			Dim ageInWeeks As Integer = (age - noOfDaysInWeekSoFar) / 7
			Select Case ageInWeeks
				Case 0, 1
					Return Convert.ToInt32(days.LastWeek)
				Case 2
					Return Convert.ToInt32(days.TwoWeeksAgo)
				Case 3
					Return Convert.ToInt32(days.ThreeWeeksAgo)
			End Select
			If ageInWeeks < 5 Then
				Return Convert.ToInt32(days.LastMonth)
			End If
			Return Convert.ToInt32(days.Older)
		End Function


		Private Function GetDayOfWeek(ByVal intDay As Integer) As String
			Return (CType(intDay, DayOfWeek)).ToString()
		End Function

		Private Sub ShowGroupDropArea()
			If Me.barItem_ShowInGroups.Checked Then
				Me.gridGroupingControl1.ShowGroupDropArea = True
			Else
				Me.gridGroupingControl1.ShowGroupDropArea = False
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
			End If
		End Sub
		Private Sub ClearChecks(ByVal parentBarItem As ParentBarItem)
			For Each barItem As BarItem In parentBarItem.Items
				Dim name As String = barItem.Text
				If parentBarItem.IsGroupBeginning(barItem) Then
					Return
				End If
				If barItem.Checked Then
					barItem.Checked = False
					Return
				End If
			Next barItem
		End Sub

		''' <summary>
		''' Expands the group if collapsed..
		''' </summary>
		Public Sub ExpandthisGroup()
			' from the row of the nesteddispaly elemnt 
			Dim el As Element = Me.gridGroupingControl1.Table.GetInnerMostCurrentElement()
			Dim row As Integer = Me.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el)
			If Me.gridGroupingControl1.Table.NestedDisplayElements(row).IsCaption() Then
				Dim crow As GridCaptionRow = CType(el, GridCaptionRow)
				Dim gp As Group = crow.ParentGroup
				gp.IsExpanded = True
			End If
		End Sub

		''' <summary>
		''' Sets the required flag, also selects the group..
		''' </summary>
		''' <param name="thisFlag">flag identifier from flags enum</param>
		Private Sub ApplythisGroupwithFlag(ByVal thisFlag As Integer)
			ExpandthisGroup()
			' from the row of the current nesteddispaly elemnt 
			Dim el As Element = Me.gridGroupingControl1.Table.GetInnerMostCurrentElement()
			Dim row As Integer = Me.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el)
			row += 1
			Dim rows As Integer = row
			' enumerate each rows and clear the flag
			Do While rows < Me.gridGroupingControl1.Table.NestedDisplayElements.Count
				' check till the next available caption element..
				If Me.gridGroupingControl1.Table.NestedDisplayElements(rows).IsCaption() Then
					Exit Do
				Else
					Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Row(rows))
					Dim r As Record = Me.gridGroupingControl1.Table.NestedDisplayElements(rows).GetRecord()
					r.SetValue("flag", thisFlag)
					'fl[r.Id] = thisFlag;
				End If
				rows += 1
			Loop
		End Sub

		''' <summary>
		''' Sets the required mark into the ReadState column..
		''' So as to show read or unread
		''' </summary>
		''' <param name="mark">read as 1 or unread as 0</param>
		Private Sub ApplythisGroupwithReadState(ByVal mark As Integer)
			ExpandthisGroup()
			' from the row of the nesteddispaly elemnt 
			Dim el As Element = Me.gridGroupingControl1.Table.GetInnerMostCurrentElement()
			Dim row As Integer = Me.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el)
			row += 1
			Dim rows As Integer = row
			' enumerate each rows and clear the flag
			Do While rows < Me.gridGroupingControl1.Table.NestedDisplayElements.Count
				' check till the next available caption element..
				If Me.gridGroupingControl1.Table.NestedDisplayElements(rows).IsCaption() Then
					Exit Do
				Else
					Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Row(rows))
					Dim r As Record = Me.gridGroupingControl1.Table.NestedDisplayElements(rows).GetRecord()
					r.SetValue("ReadState", mark)
				End If
				rows += 1
			Loop
		End Sub
		#End Region


		#Region "event Handlers"

		#Region "GridGroupingControl event handlers"
		Private keyId As Integer = -1
		''' <summary>
		''' Queries the column width as required
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub TableModel_QueryColWidth(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
			Dim gridModel As GridTableModel = TryCast(sender, GridTableModel)
			If NormalView Then
				' proportional sizing of the normal view
				Dim factor As Single = 0f
				Dim availableWidth As Integer = Me.gridGroupingControl1.Width - (FixedColumnWidths + gridModel.GetColumnIndentCount() * Me.gridGroupingControl1.TableOptions.IndentWidth)
				If Me.gridGroupingControl1.TableControl.VScroll Then
					factor = CSng(availableWidth - SystemInformation.VerticalScrollBarWidth) / GetTotalColumnWidth()
				Else
					factor = CSng(availableWidth) / GetTotalColumnWidth()
				End If
				If e.Index >= gridModel.GetColumnIndentCount() AndAlso e.Index <> keyId Then
					e.Size = Convert.ToInt32(Math.Round((e.Size + 2) * factor))
				End If
				e.Handled = True
			Else ' column set view
				If e.Index = 2 + (gridModel.GetColumnIndentCount() - 1) Then ' resize 2nd column only
					e.Size = Me.gridGroupingControl1.Width - Me.gridGroupingControl1.TableDescriptor.Columns("mails").Width
					If Me.gridGroupingControl1.TableDescriptor.Columns.Contains("Received") Then
						e.Size -= Me.gridGroupingControl1.TableDescriptor.Columns("Received").Width
					Else
						e.Size -= Me.gridGroupingControl1.TableDescriptor.Columns("DummyCol").Width
					End If
					If Me.gridGroupingControl1.TableDescriptor.Columns.Contains("flag") Then
						e.Size -= Me.gridGroupingControl1.TableDescriptor.Columns("flag").Width
					End If
					If Me.gridGroupingControl1.TableControl.VScroll Then
						e.Size -= SystemInformation.VerticalScrollBarWidth
					End If
					secondColumnSetSize_Renamed = e.Size

					e.Handled = True
				End If
			End If
		End Sub

		Private Sub TableModel_ColWidthsChanging(ByVal sender As Object, ByVal e As GridRowColSizeChangingEventArgs)
			Dim gridModel As GridTableModel = TryCast(sender, GridTableModel)

			If Me.gridGroupingControl1.TableDescriptor.Columns(e.From - gridModel.GetColumnIndentCount()).Name = "mails" OrElse Me.gridGroupingControl1.TableDescriptor.Columns(e.From - gridModel.GetColumnIndentCount()).Name = "flag" OrElse Me.gridGroupingControl1.TableDescriptor.Columns(e.From - gridModel.GetColumnIndentCount()).Name = "ReadState" OrElse Me.gridGroupingControl1.TableDescriptor.Columns(e.From - gridModel.GetColumnIndentCount()).Name = "Priority" OrElse Me.gridGroupingControl1.TableDescriptor.Columns(e.From - gridModel.GetColumnIndentCount()).Name = "Attachment" Then
				e.Cancel = True
				Return
			End If
			keyId = e.From
		End Sub

		Private Sub TableModel_ColWidthsChanged(ByVal sender As Object, ByVal e As GridRowColSizeChangedEventArgs)
			keyId = -1
		End Sub

		Private Sub gridGroupingControl1_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.gridGroupingControl1.Width > 400 Then
				Me.NormalView = True
			Else
				Me.NormalView = False
			End If
		End Sub

		Private Function UsedColors(ByVal index As Integer) As Color
			Select Case index
				Case 0
					Return SystemColors.ControlLightLight

				Case 1
					Return Color.FromArgb(80, 255, 48, 0)

				Case 2
					Return Color.FromArgb(80, Color.DarkBlue)

				Case 3
					Return Color.FromArgb(80, 255, 207, 49)

				Case 4
					Return Color.FromArgb(80, 0, 255, 0)

				Case 5
					Return Color.FromArgb(80, Color.Orange)

				Case 6
					Return Color.FromArgb(80, Color.Purple)

				Case Else
					Return Color.FromArgb(80, Color.White)
			End Select
		End Function

		Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)
			If Me.gridGroupingControl1.TableOptions.ShowRecordPreviewRow Then
				If e.TableCellIdentity.TableCellType = GridTableCellType.RecordPreviewCell Then
					Dim record As GridRecord = TryCast(e.TableCellIdentity.DisplayElement.ParentRecord, GridRecord)
					If record IsNot Nothing Then
						e.Style.TextColor = System.Drawing.Color.Black
						e.Style.CellValue = record.GetValue("Content").ToString().Trim()
						e.Style.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
					Else
						e.Style.CellValue = " "
					End If
					e.Style.Trimming = StringTrimming.EllipsisCharacter
				End If
			End If
			If e.Style.CellType Is "ColumnHeaderCell" Then
				e.Style.Borders.Top = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thin)
				e.Style.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thin)
				e.Style.CellTipText = e.Style.Text
				e.Style.HorizontalAlignment = GridHorizontalAlignment.Left
				e.Style.Interior = New BrushInfo(GradientStyle.Vertical, HeaderForeColor, HeaderBackColor)
			End If
			If e.Style IsNot Nothing AndAlso e.TableCellIdentity.Column IsNot Nothing Then
				e.Style.Font.Facename = "Arial"
				e.Style.Font.Size = 8f
				e.Style.Trimming = StringTrimming.EllipsisCharacter
				e.Style.ReadOnly = True
				If e.TableCellIdentity.Column.Name = "Received" Then
					e.Style.ShowButtons = GridShowButtons.Hide
				End If

				If Not Me.NormalView Then
					e.Style.Borders.Bottom = New GridBorder(GridBorderStyle.None)
					If e.TableCellIdentity.Column.Name = "mails" OrElse e.TableCellIdentity.Column.Name = "flag" OrElse e.TableCellIdentity.Column.Name = Me.ColumnAtBottom OrElse e.TableCellIdentity.Column.Name = "Attachment" OrElse e.TableCellIdentity.Column.Name = "Priority" Then
						e.Style.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.ExtraThin)
					End If
				End If
				If (Not Me.NormalView) AndAlso e.TableCellIdentity.Column.Name <> Me.columnAtTop_Renamed AndAlso e.TableCellIdentity.Column.Name <> "Received" Then
					e.Style.TextColor = Color.Gray
				End If

				If e.TableCellIdentity.Column.Name = "flag" Then
					If e.Style.CellType IsNot "ColumnHeaderCell" Then
						e.Style.CellType = "Image"
						e.Style.ImageList = Me.fList
						e.Style.ImageIndex = Convert.ToInt32(e.Style.CellValue)

					End If

					If e.Style.CellType Is "ColumnHeaderCell" Then
						e.Style.CellType = "Static"
						e.Style.ImageList = Me.fList
						e.Style.ImageIndex = CInt(headerImage.Flag)
						e.Style.Text = ""
					End If
				End If
				If e.TableCellIdentity.Column.Name = "Category" Then
					If e.Style.CellType IsNot "ColumnHeaderCell" Then
						e.Style.CellType = "Static"
						e.Style.ImageList = Me.imageList1
						Select Case CStr(e.Style.CellValue)
							Case "Red Category"
								e.Style.ImageIndex = 0
							Case "Blue Category"
								e.Style.ImageIndex = 1
							Case "Green Category"
								e.Style.ImageIndex = 2
							Case "Orange Category"
								e.Style.ImageIndex = 3
							Case "Purple Category"
								e.Style.ImageIndex = 4
							Case "Yellow Category"
								e.Style.ImageIndex = 5
						End Select
					End If
				End If
				If e.TableCellIdentity.Column.Name = "Size" Then
					If e.Style.CellType IsNot "ColumnHeaderCell" Then
						Dim value As Double = CDbl(e.Style.CellValue)
						If value < 1024 Then
							e.Style.CellValue = value & " B"
						ElseIf value < 1048575 Then
							value = Math.Floor(value / 1024)
							e.Style.CellValue = value & " KB"
						ElseIf value < 1073741824 Then
							value = Math.Floor(value / 1048575)
							e.Style.CellValue = value & " MB"
						ElseIf value > 1073741824 Then
							value = Math.Floor(value / 1073741824)
							e.Style.CellValue = value & " GB"
						End If
						e.Style.HorizontalAlignment = GridHorizontalAlignment.Left
					End If
				End If
				If e.TableCellIdentity.Column.Name = "mails" Then
					If e.Style.CellType IsNot "ColumnHeaderCell" Then
						e.Style.CellType = "Image"
						e.Style.ImageList = Me.mailList
						e.Style.ImageIndex = CInt(Fix(e.Style.CellValue))
					End If
					If e.Style.CellType Is "ColumnHeaderCell" Then
						e.Style.CellType = "Static"
						e.Style.ImageList = Me.iList
						e.Style.ImageIndex = CInt(headerImage.Mail)
						e.Style.Text = ""
					End If
				End If

				If e.TableCellIdentity.Column.Name = "ReadState" Then
					If e.Style.CellType IsNot "ColumnHeaderCell" Then
						e.Style.CellType = "Image"
						e.Style.ImageList = Me.mailList
						e.Style.ImageIndex = CInt(Fix(e.Style.CellValue))
					End If
					If e.Style.CellType Is "ColumnHeaderCell" Then
						e.Style.CellType = "Static"
						e.Style.ImageList = Me.iList
						e.Style.ImageIndex = CInt(headerImage.ReadState)
						e.Style.Text = ""
					End If
				End If

				If e.TableCellIdentity.Column.Name = "Priority" Then
					If e.Style.CellType IsNot "ColumnHeaderCell" Then
						If e.Style.Text = "1" OrElse e.Style.Text = "-1" Then
							e.Style.CellType = "Image"
							e.Style.ImageList = Me.iList
                            If e.Style.Text = "1" Then
                                e.Style.ImageIndex = CInt(flags.HighPriority)
                            Else
                                e.Style.ImageIndex = CInt(flags.LowPriority)
                            End If
						End If
					End If
					If e.Style.CellType Is "ColumnHeaderCell" Then
						e.Style.CellType = "Static"
						e.Style.ImageList = Me.iList
						e.Style.Text = ""
						e.Style.ImageIndex = CInt(headerImage.Priority)
					End If
				End If

				If e.TableCellIdentity.Column.Name = "Attachment" Then
					If e.Style.CellType IsNot "ColumnHeaderCell" Then
						If e.Style.Text = "1" Then
							e.Style.CellType = "Image"
							e.Style.ImageList = Me.iList
							e.Style.ImageIndex = CInt(flags.ShowClip)
						End If
					End If
					If e.Style.CellType Is "ColumnHeaderCell" Then
						e.Style.CellType = "Static"
						e.Style.ImageList = Me.iList
						e.Style.ImageIndex = CInt(headerImage.Attachment)
						e.Style.Text = ""
					End If
				End If
				If e.Style.CellType Is "ColumnHeaderCell" Then
					e.Style.CellType = "Static"
				End If

				If TypeOf e.TableCellIdentity.DisplayElement Is GridRecordRow Then
					If Me.NormalView Then
						Dim dr As DataRowView = TryCast(e.TableCellIdentity.DisplayElement.ParentRecord.GetData(), DataRowView)
						If dr IsNot Nothing AndAlso Convert.ToInt32(dr("ReadState")) = 1 Then
							e.Style.Font.Bold = False
							If e.TableCellIdentity.Column.Name = "mails" AndAlso e.Style.CellType IsNot "ColumnHeaderCell" AndAlso CInt(Fix(e.Style.CellValue)) = 0 Then
								e.Style.ImageIndex = 1
							End If
						ElseIf dr IsNot Nothing AndAlso Convert.ToInt32(dr("ReadState")) = 0 Then
							e.Style.Font.Bold = True
							If e.TableCellIdentity.Column.Name = "mails" AndAlso e.Style.CellType IsNot "ColumnHeaderCell" AndAlso CInt(Fix(e.Style.CellValue)) = 1 Then
								e.Style.ImageIndex = 0
							End If
						End If
					End If
				End If
			End If
			If e.TableCellIdentity.TableCellType = GridTableCellType.GroupCaptionCell Then
				e.Style.Themed = False
				e.Style.BackColor = Color.White
				e.Style.Borders.Top = New GridBorder(GridBorderStyle.None, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thick)
				e.Style.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thick)
				e.Style.TextColor = Color.FromArgb(50, 100, 160)
				e.Style.Text = e.TableCellIdentity.DisplayElement.ParentGroup.Category.ToString()
				e.Style.TextMargins.Bottom = 8 - 3

				e.Style.VerticalAlignment = GridVerticalAlignment.Bottom
			End If
			If e.TableCellIdentity.TableCellType = GridTableCellType.GroupCaptionPlusMinusCell Then
				e.Style.CellAppearance = GridCellAppearance.Flat
				e.Style.Borders.Top = New GridBorder(GridBorderStyle.None)
				e.Style.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(Form1.r, Form1.g, Form1.b), GridBorderWeight.Thick)
			End If
			If e.TableCellIdentity.TableCellType = GridTableCellType.GroupIndentCell Then
				e.Style.Borders.Top = New GridBorder(GridBorderStyle.None)
				e.Style.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(227, 239, 255), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			End If

			If (e.TableCellIdentity.TableCellType = GridTableCellType.GroupCaptionCell AndAlso e.TableCellIdentity.RowIndex > 1) Then
				If gridGroupingControl1.TableDescriptor.GroupedColumns.IndexOf("date") > -1 Then
					e.Style.Font.Bold = True
					Try
						Select Case CType(Convert.ToInt32(e.Style.Text), days)
							Case days.LastWeek
									e.Style.Text = "Date: Last Week"
									Exit Select
							Case days.TwoWeeksAgo
									e.Style.Text = "Date: Two Weeks Ago"
									Exit Select
							Case days.ThreeWeeksAgo
									e.Style.Text = "Date: Three Weeks Ago"
									Exit Select
							Case days.LastMonth
									e.Style.Text = "Date: Last Month"
									Exit Select
							Case Else
									e.Style.Text = "Date: " & CType(Convert.ToInt32(e.Style.Text), days)
									Exit Select
						End Select
					Catch
						'Console.WriteLine(ex.Message);
					End Try
				End If
				If gridGroupingControl1.TableDescriptor.GroupedColumns.IndexOf("customSize") > -1 Then
					e.Style.Font.Bold = True
					If e.Style.Text = "1" Then
						e.Style.Text = "Tiny (<10 KB)"
					ElseIf e.Style.Text = "2" Then
						e.Style.Text = "Small (10 KB - 25 KB)"
					ElseIf e.Style.Text = "3" Then
						e.Style.Text = "Medium (25 KB - 100 KB)"
					ElseIf e.Style.Text = "4" Then
						e.Style.Text = "Large (100 KB - 500 KB)"
					ElseIf e.Style.Text = "5" Then
						e.Style.Text = "Very Large (500 KB - 1 MB)"
					ElseIf e.Style.Text = "6" Then
						e.Style.Text = "Huge (1 MB - 5 MB)"
					ElseIf e.Style.Text = "7" Then
						e.Style.Text = "Enormous (>5 MB)"
					End If
				End If
				If gridGroupingControl1.TableDescriptor.GroupedColumns.IndexOf("Priority") > -1 Then
					e.Style.Font.Bold = False
					If e.Style.Text = "1" Then
						e.Style.Text = "Importance: High(" & e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() & "items)"
					ElseIf e.Style.Text = "-1" Then
						e.Style.Text = "Importance: Low(" & e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() & "items)"
					ElseIf e.Style.Text = "0" Then
						e.Style.Text = "Importance: Normal(" & e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() & "items)"
					End If
				End If
				If gridGroupingControl1.TableDescriptor.GroupedColumns.IndexOf("Attachment") > -1 Then
					e.Style.Font.Bold = False
					If e.Style.Text = "1" Then
						e.Style.Text = "Attachment: With Attachments(" & e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() & "items)"
					ElseIf e.Style.Text = "0" Then
						e.Style.Text = "Attachment: No Attachments(" & e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() & "items)"
					End If
				End If
				If gridGroupingControl1.TableDescriptor.GroupedColumns.IndexOf("flag") > -1 Then
					e.Style.Font.Bold = False
					If e.Style.Text = "0" Then
						e.Style.Text = "Flag Status: Unflagged(" & e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() & "items)"
					ElseIf e.Style.Text = "1" Then
						e.Style.Text = "Flag Status: Red Flag(" & e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() & "items)"
					ElseIf e.Style.Text = "2" Then
						e.Style.Text = "Flag Status: Blue Flag(" & e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() & "items)"
					ElseIf e.Style.Text = "3" Then
						e.Style.Text = "Flag Status: Yellow Flag(" & e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() & "items)"
					ElseIf e.Style.Text = "4" Then
						e.Style.Text = "Flag Status: Green Flag(" & e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() & "items)"
					ElseIf e.Style.Text = "5" Then
						e.Style.Text = "Flag Status: Orange Flag(" & e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() & "items)"
					ElseIf e.Style.Text = "6" Then
						e.Style.Text = "Flag Status: Purple Flag(" & e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() & "items)"
					ElseIf e.Style.Text = "7" Then
						e.Style.Text = "Flag Status: Flag Complete(" & e.TableCellIdentity.DisplayElement.ParentGroup.GetFilteredRecordCount() & "items)"
					End If
				End If
			End If
			If (Not normalView_Renamed) AndAlso TypeOf e.TableCellIdentity.DisplayElement Is ExtraSection Then
				e.Style.CellType = "Control"
				e.Style.Control = Me.CSVHeader
			End If
		End Sub

		Private record As Integer
		Private Sub gridGroupingControl1_TableControlCellClick(ByVal sender As Object, ByVal e As GridTableControlCellClickEventArgs)


            If e.Inner.MouseEventArgs.Button = Windows.Forms.MouseButtons.Left Then
                If e.Inner.RowIndex > 1 AndAlso TypeOf e.TableControl.Table.CurrentElement Is GridCaptionRow Then
                    Dim style As GridTableCellStyleInfo = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex)
                    If style.TableCellIdentity.TableCellType = GridTableCellType.GroupCaptionPlusMinusCell Then
                        Dim curGrp As GridCaptionRow = CType(IIf(TypeOf e.TableControl.Table.CurrentElement Is GridCaptionRow, e.TableControl.Table.CurrentElement, Nothing), GridCaptionRow)
                        curGrp.ParentGroup.IsExpanded = Not curGrp.ParentGroup.IsExpanded
                    End If
                End If

                If e.Inner.RowIndex > 1 AndAlso TypeOf e.TableControl.Table.CurrentElement Is GridRecord Then
                    Dim r As GridRecord = CType(e.TableControl.Table.CurrentElement, GridRecord)
                    Dim style As GridTableCellStyleInfo = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex)
                    If Not style.TableCellIdentity.Column Is Nothing AndAlso style.TableCellIdentity.Column.Name = "flag" Then
                        If CInt(style.CellValue) = CInt(flags.Clear) Then
                            r.SetValue("flag", CInt(Me.defaultFlag_Renamed))
                        ElseIf CInt(style.CellValue) <> CInt(flags.Complete) Then
                            r.SetValue("flag", CInt(flags.Complete))
                        ElseIf CInt(style.CellValue) = CInt(flags.Complete) Then
                            r.SetValue("flag", CInt(Me.defaultFlag_Renamed))
                        End If
                    End If
                End If

                If Me.PreviewSelected Then
                    ' Select both record & record preview in case of clicks either in record or record preview
                    Dim tableCellStyle As GridTableCellStyleInfo = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex)
                    Dim elt As Element = tableCellStyle.TableCellIdentity.DisplayElement
                    If TypeOf elt Is GridRecordRow Then
                        catchRecord = Me.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(elt)
                        catchPreview = Me.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(elt) + 1

                        e.TableControl.Selections.Add(GridRangeInfo.Rows(e.Inner.RowIndex, e.Inner.RowIndex + 1))
                    End If
                    If TypeOf elt Is GridRecordPreviewRow Then
                        catchRecord = Me.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(elt) - 1
                        catchPreview = Me.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(elt)

                        e.TableControl.Selections.Add(GridRangeInfo.Rows(e.Inner.RowIndex - 1, e.Inner.RowIndex))
                    End If
                End If
            ElseIf e.Inner.MouseEventArgs.Button = Windows.Forms.MouseButtons.Right Then
                Dim pos As Point = New Point(e.Inner.MouseEventArgs.X, e.Inner.MouseEventArgs.Y)
                Dim col As Integer = 0
                Dim row As Integer = 0
                e.TableControl.PointToRowCol(pos, row, col)
                col = e.TableControl.TableDescriptor.ColIndexToField(col)
                If normalView_Renamed AndAlso e.Inner.RowIndex = 1 Then
                    e.Inner.Cancel = True
                    groupColumn_Renamed = CStr(e.TableControl.TableDescriptor.Columns(col).Name)
                    If groupColumn_Renamed = "Received" Then
                        groupColumn_Renamed = "date"
                    End If
                    If groupColumn_Renamed = "Size" Then
                        groupColumn_Renamed = "customSize"
                    End If

                    Me.normalViewPopUpMenu.Show(e.TableControl, pos)
                End If
                Dim tableCellStyle As GridTableCellStyleInfo = e.TableControl.GetTableViewStyleInfo(row, col)

                Dim contextElement As Element = tableCellStyle.TableCellIdentity.DisplayElement
                If e.Inner.RowIndex > 1 AndAlso TypeOf contextElement Is GridCaptionRow Then
                    Dim count As Integer = 0
                    e.TableControl.Table.CurrentElement = e.TableControl.Table.NestedDisplayElements(row)
                    Dim i As Integer = 0
                    'ORIGINAL LINE: for (int i = 0; i <= e.Inner.RowIndex; i += 1)
                    'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                    Do While i <= e.Inner.RowIndex
                        Dim elt As Element = Me.gridGroupingControl1.Table.NestedDisplayElements(i)
                        If elt.Kind = DisplayElementKind.Caption Then
                            count += 1
                        End If
                        i += 1
                    Loop
                    countas = count
                    Me.CaptionPopupMenu.Show(e.TableControl, pos)
                End If
                ' Not a right way for this condition is the try - catch used
                If Me.PreviewSelected AndAlso TypeOf contextElement Is GridRecordPreviewRow Then
                    If Convert.ToInt32(contextElement.GetRecord().GetValue("ReadState")) = 0 Then
                        Me.MarkfromRecordBarItem.Text = "Mar&k as Read"
                    Else
                        Me.MarkfromRecordBarItem.Text = "Mark as U&nread"
                    End If
                    If Convert.ToInt32(contextElement.GetRecord().GetValue("ReadState")) = 0 Then
                        Me.MarkfromRecordBarItem.ImageIndex = 1
                    Else
                        Me.MarkfromRecordBarItem.ImageIndex = 0
                    End If
                    Me.RecordPopupMenu.Show(e.TableControl, pos)
                ElseIf e.Inner.RowIndex > 1 AndAlso TypeOf e.TableControl.Table.CurrentElement Is GridRecord Then
                    Try
                        Dim r As GridRecord = CType(e.TableControl.Table.CurrentElement, GridRecord)
                        r.SetCurrent()
                        Dim style As GridTableCellStyleInfo = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex)
                        If Not style.TableCellIdentity.Column Is Nothing AndAlso style.TableCellIdentity.Column.Name = "flag" Then
                            record = r.Id
                            rowas = row
                            Me.flagPopupMenu.Show(e.TableControl, pos)
                        ElseIf Not style.TableCellIdentity.Column Is Nothing AndAlso style.TableCellIdentity.Column.Name = "Category" Then
                            record = r.Id
                            rowas = row
                            Me.categoryPopUpMenu.Show(e.TableControl, pos)
                        Else
                            record = r.Id ' For the sake of the flag through Follow up menu..
                            rowas = row
                            If Convert.ToInt32(r.GetValue("ReadState")) = 0 Then
                                Me.MarkfromRecordBarItem.Text = "Mar&k as Read"
                            Else
                                Me.MarkfromRecordBarItem.Text = "Mark as U&nread"
                            End If
                            If Convert.ToInt32(r.GetValue("ReadState")) = 0 Then
                                Me.MarkfromRecordBarItem.ImageIndex = 1
                            Else
                                Me.MarkfromRecordBarItem.ImageIndex = 0
                            End If

                            Me.RecordPopupMenu.Show(e.TableControl, pos)
                        End If

                    Catch 'System.InvalidCastException ex

                    End Try

                End If
            End If
		End Sub
		Private rowas, countas As Integer

		Private Sub TableModel_QueryCoveredRange(ByVal sender As Object, ByVal e As GridQueryCoveredRangeEventArgs)
			If Not normalView_Renamed Then
				Dim tm As GridTableModel = TryCast(sender, GridTableModel)
				Dim el As Element = tm.Table.DisplayElements(e.RowIndex)
				If TypeOf el Is ExtraSection Then
					e.Range = GridRangeInfo.Cells(e.RowIndex, 0, e.ColIndex, tm.ColCount)
					e.Handled = True
				End If
			End If
		End Sub

		Private Sub gridGroupingControl1_QueryValue(ByVal sender As Object, ByVal e As Syncfusion.Grouping.FieldValueEventArgs)
			Dim rd As Syncfusion.Grouping.Record = CType(e.Record, Syncfusion.Grouping.Record)
			Dim TodaysDate As DateTime = DateTime.Today
			Dim dt As DateTime = DateTime.Parse(Convert.ToDateTime(rd.GetValue("Received")).ToShortDateString())
			Dim dtvalue As System.TimeSpan = TodaysDate.Subtract(dt)
            Dim totdays As Integer
            If dtvalue.TotalDays < 1 Then
                totdays = 0
            Else
                totdays = CInt(Math.Round(dtvalue.TotalDays))
            End If
			If e.Field.Name = "date" Then
				e.Value = ComputePeriodReceived(totdays)
			End If
			If e.Field.Name = "customSize" Then
				Dim d As Double = Convert.ToDouble(rd.GetValue("Size"))
				If d < 10240 Then
					e.Value = 1
				ElseIf d < 25600 Then
					e.Value = 2
				ElseIf d < 102400 Then
					e.Value = 3
				ElseIf d < 512000 Then
					e.Value = 4
				ElseIf d < 1048576 Then
					e.Value = 5
				ElseIf d < 5242880 Then
					e.Value = 6
				Else
					e.Value = 7
				End If
			End If
		End Sub

		Private Sub Model_QueryColWidth(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
			If e.Index = 2 Then
				e.Size = 0
				e.Handled = True
			End If
		End Sub

		Private Sub GroupedColumns_Changed(ByVal sender As Object, ByVal e As ListPropertyChangedEventArgs)
			Dim scd As Syncfusion.Grouping.SortColumnDescriptor = TryCast(e.Item, Syncfusion.Grouping.SortColumnDescriptor)
			If e.Action = Syncfusion.Collections.ListPropertyChangedType.Insert OrElse e.Action = Syncfusion.Collections.ListPropertyChangedType.Add Then
				ClearChecks(parentBarItem_ArrangeBy)
				Me.barItem_Custom.Checked = False

				If scd.Name = "date" Then
					Me.barItem_Date.Checked = True
				End If
				If scd.Name = "customSize" Then
					Me.barItem_Size.Checked = True
				End If
				If scd.Name = "From" Then
					Me.barItem_From.Checked = True
				End If
				If scd.Name = "To" Then
					Me.barItem_To.Checked = True
				End If
				If scd.Name = "Subject" Then
					Me.barItem_Subject.Checked = True
				End If
				If scd.Name = "flag" Then
					Me.barItem_Flag.Checked = True
				End If
				If scd.Name = "Attachment" Then
					Me.barItem_Attachments.Checked = True
				End If
				If scd.Name = "Priority" Then
					Me.barItem_Importance.Checked = True
				End If

				If Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Count > 1 Then
					ClearChecks(parentBarItem_ArrangeBy)
					Me.barItem_Custom.Checked = True
				End If
			End If
			If e.Action = Syncfusion.Collections.ListPropertyChangedType.Remove Then
				ClearChecks(parentBarItem_ArrangeBy)
				Me.barItem_Custom.Checked = False
			End If

			If Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Count >= 1 Then
				Me.barItem_ShowInGroups.Checked = True
			Else
				Me.barItem_ShowInGroups.Checked = False
			End If
			If Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Count >= 1 Then
				For Each el As Element In Me.gridGroupingControl1.Table.DisplayElements
					If Not(TypeOf el Is GridRecordRow) Then
						Dim row As Integer = Me.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el)
						If Me.gridGroupingControl1.Table.NestedDisplayElements(row).IsCaption() Then
							Dim crow As GridCaptionRow = CType(el, GridCaptionRow)
							Dim gp As Group = crow.ParentGroup
							If gp.IsExpanded Then
								crow.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"))
							Else
								crow.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "plus.png"))
							End If
						End If
					End If
				Next el
			End If
		End Sub

		Private Sub GroupedColumns_Changing(ByVal sender As Object, ByVal e As Syncfusion.Collections.ListPropertyChangedEventArgs)
			Dim scd As Syncfusion.Grouping.SortColumnDescriptor = TryCast(e.Item, Syncfusion.Grouping.SortColumnDescriptor)
			If e.Action = Syncfusion.Collections.ListPropertyChangedType.Insert OrElse e.Action = Syncfusion.Collections.ListPropertyChangedType.Add Then
				'Custom sort with IComparer class below
				'				if (scd.Name == "date" && scd.Comparer == null)
				'					scd.Comparer = new CustomDateComparer();
				groupedBy = scd.Name

				gridGroupingControl1.TableDescriptor.Columns(scd.Name).Appearance.AnyRecordFieldCell.BackColor = Color.FromArgb(Form1.r, Form1.g, Form1.b)
			End If
			If e.Action = Syncfusion.Collections.ListPropertyChangedType.Remove Then
				If scd.Name = "date" Then
					groupedBy = ""
				End If
				If scd.Name = "customSize" Then
					groupedBy = ""
				End If
				gridGroupingControl1.TableDescriptor.Columns(scd.Name).Appearance.AnyRecordFieldCell.BackColor = Color.FromArgb(Form1.r, Form1.g, Form1.b)
			End If
		End Sub

		Private Sub gridGroupingControl1_TableControlCurrentCellActivating(ByVal sender As Object, ByVal e As GridTableControlCurrentCellActivatingEventArgs)
			e.Inner.ColIndex = 0
		End Sub

		' May be at the point teh preview is turned on we will add preview selection
		Private catchRecord, catchPreview, celling, floor As Integer
		Private Sub gridGroupingControl1_TableControlKeyDown(ByVal sender As Object, ByVal e As GridTableControlKeyEventArgs)
            Dim cc As GridCurrentCell = e.TableControl.CurrentCell
            Dim el As Element = Me.gridGroupingControl1.Table.GetInnerMostCurrentElement()
            Me.gridGroupingControl1.TableControl.Selections.Clear()
            Dim row As Integer = Me.gridGroupingControl1.Table.NestedDisplayElements.IndexOf(el)

            Dim foundRow As Integer = LocateSelectionToKey(e.Inner.KeyCode)
            If foundRow <> -1 Then
                Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Row(foundRow))
                Me.gridGroupingControl1.TableControl.ScrollCellInView(foundRow, 1, GridScrollCurrentCellReason.KeyPress)
            End If

            If Me.PreviewSelected Then
                If e.Inner.KeyCode = Keys.Down Then
                    '					if(celling > 0 && celling <= catchRecord)
                    '					{
                    '						catchPreview = catchRecord = celling;
                    '						celling = 0;
                    '					}

                    If catchRecord + 2 > gridGroupingControl1.Table.NestedDisplayElements.Count - 1 Then
                        If Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord).IsRecord() Then
                            catchPreview = catchRecord + 1
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                        ElseIf Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord + 1).IsCaption() Then
                            floor = catchRecord + 1
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord + 1, catchRecord + 1))
                        End If
                        '						else if(this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsCaption())
                        '						{
                        '							catchPreview = catchRecord;
                        '							this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview));
                        '						}
                    Else
                        ' Move down two by two in case of record & record preview
                        If Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord + 1).IsRecord() Then
                            ' Correct the indexes here
                            catchRecord -= 1
                        End If
                        If Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord + 2).IsRecord() Then
                            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                            'ORIGINAL LINE: Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord += 2, catchPreview += 2));
                            catchRecord = catchRecord + 2
                            catchPreview = catchPreview + 2
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                            ' in case of caption just select the caption
                        ElseIf Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord + 1).IsCaption() Then
                            ' Look from reverse * suppose looking ahead is full of captions
                            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                            'ORIGINAL LINE: Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord += 1, catchPreview += 1));
                            catchRecord = catchRecord + 1
                            catchPreview = catchPreview + 1
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                        ElseIf Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord + 2).IsCaption() Then
                            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                            'ORIGINAL LINE: Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord += 2, catchPreview += 1));
                            catchRecord = catchRecord + 2
                            catchPreview = catchPreview + 1
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                        End If
                    End If
                    ' Move the scroll bar together.. 
                    Me.gridGroupingControl1.TableControl.ScrollCellInView(catchRecord + 1, 1, GridScrollCurrentCellReason.KeyPress)
                End If
                If e.Inner.KeyCode = Keys.Up Then
                    If catchRecord - 2 < 2 Then
                        If Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord - 1).IsCaption() Then
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord - 1, catchRecord - 1))
                            catchPreview = catchRecord
                        ElseIf Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord).IsRecord() Then
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                        ElseIf Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord).IsCaption() Then
                            catchPreview = catchRecord
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                        End If
                    Else
                        ' Move up two by two in case of record & record preview
                        If Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord - 2).IsRecord() AndAlso catchPreview = catchRecord Then
                            catchPreview += 1 ' Correct the indexes here
                        End If
                        If Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord - 2).IsRecord() Then
                            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                            'ORIGINAL LINE: Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord -= 2, catchPreview -= 2));
                            catchRecord = catchRecord - 2
                            catchPreview = catchPreview - 2
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                            ' in case of caption just select the caption
                        ElseIf Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord - 1).IsCaption() Then
                            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                            'ORIGINAL LINE: Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord -= 1, catchPreview -= 2));
                            catchRecord = catchRecord - 1
                            catchPreview = catchPreview - 2
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                        End If
                    End If
                    ' Move the scroll bar together.. 
                    Me.gridGroupingControl1.TableControl.ScrollCellInView(catchRecord, 1, GridScrollCurrentCellReason.KeyPress)
                End If
                If e.Inner.KeyCode = Keys.Left Then
                    If catchRecord - 2 < 2 Then
                        ' Might need to collapse
                        If Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord - 1).IsCaption() Then
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord - 1, catchRecord - 1))
                            Dim count As Integer = 0
                            Dim i As Integer = 0
                            'ORIGINAL LINE: for (int i = 0; i < catchRecord - 1; i += 1)
                            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                            Do While i < catchRecord - 1
                                Dim elt As Element = Me.gridGroupingControl1.Table.NestedDisplayElements(i)
                                If elt.Kind = DisplayElementKind.Caption Then
                                    count += 1
                                End If
                                i += 1
                            Loop
                            e.TableControl.Table.TopLevelGroup.Groups(count).IsExpanded = False
                            catchPreview = catchRecord
                            celling = catchRecord - 1
                        ElseIf Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord).IsRecord() Then
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                        ElseIf Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord).IsCaption() Then
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchRecord))
                            catchPreview = catchRecord
                        End If
                    Else
                        If floor >= catchRecord Then
                            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                            'ORIGINAL LINE: catchPreview = catchRecord = floor;
                            catchRecord = floor
                            catchPreview = catchRecord
                            floor = 0
                        End If
                        ' Collapse the group and move up
                        If Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord - 1).IsCaption() AndAlso catchPreview = catchRecord Then
                            ' Correct the indexes here
                            catchPreview += 1
                        End If
                        If Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord - 2).IsRecord() AndAlso catchPreview = catchRecord Then
                            ' Correct the indexes here
                            catchPreview += 1
                        End If
                        If Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord - 2).IsRecord() Then
                            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                            'ORIGINAL LINE: Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord -= 2, catchPreview -= 2));
                            catchRecord = catchRecord - 2
                            catchPreview = catchPreview - 2
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                            ' in case of caption just select the caption
                        ElseIf Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord - 1).IsCaption() Then
                            Dim count As Integer = 0
                            Dim i As Integer = 0
                            'ORIGINAL LINE: for (int i = 0; i < catchRecord - 1; i += 1)
                            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                            Do While i < catchRecord - 1
                                Dim elt As Element = Me.gridGroupingControl1.Table.NestedDisplayElements(i)
                                If elt.Kind = DisplayElementKind.Caption Then
                                    count += 1
                                End If
                                i += 1
                            Loop
                            e.TableControl.Table.TopLevelGroup.Groups(count).IsExpanded = False
                            ' Look from reverse * suppose looking ahead is full of captions
                            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                            'ORIGINAL LINE: Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord -= 1, catchPreview -= 2));
                            catchRecord = catchRecord - 1
                            catchPreview = catchPreview - 2
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                        End If
                    End If
                    ' Move the scroll bar together.. 
                    e.TableControl.ScrollCellInView(catchRecord, 1, GridScrollCurrentCellReason.KeyPress)
                End If
                If e.Inner.KeyCode = Keys.Right Then
                    If celling > 0 AndAlso celling <= catchRecord Then
                        'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                        'ORIGINAL LINE: catchPreview = catchRecord = celling;
                        catchRecord = celling
                        catchPreview = catchRecord
                        celling = 0
                    End If
                    If catchRecord + 2 > gridGroupingControl1.Table.NestedDisplayElements.Count - 1 Then
                        If Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord).IsRecord() Then
                            catchPreview = catchRecord + 1
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                        End If
                        '						else if(this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsCaption())
                        '						{
                        '							int count =0;
                        '							for(int i = 0; i < catchRecord+1; i++)
                        '							{
                        '								Element elt = this.gridGroupingControl1.Table.NestedDisplayElements[i];
                        '								if(elt.Kind == DisplayElementKind.Caption)
                        '									count++;
                        '							}
                        '							e.TableControl.Table.TopLevelGroup.Groups[count].IsExpanded = true;
                        '							this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord+=1, catchPreview+=1));
                        '						}
                    Else
                        ' Expand the group and Move Down 
                        ' Move down two by two in case of record & record preview
                        If Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord + 1).IsRecord() Then
                            ' Correct the indexes here
                            catchRecord -= 1
                        End If
                        If Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord + 2).IsRecord() Then
                            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                            'ORIGINAL LINE: Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord += 2, catchPreview += 2));
                            catchRecord = catchRecord + 2
                            catchPreview = catchPreview + 2
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                            ' in case of caption just select the caption
                        ElseIf Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord).IsCaption() Then
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                            'Expand the first caption..
                            e.TableControl.Table.TopLevelGroup.Groups(0).IsExpanded = True
                        ElseIf Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord + 1).IsCaption() Then
                            ' Look from reverse * suppose looking ahead is full of captions
                            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                            'ORIGINAL LINE: Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord += 1, catchPreview += 1));
                            catchRecord = catchRecord + 1
                            catchPreview = catchPreview + 1
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                            Dim count As Integer = 0
                            Dim i As Integer = 0
                            'ORIGINAL LINE: for (int i = 0; i < catchRecord + 1; i += 1)
                            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                            Do While i < catchRecord + 1
                                Dim elt As Element = Me.gridGroupingControl1.Table.NestedDisplayElements(i)
                                If elt.Kind = DisplayElementKind.Caption Then
                                    count += 1
                                End If
                                i += 1
                            Loop
                            e.TableControl.Table.TopLevelGroup.Groups(count).IsExpanded = True
                        ElseIf Me.gridGroupingControl1.Table.NestedDisplayElements(catchRecord + 2).IsCaption() Then
                            Dim count As Integer = 0
                            Dim i As Integer = 0
                            'ORIGINAL LINE: for (int i = 0; i < catchRecord + 2; i += 1)
                            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                            Do While i < catchRecord + 2
                                Dim elt As Element = Me.gridGroupingControl1.Table.NestedDisplayElements(i)
                                If elt.Kind = DisplayElementKind.Caption Then
                                    count += 1
                                End If
                                i += 1
                            Loop
                            e.TableControl.Table.TopLevelGroup.Groups(count).IsExpanded = True
                            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                            'ORIGINAL LINE: Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord += 2, catchPreview += 1));
                            catchRecord = catchRecord + 2
                            catchPreview = catchPreview + 1
                            Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchPreview))
                        End If
                    End If
                    ' Move the scroll bar together.. 
                    Me.gridGroupingControl1.TableControl.ScrollCellInView(catchRecord + 1, 1, GridScrollCurrentCellReason.KeyPress)
                End If

            Else
                If e.Inner.KeyCode = Keys.Up Then
                    ' Move up one by one
                    If row > 2 Then ' dont move to header
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row - 1))
                    Else
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row))
                    End If

                End If
                If e.Inner.KeyCode = Keys.Down Then
                    ' Move down one by one
                    If row < gridGroupingControl1.Table.NestedDisplayElements.Count - 1 Then ' stop by the last row
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row + 1))
                    Else
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row))
                    End If
                End If
                If e.Inner.KeyCode = Keys.Left Then
                    If row <= 2 Then ' dont move to header
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row))
                    Else
                        'Close this group and move up one by one 
                        If TypeOf el Is GridRecord Then
                            'No code necessary! // Worked in Laptop version *to be checked
                            e.TableControl.CurrentCell.MoveUp()
                            e.TableControl.Selections.Add(GridRangeInfo.Row(row - 1))
                        End If
                        'With MoveUp caption row is recoganized instead of record
                        If TypeOf el Is GridCaptionRow Then
                            Dim crow As GridCaptionRow = CType(el, GridCaptionRow)
                            el.ParentGroup.IsExpanded = False
                            e.TableControl.CurrentCell.MoveUp()
                            e.TableControl.Selections.Add(GridRangeInfo.Row(row - 1))
                        End If
                    End If
                End If
                If e.Inner.KeyCode = Keys.Right Then
                    'expand the cloapsed group and move down one by one
                    If TypeOf el Is GridCaptionRow Then
                        'if(this.gridGroupingControl1.Table.NestedDisplayElements[row].IsCaption())
                        Dim count As Integer = 0
                        Dim i As Integer = 0
                        'ORIGINAL LINE: for (int i = 0; i < row; i += 1)
                        'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                        Do While i < row
                            Dim elt As Element = Me.gridGroupingControl1.Table.NestedDisplayElements(i)
                            If elt.Kind = DisplayElementKind.Caption Then
                                count += 1
                            End If
                            i += 1
                        Loop
                        e.TableControl.Table.TopLevelGroup.Groups(count).IsExpanded = True
                        e.TableControl.CurrentCell.MoveDown()
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row + 1))
                    End If

                    If TypeOf el Is GridRecord Then
                        'if(this.gridGroupingControl1.Table.NestedDisplayElements[row].IsRecord())
                        e.TableControl.CurrentCell.MoveDown()
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row + 1))
                    End If
                    '&& e.TableControl.Selections.Count == 0

                    If row >= e.TableControl.Table.NestedDisplayElements.Count - 2 AndAlso e.TableControl.Selections.Count > 1 Then ' Stop by last row
                        e.TableControl.Selections.Add(GridRangeInfo.Row(row))
                    End If
                    Console.WriteLine("From KeyDown " & e.TableControl.Selections.Count)
                End If
            End If
		End Sub
		''' <summary>
		''' 
		''' </summary>
		''' <param name="key">enum System.Windows.Form.Keys is passed from KeyDown handler</param>
		''' <returns>The rowindex in the display elements for the </returns>
		Private Function LocateSelectionToKey(ByVal key As Keys) As Integer
			' Check if the key is valid
			If CInt(Fix(key)) > CInt(Keys.Z) OrElse CInt(Fix(key)) < CInt(Keys.A) Then
				Return -1
			End If
			Dim notfound As Boolean = True
			' loop throgh the caption 
			' check for the starting text that matches with the the key
			' send the row number to mark selection in that caption
			Do While notfound
				For row As Integer = 2 To Me.gridGroupingControl1.Table.DisplayElements.Count - 1
					' check every caption element..
					If Me.gridGroupingControl1.Table.DisplayElements(row).IsCaption() Then
						Dim element As Element = CType(Me.gridGroupingControl1.Table.DisplayElements(row), Element)
						Dim captionRow As GridCaptionRow = CType(element, GridCaptionRow)
						Dim foundString As String = captionRow.ParentGroup.Category.ToString()
						If foundString.StartsWith(key.ToString()) Then
							notfound = False
							Return row
						End If
					End If
				Next row
                If key = Keys.Z Then
                    key = Keys.A
                Else
                    key = key
                End If
				' Search next alphabet
				key = CType(CInt(Fix(key)) + 1, Keys)

			Loop
			Return 0
		End Function

		Private Sub gridGroupingControl1_Resize(ByVal sender As Object, ByVal e As EventArgs)
			CType(sender, GridGroupingControl).Invalidate(True)
		End Sub


		Private Sub TableControl_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As GridPrepareViewStyleInfoEventArgs)
			If e.RowIndex > 0 AndAlso e.ColIndex > 0 Then
				If Me.gridGroupingControl1.TableControl.Selections.GetSelectedRows(True, False).AnyRangeContains(GridRangeInfo.Row(e.RowIndex)) Then
					e.Style.TextColor = SystemColors.ControlText
					'e.Style.BackColor = SystemColors.Highlight;
					e.Style.BackColor = SystemColors.GradientInactiveCaption

					If e.ColIndex = Me.gridGroupingControl1.TableDescriptor.Columns.IndexOf("flag") + 2 Then
						Try
							'e.Style.BackColor = UsedColors(Convert.ToInt32(e.Style.CellValue));

							' If Mouse Hovers..
							Dim mousePosition As Point = Cursor.Position
							Dim rect As Rectangle = Me.gridGroupingControl1.TableControl.RangeInfoToRectangle(GridRangeInfo.Cell(e.RowIndex, e.ColIndex))
							Dim RectToScreen As Rectangle = Me.gridGroupingControl1.TableControl.RectangleToScreen(rect)
							If RectToScreen.Contains(mousePosition) Then
								e.Style.BackColor = SystemColors.Info
							End If
						Catch
						End Try
					End If
				End If

				Dim style As GridTableCellStyleInfo = CType(e.Style, GridTableCellStyleInfo)

				If style.TableCellIdentity.TableCellType = GridTableCellType.GroupCaptionPlusMinusCell Then
					e.Style.TextColor = SystemColors.Desktop
				End If
			End If
		End Sub


		Private Sub Model_SelectionChanging(ByVal sender As Object, ByVal e As GridSelectionChangingEventArgs)
			Dim ForcedCancel As Boolean = False
			If Control.MouseButtons = MouseButtons.Right Then
				e.Cancel = True
				'ForcedCancel = true;
			End If
			' use the Nested display elements to know the selection is of record or caption
			Dim row As Integer = e.Range.Top
			If (Not ForcedCancel) AndAlso row = 0 Then ' this helps in preview selection on readstate but lately..
				Dim rangeInfo As GridRangeInfoList
				Dim check As Boolean = Me.gridGroupingControl1.TableControl.Selections.GetSelectedRanges(rangeInfo, True)

				row = rangeInfo.ActiveRange.Top
				Console.WriteLine(check & " " & row)
			End If
			' If the selection is of record and Unread, then mark that as Read
			If Me.gridGroupingControl1.Table.NestedDisplayElements(row) IsNot Nothing AndAlso Me.gridGroupingControl1.Table.NestedDisplayElements(row).IsRecord() Then
				Dim r As Record = CType(Me.gridGroupingControl1.Table.NestedDisplayElements(row).GetRecord(), Record)
				If Convert.ToInt32(r.GetValue("ReadState")) = 0 AndAlso e.Reason = (GridSelectionReason.MouseDown Or GridSelectionReason.ArrowKey) Then
					r.SetValue("ReadState", 1)
				End If
			End If
		End Sub
		Private Sub gridGroupingControl1_GroupCollapsed(ByVal sender As Object, ByVal e As GroupEventArgs)
			Dim gcr As GridCaptionRow = CType(e.Group.Caption.CaptionRows(0), GridCaptionRow)
			gcr.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "plus.png"))
		End Sub

		Private Sub gridGroupingControl1_GroupExpanded(ByVal sender As Object, ByVal e As GroupEventArgs)
			Dim gcr As GridCaptionRow = CType(e.Group.Caption.CaptionRows(0), GridCaptionRow)
			gcr.Appearance.GroupCaptionPlusMinusCell.CellValue = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("res", "minus.png"))
		End Sub

		Private Sub GridGroupDropArea_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As GridPrepareViewStyleInfoEventArgs)
			e.Style.Font.Facename = "Corbel"

			If e.Style.Text <> " " Then
				If e.Style.Text.StartsWith("Drag a") Then
					e.Style.TextColor = Color.FromArgb(22, 74, 167)
				End If
			End If
			e.Style.Borders.All = New GridBorder(GridBorderStyle.None)
		End Sub

		Private Sub gridGroupingControl1_TableControlCellDrawn(ByVal sender As Object, ByVal e As GridTableControlDrawCellEventArgs)
			If e.Inner.RowIndex = 1 Then
				Dim rect1 As Rectangle = e.Inner.Bounds
				rect1.X = (rect1.X + rect1.Width) - 10
				rect1.Width = 10
				rect1.Y = (rect1.Y + rect1.Height) - 16
				rect1.Height = 10
				e.Inner.Graphics.DrawLine(New Pen(Color.FromArgb(Form1.r, Form1.g, Form1.b)), New Point(rect1.X + 9, rect1.Y - 2), New Point(rect1.X + 9, rect1.Y + 12))
				e.Inner.Graphics.DrawLine(Pens.AliceBlue, New Point(rect1.X + 10, rect1.Y - 2), New Point(rect1.X + 10, rect1.Y + 12))
				Dim colName As String = e.Inner.Style.Text
				If colName = "Subject" OrElse colName = "Received" OrElse colName = "From" OrElse colName = "Size" Then
					Dim style As GridTableCellStyleInfo = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex)
					If style.Tag IsNot Nothing Then
						Dim rect As Rectangle = e.Inner.Bounds
						rect.X = (rect.X + rect.Width) - 25
						rect.Width = 10
						rect.Y = (rect.Y + rect.Height) - 15
						rect.Height = 10
						If style.Tag.ToString() = "Ascending" Then
							Dim p1 As New Point(rect.X - 4, rect.Y + 6)
							Dim p2 As New Point(rect.X, rect.Y + 2)
							Dim p3 As New Point(rect.X + 4, rect.Y + 6)

							e.Inner.Graphics.DrawLine(New Pen(Color.FromArgb(154, 198, 255)), p2, p3)
							e.Inner.Graphics.DrawLine(New Pen(Color.FromArgb(154, 198, 255)), p3, p1)
							e.Inner.Graphics.DrawLine(New Pen(Color.FromArgb(154, 198, 255)), p1, p2)
							e.Inner.Graphics.FillPolygon(New SolidBrush(SortIconColor), New Point() { p1, p2, p3 })
						Else
							Dim p1 As New Point(rect.X - 4, rect.Y + 2)
							Dim p2 As New Point(rect.X, rect.Y + 6)
							Dim p3 As New Point(rect.X + 4, rect.Y + 2)

							e.Inner.Graphics.DrawLine(New Pen(Color.FromArgb(154, 198, 255)), p1, p2)
							e.Inner.Graphics.DrawLine(New Pen(Color.FromArgb(154, 198, 255)), p3, p1)
							e.Inner.Graphics.DrawLine(New Pen(Color.FromArgb(154, 198, 255)), p2, p3)
							e.Inner.Graphics.FillPolygon(New SolidBrush(SortIconColor), New Point() { p1, p2, p3 })
						End If
					End If
				End If
			End If
		End Sub
		#End Region

		#Region "Custom event handlers"

		Private Sub GroupingPanel_Changed(ByVal sender As Object, ByVal e As EventArgs)
			' the state before event is only known
			If Not Me.NormalView Then
				Me.gridGroupingControl1.Table.TableDirty = True
				' NormalStyle without column sets
				Me.gridGroupingControl1.TableDescriptor.ColumnSets.Clear()
				RollBackSizeChanges()
				' Also remove the custom section
				EnableCustomSection(False)
				'show the default column headers 
				Me.gridGroupingControl1.TopLevelGroupOptions.ShowColumnHeaders = True
			Else
				CreateColumnSetView(numberOfLayers_Renamed)
				EnableCustomSection(False) ' true
				' Hide the default multi headers to a header in the custom section..
				Me.gridGroupingControl1.TopLevelGroupOptions.ShowColumnHeaders = False
			End If
		End Sub

		Private Sub GroupingPanel_CancelGroup(ByVal sender As Object, ByVal e As EventArgs)
			If groupedBy = "date" OrElse groupedBy = "customSize" Then
				For Each cd As GridColumnDescriptor In Me.gridGroupingControl1.TableDescriptor.Columns
					cd.AllowGroupByColumn = False
				Next cd
				MessageBox.Show("Cannot Group items by this field")
			Else
				For Each cd As GridColumnDescriptor In Me.gridGroupingControl1.TableDescriptor.Columns
					cd.AllowGroupByColumn = True
				Next cd
			End If
		End Sub

		Private Sub GroupingPanel_ShowViewChanged(ByVal sender As Object, ByVal e As EventArgs)
			'			if(this.gridGroupingControl1.TableOptions.ShowRecordPreviewRow )
			'			{
			'				int catchRecord = this.gridGroupingControl1.TableControl.Selections.Ranges.ActiveRange.Top;
			'
			'				//this.gridGroupingControl1.TableControl.Selections.Clear();
			'				//Console.WriteLine(this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].ToString());
			'				//if(this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsRecord())
			'				this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Row(10));
			'			}
			'			else
			'			{			
			'				int catchRecord = this.gridGroupingControl1.TableControl.Selections.Ranges.ActiveRange.Top;
			'				//int catchPreview = this.gridGroupingControl1.TableControl.Selections.Ranges.ActiveRange.Bottom;
			'				this.gridGroupingControl1.TableControl.Selections.Clear();
			'				//if(this.gridGroupingControl1.Table.NestedDisplayElements[catchRecord].IsRecord())			
			'				this.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Rows(catchRecord, catchRecord));
			'			}
		End Sub
		#End Region

		#End Region

		#Region "Menus"

		#Region "Normal view Popup menu handlers"

		Private Sub barItem_Attachments_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_Attachments.Click
			ClearChecks(parentBarItem_ArrangeBy)
			Me.barItem_Custom.Checked = False
			ShowGroupDropArea()
			Me.barItem_Attachments.Checked = True
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("attachments")
		End Sub

		Private Sub barItem_Conversation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_Conversation.Click
			ClearChecks(parentBarItem_ArrangeBy)
			Me.barItem_Custom.Checked = False
			ShowGroupDropArea()
			Me.barItem_Conversation.Checked = True

			If Me.gridGroupingControl1.TableDescriptor.Columns.Contains("conversation") Then
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("conversation")
			Else
				MessageBox.Show("Is not currently supported")
			End If
		End Sub

		Private Sub barItem_EmailAccounts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_EmailAccounts.Click
			ClearChecks(parentBarItem_ArrangeBy)
			Me.barItem_Custom.Checked = False
			ShowGroupDropArea()
			Me.barItem_EmailAccounts.Checked = True

			If Me.gridGroupingControl1.TableDescriptor.Columns.Contains("emailAccounts") Then
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("emailAccounts")
			Else
				MessageBox.Show("Is not currently supported")
			End If
		End Sub

		Private Sub barItem_Importance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_Importance.Click
			ClearChecks(parentBarItem_ArrangeBy)
			Me.barItem_Custom.Checked = False
			ShowGroupDropArea()
			Me.barItem_Importance.Checked = True

			If Me.gridGroupingControl1.TableDescriptor.Columns.Contains("Priority") Then
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Priority")
			Else
				MessageBox.Show("Is not currently supported")
			End If
		End Sub

		Private Sub barItem_Categories_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_Categories.Click
			ClearChecks(parentBarItem_ArrangeBy)
			Me.barItem_Custom.Checked = False
			ShowGroupDropArea()
			Me.barItem_Categories.Checked = True
			If Me.gridGroupingControl1.TableDescriptor.Columns.Contains("Categories") Then
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Categories")
			Else
				MessageBox.Show("Is not currently supported")
			End If
		End Sub

		Private Sub barItem_Flag_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_Flag.Click
			ClearChecks(parentBarItem_ArrangeBy)
			Me.barItem_Custom.Checked = False
			ShowGroupDropArea()
			Me.barItem_Flag.Checked = True
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("flag")
		End Sub

		Private Sub barItem_Type_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_Type.Click
			ClearChecks(parentBarItem_ArrangeBy)
			Me.barItem_Custom.Checked = False
			ShowGroupDropArea()
			Me.barItem_Type.Checked = True
			If Me.gridGroupingControl1.TableDescriptor.Columns.Contains("Type") Then
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Type")
			Else
				MessageBox.Show("Is not currently supported")
			End If
		End Sub

		Private Sub barItem_GroupByBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_GroupByBox.Click
			Me.gridGroupingControl1.ShowGroupDropArea = Not Me.gridGroupingControl1.ShowGroupDropArea
		End Sub

		Private Sub barItem_Subject_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_Subject.Click
			ClearChecks(parentBarItem_ArrangeBy)
			Me.barItem_Custom.Checked = False
			ShowGroupDropArea()
			Me.barItem_Subject.Checked = True
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Subject")
		End Sub

		Private Sub barItem_From_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_From.Click
			ClearChecks(parentBarItem_ArrangeBy)
			Me.barItem_Custom.Checked = False
			ShowGroupDropArea()
			Me.barItem_From.Checked = True
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("From")
		End Sub

		Private Sub barItem_Date_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_Date.Click
			ClearChecks(parentBarItem_ArrangeBy)
			Me.barItem_Custom.Checked = False
			ShowGroupDropArea()
			Me.barItem_Date.Checked = True
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("date")
		End Sub

		Private Sub barItem_Size_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_Size.Click
			ClearChecks(parentBarItem_ArrangeBy)
			Me.barItem_Custom.Checked = False
			ShowGroupDropArea()
			Me.barItem_Size.Checked = True
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("customSize")
			'this.gridGroupingControl1.TableDescriptor.Columns["customSize"].HeaderText = "Size";
		End Sub

		Private Sub barItem_ShowInGroups_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_ShowInGroups.Click
			Me.barItem_ShowInGroups.Checked = Not Me.barItem_ShowInGroups.Checked
			ShowGroupDropArea()
		End Sub

		Private Sub barItem_GroupByThisField_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_GroupByThisField.Click
			Dim flag As Boolean = False
			For Each des As SortColumnDescriptor In Me.gridGroupingControl1.TableDescriptor.GroupedColumns
				If des.Name = groupColumn_Renamed Then
					flag = True
				End If
			Next des
			If Not flag Then
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add(groupColumn_Renamed)
			End If
		End Sub

		Private Sub barItem_SortAscending_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_SortAscending.Click
			Me.gridGroupingControl1.TableDescriptor.SortedColumns.Remove(groupColumn_Renamed)
			Me.gridGroupingControl1.TableDescriptor.SortedColumns.Add(groupColumn_Renamed, ListSortDirection.Ascending)
		End Sub

		Private Sub barItem_sortDescending_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_sortDescending.Click
			Me.gridGroupingControl1.TableDescriptor.SortedColumns.Remove(groupColumn_Renamed)
			Me.gridGroupingControl1.TableDescriptor.SortedColumns.Add(groupColumn_Renamed, ListSortDirection.Descending)
		End Sub

		Private Sub barItem_RemoveThisColumn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_RemoveThisColumn.Click
			If groupColumn_Renamed = "date" Then
				groupColumn_Renamed = "Received"
			End If
			If groupColumn_Renamed = "customSize" Then
				groupColumn_Renamed = "Size"
			End If
			'this.gridGroupingControl1.TableDescriptor.VisibleColumns.Remove(groupColumn);
			Me.gridGroupingControl1.TableDescriptor.Columns.Remove(groupColumn_Renamed)
		End Sub

		Private Sub barItem_FieldChooser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_FieldChooser.Click
			Dim hiddenCols(Me.gridGroupingControl1.TableDescriptor.Columns.Count - 1) As String
			Dim flag As Boolean = False
			Dim hiddenIndex As Integer = 0
			Dim temp As String
			For i As Integer = 0 To hiddenCols.Length - 1
				temp = Me.gridGroupingControl1.TableDescriptor.Columns(i).Name
				For j As Integer = 0 To visibleCols.Length - 1
					If visibleCols(j).CompareTo(temp) = 0 Then
						flag = True
						Exit For
					End If
				Next j
				If Not flag Then
					hiddenCols(hiddenIndex) = temp
					hiddenIndex += 1
				Else
					flag = False
				End If
			Next i
			Dim dlg As New FieldChooserDialog(hiddenCols, visibleCols)
			If dlg.ShowDialog() = DialogResult.OK Then
				Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Clear()
				For Each str As String In dlg.SelectedFields
					Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Add(str)
				Next str
			End If
		End Sub

		Private Sub barItem_CustomizeCurrentView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem_CustomizeCurrentView.Click
			'			CurrentView curView=new CurrentView(this);
			'			curView.ShowDialog();
		End Sub

		#End Region

		#Region "Flag Menu context menu handlers"

		Private Sub redFlagBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles todayBarItem.Click, todayRecordBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("flag", CInt(flags.Red))
		End Sub

		Private Sub blueFlagBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tomoBarItem.Click, tomoRecordBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("flag", CInt(flags.Blue))
		End Sub

		Private Sub yellowFlagBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles thisweekFlagBarItem.Click, thisweekRecordBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("flag", CInt(flags.Yellow))
		End Sub

		Private Sub greenFlagBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nextweekFlagBarItem.Click, nextweekRecordBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("flag", CInt(flags.Green))
		End Sub

		Private Sub orangeFlagBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nodateFlagBarItem.Click, nodateRecordBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("flag", CInt(flags.Orange))
		End Sub

		Private Sub purpleFlagBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles customFlagBarItem.Click, customRecordBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("flag", CInt(flags.Purple))
		End Sub

		Private Sub flagCompleteBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles setquickclickBarItem.Click, addreminderRecordBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("flag", CInt(flags.Complete))
		End Sub

		Private Sub addReminderBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles addReminderBarItem.Click

		End Sub

		Private Sub clearFlagBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles markcompleteFlagBarItem.Click, ClearFlagfromRecordBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("flag", CInt(flags.Clear))
		End Sub

		Private Sub redAsDefaultBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles redAsDefaultBarItem.Click, RedAsDefaultfromRecordBarItem.Click
			Dim barItem As BarItem = TryCast(sender, BarItem)
			Me.DefaultFlag = flags.Red
			ClearChecks(FollowUpParentBarItem)
			ClearChecks(clearflagParentBarItem)
			ClearChecks(RecordFollowUpParentBarItem)
			Me.RedAsDefaultfromRecordBarItem.Checked = True
			Me.todayCaptionBarItem.Checked = Me.RedAsDefaultfromRecordBarItem.Checked
			Me.redAsDefaultBarItem.Checked = Me.todayCaptionBarItem.Checked
		End Sub

		Private Sub blueAsDefaultBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles blueAsDefaultBarItem.Click, BlueasDefaultfromRecordBarItem.Click
			Me.DefaultFlag = flags.Blue
			ClearChecks(FollowUpParentBarItem)
			ClearChecks(clearflagParentBarItem)
			ClearChecks(RecordFollowUpParentBarItem)
			Me.BlueasDefaultfromRecordBarItem.Checked = True
			Me.tomoCaptionBarItem.Checked = Me.BlueasDefaultfromRecordBarItem.Checked
			Me.blueAsDefaultBarItem.Checked = Me.tomoCaptionBarItem.Checked
		End Sub

		Private Sub yellowAsDefaultBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles yellowAsDefaultBarItem.Click, YellowasDefaultfromRecordBarItem.Click
			Me.DefaultFlag = flags.Yellow
			ClearChecks(FollowUpParentBarItem)
			ClearChecks(clearflagParentBarItem)
			ClearChecks(RecordFollowUpParentBarItem)
			Me.YellowasDefaultfromRecordBarItem.Checked = True
			Me.thisweekfromCaptionBarItem.Checked = Me.YellowasDefaultfromRecordBarItem.Checked
			Me.yellowAsDefaultBarItem.Checked = Me.thisweekfromCaptionBarItem.Checked
		End Sub

		Private Sub greenAsDefaultBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles greenAsDefaultBarItem.Click, GreenasDefaultfromRecordBarItem.Click
			Me.DefaultFlag = flags.Green
			ClearChecks(FollowUpParentBarItem)
			ClearChecks(clearflagParentBarItem)
			ClearChecks(RecordFollowUpParentBarItem)
			Me.GreenasDefaultfromRecordBarItem.Checked = True
			Me.nextweekCaptionBarItem.Checked = Me.GreenasDefaultfromRecordBarItem.Checked
			Me.greenAsDefaultBarItem.Checked = Me.nextweekCaptionBarItem.Checked
		End Sub

		Private Sub orangeAsDefaultBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles orangeAsDefaultBarItem.Click, OrangeasDefaultfromRecordBarItem.Click
			Me.DefaultFlag = flags.Orange
			ClearChecks(FollowUpParentBarItem)
			ClearChecks(clearflagParentBarItem)
			ClearChecks(RecordFollowUpParentBarItem)
			Me.OrangeasDefaultfromRecordBarItem.Checked = True
			Me.markcompletefromCaptionBarItem.Checked = Me.OrangeasDefaultfromRecordBarItem.Checked
			Me.orangeAsDefaultBarItem.Checked = Me.markcompletefromCaptionBarItem.Checked
		End Sub

		Private Sub purpleAsDefaultBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles purpleAsDefaultBarItem.Click, PurpleasDefaultfromRecordBarItem.Click
			Me.DefaultFlag = flags.Purple
			ClearChecks(FollowUpParentBarItem)
			ClearChecks(clearflagParentBarItem)
			ClearChecks(RecordFollowUpParentBarItem)
			Me.clearflagCaptionBarItem.Checked = True
			Me.PurpleasDefaultfromRecordBarItem.Checked = Me.clearflagCaptionBarItem.Checked
			Me.purpleAsDefaultBarItem.Checked = Me.PurpleasDefaultfromRecordBarItem.Checked
		End Sub
		#End Region

		#Region "Record fields context menu handlers"

		Private Sub MarkfromRecordBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MarkfromRecordBarItem.Click
			If Convert.ToInt32(Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().GetValue("ReadState")) = 1 Then
				Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("ReadState", 0)
			ElseIf Convert.ToInt32(Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().GetValue("ReadState")) = 0 Then
				Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("ReadState", 1)
			End If
		End Sub

		Private Sub DeletefromRecordBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeletefromRecordBarItem.Click
			'Should take it to the delete table
			Dim dr As DataRow = TryCast(Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().GetData(), DataRow)
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().Delete()
		End Sub

		#End Region

		#Region "Caption PopUp Menu Handlers"

		Private Sub collapseAllGroupsBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles collapseAllGroupsBarItem.Click
			Me.gridGroupingControl1.Table.CollapseAllGroups()
			Me.gridGroupingControl1.Refresh()
		End Sub

		Private Sub ExpandAllGroupsBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExpandAllGroupsBarItem.Click
			Dim i As Integer = 0
			Dim count As Integer = 0
			Me.gridGroupingControl1.Table.ExpandAllGroups()
			Do
				Dim elt As Element = Me.gridGroupingControl1.Table.NestedDisplayElements(i)
				i += 1
                If elt.Kind = DisplayElementKind.Caption Then
                    count += 1
                End If
			Loop While count < countas

			Me.gridGroupingControl1.TableControl.Selections.Clear()
			Me.gridGroupingControl1.TableControl.Selections.Add(GridRangeInfo.Row(i))
			'this.gridGroupingControl1.Refresh();
		End Sub

		Private Sub RedfromCaptionBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles todayCaptionBarItem.Click
			ApplythisGroupwithFlag(CInt(flags.Red))
			Me.gridGroupingControl1.Refresh()
		End Sub
		Private Sub BluefromCaptionBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tomoCaptionBarItem.Click
			ApplythisGroupwithFlag(CInt(flags.Blue))
			Me.gridGroupingControl1.Refresh()
		End Sub
		Private Sub YellowfromCaptionBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles thisweekfromCaptionBarItem.Click
			ApplythisGroupwithFlag(CInt(flags.Yellow))
			Me.gridGroupingControl1.Refresh()
		End Sub

		Private Sub GreenfromCaptionBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nextweekCaptionBarItem.Click
			ApplythisGroupwithFlag(CInt(flags.Green))
			Me.gridGroupingControl1.Refresh()
		End Sub

		Private Sub OrangefromCaptionBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nodateCaptionBarItem.Click
			ApplythisGroupwithFlag(CInt(flags.Orange))
			Me.gridGroupingControl1.Refresh()
		End Sub

		Private Sub PurplefromCaptionBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles customCaptionBarItem.Click
			ApplythisGroupwithFlag(CInt(flags.Purple))
			Me.gridGroupingControl1.Refresh()
		End Sub
		Private Sub ClearFlagfromCaptionBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles markcompletefromCaptionBarItem.Click
			ApplythisGroupwithFlag(CInt(flags.Clear))
			Me.gridGroupingControl1.Refresh()
		End Sub
		Private Sub FlagCompletefromCaptionBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles addreminderCaptionBarItem.Click
			ApplythisGroupwithFlag(CInt(flags.Complete))
			Me.gridGroupingControl1.Refresh()
		End Sub
		Private Sub MarkAsReadfromCaptionBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MarkAsReadfromCaptionBarItem.Click
			ApplythisGroupwithReadState(CInt(mail.Read))
			Me.gridGroupingControl1.Refresh()
		End Sub

		Private Sub MarkAsUnreadfromCaptionBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MarkAsUnreadfromCaptionBarItem.Click
			ApplythisGroupwithReadState(CInt(mail.Unread))
			Me.gridGroupingControl1.Refresh()
		End Sub
		#End Region

		#Region "Category PopUp Menu Handlers"

		Private Sub yellowBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles yellowBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("Category", "Yellow Category")
		End Sub

		Private Sub purpleBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles purpleBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("Category", "Purple Category")
		End Sub

		Private Sub orangeBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles orangeBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("Category", "Orange Category")
		End Sub

		Private Sub greenBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles greenBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("Category", "Green Category")
		End Sub

		Private Sub blueBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles blueBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("Category", "Blue Category")
		End Sub

		Private Sub redcategBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles redcategBarItem.Click
			Me.gridGroupingControl1.Table.NestedDisplayElements(rowas).GetRecord().SetValue("Category", "Red Category")
		End Sub
		#End Region

		#End Region


	End Class
	#End Region





End Namespace
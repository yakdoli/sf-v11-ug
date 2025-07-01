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
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Globalization
Imports System.Resources

Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms
Imports System.Reflection
Imports System.IO

Namespace CalendarControlsDemo

	Public Class Form1
		Inherits Office2007Form
		#Region "Declaration"

		Private imageList1 As System.Windows.Forms.ImageList
		Private popupControlContainer1 As Syncfusion.Windows.Forms.PopupControlContainer
        Private WithEvents monthCalendarAdv1 As Syncfusion.Windows.Forms.Tools.MonthCalendarAdv
		Private dataGrid1 As System.Windows.Forms.DataGrid
		Private components As System.ComponentModel.IContainer
		Private m_dataSetTbg As DataSet=Nothing
		Private dateTimePickerAdv15 As DateTimePickerAdv
		Private WithEvents checkBoxAdv1 As CheckBoxAdv
		Private gradientLabel1 As GradientLabel
		Private WithEvents comboBox1 As ComboBox
		Private label10 As Label
		Private WithEvents checkBoxAdv2 As CheckBoxAdv
		Private WithEvents checkBoxAdv3 As CheckBoxAdv
		Private WithEvents checkBoxAdv4 As CheckBoxAdv
		Private label7 As Label
		Private WithEvents comboBox2 As ComboBox
		Private WithEvents checkBoxAdv5 As CheckBoxAdv
		Private label4 As Label
		Private WithEvents comboBox3 As ComboBox
		Private label88 As Label
		Private WithEvents checkBoxAdv6 As CheckBoxAdv
		Private label1 As Label
		Private WithEvents comboBox4 As ComboBox
		Private label2 As Label
		Private WithEvents comboBox5 As ComboBox
		Private label3 As Label
		Private label5 As Label
		Private gradientPanel3 As GradientPanel
		Private label116 As Label
		Private label6 As Label
		Private WithEvents checkBoxAdv7 As CheckBoxAdv
		Private WithEvents checkBoxAdv8 As CheckBoxAdv
		Private WithEvents checkBoxAdv9 As CheckBoxAdv
		Private label36 As Label
		Private toolTip1 As ToolTip
		Private label11 As Label
		Private WithEvents comboBox7 As ComboBox
		Private label12 As Label
		Private tabControlAdv1 As TabControlAdv
		Private tabPageAdv1 As TabPageAdv
		Private tabPageAdv2 As TabPageAdv
		Private WithEvents checkBoxAdv10 As CheckBoxAdv
		Private label15 As Label
		Private WithEvents comboBox9 As ComboBox
		Private label16 As Label
		Private WithEvents comboBox10 As ComboBox
		Private WithEvents checkBoxAdv11 As CheckBoxAdv
		Private label17 As Label
		Private label18 As Label
		Private WithEvents checkBoxAdv13 As CheckBoxAdv
		Private WithEvents checkBoxAdv14 As CheckBoxAdv
		Private monthCalendarAdv2 As MonthCalendarAdv
		Private label19 As Label
		Private WithEvents comboBox11 As ComboBox
		Private label20 As Label
		Private WithEvents comboBox12 As ComboBox
		Private label21 As Label
		Private label22 As Label
		Private WithEvents checkBoxAdv16 As CheckBoxAdv
		Private WithEvents checkBoxAdv15 As CheckBoxAdv
		Private label42 As Label
		Private WithEvents buttonEdit1 As ButtonEdit
		Private buttonEditChildButton2 As ButtonEditChildButton
		Private colorDialog1 As ColorDialog
		Private label13 As Label
		Private WithEvents buttonEdit2 As ButtonEdit
		Private buttonEditChildButton1 As ButtonEditChildButton
		Private label24 As Label
		Private WithEvents buttonEdit3 As ButtonEdit
		Private buttonEditChildButton3 As ButtonEditChildButton
		Private label25 As Label
		Private WithEvents buttonEdit4 As ButtonEdit
		Private buttonEditChildButton4 As ButtonEditChildButton
		Private WithEvents checkBoxAdv12 As CheckBoxAdv
		Private label27 As Label
		Private WithEvents buttonEdit6 As ButtonEdit
		Private buttonEditChildButton6 As ButtonEditChildButton
		Private label26 As Label
		Private WithEvents buttonEdit5 As ButtonEdit
		Private buttonEditChildButton5 As ButtonEditChildButton
		Private label28 As Label
		Private gradientPanel1 As GradientPanel
		Private label14 As Label
		Private gradientPanel2 As GradientPanel
		Private gradientPanel4 As GradientPanel
		Private panel1 As Panel
		Private panel2 As Panel
		Private label9 As Label
		Private label23 As Label
		Private gradientPanel5 As GradientPanel
		Private panel3 As Panel
		Private label8 As Label
		Private label30 As Label
		Private gradientPanel8 As GradientPanel
		Private panel6 As Panel
		Private label33 As Label
		Private gradientPanel7 As GradientPanel
		Private panel5 As Panel
		Private label32 As Label
		Private gradientPanel6 As GradientPanel
		Private panel4 As Panel
		Private label31 As Label
		Private label29 As Label
		Private table As DataTable = Nothing
		#End Region

		#Region "Form Constructor and Dispose"
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Me.buttonEdit1.ShowTextBox = True
			Me.buttonEdit2.ShowTextBox = True
			Me.buttonEdit3.ShowTextBox = True
			Me.buttonEdit4.ShowTextBox = True
			Me.buttonEdit5.ShowTextBox = True
            Me.buttonEdit6.ShowTextBox = True
           
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.dataGrid1 = New System.Windows.Forms.DataGrid
            Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer
            Me.gradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.monthCalendarAdv1 = New Syncfusion.Windows.Forms.Tools.MonthCalendarAdv
            Me.dateTimePickerAdv15 = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
            Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label10 = New System.Windows.Forms.Label
            Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv4 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label7 = New System.Windows.Forms.Label
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.checkBoxAdv5 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label4 = New System.Windows.Forms.Label
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.label88 = New System.Windows.Forms.Label
            Me.checkBoxAdv6 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.comboBox4 = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.comboBox5 = New System.Windows.Forms.ComboBox
            Me.label3 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label116 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.checkBoxAdv7 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv8 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv9 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label36 = New System.Windows.Forms.Label
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.label12 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.comboBox7 = New System.Windows.Forms.ComboBox
            Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv
            Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.monthCalendarAdv2 = New Syncfusion.Windows.Forms.Tools.MonthCalendarAdv
            Me.gradientPanel8 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.panel6 = New System.Windows.Forms.Panel
            Me.label18 = New System.Windows.Forms.Label
            Me.label28 = New System.Windows.Forms.Label
            Me.label13 = New System.Windows.Forms.Label
            Me.buttonEdit2 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.buttonEdit4 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton4 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.label25 = New System.Windows.Forms.Label
            Me.label42 = New System.Windows.Forms.Label
            Me.label27 = New System.Windows.Forms.Label
            Me.buttonEdit1 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton2 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.buttonEdit6 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton6 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.buttonEdit3 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton3 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.label26 = New System.Windows.Forms.Label
            Me.label24 = New System.Windows.Forms.Label
            Me.buttonEdit5 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton5 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.checkBoxAdv12 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label33 = New System.Windows.Forms.Label
            Me.gradientPanel7 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.panel5 = New System.Windows.Forms.Panel
            Me.label21 = New System.Windows.Forms.Label
            Me.label17 = New System.Windows.Forms.Label
            Me.label16 = New System.Windows.Forms.Label
            Me.checkBoxAdv11 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.comboBox10 = New System.Windows.Forms.ComboBox
            Me.comboBox9 = New System.Windows.Forms.ComboBox
            Me.label15 = New System.Windows.Forms.Label
            Me.checkBoxAdv15 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv16 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label32 = New System.Windows.Forms.Label
            Me.gradientPanel6 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.panel4 = New System.Windows.Forms.Panel
            Me.label31 = New System.Windows.Forms.Label
            Me.label19 = New System.Windows.Forms.Label
            Me.label20 = New System.Windows.Forms.Label
            Me.checkBoxAdv14 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv13 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv10 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label22 = New System.Windows.Forms.Label
            Me.comboBox12 = New System.Windows.Forms.ComboBox
            Me.comboBox11 = New System.Windows.Forms.ComboBox
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label14 = New System.Windows.Forms.Label
            Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.gradientPanel5 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.panel3 = New System.Windows.Forms.Panel
            Me.label8 = New System.Windows.Forms.Label
            Me.label30 = New System.Windows.Forms.Label
            Me.label23 = New System.Windows.Forms.Label
            Me.gradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.panel2 = New System.Windows.Forms.Panel
            Me.label9 = New System.Windows.Forms.Label
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label29 = New System.Windows.Forms.Label
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer1.SuspendLayout()
            CType(Me.monthCalendarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateTimePickerAdv15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateTimePickerAdv15.Calendar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel3.SuspendLayout()
            CType(Me.checkBoxAdv7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlAdv1.SuspendLayout()
            Me.tabPageAdv1.SuspendLayout()
            CType(Me.monthCalendarAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel8.SuspendLayout()
            Me.panel6.SuspendLayout()
            CType(Me.buttonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit2.SuspendLayout()
            CType(Me.buttonEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit4.SuspendLayout()
            CType(Me.buttonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit1.SuspendLayout()
            CType(Me.buttonEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit6.SuspendLayout()
            CType(Me.buttonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit3.SuspendLayout()
            CType(Me.buttonEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit5.SuspendLayout()
            CType(Me.checkBoxAdv12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel7.SuspendLayout()
            Me.panel5.SuspendLayout()
            CType(Me.checkBoxAdv11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel6.SuspendLayout()
            Me.panel4.SuspendLayout()
            CType(Me.checkBoxAdv14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            Me.tabPageAdv2.SuspendLayout()
            CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel5.SuspendLayout()
            Me.panel3.SuspendLayout()
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel4.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            Me.imageList1.Images.SetKeyName(4, "")
            Me.imageList1.Images.SetKeyName(5, "")
            Me.imageList1.Images.SetKeyName(6, "")
            Me.imageList1.Images.SetKeyName(7, "")
            Me.imageList1.Images.SetKeyName(8, "")
            Me.imageList1.Images.SetKeyName(9, "")
            Me.imageList1.Images.SetKeyName(10, "")
            Me.imageList1.Images.SetKeyName(11, "")
            '
            'dataGrid1
            '
            Me.dataGrid1.AlternatingBackColor = System.Drawing.Color.LightGray
            Me.dataGrid1.BackColor = System.Drawing.Color.DarkGray
            Me.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.dataGrid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dataGrid1.CaptionForeColor = System.Drawing.Color.Navy
            Me.dataGrid1.CaptionText = "Date"
            Me.dataGrid1.DataMember = ""
            Me.dataGrid1.ForeColor = System.Drawing.Color.Black
            Me.dataGrid1.GridLineColor = System.Drawing.Color.Black
            Me.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
            Me.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver
            Me.dataGrid1.HeaderForeColor = System.Drawing.Color.Black
            Me.dataGrid1.LinkColor = System.Drawing.Color.Navy
            Me.dataGrid1.Location = New System.Drawing.Point(54, 118)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White
            Me.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy
            Me.dataGrid1.SelectionForeColor = System.Drawing.Color.White
            Me.dataGrid1.Size = New System.Drawing.Size(122, 111)
            Me.dataGrid1.TabIndex = 10
            '
            'popupControlContainer1
            '
            Me.popupControlContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.popupControlContainer1.BackgroundImage = CType(resources.GetObject("popupControlContainer1.BackgroundImage"), System.Drawing.Image)
            Me.popupControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.popupControlContainer1.Controls.Add(Me.gradientLabel1)
            Me.popupControlContainer1.Controls.Add(Me.monthCalendarAdv1)
            Me.popupControlContainer1.ForeColor = System.Drawing.Color.DarkSlateBlue
            Me.popupControlContainer1.Location = New System.Drawing.Point(265, 505)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.popupControlContainer1.Size = New System.Drawing.Size(272, 180)
            Me.popupControlContainer1.TabIndex = 5
            Me.popupControlContainer1.Visible = False
            '
            'gradientLabel1
            '
            Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            Me.gradientLabel1.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
            Me.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
            Me.gradientLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(106, Byte), Integer))
            Me.gradientLabel1.Location = New System.Drawing.Point(8, 154)
            Me.gradientLabel1.Name = "gradientLabel1"
            Me.gradientLabel1.Size = New System.Drawing.Size(244, 18)
            Me.gradientLabel1.TabIndex = 2
            Me.gradientLabel1.Text = "Custom Popup Window"
            Me.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'monthCalendarAdv1
            '
            Me.monthCalendarAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(203, Byte), Integer))
            Me.monthCalendarAdv1.BorderColor = System.Drawing.Color.White
            Me.monthCalendarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.monthCalendarAdv1.Culture = New System.Globalization.CultureInfo("")
            Me.monthCalendarAdv1.DaysFont = New System.Drawing.Font("Verdana", 8.0!)
            Me.monthCalendarAdv1.DaysHeaderInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            Me.monthCalendarAdv1.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
            Me.monthCalendarAdv1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.monthCalendarAdv1.HeaderHeight = 20
            Me.monthCalendarAdv1.HeaderStartColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(62, Byte), Integer))
            Me.monthCalendarAdv1.Location = New System.Drawing.Point(73, 6)
            Me.monthCalendarAdv1.Name = "monthCalendarAdv1"
            Me.monthCalendarAdv1.ScrollButtonSize = New System.Drawing.Size(24, 24)
            Me.monthCalendarAdv1.SelectedDates = New Date() {New Date(2008, 4, 4, 6, 27, 41, 31)}
            Me.monthCalendarAdv1.Size = New System.Drawing.Size(194, 145)
            Me.monthCalendarAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
            Me.monthCalendarAdv1.TabIndex = 1
            Me.monthCalendarAdv1.WeekFont = New System.Drawing.Font("Verdana", 8.0!)
            Me.monthCalendarAdv1.WeekInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite)
            '
            '
            '
            Me.monthCalendarAdv1.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2003
            Me.monthCalendarAdv1.NoneButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None
            Me.monthCalendarAdv1.NoneButton.Location = New System.Drawing.Point(118, 0)
            Me.monthCalendarAdv1.NoneButton.Size = New System.Drawing.Size(72, 20)
            Me.monthCalendarAdv1.NoneButton.Text = "None"
            Me.monthCalendarAdv1.NoneButton.UseVisualStyle = True
            '
            '
            '
            Me.monthCalendarAdv1.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2003
            Me.monthCalendarAdv1.TodayButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None
            Me.monthCalendarAdv1.TodayButton.Location = New System.Drawing.Point(0, 0)
            Me.monthCalendarAdv1.TodayButton.Size = New System.Drawing.Size(118, 20)
            Me.monthCalendarAdv1.TodayButton.Text = "Today"
            Me.monthCalendarAdv1.TodayButton.UseVisualStyle = True
            '
            'dateTimePickerAdv15
            '
            Me.dateTimePickerAdv15.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.dateTimePickerAdv15.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(222, Byte), Integer))
            Me.dateTimePickerAdv15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            '
            '
            '
            Me.dateTimePickerAdv15.Calendar.AllowMultipleSelection = False
            Me.dateTimePickerAdv15.Calendar.Culture = New System.Globalization.CultureInfo("")
            Me.dateTimePickerAdv15.Calendar.DaysFont = New System.Drawing.Font("Verdana", 8.0!)
            Me.dateTimePickerAdv15.Calendar.DaysHeaderInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            Me.dateTimePickerAdv15.Calendar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dateTimePickerAdv15.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dateTimePickerAdv15.Calendar.ForeColor = System.Drawing.SystemColors.ControlText
            Me.dateTimePickerAdv15.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
            Me.dateTimePickerAdv15.Calendar.HeaderEndColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.dateTimePickerAdv15.Calendar.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.dateTimePickerAdv15.Calendar.HeaderHeight = 20
            Me.dateTimePickerAdv15.Calendar.HeaderStartColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.dateTimePickerAdv15.Calendar.HeadForeColor = System.Drawing.SystemColors.ControlText
            Me.dateTimePickerAdv15.Calendar.HeadGradient = True
            Me.dateTimePickerAdv15.Calendar.Location = New System.Drawing.Point(0, 0)
            Me.dateTimePickerAdv15.Calendar.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
            Me.dateTimePickerAdv15.Calendar.Name = "monthCalendar"
            Me.dateTimePickerAdv15.Calendar.ScrollButtonSize = New System.Drawing.Size(24, 24)
            Me.dateTimePickerAdv15.Calendar.SelectedDates = New Date(-1) {}
            Me.dateTimePickerAdv15.Calendar.Size = New System.Drawing.Size(211, 174)
            Me.dateTimePickerAdv15.Calendar.SizeToFit = True
            Me.dateTimePickerAdv15.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.dateTimePickerAdv15.Calendar.TabIndex = 0
            Me.dateTimePickerAdv15.Calendar.WeekFont = New System.Drawing.Font("Verdana", 8.0!)
            Me.dateTimePickerAdv15.Calendar.WeekInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite)
            '
            '
            '
            Me.dateTimePickerAdv15.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.dateTimePickerAdv15.Calendar.NoneButton.Location = New System.Drawing.Point(139, 0)
            Me.dateTimePickerAdv15.Calendar.NoneButton.Size = New System.Drawing.Size(72, 20)
            Me.dateTimePickerAdv15.Calendar.NoneButton.Text = "None"
            Me.dateTimePickerAdv15.Calendar.NoneButton.UseVisualStyle = True
            '
            '
            '
            Me.dateTimePickerAdv15.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.dateTimePickerAdv15.Calendar.TodayButton.Location = New System.Drawing.Point(0, 0)
            Me.dateTimePickerAdv15.Calendar.TodayButton.Size = New System.Drawing.Size(139, 20)
            Me.dateTimePickerAdv15.Calendar.TodayButton.Text = "Today"
            Me.dateTimePickerAdv15.Calendar.TodayButton.UseVisualStyle = True
            Me.dateTimePickerAdv15.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dateTimePickerAdv15.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.dateTimePickerAdv15.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText
            Me.dateTimePickerAdv15.DropDownImage = Nothing
            Me.dateTimePickerAdv15.Location = New System.Drawing.Point(173, 53)
            Me.dateTimePickerAdv15.MinValue = New Date(CType(0, Long))
            Me.dateTimePickerAdv15.Name = "dateTimePickerAdv15"
            Me.dateTimePickerAdv15.ShowCheckBox = False
            Me.dateTimePickerAdv15.Size = New System.Drawing.Size(241, 20)
            Me.dateTimePickerAdv15.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.dateTimePickerAdv15.TabIndex = 9
            Me.dateTimePickerAdv15.Value = New Date(2007, 11, 21, 11, 34, 33, 781)
            Me.dateTimePickerAdv15.VSLikeUpDown = True
            '
            'checkBoxAdv1
            '
            Me.checkBoxAdv1.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv1.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv1.Location = New System.Drawing.Point(23, 47)
            Me.checkBoxAdv1.Name = "checkBoxAdv1"
            Me.checkBoxAdv1.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv1.Size = New System.Drawing.Size(139, 21)
            Me.checkBoxAdv1.TabIndex = 10
            Me.checkBoxAdv1.Text = "CustomPopupWindow"
            Me.checkBoxAdv1.ThemesEnabled = True
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Location = New System.Drawing.Point(105, 96)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(106, 21)
            Me.comboBox1.TabIndex = 11
            '
            'label10
            '
            Me.label10.BackColor = System.Drawing.Color.Transparent
            Me.label10.Location = New System.Drawing.Point(4, 95)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(94, 20)
            Me.label10.TabIndex = 12
            Me.label10.Text = "Culture Settings"
            '
            'checkBoxAdv2
            '
            Me.checkBoxAdv2.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv2.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv2.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv2.Location = New System.Drawing.Point(6, 182)
            Me.checkBoxAdv2.Name = "checkBoxAdv2"
            Me.checkBoxAdv2.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv2.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv2.Size = New System.Drawing.Size(157, 21)
            Me.checkBoxAdv2.TabIndex = 13
            Me.checkBoxAdv2.Text = "ShowUpDownOnFocus"
            Me.checkBoxAdv2.ThemesEnabled = True
            '
            'checkBoxAdv3
            '
            Me.checkBoxAdv3.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv3.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv3.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv3.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv3.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv3.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv3.Location = New System.Drawing.Point(6, 156)
            Me.checkBoxAdv3.Name = "checkBoxAdv3"
            Me.checkBoxAdv3.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv3.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv3.Size = New System.Drawing.Size(139, 21)
            Me.checkBoxAdv3.TabIndex = 14
            Me.checkBoxAdv3.Text = "ShowCheckBox"
            Me.checkBoxAdv3.ThemesEnabled = True
            '
            'checkBoxAdv4
            '
            Me.checkBoxAdv4.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv4.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv4.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv4.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv4.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv4.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv4.Location = New System.Drawing.Point(6, 208)
            Me.checkBoxAdv4.Name = "checkBoxAdv4"
            Me.checkBoxAdv4.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv4.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv4.Size = New System.Drawing.Size(139, 21)
            Me.checkBoxAdv4.TabIndex = 15
            Me.checkBoxAdv4.Text = "ShowUpDown"
            Me.checkBoxAdv4.ThemesEnabled = True
            '
            'label7
            '
            Me.label7.BackColor = System.Drawing.Color.Transparent
            Me.label7.Location = New System.Drawing.Point(4, 71)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(94, 20)
            Me.label7.TabIndex = 17
            Me.label7.Text = "Custom Format"
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.DropDownWidth = 150
            Me.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox2.FormattingEnabled = True
            Me.comboBox2.Items.AddRange(New Object() {"MMMM MMM MM dddd ddd dd yyyy hh mm ss", "dddd - dd MMMM yyyy", "HH:m , dd MM yyyy"})
            Me.comboBox2.Location = New System.Drawing.Point(105, 71)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(106, 21)
            Me.comboBox2.TabIndex = 16
            '
            'checkBoxAdv5
            '
            Me.checkBoxAdv5.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv5.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv5.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv5.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv5.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv5.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv5.Location = New System.Drawing.Point(23, 71)
            Me.checkBoxAdv5.Name = "checkBoxAdv5"
            Me.checkBoxAdv5.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv5.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv5.Size = New System.Drawing.Size(139, 21)
            Me.checkBoxAdv5.TabIndex = 18
            Me.checkBoxAdv5.Text = "DataBinding"
            Me.checkBoxAdv5.ThemesEnabled = True
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.Transparent
            Me.label4.Location = New System.Drawing.Point(4, 47)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(94, 20)
            Me.label4.TabIndex = 20
            Me.label4.Text = "Format"
            '
            'comboBox3
            '
            Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox3.FormattingEnabled = True
            Me.comboBox3.Items.AddRange(New Object() {"Long", "Short", "Time", "Custom"})
            Me.comboBox3.Location = New System.Drawing.Point(105, 46)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(106, 21)
            Me.comboBox3.TabIndex = 19
            '
            'label88
            '
            Me.label88.BackColor = System.Drawing.Color.Transparent
            Me.label88.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label88.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label88.Image = CType(resources.GetObject("label88.Image"), System.Drawing.Image)
            Me.label88.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label88.Location = New System.Drawing.Point(6, 5)
            Me.label88.Name = "label88"
            Me.label88.Size = New System.Drawing.Size(97, 24)
            Me.label88.TabIndex = 131
            Me.label88.Text = "Appearance"
            Me.label88.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'checkBoxAdv6
            '
            Me.checkBoxAdv6.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv6.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv6.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv6.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv6.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv6.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv6.Location = New System.Drawing.Point(6, 130)
            Me.checkBoxAdv6.Name = "checkBoxAdv6"
            Me.checkBoxAdv6.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv6.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv6.Size = New System.Drawing.Size(117, 21)
            Me.checkBoxAdv6.TabIndex = 133
            Me.checkBoxAdv6.Text = "ThemesEnabled"
            Me.checkBoxAdv6.ThemesEnabled = True
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Location = New System.Drawing.Point(6, 47)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(69, 19)
            Me.label1.TabIndex = 135
            Me.label1.Text = "Visual Styles"
            '
            'comboBox4
            '
            Me.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox4.FormattingEnabled = True
            Me.comboBox4.Items.AddRange(New Object() {"Default", "OfficeXP", "Office2007"})
            Me.comboBox4.Location = New System.Drawing.Point(107, 47)
            Me.comboBox4.Name = "comboBox4"
            Me.comboBox4.Size = New System.Drawing.Size(106, 21)
            Me.comboBox4.TabIndex = 134
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Location = New System.Drawing.Point(6, 71)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(86, 28)
            Me.label2.TabIndex = 137
            Me.label2.Text = "Office2007 Color Scheme"
            '
            'comboBox5
            '
            Me.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox5.FormattingEnabled = True
            Me.comboBox5.Items.AddRange(New Object() {"Blue", "Silver", "Black"})
            Me.comboBox5.Location = New System.Drawing.Point(107, 71)
            Me.comboBox5.Name = "comboBox5"
            Me.comboBox5.Size = New System.Drawing.Size(106, 21)
            Me.comboBox5.TabIndex = 136
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label3.Location = New System.Drawing.Point(5, 5)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(76, 24)
            Me.label3.TabIndex = 139
            Me.label3.Text = "Behavior"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.Color.White
            Me.label5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label5.Location = New System.Drawing.Point(0, 33)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(229, 2)
            Me.label5.TabIndex = 138
            '
            'gradientPanel3
            '
            Me.gradientPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel3.Controls.Add(Me.dateTimePickerAdv15)
            Me.gradientPanel3.Controls.Add(Me.label116)
            Me.gradientPanel3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel3.Location = New System.Drawing.Point(86, 34)
            Me.gradientPanel3.Name = "gradientPanel3"
            Me.gradientPanel3.Size = New System.Drawing.Size(576, 87)
            Me.gradientPanel3.TabIndex = 140
            '
            'label116
            '
            Me.label116.BackColor = System.Drawing.Color.Transparent
            Me.label116.Dock = System.Windows.Forms.DockStyle.Top
            Me.label116.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label116.Image = CType(resources.GetObject("label116.Image"), System.Drawing.Image)
            Me.label116.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label116.Location = New System.Drawing.Point(0, 0)
            Me.label116.Name = "label116"
            Me.label116.Size = New System.Drawing.Size(574, 36)
            Me.label116.TabIndex = 1
            Me.label116.Text = "DateTimePickerAdv is an advanced DateTimePicker control that provides an easy way" & _
                " to implement a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "culture based DateTimePicker in an application. It has various" & _
                " features as shown below."
            '
            'label6
            '
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label6.Location = New System.Drawing.Point(4, 5)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(126, 24)
            Me.label6.TabIndex = 142
            Me.label6.Text = "Data Association"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'checkBoxAdv7
            '
            Me.checkBoxAdv7.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv7.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv7.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv7.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv7.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv7.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv7.Location = New System.Drawing.Point(4, 145)
            Me.checkBoxAdv7.Name = "checkBoxAdv7"
            Me.checkBoxAdv7.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv7.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv7.Size = New System.Drawing.Size(139, 21)
            Me.checkBoxAdv7.TabIndex = 143
            Me.checkBoxAdv7.Text = "ReadOnly"
            Me.checkBoxAdv7.ThemesEnabled = True
            '
            'checkBoxAdv8
            '
            Me.checkBoxAdv8.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv8.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv8.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv8.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv8.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv8.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv8.Location = New System.Drawing.Point(4, 171)
            Me.checkBoxAdv8.Name = "checkBoxAdv8"
            Me.checkBoxAdv8.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv8.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv8.Size = New System.Drawing.Size(139, 21)
            Me.checkBoxAdv8.TabIndex = 144
            Me.checkBoxAdv8.Text = "RightToLeft"
            Me.checkBoxAdv8.ThemesEnabled = True
            '
            'checkBoxAdv9
            '
            Me.checkBoxAdv9.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv9.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv9.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv9.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv9.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv9.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv9.Location = New System.Drawing.Point(6, 104)
            Me.checkBoxAdv9.Name = "checkBoxAdv9"
            Me.checkBoxAdv9.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv9.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv9.Size = New System.Drawing.Size(124, 21)
            Me.checkBoxAdv9.TabIndex = 147
            Me.checkBoxAdv9.Text = "UseEnhancedMenu"
            Me.checkBoxAdv9.ThemesEnabled = True
            '
            'label36
            '
            Me.label36.BackColor = System.Drawing.Color.Transparent
            Me.label36.Image = CType(resources.GetObject("label36.Image"), System.Drawing.Image)
            Me.label36.Location = New System.Drawing.Point(132, 106)
            Me.label36.Name = "label36"
            Me.label36.Size = New System.Drawing.Size(20, 20)
            Me.label36.TabIndex = 148
            Me.toolTip1.SetToolTip(Me.label36, "ContextMenu will be a Syncfusion XPMenu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right Click on the DateTimePickerAdv to " & _
                    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "view the contextmenu.")
            '
            'label12
            '
            Me.label12.BackColor = System.Drawing.Color.Transparent
            Me.label12.Image = CType(resources.GetObject("label12.Image"), System.Drawing.Image)
            Me.label12.Location = New System.Drawing.Point(212, 123)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(14, 20)
            Me.label12.TabIndex = 151
            Me.toolTip1.SetToolTip(Me.label12, "Click the None button in the calendar to clear the date." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Now press keys to toggl" & _
                    "e the date. These kays can be " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "numeric keys, arrow keys or any keys.")
            '
            'label11
            '
            Me.label11.BackColor = System.Drawing.Color.Transparent
            Me.label11.Location = New System.Drawing.Point(4, 121)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(102, 18)
            Me.label11.TabIndex = 150
            Me.label11.Text = "NullModeKeyReset"
            '
            'comboBox7
            '
            Me.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox7.FormattingEnabled = True
            Me.comboBox7.Items.AddRange(New Object() {"Arrow Keys", "Numeric Keys", "Any Key"})
            Me.comboBox7.Location = New System.Drawing.Point(105, 121)
            Me.comboBox7.Name = "comboBox7"
            Me.comboBox7.Size = New System.Drawing.Size(106, 21)
            Me.comboBox7.TabIndex = 149
            '
            'tabControlAdv1
            '
            Me.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.tabControlAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
            Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabControlAdv1.Location = New System.Drawing.Point(0, 0)
            Me.tabControlAdv1.Name = "tabControlAdv1"
            Me.tabControlAdv1.Size = New System.Drawing.Size(759, 534)
            Me.tabControlAdv1.TabGap = 10
            Me.tabControlAdv1.TabIndex = 152
            Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
            '
            'tabPageAdv1
            '
            Me.tabPageAdv1.Controls.Add(Me.monthCalendarAdv2)
            Me.tabPageAdv1.Controls.Add(Me.gradientPanel8)
            Me.tabPageAdv1.Controls.Add(Me.label33)
            Me.tabPageAdv1.Controls.Add(Me.gradientPanel7)
            Me.tabPageAdv1.Controls.Add(Me.label32)
            Me.tabPageAdv1.Controls.Add(Me.gradientPanel6)
            Me.tabPageAdv1.Controls.Add(Me.gradientPanel1)
            Me.tabPageAdv1.Location = New System.Drawing.Point(1, 29)
            Me.tabPageAdv1.Name = "tabPageAdv1"
            Me.tabPageAdv1.Size = New System.Drawing.Size(757, 504)
            Me.tabPageAdv1.TabBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.tabPageAdv1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.tabPageAdv1.TabIndex = 1
            Me.tabPageAdv1.Text = "MonthCalendarAdv"
            Me.tabPageAdv1.ThemesEnabled = False
            '
            'monthCalendarAdv2
            '
            Me.monthCalendarAdv2.BackColor = System.Drawing.Color.White
            Me.monthCalendarAdv2.Culture = New System.Globalization.CultureInfo("")
            Me.monthCalendarAdv2.DayNamesColor = System.Drawing.Color.Black
            Me.monthCalendarAdv2.DaysColor = System.Drawing.Color.Black
            Me.monthCalendarAdv2.DaysFont = New System.Drawing.Font("Verdana", 8.0!)
            Me.monthCalendarAdv2.DaysHeaderInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            Me.monthCalendarAdv2.GridBackColor = System.Drawing.Color.White
            Me.monthCalendarAdv2.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
            Me.monthCalendarAdv2.HeaderEndColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.monthCalendarAdv2.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.monthCalendarAdv2.HeaderHeight = 20
            Me.monthCalendarAdv2.HeaderStartColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.monthCalendarAdv2.HeadForeColor = System.Drawing.SystemColors.ControlText
            Me.monthCalendarAdv2.HeadGradient = True
            Me.monthCalendarAdv2.Location = New System.Drawing.Point(281, 32)
            Me.monthCalendarAdv2.Name = "monthCalendarAdv2"
            Me.monthCalendarAdv2.ScrollButtonSize = New System.Drawing.Size(24, 24)
            Me.monthCalendarAdv2.SelectedDates = New Date() {New Date(2008, 4, 4, 6, 27, 42, 562)}
            Me.monthCalendarAdv2.Size = New System.Drawing.Size(192, 169)
            Me.monthCalendarAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.monthCalendarAdv2.TabIndex = 0
            Me.monthCalendarAdv2.WeekFont = New System.Drawing.Font("Verdana", 8.0!)
            Me.monthCalendarAdv2.WeekInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite)
            Me.monthCalendarAdv2.WeekTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            '
            '
            '
            Me.monthCalendarAdv2.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.monthCalendarAdv2.NoneButton.Size = New System.Drawing.Size(72, 20)
            Me.monthCalendarAdv2.NoneButton.Text = "None"
            Me.monthCalendarAdv2.NoneButton.UseVisualStyle = True
            '
            '
            '
            Me.monthCalendarAdv2.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.monthCalendarAdv2.TodayButton.Location = New System.Drawing.Point(0, 0)
            Me.monthCalendarAdv2.TodayButton.Size = New System.Drawing.Size(120, 20)
            Me.monthCalendarAdv2.TodayButton.Text = "Today"
            Me.monthCalendarAdv2.TodayButton.UseVisualStyle = True
            '
            'gradientPanel8
            '
            Me.gradientPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.gradientPanel8.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.gradientPanel8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.gradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel8.Controls.Add(Me.panel6)
            Me.gradientPanel8.Controls.Add(Me.label13)
            Me.gradientPanel8.Controls.Add(Me.buttonEdit2)
            Me.gradientPanel8.Controls.Add(Me.buttonEdit4)
            Me.gradientPanel8.Controls.Add(Me.label25)
            Me.gradientPanel8.Controls.Add(Me.label42)
            Me.gradientPanel8.Controls.Add(Me.label27)
            Me.gradientPanel8.Controls.Add(Me.buttonEdit1)
            Me.gradientPanel8.Controls.Add(Me.buttonEdit6)
            Me.gradientPanel8.Controls.Add(Me.buttonEdit3)
            Me.gradientPanel8.Controls.Add(Me.label26)
            Me.gradientPanel8.Controls.Add(Me.label24)
            Me.gradientPanel8.Controls.Add(Me.buttonEdit5)
            Me.gradientPanel8.Controls.Add(Me.checkBoxAdv12)
            Me.gradientPanel8.Location = New System.Drawing.Point(511, 234)
            Me.gradientPanel8.Name = "gradientPanel8"
            Me.gradientPanel8.Size = New System.Drawing.Size(224, 246)
            Me.gradientPanel8.TabIndex = 193
            '
            'panel6
            '
            Me.panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.panel6.Controls.Add(Me.label18)
            Me.panel6.Controls.Add(Me.label28)
            Me.panel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel6.Location = New System.Drawing.Point(0, 0)
            Me.panel6.Name = "panel6"
            Me.panel6.Size = New System.Drawing.Size(222, 35)
            Me.panel6.TabIndex = 157
            '
            'label18
            '
            Me.label18.BackColor = System.Drawing.Color.White
            Me.label18.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label18.Location = New System.Drawing.Point(0, 33)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(222, 2)
            Me.label18.TabIndex = 152
            '
            'label28
            '
            Me.label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label28.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label28.Image = CType(resources.GetObject("label28.Image"), System.Drawing.Image)
            Me.label28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label28.Location = New System.Drawing.Point(5, 4)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(106, 24)
            Me.label28.TabIndex = 187
            Me.label28.Text = "Color Settings"
            Me.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.BackColor = System.Drawing.Color.Transparent
            Me.label13.Location = New System.Drawing.Point(10, 47)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(59, 13)
            Me.label13.TabIndex = 175
            Me.label13.Text = "Back Color"
            '
            'buttonEdit2
            '
            Me.buttonEdit2.BackColor = System.Drawing.Color.White
            Me.buttonEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit2.Buttons.Add(Me.buttonEditChildButton1)
            Me.buttonEdit2.Controls.Add(Me.buttonEditChildButton1)
            Me.buttonEdit2.Location = New System.Drawing.Point(109, 45)
            Me.buttonEdit2.Name = "buttonEdit2"
            Me.buttonEdit2.ShowTextBox = False
            Me.buttonEdit2.Size = New System.Drawing.Size(102, 26)
            Me.buttonEdit2.TabIndex = 176
            Me.buttonEdit2.UseVisualStyle = True
            '
            'buttonEditChildButton1
            '
            Me.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton1.ComboEditBackColor = System.Drawing.Color.White
            Me.buttonEditChildButton1.Image = Nothing
            Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
            Me.buttonEditChildButton1.PreferredWidth = 18
            Me.buttonEditChildButton1.TabIndex = 1
            Me.buttonEditChildButton1.Text = "..."
            '
            'buttonEdit4
            '
            Me.buttonEdit4.BackColor = System.Drawing.Color.White
            Me.buttonEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit4.Buttons.Add(Me.buttonEditChildButton4)
            Me.buttonEdit4.Controls.Add(Me.buttonEditChildButton4)
            Me.buttonEdit4.Location = New System.Drawing.Point(109, 74)
            Me.buttonEdit4.Name = "buttonEdit4"
            Me.buttonEdit4.ShowTextBox = False
            Me.buttonEdit4.Size = New System.Drawing.Size(102, 26)
            Me.buttonEdit4.TabIndex = 180
            Me.buttonEdit4.UseVisualStyle = True
            '
            'buttonEditChildButton4
            '
            Me.buttonEditChildButton4.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton4.ComboEditBackColor = System.Drawing.Color.White
            Me.buttonEditChildButton4.Image = Nothing
            Me.buttonEditChildButton4.Name = "buttonEditChildButton4"
            Me.buttonEditChildButton4.PreferredWidth = 18
            Me.buttonEditChildButton4.TabIndex = 1
            Me.buttonEditChildButton4.Text = "..."
            '
            'label25
            '
            Me.label25.AutoSize = True
            Me.label25.BackColor = System.Drawing.Color.Transparent
            Me.label25.Location = New System.Drawing.Point(10, 74)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(78, 13)
            Me.label25.TabIndex = 179
            Me.label25.Text = "Grid BackColor"
            '
            'label42
            '
            Me.label42.AutoSize = True
            Me.label42.BackColor = System.Drawing.Color.Transparent
            Me.label42.Location = New System.Drawing.Point(10, 102)
            Me.label42.Name = "label42"
            Me.label42.Size = New System.Drawing.Size(84, 13)
            Me.label42.TabIndex = 173
            Me.label42.Text = "Day Name Color"
            '
            'label27
            '
            Me.label27.AutoSize = True
            Me.label27.BackColor = System.Drawing.Color.Transparent
            Me.label27.Location = New System.Drawing.Point(10, 215)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(91, 13)
            Me.label27.TabIndex = 184
            Me.label27.Text = "Header End Color"
            '
            'buttonEdit1
            '
            Me.buttonEdit1.BackColor = System.Drawing.Color.White
            Me.buttonEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit1.Buttons.Add(Me.buttonEditChildButton2)
            Me.buttonEdit1.Controls.Add(Me.buttonEditChildButton2)
            Me.buttonEdit1.Location = New System.Drawing.Point(109, 102)
            Me.buttonEdit1.Name = "buttonEdit1"
            Me.buttonEdit1.ShowTextBox = False
            Me.buttonEdit1.Size = New System.Drawing.Size(102, 26)
            Me.buttonEdit1.TabIndex = 174
            Me.buttonEdit1.UseVisualStyle = True
            '
            'buttonEditChildButton2
            '
            Me.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton2.ComboEditBackColor = System.Drawing.Color.White
            Me.buttonEditChildButton2.Image = Nothing
            Me.buttonEditChildButton2.Name = "buttonEditChildButton2"
            Me.buttonEditChildButton2.PreferredWidth = 18
            Me.buttonEditChildButton2.TabIndex = 1
            Me.buttonEditChildButton2.Text = "..."
            '
            'buttonEdit6
            '
            Me.buttonEdit6.BackColor = System.Drawing.Color.White
            Me.buttonEdit6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit6.Buttons.Add(Me.buttonEditChildButton6)
            Me.buttonEdit6.Controls.Add(Me.buttonEditChildButton6)
            Me.buttonEdit6.Location = New System.Drawing.Point(109, 213)
            Me.buttonEdit6.Name = "buttonEdit6"
            Me.buttonEdit6.ShowTextBox = False
            Me.buttonEdit6.Size = New System.Drawing.Size(102, 26)
            Me.buttonEdit6.TabIndex = 185
            Me.buttonEdit6.UseVisualStyle = True
            '
            'buttonEditChildButton6
            '
            Me.buttonEditChildButton6.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton6.ComboEditBackColor = System.Drawing.Color.White
            Me.buttonEditChildButton6.Image = Nothing
            Me.buttonEditChildButton6.Name = "buttonEditChildButton6"
            Me.buttonEditChildButton6.PreferredWidth = 18
            Me.buttonEditChildButton6.TabIndex = 1
            Me.buttonEditChildButton6.Text = "..."
            '
            'buttonEdit3
            '
            Me.buttonEdit3.BackColor = System.Drawing.Color.White
            Me.buttonEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit3.Buttons.Add(Me.buttonEditChildButton3)
            Me.buttonEdit3.Controls.Add(Me.buttonEditChildButton3)
            Me.buttonEdit3.Location = New System.Drawing.Point(109, 131)
            Me.buttonEdit3.Name = "buttonEdit3"
            Me.buttonEdit3.ShowTextBox = False
            Me.buttonEdit3.Size = New System.Drawing.Size(102, 26)
            Me.buttonEdit3.TabIndex = 178
            Me.buttonEdit3.UseVisualStyle = True
            '
            'buttonEditChildButton3
            '
            Me.buttonEditChildButton3.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton3.ComboEditBackColor = System.Drawing.Color.White
            Me.buttonEditChildButton3.Image = Nothing
            Me.buttonEditChildButton3.Name = "buttonEditChildButton3"
            Me.buttonEditChildButton3.PreferredWidth = 18
            Me.buttonEditChildButton3.TabIndex = 1
            Me.buttonEditChildButton3.Text = "..."
            '
            'label26
            '
            Me.label26.AutoSize = True
            Me.label26.BackColor = System.Drawing.Color.Transparent
            Me.label26.Location = New System.Drawing.Point(10, 186)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(94, 13)
            Me.label26.TabIndex = 182
            Me.label26.Text = "Header Start Color"
            '
            'label24
            '
            Me.label24.AutoSize = True
            Me.label24.BackColor = System.Drawing.Color.Transparent
            Me.label24.Location = New System.Drawing.Point(10, 131)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(53, 13)
            Me.label24.TabIndex = 177
            Me.label24.Text = "Day Color"
            '
            'buttonEdit5
            '
            Me.buttonEdit5.BackColor = System.Drawing.Color.White
            Me.buttonEdit5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit5.Buttons.Add(Me.buttonEditChildButton5)
            Me.buttonEdit5.Controls.Add(Me.buttonEditChildButton5)
            Me.buttonEdit5.Location = New System.Drawing.Point(109, 184)
            Me.buttonEdit5.Name = "buttonEdit5"
            Me.buttonEdit5.ShowTextBox = False
            Me.buttonEdit5.Size = New System.Drawing.Size(102, 26)
            Me.buttonEdit5.TabIndex = 183
            Me.buttonEdit5.UseVisualStyle = True
            '
            'buttonEditChildButton5
            '
            Me.buttonEditChildButton5.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton5.ComboEditBackColor = System.Drawing.Color.White
            Me.buttonEditChildButton5.Image = Nothing
            Me.buttonEditChildButton5.Name = "buttonEditChildButton5"
            Me.buttonEditChildButton5.PreferredWidth = 18
            Me.buttonEditChildButton5.TabIndex = 1
            Me.buttonEditChildButton5.Text = "..."
            '
            'checkBoxAdv12
            '
            Me.checkBoxAdv12.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv12.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv12.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv12.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv12.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv12.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv12.Location = New System.Drawing.Point(10, 159)
            Me.checkBoxAdv12.Name = "checkBoxAdv12"
            Me.checkBoxAdv12.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv12.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv12.Size = New System.Drawing.Size(105, 15)
            Me.checkBoxAdv12.TabIndex = 181
            Me.checkBoxAdv12.Text = "HeaderVerticalGradient"
            Me.checkBoxAdv12.ThemesEnabled = True
            '
            'label33
            '
            Me.label33.BackColor = System.Drawing.Color.White
            Me.label33.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label33.Location = New System.Drawing.Point(0, 500)
            Me.label33.Name = "label33"
            Me.label33.Size = New System.Drawing.Size(757, 2)
            Me.label33.TabIndex = 192
            '
            'gradientPanel7
            '
            Me.gradientPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.gradientPanel7.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.gradientPanel7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel7.Controls.Add(Me.panel5)
            Me.gradientPanel7.Controls.Add(Me.label16)
            Me.gradientPanel7.Controls.Add(Me.checkBoxAdv11)
            Me.gradientPanel7.Controls.Add(Me.comboBox10)
            Me.gradientPanel7.Controls.Add(Me.comboBox9)
            Me.gradientPanel7.Controls.Add(Me.label15)
            Me.gradientPanel7.Controls.Add(Me.checkBoxAdv15)
            Me.gradientPanel7.Controls.Add(Me.checkBoxAdv16)
            Me.gradientPanel7.Location = New System.Drawing.Point(263, 234)
            Me.gradientPanel7.Name = "gradientPanel7"
            Me.gradientPanel7.Size = New System.Drawing.Size(224, 246)
            Me.gradientPanel7.TabIndex = 191
            '
            'panel5
            '
            Me.panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.panel5.Controls.Add(Me.label21)
            Me.panel5.Controls.Add(Me.label17)
            Me.panel5.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel5.Location = New System.Drawing.Point(0, 0)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(222, 35)
            Me.panel5.TabIndex = 157
            '
            'label21
            '
            Me.label21.BackColor = System.Drawing.Color.White
            Me.label21.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label21.Location = New System.Drawing.Point(0, 33)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(222, 2)
            Me.label21.TabIndex = 169
            '
            'label17
            '
            Me.label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label17.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label17.Image = CType(resources.GetObject("label17.Image"), System.Drawing.Image)
            Me.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label17.Location = New System.Drawing.Point(3, 4)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(97, 23)
            Me.label17.TabIndex = 153
            Me.label17.Text = "Appearance"
            Me.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label16
            '
            Me.label16.BackColor = System.Drawing.Color.Transparent
            Me.label16.Location = New System.Drawing.Point(9, 47)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(69, 20)
            Me.label16.TabIndex = 156
            Me.label16.Text = "Visual Styles"
            '
            'checkBoxAdv11
            '
            Me.checkBoxAdv11.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv11.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv11.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv11.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv11.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv11.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv11.Location = New System.Drawing.Point(9, 117)
            Me.checkBoxAdv11.Name = "checkBoxAdv11"
            Me.checkBoxAdv11.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv11.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv11.Size = New System.Drawing.Size(117, 21)
            Me.checkBoxAdv11.TabIndex = 154
            Me.checkBoxAdv11.Text = "ThemesEnabled"
            Me.checkBoxAdv11.ThemesEnabled = True
            '
            'comboBox10
            '
            Me.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox10.FormattingEnabled = True
            Me.comboBox10.Location = New System.Drawing.Point(107, 47)
            Me.comboBox10.Name = "comboBox10"
            Me.comboBox10.Size = New System.Drawing.Size(106, 21)
            Me.comboBox10.TabIndex = 155
            '
            'comboBox9
            '
            Me.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox9.FormattingEnabled = True
            Me.comboBox9.Items.AddRange(New Object() {"Blue", "Silver", "Black"})
            Me.comboBox9.Location = New System.Drawing.Point(107, 79)
            Me.comboBox9.Name = "comboBox9"
            Me.comboBox9.Size = New System.Drawing.Size(106, 21)
            Me.comboBox9.TabIndex = 157
            '
            'label15
            '
            Me.label15.BackColor = System.Drawing.Color.Transparent
            Me.label15.Location = New System.Drawing.Point(9, 78)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(86, 26)
            Me.label15.TabIndex = 158
            Me.label15.Text = "Office2007 Color Scheme"
            '
            'checkBoxAdv15
            '
            Me.checkBoxAdv15.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv15.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv15.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv15.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv15.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv15.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv15.Location = New System.Drawing.Point(9, 151)
            Me.checkBoxAdv15.Name = "checkBoxAdv15"
            Me.checkBoxAdv15.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv15.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv15.Size = New System.Drawing.Size(157, 21)
            Me.checkBoxAdv15.TabIndex = 171
            Me.checkBoxAdv15.Text = "LeftScrollButtonImage"
            Me.checkBoxAdv15.ThemesEnabled = True
            '
            'checkBoxAdv16
            '
            Me.checkBoxAdv16.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv16.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv16.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv16.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv16.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv16.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv16.Location = New System.Drawing.Point(9, 184)
            Me.checkBoxAdv16.Name = "checkBoxAdv16"
            Me.checkBoxAdv16.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv16.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv16.Size = New System.Drawing.Size(159, 21)
            Me.checkBoxAdv16.TabIndex = 172
            Me.checkBoxAdv16.Text = "RightScrollButtonImage"
            Me.checkBoxAdv16.ThemesEnabled = True
            '
            'label32
            '
            Me.label32.BackColor = System.Drawing.Color.White
            Me.label32.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label32.Location = New System.Drawing.Point(0, 502)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(757, 2)
            Me.label32.TabIndex = 190
            '
            'gradientPanel6
            '
            Me.gradientPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.gradientPanel6.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.gradientPanel6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel6.Controls.Add(Me.panel4)
            Me.gradientPanel6.Controls.Add(Me.label20)
            Me.gradientPanel6.Controls.Add(Me.checkBoxAdv14)
            Me.gradientPanel6.Controls.Add(Me.checkBoxAdv13)
            Me.gradientPanel6.Controls.Add(Me.checkBoxAdv10)
            Me.gradientPanel6.Controls.Add(Me.label22)
            Me.gradientPanel6.Controls.Add(Me.comboBox12)
            Me.gradientPanel6.Controls.Add(Me.comboBox11)
            Me.gradientPanel6.Location = New System.Drawing.Point(15, 234)
            Me.gradientPanel6.Name = "gradientPanel6"
            Me.gradientPanel6.Size = New System.Drawing.Size(224, 246)
            Me.gradientPanel6.TabIndex = 189
            '
            'panel4
            '
            Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.panel4.Controls.Add(Me.label31)
            Me.panel4.Controls.Add(Me.label19)
            Me.panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel4.Location = New System.Drawing.Point(0, 0)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(222, 35)
            Me.panel4.TabIndex = 157
            '
            'label31
            '
            Me.label31.BackColor = System.Drawing.Color.White
            Me.label31.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label31.Location = New System.Drawing.Point(0, 33)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(222, 2)
            Me.label31.TabIndex = 139
            '
            'label19
            '
            Me.label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label19.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label19.Image = CType(resources.GetObject("label19.Image"), System.Drawing.Image)
            Me.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label19.Location = New System.Drawing.Point(10, 4)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(77, 24)
            Me.label19.TabIndex = 170
            Me.label19.Text = "Behavior"
            Me.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label20
            '
            Me.label20.BackColor = System.Drawing.Color.Transparent
            Me.label20.Location = New System.Drawing.Point(10, 49)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(85, 20)
            Me.label20.TabIndex = 164
            Me.label20.Text = "Culture Settings"
            '
            'checkBoxAdv14
            '
            Me.checkBoxAdv14.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv14.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv14.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv14.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv14.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv14.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv14.Location = New System.Drawing.Point(10, 183)
            Me.checkBoxAdv14.Name = "checkBoxAdv14"
            Me.checkBoxAdv14.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv14.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv14.Size = New System.Drawing.Size(157, 21)
            Me.checkBoxAdv14.TabIndex = 149
            Me.checkBoxAdv14.Text = "MouseDragMultiSelect"
            Me.checkBoxAdv14.ThemesEnabled = True
            '
            'checkBoxAdv13
            '
            Me.checkBoxAdv13.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv13.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv13.Checked = True
            Me.checkBoxAdv13.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv13.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv13.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv13.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv13.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv13.Location = New System.Drawing.Point(10, 149)
            Me.checkBoxAdv13.Name = "checkBoxAdv13"
            Me.checkBoxAdv13.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv13.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv13.Size = New System.Drawing.Size(182, 21)
            Me.checkBoxAdv13.TabIndex = 150
            Me.checkBoxAdv13.Text = "Allow Multiple Selection"
            Me.checkBoxAdv13.ThemesEnabled = True
            '
            'checkBoxAdv10
            '
            Me.checkBoxAdv10.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv10.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv10.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv10.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv10.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv10.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv10.Location = New System.Drawing.Point(10, 115)
            Me.checkBoxAdv10.Name = "checkBoxAdv10"
            Me.checkBoxAdv10.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv10.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv10.Size = New System.Drawing.Size(139, 21)
            Me.checkBoxAdv10.TabIndex = 161
            Me.checkBoxAdv10.Text = "ShowWeekNumbers"
            Me.checkBoxAdv10.ThemesEnabled = True
            '
            'label22
            '
            Me.label22.BackColor = System.Drawing.Color.Transparent
            Me.label22.Location = New System.Drawing.Point(10, 82)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(87, 20)
            Me.label22.TabIndex = 166
            Me.label22.Text = "FirstDayOfWeek"
            '
            'comboBox12
            '
            Me.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox12.FormattingEnabled = True
            Me.comboBox12.Location = New System.Drawing.Point(101, 79)
            Me.comboBox12.Name = "comboBox12"
            Me.comboBox12.Size = New System.Drawing.Size(106, 21)
            Me.comboBox12.TabIndex = 165
            '
            'comboBox11
            '
            Me.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox11.FormattingEnabled = True
            Me.comboBox11.Location = New System.Drawing.Point(101, 49)
            Me.comboBox11.Name = "comboBox11"
            Me.comboBox11.Size = New System.Drawing.Size(106, 21)
            Me.comboBox11.TabIndex = 163
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.label14)
            Me.gradientPanel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel1.Location = New System.Drawing.Point(99, 9)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(595, 203)
            Me.gradientPanel1.TabIndex = 188
            '
            'label14
            '
            Me.label14.BackColor = System.Drawing.Color.Transparent
            Me.label14.Dock = System.Windows.Forms.DockStyle.Top
            Me.label14.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label14.Image = CType(resources.GetObject("label14.Image"), System.Drawing.Image)
            Me.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label14.Location = New System.Drawing.Point(0, 0)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(593, 39)
            Me.label14.TabIndex = 1
            Me.label14.Text = "MonthCalendarAdv is an advanced calendar control that can display a full month of" & _
                " the year."
            '
            'tabPageAdv2
            '
            Me.tabPageAdv2.Controls.Add(Me.gradientPanel5)
            Me.tabPageAdv2.Controls.Add(Me.label8)
            Me.tabPageAdv2.Controls.Add(Me.label30)
            Me.tabPageAdv2.Controls.Add(Me.label23)
            Me.tabPageAdv2.Controls.Add(Me.gradientPanel4)
            Me.tabPageAdv2.Controls.Add(Me.gradientPanel2)
            Me.tabPageAdv2.Controls.Add(Me.popupControlContainer1)
            Me.tabPageAdv2.Controls.Add(Me.gradientPanel3)
            Me.tabPageAdv2.Location = New System.Drawing.Point(1, 29)
            Me.tabPageAdv2.Name = "tabPageAdv2"
            Me.tabPageAdv2.Size = New System.Drawing.Size(757, 504)
            Me.tabPageAdv2.TabBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.tabPageAdv2.TabIndex = 1
            Me.tabPageAdv2.Text = "DateTimePickerAdv"
            Me.tabPageAdv2.ThemesEnabled = False
            '
            'gradientPanel5
            '
            Me.gradientPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.gradientPanel5.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.gradientPanel5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel5.Controls.Add(Me.panel3)
            Me.gradientPanel5.Controls.Add(Me.label4)
            Me.gradientPanel5.Controls.Add(Me.label7)
            Me.gradientPanel5.Controls.Add(Me.label10)
            Me.gradientPanel5.Controls.Add(Me.checkBoxAdv7)
            Me.gradientPanel5.Controls.Add(Me.checkBoxAdv8)
            Me.gradientPanel5.Controls.Add(Me.label11)
            Me.gradientPanel5.Controls.Add(Me.label12)
            Me.gradientPanel5.Controls.Add(Me.comboBox3)
            Me.gradientPanel5.Controls.Add(Me.comboBox2)
            Me.gradientPanel5.Controls.Add(Me.comboBox7)
            Me.gradientPanel5.Controls.Add(Me.comboBox1)
            Me.gradientPanel5.Location = New System.Drawing.Point(262, 192)
            Me.gradientPanel5.Name = "gradientPanel5"
            Me.gradientPanel5.Size = New System.Drawing.Size(231, 246)
            Me.gradientPanel5.TabIndex = 158
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.panel3.Controls.Add(Me.label5)
            Me.panel3.Controls.Add(Me.label3)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel3.Location = New System.Drawing.Point(0, 0)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(229, 35)
            Me.panel3.TabIndex = 156
            '
            'label8
            '
            Me.label8.BackColor = System.Drawing.Color.White
            Me.label8.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label8.Location = New System.Drawing.Point(0, 500)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(757, 2)
            Me.label8.TabIndex = 156
            '
            'label30
            '
            Me.label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label30.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label30.Image = CType(resources.GetObject("label30.Image"), System.Drawing.Image)
            Me.label30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label30.Location = New System.Drawing.Point(-184, -49)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(126, 24)
            Me.label30.TabIndex = 157
            Me.label30.Text = "Data Association"
            Me.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label23
            '
            Me.label23.BackColor = System.Drawing.Color.White
            Me.label23.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label23.Location = New System.Drawing.Point(0, 502)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(757, 2)
            Me.label23.TabIndex = 155
            '
            'gradientPanel4
            '
            Me.gradientPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.gradientPanel4.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel4.Controls.Add(Me.panel2)
            Me.gradientPanel4.Controls.Add(Me.checkBoxAdv1)
            Me.gradientPanel4.Controls.Add(Me.checkBoxAdv5)
            Me.gradientPanel4.Controls.Add(Me.dataGrid1)
            Me.gradientPanel4.Location = New System.Drawing.Point(512, 193)
            Me.gradientPanel4.Name = "gradientPanel4"
            Me.gradientPanel4.Size = New System.Drawing.Size(231, 246)
            Me.gradientPanel4.TabIndex = 154
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.panel2.Controls.Add(Me.label9)
            Me.panel2.Controls.Add(Me.label6)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(229, 35)
            Me.panel2.TabIndex = 156
            '
            'label9
            '
            Me.label9.BackColor = System.Drawing.Color.White
            Me.label9.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label9.Location = New System.Drawing.Point(0, 33)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(229, 2)
            Me.label9.TabIndex = 139
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.gradientPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel2.Controls.Add(Me.panel1)
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv2)
            Me.gradientPanel2.Controls.Add(Me.label36)
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv3)
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv4)
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv9)
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv6)
            Me.gradientPanel2.Controls.Add(Me.comboBox4)
            Me.gradientPanel2.Controls.Add(Me.label1)
            Me.gradientPanel2.Controls.Add(Me.label2)
            Me.gradientPanel2.Controls.Add(Me.comboBox5)
            Me.gradientPanel2.Location = New System.Drawing.Point(12, 192)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(231, 246)
            Me.gradientPanel2.TabIndex = 153
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.panel1.Controls.Add(Me.label29)
            Me.panel1.Controls.Add(Me.label88)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(229, 35)
            Me.panel1.TabIndex = 155
            '
            'label29
            '
            Me.label29.BackColor = System.Drawing.Color.White
            Me.label29.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label29.Location = New System.Drawing.Point(0, 33)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(229, 2)
            Me.label29.TabIndex = 139
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(759, 534)
            Me.Controls.Add(Me.tabControlAdv1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Calendar Controls"
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer1.ResumeLayout(False)
            CType(Me.monthCalendarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateTimePickerAdv15.Calendar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateTimePickerAdv15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel3.ResumeLayout(False)
            CType(Me.checkBoxAdv7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlAdv1.ResumeLayout(False)
            Me.tabPageAdv1.ResumeLayout(False)
            CType(Me.monthCalendarAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel8.ResumeLayout(False)
            Me.gradientPanel8.PerformLayout()
            Me.panel6.ResumeLayout(False)
            CType(Me.buttonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit2.ResumeLayout(False)
            Me.buttonEdit2.PerformLayout()
            CType(Me.buttonEdit4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit4.ResumeLayout(False)
            Me.buttonEdit4.PerformLayout()
            CType(Me.buttonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit1.ResumeLayout(False)
            Me.buttonEdit1.PerformLayout()
            CType(Me.buttonEdit6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit6.ResumeLayout(False)
            Me.buttonEdit6.PerformLayout()
            CType(Me.buttonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit3.ResumeLayout(False)
            Me.buttonEdit3.PerformLayout()
            CType(Me.buttonEdit5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit5.ResumeLayout(False)
            Me.buttonEdit5.PerformLayout()
            CType(Me.checkBoxAdv12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel7.ResumeLayout(False)
            Me.panel5.ResumeLayout(False)
            CType(Me.checkBoxAdv11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel6.ResumeLayout(False)
            Me.panel4.ResumeLayout(False)
            CType(Me.checkBoxAdv14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.tabPageAdv2.ResumeLayout(False)
            CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel5.ResumeLayout(False)
            Me.panel3.ResumeLayout(False)
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel4.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region

		#Region "Main"
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub
		#End Region

		#Region "FormLoad"
		Private leftButtonImg As Image
		Private rightButtonImg As Image
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim assem As System.Reflection.Assembly = Me.GetType().Assembly
            Dim imgStr1 As Stream = assem.GetManifestResourceStream("CalendarControls.arrow_left_blue.png")
            Dim imgStr2 As Stream = assem.GetManifestResourceStream("CalendarControls.arrow_right_blue.png")
            leftButtonImg = Image.FromStream(imgStr1)
            rightButtonImg = Image.FromStream(imgStr2)

           
			' Load all Specific Cultures to the Combo Box
			For Each info As CultureInfo In CultureInfo.GetCultures(CultureTypes.SpecificCultures)
				comboBox1.Items.Add(info.Name)
				comboBox11.Items.Add(info.Name)
			Next info

			Me.comboBox2.SelectedIndex = 0
            Me.comboBox2.Enabled = False
            Me.comboBox5.SelectedIndex = 0
			Me.comboBox5.Enabled = False
			Me.comboBox7.SelectedIndex = 0
			Me.comboBox9.SelectedIndex = 0
			Me.comboBox1.SelectedIndex = 8
            Me.comboBox11.SelectedIndex = 8
            Me.comboBox3.SelectedIndex = 0


			' Populate Combo Box with VisualStyle
			Dim str As String() = System.Enum.GetNames(GetType(VisualStyle))
			comboBox10.Items.AddRange(str)
            comboBox4.SelectedIndex = 2
			comboBox10.SelectedIndex = 4
			' Populate Week Days
			Dim str1 As String() = System.Enum.GetNames(GetType(Day))
			comboBox12.Items.AddRange(str1)

			comboBox12.SelectedIndex = 0

            '#Region "DataBinding"
			m_dataSetTbg = New DataSet()
			table = m_dataSetTbg.Tables.Add("tbgstrg")
			table.Columns.Add("Date", GetType(DateTime))
			table.Columns(0).AllowDBNull = True
			table.Rows.Add(New Object() { DateTime.Now - TimeSpan.FromDays(60) })
			table.Rows.Add(New Object() { DateTime.Now })
			table.Rows.Add(New Object() { DBNull.Value })
			dataGrid1.DataSource = m_dataSetTbg
			dataGrid1.DataMember = "tbgstrg"
            ' #End Region


		End Sub
		#End Region

		#Region "DateTimePickerAdv"


		#Region "dateTimePickerAdv Culture"


		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			comboBox1.SelectedItem = "en-US"
			Dim culture As String = comboBox1.SelectedItem.ToString()
			System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(culture)
			Me.dateTimePickerAdv15.Culture = New System.Globalization.CultureInfo(culture)

		End Sub
		#End Region

		Private Sub checkBoxAdv3_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv3.CheckStateChanged
			Me.dateTimePickerAdv15.ShowCheckBox = Me.checkBoxAdv3.Checked
		End Sub

		Private Sub checkBoxAdv2_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv2.CheckStateChanged
			Me.dateTimePickerAdv15.ShowUpDownOnFocus = Me.checkBoxAdv2.Checked
		End Sub

		Private Sub checkBoxAdv4_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv4.CheckStateChanged
			Me.dateTimePickerAdv15.ShowUpDown = Me.checkBoxAdv4.Checked
		End Sub


		#Region "CustomFormat"
		Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
			Me.dateTimePickerAdv15.Format = DateTimePickerFormat.Custom
			Select Case Me.comboBox2.SelectedIndex

				Case 0
						Me.dateTimePickerAdv15.CustomFormat = "MMMM MMM MM dddd ddd dd yyyy hh mm ss"
						Exit Select
				Case 1
						Me.dateTimePickerAdv15.CustomFormat = "dddd - dd MMMM yyyy"
						Exit Select
				Case 2
						Me.dateTimePickerAdv15.CustomFormat = "HH:m , dd MM yyyy"
						Exit Select
			End Select
'		#End Region


		End Sub




		Private Sub checkBoxAdv5_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv5.CheckStateChanged
			If Me.checkBoxAdv5.Checked Then
				Me.dateTimePickerAdv15.DataBindings.Add("BindableValue", m_dataSetTbg, "tbgstrg.Date")
			Else
				Me.dateTimePickerAdv15.DataBindings.Clear()
			End If

		End Sub
		#Region "Format"
		Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox3.SelectedIndexChanged
			Select Case Me.comboBox3.SelectedIndex

				Case 0
						Me.dateTimePickerAdv15.Format = DateTimePickerFormat.Long
						Me.comboBox2.Enabled = False
						Exit Select
				Case 1
						Me.dateTimePickerAdv15.Format = DateTimePickerFormat.Short
						Me.comboBox2.Enabled = False
						Exit Select
				Case 2
						Me.dateTimePickerAdv15.Format = DateTimePickerFormat.Time
						Me.comboBox2.Enabled = False
						Exit Select
				Case 3
						Me.dateTimePickerAdv15.Format = DateTimePickerFormat.Custom
						Me.comboBox2.Enabled = True
						Exit Select
			End Select
		End Sub
		#End Region

		Private Sub checkBoxAdv6_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv6.CheckStateChanged
			Me.dateTimePickerAdv15.ThemesEnabled = Me.checkBoxAdv6.Checked
		End Sub

		#Region "Visual Style"
		Private Sub comboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox4.SelectedIndexChanged
			Select Case Me.comboBox4.SelectedItem.ToString()

				Case "Default"
						Me.dateTimePickerAdv15.Style = VisualStyle.Default
						Me.comboBox5.Enabled = False
						Exit Select
				Case "OfficeXP"
						Me.dateTimePickerAdv15.Style = VisualStyle.OfficeXP
						Me.comboBox5.Enabled = False
						Exit Select

			   Case "Office2007"
						Me.dateTimePickerAdv15.Style = VisualStyle.Office2007
						Me.comboBox5.Enabled = True
						Exit Select

			End Select


		End Sub
		#End Region

		#Region "Color Scheme"
		Private Sub comboBox5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox5.SelectedIndexChanged
			If Me.comboBox5.SelectedItem.ToString() = "Blue" Then
				Me.dateTimePickerAdv15.Office2007Theme = Office2007Theme.Blue
			ElseIf Me.comboBox5.SelectedItem.ToString() = "Silver" Then
				Me.dateTimePickerAdv15.Office2007Theme = Office2007Theme.Silver
			Else
				Me.dateTimePickerAdv15.Office2007Theme = Office2007Theme.Black
			End If
		End Sub
		#End Region

		Private Sub checkBoxAdv7_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv7.CheckStateChanged
			Me.dateTimePickerAdv15.ReadOnly = checkBoxAdv7.Checked
			Me.dateTimePickerAdv15.ReadOnlyValueChange = Not checkBoxAdv7.Checked
		End Sub

		Private Sub checkBoxAdv8_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv8.CheckStateChanged
			If Me.checkBoxAdv8.Checked Then
				Me.dateTimePickerAdv15.RightToLeft = RightToLeft.Yes
			Else
				Me.dateTimePickerAdv15.RightToLeft = RightToLeft.No
			End If


		End Sub



		Private Sub checkBoxAdv9_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv9.CheckStateChanged
			Me.dateTimePickerAdv15.UseEnhancedMenu = checkBoxAdv9.Checked
		End Sub

#Region "NullModeKeyReset"
		Private Sub comboBox7_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox7.SelectedIndexChanged
			Select Case Me.comboBox7.SelectedIndex
				Case 0
						Me.dateTimePickerAdv15.NullModeKeyReset = NullModeKeyReset.ArrowKeys
						Exit Select
				Case 1
						Me.dateTimePickerAdv15.NullModeKeyReset = NullModeKeyReset.NumericKeys
						Exit Select
				Case 2
						Me.dateTimePickerAdv15.NullModeKeyReset = NullModeKeyReset.Any
						Exit Select
			End Select
		End Sub
#End Region

		Private Sub checkBoxAdv1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv1.CheckStateChanged
			If Me.checkBoxAdv1.Checked Then
				Me.dateTimePickerAdv15.CustomPopupWindow = Me.popupControlContainer1
				Me.dateTimePickerAdv15.CustomDrop = True
			Else

				Me.dateTimePickerAdv15.CustomDrop = False

			End If

		End Sub

		#Region "PopUpControlContainer"


		Private Sub popupControlContainer1_Popup(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.monthCalendarAdv1.Focus()
		End Sub
		#End Region
		#End Region
#End Region

#Region "MonthCalendarAdv"
#Region "Visual Styles"
        Private Sub comboBox10_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox10.SelectedIndexChanged
            Select Case Me.comboBox10.SelectedItem.ToString()

                Case "Default"
                    Me.monthCalendarAdv2.Style = VisualStyle.Default
                    Me.comboBox9.Enabled = False
                    Exit Select
                Case "OfficeXP"
                    Me.monthCalendarAdv2.Style = VisualStyle.OfficeXP
                    Me.comboBox9.Enabled = False
                    Exit Select

                Case "Office2003"
                    Me.monthCalendarAdv2.Style = VisualStyle.Office2003
                    Me.comboBox9.Enabled = False
                    Exit Select
                Case "VS2005"
                    Me.monthCalendarAdv2.Style = VisualStyle.VS2005
                    Me.comboBox9.Enabled = False
                    Exit Select
                Case "Office2007"
                    Me.monthCalendarAdv2.Style = VisualStyle.Office2007
                    Me.comboBox9.Enabled = True
                    Exit Select
                Case "Office2007Outlook"
                    Me.monthCalendarAdv2.Style = VisualStyle.Office2007Outlook
                    Me.comboBox9.Enabled = False
                    Exit Select
            End Select
        End Sub
#End Region

#Region "Color Scheme"
        Private Sub comboBox9_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox9.SelectedIndexChanged
            If Me.comboBox9.SelectedItem.ToString() = "Blue" Then
                Me.monthCalendarAdv2.Office2007Theme = Office2007Theme.Blue
            ElseIf Me.comboBox9.SelectedItem.ToString() = "Silver" Then
                Me.monthCalendarAdv2.Office2007Theme = Office2007Theme.Silver
            Else
                Me.monthCalendarAdv2.Office2007Theme = Office2007Theme.Black
            End If
        End Sub
#End Region

#Region "Themes"
        Private Sub checkBoxAdv11_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv11.CheckStateChanged
            Me.monthCalendarAdv2.ThemedBorder = checkBoxAdv11.Checked
            Me.monthCalendarAdv2.ThemedEnabledGrid = checkBoxAdv11.Checked
            Me.monthCalendarAdv2.ThemedEnabledScrollButtons = checkBoxAdv11.Checked
        End Sub


#End Region

#Region "Select option"
        Private Sub checkBoxAdv13_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv13.CheckStateChanged
            Me.monthCalendarAdv2.AllowMultipleSelection = Me.checkBoxAdv13.Checked
        End Sub

        Private Sub checkBoxAdv14_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv14.CheckStateChanged
            Me.monthCalendarAdv2.MouseDragMultiselect = Me.checkBoxAdv14.Checked
        End Sub
#End Region


#Region "Culture settings"
        Private Sub comboBox11_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox11.SelectedIndexChanged
			Dim culture As String = comboBox11.SelectedItem.ToString()
            System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(culture)
            Me.monthCalendarAdv2.Culture = New System.Globalization.CultureInfo(culture)

        End Sub
#End Region

#Region "FirstDayOfWeek"
        Private Sub comboBox12_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox12.SelectedIndexChanged
            Select Case Me.comboBox12.SelectedItem.ToString()

                Case "Default"
                    Me.monthCalendarAdv2.FirstDayOfWeek = Day.Default

                    Exit Select
                Case "Friday"
                    Me.monthCalendarAdv2.FirstDayOfWeek = Day.Friday

                    Exit Select
                Case "Monday"
                    Me.monthCalendarAdv2.FirstDayOfWeek = Day.Monday

                    Exit Select
                Case "Saturday"
                    Me.monthCalendarAdv2.FirstDayOfWeek = Day.Saturday

                    Exit Select
                Case "Sunday"
                    Me.monthCalendarAdv2.FirstDayOfWeek = Day.Sunday

                    Exit Select
                Case "Thursday"
                    Me.monthCalendarAdv2.FirstDayOfWeek = Day.Thursday

                    Exit Select
                Case "Tuesday"
                    Me.monthCalendarAdv2.FirstDayOfWeek = Day.Tuesday

                    Exit Select
                Case "Wednesday"
                    Me.monthCalendarAdv2.FirstDayOfWeek = Day.Wednesday

                    Exit Select
            End Select
        End Sub
#End Region

#Region "Show Week numbers"
        Private Sub checkBoxAdv10_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv10.CheckStateChanged
            Me.monthCalendarAdv2.ShowWeekNumbers = checkBoxAdv10.Checked
        End Sub
#End Region

#Region "LeftButton Image"
        Private Sub checkBoxAdv15_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv15.CheckStateChanged
            If Me.checkBoxAdv15.Checked Then
                Me.monthCalendarAdv2.LeftScrollButtonImage = leftButtonImg
            Else
                Me.monthCalendarAdv2.LeftScrollButtonImage = Nothing
            End If
        End Sub
#End Region

#Region "Rightutton Image"
        Private Sub checkBoxAdv16_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv16.CheckStateChanged
            If Me.checkBoxAdv16.Checked Then
                Me.monthCalendarAdv2.RightScrollButtonImage = rightButtonImg
            Else
                Me.monthCalendarAdv2.RightScrollButtonImage = Nothing
            End If
        End Sub
#End Region

#Region "ColorSettings"
        Private Sub buttonEdit1_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit1.ButtonClicked

            If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                
                Me.buttonEdit1.TextBox.BackColor = colorDialog1.Color
                Me.monthCalendarAdv2.DayNamesColor = colorDialog1.Color
            End If

        End Sub


        Private Sub buttonEdit2_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit2.ButtonClicked
            If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
               
                Me.buttonEdit2.TextBox.BackColor = colorDialog1.Color
                Me.monthCalendarAdv2.BackColor = colorDialog1.Color
            End If
        End Sub

        Private Sub buttonEdit3_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit3.ButtonClicked
            If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                
                Me.buttonEdit3.TextBox.BackColor = colorDialog1.Color
                Me.monthCalendarAdv2.DaysColor = colorDialog1.Color
            End If
        End Sub

        Private Sub buttonEdit4_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit4.ButtonClicked
            If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                
                Me.buttonEdit4.TextBox.BackColor = colorDialog1.Color
                Me.monthCalendarAdv2.GridBackColor = colorDialog1.Color
            End If
        End Sub

        Private Sub checkBoxAdv12_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv12.CheckStateChanged
            
            Me.monthCalendarAdv2.HeaderVerticalGradient = Me.checkBoxAdv12.Checked
            Me.monthCalendarAdv2.HeadGradient = Me.checkBoxAdv12.Checked
        End Sub

        Private Sub buttonEdit5_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit5.ButtonClicked
            If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                
                Me.buttonEdit5.TextBox.BackColor = colorDialog1.Color
                Me.monthCalendarAdv2.HeaderEndColor = colorDialog1.Color
            End If
        End Sub

        Private Sub buttonEdit6_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit6.ButtonClicked
            If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                
                Me.buttonEdit6.TextBox.BackColor = colorDialog1.Color
                Me.monthCalendarAdv2.HeaderStartColor = colorDialog1.Color
            End If
        End Sub
#End Region



#End Region


        Private Sub monthCalendarAdv1_DateSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles monthCalendarAdv1.DateSelected
            Me.popupControlContainer1.HidePopup()
            Me.dateTimePickerAdv15.Value = Me.monthCalendarAdv1.SelectedDates(0)
        End Sub

        Private Sub monthCalendarAdv1_NoneButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles monthCalendarAdv1.NoneButtonClick
            popupControlContainer1.HidePopup()
            dateTimePickerAdv15.IsNullDate = True
        End Sub

        Private Sub monthCalendarAdv1_TodayButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles monthCalendarAdv1.TodayButton.Click
            dateTimePickerAdv15.Value = monthCalendarAdv1.Value
        End Sub
    End Class
End Namespace

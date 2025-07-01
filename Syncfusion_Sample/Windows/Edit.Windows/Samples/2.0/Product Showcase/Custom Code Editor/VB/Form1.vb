#Region "Namespaces Used"

Imports Microsoft.VisualBasic
Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports System.Collections
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D
Imports System.Xml.Serialization

Imports Syncfusion.IO
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Enums
Imports Syncfusion.Windows.Forms.Edit.Dialogs
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Implementation
Imports Syncfusion.Windows.Forms.Edit.Implementation.IO
Imports Syncfusion.Windows.Forms.Edit.Implementation.Config
Imports Syncfusion.Windows.Forms.Edit.Implementation.Parser
Imports Syncfusion.Windows.Forms.Edit.Implementation.Formatting
#End Region


Namespace CustomCodeEditorDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits Office2007Form
		#Region "Components on the Form"

		Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
		Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem12 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem13 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem14 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem15 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem16 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem17 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem18 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem19 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem20 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private WithEvents barItem21 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem22 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem27 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem28 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem29 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem30 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem31 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem25 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem26 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem23 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem44 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem45 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem46 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem47 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem48 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem49 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem50 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem52 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem53 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem54 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem55 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem56 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem57 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem58 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem59 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem61 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem60 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem62 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem63 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem64 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem65 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem66 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem67 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem68 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem69 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem70 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem71 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem72 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem73 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem74 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem24 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem75 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem76 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem77 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem78 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem79 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem80 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem81 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem82 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem83 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem84 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem85 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem86 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem87 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem88 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem89 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem90 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem91 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem92 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem93 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem94 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem95 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem96 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem97 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem98 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem99 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem100 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem101 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem102 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem103 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem104 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem105 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem106 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem107 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem108 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem109 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem110 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem111 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem112 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem114 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem113 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem115 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem117 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem118 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem119 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem120 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem116 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem121 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem32 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem33 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem34 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem35 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem36 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem

		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem12 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem13 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem14 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem15 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem16 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem17 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem18 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem19 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem20 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem21 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem22 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem23 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem24 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem

		Private popupMenu1 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private popupMenusManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager

		Private components As System.ComponentModel.IContainer = Nothing

		Private inputdialog As InsertText
		Private inputString As String = String.Empty
		Private accepted As Boolean = False
		Private imageList1 As System.Windows.Forms.ImageList
		Private image1, image2, image3, image4, selectedImage As Bitmap

		Private currentCursor As Cursor = Cursors.Default

		Private Shared form1_Renamed As Form1 = Nothing

		#End Region


		#Region "Declaration"
		Private reader As XmlTextReader
		Private intellisensePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Intellisense.xml"
		Private imagePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Images\"
		Private BasePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Test Files\"
		Private filePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Test Files\CSharpSource.cs"
		Private generatedFilesPath As String=Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Generated Files"
		Private WithEvents barItem37 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem38 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem39 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem40 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem41 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem42 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem43 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem51 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents button4 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private radioButton16 As System.Windows.Forms.RadioButton
		Private radioButton15 As System.Windows.Forms.RadioButton
		Private radioButton14 As System.Windows.Forms.RadioButton
		Private radioButton13 As System.Windows.Forms.RadioButton
		Private radioButton12 As System.Windows.Forms.RadioButton
		Private groupBox4 As System.Windows.Forms.GroupBox
		Private radioButton9 As System.Windows.Forms.RadioButton
		Private radioButton10 As System.Windows.Forms.RadioButton
		Private radioButton11 As System.Windows.Forms.RadioButton
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private checkBox2 As System.Windows.Forms.CheckBox
		Private label3 As System.Windows.Forms.Label
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button1 As System.Windows.Forms.Button
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private comboBox2 As System.Windows.Forms.ComboBox
		Private radioButton5 As System.Windows.Forms.RadioButton
		Private radioButton6 As System.Windows.Forms.RadioButton
		Private radioButton7 As System.Windows.Forms.RadioButton
		Private radioButton8 As System.Windows.Forms.RadioButton
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private radioButton4 As System.Windows.Forms.RadioButton
		Private radioButton2 As System.Windows.Forms.RadioButton
		Private radioButton3 As System.Windows.Forms.RadioButton
		Private radioButton1 As System.Windows.Forms.RadioButton
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private panel3 As System.Windows.Forms.Panel
		Private WithEvents button7 As System.Windows.Forms.Button
		Private WithEvents button8 As System.Windows.Forms.Button
		Private groupBox7 As System.Windows.Forms.GroupBox
		Private radioButton25 As System.Windows.Forms.RadioButton
		Private radioButton26 As System.Windows.Forms.RadioButton
		Private radioButton27 As System.Windows.Forms.RadioButton
		Private radioButton28 As System.Windows.Forms.RadioButton
		Private radioButton29 As System.Windows.Forms.RadioButton
		Private groupBox8 As System.Windows.Forms.GroupBox
		Private radioButton30 As System.Windows.Forms.RadioButton
		Private radioButton31 As System.Windows.Forms.RadioButton
		Private radioButton32 As System.Windows.Forms.RadioButton
		Private label6 As System.Windows.Forms.Label
		Private panel2 As System.Windows.Forms.Panel
		Private WithEvents button5 As System.Windows.Forms.Button
		Private WithEvents button6 As System.Windows.Forms.Button
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private groupBox5 As System.Windows.Forms.GroupBox
		Private radioButton17 As System.Windows.Forms.RadioButton
		Private radioButton18 As System.Windows.Forms.RadioButton
		Private radioButton19 As System.Windows.Forms.RadioButton
		Private radioButton20 As System.Windows.Forms.RadioButton
		Private groupBox6 As System.Windows.Forms.GroupBox
		Private radioButton21 As System.Windows.Forms.RadioButton
		Private radioButton22 As System.Windows.Forms.RadioButton
		Private radioButton23 As System.Windows.Forms.RadioButton
		Private radioButton24 As System.Windows.Forms.RadioButton
		Private panel1 As System.Windows.Forms.Panel
		Public WithEvents editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
		Private propertyEditor As System.Windows.Forms.PropertyGrid
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private parentBarItem25 As ParentBarItem
		Private WithEvents barItem122 As BarItem
		Private exportPath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Generated Files\"
		Private WithEvents barItem123 As BarItem
		Private WithEvents barItem124 As BarItem
		Private imageList2 As ImageList
		Private arr As ArrayList

		#End Region

		#Region "Initialization code"

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			mainFrameBarManager1.InternalDocking = False
			image1 = New Bitmap(imagePath & "Image1.png")
			image2 = New Bitmap(imagePath & "Image2.png")
			image3 = New Bitmap(imagePath & "Image3.png")
			image4 = New Bitmap(imagePath & "Image4.png")

			selectedImage = image4

			Me.editControl1.ShowHorizontalSplitters = True
			Me.editControl1.ShowVerticalSplitters = True

			inputdialog = New InsertText()
			AddHandler inputdialog.AcceptButton.Click, AddressOf AcceptButton_Clicked
			AddHandler inputdialog.CancelButton.Click, AddressOf CancelButton_Clicked

			Me.barItem10.Enabled = False
			Me.barItem11.Enabled = False

			Me.editControl1.StatusBarSettings.StatusPanel.Visible = False
			Me.editControl1.LoadFile(filePath)
			Directory.CreateDirectory(generatedFilesPath)
			generatedFilesPath &= "\"

			arr = New ArrayList()

            Me.propertyEditor.BackColor = System.Drawing.Color.FromArgb((CByte(227)), (CByte(239)), (CByte(255)))
			Me.propertyEditor.CommandsBackColor = System.Drawing.Color.FromArgb((CByte(227)), (CByte(239)), (CByte(255)))
			Me.propertyEditor.CommandsForeColor = System.Drawing.Color.MidnightBlue
			Me.propertyEditor.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.propertyEditor.HelpBackColor = System.Drawing.Color.FromArgb((CByte(227)), (CByte(239)), (CByte(255)))
			Me.propertyEditor.HelpForeColor = System.Drawing.Color.MidnightBlue
			Me.propertyEditor.LineColor = System.Drawing.Color.FromArgb((CByte(185)), (CByte(216)), (CByte(255)))
			Me.propertyEditor.ViewBackColor = System.Drawing.Color.FromArgb((CByte(227)), (CByte(239)), (CByte(255)))
			Me.propertyEditor.ViewForeColor = System.Drawing.Color.MidnightBlue

            AddHandler Me.editControl1.ContextChoiceOpen, AddressOf Me.editControl1_ContextChoiceOpen
			AddHandler editControl1.ContextPromptBeforeOpen, AddressOf editControl1_ContextPromptBeforeOpen
			AddHandler editControl1.ContextChoiceBeforeOpen, AddressOf editControl1_ContextChoiceBeforeOpen
            AddHandler Me.editControl1.ContextChoiceClose, AddressOf Me.editControl1_ContextChoiceClose
            AddHandler Me.editControl1.ContextPromptOpen, AddressOf Me.editControl1_ContextPromptOpen
            AddHandler Me.editControl1.ContextChoiceItemSelected, AddressOf Me.editControl1_ContextChoiceItemSelected

			Dim index As Integer = 0
			For Each img As Image In Me.imageList2.Images
				' Populating images using an external ImageList
				Me.editControl1.ContextChoiceController.AddImage("Image" & index.ToString(), img)
				index += 1
			Next img

		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
		#End Region         

		Private Sub AcceptButton_Clicked(ByVal sender As Object, ByVal args As EventArgs)
			Me.inputString = Me.inputdialog.InputString
			Me.accepted = True
			Me.inputdialog.Close()
		End Sub

		Private Sub CancelButton_Clicked(ByVal sender As Object, ByVal args As EventArgs)
			Me.accepted = False
			Me.inputdialog.Close()
		End Sub


		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim Config1 As Syncfusion.Windows.Forms.Edit.Implementation.Config.Config = New Syncfusion.Windows.Forms.Edit.Implementation.Config.Config
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
            Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Mainmenu")
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem52 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem53 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem54 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem120 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem20 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem13 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem14 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem16 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem15 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem48 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem49 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem50 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem17 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem18 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem19 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.parentBarItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.parentBarItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem27 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem28 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem29 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem30 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem21 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem33 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem34 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem25 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem26 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem35 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem36 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem23 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem24 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem32 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem55 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem56 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem57 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem61 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem119 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem58 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem59 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem60 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem116 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem84 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem24 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem121 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.parentBarItem13 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem62 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem63 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem64 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem65 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem66 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem67 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem68 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem69 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem70 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem71 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem72 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem73 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem74 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem18 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem89 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem90 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem99 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem100 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem93 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem94 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem91 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem92 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem97 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem98 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem95 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem96 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem112 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem75 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem86 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem17 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem87 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem88 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem14 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem77 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem78 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem79 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem115 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem23 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem114 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem113 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem19 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.parentBarItem22 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem109 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem110 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem111 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem21 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem106 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem107 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem108 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem20 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem101 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem102 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem103 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem104 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem105 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem123 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem124 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem15 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem80 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem81 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem82 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem83 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem44 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem45 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem46 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem47 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem38 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem37 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem39 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem40 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem41 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem42 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem43 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem118 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem25 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem117 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem122 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Standered")
            Me.barItem22 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem31 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.barItem76 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem85 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem51 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.popupMenu1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
            Me.popupMenusManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(Me.components)
            Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl
            Me.parentBarItem16 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.button4 = New System.Windows.Forms.Button
            Me.button3 = New System.Windows.Forms.Button
            Me.radioButton16 = New System.Windows.Forms.RadioButton
            Me.radioButton15 = New System.Windows.Forms.RadioButton
            Me.radioButton14 = New System.Windows.Forms.RadioButton
            Me.radioButton13 = New System.Windows.Forms.RadioButton
            Me.radioButton12 = New System.Windows.Forms.RadioButton
            Me.groupBox4 = New System.Windows.Forms.GroupBox
            Me.radioButton9 = New System.Windows.Forms.RadioButton
            Me.radioButton10 = New System.Windows.Forms.RadioButton
            Me.radioButton11 = New System.Windows.Forms.RadioButton
            Me.groupBox3 = New System.Windows.Forms.GroupBox
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.label3 = New System.Windows.Forms.Label
            Me.button2 = New System.Windows.Forms.Button
            Me.button1 = New System.Windows.Forms.Button
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.radioButton5 = New System.Windows.Forms.RadioButton
            Me.radioButton6 = New System.Windows.Forms.RadioButton
            Me.radioButton7 = New System.Windows.Forms.RadioButton
            Me.radioButton8 = New System.Windows.Forms.RadioButton
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.radioButton4 = New System.Windows.Forms.RadioButton
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.radioButton3 = New System.Windows.Forms.RadioButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.panel3 = New System.Windows.Forms.Panel
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label6 = New System.Windows.Forms.Label
            Me.button7 = New System.Windows.Forms.Button
            Me.button8 = New System.Windows.Forms.Button
            Me.groupBox7 = New System.Windows.Forms.GroupBox
            Me.radioButton25 = New System.Windows.Forms.RadioButton
            Me.radioButton26 = New System.Windows.Forms.RadioButton
            Me.radioButton27 = New System.Windows.Forms.RadioButton
            Me.radioButton28 = New System.Windows.Forms.RadioButton
            Me.radioButton29 = New System.Windows.Forms.RadioButton
            Me.groupBox8 = New System.Windows.Forms.GroupBox
            Me.radioButton30 = New System.Windows.Forms.RadioButton
            Me.radioButton31 = New System.Windows.Forms.RadioButton
            Me.radioButton32 = New System.Windows.Forms.RadioButton
            Me.panel2 = New System.Windows.Forms.Panel
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label4 = New System.Windows.Forms.Label
            Me.button5 = New System.Windows.Forms.Button
            Me.button6 = New System.Windows.Forms.Button
            Me.label5 = New System.Windows.Forms.Label
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.groupBox5 = New System.Windows.Forms.GroupBox
            Me.radioButton17 = New System.Windows.Forms.RadioButton
            Me.radioButton18 = New System.Windows.Forms.RadioButton
            Me.radioButton19 = New System.Windows.Forms.RadioButton
            Me.radioButton20 = New System.Windows.Forms.RadioButton
            Me.groupBox6 = New System.Windows.Forms.GroupBox
            Me.radioButton21 = New System.Windows.Forms.RadioButton
            Me.radioButton22 = New System.Windows.Forms.RadioButton
            Me.radioButton23 = New System.Windows.Forms.RadioButton
            Me.radioButton24 = New System.Windows.Forms.RadioButton
            Me.panel1 = New System.Windows.Forms.Panel
            Me.propertyEditor = New System.Windows.Forms.PropertyGrid
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            Me.groupBox7.SuspendLayout()
            Me.groupBox8.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            Me.groupBox5.SuspendLayout()
            Me.groupBox6.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'mainFrameBarManager1
            '
            Me.mainFrameBarManager1.BarPositionInfo = CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.mainFrameBarManager1.Bars.Add(Me.bar1)
            Me.mainFrameBarManager1.Bars.Add(Me.bar2)
            Me.mainFrameBarManager1.Categories.Add("&File")
            Me.mainFrameBarManager1.Categories.Add("&Edit")
            Me.mainFrameBarManager1.Categories.Add("Window")
            Me.mainFrameBarManager1.Categories.Add("&Language")
            Me.mainFrameBarManager1.Categories.Add("Help")
            Me.mainFrameBarManager1.Categories.Add("Property Grid")
            Me.mainFrameBarManager1.Categories.Add("Print")
            Me.mainFrameBarManager1.CurrentBaseFormType = ""
            Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mainFrameBarManager1.Form = Me
            Me.mainFrameBarManager1.ImageList = Me.imageList1
            Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem10, Me.barItem11, Me.barItem12, Me.barItem13, Me.barItem14, Me.barItem15, Me.barItem1, Me.barItem16, Me.barItem17, Me.barItem18, Me.barItem19, Me.parentBarItem4, Me.barItem2, Me.barItem21, Me.barItem22, Me.parentBarItem7, Me.barItem27, Me.barItem28, Me.barItem29, Me.barItem3, Me.barItem30, Me.barItem31, Me.barItem4, Me.barItem5, Me.parentBarItem5, Me.barItem6, Me.parentBarItem3, Me.barItem26, Me.barItem25, Me.parentBarItem11, Me.barItem44, Me.parentBarItem1, Me.barItem45, Me.barItem46, Me.barItem47, Me.barItem49, Me.barItem48, Me.barItem7, Me.barItem50, Me.parentBarItem13, Me.barItem62, Me.barItem63, Me.parentBarItem2, Me.barItem64, Me.barItem65, Me.barItem66, Me.barItem67, Me.barItem68, Me.barItem8, Me.barItem69, Me.barItem70, Me.barItem71, Me.barItem72, Me.barItem73, Me.barItem74, Me.barItem9, Me.barItem75, Me.barItem76, Me.parentBarItem14, Me.barItem77, Me.barItem78, Me.barItem79, Me.parentBarItem15, Me.barItem20, Me.barItem80, Me.barItem81, Me.barItem82, Me.barItem83, Me.barItem86, Me.barItem87, Me.parentBarItem17, Me.barItem88, Me.parentBarItem10, Me.barItem23, Me.barItem24, Me.barItem52, Me.barItem53, Me.barItem54, Me.parentBarItem12, Me.barItem55, Me.barItem56, Me.barItem57, Me.barItem58, Me.barItem59, Me.barItem61, Me.barItem60, Me.barItem84, Me.barItem85, Me.parentBarItem18, Me.barItem89, Me.barItem90, Me.barItem91, Me.barItem92, Me.barItem93, Me.barItem94, Me.barItem95, Me.barItem96, Me.barItem97, Me.barItem98, Me.barItem99, Me.barItem100, Me.parentBarItem19, Me.parentBarItem20, Me.parentBarItem21, Me.parentBarItem22, Me.barItem101, Me.barItem102, Me.barItem103, Me.barItem104, Me.barItem105, Me.barItem106, Me.barItem107, Me.barItem108, Me.barItem109, Me.barItem110, Me.barItem111, Me.barItem112, Me.parentBarItem23, Me.barItem114, Me.barItem113, Me.barItem115, Me.barItem116, Me.barItem117, Me.barItem118, Me.barItem119, Me.barItem120, Me.parentBarItem24, Me.barItem121, Me.barItem32, Me.parentBarItem6, Me.barItem33, Me.barItem34, Me.barItem35, Me.barItem36, Me.barItem37, Me.barItem38, Me.parentBarItem8, Me.barItem39, Me.barItem40, Me.barItem41, Me.parentBarItem9, Me.barItem42, Me.barItem43, Me.barItem51, Me.barItem122, Me.parentBarItem25, Me.barItem123, Me.barItem124})
            Me.mainFrameBarManager1.ResetCustomization = False
            Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'bar1
            '
            Me.bar1.BarName = "Mainmenu"
            Me.bar1.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar1.Caption = "Mainmenu"
            Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem2, Me.parentBarItem3, Me.parentBarItem10, Me.parentBarItem12, Me.parentBarItem24, Me.parentBarItem11, Me.barItem118, Me.parentBarItem25})
            Me.bar1.Manager = Me.mainFrameBarManager1
            '
            'parentBarItem2
            '
            Me.parentBarItem2.CategoryIndex = 0
            Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem2.ID = "&File"
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem4, Me.barItem52, Me.barItem53, Me.barItem54, Me.barItem120, Me.barItem20})
            Me.parentBarItem2.SeparatorIndices.AddRange(New Integer() {2, 4, 7})
            Me.parentBarItem2.Text = "&File"
            '
            'barItem1
            '
            Me.barItem1.CategoryIndex = 0
            Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem1.ID = "&New"
            Me.barItem1.ImageIndex = 0
            Me.barItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlN
            Me.barItem1.Text = "&New"
            Me.barItem1.Tooltip = "New Document"
            '
            'barItem2
            '
            Me.barItem2.CategoryIndex = 0
            Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem2.ID = "&Open"
            Me.barItem2.ImageIndex = 43
            Me.barItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.barItem2.Text = "&Open"
            Me.barItem2.Tooltip = "Open Document"
            '
            'barItem3
            '
            Me.barItem3.CategoryIndex = 0
            Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem3.ID = "&Save"
            Me.barItem3.ImageIndex = 44
            Me.barItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.barItem3.Text = "&Save"
            Me.barItem3.Tooltip = "Save File"
            '
            'barItem4
            '
            Me.barItem4.CategoryIndex = 0
            Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem4.ID = "Save &As"
            Me.barItem4.ImageIndex = 53
            Me.barItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftA
            Me.barItem4.Text = "Save &As"
            '
            'barItem52
            '
            Me.barItem52.CategoryIndex = 0
            Me.barItem52.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem52.ID = "Save As &HTML"
            Me.barItem52.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftH
            Me.barItem52.Text = "Save As &HTML"
            '
            'barItem53
            '
            Me.barItem53.CategoryIndex = 0
            Me.barItem53.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem53.ID = "Save As &XML"
            Me.barItem53.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftX
            Me.barItem53.Text = "Save As &XML"
            '
            'barItem54
            '
            Me.barItem54.CategoryIndex = 0
            Me.barItem54.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem54.ID = "Save As &RTF"
            Me.barItem54.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftR
            Me.barItem54.Text = "Save As &RTF"
            '
            'barItem120
            '
            Me.barItem120.CategoryIndex = 0
            Me.barItem120.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem120.ID = "Close"
            Me.barItem120.Text = "C&lose"
            '
            'barItem20
            '
            Me.barItem20.CategoryIndex = 0
            Me.barItem20.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem20.ID = "E&xit"
            Me.barItem20.Shortcut = System.Windows.Forms.Shortcut.AltF4
            Me.barItem20.Text = "E&xit"
            '
            'parentBarItem3
            '
            Me.parentBarItem3.CategoryIndex = 1
            Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem3.ID = "&Edit"
            Me.parentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem10, Me.barItem11, Me.barItem12, Me.barItem13, Me.barItem14, Me.barItem16, Me.barItem15, Me.barItem48, Me.barItem49, Me.barItem50, Me.barItem17, Me.barItem18, Me.barItem19, Me.parentBarItem4})
            Me.parentBarItem3.SeparatorIndices.AddRange(New Integer() {2, 7, 10})
            Me.parentBarItem3.Text = "&Edit"
            '
            'barItem10
            '
            Me.barItem10.CategoryIndex = 1
            Me.barItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem10.Enabled = False
            Me.barItem10.ID = "&Undo"
            Me.barItem10.ImageIndex = 45
            Me.barItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
            Me.barItem10.Text = "&Undo"
            Me.barItem10.Tooltip = "Undo"
            '
            'barItem11
            '
            Me.barItem11.CategoryIndex = 1
            Me.barItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem11.Enabled = False
            Me.barItem11.ID = "&Redo"
            Me.barItem11.ImageIndex = 46
            Me.barItem11.Shortcut = System.Windows.Forms.Shortcut.CtrlY
            Me.barItem11.Text = "&Redo"
            Me.barItem11.Tooltip = "Redo"
            '
            'barItem12
            '
            Me.barItem12.CategoryIndex = 1
            Me.barItem12.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem12.ID = "Cu&t"
            Me.barItem12.ImageIndex = 47
            Me.barItem12.Shortcut = System.Windows.Forms.Shortcut.CtrlX
            Me.barItem12.Text = "Cu&t"
            Me.barItem12.Tooltip = "Cut"
            '
            'barItem13
            '
            Me.barItem13.CategoryIndex = 1
            Me.barItem13.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem13.ID = "&Copy"
            Me.barItem13.ImageIndex = 48
            Me.barItem13.Shortcut = System.Windows.Forms.Shortcut.CtrlC
            Me.barItem13.Text = "&Copy"
            Me.barItem13.Tooltip = "Copy"
            '
            'barItem14
            '
            Me.barItem14.CategoryIndex = 1
            Me.barItem14.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem14.ID = "&Paste"
            Me.barItem14.ImageIndex = 49
            Me.barItem14.Shortcut = System.Windows.Forms.Shortcut.CtrlV
            Me.barItem14.Text = "&Paste"
            Me.barItem14.Tooltip = "Paste"
            '
            'barItem16
            '
            Me.barItem16.CategoryIndex = 1
            Me.barItem16.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem16.ID = "Select &All"
            Me.barItem16.Shortcut = System.Windows.Forms.Shortcut.CtrlA
            Me.barItem16.Text = "Select &All"
            '
            'barItem15
            '
            Me.barItem15.CategoryIndex = 1
            Me.barItem15.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem15.ID = "Delete"
            Me.barItem15.ImageIndex = 51
            Me.barItem15.ShortcutText = "Del"
            Me.barItem15.Text = "Delete"
            '
            'barItem48
            '
            Me.barItem48.CategoryIndex = 1
            Me.barItem48.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem48.ID = "CollapseAll"
            Me.barItem48.Text = "CollapseAll"
            '
            'barItem49
            '
            Me.barItem49.CategoryIndex = 1
            Me.barItem49.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem49.ID = "ExpandAll"
            Me.barItem49.Text = "ExpandAll"
            '
            'barItem50
            '
            Me.barItem50.CategoryIndex = 1
            Me.barItem50.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem50.ID = "Show Collapsers"
            Me.barItem50.Text = "Show Collapsers"
            '
            'barItem17
            '
            Me.barItem17.CategoryIndex = 1
            Me.barItem17.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem17.ID = "Find"
            Me.barItem17.ImageIndex = 54
            Me.barItem17.Shortcut = System.Windows.Forms.Shortcut.CtrlF
            Me.barItem17.Text = "Find"
            '
            'barItem18
            '
            Me.barItem18.CategoryIndex = 1
            Me.barItem18.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem18.ID = "Replace"
            Me.barItem18.Shortcut = System.Windows.Forms.Shortcut.CtrlH
            Me.barItem18.Text = "Replace"
            '
            'barItem19
            '
            Me.barItem19.CategoryIndex = 1
            Me.barItem19.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem19.ID = "Goto"
            Me.barItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlG
            Me.barItem19.Text = "GoTo"
            '
            'parentBarItem4
            '
            Me.parentBarItem4.CategoryIndex = 1
            Me.parentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem4.ID = "&Book Marks"
            Me.parentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem5, Me.parentBarItem6, Me.barItem25, Me.barItem26, Me.barItem35, Me.barItem36})
            Me.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem4.Text = "&Book Marks"
            '
            'parentBarItem5
            '
            Me.parentBarItem5.CategoryIndex = 1
            Me.parentBarItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem5.ID = "Custom"
            Me.parentBarItem5.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem7, Me.barItem21})
            Me.parentBarItem5.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem5.Text = "Custom"
            '
            'parentBarItem7
            '
            Me.parentBarItem7.CategoryIndex = 1
            Me.parentBarItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem7.ID = "Select Image"
            Me.parentBarItem7.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem27, Me.barItem28, Me.barItem29, Me.barItem30})
            Me.parentBarItem7.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem7.Text = "Select Image"
            '
            'barItem27
            '
            Me.barItem27.CategoryIndex = 1
            Me.barItem27.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem27.ID = "Image1"
            Me.barItem27.ImageIndex = 70
            Me.barItem27.Text = "Image1"
            '
            'barItem28
            '
            Me.barItem28.CategoryIndex = 1
            Me.barItem28.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem28.ID = "Image2"
            Me.barItem28.ImageIndex = 71
            Me.barItem28.Text = "Image2"
            '
            'barItem29
            '
            Me.barItem29.CategoryIndex = 1
            Me.barItem29.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem29.ID = "Image3"
            Me.barItem29.ImageIndex = 72
            Me.barItem29.Text = "Image3"
            '
            'barItem30
            '
            Me.barItem30.CategoryIndex = 1
            Me.barItem30.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem30.ID = "Image4"
            Me.barItem30.ImageIndex = 73
            Me.barItem30.Text = "Image4"
            '
            'barItem21
            '
            Me.barItem21.CategoryIndex = 1
            Me.barItem21.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem21.ID = "Insert CustomBookMark"
            Me.barItem21.Text = "Insert CustomBookMark"
            '
            'parentBarItem6
            '
            Me.parentBarItem6.CategoryIndex = 1
            Me.parentBarItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem6.ID = "Default_1"
            Me.parentBarItem6.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem33, Me.barItem34})
            Me.parentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
            Me.parentBarItem6.Text = "Default"
            '
            'barItem33
            '
            Me.barItem33.CategoryIndex = 1
            Me.barItem33.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem33.ID = "Add BookMark"
            Me.barItem33.Text = "Add BookMark"
            '
            'barItem34
            '
            Me.barItem34.CategoryIndex = 1
            Me.barItem34.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem34.ID = "Remove BookMark"
            Me.barItem34.Text = "Remove BookMark"
            '
            'barItem25
            '
            Me.barItem25.CategoryIndex = 1
            Me.barItem25.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem25.ID = "&Next BookMark"
            Me.barItem25.ImageIndex = 9
            Me.barItem25.Text = "&Next BookMark"
            Me.barItem25.Tooltip = "Next BookMark"
            '
            'barItem26
            '
            Me.barItem26.CategoryIndex = 1
            Me.barItem26.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem26.ID = "&Previous BookMark"
            Me.barItem26.ImageIndex = 10
            Me.barItem26.Text = "&Previous BookMark"
            Me.barItem26.Tooltip = "Previous Bookmark"
            '
            'barItem35
            '
            Me.barItem35.CategoryIndex = 1
            Me.barItem35.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem35.ID = "Toggle BookMark_1"
            Me.barItem35.Text = "Toggle BookMark"
            '
            'barItem36
            '
            Me.barItem36.CategoryIndex = 1
            Me.barItem36.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem36.ID = "Clear All BookMarks"
            Me.barItem36.Text = "Clear All BookMarks"
            '
            'parentBarItem10
            '
            Me.parentBarItem10.CategoryIndex = 2
            Me.parentBarItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem10.ID = "&Window"
            Me.parentBarItem10.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem23, Me.barItem24, Me.barItem32})
            Me.parentBarItem10.Text = "&Window"
            '
            'barItem23
            '
            Me.barItem23.CategoryIndex = 2
            Me.barItem23.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem23.ID = "Split Vertically"
            Me.barItem23.ImageIndex = 57
            Me.barItem23.Text = "Split Vertically"
            '
            'barItem24
            '
            Me.barItem24.CategoryIndex = 2
            Me.barItem24.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem24.ID = "Split Horizontally"
            Me.barItem24.ImageIndex = 56
            Me.barItem24.Text = "Split Horizontally"
            '
            'barItem32
            '
            Me.barItem32.CategoryIndex = 2
            Me.barItem32.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem32.ID = "Split Into Quadrants"
            Me.barItem32.ImageIndex = 55
            Me.barItem32.Text = "Split Into Quadrants"
            '
            'parentBarItem12
            '
            Me.parentBarItem12.CategoryIndex = 3
            Me.parentBarItem12.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem12.ID = "&Language"
            Me.parentBarItem12.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem55, Me.barItem56, Me.barItem57, Me.barItem61, Me.barItem119, Me.barItem58, Me.barItem59, Me.barItem60, Me.barItem116, Me.barItem84})
            Me.parentBarItem12.SeparatorIndices.AddRange(New Integer() {9})
            Me.parentBarItem12.Text = "&Language"
            '
            'barItem55
            '
            Me.barItem55.CategoryIndex = 3
            Me.barItem55.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem55.ID = "CSharp"
            Me.barItem55.Text = "CSharp"
            '
            'barItem56
            '
            Me.barItem56.CategoryIndex = 3
            Me.barItem56.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem56.ID = "HTML"
            Me.barItem56.Text = "HTML"
            '
            'barItem57
            '
            Me.barItem57.CategoryIndex = 3
            Me.barItem57.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem57.ID = "XML"
            Me.barItem57.Text = "XML"
            '
            'barItem61
            '
            Me.barItem61.CategoryIndex = 3
            Me.barItem61.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem61.ID = "VB .Net"
            Me.barItem61.Text = "VB.NET"
            '
            'barItem119
            '
            Me.barItem119.CategoryIndex = 3
            Me.barItem119.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem119.ID = "SQL"
            Me.barItem119.Text = "SQL"
            '
            'barItem58
            '
            Me.barItem58.CategoryIndex = 3
            Me.barItem58.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem58.ID = "Pascal"
            Me.barItem58.Text = "Pascal"
            '
            'barItem59
            '
            Me.barItem59.CategoryIndex = 3
            Me.barItem59.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem59.ID = "Delphi"
            Me.barItem59.Text = "VBScript"
            '
            'barItem60
            '
            Me.barItem60.CategoryIndex = 3
            Me.barItem60.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem60.ID = "HTML with embedded JScript"
            Me.barItem60.Text = "JScript"
            '
            'barItem116
            '
            Me.barItem116.CategoryIndex = 3
            Me.barItem116.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem116.ID = "Default Language"
            Me.barItem116.Text = "Default Language"
            '
            'barItem84
            '
            Me.barItem84.CategoryIndex = 3
            Me.barItem84.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem84.ID = "Modify Text  Properties"
            Me.barItem84.ImageIndex = 69
            Me.barItem84.Text = "Configuration Editor"
            Me.barItem84.Tooltip = "Configuration Editor"
            '
            'parentBarItem24
            '
            Me.parentBarItem24.CategoryIndex = 6
            Me.parentBarItem24.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem24.ID = "Print_1"
            Me.parentBarItem24.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem121, Me.barItem5, Me.barItem6, Me.parentBarItem1})
            Me.parentBarItem24.Text = "Printing"
            '
            'barItem121
            '
            Me.barItem121.CategoryIndex = 6
            Me.barItem121.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem121.ID = "&Print"
            Me.barItem121.Text = "&Print"
            '
            'barItem5
            '
            Me.barItem5.CategoryIndex = 6
            Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem5.ID = "&Print Preview"
            Me.barItem5.ImageIndex = 52
            Me.barItem5.Text = "Print Preview"
            Me.barItem5.Tooltip = "Print Preview"
            '
            'barItem6
            '
            Me.barItem6.CategoryIndex = 6
            Me.barItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem6.ID = "&Show Print Dialog"
            Me.barItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlP
            Me.barItem6.Text = "Print Dialog"
            '
            'parentBarItem1
            '
            Me.parentBarItem1.CategoryIndex = 6
            Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem1.ID = "Print"
            Me.parentBarItem1.ImageIndex = 50
            Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem9, Me.barItem8, Me.barItem7})
            Me.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem1.Text = "Print Options"
            Me.parentBarItem1.Tooltip = "print"
            '
            'barItem9
            '
            Me.barItem9.CategoryIndex = 6
            Me.barItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem9.ID = "Print Current Page"
            Me.barItem9.Text = "Print Current Page"
            '
            'barItem8
            '
            Me.barItem8.CategoryIndex = 6
            Me.barItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem8.ID = "Print Selected Text"
            Me.barItem8.Text = "Print Selected Text"
            '
            'barItem7
            '
            Me.barItem7.CategoryIndex = 6
            Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem7.ID = "Print To document"
            Me.barItem7.Text = "Print To File"
            '
            'parentBarItem11
            '
            Me.parentBarItem11.CategoryIndex = 1
            Me.parentBarItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem11.ID = "Ad&vanced"
            Me.parentBarItem11.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem13, Me.parentBarItem18, Me.barItem112, Me.barItem75, Me.barItem86, Me.parentBarItem17, Me.parentBarItem14, Me.parentBarItem23, Me.parentBarItem19, Me.barItem123, Me.barItem124, Me.parentBarItem15, Me.barItem83, Me.barItem44, Me.barItem45, Me.barItem46, Me.barItem47, Me.barItem38, Me.barItem37, Me.parentBarItem8, Me.parentBarItem9})
            Me.parentBarItem11.SeparatorIndices.AddRange(New Integer() {11, 13, 17})
            Me.parentBarItem11.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem11.Text = "Ad&vanced"
            '
            'parentBarItem13
            '
            Me.parentBarItem13.CategoryIndex = 1
            Me.parentBarItem13.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem13.ID = "Custom Cursor"
            Me.parentBarItem13.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem62, Me.barItem63, Me.barItem64, Me.barItem65, Me.barItem66, Me.barItem67, Me.barItem68, Me.barItem69, Me.barItem70, Me.barItem71, Me.barItem72, Me.barItem73, Me.barItem74})
            Me.parentBarItem13.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem13.Text = "Custom Cursor"
            '
            'barItem62
            '
            Me.barItem62.CategoryIndex = 1
            Me.barItem62.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem62.ID = "AppStarting"
            Me.barItem62.Text = "AppStarting"
            '
            'barItem63
            '
            Me.barItem63.CategoryIndex = 1
            Me.barItem63.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem63.ID = "Arrow"
            Me.barItem63.Text = "Arrow"
            '
            'barItem64
            '
            Me.barItem64.CategoryIndex = 1
            Me.barItem64.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem64.ID = "Cross"
            Me.barItem64.Text = "Cross"
            '
            'barItem65
            '
            Me.barItem65.CategoryIndex = 1
            Me.barItem65.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem65.ID = "Default"
            Me.barItem65.Text = "Default"
            '
            'barItem66
            '
            Me.barItem66.CategoryIndex = 1
            Me.barItem66.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem66.ID = "Hand"
            Me.barItem66.Text = "Hand"
            '
            'barItem67
            '
            Me.barItem67.CategoryIndex = 1
            Me.barItem67.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem67.ID = "Help"
            Me.barItem67.Text = "Help"
            '
            'barItem68
            '
            Me.barItem68.CategoryIndex = 1
            Me.barItem68.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem68.ID = "HSplit"
            Me.barItem68.Text = "HSplit"
            '
            'barItem69
            '
            Me.barItem69.CategoryIndex = 1
            Me.barItem69.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem69.ID = "IBeam"
            Me.barItem69.Text = "IBeam"
            '
            'barItem70
            '
            Me.barItem70.CategoryIndex = 1
            Me.barItem70.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem70.ID = "No"
            Me.barItem70.Text = "No"
            '
            'barItem71
            '
            Me.barItem71.CategoryIndex = 1
            Me.barItem71.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem71.ID = "SizeAll"
            Me.barItem71.Text = "SizeAll"
            '
            'barItem72
            '
            Me.barItem72.CategoryIndex = 1
            Me.barItem72.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem72.ID = "UpArrow"
            Me.barItem72.Text = "UpArrow"
            '
            'barItem73
            '
            Me.barItem73.CategoryIndex = 1
            Me.barItem73.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem73.ID = "VSplit"
            Me.barItem73.Text = "VSplit"
            '
            'barItem74
            '
            Me.barItem74.CategoryIndex = 1
            Me.barItem74.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem74.ID = "WaitCursor"
            Me.barItem74.Text = "WaitCursor"
            '
            'parentBarItem18
            '
            Me.parentBarItem18.CategoryIndex = 1
            Me.parentBarItem18.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem18.ID = "NavigationMenu"
            Me.parentBarItem18.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem89, Me.barItem90, Me.barItem99, Me.barItem100, Me.barItem93, Me.barItem94, Me.barItem91, Me.barItem92, Me.barItem97, Me.barItem98, Me.barItem95, Me.barItem96})
            Me.parentBarItem18.SeparatorIndices.AddRange(New Integer() {4, 6, 8, 10})
            Me.parentBarItem18.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem18.Text = "NavigationMenu"
            '
            'barItem89
            '
            Me.barItem89.CategoryIndex = 1
            Me.barItem89.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem89.ID = "Move Up"
            Me.barItem89.ImageIndex = 64
            Me.barItem89.Text = "Move Up"
            '
            'barItem90
            '
            Me.barItem90.CategoryIndex = 1
            Me.barItem90.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem90.ID = "Move Down"
            Me.barItem90.ImageIndex = 65
            Me.barItem90.Text = "Move Down"
            '
            'barItem99
            '
            Me.barItem99.CategoryIndex = 1
            Me.barItem99.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem99.ID = "Move to Line Start"
            Me.barItem99.Text = "Move to Line Start"
            '
            'barItem100
            '
            Me.barItem100.CategoryIndex = 1
            Me.barItem100.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem100.ID = "Move to Line End"
            Me.barItem100.Text = "Move to Line End"
            '
            'barItem93
            '
            Me.barItem93.CategoryIndex = 1
            Me.barItem93.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem93.ID = "Page Up"
            Me.barItem93.ImageIndex = 66
            Me.barItem93.Text = "Page Up"
            '
            'barItem94
            '
            Me.barItem94.CategoryIndex = 1
            Me.barItem94.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem94.ID = "Page Down"
            Me.barItem94.ImageIndex = 67
            Me.barItem94.Text = "Page Down"
            '
            'barItem91
            '
            Me.barItem91.CategoryIndex = 1
            Me.barItem91.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem91.ID = "Move Left"
            Me.barItem91.ImageIndex = 63
            Me.barItem91.Text = "Move Left"
            '
            'barItem92
            '
            Me.barItem92.CategoryIndex = 1
            Me.barItem92.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem92.ID = "Move Right"
            Me.barItem92.ImageIndex = 62
            Me.barItem92.Text = "Move Right"
            '
            'barItem97
            '
            Me.barItem97.CategoryIndex = 1
            Me.barItem97.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem97.ID = "Move Left One Word"
            Me.barItem97.Text = "Move Left One Word"
            '
            'barItem98
            '
            Me.barItem98.CategoryIndex = 1
            Me.barItem98.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem98.ID = "Move Right One Word"
            Me.barItem98.Text = "Move Right One Word"
            '
            'barItem95
            '
            Me.barItem95.CategoryIndex = 1
            Me.barItem95.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem95.ID = "Move to Start"
            Me.barItem95.Text = "Move to Start"
            '
            'barItem96
            '
            Me.barItem96.CategoryIndex = 1
            Me.barItem96.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem96.ID = "Move to End"
            Me.barItem96.Text = "Move to End"
            '
            'barItem112
            '
            Me.barItem112.CategoryIndex = 1
            Me.barItem112.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem112.ID = "Bind Keys"
            Me.barItem112.ImageIndex = 58
            Me.barItem112.Text = "Bind Keys"
            Me.barItem112.Tooltip = "Keyboard Binding"
            '
            'barItem75
            '
            Me.barItem75.CategoryIndex = 1
            Me.barItem75.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem75.ID = "SetLineBackColor"
            Me.barItem75.ImageIndex = 59
            Me.barItem75.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem75.Text = "LineBackColor"
            Me.barItem75.Tooltip = "Set Line Color"
            '
            'barItem86
            '
            Me.barItem86.CategoryIndex = 1
            Me.barItem86.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem86.ID = "Set Underlines"
            Me.barItem86.ImageIndex = 60
            Me.barItem86.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem86.Text = "Underlines"
            Me.barItem86.Tooltip = "Underlines"
            '
            'parentBarItem17
            '
            Me.parentBarItem17.CategoryIndex = 1
            Me.parentBarItem17.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem17.ID = "Editor BackColor"
            Me.parentBarItem17.ImageIndex = 61
            Me.parentBarItem17.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem87, Me.barItem88})
            Me.parentBarItem17.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem17.Text = "Editor BackColor"
            Me.parentBarItem17.Tooltip = "Editor BackColor"
            '
            'barItem87
            '
            Me.barItem87.CategoryIndex = 1
            Me.barItem87.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem87.ID = "GradientBackGround"
            Me.barItem87.ImageIndex = 68
            Me.barItem87.Text = "GradientBackGround"
            '
            'barItem88
            '
            Me.barItem88.CategoryIndex = 1
            Me.barItem88.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem88.ID = "Regular_1"
            Me.barItem88.ImageIndex = 30
            Me.barItem88.Text = "Regular"
            '
            'parentBarItem14
            '
            Me.parentBarItem14.CategoryIndex = 1
            Me.parentBarItem14.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem14.ID = "Modify Text"
            Me.parentBarItem14.ImageIndex = 24
            Me.parentBarItem14.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem77, Me.barItem78, Me.barItem79, Me.barItem115})
            Me.parentBarItem14.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem14.Text = "Modify Text"
            Me.parentBarItem14.Tooltip = "Modify Text"
            '
            'barItem77
            '
            Me.barItem77.CategoryIndex = 1
            Me.barItem77.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem77.ID = "SetText"
            Me.barItem77.Text = "SetText"
            '
            'barItem78
            '
            Me.barItem78.CategoryIndex = 1
            Me.barItem78.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem78.ID = "AppendText"
            Me.barItem78.Text = "AppendText"
            '
            'barItem79
            '
            Me.barItem79.CategoryIndex = 1
            Me.barItem79.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem79.ID = "InsertText"
            Me.barItem79.Text = "InsertText"
            '
            'barItem115
            '
            Me.barItem115.CategoryIndex = 1
            Me.barItem115.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem115.ID = "Insert XML Tag"
            Me.barItem115.Text = "Insert XML Tag"
            '
            'parentBarItem23
            '
            Me.parentBarItem23.CategoryIndex = 1
            Me.parentBarItem23.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem23.ID = "IndentationGuidelines"
            Me.parentBarItem23.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem114, Me.barItem113})
            Me.parentBarItem23.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem23.Text = "IndentationGuidelines"
            '
            'barItem114
            '
            Me.barItem114.CategoryIndex = 1
            Me.barItem114.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem114.ID = "MoveToBeginingOfBlock"
            Me.barItem114.Text = "MoveToBeginingOfBlock"
            '
            'barItem113
            '
            Me.barItem113.CategoryIndex = 1
            Me.barItem113.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem113.ID = "MoveToEndOfBlock"
            Me.barItem113.Text = "MoveToEndOfBlock"
            '
            'parentBarItem19
            '
            Me.parentBarItem19.CategoryIndex = 1
            Me.parentBarItem19.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem19.ID = "Selection Margin"
            Me.parentBarItem19.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem22, Me.parentBarItem21, Me.parentBarItem20})
            Me.parentBarItem19.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem19.Text = "Selection Margin"
            '
            'parentBarItem22
            '
            Me.parentBarItem22.CategoryIndex = 1
            Me.parentBarItem22.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem22.ID = "BackGroundColor"
            Me.parentBarItem22.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem109, Me.barItem110, Me.barItem111})
            Me.parentBarItem22.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.parentBarItem22.Text = "BackGroundColor"
            '
            'barItem109
            '
            Me.barItem109.CategoryIndex = 1
            Me.barItem109.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem109.ID = "LightBlue"
            Me.barItem109.Text = "LightBlue"
            '
            'barItem110
            '
            Me.barItem110.CategoryIndex = 1
            Me.barItem110.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem110.ID = "IndianRed"
            Me.barItem110.Text = "IndianRed"
            '
            'barItem111
            '
            Me.barItem111.CategoryIndex = 1
            Me.barItem111.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem111.ID = "Beige"
            Me.barItem111.Text = "Beige"
            '
            'parentBarItem21
            '
            Me.parentBarItem21.CategoryIndex = 1
            Me.parentBarItem21.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem21.ID = "ForeGroundColor"
            Me.parentBarItem21.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem106, Me.barItem107, Me.barItem108})
            Me.parentBarItem21.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.parentBarItem21.Text = "ForeGroundColor"
            '
            'barItem106
            '
            Me.barItem106.CategoryIndex = 1
            Me.barItem106.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem106.ID = "Gray"
            Me.barItem106.Text = "Gray"
            '
            'barItem107
            '
            Me.barItem107.CategoryIndex = 1
            Me.barItem107.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem107.ID = "Maroon"
            Me.barItem107.Text = "Maroon"
            '
            'barItem108
            '
            Me.barItem108.CategoryIndex = 1
            Me.barItem108.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem108.ID = "Navy"
            Me.barItem108.Text = "Navy"
            '
            'parentBarItem20
            '
            Me.parentBarItem20.CategoryIndex = 1
            Me.parentBarItem20.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem20.ID = "Width"
            Me.parentBarItem20.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem101, Me.barItem102, Me.barItem103, Me.barItem104, Me.barItem105})
            Me.parentBarItem20.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.parentBarItem20.Text = "Width"
            '
            'barItem101
            '
            Me.barItem101.CategoryIndex = 1
            Me.barItem101.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem101.ID = "25"
            Me.barItem101.Text = "25"
            '
            'barItem102
            '
            Me.barItem102.CategoryIndex = 1
            Me.barItem102.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem102.ID = "50"
            Me.barItem102.Text = "50"
            '
            'barItem103
            '
            Me.barItem103.CategoryIndex = 1
            Me.barItem103.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem103.ID = "75"
            Me.barItem103.Text = "75"
            '
            'barItem104
            '
            Me.barItem104.CategoryIndex = 1
            Me.barItem104.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem104.ID = "100"
            Me.barItem104.Text = "100"
            '
            'barItem105
            '
            Me.barItem105.CategoryIndex = 1
            Me.barItem105.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem105.ID = "125"
            Me.barItem105.Text = "125"
            '
            'barItem123
            '
            Me.barItem123.CategoryIndex = 1
            Me.barItem123.Checked = True
            Me.barItem123.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem123.ID = "SelectFullLine On LineNumberClick"
            Me.barItem123.Text = "SelectFullLine On LineNumberClick"
            '
            'barItem124
            '
            Me.barItem124.CategoryIndex = 1
            Me.barItem124.Checked = True
            Me.barItem124.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem124.ID = "ExtendMultilineSelectionToFarRight"
            Me.barItem124.Text = "ExtendMultilineSelectionToFarRight"
            '
            'parentBarItem15
            '
            Me.parentBarItem15.CategoryIndex = 1
            Me.parentBarItem15.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem15.ID = "Action Grouping"
            Me.parentBarItem15.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem80, Me.barItem81, Me.barItem82})
            Me.parentBarItem15.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem15.Text = "Action Grouping"
            '
            'barItem80
            '
            Me.barItem80.CategoryIndex = 1
            Me.barItem80.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem80.ID = "Open Group"
            Me.barItem80.Text = "Open Group"
            '
            'barItem81
            '
            Me.barItem81.CategoryIndex = 1
            Me.barItem81.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem81.ID = "Close Group"
            Me.barItem81.Text = "Close Group"
            '
            'barItem82
            '
            Me.barItem82.CategoryIndex = 1
            Me.barItem82.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem82.ID = "Cancel Group"
            Me.barItem82.Text = "Cancel Group"
            '
            'barItem83
            '
            Me.barItem83.CategoryIndex = 1
            Me.barItem83.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem83.ID = "Reset Undo Info"
            Me.barItem83.Text = "Reset Undo Info"
            '
            'barItem44
            '
            Me.barItem44.CategoryIndex = 1
            Me.barItem44.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem44.ID = "WordWrap"
            Me.barItem44.Text = "WordWrap"
            '
            'barItem45
            '
            Me.barItem45.CategoryIndex = 1
            Me.barItem45.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem45.ID = "Show&WhiteSpace"
            Me.barItem45.Text = "Show&WhiteSpace"
            '
            'barItem46
            '
            Me.barItem46.CategoryIndex = 1
            Me.barItem46.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem46.ID = "Show User &Margin"
            Me.barItem46.Text = "Show User &Margin"
            '
            'barItem47
            '
            Me.barItem47.CategoryIndex = 1
            Me.barItem47.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem47.ID = "Show Markers Area"
            Me.barItem47.Text = "Show Markers Area"
            '
            'barItem38
            '
            Me.barItem38.CategoryIndex = 1
            Me.barItem38.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem38.ID = "Outdent Selection"
            Me.barItem38.ImageIndex = 41
            Me.barItem38.Text = "Outdent Selection"
            '
            'barItem37
            '
            Me.barItem37.CategoryIndex = 1
            Me.barItem37.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem37.ID = "Indent Selection"
            Me.barItem37.ImageIndex = 40
            Me.barItem37.Text = "Indent Selection"
            '
            'parentBarItem8
            '
            Me.parentBarItem8.CategoryIndex = 1
            Me.parentBarItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem8.ID = "Indent Menu"
            Me.parentBarItem8.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem39, Me.barItem40, Me.barItem41})
            Me.parentBarItem8.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem8.Text = "Indent Menu"
            '
            'barItem39
            '
            Me.barItem39.CategoryIndex = 1
            Me.barItem39.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem39.ID = "None"
            Me.barItem39.Text = "None"
            '
            'barItem40
            '
            Me.barItem40.CategoryIndex = 1
            Me.barItem40.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem40.ID = "Block"
            Me.barItem40.Text = "Block"
            '
            'barItem41
            '
            Me.barItem41.CategoryIndex = 1
            Me.barItem41.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem41.ID = "Smart"
            Me.barItem41.Text = "Smart"
            '
            'parentBarItem9
            '
            Me.parentBarItem9.CategoryIndex = 1
            Me.parentBarItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem9.ID = "ReadOnly"
            Me.parentBarItem9.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem42, Me.barItem43})
            Me.parentBarItem9.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem9.Text = "ReadOnly"
            '
            'barItem42
            '
            Me.barItem42.CategoryIndex = 1
            Me.barItem42.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem42.ID = "MarkAsReadOnly"
            Me.barItem42.Text = "MarkAsReadOnly"
            '
            'barItem43
            '
            Me.barItem43.CategoryIndex = 1
            Me.barItem43.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem43.ID = "RemoveReadOnly"
            Me.barItem43.Text = "RemoveReadOnly"
            '
            'barItem118
            '
            Me.barItem118.CategoryIndex = 5
            Me.barItem118.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem118.ID = "Properties "
            Me.barItem118.Text = "Properties "
            '
            'parentBarItem25
            '
            Me.parentBarItem25.CategoryIndex = 4
            Me.parentBarItem25.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem25.ID = "Help_2"
            Me.parentBarItem25.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem117, Me.barItem122})
            Me.parentBarItem25.Text = "Help"
            '
            'barItem117
            '
            Me.barItem117.CategoryIndex = 4
            Me.barItem117.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem117.ID = "Help_1"
            Me.barItem117.Text = "Help Edit"
            '
            'barItem122
            '
            Me.barItem122.CategoryIndex = 4
            Me.barItem122.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem122.ID = "About"
            Me.barItem122.Text = "About"
            '
            'bar2
            '
            Me.bar2.BarName = "Standered"
            Me.bar2.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar2.Caption = "Standered"
            Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1, Me.barItem2, Me.barItem3, Me.parentBarItem1, Me.barItem5, Me.barItem12, Me.barItem13, Me.barItem14, Me.barItem10, Me.barItem11, Me.barItem22, Me.barItem31, Me.barItem26, Me.barItem25, Me.barItem75, Me.barItem86, Me.barItem84, Me.parentBarItem17, Me.parentBarItem14, Me.barItem112, Me.barItem37, Me.barItem38})
            Me.bar2.Manager = Me.mainFrameBarManager1
            Me.bar2.SeparatorIndices.AddRange(New Integer() {0, 3, 5, 8, 10, 14, 18})
            '
            'barItem22
            '
            Me.barItem22.CategoryIndex = 1
            Me.barItem22.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem22.ID = "Toggle BookMark"
            Me.barItem22.ImageIndex = 8
            Me.barItem22.Text = "Toggle BookMark"
            Me.barItem22.Tooltip = "Toggle BookMark"
            '
            'barItem31
            '
            Me.barItem31.CategoryIndex = 1
            Me.barItem31.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem31.ID = "Clear All bookMarks"
            Me.barItem31.ImageIndex = 11
            Me.barItem31.Text = "Clear All BookMarks"
            Me.barItem31.Tooltip = "Clear BookMarks"
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "NewDocumentHS.png")
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
            Me.imageList1.Images.SetKeyName(12, "")
            Me.imageList1.Images.SetKeyName(13, "")
            Me.imageList1.Images.SetKeyName(14, "")
            Me.imageList1.Images.SetKeyName(15, "")
            Me.imageList1.Images.SetKeyName(16, "")
            Me.imageList1.Images.SetKeyName(17, "")
            Me.imageList1.Images.SetKeyName(18, "")
            Me.imageList1.Images.SetKeyName(19, "")
            Me.imageList1.Images.SetKeyName(20, "")
            Me.imageList1.Images.SetKeyName(21, "")
            Me.imageList1.Images.SetKeyName(22, "")
            Me.imageList1.Images.SetKeyName(23, "")
            Me.imageList1.Images.SetKeyName(24, "")
            Me.imageList1.Images.SetKeyName(25, "")
            Me.imageList1.Images.SetKeyName(26, "")
            Me.imageList1.Images.SetKeyName(27, "")
            Me.imageList1.Images.SetKeyName(28, "")
            Me.imageList1.Images.SetKeyName(29, "")
            Me.imageList1.Images.SetKeyName(30, "")
            Me.imageList1.Images.SetKeyName(31, "")
            Me.imageList1.Images.SetKeyName(32, "")
            Me.imageList1.Images.SetKeyName(33, "")
            Me.imageList1.Images.SetKeyName(34, "")
            Me.imageList1.Images.SetKeyName(35, "")
            Me.imageList1.Images.SetKeyName(36, "")
            Me.imageList1.Images.SetKeyName(37, "")
            Me.imageList1.Images.SetKeyName(38, "")
            Me.imageList1.Images.SetKeyName(39, "")
            Me.imageList1.Images.SetKeyName(40, "")
            Me.imageList1.Images.SetKeyName(41, "")
            Me.imageList1.Images.SetKeyName(42, "")
            Me.imageList1.Images.SetKeyName(43, "openfolderHS.png")
            Me.imageList1.Images.SetKeyName(44, "saveHS.png")
            Me.imageList1.Images.SetKeyName(45, "Edit_UndoHS.png")
            Me.imageList1.Images.SetKeyName(46, "Edit_RedoHS.png")
            Me.imageList1.Images.SetKeyName(47, "CutHS.png")
            Me.imageList1.Images.SetKeyName(48, "CopyHS.png")
            Me.imageList1.Images.SetKeyName(49, "PasteHS.png")
            Me.imageList1.Images.SetKeyName(50, "PrintHS.png")
            Me.imageList1.Images.SetKeyName(51, "DeleteHS.png")
            Me.imageList1.Images.SetKeyName(52, "PrintPreviewHS.png")
            Me.imageList1.Images.SetKeyName(53, "SaveAllHS.png")
            Me.imageList1.Images.SetKeyName(54, "FindHS.png")
            Me.imageList1.Images.SetKeyName(55, "border3.gif")
            Me.imageList1.Images.SetKeyName(56, "window2.gif")
            Me.imageList1.Images.SetKeyName(57, "wib25e1.gif")
            Me.imageList1.Images.SetKeyName(58, "key.gif")
            Me.imageList1.Images.SetKeyName(59, "LineColorHS.png")
            Me.imageList1.Images.SetKeyName(60, "underl1.gif")
            Me.imageList1.Images.SetKeyName(61, "backgr1.gif")
            Me.imageList1.Images.SetKeyName(62, "DataContainer_MoveNextHS.png")
            Me.imageList1.Images.SetKeyName(63, "DataContainer_MovePreviousHS.png")
            Me.imageList1.Images.SetKeyName(64, "GoToPreviousMessage.png")
            Me.imageList1.Images.SetKeyName(65, "GoToNextMessage.png")
            Me.imageList1.Images.SetKeyName(66, "FillUpHS.png")
            Me.imageList1.Images.SetKeyName(67, "FillDownHS.png")
            Me.imageList1.Images.SetKeyName(68, "EditBrightContrastHS.png")
            Me.imageList1.Images.SetKeyName(69, "Color_font.png")
            Me.imageList1.Images.SetKeyName(70, "BreakpointHS.png")
            Me.imageList1.Images.SetKeyName(71, "Flag_redHS.png")
            Me.imageList1.Images.SetKeyName(72, "RadialChartHS.png")
            Me.imageList1.Images.SetKeyName(73, "Book_angleHS.png")
            '
            'barItem76
            '
            Me.barItem76.CategoryIndex = 1
            Me.barItem76.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem76.ID = "Single Line Mode"
            Me.barItem76.ImageIndex = 23
            Me.barItem76.Text = "Single Line Mode"
            Me.barItem76.Tooltip = "Single Line Mode"
            '
            'barItem85
            '
            Me.barItem85.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem85.ID = "_2"
            '
            'barItem51
            '
            Me.barItem51.CategoryIndex = 0
            Me.barItem51.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem51.ID = "Autoformatting"
            Me.barItem51.ImageIndex = 42
            Me.barItem51.Text = "Autoformatting"
            '
            'popupMenu1
            '
            Me.popupMenu1.ParentBarItem = Me.parentBarItem3
            '
            'popupMenusManager1
            '
            Me.popupMenusManager1.ParentForm = Me
            '
            'editControl1
            '
            Me.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart
            Me.editControl1.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.editControl1.Configurator = Config1
            Me.editControl1.ContextMenuEnabled = False
            Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.editControl1.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.editControl1.Location = New System.Drawing.Point(432, 0)
            Me.editControl1.Name = "editControl1"
            Me.editControl1.ScrollPosition = New System.Drawing.Point(155, 0)
            Me.editControl1.Size = New System.Drawing.Size(80, 498)
            Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
            Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
            Me.editControl1.StatusBarSettings.Visible = True
            Me.editControl1.TabIndex = 4
            Me.editControl1.Text = "editControl1"
            Me.editControl1.TransferFocusOnTab = True
            Me.editControl1.VisualColumn = 13
            Me.popupMenusManager1.SetXPContextMenu(Me.editControl1, Me.popupMenu1)
            '
            'parentBarItem16
            '
            Me.parentBarItem16.ID = "_1"
            Me.parentBarItem16.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem85})
            '
            'button4
            '
            Me.button4.Location = New System.Drawing.Point(24, 440)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(144, 32)
            Me.button4.TabIndex = 10
            Me.button4.Text = "Remove UnderLine"
            '
            'button3
            '
            Me.button3.Location = New System.Drawing.Point(24, 392)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(144, 32)
            Me.button3.TabIndex = 9
            Me.button3.Text = "UnderLine Selection"
            '
            'radioButton16
            '
            Me.radioButton16.BackColor = System.Drawing.SystemColors.Control
            Me.radioButton16.Location = New System.Drawing.Point(24, 120)
            Me.radioButton16.Name = "radioButton16"
            Me.radioButton16.Size = New System.Drawing.Size(104, 24)
            Me.radioButton16.TabIndex = 4
            Me.radioButton16.Text = "Dash"
            Me.radioButton16.UseVisualStyleBackColor = False
            '
            'radioButton15
            '
            Me.radioButton15.BackColor = System.Drawing.SystemColors.Control
            Me.radioButton15.Location = New System.Drawing.Point(24, 96)
            Me.radioButton15.Name = "radioButton15"
            Me.radioButton15.Size = New System.Drawing.Size(104, 24)
            Me.radioButton15.TabIndex = 3
            Me.radioButton15.Text = "Dot"
            Me.radioButton15.UseVisualStyleBackColor = False
            '
            'radioButton14
            '
            Me.radioButton14.BackColor = System.Drawing.SystemColors.Control
            Me.radioButton14.Location = New System.Drawing.Point(24, 72)
            Me.radioButton14.Name = "radioButton14"
            Me.radioButton14.Size = New System.Drawing.Size(104, 24)
            Me.radioButton14.TabIndex = 2
            Me.radioButton14.Text = "Wave"
            Me.radioButton14.UseVisualStyleBackColor = False
            '
            'radioButton13
            '
            Me.radioButton13.BackColor = System.Drawing.SystemColors.Control
            Me.radioButton13.Location = New System.Drawing.Point(24, 48)
            Me.radioButton13.Name = "radioButton13"
            Me.radioButton13.Size = New System.Drawing.Size(104, 24)
            Me.radioButton13.TabIndex = 1
            Me.radioButton13.Text = "DashDot"
            Me.radioButton13.UseVisualStyleBackColor = False
            '
            'radioButton12
            '
            Me.radioButton12.BackColor = System.Drawing.SystemColors.Control
            Me.radioButton12.Location = New System.Drawing.Point(24, 24)
            Me.radioButton12.Name = "radioButton12"
            Me.radioButton12.Size = New System.Drawing.Size(104, 24)
            Me.radioButton12.TabIndex = 0
            Me.radioButton12.Text = "Solid"
            Me.radioButton12.UseVisualStyleBackColor = False
            '
            'groupBox4
            '
            Me.groupBox4.BackColor = System.Drawing.SystemColors.Control
            Me.groupBox4.Location = New System.Drawing.Point(8, 200)
            Me.groupBox4.Name = "groupBox4"
            Me.groupBox4.Size = New System.Drawing.Size(192, 176)
            Me.groupBox4.TabIndex = 6
            Me.groupBox4.TabStop = False
            '
            'radioButton9
            '
            Me.radioButton9.BackColor = System.Drawing.SystemColors.Control
            Me.radioButton9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.radioButton9.Location = New System.Drawing.Point(24, 24)
            Me.radioButton9.Name = "radioButton9"
            Me.radioButton9.Size = New System.Drawing.Size(144, 24)
            Me.radioButton9.TabIndex = 2
            Me.radioButton9.Text = "Red"
            Me.radioButton9.UseVisualStyleBackColor = False
            '
            'radioButton10
            '
            Me.radioButton10.BackColor = System.Drawing.SystemColors.Control
            Me.radioButton10.ForeColor = System.Drawing.Color.Navy
            Me.radioButton10.Location = New System.Drawing.Point(24, 48)
            Me.radioButton10.Name = "radioButton10"
            Me.radioButton10.Size = New System.Drawing.Size(144, 24)
            Me.radioButton10.TabIndex = 3
            Me.radioButton10.Text = "Blue"
            Me.radioButton10.UseVisualStyleBackColor = False
            '
            'radioButton11
            '
            Me.radioButton11.BackColor = System.Drawing.SystemColors.Control
            Me.radioButton11.ForeColor = System.Drawing.Color.Green
            Me.radioButton11.Location = New System.Drawing.Point(24, 72)
            Me.radioButton11.Name = "radioButton11"
            Me.radioButton11.Size = New System.Drawing.Size(144, 24)
            Me.radioButton11.TabIndex = 4
            Me.radioButton11.Text = "Green"
            Me.radioButton11.UseVisualStyleBackColor = False
            '
            'groupBox3
            '
            Me.groupBox3.BackColor = System.Drawing.SystemColors.Control
            Me.groupBox3.Location = New System.Drawing.Point(8, 80)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(192, 112)
            Me.groupBox3.TabIndex = 5
            Me.groupBox3.TabStop = False
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.checkBox2.Location = New System.Drawing.Point(8, 55)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(60, 17)
            Me.checkBox2.TabIndex = 1
            Me.checkBox2.Text = "Double"
            Me.checkBox2.UseVisualStyleBackColor = False
            '
            'label3
            '
            Me.label3.BackColor = System.Drawing.SystemColors.Control
            Me.label3.Location = New System.Drawing.Point(14, 16)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(192, 23)
            Me.label3.TabIndex = 0
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'button2
            '
            Me.button2.BackColor = System.Drawing.SystemColors.Control
            Me.button2.Location = New System.Drawing.Point(25, 440)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(144, 32)
            Me.button2.TabIndex = 16
            Me.button2.Text = "Set Selection BackColor"
            Me.button2.UseVisualStyleBackColor = False
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.SystemColors.Control
            Me.button1.Location = New System.Drawing.Point(25, 392)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(144, 32)
            Me.button1.TabIndex = 15
            Me.button1.Text = "Set Line BackColor"
            Me.button1.UseVisualStyleBackColor = False
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.SystemColors.Control
            Me.label2.Location = New System.Drawing.Point(8, 16)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(192, 23)
            Me.label2.TabIndex = 14
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.SystemColors.Control
            Me.label1.Location = New System.Drawing.Point(16, 48)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(176, 16)
            Me.label1.TabIndex = 11
            '
            'radioButton5
            '
            Me.radioButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(111, Byte), Integer))
            Me.radioButton5.Location = New System.Drawing.Point(8, 24)
            Me.radioButton5.Name = "radioButton5"
            Me.radioButton5.Size = New System.Drawing.Size(160, 24)
            Me.radioButton5.TabIndex = 4
            Me.radioButton5.Text = "Orange"
            Me.radioButton5.UseVisualStyleBackColor = False
            '
            'radioButton6
            '
            Me.radioButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.radioButton6.Location = New System.Drawing.Point(8, 48)
            Me.radioButton6.Name = "radioButton6"
            Me.radioButton6.Size = New System.Drawing.Size(160, 24)
            Me.radioButton6.TabIndex = 5
            Me.radioButton6.Text = "LightBlue"
            Me.radioButton6.UseVisualStyleBackColor = False
            '
            'radioButton7
            '
            Me.radioButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.radioButton7.Location = New System.Drawing.Point(8, 72)
            Me.radioButton7.Name = "radioButton7"
            Me.radioButton7.Size = New System.Drawing.Size(160, 24)
            Me.radioButton7.TabIndex = 6
            Me.radioButton7.Text = "LightOliveGreen"
            Me.radioButton7.UseVisualStyleBackColor = False
            '
            'radioButton8
            '
            Me.radioButton8.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.radioButton8.Location = New System.Drawing.Point(8, 96)
            Me.radioButton8.Name = "radioButton8"
            Me.radioButton8.Size = New System.Drawing.Size(160, 24)
            Me.radioButton8.TabIndex = 7
            Me.radioButton8.Text = "none"
            Me.radioButton8.UseVisualStyleBackColor = False
            '
            'groupBox2
            '
            Me.groupBox2.BackColor = System.Drawing.SystemColors.Control
            Me.groupBox2.Location = New System.Drawing.Point(8, 240)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(192, 136)
            Me.groupBox2.TabIndex = 9
            Me.groupBox2.TabStop = False
            '
            'radioButton4
            '
            Me.radioButton4.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.radioButton4.Location = New System.Drawing.Point(8, 96)
            Me.radioButton4.Name = "radioButton4"
            Me.radioButton4.Size = New System.Drawing.Size(160, 24)
            Me.radioButton4.TabIndex = 3
            Me.radioButton4.Text = "none"
            Me.radioButton4.UseVisualStyleBackColor = False
            '
            'radioButton2
            '
            Me.radioButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.radioButton2.Location = New System.Drawing.Point(8, 48)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(160, 24)
            Me.radioButton2.TabIndex = 1
            Me.radioButton2.Text = "SteelBlue"
            Me.radioButton2.UseVisualStyleBackColor = False
            '
            'radioButton3
            '
            Me.radioButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.radioButton3.Location = New System.Drawing.Point(8, 72)
            Me.radioButton3.Name = "radioButton3"
            Me.radioButton3.Size = New System.Drawing.Size(160, 24)
            Me.radioButton3.TabIndex = 2
            Me.radioButton3.Text = "DarkGray"
            Me.radioButton3.UseVisualStyleBackColor = False
            '
            'radioButton1
            '
            Me.radioButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(27, Byte), Integer))
            Me.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.radioButton1.Location = New System.Drawing.Point(8, 24)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(160, 24)
            Me.radioButton1.TabIndex = 0
            Me.radioButton1.Text = "Crimson"
            Me.radioButton1.UseVisualStyleBackColor = False
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.SystemColors.Control
            Me.groupBox1.Location = New System.Drawing.Point(8, 96)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(192, 144)
            Me.groupBox1.TabIndex = 8
            Me.groupBox1.TabStop = False
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.panel3.Controls.Add(Me.gradientPanel2)
            Me.panel3.Controls.Add(Me.button7)
            Me.panel3.Controls.Add(Me.button8)
            Me.panel3.Controls.Add(Me.groupBox7)
            Me.panel3.Controls.Add(Me.groupBox8)
            Me.panel3.Controls.Add(Me.checkBox2)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel3.Location = New System.Drawing.Point(216, 0)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(216, 498)
            Me.panel3.TabIndex = 32
            Me.panel3.Visible = False
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel2.Controls.Add(Me.label6)
            Me.gradientPanel2.Location = New System.Drawing.Point(8, 16)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(192, 26)
            Me.gradientPanel2.TabIndex = 18
            '
            'label6
            '
            Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.label6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.Location = New System.Drawing.Point(0, 0)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(190, 24)
            Me.label6.TabIndex = 0
            Me.label6.Text = "Set Underlines"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'button7
            '
            Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button7.Location = New System.Drawing.Point(24, 440)
            Me.button7.Name = "button7"
            Me.button7.Size = New System.Drawing.Size(136, 27)
            Me.button7.TabIndex = 10
            Me.button7.Text = "Remove UnderLine"
            '
            'button8
            '
            Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button8.Location = New System.Drawing.Point(24, 392)
            Me.button8.Name = "button8"
            Me.button8.Size = New System.Drawing.Size(136, 27)
            Me.button8.TabIndex = 9
            Me.button8.Text = "UnderLine Selection"
            '
            'groupBox7
            '
            Me.groupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.groupBox7.Controls.Add(Me.radioButton25)
            Me.groupBox7.Controls.Add(Me.radioButton26)
            Me.groupBox7.Controls.Add(Me.radioButton27)
            Me.groupBox7.Controls.Add(Me.radioButton28)
            Me.groupBox7.Controls.Add(Me.radioButton29)
            Me.groupBox7.Location = New System.Drawing.Point(8, 200)
            Me.groupBox7.Name = "groupBox7"
            Me.groupBox7.Size = New System.Drawing.Size(192, 149)
            Me.groupBox7.TabIndex = 6
            Me.groupBox7.TabStop = False
            Me.groupBox7.Text = "Style"
            '
            'radioButton25
            '
            Me.radioButton25.AutoSize = True
            Me.radioButton25.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.radioButton25.Location = New System.Drawing.Point(24, 120)
            Me.radioButton25.Name = "radioButton25"
            Me.radioButton25.Size = New System.Drawing.Size(50, 17)
            Me.radioButton25.TabIndex = 4
            Me.radioButton25.Text = "Dash"
            Me.radioButton25.UseVisualStyleBackColor = False
            '
            'radioButton26
            '
            Me.radioButton26.AutoSize = True
            Me.radioButton26.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.radioButton26.Location = New System.Drawing.Point(24, 96)
            Me.radioButton26.Name = "radioButton26"
            Me.radioButton26.Size = New System.Drawing.Size(42, 17)
            Me.radioButton26.TabIndex = 3
            Me.radioButton26.Text = "Dot"
            Me.radioButton26.UseVisualStyleBackColor = False
            '
            'radioButton27
            '
            Me.radioButton27.AutoSize = True
            Me.radioButton27.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.radioButton27.Location = New System.Drawing.Point(24, 72)
            Me.radioButton27.Name = "radioButton27"
            Me.radioButton27.Size = New System.Drawing.Size(54, 17)
            Me.radioButton27.TabIndex = 2
            Me.radioButton27.Text = "Wave"
            Me.radioButton27.UseVisualStyleBackColor = False
            '
            'radioButton28
            '
            Me.radioButton28.AutoSize = True
            Me.radioButton28.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.radioButton28.Location = New System.Drawing.Point(24, 48)
            Me.radioButton28.Name = "radioButton28"
            Me.radioButton28.Size = New System.Drawing.Size(67, 17)
            Me.radioButton28.TabIndex = 1
            Me.radioButton28.Text = "DashDot"
            Me.radioButton28.UseVisualStyleBackColor = False
            '
            'radioButton29
            '
            Me.radioButton29.AutoSize = True
            Me.radioButton29.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.radioButton29.Checked = True
            Me.radioButton29.Location = New System.Drawing.Point(24, 24)
            Me.radioButton29.Name = "radioButton29"
            Me.radioButton29.Size = New System.Drawing.Size(48, 17)
            Me.radioButton29.TabIndex = 0
            Me.radioButton29.TabStop = True
            Me.radioButton29.Text = "Solid"
            Me.radioButton29.UseVisualStyleBackColor = False
            '
            'groupBox8
            '
            Me.groupBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.groupBox8.Controls.Add(Me.radioButton30)
            Me.groupBox8.Controls.Add(Me.radioButton31)
            Me.groupBox8.Controls.Add(Me.radioButton32)
            Me.groupBox8.Location = New System.Drawing.Point(8, 80)
            Me.groupBox8.Name = "groupBox8"
            Me.groupBox8.Size = New System.Drawing.Size(192, 112)
            Me.groupBox8.TabIndex = 5
            Me.groupBox8.TabStop = False
            Me.groupBox8.Text = "Color"
            '
            'radioButton30
            '
            Me.radioButton30.AutoSize = True
            Me.radioButton30.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.radioButton30.Checked = True
            Me.radioButton30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.radioButton30.Location = New System.Drawing.Point(24, 24)
            Me.radioButton30.Name = "radioButton30"
            Me.radioButton30.Size = New System.Drawing.Size(45, 17)
            Me.radioButton30.TabIndex = 2
            Me.radioButton30.TabStop = True
            Me.radioButton30.Text = "Red"
            Me.radioButton30.UseVisualStyleBackColor = False
            '
            'radioButton31
            '
            Me.radioButton31.AutoSize = True
            Me.radioButton31.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.radioButton31.ForeColor = System.Drawing.Color.Navy
            Me.radioButton31.Location = New System.Drawing.Point(24, 48)
            Me.radioButton31.Name = "radioButton31"
            Me.radioButton31.Size = New System.Drawing.Size(46, 17)
            Me.radioButton31.TabIndex = 3
            Me.radioButton31.Text = "Blue"
            Me.radioButton31.UseVisualStyleBackColor = False
            '
            'radioButton32
            '
            Me.radioButton32.AutoSize = True
            Me.radioButton32.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.radioButton32.ForeColor = System.Drawing.Color.Green
            Me.radioButton32.Location = New System.Drawing.Point(24, 72)
            Me.radioButton32.Name = "radioButton32"
            Me.radioButton32.Size = New System.Drawing.Size(54, 17)
            Me.radioButton32.TabIndex = 4
            Me.radioButton32.Text = "Green"
            Me.radioButton32.UseVisualStyleBackColor = False
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.panel2.Controls.Add(Me.gradientPanel1)
            Me.panel2.Controls.Add(Me.button5)
            Me.panel2.Controls.Add(Me.button6)
            Me.panel2.Controls.Add(Me.label5)
            Me.panel2.Controls.Add(Me.comboBox2)
            Me.panel2.Controls.Add(Me.groupBox5)
            Me.panel2.Controls.Add(Me.groupBox6)
            Me.panel2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(216, 498)
            Me.panel2.TabIndex = 7
            Me.panel2.Visible = False
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.label4)
            Me.gradientPanel1.Location = New System.Drawing.Point(12, 16)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(188, 22)
            Me.gradientPanel1.TabIndex = 17
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.label4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(0, 0)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(186, 20)
            Me.label4.TabIndex = 14
            Me.label4.Text = "Set Line Colors"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'button5
            '
            Me.button5.BackColor = System.Drawing.SystemColors.Control
            Me.button5.Location = New System.Drawing.Point(25, 440)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(136, 27)
            Me.button5.TabIndex = 16
            Me.button5.Text = "Set Selection BackColor"
            Me.button5.UseVisualStyleBackColor = True
            '
            'button6
            '
            Me.button6.BackColor = System.Drawing.SystemColors.Control
            Me.button6.Location = New System.Drawing.Point(25, 392)
            Me.button6.Name = "button6"
            Me.button6.Size = New System.Drawing.Size(136, 27)
            Me.button6.TabIndex = 15
            Me.button6.Text = "Set Line BackColor"
            Me.button6.UseVisualStyleBackColor = True
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(7, 48)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(176, 16)
            Me.label5.TabIndex = 11
            Me.label5.Text = "HashStyle:"
            '
            'comboBox2
            '
            Me.comboBox2.ItemHeight = 13
            Me.comboBox2.Location = New System.Drawing.Point(8, 72)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(192, 21)
            Me.comboBox2.TabIndex = 10
            '
            'groupBox5
            '
            Me.groupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.groupBox5.Controls.Add(Me.radioButton17)
            Me.groupBox5.Controls.Add(Me.radioButton18)
            Me.groupBox5.Controls.Add(Me.radioButton19)
            Me.groupBox5.Controls.Add(Me.radioButton20)
            Me.groupBox5.Location = New System.Drawing.Point(8, 240)
            Me.groupBox5.Name = "groupBox5"
            Me.groupBox5.Size = New System.Drawing.Size(192, 136)
            Me.groupBox5.TabIndex = 9
            Me.groupBox5.TabStop = False
            Me.groupBox5.Text = "Select background"
            '
            'radioButton17
            '
            Me.radioButton17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(111, Byte), Integer))
            Me.radioButton17.Location = New System.Drawing.Point(8, 24)
            Me.radioButton17.Name = "radioButton17"
            Me.radioButton17.Size = New System.Drawing.Size(160, 24)
            Me.radioButton17.TabIndex = 4
            Me.radioButton17.Text = "Orange"
            Me.radioButton17.UseVisualStyleBackColor = False
            '
            'radioButton18
            '
            Me.radioButton18.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.radioButton18.Checked = True
            Me.radioButton18.Location = New System.Drawing.Point(8, 48)
            Me.radioButton18.Name = "radioButton18"
            Me.radioButton18.Size = New System.Drawing.Size(160, 24)
            Me.radioButton18.TabIndex = 5
            Me.radioButton18.TabStop = True
            Me.radioButton18.Text = "LightBlue"
            Me.radioButton18.UseVisualStyleBackColor = False
            '
            'radioButton19
            '
            Me.radioButton19.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.radioButton19.Location = New System.Drawing.Point(8, 72)
            Me.radioButton19.Name = "radioButton19"
            Me.radioButton19.Size = New System.Drawing.Size(160, 24)
            Me.radioButton19.TabIndex = 6
            Me.radioButton19.Text = "LightOliveGreen"
            Me.radioButton19.UseVisualStyleBackColor = False
            '
            'radioButton20
            '
            Me.radioButton20.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.radioButton20.Location = New System.Drawing.Point(8, 96)
            Me.radioButton20.Name = "radioButton20"
            Me.radioButton20.Size = New System.Drawing.Size(160, 24)
            Me.radioButton20.TabIndex = 7
            Me.radioButton20.Text = "none"
            Me.radioButton20.UseVisualStyleBackColor = False
            '
            'groupBox6
            '
            Me.groupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.groupBox6.Controls.Add(Me.radioButton21)
            Me.groupBox6.Controls.Add(Me.radioButton22)
            Me.groupBox6.Controls.Add(Me.radioButton23)
            Me.groupBox6.Controls.Add(Me.radioButton24)
            Me.groupBox6.Location = New System.Drawing.Point(8, 96)
            Me.groupBox6.Name = "groupBox6"
            Me.groupBox6.Size = New System.Drawing.Size(192, 144)
            Me.groupBox6.TabIndex = 8
            Me.groupBox6.TabStop = False
            Me.groupBox6.Text = "Select Color"
            '
            'radioButton21
            '
            Me.radioButton21.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.radioButton21.Location = New System.Drawing.Point(8, 96)
            Me.radioButton21.Name = "radioButton21"
            Me.radioButton21.Size = New System.Drawing.Size(160, 24)
            Me.radioButton21.TabIndex = 3
            Me.radioButton21.Text = "none"
            Me.radioButton21.UseVisualStyleBackColor = False
            '
            'radioButton22
            '
            Me.radioButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.radioButton22.Location = New System.Drawing.Point(8, 48)
            Me.radioButton22.Name = "radioButton22"
            Me.radioButton22.Size = New System.Drawing.Size(160, 24)
            Me.radioButton22.TabIndex = 1
            Me.radioButton22.Text = "SteelBlue"
            Me.radioButton22.UseVisualStyleBackColor = False
            '
            'radioButton23
            '
            Me.radioButton23.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
            Me.radioButton23.ForeColor = System.Drawing.Color.White
            Me.radioButton23.Location = New System.Drawing.Point(8, 72)
            Me.radioButton23.Name = "radioButton23"
            Me.radioButton23.Size = New System.Drawing.Size(160, 24)
            Me.radioButton23.TabIndex = 2
            Me.radioButton23.Text = "DarkGray"
            Me.radioButton23.UseVisualStyleBackColor = False
            '
            'radioButton24
            '
            Me.radioButton24.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(27, Byte), Integer))
            Me.radioButton24.Checked = True
            Me.radioButton24.ForeColor = System.Drawing.Color.White
            Me.radioButton24.Location = New System.Drawing.Point(8, 24)
            Me.radioButton24.Name = "radioButton24"
            Me.radioButton24.Size = New System.Drawing.Size(160, 24)
            Me.radioButton24.TabIndex = 0
            Me.radioButton24.TabStop = True
            Me.radioButton24.Text = "Crimson"
            Me.radioButton24.UseVisualStyleBackColor = False
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.editControl1)
            Me.panel1.Controls.Add(Me.propertyEditor)
            Me.panel1.Controls.Add(Me.panel3)
            Me.panel1.Controls.Add(Me.panel2)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 52)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(744, 498)
            Me.panel1.TabIndex = 6
            '
            'propertyEditor
            '
            Me.propertyEditor.BackColor = System.Drawing.SystemColors.Control
            Me.propertyEditor.Dock = System.Windows.Forms.DockStyle.Right
            Me.propertyEditor.LineColor = System.Drawing.SystemColors.Control
            Me.propertyEditor.Location = New System.Drawing.Point(512, 0)
            Me.propertyEditor.Name = "propertyEditor"
            Me.propertyEditor.SelectedObject = Me.editControl1
            Me.propertyEditor.Size = New System.Drawing.Size(232, 498)
            Me.propertyEditor.TabIndex = 35
            Me.propertyEditor.Visible = False
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList2.Images.SetKeyName(0, "function_locked.png")
            Me.imageList2.Images.SetKeyName(1, "function_unlocked.png")
            Me.imageList2.Images.SetKeyName(2, "property_protected.png")
            Me.imageList2.Images.SetKeyName(3, "property_public.png")
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(744, 550)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Custom Code Editor"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.groupBox7.ResumeLayout(False)
            Me.groupBox7.PerformLayout()
            Me.groupBox8.ResumeLayout(False)
            Me.groupBox8.PerformLayout()
            Me.panel2.ResumeLayout(False)
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.groupBox5.ResumeLayout(False)
            Me.groupBox6.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			form1_Renamed = New Form1()
Application.EnableVisualStyles()
			Application.Run(form1_Renamed)
		End Sub

		#Region "MenuClicks"

		Private Sub FileMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem1.Click, barItem2.Click, barItem3.Click, barItem4.Click, barItem52.Click, barItem53.Click, barItem54.Click, barItem120.Click, barItem20.Click
			Dim bi As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			Select Case bi.Text
				Case "&New"
					Me.editControl1.NewFile()
				Case "&Open"
					Me.editControl1.LoadFile()
					Me.editControl1.StatusBarSettings.TextPanel.Panel.Text = Me.editControl1.FileName
				Case "&Save"
					Me.editControl1.Save()
				Case "Save &As"
					Me.editControl1.SaveAs()
				Case "Save As &RTF"

					saveFileDialog.Filter = "RitchTextDocuments (*.rtf)|*.rtf"
                    If saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.editControl1.SaveAsRTF(saveFileDialog.FileName)
                    End If
				Case "Save As &XML"
					saveFileDialog.Filter = "XML Documents (*.xml)|*.xml"
                    If saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.editControl1.SaveAsXML(saveFileDialog.FileName)
                    End If
				Case "Save As &HTML"
					saveFileDialog.Filter = "HTML Documents (*.html)|*.html"
                    If saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.editControl1.SaveAsHTML(saveFileDialog.FileName)
                    End If
				Case "C&lose"
					Me.editControl1.Close()
				Case "E&xit"
					Me.Close()
			End Select
		End Sub


		Private Sub WindowMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem23.Click, barItem24.Click, barItem32.Click
			Dim bi As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)

			Select Case bi.Text
				Case "Split Horizontally"
					Me.editControl1.SplitHorizontally()
				Case "Split Vertically"
					Me.editControl1.SplitVertically()
				Case "Split Into Quadrants"
					Me.editControl1.SplitFourQuadrants()
			End Select
		End Sub


		Private Sub PrintingMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem121.Click, barItem5.Click, barItem6.Click, barItem9.Click, barItem8.Click, barItem7.Click
			Dim bi As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)

			Select Case bi.Text
				Case "&Print"
					Me.editControl1.PrintNoDialog()
				Case "Print Preview"
					Me.editControl1.PrintPreview()
				Case "Print Dialog"
					Me.editControl1.Print()
				Case "Print To File"
					Dim printdoc As PrintDocument = Me.editControl1.PrintDocument
					printdoc.Print()
				Case "Print Current Page"
					Me.editControl1.PrintCurrentPage()
				Case "Print Selected Text"
					Me.editControl1.PrintSelection()
			End Select
		End Sub


		Private Sub LanguageMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem55.Click, barItem56.Click, barItem57.Click, barItem61.Click, barItem119.Click, barItem58.Click, barItem59.Click, barItem60.Click, barItem116.Click, barItem84.Click
			Dim bi As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)

			Select Case bi.Text
				Case "CSharp"
					Me.editControl1.LoadFile(BasePath & "\CSharpSource.cs")
					Me.editControl1.ApplyConfiguration(KnownLanguages.CSharp)
				Case "XML"
					Me.editControl1.LoadFile(BasePath & "\XMLSource.xml")
					Me.editControl1.ApplyConfiguration(KnownLanguages.XML)
				Case "VB.NET"
					Me.editControl1.LoadFile(BasePath & "\VBSource.vb")
					Me.editControl1.ApplyConfiguration(KnownLanguages.VBNET)
				Case "SQL"
					Me.editControl1.LoadFile(BasePath & "\SQLSource.sql")
					Me.editControl1.ApplyConfiguration(KnownLanguages.SQL)
				Case "Pascal"
				 
					Me.editControl1.LoadFile(BasePath & "..\..\..\..\..\..\..\..\Common\Data\DelphiSource.pas" )
					Me.editControl1.ApplyConfiguration(KnownLanguages.Delphi)
				Case "HTML"
					Me.editControl1.LoadFile(BasePath & "\HTMLSource.html")
					Me.editControl1.ApplyConfiguration(KnownLanguages.HTML)
				Case "Java"
					Me.editControl1.LoadFile(BasePath & "\JavaSource.Java")
					Me.editControl1.ApplyConfiguration(KnownLanguages.Java)
				Case "JScript"
					Me.editControl1.LoadFile(BasePath & "\JScriptSource.js")
					Me.editControl1.ApplyConfiguration(KnownLanguages.JScript)
				Case "VBScript"
					Me.editControl1.LoadFile(BasePath & "\VBScriptSource.vbs")
					Me.editControl1.ApplyConfiguration(KnownLanguages.VBScript)
				Case "Configuration Editor"
					Try
						Dim activeLang As IConfigLanguage = CType(IIf(TypeOf Me.editControl1.Parser.Formats Is IConfigLanguage, Me.editControl1.Parser.Formats, Nothing), IConfigLanguage)

						Dim editConfig As ConfigurationDialog = New ConfigurationDialog(Me.editControl1.Configurator, activeLang)

                        If editConfig.ShowDialog(Me) = Windows.Forms.DialogResult.OK AndAlso Not activeLang Is Nothing Then
                            Dim newLang As IConfigLanguage
                            If editConfig.Configurator.KnownLanguageNames.Contains(activeLang.Language) Then
                                newLang = editConfig.Configurator(activeLang.Language)
                            Else
                                newLang = editConfig.Configurator.DefaultLanguage
                            End If

                            If Not newLang Is Nothing Then
                                Me.editControl1.Configurator = editConfig.Configurator
                                'this.editControl1.ResetColoring( newLang );
                                Me.editControl1.ApplyConfiguration(newLang)
                            End If
                        End If
					Catch e1 As ArgumentException
					End Try
				Case "Default Language"
					Me.editControl1.ApplyConfiguration(KnownLanguages.Text)
			End Select
		End Sub


		Private Sub EditMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem10.Click, barItem11.Click, barItem12.Click, barItem13.Click, barItem14.Click, barItem16.Click, barItem15.Click, barItem48.Click, barItem49.Click, barItem50.Click, barItem17.Click, barItem18.Click, barItem19.Click, barItem27.Click, barItem28.Click, barItem29.Click, barItem30.Click, barItem21.Click, barItem33.Click, barItem34.Click, barItem25.Click, barItem26.Click, barItem35.Click, barItem36.Click, barItem22.Click, barItem31.Click
			Dim bi As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)

			Select Case bi.Text
				Case "&Undo"
					Me.editControl1.Undo()
				Case "&Redo"
					Me.editControl1.Redo()
				Case "Cu&t"
					Me.editControl1.Cut()
				Case "&Copy"
					Me.editControl1.Copy()
				Case "&Paste"
					Me.editControl1.Paste()
				Case "Select &All"
					Me.editControl1.SelectAll()
				Case "Delete"
					If Not editControl1.Selection Is Nothing Then
						Me.editControl1.DeleteText(Me.editControl1.Selection.Top, Me.editControl1.Selection.Bottom)
					Else
						MessageBox.Show("Please select the text to be deleted")
					End If
				Case "Delete All"
					Me.editControl1.DeleteAll()
				Case "CollapseAll"
					Me.editControl1.CollapseAll()
				Case "ExpandAll"
					Me.editControl1.ExpandAll()
				Case "Show Collapsers"
					barItem50.Checked = Not barItem50.Checked
					Me.editControl1.ShowOutliningCollapsers = barItem50.Checked
				Case "Find"
					Me.editControl1.ShowFindDialog()
				Case "Replace"
					Me.editControl1.ShowReplaceDialog()
				Case "GoTo"
					Me.editControl1.ShowGoToDialog()
				Case "Insert CustomBookMark"
					Me.InsertCustomBookMark()
				Case "&Next BookMark"
					Me.editControl1.BookmarkNext()
				Case "&Previous BookMark"
					Me.editControl1.BookmarkPrevious()
				Case "Toggle BookMark"
					Me.editControl1.BookmarkToggle()
				Case "Clear All BookMarks"
					Me.editControl1.BookmarkClear()
					Dim i As Integer = 0
'ORIGINAL LINE: for (int i = 0 ; i < arr.Count ; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
					Do While i < arr.Count
						Dim line As Integer = CInt(arr(i))
                        Me.editControl1.RemoveCustomBookmark(line, AddressOf CustomBookmarkPainter1)
                        Me.editControl1.RemoveCustomBookmark(line, AddressOf CustomBookmarkPainter2)
                        Me.editControl1.RemoveCustomBookmark(line, AddressOf CustomBookmarkPainter3)
                        Me.editControl1.RemoveCustomBookmark(line, AddressOf CustomBookmarkPainter4)

                        Me.editControl1.RemoveCustomBookmark(line, AddressOf CustomBookmarkPainter1)
                        Me.editControl1.RemoveCustomBookmark(line, AddressOf CustomBookmarkPainter2)
                        Me.editControl1.RemoveCustomBookmark(line, AddressOf CustomBookmarkPainter3)
                        Me.editControl1.RemoveCustomBookmark(line, AddressOf CustomBookmarkPainter4)
						i += 1
					Loop
				Case "Add BookMark"
					Me.editControl1.BookmarkAdd(Me.editControl1.CurrentLine)
				Case "Remove BookMark"
					Me.editControl1.BookmarkToggle()
				Case "Image1"
					Me.selectedImage = image1
				Case "Image2"
					Me.selectedImage = image2
				Case "Image3"
					Me.selectedImage = image3
				Case "Image4"
					Me.selectedImage = image4
				Case Else
					MessageBox.Show("Handler does not exist")
			End Select
		End Sub

		#Region "BookMarks Helper Methods"
		Private Sub InsertCustomBookMark()
			If Me.selectedImage Is image1 Then
                Me.editControl1.SetCustomBookmark(Me.editControl1.CurrentLine, AddressOf CustomBookmarkPainter1)
                Dim customBookmark1 As ICustomBookmark = Me.editControl1.SetCustomBookmark(Me.editControl1.CurrentLine, AddressOf CustomBookmarkPainter1)
				customBookmark1.UseInBookmarkSearch = True
				arr.Add(Me.editControl1.CurrentLine)
			Else If Me.selectedImage Is image2 Then
                Me.editControl1.SetCustomBookmark(Me.editControl1.CurrentLine, AddressOf CustomBookmarkPainter2)
                Dim customBookmark2 As ICustomBookmark = Me.editControl1.SetCustomBookmark(Me.editControl1.CurrentLine, AddressOf CustomBookmarkPainter2)
				customBookmark2.UseInBookmarkSearch = True
				arr.Add(Me.editControl1.CurrentLine)
			Else If Me.selectedImage Is image3 Then
                Me.editControl1.SetCustomBookmark(Me.editControl1.CurrentLine, AddressOf CustomBookmarkPainter3)
                Dim customBookmark3 As ICustomBookmark = Me.editControl1.SetCustomBookmark(Me.editControl1.CurrentLine, AddressOf CustomBookmarkPainter3)
				customBookmark3.UseInBookmarkSearch = True
				arr.Add(Me.editControl1.CurrentLine)
			Else If Me.selectedImage Is image4 Then
                Me.editControl1.SetCustomBookmark(Me.editControl1.CurrentLine, AddressOf CustomBookmarkPainter4)
                Dim customBookmark4 As ICustomBookmark = Me.editControl1.SetCustomBookmark(Me.editControl1.CurrentLine, AddressOf CustomBookmarkPainter4)
				customBookmark4.UseInBookmarkSearch = True
				arr.Add(Me.editControl1.CurrentLine)
			End If
		End Sub

		Private Sub CustomBookmarkPainter1(ByVal sender As Object, ByVal args As BookmarkPaintEventArgs)
			args.Graphics.DrawImage(image1, args.ClipRectangle.Left, args.ClipRectangle.Top, 16, 16)
		End Sub

		Private Sub CustomBookmarkPainter2(ByVal sender As Object, ByVal args As BookmarkPaintEventArgs)
			args.Graphics.DrawImage(image2, args.ClipRectangle.Left, args.ClipRectangle.Top, 16, 16)
		End Sub

		Private Sub CustomBookmarkPainter3(ByVal sender As Object, ByVal args As BookmarkPaintEventArgs)
			args.Graphics.DrawImage(image3, args.ClipRectangle.Left, args.ClipRectangle.Top, 16, 16)
		End Sub

		Private Sub CustomBookmarkPainter4(ByVal sender As Object, ByVal args As BookmarkPaintEventArgs)
			args.Graphics.DrawImage(image4, args.ClipRectangle.Left, args.ClipRectangle.Top, 16, 16)
		End Sub
		#End Region

		Private Sub PropertiesMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem118.Click
			Me.propertyEditor.Visible = Not Me.propertyEditor.Visible
		End Sub


		Private Sub HelpMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem117.Click
			Process.Start("http://www.syncfusion.com/products/edit/windows/default.aspx")
		End Sub

		#End Region        

		#Region "EditControl Events"

		Private Sub editControl1_CursorPositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles editControl1.CursorPositionChanged
			'this.PositionPanel.Text = "Ln  " + this.editControl1.CurrentLine + "  Col "+this.editControl1.CurrentColumn +"  Pos  "+this.editControl1.CurrentPosition;
		End Sub


		Private Sub editControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles editControl1.MouseMove
			Me.editControl1.Cursor = Me.currentCursor
		End Sub

		Private Sub LineColor(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.panel3.Visible = False

			If (Not Me.panel1.Visible) Then
				Me.panel1.Visible = True
				'	this.editControl1.Width = 710;
			Else
				Me.panel1.Visible = False
				'	this.editControl1.Width = 912;
			End If

		End Sub

		#End Region

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.editControl1.Text = "panel active"
		End Sub

		Private Function RegisterFormat() As IBackgroundFormat
			Dim background As Color = Color.Empty, foreground As Color = Color.Empty

			If radioButton22.Checked Then
				foreground = radioButton22.BackColor
			Else If radioButton23.Checked Then
				foreground = radioButton23.BackColor
			Else If radioButton24.Checked Then
				foreground = radioButton24.BackColor
			Else If radioButton21.Checked Then
				foreground = Color.Empty
			End If

			If radioButton17.Checked Then
				background = radioButton17.BackColor
			Else If radioButton18.Checked Then
				background = radioButton18.BackColor
			Else If radioButton19.Checked Then
				background = radioButton19.BackColor
			Else If radioButton20.Checked Then
                background = Color.White
			End If

			Dim bUseHatchFille As Boolean = comboBox2.SelectedIndex > 0
			Dim style As HatchStyle
			If (bUseHatchFille) Then
				style = CType(System.Enum.Parse(GetType(HatchStyle), comboBox2.SelectedItem.ToString()), HatchStyle)
			Else
				style = HatchStyle.Min
			End If

			Dim format As IBackgroundFormat = editControl1.RegisterBackColorFormat(background, foreground, style, bUseHatchFille)
			Return format
		End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			comboBox2.Items.Clear()

			comboBox2.Items.Add("Solid")

			For Each name As String In System.Enum.GetNames(GetType(HatchStyle))
				comboBox2.Items.Add(name)
			Next name

			comboBox2.SelectedText = "Percent05"
			comboBox2.SelectedIndex = 0
		End Sub



		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)

			Dim format As IBackgroundFormat = RegisterFormat()
			editControl1.SetSelectionBackColor(format)
		End Sub




		Private Sub editControl1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles editControl1.TextChanged
			Me.barItem10.Enabled = True
			Me.barItem11.Enabled = True
		End Sub




		Private ReadOnly Property SelectedColor() As Color
			Get
				If radioButton30.Checked Then
					Return radioButton9.ForeColor
				End If

				If radioButton31.Checked Then
					Return radioButton10.ForeColor
				End If

				If radioButton32.Checked Then
					Return radioButton11.ForeColor
				End If

				Return Color.Black
			End Get
		End Property

		Private ReadOnly Property SelectedStyle() As UnderlineStyle
			Get
				If radioButton29.Checked Then
					Return UnderlineStyle.Solid
				End If

				If radioButton28.Checked Then
					Return UnderlineStyle.DashDot
				End If

				If radioButton27.Checked Then
					Return UnderlineStyle.Wave
				End If

				If radioButton26.Checked Then
					Return UnderlineStyle.Dot
				End If

				If radioButton25.Checked Then
					Return UnderlineStyle.Dash
				End If

				Return UnderlineStyle.Solid
			End Get
		End Property

		Private ReadOnly Property SelectedWeight() As UnderlineWeight
			Get
				If checkBox2.Checked Then
					Return UnderlineWeight.Double
				End If

				Return UnderlineWeight.Bold
			End Get
		End Property

		Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs)

		End Sub

		Private Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs)


		End Sub

        Private Sub editControl1_UpdateContextToolTip(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Edit.UpdateTooltipEventArgs) Handles editControl1.UpdateContextToolTip
            If e.Text = String.Empty Then
                Dim pointVirtual As Point = editControl1.PointToVirtualPosition(New Point(e.X, e.Y))

                If pointVirtual.Y > 0 Then
                    ' Get the current line
                    Dim line As ILexemLine = editControl1.GetLine(pointVirtual.Y)

                    If Not line Is Nothing Then
                        ' Get tokens from the current line
                        Dim lexem As ILexem = line.FindLexemByColumn(pointVirtual.X)

                        If Not lexem Is Nothing Then
                            e.Text = lexem.Text
                        End If
                    End If
                End If
            End If

        End Sub

	Private Sub moveMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem90.Click, barItem99.Click, barItem100.Click, barItem93.Click, barItem94.Click, barItem91.Click, barItem92.Click, barItem97.Click, barItem98.Click, barItem95.Click, barItem96.Click
			'MenuItem item = sender as MenuItem;
			Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
			Select Case item.Text
				Case "Move Up" 
					Me.editControl1.MoveUp()
				Case "Move Down" 
					Me.editControl1.MoveDown()
				Case "Move Left" 
					Me.editControl1.MoveLeft()
				Case "Move Right" 
					Me.editControl1.MoveRight()
				Case "Move to Start" 
					Me.editControl1.MoveToBeginning()
				Case "Move to End" 
					Me.editControl1.MoveToEnd()
				Case "Page Up" 
					Me.editControl1.MovePageUp()
				Case "Page Down" 
					Me.editControl1.MovePageDown()
				Case "Move Left One Word" 
					Me.editControl1.MoveLeftWord()
				Case "Move Right One Word" 
					Me.editControl1.MoveRightWord()
				Case "Move to Line Start" 
					Me.editControl1.MoveToLineStart()
				Case "Move to Line End" 
					Me.editControl1.MoveToLineEnd()
				Case Else 
					MessageBox.Show("Handler does not exist")
			End Select
	End Sub

		Private Sub Width_menuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem101.Click, barItem102.Click, barItem103.Click, barItem104.Click, barItem105.Click
			Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
			Select Case item.Text
				Case"25"
					Me.editControl1.SelectionMarginWidth = 25
				Case"50"
					Me.editControl1.SelectionMarginWidth = 50
				Case"75"
					Me.editControl1.SelectionMarginWidth = 75
				Case"100"
					Me.editControl1.SelectionMarginWidth = 100
				Case"125"
					Me.editControl1.SelectionMarginWidth = 125
				Case Else 
					MessageBox.Show("Handler does not exist")
			End Select
		End Sub

		Private Sub BackgroundColor_menuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem109.Click, barItem110.Click, barItem111.Click
			Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
			Select Case item.Text
				Case "LightBlue"
					Me.editControl1.SelectionMarginBackgroundColor = Color.LightBlue

				Case "IndianRed"
					Me.editControl1.SelectionMarginBackgroundColor = Color.IndianRed
				Case "Beige"
					Me.editControl1.SelectionMarginBackgroundColor = Color.Beige
				Case Else 
					MessageBox.Show("Handler does not exist")

			End Select
		End Sub

		Private Sub ForegroundColor_menuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem106.Click, barItem107.Click, barItem108.Click
			Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
			Select Case item.Text
				Case"Gray"
					Me.editControl1.SelectionMarginForegroundColor = Color.Gray
				Case"Maroon"
					Me.editControl1.SelectionMarginForegroundColor = Color.Maroon
				Case "Navy"
					Me.editControl1.SelectionMarginForegroundColor = Color.Navy
				Case Else 
					MessageBox.Show("Handler does not exist")
			End Select
		End Sub


		Private Sub CustomCursorMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem62.Click, barItem63.Click, barItem64.Click, barItem65.Click, barItem66.Click, barItem67.Click, barItem68.Click, barItem69.Click, barItem70.Click, barItem71.Click, barItem72.Click, barItem73.Click, barItem74.Click
			Dim bi As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)

			Select Case bi.Text
				Case "AppStarting" 
					Me.currentCursor=Cursors.AppStarting
				Case "Arrow" 
					Me.currentCursor =Cursors.Arrow
				Case "Cross" 
					Me.currentCursor=Cursors.Cross
				Case "Default" 
					Me.currentCursor=Cursors.Default
				Case "Hand" 
					Me.currentCursor=Cursors.Hand
				Case "Help" 
					Me.currentCursor=Cursors.Help
				Case "HSplit" 
					Me.currentCursor=Cursors.HSplit
				Case "IBeam" 
					Me.currentCursor=Cursors.IBeam
				Case "No" 
					Me.currentCursor=Cursors.No
				Case "SizeAll" 
					Me.currentCursor=Cursors.SizeAll
				Case "UpArrow" 
					Me.currentCursor=Cursors.UpArrow
				Case "VSplit" 
					Me.currentCursor=Cursors.VSplit
				Case "WaitCursor" 
					Me.currentCursor=Cursors.WaitCursor
				Case Else 
					MessageBox.Show("Handler does not exist")
			End Select
		End Sub

		Private Sub NavigationMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem89.Click
			Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)

				Select Case item.Text
					Case "Move Up" 
						Me.editControl1.MoveUp()
					Case "Move Down" 
						Me.editControl1.MoveDown()
					Case "Move Left" 
						Me.editControl1.MoveLeft()
					Case "Move Right" 
						Me.editControl1.MoveRight()
					Case "Move to Start" 
						Me.editControl1.MoveToBeginning()
					Case "Move to End" 
						Me.editControl1.MoveToEnd()
					Case "Page Up" 
						Me.editControl1.MovePageUp()
					Case "Page Down" 
						Me.editControl1.MovePageDown()
					Case "Move Left One Word" 
						Me.editControl1.MoveLeftWord()
					Case "Move Right One Word" 
						Me.editControl1.MoveRightWord()
					Case "Move to Line Start" 
						Me.editControl1.MoveToLineStart()
					Case "Move to Line End" 
						Me.editControl1.MoveToLineEnd()
					Case Else 
						MessageBox.Show("Handler does not exist")
				End Select
		End Sub

		Private Sub AdvancedMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem112.Click, barItem75.Click, barItem86.Click, barItem87.Click, barItem88.Click, barItem77.Click, barItem78.Click, barItem79.Click, barItem115.Click, barItem114.Click, barItem113.Click, barItem83.Click, barItem44.Click, barItem45.Click, barItem46.Click, barItem47.Click, barItem38.Click, barItem37.Click, barItem76.Click
			Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
			Select Case item.Text
				Case "Bind Keys"
					Me.editControl1.ShowKeysBindingEditor()
				Case "LineBackColor"
					barItem75.Checked = Not barItem75.Checked
					Me.panel2.Visible = barItem75.Checked
					Me.panel3.Visible = False
					barItem86.Checked = False
				Case "Underlines"
					barItem86.Checked = Not barItem86.Checked
					Me.panel3.Visible = barItem86.Checked
					Me.panel2.Visible = False
					barItem75.Checked = False
				Case "GradientBackGround"
					Me.editControl1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Beige, System.Drawing.Color.LightBlue)
				Case "Regular"
					Me.editControl1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
				Case "SetText"
					Me.inputdialog.ShowDialog()

					If Me.accepted = True Then
						Me.editControl1.Text = Me.inputString
					End If
				Case "AppendText"
					Me.inputdialog.ShowDialog()

					If Me.accepted = True Then
						Me.editControl1.AppendText(Me.inputString)
					End If
				Case "InsertText"
					Me.inputdialog.ShowDialog()

					If Me.accepted = True Then
						Me.editControl1.InsertText(Me.editControl1.CurrentLine, Me.editControl1.CurrentColumn, Me.inputString)
					End If
				Case "Insert XML Tag"
					Me.inputdialog.ShowDialog()

					If Me.accepted = True Then
						If Me.inputString.Equals("") Then
							MessageBox.Show("The node name cannot be empty")
						Else
							Me.editControl1.InsertText(Me.editControl1.CurrentLine,Me.editControl1.CurrentColumn,"<" & Me.inputString & ">")
							Me.editControl1.InsertText(Me.editControl1.CurrentLine,(Me.editControl1.CurrentColumn)," ")
							Me.editControl1.InsertText(Me.editControl1.CurrentLine,Me.editControl1.CurrentColumn,"</" & Me.inputString & ">")
						End If
					End If
				Case "MoveToBeginingOfBlock"
					Me.editControl1.JumpToIndentBlockStart()
				Case "MoveToEndOfBlock"
					Me.editControl1.JumpToIndentBlockEnd()
				Case "Reset Undo Info"
					Me.editControl1.ResetUndoInfo()
				Case "WordWrap"
					Me.editControl1.WordWrap = Not Me.editControl1.WordWrap
				Case "Show&WhiteSpace"
					Me.editControl1.ShowWhitespaces = Not Me.editControl1.ShowWhitespaces
				Case "Show User &Margin"
					Me.editControl1.ShowUserMargin = Not Me.editControl1.ShowUserMargin
				Case "Show Markers Area"
					Me.editControl1.ShowMarkers = Not Me.editControl1.ShowMarkers
				Case "Single Line Mode"
					Dim h As Integer = Me.editControl1.Height
					If Me.editControl1.Dock<>DockStyle.Fill Then
						Me.editControl1.SingleLineMode = Not Me.editControl1.SingleLineMode
					End If
					Me.editControl1.Height = h
				Case "Indent Selection"
					Me.editControl1.IndentSelection()
				Case "Outdent Selection"
					Me.editControl1.OutdentSelection()
				Case Else 
					MessageBox.Show("Handler does not exist")
			End Select

		End Sub

		Private Sub ActionGroupingClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem80.Click, barItem81.Click, barItem82.Click
		   Dim item As BarItem=CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
			Select Case item.Text
				Case "Open Group"
					Me.editControl1.UndoGroupOpen()
				Case "Close Group"
					Me.editControl1.UndoGroupClose()
				Case "Cancel Group"
					Me.editControl1.UndoGroupCancel()
				Case Else 
					MessageBox.Show("Handler does not exist")


			End Select
		End Sub
		Private Sub IndentMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem39.Click, barItem40.Click, barItem41.Click
			Dim mi As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
			Select Case mi.Text
				Case "None" 
					Me.editControl1.AutoIndentMode = AutoIndentMode.None
				Case "Block" 
					Me.editControl1.AutoIndentMode = AutoIndentMode.Block
				Case "Smart" 
					Me.editControl1.AutoIndentMode = AutoIndentMode.Smart
				Case Else 
					MessageBox.Show("Handler does not exist")

			End Select
		End Sub

		Private Sub ReadOnlyMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem42.Click, barItem43.Click
			Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
			Select Case item.Text
				Case "MarkAsReadOnly"
					If Not editControl1.Selection Is Nothing Then
						Me.editControl1.MarkAsReadOnly(Me.editControl1.Selection.Start, Me.editControl1.Selection.End, Color.Orange, Color.Crimson)
					Else
						MessageBox.Show("Please select the text to be made read-only")
					End If
				Case "RemoveReadOnly"
					If Not editControl1.Selection Is Nothing Then
						Me.editControl1.RemoveReadOnly(Me.editControl1.Selection.Start, Me.editControl1.Selection.End)
					Else
					MessageBox.Show("Please select the text for which read-only has to be removed")
					End If
				Case Else 
					MessageBox.Show("Handler does not exist")
			End Select
		End Sub

		Private Sub barItem51_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem51.Click

		End Sub

		Private Sub button1_Click_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click, button6.Click
			Dim temp As IDynamicFormat() = editControl1.GetLineBackColorFormats(editControl1.CurrentLine)

			Dim format As IBackgroundFormat = RegisterFormat()
			editControl1.SetLineBackColor(editControl1.CurrentLine, True, format)
		End Sub

		Private Sub button2_Click_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click, button5.Click
			Dim format As IBackgroundFormat = RegisterFormat()
			editControl1.SetSelectionBackColor(format)

		End Sub

		Private Sub button3_Click_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click, button8.Click
			If Not editControl1.Selection Is Nothing Then
				Dim format As ISnippetFormat = editControl1.RegisterUnderlineFormat(SelectedColor, SelectedStyle, SelectedWeight)
				Me.editControl1.SetUnderline(editControl1.Selection.Top, editControl1.Selection.Bottom, format)
			End If
		End Sub

		Private Sub button4_Click_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles button4.Click, button7.Click
			If Not editControl1.Selection Is Nothing Then
				Me.editControl1.RemoveUnderline(Me.editControl1.Selection.Top, Me.editControl1.Selection.Bottom)
			End If
		End Sub

		Private Sub barItem122_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem122.Click
			Dim form As DemoCommon.AboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
			form.ShowDialog()
		End Sub

		Private Sub barItem123_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem123.Click

			Me.barItem123.Checked = Not Me.barItem123.Checked
			If Me.barItem123.Checked Then
				'Selects the whole line when clicked on line number
				Me.editControl1.SelectOnLineNumberClick = True
			Else
				Me.editControl1.SelectOnLineNumberClick = False
			End If

		End Sub

		Private Sub barItem124_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem124.Click
			Me.barItem124.Checked = Not Me.barItem124.Checked
			If Me.barItem124.Checked Then
			   Me.editControl1.ExtendSelectionToFarRight = True
			Else
				'Selects the text upto the end of the line alone similar to VS IDE.
			   Me.editControl1.ExtendSelectionToFarRight = False
			End If
		End Sub


		#Region "Context Choice Implementation"
		Private Sub editControl1_ContextChoiceBeforeOpen(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
			Dim lexemLine As ILexemLine = Me.editControl1.GetLine(Me.editControl1.CurrentLine)

			'Gets the index of the current word in that line
			Dim ind As Integer = GetContextChoiceCharIndex(lexemLine)
			If ind <= 0 Then
				e.Cancel = True
				Return
			End If
			Dim lex As ILexem = CType(IIf(TypeOf lexemLine.LineLexems(ind - 1) Is ILexem, lexemLine.LineLexems(ind - 1), Nothing), ILexem)

			' If the count is less than '2', do not show the ContextChoice popup
			If lexemLine.LineLexems.Count < 2 Then
				e.Cancel = True
			Else
				' Display ContextChoice popup if the lexem used to invoke them is "this" or "me" only
				If (lex.Text = "this") OrElse (lex.Text = "me") Then
					e.Cancel = False
				Else
					e.Cancel = True
				End If
			End If

		End Sub


		Private Function GetContextChoiceCharIndex(ByVal line As ILexemLine) As Integer
			Dim lastPos As Integer = -1

			Dim i As Integer = 0
'ORIGINAL LINE: for (int i = 0 ; i < line.LineLexems.Count ; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < line.LineLexems.Count
				Dim lex As ILexem = CType(IIf(TypeOf line.LineLexems(i) Is ILexem, line.LineLexems(i), Nothing), ILexem)

				If lex.Text = "." Then
					lastPos = i
				End If
				i += 1
			Loop

			Return lastPos
		End Function

		Private Sub editControl1_ContextChoiceOpen(ByVal controller As Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController)
			reader = New XmlTextReader(intellisensePath)
			Do While reader.Read()
				Dim itemname As String = "", tooltip As String = ""
				Select Case reader.NodeType
					Case (XmlNodeType.Element)

						If reader.Name = "Items" Then
							If reader.AttributeCount > 0 Then
								Do While reader.MoveToNextAttribute()
									If reader.Name = "Name" Then
										itemname = reader.Value
									End If
									If reader.Name = "Tooltip" Then
										tooltip = reader.Value
									End If
									If reader.Name = "Image" Then
										controller.Items.Add(itemname, tooltip, Me.editControl1.ContextChoiceController.Images(reader.Value))
									End If
								Loop
							End If
						End If


				End Select
			Loop

		End Sub

		Private Sub editControl1_ContextChoiceItemSelected(ByVal sender As Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController, ByVal e As Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventArgs)
			Console.WriteLine("SelectedItem : " & e.SelectedItem.Text)
		End Sub

		Private Sub editControl1_ContextChoiceClose(ByVal controller As Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController, ByVal dialogresult As System.Windows.Forms.DialogResult)
			controller.Items.Clear()
			reader.Close()
		End Sub
		#End Region

		#Region "Context Prompt Implementation"
		Private Function GetContextPromptCharIndex(ByVal line As ILexemLine) As Integer
			Dim lastPos As Integer = -1
			Dim i As Integer = 0
'ORIGINAL LINE: for (int i = 0 ; i < line.LineLexems.Count ; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < line.LineLexems.Count
				Dim lex As ILexem = CType(IIf(TypeOf line.LineLexems(i) Is ILexem, line.LineLexems(i), Nothing), ILexem)

				If lex.Text = "(" Then
					lastPos = i
				End If
				i += 1
			Loop

			Return lastPos
		End Function

		Private contextPromptLexem As String = ""
		' Method that populates the context prompt list based on the lexem invoking it
		Private Sub PopulateContextPromptItems(ByVal e As ContextPromptUpdateEventArgs)
			e.List.Clear()
			GetFunctionNames(e)

			'switch (this.contextPromptLexem)
			'{
			'    case "Chat" :
			'        e.List.Clear();
			'        GetFunctionNames(e);
			'        break;

			'    case "Database" :
			'        e.List.Clear();
			'        GetFunctionNames(e);
			'        break;
			'    case "NewFile" :
			'        e.List.Clear();
			'        GetFunctionNames(e);
			'        break;
			'    case "Find" :
			'        e.List.Clear();
			'        GetFunctionNames(e);
			'        break;
			'    case "Home" :
			'        e.List.Clear();
			'        GetFunctionNames(e);
			'        break;
			'    case "PieChart" :
			'        e.List.Clear();
			'        GetFunctionNames(e);
			'        break;
			'    case "Tools" :
			'        e.List.Clear();
			'        GetFunctionNames(e);
			'        break;
			'}
		End Sub

'TODO: INSTANT VB TODO TASK: function is a keyword in VB.NET. Change the name or use square brackets to override it:
		Private function_Renamed As String = ""
		Private Sub GetFunctionNames(ByVal e As ContextPromptUpdateEventArgs)
			reader = New XmlTextReader(intellisensePath)
			function_Renamed = ""
			Dim i As Integer = 1
			Do While reader.Read()
				function_Renamed = ""
				Select Case reader.NodeType
					Case (XmlNodeType.Element)

						If reader.Name = "Function" Then
							reader.MoveToFirstAttribute()
							If reader.Value = Me.contextPromptLexem Then
								Do While reader.MoveToNextAttribute()
									If reader.Name = "overloads" & i Then
										function_Renamed = reader.Value

									Else
										If reader.Name = "Description" & i Then

											e.AddPrompt(function_Renamed, reader.Value)
											i += 1
										End If
									End If

								Loop
							End If
						End If


				End Select
			Loop

		End Sub

		Private Sub editControl1_ContextPromptBeforeOpen(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
			Dim lexemLine As ILexemLine = Me.editControl1.GetLine(Me.editControl1.CurrentLine)

			'Gets the index of the current word in that line
			Dim ind As Integer = GetContextPromptCharIndex(lexemLine)
			If ind <= 0 Then
				e.Cancel = True
				Return
			End If
			Dim lex As ILexem = CType(IIf(TypeOf lexemLine.LineLexems(ind - 1) Is ILexem, lexemLine.LineLexems(ind - 1), Nothing), ILexem)

			' If the count is less than '2', do not show the ContextPrompt popup
			If lexemLine.LineLexems.Count < 2 Then
				e.Cancel = True
			Else
				' Display ContextChoice popup if the lexem used to invoke them is "this" or "me" only
				'if ( ( lex.Text == "Chat" ) || ( lex.Text == "Database" ) || ( lex.Text == "NewFile" ) || ( lex.Text == "Find" ) || ( lex.Text == "Home" ) || ( lex.Text == "PieChart" ) || ( lex.Text == "Tools" ) )
				If lex.Text <> "" Then
					Me.contextPromptLexem = lex.Text
					e.Cancel = False
				Else
					e.Cancel = True
				End If

			End If
		End Sub

		Private Sub editControl1_ContextPromptOpen(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs)
			If Me.contextPromptLexem <> "" Then
				PopulateContextPromptItems(e)
			End If
		End Sub
		#End Region


	End Class
End Namespace

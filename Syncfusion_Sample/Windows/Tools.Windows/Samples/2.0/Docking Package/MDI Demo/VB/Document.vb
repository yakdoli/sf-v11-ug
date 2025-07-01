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
	Imports System.ComponentModel
	Imports System.Drawing
	Imports System.Drawing.Text
	Imports System.Windows.Forms
	Imports System.Diagnostics
	Imports System.IO
	Imports Syncfusion.Windows.Forms.Tools.XPMenus
Namespace MDIDemo

	Public Class Document : Inherits Syncfusion.Windows.Forms.Office2007Form
		Protected richTextBox1 As System.Windows.Forms.RichTextBox

        Private Structure FontSizes
            Private n As Integer
            Public Shared Small As Single
            Public Shared Medium As Single
            Public Shared Large As Single

            Shared Sub New()
                FontSizes.Small = 8.0F
                FontSizes.Medium = 12.0F
                FontSizes.Large = 24.0F
            End Sub
        End Structure

		Private fontSize As Single = FontSizes.Medium

		Private currentFontFamily_ As FontFamily
		Private courierNewFontFamily As FontFamily
		Private sansSerifFontFamily As FontFamily
		Private arialFontFamily As FontFamily
		Private childFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager
		Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private fontFaceParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private fontSizeParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private timesNewRomanFontFamily As FontFamily

		Public Property CurrentFontFamily() As String
			Get
				If Me.currentFontFamily_ Is Me.sansSerifFontFamily Then
					Return "MS Sans Serif"
				Else If Me.currentFontFamily_ Is Me.timesNewRomanFontFamily Then
					Return "Times New Roman"
				Else If Me.currentFontFamily_ Is Me.courierNewFontFamily Then
					Return "Courier New"
				Else
					Return "Arial"
				End If
			End Get

			Set
				Dim fontfamily As FontFamily = Nothing
				Select Case Value
					Case "MS Sans Serif"
						fontfamily = Me.sansSerifFontFamily
					Case "Times New Roman"
						fontfamily = Me.timesNewRomanFontFamily
					Case "Courier New"
						fontfamily = Me.courierNewFontFamily
					Case "Arial"
						fontfamily = Me.arialFontFamily

				End Select
				If Not Me.currentFontFamily_ Is fontfamily Then
					Me.currentFontFamily_ = fontfamily
					Me.richTextBox1.Font = New Font(Me.currentFontFamily_, Me.fontSize)
				End If
			End Set
		End Property

		Public Property CurrentFontSize() As String
			Get
				If Me.fontSize = FontSizes.Small Then
					Return "Small"
				Else If Me.fontSize = FontSizes.Medium Then
					Return "Medium"
				End If
				Return "Large"
			End Get

			Set
'INSTANT VB NOTE: The local variable fontsize was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
				Dim fontsize_Renamed As Single = 0
				Select Case Value
					Case "Small"
						fontsize_Renamed = FontSizes.Small
					Case "Medium"
						fontsize_Renamed = FontSizes.Medium
					Case "Large"
						fontsize_Renamed = FontSizes.Large
				End Select

				If Me.fontSize <> fontsize_Renamed Then
					Me.fontSize = fontsize_Renamed
					Me.richTextBox1.Font = New Font(Me.currentFontFamily_, Me.fontSize)
				End If
			End Set
		End Property

		Public Sub New(ByVal docName As String)
			InitializeComponent()

			' Initialize fonts - use generic fonts to avoid problems across
			' different versions of the OS.
			courierNewFontFamily = New FontFamily(GenericFontFamilies.Monospace)
			sansSerifFontFamily = New FontFamily(GenericFontFamilies.SansSerif)
			timesNewRomanFontFamily = New FontFamily(GenericFontFamilies.Serif)
			arialFontFamily = New FontFamily("Arial")
			currentFontFamily_ = arialFontFamily

			Me.Text = docName

			richTextBox1.Font = New System.Drawing.Font(currentFontFamily_, fontSize)
			richTextBox1.Text = docName
			For Each i As BarItem In Me.childFrameBarManager1.Items
				i.CustomTextFont = New Font("Microsoft Sans Seriff", 8.25f)
			Next i
		End Sub

		#Region "Initialize Component"
		Private Sub InitializeComponent()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Document))
			Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
			Me.childFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(Me)
			Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childFrameBarManager1, "FormatMenu")
			Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.fontFaceParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.fontSizeParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			CType(Me.childFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' richTextBox1
			' 
			Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.Size = New System.Drawing.Size(316, 213)
			Me.richTextBox1.TabIndex = 0
			Me.richTextBox1.Text = ""
			' 
			' childFrameBarManager1
			' 
			Me.childFrameBarManager1.BarPositionInfo = (CType(resources.GetObject("childFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream))
			Me.childFrameBarManager1.Bars.Add(Me.bar1)
			Me.childFrameBarManager1.Categories.Add("Format")
			Me.childFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form"
			Me.childFrameBarManager1.Form = Me
			Me.childFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem1, Me.fontFaceParentBarItem, Me.fontSizeParentBarItem, Me.barItem3, Me.barItem1, Me.barItem2, Me.barItem4, Me.barItem5, Me.barItem7, Me.barItem6})
			Me.childFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' bar1
			' 
			Me.bar1.BarName = "FormatMenu"
			Me.bar1.BarStyle = (CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle))
			Me.bar1.Caption = "FormatMenu"
			Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem1})
			Me.bar1.Manager = Me.childFrameBarManager1
			' 
			' parentBarItem1
			' 
			Me.parentBarItem1.CategoryIndex = 0
			Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem1.ID = "F&ormat"
			Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.fontFaceParentBarItem, Me.fontSizeParentBarItem})
			Me.parentBarItem1.MergeOrder = 1
			Me.parentBarItem1.Text = "F&ormat"
			' 
			' fontFaceParentBarItem
			' 
			Me.fontFaceParentBarItem.CategoryIndex = 0
			Me.fontFaceParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.fontFaceParentBarItem.ID = "FontFace"
			Me.fontFaceParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem4})
			Me.fontFaceParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.fontFaceParentBarItem.Text = "FontFace"
			' 
			' barItem1
			' 
			Me.barItem1.CategoryIndex = 0
			Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem1.ID = "MS Sans Serif"
			Me.barItem1.Text = "1. MS Sans Serif"
'			Me.barItem1.Click += New System.EventHandler(Me.OnFontFaceBarItemClick);
			' 
			' barItem2
			' 
			Me.barItem2.CategoryIndex = 0
			Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem2.ID = "Times New Roman"
			Me.barItem2.Text = "2. Times New Roman"
'			Me.barItem2.Click += New System.EventHandler(Me.OnFontFaceBarItemClick);
			' 
			' barItem3
			' 
			Me.barItem3.CategoryIndex = 0
			Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem3.ID = "Courier New"
			Me.barItem3.Text = "3. Courier New"
'			Me.barItem3.Click += New System.EventHandler(Me.OnFontFaceBarItemClick);
			' 
			' barItem4
			' 
			Me.barItem4.CategoryIndex = 0
			Me.barItem4.Checked = True
			Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem4.ID = "Calibri"
			Me.barItem4.Text = "4. Calibri"
'			Me.barItem4.Click += New System.EventHandler(Me.OnFontFaceBarItemClick);
			' 
			' fontSizeParentBarItem
			' 
			Me.fontSizeParentBarItem.CategoryIndex = 0
			Me.fontSizeParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.fontSizeParentBarItem.ID = "FontSize"
			Me.fontSizeParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem5, Me.barItem7, Me.barItem6})
			Me.fontSizeParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.fontSizeParentBarItem.Text = "FontSize"
			' 
			' barItem5
			' 
			Me.barItem5.CategoryIndex = 0
			Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem5.ID = "Small"
			Me.barItem5.Text = "Small"
'			Me.barItem5.Click += New System.EventHandler(Me.OnFontSizeBarItemClick);
			' 
			' barItem7
			' 
			Me.barItem7.CategoryIndex = 0
			Me.barItem7.Checked = True
			Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem7.ID = "Medium"
			Me.barItem7.Text = "Medium"
'			Me.barItem7.Click += New System.EventHandler(Me.OnFontSizeBarItemClick);
			' 
			' barItem6
			' 
			Me.barItem6.CategoryIndex = 0
			Me.barItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem6.ID = "Large"
			Me.barItem6.Text = "Large"
'			Me.barItem6.Click += New System.EventHandler(Me.OnFontSizeBarItemClick);
			' 
			' Document
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(316, 213)
			Me.Controls.Add(Me.richTextBox1)
			Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8F)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Document"
			CType(Me.childFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private Sub OnFontFaceBarItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles barItem1.Click, barItem2.Click, barItem3.Click, barItem4.Click
			Dim item As BarItem = TryCast(sender, BarItem)
			Dim f As Form = Me.ParentForm
			If Not f Is Nothing Then
				Dim m As MainForm = CType(f, MainForm)
				Select Case item.ID
					Case "MS Sans Serif"
						Me.currentFontFamily_ = Me.sansSerifFontFamily
						Me.barItem1.Checked = True
					Case "Times New Roman"
						Me.currentFontFamily_ = Me.timesNewRomanFontFamily
						Me.barItem2.Checked = True
					Case "Courier New"
						Me.currentFontFamily_ = Me.courierNewFontFamily
						Me.barItem3.Checked = True
					Case "Arial"
						Me.currentFontFamily_ = Me.arialFontFamily
						Me.barItem4.Checked = True
				End Select
				Me.richTextBox1.Font = New Font(Me.currentFontFamily_, Me.fontSize)
				CheckChildItem(Me.fontFaceParentBarItem, item)
			End If
		End Sub

		Private Sub OnFontSizeBarItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles barItem5.Click, barItem7.Click, barItem6.Click
			Dim item As BarItem = TryCast(sender, BarItem)
			Dim f As Form = Me.ParentForm
			If Not f Is Nothing Then
				Dim m As MainForm = CType(f, MainForm)
				Select Case item.ID
					Case "Small"
						Me.fontSize = FontSizes.Small
					Case "Medium"
						Me.fontSize = FontSizes.Medium
					Case "Large"
						Me.fontSize = FontSizes.Large
				End Select
				Me.richTextBox1.Font = New Font(Me.currentFontFamily_, Me.fontSize)
				CheckChildItem(Me.fontSizeParentBarItem, item)
			End If
		End Sub

		Private Sub CheckChildItem(ByVal parentBarItem As ParentBarItem, ByVal item As BarItem)
			For Each i As BarItem In parentBarItem.Items
				If item.ID = i.ID Then
					i.Checked = True
				Else
					i.Checked = False
				End If
			Next i
		End Sub

		Public Sub DoLoadDocument(ByVal filename As String)
			Me.richTextBox1.LoadFile(filename, RichTextBoxStreamType.PlainText)
		End Sub

		Public Sub DoSaveDocument(ByVal filename As String)
			Me.richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText)
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			MyBase.Dispose(disposing)
		End Sub

	End Class
End Namespace











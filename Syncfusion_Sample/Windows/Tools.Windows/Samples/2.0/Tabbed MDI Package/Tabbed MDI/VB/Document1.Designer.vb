Imports Microsoft.VisualBasic
Imports System
Namespace TabbedMDI_2005
	Partial Public Class Document1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Document1))
			Me.childFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(Me)
			Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childFrameBarManager1, "Format Document")
			Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem_SansSerif = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_times = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem_courier = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.comboBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem()
			Me.comboBoxBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem()
			Me.parentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
			CType(Me.childFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' childFrameBarManager1
			' 
			Me.childFrameBarManager1.BarPositionInfo = (CType(resources.GetObject("childFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream))
			Me.childFrameBarManager1.Bars.Add(Me.bar1)
			Me.childFrameBarManager1.Categories.Add("Font Face")
			Me.childFrameBarManager1.Categories.Add("FontSize")
			Me.childFrameBarManager1.Categories.Add("Format Document")
			Me.childFrameBarManager1.Categories.Add("FontFormat")
			Me.childFrameBarManager1.CurrentBaseFormType = ""
			Me.childFrameBarManager1.Form = Me
			Me.childFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem1, Me.barItem_SansSerif, Me.barItem_times, Me.barItem_courier, Me.parentBarItem2, Me.barItem4, Me.barItem5, Me.barItem6, Me.parentBarItem3, Me.comboBoxBarItem1, Me.comboBoxBarItem2, Me.parentBarItem4})
			Me.childFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' bar1
			' 
			Me.bar1.BarName = "Format Document"
			Me.bar1.BarStyle = (CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle))
			Me.bar1.Caption = "Format Document"
			Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem3})
			Me.bar1.Manager = Me.childFrameBarManager1
			' 
			' parentBarItem3
			' 
			Me.parentBarItem3.CategoryIndex = 2
			Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem3.ID = "Format Document"
			Me.parentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem1, Me.parentBarItem2})
			Me.parentBarItem3.MergeOrder = 2
			Me.parentBarItem3.Text = "Format Document"
			' 
			' parentBarItem1
			' 
			Me.parentBarItem1.CategoryIndex = 0
			Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem1.ID = "Font Face"
			Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem_SansSerif, Me.barItem_times, Me.barItem_courier})
			Me.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.parentBarItem1.Text = "Font Face"
			' 
			' barItem_SansSerif
			' 
			Me.barItem_SansSerif.CategoryIndex = 0
			Me.barItem_SansSerif.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem_SansSerif.ID = "Microsoft Sans Serif"
			Me.barItem_SansSerif.Text = "Microsoft Sans Serif"
'			Me.barItem_SansSerif.Click += New System.EventHandler(Me.FormatFont_Clicked);
			' 
			' barItem_times
			' 
			Me.barItem_times.CategoryIndex = 0
			Me.barItem_times.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem_times.ID = "Times New Roman"
			Me.barItem_times.Text = "Times New Roman"
'			Me.barItem_times.Click += New System.EventHandler(Me.FormatFont_Clicked);
			' 
			' barItem_courier
			' 
			Me.barItem_courier.CategoryIndex = 0
			Me.barItem_courier.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem_courier.ID = "Courier New"
			Me.barItem_courier.Text = "Courier New"
'			Me.barItem_courier.Click += New System.EventHandler(Me.FormatFont_Clicked);
			' 
			' parentBarItem2
			' 
			Me.parentBarItem2.CategoryIndex = 1
			Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem2.ID = "Font Size"
			Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem4, Me.barItem5, Me.barItem6})
			Me.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.parentBarItem2.Text = "Font Size"
			' 
			' barItem4
			' 
			Me.barItem4.CategoryIndex = 1
			Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem4.ID = "Small"
			Me.barItem4.Text = "Small"
'			Me.barItem4.Click += New System.EventHandler(Me.FormatFont_Clicked);
			' 
			' barItem5
			' 
			Me.barItem5.CategoryIndex = 1
			Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem5.ID = "Medium"
			Me.barItem5.Text = "Medium"
'			Me.barItem5.Click += New System.EventHandler(Me.FormatFont_Clicked);
			' 
			' barItem6
			' 
			Me.barItem6.CategoryIndex = 1
			Me.barItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem6.ID = "Large"
			Me.barItem6.Text = "Large"
'			Me.barItem6.Click += New System.EventHandler(Me.FormatFont_Clicked);
			' 
			' comboBoxBarItem1
			' 
			Me.comboBoxBarItem1.CategoryIndex = 3
			Me.comboBoxBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBoxBarItem1.ID = "FontSize"
			Me.comboBoxBarItem1.Text = "FontSize"
			' 
			' comboBoxBarItem2
			' 
			Me.comboBoxBarItem2.CategoryIndex = 3
			Me.comboBoxBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBoxBarItem2.ID = "FontFac"
			Me.comboBoxBarItem2.Text = "FontFace"
			' 
			' parentBarItem4
			' 
			Me.parentBarItem4.CategoryIndex = 3
			Me.parentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem4.ID = "FontFormat"
			Me.parentBarItem4.Text = "FontFormat"
			' 
			' richTextBox1
			' 
			Me.richTextBox1.BackColor = System.Drawing.Color.White
			Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richTextBox1.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.richTextBox1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.ReadOnly = True
			Me.richTextBox1.Size = New System.Drawing.Size(292, 266)
			Me.richTextBox1.TabIndex = 4
			Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
			' 
			' Document1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 266)
			Me.Controls.Add(Me.richTextBox1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Document1"
			Me.Text = "Document1"
			CType(Me.childFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private childFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager
		Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private parentBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem_SansSerif As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_times As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem_courier As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private comboBoxBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
		Private comboBoxBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
		Private parentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private richTextBox1 As System.Windows.Forms.RichTextBox
	End Class
End Namespace
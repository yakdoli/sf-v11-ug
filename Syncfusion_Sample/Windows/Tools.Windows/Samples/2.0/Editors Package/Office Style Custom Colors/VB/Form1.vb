#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports System.IO
Imports Syncfusion.Drawing

Namespace CustomColors_2005
	Partial Public Class Form1
		Inherits RibbonForm
		#Region "Form constructor"
		Private customColor As Color
		Public Sub New()
			InitializeComponent()
			AddHandler Load, AddressOf Form1_Load
            ' "Default settings"
			Dim host As ToolStripControlHost = New ToolStripControlHost(Me.colorPickerUIAdv1)
            host.Size = New Size(200, 250)
            '  Me.colorPickerUIAdv1.Dock = DockStyle.Fill
			
			Dim dd As ToolStripDropDown = New ToolStripDropDown()
			dd.Items.Add(host)
			dd.Renderer = New BorderlessRenderer()
			Me.toolStripDropDownButton1.DropDown = dd
			Dim path As String = Application.StartupPath.ToString() & "..\..\..\Text.rtf"
			If File.Exists(path) Then
				Me.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText)
			End If
			customColor = Color.FromArgb(127, 102, 160)
			  Office2007Colors.ApplyManagedColors(Me, Color.FromArgb(127, 102, 160))
			  SetColors()
			  Me.groupBar1.SelectedItem = 0
            Me.xpTaskBarBox1.DrawFocusRect = False
            Me.xpTaskBarBox2.DrawFocusRect = False

'			#Region "Control's Visual Styles"
			'To set custom colors, the Visual styles of the control
			'need to be set as Office2007 and the the color scheme 
			'should be set as Managed.

			'MonthaCalendarAdv Visual Styles
			'this.monthCalendarAdv1.Style = VisualStyle.Office2007;
			'this.monthCalendarAdv1.Office2007Theme = Office2007Theme.Managed;

			  'ButtonAdv Visual Styles
			'this.buttonAdv2.UseVisualStyle = true;
			'this.buttonAdv2.Appearance = ButtonAppearance.Office2007;
			'this.buttonAdv2.Office2007ColorScheme = Office2007Theme.Managed;

			  'NumericUpDown Visual Styles
			'this.numericUpDownExt1.VisualStyle = VisualStyle.Office2007;
			'this.numericUpDownExt1.ColorScheme = Office2007Theme.Managed;

			  'CheckBoxAdv Visual Styles
			'this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2007;
			'this.checkBoxAdv1.Office2007ColorScheme = Office2007Theme.Managed;

			  'Calculator Visual Styles
			  'this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2007;
			'this.calculatorControl1.Office2007Theme = Office2007Theme.Managed;

			  'XPTaskBar Visual Styles
			  'this.xpTaskBar1.Style = XPTaskBarStyle.Office2007;
			  'this.xpTaskBar1.Office2007ColorScheme = Office2007Theme.Managed;

			  'MonthaCalendarAdv Visual Styles
			  'this.xpTaskPane1.VisualStyle = VisualStyle.Office2007;
			  'this.xpTaskPane1.Office2007ColorScheme = Office2007Theme.Managed;

			  'RibbonControlAdv Visual Styles
			  'this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Managed;
'#End Region
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
			Me.xpTaskPane1 = New Syncfusion.Windows.Forms.Tools.XPTaskPane()
			' 
			' xpTaskPane1
			' 
			Me.xpTaskPane1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(243))))), (CInt(Fix((CByte(255))))))
			Me.xpTaskPane1.Controls.Add(Me.wizardContainer1)
			Me.xpTaskPane1.Dock = System.Windows.Forms.DockStyle.Right
			' 
			' 
			' 
			Me.xpTaskPane1.Header.BackColor = System.Drawing.Color.Transparent
			Me.xpTaskPane1.Header.BorderColor = System.Drawing.Color.Black
			Me.xpTaskPane1.Header.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.xpTaskPane1.Header.Controls.Add(Me.xpTaskPane1.HeaderLabel)
			Me.xpTaskPane1.Header.Dock = System.Windows.Forms.DockStyle.Top
			Me.xpTaskPane1.Header.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskPane1.Header.Name = "header"
			Me.xpTaskPane1.Header.Size = New System.Drawing.Size(229, 22)
			Me.xpTaskPane1.Header.TabIndex = 2
			' 
			' 
			' 
			Me.xpTaskPane1.HeaderMenuItem.ImageIndex = 2
			Me.xpTaskPane1.HeaderMenuItem.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.xpTaskPane1.HeaderMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.xpTaskPane1.Location = New System.Drawing.Point(642, 157)
			Me.xpTaskPane1.Name = "xpTaskPane1"
			Me.xpTaskPane1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.xpTaskPane1.SelectedPage = Me.xpTaskPage1
			Me.xpTaskPane1.Size = New System.Drawing.Size(233, 395)
			Me.xpTaskPane1.TabIndex = 7
			Me.xpTaskPane1.TaskPages = New Syncfusion.Windows.Forms.Tools.XPTaskPage() { Me.xpTaskPage1, Me.xpTaskPage2, Me.xpTaskPage3}
			Me.xpTaskPane1.TaskPanePageContainer = Me.wizardContainer1
			Me.xpTaskPane1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' wizardContainer1
			' 
			Me.wizardContainer1.Controls.Add(Me.xpTaskPage1)
			Me.wizardContainer1.Controls.Add(Me.xpTaskPage2)
			Me.wizardContainer1.Controls.Add(Me.xpTaskPage3)
			' 
			' xpTaskPage1
			' 
			Me.xpTaskPage1.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(99))))), (CInt(Fix((CByte(146))))), (CInt(Fix((CByte(206))))))
			Me.xpTaskPage1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.xpTaskPage1.Controls.Add(Me.panel4)
			Me.xpTaskPage1.Controls.Add(Me.multiColumnComboBox1)
			Me.xpTaskPage1.Controls.Add(Me.textBoxExt2)
			Me.xpTaskPage1.Controls.Add(Me.comboBoxBase1)
			Me.xpTaskPage1.Controls.Add(Me.buttonAdv6)
			Me.xpTaskPage1.Controls.Add(Me.buttonAdv5)
			Me.xpTaskPage1.Controls.Add(Me.label31)
			Me.xpTaskPage1.Controls.Add(Me.label11)
			Me.xpTaskPage1.Controls.Add(Me.linkLabel15)
			Me.xpTaskPage1.Controls.Add(Me.linkLabel16)
			Me.xpTaskPage1.Controls.Add(Me.label9)
			Me.xpTaskPage1.Controls.Add(Me.label12)
			Me.xpTaskPage1.Controls.Add(Me.label8)
			Me.xpTaskPage1.Controls.Add(Me.label10)
			Me.xpTaskPage1.LayoutName = "Card1"
			Me.xpTaskPage1.Location = New System.Drawing.Point(0, 25)
			Me.xpTaskPage1.Name = "xpTaskPage1"
			Me.xpTaskPage1.NextPage = Nothing
			Me.xpTaskPage1.PreviousPage = Nothing
			Me.xpTaskPage1.Size = New System.Drawing.Size(229, 369)
			Me.xpTaskPage1.TabIndex = 0
			Me.xpTaskPage1.Title = "Basic Search"
			Me.Controls.Add(Me.xpTaskPane1)
		End Sub


		#End Region

		#Region "Apply custom Color"

		Private Sub colorPickerUIAdv1_Picked(ByVal sender As Object, ByVal args As ColorPickerUIAdv.ColorPickedEventArgs) Handles colorPickerUIAdv1.Picked
			customColor = args.Color
			'Applies custom colors for syncfusion controls whose color scheme
			'is set as Managed and Visual styles set as Office2007
			Office2007Colors.ApplyManagedColors(Me, customColor)
			SetColors()

			' Ensures that the PopupControlContainer is closed after the selection of a color.
			Dim cc As ColorPickerUIAdv = TryCast(sender, ColorPickerUIAdv)
			Dim dd As ToolStripDropDown = TryCast(cc.Parent, ToolStripDropDown)
			dd.Hide()
			Me.Focus()

		End Sub

		#Region "Colors for other controls"
		Private Sub SetColors()
			Me.trackBarItem1.TrackBarExControl.ButtonColor = customColor
            Dim color As Color() = New Color() {System.Drawing.Color.White, customColor}
			Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(GradientStyle.Vertical, color)
			Me.richTextBox1.ForeColor = customColor
			Me.gradientPanel3.BorderColor = customColor
			Me.gradientPanel1.BorderColor = customColor
		End Sub
		#End Region
		#End Region

		#Region "AboutForm"
		Private aboutForm As DemoCommon.AboutForm = Nothing
		Private Sub toolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton1.Click
			aboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
			aboutForm.ShowDialog()
			Office2007Colors.ApplyManagedColors(aboutForm, customColor)
		End Sub
		#End Region

	End Class
	#Region "BorderlessRenderer - For ColorPickerUIAdv"
	Public Class BorderlessRenderer
		Inherits ToolStripProfessionalRenderer
		Protected Overrides Sub OnRenderToolStripBorder(ByVal e As ToolStripRenderEventArgs)
			' do nothing
		End Sub
	End Class
	#End Region

End Namespace
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
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.IO
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms

Namespace RibbonControlAdv_2005
	Partial Public Class Form1
		Inherits RibbonForm
		#Region "Constructor"
		Public Sub New()
			InitializeComponent()
			Me.gradientPanel1.Visible = False
			Me.richTextBox1.Visible = False
			Me.gridControl1.Visible = False
            Me.superAccelerator1.SetAccelerator(Me.toolStripTabItem2, "R")
            Me.statusStripEx1.ContextMenuStrip = Nothing

            ' To host any .Net control into ToolStripEx, StatusStrip,
			' User can make use of ToolStripControlHost class
			' and host the control inside it and add the host
			' to item collection.
			Dim host1 As ToolStripControlHost = New ToolStripControlHost(Me.treeViewAdv1)
			Me.toolStripEx25.Items.Add(host1)
			Dim host2 As ToolStripControlHost = New ToolStripControlHost(Me.gridControl1)
			Me.toolStripEx26.Items.Add(host2)
			Dim host3 As ToolStripControlHost = New ToolStripControlHost(Me.panel1)
			Me.toolStripEx28.Items.Add(host3)

		End Sub
		#End Region

		#Region "ColorScheme"

		Private Sub ColorSchemeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton29.Click, toolStripButton30.Click, toolStripButton31.Click
			Dim toolStripButton As ToolStripButton = TryCast(sender, ToolStripButton)
			If toolStripButton Is Me.toolStripButton29 Then
				If toolStripButton.Checked Then
				  Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue
				   Me.ColorScheme = Syncfusion.Windows.Forms.Tools.RibbonForm.ColorSchemeType.Blue
					Me.toolStripButton30.Checked = False
					Me.toolStripButton31.Checked = False
				End If
			End If
			If toolStripButton Is Me.toolStripButton30 Then
				If toolStripButton.Checked Then
				  Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
					Me.ColorScheme = Syncfusion.Windows.Forms.Tools.RibbonForm.ColorSchemeType.Silver
					Me.toolStripButton29.Checked = False
					Me.toolStripButton31.Checked = False

				End If
			End If
			If toolStripButton Is Me.toolStripButton31 Then
				If toolStripButton.Checked Then
				  Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Black
					Me.ColorScheme = Syncfusion.Windows.Forms.Tools.RibbonForm.ColorSchemeType.Black
					Me.toolStripButton29.Checked = False
					Me.toolStripButton30.Checked = False

				End If
			End If
		End Sub
		#End Region

		#Region "Launcher"
		Private Sub LauncherButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton32.Click, toolStripButton33.Click
			Dim toolStripButton As ToolStripButton = TryCast(sender, ToolStripButton)
			If toolStripButton Is Me.toolStripButton32 Then
				If toolStripButton.Checked Then
				  Me.ribbonControlAdv1.LauncherStyle = LauncherStyle.Office12
					Me.toolStripButton33.Checked = False

				End If
			End If
			If toolStripButton Is Me.toolStripButton33 Then
				If toolStripButton.Checked Then
				  Me.ribbonControlAdv1.LauncherStyle = LauncherStyle.Office2007
					Me.toolStripButton32.Checked = False

				End If
			End If

		End Sub

		Private Sub toolStripButton34_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton34.Click
			If toolStripButton34.Checked Then
			  Me.ribbonControlAdv1.ShowLauncher = True
			Else
			  Me.ribbonControlAdv1.ShowLauncher = False
			End If

		End Sub
#End Region

		#Region "QuickPanel"

		Private Sub toolStripButton37_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton37.Click

			If toolStripButton37.Checked Then
			  Me.ribbonControlAdv1.QuickPanelVisible = True
			Else
			  Me.ribbonControlAdv1.QuickPanelVisible = False
			End If

		End Sub
		Private Sub QuickPanelToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton35.Click, toolStripButton36.Click
			Dim toolStripButton As ToolStripButton = TryCast(sender, ToolStripButton)
			If toolStripButton Is Me.toolStripButton35 Then
				If toolStripButton.Checked Then
				  Me.ribbonControlAdv1.ShowQuickPanelBelowRibbon = False
					Me.toolStripButton36.Checked = False

				End If
			End If
			If toolStripButton Is Me.toolStripButton36 Then
				If toolStripButton.Checked Then
				  Me.ribbonControlAdv1.ShowQuickPanelBelowRibbon = True
					Me.toolStripButton35.Checked = False

				End If
			End If

		End Sub
		#End Region

		#Region "MenuButton"
		Private Sub toolStripButton38_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton38.CheckStateChanged
			If Me.toolStripButton38.Checked Then
				Dim img As Image = Image.FromFile("../../Data/fSEARCH_00.gif")
			  Me.ribbonControlAdv1.MenuButtonImage = img
			Else
				Dim img As Image = Image.FromFile("../../Data/sync_icon.ico")
				Me.ribbonControlAdv1.MenuButtonImage = img
			End If
		End Sub

		Private Sub toolStripCheckBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripCheckBox5.CheckedChanged
			Me.ribbonControlAdv1.MenuButtonVisible = toolStripCheckBox5.Checked
		End Sub


		#End Region

		#Region "Gallery"
		Private Sub numericUpDownExt2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownExt2.ValueChanged
			Me.toolStripGallery2.DropDownDimensions = New System.Drawing.Size(Convert.ToInt16(Me.numericUpDownExt2.Value), 0)
		End Sub

		Private Sub numericUpDownExt1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownExt1.ValueChanged
			Me.toolStripGallery2.Dimensions = New System.Drawing.Size(Convert.ToInt16(Me.numericUpDownExt1.Value), 0)
		End Sub

		Private Sub ToolStripTabItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripTabItem6.Click, toolStripTabItem1.Click, toolStripTabItem4.Click, toolStripTabItem9.Click
			Dim toolStripTabItem As ToolStripTabItem = TryCast(sender, ToolStripTabItem)
			If toolStripTabItem Is Me.toolStripTabItem4 Then
				Me.gradientPanel1.Visible = True
				Me.richTextBox1.Visible = False
			ElseIf toolStripTabItem Is Me.toolStripTabItem9 Then
				Me.gradientPanel1.Visible = False
				Me.richTextBox1.Visible = True
				Me.richTextBox1.Dock = DockStyle.Fill

		   Else
				Me.gradientPanel1.Visible = False
				Me.richTextBox1.Visible = False
		   End If


		End Sub


		#End Region

		#Region "CaptionTextStyle"
		Private Sub TextStyleToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton48.Click, toolStripButton49.Click, toolStripButton50.Click
			Dim toolStripButton As ToolStripButton = TryCast(sender, ToolStripButton)
			If toolStripButton Is Me.toolStripButton48 Then
				Me.toolStripButton49.Checked = False
				Me.toolStripButton50.Checked = False
			End If
			If Me.toolStripButton48.Checked Then
			  Me.ribbonControlAdv1.CaptionTextStyle = CaptionTextStyle.Plain
			End If
			If toolStripButton Is Me.toolStripButton49 Then
				Me.toolStripButton48.Checked = False
				Me.toolStripButton50.Checked = False
			End If
			If Me.toolStripButton49.Checked Then
			  Me.ribbonControlAdv1.CaptionTextStyle = CaptionTextStyle.Etched
			End If
			If toolStripButton Is Me.toolStripButton50 Then
				Me.toolStripButton48.Checked = False
				Me.toolStripButton49.Checked = False
			End If
			If Me.toolStripButton50.Checked Then
			  Me.ribbonControlAdv1.CaptionTextStyle = CaptionTextStyle.Shadow
			End If

		End Sub
			#End Region

		#Region "TabGroupColor"
		Private Sub GroupColorToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton51.Click, toolStripButton52.Click
			Dim toolStripButton As ToolStripButton = TryCast(sender, ToolStripButton)
			If toolStripButton Is Me.toolStripButton51 Then
				If Me.toolStripButton51.Checked Then
					Me.toolStripTabGroup1 = New ToolStripTabGroup()
					Me.toolStripTabGroup1.Visible = True
				   Me.toolStripTabGroup1.Name = "TabGroup"
					Me.toolStripTabGroup1.Color = Color.FromArgb(113, 215, 62)
				 Me.ribbonControlAdv1.TabGroups.Add(Me.toolStripTabGroup1)
				 Me.ribbonControlAdv1.TabGroups.SetTabGroup(Me.toolStripTabItem4, Me.toolStripTabGroup1)
				 Me.ribbonControlAdv1.TabGroups.SetTabGroup(Me.toolStripTabItem2, Me.toolStripTabGroup1)
				 Me.toolStripButton52.Checked = False
				End If
			End If
			If toolStripButton Is Me.toolStripButton52 Then
				If Me.toolStripButton52.Checked Then
					Me.toolStripTabGroup1 = New ToolStripTabGroup()
					Me.toolStripTabGroup1.Visible = True
					Me.toolStripTabGroup1.Name = "TabGroup"
					Me.toolStripTabGroup1.Color = Color.FromArgb(247, 94, 217)
					Me.ribbonControlAdv1.TabGroups.Add(Me.toolStripTabGroup1)
					Me.ribbonControlAdv1.TabGroups.SetTabGroup(Me.toolStripTabItem4, Me.toolStripTabGroup1)
					Me.ribbonControlAdv1.TabGroups.SetTabGroup(Me.toolStripTabItem2, Me.toolStripTabGroup1)
					Me.toolStripButton51.Checked = False
				End If

			End If
		End Sub
		#End Region

		#Region "Form_Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim path As String = Application.StartupPath.ToString() & "..\..\..\Introduction.rtf"
			If File.Exists(path) Then
				Me.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText)
			End If

        End Sub
#End Region

		#Region "Launcher_Click"
		Private Sub Launcher_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripEx16.LauncherClick, toolStripEx22.LauncherClick, toolStripEx23.LauncherClick, toolStripEx21.LauncherClick, toolStripEx17.LauncherClick, toolStripEx18.LauncherClick, toolStripEx7.LauncherClick, toolStripEx5.LauncherClick, toolStripEx4.LauncherClick, toolStripEx6.LauncherClick, toolStripEx1.LauncherClick, toolStripEx2.LauncherClick, toolStripEx19.LauncherClick, toolStripEx3.LauncherClick, toolStripEx12.LauncherClick, toolStripEx11.LauncherClick, toolStripEx24.LauncherClick, toolStripEx9.LauncherClick, toolStripEx10.LauncherClick, toolStripEx20.LauncherClick, toolStripEx15.LauncherClick, toolStripEx13.LauncherClick, toolStripEx14.LauncherClick, toolStripEx8.LauncherClick, toolStripEx25.LauncherClick, toolStripEx26.LauncherClick
			Dim toolStripEx As ToolStripEx = TryCast(sender, ToolStripEx)
			If toolStripEx.Text = "Launcher" Then
                Me.statusStripLabel1.Text = "Launcher ToolStripEx Launcher clicked"
            ElseIf toolStripEx.Text = "3 Rows" Then
                Me.statusStripLabel1.Text = "Panel - 3 Rows, Launcher clicked"
            Else
                Me.statusStripLabel1.Text = toolStripEx.Text & " Launcher clicked"
			End If
		End Sub
		#End Region

		#Region "General Properties"
		'To allow or disallow the ribbon from collapsing
		Private Sub toolStripCheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripCheckBox1.CheckedChanged
			Me.ribbonControlAdv1.AllowCollapse = Me.toolStripCheckBox1.Checked
		End Sub

		'To Show the customize Dialog
		Private Sub toolStripButton24_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton24.Click
			Me.ribbonControlAdv1.ShowCustomizeDialog()
		End Sub
		#End Region

		#Region "Custom Colors"

		Private Sub colorPickerUIAdv1_Picked(ByVal sender As Object, ByVal args As ColorPickerUIAdv.ColorPickedEventArgs) Handles colorPickerUIAdv1.Picked

			'set the custom color to the form and RibbonControlAdv
			Me.ColorScheme = ColorSchemeType.Managed
			Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Managed
			Office12ColorTable.ApplyManagedColors(Me, args.Color)

			'Set the GradientLabel color
		   Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { Color.WhiteSmoke, args.Color, Color.WhiteSmoke})

			' Ensures that the PopupControlContainer is closed after the selection of a color.
			Dim cc As ColorPickerUIAdv = TryCast(sender, ColorPickerUIAdv)
			Dim pcc As Syncfusion.Windows.Forms.PopupControlContainer = TryCast(cc.Parent, Syncfusion.Windows.Forms.PopupControlContainer)
            pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done)
            Dim bInfo As Syncfusion.Drawing.BrushInfo = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, args.Color, Color.FromArgb(237, 240, 247))
            df.gradientLabel1.BackgroundColor = bInfo
            df.gradientLabel2.BackgroundColor = bInfo
            df.gradientLabel3.BackgroundColor = bInfo
            df.gradientPanel1.BackgroundColor = bInfo
			Me.toolStripButton29.Checked = False
			Me.popupControlContainer1.Size = Me.colorPickerUIAdv1.Size
		End Sub
		Private Sub toolStripMenuItem8_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			Me.popupControlContainer1.ShowPopup(e.Location)
		End Sub
#End Region

		#Region "Retrieve Items Collection"

        Private df As DialogForm = New DialogForm()

        Private Sub toolStripButton25_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton25.Click
            'df = New DialogForm()
            Select Case Me.ColorScheme
                Case ColorSchemeType.Blue
                    df.ColorScheme = Office2007Theme.Blue
                    df.UpdateFormControlColors(Office2007Theme.Blue)
                Case ColorSchemeType.Black
                    df.ColorScheme = Office2007Theme.Black
                    df.UpdateFormControlColors(Office2007Theme.Black)
                Case ColorSchemeType.Silver
                    df.ColorScheme = Office2007Theme.Silver
                    df.UpdateFormControlColors(Office2007Theme.Silver)
            End Select
            df.TopMost = True
            df.listBox1.Items.Clear()
            df.listBox2.Items.Clear()
            For Each tsItem As ToolStripItem In Me.ribbonControlAdv1.Header.QuickItems
                df.listBox1.Items.Add(tsItem.Text.ToString())
            Next tsItem

            For Each tstabItem As ToolStripTabItem In Me.ribbonControlAdv1.Header.MainItems
                df.listBox2.Items.Add(tstabItem.Text.ToString())
            Next tstabItem
            df.ShowDialog()
        End Sub
		#End Region

		#Region "Option Controls"
		Private Sub toolStripCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripCheckBox3.CheckStateChanged, toolStripCheckBox4.CheckStateChanged
			Dim toolStripCheckBox As ToolStripCheckBox = TryCast(sender, ToolStripCheckBox)
			toolStripCheckBox.Text = toolStripCheckBox.CheckState.ToString()
		End Sub

		Private Sub toolStripRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripRadioButton1.CheckedChanged, toolStripRadioButton2.CheckedChanged
			Dim toolStripRadioButton As ToolStripRadioButton = TryCast(sender, ToolStripRadioButton)
			toolStripRadioButton.Text = toolStripRadioButton.CheckState.ToString()
		End Sub
#End Region    
        Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.SizeChanged
            If Me.WindowState <> FormWindowState.Maximized Then
                Me.statusStripEx1.SizingGrip = True
            Else
                Me.statusStripEx1.SizingGrip = False
            End If
        End Sub

    End Class
End Namespace
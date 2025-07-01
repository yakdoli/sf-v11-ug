Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace BackStageDemo
	Partial Public Class Form1
		Inherits RibbonForm
		Private toolStripTabGroup1 As New Syncfusion.Windows.Forms.Tools.ToolStripTabGroup()
		Private colorPickerUIAdv1 As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
		Public Sub New()
            InitializeComponent()

		End Sub

		Private Sub colorPickerUIAdv1_ItemSelection(ByVal sender As Object, ByVal args As ColorPickerUIAdv.ColorPickedEventArgs)

		End Sub

		Private Sub colorPickerUIAdv1_Picked(ByVal sender As Object, ByVal args As ColorPickerUIAdv.ColorPickedEventArgs)
			Me.ribbonControlAdv1.MenuColor = Me.colorPickerUIAdv1.SelectedColor
			toolStripTabGroup1.Color = Me.ribbonControlAdv1.MenuColor
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub backStageButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles backStageButton1.Click

		End Sub

		Private Sub backStageButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles backStageButton2.Click

		End Sub

		Private Sub backStageButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles backStageButton3.Click

		End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.backStageButton1.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton1.Enabled = False
            Me.backStageButton1.Image = My.Resources.Save16
            Me.backStageButton1.Location = New System.Drawing.Point(10, 10)
            Me.backStageButton1.Name = "backStageButton1"
            Me.backStageButton1.Size = New System.Drawing.Size(110, 25)
            Me.backStageButton1.TabIndex = 2
            Me.backStageButton1.Text = "Save"
            '			Me.backStageButton1.Click += New System.EventHandler(Me.backStageButton1_Click)
            ' 
            ' backStageButton2
            ' 
            Me.backStageButton2.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton2.Image = My.Resources.SaveAs32
            Me.backStageButton2.Location = New System.Drawing.Point(10, 35)
            Me.backStageButton2.Name = "backStageButton2"
            Me.backStageButton2.Size = New System.Drawing.Size(110, 25)
            Me.backStageButton2.TabIndex = 3
            Me.backStageButton2.Text = "Save As"
            '			Me.backStageButton2.Click += New System.EventHandler(Me.backStageButton2_Click)
            ' 
            ' backStageButton3
            ' 
            Me.backStageButton3.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton3.Image = My.Resources.Open32
            Me.backStageButton3.Location = New System.Drawing.Point(10, 60)
            Me.backStageButton3.Name = "backStageButton3"
            Me.backStageButton3.Size = New System.Drawing.Size(110, 25)
            Me.backStageButton3.TabIndex = 4
            Me.backStageButton3.Text = "Open"
            '			Me.backStageButton3.Click += New System.EventHandler(Me.backStageButton3_Click)
            ' 
            ' backStageButton4
            ' 
            Me.backStageButton4.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton4.Image = My.Resources.Close32
            Me.backStageButton4.Location = New System.Drawing.Point(10, 85)
            Me.backStageButton4.Name = "backStageButton4"
            Me.backStageButton4.Size = New System.Drawing.Size(110, 25)
            Me.backStageButton4.TabIndex = 5
            Me.backStageButton4.Text = "Close"
            'Me.ribbonControlAdv1.Header.AddQuickItem(New Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton5))
            'Me.ribbonControlAdv1.Header.AddQuickItem(New Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton3))
            toolStripTabGroup1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))))
            toolStripTabGroup1.Name = "Layout"
            toolStripTabGroup1.Visible = True
            Me.ribbonControlAdv1.TabGroups.Add(toolStripTabGroup1)
            Me.ribbonControlAdv1.TabGroups.SetTabGroup(Me.toolStripTabItem3, toolStripTabGroup1)


            Me.toolStripButton18.Enabled = False
            Me.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
            Me.colorPickerUIAdv1 = New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv()
            ' 
            ' colorPickerUIAdv1.RecentGroup
            ' 
            Me.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors"
            Me.colorPickerUIAdv1.RecentGroup.Visible = False
            ' 
            ' colorPickerUIAdv1.StandardGroup
            ' 
            Me.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors"
            ' 
            ' colorPickerUIAdv1.ThemeGroup
            ' 
            Me.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = True
            Me.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors"
            ' 
            ' colorPickerUIAdv1
            ' 
            Me.colorPickerUIAdv1.ColorItemSize = New System.Drawing.Size(13, 13)
            Me.colorPickerUIAdv1.HorizontalItemsSpacing = 5
            Me.colorPickerUIAdv1.Location = New System.Drawing.Point(25, 52)
            Me.colorPickerUIAdv1.MinimumSize = New System.Drawing.Size(136, 149)
            Me.colorPickerUIAdv1.Name = "colorPickerUIAdv1"
            Me.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty
            Me.colorPickerUIAdv1.Size = New System.Drawing.Size(181, 195)
            Me.colorPickerUIAdv1.TabIndex = 0
            Me.colorPickerUIAdv1.Text = "colorPickerUIAdv1"
            AddHandler colorPickerUIAdv1.ItemSelection, AddressOf colorPickerUIAdv1_ItemSelection
            AddHandler colorPickerUIAdv1.Picked, AddressOf colorPickerUIAdv1_Picked
            Me.backStageTab1.Controls.Add(Me.colorPickerUIAdv1)

        End Sub

      
    End Class
End Namespace

#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace ExcelToolTip
	Partial Public Class Form1
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
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.label1 = New System.Windows.Forms.Label()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 14)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.Size = New System.Drawing.Size(529, 366)
			Me.gridGroupingControl1.TabIndex = 0
			Me.gridGroupingControl1.TableDescriptor.Appearance.AlternateRecordFieldCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.GradientInactiveCaption)
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.VersionInfo = "7.403.0.5"
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.DimGray
			Me.panel1.ForeColor = System.Drawing.Color.DimGray
			Me.panel1.Location = New System.Drawing.Point(548, 27)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1, 401)
			Me.panel1.TabIndex = 22
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.propertyGrid1.BackColor = System.Drawing.Color.White
			Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
			Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
			Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
			Me.propertyGrid1.LineColor = System.Drawing.Color.White
			Me.propertyGrid1.Location = New System.Drawing.Point(556, 2)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
			Me.propertyGrid1.Size = New System.Drawing.Size(203, 436)
			Me.propertyGrid1.TabIndex = 21
			' 
			' panel2
			' 
			Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.label1)
			Me.panel2.Location = New System.Drawing.Point(12, 389)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(529, 49)
			Me.panel2.TabIndex = 23
			' 
			' label1
			' 
			Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.label1.BackColor = System.Drawing.Color.White
			Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.label1.ForeColor = System.Drawing.Color.DimGray
			Me.label1.Location = New System.Drawing.Point(25, 15)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(473, 16)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Right-Click Cell or Left-Click existing comment corner to Add, Remove or Edit com" & "ment "
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(772, 457)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.propertyGrid1)
			Me.Controls.Add(Me.gridGroupingControl1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
            Me.Text = "Excel-Like Cell Comment Tip Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private panel1 As System.Windows.Forms.Panel
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private panel2 As System.Windows.Forms.Panel
		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace


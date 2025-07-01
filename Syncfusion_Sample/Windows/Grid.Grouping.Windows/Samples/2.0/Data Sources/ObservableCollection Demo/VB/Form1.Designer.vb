#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports Syncfusion.Windows.Forms.Grid.Grouping
Namespace ObservableCollection_Demo
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
			Me.components = New System.ComponentModel.Container()
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.listView1 = New System.Windows.Forms.ListView()
			Me.columnHeader1 = New System.Windows.Forms.ColumnHeader()
			Me.columnHeader2 = New System.Windows.Forms.ColumnHeader()
			Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.Location = New System.Drawing.Point(17, 22)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.Size = New System.Drawing.Size(619, 362)
			Me.gridGroupingControl1.SortIconPlacement = Syncfusion.Windows.Forms.Grid.SortIconPlacement.Right
			Me.gridGroupingControl1.TabIndex = 0
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.VersionInfo = "10.404.0.21"
'			Me.gridGroupingControl1.FilterBarSelectedItemChanged += New FilterBarSelectedItemChangedEventHandler(gridGroupingControl1_FilterBarSelectedItemChanged)
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.propertyGrid1.Location = New System.Drawing.Point(655, 22)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
			Me.propertyGrid1.Size = New System.Drawing.Size(223, 362)
			Me.propertyGrid1.TabIndex = 1
			' 
			' panel1
			' 
			Me.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.panel1.BackColor = System.Drawing.Color.Black
			Me.panel1.Location = New System.Drawing.Point(645, 22)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1, 362)
			Me.panel1.TabIndex = 2
			' 
			' listView1
			' 
			Me.listView1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() { Me.columnHeader1, Me.columnHeader2})
			Me.listView1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.listView1.ForeColor = System.Drawing.Color.DimGray
			Me.listView1.Location = New System.Drawing.Point(17, 390)
			Me.listView1.Name = "listView1"
			Me.listView1.Size = New System.Drawing.Size(619, 185)
			Me.listView1.TabIndex = 11
			Me.listView1.UseCompatibleStateImageBehavior = False
			Me.listView1.View = System.Windows.Forms.View.Details
			' 
			' columnHeader1
			' 
			Me.columnHeader1.Text = "Event"
			Me.columnHeader1.Width = 186
			' 
			' columnHeader2
			' 
			Me.columnHeader2.Text = "Details"
			Me.columnHeader2.Width = 759
			' 
			' button1
			' 
			Me.button1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0))))))
			Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.White
			Me.button1.Location = New System.Drawing.Point(699, 415)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(128, 24)
			Me.button1.TabIndex = 12
			Me.button1.Text = "Trace Events"
			Me.button1.UseVisualStyle = True
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' buttonAdv1
			' 
			Me.buttonAdv1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0))))))
			Me.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.buttonAdv1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv1.ForeColor = System.Drawing.Color.White
			Me.buttonAdv1.Location = New System.Drawing.Point(699, 463)
			Me.buttonAdv1.Name = "buttonAdv1"
			Me.buttonAdv1.Size = New System.Drawing.Size(128, 24)
			Me.buttonAdv1.TabIndex = 13
			Me.buttonAdv1.Text = "Clear Trace"
			Me.buttonAdv1.UseVisualStyle = True
			Me.buttonAdv1.UseVisualStyleBackColor = False
'			Me.buttonAdv1.Click += New System.EventHandler(Me.buttonAdv1_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(890, 587)
			Me.Controls.Add(Me.buttonAdv1)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.listView1)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.propertyGrid1)
			Me.Controls.Add(Me.gridGroupingControl1)
			Me.DropShadow = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Observable Collection Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private panel1 As System.Windows.Forms.Panel
		Private listView1 As System.Windows.Forms.ListView
		Private columnHeader1 As System.Windows.Forms.ColumnHeader
		Private columnHeader2 As System.Windows.Forms.ColumnHeader
		Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
	End Class
End Namespace


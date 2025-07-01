Imports Microsoft.VisualBasic
Imports System
Namespace TooltipDemo_2005
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
			Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.button5 = New System.Windows.Forms.Button()
			Me.button6 = New System.Windows.Forms.Button()
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridDataBoundGrid1
			' 
			Me.gridDataBoundGrid1.AllowDragSelectedCols = True
			Me.gridDataBoundGrid1.GridLineColor = System.Drawing.SystemColors.GrayText
			Me.gridDataBoundGrid1.Location = New System.Drawing.Point(0, 0)
			Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
			Me.gridDataBoundGrid1.OptimizeInsertRemoveCells = True
			Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
			Me.gridDataBoundGrid1.Size = New System.Drawing.Size(702, 338)
			Me.gridDataBoundGrid1.SmartSizeBox = False
			Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
			Me.gridDataBoundGrid1.TabIndex = 0
			Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
			Me.gridDataBoundGrid1.ThemesEnabled = True
			Me.gridDataBoundGrid1.UseListChangedEvent = True
			Me.gridDataBoundGrid1.UseRightToLeftCompatibleTextBox = True
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.button6)
			Me.groupBox1.Controls.Add(Me.button5)
			Me.groupBox1.Controls.Add(Me.button4)
			Me.groupBox1.Controls.Add(Me.button3)
			Me.groupBox1.Controls.Add(Me.button2)
			Me.groupBox1.Controls.Add(Me.button1)
			Me.groupBox1.Location = New System.Drawing.Point(12, 344)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(678, 122)
			Me.groupBox1.TabIndex = 1
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Sort Options"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(137, 31)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(126, 23)
			Me.button1.TabIndex = 0
			Me.button1.Text = "SortByCustomerName"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(279, 31)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(126, 23)
			Me.button2.TabIndex = 1
			Me.button2.Text = "SortByContactName"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' button3
			' 
			Me.button3.Location = New System.Drawing.Point(420, 31)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(126, 23)
			Me.button3.TabIndex = 2
			Me.button3.Text = "SortByContactTitle"
			Me.button3.UseVisualStyleBackColor = True
'			Me.button3.Click += New System.EventHandler(Me.button3_Click)
			' 
			' button4
			' 
			Me.button4.Location = New System.Drawing.Point(137, 71)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(126, 23)
			Me.button4.TabIndex = 3
			Me.button4.Text = "SortOnDoubleClick"
			Me.button4.UseVisualStyleBackColor = True
'			Me.button4.Click += New System.EventHandler(Me.button4_Click)
			' 
			' button5
			' 
			Me.button5.Location = New System.Drawing.Point(420, 71)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(126, 23)
			Me.button5.TabIndex = 4
			Me.button5.Text = "AvoidSorting"
			Me.button5.UseVisualStyleBackColor = True
'			Me.button5.Click += New System.EventHandler(Me.button5_Click)
			' 
			' button6
			' 
			Me.button6.Location = New System.Drawing.Point(279, 71)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(126, 23)
			Me.button6.TabIndex = 5
			Me.button6.Text = "SortOnSingleClick"
			Me.button6.UseVisualStyleBackColor = True
'			Me.button6.Click += New System.EventHandler(Me.button6_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(712, 478)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.gridDataBoundGrid1)
			Me.Name = "Form1"
			Me.Text = "Sort Demo"
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents button6 As System.Windows.Forms.Button
		Private WithEvents button5 As System.Windows.Forms.Button
		Private WithEvents button4 As System.Windows.Forms.Button
	End Class
End Namespace


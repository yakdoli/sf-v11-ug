Imports Microsoft.VisualBasic
Imports System
Namespace Enhanced_VisualStyle_In_GDBG
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.label8 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.pictureBox5 = New System.Windows.Forms.PictureBox()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.pictureBox3 = New System.Windows.Forms.PictureBox()
			Me.pictureBox4 = New System.Windows.Forms.PictureBox()
			Me.pictureBox7 = New System.Windows.Forms.PictureBox()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.pictureBox6 = New System.Windows.Forms.PictureBox()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridDataBoundGrid1
			' 
			Me.gridDataBoundGrid1.AllowDragSelectedCols = True
			Me.gridDataBoundGrid1.Location = New System.Drawing.Point(17, 29)
			Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
			Me.gridDataBoundGrid1.OptimizeInsertRemoveCells = True
			Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
			Me.gridDataBoundGrid1.Size = New System.Drawing.Size(276, 432)
			Me.gridDataBoundGrid1.SmartSizeBox = False
			Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
			Me.gridDataBoundGrid1.TabIndex = 0
			Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
			Me.gridDataBoundGrid1.UseListChangedEvent = True
			Me.gridDataBoundGrid1.UseRightToLeftCompatibleTextBox = True
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.gridDataBoundGrid1)
			Me.groupBox1.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.Location = New System.Drawing.Point(21, 20)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(313, 467)
			Me.groupBox1.TabIndex = 1
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "GridDataBoundGrid"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Font = New System.Drawing.Font("Segoe UI", 8.25F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle)), System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label8.Location = New System.Drawing.Point(376, 373)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(214, 13)
			Me.label8.TabIndex = 23
			Me.label8.Text = """Grid.Model.EnableLegacyStyle = false"""
			' 
			' label7
			' 
			Me.label7.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label7.Location = New System.Drawing.Point(356, 273)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(261, 90)
			Me.label7.TabIndex = 22
			Me.label7.Text = Constants.vbCrLf & "The existing ColorStyles property is marked as deprecated, " & Constants.vbCrLf & Constants.vbCrLf & "So the colorsche" & "me used by ColorStyles will be applied to the Grid just by disabling its LegacyS" & "tyles."
			' 
			' label2
			' 
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle)), System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(356, 232)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(261, 41)
			Me.label2.TabIndex = 21
			Me.label2.Text = "This sample features the GridDataBoundGrid Control with the new colorscheme used " & "for the ColorStyles. "
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.label1)
			Me.groupBox3.Controls.Add(Me.panel1)
			Me.groupBox3.Controls.Add(Me.pictureBox5)
			Me.groupBox3.Controls.Add(Me.panel2)
			Me.groupBox3.Controls.Add(Me.pictureBox3)
			Me.groupBox3.Controls.Add(Me.pictureBox4)
			Me.groupBox3.Controls.Add(Me.pictureBox7)
			Me.groupBox3.Controls.Add(Me.pictureBox2)
			Me.groupBox3.Controls.Add(Me.pictureBox6)
			Me.groupBox3.Controls.Add(Me.pictureBox1)
			Me.groupBox3.Location = New System.Drawing.Point(355, 21)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(259, 86)
			Me.groupBox3.TabIndex = 20
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Styles"
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(59, 69)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(176, 13)
			Me.label1.TabIndex = 13
			Me.label1.Text = "GridVisualStyles.Metro"
			Me.label1.Visible = False
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.DimGray
			Me.panel1.Location = New System.Drawing.Point(190, 60)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(26, 4)
			Me.panel1.TabIndex = 12
			' 
			' pictureBox5
			' 
			Me.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox5.Image = (CType(resources.GetObject("pictureBox5.Image"), System.Drawing.Image))
			Me.pictureBox5.Location = New System.Drawing.Point(151, 24)
			Me.pictureBox5.Name = "pictureBox5"
			Me.pictureBox5.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox5.TabIndex = 4
			Me.pictureBox5.TabStop = False
'			Me.pictureBox5.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox5.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox5.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.Orange
			Me.panel2.Location = New System.Drawing.Point(13, 60)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(26, 4)
			Me.panel2.TabIndex = 7
			Me.panel2.Visible = False
			' 
			' pictureBox3
			' 
			Me.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox3.Image = (CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image))
			Me.pictureBox3.Location = New System.Drawing.Point(81, 24)
			Me.pictureBox3.Name = "pictureBox3"
			Me.pictureBox3.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox3.TabIndex = 2
			Me.pictureBox3.TabStop = False
'			Me.pictureBox3.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox3.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox3.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' pictureBox4
			' 
			Me.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox4.Image = (CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image))
			Me.pictureBox4.Location = New System.Drawing.Point(116, 24)
			Me.pictureBox4.Name = "pictureBox4"
			Me.pictureBox4.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox4.TabIndex = 3
			Me.pictureBox4.TabStop = False
'			Me.pictureBox4.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox4.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox4.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' pictureBox7
			' 
			Me.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox7.Image = (CType(resources.GetObject("pictureBox7.Image"), System.Drawing.Image))
			Me.pictureBox7.Location = New System.Drawing.Point(221, 24)
			Me.pictureBox7.Name = "pictureBox7"
			Me.pictureBox7.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox7.TabIndex = 4
			Me.pictureBox7.TabStop = False
'			Me.pictureBox7.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox7.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox7.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' pictureBox2
			' 
			Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox2.Image = (CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image))
			Me.pictureBox2.Location = New System.Drawing.Point(46, 24)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox2.TabIndex = 1
			Me.pictureBox2.TabStop = False
'			Me.pictureBox2.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox2.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox2.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' pictureBox6
			' 
			Me.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox6.Image = (CType(resources.GetObject("pictureBox6.Image"), System.Drawing.Image))
			Me.pictureBox6.Location = New System.Drawing.Point(186, 24)
			Me.pictureBox6.Name = "pictureBox6"
			Me.pictureBox6.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox6.TabIndex = 5
			Me.pictureBox6.TabStop = False
'			Me.pictureBox6.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox6.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox6.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox1.Image = (CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image))
			Me.pictureBox1.Location = New System.Drawing.Point(11, 24)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
'			Me.pictureBox1.MouseLeave += New System.EventHandler(Me.pictureBox1_MouseLeave)
'			Me.pictureBox1.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox1_MouseClick)
'			Me.pictureBox1.MouseHover += New System.EventHandler(Me.pictureBox1_MouseHover)
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.label6)
			Me.groupBox2.Controls.Add(Me.label5)
			Me.groupBox2.Controls.Add(Me.label4)
			Me.groupBox2.Controls.Add(Me.label3)
			Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox2.ForeColor = System.Drawing.Color.Black
			Me.groupBox2.Location = New System.Drawing.Point(355, 121)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(259, 89)
			Me.groupBox2.TabIndex = 19
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Applied Changes"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
			Me.label6.Location = New System.Drawing.Point(133, 32)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(91, 15)
			Me.label6.TabIndex = 10
			Me.label6.Text = "Office2010Black"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.ForeColor = System.Drawing.Color.DimGray
			Me.label5.Location = New System.Drawing.Point(23, 32)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(101, 15)
			Me.label5.TabIndex = 9
			Me.label5.Text = "Active Style          :"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
			Me.label4.Location = New System.Drawing.Point(132, 56)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(91, 15)
			Me.label4.TabIndex = 8
			Me.label4.Text = "Office2010Black"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.ForeColor = System.Drawing.Color.DimGray
			Me.label3.Location = New System.Drawing.Point(23, 56)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(100, 15)
			Me.label3.TabIndex = 7
			Me.label3.Text = "Active Scrollbars :"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(629, 510)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.groupBox3)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "Form1"
			Me.Text = "EnhancedVisualStyleInGDBG_Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox3.ResumeLayout(False)
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label8 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private label1 As System.Windows.Forms.Label
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents pictureBox5 As System.Windows.Forms.PictureBox
		Private panel2 As System.Windows.Forms.Panel
		Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox4 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox7 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox6 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private label6 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
	End Class
End Namespace


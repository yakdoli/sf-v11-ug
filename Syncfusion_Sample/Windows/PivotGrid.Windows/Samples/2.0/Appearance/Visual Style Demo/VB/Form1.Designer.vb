Imports Microsoft.VisualBasic
Imports System
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Namespace PivotGridDemo
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.pivotGridControl1 = New Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(Me.components)
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.Metro = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.Office2010Silver = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.Office2010Black = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.Office2010Blue = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.Office2007Silver = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.Office2007Black = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.Office2007Blue = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.groupBox2.SuspendLayout()
            CType(Me.Metro, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Office2010Silver, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Office2010Black, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Office2010Blue, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Office2007Silver, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Office2007Black, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Office2007Blue, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.AllowFiltering = True
            Me.pivotGridControl1.AllowSorting = True
            Me.pivotGridControl1.DeferLayoutUpdate = False
            Me.pivotGridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.pivotGridControl1.Location = New System.Drawing.Point(12, 16)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.ShowGrandTotals = True
            Me.pivotGridControl1.ShowGroupBar = False
            Me.pivotGridControl1.ShowSubTotals = True
            Me.pivotGridControl1.Size = New System.Drawing.Size(686, 461)
            Me.pivotGridControl1.TabIndex = 0
            Me.pivotGridControl1.Text = "pivotGridControl1"
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.Metro)
            Me.groupBox2.Controls.Add(Me.Office2010Silver)
            Me.groupBox2.Controls.Add(Me.Office2010Black)
            Me.groupBox2.Controls.Add(Me.Office2010Blue)
            Me.groupBox2.Controls.Add(Me.Office2007Silver)
            Me.groupBox2.Controls.Add(Me.Office2007Black)
            Me.groupBox2.Controls.Add(Me.Office2007Blue)
            Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.groupBox2.ForeColor = System.Drawing.Color.DimGray
            Me.groupBox2.Location = New System.Drawing.Point(712, 7)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(177, 270)
            Me.groupBox2.TabIndex = 3
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "VisualStyle"
            '
            'Metro
            '
            Me.Metro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Metro.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Metro.Checked = True
            Me.Metro.DrawFocusRectangle = False
            Me.Metro.Location = New System.Drawing.Point(25, 236)
            Me.Metro.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Metro.Name = "Metro"
            Me.Metro.Size = New System.Drawing.Size(125, 22)
            Me.Metro.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.Metro.TabIndex = 6
            Me.Metro.Text = "Metro"
            Me.Metro.ThemesEnabled = False
            '
            'Office2010Silver
            '
            Me.Office2010Silver.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Office2010Silver.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Office2010Silver.DrawFocusRectangle = False
            Me.Office2010Silver.Location = New System.Drawing.Point(25, 204)
            Me.Office2010Silver.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Office2010Silver.Name = "Office2010Silver"
            Me.Office2010Silver.Size = New System.Drawing.Size(125, 22)
            Me.Office2010Silver.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.Office2010Silver.TabIndex = 5
            Me.Office2010Silver.TabStop = False
            Me.Office2010Silver.Text = "Office2010Silver"
            Me.Office2010Silver.ThemesEnabled = False
            '
            'Office2010Black
            '
            Me.Office2010Black.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Office2010Black.DrawFocusRectangle = False
            Me.Office2010Black.Location = New System.Drawing.Point(25, 165)
            Me.Office2010Black.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Office2010Black.Name = "Office2010Black"
            Me.Office2010Black.Size = New System.Drawing.Size(125, 28)
            Me.Office2010Black.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.Office2010Black.TabIndex = 4
            Me.Office2010Black.TabStop = False
            Me.Office2010Black.Text = "Office2010Black"
            Me.Office2010Black.ThemesEnabled = False
            '
            'Office2010Blue
            '
            Me.Office2010Blue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Office2010Blue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Office2010Blue.DrawFocusRectangle = False
            Me.Office2010Blue.Location = New System.Drawing.Point(25, 131)
            Me.Office2010Blue.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Office2010Blue.Name = "Office2010Blue"
            Me.Office2010Blue.Size = New System.Drawing.Size(119, 21)
            Me.Office2010Blue.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.Office2010Blue.TabIndex = 3
            Me.Office2010Blue.TabStop = False
            Me.Office2010Blue.Text = "Office2010Blue"
            Me.Office2010Blue.ThemesEnabled = False
            '
            'Office2007Silver
            '
            Me.Office2007Silver.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Office2007Silver.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Office2007Silver.DrawFocusRectangle = False
            Me.Office2007Silver.Location = New System.Drawing.Point(25, 97)
            Me.Office2007Silver.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Office2007Silver.Name = "Office2007Silver"
            Me.Office2007Silver.Size = New System.Drawing.Size(125, 19)
            Me.Office2007Silver.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.Office2007Silver.TabIndex = 2
            Me.Office2007Silver.TabStop = False
            Me.Office2007Silver.Text = "Office2007Silver"
            Me.Office2007Silver.ThemesEnabled = False
            '
            'Office2007Black
            '
            Me.Office2007Black.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Office2007Black.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Office2007Black.DrawFocusRectangle = False
            Me.Office2007Black.Location = New System.Drawing.Point(24, 63)
            Me.Office2007Black.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Office2007Black.Name = "Office2007Black"
            Me.Office2007Black.Size = New System.Drawing.Size(123, 18)
            Me.Office2007Black.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.Office2007Black.TabIndex = 1
            Me.Office2007Black.TabStop = False
            Me.Office2007Black.Text = "Office2007Black"
            Me.Office2007Black.ThemesEnabled = False
            '
            'Office2007Blue
            '
            Me.Office2007Blue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Office2007Blue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Office2007Blue.DrawFocusRectangle = False
            Me.Office2007Blue.Location = New System.Drawing.Point(24, 28)
            Me.Office2007Blue.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Office2007Blue.Name = "Office2007Blue"
            Me.Office2007Blue.Size = New System.Drawing.Size(123, 21)
            Me.Office2007Blue.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.Office2007Blue.TabIndex = 0
            Me.Office2007Blue.TabStop = False
            Me.Office2007Blue.Text = "Office2007Blue"
            Me.Office2007Blue.ThemesEnabled = False
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(900, 489)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.DropShadow = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Me.BackColor = Drawing.Color.White
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "PivotGridVisualStyleDemo"
            Me.groupBox2.ResumeLayout(False)
            CType(Me.Metro, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Office2010Silver, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Office2010Black, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Office2010Blue, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Office2007Silver, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Office2007Black, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Office2007Blue, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private pivotGridControl1 As Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private WithEvents Office2010Silver As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents Office2010Black As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents Office2010Blue As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents Office2007Silver As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents Office2007Black As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents Office2007Blue As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents Metro As Syncfusion.Windows.Forms.Tools.RadioButtonAdv

	End Class
End Namespace


Imports Microsoft.VisualBasic
Imports System
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Namespace ToolTipDemo
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
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.checkBox2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.pivotGridControl1 = New Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(Me.components)
            Me.groupBox1.SuspendLayout()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'groupBox1
            '
            Me.groupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.groupBox1.Controls.Add(Me.checkBox2)
            Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.groupBox1.ForeColor = System.Drawing.Color.DimGray
            Me.groupBox1.Location = New System.Drawing.Point(790, 13)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(224, 60)
            Me.groupBox1.TabIndex = 1
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "HyperLink Cell"
            '
            'checkBox2
            '
            Me.checkBox2.DrawFocusRectangle = False
            Me.checkBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.checkBox2.ForeColor = System.Drawing.Color.DimGray
            Me.checkBox2.Location = New System.Drawing.Point(38, 22)
            Me.checkBox2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(164, 28)
            Me.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox2.TabIndex = 3
            Me.checkBox2.Text = "Enable Link in Cells"
            Me.checkBox2.ThemesEnabled = False
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.AllowFiltering = True
            Me.pivotGridControl1.AllowSorting = True
            Me.pivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pivotGridControl1.DeferLayoutUpdate = False
            Me.pivotGridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.pivotGridControl1.Location = New System.Drawing.Point(6, 18)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.ShowGrandTotals = True
            Me.pivotGridControl1.ShowGroupBar = False
            Me.pivotGridControl1.ShowSubTotals = True
            Me.pivotGridControl1.Size = New System.Drawing.Size(773, 484)
            Me.pivotGridControl1.TabIndex = 0
            Me.pivotGridControl1.Text = "pivotGridControl1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1026, 507)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.BackColor = Drawing.Color.White
            Me.DropShadow = True
            Me.MaximizeBox = False
			Me.MinimizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Hyperlink Demo"
            Me.groupBox1.ResumeLayout(False)
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private pivotGridControl1 As Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents checkBox2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv

	End Class
End Namespace


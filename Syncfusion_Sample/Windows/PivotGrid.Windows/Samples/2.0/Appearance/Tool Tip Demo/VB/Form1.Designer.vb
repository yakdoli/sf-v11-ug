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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.chkEnable = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.chkSummary = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.chkColHeader = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.chkSumHeader = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.chkRowHeader = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.chkValue = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.pivotGridControl1 = New Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(Me.components)
			Me.groupBox1.SuspendLayout()
			CType(Me.chkEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox2.SuspendLayout()
			CType(Me.chkSummary, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkColHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkSumHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkRowHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkValue, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.groupBox1.Controls.Add(Me.chkEnable)
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold)
			Me.groupBox1.ForeColor = System.Drawing.Color.DimGray
			Me.groupBox1.Location = New System.Drawing.Point(781, 12)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(200, 60)
			Me.groupBox1.TabIndex = 1
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "ToolTip Properties"
			' 
			' chkEnable
			' 
			Me.chkEnable.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chkEnable.DrawFocusRectangle = False
			Me.chkEnable.Location = New System.Drawing.Point(21, 21)
			Me.chkEnable.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.chkEnable.Name = "chkEnable"
			Me.chkEnable.Size = New System.Drawing.Size(173, 28)
			Me.chkEnable.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.chkEnable.TabIndex = 9
			Me.chkEnable.Text = "Enable ToolTip"
			Me.chkEnable.ThemesEnabled = False
'			Me.chkEnable.CheckStateChanged += New System.EventHandler(Me.chkEnable_CheckStateChanged)
			' 
			' groupBox2
			' 
			Me.groupBox2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.groupBox2.Controls.Add(Me.chkSummary)
			Me.groupBox2.Controls.Add(Me.chkColHeader)
			Me.groupBox2.Controls.Add(Me.chkSumHeader)
			Me.groupBox2.Controls.Add(Me.chkRowHeader)
			Me.groupBox2.Controls.Add(Me.chkValue)
			Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold)
			Me.groupBox2.ForeColor = System.Drawing.Color.DimGray
			Me.groupBox2.Location = New System.Drawing.Point(781, 98)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(200, 227)
			Me.groupBox2.TabIndex = 2
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Enable ToolTip"
			' 
			' chkSummary
			' 
			Me.chkSummary.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chkSummary.DrawFocusRectangle = False
			Me.chkSummary.Location = New System.Drawing.Point(21, 166)
			Me.chkSummary.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.chkSummary.Name = "chkSummary"
			Me.chkSummary.Size = New System.Drawing.Size(173, 28)
			Me.chkSummary.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.chkSummary.TabIndex = 8
			Me.chkSummary.Text = "Summary Cell"
			Me.chkSummary.ThemesEnabled = False
			' 
			' chkColHeader
			' 
			Me.chkColHeader.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chkColHeader.DrawFocusRectangle = False
			Me.chkColHeader.Location = New System.Drawing.Point(21, 35)
			Me.chkColHeader.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.chkColHeader.Name = "chkColHeader"
			Me.chkColHeader.Size = New System.Drawing.Size(162, 28)
			Me.chkColHeader.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.chkColHeader.TabIndex = 4
			Me.chkColHeader.Text = "ColumnHeader"
			Me.chkColHeader.ThemesEnabled = False
			' 
			' chkSumHeader
			' 
			Me.chkSumHeader.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chkSumHeader.DrawFocusRectangle = False
			Me.chkSumHeader.Location = New System.Drawing.Point(21, 133)
			Me.chkSumHeader.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.chkSumHeader.Name = "chkSumHeader"
			Me.chkSumHeader.Size = New System.Drawing.Size(173, 28)
			Me.chkSumHeader.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.chkSumHeader.TabIndex = 7
			Me.chkSumHeader.Text = "Summary Header"
			Me.chkSumHeader.ThemesEnabled = False
			' 
			' chkRowHeader
			' 
			Me.chkRowHeader.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chkRowHeader.DrawFocusRectangle = False
			Me.chkRowHeader.Location = New System.Drawing.Point(21, 66)
			Me.chkRowHeader.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.chkRowHeader.Name = "chkRowHeader"
			Me.chkRowHeader.Size = New System.Drawing.Size(173, 28)
			Me.chkRowHeader.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.chkRowHeader.TabIndex = 5
			Me.chkRowHeader.Text = "RowHeader"
			Me.chkRowHeader.ThemesEnabled = False
			' 
			' chkValue
			' 
			Me.chkValue.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chkValue.DrawFocusRectangle = False
			Me.chkValue.Location = New System.Drawing.Point(21, 99)
			Me.chkValue.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.chkValue.Name = "chkValue"
			Me.chkValue.Size = New System.Drawing.Size(173, 28)
			Me.chkValue.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.chkValue.TabIndex = 6
			Me.chkValue.Text = "Value Cell"
			Me.chkValue.ThemesEnabled = False
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.AllowFiltering = True
			Me.pivotGridControl1.AllowSorting = True
			Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.DeferLayoutUpdate = False
			Me.pivotGridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.pivotGridControl1.Location = New System.Drawing.Point(12, 12)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.ShowGrandTotals = True
			Me.pivotGridControl1.ShowGroupBar = False
			Me.pivotGridControl1.ShowSubTotals = True
			Me.pivotGridControl1.Size = New System.Drawing.Size(746, 465)
			Me.pivotGridControl1.TabIndex = 0
			Me.pivotGridControl1.Text = "pivotGridControl1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(993, 489)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.DropShadow = True
            Me.MaximizeBox = False
			Me.MinimizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "ToolTipDemo"
			Me.groupBox1.ResumeLayout(False)
			CType(Me.chkEnable, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox2.ResumeLayout(False)
			CType(Me.chkSummary, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkColHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkSumHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkRowHeader, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkValue, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private chkValue As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private chkRowHeader As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private chkColHeader As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private chkSummary As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private chkSumHeader As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents chkEnable As Syncfusion.Windows.Forms.Tools.CheckBoxAdv

	End Class
End Namespace


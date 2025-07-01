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
            Me.pivotGridControl1 = New Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(Me.components)
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.AllowFiltering = True
            Me.pivotGridControl1.AllowSorting = True
            Me.pivotGridControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pivotGridControl1.DeferLayoutUpdate = False
            Me.pivotGridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.pivotGridControl1.Location = New System.Drawing.Point(12, 15)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.ShowGrandTotals = True
            Me.pivotGridControl1.ShowGroupBar = False
            Me.pivotGridControl1.ShowPivotTableFieldList = False
            Me.pivotGridControl1.ShowSubTotals = True
            Me.pivotGridControl1.Size = New System.Drawing.Size(758, 467)
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
            Me.ClientSize = New System.Drawing.Size(782, 494)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.DropShadow = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Pivot Grid Demo"
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private pivotGridControl1 As Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl

	End Class
End Namespace


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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.pivotGridControl1 = New Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl(Me.components)
			Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.SuspendLayout()
            Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch
            End Try
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.AllowFiltering = True
            Me.pivotGridControl1.AllowSorting = True
            Me.pivotGridControl1.DeferLayoutUpdate = False
            Me.pivotGridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.pivotGridControl1.Location = New System.Drawing.Point(12, 12)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.ShowGrandTotals = True
            Me.pivotGridControl1.ShowGroupBar = False
            Me.pivotGridControl1.ShowSubTotals = True
            Me.pivotGridControl1.Size = New System.Drawing.Size(758, 465)
            Me.pivotGridControl1.TabIndex = 0
            Me.pivotGridControl1.Text = "pivotGridControl1"
            ' 
            ' button1
            ' 
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
            Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(278, 483)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(176, 23)
            Me.button1.TabIndex = 2
            Me.button1.Text = "Print Pivot Grid"
            Me.button1.UseVisualStyle = True
            '			Me.button1.Click += New System.EventHandler(Me.button1_Click_1)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.ClientSize = New System.Drawing.Size(785, 514)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.DropShadow = True
            Me.MaximizeBox = False
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Pivot Grid Demo"
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private Function GetIconFile(ByVal bitmapName As String) As String
            For n As Integer = 0 To 9
                If System.IO.File.Exists(bitmapName) Then
                    Return bitmapName
                End If

                bitmapName = "..\" & bitmapName
            Next n

            Return bitmapName
        End Function
        Private pivotGridControl1 As Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl
        Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv

    End Class
End Namespace


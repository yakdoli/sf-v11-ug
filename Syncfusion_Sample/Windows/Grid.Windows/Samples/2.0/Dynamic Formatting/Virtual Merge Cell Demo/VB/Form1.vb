Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Tools
Namespace VirtualMergeCell
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		#Region "Private Members"
		Private gridControl1 As CustomGridControl
		Private WithEvents centerText As CheckBoxAdv
		Private panel1 As System.Windows.Forms.Panel
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		#End Region

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call


			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

'			#Region "Initial Settings"

			Me.gridControl1.Initialize()

			Dim row As Integer = 2
			Do While row <> 13
				Me.gridControl1.Model(row, 5).Text = "Test"
				row += 1
			Loop

			Me.gridControl1.Refresh()
			gridControl1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.Model.Options.GridVisualStyles = GridVisualStyles.Metro
'			#End Region
		End Sub

		#Region "Form Handlers"
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.centerText = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.gridControl1 = New VirtualMergeCell.CustomGridControl()
			CType(Me.centerText, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' centerText
			' 
			Me.centerText.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.centerText.Checked = True
			Me.centerText.CheckState = System.Windows.Forms.CheckState.Checked
			Me.centerText.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.centerText.Location = New System.Drawing.Point(29, 323)
			Me.centerText.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.centerText.Name = "centerText"
			Me.centerText.Size = New System.Drawing.Size(480, 20)
			Me.centerText.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.centerText.TabIndex = 2
			Me.centerText.Text = "Center text in first 3 columns of visible parts of partially visible cells"
			Me.centerText.ThemesEnabled = False
'			Me.centerText.CheckStateChanged += New System.EventHandler(Me.centerText_CheckStateChanged)
			' 
			' panel1
			' 
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(664, 366)
			Me.panel1.TabIndex = 3
			' 
			' gridControl1
			' 
			Me.gridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gridControl1.CenterTextInVisibleCellPart = False
			Me.gridControl1.DefaultColWidth = 100
			Me.gridControl1.DefaultRowHeight = 18
			Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridControl1.HorizontalThumbTrack = True
			Me.gridControl1.Location = New System.Drawing.Point(29, 33)
			Me.gridControl1.MetroScrollBars = True
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(606, 281)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.Text = "gridControl1"
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.VerticalThumbTrack = True
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(664, 366)
			Me.Controls.Add(Me.centerText)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panel1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Virtual Merge Cell Demo"
			CType(Me.centerText, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
        <STAThread()> _
  Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
            Application.EnableVisualStyles()
#End If
            Application.Run(New Form1())
        End Sub
		#End Region

		#Region "Event Hanlders"
		Private Sub centerText_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles centerText.CheckStateChanged
			Me.gridControl1.CenterTextInVisibleCellPart = Me.centerText.Checked
		End Sub

		Private Sub gridControl1_CurrentCellMoved(ByVal sender As Object, ByVal e As GridCurrentCellMovedEventArgs)
			gridControl1.EndUpdate()
			gridControl1.Refresh()
		End Sub
		#End Region


	End Class
End Namespace

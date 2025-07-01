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

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms

Namespace ScrollBars
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		#Region "Private Members"
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private vScrollBar1 As System.Windows.Forms.VScrollBar
		Private hScrollBar1 As System.Windows.Forms.HScrollBar
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

'			#Region "Scrollbars"
			gridControl1.HScrollBehavior = GridScrollbarMode.Shared
			gridControl1.VScrollBehavior = GridScrollbarMode.Shared
			gridControl1.UseSharedScrollBars = True
			gridControl1.VScrollBar.InnerScrollBar = vScrollBar1
			gridControl1.HScrollBar.InnerScrollBar = hScrollBar1
			Me.gridControl1.DefaultRowHeight = 18
			Me.gridControl1.DefaultColWidth = 70
'			#End Region

			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
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
			Dim gridCellInfo1 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.vScrollBar1 = New System.Windows.Forms.VScrollBar()
			Me.hScrollBar1 = New System.Windows.Forms.HScrollBar()
			Me.panel1 = New System.Windows.Forms.Panel()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gridControl1.DefaultRowHeight = 20
			Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			gridCellInfo1.Col = -1
			gridCellInfo1.Row = -1
			gridCellInfo1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
			gridCellInfo1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() { gridCellInfo1})
			Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridControl1.HorizontalScrollTips = True
			Me.gridControl1.HorizontalThumbTrack = True
			Me.gridControl1.HScrollBehavior = Syncfusion.Windows.Forms.Grid.GridScrollbarMode.Shared
			Me.gridControl1.Location = New System.Drawing.Point(40, 40)
			Me.gridControl1.MetroScrollBars = True
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RowCount = 100
			Me.gridControl1.Size = New System.Drawing.Size(527, 256)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.Text = "gridControl1"
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.VerticalScrollTips = True
			Me.gridControl1.VerticalThumbTrack = True
			Me.gridControl1.VScrollBehavior = Syncfusion.Windows.Forms.Grid.GridScrollbarMode.Shared
			' 
			' vScrollBar1
			' 
			Me.vScrollBar1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.vScrollBar1.Location = New System.Drawing.Point(576, 88)
			Me.vScrollBar1.Name = "vScrollBar1"
			Me.vScrollBar1.Size = New System.Drawing.Size(16, 184)
			Me.vScrollBar1.TabIndex = 1
			' 
			' hScrollBar1
			' 
			Me.hScrollBar1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.hScrollBar1.Location = New System.Drawing.Point(112, 304)
			Me.hScrollBar1.Name = "hScrollBar1"
			Me.hScrollBar1.Size = New System.Drawing.Size(415, 16)
			Me.hScrollBar1.TabIndex = 2
			' 
			' panel1
			' 
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(608, 334)
			Me.panel1.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(608, 334)
			Me.Controls.Add(Me.hScrollBar1)
			Me.Controls.Add(Me.vScrollBar1)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panel1)
			Me.DropShadow = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.Text = "Scroll Bar Demo"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
        <STAThread()> _
  Public Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
            Application.EnableVisualStyles()
#End If

            Application.Run(New Form1())
        End Sub
		#End Region
	End Class
End Namespace

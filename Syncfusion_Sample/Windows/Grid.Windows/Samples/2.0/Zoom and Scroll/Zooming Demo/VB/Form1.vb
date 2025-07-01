Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2011"
' Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Drawing
Imports Syncfusion.Styles
Imports Syncfusion.GridHelperClasses
Imports System.IO
Imports System.Data.SqlClient
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace ZoomGrid1
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		#Region "Private Members"
		Private WithEvents trackBar1 As TrackBar
		Private WithEvents comboBox1 As ComboBoxAdv
		Private WithEvents checkBox1 As CheckBoxAdv
		Private label2 As Label
		Private gridControl1 As GridControl
		Private groupBox1 As GroupBox
		Private groupBox3 As GroupBox
		Private groupBox2 As GroupBox
		Private label4 As Label
		Private label3 As Label

		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private zoom As ZoomGrid
		#End Region

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

'			#Region "Initial Settings"
			Dim dataSet As New DataSet()
			dataSet.ReadXml(GetFile("Datasource.xml"))

			Me.gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, 20, 9), dataSet.Tables(0))
			Me.gridControl1.PopulateHeaders(GridRangeInfo.Cells(0, 1, Me.gridControl1.RowCount, Me.gridControl1.ColCount), dataSet.Tables(0))

			zoom = New ZoomGrid(Me.gridControl1)
			ZoomGrid.ZoomGridControlCell = True

			Me.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table())
'			#End Region
		End Sub

		#Region "Form Handlers"
		Private Function GetFile(ByVal fileName As String) As String
			Dim dataFileName As String = "" & fileName
			For n As Integer = 0 To 11
				If System.IO.File.Exists(dataFileName) Then
					Return New FileInfo(dataFileName).FullName
				End If
				dataFileName = "..\" & dataFileName
			Next n
			Return dataFileName
		End Function

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
            Dim GridRangeStyle1 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle2 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Me.trackBar1 = New System.Windows.Forms.TrackBar
            Me.comboBox1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label2 = New System.Windows.Forms.Label
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.groupBox3 = New System.Windows.Forms.GroupBox
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.label4 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'trackBar1
            '
            Me.trackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.trackBar1.AutoSize = False
            Me.trackBar1.BackColor = System.Drawing.Color.White
            Me.trackBar1.Location = New System.Drawing.Point(99, 83)
            Me.trackBar1.Maximum = 250
            Me.trackBar1.Minimum = 20
            Me.trackBar1.Name = "trackBar1"
            Me.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.trackBar1.Size = New System.Drawing.Size(96, 28)
            Me.trackBar1.TabIndex = 12
            Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None
            Me.trackBar1.Value = 100
            '
            'comboBox1
            '
            Me.comboBox1.BackColor = System.Drawing.Color.White
            Me.comboBox1.Items.AddRange(New Object() {"50", "75", "100", "125"})
            Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "50"))
            Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "75"))
            Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "100"))
            Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "125"))
            Me.comboBox1.Location = New System.Drawing.Point(97, 28)
            Me.comboBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(96, 21)
            Me.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
            Me.comboBox1.TabIndex = 14
            Me.comboBox1.Text = "100"
            '
            'checkBox1
            '
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.DrawFocusRectangle = False
            Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.ForeColor = System.Drawing.Color.Black
            Me.checkBox1.Location = New System.Drawing.Point(65, 21)
            Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(82, 17)
            Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox1.TabIndex = 11
            Me.checkBox1.Text = "Zoom Cell"
            Me.checkBox1.ThemesEnabled = False
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.White
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.DimGray
            Me.label2.Location = New System.Drawing.Point(22, 267)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(210, 65)
            Me.label2.TabIndex = 15
            Me.label2.Text = "Click a cell to view in zoomed state. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use the above slider and dropdown to zo" & _
                "om the grid in different values."
            '
            'gridControl1
            '
            Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridControl1.ColCount = 5
            Me.gridControl1.DefaultColWidth = 85
            Me.gridControl1.DefaultRowHeight = 20
            Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.HorizontalThumbTrack = True
            Me.gridControl1.Location = New System.Drawing.Point(12, 17)
            Me.gridControl1.MetroScrollBars = True
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.gridControl1.Properties.MarkColHeader = False
            Me.gridControl1.Properties.MarkRowHeader = False
            GridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle1.StyleInfo.Font.Bold = False
            GridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle1.StyleInfo.Font.Italic = False
            GridRangeStyle1.StyleInfo.Font.Size = 8.25!
            GridRangeStyle1.StyleInfo.Font.Strikeout = False
            GridRangeStyle1.StyleInfo.Font.Underline = False
            GridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle2.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle2.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle2.StyleInfo.Font.Bold = False
            GridRangeStyle2.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle2.StyleInfo.Font.Italic = False
            GridRangeStyle2.StyleInfo.Font.Size = 8.25!
            GridRangeStyle2.StyleInfo.Font.Strikeout = False
            GridRangeStyle2.StyleInfo.Font.Underline = False
            GridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle2.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle1, GridRangeStyle2})
            Me.gridControl1.RowCount = 20
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(476, 347)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 16
            Me.gridControl1.Text = "gridControl1"
            Me.gridControl1.ThemesEnabled = True
            Me.gridControl1.UseRightToLeftCompatibleTextBox = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.groupBox3)
            Me.groupBox1.Controls.Add(Me.groupBox2)
            Me.groupBox1.Location = New System.Drawing.Point(502, 17)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(254, 347)
            Me.groupBox1.TabIndex = 17
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Zooming Options"
            '
            'groupBox3
            '
            Me.groupBox3.Controls.Add(Me.checkBox1)
            Me.groupBox3.Location = New System.Drawing.Point(25, 190)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(207, 57)
            Me.groupBox3.TabIndex = 1
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Cell Level"
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.label4)
            Me.groupBox2.Controls.Add(Me.label3)
            Me.groupBox2.Controls.Add(Me.comboBox1)
            Me.groupBox2.Controls.Add(Me.trackBar1)
            Me.groupBox2.Location = New System.Drawing.Point(25, 33)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(207, 129)
            Me.groupBox2.TabIndex = 0
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Grid Level"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(6, 83)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(87, 13)
            Me.label4.TabIndex = 16
            Me.label4.Text = "Zoom Frequency"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(15, 36)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(63, 13)
            Me.label3.TabIndex = 15
            Me.label3.Text = "Zoom Level"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(768, 377)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.gridControl1)
            Me.DropShadow = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
            Me.Text = "Zooming Demo"
            CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox3.ResumeLayout(False)
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub


		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
        <STAThread()> _
  Shared Sub Main()
            Application.Run(New Form1())
        End Sub
		#End Region

		#Region "Event Handlers"

        Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar1.ValueChanged
            If zoom IsNot Nothing Then
                zoom.zoomGrid(Me.trackBar1.Value.ToString())
                Me.comboBox1.Text = Me.trackBar1.Value.ToString()
                If Me.trackBar1.Value = 100 Then
                    Me.checkBox1.Checked = True
                Else
                    Me.checkBox1.Checked = False
                End If
            End If
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
            If zoom IsNot Nothing Then
                zoom.zoomGrid(Me.comboBox1.SelectedItem.ToString())
                If Me.comboBox1.SelectedItem.ToString() = "100" Then
                    Me.checkBox1.Checked = True
                Else
                    Me.checkBox1.Checked = False
                End If
            End If
        End Sub


        Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox1.CheckedChanged
            ZoomGrid.ZoomGridControlCell = Me.checkBox1.Checked
            If Me.checkBox1.Checked Then
                Me.trackBar1.Value = 100
            End If
        End Sub
#End Region
    End Class
End Namespace

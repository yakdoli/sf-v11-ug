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

Namespace ZoomDataBoundGrid
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents trackBar1 As TrackBar
		Private label1 As Label
		Private WithEvents comboBox1 As ComboBox
		Private WithEvents checkBox1 As CheckBox
		Private gridDataBoundGrid1 As GridDataBoundGrid
		Private groupBox1 As GroupBox
		Private groupBox3 As GroupBox
		Private groupBox2 As GroupBox
		Private panel1 As Panel
		Private label2 As Label
		Private label3 As Label
		Private label4 As Label
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private zoom As ZoomGrid
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
            Try
                Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
                Me.Icon = ico
            Catch ex As Exception
            End Try
			Dim dataSet As New DataSet()
			dataSet.ReadXml(GetFile("Datasource.xml"))

			Me.gridDataBoundGrid1.DataSource = dataSet.Tables(0)

			zoom = New ZoomGrid(Me.gridDataBoundGrid1)
			ZoomGrid.ZoomGridDataBoundCell = True
		End Sub

		Private Function GetFile(ByVal fileName As String) As String
            Dim dataFileName As String = "Common\Data\Grid\" & fileName
			For n As Integer = 0 To 11
				If System.IO.File.Exists(dataFileName) Then
					Return New FileInfo(dataFileName).FullName
				End If
				dataFileName = "..\" & dataFileName
			Next n
			Return dataFileName
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
			Dim gridStyleInfo1 As New Syncfusion.Windows.Forms.Grid.GridStyleInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.trackBar1 = New System.Windows.Forms.TrackBar()
			Me.label1 = New System.Windows.Forms.Label()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.label2 = New System.Windows.Forms.Label()
			CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' trackBar1
			' 
			Me.trackBar1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.trackBar1.AutoSize = False
			Me.trackBar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(200))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(255))))))
			Me.trackBar1.Location = New System.Drawing.Point(93, 83)
			Me.trackBar1.Maximum = 250
			Me.trackBar1.Minimum = 20
			Me.trackBar1.Name = "trackBar1"
			Me.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.trackBar1.Size = New System.Drawing.Size(100, 28)
			Me.trackBar1.TabIndex = 12
			Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None
			Me.trackBar1.Value = 100
'			Me.trackBar1.ValueChanged += New System.EventHandler(Me.trackBar1_ValueChanged)
			' 
			' label1
			' 
			Me.label1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.label1.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(393, 263)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(41, 23)
			Me.label1.TabIndex = 13
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Items.AddRange(New Object() { "50", "75", "100", "125"})
			Me.comboBox1.Location = New System.Drawing.Point(94, 28)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(86, 21)
			Me.comboBox1.TabIndex = 14
			Me.comboBox1.Text = "100"
'			Me.comboBox1.SelectedIndexChanged += New System.EventHandler(Me.comboBox1_SelectedIndexChanged)
			' 
			' checkBox1
			' 
			Me.checkBox1.Checked = True
			Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox1.ForeColor = System.Drawing.Color.Black
			Me.checkBox1.Location = New System.Drawing.Point(59, 32)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(75, 24)
			Me.checkBox1.TabIndex = 11
			Me.checkBox1.Text = "Zoom Cell"
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged)
			' 
			' gridDataBoundGrid1
			' 
			Me.gridDataBoundGrid1.AllowDragSelectedCols = True
			Me.gridDataBoundGrid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2010
			Me.gridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2010Blue
			Me.gridDataBoundGrid1.Location = New System.Drawing.Point(0, 23)
			Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
			Me.gridDataBoundGrid1.OptimizeInsertRemoveCells = True
			Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
			Me.gridDataBoundGrid1.Size = New System.Drawing.Size(437, 266)
			Me.gridDataBoundGrid1.SmartSizeBox = False
			Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
			Me.gridDataBoundGrid1.TabIndex = 16
			gridStyleInfo1.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.LightBlue)
			gridStyleInfo1.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.LightBlue)
			gridStyleInfo1.TextColor = System.Drawing.Color.Gray
			Me.gridDataBoundGrid1.TableStyle = gridStyleInfo1
			Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
			Me.gridDataBoundGrid1.ThemesEnabled = True
			Me.gridDataBoundGrid1.UseListChangedEvent = True
			Me.gridDataBoundGrid1.UseRightToLeftCompatibleTextBox = True
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.groupBox3)
			Me.groupBox1.Controls.Add(Me.groupBox2)
			Me.groupBox1.Location = New System.Drawing.Point(439, 23)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(226, 266)
			Me.groupBox1.TabIndex = 17
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Zooming Options"
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.checkBox1)
			Me.groupBox3.Location = New System.Drawing.Point(13, 174)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(200, 76)
			Me.groupBox3.TabIndex = 1
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Cell Level"
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.label4)
			Me.groupBox2.Controls.Add(Me.label3)
			Me.groupBox2.Controls.Add(Me.comboBox1)
			Me.groupBox2.Controls.Add(Me.trackBar1)
			Me.groupBox2.Location = New System.Drawing.Point(13, 29)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(199, 128)
			Me.groupBox2.TabIndex = 0
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Grid Level"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(7, 83)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(87, 13)
			Me.label4.TabIndex = 16
			Me.label4.Text = "Zoom Frequency"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(16, 36)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(63, 13)
			Me.label3.TabIndex = 15
			Me.label3.Text = "Zoom Level"
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.Black
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(682, 23)
			Me.panel1.TabIndex = 18
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
			Me.label2.Location = New System.Drawing.Point(4, 4)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(346, 16)
			Me.label2.TabIndex = 0
			Me.label2.Text = "Demo Ilustrating Zooming Functionality in DataBoundGrid"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(200))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(255))))))
			Me.ClientSize = New System.Drawing.Size(665, 289)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.gridDataBoundGrid1)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Zooming Demo"
			CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>

		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			ZoomGrid.ZoomGridDataBoundCell = Me.checkBox1.Checked
			If Me.checkBox1.Checked Then
				Me.trackBar1.Value = 100
			End If
		End Sub

        Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar1.ValueChanged
            If zoom IsNot Nothing Then
                zoom.zoomGrid(Me.trackBar1.Value.ToString())
                Me.comboBox1.Text = Me.trackBar1.Value.ToString()
                Me.checkBox1.Checked = False
            End If
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
            If zoom IsNot Nothing Then
                zoom.zoomGrid(Me.comboBox1.SelectedItem.ToString())
                Me.checkBox1.Checked = False
            End If
        End Sub
        Private Function GetIconFile(ByVal bitmapName As String) As String
            For n As Integer = 0 To 9
                If System.IO.File.Exists(bitmapName) Then
                    Return bitmapName
                End If

                bitmapName = "..\" & bitmapName
            Next n

            Return bitmapName
        End Function
	End Class
End Namespace

#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO

	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents button2 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents button3 As Syncfusion.Windows.Forms.ButtonAdv
		Private dataset11 As GroupingEngineEventsTracer.Dataset1
		Private tracer As Tracer
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents checkBoxAdv1 As System.Windows.Forms.CheckBox
		Private components As IContainer
		Private panel2 As Panel
    Private eventTracer1 As EventTracer
		Private label1 As Label
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Public ReadOnly Shared connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")

		Public Sub New()
			InitializeComponent()

			Dim commandstring1 As String = "select * from Employees"
			Dim commandstring2 As String = "select * from Orders"

			Dim da1 As New SqlCeDataAdapter(commandstring1, connString)
			Dim da2 As New SqlCeDataAdapter(commandstring2, connString)
			Try
				da1.Fill(dataset11, "Employees")
				da2.Fill(dataset11, "Orders")
			Catch ex As SqlException
				ShowErrorMessage(ex)
			End Try

			Me.gridGroupingControl1.ShowGroupDropArea=True
			tracer = New Tracer(Me.gridGroupingControl1.Engine,eventTracer1)
			Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
			Me.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			eventTracer1.output.ControllerOptions = GridControllerOptions.All And ((Not GridControllerOptions.OleDataSource))

			eventTracer1.output.ResetVolatileData()
			eventTracer1.output.ColWidths(1) = 200
			eventTracer1.output.ColWidths(2) = 1000
			eventTracer1.output.GridVisualStyles = GridVisualStyles.Metro
			eventTracer1.output.DefaultGridBorderStyle = GridBorderStyle.None
			eventTracer1.output.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
			Dim style As GridStyleInfo = eventTracer1.output.BaseStylesMap("Header").StyleInfo
			style.TextColor = Color.MidnightBlue
			style.Font.Facename = "Verdana"

			eventTracer1.output.RowHeights(0) = 0
			eventTracer1.output.ColWidths(0) = 0
			eventTracer1.output.RowCount = 0
			eventTracer1.output.ColCount = 2
			eventTracer1.output.ListBoxSelectionMode = SelectionMode.One
			AddHandler eventTracer1.output.QueryCellInfo, AddressOf Output_QueryCellInfo
			AddHandler eventTracer1.output.CurrentCellStartEditing, AddressOf Output_CurrentCellStartEditing
		End Sub

		Private Shared Function FindFile(ByVal fileName As String) As String
			' Check both in parent folder and Parent\Data folders.
			Dim dataFileName As String = "Common\Data\" & fileName
			For n As Integer = 0 To 11
				If System.IO.File.Exists(fileName) Then
					Return New FileInfo(fileName).FullName
				End If
				If System.IO.File.Exists(dataFileName) Then
					Return New FileInfo(dataFileName).FullName
				End If
				fileName = "..\" & fileName
				dataFileName = "..\" & dataFileName
			Next n

			Return fileName
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

		Private Shared Sub ShowErrorMessage(ByVal ex As SqlException)
			If ex.Number = 11001 Then
				MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
			If ex.Number = 208 Then
				MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
			If ex.Number = 156 OrElse ex.Number = 102 Then
				MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If

		End Sub

		Private Sub Output_QueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
			e.Style.CellType = "Static"
		End Sub

	   Private Sub Output_CurrentCellStartEditing(ByVal sender As Object, ByVal e As CancelEventArgs)
			e.Cancel = True
	   End Sub

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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.dataset11 = New GroupingEngineEventsTracer.Dataset1()
			Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.button3 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.checkBoxAdv1 = New System.Windows.Forms.CheckBox()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.panel2 = New System.Windows.Forms.Panel()
        Me.eventTracer1 = New EventTracer()
			Me.label1 = New System.Windows.Forms.Label()
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			CType(Me.dataset11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel1.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.panel2.SuspendLayout()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataset11
			' 
			Me.dataset11.DataSetName = "Dataset1"
			Me.dataset11.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' button1
			' 
			Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.White
			Me.button1.Location = New System.Drawing.Point(12, 16)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(128, 23)
			Me.button1.TabIndex = 2
			Me.button1.Text = "Engine Events"
			Me.button1.UseVisualStyle = True
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button2.ForeColor = System.Drawing.Color.White
			Me.button2.Location = New System.Drawing.Point(12, 56)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(128, 23)
			Me.button2.TabIndex = 3
			Me.button2.Text = "Engine.Table Events"
			Me.button2.UseVisualStyle = True
			Me.button2.UseVisualStyleBackColor = False
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' button3
			' 
			Me.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button3.ForeColor = System.Drawing.Color.White
			Me.button3.Location = New System.Drawing.Point(12, 96)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(128, 23)
			Me.button3.TabIndex = 5
			Me.button3.Text = "Clear Output Window"
			Me.button3.UseVisualStyle = True
			Me.button3.UseVisualStyleBackColor = False
'			Me.button3.Click += New System.EventHandler(Me.button3_Click)
			' 
			' gradientPanel1
			' 
			Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel1.Controls.Add(Me.checkBoxAdv1)
			Me.gradientPanel1.Controls.Add(Me.button1)
			Me.gradientPanel1.Controls.Add(Me.button2)
			Me.gradientPanel1.Controls.Add(Me.button3)
			Me.gradientPanel1.Location = New System.Drawing.Point(624, 288)
			Me.gradientPanel1.Name = "gradientPanel1"
			Me.gradientPanel1.Size = New System.Drawing.Size(149, 176)
			Me.gradientPanel1.TabIndex = 6
			' 
			' checkBoxAdv1
			' 
			Me.checkBoxAdv1.BackColor = System.Drawing.Color.Transparent
			Me.checkBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxAdv1.ForeColor = System.Drawing.Color.DimGray
			Me.checkBoxAdv1.Location = New System.Drawing.Point(19, 135)
			Me.checkBoxAdv1.Name = "checkBoxAdv1"
			Me.checkBoxAdv1.Size = New System.Drawing.Size(110, 23)
			Me.checkBoxAdv1.TabIndex = 6
			Me.checkBoxAdv1.Text = "Disable Tracing"
			Me.checkBoxAdv1.UseVisualStyleBackColor = False
'			Me.checkBoxAdv1.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv1_CheckStateChanged)
'			Me.checkBoxAdv1.CheckedChanged += New System.EventHandler(Me.checkBoxAdv1_CheckedChanged)
			' 
			' panel1
			' 
			Me.panel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel1.Controls.Add(Me.gridGroupingControl1)
			Me.panel1.Location = New System.Drawing.Point(0, 12)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(773, 270)
			Me.panel1.TabIndex = 7
			' 
			' panel2
			' 
			Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.eventTracer1)
			Me.panel2.Controls.Add(Me.label1)
			Me.panel2.Location = New System.Drawing.Point(1, 288)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(617, 176)
			Me.panel2.TabIndex = 8
			' 
			' eventTracer1
			' 
			Me.eventTracer1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.eventTracer1.Enabled = False
			Me.eventTracer1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.eventTracer1.ForeColor = System.Drawing.Color.DimGray
			Me.eventTracer1.Location = New System.Drawing.Point(28, 21)
			Me.eventTracer1.Name = "eventTracer1"
			Me.eventTracer1.Size = New System.Drawing.Size(523, 150)
			Me.eventTracer1.TabIndex = 11
			' 
			' label1
			' 
			Me.label1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.DimGray
			Me.label1.Location = New System.Drawing.Point(6, 5)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(168, 16)
			Me.label1.TabIndex = 10
			Me.label1.Text = "Event Log"
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gridGroupingControl1.DataMember = "Employees"
			Me.gridGroupingControl1.DataSource = Me.dataset11
			Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridGroupingControl1.Location = New System.Drawing.Point(0, -1)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.Size = New System.Drawing.Size(771, 287)
			Me.gridGroupingControl1.TabIndex = 3
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.VersionInfo = "4.301.0.0"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.BorderThickness = 2
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
			Me.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(775, 469)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.gradientPanel1)
			Me.Controls.Add(Me.panel1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.Text = "Grouping Engine Events Demo"
			CType(Me.dataset11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel1.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Me.tracer.UnhookEngTableEvents()
			If Not Me.checkBoxAdv1.Checked Then
				Me.tracer.HookEngEvents()
			End If
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			Me.tracer.UnhookEngEvents()
			If Not Me.checkBoxAdv1.Checked Then
				Me.tracer.HookEngTableEvents()
			End If
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
			Me.eventTracer1.clear()
		End Sub

		Private Sub checkBoxAdv1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxAdv1.CheckStateChanged
			If Me.checkBoxAdv1.Checked Then
				Me.tracer.UnhookEngEvents()
				Me.tracer.UnhookEngTableEvents()
			End If
		End Sub

		Private Sub checkBoxAdv1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv1.CheckedChanged
			Me.eventTracer1.Enabled = Not checkBoxAdv1.Checked
		End Sub
	End Class


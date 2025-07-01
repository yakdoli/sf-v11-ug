#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO

Namespace TableControlEvents
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private dataset11 As TableControlEvents.Dataset1 = New Dataset1()
		Private eventTracer As EngineEventTracer
		Private label1 As System.Windows.Forms.Label
		Private components As IContainer
		Private groupBox1 As GroupBox
		Private WithEvents checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents button3 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents button2 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents button6 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents button4 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents button5 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents button7 As Syncfusion.Windows.Forms.ButtonAdv
		Private Output As ListBox
		Private gridGroupingControl1 As GridGroupingControl
		Public ReadOnly Shared connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
		Public Sub New()
			InitializeComponent()

			Dim commandstring1 As String = "select * from Categories"
			Dim commandstring2 As String = "select * from Products"

			Dim da1 As New SqlCeDataAdapter(commandstring1, connString)
			Dim da2 As New SqlCeDataAdapter(commandstring2, connString)
			Try
				da1.Fill(dataset11, "Categories")
				da2.Fill(dataset11, "Products")
			Catch ex As SqlException
				ShowErrorMessage(ex)
			End Try

			Dim eng As GridEngine=Me.gridGroupingControl1.Engine
			eventTracer = New EngineEventTracer(eng,Me.Output)
			Me.eventTracer.HookCurrentCellEvents()
			Me.gridGroupingControl1.DataMember = "Categories"
			Me.gridGroupingControl1.DataSource = Me.dataset11
			Me.gridGroupingControl1.ShowGroupDropArea=True
			Me.gridGroupingControl1.AddGroupDropArea("Categories")
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
			Me.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.button3 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.button6 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.button4 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.button5 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.button7 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.Output = New System.Windows.Forms.ListBox()
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.groupBox1.SuspendLayout()
			CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.DimGray
			Me.label1.Location = New System.Drawing.Point(10, 291)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(410, 16)
			Me.label1.TabIndex = 11
			Me.label1.Text = "Event Log"
			' 
			' groupBox1
			' 
			Me.groupBox1.BackColor = System.Drawing.Color.Transparent
			Me.groupBox1.Controls.Add(Me.checkBox1)
			Me.groupBox1.Controls.Add(Me.button3)
			Me.groupBox1.Controls.Add(Me.button1)
			Me.groupBox1.Controls.Add(Me.button2)
			Me.groupBox1.Controls.Add(Me.button6)
			Me.groupBox1.Controls.Add(Me.button4)
			Me.groupBox1.Controls.Add(Me.button5)
			Me.groupBox1.Controls.Add(Me.button7)
			Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.ForeColor = System.Drawing.Color.DimGray
			Me.groupBox1.Location = New System.Drawing.Point(676, 56)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(194, 385)
			Me.groupBox1.TabIndex = 13
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Select Events"
			' 
			' checkBox1
			' 
			Me.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.checkBox1.DrawFocusRectangle = False
			Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox1.Location = New System.Drawing.Point(49, 331)
			Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(115, 17)
			Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox1.TabIndex = 9
			Me.checkBox1.Text = "Disable Tracing"
			Me.checkBox1.ThemesEnabled = False
'			Me.checkBox1.CheckStateChanged += New System.EventHandler(Me.checkBox1_CheckedChanged)
			' 
			' button3
			' 
			Me.button3.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button3.ForeColor = System.Drawing.Color.White
			Me.button3.Location = New System.Drawing.Point(34, 51)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(130, 25)
			Me.button3.TabIndex = 4
			Me.button3.Text = "Trace Grid Events"
			Me.button3.UseVisualStyle = True
			Me.button3.UseVisualStyleBackColor = False
'			Me.button3.Click += New System.EventHandler(Me.button3_Click)
			' 
			' button1
			' 
			Me.button1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.White
			Me.button1.Location = New System.Drawing.Point(34, 91)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(130, 25)
			Me.button1.TabIndex = 2
			Me.button1.Text = "Trace Cell Events"
			Me.button1.UseVisualStyle = True
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button2.ForeColor = System.Drawing.Color.White
			Me.button2.Location = New System.Drawing.Point(34, 131)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(130, 25)
			Me.button2.TabIndex = 3
			Me.button2.Text = "Trace CurrentCell Events"
			Me.button2.UseVisualStyle = True
			Me.button2.UseVisualStyleBackColor = False
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' button6
			' 
			Me.button6.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.button6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button6.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button6.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button6.ForeColor = System.Drawing.Color.White
			Me.button6.Location = New System.Drawing.Point(34, 251)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(130, 25)
			Me.button6.TabIndex = 7
			Me.button6.Text = "Trace TableStyle Events"
			Me.button6.UseVisualStyle = True
			Me.button6.UseVisualStyleBackColor = False
'			Me.button6.Click += New System.EventHandler(Me.button6_Click)
			' 
			' button4
			' 
			Me.button4.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.button4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button4.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button4.ForeColor = System.Drawing.Color.White
			Me.button4.Location = New System.Drawing.Point(34, 171)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(130, 25)
			Me.button4.TabIndex = 5
			Me.button4.Text = "Trace Key Events"
			Me.button4.UseVisualStyle = True
			Me.button4.UseVisualStyleBackColor = False
'			Me.button4.Click += New System.EventHandler(Me.button4_Click)
			' 
			' button5
			' 
			Me.button5.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.button5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button5.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button5.ForeColor = System.Drawing.Color.White
			Me.button5.Location = New System.Drawing.Point(34, 211)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(130, 25)
			Me.button5.TabIndex = 6
			Me.button5.Text = "Trace Mouse Events"
			Me.button5.UseVisualStyle = True
			Me.button5.UseVisualStyleBackColor = False
'			Me.button5.Click += New System.EventHandler(Me.button5_Click)
			' 
			' button7
			' 
			Me.button7.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.button7.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button7.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button7.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button7.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button7.ForeColor = System.Drawing.Color.White
			Me.button7.Location = New System.Drawing.Point(34, 291)
			Me.button7.Name = "button7"
			Me.button7.Size = New System.Drawing.Size(130, 25)
			Me.button7.TabIndex = 8
			Me.button7.Text = "Clear Output Window"
			Me.button7.UseVisualStyle = True
			Me.button7.UseVisualStyleBackColor = False
'			Me.button7.Click += New System.EventHandler(Me.button7_Click)
			' 
			' Output
			' 
			Me.Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.Output.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Output.ForeColor = System.Drawing.Color.DimGray
			Me.Output.Location = New System.Drawing.Point(11, 308)
			Me.Output.Name = "Output"
			Me.Output.Size = New System.Drawing.Size(648, 171)
			Me.Output.TabIndex = 14
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.Location = New System.Drawing.Point(11, 26)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.Size = New System.Drawing.Size(645, 258)
			Me.gridGroupingControl1.TabIndex = 15
			Me.gridGroupingControl1.TableDescriptor.AllowNew = False
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235)))))))
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))))
			Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
			Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
			Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
			Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.VersionInfo = "4.301.0.0"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.BorderThickness = 2
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(882, 490)
			Me.Controls.Add(Me.gridGroupingControl1)
			Me.Controls.Add(Me.Output)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.label1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Table Control Events Demo"
			Me.groupBox1.ResumeLayout(False)
			CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region


        <STAThread()> _
  Shared Sub Main()
            Application.Run(New Form1())
        End Sub


		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			If Not checkBox1.Checked Then
				Me.eventTracer.UnHookEvents()
				Me.eventTracer.HookCellEvents()
			End If
		End Sub

		Private Sub button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button6.Click
			If Not checkBox1.Checked Then
				Me.eventTracer.UnHookEvents()
				Me.eventTracer.HookTableStyleEvents()
			End If
		End Sub

		Private Sub button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button7.Click
			Me.Output.Items.Clear()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			If Not checkBox1.Checked Then
				Me.eventTracer.UnHookEvents()
				Me.eventTracer.HookCurrentCellEvents()
			End If
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
			If Not checkBox1.Checked Then
				Me.eventTracer.UnHookEvents()
				Me.eventTracer.HookGridControlEvents()
			End If
		End Sub

		Private Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button4.Click
			If Not checkBox1.Checked Then
				Me.eventTracer.UnHookEvents()
				Me.eventTracer.HookKeyEvents()
			End If
		End Sub

		Private Sub button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button5.Click
			If Not checkBox1.Checked Then
				Me.eventTracer.UnHookEvents()
				Me.eventTracer.HookMouseEvents()
			End If
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckStateChanged
			If Me.checkBox1.Checked Then
				Me.eventTracer.UnHookEvents()
			Else
				Me.eventTracer.HookCellEvents()
				Me.eventTracer.HookCurrentCellEvents()
				Me.eventTracer.HookGridControlEvents()
				Me.eventTracer.HookKeyEvents()
				Me.eventTracer.HookMouseEvents()
				Me.eventTracer.HookTableStyleEvents()
			End If
		End Sub

	End Class
End Namespace

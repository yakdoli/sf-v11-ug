Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Drawing
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		#Region "Members"
		Private dataset11 As GridListControl.Dataset1
		Private gridListControl1 As Syncfusion.Windows.Forms.Grid.GridListControl
		Private WithEvents checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents button1 As System.Windows.Forms.Button
		Private colorPickerButton2 As Syncfusion.Windows.Forms.ColorPickerButton
		Private colorPickerButton3 As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents trackBar4 As TrackBarEx
		Private WithEvents trackBar5 As TrackBarEx
		Private WithEvents trackBar6 As TrackBarEx
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents checkBoxAdv5 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private fontDialog1 As System.Windows.Forms.FontDialog
		Private WithEvents checkBoxAdv4 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private components As System.ComponentModel.IContainer=Nothing
		Private groupBox2 As GroupBox
		Private Const connection As String = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""{0}"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"
#End Region

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Dim commandstring As String = "select * from Products"
			Dim connection As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
			Dim da As New SqlCeDataAdapter(commandstring,connection)
			Try
				da.Fill(dataset11, "Products")
				'System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
				Dim ico As New System.Drawing.Icon(GetIconFile("D:\icons\LOGO.ico"))
				Me.Icon = ico
			Catch ex As SqlException
				ShowErrorMessage(ex)
			End Try


		End Sub

		#Region "Form Handlers"
		Private Function FindFile(ByVal connstring As String) As String
			'connstring = @"common\data\" + connstring;
			connstring = "" & connstring
			For n As Integer = 0 To 9
				If System.IO.File.Exists(connstring) Then
					Return New FileInfo(connstring).FullName
				End If
				connstring = "..\" & connstring
			Next n

			Return connstring
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

		Private Function FindImageFile(ByVal bitmapName As String) As String
			Dim bitmappath As String = ""
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					bitmappath = bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n
			Return bitmappath
		End Function
		#End Region

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dataset11 = New GridListControl.Dataset1()
			Me.gridListControl1 = New Syncfusion.Windows.Forms.Grid.GridListControl()
			Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.button1 = New System.Windows.Forms.Button()
			Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.colorPickerButton3 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.trackBar4 = New Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 255)
			Me.trackBar5 = New Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 255)
			Me.trackBar6 = New Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 255)
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.checkBoxAdv5 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.fontDialog1 = New System.Windows.Forms.FontDialog()
			Me.checkBoxAdv4 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBoxAdv3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			CType(Me.dataset11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.checkBoxAdv5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAdv4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' dataset11
			' 
			Me.dataset11.DataSetName = "Dataset1"
			Me.dataset11.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridListControl1
			' 
			Me.gridListControl1.BackColor = System.Drawing.SystemColors.Control
			Me.gridListControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.gridListControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gridListControl1.DataSource = Me.dataset11
			Me.gridListControl1.DisplayMember = "Products.ProductID"
			Me.gridListControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridListControl1.ItemHeight = 17
			Me.gridListControl1.Location = New System.Drawing.Point(12, 21)
			Me.gridListControl1.MultiColumn = True
			Me.gridListControl1.Name = "gridListControl1"
			Me.gridListControl1.Properties.BackgroundColor = System.Drawing.SystemColors.Window
			Me.gridListControl1.Properties.DisplayHorzLines = False
			Me.gridListControl1.Properties.DisplayVertLines = False
			Me.gridListControl1.Properties.MarkColHeader = False
			Me.gridListControl1.Properties.MarkRowHeader = False
			Me.gridListControl1.SelectedIndex = -1
			Me.gridListControl1.Size = New System.Drawing.Size(779, 524)
			Me.gridListControl1.TabIndex = 0
			Me.gridListControl1.ThemesEnabled = True
			Me.gridListControl1.TopIndex = 0
			' 
			' checkBoxAdv1
			' 
			Me.checkBoxAdv1.BackColor = System.Drawing.Color.Transparent
			Me.checkBoxAdv1.BorderColor = System.Drawing.Color.DimGray
			Me.checkBoxAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.checkBoxAdv1.DrawFocusRectangle = False
			Me.checkBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxAdv1.Location = New System.Drawing.Point(99, 172)
			Me.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBoxAdv1.Name = "checkBoxAdv1"
			Me.checkBoxAdv1.Size = New System.Drawing.Size(163, 23)
			Me.checkBoxAdv1.StretchImage = False
			Me.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBoxAdv1.TabIndex = 5
			Me.checkBoxAdv1.Text = "Transparent Background"
			Me.checkBoxAdv1.ThemesEnabled = False
'			Me.checkBoxAdv1.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv1_CheckStateChanged)
			' 
			' checkBoxAdv2
			' 
			Me.checkBoxAdv2.BackColor = System.Drawing.Color.Transparent
			Me.checkBoxAdv2.BorderColor = System.Drawing.Color.DimGray
			Me.checkBoxAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.checkBoxAdv2.DrawFocusRectangle = False
			Me.checkBoxAdv2.Enabled = False
			Me.checkBoxAdv2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxAdv2.Location = New System.Drawing.Point(180, 135)
			Me.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBoxAdv2.Name = "checkBoxAdv2"
			Me.checkBoxAdv2.Size = New System.Drawing.Size(152, 22)
			Me.checkBoxAdv2.StretchImage = False
			Me.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBoxAdv2.TabIndex = 6
			Me.checkBoxAdv2.Text = "Remove BackgroundImage"
			Me.checkBoxAdv2.ThemesEnabled = False
'			Me.checkBoxAdv2.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv2_CheckStateChanged)
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.Color.White
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.button1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.Location = New System.Drawing.Point(22, 134)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(152, 23)
			Me.button1.TabIndex = 7
			Me.button1.Text = "Browse BackgroundImage"
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' colorPickerButton2
			' 
			Me.colorPickerButton2.BackColor = System.Drawing.Color.White
			Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.colorPickerButton2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.colorPickerButton2.Location = New System.Drawing.Point(22, 232)
			Me.colorPickerButton2.Name = "colorPickerButton2"
			Me.colorPickerButton2.SelectedAsBackcolor = True
			Me.colorPickerButton2.Size = New System.Drawing.Size(152, 24)
			Me.colorPickerButton2.TabIndex = 9
			Me.colorPickerButton2.Text = "HeaderBackColor"
			Me.colorPickerButton2.UseVisualStyleBackColor = False
			' 
			' colorPickerButton3
			' 
			Me.colorPickerButton3.BackColor = System.Drawing.Color.White
			Me.colorPickerButton3.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.colorPickerButton3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.colorPickerButton3.Location = New System.Drawing.Point(180, 232)
			Me.colorPickerButton3.Name = "colorPickerButton3"
			Me.colorPickerButton3.SelectedAsBackcolor = True
			Me.colorPickerButton3.Size = New System.Drawing.Size(152, 24)
			Me.colorPickerButton3.TabIndex = 10
			Me.colorPickerButton3.Text = "HeaderTextColor"
			Me.colorPickerButton3.UseVisualStyleBackColor = False
			' 
			' trackBar4
			' 
			Me.trackBar4.Location = New System.Drawing.Point(71, 27)
			Me.trackBar4.Name = "trackBar4"
			Me.trackBar4.Size = New System.Drawing.Size(215, 20)
			Me.trackBar4.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro
			Me.trackBar4.TabIndex = 11
			Me.trackBar4.TimerInterval = 100
			Me.trackBar4.Value = 255
'			Me.trackBar4.Scroll += New System.EventHandler(Me.trackBar1_Scroll)
			' 
			' trackBar5
			' 
			Me.trackBar5.Location = New System.Drawing.Point(71, 75)
			Me.trackBar5.Name = "trackBar5"
			Me.trackBar5.Size = New System.Drawing.Size(215, 20)
			Me.trackBar5.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro
			Me.trackBar5.TabIndex = 0
			Me.trackBar5.TimerInterval = 100
			Me.trackBar5.Value = 255
'			Me.trackBar5.Scroll += New System.EventHandler(Me.trackBar2_Scroll)
			' 
			' trackBar6
			' 
			Me.trackBar6.Location = New System.Drawing.Point(73, 117)
			Me.trackBar6.Name = "trackBar6"
			Me.trackBar6.Size = New System.Drawing.Size(215, 20)
			Me.trackBar6.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro
			Me.trackBar6.TabIndex = 0
			Me.trackBar6.TimerInterval = 100
			Me.trackBar6.Value = 255
'			Me.trackBar6.Scroll += New System.EventHandler(Me.trackBar3_Scroll)
			' 
			' groupBox1
			' 
			Me.groupBox1.BackColor = System.Drawing.Color.White
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.trackBar4)
			Me.groupBox1.Controls.Add(Me.trackBar5)
			Me.groupBox1.Controls.Add(Me.trackBar6)
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.Location = New System.Drawing.Point(22, 325)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(296, 176)
			Me.groupBox1.TabIndex = 14
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "BackColor"
			' 
			' label3
			' 
			Me.label3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.Location = New System.Drawing.Point(33, 117)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(32, 16)
			Me.label3.TabIndex = 16
			Me.label3.Text = "Blue"
			' 
			' label2
			' 
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(33, 75)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(40, 16)
			Me.label2.TabIndex = 15
			Me.label2.Text = "Green"
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(33, 31)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(32, 16)
			Me.label1.TabIndex = 14
			Me.label1.Text = "Red"
			' 
			' colorPickerButton1
			' 
			Me.colorPickerButton1.BackColor = System.Drawing.Color.White
			Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.colorPickerButton1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.colorPickerButton1.Location = New System.Drawing.Point(99, 267)
			Me.colorPickerButton1.Name = "colorPickerButton1"
			Me.colorPickerButton1.SelectedAsBackcolor = True
			Me.colorPickerButton1.Size = New System.Drawing.Size(163, 24)
			Me.colorPickerButton1.TabIndex = 15
			Me.colorPickerButton1.Text = "GridLineColor"
			Me.colorPickerButton1.UseVisualStyleBackColor = False
			' 
			' checkBoxAdv5
			' 
			Me.checkBoxAdv5.BackColor = System.Drawing.Color.White
			Me.checkBoxAdv5.BorderColor = System.Drawing.Color.DimGray
			Me.checkBoxAdv5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.checkBoxAdv5.Checked = True
			Me.checkBoxAdv5.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBoxAdv5.DrawFocusRectangle = False
			Me.checkBoxAdv5.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxAdv5.Location = New System.Drawing.Point(97, 79)
			Me.checkBoxAdv5.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBoxAdv5.Name = "checkBoxAdv5"
			Me.checkBoxAdv5.Size = New System.Drawing.Size(163, 21)
			Me.checkBoxAdv5.StretchImage = False
			Me.checkBoxAdv5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBoxAdv5.TabIndex = 18
			Me.checkBoxAdv5.Text = "Buttons3D"
			Me.checkBoxAdv5.ThemesEnabled = False
'			Me.checkBoxAdv5.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv5_CheckStateChanged)
			' 
			' checkBoxAdv4
			' 
			Me.checkBoxAdv4.BackColor = System.Drawing.Color.White
			Me.checkBoxAdv4.BorderColor = System.Drawing.Color.DimGray
			Me.checkBoxAdv4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.checkBoxAdv4.DrawFocusRectangle = False
			Me.checkBoxAdv4.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxAdv4.Location = New System.Drawing.Point(180, 44)
			Me.checkBoxAdv4.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBoxAdv4.Name = "checkBoxAdv4"
			Me.checkBoxAdv4.Size = New System.Drawing.Size(152, 22)
			Me.checkBoxAdv4.StretchImage = False
			Me.checkBoxAdv4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBoxAdv4.TabIndex = 17
			Me.checkBoxAdv4.Text = "Vertical Lines"
			Me.checkBoxAdv4.ThemesEnabled = False
'			Me.checkBoxAdv4.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv4_CheckStateChanged)
			' 
			' checkBoxAdv3
			' 
			Me.checkBoxAdv3.BackColor = System.Drawing.Color.Transparent
			Me.checkBoxAdv3.BorderColor = System.Drawing.Color.DimGray
			Me.checkBoxAdv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.checkBoxAdv3.DrawFocusRectangle = False
			Me.checkBoxAdv3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxAdv3.Location = New System.Drawing.Point(22, 44)
			Me.checkBoxAdv3.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBoxAdv3.Name = "checkBoxAdv3"
			Me.checkBoxAdv3.Size = New System.Drawing.Size(152, 22)
			Me.checkBoxAdv3.StretchImage = False
			Me.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBoxAdv3.TabIndex = 16
			Me.checkBoxAdv3.Text = "Horizontal Lines"
			Me.checkBoxAdv3.ThemesEnabled = False
'			Me.checkBoxAdv3.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv3_CheckStateChanged)
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.groupBox1)
			Me.groupBox2.Controls.Add(Me.checkBoxAdv5)
			Me.groupBox2.Controls.Add(Me.checkBoxAdv4)
			Me.groupBox2.Controls.Add(Me.checkBoxAdv3)
			Me.groupBox2.Controls.Add(Me.checkBoxAdv2)
			Me.groupBox2.Controls.Add(Me.checkBoxAdv1)
			Me.groupBox2.Controls.Add(Me.colorPickerButton1)
			Me.groupBox2.Controls.Add(Me.colorPickerButton3)
			Me.groupBox2.Controls.Add(Me.colorPickerButton2)
			Me.groupBox2.Controls.Add(Me.button1)
			Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox2.Location = New System.Drawing.Point(802, 14)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(344, 531)
			Me.groupBox2.TabIndex = 20
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Customizing Options..."
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(1150, 557)
			Me.Controls.Add(Me.gridListControl1)
			Me.Controls.Add(Me.groupBox2)
			Me.DropShadow = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Customization Demo"
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.dataset11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridListControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.checkBoxAdv5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxAdv4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "Entry Point"
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub
		#End Region

		#Region "EventHandlers"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.gridListControl1.ThemesEnabled = True
			Me.gridListControl1.HeaderBackColor = Color.FromArgb(0, 21, 84)
			Me.gridListControl1.HeaderTextColor = Color.MidnightBlue
			Me.gridListControl1.BackColor = Color.White
			AddHandler colorPickerButton1.ColorSelected, AddressOf colorPickerButton1_ColorSelected
			AddHandler colorPickerButton2.ColorSelected, AddressOf colorPickerButton2_ColorSelected
			AddHandler colorPickerButton3.ColorSelected, AddressOf colorPickerButton3_ColorSelected

		End Sub

		Private Sub checkBoxAdv1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxAdv1.CheckStateChanged
			If Me.checkBoxAdv1.Checked Then
				Me.checkBoxAdv2.Enabled = True

				'Make the grid background transparent
				Me.gridListControl1.TransparentBackground = True
				If Not checkBoxAdv2.Checked Then
					'Add background image
					If imageFileName Is Nothing Then
						imageFileName = FindImageFile("..\..\abstract.jpg")
						Me.gridListControl1.BackgroundImage = Image.FromFile(imageFileName)
					Else
						Me.gridListControl1.BackgroundImage = Image.FromFile(imageFileName)
					End If
				End If
				Me.groupBox1.Enabled = False
				Me.colorPickerButton2.Enabled = False
				Me.button1.Enabled = True

			Else
				'Remove transparent background
				Me.groupBox1.Enabled=True
				Me.colorPickerButton2.Enabled = True
				Me.button1.Enabled = False
				Me.gridListControl1.TransparentBackground = False
				Me.gridListControl1.TableStyle.TextColor = Color.MidnightBlue
				Me.checkBoxAdv2.Enabled=False
			End If
		End Sub



		Private Sub checkBoxAdv2_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxAdv2.CheckStateChanged
			If Me.checkBoxAdv2.Checked Then
				'Remove Backround Image
				Me.gridListControl1.BackgroundImage = Nothing
			Else
				If imageFileName Is Nothing Then
					Me.gridListControl1.BackgroundImage = Image.FromFile(FindImageFile("common\Images\Grid\CustomizedListControl\Cloud.jpg"))
				Else
					Me.gridListControl1.BackgroundImage = Image.FromFile(imageFileName)
				End If
			End If
		End Sub

		Private imageFileName As String = Nothing
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Dim dlg As FileDialog = New OpenFileDialog()
			dlg.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg Files (*.jpg)|*.jpg | All files (*.*)|*.*"
			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Me.checkBoxAdv1.Enabled = True
				Me.imageFileName = dlg.FileName
				'Apply the selected image to grid's background
				Me.gridListControl1.BackgroundImage = Image.FromFile(Me.imageFileName)
			End If
		End Sub

		Private Sub colorPickerButton2_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			'Change Header BackColor
			Me.gridListControl1.HeaderBackColor=colorPickerButton2.SelectedColor
		End Sub

		Private Sub colorPickerButton3_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			'Change Header TextColor
			Me.gridListControl1.HeaderTextColor=colorPickerButton3.SelectedColor
		End Sub

		Private Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar4.Scroll
			'Change the red component value of grid's backcolor
			Me.gridListControl1.BackColor=Color.FromArgb(Me.trackBar4.Value,Me.trackBar5.Value,Me.trackBar6.Value)
		End Sub

		Private Sub trackBar2_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar5.Scroll
			'Change the green component value of grid's backcolor
			Me.gridListControl1.BackColor=Color.FromArgb(Me.trackBar4.Value,Me.trackBar5.Value,Me.trackBar6.Value)
		End Sub

		Private Sub trackBar3_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar6.Scroll
			'Change the blue component value of grid's backcolor
			Me.gridListControl1.BackColor=Color.FromArgb(Me.trackBar4.Value,Me.trackBar5.Value,Me.trackBar6.Value)
		End Sub

		Private Sub checkBoxAdv3_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxAdv3.CheckStateChanged
			'Enable or Disable the display of horizontal grid lines
			If Me.checkBoxAdv3.Checked Then
				Me.gridListControl1.Properties.DisplayHorzLines=True
			Else
				Me.gridListControl1.Properties.DisplayHorzLines=False
			End If

		End Sub

		Private Sub checkBoxAdv4_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxAdv4.CheckStateChanged
			'Enable or Disable the display of vertical grid lines
			If Me.checkBoxAdv4.Checked Then
				Me.gridListControl1.Properties.DisplayVertLines=True
			Else
				Me.gridListControl1.Properties.DisplayVertLines=False
			End If

		End Sub

		Private Sub checkBoxAdv5_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxAdv5.CheckStateChanged
			'Specify if row/column headers should appear raised or flat
			If Me.checkBoxAdv5.Checked Then
				Me.gridListControl1.Properties.Buttons3D=True
			Else
				Me.gridListControl1.Properties.Buttons3D=False
			End If
		End Sub

		Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			'Change grid lines color
			Me.gridListControl1.Grid.Properties.GridLineColor = Me.colorPickerButton1.SelectedColor
			Me.gridListControl1.Grid.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
		End Sub

		Private Sub checkBoxAdv6_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs)
			'Enable or disable ListBoxSelection Mode
			'if(this.checkBoxAdv6.Checked)
				'this.gridListControl1.Grid.DrawCell+=new GridDrawCellEventHandler(Grid_DrawCell);
			'else
				'this.gridListControl1.Grid.DrawCell-=new GridDrawCellEventHandler(Grid_DrawCell);
		End Sub
		#End Region
	End Class

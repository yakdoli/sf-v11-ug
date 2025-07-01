Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace GridProperties
	Public Class Form1
		Inherits MetroForm
		Private xpTaskBar1 As Syncfusion.Windows.Forms.Tools.XPTaskBar
		Private colorPickerButton5 As Syncfusion.Windows.Forms.ColorPickerButton
		Private colorPickerButton4 As Syncfusion.Windows.Forms.ColorPickerButton
		Private colorPickerButton3 As Syncfusion.Windows.Forms.ColorPickerButton
		Private colorPickerButton2 As Syncfusion.Windows.Forms.ColorPickerButton
		Private colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
		Private xpTaskBarBox1 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private WithEvents button2 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents xpTaskBarBox2 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private WithEvents button3 As Syncfusion.Windows.Forms.ButtonAdv
		Private panel1 As System.Windows.Forms.Panel
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private colorPickerButton6 As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents buttonAdv1 As ButtonAdv
		Private temp1 As Boolean, temp2 As Boolean = False
		Private WithEvents checkBoxAdv1 As CheckBoxAdv
		Private WithEvents checkBoxAdv2 As CheckBoxAdv
		Private WithEvents checkBoxAdv3 As CheckBoxAdv
		Private WithEvents checkBoxAdv4 As CheckBoxAdv
		Private WithEvents checkBoxAdv5 As CheckBoxAdv
		Private WithEvents checkBoxAdv7 As CheckBoxAdv
		Private WithEvents checkBoxAdv8 As CheckBoxAdv
		Private WithEvents checkBoxAdv9 As CheckBoxAdv
		Private WithEvents checkBoxAdv10 As CheckBoxAdv
		Private WithEvents checkBoxAdv11 As CheckBoxAdv
		Private WithEvents checkBoxAdv12 As CheckBoxAdv
		Private WithEvents checkBoxAdv13 As CheckBoxAdv
		Private WithEvents checkBoxAdv14 As CheckBoxAdv
		Private WithEvents checkBoxAdv15 As CheckBoxAdv
		Private WithEvents checkBoxAdv16 As CheckBoxAdv
		Private WithEvents checkBoxAdv17 As CheckBoxAdv
		Private components As IContainer

		Public Sub New()
			InitializeComponent()
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico
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

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim GridBaseStyle5 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle6 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle7 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle8 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridRangeStyle31 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle32 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle33 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle34 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle35 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle36 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle37 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle38 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle39 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle40 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle41 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle42 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle43 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle44 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle45 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle46 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle47 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle48 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle49 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle50 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle51 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle52 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle53 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle54 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle55 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle56 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle57 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle58 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle59 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle60 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Me.xpTaskBar1 = New Syncfusion.Windows.Forms.Tools.XPTaskBar
            Me.xpTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.checkBoxAdv8 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv7 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv5 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv4 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.colorPickerButton6 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.colorPickerButton3 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.colorPickerButton4 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.colorPickerButton5 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.xpTaskBarBox2 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.checkBoxAdv17 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv9 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv16 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv15 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv14 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv13 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv12 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv11 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv10 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.button3 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.panel1 = New System.Windows.Forms.Panel
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xpTaskBar1.SuspendLayout()
            Me.xpTaskBarBox1.SuspendLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            CType(Me.checkBoxAdv8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xpTaskBarBox2.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            CType(Me.checkBoxAdv17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv10, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xpTaskBar1
            '
            Me.xpTaskBar1.BackColor = System.Drawing.Color.White
            Me.xpTaskBar1.BorderColor = System.Drawing.Color.Black
            Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox1)
            Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox2)
            Me.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Right
            Me.xpTaskBar1.Location = New System.Drawing.Point(640, 0)
            Me.xpTaskBar1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.xpTaskBar1.MinimumSize = New System.Drawing.Size(0, 0)
            Me.xpTaskBar1.Name = "xpTaskBar1"
            Me.xpTaskBar1.Size = New System.Drawing.Size(371, 488)
            Me.xpTaskBar1.TabIndex = 0
            '
            'xpTaskBarBox1
            '
            Me.xpTaskBarBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.xpTaskBarBox1.BackColor = System.Drawing.Color.White
            Me.xpTaskBarBox1.Controls.Add(Me.gradientPanel1)
            Me.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.Gray
            Me.xpTaskBarBox1.HeaderForeColor = System.Drawing.Color.White
            Me.xpTaskBarBox1.HeaderImageIndex = -1
            Me.xpTaskBarBox1.HitTaskBoxArea = False
            Me.xpTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty
            Me.xpTaskBarBox1.ItemBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(201, Byte), Integer))
            Me.xpTaskBarBox1.Location = New System.Drawing.Point(0, 0)
            Me.xpTaskBarBox1.Name = "xpTaskBarBox1"
            Me.xpTaskBarBox1.PreferredChildPanelHeight = 250
            Me.xpTaskBarBox1.Size = New System.Drawing.Size(371, 282)
            Me.xpTaskBarBox1.TabIndex = 0
            Me.xpTaskBarBox1.Text = "Appearance"
            '
            'gradientPanel1
            '
            Me.gradientPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            Me.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedInner
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.checkBoxAdv8)
            Me.gradientPanel1.Controls.Add(Me.checkBoxAdv7)
            Me.gradientPanel1.Controls.Add(Me.checkBoxAdv5)
            Me.gradientPanel1.Controls.Add(Me.checkBoxAdv4)
            Me.gradientPanel1.Controls.Add(Me.checkBoxAdv3)
            Me.gradientPanel1.Controls.Add(Me.checkBoxAdv2)
            Me.gradientPanel1.Controls.Add(Me.checkBoxAdv1)
            Me.gradientPanel1.Controls.Add(Me.buttonAdv1)
            Me.gradientPanel1.Controls.Add(Me.colorPickerButton6)
            Me.gradientPanel1.Controls.Add(Me.colorPickerButton1)
            Me.gradientPanel1.Controls.Add(Me.colorPickerButton2)
            Me.gradientPanel1.Controls.Add(Me.colorPickerButton3)
            Me.gradientPanel1.Controls.Add(Me.button1)
            Me.gradientPanel1.Controls.Add(Me.colorPickerButton4)
            Me.gradientPanel1.Controls.Add(Me.colorPickerButton5)
            Me.gradientPanel1.Controls.Add(Me.button2)
            Me.gradientPanel1.Location = New System.Drawing.Point(2, 30)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(367, 250)
            Me.gradientPanel1.TabIndex = 0
            '
            'checkBoxAdv8
            '
            Me.checkBoxAdv8.Checked = True
            Me.checkBoxAdv8.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv8.Location = New System.Drawing.Point(13, 181)
            Me.checkBoxAdv8.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv8.Name = "checkBoxAdv8"
            Me.checkBoxAdv8.Size = New System.Drawing.Size(157, 21)
            Me.checkBoxAdv8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv8.TabIndex = 22
            Me.checkBoxAdv8.Text = "Buttons3D"
            Me.checkBoxAdv8.ThemesEnabled = False
            '
            'checkBoxAdv7
            '
            Me.checkBoxAdv7.Location = New System.Drawing.Point(13, 215)
            Me.checkBoxAdv7.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv7.Name = "checkBoxAdv7"
            Me.checkBoxAdv7.Size = New System.Drawing.Size(157, 21)
            Me.checkBoxAdv7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv7.TabIndex = 21
            Me.checkBoxAdv7.Text = "Transparent Background"
            Me.checkBoxAdv7.ThemesEnabled = False
            '
            'checkBoxAdv5
            '
            Me.checkBoxAdv5.Checked = True
            Me.checkBoxAdv5.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv5.Location = New System.Drawing.Point(13, 147)
            Me.checkBoxAdv5.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv5.Name = "checkBoxAdv5"
            Me.checkBoxAdv5.Size = New System.Drawing.Size(150, 21)
            Me.checkBoxAdv5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv5.TabIndex = 19
            Me.checkBoxAdv5.Text = "Enabled"
            Me.checkBoxAdv5.ThemesEnabled = False
            '
            'checkBoxAdv4
            '
            Me.checkBoxAdv4.Checked = True
            Me.checkBoxAdv4.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv4.Location = New System.Drawing.Point(13, 111)
            Me.checkBoxAdv4.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv4.Name = "checkBoxAdv4"
            Me.checkBoxAdv4.Size = New System.Drawing.Size(163, 21)
            Me.checkBoxAdv4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv4.TabIndex = 18
            Me.checkBoxAdv4.Text = "Display Vrtcl Lines"
            Me.checkBoxAdv4.ThemesEnabled = False
            '
            'checkBoxAdv3
            '
            Me.checkBoxAdv3.Checked = True
            Me.checkBoxAdv3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv3.Location = New System.Drawing.Point(13, 77)
            Me.checkBoxAdv3.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv3.Name = "checkBoxAdv3"
            Me.checkBoxAdv3.Size = New System.Drawing.Size(163, 21)
            Me.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv3.TabIndex = 1
            Me.checkBoxAdv3.Text = "Display Horzntl Lines"
            Me.checkBoxAdv3.ThemesEnabled = False
            '
            'checkBoxAdv2
            '
            Me.checkBoxAdv2.Checked = True
            Me.checkBoxAdv2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv2.Location = New System.Drawing.Point(13, 42)
            Me.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv2.Name = "checkBoxAdv2"
            Me.checkBoxAdv2.Size = New System.Drawing.Size(150, 21)
            Me.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv2.TabIndex = 1
            Me.checkBoxAdv2.Text = "Show RowHeaders"
            Me.checkBoxAdv2.ThemesEnabled = False
            '
            'checkBoxAdv1
            '
            Me.checkBoxAdv1.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv1.Checked = True
            Me.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxAdv1.Location = New System.Drawing.Point(13, 5)
            Me.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv1.Name = "checkBoxAdv1"
            Me.checkBoxAdv1.Size = New System.Drawing.Size(150, 21)
            Me.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv1.TabIndex = 1
            Me.checkBoxAdv1.Text = "Show ColHeaders"
            Me.checkBoxAdv1.ThemesEnabled = False
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.buttonAdv1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv1.ForeColor = System.Drawing.Color.White
            Me.buttonAdv1.Location = New System.Drawing.Point(173, 258)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(185, 40)
            Me.buttonAdv1.TabIndex = 16
            Me.buttonAdv1.Text = "Remove Numbering in Headers"
            Me.buttonAdv1.UseVisualStyle = True
            Me.buttonAdv1.UseVisualStyleBackColor = True
            '
            'colorPickerButton6
            '
            Me.colorPickerButton6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.colorPickerButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colorPickerButton6.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.colorPickerButton6.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton6.ForeColor = System.Drawing.Color.White
            Me.colorPickerButton6.Location = New System.Drawing.Point(182, 111)
            Me.colorPickerButton6.Name = "colorPickerButton6"
            Me.colorPickerButton6.Size = New System.Drawing.Size(161, 30)
            Me.colorPickerButton6.TabIndex = 15
            Me.colorPickerButton6.Text = "Grid TextColor"
            Me.colorPickerButton6.UseVisualStyle = True
            Me.colorPickerButton6.UseVisualStyleBackColor = True
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.colorPickerButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colorPickerButton1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton1.ForeColor = System.Drawing.Color.White
            Me.colorPickerButton1.Location = New System.Drawing.Point(182, 5)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.Size = New System.Drawing.Size(160, 28)
            Me.colorPickerButton1.TabIndex = 10
            Me.colorPickerButton1.Text = "BackColor"
            Me.colorPickerButton1.UseVisualStyle = True
            Me.colorPickerButton1.UseVisualStyleBackColor = True
            '
            'colorPickerButton2
            '
            Me.colorPickerButton2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.colorPickerButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colorPickerButton2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton2.ForeColor = System.Drawing.Color.White
            Me.colorPickerButton2.Location = New System.Drawing.Point(182, 42)
            Me.colorPickerButton2.Name = "colorPickerButton2"
            Me.colorPickerButton2.Size = New System.Drawing.Size(161, 28)
            Me.colorPickerButton2.TabIndex = 11
            Me.colorPickerButton2.Text = "BackgroundColor"
            Me.colorPickerButton2.UseVisualStyle = True
            Me.colorPickerButton2.UseVisualStyleBackColor = True
            '
            'colorPickerButton3
            '
            Me.colorPickerButton3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.colorPickerButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colorPickerButton3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.colorPickerButton3.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton3.ForeColor = System.Drawing.Color.White
            Me.colorPickerButton3.Location = New System.Drawing.Point(182, 147)
            Me.colorPickerButton3.Name = "colorPickerButton3"
            Me.colorPickerButton3.Size = New System.Drawing.Size(160, 28)
            Me.colorPickerButton3.TabIndex = 12
            Me.colorPickerButton3.Text = "Fixed Lines Color"
            Me.colorPickerButton3.UseVisualStyle = True
            Me.colorPickerButton3.UseVisualStyleBackColor = True
            '
            'button1
            '
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(182, 215)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(161, 28)
            Me.button1.TabIndex = 8
            Me.button1.Text = "BackgroundImage"
            Me.button1.UseVisualStyle = True
            Me.button1.UseVisualStyleBackColor = True
            '
            'colorPickerButton4
            '
            Me.colorPickerButton4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.colorPickerButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colorPickerButton4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.colorPickerButton4.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton4.ForeColor = System.Drawing.Color.White
            Me.colorPickerButton4.Location = New System.Drawing.Point(182, 77)
            Me.colorPickerButton4.Name = "colorPickerButton4"
            Me.colorPickerButton4.Size = New System.Drawing.Size(161, 28)
            Me.colorPickerButton4.TabIndex = 13
            Me.colorPickerButton4.Text = "Grid Line Color"
            Me.colorPickerButton4.UseVisualStyle = True
            Me.colorPickerButton4.UseVisualStyleBackColor = True
            '
            'colorPickerButton5
            '
            Me.colorPickerButton5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.colorPickerButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colorPickerButton5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.colorPickerButton5.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton5.ForeColor = System.Drawing.Color.White
            Me.colorPickerButton5.Location = New System.Drawing.Point(182, 181)
            Me.colorPickerButton5.Name = "colorPickerButton5"
            Me.colorPickerButton5.Size = New System.Drawing.Size(161, 28)
            Me.colorPickerButton5.TabIndex = 14
            Me.colorPickerButton5.Text = "Resizing Cells Line Color"
            Me.colorPickerButton5.UseVisualStyle = True
            Me.colorPickerButton5.UseVisualStyleBackColor = True
            '
            'button2
            '
            Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.ForeColor = System.Drawing.Color.White
            Me.button2.Location = New System.Drawing.Point(4, 249)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(159, 49)
            Me.button2.TabIndex = 1
            Me.button2.Text = "Remove Background Image"
            Me.button2.UseVisualStyle = True
            Me.button2.UseVisualStyleBackColor = True
            '
            'xpTaskBarBox2
            '
            Me.xpTaskBarBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.xpTaskBarBox2.BackColor = System.Drawing.Color.White
            Me.xpTaskBarBox2.Controls.Add(Me.gradientPanel2)
            Me.xpTaskBarBox2.HeaderBackColor = System.Drawing.Color.Gray
            Me.xpTaskBarBox2.HeaderForeColor = System.Drawing.Color.White
            Me.xpTaskBarBox2.HeaderImageIndex = -1
            Me.xpTaskBarBox2.HitTaskBoxArea = False
            Me.xpTaskBarBox2.HotTrackColor = System.Drawing.Color.Empty
            Me.xpTaskBarBox2.ItemBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(201, Byte), Integer))
            Me.xpTaskBarBox2.Location = New System.Drawing.Point(0, 282)
            Me.xpTaskBarBox2.Name = "xpTaskBarBox2"
            Me.xpTaskBarBox2.PreferredChildPanelHeight = 170
            Me.xpTaskBarBox2.Size = New System.Drawing.Size(371, 202)
            Me.xpTaskBarBox2.TabIndex = 1
            Me.xpTaskBarBox2.Text = "PrintStyle"
            '
            'gradientPanel2
            '
            Me.gradientPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gradientPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            Me.gradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv17)
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv9)
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv16)
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv15)
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv14)
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv13)
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv12)
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv11)
            Me.gradientPanel2.Controls.Add(Me.checkBoxAdv10)
            Me.gradientPanel2.Controls.Add(Me.button3)
            Me.gradientPanel2.Location = New System.Drawing.Point(2, 30)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(367, 170)
            Me.gradientPanel2.TabIndex = 0
            '
            'checkBoxAdv17
            '
            Me.checkBoxAdv17.Location = New System.Drawing.Point(13, 130)
            Me.checkBoxAdv17.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv17.Name = "checkBoxAdv17"
            Me.checkBoxAdv17.Size = New System.Drawing.Size(157, 21)
            Me.checkBoxAdv17.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv17.TabIndex = 13
            Me.checkBoxAdv17.Text = "Printing"
            Me.checkBoxAdv17.ThemesEnabled = False
            '
            'checkBoxAdv9
            '
            Me.checkBoxAdv9.Checked = True
            Me.checkBoxAdv9.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv9.Location = New System.Drawing.Point(13, 21)
            Me.checkBoxAdv9.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv9.Name = "checkBoxAdv9"
            Me.checkBoxAdv9.Size = New System.Drawing.Size(157, 21)
            Me.checkBoxAdv9.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv9.TabIndex = 10
            Me.checkBoxAdv9.Text = "Center Horizontal"
            Me.checkBoxAdv9.ThemesEnabled = False
            '
            'checkBoxAdv16
            '
            Me.checkBoxAdv16.Checked = True
            Me.checkBoxAdv16.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv16.Location = New System.Drawing.Point(182, 103)
            Me.checkBoxAdv16.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv16.Name = "checkBoxAdv16"
            Me.checkBoxAdv16.Size = New System.Drawing.Size(160, 21)
            Me.checkBoxAdv16.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv16.TabIndex = 12
            Me.checkBoxAdv16.Text = "Black/White"
            Me.checkBoxAdv16.ThemesEnabled = False
            '
            'checkBoxAdv15
            '
            Me.checkBoxAdv15.Checked = True
            Me.checkBoxAdv15.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv15.Location = New System.Drawing.Point(13, 103)
            Me.checkBoxAdv15.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv15.Name = "checkBoxAdv15"
            Me.checkBoxAdv15.Size = New System.Drawing.Size(157, 21)
            Me.checkBoxAdv15.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv15.TabIndex = 11
            Me.checkBoxAdv15.Text = "Print Frame"
            Me.checkBoxAdv15.ThemesEnabled = False
            '
            'checkBoxAdv14
            '
            Me.checkBoxAdv14.Checked = True
            Me.checkBoxAdv14.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv14.Location = New System.Drawing.Point(182, 76)
            Me.checkBoxAdv14.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv14.Name = "checkBoxAdv14"
            Me.checkBoxAdv14.Size = New System.Drawing.Size(160, 21)
            Me.checkBoxAdv14.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv14.TabIndex = 11
            Me.checkBoxAdv14.Text = "Print Vrtcl Lines"
            Me.checkBoxAdv14.ThemesEnabled = False
            '
            'checkBoxAdv13
            '
            Me.checkBoxAdv13.Checked = True
            Me.checkBoxAdv13.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv13.Location = New System.Drawing.Point(13, 76)
            Me.checkBoxAdv13.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv13.Name = "checkBoxAdv13"
            Me.checkBoxAdv13.Size = New System.Drawing.Size(150, 21)
            Me.checkBoxAdv13.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv13.TabIndex = 11
            Me.checkBoxAdv13.Text = "Print Hzntl Lines"
            Me.checkBoxAdv13.ThemesEnabled = False
            '
            'checkBoxAdv12
            '
            Me.checkBoxAdv12.Checked = True
            Me.checkBoxAdv12.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv12.Location = New System.Drawing.Point(182, 49)
            Me.checkBoxAdv12.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv12.Name = "checkBoxAdv12"
            Me.checkBoxAdv12.Size = New System.Drawing.Size(150, 21)
            Me.checkBoxAdv12.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv12.TabIndex = 11
            Me.checkBoxAdv12.Text = "Print RowHeader"
            Me.checkBoxAdv12.ThemesEnabled = False
            '
            'checkBoxAdv11
            '
            Me.checkBoxAdv11.Checked = True
            Me.checkBoxAdv11.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv11.Location = New System.Drawing.Point(13, 49)
            Me.checkBoxAdv11.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv11.Name = "checkBoxAdv11"
            Me.checkBoxAdv11.Size = New System.Drawing.Size(163, 21)
            Me.checkBoxAdv11.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv11.TabIndex = 11
            Me.checkBoxAdv11.Text = "Print ColHeader"
            Me.checkBoxAdv11.ThemesEnabled = False
            '
            'checkBoxAdv10
            '
            Me.checkBoxAdv10.Checked = True
            Me.checkBoxAdv10.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv10.Location = New System.Drawing.Point(182, 21)
            Me.checkBoxAdv10.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxAdv10.Name = "checkBoxAdv10"
            Me.checkBoxAdv10.Size = New System.Drawing.Size(130, 20)
            Me.checkBoxAdv10.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv10.TabIndex = 10
            Me.checkBoxAdv10.Text = "Center Vertical"
            Me.checkBoxAdv10.ThemesEnabled = False
            '
            'button3
            '
            Me.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button3.ForeColor = System.Drawing.Color.White
            Me.button3.Location = New System.Drawing.Point(182, 130)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(160, 29)
            Me.button3.TabIndex = 9
            Me.button3.Text = "Print Preview"
            Me.button3.UseVisualStyle = True
            Me.button3.UseVisualStyleBackColor = True
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.gridControl1)
            Me.panel1.Controls.Add(Me.xpTaskBar1)
            Me.panel1.Location = New System.Drawing.Point(0, 12)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1011, 488)
            Me.panel1.TabIndex = 1
            '
            'gridControl1
            '
            GridBaseStyle5.Name = "Row Header"
            GridBaseStyle5.StyleInfo.BaseStyle = "Header"
            GridBaseStyle5.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle5.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.Window, System.Drawing.Color.Lavender)
            GridBaseStyle6.Name = "Column Header"
            GridBaseStyle6.StyleInfo.BaseStyle = "Header"
            GridBaseStyle6.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            GridBaseStyle6.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.Window, System.Drawing.Color.Lavender)
            GridBaseStyle7.Name = "Standard"
            GridBaseStyle7.StyleInfo.Font.Facename = "Tahoma"
            GridBaseStyle7.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle8.Name = "Header"
            GridBaseStyle8.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle8.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle8.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle8.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle8.StyleInfo.CellType = "Header"
            GridBaseStyle8.StyleInfo.Font.Bold = True
            GridBaseStyle8.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.SystemColors.Window, System.Drawing.Color.Lavender)
            GridBaseStyle8.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle5, GridBaseStyle6, GridBaseStyle7, GridBaseStyle8})
            Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
            Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
            Me.gridControl1.DefaultRowHeight = 20
            Me.gridControl1.Font = New System.Drawing.Font("Verdana", 8.5!)
            Me.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.Location = New System.Drawing.Point(12, 3)
            Me.gridControl1.MetroScrollBars = True
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.gridControl1.Properties.MarkColHeader = False
            Me.gridControl1.Properties.MarkRowHeader = False
            GridRangeStyle31.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle31.StyleInfo.Font.Bold = False
            GridRangeStyle31.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle31.StyleInfo.Font.Italic = False
            GridRangeStyle31.StyleInfo.Font.Size = 8.5!
            GridRangeStyle31.StyleInfo.Font.Strikeout = False
            GridRangeStyle31.StyleInfo.Font.Underline = False
            GridRangeStyle31.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle32.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle32.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle32.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle32.StyleInfo.Font.Bold = False
            GridRangeStyle32.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle32.StyleInfo.Font.Italic = False
            GridRangeStyle32.StyleInfo.Font.Size = 8.5!
            GridRangeStyle32.StyleInfo.Font.Strikeout = False
            GridRangeStyle32.StyleInfo.Font.Underline = False
            GridRangeStyle32.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle32.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle32.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle33.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle33.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle33.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle33.StyleInfo.Font.Bold = False
            GridRangeStyle33.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle33.StyleInfo.Font.Italic = False
            GridRangeStyle33.StyleInfo.Font.Size = 8.5!
            GridRangeStyle33.StyleInfo.Font.Strikeout = False
            GridRangeStyle33.StyleInfo.Font.Underline = False
            GridRangeStyle33.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle33.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle33.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle34.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle34.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle34.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle34.StyleInfo.Font.Bold = False
            GridRangeStyle34.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle34.StyleInfo.Font.Italic = False
            GridRangeStyle34.StyleInfo.Font.Size = 8.5!
            GridRangeStyle34.StyleInfo.Font.Strikeout = False
            GridRangeStyle34.StyleInfo.Font.Underline = False
            GridRangeStyle34.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle34.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle34.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle35.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle35.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle35.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle35.StyleInfo.Font.Bold = False
            GridRangeStyle35.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle35.StyleInfo.Font.Italic = False
            GridRangeStyle35.StyleInfo.Font.Size = 8.5!
            GridRangeStyle35.StyleInfo.Font.Strikeout = False
            GridRangeStyle35.StyleInfo.Font.Underline = False
            GridRangeStyle35.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle35.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle35.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle36.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle36.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle36.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle36.StyleInfo.Font.Bold = False
            GridRangeStyle36.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle36.StyleInfo.Font.Italic = False
            GridRangeStyle36.StyleInfo.Font.Size = 8.5!
            GridRangeStyle36.StyleInfo.Font.Strikeout = False
            GridRangeStyle36.StyleInfo.Font.Underline = False
            GridRangeStyle36.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle36.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle36.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle37.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle37.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle37.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle37.StyleInfo.Font.Bold = False
            GridRangeStyle37.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle37.StyleInfo.Font.Italic = False
            GridRangeStyle37.StyleInfo.Font.Size = 8.5!
            GridRangeStyle37.StyleInfo.Font.Strikeout = False
            GridRangeStyle37.StyleInfo.Font.Underline = False
            GridRangeStyle37.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle37.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle37.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle38.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle38.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle38.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle38.StyleInfo.Font.Bold = False
            GridRangeStyle38.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle38.StyleInfo.Font.Italic = False
            GridRangeStyle38.StyleInfo.Font.Size = 8.5!
            GridRangeStyle38.StyleInfo.Font.Strikeout = False
            GridRangeStyle38.StyleInfo.Font.Underline = False
            GridRangeStyle38.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle38.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle38.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle39.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle39.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle39.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle39.StyleInfo.Font.Bold = False
            GridRangeStyle39.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle39.StyleInfo.Font.Italic = False
            GridRangeStyle39.StyleInfo.Font.Size = 8.5!
            GridRangeStyle39.StyleInfo.Font.Strikeout = False
            GridRangeStyle39.StyleInfo.Font.Underline = False
            GridRangeStyle39.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle39.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle39.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle40.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle40.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle40.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle40.StyleInfo.Font.Bold = False
            GridRangeStyle40.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle40.StyleInfo.Font.Italic = False
            GridRangeStyle40.StyleInfo.Font.Size = 8.5!
            GridRangeStyle40.StyleInfo.Font.Strikeout = False
            GridRangeStyle40.StyleInfo.Font.Underline = False
            GridRangeStyle40.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle40.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle40.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle41.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle41.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle41.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle41.StyleInfo.Font.Bold = False
            GridRangeStyle41.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle41.StyleInfo.Font.Italic = False
            GridRangeStyle41.StyleInfo.Font.Size = 8.5!
            GridRangeStyle41.StyleInfo.Font.Strikeout = False
            GridRangeStyle41.StyleInfo.Font.Underline = False
            GridRangeStyle41.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle41.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle41.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle42.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle42.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle42.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle42.StyleInfo.Font.Bold = False
            GridRangeStyle42.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle42.StyleInfo.Font.Italic = False
            GridRangeStyle42.StyleInfo.Font.Size = 8.5!
            GridRangeStyle42.StyleInfo.Font.Strikeout = False
            GridRangeStyle42.StyleInfo.Font.Underline = False
            GridRangeStyle42.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle42.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle42.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle43.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle43.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle43.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle43.StyleInfo.Font.Bold = False
            GridRangeStyle43.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle43.StyleInfo.Font.Italic = False
            GridRangeStyle43.StyleInfo.Font.Size = 8.5!
            GridRangeStyle43.StyleInfo.Font.Strikeout = False
            GridRangeStyle43.StyleInfo.Font.Underline = False
            GridRangeStyle43.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle43.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle43.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle44.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle44.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle44.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle44.StyleInfo.Font.Bold = False
            GridRangeStyle44.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle44.StyleInfo.Font.Italic = False
            GridRangeStyle44.StyleInfo.Font.Size = 8.5!
            GridRangeStyle44.StyleInfo.Font.Strikeout = False
            GridRangeStyle44.StyleInfo.Font.Underline = False
            GridRangeStyle44.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle44.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle44.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle45.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle45.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle45.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle45.StyleInfo.Font.Bold = False
            GridRangeStyle45.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle45.StyleInfo.Font.Italic = False
            GridRangeStyle45.StyleInfo.Font.Size = 8.5!
            GridRangeStyle45.StyleInfo.Font.Strikeout = False
            GridRangeStyle45.StyleInfo.Font.Underline = False
            GridRangeStyle45.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle45.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle45.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle46.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle46.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle46.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle46.StyleInfo.Font.Bold = False
            GridRangeStyle46.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle46.StyleInfo.Font.Italic = False
            GridRangeStyle46.StyleInfo.Font.Size = 8.5!
            GridRangeStyle46.StyleInfo.Font.Strikeout = False
            GridRangeStyle46.StyleInfo.Font.Underline = False
            GridRangeStyle46.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle46.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle46.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle47.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle47.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle47.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle47.StyleInfo.Font.Bold = False
            GridRangeStyle47.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle47.StyleInfo.Font.Italic = False
            GridRangeStyle47.StyleInfo.Font.Size = 8.5!
            GridRangeStyle47.StyleInfo.Font.Strikeout = False
            GridRangeStyle47.StyleInfo.Font.Underline = False
            GridRangeStyle47.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle47.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle47.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle48.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle48.StyleInfo.Font.Bold = False
            GridRangeStyle48.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle48.StyleInfo.Font.Italic = False
            GridRangeStyle48.StyleInfo.Font.Size = 8.5!
            GridRangeStyle48.StyleInfo.Font.Strikeout = False
            GridRangeStyle48.StyleInfo.Font.Underline = False
            GridRangeStyle48.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle49.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle49.StyleInfo.Font.Bold = False
            GridRangeStyle49.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle49.StyleInfo.Font.Italic = False
            GridRangeStyle49.StyleInfo.Font.Size = 8.5!
            GridRangeStyle49.StyleInfo.Font.Strikeout = False
            GridRangeStyle49.StyleInfo.Font.Underline = False
            GridRangeStyle49.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle50.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle50.StyleInfo.Font.Bold = False
            GridRangeStyle50.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle50.StyleInfo.Font.Italic = False
            GridRangeStyle50.StyleInfo.Font.Size = 8.5!
            GridRangeStyle50.StyleInfo.Font.Strikeout = False
            GridRangeStyle50.StyleInfo.Font.Underline = False
            GridRangeStyle50.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle51.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle51.StyleInfo.Font.Bold = False
            GridRangeStyle51.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle51.StyleInfo.Font.Italic = False
            GridRangeStyle51.StyleInfo.Font.Size = 8.5!
            GridRangeStyle51.StyleInfo.Font.Strikeout = False
            GridRangeStyle51.StyleInfo.Font.Underline = False
            GridRangeStyle51.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle52.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle52.StyleInfo.Font.Bold = False
            GridRangeStyle52.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle52.StyleInfo.Font.Italic = False
            GridRangeStyle52.StyleInfo.Font.Size = 8.5!
            GridRangeStyle52.StyleInfo.Font.Strikeout = False
            GridRangeStyle52.StyleInfo.Font.Underline = False
            GridRangeStyle52.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle53.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle53.StyleInfo.Font.Bold = False
            GridRangeStyle53.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle53.StyleInfo.Font.Italic = False
            GridRangeStyle53.StyleInfo.Font.Size = 8.5!
            GridRangeStyle53.StyleInfo.Font.Strikeout = False
            GridRangeStyle53.StyleInfo.Font.Underline = False
            GridRangeStyle53.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle54.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle54.StyleInfo.Font.Bold = False
            GridRangeStyle54.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle54.StyleInfo.Font.Italic = False
            GridRangeStyle54.StyleInfo.Font.Size = 8.5!
            GridRangeStyle54.StyleInfo.Font.Strikeout = False
            GridRangeStyle54.StyleInfo.Font.Underline = False
            GridRangeStyle54.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle55.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle55.StyleInfo.Font.Bold = False
            GridRangeStyle55.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle55.StyleInfo.Font.Italic = False
            GridRangeStyle55.StyleInfo.Font.Size = 8.5!
            GridRangeStyle55.StyleInfo.Font.Strikeout = False
            GridRangeStyle55.StyleInfo.Font.Underline = False
            GridRangeStyle55.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle56.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle56.StyleInfo.Font.Bold = False
            GridRangeStyle56.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle56.StyleInfo.Font.Italic = False
            GridRangeStyle56.StyleInfo.Font.Size = 8.5!
            GridRangeStyle56.StyleInfo.Font.Strikeout = False
            GridRangeStyle56.StyleInfo.Font.Underline = False
            GridRangeStyle56.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle57.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle57.StyleInfo.Font.Bold = False
            GridRangeStyle57.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle57.StyleInfo.Font.Italic = False
            GridRangeStyle57.StyleInfo.Font.Size = 8.5!
            GridRangeStyle57.StyleInfo.Font.Strikeout = False
            GridRangeStyle57.StyleInfo.Font.Underline = False
            GridRangeStyle57.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle58.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle58.StyleInfo.Font.Bold = False
            GridRangeStyle58.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle58.StyleInfo.Font.Italic = False
            GridRangeStyle58.StyleInfo.Font.Size = 8.5!
            GridRangeStyle58.StyleInfo.Font.Strikeout = False
            GridRangeStyle58.StyleInfo.Font.Underline = False
            GridRangeStyle58.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle59.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle59.StyleInfo.Font.Bold = False
            GridRangeStyle59.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle59.StyleInfo.Font.Italic = False
            GridRangeStyle59.StyleInfo.Font.Size = 8.5!
            GridRangeStyle59.StyleInfo.Font.Strikeout = False
            GridRangeStyle59.StyleInfo.Font.Underline = False
            GridRangeStyle59.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle60.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle60.StyleInfo.Font.Bold = False
            GridRangeStyle60.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle60.StyleInfo.Font.Italic = False
            GridRangeStyle60.StyleInfo.Font.Size = 8.5!
            GridRangeStyle60.StyleInfo.Font.Strikeout = False
            GridRangeStyle60.StyleInfo.Font.Underline = False
            GridRangeStyle60.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle31, GridRangeStyle32, GridRangeStyle33, GridRangeStyle34, GridRangeStyle35, GridRangeStyle36, GridRangeStyle37, GridRangeStyle38, GridRangeStyle39, GridRangeStyle40, GridRangeStyle41, GridRangeStyle42, GridRangeStyle43, GridRangeStyle44, GridRangeStyle45, GridRangeStyle46, GridRangeStyle47, GridRangeStyle48, GridRangeStyle49, GridRangeStyle50, GridRangeStyle51, GridRangeStyle52, GridRangeStyle53, GridRangeStyle54, GridRangeStyle55, GridRangeStyle56, GridRangeStyle57, GridRangeStyle58, GridRangeStyle59, GridRangeStyle60})
            Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gridControl1.RowCount = 25
            Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(606, 481)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ThemesEnabled = True
            Me.gridControl1.TransparentBackground = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1024, 510)
            Me.Controls.Add(Me.panel1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Grid Properties Demo"
            CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xpTaskBar1.ResumeLayout(False)
            Me.xpTaskBarBox1.ResumeLayout(False)
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            CType(Me.checkBoxAdv8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xpTaskBarBox2.ResumeLayout(False)
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            CType(Me.checkBoxAdv17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv10, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

        <STAThread()> _
  Shared Sub Main()
            Application.Run(New Form1())
        End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			gridControl1.Model.BaseStylesMap("Header").StyleInfo.Font.Bold = True
			gridControl1.Model.Cols.FreezeRange(1, 1)
			AddHandler gridControl1.QueryCellInfo, AddressOf gridControl1_QueryCellInfo
			AddHandler colorPickerButton1.ColorSelected, AddressOf colorPickerButton1_ColorSelected
			AddHandler colorPickerButton2.ColorSelected, AddressOf colorPickerButton2_ColorSelected
			AddHandler colorPickerButton3.ColorSelected, AddressOf colorPickerButton3_ColorSelected
			AddHandler colorPickerButton4.ColorSelected, AddressOf colorPickerButton4_ColorSelected
			AddHandler colorPickerButton5.ColorSelected, AddressOf colorPickerButton5_ColorSelected
			AddHandler colorPickerButton6.ColorSelected, AddressOf colorPickerButton6_ColorSelected
		End Sub

		#Region "Appearance Properties"




		Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			'Enable or Disable the Grid
			If Me.checkBoxAdv5.Checked Then
				Me.gridControl1.Enabled = True
			Else
				Me.gridControl1.ShowDisabledGridAsGray = True
				Me.gridControl1.Enabled = False
			End If
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

		Private imageFileName As String = Nothing
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			'Browse an image for grid background
			Dim dlg As FileDialog = New OpenFileDialog()
			dlg.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg Files (*.jpg)|*.jpg | All files (*.*)|*.*"
			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Me.checkBoxAdv7.Enabled = True
				Me.imageFileName = dlg.FileName
				Me.gridControl1.BackgroundImage = Image.FromFile(Me.imageFileName)
			End If
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			'Remove background image
			Me.gridControl1.BackgroundImage = Nothing
		End Sub
		Private Sub colorPickerButton6_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			'set grid textcolor
			Me.gridControl1.TableStyle.TextColor = Me.colorPickerButton6.SelectedColor
		End Sub
		Private Sub colorPickerButton5_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			'set resizing cells linecolor
			Me.gridControl1.Properties.ResizingCellsLinesColor = Me.colorPickerButton5.SelectedColor
		End Sub

		Private Sub colorPickerButton4_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			'set grid linecolor
			If checkBoxAdv4.Checked Then
				Me.gridControl1.TableStyle.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Me.colorPickerButton4.SelectedColor)
				Me.gridControl1.TableStyle.Borders.Top = New GridBorder(GridBorderStyle.Solid, Me.colorPickerButton4.SelectedColor)
				temp1 = True
			End If
			If checkBoxAdv4.Checked Then
				Me.gridControl1.TableStyle.Borders.Left = New GridBorder(GridBorderStyle.Solid, Me.colorPickerButton4.SelectedColor)
				Me.gridControl1.TableStyle.Borders.Right = New GridBorder(GridBorderStyle.Solid, Me.colorPickerButton4.SelectedColor)
				temp2 = True
			End If
		End Sub

		Private Sub colorPickerButton3_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			'set fixed lines color
			Me.gridControl1.Properties.FixedLinesColor = Me.colorPickerButton3.SelectedColor
			Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid
		End Sub

		Private Sub colorPickerButton2_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			'set grid background color
			Me.gridControl1.BackColor = Me.colorPickerButton2.SelectedColor
		End Sub

		Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			'set grid back color
			Me.gridControl1.BackColor = Me.colorPickerButton1.SelectedColor
		End Sub


		Private Sub gridControl1_QueryCellInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs)
			If e.RowIndex > 0 AndAlso e.ColIndex > 0 Then
				e.Style.Text = String.Format("Row{0}:Col{0}", e.RowIndex, e.ColIndex)
			End If
		End Sub
		#End Region

		#Region "Printer related properties"


		Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
			'Print Preview
			Try
				Dim pd As New GridPrintDocument(Me.gridControl1, True)
				Dim dlg As New PrintPreviewDialog()
				dlg.Document = pd
				dlg.ShowDialog()
			Catch excep As Exception
				MessageBox.Show("Error :" & excep.Message)
			End Try
		End Sub
		#End Region

		Private Sub xpTaskBarBox2_ItemClick(ByVal sender As Object, ByVal e As XPTaskBarItemClickArgs) Handles xpTaskBarBox2.ItemClick

		End Sub

		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click
			If Me.gridControl1.NumberedRowHeaders Then
				Me.gridControl1.NumberedRowHeaders = False
			Else
				Me.gridControl1.NumberedRowHeaders = True
			End If
			If Me.gridControl1.NumberedColHeaders Then
				Me.gridControl1.NumberedColHeaders = False
			Else
				Me.gridControl1.NumberedColHeaders = True
			End If
		End Sub

		Private Sub checkBoxAdv1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv1.CheckStateChanged
			'Enable or disable the disply of Column Headers
			If Me.checkBoxAdv1.Checked Then
				Me.gridControl1.Properties.ColHeaders = True
			Else
				Me.gridControl1.Properties.ColHeaders = False
			End If
		End Sub

		Private Sub checkBoxAdv2_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv2.CheckStateChanged
			'Enable or disable the disply of Row Headers
			If Me.checkBoxAdv2.Checked Then
				Me.gridControl1.Properties.RowHeaders = True
			Else
				Me.gridControl1.Properties.RowHeaders = False
			End If
		End Sub

		Private Sub checkBoxAdv3_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv3.CheckStateChanged

			'Enable or disable the disply of horizontal grid lines
			If Me.checkBoxAdv3.Checked Then
				Me.gridControl1.Properties.DisplayHorzLines = True
				If temp1 Then
					Me.gridControl1.TableStyle.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Me.colorPickerButton4.SelectedColor)
					Me.gridControl1.TableStyle.Borders.Top = New GridBorder(GridBorderStyle.Solid, Me.colorPickerButton4.SelectedColor)
				End If
			Else
				Me.gridControl1.Properties.DisplayHorzLines = False
				If temp1 Then
					Me.gridControl1.TableStyle.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.Transparent)
					Me.gridControl1.TableStyle.Borders.Top = New GridBorder(GridBorderStyle.Solid, Color.Transparent)
				End If
			End If
		End Sub

		Private Sub checkBoxAdv4_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv4.CheckStateChanged

			'Enable or disable the display of vertical grid lines
			If Me.checkBoxAdv4.Checked Then
				Me.gridControl1.Properties.DisplayVertLines = True
				If temp2 Then
					Me.gridControl1.TableStyle.Borders.Right = New GridBorder(GridBorderStyle.Solid, Me.colorPickerButton4.SelectedColor)
					Me.gridControl1.TableStyle.Borders.Left = New GridBorder(GridBorderStyle.Solid, Me.colorPickerButton4.SelectedColor)
				End If
			Else
				Me.gridControl1.Properties.DisplayVertLines = False
				If temp2 Then
					Me.gridControl1.TableStyle.Borders.Right = New GridBorder(GridBorderStyle.Solid, Color.Transparent)
					Me.gridControl1.TableStyle.Borders.Left = New GridBorder(GridBorderStyle.Solid, Color.Transparent)
				End If
			End If
		End Sub

		Private Sub checkBoxAdv5_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv5.CheckStateChanged

			'Enable or Disable the Grid
			If Me.checkBoxAdv5.Checked Then
				Me.gridControl1.Enabled = True
			Else
				Me.gridControl1.ShowDisabledGridAsGray = True
				Me.gridControl1.Enabled = False
			End If
		End Sub

		Private Sub checkBoxAdv7_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv7.CheckStateChanged
			'Enable or disable transparent background
			If Me.checkBoxAdv7.Checked Then
				Me.gridControl1.TransparentBackground = False
				'Specify background image
				Me.gridControl1.BackgroundImage = Image.FromFile(FindImageFile("common\Images\Grid\GridProperties\pic.jpg"))
				Me.colorPickerButton1.Enabled = True
				Me.button1.Enabled = True
			Else
				Me.colorPickerButton1.Enabled = False
				Me.button1.Enabled = False
				Me.gridControl1.TransparentBackground = True
				Me.gridControl1.BackgroundImage = Nothing
			End If
		End Sub

		Private Sub checkBoxAdv8_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv8.CheckStateChanged
			'Specify if row/col headers should appear raised or flat
			If Me.checkBoxAdv8.Checked Then
				Me.gridControl1.Properties.Buttons3D = True
			Else
				Me.gridControl1.Properties.Buttons3D = False
			End If
		End Sub

		Private Sub checkBoxAdv9_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv9.CheckStateChanged
			'Specify if the grid should be centered horizontally on printing
			If Me.checkBoxAdv9.Checked Then
				Me.gridControl1.Properties.CenterHorizontal = True
			Else
				Me.gridControl1.Properties.CenterHorizontal = False
			End If
		End Sub

		Private Sub checkBoxAdv10_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv10.CheckStateChanged

			'Specify if the grid should be centered vertically on printing
			If Me.checkBoxAdv10.Checked Then
				Me.gridControl1.Properties.CenterVertical = True
			Else
				Me.gridControl1.Properties.CenterVertical = False
			End If
		End Sub

		Private Sub checkBoxAdv11_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv11.CheckStateChanged
			'Specify if column headers should be printed 
			If Me.checkBoxAdv11.Checked Then
				Me.gridControl1.Properties.PrintColHeader = True
			Else
				Me.gridControl1.Properties.PrintColHeader = False
			End If
		End Sub

		Private Sub checkBoxAdv12_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv12.CheckStateChanged
			'Specify if row headers should be printed
			If Me.checkBoxAdv12.Checked Then
				Me.gridControl1.Properties.PrintRowHeader = True
			Else
				Me.gridControl1.Properties.PrintRowHeader = False
			End If
		End Sub

		Private Sub checkBoxAdv13_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv13.CheckStateChanged
			'Specify if grid horizontal lines should be printed
			If Me.checkBoxAdv13.Checked Then
				Me.gridControl1.Properties.PrintHorzLines = True
			Else
				Me.gridControl1.Properties.PrintHorzLines = False
			End If
		End Sub

		Private Sub checkBoxAdv14_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv14.CheckStateChanged
			'Specify if grid vertical lines should be printed
			If Me.checkBoxAdv14.Checked Then
				Me.gridControl1.Properties.PrintVertLines = True
			Else
				Me.gridControl1.Properties.PrintVertLines = False
			End If
		End Sub

		Private Sub checkBoxAdv15_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv15.CheckStateChanged
			'Specify if a frame should be drawn around the grid when printing
			If Me.checkBoxAdv15.Checked Then
				Me.gridControl1.Properties.PrintFrame = True
			Else
				Me.gridControl1.Properties.PrintFrame = False
			End If
		End Sub

		Private Sub checkBoxAdv16_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv16.CheckStateChanged
			'Specify if the grid should be printed only in black and white
			If Me.checkBoxAdv16.Checked Then
				Me.gridControl1.Properties.BlackWhite = True
			Else
				Me.gridControl1.Properties.BlackWhite = False
			End If
		End Sub

		Private Sub checkBoxAdv17_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv17.CheckStateChanged
			'Switch print mode
			If Me.checkBoxAdv17.Checked Then
				Me.gridControl1.Properties.Printing = True
			Else
				Me.gridControl1.Properties.Printing = False
			End If
		End Sub




	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace ProgressBarAdvProperties
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents Timer As System.Windows.Forms.Timer
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private WithEvents checkBoxAdv2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private label6 As System.Windows.Forms.Label
		Private WithEvents comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private groupBox5 As System.Windows.Forms.GroupBox
		Private WithEvents buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private progressBarAdv1 As Syncfusion.Windows.Forms.Tools.ProgressBarAdv
		Private WithEvents checkBoxAdv3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private label9 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private WithEvents numericUpDownExt1 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private components As System.ComponentModel.IContainer
		Private WithEvents checkBoxAdv4 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private label5 As Label
		Private Start As Boolean

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'this.comboBoxAdv1.DataSource = Enum.GetValues(typeof (Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles)); 

		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.Timer = New System.Windows.Forms.Timer(Me.components)
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.label6 = New System.Windows.Forms.Label()
			Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.checkBoxAdv3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.label9 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.numericUpDownExt1 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt()
			Me.groupBox5 = New System.Windows.Forms.GroupBox()
			Me.progressBarAdv1 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
			Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.label5 = New System.Windows.Forms.Label()
			Me.checkBoxAdv4 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.groupBox2.SuspendLayout()
			CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox5.SuspendLayout()
			CType(Me.progressBarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAdv4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' Timer
			' 
			Me.Timer.Enabled = True
'			Me.Timer.Tick += New System.EventHandler(Me.timer2_Tick);
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.checkBoxAdv2)
			Me.groupBox2.Controls.Add(Me.colorPickerButton1)
			Me.groupBox2.Controls.Add(Me.label4)
			Me.groupBox2.Controls.Add(Me.numericUpDownExt1)
			Me.groupBox2.Controls.Add(Me.label6)
			Me.groupBox2.Controls.Add(Me.comboBoxAdv1)
			Me.groupBox2.Controls.Add(Me.checkBoxAdv1)
			Me.groupBox2.Controls.Add(Me.label3)
			Me.groupBox2.Controls.Add(Me.label2)
			Me.groupBox2.Controls.Add(Me.label1)
			Me.groupBox2.Controls.Add(Me.checkBoxAdv4)
			Me.groupBox2.Controls.Add(Me.checkBoxAdv3)
			Me.groupBox2.Controls.Add(Me.label5)
			Me.groupBox2.Controls.Add(Me.label9)
			Me.groupBox2.Location = New System.Drawing.Point(336, 8)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(312, 287)
			Me.groupBox2.TabIndex = 7
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Text Properties"
			' 
			' checkBoxAdv2
			' 
			Me.checkBoxAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv2.Checked = False
			Me.checkBoxAdv2.CheckState = System.Windows.Forms.CheckState.Unchecked
			Me.checkBoxAdv2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark
			Me.checkBoxAdv2.GradientStart = System.Drawing.SystemColors.Control
			Me.checkBoxAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv2.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
			Me.checkBoxAdv2.Location = New System.Drawing.Point(136, 144)
			Me.checkBoxAdv2.Name = "checkBoxAdv2"
			Me.checkBoxAdv2.ShadowColor = System.Drawing.Color.Black
			Me.checkBoxAdv2.ShadowOffset = New System.Drawing.Point(2, 2)
			Me.checkBoxAdv2.Size = New System.Drawing.Size(52, 17)
			Me.checkBoxAdv2.StretchImage = False
			Me.checkBoxAdv2.TabIndex = 10
			Me.checkBoxAdv2.Text = "Yes"
			Me.checkBoxAdv2.ThemesEnabled = True
'			Me.checkBoxAdv2.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv2_CheckStateChanged);
			' 
			' colorPickerButton1
			' 
			Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.colorPickerButton1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.colorPickerButton1.Location = New System.Drawing.Point(136, 104)
			Me.colorPickerButton1.Name = "colorPickerButton1"
			Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.colorPickerButton1.Size = New System.Drawing.Size(152, 23)
			Me.colorPickerButton1.TabIndex = 9
			Me.colorPickerButton1.Text = "Pick the text color"
'			Me.colorPickerButton1.ColorSelected += New System.EventHandler(Me.colorPickerButton1_ColorSelected);
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label6.Location = New System.Drawing.Point(16, 104)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(56, 14)
			Me.label6.TabIndex = 8
			Me.label6.Text = "Font Color"
			' 
			' comboBoxAdv1
			' 
			Me.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBoxAdv1.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.System
			Me.comboBoxAdv1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBoxAdv1.IgnoreThemeBackground = True
			Me.comboBoxAdv1.Items.AddRange(New Object() { "Percentage", "Value"})
			Me.comboBoxAdv1.Location = New System.Drawing.Point(136, 64)
			Me.comboBoxAdv1.Name = "comboBoxAdv1"
			Me.comboBoxAdv1.Size = New System.Drawing.Size(152, 21)
			Me.comboBoxAdv1.SuppressDropDownEvent = False
			Me.comboBoxAdv1.TabIndex = 6
'			Me.comboBoxAdv1.SelectedIndexChanged += New System.EventHandler(Me.comboBoxAdv1_SelectedIndexChanged);
			' 
			' checkBoxAdv1
			' 
			Me.checkBoxAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark
			Me.checkBoxAdv1.GradientStart = System.Drawing.SystemColors.Control
			Me.checkBoxAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
			Me.checkBoxAdv1.Location = New System.Drawing.Point(136, 24)
			Me.checkBoxAdv1.Name = "checkBoxAdv1"
			Me.checkBoxAdv1.ShadowColor = System.Drawing.Color.Black
			Me.checkBoxAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
			Me.checkBoxAdv1.Size = New System.Drawing.Size(52, 17)
			Me.checkBoxAdv1.StretchImage = False
			Me.checkBoxAdv1.TabIndex = 5
			Me.checkBoxAdv1.Text = "Yes"
			Me.checkBoxAdv1.ThemesEnabled = True
'			Me.checkBoxAdv1.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv1_CheckStateChanged);
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.Location = New System.Drawing.Point(16, 144)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(72, 14)
			Me.label3.TabIndex = 2
			Me.label3.Text = "Text Shadow"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(16, 64)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(55, 14)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Text Style"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(16, 24)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(63, 14)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Text Visible"
			' 
			' checkBoxAdv3
			' 
			Me.checkBoxAdv3.BorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv3.Checked = False
			Me.checkBoxAdv3.CheckState = System.Windows.Forms.CheckState.Unchecked
			Me.checkBoxAdv3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxAdv3.GradientEnd = System.Drawing.SystemColors.ControlDark
			Me.checkBoxAdv3.GradientStart = System.Drawing.SystemColors.Control
			Me.checkBoxAdv3.HotBorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv3.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
			Me.checkBoxAdv3.Location = New System.Drawing.Point(136, 217)
			Me.checkBoxAdv3.Name = "checkBoxAdv3"
			Me.checkBoxAdv3.ShadowColor = System.Drawing.Color.Black
			Me.checkBoxAdv3.ShadowOffset = New System.Drawing.Point(2, 2)
			Me.checkBoxAdv3.Size = New System.Drawing.Size(52, 17)
			Me.checkBoxAdv3.StretchImage = False
			Me.checkBoxAdv3.TabIndex = 12
			Me.checkBoxAdv3.Text = "Yes"
			Me.checkBoxAdv3.ThemesEnabled = True
'			Me.checkBoxAdv3.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv3_CheckStateChanged);
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label9.Location = New System.Drawing.Point(16, 217)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(82, 14)
			Me.label9.TabIndex = 11
			Me.label9.Text = "Back Segments"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label4.Location = New System.Drawing.Point(17, 254)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(79, 14)
			Me.label4.TabIndex = 1
			Me.label4.Text = "Segment Width"
			' 
			' numericUpDownExt1
			' 
			Me.numericUpDownExt1.BorderColor = System.Drawing.Color.Black
			Me.numericUpDownExt1.Enabled = False
			Me.numericUpDownExt1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.numericUpDownExt1.Location = New System.Drawing.Point(136, 248)
			Me.numericUpDownExt1.Maximum = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.numericUpDownExt1.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.numericUpDownExt1.Name = "numericUpDownExt1"
			Me.numericUpDownExt1.Size = New System.Drawing.Size(152, 20)
			Me.numericUpDownExt1.TabIndex = 0
			Me.numericUpDownExt1.Value = New Decimal(New Integer() { 1, 0, 0, 0})
'			Me.numericUpDownExt1.ValueChanged += New System.EventHandler(Me.numericUpDownExt1_ValueChanged);
			' 
			' groupBox5
			' 
			Me.groupBox5.Controls.Add(Me.progressBarAdv1)
			Me.groupBox5.Controls.Add(Me.buttonAdv1)
			Me.groupBox5.Controls.Add(Me.buttonAdv2)
			Me.groupBox5.Location = New System.Drawing.Point(8, 8)
			Me.groupBox5.Name = "groupBox5"
			Me.groupBox5.Size = New System.Drawing.Size(312, 152)
			Me.groupBox5.TabIndex = 8
			Me.groupBox5.TabStop = False
			Me.groupBox5.Text = "Demo"
			' 
			' progressBarAdv1
			' 
			Me.progressBarAdv1.BackGradientEndColor = System.Drawing.Color.White
			Me.progressBarAdv1.BackGradientStartColor = System.Drawing.Color.White
			Me.progressBarAdv1.BackgroundFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient
			Me.progressBarAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient
			Me.progressBarAdv1.BackMultipleColors = New System.Drawing.Color() { System.Drawing.Color.Red}
			Me.progressBarAdv1.BackSegments = False
			Me.progressBarAdv1.BackTubeEndColor = System.Drawing.Color.White
			Me.progressBarAdv1.BackTubeStartColor = System.Drawing.Color.White
			Me.progressBarAdv1.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(119))))), (CInt(Fix((CByte(101))))), (CInt(Fix((CByte(91))))))
			Me.progressBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.progressBarAdv1.CustomWaitingRender = False
			Me.progressBarAdv1.FontColor = System.Drawing.Color.Black
			Me.progressBarAdv1.ForeColor = System.Drawing.Color.White
			Me.progressBarAdv1.ForegroundImage = Nothing
			Me.progressBarAdv1.ForeSegments = False
			Me.progressBarAdv1.GradientEndColor = System.Drawing.Color.Lime
			Me.progressBarAdv1.GradientStartColor = System.Drawing.Color.RosyBrown
			Me.progressBarAdv1.Location = New System.Drawing.Point(24, 35)
			Me.progressBarAdv1.MultipleColors = New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128)))))), System.Drawing.Color.Blue, System.Drawing.Color.Magenta}
			Me.progressBarAdv1.Name = "progressBarAdv1"
			Me.progressBarAdv1.ProgressFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube
			Me.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube
			Me.progressBarAdv1.SegmentWidth = 2
			Me.progressBarAdv1.Size = New System.Drawing.Size(248, 24)
			Me.progressBarAdv1.TabIndex = 0
			Me.progressBarAdv1.Text = "progressBarAdv1"
			Me.progressBarAdv1.TextShadow = False
			Me.progressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value
			Me.progressBarAdv1.ThemesEnabled = True
			Me.progressBarAdv1.TubeEndColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(251))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(106))))))
			Me.progressBarAdv1.TubeStartColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(183))))), (CInt(Fix((CByte(74))))), (CInt(Fix((CByte(7))))))
			Me.progressBarAdv1.WaitingGradientWidth = 400
			' 
			' buttonAdv1
			' 
			Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.buttonAdv1.KeepFocusRectangle = False
			Me.buttonAdv1.Location = New System.Drawing.Point(48, 107)
			Me.buttonAdv1.Name = "buttonAdv1"
			Me.buttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver
			Me.buttonAdv1.Size = New System.Drawing.Size(75, 23)
			Me.buttonAdv1.TabIndex = 1
			Me.buttonAdv1.Text = "START"
			Me.buttonAdv1.UseVisualStyle = True
'			Me.buttonAdv1.Click += New System.EventHandler(Me.buttonAdv1_Click);
			' 
			' buttonAdv2
			' 
			Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.buttonAdv2.KeepFocusRectangle = False
			Me.buttonAdv2.Location = New System.Drawing.Point(144, 107)
			Me.buttonAdv2.Name = "buttonAdv2"
			Me.buttonAdv2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver
			Me.buttonAdv2.Size = New System.Drawing.Size(75, 23)
			Me.buttonAdv2.TabIndex = 2
			Me.buttonAdv2.Text = "STOP"
			Me.buttonAdv2.UseVisualStyle = True
'			Me.buttonAdv2.Click += New System.EventHandler(Me.buttonAdv2_Click);
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label5.Location = New System.Drawing.Point(16, 180)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(80, 14)
			Me.label5.TabIndex = 11
			Me.label5.Text = "Fore Segments"
			' 
			' checkBoxAdv4
			' 
			Me.checkBoxAdv4.BorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv4.Checked = False
			Me.checkBoxAdv4.CheckState = System.Windows.Forms.CheckState.Unchecked
			Me.checkBoxAdv4.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxAdv4.GradientEnd = System.Drawing.SystemColors.ControlDark
			Me.checkBoxAdv4.GradientStart = System.Drawing.SystemColors.Control
			Me.checkBoxAdv4.HotBorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv4.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
			Me.checkBoxAdv4.Location = New System.Drawing.Point(136, 180)
			Me.checkBoxAdv4.Name = "checkBoxAdv4"
			Me.checkBoxAdv4.ShadowColor = System.Drawing.Color.Black
			Me.checkBoxAdv4.ShadowOffset = New System.Drawing.Point(2, 2)
			Me.checkBoxAdv4.Size = New System.Drawing.Size(52, 17)
			Me.checkBoxAdv4.StretchImage = False
			Me.checkBoxAdv4.TabIndex = 12
			Me.checkBoxAdv4.Text = "Yes"
			Me.checkBoxAdv4.ThemesEnabled = True
'			Me.checkBoxAdv4.CheckStateChanged += New System.EventHandler(Me.checkBoxForeSeg_CheckStateChanged);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(246))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(254))))))
			Me.ClientSize = New System.Drawing.Size(658, 320)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox5)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.KeyPreview = True
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "ProgressBar Features"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox5.ResumeLayout(False)
			CType(Me.progressBarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxAdv4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.comboBoxAdv1.SelectedIndex = 1
			checkBoxAdv1.Checked = True
            checkBoxAdv2.Checked = False
            numericUpDownExt1.Value = 4
		End Sub

		#Region "Start"
		Private Sub buttonAdv2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonAdv2.Click
			Start = False
		End Sub

		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonAdv1.Click
			Start = True
		End Sub
		#End Region

		#Region "BackSegments"
		Private Sub checkBoxAdv3_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxAdv3.CheckStateChanged
			Me.progressBarAdv1.BackSegments = Me.checkBoxAdv3.Checked
		End Sub
		#End Region

		#Region "TextShadow"
		Private Sub checkBoxAdv2_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxAdv2.CheckStateChanged
			Me.progressBarAdv1.TextShadow = Me.checkBoxAdv2.Checked
		End Sub
		#End Region

		#Region "TextVisible"
		Private Sub checkBoxAdv1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxAdv1.CheckStateChanged
			Me.progressBarAdv1.TextVisible = Me.checkBoxAdv1.Checked
		End Sub
		#End Region

		#Region "SegmentWidth"
		Private Sub numericUpDownExt1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDownExt1.ValueChanged
			Me.progressBarAdv1.SegmentWidth = Convert.ToInt32(Me.numericUpDownExt1.Value)
		End Sub
		#End Region
		#Region "TextStyle"
		Private Sub comboBoxAdv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxAdv1.SelectedIndexChanged
			If Me.comboBoxAdv1.SelectedIndex = 0 Then
				Me.progressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Percentage
			End If
			If Me.comboBoxAdv1.SelectedIndex = 1 Then
				Me.progressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value
			End If
		End Sub
		#End Region

		#Region "FontColor"
		Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorPickerButton1.ColorSelected
			Me.progressBarAdv1.FontColor = Me.colorPickerButton1.ColorUI.SelectedColor
		End Sub
		#End Region

		#Region "timer"
		Private Sub timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
			If Start Then
				If Me.progressBarAdv1.Value < 100 Then
					Me.progressBarAdv1.Value += 1
				Else
					Me.progressBarAdv1.Value = 0
				End If
			End If
		End Sub
		#End Region

		Private Sub checkBoxForeSeg_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv4.CheckStateChanged
			Me.progressBarAdv1.ForeSegments = checkBoxAdv4.Checked
			Me.numericUpDownExt1.Enabled = checkBoxAdv4.Checked
		End Sub
	End Class
End Namespace

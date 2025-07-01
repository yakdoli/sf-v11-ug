#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace ProgressBarDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class FormMain
		Inherits System.Windows.Forms.Form
		Public progressBarAdv1 As ProgressBarAdv
		Private progressBarAdv3 As ProgressBarAdv
		Private progressBarAdv4 As ProgressBarAdv
		Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private progressBarAdv7 As ProgressBarAdv
		Private progressBarAdv2 As ProgressBarAdv
		Private progressBarAdv5 As ProgressBarAdv
		Private progressBarAdv6 As ProgressBarAdv
		Private progressBarAdv9 As ProgressBarAdv
		Private progressBarAdv10 As ProgressBarAdv
		Private progressBarAdv11 As ProgressBarAdv
		Private progressBarAdv12 As ProgressBarAdv
		Private progressBarAdv13 As ProgressBarAdv
		Private progressBarAdv14 As ProgressBarAdv
		Private WithEvents timer As System.Windows.Forms.Timer
		Private WithEvents TestButton As System.Windows.Forms.Button
        Private WithEvents StopBtn As System.Windows.Forms.Button
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private progressBarWaiting As ProgressBarAdv
        Private components As System.ComponentModel.IContainer

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
            Me.progressBarAdv1 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.progressBarAdv3 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.progressBarAdv4 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
            Me.progressBarAdv7 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.progressBarAdv2 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.progressBarAdv5 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.progressBarAdv6 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.progressBarAdv9 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.progressBarAdv10 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.progressBarAdv11 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.progressBarAdv12 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.progressBarAdv13 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.progressBarAdv14 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            Me.timer = New System.Windows.Forms.Timer(Me.components)
            Me.TestButton = New System.Windows.Forms.Button()
            Me.StopBtn = New System.Windows.Forms.Button()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.progressBarWaiting = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv()
            CType(Me.progressBarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progressBarAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progressBarAdv4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progressBarAdv7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progressBarAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progressBarAdv5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progressBarAdv6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progressBarAdv9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progressBarAdv10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progressBarAdv11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progressBarAdv12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progressBarAdv13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.progressBarAdv14, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.progressBarWaiting, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' progressBarAdv1
            ' 
            Me.progressBarAdv1.BackColor = System.Drawing.SystemColors.Control
            Me.progressBarAdv1.BackGradientEndColor = System.Drawing.SystemColors.ControlLightLight
            Me.progressBarAdv1.BackGradientStartColor = System.Drawing.SystemColors.ControlDark
            Me.progressBarAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient
            Me.progressBarAdv1.BackMultipleColors = New System.Drawing.Color() {System.Drawing.SystemColors.ControlDark, System.Drawing.SystemColors.ControlLightLight, System.Drawing.SystemColors.Control}
            Me.progressBarAdv1.BackSegments = False
            Me.progressBarAdv1.BackTubeEndColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0))))))
            Me.progressBarAdv1.BackTubeStartColor = System.Drawing.Color.Yellow
            Me.progressBarAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
            Me.progressBarAdv1.BorderColor = System.Drawing.Color.Black
            Me.progressBarAdv1.CustomWaitingRender = False
            Me.progressBarAdv1.FontColor = System.Drawing.SystemColors.HighlightText
            Me.progressBarAdv1.ForeColor = System.Drawing.Color.MediumBlue
            Me.progressBarAdv1.ForegroundImage = Nothing
            Me.progressBarAdv1.ForeSegments = False
            Me.progressBarAdv1.GradientEndColor = System.Drawing.Color.Magenta
            Me.progressBarAdv1.GradientStartColor = System.Drawing.Color.Orange
            Me.progressBarAdv1.Location = New System.Drawing.Point(236, 12)
            Me.progressBarAdv1.MultipleColors = New System.Drawing.Color() {System.Drawing.Color.DarkRed, System.Drawing.Color.Red, System.Drawing.Color.Black}
            Me.progressBarAdv1.Name = "progressBarAdv1"
            Me.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube
            Me.progressBarAdv1.SegmentWidth = 20
            Me.progressBarAdv1.Size = New System.Drawing.Size(240, 23)
            Me.progressBarAdv1.StretchImage = False
            Me.progressBarAdv1.StretchMultGrad = False
            Me.progressBarAdv1.TabIndex = 0
            Me.progressBarAdv1.TextShadow = False
            Me.progressBarAdv1.TextVisible = False
            Me.progressBarAdv1.ThemesEnabled = False
            Me.progressBarAdv1.TubeEndColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(192))))))
            Me.progressBarAdv1.TubeStartColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(101))))), (CInt(Fix((CByte(151))))), (CInt(Fix((CByte(226))))))
            Me.progressBarAdv1.Value = 79
            Me.progressBarAdv1.WaitingGradientEnabled = True
            Me.progressBarAdv1.WaitingGradientWidth = 400
            ' 
            ' progressBarAdv3
            ' 
            Me.progressBarAdv3.BackGradientEndColor = System.Drawing.Color.Green
            Me.progressBarAdv3.BackGradientStartColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(0))))))
            Me.progressBarAdv3.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient
            Me.progressBarAdv3.BackMultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv3.BackSegments = False
            Me.progressBarAdv3.BackTubeEndColor = System.Drawing.SystemColors.Control
            Me.progressBarAdv3.BackTubeStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv3.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched
            Me.progressBarAdv3.BorderColor = System.Drawing.Color.Black
            Me.progressBarAdv3.CustomWaitingRender = False
            Me.progressBarAdv3.FontColor = System.Drawing.Color.Lime
            Me.progressBarAdv3.ForegroundImage = Nothing
            Me.progressBarAdv3.GradientEndColor = System.Drawing.Color.Lime
            Me.progressBarAdv3.GradientStartColor = System.Drawing.Color.Red
            Me.progressBarAdv3.Location = New System.Drawing.Point(236, 44)
            Me.progressBarAdv3.MultipleColors = New System.Drawing.Color() {System.Drawing.SystemColors.ControlDarkDark, System.Drawing.SystemColors.ControlLight, System.Drawing.SystemColors.ControlDark, System.Drawing.SystemColors.Control}
            Me.progressBarAdv3.Name = "progressBarAdv3"
            Me.progressBarAdv3.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube
            Me.progressBarAdv3.SegmentWidth = 12
            Me.progressBarAdv3.Size = New System.Drawing.Size(240, 23)
            Me.progressBarAdv3.TabIndex = 2
            Me.progressBarAdv3.TextVisible = False
            Me.progressBarAdv3.ThemesEnabled = False
            Me.progressBarAdv3.TubeEndColor = System.Drawing.Color.Black
            Me.progressBarAdv3.TubeStartColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(0))))))
            Me.progressBarAdv3.Value = 75
            Me.progressBarAdv3.WaitingGradientWidth = 400
            ' 
            ' progressBarAdv4
            ' 
            Me.progressBarAdv4.BackGradientEndColor = System.Drawing.Color.White
            Me.progressBarAdv4.BackGradientStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv4.BackgroundImage = (CType(resources.GetObject("progressBarAdv4.BackgroundImage"), System.Drawing.Image))
            Me.progressBarAdv4.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Image
            Me.progressBarAdv4.BackMultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv4.BackSegments = False
            Me.progressBarAdv4.BackTubeEndColor = System.Drawing.Color.White
            Me.progressBarAdv4.BackTubeStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv4.BorderColor = System.Drawing.Color.Black
            Me.progressBarAdv4.CustomWaitingRender = False
            Me.progressBarAdv4.FontColor = System.Drawing.SystemColors.Control
            Me.progressBarAdv4.ForegroundImage = (CType(resources.GetObject("progressBarAdv4.ForegroundImage"), System.Drawing.Image))
            Me.progressBarAdv4.GradientEndColor = System.Drawing.Color.Lime
            Me.progressBarAdv4.GradientStartColor = System.Drawing.Color.Red
            Me.progressBarAdv4.Location = New System.Drawing.Point(236, 84)
            Me.progressBarAdv4.MultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv4.Name = "progressBarAdv4"
            Me.progressBarAdv4.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Image
            Me.progressBarAdv4.SegmentWidth = 12
            Me.progressBarAdv4.Size = New System.Drawing.Size(240, 23)
            Me.progressBarAdv4.StretchImage = False
            Me.progressBarAdv4.TabIndex = 3
            Me.progressBarAdv4.ThemesEnabled = False
            Me.progressBarAdv4.TubeEndColor = System.Drawing.Color.Black
            Me.progressBarAdv4.TubeStartColor = System.Drawing.Color.Red
            Me.progressBarAdv4.Value = 75
            Me.progressBarAdv4.WaitingGradientWidth = 400
            ' 
            ' numericUpDown1
            ' 
            Me.numericUpDown1.Increment = New Decimal(New Integer() {5, 0, 0, 0})
            Me.numericUpDown1.Location = New System.Drawing.Point(297, 18)
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(80, 20)
            Me.numericUpDown1.TabIndex = 7
            '			Me.numericUpDown1.ValueChanged += New System.EventHandler(Me.numericUpDown1_ValueChanged);
            ' 
            ' progressBarAdv7
            ' 
            Me.progressBarAdv7.BackGradientEndColor = System.Drawing.SystemColors.ControlLightLight
            Me.progressBarAdv7.BackGradientStartColor = System.Drawing.SystemColors.ControlDark
            Me.progressBarAdv7.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient
            Me.progressBarAdv7.BackMultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv7.BackSegments = False
            Me.progressBarAdv7.BackTubeEndColor = System.Drawing.Color.Silver
            Me.progressBarAdv7.BackTubeStartColor = System.Drawing.Color.White
            Me.progressBarAdv7.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
            Me.progressBarAdv7.BorderColor = System.Drawing.Color.IndianRed
            Me.progressBarAdv7.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None
            Me.progressBarAdv7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.progressBarAdv7.CustomWaitingRender = False
            Me.progressBarAdv7.FontColor = System.Drawing.Color.White
            Me.progressBarAdv7.ForegroundImage = Nothing
            Me.progressBarAdv7.GradientEndColor = System.Drawing.Color.Lime
            Me.progressBarAdv7.GradientStartColor = System.Drawing.Color.Red
            Me.progressBarAdv7.Location = New System.Drawing.Point(236, 116)
            Me.progressBarAdv7.MultipleColors = New System.Drawing.Color() {System.Drawing.SystemColors.ControlDarkDark, System.Drawing.SystemColors.ControlLightLight, System.Drawing.SystemColors.ActiveCaption}
            Me.progressBarAdv7.Name = "progressBarAdv7"
            Me.progressBarAdv7.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube
            Me.progressBarAdv7.SegmentWidth = 8
            Me.progressBarAdv7.Size = New System.Drawing.Size(240, 23)
            Me.progressBarAdv7.StretchImage = False
            Me.progressBarAdv7.TabIndex = 8
            Me.progressBarAdv7.TextVisible = False
            Me.progressBarAdv7.ThemesEnabled = False
            Me.progressBarAdv7.TubeEndColor = System.Drawing.Color.SpringGreen
            Me.progressBarAdv7.TubeStartColor = System.Drawing.Color.YellowGreen
            Me.progressBarAdv7.Value = 75
            Me.progressBarAdv7.WaitingGradientWidth = 400
            ' 
            ' progressBarAdv2
            ' 
            Me.progressBarAdv2.BackGradientEndColor = System.Drawing.SystemColors.ControlLightLight
            Me.progressBarAdv2.BackGradientStartColor = System.Drawing.SystemColors.ControlDark
            Me.progressBarAdv2.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient
            Me.progressBarAdv2.BackMultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv2.BackSegments = False
            Me.progressBarAdv2.BackTubeEndColor = System.Drawing.Color.Silver
            Me.progressBarAdv2.BackTubeStartColor = System.Drawing.Color.White
            Me.progressBarAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
            Me.progressBarAdv2.BorderColor = System.Drawing.Color.Black
            Me.progressBarAdv2.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None
            Me.progressBarAdv2.CustomWaitingRender = False
            Me.progressBarAdv2.FontColor = System.Drawing.Color.White
            Me.progressBarAdv2.ForegroundImage = Nothing
            Me.progressBarAdv2.ForeSegments = False
            Me.progressBarAdv2.GradientEndColor = System.Drawing.Color.Lime
            Me.progressBarAdv2.GradientStartColor = System.Drawing.Color.Red
            Me.progressBarAdv2.Location = New System.Drawing.Point(100, 12)
            Me.progressBarAdv2.MultipleColors = New System.Drawing.Color() {System.Drawing.SystemColors.ControlDarkDark, System.Drawing.SystemColors.ControlLightLight, System.Drawing.SystemColors.ActiveCaption}
            Me.progressBarAdv2.Name = "progressBarAdv2"
            Me.progressBarAdv2.ProgressOrientation = System.Windows.Forms.Orientation.Vertical
            Me.progressBarAdv2.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube
            Me.progressBarAdv2.SegmentWidth = 7
            Me.progressBarAdv2.Size = New System.Drawing.Size(23, 240)
            Me.progressBarAdv2.StretchImage = False
            Me.progressBarAdv2.TabIndex = 14
            Me.progressBarAdv2.TextOrientation = System.Windows.Forms.Orientation.Vertical
            Me.progressBarAdv2.TextVisible = False
            Me.progressBarAdv2.ThemesEnabled = False
            Me.progressBarAdv2.TubeEndColor = System.Drawing.Color.Honeydew
            Me.progressBarAdv2.TubeStartColor = System.Drawing.Color.Green
            Me.progressBarAdv2.Value = 75
            Me.progressBarAdv2.WaitingGradientWidth = 400
            ' 
            ' progressBarAdv5
            ' 
            Me.progressBarAdv5.BackGradientEndColor = System.Drawing.Color.White
            Me.progressBarAdv5.BackGradientStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv5.BackgroundImage = (CType(resources.GetObject("progressBarAdv5.BackgroundImage"), System.Drawing.Image))
            Me.progressBarAdv5.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Image
            Me.progressBarAdv5.BackMultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv5.BackSegments = False
            Me.progressBarAdv5.BackTubeEndColor = System.Drawing.Color.White
            Me.progressBarAdv5.BackTubeStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv5.BorderColor = System.Drawing.Color.Black
            Me.progressBarAdv5.CustomWaitingRender = False
            Me.progressBarAdv5.FontColor = System.Drawing.SystemColors.Control
            Me.progressBarAdv5.ForegroundImage = (CType(resources.GetObject("progressBarAdv5.ForegroundImage"), System.Drawing.Image))
            Me.progressBarAdv5.GradientEndColor = System.Drawing.Color.Lime
            Me.progressBarAdv5.GradientStartColor = System.Drawing.Color.Red
            Me.progressBarAdv5.Location = New System.Drawing.Point(68, 12)
            Me.progressBarAdv5.MultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv5.Name = "progressBarAdv5"
            Me.progressBarAdv5.ProgressOrientation = System.Windows.Forms.Orientation.Vertical
            Me.progressBarAdv5.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Image
            Me.progressBarAdv5.SegmentWidth = 12
            Me.progressBarAdv5.Size = New System.Drawing.Size(23, 240)
            Me.progressBarAdv5.StretchImage = False
            Me.progressBarAdv5.TabIndex = 13
            Me.progressBarAdv5.TextOrientation = System.Windows.Forms.Orientation.Vertical
            Me.progressBarAdv5.ThemesEnabled = False
            Me.progressBarAdv5.TubeEndColor = System.Drawing.Color.Black
            Me.progressBarAdv5.TubeStartColor = System.Drawing.Color.Red
            Me.progressBarAdv5.Value = 75
            Me.progressBarAdv5.WaitingGradientWidth = 400
            ' 
            ' progressBarAdv6
            ' 
            Me.progressBarAdv6.BackGradientEndColor = System.Drawing.Color.RosyBrown
            Me.progressBarAdv6.BackGradientStartColor = System.Drawing.Color.DarkRed
            Me.progressBarAdv6.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient
            Me.progressBarAdv6.BackMultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv6.BackSegments = False
            Me.progressBarAdv6.BackTubeEndColor = System.Drawing.SystemColors.Control
            Me.progressBarAdv6.BackTubeStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv6.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched
            Me.progressBarAdv6.BorderColor = System.Drawing.Color.Black
            Me.progressBarAdv6.CustomWaitingRender = False
            Me.progressBarAdv6.FontColor = System.Drawing.Color.Lime
            Me.progressBarAdv6.ForegroundImage = Nothing
            Me.progressBarAdv6.ForeSegments = False
            Me.progressBarAdv6.GradientEndColor = System.Drawing.Color.Lime
            Me.progressBarAdv6.GradientStartColor = System.Drawing.Color.Red
            Me.progressBarAdv6.Location = New System.Drawing.Point(36, 12)
            Me.progressBarAdv6.MultipleColors = New System.Drawing.Color() {System.Drawing.SystemColors.ControlDarkDark, System.Drawing.SystemColors.ControlLight, System.Drawing.SystemColors.ControlDark, System.Drawing.SystemColors.Control}
            Me.progressBarAdv6.Name = "progressBarAdv6"
            Me.progressBarAdv6.ProgressOrientation = System.Windows.Forms.Orientation.Vertical
            Me.progressBarAdv6.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube
            Me.progressBarAdv6.SegmentWidth = 12
            Me.progressBarAdv6.Size = New System.Drawing.Size(23, 240)
            Me.progressBarAdv6.TabIndex = 12
            Me.progressBarAdv6.TextOrientation = System.Windows.Forms.Orientation.Vertical
            Me.progressBarAdv6.TextVisible = False
            Me.progressBarAdv6.ThemesEnabled = False
            Me.progressBarAdv6.TubeEndColor = System.Drawing.Color.Black
            Me.progressBarAdv6.TubeStartColor = System.Drawing.Color.Red
            Me.progressBarAdv6.Value = 75
            Me.progressBarAdv6.WaitingGradientWidth = 400
            ' 
            ' progressBarAdv9
            ' 
            Me.progressBarAdv9.BackGradientEndColor = System.Drawing.Color.White
            Me.progressBarAdv9.BackGradientStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv9.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Tube
            Me.progressBarAdv9.BackMultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv9.BackSegments = False
            Me.progressBarAdv9.BackTubeEndColor = System.Drawing.Color.White
            Me.progressBarAdv9.BackTubeStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv9.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.progressBarAdv9.BorderColor = System.Drawing.Color.Brown
            Me.progressBarAdv9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.progressBarAdv9.CustomWaitingRender = False
            Me.progressBarAdv9.FontColor = System.Drawing.Color.LightSteelBlue
            Me.progressBarAdv9.ForegroundImage = Nothing
            Me.progressBarAdv9.ForeSegments = False
            Me.progressBarAdv9.GradientEndColor = System.Drawing.Color.Olive
            Me.progressBarAdv9.GradientStartColor = System.Drawing.Color.WhiteSmoke
            Me.progressBarAdv9.Location = New System.Drawing.Point(236, 229)
            Me.progressBarAdv9.MultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv9.Name = "progressBarAdv9"
            Me.progressBarAdv9.ProgressFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient
            Me.progressBarAdv9.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient
            Me.progressBarAdv9.SegmentWidth = 0
            Me.progressBarAdv9.Size = New System.Drawing.Size(240, 23)
            Me.progressBarAdv9.TabIndex = 15
            Me.progressBarAdv9.TextVisible = False
            Me.progressBarAdv9.ThemesEnabled = False
            Me.progressBarAdv9.TubeEndColor = System.Drawing.Color.Black
            Me.progressBarAdv9.TubeStartColor = System.Drawing.Color.Red
            Me.progressBarAdv9.Value = 75
            Me.progressBarAdv9.WaitingGradientEnabled = True
            Me.progressBarAdv9.WaitingGradientInterval = 50
            Me.progressBarAdv9.WaitingGradientWidth = 20
            ' 
            ' progressBarAdv10
            ' 
            Me.progressBarAdv10.BackGradientEndColor = System.Drawing.Color.White
            Me.progressBarAdv10.BackGradientStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv10.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Tube
            Me.progressBarAdv10.BackMultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv10.BackSegments = False
            Me.progressBarAdv10.BackTubeEndColor = System.Drawing.Color.White
            Me.progressBarAdv10.BackTubeStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv10.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
            Me.progressBarAdv10.BorderColor = System.Drawing.Color.Black
            Me.progressBarAdv10.CustomWaitingRender = False
            Me.progressBarAdv10.FontColor = System.Drawing.Color.LightSteelBlue
            Me.progressBarAdv10.ForegroundImage = Nothing
            Me.progressBarAdv10.ForeSegments = False
            Me.progressBarAdv10.GradientEndColor = System.Drawing.Color.Yellow
            Me.progressBarAdv10.GradientStartColor = System.Drawing.Color.Red
            Me.progressBarAdv10.Location = New System.Drawing.Point(132, 12)
            Me.progressBarAdv10.MultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv10.Name = "progressBarAdv10"
            Me.progressBarAdv10.ProgressOrientation = System.Windows.Forms.Orientation.Vertical
            Me.progressBarAdv10.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Gradient
            Me.progressBarAdv10.SegmentWidth = 12
            Me.progressBarAdv10.Size = New System.Drawing.Size(23, 240)
            Me.progressBarAdv10.TabIndex = 16
            Me.progressBarAdv10.TextOrientation = System.Windows.Forms.Orientation.Vertical
            Me.progressBarAdv10.ThemesEnabled = False
            Me.progressBarAdv10.TubeEndColor = System.Drawing.Color.Black
            Me.progressBarAdv10.TubeStartColor = System.Drawing.Color.Red
            Me.progressBarAdv10.Value = 75
            Me.progressBarAdv10.WaitingGradientWidth = 400
            ' 
            ' progressBarAdv11
            ' 
            Me.progressBarAdv11.BackGradientEndColor = System.Drawing.Color.White
            Me.progressBarAdv11.BackGradientStartColor = System.Drawing.Color.White
            Me.progressBarAdv11.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient
            Me.progressBarAdv11.BackMultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv11.BackSegments = False
            Me.progressBarAdv11.BackTubeEndColor = System.Drawing.Color.White
            Me.progressBarAdv11.BackTubeStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv11.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenInner
            Me.progressBarAdv11.BorderColor = System.Drawing.Color.Black
            Me.progressBarAdv11.CustomWaitingRender = False
            Me.progressBarAdv11.FontColor = System.Drawing.Color.White
            Me.progressBarAdv11.ForeColor = System.Drawing.Color.White
            Me.progressBarAdv11.ForegroundImage = Nothing
            Me.progressBarAdv11.GradientEndColor = System.Drawing.Color.DarkSeaGreen
            Me.progressBarAdv11.GradientStartColor = System.Drawing.Color.Red
            Me.progressBarAdv11.Location = New System.Drawing.Point(236, 154)
            Me.progressBarAdv11.Maximum = 75
            Me.progressBarAdv11.MultipleColors = New System.Drawing.Color() {System.Drawing.Color.Brown, System.Drawing.Color.MidnightBlue, System.Drawing.Color.DarkSeaGreen, System.Drawing.Color.DeepPink, System.Drawing.Color.DarkOrange, System.Drawing.Color.LawnGreen}
            Me.progressBarAdv11.Name = "progressBarAdv11"
            Me.progressBarAdv11.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.MultipleGradient
            Me.progressBarAdv11.SegmentWidth = 12
            Me.progressBarAdv11.Size = New System.Drawing.Size(240, 23)
            Me.progressBarAdv11.StretchMultGrad = False
            Me.progressBarAdv11.TabIndex = 17
            Me.progressBarAdv11.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value
            Me.progressBarAdv11.ThemesEnabled = False
            Me.progressBarAdv11.TubeEndColor = System.Drawing.Color.Black
            Me.progressBarAdv11.TubeStartColor = System.Drawing.Color.Red
            Me.progressBarAdv11.Value = 75
            Me.progressBarAdv11.WaitingGradientWidth = 400
            ' 
            ' progressBarAdv12
            ' 
            Me.progressBarAdv12.BackGradientEndColor = System.Drawing.Color.White
            Me.progressBarAdv12.BackGradientStartColor = System.Drawing.Color.Lime
            Me.progressBarAdv12.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient
            Me.progressBarAdv12.BackMultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv12.BackSegments = False
            Me.progressBarAdv12.BackTubeEndColor = System.Drawing.Color.White
            Me.progressBarAdv12.BackTubeStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv12.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenInner
            Me.progressBarAdv12.BorderColor = System.Drawing.Color.Black
            Me.progressBarAdv12.CustomWaitingRender = False
            Me.progressBarAdv12.FontColor = System.Drawing.Color.White
            Me.progressBarAdv12.ForegroundImage = Nothing
            Me.progressBarAdv12.ForeSegments = False
            Me.progressBarAdv12.GradientEndColor = System.Drawing.Color.Lime
            Me.progressBarAdv12.GradientStartColor = System.Drawing.Color.Red
            Me.progressBarAdv12.Location = New System.Drawing.Point(164, 12)
            Me.progressBarAdv12.Maximum = 75
            Me.progressBarAdv12.MultipleColors = New System.Drawing.Color() {System.Drawing.Color.Brown, System.Drawing.Color.MidnightBlue, System.Drawing.Color.DarkSeaGreen, System.Drawing.Color.DeepPink, System.Drawing.Color.DarkOrange, System.Drawing.Color.LawnGreen}
            Me.progressBarAdv12.Name = "progressBarAdv12"
            Me.progressBarAdv12.ProgressOrientation = System.Windows.Forms.Orientation.Vertical
            Me.progressBarAdv12.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.MultipleGradient
            Me.progressBarAdv12.SegmentWidth = 12
            Me.progressBarAdv12.Size = New System.Drawing.Size(23, 240)
            Me.progressBarAdv12.StretchMultGrad = False
            Me.progressBarAdv12.TabIndex = 18
            Me.progressBarAdv12.TextOrientation = System.Windows.Forms.Orientation.Vertical
            Me.progressBarAdv12.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value
            Me.progressBarAdv12.ThemesEnabled = False
            Me.progressBarAdv12.TubeEndColor = System.Drawing.Color.Black
            Me.progressBarAdv12.TubeStartColor = System.Drawing.Color.Red
            Me.progressBarAdv12.Value = 75
            Me.progressBarAdv12.WaitingGradientWidth = 400
            ' 
            ' progressBarAdv13
            ' 
            Me.progressBarAdv13.BackGradientEndColor = System.Drawing.Color.White
            Me.progressBarAdv13.BackGradientStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv13.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.System
            Me.progressBarAdv13.BackMultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv13.BackSegments = False
            Me.progressBarAdv13.BackTubeEndColor = System.Drawing.Color.White
            Me.progressBarAdv13.BackTubeStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv13.BorderColor = System.Drawing.Color.Black
            Me.progressBarAdv13.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.progressBarAdv13.CustomWaitingRender = False
            Me.progressBarAdv13.FontColor = System.Drawing.Color.White
            Me.progressBarAdv13.ForegroundImage = Nothing
            Me.progressBarAdv13.GradientEndColor = System.Drawing.Color.Lime
            Me.progressBarAdv13.GradientStartColor = System.Drawing.Color.Red
            Me.progressBarAdv13.Location = New System.Drawing.Point(196, 12)
            Me.progressBarAdv13.MultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv13.Name = "progressBarAdv13"
            Me.progressBarAdv13.ProgressOrientation = System.Windows.Forms.Orientation.Vertical
            Me.progressBarAdv13.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.System
            Me.progressBarAdv13.SegmentWidth = 12
            Me.progressBarAdv13.Size = New System.Drawing.Size(23, 240)
            Me.progressBarAdv13.TabIndex = 19
            Me.progressBarAdv13.TextOrientation = System.Windows.Forms.Orientation.Vertical
            Me.progressBarAdv13.ThemesEnabled = True
            Me.progressBarAdv13.TubeEndColor = System.Drawing.Color.Black
            Me.progressBarAdv13.TubeStartColor = System.Drawing.Color.Red
            Me.progressBarAdv13.Value = 75
            Me.progressBarAdv13.WaitingGradientWidth = 400
            ' 
            ' progressBarAdv14
            ' 
            Me.progressBarAdv14.BackGradientEndColor = System.Drawing.Color.White
            Me.progressBarAdv14.BackGradientStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv14.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.System
            Me.progressBarAdv14.BackMultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv14.BackSegments = False
            Me.progressBarAdv14.BackTubeEndColor = System.Drawing.Color.White
            Me.progressBarAdv14.BackTubeStartColor = System.Drawing.Color.LightGray
            Me.progressBarAdv14.BorderColor = System.Drawing.Color.Black
            Me.progressBarAdv14.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dotted
            Me.progressBarAdv14.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.progressBarAdv14.CustomWaitingRender = False
            Me.progressBarAdv14.FontColor = System.Drawing.Color.White
            Me.progressBarAdv14.ForegroundImage = Nothing
            Me.progressBarAdv14.GradientEndColor = System.Drawing.Color.Lime
            Me.progressBarAdv14.GradientStartColor = System.Drawing.Color.Red
            Me.progressBarAdv14.Location = New System.Drawing.Point(236, 194)
            Me.progressBarAdv14.MultipleColors = New System.Drawing.Color() {}
            Me.progressBarAdv14.Name = "progressBarAdv14"
            Me.progressBarAdv14.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.System
            Me.progressBarAdv14.SegmentWidth = 12
            Me.progressBarAdv14.Size = New System.Drawing.Size(240, 23)
            Me.progressBarAdv14.TabIndex = 20
            Me.progressBarAdv14.ThemesEnabled = True
            Me.progressBarAdv14.TubeEndColor = System.Drawing.Color.Black
            Me.progressBarAdv14.TubeStartColor = System.Drawing.Color.Red
            Me.progressBarAdv14.Value = 75
            Me.progressBarAdv14.WaitingGradientWidth = 400
            ' 
            ' timer
            ' 
            '			Me.timer.Tick += New System.EventHandler(Me.timer_Tick);
            ' 
            ' TestButton
            ' 
            Me.TestButton.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.TestButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.TestButton.ImageIndex = 0
            Me.TestButton.Location = New System.Drawing.Point(64, 16)
            Me.TestButton.Name = "TestButton"
            Me.TestButton.Size = New System.Drawing.Size(80, 24)
            Me.TestButton.TabIndex = 21
            Me.TestButton.Text = "Test"
            '			Me.TestButton.Click += New System.EventHandler(Me.TestButton_Click);
            ' 
            ' Stop
            ' 
            Me.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.StopBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.StopBtn.ImageIndex = 1
            Me.StopBtn.Location = New System.Drawing.Point(179, 18)
            Me.StopBtn.Name = "Stop"
            Me.StopBtn.Size = New System.Drawing.Size(80, 24)
            Me.StopBtn.TabIndex = 22
            Me.StopBtn.Text = "Stop"
            '			Me.Stop.Click += New System.EventHandler(Me.Stop_Click);
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Controls.Add(Me.TestButton)
            Me.groupBox1.Controls.Add(Me.StopBtn)
            Me.groupBox1.Controls.Add(Me.numericUpDown1)
            Me.groupBox1.Location = New System.Drawing.Point(36, 272)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(440, 48)
            Me.groupBox1.TabIndex = 23
            Me.groupBox1.TabStop = False
            ' 
            ' progressBarWaiting
            ' 
            Me.progressBarWaiting.BackColor = System.Drawing.Color.Lavender
            Me.progressBarWaiting.BackGradientEndColor = System.Drawing.Color.White
            Me.progressBarWaiting.BackGradientStartColor = System.Drawing.Color.LightGray
            Me.progressBarWaiting.BackMultipleColors = New System.Drawing.Color() {}
            Me.progressBarWaiting.BackSegments = False
            Me.progressBarWaiting.BackTubeEndColor = System.Drawing.Color.White
            Me.progressBarWaiting.BackTubeStartColor = System.Drawing.Color.LightGray
            Me.progressBarWaiting.BorderColor = System.Drawing.Color.Black
            Me.progressBarWaiting.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.progressBarWaiting.CustomWaitingRender = False
            Me.progressBarWaiting.Dock = System.Windows.Forms.DockStyle.Top
            Me.progressBarWaiting.FontColor = System.Drawing.Color.White
            Me.progressBarWaiting.ForegroundImage = Nothing
            Me.progressBarWaiting.ForeSegments = False
            Me.progressBarWaiting.GradientEndColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0))))))
            Me.progressBarWaiting.GradientStartColor = System.Drawing.Color.Lavender
            Me.progressBarWaiting.Location = New System.Drawing.Point(0, 0)
            Me.progressBarWaiting.MultipleColors = New System.Drawing.Color() {System.Drawing.Color.Thistle, System.Drawing.Color.Blue}
            Me.progressBarWaiting.Name = "progressBarWaiting"
            Me.progressBarWaiting.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient
            Me.progressBarWaiting.SegmentWidth = 12
            Me.progressBarWaiting.Size = New System.Drawing.Size(526, 6)
            Me.progressBarWaiting.TabIndex = 2
            Me.progressBarWaiting.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom
            Me.progressBarWaiting.ThemesEnabled = False
            Me.progressBarWaiting.TubeEndColor = System.Drawing.Color.Black
            Me.progressBarWaiting.TubeStartColor = System.Drawing.Color.Red
            Me.progressBarWaiting.Value = 100
            Me.progressBarWaiting.WaitingGradientEnabled = True
            Me.progressBarWaiting.WaitingGradientInterval = 25
            Me.progressBarWaiting.WaitingGradientWidth = 600
            ' 
            ' FormMain
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(246))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(254))))))
            Me.ClientSize = New System.Drawing.Size(526, 332)
            Me.Controls.Add(Me.progressBarWaiting)
            Me.Controls.Add(Me.progressBarAdv5)
            Me.Controls.Add(Me.progressBarAdv13)
            Me.Controls.Add(Me.progressBarAdv6)
            Me.Controls.Add(Me.progressBarAdv10)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.progressBarAdv12)
            Me.Controls.Add(Me.progressBarAdv14)
            Me.Controls.Add(Me.progressBarAdv3)
            Me.Controls.Add(Me.progressBarAdv2)
            Me.Controls.Add(Me.progressBarAdv1)
            Me.Controls.Add(Me.progressBarAdv9)
            Me.Controls.Add(Me.progressBarAdv11)
            Me.Controls.Add(Me.progressBarAdv7)
            Me.Controls.Add(Me.progressBarAdv4)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
            Me.MaximizeBox = False
            Me.Name = "FormMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ProgressBarAdv Demo"
            CType(Me.progressBarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progressBarAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progressBarAdv4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progressBarAdv7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progressBarAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progressBarAdv5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progressBarAdv6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progressBarAdv9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progressBarAdv10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progressBarAdv11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progressBarAdv12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progressBarAdv13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.progressBarAdv14, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            CType(Me.progressBarWaiting, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New FormMain())
		End Sub

		Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
			SetProgressValue(CInt(Fix(numericUpDown1.Value)))
		End Sub

		Private Sub timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer.Tick
			SetProgressValue(progressBarAdv1.Value+1)
			If progressBarAdv1.Value >= 100 Then
				SetProgressValue(0)
			End If
		End Sub
		Private Sub SetProgressValue(ByVal val As Integer)

			Me.progressBarAdv1.Value = val
			Me.progressBarAdv2.Value = val
			Me.progressBarAdv3.Value = val
			Me.progressBarAdv4.Value = val
			Me.progressBarAdv5.Value = val
			Me.progressBarAdv6.Value = val
			Me.progressBarAdv7.Value = val
			Me.progressBarAdv9.Value = val
			Me.progressBarAdv10.Value = val
			Me.progressBarAdv11.Value = val
			Me.progressBarAdv12.Value = val
			Me.progressBarAdv13.Value = val
			Me.progressBarAdv14.Value = val
		End Sub

		Private Sub TestButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TestButton.Click
			timer.Enabled = True
			If progressBarAdv1.Value >= 100 Then
				SetProgressValue(0)
			End If
		End Sub

        Private Sub Stop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles StopBtn.Click
            timer.Enabled = False
        End Sub

	End Class
End Namespace

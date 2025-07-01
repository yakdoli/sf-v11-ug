Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Drawing


	''' <summary>
	''' DesignerPanel, a GradientPanel with Header.
	''' </summary>
	Public Class DesignerPanel
		Inherits GradientPanel
		#Region "Private Members"
		  Private components As System.ComponentModel.Container = Nothing
		Private headerImage_Renamed As Image
		Private headerText_Renamed As String
		Private TopPanel As GradientPanel = New GradientPanel()
		Private TextLabel As Label = New Label()
    Private color As Color() = New Color() {System.Drawing.Color.FromArgb(201, 220, 237), System.Drawing.Color.FromArgb(218, 230, 242), System.Drawing.Color.FromArgb(227, 236, 243), System.Drawing.Color.FromArgb(232, 239, 245), System.Drawing.Color.FromArgb(241, 245, 248)}
#End Region

		#Region "Constructor and Dispose"
		Public Sub New()
			InitializeComponent()
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
		#End Region

		#Region "InitializeComponent"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
	   Private Sub InitializeComponent()
			components = New System.ComponentModel.Container()

        Me.BackColor = System.Drawing.Color.White
        Me.BorderColor = System.Drawing.Color.FromArgb(209, 220, 231)
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.Size = New System.Drawing.Size(190, 150)
			Me.headerText_Renamed = "PanelText"
			Me.BackgroundColor = New BrushInfo(GradientStyle.Vertical, color)

			Me.TopPanel.BackgroundColor = Me.BackgroundColor
			Me.TopPanel.BorderColor = Me.BorderColor
			Me.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.TopPanel.Location = New System.Drawing.Point(0, 0)
			Me.TopPanel.Name = "gradientPanel1"
			Me.TopPanel.Size = New System.Drawing.Size(188, 26)

			Me.TextLabel.Text = Me.headerText_Renamed
			Me.TextLabel.TextAlign = ContentAlignment.MiddleLeft
			Me.TextLabel.ImageAlign = ContentAlignment.MiddleLeft
			Me.TextLabel.Dock = DockStyle.Fill
        Me.TextLabel.BackColor = System.Drawing.Color.Transparent


			Me.TopPanel.Controls.Add(TextLabel)
			Me.TopPanel.TabIndex = 0
			Me.Controls.Add(TopPanel)

	   End Sub
#End Region

		#Region "Properties and events"
		<Category("Appearance"), Description("HeaderText of the panel")> _
		Public Property HeaderText() As String
			Get
				Return headerText_Renamed
			End Get
			Set(ByVal value As String)
				Me.headerText_Renamed = value
				Me.TextLabel.Text = Me.headerText_Renamed
				Invalidate()
			End Set
		End Property

		<Category("Appearance"), Description("Header image of the panel")> _
		Public Property HeaderImage() As Image
			Get
				Return headerImage_Renamed
			End Get

			Set(ByVal value As Image)
				Me.headerImage_Renamed = value
				Me.TextLabel.Image = Me.headerImage_Renamed
				Invalidate()
			End Set
		End Property
		Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
			Me.TopPanel.BackgroundColor = Me.BackgroundColor
			Me.TopPanel.BorderColor = Me.BorderColor
		End Sub
		#End Region
	End Class

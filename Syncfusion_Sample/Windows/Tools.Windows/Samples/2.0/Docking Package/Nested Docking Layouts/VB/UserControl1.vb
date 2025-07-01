Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Namespace nesteddockinglayout
	''' <summary>
	''' Summary description for UserControl1.
	''' </summary>
	Public Class UserControl1 : Inherits System.Windows.Forms.UserControl
		#Region "Variable declaration"

		Private WithEvents dm As Syncfusion.Windows.Forms.Tools.DockingManager
		Private components As System.ComponentModel.IContainer
		Private WithEvents pnlpanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private pnlpanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private pnlpanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private bNestedTab As Boolean

		#End Region

		#Region "VS Form code ( Constructor , Initialization and Disposing )"

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitForm call

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


		#Region "Component Designer generated code"
		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim CaptionButton1 As Syncfusion.Windows.Forms.Tools.CaptionButton = New Syncfusion.Windows.Forms.Tools.CaptionButton
            Dim ToolTipInfo1 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim CaptionButton2 As Syncfusion.Windows.Forms.Tools.CaptionButton = New Syncfusion.Windows.Forms.Tools.CaptionButton
            Dim ToolTipInfo2 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim CaptionButton3 As Syncfusion.Windows.Forms.Tools.CaptionButton = New Syncfusion.Windows.Forms.Tools.CaptionButton
            Dim ToolTipInfo3 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim CaptionButton4 As Syncfusion.Windows.Forms.Tools.CaptionButton = New Syncfusion.Windows.Forms.Tools.CaptionButton
            Dim ToolTipInfo4 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
            Me.dm = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
            Me.pnlpanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.pnlpanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.pnlpanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            CType(Me.dm, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlpanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlpanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlpanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dm
            '
            CaptionButton1.ImageIndex = -1
            CaptionButton1.Name = "CloseButton"
            CaptionButton1.SuperToolTipInfo = ToolTipInfo1
            CaptionButton1.ToolTip = "Close"
            CaptionButton1.TransparentImageColor = System.Drawing.Color.Transparent
            CaptionButton1.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close
            CaptionButton2.ImageIndex = -1
            CaptionButton2.Name = "PinButton"
            CaptionButton2.SuperToolTipInfo = ToolTipInfo2
            CaptionButton2.ToolTip = "Auto Hide"
            CaptionButton2.TransparentImageColor = System.Drawing.Color.Transparent
            CaptionButton2.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin
            CaptionButton3.ImageIndex = -1
            CaptionButton3.Name = "MenuButton"
            CaptionButton3.SuperToolTipInfo = ToolTipInfo3
            CaptionButton3.ToolTip = "Window Position"
            CaptionButton3.TransparentImageColor = System.Drawing.Color.Transparent
            CaptionButton3.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu
            CaptionButton4.ImageIndex = -1
            CaptionButton4.Name = "MaximizeButton"
            CaptionButton4.SuperToolTipInfo = ToolTipInfo4
            CaptionButton4.ToolTip = "Maximize"
            CaptionButton4.TransparentImageColor = System.Drawing.Color.Transparent
            CaptionButton4.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize
            Me.dm.CaptionButtons.Add(CaptionButton1)
            Me.dm.CaptionButtons.Add(CaptionButton2)
            Me.dm.CaptionButtons.Add(CaptionButton3)
            Me.dm.CaptionButtons.Add(CaptionButton4)
            Me.dm.DockLayoutStream = CType(resources.GetObject("dm.DockLayoutStream"), System.IO.MemoryStream)
            Me.dm.DockToFill = True
            Me.dm.HostControl = Me
            Me.dm.DragProviderStyle = Tools.DragProviderStyle.VS2005
            Me.dm.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.dm.SetDockLabel(Me.pnlpanel1, "Orange")
            Me.dm.SetDockLabel(Me.pnlpanel2, "pnlpanel2")
            Me.dm.SetDockLabel(Me.pnlpanel3, "Maroon")
            '
            'pnlpanel1
            '
            Me.pnlpanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(57, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(132, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(132, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(57, Byte), Integer))})
            Me.pnlpanel1.BorderColor = System.Drawing.Color.Black
            Me.dm.SetEnableDocking(Me.pnlpanel1, True)
            Me.pnlpanel1.Location = New System.Drawing.Point(3, 22)
            Me.pnlpanel1.Name = "pnlpanel1"
            Me.pnlpanel1.Size = New System.Drawing.Size(167, 335)
            Me.pnlpanel1.TabIndex = 8
            '
            'pnlpanel2
            '
            Me.pnlpanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(165, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(231, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(165, Byte), Integer))})
            Me.pnlpanel2.BorderColor = System.Drawing.Color.Black
            Me.dm.SetEnableDocking(Me.pnlpanel2, True)
            Me.pnlpanel2.Location = New System.Drawing.Point(3, 22)
            Me.pnlpanel2.Name = "pnlpanel2"
            Me.pnlpanel2.Size = New System.Drawing.Size(161, 359)
            Me.pnlpanel2.TabIndex = 9
            '
            'pnlpanel3
            '
            Me.pnlpanel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(41, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(74, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(74, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(41, Byte), Integer))})
            Me.pnlpanel3.BorderColor = System.Drawing.Color.Black
            Me.dm.SetEnableDocking(Me.pnlpanel3, True)
            Me.pnlpanel3.Location = New System.Drawing.Point(3, 22)
            Me.pnlpanel3.Name = "pnlpanel3"
            Me.pnlpanel3.Size = New System.Drawing.Size(167, 335)
            Me.pnlpanel3.TabIndex = 10
            '
            'UserControl1
            '
            Me.Name = "UserControl1"
            Me.Size = New System.Drawing.Size(344, 384)
            CType(Me.dm, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlpanel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlpanel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlpanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		#End Region

		#Region "Properties"

		'Assigning Themes to the DockingManager
		Public WriteOnly Property ThemesEnabled() As Boolean
			Set
				dm.ThemesEnabled=Value
			End Set
		End Property

		'Assigning VisualStyles to the DockingManager
		Public WriteOnly Property VisualStyle() As VisualStyle
			Set
				dm.VisualStyle=Value
			End Set
		End Property

		'Assigning DragProviderStyle to the DockingManager
		Public WriteOnly Property DragProviderStyle() As DragProviderStyle
			Set
				dm.DragProviderStyle=Value
			End Set
		End Property

		'Assigning NextedTabbing to the DockingManager
		Public Property NestedTabbing() As Boolean
			Get
				Return bNestedTab
			End Get
			Set
				bNestedTab=Value
				If bNestedTab Then
					Me.dm.LockHostFormUpdate()

                    If dm.GetDockVisibility(pnlpanel1) And dm.GetDockVisibility(pnlpanel2) And dm.GetDockVisibility(pnlpanel3) Then

                        dm.DockControl(pnlpanel1, Me, DockingStyle.Left, Me.Width - 10)
                        dm.DockControl(pnlpanel2, pnlpanel1, DockingStyle.Tabbed, 100)
                        dm.DockControl(pnlpanel3, pnlpanel2, DockingStyle.Tabbed, 100, True)
                    End If

                    Me.dm.UnlockHostFormUpdate()

                End If
			End Set
		End Property

		#End Region

		#Region "Event Handlers "

		Private Sub UserControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

		End Sub

		'Not allowing nexted tabbing when NextedTabbing is on.
		Private Sub dm_DockAllow(ByVal sender As Object, ByVal arg As Syncfusion.Windows.Forms.Tools.DockAllowEventArgs) Handles dm.DockAllow
			If Me.NestedTabbing AndAlso arg.DockStyle <>DockingStyle.Tabbed Then
				arg.Cancel =True
			End If
		End Sub

		#End Region

		Private Sub pnlPanel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlpanel1.Paint

		End Sub

	End Class
End Namespace

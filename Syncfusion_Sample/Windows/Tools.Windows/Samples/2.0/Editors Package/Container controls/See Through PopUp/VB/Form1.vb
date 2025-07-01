Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms

Namespace SemiTransparentPopUp
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private WithEvents popupControlContainer1 As Syncfusion.Windows.Forms.PopupControlContainer
		Private label1 As System.Windows.Forms.Label
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private pictureBox2 As System.Windows.Forms.PictureBox
		Private WithEvents button1 As System.Windows.Forms.Button
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
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
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
			Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer()
			Me.button1 = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.popupControlContainer1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' popupControlContainer1
			' 
			Me.popupControlContainer1.BackColor = System.Drawing.Color.White
			Me.popupControlContainer1.Controls.AddRange(New System.Windows.Forms.Control() { Me.button1})
			Me.popupControlContainer1.Location = New System.Drawing.Point(184, 64)
			Me.popupControlContainer1.Name = "popupControlContainer1"
			Me.popupControlContainer1.Size = New System.Drawing.Size(272, 256)
			Me.popupControlContainer1.TabIndex = 0
			Me.popupControlContainer1.Visible = False
'			Me.popupControlContainer1.BeforePopup += New System.ComponentModel.CancelEventHandler(Me.popupControlContainer1_BeforePopup);
			' 
			' button1
			' 
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button1.Location = New System.Drawing.Point(48, 200)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(184, 24)
			Me.button1.TabIndex = 0
			Me.button1.Text = "This is a transparent popup"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Image = (CType(resources.GetObject("label1.Image"), System.Drawing.Bitmap))
			Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.label1.ImageIndex = 0
			Me.label1.ImageList = Me.imageList1
			Me.label1.Location = New System.Drawing.Point(40, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(480, 40)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Right click anywhere on the form to show the popup." & Constants.vbLf & "The popup will draw semi-tran" & "sparent."
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' imageList1
			' 
			Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
			Me.imageList1.ImageSize = New System.Drawing.Size(32, 32)
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			' 
			' pictureBox1
			' 
			Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb((CByte(204)), (CByte(212)), (CByte(230)))
			Me.pictureBox1.Image = (CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Bitmap))
			Me.pictureBox1.Location = New System.Drawing.Point(32, 80)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(224, 264)
			Me.pictureBox1.TabIndex = 2
			Me.pictureBox1.TabStop = False
			' 
			' pictureBox2
			' 
			Me.pictureBox2.BackColor = System.Drawing.Color.FromArgb((CByte(204)), (CByte(212)), (CByte(230)))
			Me.pictureBox2.Image = (CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Bitmap))
			Me.pictureBox2.Location = New System.Drawing.Point(288, 80)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(232, 264)
			Me.pictureBox2.TabIndex = 4
			Me.pictureBox2.TabStop = False
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.ClientSize = New System.Drawing.Size(554, 376)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.popupControlContainer1, Me.pictureBox2, Me.label1, Me.pictureBox1})
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MaximumSize = New System.Drawing.Size(560, 408)
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "See Through PopUp"
'			Me.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.Form1_MouseDown);
			Me.popupControlContainer1.ResumeLayout(False)
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
		#Region "Opacity"
		Private Sub popupControlContainer1_BeforePopup(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles popupControlContainer1.BeforePopup
			' Get the popupHost which is used to host the popupControlContainer
			' and set the opacity.
			Me.popupControlContainer1.PopupHost.Opacity = 0.75
		End Sub
		#End Region
		#Region "ShowPopup"
		Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Me.popupControlContainer1.ShowPopup(Me.PointToScreen(New Point(e.X, e.Y)))
            End If
		End Sub
		#End Region
		#Region "HodePopUp"

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Me.popupControlContainer1.HidePopup(PopupCloseType.Done)
		End Sub
		#End Region

	End Class
End Namespace

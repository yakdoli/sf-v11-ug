Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Namespace ImageListAdv_Demo
	Partial Public Class Docking1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Docking1))
			Dim ccbpanel1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection()
			Me.dockingManager1 = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.imageListAdv1 = New Syncfusion.Windows.Forms.Tools.ImageListAdv(Me.components)
			CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dockingManager1
			' 
			Me.dockingManager1.DockLayoutStream = (CType(resources.GetObject("dockingManager1.DockLayoutStream"), System.IO.MemoryStream))
			Me.dockingManager1.HostControl = Me
			Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Custom, "CaptionButton1", 0, System.Drawing.Color.Transparent, ""))
			Me.dockingManager1.SetDockLabel(Me.panel1, "Panel1")
			ccbpanel1.MergeWith(Me.dockingManager1.CaptionButtons, False)
			Me.dockingManager1.SetCustomCaptionButtons(Me.panel1, ccbpanel1)
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.SystemColors.Control
			Me.dockingManager1.SetEnableDocking(Me.panel1, True)
			Me.panel1.Location = New System.Drawing.Point(1, 26)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(146, 191)
			Me.panel1.TabIndex = 0
			' 
			' imageListAdv1
			' 
			Me.imageListAdv1.Images.AddRange(New System.Drawing.Image() { (CType(resources.GetObject("imageListAdv1.Images"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images1"), System.Drawing.Image))})
			' 
			' Docking1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(254))))))
			Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.Name = "Docking1"
			Me.Size = New System.Drawing.Size(157, 218)
			CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private dockingManager1 As Syncfusion.Windows.Forms.Tools.DockingManager
		Private imageListAdv1 As Syncfusion.Windows.Forms.Tools.ImageListAdv


	End Class
End Namespace

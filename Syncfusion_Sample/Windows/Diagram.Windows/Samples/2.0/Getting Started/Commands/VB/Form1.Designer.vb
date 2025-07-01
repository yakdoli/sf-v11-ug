Imports Microsoft.VisualBasic
Imports System
Namespace Commands
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New DemoCommon.Diagram.TitlePanel
            Me.toolStrip1 = New System.Windows.Forms.ToolStrip
            Me.cutToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.copyToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.pasteToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.alignLeftToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.alignCenterToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.alignRightToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.alignTopToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.alignMiddleToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.alignBottomToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
            Me.rotateLeftToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.rotateRightToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
            Me.flipVerticalToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.flipHorizontalToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
            Me.spaceAcrossToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.spaceDownToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.sameWidthToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.sameHeightToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.sameSizeToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.panel2 = New System.Windows.Forms.Panel
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.toolStrip1.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.panel1.ControlBox = False
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Form = Me
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Margin = New System.Windows.Forms.Padding(4)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(735, 76)
            Me.panel1.TabIndex = 1
            Me.panel1.TitleText = "Commands"
            '
            'toolStrip1
            '
            Me.toolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cutToolStripButton, Me.copyToolStripButton, Me.pasteToolStripButton, Me.toolStripSeparator1, Me.alignLeftToolStripButton, Me.alignCenterToolStripButton, Me.alignRightToolStripButton, Me.alignTopToolStripButton, Me.alignMiddleToolStripButton, Me.alignBottomToolStripButton, Me.toolStripSeparator4, Me.rotateLeftToolStripButton, Me.rotateRightToolStripButton, Me.toolStripSeparator5, Me.flipVerticalToolStripButton, Me.flipHorizontalToolStripButton, Me.toolStripSeparator2, Me.spaceAcrossToolStripButton, Me.spaceDownToolStripButton, Me.sameWidthToolStripButton, Me.sameHeightToolStripButton, Me.sameSizeToolStripButton})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 76)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Padding = New System.Windows.Forms.Padding(2)
            Me.toolStrip1.Size = New System.Drawing.Size(735, 42)
            Me.toolStrip1.TabIndex = 2
            Me.toolStrip1.Text = "toolStrip1"
            '
            'cutToolStripButton
            '
            Me.cutToolStripButton.AutoSize = False
            Me.cutToolStripButton.BackColor = System.Drawing.Color.Transparent
            Me.cutToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.cutToolStripButton.Enabled = False
            Me.cutToolStripButton.Image = CType(resources.GetObject("cutToolStripButton.Image"), System.Drawing.Image)
            Me.cutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.cutToolStripButton.Name = "cutToolStripButton"
            Me.cutToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.cutToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.cutToolStripButton.Text = "Cut"
            Me.cutToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.cutToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'copyToolStripButton
            '
            Me.copyToolStripButton.AutoSize = False
            Me.copyToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.copyToolStripButton.Enabled = False
            Me.copyToolStripButton.Image = CType(resources.GetObject("copyToolStripButton.Image"), System.Drawing.Image)
            Me.copyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.copyToolStripButton.Name = "copyToolStripButton"
            Me.copyToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.copyToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.copyToolStripButton.Text = "Copy"
            Me.copyToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.copyToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'pasteToolStripButton
            '
            Me.pasteToolStripButton.AutoSize = False
            Me.pasteToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.pasteToolStripButton.Enabled = False
            Me.pasteToolStripButton.Image = CType(resources.GetObject("pasteToolStripButton.Image"), System.Drawing.Image)
            Me.pasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.pasteToolStripButton.Name = "pasteToolStripButton"
            Me.pasteToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.pasteToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.pasteToolStripButton.Text = "Paste"
            Me.pasteToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.pasteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 38)
            '
            'alignLeftToolStripButton
            '
            Me.alignLeftToolStripButton.AutoSize = False
            Me.alignLeftToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.alignLeftToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.alignLeftToolStripButton.Enabled = False
            Me.alignLeftToolStripButton.Image = CType(resources.GetObject("alignLeftToolStripButton.Image"), System.Drawing.Image)
            Me.alignLeftToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.alignLeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.alignLeftToolStripButton.Name = "alignLeftToolStripButton"
            Me.alignLeftToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.alignLeftToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.alignLeftToolStripButton.Text = "Align" & Global.Microsoft.VisualBasic.ChrW(10) & "Left"
            Me.alignLeftToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.alignLeftToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
            Me.alignLeftToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'alignCenterToolStripButton
            '
            Me.alignCenterToolStripButton.AutoSize = False
            Me.alignCenterToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.alignCenterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.alignCenterToolStripButton.Enabled = False
            Me.alignCenterToolStripButton.Image = CType(resources.GetObject("alignCenterToolStripButton.Image"), System.Drawing.Image)
            Me.alignCenterToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.alignCenterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.alignCenterToolStripButton.Name = "alignCenterToolStripButton"
            Me.alignCenterToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.alignCenterToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.alignCenterToolStripButton.Text = "Align" & Global.Microsoft.VisualBasic.ChrW(10) & "Center"
            Me.alignCenterToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'alignRightToolStripButton
            '
            Me.alignRightToolStripButton.AutoSize = False
            Me.alignRightToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.alignRightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.alignRightToolStripButton.Enabled = False
            Me.alignRightToolStripButton.Image = CType(resources.GetObject("alignRightToolStripButton.Image"), System.Drawing.Image)
            Me.alignRightToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.alignRightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.alignRightToolStripButton.Margin = New System.Windows.Forms.Padding(0)
            Me.alignRightToolStripButton.Name = "alignRightToolStripButton"
            Me.alignRightToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.alignRightToolStripButton.Text = "Align" & Global.Microsoft.VisualBasic.ChrW(10) & "Right"
            Me.alignRightToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
            Me.alignRightToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'alignTopToolStripButton
            '
            Me.alignTopToolStripButton.AutoSize = False
            Me.alignTopToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.alignTopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.alignTopToolStripButton.Enabled = False
            Me.alignTopToolStripButton.Image = CType(resources.GetObject("alignTopToolStripButton.Image"), System.Drawing.Image)
            Me.alignTopToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.alignTopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.alignTopToolStripButton.Name = "alignTopToolStripButton"
            Me.alignTopToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.alignTopToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.alignTopToolStripButton.Text = "Align" & Global.Microsoft.VisualBasic.ChrW(10) & "Top"
            Me.alignTopToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.alignTopToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'alignMiddleToolStripButton
            '
            Me.alignMiddleToolStripButton.AutoSize = False
            Me.alignMiddleToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.alignMiddleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.alignMiddleToolStripButton.Enabled = False
            Me.alignMiddleToolStripButton.Image = CType(resources.GetObject("alignMiddleToolStripButton.Image"), System.Drawing.Image)
            Me.alignMiddleToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.alignMiddleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.alignMiddleToolStripButton.Name = "alignMiddleToolStripButton"
            Me.alignMiddleToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.alignMiddleToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.alignMiddleToolStripButton.Text = "Align" & Global.Microsoft.VisualBasic.ChrW(10) & "Middle"
            Me.alignMiddleToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.alignMiddleToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'alignBottomToolStripButton
            '
            Me.alignBottomToolStripButton.AutoSize = False
            Me.alignBottomToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.alignBottomToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.alignBottomToolStripButton.Enabled = False
            Me.alignBottomToolStripButton.Image = CType(resources.GetObject("alignBottomToolStripButton.Image"), System.Drawing.Image)
            Me.alignBottomToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.alignBottomToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.alignBottomToolStripButton.Name = "alignBottomToolStripButton"
            Me.alignBottomToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.alignBottomToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.alignBottomToolStripButton.Text = "Align" & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom"
            Me.alignBottomToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.alignBottomToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripSeparator4
            '
            Me.toolStripSeparator4.Name = "toolStripSeparator4"
            Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 38)
            '
            'rotateLeftToolStripButton
            '
            Me.rotateLeftToolStripButton.AutoSize = False
            Me.rotateLeftToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.rotateLeftToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.rotateLeftToolStripButton.Enabled = False
            Me.rotateLeftToolStripButton.Image = CType(resources.GetObject("rotateLeftToolStripButton.Image"), System.Drawing.Image)
            Me.rotateLeftToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.rotateLeftToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.rotateLeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.rotateLeftToolStripButton.Name = "rotateLeftToolStripButton"
            Me.rotateLeftToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.rotateLeftToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.rotateLeftToolStripButton.Text = "Rotate" & Global.Microsoft.VisualBasic.ChrW(10) & "Left"
            Me.rotateLeftToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.rotateLeftToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'rotateRightToolStripButton
            '
            Me.rotateRightToolStripButton.AutoSize = False
            Me.rotateRightToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.rotateRightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.rotateRightToolStripButton.Enabled = False
            Me.rotateRightToolStripButton.Image = CType(resources.GetObject("rotateRightToolStripButton.Image"), System.Drawing.Image)
            Me.rotateRightToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.rotateRightToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.rotateRightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.rotateRightToolStripButton.Name = "rotateRightToolStripButton"
            Me.rotateRightToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.rotateRightToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.rotateRightToolStripButton.Text = "Rotate" & Global.Microsoft.VisualBasic.ChrW(10) & "Right"
            Me.rotateRightToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.rotateRightToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripSeparator5
            '
            Me.toolStripSeparator5.Name = "toolStripSeparator5"
            Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 38)
            '
            'flipVerticalToolStripButton
            '
            Me.flipVerticalToolStripButton.AutoSize = False
            Me.flipVerticalToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.flipVerticalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.flipVerticalToolStripButton.Enabled = False
            Me.flipVerticalToolStripButton.Image = CType(resources.GetObject("flipVerticalToolStripButton.Image"), System.Drawing.Image)
            Me.flipVerticalToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.flipVerticalToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.flipVerticalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.flipVerticalToolStripButton.Name = "flipVerticalToolStripButton"
            Me.flipVerticalToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.flipVerticalToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.flipVerticalToolStripButton.Text = "Flip" & Global.Microsoft.VisualBasic.ChrW(10) & "Vertical"
            Me.flipVerticalToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.flipVerticalToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'flipHorizontalToolStripButton
            '
            Me.flipHorizontalToolStripButton.AutoSize = False
            Me.flipHorizontalToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.flipHorizontalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.flipHorizontalToolStripButton.Enabled = False
            Me.flipHorizontalToolStripButton.Image = CType(resources.GetObject("flipHorizontalToolStripButton.Image"), System.Drawing.Image)
            Me.flipHorizontalToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.flipHorizontalToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.flipHorizontalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.flipHorizontalToolStripButton.Name = "flipHorizontalToolStripButton"
            Me.flipHorizontalToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.flipHorizontalToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.flipHorizontalToolStripButton.Text = "Flip" & Global.Microsoft.VisualBasic.ChrW(10) & "Horizontal"
            Me.flipHorizontalToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.flipHorizontalToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 38)
            '
            'spaceAcrossToolStripButton
            '
            Me.spaceAcrossToolStripButton.AutoSize = False
            Me.spaceAcrossToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.spaceAcrossToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.spaceAcrossToolStripButton.Enabled = False
            Me.spaceAcrossToolStripButton.Image = CType(resources.GetObject("spaceAcrossToolStripButton.Image"), System.Drawing.Image)
            Me.spaceAcrossToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.spaceAcrossToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.spaceAcrossToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.spaceAcrossToolStripButton.Name = "spaceAcrossToolStripButton"
            Me.spaceAcrossToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.spaceAcrossToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.spaceAcrossToolStripButton.Text = "Space" & Global.Microsoft.VisualBasic.ChrW(10) & "Across"
            Me.spaceAcrossToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.spaceAcrossToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'spaceDownToolStripButton
            '
            Me.spaceDownToolStripButton.AutoSize = False
            Me.spaceDownToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.spaceDownToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.spaceDownToolStripButton.Enabled = False
            Me.spaceDownToolStripButton.Image = CType(resources.GetObject("spaceDownToolStripButton.Image"), System.Drawing.Image)
            Me.spaceDownToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.spaceDownToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.spaceDownToolStripButton.Name = "spaceDownToolStripButton"
            Me.spaceDownToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.spaceDownToolStripButton.Text = "Space" & Global.Microsoft.VisualBasic.ChrW(10) & "Down"
            Me.spaceDownToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.spaceDownToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'sameWidthToolStripButton
            '
            Me.sameWidthToolStripButton.AutoSize = False
            Me.sameWidthToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.sameWidthToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.sameWidthToolStripButton.Enabled = False
            Me.sameWidthToolStripButton.Image = CType(resources.GetObject("sameWidthToolStripButton.Image"), System.Drawing.Image)
            Me.sameWidthToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.sameWidthToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.sameWidthToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.sameWidthToolStripButton.Name = "sameWidthToolStripButton"
            Me.sameWidthToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.sameWidthToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.sameWidthToolStripButton.Text = "Same" & Global.Microsoft.VisualBasic.ChrW(10) & "Width"
            Me.sameWidthToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.sameWidthToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'sameHeightToolStripButton
            '
            Me.sameHeightToolStripButton.AutoSize = False
            Me.sameHeightToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.sameHeightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.sameHeightToolStripButton.Enabled = False
            Me.sameHeightToolStripButton.Image = CType(resources.GetObject("sameHeightToolStripButton.Image"), System.Drawing.Image)
            Me.sameHeightToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.sameHeightToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.sameHeightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.sameHeightToolStripButton.Name = "sameHeightToolStripButton"
            Me.sameHeightToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.sameHeightToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.sameHeightToolStripButton.Text = "Same" & Global.Microsoft.VisualBasic.ChrW(10) & "Height"
            Me.sameHeightToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.sameHeightToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'sameSizeToolStripButton
            '
            Me.sameSizeToolStripButton.AutoSize = False
            Me.sameSizeToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.sameSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.sameSizeToolStripButton.Enabled = False
            Me.sameSizeToolStripButton.Image = CType(resources.GetObject("sameSizeToolStripButton.Image"), System.Drawing.Image)
            Me.sameSizeToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.sameSizeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.sameSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.sameSizeToolStripButton.Name = "sameSizeToolStripButton"
            Me.sameSizeToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.sameSizeToolStripButton.Size = New System.Drawing.Size(35, 35)
            Me.sameSizeToolStripButton.Text = "Same" & Global.Microsoft.VisualBasic.ChrW(10) & "Size"
            Me.sameSizeToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.sameSizeToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.diagram1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel2.Location = New System.Drawing.Point(0, 118)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(735, 543)
            Me.panel2.TabIndex = 3
            '
            'diagram1
            '
            Me.diagram1.BackColor = System.Drawing.SystemColors.Control
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(0, 0)
            Me.diagram1.Model = Me.model1
            Me.diagram1.Name = "diagram1"
            Me.diagram1.Padding = New System.Windows.Forms.Padding(2, 2, 10, 2)
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(735, 543)
            Me.diagram1.SmartSizeBox = False
            Me.diagram1.TabIndex = 0
            Me.diagram1.Text = "diagram1"
            '
            '
            '
            Me.diagram1.View.BackgroundColor = System.Drawing.SystemColors.Control
            Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
            Me.diagram1.View.Controller = Me.diagram1.Controller
            Me.diagram1.View.Grid.MinPixelSpacing = 4.0!
            Me.diagram1.View.ScrollVirtualBounds = CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF)
            '
            'model1
            '
            Me.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
            Me.model1.DocumentScale.DisplayName = "No Scale"
            Me.model1.DocumentScale.Height = 1.0!
            Me.model1.DocumentScale.Width = 1.0!
            Me.model1.DocumentSize.Height = 485.0!
            Me.model1.DocumentSize.Width = 1492.0!
            Me.model1.LineStyle.DashPattern = Nothing
            Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
            Me.model1.LogicalSize = New System.Drawing.SizeF(1492.0!, 485.0!)
            Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(735, 661)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.toolStrip1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.panel2.ResumeLayout(False)
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private panel1 As DemoCommon.Diagram.TitlePanel
		Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
		Private cutToolStripButton As System.Windows.Forms.ToolStripButton
		Private copyToolStripButton As System.Windows.Forms.ToolStripButton
		Private pasteToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private alignLeftToolStripButton As System.Windows.Forms.ToolStripButton
		Private alignBottomToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
		Private rotateLeftToolStripButton As System.Windows.Forms.ToolStripButton
		Private rotateRightToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private alignCenterToolStripButton As System.Windows.Forms.ToolStripButton
		Private alignRightToolStripButton As System.Windows.Forms.ToolStripButton
		Private alignTopToolStripButton As System.Windows.Forms.ToolStripButton
		Private alignMiddleToolStripButton As System.Windows.Forms.ToolStripButton
		Private spaceAcrossToolStripButton As System.Windows.Forms.ToolStripButton
		Private spaceDownToolStripButton As System.Windows.Forms.ToolStripButton
		Private sameWidthToolStripButton As System.Windows.Forms.ToolStripButton
		Private sameHeightToolStripButton As System.Windows.Forms.ToolStripButton
		Private sameSizeToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
		Private flipVerticalToolStripButton As System.Windows.Forms.ToolStripButton
		Private flipHorizontalToolStripButton As System.Windows.Forms.ToolStripButton
		Private panel2 As System.Windows.Forms.Panel
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
	End Class
End Namespace


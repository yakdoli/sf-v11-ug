Imports Microsoft.VisualBasic
Imports System
Namespace MultiColumnTreeViewDemo
	Partial Public Class MainForm
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
            Dim TreeNodeAdvSubItemStyleInfo1 As Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo = New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvSubItemStyleInfo
            Dim TreeNodeAdvStyleInfo1 As Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeNodeAdvStyleInfo
            Dim TreeColumnAdvStyleInfo1 As Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.TreeColumnAdvStyleInfo
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.multiColumnTreeView1 = New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeView
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel
            Me.ColorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.ColorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.ColorPickerButton3 = New Syncfusion.Windows.Forms.ColorPickerButton
            CType(Me.multiColumnTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'multiColumnTreeView1
            '
            Me.multiColumnTreeView1.AddSeparatorAtEnd = True
            Me.multiColumnTreeView1.AutoAdjustMultiLineHeight = True
            Me.multiColumnTreeView1.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair() {New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard - SubItem", TreeNodeAdvSubItemStyleInfo1), New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard", TreeNodeAdvStyleInfo1), New Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.StyleNamePair("Standard - Column", TreeColumnAdvStyleInfo1)})
            Me.multiColumnTreeView1.ColumnsHeaderBackground = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
            Me.multiColumnTreeView1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.multiColumnTreeView1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.multiColumnTreeView1.HelpTextControl.Location = New System.Drawing.Point(0, 0)
            Me.multiColumnTreeView1.HelpTextControl.Name = "m_helpText"
            Me.multiColumnTreeView1.HelpTextControl.Size = New System.Drawing.Size(49, 15)
            Me.multiColumnTreeView1.HelpTextControl.TabIndex = 0
            Me.multiColumnTreeView1.HelpTextControl.Text = "help text"
            Me.multiColumnTreeView1.LabelEdit = True
            Me.multiColumnTreeView1.LoadOnDemand = True
            Me.multiColumnTreeView1.Location = New System.Drawing.Point(0, 66)
            Me.multiColumnTreeView1.Name = "multiColumnTreeView1"
            Me.multiColumnTreeView1.OwnerDrawNodes = True
            Me.multiColumnTreeView1.Size = New System.Drawing.Size(759, 486)
            Me.multiColumnTreeView1.StateImageList = Me.imageList1
            Me.multiColumnTreeView1.TabIndex = 0
            Me.multiColumnTreeView1.Text = "MultiColumnTreeViewDemo.csmultiColumnTreeView1"
            '
            '
            '
            Me.multiColumnTreeView1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
            Me.multiColumnTreeView1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.multiColumnTreeView1.ToolTipControl.Location = New System.Drawing.Point(0, 0)
            Me.multiColumnTreeView1.ToolTipControl.Name = "m_toolTip"
            Me.multiColumnTreeView1.ToolTipControl.Size = New System.Drawing.Size(41, 15)
            Me.multiColumnTreeView1.ToolTipControl.TabIndex = 1
            Me.multiColumnTreeView1.ToolTipControl.Text = "toolTip"
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "folder.ico")
            Me.imageList1.Images.SetKeyName(1, "folder.ico")
            Me.imageList1.Images.SetKeyName(2, "folder.ico")
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.ColorPickerButton3)
            Me.Panel1.Controls.Add(Me.ColorPickerButton2)
            Me.Panel1.Controls.Add(Me.ColorPickerButton1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(759, 68)
            Me.Panel1.TabIndex = 1
            '
            'ColorPickerButton1
            '
            Me.ColorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.ColorPickerButton1.Location = New System.Drawing.Point(534, 17)
            Me.ColorPickerButton1.Name = "ColorPickerButton1"
            Me.ColorPickerButton1.Size = New System.Drawing.Size(213, 25)
            Me.ColorPickerButton1.TabIndex = 0
            Me.ColorPickerButton1.Text = "Header 3 HighLight Border"
            Me.ColorPickerButton1.UseVisualStyleBackColor = True
            '
            'ColorPickerButton2
            '
            Me.ColorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
            Me.ColorPickerButton2.Location = New System.Drawing.Point(276, 15)
            Me.ColorPickerButton2.Name = "ColorPickerButton2"
            Me.ColorPickerButton2.Size = New System.Drawing.Size(203, 25)
            Me.ColorPickerButton2.TabIndex = 1
            Me.ColorPickerButton2.Text = "Header 2 HighLight Border"
            Me.ColorPickerButton2.UseVisualStyleBackColor = True
            '
            'ColorPickerButton3
            '
            Me.ColorPickerButton3.ColorUISize = New System.Drawing.Size(208, 230)
            Me.ColorPickerButton3.Location = New System.Drawing.Point(12, 17)
            Me.ColorPickerButton3.Name = "ColorPickerButton3"
            Me.ColorPickerButton3.Size = New System.Drawing.Size(206, 23)
            Me.ColorPickerButton3.TabIndex = 2
            Me.ColorPickerButton3.Text = "Header 1 HighLight Border"
            Me.ColorPickerButton3.UseVisualStyleBackColor = True
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(759, 552)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.multiColumnTreeView1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Multi Column TreeView"
            CType(Me.multiColumnTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private multiColumnTreeView1 As Syncfusion.Windows.Forms.Tools.MultiColumnTreeView.MultiColumnTreeView
        Private imageList1 As System.Windows.Forms.ImageList
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents ColorPickerButton3 As Syncfusion.Windows.Forms.ColorPickerButton
        Friend WithEvents ColorPickerButton2 As Syncfusion.Windows.Forms.ColorPickerButton
        Friend WithEvents ColorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
	End Class
End Namespace
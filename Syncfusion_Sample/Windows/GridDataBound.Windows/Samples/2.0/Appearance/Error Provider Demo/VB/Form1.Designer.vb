Imports Microsoft.VisualBasic
Imports System
Namespace ErrorProvider
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
            Me.components = New System.ComponentModel.Container()
            Me.GridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.chkSetError = New System.Windows.Forms.CheckBox()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.checkBox4 = New System.Windows.Forms.CheckBox()
            Me.checkBox3 = New System.Windows.Forms.CheckBox()
            Me.checkBox2 = New System.Windows.Forms.CheckBox()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            CType(Me.GridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GridDataBoundGrid1
            '
            Me.GridDataBoundGrid1.AllowDragSelectedCols = True
            Me.GridDataBoundGrid1.GridLineColor = System.Drawing.SystemColors.GrayText
            Me.GridDataBoundGrid1.Location = New System.Drawing.Point(9, 12)
            Me.GridDataBoundGrid1.Name = "GridDataBoundGrid1"
            Me.GridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
            Me.GridDataBoundGrid1.Size = New System.Drawing.Size(492, 127)
            Me.GridDataBoundGrid1.SmartSizeBox = False
            Me.GridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
            Me.GridDataBoundGrid1.TabIndex = 0
            Me.GridDataBoundGrid1.Text = "GridDataBoundGrid1"
            Me.GridDataBoundGrid1.UseRightToLeftCompatibleTextBox = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.textBox2)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.chkSetError)
            Me.groupBox1.Controls.Add(Me.textBox1)
            Me.groupBox1.Controls.Add(Me.checkBox4)
            Me.groupBox1.Controls.Add(Me.checkBox3)
            Me.groupBox1.Controls.Add(Me.checkBox2)
            Me.groupBox1.Controls.Add(Me.checkBox1)
            Me.groupBox1.Location = New System.Drawing.Point(9, 153)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(492, 154)
            Me.groupBox1.TabIndex = 1
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Error Provider Settings"
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(108, 108)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(379, 20)
            Me.textBox2.TabIndex = 20
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(105, 131)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(210, 13)
            Me.label2.TabIndex = 19
            Me.label2.Text = "(The error Messagebox will display this text)"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(114, 73)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(210, 13)
            Me.label1.TabIndex = 18
            Me.label1.Text = "(The error Messagebox will display this text)"
            '
            'chkSetError
            '
            Me.chkSetError.AutoSize = True
            Me.chkSetError.Location = New System.Drawing.Point(6, 111)
            Me.chkSetError.Name = "chkSetError"
            Me.chkSetError.Size = New System.Drawing.Size(105, 17)
            Me.chkSetError.TabIndex = 17
            Me.chkSetError.Text = "Set Custom Error"
            Me.ToolTip1.SetToolTip(Me.chkSetError, "This will trigger the CurrentCellValidating event to customize the error")
            Me.chkSetError.UseVisualStyleBackColor = True
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(108, 50)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(379, 20)
            Me.textBox1.TabIndex = 16
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Location = New System.Drawing.Point(6, 52)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(96, 17)
            Me.checkBox4.TabIndex = 15
            Me.checkBox4.Text = "Validation Text"
            Me.checkBox4.UseVisualStyleBackColor = True
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Location = New System.Drawing.Point(173, 21)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(142, 17)
            Me.checkBox3.TabIndex = 14
            Me.checkBox3.Text = "Show Error MessageBox"
            Me.checkBox3.UseVisualStyleBackColor = True
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Location = New System.Drawing.Point(336, 21)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(155, 17)
            Me.checkBox2.TabIndex = 13
            Me.checkBox2.Text = "Show Currentcell Error Icon"
            Me.checkBox2.UseVisualStyleBackColor = True
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(6, 21)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(140, 17)
            Me.checkBox1.TabIndex = 12
            Me.checkBox1.Text = "Show Header Error Icon"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(513, 312)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.GridDataBoundGrid1)
            Me.Name = "Form1"
            Me.Text = "ErrorProvider"
            CType(Me.GridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private GridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private label2 As System.Windows.Forms.Label
        Private label1 As System.Windows.Forms.Label
        Private WithEvents chkSetError As System.Windows.Forms.CheckBox
        Private WithEvents textBox1 As System.Windows.Forms.TextBox
		Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
		Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
		Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private textBox2 As System.Windows.Forms.TextBox
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	End Class
End Namespace


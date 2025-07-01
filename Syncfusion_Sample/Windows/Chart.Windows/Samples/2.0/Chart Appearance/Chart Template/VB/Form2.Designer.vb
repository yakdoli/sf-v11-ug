Imports Microsoft.VisualBasic
Imports System
Namespace ChartTemplate_2005
	Partial Public Class Form2
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.SuspendLayout()
            '
            'radioButton1
            '
            Me.radioButton1.AutoSize = True
            Me.radioButton1.BackColor = System.Drawing.Color.Transparent
            Me.radioButton1.Checked = True
            Me.radioButton1.Location = New System.Drawing.Point(13, 17)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(196, 17)
            Me.radioButton1.TabIndex = 0
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "Save Changes to the same template"
            Me.radioButton1.UseVisualStyleBackColor = False
            '
            'radioButton2
            '
            Me.radioButton2.AutoSize = True
            Me.radioButton2.BackColor = System.Drawing.Color.Transparent
            Me.radioButton2.Location = New System.Drawing.Point(13, 50)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(183, 17)
            Me.radioButton2.TabIndex = 1
            Me.radioButton2.Text = "Save changes as a new template"
            Me.radioButton2.UseVisualStyleBackColor = False
            '
            'buttonAdv2
            '
            Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP
            Me.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat
            Me.buttonAdv2.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.buttonAdv2.Location = New System.Drawing.Point(112, 85)
            Me.buttonAdv2.Name = "buttonAdv2"
            Me.buttonAdv2.Size = New System.Drawing.Size(58, 23)
            Me.buttonAdv2.TabIndex = 3
            Me.buttonAdv2.Text = "Cancel"
            Me.buttonAdv2.UseVisualStyle = True
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP
            Me.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat
            Me.buttonAdv1.Location = New System.Drawing.Point(32, 85)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(58, 23)
            Me.buttonAdv1.TabIndex = 2
            Me.buttonAdv1.Text = "Save"
            Me.buttonAdv1.UseVisualStyle = True
            '
            'Form2
            '
            Me.AcceptButton = Me.buttonAdv1
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.CancelButton = Me.buttonAdv2
            Me.ClientSize = New System.Drawing.Size(221, 121)
            Me.ControlBox = False
            Me.Controls.Add(Me.buttonAdv1)
            Me.Controls.Add(Me.radioButton1)
            Me.Controls.Add(Me.buttonAdv2)
            Me.Controls.Add(Me.radioButton2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form2"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Save Template"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Public radioButton1 As System.Windows.Forms.RadioButton
		Public radioButton2 As System.Windows.Forms.RadioButton
		Public buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Public buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
	End Class
End Namespace
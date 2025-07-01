Imports Microsoft.VisualBasic
Imports System
Namespace PivotGridLibrary
	Public Partial Class PivotComputationInfoForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.textBoxDescription = New System.Windows.Forms.TextBox()
			Me.textBoxFormat = New System.Windows.Forms.TextBox()
			Me.buttonCancel = New System.Windows.Forms.Button()
			Me.buttonOK = New System.Windows.Forms.Button()
			Me.labelName = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(61, 30)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(63, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Field Name:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(61, 58)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(63, 13)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Description:"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(82, 89)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(42, 13)
			Me.label3.TabIndex = 2
			Me.label3.Text = "Format:"
			' 
			' listBox1
			' 
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.Location = New System.Drawing.Point(130, 123)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(101, 121)
			Me.listBox1.TabIndex = 3
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(24, 123)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(100, 13)
			Me.label4.TabIndex = 4
			Me.label4.Text = "Computation Name:"
			' 
			' textBoxDescription
			' 
			Me.textBoxDescription.Location = New System.Drawing.Point(130, 53)
			Me.textBoxDescription.Name = "textBoxDescription"
			Me.textBoxDescription.Size = New System.Drawing.Size(100, 20)
			Me.textBoxDescription.TabIndex = 6
			' 
			' textBoxFormat
			' 
			Me.textBoxFormat.Location = New System.Drawing.Point(130, 84)
			Me.textBoxFormat.Name = "textBoxFormat"
			Me.textBoxFormat.Size = New System.Drawing.Size(100, 20)
			Me.textBoxFormat.TabIndex = 7
			' 
			' buttonCancel
			' 
			Me.buttonCancel.CausesValidation = False
			Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.buttonCancel.Location = New System.Drawing.Point(176, 274)
			Me.buttonCancel.Name = "buttonCancel"
			Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
			Me.buttonCancel.TabIndex = 8
			Me.buttonCancel.Text = "Cancel"
			Me.buttonCancel.UseVisualStyleBackColor = True
'			Me.buttonCancel.Click += New System.EventHandler(Me.buttonCancel_Click);
			' 
			' buttonOK
			' 
			Me.buttonOK.Location = New System.Drawing.Point(85, 274)
			Me.buttonOK.Name = "buttonOK"
			Me.buttonOK.Size = New System.Drawing.Size(75, 23)
			Me.buttonOK.TabIndex = 9
			Me.buttonOK.Text = "OK"
			Me.buttonOK.UseVisualStyleBackColor = True
'			Me.buttonOK.Click += New System.EventHandler(Me.buttonOK_Click);
			' 
			' labelName
			' 
			Me.labelName.AutoSize = True
			Me.labelName.Location = New System.Drawing.Point(131, 29)
			Me.labelName.Name = "labelName"
			Me.labelName.Size = New System.Drawing.Size(0, 13)
			Me.labelName.TabIndex = 10
			' 
			' PivotComputationInfoForm
			' 
			Me.AcceptButton = Me.buttonOK
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.buttonCancel
			Me.ClientSize = New System.Drawing.Size(299, 317)
			Me.Controls.Add(Me.labelName)
			Me.Controls.Add(Me.buttonOK)
			Me.Controls.Add(Me.buttonCancel)
			Me.Controls.Add(Me.textBoxFormat)
			Me.Controls.Add(Me.textBoxDescription)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "PivotComputationInfoForm"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.Text = "Pivot Computation Information"
'			Me.Load += New System.EventHandler(Me.PivotComputationInfoForm_Load);
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private listBox1 As System.Windows.Forms.ListBox
		Private label4 As System.Windows.Forms.Label
		Private textBoxDescription As System.Windows.Forms.TextBox
		Private textBoxFormat As System.Windows.Forms.TextBox
		Private WithEvents buttonCancel As System.Windows.Forms.Button
		Private WithEvents buttonOK As System.Windows.Forms.Button
		Private labelName As System.Windows.Forms.Label
	End Class
End Namespace
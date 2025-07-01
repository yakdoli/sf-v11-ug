Namespace EssentailXlsIOSample
    Partial Public Class LINQWrapper
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LINQWrapper))
            Me.txtResult = New System.Windows.Forms.TextBox()
            Me.btnQueryData = New System.Windows.Forms.Button()
            Me.cmbName = New System.Windows.Forms.ComboBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label3 = New System.Windows.Forms.Label()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtResult
            '
            Me.txtResult.Location = New System.Drawing.Point(74, 222)
            Me.txtResult.Multiline = True
            Me.txtResult.Name = "txtResult"
            Me.txtResult.ReadOnly = True
            Me.txtResult.Size = New System.Drawing.Size(277, 50)
            Me.txtResult.TabIndex = 1
            '
            'btnQueryData
            '
            Me.btnQueryData.Location = New System.Drawing.Point(276, 285)
            Me.btnQueryData.Name = "btnQueryData"
            Me.btnQueryData.Size = New System.Drawing.Size(75, 23)
            Me.btnQueryData.TabIndex = 2
            Me.btnQueryData.Text = "Query Data"
            Me.btnQueryData.UseVisualStyleBackColor = True
            '
            'cmbName
            '
            Me.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbName.FormattingEnabled = True
            Me.cmbName.Items.AddRange(New Object() {"Maria", "Ana", "Antonio", "Thomas", "Christina", "Hanna"})
            Me.cmbName.Location = New System.Drawing.Point(223, 103)
            Me.cmbName.Name = "cmbName"
            Me.cmbName.Size = New System.Drawing.Size(128, 21)
            Me.cmbName.TabIndex = 0
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Location = New System.Drawing.Point(12, 103)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(160, 13)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Select a name from this list"
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(74, 147)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(277, 45)
            Me.textBox1.TabIndex = 5
            Me.textBox1.Text = "var matchingRanges = from IRange s in sheet[""FirstName""] where s.Text == cmbName." & _
                "SelectedItem.ToString() select s;"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Location = New System.Drawing.Point(12, 147)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(40, 13)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Query"
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(372, 96)
            Me.pictureBox1.TabIndex = 63
            Me.pictureBox1.TabStop = False
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Location = New System.Drawing.Point(12, 222)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(43, 13)
            Me.label3.TabIndex = 71
            Me.label3.Text = "Status"
            '
            'Form1
            '
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(372, 317)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.cmbName)
            Me.Controls.Add(Me.btnQueryData)
            Me.Controls.Add(Me.txtResult)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "LINQ Wrapper"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private txtResult As TextBox
        Private WithEvents btnQueryData As Button
        Private cmbName As ComboBox
        Private label1 As Label
        Private textBox1 As TextBox
        Private label2 As Label
        Private pictureBox1 As PictureBox
        Private label3 As Label
    End Class
End Namespace


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EssentailXlsIOSamples
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EssentailXlsIOSamples))
        Me.label2 = New System.Windows.Forms.Label
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnConvert = New System.Windows.Forms.Button
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbMetafile = New System.Windows.Forms.RadioButton
        Me.rdbBitmap = New System.Windows.Forms.RadioButton
        Me.viewInputTemplate = New System.Windows.Forms.Button
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label2.Location = New System.Drawing.Point(0, 105)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(372, 48)
        Me.label2.TabIndex = 81
        Me.label2.Text = "Click the button below to convert the Excel worksheet to image using Essential Xl" & _
            "sIO."
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(372, 96)
        Me.pictureBox1.TabIndex = 80
        Me.pictureBox1.TabStop = False
        '
        'btnConvert
        '
        Me.btnConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConvert.BackColor = System.Drawing.Color.Transparent
        Me.btnConvert.Image = CType(resources.GetObject("btnConvert.Image"), System.Drawing.Image)
        Me.btnConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConvert.Location = New System.Drawing.Point(50, 213)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(89, 26)
        Me.btnConvert.TabIndex = 79
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rdbMetafile)
        Me.groupBox1.Controls.Add(Me.rdbBitmap)
        Me.groupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.groupBox1.Location = New System.Drawing.Point(86, 156)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(188, 41)
        Me.groupBox1.TabIndex = 83
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Image format"
        '
        'rdbMetafile
        '
        Me.rdbMetafile.AutoSize = True
        Me.rdbMetafile.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rdbMetafile.Location = New System.Drawing.Point(101, 20)
        Me.rdbMetafile.Name = "rdbMetafile"
        Me.rdbMetafile.Size = New System.Drawing.Size(69, 17)
        Me.rdbMetafile.TabIndex = 1
        Me.rdbMetafile.Text = "Metafile"
        Me.rdbMetafile.UseVisualStyleBackColor = True
        '
        'rdbBitmap
        '
        Me.rdbBitmap.AutoSize = True
        Me.rdbBitmap.Checked = True
        Me.rdbBitmap.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rdbBitmap.Location = New System.Drawing.Point(20, 20)
        Me.rdbBitmap.Name = "rdbBitmap"
        Me.rdbBitmap.Size = New System.Drawing.Size(65, 17)
        Me.rdbBitmap.TabIndex = 0
        Me.rdbBitmap.TabStop = True
        Me.rdbBitmap.Text = "Bitmap"
        Me.rdbBitmap.UseVisualStyleBackColor = True
        '
        'viewInputTemplate
        '
        Me.viewInputTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewInputTemplate.BackColor = System.Drawing.Color.Transparent
        Me.viewInputTemplate.Image = CType(resources.GetObject("viewInputTemplate.Image"), System.Drawing.Image)
        Me.viewInputTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.viewInputTemplate.Location = New System.Drawing.Point(167, 213)
        Me.viewInputTemplate.Name = "viewInputTemplate"
        Me.viewInputTemplate.Size = New System.Drawing.Size(131, 26)
        Me.viewInputTemplate.TabIndex = 84
        Me.viewInputTemplate.Text = "Input Template"
        Me.viewInputTemplate.UseVisualStyleBackColor = False
        '
        'EssentailXlsIOSamples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(372, 251)
        Me.Controls.Add(Me.viewInputTemplate)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.btnConvert)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EssentailXlsIOSamples"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Worksheet to Image"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents btnConvert As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rdbMetafile As System.Windows.Forms.RadioButton
    Private WithEvents rdbBitmap As System.Windows.Forms.RadioButton
    Private WithEvents viewInputTemplate As System.Windows.Forms.Button

End Class

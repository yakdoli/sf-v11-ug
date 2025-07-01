Imports Microsoft.VisualBasic
Imports System
Namespace EssentialXlsIOSamples
    Partial Public Class StockReport
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockReport))
            Me.ImageChDialog = New System.Windows.Forms.OpenFileDialog
            Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
            Me.btnCreateReport = New System.Windows.Forms.Button
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.pictureBox2 = New System.Windows.Forms.PictureBox
            Me.label10 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.StockList = New System.Windows.Forms.ListBox
            Me.label4 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.StartDateTimePicker = New System.Windows.Forms.DateTimePicker
            Me.label2 = New System.Windows.Forms.Label
            Me.isCornersRound = New System.Windows.Forms.CheckBox
            Me.label3 = New System.Windows.Forms.Label
            Me.EndDateTimePicker = New System.Windows.Forms.DateTimePicker
            Me.reportdir = New System.Windows.Forms.Button
            Me.bacgrimage = New System.Windows.Forms.Button
            Me.label8 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.label14 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.viewInputTemplate = New System.Windows.Forms.Button
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ImageChDialog
            '
            Me.ImageChDialog.FileName = "openFileDialog1"
            '
            'btnCreateReport
            '
            Me.btnCreateReport.Location = New System.Drawing.Point(376, 428)
            Me.btnCreateReport.Name = "btnCreateReport"
            Me.btnCreateReport.Size = New System.Drawing.Size(84, 26)
            Me.btnCreateReport.TabIndex = 6
            Me.btnCreateReport.Text = "Create report"
            Me.btnCreateReport.UseVisualStyleBackColor = True
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(482, 78)
            Me.pictureBox1.TabIndex = 61
            Me.pictureBox1.TabStop = False
            '
            'pictureBox2
            '
            Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
            Me.pictureBox2.Location = New System.Drawing.Point(0, 460)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(482, 18)
            Me.pictureBox2.TabIndex = 66
            Me.pictureBox2.TabStop = False
            '
            'label10
            '
            Me.label10.Dock = System.Windows.Forms.DockStyle.Top
            Me.label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label10.Location = New System.Drawing.Point(0, 78)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(482, 103)
            Me.label10.TabIndex = 71
            Me.label10.Text = resources.GetString("label10.Text")
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label1.ForeColor = System.Drawing.Color.Black
            Me.label1.Location = New System.Drawing.Point(21, 225)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(160, 14)
            Me.label1.TabIndex = 7
            Me.label1.Text = "Select one or more stocks: "
            '
            'StockList
            '
            Me.StockList.FormattingEnabled = True
            Me.StockList.Items.AddRange(New Object() {"AAPL", "ADBE", "AMD", "AMZN", "BF.B", "BRCM", "CSCO", "DELL", "EBAY", "GOOG", "IBM", "INTC", "JDSU", "JNPR", "MSFT", "ORCL", "QCOM", "SYMC", "YHOO"})
            Me.StockList.Location = New System.Drawing.Point(24, 259)
            Me.StockList.Name = "StockList"
            Me.StockList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
            Me.StockList.Size = New System.Drawing.Size(181, 160)
            Me.StockList.Sorted = True
            Me.StockList.TabIndex = 8
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label4.ForeColor = System.Drawing.Color.Black
            Me.label4.Location = New System.Drawing.Point(21, 239)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(184, 14)
            Me.label4.TabIndex = 10
            Me.label4.Text = "To select more than one hold Ctrl key"
            '
            'label6
            '
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label6.Location = New System.Drawing.Point(21, 191)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(69, 24)
            Me.label6.TabIndex = 67
            Me.label6.Text = "Stocks"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'StartDateTimePicker
            '
            Me.StartDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.StartDateTimePicker.Location = New System.Drawing.Point(261, 241)
            Me.StartDateTimePicker.MaxDate = New Date(2008, 1, 29, 0, 0, 0, 0)
            Me.StartDateTimePicker.MinDate = New Date(2007, 12, 31, 0, 0, 0, 0)
            Me.StartDateTimePicker.Name = "StartDateTimePicker"
            Me.StartDateTimePicker.Size = New System.Drawing.Size(199, 20)
            Me.StartDateTimePicker.TabIndex = 3
            Me.StartDateTimePicker.Value = New Date(2008, 1, 1, 0, 0, 0, 0)
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.Location = New System.Drawing.Point(260, 225)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(55, 14)
            Me.label2.TabIndex = 5
            Me.label2.Text = "Start Data"
            '
            'isCornersRound
            '
            Me.isCornersRound.AutoSize = True
            Me.isCornersRound.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.isCornersRound.Location = New System.Drawing.Point(263, 381)
            Me.isCornersRound.Name = "isCornersRound"
            Me.isCornersRound.Size = New System.Drawing.Size(165, 18)
            Me.isCornersRound.TabIndex = 0
            Me.isCornersRound.Text = "Curved borders for the chart"
            Me.isCornersRound.UseVisualStyleBackColor = True
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label3.Location = New System.Drawing.Point(259, 268)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(50, 14)
            Me.label3.TabIndex = 6
            Me.label3.Text = "End Data"
            '
            'EndDateTimePicker
            '
            Me.EndDateTimePicker.Location = New System.Drawing.Point(261, 285)
            Me.EndDateTimePicker.MaxDate = New Date(2008, 1, 29, 0, 0, 0, 0)
            Me.EndDateTimePicker.MinDate = New Date(2007, 12, 31, 0, 0, 0, 0)
            Me.EndDateTimePicker.Name = "EndDateTimePicker"
            Me.EndDateTimePicker.Size = New System.Drawing.Size(199, 20)
            Me.EndDateTimePicker.TabIndex = 4
            Me.EndDateTimePicker.Value = New Date(2008, 1, 29, 0, 0, 0, 0)
            '
            'reportdir
            '
            Me.reportdir.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.reportdir.Location = New System.Drawing.Point(185, 430)
            Me.reportdir.Name = "reportdir"
            Me.reportdir.Size = New System.Drawing.Size(20, 20)
            Me.reportdir.TabIndex = 2
            Me.reportdir.Text = "..."
            Me.reportdir.UseVisualStyleBackColor = True
            '
            'bacgrimage
            '
            Me.bacgrimage.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.bacgrimage.Location = New System.Drawing.Point(440, 349)
            Me.bacgrimage.Name = "bacgrimage"
            Me.bacgrimage.Size = New System.Drawing.Size(20, 20)
            Me.bacgrimage.TabIndex = 1
            Me.bacgrimage.Text = "..."
            Me.bacgrimage.UseVisualStyleBackColor = True
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label8.Location = New System.Drawing.Point(259, 353)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(149, 14)
            Me.label8.TabIndex = 69
            Me.label8.Text = "Select the BackGround Image"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label9.Location = New System.Drawing.Point(21, 435)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(137, 14)
            Me.label9.TabIndex = 70
            Me.label9.Text = "Select the Report Directory"
            '
            'label11
            '
            Me.label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label11.Location = New System.Drawing.Point(21, 214)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(185, 1)
            Me.label11.TabIndex = 73
            '
            'label7
            '
            Me.label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Image)
            Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label7.Location = New System.Drawing.Point(260, 189)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(76, 24)
            Me.label7.TabIndex = 68
            Me.label7.Text = "TimeLine"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label14
            '
            Me.label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label14.Location = New System.Drawing.Point(260, 214)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(200, 1)
            Me.label14.TabIndex = 72
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label5.Location = New System.Drawing.Point(263, 341)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(200, 1)
            Me.label5.TabIndex = 75
            '
            'label12
            '
            Me.label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label12.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label12.Image = CType(resources.GetObject("label12.Image"), System.Drawing.Image)
            Me.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label12.Location = New System.Drawing.Point(260, 316)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(106, 24)
            Me.label12.TabIndex = 74
            Me.label12.Text = "Look And Feel"
            Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'viewInputTemplate
            '
            Me.viewInputTemplate.Location = New System.Drawing.Point(261, 428)
            Me.viewInputTemplate.Name = "viewInputTemplate"
            Me.viewInputTemplate.Size = New System.Drawing.Size(95, 26)
            Me.viewInputTemplate.TabIndex = 76
            Me.viewInputTemplate.Text = "Input Template"
            Me.viewInputTemplate.UseVisualStyleBackColor = True
            '
            'StockReport
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(482, 478)
            Me.Controls.Add(Me.viewInputTemplate)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label12)
            Me.Controls.Add(Me.StockList)
            Me.Controls.Add(Me.label11)
            Me.Controls.Add(Me.label14)
            Me.Controls.Add(Me.label10)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.bacgrimage)
            Me.Controls.Add(Me.reportdir)
            Me.Controls.Add(Me.EndDateTimePicker)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.isCornersRound)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.StartDateTimePicker)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.pictureBox2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.btnCreateReport)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "StockReport"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Stock Portfolio"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private ImageChDialog As System.Windows.Forms.OpenFileDialog
        Private FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
        Private WithEvents btnCreateReport As System.Windows.Forms.Button
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private pictureBox2 As System.Windows.Forms.PictureBox
        Private label10 As System.Windows.Forms.Label
        Private label1 As System.Windows.Forms.Label
        Private StockList As System.Windows.Forms.ListBox
        Private label4 As System.Windows.Forms.Label
        Private label6 As System.Windows.Forms.Label
        Private StartDateTimePicker As System.Windows.Forms.DateTimePicker
        Private label2 As System.Windows.Forms.Label
        Private isCornersRound As System.Windows.Forms.CheckBox
        Private label3 As System.Windows.Forms.Label
        Private EndDateTimePicker As System.Windows.Forms.DateTimePicker
        Private WithEvents reportdir As System.Windows.Forms.Button
        Private WithEvents bacgrimage As System.Windows.Forms.Button
        Private label8 As System.Windows.Forms.Label
        Private label9 As System.Windows.Forms.Label
        Private label11 As System.Windows.Forms.Label
        Private label7 As System.Windows.Forms.Label
        Private label14 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private label12 As System.Windows.Forms.Label
        Friend WithEvents viewInputTemplate As System.Windows.Forms.Button
    End Class
End Namespace


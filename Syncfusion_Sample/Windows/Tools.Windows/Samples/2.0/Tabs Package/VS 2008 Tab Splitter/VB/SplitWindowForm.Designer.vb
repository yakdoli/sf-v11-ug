Imports Microsoft.VisualBasic
Imports System
Namespace TabSplitterContainer_2005
    Partial Class SplitWindowForm
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplitWindowForm))
            Me.tabSplitterContainer1 = New Syncfusion.Windows.Forms.Tools.TabSplitterContainer()
            Me.DesignPage = New Syncfusion.Windows.Forms.Tools.TabSplitterPage()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.XAMLPage = New Syncfusion.Windows.Forms.Tools.TabSplitterPage()
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.tabSplitterContainer1.SuspendLayout()
            Me.DesignPage.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XAMLPage.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' tabSplitterContainer1
            ' 
            Me.tabSplitterContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabSplitterContainer1.Location = New System.Drawing.Point(0, 0)
            Me.tabSplitterContainer1.Name = "tabSplitterContainer1"
            Me.tabSplitterContainer1.PrimaryPages.AddRange(New Syncfusion.Windows.Forms.Tools.TabSplitterPage() {Me.DesignPage})
            Me.tabSplitterContainer1.SecondaryPages.AddRange(New Syncfusion.Windows.Forms.Tools.TabSplitterPage() {Me.XAMLPage})
            Me.tabSplitterContainer1.Size = New System.Drawing.Size(556, 524)
            Me.tabSplitterContainer1.SplitterPosition = 331
            Me.tabSplitterContainer1.TabIndex = 0
            Me.tabSplitterContainer1.Text = "tabSplitterContainer1"
            ' 
            ' DesignPage
            ' 
            Me.DesignPage.AutoScroll = True
            Me.DesignPage.Controls.Add(Me.pictureBox1)
            Me.DesignPage.Image = (CType(resources.GetObject("DesignPage.Image"), System.Drawing.Image))
            Me.DesignPage.Location = New System.Drawing.Point(0, 0)
            Me.DesignPage.Name = "DesignPage"
            Me.DesignPage.Size = New System.Drawing.Size(556, 331)
            Me.DesignPage.TabIndex = 1
            Me.DesignPage.Text = "Design"
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.BackColor = System.Drawing.Color.White
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(556, 331)
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            ' 
            ' XAMLPage
            ' 
            Me.XAMLPage.AutoScroll = True
            Me.XAMLPage.Controls.Add(Me.richTextBox1)
            Me.XAMLPage.Image = (CType(resources.GetObject("XAMLPage.Image"), System.Drawing.Image))
            Me.XAMLPage.Location = New System.Drawing.Point(0, 351)
            Me.XAMLPage.Name = "XAMLPage"
            Me.XAMLPage.Size = New System.Drawing.Size(556, 173)
            Me.XAMLPage.TabIndex = 2
            Me.XAMLPage.Text = "XAML"
            ' 
            ' richTextBox1
            ' 
            Me.richTextBox1.BackColor = System.Drawing.Color.White
            Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.ReadOnly = True
            Me.richTextBox1.Size = New System.Drawing.Size(556, 173)
            Me.richTextBox1.TabIndex = 0
            Me.richTextBox1.Text = ""
            ' 
            ' SplitWindowForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(556, 524)
            Me.Controls.Add(Me.tabSplitterContainer1)
            Me.Name = "SplitWindowForm"
            Me.ShowIcon = False
            Me.Text = "SplitWindowForm"
            Me.tabSplitterContainer1.ResumeLayout(False)
            Me.DesignPage.ResumeLayout(False)
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XAMLPage.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private tabSplitterContainer1 As Syncfusion.Windows.Forms.Tools.TabSplitterContainer
        Private DesignPage As Syncfusion.Windows.Forms.Tools.TabSplitterPage
        Private XAMLPage As Syncfusion.Windows.Forms.Tools.TabSplitterPage
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private richTextBox1 As System.Windows.Forms.RichTextBox
    End Class
End Namespace
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms

Namespace PrintGrid_2008
    Partial Friend Class Form1
        Inherits MetroForm
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
            Me.components = New System.ComponentModel.Container
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.ScaleColumnsToFit = New System.Windows.Forms.CheckBox
            Me.ShowHeaderFooter = New System.Windows.Forms.CheckBox
            Me.Panel1 = New System.Windows.Forms.Panel
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridControl1.Location = New System.Drawing.Point(12, 12)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(986, 338)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.Text = "gridControl1"
            Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.BorderStyle = BorderStyle.FixedSingle
            Me.gridControl1.UseRightToLeftCompatibleTextBox = True
            '
            'groupBox1
            '
            Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.groupBox1.Controls.Add(Me.button1)
            Me.groupBox1.Controls.Add(Me.ScaleColumnsToFit)
            Me.groupBox1.Controls.Add(Me.ShowHeaderFooter)
            Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(12, 356)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(986, 79)
            Me.groupBox1.TabIndex = 1
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Grid Printing Options"
            '
            'button1
            '
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(136, 31)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(136, 23)
            Me.button1.TabIndex = 2
            Me.button1.Text = "Print Preview"
            Me.button1.UseVisualStyle = True
            Me.button1.UseVisualStyleBackColor = True
            '
            'ScaleColumnsToFit
            '
            Me.ScaleColumnsToFit.AutoSize = True
            Me.ScaleColumnsToFit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ScaleColumnsToFit.Location = New System.Drawing.Point(631, 36)
            Me.ScaleColumnsToFit.Name = "ScaleColumnsToFit"
            Me.ScaleColumnsToFit.Size = New System.Drawing.Size(137, 19)
            Me.ScaleColumnsToFit.TabIndex = 1
            Me.ScaleColumnsToFit.Text = "Scale Columns To Fit"
            Me.ScaleColumnsToFit.UseVisualStyleBackColor = True
            '
            'ShowHeaderFooter
            '
            Me.ShowHeaderFooter.AutoSize = True
            Me.ShowHeaderFooter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ShowHeaderFooter.Location = New System.Drawing.Point(350, 36)
            Me.ShowHeaderFooter.Name = "ShowHeaderFooter"
            Me.ShowHeaderFooter.Size = New System.Drawing.Size(156, 19)
            Me.ShowHeaderFooter.TabIndex = 0
            Me.ShowHeaderFooter.Text = "Show Header and Footer"
            Me.ShowHeaderFooter.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.gridControl1)
            Me.Panel1.Controls.Add(Me.groupBox1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1020, 447)
            Me.Panel1.TabIndex = 2
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
			Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1020, 447)
            Me.Controls.Add(Me.Panel1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Print Grid Demo"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private ScaleColumnsToFit As System.Windows.Forms.CheckBox
        Private ShowHeaderFooter As System.Windows.Forms.CheckBox
        Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
    End Class
End Namespace


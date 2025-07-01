#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Calculate

Public Class ManualCalcForm
    Inherits System.Windows.Forms.Form
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private textBox1 As System.Windows.Forms.TextBox
    Private textBox2 As System.Windows.Forms.TextBox
    Private textBox3 As System.Windows.Forms.TextBox
    Private textBox4 As System.Windows.Forms.TextBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents Button3 As System.Windows.Forms.Button
    
    Private components As System.ComponentModel.Container = Nothing


    Public Sub New()
        '
        ' Required for Windows Form Designer support.
        '
        InitializeComponent()
        Try
            Dim ico As Icon = New Icon(SelectForm.FindFile("Icon", "sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try
    End Sub 'New


    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support; do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.textBox3 = New System.Windows.Forms.TextBox
        Me.textBox4 = New System.Windows.Forms.TextBox
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(32, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(24, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "A"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(32, 72)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(24, 23)
        Me.label2.TabIndex = 1
        Me.label2.Text = "B"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(32, 112)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(24, 23)
        Me.label3.TabIndex = 2
        Me.label3.Text = "C"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(32, 160)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(24, 23)
        Me.label4.TabIndex = 3
        Me.label4.Text = "D"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(80, 32)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(176, 20)
        Me.textBox1.TabIndex = 4
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(80, 72)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(176, 20)
        Me.textBox2.TabIndex = 5
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(80, 120)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(176, 20)
        Me.textBox3.TabIndex = 6
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(80, 160)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(176, 20)
        Me.textBox4.TabIndex = 7
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(272, 24)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(96, 23)
        Me.button1.TabIndex = 8
        Me.button1.Text = "Calculate"
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.Location = New System.Drawing.Point(272, 72)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(96, 23)
        Me.button2.TabIndex = 9
        Me.button2.Text = "Show Formulas"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(272, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Reset Keys"
        '
        'ManualCalcForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 230)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "ManualCalcForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minimal Sample with Manual Calculations Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'InitializeComponent 
#End Region


    Private calculator As CalcQuick = Nothing

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        calculator = New CalcQuick()

        Me.textBox1.Text = "12"
        Me.textBox2.Text = "=[A] + [C]"
        Me.textBox3.Text = "13"
    End Sub 'Form1_Load




    'Calculate:
    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        calculator("A") = Me.textBox1.Text
        calculator("B") = Me.textBox2.Text
        calculator("C") = Me.textBox3.Text
        calculator("D") = Me.textBox4.Text

        calculator.SetDirty()

        Me.textBox1.Text = calculator("A").ToString()
        Me.textBox2.Text = calculator("B").ToString()
        Me.textBox3.Text = calculator("C").ToString()
        Me.textBox4.Text = calculator("D").ToString()
    End Sub 'button1_Click


    'Show formulas:
    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.textBox1.Text = calculator.GetFormula("A")
        Me.textBox2.Text = calculator.GetFormula("B")
        Me.textBox3.Text = calculator.GetFormula("C")
        Me.textBox4.Text = calculator.GetFormula("D")
    End Sub 'button2_Click

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        calculator.ResetKeys()
    End Sub
End Class 'ManualCalcForm
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

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Syncfusion.Calculate


''' <summary>
''' Summary description for AlgebraicExpressions.
''' </summary>
Public Class AlgebraicExpressions : Inherits System.Windows.Forms.Form
    Private label1 As System.Windows.Forms.Label
    Private textBox1 As System.Windows.Forms.TextBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private textBox2 As System.Windows.Forms.TextBox
    Private textBox3 As System.Windows.Forms.TextBox
    Private label4 As System.Windows.Forms.Label
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private label5 As System.Windows.Forms.Label
    Private WithEvents button2 As System.Windows.Forms.Button
    Private textBox4 As System.Windows.Forms.TextBox
    Private label6 As System.Windows.Forms.Label
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
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

        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
    End Sub

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support; do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.button1 = New System.Windows.Forms.Button
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.textBox3 = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.button2 = New System.Windows.Forms.Button
        Me.label5 = New System.Windows.Forms.Label
        Me.textBox4 = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(8, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(168, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Enter an algebraic expression:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(184, 24)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(192, 20)
        Me.textBox1.TabIndex = 1
        Me.textBox1.Text = "sqrt(2) * 2"
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(16, 88)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(360, 23)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Compute"
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(76, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 23)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Computed value:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(184, 56)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(192, 16)
        Me.label3.TabIndex = 4
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(16, 56)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(72, 20)
        Me.textBox2.TabIndex = 5
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(112, 56)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(80, 20)
        Me.textBox3.TabIndex = 6
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(16, 16)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 32)
        Me.label4.TabIndex = 7
        Me.label4.Text = "variable name"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.textBox2)
        Me.groupBox1.Controls.Add(Me.textBox3)
        Me.groupBox1.Location = New System.Drawing.Point(16, 120)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(208, 128)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.Location = New System.Drawing.Point(16, 88)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(176, 23)
        Me.button2.TabIndex = 9
        Me.button2.Text = "Set Variable"
        '
        'label5
        '
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(120, 16)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(72, 32)
        Me.label5.TabIndex = 8
        Me.label5.Text = "variable value"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'textBox4
        '
        Me.textBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.textBox4.Location = New System.Drawing.Point(232, 152)
        Me.textBox4.Multiline = True
        Me.textBox4.Name = "textBox4"
        Me.textBox4.ReadOnly = True
        Me.textBox4.Size = New System.Drawing.Size(144, 120)
        Me.textBox4.TabIndex = 9
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(264, 128)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(80, 23)
        Me.label6.TabIndex = 10
        Me.label6.Text = "Set Variables"
        '
        'AlgebraicExpressions
        '
        Me.AcceptButton = Me.button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 286)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "AlgebraicExpressions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Algebraic Expressions Demo"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Try
            Dim s As String = calculator.ParseAndCompute(Me.textBox1.Text)
            Me.label3.Text = s
        Catch ex As Exception
            'show error
            Me.label3.Text = ex.Message
        End Try
    End Sub

    Private calculator As CalcQuick = Nothing

    Private Sub AlgebraicExpressions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        calculator = New CalcQuick

        Me.calculator("base") = (3).ToString()
        Me.calculator("height") = (2.5).ToString()

        'this.textBox4.ForeColor = Color.Black;
        'this.textBox4.Enabled = false;

    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        'Register a variable name and its value.
        Dim name As String = Me.textBox2.Text
        Dim val As String = Me.textBox3.Text
        If name.Length > 0 Then
            Me.calculator(name) = val
        End If

        Me.textBox4.Text += name & ": " & val & Environment.NewLine
    End Sub
End Class


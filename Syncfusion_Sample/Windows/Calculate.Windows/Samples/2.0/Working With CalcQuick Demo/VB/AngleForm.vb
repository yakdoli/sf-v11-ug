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
Imports Syncfusion.Calculate

 

Public Class AngleForm
   Inherits System.Windows.Forms.Form
   Private Angle As System.Windows.Forms.TextBox
   Private label1 As System.Windows.Forms.Label
   Private label2 As System.Windows.Forms.Label
   Private label3 As System.Windows.Forms.Label
   Private cosTB As System.Windows.Forms.TextBox
   Private sinTB As System.Windows.Forms.TextBox
   Private WithEvents button1 As System.Windows.Forms.Button
   Private label4 As System.Windows.Forms.Label
   
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
        Me.Angle = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.cosTB = New System.Windows.Forms.TextBox
        Me.sinTB = New System.Windows.Forms.TextBox
        Me.button1 = New System.Windows.Forms.Button
        Me.label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Angle
        '
        Me.Angle.Location = New System.Drawing.Point(152, 88)
        Me.Angle.Name = "Angle"
        Me.Angle.Size = New System.Drawing.Size(56, 20)
        Me.Angle.TabIndex = 0
        Me.Angle.Text = "30"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(32, 88)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 23)
        Me.label1.TabIndex = 1
        Me.label1.Text = "angle in degrees"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(32, 168)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 23)
        Me.label2.TabIndex = 2
        Me.label2.Text = "cosine of angle"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(32, 128)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 23)
        Me.label3.TabIndex = 3
        Me.label3.Text = "sine of angle"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cosTB
        '
        Me.cosTB.Location = New System.Drawing.Point(152, 128)
        Me.cosTB.Name = "cosTB"
        Me.cosTB.Size = New System.Drawing.Size(136, 20)
        Me.cosTB.TabIndex = 4
        Me.cosTB.Text = "= sin([Angle] * pi() / 180) "
        '
        'sinTB
        '
        Me.sinTB.Location = New System.Drawing.Point(152, 168)
        Me.sinTB.Name = "sinTB"
        Me.sinTB.Size = New System.Drawing.Size(136, 20)
        Me.sinTB.TabIndex = 5
        Me.sinTB.Text = "= cos([Angle] * pi() / 180) "
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(104, 40)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(112, 23)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Compute"
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(40, 8)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(240, 24)
        Me.label4.TabIndex = 7
        Me.label4.Text = "Enter an angle and press the Compute button."
        '
        'AngleForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 206)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.sinTB)
        Me.Controls.Add(Me.cosTB)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Angle)
        Me.Name = "AngleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Angle Form Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'InitializeComponent 
#End Region

    Private calculator As CalcQuick = Nothing


    Private Sub AngleForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TextBox Angle = new TextBox();
        Me.Angle.Name = "Angle"
        Me.Angle.Text = "30"

        'cosTB = new TextBox();
        Me.cosTB.Name = "cosTB"
        Me.cosTB.Text = "= cos([Angle] * pi() / 180) "

        'sinTB = new TextBox();
        Me.sinTB.Name = "sinTB"
        Me.sinTB.Text = "= sin([Angle] * pi() / 180) "

        'Instantiate the CalcQuick object:
        Me.calculator = New CalcQuick()
    End Sub 'AngleForm_Load


    'Perform a manual calculation:
    Private Sub ComputeButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        'Let the calculator know the values / formulas 
        'by using an indexer on the calculator object.
        'Here we are using the text box names as the indexer keys
        'provided to the calculator object. This is not required.
        'The only restrictions for the indexer key values are that they 
        'unique nonempty strings.
        Me.calculator("Angle") = Me.Angle.Text
        Me.calculator("cosTB") = Me.cosTB.Text
        Me.calculator("sinTB") = Me.sinTB.Text

        'Mark the calculator dirty:
        Me.calculator.SetDirty()

        'Now as the values are retrieved from the calculator, they
        'will be the newly calculated values.
        Me.cosTB.Text = Me.calculator("cosTB")
        Me.sinTB.Text = Me.calculator("sinTB")
    End Sub 'ComputeButton_Click
End Class 'AngleForm
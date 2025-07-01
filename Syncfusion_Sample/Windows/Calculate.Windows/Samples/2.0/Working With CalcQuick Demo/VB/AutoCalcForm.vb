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

 
Public Class AutoCalcForm
   Inherits System.Windows.Forms.Form
   Private textBoxD As System.Windows.Forms.TextBox
   Private textBoxC As System.Windows.Forms.TextBox
   Private textBoxB As System.Windows.Forms.TextBox
   Private textBoxA As System.Windows.Forms.TextBox
   Private label4 As System.Windows.Forms.Label
   Private label3 As System.Windows.Forms.Label
   Private label2 As System.Windows.Forms.Label
   Private label1 As System.Windows.Forms.Label
   Private labelA As System.Windows.Forms.Label
   Private labelB As System.Windows.Forms.Label
   Private labelC As System.Windows.Forms.Label
   Private labelD As System.Windows.Forms.Label
    
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
        Me.textBoxD = New System.Windows.Forms.TextBox
        Me.textBoxC = New System.Windows.Forms.TextBox
        Me.textBoxB = New System.Windows.Forms.TextBox
        Me.textBoxA = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.labelA = New System.Windows.Forms.Label
        Me.labelB = New System.Windows.Forms.Label
        Me.labelC = New System.Windows.Forms.Label
        Me.labelD = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'textBoxD
        '
        Me.textBoxD.Location = New System.Drawing.Point(80, 152)
        Me.textBoxD.Name = "textBoxD"
        Me.textBoxD.Size = New System.Drawing.Size(176, 20)
        Me.textBoxD.TabIndex = 15
        '
        'textBoxC
        '
        Me.textBoxC.Location = New System.Drawing.Point(80, 112)
        Me.textBoxC.Name = "textBoxC"
        Me.textBoxC.Size = New System.Drawing.Size(176, 20)
        Me.textBoxC.TabIndex = 14
        '
        'textBoxB
        '
        Me.textBoxB.Location = New System.Drawing.Point(80, 72)
        Me.textBoxB.Name = "textBoxB"
        Me.textBoxB.Size = New System.Drawing.Size(176, 20)
        Me.textBoxB.TabIndex = 13
        '
        'textBoxA
        '
        Me.textBoxA.Location = New System.Drawing.Point(80, 32)
        Me.textBoxA.Name = "textBoxA"
        Me.textBoxA.Size = New System.Drawing.Size(176, 20)
        Me.textBoxA.TabIndex = 12
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(32, 152)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(24, 23)
        Me.label4.TabIndex = 11
        Me.label4.Text = "D"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(32, 112)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(24, 23)
        Me.label3.TabIndex = 10
        Me.label3.Text = "C"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(32, 72)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(24, 23)
        Me.label2.TabIndex = 9
        Me.label2.Text = "B"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(32, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(24, 23)
        Me.label1.TabIndex = 8
        Me.label1.Text = "A"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelA
        '
        Me.labelA.Location = New System.Drawing.Point(272, 32)
        Me.labelA.Name = "labelA"
        Me.labelA.Size = New System.Drawing.Size(160, 23)
        Me.labelA.TabIndex = 16
        '
        'labelB
        '
        Me.labelB.Location = New System.Drawing.Point(272, 72)
        Me.labelB.Name = "labelB"
        Me.labelB.Size = New System.Drawing.Size(160, 23)
        Me.labelB.TabIndex = 17
        '
        'labelC
        '
        Me.labelC.Location = New System.Drawing.Point(272, 112)
        Me.labelC.Name = "labelC"
        Me.labelC.Size = New System.Drawing.Size(160, 23)
        Me.labelC.TabIndex = 18
        '
        'labelD
        '
        Me.labelD.Location = New System.Drawing.Point(272, 152)
        Me.labelD.Name = "labelD"
        Me.labelD.Size = New System.Drawing.Size(160, 23)
        Me.labelD.TabIndex = 19
        '
        'AutoCalcForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(448, 222)
        Me.Controls.Add(Me.labelD)
        Me.Controls.Add(Me.labelC)
        Me.Controls.Add(Me.labelB)
        Me.Controls.Add(Me.labelA)
        Me.Controls.Add(Me.textBoxD)
        Me.Controls.Add(Me.textBoxC)
        Me.Controls.Add(Me.textBoxB)
        Me.Controls.Add(Me.textBoxA)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "AutoCalcForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Calculation Form Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'InitializeComponent 
#End Region

    Private calculator As CalcQuick = Nothing

    Private Sub AutoCalcForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '1) Instantiate a CalcQuick object:
        calculator = New CalcQuick()

        '2) Populate your controls:
        Me.textBoxA.Text = "12"
        Me.textBoxB.Text = "=[A] + [C]"
        Me.textBoxC.Text = "13"

        'B is the only formula:
        Me.labelB.Text = Me.textBoxB.Text


        'Must enter formula names before turning on calculations.
        '3) Assign formula object names:
        calculator("A") = Me.textBoxA.Text
        calculator("B") = Me.textBoxB.Text
        calculator("C") = Me.textBoxC.Text
        calculator("D") = Me.textBoxD.Text

        '4) Turn on auto calculations:
        Me.calculator.AutoCalc = True

        '5) Subscribe to the event to set newly calculated values:
        AddHandler Me.calculator.ValueSet, AddressOf calculator_ValueSet

        '6) Subscribe to some events (in this case, Leave events) to trigger setting values into CalcQuick:
        AddHandler Me.textBoxA.Leave, AddressOf textBoxA_Leave
        AddHandler Me.textBoxB.Leave, AddressOf textBoxB_Leave
        AddHandler Me.textBoxC.Leave, AddressOf textBoxC_Leave
        AddHandler Me.textBoxD.Leave, AddressOf textBoxD_Leave

        '7) Allow the CalcQuick sheet to create dependency lists among the formula objects
        '   necesary for auto-calculations.
        Me.calculator.RefreshAllCalculations()
    End Sub 'AutoCalcForm_Load


    ' Raised when a value is calculated:
    Private Sub calculator_ValueSet(ByVal sender As Object, ByVal e As QuickValueSetEventArgs)

        'Console.WriteLine(e.Key + " " + e.Value);
        Select Case e.Key
            Case "A"
                Me.textBoxA.Text = Me.calculator(e.Key).ToString()
            Case "B"
                Me.textBoxB.Text = Me.calculator(e.Key).ToString()
            Case "C"
                Me.textBoxC.Text = Me.calculator(e.Key).ToString()
            Case "D"
                Me.textBoxD.Text = Me.calculator(e.Key).ToString()
            Case Else
        End Select
    End Sub 'calculator_ValueCalculated


    Private Sub textBoxA_Leave(ByVal sender As Object, ByVal e As EventArgs)
        If Me.textBoxA.Modified Then
            calculator("A") = Me.textBoxA.Text
            Me.labelA.Text = Me.calculator.GetFormula("A")
        End If
        Me.textBoxA.Modified = False
    End Sub 'textBoxA_Leave

    Private Sub textBoxB_Leave(ByVal sender As Object, ByVal e As EventArgs)
        If Me.textBoxB.Modified Then
            calculator("B") = Me.textBoxB.Text
            Me.labelB.Text = Me.calculator.GetFormula("B")
        End If
        Me.textBoxB.Modified = False
    End Sub 'textBoxB_Leave

    Private Sub textBoxC_Leave(ByVal sender As Object, ByVal e As EventArgs)
        If Me.textBoxC.Modified Then
            calculator("C") = Me.textBoxC.Text
            Me.labelC.Text = Me.calculator.GetFormula("C")
        End If
        Me.textBoxC.Modified = False
    End Sub 'textBoxC_Leave

    Private Sub textBoxD_Leave(ByVal sender As Object, ByVal e As EventArgs)
        If Me.textBoxD.Modified Then
            calculator("D") = Me.textBoxD.Text
            Me.labelD.Text = Me.calculator.GetFormula("D")
        End If
        Me.textBoxD.Modified = False
    End Sub 'textBoxD_Leave
End Class 'AutoCalcForm
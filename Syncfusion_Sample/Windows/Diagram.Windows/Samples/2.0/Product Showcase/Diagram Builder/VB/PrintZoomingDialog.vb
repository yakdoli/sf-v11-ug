#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Re-distribution in any form is strictly
'  prohibited. Any infringement will be prosecuted under applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace DiagramTool
    ''' <summary>
    ''' Diagram used by the Diagram printing system for setting the PrintZoom values.
    ''' </summary>
    Public Class PrintZoomingDialog : Inherits System.Windows.Forms.Form
        Public WithEvents radio1 As System.Windows.Forms.RadioButton
        Public comboBox1 As System.Windows.Forms.ComboBox
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private btnOK As System.Windows.Forms.Button
        Private btnCancel As System.Windows.Forms.Button
        Public radio2 As System.Windows.Forms.RadioButton
        Private WithEvents txtAcross As System.Windows.Forms.TextBox
        Private WithEvents txtDown As System.Windows.Forms.TextBox
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
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
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.radio1 = New System.Windows.Forms.RadioButton()
            Me.radio2 = New System.Windows.Forms.RadioButton()
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.txtDown = New System.Windows.Forms.TextBox()
            Me.txtAcross = New System.Windows.Forms.TextBox()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' radio1
            ' 
            Me.radio1.Location = New System.Drawing.Point(16, 24)
            Me.radio1.Name = "radio1"
            Me.radio1.Size = New System.Drawing.Size(72, 16)
            Me.radio1.TabIndex = 0
            Me.radio1.Text = "Adjust to "
            '			Me.radio1.CheckedChanged += New System.EventHandler(Me.radio1_CheckedChanged);
            ' 
            ' radio2
            ' 
            Me.radio2.Location = New System.Drawing.Point(16, 56)
            Me.radio2.Name = "radio2"
            Me.radio2.Size = New System.Drawing.Size(56, 16)
            Me.radio2.TabIndex = 1
            Me.radio2.Text = "Fit to"
            ' 
            ' comboBox1
            ' 
            Me.comboBox1.Items.AddRange(New Object() {"25%", "50%", "100%", "200%", "400%"})
            Me.comboBox1.Location = New System.Drawing.Point(104, 24)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(64, 21)
            Me.comboBox1.TabIndex = 2
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.txtDown)
            Me.groupBox1.Controls.Add(Me.txtAcross)
            Me.groupBox1.Controls.Add(Me.radio1)
            Me.groupBox1.Controls.Add(Me.comboBox1)
            Me.groupBox1.Controls.Add(Me.radio2)
            Me.groupBox1.Location = New System.Drawing.Point(8, 8)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(256, 112)
            Me.groupBox1.TabIndex = 3
            Me.groupBox1.TabStop = False
            ' 
            ' label4
            ' 
            Me.label4.Location = New System.Drawing.Point(160, 80)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(88, 16)
            Me.label4.TabIndex = 8
            Me.label4.Text = "sheet(s) down"
            ' 
            ' label3
            ' 
            Me.label3.Location = New System.Drawing.Point(80, 80)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(16, 16)
            Me.label3.TabIndex = 7
            Me.label3.Text = "by"
            ' 
            ' label2
            ' 
            Me.label2.Location = New System.Drawing.Point(160, 56)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(88, 16)
            Me.label2.TabIndex = 6
            Me.label2.Text = "sheet(s) across"
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(80, 56)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(16, 16)
            Me.label1.TabIndex = 5
            Me.label1.Text = "to"
            ' 
            ' txtDown
            ' 
            Me.txtDown.Location = New System.Drawing.Point(104, 80)
            Me.txtDown.Name = "txtDown"
            Me.txtDown.Size = New System.Drawing.Size(48, 20)
            Me.txtDown.TabIndex = 4
            Me.txtDown.Text = "1"
            '			Me.txtDown.KeyPress += New System.Windows.Forms.KeyPressEventHandler(Me.txtDown_KeyPress);
            '			Me.txtDown.KeyUp += New System.Windows.Forms.KeyEventHandler(Me.txtDown_KeyUp);
            ' 
            ' txtAcross
            ' 
            Me.txtAcross.Location = New System.Drawing.Point(104, 56)
            Me.txtAcross.Name = "txtAcross"
            Me.txtAcross.Size = New System.Drawing.Size(48, 20)
            Me.txtAcross.TabIndex = 3
            Me.txtAcross.Text = "1"
            '			Me.txtAcross.KeyPress += New System.Windows.Forms.KeyPressEventHandler(Me.txtDown_KeyPress);
            '			Me.txtAcross.KeyUp += New System.Windows.Forms.KeyEventHandler(Me.txtDown_KeyUp);
            ' 
            ' btnOK
            ' 
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New System.Drawing.Point(96, 128)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(76, 24)
            Me.btnOK.TabIndex = 4
            Me.btnOK.Text = "OK"
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(184, 128)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(76, 24)
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "Cancel"
            ' 
            ' PrintZoomingDialog
            ' 
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(274, 159)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.groupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "PrintZoomingDialog"
            Me.Text = "Print Zooming"
            '			Me.Load += New System.EventHandler(Me.PrintZoomingDialog_Load);
            Me.groupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

        Private Sub txtDown_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDown.KeyPress, txtAcross.KeyPress
            ' proceed if user input is number or backspace
            If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = Chr(8) Then
                If (CType(sender, TextBox)).Text.Length > 2 Then
                    e.Handled = True
                    Return
                End If
                e.Handled = False
                Return
            End If

            e.Handled = True

        End Sub

        Private Sub txtDown_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDown.KeyUp, txtAcross.KeyUp
            Dim ii As Integer = Integer.Parse((CType(sender, TextBox)).Text)
            If ii > 50 Then
                CType(sender, TextBox).Text = "50"
            End If
        End Sub

        Private Sub radio1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radio1.CheckedChanged
            If (CType(sender, RadioButton)).Checked = True Then
                Me.txtAcross.Enabled = False
                Me.txtDown.Enabled = False
                Me.comboBox1.Enabled = True
            Else
                Me.comboBox1.Enabled = False
                Me.txtAcross.Enabled = True
                Me.txtDown.Enabled = True
            End If

        End Sub

        Private Sub PrintZoomingDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Me.radio1.Checked = False Then
                Me.radio1_CheckedChanged(Me.radio1, New EventArgs())
            End If
        End Sub

#Region "Public Properties"

        Public Property SheetsDown() As String
            Get
                Return Me.txtDown.Text
            End Get
            Set(ByVal value As String)
                Me.txtDown.Text = Value
            End Set
        End Property


        Public Property SheetsAcross() As String
            Get
                Return Me.txtAcross.Text
            End Get
            Set(ByVal value As String)
                Me.txtAcross.Text = Value
            End Set
        End Property

#End Region
    End Class
End Namespace

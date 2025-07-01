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

Imports DemoCommon
Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace CalculatorControlDemo
    Public Class CalculatorAboutForm
        Inherits AboutForm
        Private components As IContainer
        'Fields
        'Constructors
        'Events
        'Methods
        Public Sub New()
            MyBase.New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ' TODO: Add any initialization after the InitializeComponent call

        End Sub
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

            If disposing Then
                If (Not (components) Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)

        End Sub
        Private Shadows Sub InitializeComponent()

            Me.SuspendLayout()
            ' 
            ' button1
            ' 
            Me.button1.Visible = True
            ' 
            ' label1
            ' 
            Me.label1.Text = "Syncfusion Essential Tools - Calculator control sample"
            Me.label1.Visible = True
            ' 
            ' label2
            ' 
            Me.label2.Visible = True
            ' 
            ' linkLabel1
            ' 
            Me.linkLabel1.Visible = True
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.Visible = True
            ' 
            ' CalculatorAboutForm
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(442, 192)
            Me.Name = "CalculatorAboutForm"
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace

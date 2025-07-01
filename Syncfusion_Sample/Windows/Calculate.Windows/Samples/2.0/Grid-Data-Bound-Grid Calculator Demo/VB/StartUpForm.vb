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


Namespace GridDataBoundGridCalculator
    
   
   Public Class StartUpForm
      Inherits System.Windows.Forms.Form
      Private WithEvents button1 As System.Windows.Forms.Button
      Private WithEvents button2 As System.Windows.Forms.Button
       
      Private components As System.ComponentModel.Container = Nothing
      
      
      Public Sub New()
         '
         ' Required for Windows Form Designer support.
         '
            InitializeComponent()
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "sfgrid.ico"))
            Me.Icon = ico

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
            Me.button1 = New System.Windows.Forms.Button
            Me.button2 = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'button1
            '
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.Location = New System.Drawing.Point(40, 24)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(184, 40)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Single GridDataBoundGrid with Calculation support"
            '
            'button2
            '
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button2.Location = New System.Drawing.Point(40, 80)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(184, 40)
            Me.button2.TabIndex = 1
            Me.button2.Text = "Workbook of GridDataBoundGrids with Calculation support"
            '
            'StartUpForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(264, 150)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Name = "StartUpForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Start Up Form"
            Me.ResumeLayout(False)

        End Sub 'InitializeComponent 
#End Region

        <STAThread()> _
    Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
            Application.Run(New StartUpForm())
        End Sub 'Main


        'used in automated tests
        Dim forms(1) As Form
        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            Dim f As New SingleGridDataBoundGridForm()
            forms(0) = f
            f.Show()
        End Sub 'button1_Click


        Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
            Dim f As New GridDataBoundGridWorkBookForm()
            forms(1) = f
            f.Show()
        End Sub 'button2_Click

        Private Sub StartUpForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Environment.CommandLine.EndsWith("automatedtest") Then
                Me.button1.PerformClick()
                Me.button2.PerformClick()
                Dim sz As Size = SystemInformation.PrimaryMonitorSize
                Me.forms(0).Location = New Point(0, 0)
                Me.forms(0).Size = New Size(sz.Width / 2, sz.Height)
                Me.forms(1).Location = New Point(sz.Width / 2 + 1, 0)
                Me.forms(1).Size = New Size(sz.Width / 2, sz.Height)
                Me.WindowState = FormWindowState.Minimized
            End If
        End Sub
    End Class 'StartUpForm
End Namespace 'GridDataBoundGridCalculator
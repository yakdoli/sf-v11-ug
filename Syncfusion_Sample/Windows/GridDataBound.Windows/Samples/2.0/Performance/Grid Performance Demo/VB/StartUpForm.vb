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


Namespace GridPerf
    '/ <summary>
    '/ Summary description for StartUpForm.
    '/ </summary>
    
    Public Class StartUpForm
        Inherits System.Windows.Forms.Form
        Private WithEvents GGCbutton As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents GDBGbutton As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents DGbutton As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
        Private panel1 As System.Windows.Forms.Panel
        '/ <summary>
        '/ Required designer variable.
        '/ </summary>
        Private components As System.ComponentModel.Container = Nothing
        
        
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Try
                Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch ex As Exception

            End Try
            Me.BackColor = Color.FromArgb(223, 227, 239)
            Me.StartPosition = FormStartPosition.CenterScreen
        End Sub 'New
         
		 	Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        
        '/ <summary>
        '/ Clean up any resources being used.
        '/ </summary>
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
        '/ Required method for Designer support - do not modify
        '/ the contents of this method with the code editor.
        '/ </summary>
        Private Sub InitializeComponent()
            Me.GDBGbutton = New Syncfusion.Windows.Forms.ButtonAdv
            Me.DGbutton = New Syncfusion.Windows.Forms.ButtonAdv
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.panel1 = New System.Windows.Forms.Panel
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GDBGbutton
            '
            Me.GDBGbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.GDBGbutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.GDBGbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GDBGbutton.Location = New System.Drawing.Point(79, 31)
            Me.GDBGbutton.Name = "GDBGbutton"
            Me.GDBGbutton.Size = New System.Drawing.Size(144, 40)
            Me.GDBGbutton.TabIndex = 0
            Me.GDBGbutton.Text = "GridDataBoundGrid"
            Me.GDBGbutton.UseVisualStyle = True
            '
            'DGbutton
            '
            Me.DGbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.DGbutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.DGbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGbutton.Location = New System.Drawing.Point(79, 127)
            Me.DGbutton.Name = "DGbutton"
            Me.DGbutton.Size = New System.Drawing.Size(144, 40)
            Me.DGbutton.TabIndex = 1
            Me.DGbutton.Text = "DataGrid"
            Me.DGbutton.UseVisualStyle = True
            '
            'button1
            '
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.Location = New System.Drawing.Point(79, 79)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(144, 40)
            Me.button1.TabIndex = 3
            Me.button1.Text = "Virtual GridControl"
            Me.button1.UseVisualStyle = True
            '
            'panel1
            '
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.panel1.Controls.Add(Me.DGbutton)
            Me.panel1.Controls.Add(Me.button1)
            Me.panel1.Controls.Add(Me.GDBGbutton)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(304, 198)
            Me.panel1.TabIndex = 4
            '
            'StartUpForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(304, 198)
            Me.Controls.Add(Me.panel1)
            Me.Name = "StartUpForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Grid Performance Demo"
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub 'InitializeComponent 
#End Region


        '/ <summary>
        '/ The main entry point for the application.
        '/ </summary>
        <STAThread()> _
        Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
            Application.Run(New StartUpForm())
        End Sub 'Main


        Private Sub GGCbutton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GGCbutton.Click
        End Sub 'GGCbutton_Click

        'GroupingPerf.GridGroupingControlForm f = new GroupingPerf.GridGroupingControlForm();
        'f.Show();

        Private Sub GDBGbutton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GDBGbutton.Click
            Dim f As New GridDataBoundGridPerf.GridDataBoundGridForm()
            f.Show()
        End Sub 'GDBGbutton_Click


        Private Sub DGbutton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGbutton.Click
            Dim f As New DataGridPerf.DataGridForm()
            f.Show()
        End Sub 'DGbutton_Click


        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            Dim f As New VirtualGridControlPerf.VirtualGridControlForm()
            f.Show()
        End Sub 'button1_Click
    End Class 'StartUpForm
End Namespace 'GridPerf
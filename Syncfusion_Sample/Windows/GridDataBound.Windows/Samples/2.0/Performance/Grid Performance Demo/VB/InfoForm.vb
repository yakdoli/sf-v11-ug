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
    '/ Summary description for InfoForm.
    '/ </summary>
    
    Public Class InfoForm
        Inherits System.Windows.Forms.Form
        Public TextLabel As System.Windows.Forms.Label
        '/ <summary>
        '/ Required designer variable.
        '/ </summary>
        Private components As System.ComponentModel.Container = Nothing
        
        
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Me.BackColor = Color.FromArgb(223, 227, 239)
            Me.StartPosition = FormStartPosition.CenterParent
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
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
            Me.TextLabel = New System.Windows.Forms.Label
            Me.SuspendLayout()
            '
            'TextLabel
            '
            Me.TextLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TextLabel.BackColor = System.Drawing.SystemColors.Window
            Me.TextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.TextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextLabel.Location = New System.Drawing.Point(9, 7)
            Me.TextLabel.Name = "TextLabel"
            Me.TextLabel.Size = New System.Drawing.Size(640, 136)
            Me.TextLabel.TabIndex = 0
            Me.TextLabel.Text = "label1"
            Me.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'InfoForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(656, 150)
            Me.Controls.Add(Me.TextLabel)
            Me.Name = "InfoForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Info Form"
            Me.ResumeLayout(False)

        End Sub 'InitializeComponent 
#End Region
    End Class 'InfoForm
End Namespace 'GridPerf
#Region "Copyright Syncfusion Inc. 2001 - 2011"
' Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace GDBGFieldChooserDemo
    Partial Friend Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
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
            Me.GridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
            CType(Me.GridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.GridDataBoundGrid1.BackColor = System.Drawing.SystemColors.Window
            Me.GridDataBoundGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridDataBoundGrid1.Location = New System.Drawing.Point(0, 0)
            Me.GridDataBoundGrid1.Name = "GridDataBoundGrid1"
            Me.GridDataBoundGrid1.Size = New System.Drawing.Size(659, 439)
            Me.GridDataBoundGrid1.TabIndex = 0
            Me.GridDataBoundGrid1.Text = "GridDataBoundGrid1"
            ' Me.gridGroupingControl1.VersionInfo = "6.303.0.30"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(659, 439)
            Me.Controls.Add(Me.GridDataBoundGrid1)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "GDBG FieldChooser Demo"
            CType(Me.GridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private GridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
    End Class
End Namespace


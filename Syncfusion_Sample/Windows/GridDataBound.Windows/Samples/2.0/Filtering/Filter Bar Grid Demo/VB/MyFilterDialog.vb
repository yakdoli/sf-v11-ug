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
Imports Syncfusion.Windows.Forms.Grid

Public Class MyFilterDialog
    Inherits System.Windows.Forms.Form
    Public textBox1 As System.Windows.Forms.TextBox
    Private WithEvents OkButton As System.Windows.Forms.Button
    Private WithEvents cancelButton1 As System.Windows.Forms.Button
    Private WithEvents showDefaultButton As System.Windows.Forms.Button
    
    Private components As System.ComponentModel.Container = Nothing

    Public grid As GridDataBoundGrid = Nothing
    Public table As DataTable = Nothing


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
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
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.OkButton = New System.Windows.Forms.Button
        Me.cancelButton1 = New System.Windows.Forms.Button
        Me.showDefaultButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox1.Location = New System.Drawing.Point(24, 24)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(296, 136)
        Me.textBox1.TabIndex = 0
        '
        'OkButton
        '
        Me.OkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkButton.Location = New System.Drawing.Point(336, 40)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(96, 23)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "OK"
        '
        'cancelButton1
        '
        Me.cancelButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelButton1.Location = New System.Drawing.Point(336, 72)
        Me.cancelButton1.Name = "cancelButton1"
        Me.cancelButton1.Size = New System.Drawing.Size(96, 23)
        Me.cancelButton1.TabIndex = 2
        Me.cancelButton1.Text = "Cancel"
        '
        'showDefaultButton
        '
        Me.showDefaultButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showDefaultButton.Location = New System.Drawing.Point(336, 104)
        Me.showDefaultButton.Name = "showDefaultButton"
        Me.showDefaultButton.Size = New System.Drawing.Size(96, 23)
        Me.showDefaultButton.TabIndex = 3
        Me.showDefaultButton.Text = "Default Dialog"
        '
        'MyFilterDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 174)
        Me.Controls.Add(Me.showDefaultButton)
        Me.Controls.Add(Me.cancelButton1)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "MyFilterDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Filter Dialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'InitializeComponent 
#End Region


    Private Sub OkButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OkButton.Click
        'need to test the filter string for validity some how
        'we added a methos that just tries the filter string...
        If Not Me.IsFilterStringValid(Me.textBox1.Text) Then
            Return
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub 'OkButton_Click


    Private Sub cancelButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cancelButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub 'cancelButton1_Click


    Private Sub showDefaultButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles showDefaultButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Ignore
        Me.Close()
    End Sub 'showDefaultButton_Click


    Protected Function IsFilterStringValid(ByVal filterString As String) As Boolean
        Dim filter As String = ""
        Try
            Me.grid.BeginUpdate()
            filter = Me.table.DefaultView.RowFilter
            Me.table.DefaultView.RowFilter = filterString
        Catch ex As Exception
            Me.table.DefaultView.RowFilter = filter
            Me.grid.CancelUpdate()
            MessageBox.Show(("Improper filter: " + ex.Message))
            Return False
        End Try

        Me.table.DefaultView.RowFilter = filter
        Me.grid.CancelUpdate()
        Return True
    End Function 'IsFilterStringValid
End Class 'MyFilterDialog
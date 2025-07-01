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

Public Class StartUpForm
    Inherits System.Windows.Forms.Form
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button

    Private components As System.ComponentModel.Container = Nothing


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


#Region "FindFile Utility"
    ''' <summary>
    ''' Finds a file of the given name in the current directory or sibling "Data" directory.
    ''' If file is not found, the parent folder is checked until the file is found. This method
    ''' is used by our samples when they load data from a separate "Data" folder.
    ''' </summary>
    ''' <param name="dataDirName">The name of the "Data" folder.</param>
    ''' <param name="fileName">The filename to be searched.</param>
    ''' <returns>The full path of the file that was found; an empty string is returned if file is not found.</returns>

    Public Shared Function FindFile(ByVal dataDirName As String, ByVal fileName As String) As String
        dataDirName = dataDirName.TrimEnd("\"c, "/"c)
        ' Check both in parent folder and Parent\Data folders.
        Dim dataFileName As String = dataDirName & "\" & fileName
        Dim n As Integer
        For n = 0 To 9
            If System.IO.File.Exists(fileName) Then
                Return fileName
            End If
            If System.IO.File.Exists(dataFileName) Then
                Return dataFileName
            End If
            fileName = "..\" + fileName
            dataFileName = "..\" + dataFileName
        Next n
        Return ""
    End Function
#End Region

    Public Sub New()
        '
        ' Required for Windows Form Designer support.
        '
        InitializeComponent()
        Try
            Dim ico As Icon = New Icon(FindFile("Icon", "sfgrid.ico"))
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
        Me.button1 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(32, 32)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(184, 48)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Single DataGrid with Calculation support"
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.Location = New System.Drawing.Point(32, 112)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(184, 48)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Workbook of DataGrids with Calculation support"
        '
        'StartUpForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(248, 198)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Name = "StartUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start Up Form"
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region

    Dim forms(1) As Form
    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim f As New SingleDataGridForm()
        f.Show()
        forms(0) = f
    End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        Dim f As New DataGridWorkBookForm()
        f.Show()
        forms(1) = f
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
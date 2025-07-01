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

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


''' <summary>
''' Summary description for SelectForm.
''' </summary>
Public Class SelectForm : Inherits System.Windows.Forms.Form
    Private WithEvents manualButton As System.Windows.Forms.Button
    Private WithEvents autoButton As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents angleFormButton As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing

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
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
    End Sub

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
            fileName = "..\" & fileName
            dataFileName = "..\" & dataFileName
        Next n

        Return ""
    End Function
#End Region

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
    ''' Required method for Designer support; do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.manualButton = New System.Windows.Forms.Button
        Me.autoButton = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        Me.angleFormButton = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'manualButton
        '
        Me.manualButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.manualButton.Location = New System.Drawing.Point(48, 24)
        Me.manualButton.Name = "manualButton"
        Me.manualButton.Size = New System.Drawing.Size(184, 23)
        Me.manualButton.TabIndex = 0
        Me.manualButton.Text = "Manual Calculations"
        '
        'autoButton
        '
        Me.autoButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.autoButton.Location = New System.Drawing.Point(48, 64)
        Me.autoButton.Name = "autoButton"
        Me.autoButton.Size = New System.Drawing.Size(184, 23)
        Me.autoButton.TabIndex = 1
        Me.autoButton.Text = "Auto Calculations"
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(48, 104)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(184, 23)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Controls as Keys"
        '
        'angleFormButton
        '
        Me.angleFormButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.angleFormButton.Location = New System.Drawing.Point(48, 144)
        Me.angleFormButton.Name = "angleFormButton"
        Me.angleFormButton.Size = New System.Drawing.Size(184, 23)
        Me.angleFormButton.TabIndex = 3
        Me.angleFormButton.Text = "Angle Calculations"
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.Location = New System.Drawing.Point(48, 184)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(184, 23)
        Me.button2.TabIndex = 4
        Me.button2.Text = "Auto Angle Calculations"
        '
        'button3
        '
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button3.Location = New System.Drawing.Point(48, 224)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(184, 23)
        Me.button3.TabIndex = 5
        Me.button3.Text = "Algebraic Expressions"
        '
        'SelectForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(272, 270)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.angleFormButton)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.autoButton)
        Me.Controls.Add(Me.manualButton)
        Me.Name = "SelectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Form Demo"
        Me.ResumeLayout(False)

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New SelectForm())
    End Sub

    'used in automated testing
    Private forms As Form() = New Form(5) {}
    Private Sub manualButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles manualButton.Click
        Dim f As ManualCalcForm = New ManualCalcForm()
        forms(0) = f
        f.Show()
    End Sub

    Private Sub autoButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles autoButton.Click
        Dim f As AutoCalcForm = New AutoCalcForm()
        forms(1) = f
        f.Show()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim f As MoreComplexForm = New MoreComplexForm()
        forms(2) = f
        f.Show()
    End Sub

    Private Sub angleFormButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles angleFormButton.Click
        Dim f As AngleForm = New AngleForm()
        forms(3) = f
        f.Show()
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        Dim f As AutoAngleForm = New AutoAngleForm()
        forms(4) = f
        f.Show()
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
        Dim f As AlgebraicExpressions = New AlgebraicExpressions()
        forms(5) = f
        f.Show()
    End Sub

    Private Sub SelectForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Environment.CommandLine.EndsWith("automatedtest") Then
            Me.manualButton.PerformClick()
            Me.autoButton.PerformClick()
            Me.button1.PerformClick()
            Me.angleFormButton.PerformClick()
            Me.button2.PerformClick()
            Me.button3.PerformClick()
            Dim sz As Size = SystemInformation.PrimaryMonitorSize

            Me.forms(0).Location = New Point(0, 0)
            Me.forms(0).Size = New Size(sz.Width / 3, sz.Height / 2)
            Me.forms(1).Location = New Point(sz.Width / 3 + 1, 0)
            Me.forms(1).Size = New Size(sz.Width / 3, sz.Height / 2)
            Me.forms(2).Location = New Point(2 * sz.Width / 3 + 1, 0)
            Me.forms(2).Size = New Size(sz.Width / 3, sz.Height / 2)
            Me.forms(3).Location = New Point(0, sz.Height / 2 + 1)
            Me.forms(3).Size = New Size(sz.Width / 3, sz.Height / 2)
            Me.forms(4).Location = New Point(sz.Width / 3 + 1, sz.Height / 2 + 1)
            Me.forms(4).Size = New Size(sz.Width / 3, sz.Height / 2)
            Me.forms(5).Location = New Point(2 * sz.Width / 3 + 1, sz.Height / 2 + 1)
            Me.forms(5).Size = New Size(sz.Width / 3, sz.Height / 2)
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

End Class


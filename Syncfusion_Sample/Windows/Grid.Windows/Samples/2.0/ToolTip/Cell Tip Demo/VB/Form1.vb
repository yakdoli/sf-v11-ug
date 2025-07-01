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
Imports Syncfusion.Windows.Forms

'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits MetroForm
    Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private panel1 As System.Windows.Forms.Panel

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        Me.gridControl1.ThemesEnabled = True

        Me.gridControl1(2, 3).CellTipText = "TipText for cell 2,3"
        Me.gridControl1(2, 3).BackColor = Color.FromArgb(218, 229, 245) 'Color.FromArgb( 237, 240, 246 );//Color.FromArgb( 192, 201, 219 );//Color.Aquamarine;
        Me.gridControl1(2, 5).CellTipText = "TipText for cell 2,5"
        Me.gridControl1(2, 5).BackColor = Color.FromArgb(218, 229, 245) 'Color.FromArgb( 237, 240, 246 );//Color.FromArgb( 192, 201, 219 );//Color.Aquamarine;
        Me.gridControl1.ColStyles(4).CellTipText = "TipText for column 4"
        Me.gridControl1.ColStyles(4).BackColor = Color.FromArgb(237, 240, 246) '//Color.Bisque;
        Me.gridControl1.RowStyles(5).CellTipText = "TipText for row 5"
        Me.gridControl1.RowStyles(5).BackColor = Color.FromArgb(&HB4, &HE7, &HF2) 'Color.FromArgb( 102, 110, 152 );//;//Color.LightBlue;
        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch ex As Exception
        End Try
        Me.gridControl1.DefaultRowHeight = 18
        Me.gridControl1.DefaultColWidth = 70
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(208, 215, 229)
        Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
        Dim style As GridStyleInfo = Me.gridControl1.BaseStylesMap("Header").StyleInfo
        style.TextColor = System.Drawing.Color.MidnightBlue
        style.Font.Facename = "Verdana"
        style = Me.gridControl1.BaseStylesMap("Standard").StyleInfo
        style.TextColor = System.Drawing.Color.MidnightBlue
        style.Font.Facename = "Verdana"
        Me.BackColor = Color.FromArgb(223, 227, 239)
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
        Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
        Me.panel1 = New System.Windows.Forms.Panel()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' gridControl1
        ' 
        Me.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridControl1.Location = New System.Drawing.Point(16, 24)
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.Size = New System.Drawing.Size(528, 224)
        Me.gridControl1.SmartSizeBox = False
        Me.gridControl1.TabIndex = 0
        Me.gridControl1.Text = "gridControl1"
        ' 
        ' panel1
        ' 
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(560, 270)
        Me.panel1.TabIndex = 1
        ' 
        ' Form1
        ' 
        Me.DropShadow = True
        Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.BorderThickness = 2
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.MinimizeBox = False
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen

        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 270)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.gridControl1, Me.panel1})
        Me.Name = "Form1"
        Me.Text = "Grid With Cell Tip Demo"
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
        Application.EnableVisualStyles()
#End If
        Application.Run(New Form1())
    End Sub 'Main
End Class 'Form1
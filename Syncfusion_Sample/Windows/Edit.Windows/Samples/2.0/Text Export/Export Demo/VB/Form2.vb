#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
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

Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Enums
Imports Syncfusion.Windows.Forms.Edit.Interfaces


'/ <summary>
'/ Summary description for Form2.
'/ </summary>

Public Class Form2
    Inherits System.Windows.Forms.Form
    Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
    End Sub 'New
     
    '
    ' TODO: Add any constructor code after InitializeComponent call
    '
    
    Public Sub SetText([text] As String)
        Me.editControl1.Text = [text]
    End Sub 'SetText
    
    
    Public Sub ApplyConfiguration(lang As KnownLanguages)
        Me.editControl1.ApplyConfiguration(lang)
    End Sub 'ApplyConfiguration

    Public Sub MoveToBeginning()
        Me.editControl1.MoveToBeginning()
    End Sub 'ApplyConfiguration

    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'editControl1
        '
        Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.editControl1.MarkLineWrapping = False
        Me.editControl1.MarkWrappedLines = False
        Me.editControl1.Name = "editControl1"
        Me.editControl1.ParsingMode = Syncfusion.Windows.Forms.Edit.Enums.TextParsingMode.PartialParsingNoFallback
        Me.editControl1.SaveOnClose = False
        Me.editControl1.ShowColumnGuides = False
        Me.editControl1.ShowHorizontalSplitters = False
        Me.editControl1.ShowIndentationGuidelines = False
        Me.editControl1.ShowIndicatorMargin = False
        Me.editControl1.ShowLineNumbers = False
        Me.editControl1.ShowOutliningCollapsers = False
        Me.editControl1.ShowSelectionMargin = False
        Me.editControl1.ShowVerticalSplitters = False
        Me.editControl1.Size = New System.Drawing.Size(542, 466)
        Me.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
        Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
        Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.editControl1.TabIndex = 0
        Me.editControl1.Text = ""
        Me.editControl1.TransferFocusOnTab = True
        Me.editControl1.WordWrap = True
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(542, 466)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.editControl1})
        Me.Name = "Form2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Form2"
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region
End Class 'Form2
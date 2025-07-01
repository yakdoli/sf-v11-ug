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
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Dialogs
Imports Syncfusion.Windows.Forms.Edit.Implementation.Config
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Implementation.IO
Imports Syncfusion.Windows.Forms.Edit.Implementation.Formatting
Imports Syncfusion.Windows.Forms.Edit.Implementation.Parser
Imports Syncfusion.IO

Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports Syncfusion.Windows.Forms.Edit.Implementation
Imports Syncfusion.Windows.Forms.Edit.Enums


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private menuItem1 As System.Windows.Forms.MenuItem
    Private menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem7 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
    Private WithEvents editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem11 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem12 As System.Windows.Forms.MenuItem
    Private menuItem13 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem14 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem15 As System.Windows.Forms.MenuItem
    Private menuItem16 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem17 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem18 As System.Windows.Forms.MenuItem
    Private menuItem19 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem20 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem21 As System.Windows.Forms.MenuItem
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private WithEvents menuItem22 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem23 As System.Windows.Forms.MenuItem
    
    Private BasePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\"
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        Me.editControl1.ShowOutliningCollapsers = True
        Me.editControl1.LoadFile((BasePath + "\VBSource.vb"))
    End Sub 'New


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
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu()
        Me.menuItem13 = New System.Windows.Forms.MenuItem()
        Me.menuItem14 = New System.Windows.Forms.MenuItem()
        Me.menuItem15 = New System.Windows.Forms.MenuItem()
        Me.menuItem16 = New System.Windows.Forms.MenuItem()
        Me.menuItem17 = New System.Windows.Forms.MenuItem()
        Me.menuItem18 = New System.Windows.Forms.MenuItem()
        Me.menuItem19 = New System.Windows.Forms.MenuItem()
        Me.menuItem20 = New System.Windows.Forms.MenuItem()
        Me.menuItem21 = New System.Windows.Forms.MenuItem()
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuItem11 = New System.Windows.Forms.MenuItem()
        Me.menuItem12 = New System.Windows.Forms.MenuItem()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.menuItem5 = New System.Windows.Forms.MenuItem()
        Me.menuItem6 = New System.Windows.Forms.MenuItem()
        Me.menuItem7 = New System.Windows.Forms.MenuItem()
        Me.menuItem22 = New System.Windows.Forms.MenuItem()
        Me.menuItem8 = New System.Windows.Forms.MenuItem()
        Me.menuItem9 = New System.Windows.Forms.MenuItem()
        Me.menuItem10 = New System.Windows.Forms.MenuItem()
        Me.menuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem13, Me.menuItem1, Me.menuItem2})
        '
        'menuItem13
        '
        Me.menuItem13.Index = 0
        Me.menuItem13.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem14, Me.menuItem15, Me.menuItem16, Me.menuItem17, Me.menuItem18, Me.menuItem19, Me.menuItem20, Me.menuItem21})
        Me.menuItem13.Text = "File"
        '
        'menuItem14
        '
        Me.menuItem14.Index = 0
        Me.menuItem14.Text = "New"
        '
        'menuItem15
        '
        Me.menuItem15.Index = 1
        Me.menuItem15.Text = "Open"
        '
        'menuItem16
        '
        Me.menuItem16.Index = 2
        Me.menuItem16.Text = "-"
        '
        'menuItem17
        '
        Me.menuItem17.Index = 3
        Me.menuItem17.Text = "Save"
        '
        'menuItem18
        '
        Me.menuItem18.Index = 4
        Me.menuItem18.Text = "SaveAs"
        '
        'menuItem19
        '
        Me.menuItem19.Index = 5
        Me.menuItem19.Text = "-"
        '
        'menuItem20
        '
        Me.menuItem20.Index = 6
        Me.menuItem20.Text = "Close"
        '
        'menuItem21
        '
        Me.menuItem21.Index = 7
        Me.menuItem21.Text = "Exit"
        '
        'menuItem1
        '
        Me.menuItem1.Index = 1
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem11, Me.menuItem12})
        Me.menuItem1.Text = "Configuration Menu"
        '
        'menuItem11
        '
        Me.menuItem11.Index = 0
        Me.menuItem11.Text = "Launch Configuration Editor"
        '
        'menuItem12
        '
        Me.menuItem12.Index = 1
        Me.menuItem12.Text = "Launch Configuration Display Utility"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 2
        Me.menuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem22, Me.menuItem8, Me.menuItem9, Me.menuItem10, Me.menuItem23, Me.MenuItem24, Me.MenuItem25})
        Me.menuItem2.Text = "Code Samples"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 0
        Me.menuItem3.Text = "CSharp"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 1
        Me.menuItem4.Text = "HTML"
        '
        'menuItem5
        '
        Me.menuItem5.Index = 2
        Me.menuItem5.Text = "XML"
        '
        'menuItem6
        '
        Me.menuItem6.Index = 3
        Me.menuItem6.Text = "Pascal"
        '
        'menuItem7
        '
        Me.menuItem7.Index = 4
        Me.menuItem7.Text = "HTML with embedded JScript"
        '
        'menuItem22
        '
        Me.menuItem22.Index = 5
        Me.menuItem22.Text = "HTML with embedded VBScript"
        '
        'menuItem8
        '
        Me.menuItem8.Index = 6
        Me.menuItem8.Text = "Delphi"
        '
        'menuItem9
        '
        Me.menuItem9.Index = 7
        Me.menuItem9.Text = "VB.NET"
        '
        'menuItem10
        '
        Me.menuItem10.Index = 8
        Me.menuItem10.Text = "SQL"
        '
        'menuItem23
        '
        Me.menuItem23.Index = 9
        Me.menuItem23.Text = "Java"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 10
        Me.MenuItem24.Text = "VBScript"
        '
        'editControl1
        '
        Me.editControl1.BackColor = System.Drawing.SystemColors.Window
        Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.editControl1.ChangedLinesMarkingLineColor = System.Drawing.Color.Yellow
        Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editControl1.Name = "editControl1"
        Me.editControl1.ShowHorizontalSplitters = False
        Me.editControl1.ShowIndicatorMargin = False
        Me.editControl1.ShowOutliningCollapsers = False
        Me.editControl1.ShowVerticalSplitters = False
        Me.editControl1.Size = New System.Drawing.Size(542, 445)
        Me.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
        Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
        Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.editControl1.TabIndex = 0
        Me.editControl1.Text = ""
        Me.editControl1.TransferFocusOnTab = True
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 11
        Me.MenuItem25.Text = "JScript"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(542, 445)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.editControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Syntax Coloring"
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub 'Main


    Private Sub CodeSamplesMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click, menuItem4.Click, menuItem5.Click, menuItem6.Click, menuItem7.Click, menuItem8.Click, menuItem9.Click, menuItem10.Click, menuItem22.Click, menuItem23.Click, MenuItem24.Click, MenuItem25.Click
        Dim mi As MenuItem = sender

        Select Case mi.Text
            Case "CSharp"
                Me.editControl1.LoadFile((BasePath + "\CSharpSource.cs"))
            Case "HTML"
                Me.editControl1.LoadFile((BasePath + "\HTMLSource.html"))
            Case "XML"
                Me.editControl1.LoadFile((BasePath + "\XMLSource.xml"))
            Case "Pascal"
                Me.editControl1.LoadFile((BasePath + "\PascalSource.pas"))
            Case "HTML with embedded JScript"
                Me.editControl1.LoadFile((BasePath + "\HTML_JScript.html"))
            Case "Delphi"
                Me.editControl1.LoadFile((BasePath + "\DelphiSource.pas"))
            Case "VB.NET"
                Me.editControl1.LoadFile((BasePath + "\VBSource.vb"))
            Case "SQL"
                Me.editControl1.LoadFile((BasePath + "\SQLSource.sql"))
            Case "HTML with embedded VBScript"
                Me.editControl1.LoadFile((BasePath + "\HTML_VBScript.html"))
            Case "Java"
                Me.editControl1.LoadFile((BasePath + "\JavaSource.Java"))
            Case "VBScript"
                Me.editControl1.LoadFile((BasePath + "\VBScriptSource.vbs"))
                Me.editControl1.ApplyConfiguration(KnownLanguages.VBScript)
            Case "JScript"
                Me.editControl1.LoadFile((BasePath + "\JScriptSource.js"))
                Me.editControl1.ApplyConfiguration(KnownLanguages.JScript)
        End Select
    End Sub 'CodeSamplesMenuClick



    Private Sub ConfigurationMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem11.Click, menuItem12.Click
        Dim mi As MenuItem = sender

        Select Case mi.Text
            Case "Launch Configuration Editor"
                Try
                    Dim activeLang As IConfigLanguage = Me.editControl1.Parser.Formats

                    Dim editConfig As New ConfigurationDialog(Me.editControl1.Configurator, activeLang)

                    If editConfig.ShowDialog(Me) = DialogResult.OK AndAlso Not (activeLang Is Nothing) Then
                        Dim newLang As IConfigLanguage = IIf(editConfig.Configurator.KnownLanguageNames.Contains(activeLang.Language), editConfig.Configurator(activeLang.Language), editConfig.Configurator.DefaultLanguage) 'TODO: For performance reasons this should be changed to nested IF statements

                        If Not (newLang Is Nothing) Then
                            Me.editControl1.Configurator = editConfig.Configurator
                            Me.editControl1.ApplyConfiguration(newLang)
                        End If
                    End If
                Catch ex As ArgumentException
                    Debug.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace)
                    Throw
                End Try

            Case "Launch Configuration Display Utility"
                Dim configForm As New Form2()
                configForm.ShowDialog()
        End Select
    End Sub 'ConfigurationMenuClick


    Private Sub FileMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem14.Click, menuItem15.Click, menuItem17.Click, menuItem18.Click, menuItem20.Click, menuItem21.Click
        Dim mi As MenuItem = sender

        Select Case mi.Text
            Case "New"
                Me.editControl1.NewFile()
            Case "Open"
                Me.editControl1.LoadFile()
            Case "Save"
                Me.editControl1.Save()
            Case "SaveAs"
                Me.editControl1.SaveAs()
            Case "Close"
                Me.editControl1.Close()
            Case "Exit"
                Me.Close()
        End Select
    End Sub 'FileMenuClick


    Private Sub editControl1_MenuFill(ByVal sender As Object, ByVal e As System.EventArgs) Handles editControl1.MenuFill
        Dim contextMenu As ContextMenuManager = CType(sender, ContextMenuManager)

        ' Add a separator
        contextMenu.AddSeparator()

        ' Add custom custom context menu items and their Click eventhandlers
        contextMenu.AddMenuItem("Launch Configuration Editor", New EventHandler(AddressOf ConfigurationEditorLaunch))
        contextMenu.AddMenuItem("Launch Configuration Display Utility", New EventHandler(AddressOf ConfigurationDisplayLaunch))
    End Sub 'editControl1_MenuFill


    Private Sub ConfigurationEditorLaunch(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim activeLang As IConfigLanguage = Me.editControl1.Parser.Formats

            Dim editConfig As New ConfigurationDialog(Me.editControl1.Configurator, activeLang)

            If editConfig.ShowDialog(Me) = DialogResult.OK AndAlso Not (activeLang Is Nothing) Then
                Dim newLang As IConfigLanguage = IIf(editConfig.Configurator.KnownLanguageNames.Contains(activeLang.Language), editConfig.Configurator(activeLang.Language), editConfig.Configurator.DefaultLanguage) 'TODO: For performance reasons this should be changed to nested IF statements

                If Not (newLang Is Nothing) Then
                    Me.editControl1.Configurator = editConfig.Configurator
                    Me.editControl1.ApplyConfiguration(newLang)
                End If
            End If
        Catch ex As ArgumentException
            Debug.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace)
            Throw
        End Try
    End Sub 'ConfigurationEditorLaunch


    Private Sub ConfigurationDisplayLaunch(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim configForm As New Form2()
        configForm.ShowDialog()
    End Sub 'ConfigurationDisplayLaunch



End Class 'Form1
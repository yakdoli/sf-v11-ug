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

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Drawing

#Region "Class Form1 Description"

''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1 : Inherits System.Windows.Forms.Form

#Region "Varialble Declaration"

    Private treeViewAdv1 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing

#End Region

#Region "Form Constructor Initialization And Disposing"


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()


        ' This code shows how to get and modify a Base Style from the BaseStyle's hash.
        ' Synthesize a TextColor for these styles based on their BackColor:
        Dim panthers As TreeNodeAdvStyleInfo = CType(IIf(TypeOf Me.treeViewAdv1.BaseStyles("Panthers") Is TreeNodeAdvStyleInfo, Me.treeViewAdv1.BaseStyles("Panthers"), Nothing), TreeNodeAdvStyleInfo)
        panthers.TextColor = Me.GetGoodForeColor(panthers.Background.BackColor)

        Dim packers As TreeNodeAdvStyleInfo = CType(IIf(TypeOf Me.treeViewAdv1.BaseStyles("Packers") Is TreeNodeAdvStyleInfo, Me.treeViewAdv1.BaseStyles("Packers"), Nothing), TreeNodeAdvStyleInfo)
        packers.TextColor = Me.GetGoodForeColor(packers.Background.BackColor)

        Dim redSkins As TreeNodeAdvStyleInfo = CType(IIf(TypeOf Me.treeViewAdv1.BaseStyles("Redskins") Is TreeNodeAdvStyleInfo, Me.treeViewAdv1.BaseStyles("Redskins"), Nothing), TreeNodeAdvStyleInfo)
        redSkins.TextColor = Me.GetGoodForeColor(redSkins.Background.BackColor)

        Dim chiefs As TreeNodeAdvStyleInfo = CType(IIf(TypeOf Me.treeViewAdv1.BaseStyles("Chiefs") Is TreeNodeAdvStyleInfo, Me.treeViewAdv1.BaseStyles("Chiefs"), Nothing), TreeNodeAdvStyleInfo)
        chiefs.TextColor = Me.GetGoodForeColor(chiefs.Background.BackColor)

        Dim vikings As TreeNodeAdvStyleInfo = CType(IIf(TypeOf Me.treeViewAdv1.BaseStyles("Vikings") Is TreeNodeAdvStyleInfo, Me.treeViewAdv1.BaseStyles("Vikings"), Nothing), TreeNodeAdvStyleInfo)
        vikings.TextColor = Me.GetGoodForeColor(vikings.Background.BackColor)

    End Sub


#Region "Get the Good Forecolor based on the Back Color"
    Private Function GetGoodForeColor(ByVal backColor As Color) As Color
        Dim goodTextColor As Color = SystemColors.ControlText
        DrawingUtils.AdjustForeColorBrightnessForBackColor(goodTextColor, backColor, 0.75F)
        Return goodTextColor
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
#End Region

#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim TreeNodeAdvStyleInfo1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
        Dim TreeNodeAdvStyleInfo2 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
        Dim TreeNodeAdvStyleInfo3 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
        Dim TreeNodeAdvStyleInfo4 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
        Dim TreeNodeAdvStyleInfo5 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
        Dim TreeNodeAdvStyleInfo6 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
        Dim TreeNodeAdvStyleInfo7 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
        Dim TreeNodeAdv1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv2 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv3 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv4 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv5 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv6 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv7 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv8 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv9 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv10 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv11 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv12 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv13 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv14 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv15 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv16 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv17 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv18 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv19 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
        CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'treeViewAdv1
        '
        Me.treeViewAdv1.ActiveNode = Nothing
        Me.treeViewAdv1.AllowDrop = True
        Me.treeViewAdv1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(196, Byte), CType(214, Byte), CType(233, Byte)))
        TreeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = True
        TreeNodeAdvStyleInfo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNodeAdvStyleInfo2.Background = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(51, Byte)))
        TreeNodeAdvStyleInfo2.EnsureDefaultOptionedChild = True
        TreeNodeAdvStyleInfo2.TextColor = System.Drawing.Color.White
        TreeNodeAdvStyleInfo3.Background = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(238, Byte), CType(122, Byte), CType(3, Byte)))
        TreeNodeAdvStyleInfo3.EnsureDefaultOptionedChild = True
        TreeNodeAdvStyleInfo4.Background = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(225, Byte), CType(150, Byte), CType(1, Byte)))
        TreeNodeAdvStyleInfo4.EnsureDefaultOptionedChild = True
        TreeNodeAdvStyleInfo5.Background = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(102, Byte), CType(110, Byte), CType(152, Byte)))
        TreeNodeAdvStyleInfo5.EnsureDefaultOptionedChild = True
        TreeNodeAdvStyleInfo6.Background = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(218, Byte), CType(229, Byte), CType(245, Byte)))
        TreeNodeAdvStyleInfo6.EnsureDefaultOptionedChild = True
        TreeNodeAdvStyleInfo7.Background = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(133, Byte), CType(191, Byte), CType(117, Byte)))
        TreeNodeAdvStyleInfo7.EnsureDefaultOptionedChild = True
        Me.treeViewAdv1.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.StyleNamePair() {New Syncfusion.Windows.Forms.Tools.StyleNamePair("NodeLevel3", TreeNodeAdvStyleInfo1), New Syncfusion.Windows.Forms.Tools.StyleNamePair("Redskins", TreeNodeAdvStyleInfo2), New Syncfusion.Windows.Forms.Tools.StyleNamePair("Panthers", TreeNodeAdvStyleInfo3), New Syncfusion.Windows.Forms.Tools.StyleNamePair("Chiefs", TreeNodeAdvStyleInfo4), New Syncfusion.Windows.Forms.Tools.StyleNamePair("Vikings", TreeNodeAdvStyleInfo5), New Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", TreeNodeAdvStyleInfo6), New Syncfusion.Windows.Forms.Tools.StyleNamePair("Packers", TreeNodeAdvStyleInfo7)})
        Me.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'treeViewAdv1.HelpTextControl
        '
        Me.treeViewAdv1.HelpTextControl.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
        Me.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.treeViewAdv1.HelpTextControl.Location = New System.Drawing.Point(732, 0)
        Me.treeViewAdv1.HelpTextControl.Name = "helpText"
        Me.treeViewAdv1.HelpTextControl.Size = New System.Drawing.Size(50, 17)
        Me.treeViewAdv1.HelpTextControl.TabIndex = 0
        Me.treeViewAdv1.HelpTextControl.Text = "help text"
        Me.treeViewAdv1.Name = "treeViewAdv1"
        TreeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv1.ChildStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNodeAdv1.ChildStyle.TextColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        TreeNodeAdv1.EnsureDefaultOptionedChild = True
        TreeNodeAdv1.Expanded = True
        TreeNodeAdv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv2.ChildStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNodeAdv2.EnsureDefaultOptionedChild = True
        TreeNodeAdv2.Expanded = True
        TreeNodeAdv3.BaseStyle = "Panthers"
        TreeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv3.EnsureDefaultOptionedChild = True
        TreeNodeAdv3.Optioned = True
        TreeNodeAdv3.ShowPlusOnExpand = False
        TreeNodeAdv3.Text = "Jake Dellhomme"
        TreeNodeAdv4.BaseStyle = "Packers"
        TreeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv4.EnsureDefaultOptionedChild = True
        TreeNodeAdv4.ShowPlusOnExpand = False
        TreeNodeAdv4.Text = "Brett Favre"
        TreeNodeAdv5.BaseStyle = "Redskins"
        TreeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv5.EnsureDefaultOptionedChild = True
        TreeNodeAdv5.ShowPlusOnExpand = False
        TreeNodeAdv5.Text = "Patrick Ramsey"
        TreeNodeAdv6.BaseStyle = "Chiefs"
        TreeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv6.EnsureDefaultOptionedChild = True
        TreeNodeAdv6.ShowPlusOnExpand = False
        TreeNodeAdv6.Text = "Trent Green"
        TreeNodeAdv7.BaseStyle = "Vikings"
        TreeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv7.EnsureDefaultOptionedChild = True
        TreeNodeAdv7.ShowPlusOnExpand = False
        TreeNodeAdv7.Text = "Daunte Culpepper"
        TreeNodeAdv2.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv3, TreeNodeAdv4, TreeNodeAdv5, TreeNodeAdv6, TreeNodeAdv7})
        TreeNodeAdv2.Optioned = True
        TreeNodeAdv2.ShowPlusOnExpand = False
        TreeNodeAdv2.Text = "Quarterbacks"
        TreeNodeAdv2.TextColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(21, Byte), CType(84, Byte))
        TreeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv8.EnsureDefaultOptionedChild = True
        TreeNodeAdv8.Expanded = True
        TreeNodeAdv9.BaseStyle = "Panthers"
        TreeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv9.EnsureDefaultOptionedChild = True
        TreeNodeAdv9.Optioned = True
        TreeNodeAdv9.ShowPlusOnExpand = False
        TreeNodeAdv9.Text = "Stephen Davis"
        TreeNodeAdv10.BaseStyle = "Packers"
        TreeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv10.EnsureDefaultOptionedChild = True
        TreeNodeAdv10.ShowPlusOnExpand = False
        TreeNodeAdv10.Text = "Ahman Green"
        TreeNodeAdv11.BaseStyle = "Chiefs"
        TreeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv11.EnsureDefaultOptionedChild = True
        TreeNodeAdv11.ShowPlusOnExpand = False
        TreeNodeAdv11.Text = "Priest Holmes"
        TreeNodeAdv12.BaseStyle = "Redskins"
        TreeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv12.EnsureDefaultOptionedChild = True
        TreeNodeAdv12.ShowPlusOnExpand = False
        TreeNodeAdv12.Text = "Trung Canidate"
        TreeNodeAdv13.BaseStyle = "Vikings"
        TreeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv13.EnsureDefaultOptionedChild = True
        TreeNodeAdv13.ShowPlusOnExpand = False
        TreeNodeAdv13.Text = "Mo Lewis"
        TreeNodeAdv8.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv9, TreeNodeAdv10, TreeNodeAdv11, TreeNodeAdv12, TreeNodeAdv13})
        TreeNodeAdv8.ShowPlusOnExpand = False
        TreeNodeAdv8.Text = "Runningbacks"
        TreeNodeAdv8.TextColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(21, Byte), CType(84, Byte))
        TreeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv14.EnsureDefaultOptionedChild = True
        TreeNodeAdv14.Expanded = True
        TreeNodeAdv15.BaseStyle = "Panthers"
        TreeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv15.EnsureDefaultOptionedChild = True
        TreeNodeAdv15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNodeAdv15.Optioned = True
        TreeNodeAdv15.ShowPlusOnExpand = False
        TreeNodeAdv15.Text = "Steve Smith"
        TreeNodeAdv16.BaseStyle = "Vikings"
        TreeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv16.EnsureDefaultOptionedChild = True
        TreeNodeAdv16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNodeAdv16.ShowPlusOnExpand = False
        TreeNodeAdv16.Text = "Randy Moss"
        TreeNodeAdv17.BaseStyle = "Chiefs"
        TreeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv17.EnsureDefaultOptionedChild = True
        TreeNodeAdv17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNodeAdv17.ShowPlusOnExpand = False
        TreeNodeAdv17.Text = "Dante Hall"
        TreeNodeAdv18.BaseStyle = "Redskins"
        TreeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv18.EnsureDefaultOptionedChild = True
        TreeNodeAdv18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNodeAdv18.ShowPlusOnExpand = False
        TreeNodeAdv18.Text = "Rod Gardner"
        TreeNodeAdv19.BaseStyle = "Packers"
        TreeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv19.EnsureDefaultOptionedChild = True
        TreeNodeAdv19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNodeAdv19.ShowPlusOnExpand = False
        TreeNodeAdv19.Text = "Antonio Freeman"
        TreeNodeAdv14.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv15, TreeNodeAdv16, TreeNodeAdv17, TreeNodeAdv18, TreeNodeAdv19})
        TreeNodeAdv14.ShowPlusOnExpand = False
        TreeNodeAdv14.Text = "Receivers"
        TreeNodeAdv14.TextColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(21, Byte), CType(84, Byte))
        TreeNodeAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv2, TreeNodeAdv8, TreeNodeAdv14})
        TreeNodeAdv1.ShowPlusOnExpand = False
        TreeNodeAdv1.Text = "NFL Top 5 2003 MVPs"
        TreeNodeAdv1.TextColor = System.Drawing.Color.Magenta
        Me.treeViewAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv1})
        Me.treeViewAdv1.PathSeparator = "/"
        Me.treeViewAdv1.Size = New System.Drawing.Size(264, 326)
        Me.treeViewAdv1.TabIndex = 0
        Me.treeViewAdv1.Text = "treeViewAdv1"
        '
        'treeViewAdv1.ToolTipControl
        '
        Me.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
        Me.treeViewAdv1.ToolTipControl.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
        Me.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.treeViewAdv1.ToolTipControl.Location = New System.Drawing.Point(642, 0)
        Me.treeViewAdv1.ToolTipControl.Name = "toolTip"
        Me.treeViewAdv1.ToolTipControl.Size = New System.Drawing.Size(41, 17)
        Me.treeViewAdv1.ToolTipControl.TabIndex = 1
        Me.treeViewAdv1.ToolTipControl.Text = "toolTip"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(264, 326)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.treeViewAdv1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TreeViewAdv Styles"
        CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

#Region "Main Function Definition"
    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub
#End Region

End Class
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace TabSplitterContainer_2005
    Partial Public Class Main : Inherits Office2007Form
		Private window1 As SplitWindowForm = Nothing, window2 As SplitWindowForm = Nothing

		Public Sub New()
			InitializeComponent()

			window1 = New SplitWindowForm("Window1.xaml", "Code1.rtf")
			window1.MdiParent = Me
			window1.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Designer1.png"))
			window1.Show()

			window2 = New SplitWindowForm("Window2.xaml", "Code2.rtf")
			window2.MdiParent = Me
			window2.DesignWindow = Image.FromFile(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Resources", "Designer2.png"))
            window2.Show()
        End Sub

        Public ReadOnly Property ActiveWindow() As SplitWindowForm
            Get
                If Not Me.ActiveMdiChild Is Nothing Then
                    Return CType(Me.ActiveMdiChild, SplitWindowForm)
                Else
                    Return Nothing
                End If
            End Get
        End Property

        Private Sub Main_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            '
            'tabbedMDIManager1
            '
            Me.tabbedMDIManager1 = New Syncfusion.Windows.Forms.Tools.TabbedMDIManager(Me.components)
            Me.tabbedMDIManager1.AttachedTo = Me
            Me.tabbedMDIManager1.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabbedMDIManager1.NeedUpdateHostedForm = False
            Me.tabbedMDIManager1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererVS2008)
            Me.tabbedMDIManager1.UseIconsInTabs = False
            'Initial Settings
            Me.ActivateMdiChild(window1)
        End Sub

        Private Sub tabbedMDIManager1_TabControlAdded(ByVal sender As Object, ByVal args As TabbedMDITabControlEventArgs)
            If Not args.TabControl Is Nothing Then
                args.TabControl.BorderVisible = True
            End If
        End Sub
    End Class
End Namespace
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports System.IO
Imports Syncfusion.Windows.Forms.Tools.Navigation

Namespace NavigationViewDemo_2005
    Partial Public Class Form1
        Inherits Office2007Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.listView1.Items.Clear()
            Me.listView1.BringToFront()
            Dim drives As DriveInfo() = DriveInfo.GetDrives()

            For Each driveInfo__1 As DriveInfo In drives
                If driveInfo__1.DriveType <> DriveType.Fixed Then
                    Continue For
                End If
                Dim node As New Bar()
                node.Tag = driveInfo__1
                node.Text = "Local Disk " & driveInfo__1.Name.Replace("\", "")
                node.ImageIndex = 8
                navigationView1.SelectedBar.Bars.Add(node)
                Me.listView1.Items.Add(node.Text, 8)
            Next

            Me.VisStyleCmbBox.SelectedIndex = 0
            Me.navigationView1.HistoryManager = New Syncfusion.Windows.Forms.Tools.Navigation.HistoryManager()
            Me.navigationView1.HistoryEnabled = True
            Me.navigationView1.Refresh()
        End Sub

        Private Sub HistorycheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.HisbtnChkBox.Enabled = HistorycheckBox.Checked
            Me.navigationView1.HistoryEnabled = HistorycheckBox.Checked

            Me.navigationView1.ShowHistoryButtons = HistorycheckBox.Checked
            Me.HisbtnChkBox.Checked = HistorycheckBox.Checked
        End Sub

        Private Sub HisbtnChkBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.navigationView1.ShowHistoryButtons = HisbtnChkBox.Checked
        End Sub

        Private Sub CutmBtnChkBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.navigationView1.CustomButtons(0).Visible = Me.CutmBtnChkBox.Checked
        End Sub

        Private Sub BarImgChkBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.BarImgChkBox.Checked Then
                Me.navigationView1.ImageList = Me.imageList1
            Else
                Me.navigationView1.ImageList = Nothing
            End If
        End Sub

        Private Sub RTLChkBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.RTLChkBox.Checked Then
                Me.navigationView1.RightToLeft = RightToLeft.Yes
            Else
                Me.navigationView1.RightToLeft = RightToLeft.No
            End If
        End Sub

        Private Sub VisStyleCmbBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.VisStyleCmbBox.SelectedIndex = 0 Then
                Me.navigationView1.VisualStyle = Syncfusion.Windows.Forms.Tools.Navigation.VisualStyles.Vista
            Else
                Me.navigationView1.VisualStyle = Syncfusion.Windows.Forms.Tools.Navigation.VisualStyles.Office2007
                Me.navigationView1.Office2007ColorTheme = Office2007Theme.Blue
                Me.customButton1.Office2007ColorScheme = Office2007Theme.Blue
            End If
        End Sub

        Private Sub navigationView1_BarSelectionChanging(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.Navigation.BarSelectionChangingEventArgs)
            Me.listView1.Items.Clear()
            Dim needToAdd As Boolean = True
            Dim parent As Syncfusion.Windows.Forms.Tools.Navigation.Bar = e.Bar
            If parent Is Nothing Then
                Exit Sub
            End If
            If parent.Bars.Count > 0 Then
                needToAdd = False
            End If
            Dim dirInfo As DirectoryInfo = Nothing
            If TypeOf parent.Tag Is DriveInfo Then
                Dim driveInfo As DriveInfo = DirectCast(parent.Tag, DriveInfo)
                dirInfo = driveInfo.RootDirectory

            ElseIf TypeOf parent.Tag Is DirectoryInfo Then
                dirInfo = DirectCast(parent.Tag, DirectoryInfo)
            End If
            If dirInfo IsNot Nothing Then
                Try
                    Dim subDirectories As DirectoryInfo() = dirInfo.GetDirectories()
                    Dim files As FileInfo() = dirInfo.GetFiles()
                    For Each directoryInfo As DirectoryInfo In subDirectories
                        Dim node As New Syncfusion.Windows.Forms.Tools.Navigation.Bar()
                        node.Tag = directoryInfo
                        node.Text = directoryInfo.Name
                        node.ImageIndex = 8
                        If needToAdd Then
                            parent.Bars.Add(node)
                        End If
                        Me.listView1.Items.Add(node.Text, 8)
                    Next
                    For Each file As FileInfo In files
                        Me.listView1.Items.Add(file.Name, 5)
                    Next
                Catch ex As Exception
                    MessageBoxAdv.Show(Me, ex.Message, "Info")
                End Try
            ElseIf parent.Text = "MyComputer" Then
                Me.listView1.Items.Add("Local Disk(C:)", 8)
            End If
        End Sub
    End Class
End Namespace

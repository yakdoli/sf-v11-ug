#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.GridHelperClasses
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports System.Collections.Specialized

Namespace FormatCellDialog_2005
    Partial Public Class Form1
        Inherits MetroForm
        Public Sub New()
            InitializeComponent()
            Me.gridGroupingControl1.DataSource = CreateTable()
            Me.gridGroupingControl1.Table.Records(0).SetCurrent()
            Me.gridGroupingControl1.TableModel.Options.AllowSelection = GridSelectionFlags.Cell Or GridSelectionFlags.AlphaBlend
            Me.gridGroupingControl1.TableModel.Options.SelectCellsMouseButtonsMask = MouseButtons.Left
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
            Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch
            End Try
            Dim ToolTip1 As New System.Windows.Forms.ToolTip()
            ToolTip1.SetToolTip(Me.comboBoxAdv2, "WrapGrid option is only for Left,Right,Up,Down,PageUp,PageDown")

            'String collections...

            Dim ar As New StringCollection()
            ar.Add("None")
            ar.Add("Left")
            ar.Add("Right")
            ar.Add("Up")
            ar.Add("Down")
            ar.Add("Top")
            ar.Add("Bottom")
            ar.Add("MostLeft")
            ar.Add("MostRight")
            ar.Add("TopLeft")
            ar.Add("BottomRight")
            ar.Add("PageUp")
            ar.Add("PageDown")
            comboBoxAdv1.DataSource = ar

            Dim ad As New StringCollection()
            ad.Add("None")
            ad.Add("WrapGrid")
            comboBoxAdv2.DataSource = ad
            AddHandler comboBoxAdv1.SelectedIndexChanged, AddressOf comboBoxAdv1_SelectedIndexChanged
            AddHandler comboBoxAdv2.SelectedIndexChanged, AddressOf comboBoxAdv2_SelectedIndexChanged
        End Sub

        Private Sub comboBoxAdv2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If comboBoxAdv2.SelectedIndex = 1 Then
                If comboBoxAdv1.SelectedIndex = 1 OrElse comboBoxAdv1.SelectedIndex = 2 OrElse comboBoxAdv1.SelectedIndex = 3 OrElse comboBoxAdv1.SelectedIndex = 4 OrElse comboBoxAdv1.SelectedIndex = 11 OrElse comboBoxAdv1.SelectedIndex = 12 Then
                    Me.gridGroupingControl1.TableModel.Options.WrapCellBehavior = GridWrapCellBehavior.WrapGrid
                Else
                    Me.gridGroupingControl1.TableModel.Options.WrapCellBehavior = GridWrapCellBehavior.None
                    Me.comboBoxAdv2.SelectedIndex = 0
                End If
            Else
                Me.gridGroupingControl1.TableModel.Options.WrapCellBehavior = GridWrapCellBehavior.None
            End If
        End Sub

        Private Sub comboBoxAdv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If comboBoxAdv1.SelectedIndex = 0 Then
                gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.None
            End If
            If comboBoxAdv1.SelectedIndex = 1 Then
                gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.Left
            End If

            If comboBoxAdv1.SelectedIndex = 2 Then
                Me.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.Right
            End If
            If comboBoxAdv1.SelectedIndex = 3 Then
                Me.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.Up
            End If
            If comboBoxAdv1.SelectedIndex = 4 Then
                Me.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.Down
            End If
            If comboBoxAdv1.SelectedIndex = 5 Then
                Me.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.Top
                Me.comboBoxAdv2.SelectedIndex = 0
            End If
            If comboBoxAdv1.SelectedIndex = 6 Then
                Me.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.Bottom
            End If
            If comboBoxAdv1.SelectedIndex = 7 Then
                Me.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.MostLeft
            End If
            If comboBoxAdv1.SelectedIndex = 8 Then
                Me.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.MostRight
            End If
            If comboBoxAdv1.SelectedIndex = 9 Then
                Me.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.TopLeft
            End If
            If comboBoxAdv1.SelectedIndex = 10 Then
                Me.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.BottomRight
            End If
            If comboBoxAdv1.SelectedIndex = 11 Then
                Me.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.PageUp
            End If
            If comboBoxAdv1.SelectedIndex = 12 Then
                Me.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.PageDown
            End If
        End Sub

        Private rowcount As Integer = 20
        Private dept() As String = {"CIVIL", "MECHANICAL", "EEE", "ECE", "IT", "CSE", "BIO-TECH", "AERO", "MARINE", "TEXTILE", "EEE", "ECE", "IT", "CSE", "BIO-TECH", "AERO", "MARINE", "CIVIL", "MECHANICAL", "TEXTILE"}
        Private year() As String = {"I", "II", "III", "IV", "III", "I", "IV", "II", "III", "I", "II", "III", "IV", "III", "I", "IV", "II", "II", "III", "IV"}
        Private sem() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "One", "Two", "Three", "Four"}
        Private grade() As String = {"A", "B", "C", "D", "A", "B", "C", "D", "A", "B", "C", "D", "A", "B", "C", "D", "A", "B", "C", "D"}

        Private Function GetIconFile(ByVal bitmapName As String) As String
            For n As Integer = 0 To 9
                If System.IO.File.Exists(bitmapName) Then
                    Return bitmapName
                End If

                bitmapName = "..\" & bitmapName
            Next n

            Return bitmapName
        End Function

        Private Function CreateTable() As DataTable
            Dim dt As New DataTable()
            dt.Columns.Add("SNo")
            dt.Columns.Add("StudentID")
            dt.Columns.Add("Department")
            dt.Columns.Add("Year")
            dt.Columns.Add("Semester")
            dt.Columns.Add("Grade")
            For i As Integer = 0 To rowcount - 1
                Dim dr As DataRow = dt.NewRow()
                If (i + 1) < 10 Then
                    dr(0) = "0" & (i + 1).ToString()
                    dr(1) = "S" & "0" & (i + 1).ToString()
                Else
                    dr(0) = (i + 1).ToString()
                    dr(1) = "S" & (i + 1).ToString()
                End If
                dr(2) = dept(i)
                dr(3) = year(i)
                dr(4) = sem(i)
                dr(5) = grade(i)
                dt.Rows.Add(dr)
            Next i
            Return dt
        End Function

        Private form As MetroForm
        Private dialog As GroupingGridFormatCellDialog
        Private Sub formatCellsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles formatCellsToolStripMenuItem.Click
            form = New MetroForm()
            form.IsMdiContainer = True
            dialog = New GroupingGridFormatCellDialog(Me.gridGroupingControl1)
            dialog.FormBorderStyle = FormBorderStyle.None
            dialog.Dock = DockStyle.Fill
            dialog.MdiParent = form
            form.Size = dialog.Size + New Size(17, 37)

            AddHandler dialog.Controls(1).Click, AddressOf ButtonClick
            AddHandler dialog.Controls(0).Click, AddressOf ButtonClick
            form.DropShadow = True
            form.FormBorderStyle = FormBorderStyle.FixedSingle
            form.Font = New System.Drawing.Font("Segoe UI", 8.25F)
            form.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            form.BorderThickness = 2
            form.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            form.ShowIcon = False
            form.MaximizeBox = False
            form.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            form.MinimizeBox = False
            form.Text = "Format Cell Dialog"
            dialog.Show()
            form.ShowDialog()
        End Sub

        Private Sub ButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            dialog.Close()
            form.Close()
        End Sub

    End Class
End Namespace
#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO
Imports Syncfusion.Windows.Forms

''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits MetroForm
    Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private WithEvents checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private dataSet11 As DataSet1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private comboBox1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Private label1 As Label
    Private label2 As Label
    Private label3 As Label
    Private label4 As Label
    Private label5 As Label
    Private groupBox1 As GroupBox
    Public Shared ReadOnly connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")

    Public Sub New()
        Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
        Me.Icon = ico
        InitializeComponent()
        Dim commandstring1 As String = "select * from Customers"
        Dim commandstring2 As String = "select * from Orders"

        Dim da1 As New SqlCeDataAdapter(commandstring1, connString)
        Dim da2 As New SqlCeDataAdapter(commandstring2, connString)
        Try
            da1.Fill(dataSet11, "Customers")
            da2.Fill(dataSet11, "Orders")
        Catch ex As SqlException
            ShowErrorMessage(ex)
        End Try
        For Each col As GridColumnDescriptor In Me.gridGroupingControl1.TableDescriptor.Columns
            Me.comboBox1.Text = "None"
            Me.comboBox1.Items.Add(col.Name)
        Next col
        Me.gridGroupingControl1.DataSource = Me.dataSet11.Tables("Customers")
        Me.gridGroupingControl1.AddGroupDropArea("Orders")

        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
        Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.BackColor = Color.White
        Me.DropShadow = True
        Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
        AddHandler gridGroupingControl1.FilterBarSelectedItemChanging, AddressOf gridGroupingControl1_FilterBarSelectedItemChanging
        AddHandler gridGroupingControl1.FilterBarSelectedItemChanged, AddressOf gridGroupingControl1_FilterBarSelectedItemChanged
    End Sub
    Private Sub gridGroupingControl1_FilterBarSelectedItemChanged(ByVal sender As Object, ByVal e As FilterBarSelectedItemChangedEventArgs)
        Me.label3.Text = e.SelectedIndex.ToString()
        Me.label5.Text = e.SelectedText
    End Sub
    Private Sub gridGroupingControl1_FilterBarSelectedItemChanging(ByVal sender As Object, ByVal e As FilterBarSelectedItemChangingEventArgs)
        Dim item As Object = comboBox1.SelectedItem
        If e.Column.Name = item.ToString() Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub
    Private Shared Function FindFile(ByVal fileName As String) As String
        ' Check both in parent folder and Parent\Data folders.
        Dim dataFileName As String = "Common\Data\" & fileName
        For n As Integer = 0 To 11
            If System.IO.File.Exists(fileName) Then
                Return New FileInfo(fileName).FullName
            End If
            If System.IO.File.Exists(dataFileName) Then
                Return New FileInfo(dataFileName).FullName
            End If
            fileName = "..\" & fileName
            dataFileName = "..\" & dataFileName
        Next n

        Return fileName
    End Function
    Private Function GetIconFile(ByVal bitmapName As String) As String
        For n As Integer = 0 To 9
            If System.IO.File.Exists(bitmapName) Then
                Return bitmapName
            End If

            bitmapName = "..\" & bitmapName
        Next n

        Return bitmapName
    End Function


    Private Shared Sub ShowErrorMessage(ByVal ex As SqlException)
        If ex.Number = 11001 Then
            MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If ex.Number = 208 Then
            MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If ex.Number = 156 OrElse ex.Number = 102 Then
            MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.dataSet11 = New DataSet1()
        Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.comboBox1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' gridGroupingControl1
        ' 
        Me.gridGroupingControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
        Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.gridGroupingControl1.DataSource = Me.dataSet11.Customers
        Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridGroupingControl1.Location = New System.Drawing.Point(36, 22)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.ShowGroupDropArea = True
        Me.gridGroupingControl1.Size = New System.Drawing.Size(600, 350)
        Me.gridGroupingControl1.TabIndex = 0
        Me.gridGroupingControl1.TableDescriptor.AllowNew = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235)))))))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))))
        Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
        Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
        Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
        Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
        Me.gridGroupingControl1.Text = "gridGroupingControl1"
        Me.gridGroupingControl1.VersionInfo = "4.201.0.37"
        ' 
        ' dataSet11
        ' 
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.checkBox1.DrawFocusRectangle = False
        Me.checkBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.checkBox1.Location = New System.Drawing.Point(9, 149)
        Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(152, 32)
        Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "Add FilterBar"
        Me.checkBox1.ThemesEnabled = False
        '			Me.checkBox1.CheckStateChanged += New System.EventHandler(Me.checkBox1_CheckStateChanged)
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.comboBox1.BackColor = System.Drawing.Color.White
        Me.comboBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.comboBox1.Items.AddRange(New Object() {"None"})
        Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "None"))
        Me.comboBox1.Location = New System.Drawing.Point(172, 32)
        Me.comboBox1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.comboBox1.TabIndex = 2
        ' 
        ' label1
        ' 
        Me.label1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.label1.Location = New System.Drawing.Point(6, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(148, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Cancel Filter From Column :"
        ' 
        ' label2
        ' 
        Me.label2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.label2.Location = New System.Drawing.Point(6, 76)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(87, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Selected Index :"
        ' 
        ' label3
        ' 
        Me.label3.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.label3.Location = New System.Drawing.Point(169, 76)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(0, 13)
        Me.label3.TabIndex = 5
        ' 
        ' label4
        ' 
        Me.label4.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.label4.Location = New System.Drawing.Point(6, 112)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(82, 13)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Selected Text  :"
        ' 
        ' label5
        ' 
        Me.label5.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.label5.Location = New System.Drawing.Point(169, 112)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(0, 13)
        Me.label5.TabIndex = 7
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.checkBox1)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.comboBox1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.groupBox1.Location = New System.Drawing.Point(674, 22)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(304, 191)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Options"
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.ClientSize = New System.Drawing.Size(1016, 410)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.gridGroupingControl1)
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Bar Demo"
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub

    Private Sub checkBox1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckStateChanged
        If Me.checkBox1.Checked Then
            ' ShowFilterBar for the Main table......
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = True
            'Enable the filter for each columns 
            For i As Integer = 0 To gridGroupingControl1.TableDescriptor.Columns.Count - 1
                gridGroupingControl1.TableDescriptor.Columns(i).AllowFilter = True
            Next i
        Else
            ' removing filterbar for the Main table......
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = False
        End If
    End Sub
End Class

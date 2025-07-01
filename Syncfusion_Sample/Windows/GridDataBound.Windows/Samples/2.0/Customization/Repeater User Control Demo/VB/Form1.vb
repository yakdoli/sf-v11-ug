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


 
Public Class Form1
   Inherits System.Windows.Forms.Form
    
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support
      '
        InitializeComponent()
        Try
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
            Me.Icon = ico
        Catch ex As Exception
        End Try
        Me.BackColor = Color.FromArgb(223, 227, 239)
        Me.StartPosition = FormStartPosition.CenterScreen
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
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.gridRepeaterUserControl1 = New RepeaterUserControlSample.GridRepeaterUserControl
        Me.panel1 = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'gridRepeaterUserControl1
        '
        Me.gridRepeaterUserControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridRepeaterUserControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gridRepeaterUserControl1.Location = New System.Drawing.Point(40, 27)
        Me.gridRepeaterUserControl1.Name = "gridRepeaterUserControl1"
        Me.gridRepeaterUserControl1.Padding = New System.Windows.Forms.Padding(2)
        Me.gridRepeaterUserControl1.Size = New System.Drawing.Size(392, 320)
        Me.gridRepeaterUserControl1.TabIndex = 0
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(448, 374)
        Me.panel1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 374)
        Me.Controls.Add(Me.gridRepeaterUserControl1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.Text = "Repeater User Control Demo"
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private gridRepeaterUserControl1 As GridRepeaterUserControl
    Private panel1 As System.Windows.Forms.Panel
    Private dt As DataTable

    <STAThread()> _
    Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New Form1())
    End Sub 'Main

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'create two instances of your user control that defines the control to be repeated.
        ' SampleUserControl must derive from GridRepeaterControl.CellUserControl which
        ' is derived from UserControl and ICellUserControl. The ICellUserControl support 
        ' is what binds the grid cells to your UserControl.
        Dim activeControl As New SampleUserControl.SampleUserControl()
        Dim staticControl As New SampleUserControl.SampleUserControl()

        Me.gridRepeaterUserControl1.AddUserControls(activeControl, staticControl, 3)

        'set the binding on the repeater control
        dt = GetTable()
        Me.gridRepeaterUserControl1.SetDataBinding(dt)

        'display a second form showing the data in a grid (just as a check)
        'Dim f As Form2 = New Form2()
        'f.gridDataBoundGrid1.DataSource = dt
        'f.gridDataBoundGrid1.CurrentCell.MoveTo(-1, -1) 'no current cell
        'f.Show()

        ' Handle the SaveCellInfo and set e.Handled to true so that
        ' values are not saved to GridData
        AddHandler Me.gridRepeaterUserControl1.Grid.SaveCellInfo, AddressOf Grid_SaveCellInfo
        AddHandler Me.gridRepeaterUserControl1.Grid.TopRowChanging, AddressOf Grid_TopRowChanging
    End Sub 'Form1_Load 
	
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


Private Sub Grid_TopRowChanging(ByVal sender As Object, ByVal e As GridRowColIndexChangingEventArgs)
			If gridRepeaterUserControl1.Grid.ViewLayout.HasPartialVisibleRows AndAlso gridRepeaterUserControl1.Grid.CurrentCell.RowIndex = gridRepeaterUserControl1.Grid.ViewLayout.LastVisibleRow Then
				gridRepeaterUserControl1.Grid.CurrentCell.MoveTo(-1, -1)
			End If
End Sub

#Region "Sample Data"

    Private Function GetTable() As DataTable
        Dim dt As New DataTable("Table")
        dt.Columns.Add(New DataColumn("Name"))
        dt.Columns.Add(New DataColumn("City"))
        dt.Columns.Add(New DataColumn("Zip"))

        Dim i As Integer

        While i < 50
            Dim dr As DataRow = dt.NewRow()
            dr(0) = String.Format("Name{0}", i)
            dr(1) = String.Format("City{0}", i)
            dr(2) = String.Format("Zip{0}", i)
            dt.Rows.Add(dr)
            i += 1
        End While
        Return dt
    End Function 'GetTable
#End Region

    Private Sub Grid_SaveCellInfo(ByVal sender As Object, ByVal e As GridSaveCellInfoEventArgs)
        e.Handled = True
    End Sub
End Class 'Form1 

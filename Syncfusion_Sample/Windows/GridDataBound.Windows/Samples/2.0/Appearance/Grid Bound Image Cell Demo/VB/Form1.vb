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

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb


Public Class Form1
    Inherits Form
    Private WithEvents gridDataBoundGrid1 As GridDataBoundGrid
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents radioButton1 As RadioButton
    Private WithEvents radioButton2 As RadioButton
    Private WithEvents radioButton3 As RadioButton
    Private imageCellDrawOption As GridImageCellDrawOption
    Private WithEvents pictureBox1 As PictureBox
    Private components As Container
    Private proportionalGridCell As Boolean
    Private panel1 As System.Windows.Forms.Panel

    Public Sub New()
        MyBase.New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Try
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
            Me.Icon = ico
        Catch ex As Exception
        End Try
 	'Listen to the IBindingList.ListChanged events instead of the 
	'CurrencyManager events.
	Me.gridDataBoundGrid1.UseListChangedEvent = True

        imageCellDrawOption = GridImageCellDrawOption.FitToCell
        Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
        Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Dim style As GridStyleInfo = gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"
        Me.BackColor = Color.FromArgb(223, 227, 239)
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

        If disposing Then
            If (Not (components) Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.radioButton3 = New System.Windows.Forms.RadioButton
        Me.radioButton2 = New System.Windows.Forms.RadioButton
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.panel1 = New System.Windows.Forms.Panel
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridDataBoundGrid1
        '
        Me.gridDataBoundGrid1.AllowDragSelectedCols = True
        Me.gridDataBoundGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridDataBoundGrid1.DefaultColWidth = 70
        Me.gridDataBoundGrid1.DefaultRowHeight = 18
        Me.gridDataBoundGrid1.HorizontalThumbTrack = True
        Me.gridDataBoundGrid1.Location = New System.Drawing.Point(240, 31)
        Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.gridDataBoundGrid1.Size = New System.Drawing.Size(448, 353)
        Me.gridDataBoundGrid1.SmartSizeBox = False
        Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.gridDataBoundGrid1.TabIndex = 0
        Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ThemesEnabled = True
        Me.gridDataBoundGrid1.VerticalThumbTrack = True
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.radioButton3)
        Me.groupBox1.Controls.Add(Me.radioButton2)
        Me.groupBox1.Controls.Add(Me.radioButton1)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.groupBox1.Location = New System.Drawing.Point(240, 393)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(448, 40)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        '
        'radioButton3
        '
        Me.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButton3.Location = New System.Drawing.Point(311, 11)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(120, 24)
        Me.radioButton3.TabIndex = 2
        Me.radioButton3.Text = "FitProportionally"
        Me.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radioButton2
        '
        Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButton2.Location = New System.Drawing.Point(171, 12)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(80, 24)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.Text = "NoResize"
        Me.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radioButton1
        '
        Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButton1.Location = New System.Drawing.Point(24, 11)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(80, 24)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.Text = "FitToCell"
        Me.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Location = New System.Drawing.Point(26, 90)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(184, 216)
        Me.pictureBox1.TabIndex = 2
        Me.pictureBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(16, 403)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(152, 24)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Proportional Grid Cells"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(704, 438)
        Me.panel1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 438)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.gridDataBoundGrid1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grid Bound Image Cell Demo"
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region

    <STAThread()> _
    Public Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New Form1())

    End Sub

    Function GetPath(ByVal mdbFileName As String) As String
        Dim n As Integer
        For n = 0 To 14
            If System.IO.File.Exists(mdbFileName) Then
                GetPath = mdbFileName
                Exit Function
            End If
            mdbFileName = "..\" & mdbFileName
        Next n
        GetPath = mdbFileName
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'load the data & bind the grid using code instead of the designer...
        ' Set the connection and sql strings
        ' assumes your mdb file is in your root
        'Dim connString As String
        'connString = "Provider=Microsoft.JET.OLEDB.4.0;data source=" & GetPath("Common\Data\Northwind.mdb")
        'Dim sqlString As String
        'sqlString = "SELECT EmployeeID, LastName, FirstName, Photo, Photo as Photo1 FROM Employees"
        'Dim dataAdapter As OleDbDataAdapter
        'dataAdapter = Nothing
        'Dim _dataSet As DataSet = New DataSet()
        '_dataSet = Nothing
        'setup the column formats...
        'default image cell 

        Dim _dataSet As DataSet = Nothing
        Dim connectionstring As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
        Dim commandstring As String = "select EmployeeID, LastName, FirstName, Photo, Photo from Employees"
        _dataSet = New DataSet()
        Dim da As SqlServerCe.SqlCeDataAdapter = New SqlServerCe.SqlCeDataAdapter(commandstring, connectionstring)
        da.Fill(_dataSet, "Employees")

        Me.gridDataBoundGrid1.DataSource = _dataSet
        Me.gridDataBoundGrid1.DataMember = "Employees"

        'Dim commandstring As String = "select EmployeeID, LastName, FirstName, Photo, Photo from Employees"

        'Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(commandstring, Syncfusion.SampleSQLDBSettings.SampleDatabases.NorthwindImage)

        'Try
        '    da.Fill(_dataSet, "Employees")
        '    'bind the grid
        '    Me.gridDataBoundGrid1.DataSource = _dataSet
        '    Me.gridDataBoundGrid1.DataMember = "Employees"
        'Catch ex As SqlClient.SqlException
        '    ShowErrorMessage(ex)
        'End Try
        Dim imageCell As GridImageCellModel
        imageCell = New GridImageCellModel(gridDataBoundGrid1.Model)
        'setup how image is fitted to cell
        imageCell.CellDrawOption = GridImageCellDrawOption.FitProportionally
        'imageCell.CellDrawOption = GridImageCellDrawOption.NoResize;
        'imageCell.CellDrawOption = GridImageCellDrawOption.FitToCell; //default
        'setup offset into byte stream - northwind db is 78 because of VB6 OLE header
        'if you saved bitmap directly to the bytestream, value is 0.
        'imageCell.PictureBufferOffset = 0; //bmps directly into byte stream
        imageCell.PictureBufferOffset = 78
        'northwind
        gridDataBoundGrid1.Model.CellModels.Add("ImageCell", imageCell)
        'as another option, use a dropdown
        gridDataBoundGrid1.Model.CellModels.Add("DropDownPicture", New GridDropDownImageCellModel(Me.gridDataBoundGrid1.Model))
        'set up the GridBoundColumns with correct celltypes
        Dim cm As CurrencyManager
        cm = CType(Me.BindingContext(gridDataBoundGrid1.DataSource, gridDataBoundGrid1.DataMember), CurrencyManager)
        CType(cm.List, DataView).AllowNew = False
        Dim pdc As PropertyDescriptorCollection
        pdc = cm.GetItemProperties
        Dim pd As PropertyDescriptor
        For Each pd In pdc
            Dim col As GridBoundColumn
            col = New Syncfusion.Windows.Forms.Grid.GridBoundColumn(pd)
            col.MappingName = pd.Name
            col.HeaderText = pd.Name
            If (pd.Name = "Photo") Then
                col.StyleInfo.CellType = "ImageCell"
            End If
            If (pd.Name = "Photo1") Then
                col.StyleInfo.CellType = "DropDownPicture"
                col.HeaderText = "Photo1"
            End If
            gridDataBoundGrid1.GridBoundColumns.Add(col)
        Next
        Me.radioButton1.Checked = True
        Me.gridDataBoundGrid1.CurrentCell.MoveTo(1, 1)

        'handle proportional grid cells
        AddHandler gridDataBoundGrid1.Model.QueryColWidth, AddressOf GetColWidth
        AddHandler gridDataBoundGrid1.Model.QueryRowHeight, AddressOf GetRowHeight


        Me.CheckBox1.Checked = True
        Me.proportionalGridCell = True
        Me.gridDataBoundGrid1.DefaultRowHeight = 30
        Me.gridDataBoundGrid1.ResizeRowsBehavior = GridResizeCellsBehavior.ResizeAll
        Me.gridDataBoundGrid1.Model.Properties.GridLineColor = System.Drawing.Color.Silver
        Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid

        ' force display of image
        gridDataBoundGrid1_CurrentCellChanged(gridDataBoundGrid1, EventArgs.Empty)

    End Sub
	
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function
    Friend Shared Function FindFile(ByVal fileName As String) As String
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

	
    Private Shared Sub ShowErrorMessage(ByVal ex As SqlClient.SqlException)
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
    Private Sub GetColWidth(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
        If Me.proportionalGridCell And e.Index > 0 Then
            e.Size = Math.Ceiling(Convert.ToDouble(Me.gridDataBoundGrid1.ClientRectangle.Width - Me.gridDataBoundGrid1.Model.ColWidths(0)) / Me.gridDataBoundGrid1.Model.ColCount) - 1
            e.Handled = True
        End If
    End Sub
    Private Sub GetRowHeight(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
        If Me.proportionalGridCell And e.Index > 0 Then
            e.Size = Math.Ceiling(Convert.ToDouble(Me.gridDataBoundGrid1.ClientRectangle.Height - Me.gridDataBoundGrid1.Model.RowHeights(0)) / Me.gridDataBoundGrid1.Model.RowCount) - 1
            e.Handled = True
        End If
    End Sub
    Private Sub radioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged

        Dim imageCell As GridImageCellModel
        imageCell = CType(Me.gridDataBoundGrid1.Model.CellModels("ImageCell"), GridImageCellModel)
        If (Not (imageCell) Is Nothing) Then
            imageCell.CellDrawOption = GridImageCellDrawOption.FitToCell
            Me.gridDataBoundGrid1.Refresh()
        End If

    End Sub
    Private Sub radioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButton2.CheckedChanged

        Dim imageCell As GridImageCellModel
        imageCell = CType(Me.gridDataBoundGrid1.Model.CellModels("ImageCell"), GridImageCellModel)
        If (Not (imageCell) Is Nothing) Then
            imageCell.CellDrawOption = GridImageCellDrawOption.NoResize
            Me.gridDataBoundGrid1.Refresh()
        End If

    End Sub
    Private Sub radioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButton3.CheckedChanged

        Dim imageCell As GridImageCellModel
        imageCell = CType(Me.gridDataBoundGrid1.Model.CellModels("ImageCell"), GridImageCellModel)
        If (Not (imageCell) Is Nothing) Then
            imageCell.CellDrawOption = GridImageCellDrawOption.FitProportionally
            Me.gridDataBoundGrid1.Refresh()
        End If

    End Sub
    Private Sub gridDataBoundGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs)

        Dim PictOffSet As Integer
        PictOffSet = 78
        Try
            Dim pict() As [Byte]
            pict = CType(gridDataBoundGrid1(gridDataBoundGrid1.CurrentCell.RowIndex, 4).CellValue, [Byte]())
            If (Not (pict) Is Nothing) Then
                Dim buffer As MemoryStream
                buffer = New MemoryStream(pict, PictOffSet, (pict.Length - PictOffSet))
                Me.pictureBox1.Image = Image.FromStream(buffer, True)
            Else
                Me.pictureBox1.Image = Nothing
            End If
        Catch ex As System.Exception
            Me.pictureBox1.Image = Nothing
        End Try

    End Sub
    Private Sub gridDataBoundGrid1_CurrentCellMoved(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventArgs) Handles gridDataBoundGrid1.CurrentCellMoved

        Dim PictOffSet As Integer
        PictOffSet = 78
        Try
            Dim pict() As [Byte]
            pict = CType(gridDataBoundGrid1(gridDataBoundGrid1.CurrentCell.RowIndex, 4).CellValue, [Byte]())
            If (Not (pict) Is Nothing) Then
                Dim buffer As MemoryStream
                buffer = New MemoryStream(pict, PictOffSet, (pict.Length - PictOffSet))
                Me.pictureBox1.Image = Image.FromStream(buffer, True)
            Else
                Me.pictureBox1.Image = Nothing
            End If
        Catch ex As System.Exception
            Me.pictureBox1.Image = Nothing
        End Try

    End Sub

    Private Sub Form1_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles MyBase.Layout
        Me.gridDataBoundGrid1.Invalidate()
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.gridDataBoundGrid1.Invalidate()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Me.proportionalGridCell = Not Me.proportionalGridCell
        Me.gridDataBoundGrid1.Invalidate()
    End Sub
End Class


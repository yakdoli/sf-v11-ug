Imports Microsoft.VisualBasic
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
Imports System.Data.OleDb
Imports System.Data
Imports Syncfusion.Windows.Forms


''' <summary>
''' Summary description for SelectTableForm.
''' </summary>
Public Class SelectTableForm
    Inherits MetroForm
    'INSTANT VB NOTE: The variable table was renamed since Visual Basic does not allow class members with the same name:
    Private table_Renamed As String = "Products"
    Private comboBox1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Private label2 As System.Windows.Forms.Label
    Private button1 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents button2 As Syncfusion.Windows.Forms.ButtonAdv
    Private label1 As System.Windows.Forms.Label
    Private WithEvents textBox1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Private WithEvents button3 As Syncfusion.Windows.Forms.ButtonAdv
    Private checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private components As IContainer

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        Me.comboBox1.Text = Table
        FileName = SearchFile("Common\Data\Northwind.MDB")
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        Me.ShowIcon = False
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
        Me.components = New System.ComponentModel.Container()
        Me.comboBox1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.button3 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.BackColor = System.Drawing.Color.White
        Me.comboBox1.Items.AddRange(New Object() {"Employees", "Customers", "Categories", "Products", "Orders", "Region", "Shippers", "Suppliers"})
        Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "Employees"))
        Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "Customers"))
        Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "Categories"))
        Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "Products"))
        Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "Orders"))
        Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "Region"))
        Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "Shippers"))
        Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "Suppliers"))
        Me.comboBox1.Location = New System.Drawing.Point(112, 88)
        Me.comboBox1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(136, 21)
        Me.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.comboBox1.TabIndex = 1
        Me.comboBox1.Text = "Products"
        ' 
        ' label2
        ' 
        Me.label2.Location = New System.Drawing.Point(40, 88)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 23)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Table"
        ' 
        ' button1
        ' 
        Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
        Me.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button1.Location = New System.Drawing.Point(368, 184)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 24)
        Me.button1.TabIndex = 3
        Me.button1.Text = "&Cancel"
        Me.button1.UseVisualStyle = True
        Me.button1.UseVisualStyleBackColor = True
        ' 
        ' button2
        ' 
        Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.button2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
        Me.button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.button2.Location = New System.Drawing.Point(248, 184)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 4
        Me.button2.Text = "&OK"
        Me.button2.UseVisualStyle = True
        Me.button2.UseVisualStyleBackColor = True
        '			Me.button2.Click += New System.EventHandler(Me.button2_Click)
        ' 
        ' label1
        ' 
        Me.label1.Location = New System.Drawing.Point(40, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(56, 16)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Database"
        ' 
        ' textBox1
        ' 
        Me.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textBox1.Location = New System.Drawing.Point(112, 32)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(224, 20)
        Me.textBox1.TabIndex = 0
        '			Me.textBox1.Leave += New System.EventHandler(Me.textBox1_Leave)
        ' 
        ' button3
        ' 
        Me.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.button3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
        Me.button3.Location = New System.Drawing.Point(368, 32)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(72, 24)
        Me.button3.TabIndex = 7
        Me.button3.Text = "Browse ..."
        Me.button3.UseVisualStyle = True
        Me.button3.UseVisualStyleBackColor = True
        '			Me.button3.Click += New System.EventHandler(Me.button3_Click)
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.DrawFocusRectangle = False
        Me.checkBox1.Location = New System.Drawing.Point(112, 136)
        Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(184, 20)
        Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox1.TabIndex = 8
        Me.checkBox1.Text = "Reset Existing Columns"
        Me.checkBox1.ThemesEnabled = False
        ' 
        ' SelectTableForm
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.ClientSize = New System.Drawing.Size(472, 238)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.comboBox1)
        Me.DropShadow = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectTableForm"
        Me.Text = "Choose Database"
        CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    'INSTANT VB NOTE: The variable fileName was renamed since Visual Basic does not allow class members with the same name:
    Private fileName_Renamed As String = ""
    Public Property FileName() As String
        Get
            Return Me.fileName_Renamed
        End Get
        Set(ByVal value As String)
            If fileName_Renamed <> value Then
                textBox1.Text = value
                fileName_Renamed = value
                UpdateTableList()
            End If
        End Set
    End Property

    Public ReadOnly Property ConnectionString() As String
        Get
            Return "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Me.fileName_Renamed
        End Get
    End Property

    Public ReadOnly Property ResetColumnChecked() As Boolean
        Get
            Return Me.checkBox1.Checked
        End Get
    End Property

    Private Sub UpdateTableList()
        Dim cn As OleDbConnection
        Dim strCn As String = ConnectionString
        Dim dtTables As DataTable
        cn = New OleDbConnection(strCn)
        cn.Open()
        dtTables = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})

        Me.comboBox1.Items.Clear()
        For Each row As DataRow In dtTables.Rows
            Me.comboBox1.Items.Add(row("TABLE_NAME"))
        Next row
        Me.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        cn.Close()
    End Sub

    Public Property Table() As String
        Get
            Return table_Renamed
        End Get
        Set(ByVal value As String)
            table_Renamed = value
        End Set
    End Property


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        If Me.textBox1.Text <> "" Then
            Me.Table = Me.comboBox1.Text
        End If
    End Sub

    Private Function SearchFile(ByVal fileName As String) As String
        For n As Integer = 0 To 6
            If System.IO.File.Exists(fileName) Then
                Return System.IO.Path.GetFullPath(fileName)
            End If
            fileName = "..\" & fileName
        Next n
        Return ""
    End Function


    Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
        Dim dlg As New OpenFileDialog()
        dlg.AddExtension = True
        dlg.CheckFileExists = True
        dlg.CheckPathExists = True
        dlg.DefaultExt = ".mdb"

        dlg.FileName = FileName

        dlg.Multiselect = False
        dlg.Title = "Open Microsoft Access Database"
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            FileName = dlg.FileName
        End If
    End Sub

    Private Sub textBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox1.Leave
        FileName = textBox1.Text
    End Sub
End Class


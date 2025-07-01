Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports Syncfusion.SampleSQLDBSettings
Imports System.Data.SqlServerCe

Namespace ComboBoxBase
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits System.Windows.Forms.Form
        Friend Label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private WithEvents comboBoxBase1 As Syncfusion.Windows.Forms.Tools.ComboBoxBase
        Private dataSet11 As DataSet1
        Private dataGrid1 As System.Windows.Forms.DataGrid
        Private listBox1 As System.Windows.Forms.ListBox
        Private groupBox1 As System.Windows.Forms.Panel
        Private imageList1 As System.Windows.Forms.ImageList
        Private label3 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private WithEvents comboBoxBase2 As Syncfusion.Windows.Forms.Tools.ComboBoxBase
        Private listBox2 As System.Windows.Forms.ListBox
        Private panel1 As System.Windows.Forms.Panel
        Private label5 As System.Windows.Forms.Label
        Private textLog As System.Windows.Forms.TextBox
        Private label7 As System.Windows.Forms.Label
        Private checkedListBox1 As System.Windows.Forms.CheckedListBox
        Private WithEvents comboBoxBase4 As Syncfusion.Windows.Forms.Tools.ComboBoxBase
        Private listBox3 As System.Windows.Forms.ListBox
        Private WithEvents comboBoxBase5 As Syncfusion.Windows.Forms.Tools.ComboBoxBase
        Private label6 As System.Windows.Forms.Label
        Private label8 As System.Windows.Forms.Label
        Private components As System.ComponentModel.IContainer

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.label2 = New System.Windows.Forms.Label()
            Me.comboBoxBase1 = New Syncfusion.Windows.Forms.Tools.ComboBoxBase()
            Me.listBox1 = New System.Windows.Forms.ListBox()
            Me.dataSet11 = New DataSet1()
            Me.dataGrid1 = New System.Windows.Forms.DataGrid()
            Me.groupBox1 = New System.Windows.Forms.Panel()
            Me.comboBoxBase2 = New Syncfusion.Windows.Forms.Tools.ComboBoxBase()
            Me.listBox2 = New System.Windows.Forms.ListBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.comboBoxBase4 = New Syncfusion.Windows.Forms.Tools.ComboBoxBase()
            Me.listBox3 = New System.Windows.Forms.ListBox()
            Me.comboBoxBase5 = New Syncfusion.Windows.Forms.Tools.ComboBoxBase()
            Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.textLog = New System.Windows.Forms.TextBox()
            Me.label5 = New System.Windows.Forms.Label()
            CType(Me.comboBoxBase1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.comboBoxBase2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.comboBoxBase4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxBase5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' Label1
            ' 
            Me.Label1.BackColor = System.Drawing.Color.FromArgb((CByte(254)), (CByte(240)), (CByte(225)))
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.Label1.ImageIndex = 0
            Me.Label1.ImageList = Me.imageList1
            Me.Label1.Location = New System.Drawing.Point(136, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(440, 48)
            Me.Label1.TabIndex = 7
            Me.Label1.Text = "The ComboBoxBase can be bound to any ListBox derived class during design-time, " & Constants.vbCrLf & "which will then appear in its drop-down during runtime."
            ' 
            ' imageList1
            ' 
            Me.imageList1.ImageSize = New System.Drawing.Size(32, 32)
            Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(8, 32)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(139, 17)
            Me.label2.TabIndex = 8
            Me.label2.Text = "Select Category for Display"
            ' 
            ' comboBoxBase1
            ' 
            Me.comboBoxBase1.BackColor = System.Drawing.Color.FromArgb((CByte(234)), (CByte(242)), (CByte(251)))
            Me.comboBoxBase1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxBase1.IgnoreThemeBackground = True
            Me.comboBoxBase1.ListControl = Me.listBox1
            Me.comboBoxBase1.Location = New System.Drawing.Point(152, 26)
            Me.comboBoxBase1.Name = "comboBoxBase1"
            Me.comboBoxBase1.Size = New System.Drawing.Size(152, 22)
            Me.comboBoxBase1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxBase1.SuppressDropDownEvent = False
            Me.comboBoxBase1.TabIndex = 9
            '			Me.comboBoxBase1.SelectionChangeCommitted += New System.EventHandler(Me.comboBoxBase1_SelectionChangeCommitted);
            ' 
            ' listBox1
            ' 
            Me.listBox1.BackColor = System.Drawing.Color.FromArgb((CByte(234)), (CByte(242)), (CByte(251)))
            Me.listBox1.Items.AddRange(New Object() {""})
            Me.listBox1.Location = New System.Drawing.Point(120, 128)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(120, 95)
            Me.listBox1.TabIndex = 12
            ' 
            ' dataSet11
            ' 
            Me.dataSet11.DataSetName = "DataSet1"
            Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
            ' 
            ' dataGrid1
            ' 
            Me.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb((CByte(215)), (CByte(221)), (CByte(237)))
            Me.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb((CByte(103)), (CByte(110)), (CByte(152)))
            Me.dataGrid1.DataMember = ""
            Me.dataGrid1.HeaderBackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(198)), (CByte(220)))
            Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dataGrid1.Location = New System.Drawing.Point(8, 56)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.ParentRowsBackColor = System.Drawing.Color.FromArgb((CByte(103)), (CByte(110)), (CByte(152)))
            Me.dataGrid1.SelectionBackColor = System.Drawing.Color.FromArgb((CByte(103)), (CByte(110)), (CByte(152)))
            Me.dataGrid1.Size = New System.Drawing.Size(368, 216)
            Me.dataGrid1.TabIndex = 11

            ' 
            ' groupBox1
            ' 
            Me.groupBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.groupBox1.Controls.Add(Me.comboBoxBase2)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.dataGrid1)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.listBox1)
            Me.groupBox1.Controls.Add(Me.comboBoxBase1)
            Me.groupBox1.Controls.Add(Me.listBox2)
            Me.groupBox1.Location = New System.Drawing.Point(8, 88)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(384, 320)
            Me.groupBox1.TabIndex = 13
            Me.groupBox1.Text = "Bounded"
            ' 
            ' comboBoxBase2
            ' 
            Me.comboBoxBase2.BackColor = System.Drawing.Color.FromArgb((CByte(234)), (CByte(242)), (CByte(251)))
            Me.comboBoxBase2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxBase2.IgnoreThemeBackground = True
            Me.comboBoxBase2.ListControl = Me.listBox2
            Me.comboBoxBase2.Location = New System.Drawing.Point(152, 280)
            Me.comboBoxBase2.Name = "comboBoxBase2"
            Me.comboBoxBase2.Size = New System.Drawing.Size(152, 22)
            Me.comboBoxBase2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxBase2.SuppressDropDownEvent = False
            Me.comboBoxBase2.TabIndex = 15
            Me.comboBoxBase2.Text = "True"

            ' 
            ' listBox2
            ' 
            Me.listBox2.BackColor = System.Drawing.Color.FromArgb((CByte(234)), (CByte(242)), (CByte(251)))
            Me.listBox2.Items.AddRange(New Object() {"True", "False"})
            Me.listBox2.Location = New System.Drawing.Point(152, 112)
            Me.listBox2.Name = "listBox2"
            Me.listBox2.Size = New System.Drawing.Size(120, 95)
            Me.listBox2.TabIndex = 16
            ' 
            ' label4
            ' 
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(56, 284)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(82, 17)
            Me.label4.TabIndex = 14
            Me.label4.Text = "Set Discontinue"
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label3.ForeColor = System.Drawing.Color.Maroon
            Me.label3.Location = New System.Drawing.Point(8, 8)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(126, 17)
            Me.label3.TabIndex = 13
            Me.label3.Text = "Bounded ListControls"
            ' 
            ' panel1
            ' 
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.comboBoxBase4)
            Me.panel1.Controls.Add(Me.comboBoxBase5)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.label8)
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.textLog)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.listBox3)
            Me.panel1.Controls.Add(Me.checkedListBox1)
            Me.panel1.Location = New System.Drawing.Point(408, 88)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(336, 320)
            Me.panel1.TabIndex = 14
            ' 
            ' comboBoxBase4
            ' 
            Me.comboBoxBase4.BackColor = System.Drawing.Color.FromArgb((CByte(234)), (CByte(242)), (CByte(251)))
            Me.comboBoxBase4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxBase4.IgnoreThemeBackground = True
            Me.comboBoxBase4.ListControl = Me.listBox3
            Me.comboBoxBase4.Location = New System.Drawing.Point(8, 48)
            Me.comboBoxBase4.Name = "comboBoxBase4"
            Me.comboBoxBase4.Size = New System.Drawing.Size(160, 22)
            Me.comboBoxBase4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxBase4.SuppressDropDownEvent = False
            Me.comboBoxBase4.TabIndex = 19
            Me.comboBoxBase4.Text = "Item1"
            ' 
            ' listBox3
            ' 
            Me.listBox3.BackColor = System.Drawing.Color.FromArgb((CByte(234)), (CByte(242)), (CByte(251)))
            Me.listBox3.Items.AddRange(New Object() {"Item1", "Item2", "Item3", "Item4", "Item5"})
            Me.listBox3.Location = New System.Drawing.Point(192, 200)
            Me.listBox3.Name = "listBox3"
            Me.listBox3.Size = New System.Drawing.Size(104, 69)
            Me.listBox3.TabIndex = 23
            ' 
            ' comboBoxBase5
            ' 
            Me.comboBoxBase5.BackColor = System.Drawing.Color.FromArgb((CByte(234)), (CByte(242)), (CByte(251)))
            Me.comboBoxBase5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxBase5.IgnoreThemeBackground = True
            Me.comboBoxBase5.ListControl = Me.checkedListBox1
            Me.comboBoxBase5.Location = New System.Drawing.Point(8, 96)
            Me.comboBoxBase5.Name = "comboBoxBase5"
            Me.comboBoxBase5.Size = New System.Drawing.Size(160, 22)
            Me.comboBoxBase5.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxBase5.SuppressDropDownEvent = False
            Me.comboBoxBase5.TabIndex = 20
            Me.comboBoxBase5.Text = "Item1"
            '			Me.comboBoxBase5.SelectionChangeCommitted += New System.EventHandler(Me.comboBoxBase_SelectionChangeCommitted);
            '			Me.comboBoxBase5.DropDown += New System.EventHandler(Me.comboBoxBase_DropDown);
            '			Me.comboBoxBase5.TextChanged += New System.EventHandler(Me.comboBoxBase_TextChanged);
            ' 
            ' checkedListBox1
            ' 
            Me.checkedListBox1.BackColor = System.Drawing.Color.FromArgb((CByte(234)), (CByte(242)), (CByte(251)))
            Me.checkedListBox1.Items.AddRange(New Object() {"Item1", "Item2", "Item3", "Item4", "Item5", "Item6"})
            Me.checkedListBox1.Location = New System.Drawing.Point(223, 172)
            Me.checkedListBox1.Name = "checkedListBox1"
            Me.checkedListBox1.Size = New System.Drawing.Size(104, 68)
            Me.checkedListBox1.TabIndex = 24
            ' 
            ' label6
            ' 
            Me.label6.Location = New System.Drawing.Point(8, 80)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(184, 16)
            Me.label6.TabIndex = 22
            Me.label6.Text = "Combo With CheckedListBox:"
            ' 
            ' label8
            ' 
            Me.label8.Location = New System.Drawing.Point(8, 32)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(184, 16)
            Me.label8.TabIndex = 21
            Me.label8.Text = "Combo With ListBox:"
            ' 
            ' label7
            ' 
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label7.ForeColor = System.Drawing.Color.Maroon
            Me.label7.Location = New System.Drawing.Point(8, 144)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(66, 17)
            Me.label7.TabIndex = 18
            Me.label7.Text = "Events Log"
            ' 
            ' textLog
            ' 
            Me.textLog.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.textLog.Location = New System.Drawing.Point(0, 166)
            Me.textLog.Multiline = True
            Me.textLog.Name = "textLog"
            Me.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.textLog.Size = New System.Drawing.Size(334, 152)
            Me.textLog.TabIndex = 17
            Me.textLog.Text = ""
            ' 
            ' label5
            ' 
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label5.ForeColor = System.Drawing.Color.Maroon
            Me.label5.Location = New System.Drawing.Point(16, 8)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(303, 17)
            Me.label5.TabIndex = 14
            Me.label5.Text = "ComboBoxBase with different Controls in DropDown"
            ' 
            ' Form1
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.BackColor = System.Drawing.Color.FromArgb((CByte(215)), (CByte(221)), (CByte(237)))
            Me.ClientSize = New System.Drawing.Size(752, 414)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.Label1)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.Text = "ComboBox Base"
            '			Me.Load += New System.EventHandler(Me.Form1_Load);
            CType(Me.comboBoxBase1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            CType(Me.comboBoxBase2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.comboBoxBase4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxBase5, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.listBox1.DataSource = Me.dataSet11.Categories
            Me.listBox1.DisplayMember = "CategoryName"
            Dim DEF_DB_COMMAND2 As String = "SELECT DISTINCT CategoryName FROM Categories"
            Dim connectionstring As String = "..\..\..\..\..\..\..\..\..\Common\Data\NorthwindIO.sdf"
            Dim SqlConnString As String = "Data Source = " + connectionstring
            Dim conn As SqlCeConnection = New SqlCeConnection(SqlConnString)
            conn.Open()
            Dim Adapter As SqlCeDataAdapter = New SqlCeDataAdapter(DEF_DB_COMMAND2, conn)
            Adapter.Fill(Me.dataSet11.Categories)

            Me.dataGrid1.DataSource = Me.dataSet11.Products

            Me.comboBoxBase2.DataBindings.Add("Text", Me.dataSet11.Products, "Discontinued")
            Me.comboBoxBase2.Enabled = False

        End Sub

        Private Sub FilterProductsList(ByVal productListTable As DataTable, ByVal category As String)
            Dim query As String = "SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Products.Discontinued FROM (Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID) WHERE Categories.CategoryName='" & category & "'"

            Dim connectionstring As String = "..\..\..\..\..\..\..\..\..\Common\Data\NorthwindIO.sdf"
            Dim SqlConnString As String = "Data Source = " + connectionstring
            Dim conn As SqlCeConnection = New SqlCeConnection(SqlConnString)
            conn.Open()
            Dim Adapter As SqlCeDataAdapter = New SqlCeDataAdapter(query, conn)
            Adapter.Fill(productListTable)
        End Sub

        Private Sub comboBoxBase1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxBase1.SelectionChangeCommitted
            Me.dataSet11.Products.Clear()
            FilterProductsList(Me.dataSet11.Products, Me.comboBoxBase1.Text)
            Me.comboBoxBase2.Enabled = True
            AddLog("Displaying " & Me.comboBoxBase1.Text & " Category")
        End Sub


        Private Sub AddLog(ByVal text As String)
            Me.textLog.Text += text & Constants.vbCrLf
        End Sub



        Private Sub comboBoxBase_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxBase4.DropDown, comboBoxBase5.DropDown
            AddLog("Event: DropDown")
        End Sub

        Private Sub comboBoxBase_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxBase4.SelectionChangeCommitted, comboBoxBase5.SelectionChangeCommitted
            AddLog("Event: SelectionChangeCommitted")
        End Sub

        Private Sub comboBoxBase_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxBase4.TextChanged, comboBoxBase5.TextChanged
            AddLog("Event: TextChanged")
        End Sub


    End Class

End Namespace

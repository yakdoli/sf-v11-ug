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
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Tools


'/ <summary>
'/ Summary description for ComboBoxAdvSampleControl.
'/ </summary>

Public Class ComboBoxAdvSampleControl
   Inherits System.Windows.Forms.UserControl
   Implements IChildSampleControls 'ToDo: Add Implements Clauses for implementation methods of these interface(s)
    Private dataSet21 As ComboBoxAdvDemo.DataSet2
   Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
   Private oleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
   Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
   Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
   Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
   Private oleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Private dataSet11 As ComboBoxAdvDemo.DataSet1
   Private groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents unboundCombo As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
   Private groupBox2 As System.Windows.Forms.GroupBox
   Private label2 As System.Windows.Forms.Label
   Private label1 As System.Windows.Forms.Label
   Private WithEvents boundCombo As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
   Private dataGrid1 As System.Windows.Forms.DataGrid
   Private oleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
   Private oleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
   Private oleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
   Private oleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
   Private oleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
   '/ <summary> 
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   Friend textLog As TextBox
   
   
   Public Sub New()
      ' This call is required by the Windows.Forms Form Designer.
      InitializeComponent()
    End Sub 'New

    Function FindFile(ByVal xmlFileName As String) As String
        ' Check both in parent folder and Parent\Data folders.
        Dim xmlDataFileName As String = "Data\" + xmlFileName
        Dim n As Integer
        For n = 0 To 11
            If System.IO.File.Exists(xmlFileName) Then
                Return xmlFileName
            End If
            If System.IO.File.Exists(xmlDataFileName) Then
                Return xmlDataFileName
            End If
            xmlFileName = "..\" + xmlFileName
            xmlDataFileName = "..\" + xmlDataFileName
        Next n

        Return xmlFileName
    End Function 'ReadXml


    ' TODO: Add any initialization after the InitForm call

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

#Region "Component Designer generated code"

    '/ <summary> 
    '/ Required method for Designer support - do not modify 
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComboBoxAdvSampleControl))
        Me.dataSet21 = New ComboBoxAdvDemo.DataSet2
        Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.dataSet11 = New ComboBoxAdvDemo.DataSet1
        Me.groupBox3 = New System.Windows.Forms.GroupBox
        Me.unboundCombo = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.boundCombo = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Me.dataGrid1 = New System.Windows.Forms.DataGrid
        Me.oleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.oleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.oleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.oleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.oleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        CType(Me.dataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        CType(Me.unboundCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        CType(Me.boundCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataSet21
        '
        Me.dataSet21.DataSetName = "DataSet2"
        Me.dataSet21.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'oleDbDataAdapter1
        '
        Me.oleDbDataAdapter1.DeleteCommand = Me.oleDbDeleteCommand1
        Me.oleDbDataAdapter1.InsertCommand = Me.oleDbInsertCommand1
        Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
        Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerName", "CustomerName"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Sex", "Sex")})})
        Me.oleDbDataAdapter1.UpdateCommand = Me.oleDbUpdateCommand1
        '
        'oleDbDeleteCommand1
        '
        Me.oleDbDeleteCommand1.CommandText = "DELETE FROM Customers WHERE (ID = ?) AND (CustomerName = ? OR ? IS NULL AND Custo" & _
            "merName IS NULL) AND (Sex = ? OR ? IS NULL AND Sex IS NULL)"
        Me.oleDbDeleteCommand1.Connection = Me.oleDbConnection1
        Me.oleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sex", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sex", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sex1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sex", System.Data.DataRowVersion.Original, Nothing)})
        '
        'oleDbConnection1
        '
        Me.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString")
        '
        'oleDbInsertCommand1
        '
        Me.oleDbInsertCommand1.CommandText = "INSERT INTO Customers(CustomerName, Sex) VALUES (?, ?)"
        Me.oleDbInsertCommand1.Connection = Me.oleDbConnection1
        Me.oleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerName"), New System.Data.OleDb.OleDbParameter("Sex", System.Data.OleDb.OleDbType.VarWChar, 50, "Sex")})
        '
        'oleDbSelectCommand1
        '
        Me.oleDbSelectCommand1.CommandText = "SELECT CustomerName, ID, Sex FROM Customers"
        Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
        '
        'oleDbUpdateCommand1
        '
        Me.oleDbUpdateCommand1.CommandText = "UPDATE Customers SET CustomerName = ?, Sex = ? WHERE (ID = ?) AND (CustomerName =" & _
            " ? OR ? IS NULL AND CustomerName IS NULL) AND (Sex = ? OR ? IS NULL AND Sex IS N" & _
            "ULL)"
        Me.oleDbUpdateCommand1.Connection = Me.oleDbConnection1
        Me.oleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerName"), New System.Data.OleDb.OleDbParameter("Sex", System.Data.OleDb.OleDbType.VarWChar, 50, "Sex"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sex", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sex", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sex1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sex", System.Data.DataRowVersion.Original, Nothing)})
        '
        'dataSet11
        '
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'groupBox3
        '
        Me.groupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.groupBox3.Controls.Add(Me.unboundCombo)
        Me.groupBox3.Location = New System.Drawing.Point(328, 8)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(168, 320)
        Me.groupBox3.TabIndex = 5
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Unbound ComboBoxAdv:"
        '
        'unboundCombo
        '
        Me.unboundCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.unboundCombo.IgnoreThemeBackground = True
        Me.unboundCombo.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.unboundCombo.Location = New System.Drawing.Point(24, 40)
        Me.unboundCombo.Name = "unboundCombo"
        Me.unboundCombo.Size = New System.Drawing.Size(136, 21)
        Me.unboundCombo.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.unboundCombo.SuppressDropDownEvent = False
        Me.unboundCombo.TabIndex = 0
        '
        'groupBox2
        '
        Me.groupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me.boundCombo)
        Me.groupBox2.Controls.Add(Me.dataGrid1)
        Me.groupBox2.Location = New System.Drawing.Point(3, 8)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(317, 320)
        Me.groupBox2.TabIndex = 4
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "DataBound ComboBoxAdv"
        '
        'label2
        '
        Me.label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.Location = New System.Drawing.Point(16, 24)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(285, 48)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Databinding for this combo initialized in code. Change the Sex in the current row" & _
            " in the grid below and see the values change here and vice-versa."
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(8, 168)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(152, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Databound Grid:"
        '
        'boundCombo
        '
        Me.boundCombo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boundCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.boundCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boundCombo.IgnoreThemeBackground = True
        Me.boundCombo.Location = New System.Drawing.Point(16, 80)
        Me.boundCombo.Name = "boundCombo"
        Me.boundCombo.Size = New System.Drawing.Size(285, 21)
        Me.boundCombo.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.boundCombo.SuppressDropDownEvent = False
        Me.boundCombo.TabIndex = 0
        '
        'dataGrid1
        '
        Me.dataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGrid1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dataGrid1.CaptionBackColor = System.Drawing.Color.MidnightBlue
        Me.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dataGrid1.DataMember = ""
        Me.dataGrid1.DataSource = Me.dataSet11.Customers
        Me.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dataGrid1.LinkColor = System.Drawing.Color.Teal
        Me.dataGrid1.Location = New System.Drawing.Point(8, 184)
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dataGrid1.Size = New System.Drawing.Size(301, 128)
        Me.dataGrid1.TabIndex = 1
        '
        'oleDbDataAdapter2
        '
        Me.oleDbDataAdapter2.DeleteCommand = Me.oleDbDeleteCommand2
        Me.oleDbDataAdapter2.InsertCommand = Me.oleDbInsertCommand2
        Me.oleDbDataAdapter2.SelectCommand = Me.oleDbSelectCommand2
        Me.oleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Sex_Description", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Description", "Description")})})
        Me.oleDbDataAdapter2.UpdateCommand = Me.oleDbUpdateCommand2
        '
        'oleDbDeleteCommand2
        '
        Me.oleDbDeleteCommand2.CommandText = "DELETE FROM Sex_Description WHERE (ID = ?) AND (Description = ? OR ? IS NULL AND " & _
            "Description IS NULL)"
        Me.oleDbDeleteCommand2.Connection = Me.oleDbConnection1
        Me.oleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing)})
        '
        'oleDbInsertCommand2
        '
        Me.oleDbInsertCommand2.CommandText = "INSERT INTO Sex_Description(Description) VALUES (?)"
        Me.oleDbInsertCommand2.Connection = Me.oleDbConnection1
        Me.oleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description")})
        '
        'oleDbSelectCommand2
        '
        Me.oleDbSelectCommand2.CommandText = "SELECT Description, ID FROM Sex_Description"
        Me.oleDbSelectCommand2.Connection = Me.oleDbConnection1
        '
        'oleDbUpdateCommand2
        '
        Me.oleDbUpdateCommand2.CommandText = "UPDATE Sex_Description SET Description = ? WHERE (ID = ?) AND (Description = ? OR" & _
            " ? IS NULL AND Description IS NULL)"
        Me.oleDbUpdateCommand2.Connection = Me.oleDbConnection1
        Me.oleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ComboBoxAdvSampleControl
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Name = "ComboBoxAdvSampleControl"
        Me.Size = New System.Drawing.Size(504, 336)
        CType(Me.dataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        CType(Me.unboundCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        CType(Me.boundCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private Sub ComboBoxAdvSampleControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Validate the path to the "Data directory".
        ' The designer generated path may not be good enough if the user installed 
        ' to a non-default directory.
        ' Syncfusion.Windows.Forms.WinFormsUtils.UpdateDirectoryPath(Me.oleDbConnection1, "Data", "ComboBoxAdvDataBinding.mdb")
        Me.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & FindFile("ComboBoxAdvDataBinding.mdb")

        Me.oleDbDataAdapter1.Fill(Me.dataSet11)
        Me.oleDbDataAdapter2.Fill(Me.dataSet21)

        Me.boundCombo.DataSource = Me.dataSet21.Sex_Description
        Me.boundCombo.DisplayMember = "Description"
        Me.boundCombo.ValueMember = "ID"

        Me.boundCombo.DataBindings.Add("SelectedValue", Me.dataSet11.Customers, "Sex")
    End Sub 'ComboBoxAdvSampleControl_Load


    Public Function GetPrimaryItem() As Control Implements IChildSampleControls.GetPrimaryItem
        Return Me.boundCombo
    End Function 'GetPrimaryItem
#Region "TRACE_NOTIFICATIONS"

    Private Sub combo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles unboundCombo.SelectedIndexChanged, boundCombo.SelectedIndexChanged
        If Me.textLog Is Nothing Then
            Return
        End If
        Dim c As ComboBoxBaseDataBound = CType(sender, ComboBoxBaseDataBound)
        Dim newText As String = String.Concat(c.Name, "'s SelectedIndexChanged to:", c.SelectedIndex.ToString(), ControlChars.Cr, ControlChars.Lf)
        Me.textLog.Text += newText
    End Sub 'combo_SelectedIndexChanged


    Private Sub combo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles unboundCombo.SelectionChangeCommitted, boundCombo.SelectionChangeCommitted
        If Me.textLog Is Nothing Then
            Return
        End If
        Dim c As ComboBoxBaseDataBound = CType(sender, ComboBoxBaseDataBound)
        Dim newText As String = String.Concat(c.Name, "'s SelectionChangeCommitted to:", c.SelectedIndex.ToString(), ControlChars.Cr, ControlChars.Lf)
        Me.textLog.Text += newText
    End Sub 'combo_SelectionChangeCommitted


    Private Sub combo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles unboundCombo.Validated, boundCombo.Validated
        If Me.textLog Is Nothing Then
            Return
        End If
        Dim c As ComboBoxBaseDataBound = CType(sender, ComboBoxBaseDataBound)
        If Not (c.SelectedItem Is Nothing) Then
            Me.textLog.Text += c.Name + "has validated the new entry. New entry is:" + c.SelectedItem.ToString() + ControlChars.Cr + ControlChars.Lf
        Else
            Me.textLog.Text += c.Name + "has validated the new entry. New entry is:" + c.Text + ControlChars.Cr + ControlChars.Lf
        End If
    End Sub 'combo_Validated

    Private Sub combo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Me.textLog Is Nothing Then
            Return
        End If
        Dim c As ComboBoxBaseDataBound = sender '
        'ToDo: Error processing original source shown below
        '    return;
        '   ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
        '------------------------------------^--- Syntax error: ';' expected
        If Not (c.SelectedItem Is Nothing) Then
            Me.textLog.Text += c.Name + "is validating the new entry:" + c.SelectedItem.ToString() + ControlChars.Cr + ControlChars.Lf
        Else
            Me.textLog.Text += c.Name + "is validating the new entry:" + c.Text + ControlChars.Cr + ControlChars.Lf
        End If
    End Sub 'combo_Validating
#End Region

    
End Class 'ComboBoxAdvSampleControl 
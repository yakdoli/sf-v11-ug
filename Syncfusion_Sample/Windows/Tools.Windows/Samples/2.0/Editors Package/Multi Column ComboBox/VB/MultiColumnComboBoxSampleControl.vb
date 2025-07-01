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
Imports System.Data.SqlServerCe
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

'/ <summary>
'/ Summary description for MultiColumnComboBoxSampleControl.
'/ </summary>

Public Class MultiColumnComboBoxSampleControl
    Inherits System.Windows.Forms.UserControl
    Implements IChildSampleControls
    'ToDo: Add Implements Clauses for implementation methods of these interface(s)
    Private groupBox2 As System.Windows.Forms.GroupBox
    Private label2 As System.Windows.Forms.Label
    Public WithEvents multiColumnBoundCombo As Syncfusion.Windows.Forms.Tools.MultiColumnComboBox
    '/ <summary> 
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private groupBox1 As System.Windows.Forms.GroupBox
    Public propertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend textLog As TextBox
    
    
    Public Sub New()
        ' This call is required by the Windows.Forms Form Designer.
        InitializeComponent()
    End Sub 'New
     
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultiColumnComboBoxSampleControl))
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.label2 = New System.Windows.Forms.Label
        Me.multiColumnBoundCombo = New Syncfusion.Windows.Forms.Tools.MultiColumnComboBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
        Me.groupBox2.SuspendLayout()
        CType(Me.multiColumnBoundCombo, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.multiColumnBoundCombo)
        Me.groupBox2.Location = New System.Drawing.Point(3, 8)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(277, 288)
        Me.groupBox2.TabIndex = 4
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "DataBound MultiColumnComboBox"
        '
        'label2
        '
        Me.label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.Location = New System.Drawing.Point(16, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(245, 32)
        Me.label2.TabIndex = 3
        Me.label2.Text = "This MultiColumnComboBox is bound to the Customers Table in the Northwind.mdb"
        '
        'multiColumnBoundCombo
        '
        Me.multiColumnBoundCombo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.multiColumnBoundCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.multiColumnBoundCombo.DisplayMember = "ContactName"
        Me.multiColumnBoundCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.multiColumnBoundCombo.IgnoreThemeBackground = True
		Me.multiColumnBoundCombo.ListBox.ThemesEnabled = True
        Me.multiColumnBoundCombo.Location = New System.Drawing.Point(16, 80)
        Me.multiColumnBoundCombo.Name = "multiColumnBoundCombo"
        Me.multiColumnBoundCombo.Size = New System.Drawing.Size(245, 21)
        Me.multiColumnBoundCombo.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.multiColumnBoundCombo.SuppressDropDownEvent = False
        Me.multiColumnBoundCombo.TabIndex = 0		
        Me.multiColumnBoundCombo.ValueMember = "CompanyName"
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.propertyGrid1)
        Me.groupBox1.Location = New System.Drawing.Point(280, 8)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(200, 288)
        Me.groupBox1.TabIndex = 5
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "MultiColumnComboBox Properties"
        '
        'propertyGrid1
        '
        Me.propertyGrid1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.propertyGrid1.HelpBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
        Me.propertyGrid1.Location = New System.Drawing.Point(3, 16)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(194, 269)
        Me.propertyGrid1.TabIndex = 0
        '
        'MultiColumnComboBoxSampleControl
        '
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Name = "MultiColumnComboBoxSampleControl"
        Me.Size = New System.Drawing.Size(488, 304)
        Me.groupBox2.ResumeLayout(False)
        CType(Me.multiColumnBoundCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region
    '			this.multiColumnBoundCombo.DataBindings.Add("SelectedValue", this.dataSet11.Customers, "Sex");	

    Public Function GetPrimaryItem() As Control Implements IChildSampleControls.GetPrimaryItem
        Return Me.multiColumnBoundCombo
    End Function 'GetPrimaryItem
#Region "TRACE_NOTIFICATIONS"

    Private Sub combo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles multiColumnBoundCombo.SelectedIndexChanged
        If Me.textLog Is Nothing Then
            Return
        End If
        Dim c As ComboBoxBaseDataBound = sender '
        'ToDo: Error processing original source shown below
        '    return;
        '   ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
        '-------------------------------------^--- Syntax error: ';' expected
        Me.textLog.Text += c.Name + "'s SelectedIndexChanged to:" + c.SelectedIndex.ToString() + vbCr + vbLf
    End Sub 'combo_SelectedIndexChanged


    Private Sub combo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles multiColumnBoundCombo.SelectionChangeCommitted
        If Me.textLog Is Nothing Then
            Return
        End If
        Dim c As ComboBoxBaseDataBound = sender '
        'ToDo: Error processing original source shown below
        '    return;
        '   ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
        '-------------------------------------^--- Syntax error: ';' expected
        Me.textLog.Text += c.Name + "'s SelectionChangeCommitted. New index is:" + c.SelectedIndex.ToString() + vbCr + vbLf
    End Sub 'combo_SelectionChangeCommitted


    Private Sub combo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles multiColumnBoundCombo.Validated
        If Me.textLog Is Nothing Then
            Return
        End If
        Dim c As ComboBoxBaseDataBound = sender '
        'ToDo: Error processing original source shown below
        '
        '   ComboBoxBaseDataBound c = sender as ComboBoxBaseDataBound;
        '-------------------------------------^--- Syntax error: ';' expected
        If Not (c.SelectedItem Is Nothing) Then
            Me.textLog.Text += c.Name + "has validated the new entry. New entry is:" + c.SelectedItem.ToString() + vbCr + vbLf
        Else
            Me.textLog.Text += c.Name + "has validated the new entry. New entry is:" + c.Text + vbCr + vbLf
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
        '-------------------------------------^--- Syntax error: ';' expected
        If Not (c.SelectedItem Is Nothing) Then
            Me.textLog.Text += c.Name + "is validating the new entry:" + c.SelectedItem.ToString() + vbCr + vbLf
        Else
            Me.textLog.Text += c.Name + "is validating the new entry:" + c.Text + vbCr + vbLf
        End If
    End Sub 'combo_Validating
#End Region

End Class 'MultiColumnComboBoxSampleControl '

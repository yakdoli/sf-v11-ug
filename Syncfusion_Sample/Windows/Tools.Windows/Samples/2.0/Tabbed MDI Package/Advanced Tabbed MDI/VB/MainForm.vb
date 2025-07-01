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
Imports System.Data

Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms

'/ <summary>
'/ Summary description for MainForm.
'/ </summary>

Public Class MainForm
    Inherits Office2007Form
   Private splitter1 As System.Windows.Forms.Splitter
   Private panel1 As System.Windows.Forms.Panel
   Private label1 As System.Windows.Forms.Label
   Private label2 As System.Windows.Forms.Label
    Private WithEvents customerChoices As ComboBoxAdv
    Private WithEvents orderChoices As ComboBoxAdv
   Private customerForms As ArrayList
   Private orderForms As ArrayList
    Private WithEvents tabbedMDIManager As TabbedGroupedMDIManager
    Private WithEvents gradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents GradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents ButtonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        ' Initialize the forms list in the comboboxes.
        Me.customerForms = New ArrayList(Me.customerChoices.Items.Count)
        Dim i As Integer
        For i = 0 To (Me.customerChoices.Items.Count) - 1
            Me.customerForms.Add(Nothing)
        Next i
        Me.orderForms = New ArrayList(Me.orderChoices.Items.Count)
        For i = 0 To (Me.orderChoices.Items.Count) - 1
            Me.orderForms.Add(Nothing)
        Next i
        ' Initialize the tabbed MDI manager
        Me.tabbedMDIManager = New TabbedGroupedMDIManager
        Me.tabbedMDIManager.AllowTabGroupCustomizing = False
        Me.tabbedMDIManager.Horizontal = True
        Me.tabbedMDIManager.DropDownButtonVisible = True
        Me.tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.tabbedMDIManager.CloseItem.ImageList = Me.ImageList1
        Me.tabbedMDIManager.CloseItem.ImageIndex = 0
    End Sub 'New


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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Friend WithEvents GradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Private components As System.ComponentModel.IContainer
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.splitter1 = New System.Windows.Forms.Splitter
        Me.panel1 = New System.Windows.Forms.Panel
        Me.GradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
        Me.GradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
        Me.orderChoices = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.customerChoices = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Me.ButtonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel
        Me.label3 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.panel1.SuspendLayout()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel1.SuspendLayout()
        CType(Me.GradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel2.SuspendLayout()
        CType(Me.orderChoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerChoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gradientPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitter1
        '
        Me.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.splitter1.Location = New System.Drawing.Point(169, 0)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(2, 389)
        Me.splitter1.TabIndex = 2
        Me.splitter1.TabStop = False
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.GradientPanel1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(169, 389)
        Me.panel1.TabIndex = 3
        '
        'GradientPanel1
        '
        Me.GradientPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.GradientPanel1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None
        Me.GradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GradientPanel1.Controls.Add(Me.GradientPanel2)
        Me.GradientPanel1.Controls.Add(Me.ButtonAdv1)
        Me.GradientPanel1.Controls.Add(Me.gradientPanel3)
        Me.GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(169, 389)
        Me.GradientPanel1.TabIndex = 7
        '
        'GradientPanel2
        '
        Me.GradientPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GradientPanel2.Controls.Add(Me.orderChoices)
        Me.GradientPanel2.Controls.Add(Me.label1)
        Me.GradientPanel2.Controls.Add(Me.label2)
        Me.GradientPanel2.Controls.Add(Me.customerChoices)
        Me.GradientPanel2.Location = New System.Drawing.Point(8, 76)
        Me.GradientPanel2.Name = "GradientPanel2"
        Me.GradientPanel2.Size = New System.Drawing.Size(149, 176)
        Me.GradientPanel2.TabIndex = 6
        '
        'orderChoices
        '
        Me.orderChoices.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.orderChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.orderChoices.IgnoreThemeBackground = True
        Me.orderChoices.Items.AddRange(New Object() {"Order 1", "Order 2", "Order 3", "Order 4", "Order 5"})
        Me.orderChoices.Location = New System.Drawing.Point(15, 133)
        Me.orderChoices.Name = "orderChoices"
        Me.orderChoices.Size = New System.Drawing.Size(104, 21)
        Me.orderChoices.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.orderChoices.SuppressDropDownEvent = False
        Me.orderChoices.TabIndex = 3
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.label1.Location = New System.Drawing.Point(15, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(112, 40)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Show Customer info in Customers tab group:"
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.label2.Location = New System.Drawing.Point(15, 93)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(104, 32)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Show Orders in Orders tab group:"
        '
        'customerChoices
        '
        Me.customerChoices.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.customerChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.customerChoices.IgnoreThemeBackground = True
        Me.customerChoices.Items.AddRange(New Object() {"Customer 1", "Customer 2", "Customer 3", "Customer 4", "Customer 5"})
        Me.customerChoices.Location = New System.Drawing.Point(15, 53)
        Me.customerChoices.Name = "customerChoices"
        Me.customerChoices.Size = New System.Drawing.Size(104, 21)
        Me.customerChoices.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.customerChoices.SuppressDropDownEvent = False
        Me.customerChoices.TabIndex = 1
        '
        'ButtonAdv1
        '
        Me.ButtonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.ButtonAdv1.Location = New System.Drawing.Point(24, 293)
        Me.ButtonAdv1.Name = "ButtonAdv1"
        Me.ButtonAdv1.Size = New System.Drawing.Size(101, 29)
        Me.ButtonAdv1.TabIndex = 0
        Me.ButtonAdv1.Text = "Custom Weights"
        Me.ButtonAdv1.UseVisualStyle = True
        '
        'gradientPanel3
        '
        Me.gradientPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gradientPanel3.Controls.Add(Me.label3)
        Me.gradientPanel3.Location = New System.Drawing.Point(8, 12)
        Me.gradientPanel3.Name = "gradientPanel3"
        Me.gradientPanel3.Size = New System.Drawing.Size(149, 49)
        Me.gradientPanel3.TabIndex = 6
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.label3.Location = New System.Drawing.Point(0, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(150, 42)
        Me.label3.TabIndex = 0
        Me.label3.Text = "This sample shows you how " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to associate child forms " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to specific tab groups."
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 389)
        Me.Controls.Add(Me.splitter1)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advanced Tabbed MDI "
        Me.panel1.ResumeLayout(False)
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel1.ResumeLayout(False)
        CType(Me.GradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel2.ResumeLayout(False)
        CType(Me.orderChoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerChoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gradientPanel3.ResumeLayout(False)
        Me.gradientPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New MainForm())
    End Sub 'Main

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.tabbedMDIManager.AttachToMdiContainer(Me)
        ' Specifiy the tab groups:
        Me.tabbedMDIManager.TabbedGroups.Add(New TabbedGroup("Customers"))
        Me.tabbedMDIManager.TabbedGroups.Add(New TabbedGroup("Orders"))
    End Sub 'MainForm_Load

    ' Creating customer type child forms
    Private Function CreateCustomerInfoForm(ByVal [text] As String) As CustomerInfoForm
        Dim form As New CustomerInfoForm([text])

        ' Add the CustomerInfoForm to a specific group.
        Me.tabbedMDIManager.TabbedGroups("Customers").AddForm(form)
        Return form
    End Function 'CreateCustomerInfoForm

    ' Creating order type chid forms
    Private Function CreateOrderInfoForm(ByVal [text] As String) As OrderInfoForm
        Dim form As New OrderInfoForm([text])

        ' Add the OrderInfoForm to a specific group.
        Me.tabbedMDIManager.TabbedGroups("Orders").AddForm(form)
        Return form
    End Function 'CreateOrderInfoForm

    ' User wanted to show a customer form
    Private Sub customerChoices_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles customerChoices.SelectionChangeCommitted
        ' Verify if a Form exists already...
        Dim existingForm As Form = Me.customerForms(Me.customerChoices.SelectedIndex) '
        'ToDo: Error processing original source shown below
        '   return form;
        '  }
        '-------------------------------------------------------------------------------^--- Syntax error: ';' expected
        ' Ensure that the Form is not disposed.
        If Not (existingForm Is Nothing) AndAlso existingForm.IsDisposed Then
            Me.customerForms(Me.customerChoices.SelectedIndex) = Nothing
            existingForm = Nothing
        End If

        ' Create a new form if not already available.
        If existingForm Is Nothing Then
            Me.customerForms(Me.customerChoices.SelectedIndex) = Me.CreateCustomerInfoForm(Me.customerChoices.SelectedItem.ToString())
        End If

        Dim form As Form = Me.customerForms(Me.customerChoices.SelectedIndex) '
        'ToDo: Error processing original source shown below
        '   }
        '   
        '-----------------------------------------------------------------------^--- Syntax error: ';' expected
        form.Activate()
    End Sub 'customerChoices_SelectedIndexChanged

    ' User wanted to show a order form
    Private Sub orderChoices_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles orderChoices.SelectionChangeCommitted
        ' Verify if a Form exists already...
        Dim existingForm As Form = Me.orderForms(Me.orderChoices.SelectedIndex) '
        'ToDo: Error processing original source shown below
        '   form.Activate();
        '  }
        '-------------------------------------------------------------------------^--- Syntax error: ';' expected
        ' Ensure that the Form is not disposed.
        If Not (existingForm Is Nothing) AndAlso existingForm.IsDisposed Then
            Me.orderForms(Me.orderChoices.SelectedIndex) = Nothing
            existingForm = Nothing
        End If

        ' Create a new form if not already available.
        If existingForm Is Nothing Then
            Me.orderForms(Me.orderChoices.SelectedIndex) = Me.CreateOrderInfoForm(Me.orderChoices.SelectedItem.ToString())
        End If

        Dim form As Form = Me.orderForms(Me.orderChoices.SelectedIndex) '

        form.Activate()
    End Sub 'orderChoices_SelectedIndexChanged

    ' Optionally, you can maximize a tab group when a child form gets activated by the user.
    Protected Overrides Sub OnMdiChildActivate(ByVal e As EventArgs)
        ' Sometimes the tab host might be activated; ignore such cases.
        If Not (Me.ActiveMdiChild Is Nothing) AndAlso Not TypeOf (Me.ActiveMdiChild) Is TabHost Then
            ' Get the corresponding tab host.
            Dim tabHost As TabHost = Me.tabbedMDIManager.GetTabHostFromForm(Me.ActiveMdiChild)
            ' If the group is "minimized" (weight 0) then,
            ' make the group containing this Form occupy the maximum area.
            If tabHost.MdiChildAutoScaleBaseDim = 0 Then
                Me.tabbedMDIManager.MaximizeTabGroup(tabHost)
            End If
        End If
        MyBase.OnMdiChildActivate(e)
    End Sub 'OnMdiChildActivate


    Private Sub tabbedMDIManager_BeforeDropDownPopup(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.DropDownPopupEventArgs) Handles TabbedMDIManager.BeforeDropDownPopup
        e.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
    End Sub

    Private Sub tabbedMDIManager_TabControlAdded(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventArgs) Handles TabbedMDIManager.TabControlAdded
        args.TabControl.TabStyle = GetType(TabRendererOffice2007)
        args.TabControl.TabPanelBackColor = Color.White
        args.TabControl.TabGap = 10
    End Sub

    ' Set custom weights for tab groups:

    Private Sub ButtonAdv1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv1.Click
        
        Me.tabbedMDIManager.SetTabGroupWeights()
    End Sub
End Class 'MainForm
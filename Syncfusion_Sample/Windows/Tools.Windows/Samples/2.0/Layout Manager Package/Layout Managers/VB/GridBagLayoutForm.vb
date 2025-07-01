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

Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms.Tools
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Resources
Imports System.Windows.Forms

Namespace LayoutManagers
    Public Class GridBagLayoutForm
        Inherits Form
        Private WithEvents panel1 As Panel
        Private WithEvents propertyGrid1 As PropertyGrid
        Private WithEvents comboBox1 As ComboBox
        Private WithEvents button1 As Button
        Private WithEvents selected As GridBagLayoutForm.ConstraintsContainer
        Private WithEvents button2 As Button
        Private WithEvents gridBagLayout1 As GridBagLayout
        Private WithEvents button3 As Button
        Private WithEvents button4 As Button
        Private WithEvents button5 As Button
        Private WithEvents button6 As Button
        Private WithEvents button7 As Button
        Private WithEvents label1 As Label
        Private components As IContainer
        'Fields
        'Constructors
        'Events
        'Methods
        'Nested Types
        Public Sub New()
            MyBase.New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Me.selected = New ConstraintsContainer()

        End Sub
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

            If disposing Then
                If (Not (components) Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)

        End Sub
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GridBagLayoutForm))
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.label1 = New System.Windows.Forms.Label()
            Me.button6 = New System.Windows.Forms.Button()
            Me.button5 = New System.Windows.Forms.Button()
            Me.button4 = New System.Windows.Forms.Button()
            Me.button3 = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button7 = New System.Windows.Forms.Button()
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
            Me.gridBagLayout1 = New Syncfusion.Windows.Forms.Tools.GridBagLayout(Me.components)
            Me.panel1.SuspendLayout()
            CType(Me.gridBagLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1, Me.button6, Me.button5, Me.button4, Me.button3, Me.button1, Me.button2, Me.button7})
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(280, 292)
            Me.panel1.TabIndex = 0
            '
            'label1
            '
            Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridBagLayout1.SetConstraints(Me.label1, New Syncfusion.Windows.Forms.Tools.GridBagConstraints(-1, -1, 1, 1, 0, 0, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.None, New Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, True))
            Me.label1.Location = New System.Drawing.Point(8, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(256, 16)
            Me.label1.TabIndex = 7
            Me.label1.Text = "This Heading Label doesn't participate in Layout:"
            '
            'button6
            '
            Me.button6.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.gridBagLayout1.SetConstraints(Me.button6, New Syncfusion.Windows.Forms.Tools.GridBagConstraints(1, 3, 1, 1, 0.60000002384185791, 0.10000000149011612, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, New Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, False))
            Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button6.ForeColor = System.Drawing.Color.Black
            Me.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button6.Location = New System.Drawing.Point(54, 207)
            Me.gridBagLayout1.SetMinimumSize(Me.button6, New System.Drawing.Size(0, 0))
            Me.button6.Name = "button6"
            Me.gridBagLayout1.SetPreferredSize(Me.button6, New System.Drawing.Size(0, 0))
            Me.button6.Size = New System.Drawing.Size(170, 26)
            Me.button6.TabIndex = 5
            Me.button6.Text = "Span (1, 1), Pos (1, 3)"
            '
            'button5
            '
            Me.button5.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.gridBagLayout1.SetConstraints(Me.button5, New Syncfusion.Windows.Forms.Tools.GridBagConstraints(1, 2, 1, 1, 0.60000002384185791, 0.40000000596046448, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, New Syncfusion.Windows.Forms.Tools.Insets(10, 10, 10, 10), 0, 0, False))
            Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button5.ForeColor = System.Drawing.Color.Black
            Me.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button5.Location = New System.Drawing.Point(64, 93)
            Me.gridBagLayout1.SetMinimumSize(Me.button5, New System.Drawing.Size(0, 0))
            Me.button5.Name = "button5"
            Me.gridBagLayout1.SetPreferredSize(Me.button5, New System.Drawing.Size(0, 0))
            Me.button5.Size = New System.Drawing.Size(150, 104)
            Me.button5.TabIndex = 4
            Me.button5.Text = "Span (1, 1), Pos (1, 2)"
            '
            'button4
            '
            Me.button4.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.gridBagLayout1.SetConstraints(Me.button4, New Syncfusion.Windows.Forms.Tools.GridBagConstraints(2, 1, 1, 3, 0.20000000298023224, 0.60000002384185791, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, New Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, False))
            Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button4.ForeColor = System.Drawing.Color.Black
            Me.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button4.Location = New System.Drawing.Point(224, 57)
            Me.gridBagLayout1.SetMinimumSize(Me.button4, New System.Drawing.Size(0, 0))
            Me.button4.Name = "button4"
            Me.gridBagLayout1.SetPreferredSize(Me.button4, New System.Drawing.Size(0, 0))
            Me.button4.Size = New System.Drawing.Size(49, 176)
            Me.button4.TabIndex = 3
            Me.button4.Text = "Span (1, 3), Pos (2, 1)"
            '
            'button3
            '
            Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.gridBagLayout1.SetConstraints(Me.button3, New Syncfusion.Windows.Forms.Tools.GridBagConstraints(1, 1, 1, 1, 0.60000002384185791, 0.10000000149011612, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, New Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, False))
            Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button3.ForeColor = System.Drawing.Color.Black
            Me.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button3.Location = New System.Drawing.Point(54, 57)
            Me.gridBagLayout1.SetMinimumSize(Me.button3, New System.Drawing.Size(0, 0))
            Me.button3.Name = "button3"
            Me.gridBagLayout1.SetPreferredSize(Me.button3, New System.Drawing.Size(0, 0))
            Me.button3.Size = New System.Drawing.Size(170, 26)
            Me.button3.TabIndex = 2
            Me.button3.Text = "Span (1, 1), Pos (1, 1)"
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.gridBagLayout1.SetConstraints(Me.button1, New Syncfusion.Windows.Forms.Tools.GridBagConstraints(0, 0, 3, 1, 1, 0.20000000298023224, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, New Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, False))
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.Black
            Me.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button1.Location = New System.Drawing.Point(5, 5)
            Me.gridBagLayout1.SetMinimumSize(Me.button1, New System.Drawing.Size(0, 0))
            Me.button1.Name = "button1"
            Me.gridBagLayout1.SetPreferredSize(Me.button1, New System.Drawing.Size(0, 0))
            Me.button1.Size = New System.Drawing.Size(268, 52)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Span (3 , 1), Pos (0, 0)"
            '
            'button2
            '
            Me.button2.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.gridBagLayout1.SetConstraints(Me.button2, New Syncfusion.Windows.Forms.Tools.GridBagConstraints(0, 1, 1, 3, 0.20000000298023224, 0.60000002384185791, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, New Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, False))
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.ForeColor = System.Drawing.Color.Black
            Me.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button2.Location = New System.Drawing.Point(5, 57)
            Me.gridBagLayout1.SetMinimumSize(Me.button2, New System.Drawing.Size(0, 0))
            Me.button2.Name = "button2"
            Me.gridBagLayout1.SetPreferredSize(Me.button2, New System.Drawing.Size(0, 0))
            Me.button2.Size = New System.Drawing.Size(49, 176)
            Me.button2.TabIndex = 1
            Me.button2.Text = "Span (1, 3), Pos (0, 1)"
            '
            'button7
            '
            Me.button7.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.gridBagLayout1.SetConstraints(Me.button7, New Syncfusion.Windows.Forms.Tools.GridBagConstraints(0, 4, 3, 1, 1, 0.20000000298023224, Syncfusion.Windows.Forms.Tools.AnchorTypes.Center, Syncfusion.Windows.Forms.Tools.FillType.Both, New Syncfusion.Windows.Forms.Tools.Insets(0, 0, 0, 0), 0, 0, False))
            Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button7.ForeColor = System.Drawing.Color.Black
            Me.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button7.Location = New System.Drawing.Point(5, 233)
            Me.gridBagLayout1.SetMinimumSize(Me.button7, New System.Drawing.Size(0, 0))
            Me.button7.Name = "button7"
            Me.gridBagLayout1.SetPreferredSize(Me.button7, New System.Drawing.Size(0, 0))
            Me.button7.Size = New System.Drawing.Size(268, 52)
            Me.button7.TabIndex = 6
            Me.button7.Text = "Span (3 , 1), Pos (0, 4)"
            '
            'comboBox1
            '
            Me.comboBox1.Dock = System.Windows.Forms.DockStyle.Right
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.DropDownWidth = 176
            Me.comboBox1.ItemHeight = 13
            Me.comboBox1.Location = New System.Drawing.Point(280, 0)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(184, 21)
            Me.comboBox1.TabIndex = 2
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.propertyGrid1.CommandsVisibleIfAvailable = True
            Me.propertyGrid1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.propertyGrid1.LargeButtons = False
            Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
            Me.propertyGrid1.Location = New System.Drawing.Point(280, 24)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(184, 264)
            Me.propertyGrid1.TabIndex = 1
            Me.propertyGrid1.Text = "propertyGrid1"
            Me.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window
            Me.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText
            '
            'gridBagLayout1
            '
            Me.gridBagLayout1.BottomMargin = 4
            Me.gridBagLayout1.ContainerControl = Me.panel1
            Me.gridBagLayout1.HorzFarMargin = 4
            Me.gridBagLayout1.HorzNearMargin = 4
            Me.gridBagLayout1.TopMargin = 4
            '
            'GridBagLayoutForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(464, 293)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.comboBox1, Me.propertyGrid1, Me.panel1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "GridBagLayoutForm"
            Me.Text = "GridBagLayout"
            Me.panel1.ResumeLayout(False)
            CType(Me.gridBagLayout1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private Sub GridBagLayoutForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ' Initialization for showing the associated constraints in the property grid.
            Dim control As Control
            For Each control In Me.panel1.Controls
                Me.comboBox1.Items.Add(control)
            Next
            Me.comboBox1.DisplayMember = "Text"
            Me.comboBox1.SelectedIndex = 0

            ' Sample Code Block to illustrate initialization without designer.
            ' Adds 2 components to the gridBagLayout.
            '
            If (False) Then
                ' <samplecodeblock name="Initializing GridBagLayout">
                ' Binding a Control to the GridBagLayout manager programaitcally
                'Me.gridBagLayout1 = New GridBagLayout()

                '' Set the target control; all the child controls of this target control are
                '' automatically registered as children with the manager.
                'Me.gridBagLayout1.ContainerControl = Me.panel1
                'Me.gridBagLayout1.SetConstraints(Me.button1, New GridBagConstraints(0, 0, 3, 1, 1, 0.2, AnchorTypes.Center, FillType.Both, New Insets(0, 0, 0, 0), 0, 0, False))
                'Me.gridBagLayout1.SetConstraints(Me.button2, New GridBagConstraints(0, 1, 1, 3, 0.2, 0.6, AnchorTypes.Center, FillType.Both, New Insets(0, 0, 0, 0), 0, 0, False))
                '' Exclude button3 from layout
                'Me.gridBagLayout1.SetConstraints(Me.button3, GridBagConstraints.Empty)

                '' Modify an exisiting constraint.
                'Dim constraints1 As GridBagConstraints
                'constraints1 = Me.gridBagLayout1.GetConstraintsRef(Me.button1)
                'constraints1.Fill = FillType.Horizontal

                ' You can prevent automatic layout during the layout event:
                ' If you decide to do so, make sure to call gridBagLayout1.LayoutContainer manually.
                ' this.gridBagLayout1.AutoLayout = false;</code></coderef>
            End If
            ' </samplecodeblock>
        End Sub
        Private Sub SetButtonText(ByVal component As Control)

            Dim gbc As GridBagConstraints
            gbc = Me.gridBagLayout1.GetConstraints(component)
            component.Text = CType(TypeDescriptor.GetConverter(GetType(GridBagConstraints)).ConvertTo(gbc, GetType(System.String)), String)

        End Sub
        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged

            Me.selected.GridBagConstraints = Me.gridBagLayout1.GetConstraintsRef(CType(Me.comboBox1.SelectedItem, Control))
            Me.propertyGrid1.SelectedObject = Me.selected
            Me.propertyGrid1.ExpandAllGridItems()

        End Sub
        Private Sub Constraints_Changed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PropertyValueChangedEventArgs) Handles propertyGrid1.PropertyValueChanged

            Me.gridBagLayout1.SetConstraints(CType(Me.comboBox1.SelectedItem, Control), Me.selected.GridBagConstraints)

        End Sub
        Public Class ConstraintsContainer
            Inherits Component
            Private _gridBagConstraints As GridBagConstraints
            'Fields
            'Constructors
            'Events
            'Methods
            Public Sub New()
                'Warning: Implementation not found
            End Sub
            Public Property GridBagConstraints() As GridBagConstraints
                Get

                    Return Me._gridBagConstraints

                End Get
                Set(ByVal Value As GridBagConstraints)

                    Me._gridBagConstraints = Value

                End Set
            End Property
        End Class
    End Class
End Namespace

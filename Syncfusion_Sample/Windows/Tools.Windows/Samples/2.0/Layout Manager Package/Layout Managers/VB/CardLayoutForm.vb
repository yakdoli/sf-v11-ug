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
    Public Class CardLayoutForm
        Inherits Form
        Private WithEvents cardLayout1 As CardLayout
        Private WithEvents panel1 As Panel
        Private WithEvents label1 As Label
        Private WithEvents label2 As Label
        Private WithEvents label3 As Label
        Private WithEvents label4 As Label
        Private WithEvents label5 As Label
        Private WithEvents label6 As Label
        Private WithEvents label7 As Label
        Private WithEvents label8 As Label
        Private WithEvents label9 As Label
        Private WithEvents label10 As Label
        Private WithEvents panel2 As Panel
        Private WithEvents comboBox1 As ComboBox
        Private WithEvents label11 As Label
        Private WithEvents moveNext As Button
        Private WithEvents movePrevious As Button
        Private components As IContainer
        'Fields
        'Constructors
        'Events
        'Methods
        Public Sub New()
            MyBase.New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '

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
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CardLayoutForm))
            Me.cardLayout1 = New Syncfusion.Windows.Forms.Tools.CardLayout(Me.components)
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label10 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label9 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.label11 = New System.Windows.Forms.Label()
            Me.moveNext = New System.Windows.Forms.Button()
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.movePrevious = New System.Windows.Forms.Button()
            CType(Me.cardLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'cardLayout1
            '
            Me.cardLayout1.ContainerControl = Me.panel1
            Me.cardLayout1.SelectedCard = "Card2"
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1, Me.label2, Me.label3, Me.label4, Me.label5, Me.label6, Me.label7, Me.label8, Me.label9, Me.label10})
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(456, 316)
            Me.panel1.TabIndex = 0
            '
            'label2
            '
            Me.cardLayout1.SetCardName(Me.label2, "Card2")
            Me.label2.Image = CType(resources.GetObject("label2.Image"), System.Drawing.Bitmap)
            Me.label2.Location = New System.Drawing.Point(177, 107)
            Me.cardLayout1.SetMinimumSize(Me.label2, New System.Drawing.Size(100, 100))
            Me.label2.Name = "label2"
            Me.cardLayout1.SetPreferredSize(Me.label2, New System.Drawing.Size(100, 100))
            Me.label2.Size = New System.Drawing.Size(100, 100)
            Me.label2.TabIndex = 1
            Me.label2.Visible = False
            '
            'label5
            '
            Me.cardLayout1.SetCardName(Me.label5, "Card5")
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Bitmap)
            Me.label5.Location = New System.Drawing.Point(177, 107)
            Me.cardLayout1.SetMinimumSize(Me.label5, New System.Drawing.Size(100, 100))
            Me.label5.Name = "label5"
            Me.cardLayout1.SetPreferredSize(Me.label5, New System.Drawing.Size(100, 100))
            Me.label5.Size = New System.Drawing.Size(100, 100)
            Me.label5.TabIndex = 4
            Me.label5.Visible = False
            '
            'label3
            '
            Me.cardLayout1.SetCardName(Me.label3, "Card3")
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Bitmap)
            Me.label3.Location = New System.Drawing.Point(172, 102)
            Me.cardLayout1.SetMinimumSize(Me.label3, New System.Drawing.Size(110, 110))
            Me.label3.Name = "label3"
            Me.cardLayout1.SetPreferredSize(Me.label3, New System.Drawing.Size(110, 110))
            Me.label3.Size = New System.Drawing.Size(110, 110)
            Me.label3.TabIndex = 2
            Me.label3.Visible = False
            '
            'label10
            '
            Me.cardLayout1.SetCardName(Me.label10, "Card10")
            Me.label10.Image = CType(resources.GetObject("label10.Image"), System.Drawing.Bitmap)
            Me.label10.Location = New System.Drawing.Point(189, 119)
            Me.cardLayout1.SetMinimumSize(Me.label10, New System.Drawing.Size(75, 75))
            Me.label10.Name = "label10"
            Me.cardLayout1.SetPreferredSize(Me.label10, New System.Drawing.Size(75, 75))
            Me.label10.Size = New System.Drawing.Size(75, 75)
            Me.label10.TabIndex = 9
            Me.label10.Visible = False
            '
            'label6
            '
            Me.cardLayout1.SetCardName(Me.label6, "Card6")
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Bitmap)
            Me.label6.Location = New System.Drawing.Point(202, 132)
            Me.cardLayout1.SetMinimumSize(Me.label6, New System.Drawing.Size(50, 50))
            Me.label6.Name = "label6"
            Me.cardLayout1.SetPreferredSize(Me.label6, New System.Drawing.Size(50, 50))
            Me.label6.Size = New System.Drawing.Size(50, 50)
            Me.label6.TabIndex = 5
            Me.label6.Visible = False
            '
            'label9
            '
            Me.cardLayout1.SetCardName(Me.label9, "Card9")
            Me.label9.Image = CType(resources.GetObject("label9.Image"), System.Drawing.Bitmap)
            Me.label9.Location = New System.Drawing.Point(192, 107)
            Me.cardLayout1.SetMinimumSize(Me.label9, New System.Drawing.Size(70, 100))
            Me.label9.Name = "label9"
            Me.cardLayout1.SetPreferredSize(Me.label9, New System.Drawing.Size(70, 100))
            Me.label9.Size = New System.Drawing.Size(70, 100)
            Me.label9.TabIndex = 8
            Me.label9.Visible = False
            '
            'label8
            '
            Me.cardLayout1.SetCardName(Me.label8, "Card8")
            Me.label8.Image = CType(resources.GetObject("label8.Image"), System.Drawing.Bitmap)
            Me.label8.Location = New System.Drawing.Point(192, 122)
            Me.cardLayout1.SetMinimumSize(Me.label8, New System.Drawing.Size(70, 70))
            Me.label8.Name = "label8"
            Me.cardLayout1.SetPreferredSize(Me.label8, New System.Drawing.Size(70, 70))
            Me.label8.Size = New System.Drawing.Size(70, 70)
            Me.label8.TabIndex = 7
            Me.label8.Visible = False
            '
            'label1
            '
            Me.cardLayout1.SetCardName(Me.label1, "Card1")
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Bitmap)
            Me.label1.Location = New System.Drawing.Point(189, 119)
            Me.cardLayout1.SetMinimumSize(Me.label1, New System.Drawing.Size(75, 75))
            Me.label1.Name = "label1"
            Me.cardLayout1.SetPreferredSize(Me.label1, New System.Drawing.Size(75, 75))
            Me.label1.Size = New System.Drawing.Size(75, 75)
            Me.label1.TabIndex = 0
            '
            'label4
            '
            Me.cardLayout1.SetCardName(Me.label4, "Card4")
            Me.label4.Image = CType(resources.GetObject("label4.Image"), System.Drawing.Bitmap)
            Me.label4.Location = New System.Drawing.Point(189, 119)
            Me.cardLayout1.SetMinimumSize(Me.label4, New System.Drawing.Size(75, 75))
            Me.label4.Name = "label4"
            Me.cardLayout1.SetPreferredSize(Me.label4, New System.Drawing.Size(75, 75))
            Me.label4.Size = New System.Drawing.Size(75, 75)
            Me.label4.TabIndex = 3
            Me.label4.Visible = False
            '
            'label7
            '
            Me.cardLayout1.SetCardName(Me.label7, "Card7")
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Bitmap)
            Me.label7.Location = New System.Drawing.Point(194, 124)
            Me.cardLayout1.SetMinimumSize(Me.label7, New System.Drawing.Size(65, 65))
            Me.label7.Name = "label7"
            Me.cardLayout1.SetPreferredSize(Me.label7, New System.Drawing.Size(65, 65))
            Me.label7.Size = New System.Drawing.Size(65, 65)
            Me.label7.TabIndex = 6
            Me.label7.Visible = False
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.Moccasin
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.label11, Me.moveNext, Me.comboBox1, Me.movePrevious})
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(456, 24)
            Me.panel2.TabIndex = 1
            '
            'label11
            '
            Me.label11.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label11.Location = New System.Drawing.Point(8, 4)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(88, 14)
            Me.label11.TabIndex = 3
            Me.label11.Text = "Selected Card:"
            '
            'moveNext
            '
            Me.moveNext.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
            Me.moveNext.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.moveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.moveNext.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.moveNext.ForeColor = System.Drawing.Color.Black
            Me.moveNext.Location = New System.Drawing.Point(352, 0)
            Me.moveNext.Name = "moveNext"
            Me.moveNext.Size = New System.Drawing.Size(104, 22)
            Me.moveNext.TabIndex = 2
            Me.moveNext.Text = "Next Card >>"
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.Location = New System.Drawing.Point(96, 0)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(112, 21)
            Me.comboBox1.TabIndex = 1
            '
            'movePrevious
            '
            Me.movePrevious.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
            Me.movePrevious.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.movePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.movePrevious.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.movePrevious.ForeColor = System.Drawing.Color.Black
            Me.movePrevious.Location = New System.Drawing.Point(232, 0)
            Me.movePrevious.Name = "movePrevious"
            Me.movePrevious.Size = New System.Drawing.Size(120, 22)
            Me.movePrevious.TabIndex = 0
            Me.movePrevious.Text = "<< Previous Card"
            '
            'CardLayoutForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(456, 316)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel2, Me.panel1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "CardLayoutForm"
            Me.Text = "CardLayout"
            CType(Me.cardLayout1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As EventArgs)

            Me.cardLayout1.SelectedCard = Me.cardLayout1.GetCardName(Me.panel2)

        End Sub
        Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As EventArgs)

            Me.cardLayout1.SelectedCard = Me.cardLayout1.GetCardName(Me.panel1)

        End Sub
        Private Sub CardLayoutForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Dim cardName As String
            For Each cardName In Me.cardLayout1.GetCardNames
                Me.comboBox1.Items.Add(cardName)
            Next
            Me.comboBox1.SelectedIndex = 0
            ' Sample Code Block to illustrate initialization without designer.
            ' Repeats whatever the deisgner already did in InitializeComponent.
            '
            '// <samplecodeblock name="Initializing CardLayout">
            If (False) Then
                ' Binding a Control to the CardLayout manager programaitcally
                Me.cardLayout1 = New CardLayout

                ' Set the target control; all the child controls of this target control are
                ' automatically registered as children with the manager and get default card names.
                Me.cardLayout1.ContainerControl = Me.panel1

                ' Set custom card names to replace default card names.
                Me.cardLayout1.SetCardName(Me.label1, "MyCard1")

                ' To select a card manually, use the SelectedCard property
                Me.cardLayout1.SelectedCard = "MyCard1"

                ' Or move through the cards like this:
                Me.cardLayout1.Next()
                Me.cardLayout1.Previous()
                '// </samplecodeblock>
                '
            End If
        End Sub
        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged

            Me.cardLayout1.SelectedCard = Me.comboBox1.SelectedItem.ToString

        End Sub
        Private Sub movePrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles movePrevious.Click

            Me.cardLayout1.Previous()
            Me.comboBox1.SelectedItem = Me.cardLayout1.SelectedCard

        End Sub
        Private Sub moveNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles moveNext.Click

            Me.cardLayout1.Next()
            Me.comboBox1.SelectedItem = Me.cardLayout1.SelectedCard

        End Sub
    End Class
End Namespace

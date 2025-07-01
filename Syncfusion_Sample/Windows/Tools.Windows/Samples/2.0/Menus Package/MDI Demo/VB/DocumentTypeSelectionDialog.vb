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
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace XPMenusMDI
    Public Class DocumentTypeSelectionDialog
        Inherits Form
        Private WithEvents listBox1 As ListBox
        Private WithEvents okButton As Button
        Private WithEvents cancelButton_ As Button
        Private components As Container
 
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
        Public ReadOnly Property SelectedType() As Integer
            Get

                Return Me.listBox1.SelectedIndex

            End Get
        End Property
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

            If disposing Then
                If (Not (components) Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)

        End Sub
        Private Sub InitializeComponent()
            Me.listBox1 = New System.Windows.Forms.ListBox
            Me.okButton = New System.Windows.Forms.Button
            Me.cancelButton_ = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'listBox1
            '
            Me.listBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(213, Byte), Integer))
            Me.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.listBox1.Items.AddRange(New Object() {"Text Editor", "Image Editor"})
            Me.listBox1.Location = New System.Drawing.Point(8, 8)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(128, 43)
            Me.listBox1.TabIndex = 0
            '
            'okButton
            '
            Me.okButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.okButton.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.okButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.okButton.ForeColor = System.Drawing.Color.White
            Me.okButton.Location = New System.Drawing.Point(8, 64)
            Me.okButton.Name = "okButton"
            Me.okButton.Size = New System.Drawing.Size(64, 24)
            Me.okButton.TabIndex = 1
            Me.okButton.Text = "&OK"
            Me.okButton.UseVisualStyleBackColor = False
            '
            'cancelButton_
            '
            Me.cancelButton_.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.cancelButton_.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.cancelButton_.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cancelButton_.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cancelButton_.ForeColor = System.Drawing.Color.White
            Me.cancelButton_.Location = New System.Drawing.Point(80, 64)
            Me.cancelButton_.Name = "cancelButton_"
            Me.cancelButton_.Size = New System.Drawing.Size(56, 24)
            Me.cancelButton_.TabIndex = 2
            Me.cancelButton_.Text = "&Cancel"
            Me.cancelButton_.UseVisualStyleBackColor = False
            '
            'DocumentTypeSelectionDialog
            '
            Me.AcceptButton = Me.okButton
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.CancelButton = Me.cancelButton_
            Me.ClientSize = New System.Drawing.Size(144, 93)
            Me.ControlBox = False
            Me.Controls.Add(Me.cancelButton_)
            Me.Controls.Add(Me.okButton)
            Me.Controls.Add(Me.listBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "DocumentTypeSelectionDialog"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Document Type"
            Me.ResumeLayout(False)

        End Sub
        Private Sub DocumentTypeSelectionDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.listBox1.SelectedIndex = 0

        End Sub
        Private Sub listBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listBox1.DoubleClick

            Me.okButton.PerformClick()

        End Sub

        Private Sub listBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles listBox1.DrawItem
            e.DrawBackground()
            Dim myBrush As Brush = Brushes.Black
            Select Case e.Index
                Case 0
                    myBrush = Brushes.MidnightBlue
                Case 1
                    myBrush = Brushes.Brown

            End Select
            e.Graphics.DrawString(Me.listBox1.Items(e.Index), e.Font, myBrush, e.Bounds.X, e.Bounds.Y, StringFormat.GenericDefault)

        End Sub
    End Class
End Namespace

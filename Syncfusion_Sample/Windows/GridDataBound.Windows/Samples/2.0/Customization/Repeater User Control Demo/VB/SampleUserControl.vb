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
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms


Namespace SampleUserControl
   
   Public Class SampleUserControl
        Inherits CellUserControl
      Private label1 As System.Windows.Forms.Label
      Private WithEvents nameTextBox As System.Windows.Forms.TextBox
      Private label2 As System.Windows.Forms.Label
      Private label3 As System.Windows.Forms.Label
      Private WithEvents cityTextBox As System.Windows.Forms.TextBox
      Private WithEvents zipTextBox As System.Windows.Forms.TextBox
      Private titleLabel As System.Windows.Forms.Label
      
      Private components As System.ComponentModel.Container = Nothing
      
      
      Public Sub New()
         ' This call is required by the Windows.Forms Form Designer.
         InitializeComponent()
      End Sub 'New
       
      
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
            Me.label1 = New System.Windows.Forms.Label()
            Me.nameTextBox = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.cityTextBox = New System.Windows.Forms.TextBox()
            Me.zipTextBox = New System.Windows.Forms.TextBox()
            Me.titleLabel = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            ' 
            ' label1
            ' 
            Me.label1.Enabled = False
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
            Me.label1.Location = New System.Drawing.Point(10, 37)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(48, 23)
            Me.label1.TabIndex = 5
            Me.label1.Text = "Name :"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            ' 
            ' nameTextBox
            ' 
            Me.nameTextBox.Location = New System.Drawing.Point(72, 40)
            Me.nameTextBox.Name = "nameTextBox"
            Me.nameTextBox.Size = New System.Drawing.Size(272, 20)
            Me.nameTextBox.TabIndex = 0
            Me.nameTextBox.Text = "name"
            ' 
            ' label2
            ' 
            Me.label2.Enabled = False
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
            Me.label2.Location = New System.Drawing.Point(11, 68)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(48, 23)
            Me.label2.TabIndex = 4
            Me.label2.Text = "City :"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            ' 
            ' label3
            ' 
            Me.label3.Enabled = False
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
            Me.label3.Location = New System.Drawing.Point(227, 74)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(32, 16)
            Me.label3.TabIndex = 3
            Me.label3.Text = "Zip  :"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            ' 
            ' cityTextBox
            ' 
            Me.cityTextBox.Location = New System.Drawing.Point(71, 72)
            Me.cityTextBox.Name = "cityTextBox"
            Me.cityTextBox.Size = New System.Drawing.Size(152, 20)
            Me.cityTextBox.TabIndex = 1
            Me.cityTextBox.Text = "city"
            ' 
            ' zipTextBox
            ' 
            Me.zipTextBox.Location = New System.Drawing.Point(264, 72)
            Me.zipTextBox.Name = "zipTextBox"
            Me.zipTextBox.Size = New System.Drawing.Size(80, 20)
            Me.zipTextBox.TabIndex = 2
            Me.zipTextBox.Text = "zip"
            ' 
            ' titleLabel
            ' 
            Me.titleLabel.Enabled = False
            Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
            Me.titleLabel.Location = New System.Drawing.Point(32, 8)
            Me.titleLabel.Name = "titleLabel"
            Me.titleLabel.Size = New System.Drawing.Size(272, 24)
            Me.titleLabel.TabIndex = 6
            Me.titleLabel.Text = "Title"
            Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ' 
            ' SampleUserControl
            ' 
            Me.BackColor = System.Drawing.Color.FromArgb(CType(192, System.Byte), CType(201, System.Byte), CType(219, System.Byte))
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.label3, Me.titleLabel, Me.label2, Me.cityTextBox, Me.label1, Me.nameTextBox, Me.zipTextBox})
            Me.Name = "SampleUserControl"
            Me.Size = New System.Drawing.Size(352, 104)
            Me.ResumeLayout(False)
        End Sub 'InitializeComponent 
#End Region

#Region "Implementation of ICellUserControl"


        ' Assumes knowledge of the DataTable and where these
        ' fields are linked on this usercontrol.
        'dt.Columns.Add(new DataColumn("Name")) - nameTextBox;
        'dt.Columns.Add(new DataColumn("City")) - cityTextBox;
        'dt.Columns.Add(new DataColumn("Zip")) - zipTextBox;
        Public Overrides Function UserControlIsModified() As Boolean
            Return modified
        End Function 'UserControlIsModified


        'set values into this user control
        Public Overrides Sub UserControlSetValues(ByVal drv As DataRowView)
            modified = False
            Try
                'Console.WriteLine("UserControlSetValues");
                Me.nameTextBox.Text = CStr(drv("Name"))
                Me.cityTextBox.Text = CStr(drv("City"))
                Me.zipTextBox.Text = CStr(drv("Zip"))
            Catch
            End Try
            SetTitleLabel()
        End Sub 'UserControlSetValues


        'get values from this user control
        Public Overrides Sub UserControlGetValues(ByVal drv As DataRowView)
            'Console.WriteLine("UserControlGetValues");
            drv("Name") = Me.nameTextBox.Text
            drv("City") = Me.cityTextBox.Text
            drv("Zip") = Me.zipTextBox.Text
        End Sub 'UserControlGetValues 
#End Region

        Private modified As Boolean = False

        Private Sub userControl_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nameTextBox.TextChanged, cityTextBox.TextChanged, zipTextBox.TextChanged
            modified = True
            SetTitleLabel()
        End Sub 'userControl_ItemChanged


        'titleLable is being treated as an expression field that depend upon the bound entries
        'in a readonly way...
        Private Sub SetTitleLabel()
            Me.titleLabel.Text = Me.nameTextBox.Text + ", " + Me.cityTextBox.Text
        End Sub 'SetTitleLabel
    End Class 'SampleUserControl 
End Namespace 'SampleUserControl
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
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Imports Syncfusion.Calculate

Public Class MoreComplexForm
    Inherits System.Windows.Forms.Form
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private label5 As System.Windows.Forms.Label
    Private label6 As System.Windows.Forms.Label
    Private label7 As System.Windows.Forms.Label



    Private Total As System.Windows.Forms.TextBox
    Private Price As System.Windows.Forms.TextBox
    Private itemComboBox As System.Windows.Forms.ComboBox
    Private Quantity As System.Windows.Forms.TextBox
    Private Shipping As System.Windows.Forms.TextBox
    Private Tax As System.Windows.Forms.TextBox
    Private Discount As System.Windows.Forms.ComboBox

    Private components As System.ComponentModel.Container = Nothing


    Public Sub New()
        '
        ' Required for Windows Form Designer support.
        '
        InitializeComponent()
        Try
            Dim ico As Icon = New Icon(SelectForm.FindFile("Icon", "sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try
    End Sub 'New


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
    '/ Required method for Designer support; do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label5 = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label
        Me.Quantity = New System.Windows.Forms.TextBox
        Me.Shipping = New System.Windows.Forms.TextBox
        Me.Tax = New System.Windows.Forms.TextBox
        Me.Total = New System.Windows.Forms.TextBox
        Me.Price = New System.Windows.Forms.TextBox
        Me.itemComboBox = New System.Windows.Forms.ComboBox
        Me.Discount = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(56, 40)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(64, 23)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Item"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(56, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 23)
        Me.label2.TabIndex = 8
        Me.label2.Text = "Quantity"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(56, 120)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 23)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Price"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(56, 160)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(64, 23)
        Me.label4.TabIndex = 10
        Me.label4.Text = " Discount"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label5
        '
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(56, 200)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(64, 23)
        Me.label5.TabIndex = 11
        Me.label5.Text = "Shipping"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(56, 240)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(64, 23)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Tax"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label7
        '
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(56, 280)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(64, 23)
        Me.label7.TabIndex = 13
        Me.label7.Text = "Total"
        Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Quantity
        '
        Me.Quantity.Location = New System.Drawing.Point(128, 80)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(100, 20)
        Me.Quantity.TabIndex = 1
        '
        'Shipping
        '
        Me.Shipping.Location = New System.Drawing.Point(128, 200)
        Me.Shipping.Name = "Shipping"
        Me.Shipping.Size = New System.Drawing.Size(100, 20)
        Me.Shipping.TabIndex = 4
        '
        'Tax
        '
        Me.Tax.Location = New System.Drawing.Point(128, 240)
        Me.Tax.Name = "Tax"
        Me.Tax.Size = New System.Drawing.Size(100, 20)
        Me.Tax.TabIndex = 5
        '
        'Total
        '
        Me.Total.Location = New System.Drawing.Point(128, 280)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(100, 20)
        Me.Total.TabIndex = 6
        Me.Total.Text = "= ([Quantity] * [Price]) * (1-[Discount]) + [Shipping] + [Tax]"
        '
        'Price
        '
        Me.Price.Location = New System.Drawing.Point(128, 120)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(100, 20)
        Me.Price.TabIndex = 2
        Me.Price.Text = "0"
        '
        'itemComboBox
        '
        Me.itemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.itemComboBox.Items.AddRange(New Object() {"WidgetA", "WidgetB", "WidgetC"})
        Me.itemComboBox.Location = New System.Drawing.Point(128, 40)
        Me.itemComboBox.Name = "itemComboBox"
        Me.itemComboBox.Size = New System.Drawing.Size(104, 21)
        Me.itemComboBox.TabIndex = 0
        '
        'Discount
        '
        Me.Discount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Discount.Items.AddRange(New Object() {"1%", "2%", "3%", "5%", "10%", "20%"})
        Me.Discount.Location = New System.Drawing.Point(128, 160)
        Me.Discount.Name = "Discount"
        Me.Discount.Size = New System.Drawing.Size(121, 21)
        Me.Discount.TabIndex = 3
        '
        'MoreComplexForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(344, 350)
        Me.Controls.Add(Me.Discount)
        Me.Controls.Add(Me.itemComboBox)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Tax)
        Me.Controls.Add(Me.Shipping)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "MoreComplexForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "More Complex Form Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'InitializeComponent 
#End Region


    Private calculator As CalcQuick = Nothing


    Private Sub MoreComplexForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As String = Me.Quantity.Name

        'Initial settings done in the designer.

        'Instantiate a CalcQuick object:
        calculator = New CalcQuick()

        'Register the controls used in calculations.
        'The formula names used are the Control.Name strings.
        Me.calculator.RegisterControlArray(New Control() { _
                     Me.Quantity, _
                     Me.Price, _
                     Me.Discount, _
                     Me.Shipping, _
                     Me.Tax, _
                     Me.Total _
                    })
        'Allow the CalcQuick sheet to create dependency lists among the formula objects
        'necesary for auto-calculations and do the initial computations.
        Me.calculator.RefreshAllCalculations()
    End Sub 'MoreComplexForm_Load
End Class 'MoreComplexForm
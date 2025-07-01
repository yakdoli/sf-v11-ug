Imports Syncfusion.XlsIO
Imports System.Diagnostics

Public Class FormControls

#Region "Constants"
    Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Images\XlsIO\{0}"
#End Region

#Region "Initialize"
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.rdbExcel2013.Checked = True
        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region

#Region "Fields"
    Private fileName As String
    Private color1 As Color
    Private onlinePayments As String()
#End Region

#Region "Form Controls"
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        ' initiate the online payments
        onlinePayments = New String() {"Credit Card", "Net Banking"}

        ' New instance of XlsIO is created.(Equivalent to launching MS Excel with no workbooks open).
        ' The instantiation process consists of two steps.

        ' Step 1 : Instantiate the spreadsheet creation engine.
        Dim excelEngine As ExcelEngine = New ExcelEngine()
        ' Step 2 : Instantiate the excel application object.
        Dim application As IApplication = excelEngine.Excel

        ' Check if user opts for Excel 2007
        If Me.rdbExcel2007.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2007
            color1 = Color.FromArgb(255, 255, 230)
            ' Check if user opts for Excel 2010
        ElseIf Me.rdbExcel2010.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2010
            color1 = Color.FromArgb(255, 255, 230)
        ElseIf Me.rdbExcel2013.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2013
            color1 = Color.FromArgb(255, 255, 230)
        Else
            color1 = Color.FromArgb(255, 255, 204)
        End If

        ' A new workbook is created.(Equivalent to creating a new workbook in MS Excel)
        ' Workbook created with two worksheets
        Dim workbook As IWorkbook = application.Workbooks.Create(2)
        ' The first worksheet object in the worksheets collection is accessed.
        '(0 based index)
        Dim worksheet2 As IWorksheet = workbook.Worksheets(1)
        Dim i As Integer = 0
        'Assigning the array content to cells
        ' by passing row and column position 
        Do While i < onlinePayments.Length
            worksheet2.SetValue(i + 1, 1, onlinePayments(i))
            i += 1
        Loop

        ' The first worksheet object in the worksheets collection is accessed.
        Dim worksheet As IWorksheet = workbook.Worksheets(0)

        'Get the path of the Picture
        Dim inputPath As String = GetTemplatePath("contact_sales.gif")
        worksheet.Pictures.AddPicture(2, 3, inputPath)

        worksheet(4, 3).Text = "Phone"
        worksheet(4, 3).CellStyle.Font.Bold = True
        worksheet(5, 3).Text = "Toll Free"
        worksheet(5, 5).Text = "1-888-9DOTNET"
        worksheet(6, 5).Text = "1-888-936-8638"
        worksheet(7, 5).Text = "1-919-481-1974"
        worksheet(8, 3).Text = "Fax"
        worksheet(8, 5).Text = "1-919-573-0306"
        worksheet(9, 3).Text = "Email"
        worksheet(10, 3).Text = "Sales"

        'Creating the hyperlink in the 10th column and 
        '5th row of the sheet 
        Dim link As IHyperLink = worksheet.HyperLinks.Add(worksheet(10, 5))
        link.Type = ExcelHyperLinkType.Url
        link.Address = "mailto:sales@syncfusion.com"

        worksheet(12, 3).Text = "Please fill out all required fields."
        worksheet(14, 5).Text = "First Name*"
        worksheet(14, 5).CellStyle.Font.Bold = True
        worksheet(14, 8).Text = "Last Name*"
        worksheet(14, 8).CellStyle.Font.Bold = True

        'Create textbox for respective field
        'textbox to get First Name
        Dim textBoxShape As ITextBoxShape = worksheet.TextBoxes.AddTextBox(15, 5, 23, 190)
        textBoxShape.Fill.FillType = ExcelFillType.SolidColor
        textBoxShape.Fill.ForeColor = color1
        'textbox to get Last Name
        textBoxShape = worksheet.TextBoxes.AddTextBox(15, 8, 23, 195)
        textBoxShape.Fill.FillType = ExcelFillType.SolidColor
        textBoxShape.Fill.ForeColor = color1

        worksheet(17, 3).Text = "Company*"
        textBoxShape = worksheet.TextBoxes.AddTextBox(17, 5, 23, 385)
        textBoxShape.Fill.FillType = ExcelFillType.SolidColor
        textBoxShape.Fill.ForeColor = color1
        worksheet(19, 3).Text = "Phone*"
        textBoxShape = worksheet.TextBoxes.AddTextBox(19, 5, 23, 385)
        textBoxShape.Fill.FillType = ExcelFillType.SolidColor
        textBoxShape.Fill.ForeColor = color1
        worksheet(21, 3).Text = "Email*"
        textBoxShape = worksheet.TextBoxes.AddTextBox(21, 5, 23, 385)
        textBoxShape.Fill.FillType = ExcelFillType.SolidColor
        textBoxShape.Fill.ForeColor = color1
        worksheet(23, 3).Text = "Website"
        textBoxShape = worksheet.TextBoxes.AddTextBox(23, 5, 23, 385)

        Dim chkBoxProducts As ICheckBoxShape = worksheet.CheckBoxes.AddCheckBox(25, 5, 20, 75)
        chkBoxProducts.Top = 410
        chkBoxProducts.Left = 255
        worksheet(25, 3).Text = "Multiple products?"

        worksheet(27, 3, 28, 3).Merge()
        worksheet(27, 3).Text = "Product(s)*"
        worksheet(27, 3).MergeArea.CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter

        ' Create a checkbox for each product
        Dim chkBoxProduct As ICheckBoxShape
        chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(27, 5, 20, 75)
        chkBoxProduct.Text = "Studio"
        chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(27, 6, 20, 75)
        chkBoxProduct.Text = "Calculate"
        chkBoxProduct.IsSizeWithCell = True
        chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(27, 7, 20, 75)
        chkBoxProduct.Text = "Chart"
        chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(27, 8, 20, 75)
        chkBoxProduct.Text = "Diagram"
        chkBoxProduct.IsSizeWithCell = True
        chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(27, 9, 20, 75)
        chkBoxProduct.Text = "Edit"
        chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(27, 10, 20, 75)
        chkBoxProduct.Text = "XlsIO"
        chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(28, 5, 20, 75)
        chkBoxProduct.Text = "Grid"
        chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(28, 6, 20, 75)
        chkBoxProduct.Text = "Grouping"
        chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(28, 7, 20, 75)
        chkBoxProduct.Text = "HTMLUI"
        chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(28, 8, 20, 75)
        chkBoxProduct.Text = "PDF"
        chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(28, 9, 20, 75)
        chkBoxProduct.Text = "Tools"
        chkBoxProduct = worksheet.CheckBoxes.AddCheckBox(28, 10, 20, 75)
        chkBoxProduct.Text = "DocIO"
        chkBoxProducts.CheckState = ExcelCheckState.Mixed

        'generate the link to linked cell property and formula
        GenerateFormula(excelEngine)

        worksheet(30, 3).Text = "Selected Products Count"
        'counts selected product
        worksheet(30, 5).Formula = "Sum(AA2:AA13)"
        'align the cell content
        worksheet(30, 5).CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft

        worksheet(35, 3).Text = "Additional Information"
        textBoxShape = worksheet.TextBoxes.AddTextBox(32, 5, 150, 385)

        If Not rdbExcel97.Checked Then

            worksheet(43, 3).Text = "Online Payment"
            ' Create combobox
            Dim comboBox1 As IComboBoxShape
            comboBox1 = worksheet.ComboBoxes.AddComboBox(36, 5, 20, 100)
            ' Position combobox
            comboBox1.Top = 715
            comboBox1.Left = 260
            ' Assign value
            comboBox1.ListFillRange = worksheet2("A1:A2")
            ' Selects the 1st item from the list
            comboBox1.SelectedIndex = 1

            worksheet(46, 3).Text = "Card Type"
            Dim optionButton1 As IOptionButtonShape = worksheet.OptionButtons.AddOptionButton(46, 5)
            optionButton1.Text = "American Express"
            optionButton1.CheckState = ExcelCheckState.Checked

            optionButton1 = worksheet.OptionButtons.AddOptionButton(46, 7)
            optionButton1.Text = "Master Card"

            optionButton1 = worksheet.OptionButtons.AddOptionButton(46, 9)
            optionButton1.Text = "Visa"
        End If
        'column alignment
        worksheet.Columns(0).AutofitColumns()
        worksheet.Columns(3).ColumnWidth = 12
        worksheet.Columns(4).ColumnWidth = 10
        worksheet.Columns(5).ColumnWidth = 10
        worksheet.IsGridLinesVisible = False

        'Assign the filename depends upon the version selected
        If Me.rdbExcel2007.Checked Or Me.rdbExcel2010.Checked Or Me.rdbExcel2013.Checked Then
            fileName = "Sample.xlsx"
        Else
            fileName = "Sample.xls"
        End If

        ' Save the file
        workbook.SaveAs(fileName)
        'closes the workbook
        workbook.Close()
        excelEngine.Dispose()

        ' Message box confirmation to view the created document.
        If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Try
                'Launching the Excel file using the default Application.(MS Excel Or Free ExcelViewer)
                System.Diagnostics.Process.Start(fileName)

                'Exit
                Me.Close()
            Catch ex As System.ComponentModel.Win32Exception
                MessageBox.Show("Excel 2007 is not installed in this system")
                Console.WriteLine(ex.ToString())
            End Try
        Else
            Me.Close()
        End If
    End Sub
#End Region

#Region "Helper Methods"
    ''' <summary>
    ''' Generates the formula and linkedcell 
    ''' </summary>
    ''' <param name="excelEngine">excel application engine</param>
    ''' <remarks></remarks>

    Private Sub GenerateFormula(ByVal excelEngine As ExcelEngine)
        'gets the address of the 1st sheet
        Dim worksheet As IWorksheet = excelEngine.Excel.Workbooks(0).Worksheets(0)
        Dim checkBoxes As ICheckBoxes = worksheet.CheckBoxes
        Dim formula As String
        Dim range As IRange
        Dim i As Integer
        ' loop through each checkbox and assing the link
        For i = 1 To checkBoxes.Count - 1

            'range for linkedcell
            range = worksheet("Z" & (i + 1))
            checkBoxes(i).LinkedCell = range
            'formula to check whether the checkbox checked
            formula = "IF(" & range.AddressLocal & ",1,0)"
            worksheet("AA" & (i + 1)).Formula = formula
        Next
    End Sub

    ''' <summary>
    ''' Return the file path of the Input file
    ''' </summary>
    Private Function GetTemplatePath(ByVal inputFile As String) As String
        Return String.Format(DEFAULTPATH, inputFile)
    End Function
#End Region

End Class

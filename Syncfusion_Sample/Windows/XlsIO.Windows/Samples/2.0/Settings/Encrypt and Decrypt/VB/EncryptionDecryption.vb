#Region "Copyright Syncfusion Inc. 2001 - 2008"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.XlsIO

Public Class EncryptionDecryption

#Region "Process Spreadsheet"
    ''' <summary>
    ''' Encrypt the selected spreadsheet
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEncryption_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEncryption.Click
        If Me.txtEncryptSource.Text Is Nothing OrElse Me.txtEncryptSource.Text.Length = 0 Then
            MessageBox.Show("Please select workbook", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Me.txtEnOpen.Text Is Nothing OrElse Me.txtEnOpen.Text.Length = 0 Then
            MessageBox.Show("Please use password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()

            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            'Set the Default Version to the application
            If Me.rdbExcel2007Encrypt.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2007
            ElseIf Me.rdbExcel2010Encrypt.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2010
            End If


            ' Opening the Existing Worksheet from a Workbook.
            Dim workbook As IWorkbook = application.Workbooks.Open(Me.txtEncryptSource.Text)

            'Encrypt the workbook with password.
            workbook.PasswordToOpen = Me.txtEnOpen.Text

            'Save the workbook to disk.
            workbook.SaveAs("EncryptedWorkbook.xlsx")

            'Close the workbook.
            workbook.Close()
            excelEngine.Dispose()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Document is encrypted. Do you want to view the encrypted workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("EncryptedWorkbook.xlsx")
            End If

            'Reset the controls of successful creation of spreadsheet.
            Me.txtEncryptSource.Text = String.Empty
            Me.txtEnOpen.Text = String.Empty
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    ''' <summary>
    ''' Decrypt the selected spreadsheet
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDecryption_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDecryption.Click
        If Me.txtDecryptSource.Text Is Nothing OrElse Me.txtDecryptSource.Text.Length = 0 Then
            MessageBox.Show("Please select workbook", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()

            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            'Set the Default Version to the application
            If Me.rdbExcel2007Decrypt.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2007
            ElseIf Me.rdbExcel2010Decrypt.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2010
            End If


            ' Opening the encrypted Workbook.
            Dim workbook As IWorkbook = application.Workbooks.Open(Me.txtDecryptSource.Text, ExcelParseOptions.Default, True, Me.txtDeOpen.Text)

            'Modify the decrypted document.
            workbook.Worksheets(0).Range("B2").Text = "Demo for workbook decryption with Essential XlsIO"
            workbook.Worksheets(0).Range("B5").Text = "This document is decrypted using password " & Me.txtDeOpen.Text

            'Save the workbook to disk.
            workbook.SaveAs("DecryptedWorkbook.xlsx")

            'Close the workbook.
            workbook.Close()
            excelEngine.Dispose()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Document is decrypted and modified. Do you want to view the modified workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("DecryptedWorkbook.xlsx")
            Else
                ' Exit
                Me.Close()
            End If

            'Reset the controls of successful creation of spreadsheet.
            Me.txtDecryptSource.Text = String.Empty
            Me.txtDeOpen.Text = String.Empty
        Catch ex As System.ArgumentException
            MessageBox.Show("Password is wrong!!! Please re-enter correct password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

#End Region

#Region "Get Spreadsheet"

    ''' <summary>
    ''' Gets the source spreadsheet to encrypt
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEncryptSource_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEncryptSource.Click
        openFileDialog1.Filter = "Excel 2007 Spreadsheets (*.xlsx)|*.xlsx"
        openFileDialog1.Title = "Choose a Spreadsheet to Encrypt"

        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.txtEncryptSource.Text = openFileDialog1.FileName
            Me.btnEncryption.Enabled = True
        Else
            Me.btnEncryption.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Gets the source spreadsheet to decrypt
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDecryptSource_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDecryptSource.Click
        openFileDialog1.Filter = "Excel 2007 Spreadsheets (*.xlsx)|*.xlsx"
        openFileDialog1.Title = "Choose a Spreadsheet to Decrypt"
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.txtDecryptSource.Text = openFileDialog1.FileName
            Me.btnDecryption.Enabled = True
        Else
            Me.btnDecryption.Enabled = False
        End If
    End Sub
#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim imageFile As String = "..\..\..\..\..\..\..\..\..\Common\Images\XlsIO\"
        Me.label9.Image = Image.FromFile(imageFile + "label8_Image.gif")
        Me.label13.Image = Image.FromFile(imageFile + "label8_Image.gif")
        Me.label2.Image = Image.FromFile(imageFile + "label_Image.gif")
        Me.label12.Image = Image.FromFile(imageFile + "label_Image.gif")
    End Sub
End Class

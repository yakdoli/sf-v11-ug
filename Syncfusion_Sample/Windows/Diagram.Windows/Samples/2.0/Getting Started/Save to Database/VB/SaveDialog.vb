Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing

Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.SqlServerCe

Namespace SaveDiagramAsBinary
	Partial Public Class SaveDialog
		Inherits Office2007Form
		Private strCon As String

		Public Sub New()
			InitializeComponent()

			AddHandler txtName.GotFocus, AddressOf txtName_GotFocus

			'Get connection string.
			strCon = "Data Source=..\..\..\..\..\..\..\..\..\Common\Data\Diagram\DiagramDB.sdf"

		End Sub

		Private Sub txtName_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
			lblResult.Text = String.Empty
		End Sub

		Public ReadOnly Property DiagramName() As String
			Get
				Return txtName.Text
			End Get
		End Property

		Private Sub SaveDialog_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			If Me.DialogResult <> System.Windows.Forms.DialogResult.OK Then
				Return
			End If

			'Validation
			If String.IsNullOrEmpty(txtName.Text) Then
				lblResult.Text = "Please enter a name for the diagram"
				e.Cancel = True
				Return
			End If

			'Create an instance of connection and command object.
			Dim con As New SqlCeConnection(strCon)
			Dim cmd As New SqlCeCommand("SELECT CASE WHEN EXISTS (SELECT * FROM DiagramContent  WHERE DiagramName = @DiagramName) " & "THEN 1 ELSE 0 END AS result", con)

			'Set parameter value
			cmd.Parameters.AddWithValue("@DiagramName", txtName.Text)

			'Execute the command.
			con.Open()
			Dim result As Integer = CInt(Fix(cmd.ExecuteScalar()))
			con.Close()

			If result = 1 Then
				lblResult.Text = "The name already exist"
				e.Cancel = True
			End If
		End Sub
	End Class
End Namespace

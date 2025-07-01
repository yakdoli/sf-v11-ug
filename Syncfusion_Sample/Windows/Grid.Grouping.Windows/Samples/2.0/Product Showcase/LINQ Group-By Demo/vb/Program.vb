#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
#Region "Directives"

Imports System
Imports System.IO
Imports System.Windows.Forms

#End Region

Namespace LinqGroupBy
	Friend NotInheritable Class Program
		#Region "Variable Declaration"

		' The following sample assumes that you installed the DATA sample 
		' project and that Northwind.MDF is in that Data directory.
		Private Const sqlServerInstance As String = ".\SQLEXPRESS"

		#End Region

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub

		#End Region
	End Class
End Namespace

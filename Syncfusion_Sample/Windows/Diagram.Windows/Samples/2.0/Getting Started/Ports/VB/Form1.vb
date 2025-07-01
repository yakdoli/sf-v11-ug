Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports DemoCommon.Diagram

Namespace Ports
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.diagram1.LoadBinary("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\PortsAhoy.edd")
		End Sub
		#End Region

	End Class
End Namespace
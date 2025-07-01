Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2011"
'
'  Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Runtime.Serialization
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram

Namespace ControlsGalore
	''' <summary>
	''' CustomListSymbol class that exposes a serializable ListBox hosted by its child ControlNode.
	''' </summary>
	<Serializable()> _
	Public Class ListBoxControNode
		Inherits ControlNode
		#Region "Constants"
		Private Const c_strLIST_BOX_ITEMS As String = "listboxitems"
		#End Region

		#Region "initialize/finalize methods"
		''' <summary>
		''' Default constructor.
		''' </summary>
		Public Sub New()
			MyBase.New(New ListBox(), New System.Drawing.Rectangle(0, 0, 200, 85))
			Dim lst As ListBox = TryCast(Me.HostingControl, ListBox)

			lst.IntegralHeight = False
			Dim itemsarray() As String = { "ListBox in a ControlNode", "Use PropertyEditor to add/remove items" }
			lst.Items.AddRange(itemsarray)
		End Sub
		''' <summary>
		''' Copy constructor.
		''' </summary>
		''' <param name="src"></param>
		Public Sub New(ByVal src As ListBoxControNode)
			MyBase.New(src)
			Dim lst As ListBox = TryCast(Me.HostingControl, ListBox)
			Dim lstSrc As ListBox = TryCast(src.HostingControl, ListBox)
			Dim itemsarray(lstSrc.Items.Count - 1) As String
			lstSrc.Items.CopyTo(itemsarray, 0)
			lst.Items.AddRange(itemsarray)
		End Sub
		''' <summary>
		''' Serialization constructor for the CustomList class.
		''' </summary>
		''' <param name="info">Serialization state information</param>
		''' <param name="context">Streaming context information</param>
		''' <summary>
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
			Dim lst As ListBox = TryCast(Me.HostingControl, ListBox)
			lst.IntegralHeight = False

			Try
				Dim items() As String = CType(Me.HCP(c_strLIST_BOX_ITEMS), String())

				If items IsNot Nothing Then
					lst.Items.AddRange(items)
				End If
			Catch e1 As SerializationException
			End Try
		End Sub
		#End Region

		#Region "overrides"
		Protected Overrides Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			Dim lst As ListBox = TryCast(Me.HostingControl, ListBox)
			Dim items(lst.Items.Count - 1) As String
			lst.Items.CopyTo(items, 0)

			If Me.HCP.ContainsKey(c_strLIST_BOX_ITEMS) Then
				Me.HCP(c_strLIST_BOX_ITEMS) = items
			Else
				Me.HCP.Add(c_strLIST_BOX_ITEMS, items)
			End If

			MyBase.GetObjectData(info, context)
		End Sub

		''' <summary>
		''' Creates a new object that is a copy of the current instance.
		''' </summary>
		''' <returns>Copy of the object this method is invoked against</returns>
		Public Overrides Function Clone() As Object
			Return New ListBoxControNode(Me)
		End Function
		#End Region
	End Class

End Namespace
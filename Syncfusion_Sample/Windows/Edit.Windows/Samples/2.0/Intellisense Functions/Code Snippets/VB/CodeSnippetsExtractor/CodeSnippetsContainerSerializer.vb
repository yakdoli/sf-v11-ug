Imports Microsoft.VisualBasic
Imports System
Namespace CodeSnippetsExtractor

	Public Class CodeSnippetsContainerSerializationWriter : Inherits System.Xml.Serialization.XmlSerializationWriter : Implements Syncfusion.XmlSerializersCreator.IXmlSerializationWriter

		Protected Overrides Sub InitCallbacks()
		End Sub
		<System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.LinkDemand, Name:="FullTrust")> _
		Public Sub WriteDataToXml(ByVal o As Object) Implements Syncfusion.XmlSerializersCreator.IXmlSerializationWriter.WriteDataToXml
			WriteStartDocument()
			If o Is Nothing Then
				WriteNullTagLiteral("CodeSnippetsContainer", "")
				Return
			End If
			TopLevelElement()
			WriteSerializable((CType(o, Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets.CodeSnippetsContainer)), "CodeSnippetsContainer", "", True)
		End Sub
	End Class

	Public Class CodeSnippetsContainerSerializationReader : Inherits System.Xml.Serialization.XmlSerializationReader : Implements Syncfusion.XmlSerializersCreator.IXmlSerializationReader

		Protected Overrides Sub InitCallbacks()
		End Sub
		<System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.LinkDemand, Name:="FullTrust")> _
		Public Function ReadDataFromXml() As Object Implements Syncfusion.XmlSerializersCreator.IXmlSerializationReader.ReadDataFromXml
			Dim o As Object = Nothing
			Reader.MoveToContent()
			If Reader.NodeType = System.Xml.XmlNodeType.Element Then
				If (CObj(Reader.LocalName) = CObj(id1_CodeSnippetsContainer) AndAlso CObj(Reader.NamespaceURI) = CObj(id2_Item)) Then
					o = CType(ReadSerializable(New Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets.CodeSnippetsContainer()), Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets.CodeSnippetsContainer)
				Else
					Throw CreateUnknownNodeException()
				End If
			Else
				UnknownNode(Nothing)
			End If
			Return CObj(o)
		End Function

		Private id1_CodeSnippetsContainer As System.String
		Private id2_Item As System.String

		Protected Overrides Sub InitIDs()
			id1_CodeSnippetsContainer = Reader.NameTable.Add("CodeSnippetsContainer")
			id2_Item = Reader.NameTable.Add("")
		End Sub
	End Class
End Namespace

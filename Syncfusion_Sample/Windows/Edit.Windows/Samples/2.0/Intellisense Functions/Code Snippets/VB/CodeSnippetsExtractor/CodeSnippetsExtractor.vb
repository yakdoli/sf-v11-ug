Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization

Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets
Imports Syncfusion.XmlSerializersCreator

Namespace CodeSnippetsExtractor
	''' <summary>
	''' Class with static methods extracting code snippets from directories.
	''' </summary>
	Public Class CodeSnippetsExtractor
		#Region "Static Methods"
		''' <summary>
		''' Extracts code snippets from given folder and adds them to the current language configuration of EditControl.
		''' </summary>
		''' <param name="dir">Path to the directory with code snippets.</param>
		''' <param name="editor">Instance of EditControl to add code snippets to.</param>
		Public Shared Sub Extract(ByVal dir As String, ByVal editor As EditControl)
			Dim container As CodeSnippetsContainer = Extract(dir)

			Dim containerName As String
			For Each containerName In container.ContainersNames
				editor.Language.AddCodeSnippetsContainer(container.GetContainerByName(containerName))
			Next containerName

			Dim snippetName As String
			For Each snippetName In container.SnippetsNames
				editor.Language.AddCodeSnippet(container.GetSnippetByTitle(snippetName))
			Next snippetName
		End Sub
		''' <summary>
		''' Extracts code snippets from given folder and serializes it to Xml file.
		''' </summary>
		''' <param name="dir">Path to directory with code snippets.</param>
		''' <param name="destXml">Rath to the Xml file to write code snippets to.</param>
		Public Shared Sub Extract(ByVal dir As String, ByVal destXml As String)
			Dim writer As XmlTextWriter = New XmlTextWriter(destXml, Encoding.Default)
			writer.Formatting = Formatting.Indented

			Dim container As CodeSnippetsContainer = Extract(dir)

			Dim containerSer As XmlSerializer = SerializersManager.GetSerializer(GetType(CodeSnippetsContainer))
			containerSer.Serialize(writer, container)

			writer.Close()
		End Sub
		''' <summary>
		''' Extracts code snippets from given folder and returns container with extracted items.
		''' </summary>
		''' <param name="dir">Path to the directory with code snippets.</param>
		''' <returns>CodeSnippetsContainer instance with extracted code snippets.</returns>
		Public Shared Function Extract(ByVal dir As String) As CodeSnippetsContainer
			Dim result As CodeSnippetsContainer = New CodeSnippetsContainer()

			Extract(dir, result)

			Return result
		End Function
		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Extracts code snippets from given folder and stores it in given container.
		''' </summary>
		''' <param name="dir">Path to the directory with code snippets.</param>
		''' <param name="container">Container to store snippets in.</param>
		Private Shared Sub Extract(ByVal dir As String, ByVal container As CodeSnippetsContainer)
			Dim snippetSer As XmlSerializer = SerializersManager.GetSerializer(GetType(CodeSnippet))

			Dim files As String() = Directory.GetFiles(dir, "*.snippet")

			Dim snippetFileName As String
			For Each snippetFileName In files
				Dim reader As XmlReader = New XmlTextReader(snippetFileName)
				reader.MoveToContent()
				reader.Read() ' Read "CodeSnippets" element.
				reader.MoveToContent()

				Do While reader.Name = "CodeSnippet"
					Dim snippet As CodeSnippet = CType(snippetSer.Deserialize(reader), CodeSnippet)
					container.AddSnippet(snippet)
				Loop
			Next snippetFileName

			Dim dirs As String() = Directory.GetDirectories(dir)

			Dim dirName As String
			For Each dirName In dirs
				Dim newContainer As CodeSnippetsContainer = New CodeSnippetsContainer()
				Dim lastSlash As Integer = dirName.LastIndexOf("\")
				newContainer.Name = dirName.Substring(lastSlash + 1)
				Extract(dirName, newContainer)
				container.AddContainer(newContainer)
			Next dirName
		End Sub
		#End Region
	End Class
End Namespace
#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Runtime.Serialization

Imports Syncfusion.Scripting
Imports Syncfusion.Scripting.Design
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms.Diagram.Controls

Namespace Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool
	#Region "DiagramScript"

	''' <summary>
	''' Implements a customized Script for the Diagram.
	''' </summary>
	<Serializable> _
	Public Class DiagramScript : Inherits Syncfusion.Scripting.Script : Implements ISerializable
		''' <summary>
		''' Creates an instance of the DiagramScript class
		''' </summary>
		Public Sub New()
			Me.AddReference(New AssemblyDescriptor("Syncfusion.Shared.Base", String.Empty, String.Empty))
			Me.AddReference(New AssemblyDescriptor("Syncfusion.Shared.Windows", String.Empty, String.Empty))
			Me.AddReference(New AssemblyDescriptor("Syncfusion.Diagram.Base", String.Empty, String.Empty))
			Me.AddReference(New AssemblyDescriptor("Syncfusion.Diagram.Windows", String.Empty, String.Empty))
			Me.AddReference(New AssemblyDescriptor("System.Drawing", String.Empty, String.Empty))

			Me.AddEventSource("Model", "Syncfusion.Windows.Forms.Diagram.Model")
			Me.AddEventSource("View", "Syncfusion.Windows.Forms.Diagram.View")
			Me.AddEventSource("Controller", "Syncfusion.Windows.Forms.Diagram.Controller")
		End Sub

		#Region "ISerializable implementation"

		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub

        'Protected Overrides Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        '    Me.GetObjectData(info, context)
        'End Sub

		#End Region ' ISerializable
	End Class

	#End Region 'DiagramScript


	#Region "DiagramScriptSite"

	''' <summary>
	''' Implements the ScriptSite for a Diagram.
	''' </summary>
	Public Class DiagramScriptSite : Inherits Syncfusion.Scripting.ScriptSite
		''' <summary>
		''' Construct a ScriptSite for the specified diagram.
		''' </summary>
		Public Sub New(ByVal diagram As Syncfusion.Windows.Forms.Diagram.Controls.Diagram)
			Me.diagram = diagram
		End Sub

		''' <summary>
		''' Gets a reference to an event source previously added to a script engine using
		''' the IVsaCodeItem.AddEventSource method.
		''' </summary>		
		Public Overrides Function GetEventSourceInstance(ByVal itemName As String, ByVal eventSourceName As String) As Object
			If eventSourceName.Equals(Resources.Strings.ObjectName.Get("Model")) Then
				Return diagram.Model
			End If

			If eventSourceName.Equals(Resources.Strings.ObjectName.Get("View")) Then
				Return diagram.View
			End If

			If eventSourceName.Equals(Resources.Strings.ObjectName.Get("Controller")) Then
				Return diagram.Controller
			End If

			Return Nothing
		End Function

		''' <summary>
		''' Gets a reference to a global item, such as the host-provided application object.
		''' </summary>
		Public Overrides Function GetGlobalInstance(ByVal globInstanceName As String) As Object
			If globInstanceName.Equals(Resources.Strings.ObjectName.Get("Model")) Then
				Return diagram.Model
			End If

			If globInstanceName.Equals(Resources.Strings.ObjectName.Get("View")) Then
				Return diagram.View
			End If

			If globInstanceName.Equals(Resources.Strings.ObjectName.Get("Controller")) Then
				Return diagram.Controller
			End If

			Return Nothing
		End Function

		Private diagram As Syncfusion.Windows.Forms.Diagram.Controls.Diagram = Nothing
	End Class

	#End Region ' DiagramScriptSite
End Namespace

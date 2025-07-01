#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Text

Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Grouping

'INSTANT VB NOTE: VB does not allow aliasing interfaces:
'using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary

Namespace WeightedSummary
	''' <summary>
	''' Syncfusion Custom Summary class that computes the weighted average of the of entries 
	''' where the weights come in from a column passed in through a naming convention. 
	''' </summary>
	Public NotInheritable Class WeightedSummary
		Inherits SummaryBase
		Private _valTotal As Double
		Private _wgtTotal As Double


		Public Sub New()

		End Sub

		Public Shared ReadOnly Empty As New WeightedSummary(0, 0)

		''' <summary>
		''' Assign this CreateSummaryDelegate handler method to SummaryDescriptor.CreateSummaryMethod 
		''' </summary>
		''' <param name="sd"></param>
		''' <param name="record"></param>
		''' <returns></returns>
		Public Shared Function CreateSummaryMethod(ByVal sd As SummaryDescriptor, ByVal record As Record) As Syncfusion.Collections.BinaryTree.ITreeTableSummary
			Dim obj As Object = sd.GetValue(record)
			Dim isNull As Boolean = (obj Is Nothing OrElse TypeOf obj Is DBNull)
			If isNull Then
				Return Empty
			Else
				Dim i As Integer = sd.Name.LastIndexOf("_"c) + 1
				Dim weightsCol As String = sd.Name.Substring(i)
				Dim obj1 As Object = record.GetValue(weightsCol)
				If obj1 Is Nothing Then
					Throw New ArgumentException(String.Format("[{0}] not a column.", weightsCol))
				End If

				Dim wgt As Double = Convert.ToDouble(obj1)
				Dim val As Double = Convert.ToDouble(obj) * wgt

				Return New WeightedSummary(val, wgt)
			End If
		End Function

		''' <summary>
		''' Initializes a new summary object.
		''' </summary>
		''' <param name="valTotal"></param>
		''' <param name="wgtTotal"></param>
		Public Sub New(ByVal valTotal As Double, ByVal wgtTotal As Double)
			_wgtTotal = wgtTotal
			_valTotal = valTotal
		End Sub


		''' <summary>
		''' The running weighted sum of this summary
		''' </summary>
		Public ReadOnly Property WeightedAverage() As Double
			Get
				If _wgtTotal = 0 Then
					Return _wgtTotal
				End If
				Return _valTotal / _wgtTotal
			End Get
		End Property

		''' <summary>
		''' Combines this summary information with another objects summary and returns a new object.  
		''' </summary>
		''' <param name="other"></param>
		''' <returns></returns>
		''' <remarks>
		''' This method must honor the immutable characteristics of summary objects and return 
		''' a new summary object instead of modifying an existing summary object.
		''' </remarks>
		Public Overrides Function Combine(ByVal other As SummaryBase) As SummaryBase
			Return Combine(CType(other, WeightedSummary))
		End Function

		''' <summary>
		''' Combines this summary information with another objects summary and returns a new object.  
		''' </summary>
		''' <param name="other"></param>
		''' <returns></returns>
		''' <remarks>
		''' This method must honor the immutable characteristics of summary objects and return 
		''' a new summary object instead of modifying an existing summary object.
		''' </remarks>
		Public Overloads Function Combine(ByVal other As WeightedSummary) As WeightedSummary
			' Summary objects are immutable. That means properties cannot be modified for an 
			' existing object. Instead every time a change is made a new object must be created (just like 
			' System.String). 
			'
			Return New WeightedSummary(Me._valTotal + other._valTotal, Me._wgtTotal + other._wgtTotal)
		End Function

		''' <override/>
		Public Overrides Function ToString() As String
			Return String.Format("WeightedAverage = {0:0.00}", WeightedAverage)
		End Function
	End Class
End Namespace

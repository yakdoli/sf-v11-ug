Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Text

Imports Syncfusion.Collections
Imports Syncfusion.Collections.BinaryTree
Imports Syncfusion.Diagnostics
'using Syncfusion.Grouping.Internals;
Imports Syncfusion.Grouping

Namespace PivotGridLibrary
	''' <summary>
	''' Summarizes System.Double fields. Provides StdDev, StdDevp, Var, and Varp.
	''' </summary>
	Public NotInheritable Class DoubleStdDevSummary
		Inherits SummaryBase
		Private count As Integer
		Private sum As Double
		Private sumX2 As Double

		''' <summary>
		''' The initial summary object for empty records or tables.
		''' </summary>
		Public Shared ReadOnly Empty As DoubleStdDevSummary = New DoubleStdDevSummary(0, 0.0, 0.0)

		''' <summary>
		''' Creates a summary object for the specified SummaryDescriptor and Record.
		''' </summary>
		''' <param name="sd">The summary descriptor.</param>
		''' <param name="record">The record with data.</param>
		''' <returns>A new summary object.</returns>
		Public Shared Function CreateSummaryMethod(ByVal sd As SummaryDescriptor, ByVal record As Record) As ITreeTableSummary
			Dim obj As Object = sd.GetValue(record)
			Dim isNull As Boolean = (obj Is Nothing OrElse TypeOf obj Is DBNull)
			If isNull Then
				Return Empty
			Else
				Dim val As Double = Convert.ToDouble(obj)
				Return New DoubleStdDevSummary(1, val, val * val)
			End If
		End Function

		''' <summary>
		''' Initializes a new summary object with the specified values.
		''' </summary>
		''' <param name="count"></param>
		''' <param name="sum"></param>
		''' <param name="sumX2"></param>
		Public Sub New(ByVal count As Integer, ByVal sum As Double, ByVal sumX2 As Double)
			Me.count = count
			Me.sum = sum
			Me.sumX2 = sumX2
		End Sub




		''' <summary>
		''' Gets the Standard Deviation. (ie, divides by n-1)
		''' </summary>
		Public ReadOnly Property StdDev() As Double
			Get
				If count <= 1 Then
					Return Double.NaN
				End If
				Return Math.Sqrt(Var)
			End Get
		End Property

		''' <summary>
		''' Gets the population Standard Deviation.  (ie, divides by n)
		''' </summary>
		Public ReadOnly Property StdDevP() As Double
			Get
				If count <= 1 Then
					Return Double.NaN
				End If
				Return Math.Sqrt(VarP)
			End Get
		End Property

		''' <summary>
		''' Gets the Variance. (ie, divides by n-1)
		''' </summary>
		Public ReadOnly Property Var() As Double
			Get
				If count <= 1 Then
					Return Double.NaN
				End If
				Return (count * sumX2 - sum * sum) / (count * (count-1))
			End Get
		End Property

		''' <summary>
		''' Gets the population Variance.  (ie, divides by n)
		''' </summary>
		Public ReadOnly Property VarP() As Double
			Get
				If count <= 1 Then
					Return Double.NaN
				End If
				Return (count * sumX2 - sum * sum) / (count * count)
			End Get
		End Property


		''' <override/>
		Public Overrides Function Combine(ByVal other As SummaryBase) As SummaryBase
			Return Combine(CType(other, DoubleStdDevSummary))
		End Function

		''' <summary>
		''' Combines the values of this summary with another summary and returns
		''' a new summary object.
		''' </summary>
		''' <param name="other">Another summary object (of the same type).</param>
		''' <returns>A new summary object with combined values of both summaries.</returns>
		Public Overloads Function Combine(ByVal other As DoubleStdDevSummary) As DoubleStdDevSummary
			If other.count = 0 Then
				Return Me
			ElseIf Me.count = 0 Then
				Return other
			Else
				Return New DoubleStdDevSummary(Me.count + other.count, Me.sum + other.sum, Me.sumX2 + other.sumX2)
			End If
		End Function

		''' <override/>
		Public Overrides Function ToString() As String
			Return String.Concat("StdDev = " & Me.StdDev.ToString(), ", StdDevP = " & Me.StdDevP.ToString(), ", Var = " & Me.Var.ToString(), ", VarP = " & Me.VarP.ToString())
		End Function
	End Class



End Namespace

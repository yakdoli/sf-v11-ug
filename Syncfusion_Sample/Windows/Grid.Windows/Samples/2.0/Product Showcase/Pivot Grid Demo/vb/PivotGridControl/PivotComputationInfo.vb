Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Grouping
Imports System.ComponentModel
Imports System.Windows.Forms

Imports System.Xml.Serialization
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters
Imports System.Xml

'INSTANT VB NOTE: VB does not allow aliasing interfaces:
'using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary

Namespace PivotGridLibrary
	#Region "PivotComputationInfo class"

	Public Class PivotComputationInfo

		#Region "properties"
		Private fieldName_Renamed As String

		Public Property FieldName() As String
			Get
				Return fieldName_Renamed
			End Get
			Set(ByVal value As String)
				fieldName_Renamed = value
			End Set
		End Property

		Private description_Renamed As String

		Public Property Description() As String
			Get
				Return description_Renamed
			End Get
			Set(ByVal value As String)
				description_Renamed = value
			End Set
		End Property

		Private calculationName_Renamed As String

		Public Property CalculationName() As String
			Get
				Return calculationName_Renamed
			End Get
			Set(ByVal value As String)
				calculationName_Renamed = value
			End Set
		End Property

		Private summary_Renamed As SummaryBase

		<XmlIgnore> _
		Public Property Summary() As SummaryBase
			Get
				Return summary_Renamed
			End Get
			Set(ByVal value As SummaryBase)
				summary_Renamed = value
			End Set
		End Property


		Private pd_Renamed As PropertyDescriptor

		<XmlIgnore> _
		Public Property Pd() As PropertyDescriptor
			Get
				Return pd_Renamed
			End Get
			Set(ByVal value As PropertyDescriptor)
				pd_Renamed = value
			End Set
		End Property

		Private format_Renamed As String = "#.##"

		Public Property Format() As String
			Get
				Return format_Renamed
			End Get
			Set(ByVal value As String)
				format_Renamed = value
			End Set
		End Property

		#End Region

		#Region "constructors "

		Public Sub New()
		End Sub

		Public Sub New(ByVal summary As SummaryBase, ByVal calculationName As String, ByVal description As String, ByVal fieldName As String)
			Initialize(summary, calculationName, description, fieldName)
		End Sub

		''' <summary>
		''' Initializes the computation definition. This method must be called to define the computation.
		''' </summary>
		''' <param name="summary">The SummaryBa</param>
		''' <param name="displayPropertyName"></param>
		''' <param name="description"></param>
		''' <param name="name"></param>
		Public Sub Initialize(ByVal summary As SummaryBase, ByVal calculationName As String, ByVal description As String, ByVal fieldName As String)
			Me.summary_Renamed = summary

			Me.calculationName_Renamed = calculationName
			Me.description_Renamed = description
			Me.fieldName_Renamed = fieldName
			Me.pd_Renamed = Nothing


			If Not summary Is Nothing Then
				Dim pdc As PropertyDescriptorCollection = TypeDescriptor.GetProperties(summary, New Attribute() { New BrowsableAttribute(True) })
				Try
					pd_Renamed = pdc(calculationName)
				Catch
					MessageBox.Show(String.Format("{0} not a valid summary property (case matters)", calculationName))
				End Try
			End If
		End Sub
		#End Region

		Public Overrides Function ToString() As String
			Return Me.CalculationName
		End Function

	End Class
	#End Region

	#Region "Computation choices"

	Public Class PivotComputationInfoList
		Inherits ArrayList
		Public Sub New()
		End Sub

		Default Public Shadows Property Item(ByVal i As Integer) As PivotComputationInfo
			Get
				Return CType(MyBase.Item(i), PivotComputationInfo)
			End Get
			Set(ByVal value As PivotComputationInfo)
				MyBase.Item(i) = value
			End Set
		End Property

		Public Overridable Sub PopulateWithListChoices()
			Me.Clear()

			'xxx is a dummy fieldname just to satisfy the constructor 
			Dim sum As DoubleAggregateSummary = DoubleAggregateSummary.Empty ' new DoubleAggregateSummary(0, double.MaxValue, double.MinValue, 0d);
			Me.Add(New PivotComputationInfo(sum, "Sum", "Sum of {*}", "xxx"))
			Me.Add(New PivotComputationInfo(sum, "Average", "Average of {*}", "xxx"))

			Dim v As DoubleVectorSummary = DoubleVectorSummary.Empty ' new DoubleVectorSummary(new double[] { 1, 2, 3 }, 3);// any will do
			 Me.Add(New PivotComputationInfo(v, "Median", "Median of {*}", "xxx"))
			 Me.Add(New PivotComputationInfo(v, "Percentile25", "25 Percentile of {*}", "xxx"))
			 Me.Add(New PivotComputationInfo(v, "Percentile75", "75 Percentile of {*}", "xxx"))

			Dim c As CountSummary = CountSummary.Empty ' new VectorSummary(null, 0);
			Me.Add(New PivotComputationInfo(c, "Count", "Count of {*}", "xxx"))

			Dim sd As DoubleStdDevSummary = DoubleStdDevSummary.Empty
			Me.Add(New PivotComputationInfo(sd, "StdDev", "StDev of {*}", "xxx"))
			Me.Add(New PivotComputationInfo(sd, "StdDevP", "StDevP of {*}", "xxx"))
			Me.Add(New PivotComputationInfo(sd, "Var", "Var of {*}", "xxx"))
			Me.Add(New PivotComputationInfo(sd, "VarP", "VarP of {*}", "xxx"))



		End Sub


		Public Function Find(ByVal fieldName As String) As PivotComputationInfo
			For Each info As PivotComputationInfo In Me
				If info.FieldName = fieldName Then
					Return info
				End If
			Next info
			Return Nothing
		End Function

		Public Function Find(ByVal calculationName As String, <System.Runtime.InteropServices.Out()> ByRef location As Integer) As PivotComputationInfo
			location = 0
			For Each info As PivotComputationInfo In Me
				If info.CalculationName = calculationName Then
					Return info
				End If
				location += 1
			Next info
			location = -1
			Return Nothing
		End Function

		Public Shared Function CreateSummary(ByVal computationName As String) As SummaryBase
			Dim summary As SummaryBase = Nothing
			Select Case computationName
				Case "Average", "Minimum", "Maximum", "Sum"
					summary = DoubleAggregateSummary.Empty
				Case "Median", "Percentile25", "Percentile75"
					summary = DoubleVectorSummary.Empty
				Case "Count"
					summary = CountSummary.Empty
				Case "StdDev", "StdDevP", "Var", "VarP"
					summary = DoubleStdDevSummary.Empty
				Case Else
			End Select
			Return summary
		End Function

	End Class

	#End Region
End Namespace

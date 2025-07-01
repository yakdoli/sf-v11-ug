#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Text

Imports Syncfusion.Collections
Imports Syncfusion.Collections.BinaryTree
Imports Syncfusion.Diagnostics
Imports Syncfusion.Grouping


'/ <summary>
'/ Simple summary example: Counts total sum of entries. 
'/ </summary>

NotInheritable Public Class TotalSummary
    Inherits SummaryBase
    Private _total As Double
    
    Public Shared Empty As New TotalSummary(0)
    
    
    '/ <summary>
    '/ Assign this CreateSummaryDelegate handler method to SummaryDescriptor.CreateSummaryMethod 
    '/ </summary>
    '/ <param name="sd"></param>
    '/ <param name="record"></param>
    '/ <returns></returns>
    Public Shared Function CreateSummaryMethod(ByVal sd As SummaryDescriptor, ByVal record As Record) As ITreeTableSummary
        Dim obj As Object = sd.GetValue(record)
        Dim isNull As Boolean = obj Is Nothing OrElse TypeOf obj Is DBNull
        If isNull Then
            Return Empty
        Else
            Dim val As Double = Convert.ToDouble(obj)
            Return New TotalSummary(val)
        End If
    End Function 'CreateSummaryMethod


    '/ <summary>
    '/ Initializes a new summary object.
    '/ </summary>
    '/ <param name="total"></param>
    Public Sub New(ByVal total As Double)
        _total = total
    End Sub 'New

    '/ <summary>
    '/ The running total of this summary
    '/ </summary>
    Public ReadOnly Property Total() As Double
        Get
            Return _total
        End Get
    End Property


    '/ <summary>
    '/ Combines this summary information with another objects summary and returns a new object.  
    '/ </summary>
    '/ <param name="other"></param>
    '/ <returns></returns>
    '/ <remarks>
    '/ This method must honor the immutable characteristics of summary objects and return 
    '/ a new summary object instead of modifying an existing summary object.
    '/ </remarks>
    Public Overloads Overrides Function Combine(ByVal other As SummaryBase) As SummaryBase
        Return Combine(CType(other, TotalSummary))
    End Function 'Combine


    '/ <summary>
    '/ Combines this summary information with another objects summary and returns a new object.  
    '/ </summary>
    '/ <param name="other"></param>
    '/ <returns></returns>
    '/ <remarks>
    '/ This method must honor the immutable characteristics of summary objects and return 
    '/ a new summary object instead of modifying an existing summary object.
    '/ </remarks>
    Public Overloads Function Combine(ByVal other As TotalSummary) As TotalSummary
        ' Summary objects are immutable. That means properties cannot be modified for an 
        ' existing object. Instead every time a change is made a new object must be created (just like 
        ' System.String). 
        '
        ' This allows following optimization: return existing summary object if either one of the values is 0. -->
        If other.Total = 0 Then
            Return Me
        ElseIf Total = 0 Then
            Return other
            ' <-- end of optimization
        Else
            Return New TotalSummary(Me.Total + other.Total)
        End If
    End Function 'Combine

    '/ <override/>
    Public Overrides Function ToString() As String
        Return String.Format("Total = {0:0.00}", Total)
    End Function 'ToString
End Class 'TotalSummary



'/ <summary>
'/ Advanced summary example: Collects all entries of a column in a sorted vector. Provides statistical functions
'/ that work on this set such as Median, Percentile25, Percentile75 and PercentileQ.
'/ </summary>

Public Class StatisticsSummary
    Inherits SummaryBase
    Private _values() As Double
    Private _length As Integer

    Public Shared Empty As New StatisticsSummary(New Double(-1) {}, 0)


    Public Shared Function CreateSummaryMethod(ByVal sd As SummaryDescriptor, ByVal record As Record) As ITreeTableSummary
        Dim obj As Object = sd.GetValue(record)
        Dim isNull As Boolean = obj Is Nothing OrElse TypeOf obj Is DBNull OrElse (TypeOf obj Is Double AndAlso Double.IsNaN(System.Convert.ToDouble(obj)))
        ' could also be double.NaN... which is also treated as null
        If isNull Then
            Return New StatisticsSummary(New Double(-1) {}, 0) ' { double.NaN }, 1);
        Else
            Dim val As Double = Convert.ToDouble(obj)
            Return New StatisticsSummary(New Double() {val}, 1)
        End If
    End Function 'CreateSummaryMethod


    Public Sub New(ByVal values() As Double, ByVal length As Integer)
        _values = values
        _length = length
    End Sub 'New


    Public ReadOnly Property Count() As Integer
        Get
            If _values Is Nothing Then
                Return 0
            End If
            Return _length
        End Get
    End Property


    Public ReadOnly Property Values() As Double()
        Get
            Return _values
        End Get
    End Property


    '/ <override/>
    Public Overloads Overrides Function Combine(ByVal other As SummaryBase) As SummaryBase
        Return Combine(CType(other, StatisticsSummary))
    End Function 'Combine


    Function _Compare(ByVal x As Double, ByVal y As Double) As Integer
        Dim cmp As Integer
        Dim xIsNull As Boolean = Double.IsNaN(x)
        Dim yIsNull As Boolean = Double.IsNaN(y)

        If yIsNull AndAlso xIsNull Then
            cmp = 0
        ElseIf xIsNull Then
            cmp = -1
        ElseIf yIsNull Then
            cmp = 1
        ElseIf y = x Then
            cmp = 0
        ElseIf y > x Then
            cmp = 1
        Else
            cmp = -1
        End If
        Return cmp
    End Function '_Compare


    Public Overloads Function Combine(ByVal other As StatisticsSummary) As StatisticsSummary
        Dim length As Integer
        Dim d As Double() = CombineHelper(other, False, length)
        If length = Me.Count Then
            Return Me
        ElseIf length = other.Count Then
            Return other
        Else
            Return New StatisticsSummary(d, length)
        End If
    End Function 'Combine

    Protected Function CombineHelper(ByVal other As StatisticsSummary, ByVal distinct As Boolean, ByRef length As Integer) As Double()
        Dim d(Count + other.Count) As Double
        Dim others As Double() = other.Values

        Dim n1 As Integer = 0
        Dim n2 As Integer = 0
        Dim len1 As Integer = Count
        Dim len2 As Integer = other.Count
        Dim n3 As Integer = 0
        While n1 < len1 AndAlso n2 < len2
            Dim cmp As Integer = _Compare(_values(n1), others(n2))
            If cmp > 0 Then
                d(n3) = _values(n1)
                n1 = n1 + 1
            ElseIf cmp < 0 Then
                d(n3) = others(n2)
                n2 = n2 + 1
            Else
                d(n3) = _values(n1)
                n1 = n1 + 1
                If distinct Then
                    n2 += 1
                End If
            End If
            n3 += 1
        End While
        While n1 < len1
            d(n3) = _values(n1)
            n3 = n3 + 1
            n1 = n1 + 1
        End While
        While n2 < len2
            d(n3) = others(n2)
            n3 = n3 + 1
            n2 = n2 + 1
        End While
        length = n3
        Return d
    End Function 'CombineHelper


    Function GetPercentile(ByVal p As Double) As Double
        If p < 0 OrElse p > 1 Then
            Throw New ArgumentOutOfRangeException("Percentile out-of-range.")
        End If
        Dim s As Double() = _values
        Dim t As Double = p * (_length - 1)
        Dim i As Integer = Fix(t)
        Return (i + 1 - t) * s(i) + (t - i) * s((i + 1))
    End Function 'GetPercentile


    Public ReadOnly Property Median() As Double
        Get
            If _length < 2 Then
                Return Double.NaN
            End If
            Return GetPercentile(0.5)
        End Get
    End Property


    Public ReadOnly Property Percentile25() As Double
        Get
            If _length < 2 Then
                Return Double.NaN
            End If
            Return GetPercentile(0.25)
        End Get
    End Property


    Public ReadOnly Property Percentile75() As Double
        Get
            If _length < 2 Then
                Return Double.NaN
            End If
            Return GetPercentile(0.75)
        End Get
    End Property


    Public ReadOnly Property PercentileQ() As Double
        Get
            If _length < 2 Then
                Return Double.NaN
            End If
            Return Percentile75 - Percentile25
        End Get
    End Property


    '/ <override/>
    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder
        sb.Append(String.Concat("Count = " + Me.Count.ToString(), ", Values = { "))
        Dim n As Integer
        For n = 0 To (Math.Min(5, Count)) - 1
            If n > 0 Then
                sb.Append(", ")
            End If
            If Double.IsNaN(_values(n)) Then
                sb.Append("null")
            Else
                sb.Append(_values(n).ToString("G"))
            End If
        Next n
        If Count >= 5 Then
            sb.Append(", ...")
        End If
        sb.Append(" }")
        If Count > 1 Then
            sb.AppendFormat(", Med={0}", Me.Median)
            sb.AppendFormat(", P25={0}", Me.Percentile25)
            sb.AppendFormat(", P75={0}", Me.Percentile75)
            sb.AppendFormat(", PQ={0}", Me.PercentileQ)
        End If
        Return sb.ToString()
    End Function 'ToString
End Class 'StatisticsSummary



'/ <summary>
'/ Advanced summary example: Collects all unique integer entries of a column in a sorted vector. 
'/ </summary>

Public NotInheritable Class DistinctInt32CountSummary
    Inherits SummaryBase
    Private _values() As Int32

    Public Shared Empty As New DistinctInt32CountSummary(New Int32(-1) {})


    Public Shared Function CreateSummaryMethod(ByVal sd As SummaryDescriptor, ByVal record As Record) As ITreeTableSummary
        Dim obj As Object = sd.GetValue(record)
        Dim isNull As Boolean = obj Is Nothing OrElse TypeOf obj Is DBNull

        If isNull Then
            Return New DistinctInt32CountSummary(New Int32(-1) {})
        Else
            Dim val As Int32 = Convert.ToInt32(obj)
            Return New DistinctInt32CountSummary(New Int32() {val})
        End If
    End Function 'CreateSummaryMethod


    Public Sub New(ByVal values() As Int32)
        _values = values
    End Sub 'New


    Public ReadOnly Property Count() As Integer
        Get
            If _values Is Nothing Then
                Return 0
            End If
            Return _values.Length
        End Get
    End Property

    Public ReadOnly Property Values() As Int32()
        Get
            Return _values
        End Get
    End Property


    Public Overloads Overrides Function Combine(ByVal other As SummaryBase) As SummaryBase
        Return Combine(CType(other, DistinctInt32CountSummary))
    End Function 'Combine


    Function _Compare(ByVal x As Object, ByVal y As Object) As Integer
        Dim cmp As Integer
        Dim xIsNull As Boolean = x Is Nothing OrElse TypeOf x Is DBNull
        Dim yIsNull As Boolean = y Is Nothing OrElse TypeOf y Is DBNull

        If yIsNull AndAlso xIsNull Then
            cmp = 0
        ElseIf xIsNull Then
            cmp = -1
        ElseIf yIsNull Then
            cmp = 1
        Else
            cmp = CType(x, IComparable).CompareTo(y)
        End If
        Return cmp
    End Function '_Compare


    Public Overloads Function Combine(ByVal other As DistinctInt32CountSummary) As DistinctInt32CountSummary
        Dim d As New ArrayList(Count + other.Count)
        Dim others As Int32() = other.Values

        Dim n1 As Integer = 0
        Dim n2 As Integer = 0
        Dim len1 As Integer = _values.Length
        Dim len2 As Integer = others.Length
        While n1 < len1 AndAlso n2 < len2
            Dim cmp As Integer = _Compare(_values(n1), others(n2))
            If cmp > 0 Then
                d.Add(_values(n1))
                n1 += 1
            ElseIf cmp < 0 Then
                d.Add(others(n2))
                n2 += 1
            Else
                d.Add(_values(n1))
                n1 += 1
                n2 += 1
            End If
        End While
        While n1 < len1
            d.Add(_values(n1))
            n1 += 1
        End While
        While n2 < len2
            d.Add(others(n2))
            n2 += 1
        End While
        Return New DistinctInt32CountSummary(CType(d.ToArray(GetType(Int32)), Int32()))
    End Function 'Combine


    Public Overrides Function ToString() As String
        Dim sb As New StringBuilder
        sb.Append(String.Concat("Count = " + Me.Count.ToString(), ", Values = {"))
        Dim n As Integer
        For n = 0 To (Math.Min(10, Count)) - 1
            If n > 0 Then
                sb.Append(", ")
            End If
            sb.Append(Values(n).ToString())
        Next n
        If Count >= 10 Then
            sb.Append(", ...")
        End If
        sb.Append("}")
        Return sb.ToString()
    End Function 'ToString
End Class 'DistinctInt32CountSummary

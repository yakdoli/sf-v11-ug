#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel

Namespace RecursiveNestedCollection
    <TypeDescriptionProviderAttribute(GetType(BaseClassDescriptorProvider))> _
    Public Class BaseClass
        Private childs As Dictionary(Of String, List(Of BaseClass)) = New Dictionary(Of String, List(Of BaseClass))()
        Private id_Renamed As Integer
        Private parent As BaseClass
        Private dat As Dictionary(Of String, MyData) = New Dictionary(Of String, MyData)()

        Public fieldInt As Integer = 0
        Public fieldStr As String = ""

        Private Shared nextID_Renamed As Integer = 0
        Public Shared ReadOnly Property NextID() As Integer
            Get
                nextID_Renamed = nextID_Renamed + 1
                Return nextID_Renamed
            End Get
        End Property

        Public Sub New(ByVal parent As BaseClass)
            id_Renamed = NextID
            Me.parent = parent
        End Sub

        Public ReadOnly Property ChildTables() As Dictionary(Of String, List(Of BaseClass))
            Get
                Return childs
            End Get
        End Property

        Public ReadOnly Property ID() As Integer
            Get
                Return id_Renamed
            End Get
        End Property

        Public ReadOnly Property Data() As Dictionary(Of String, MyData)
            Get
                Return dat
            End Get
        End Property
    End Class

    Public Class FirstClass : Inherits BaseClass
        Public Sub New(ByVal parent As BaseClass, ByVal fieldInt As Integer, ByVal fieldStr As String)
            MyBase.New(parent)
            Me.fieldInt = fieldInt
            Me.fieldStr = fieldStr

            Me.Data.Add("Property1", New MyData("Data_FieldInt", Property1.ToString()))
            Me.Data.Add("Property2", New MyData("Data_FieldStr", Property2))
        End Sub

        Public ReadOnly Property Property1() As Integer
            Get
                Return fieldInt
            End Get
        End Property

        Public ReadOnly Property Property2() As String
            Get
                Return fieldStr
            End Get
        End Property

    End Class

    Public Class SecondClass : Inherits BaseClass
        Public Sub New(ByVal parent As BaseClass, ByVal fieldInt As Integer, ByVal fieldStr As String)
            MyBase.New(parent)
            Me.fieldInt = fieldInt
            Me.fieldStr = fieldStr

            Me.Data.Add("Property1", New MyData("Data_FieldOne", Property1))
            Me.Data.Add("Property2", New MyData("Data_FieldTwo", Property2.ToString()))
            Me.Data.Add("Property3", New MyData("Data_FieldThree", Property3))
        End Sub

        Public ReadOnly Property Property1() As String
            Get
                Return fieldInt.ToString()
            End Get
        End Property

        Public ReadOnly Property Property2() As Double
            Get
                Return CDbl(fieldInt) * 1.01234
            End Get
        End Property

        Public ReadOnly Property Property3() As String
            Get
                Return fieldStr
            End Get
        End Property
    End Class
End Namespace

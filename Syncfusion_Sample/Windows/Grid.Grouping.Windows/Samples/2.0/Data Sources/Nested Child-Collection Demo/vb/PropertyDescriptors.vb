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
Imports System.Diagnostics

Namespace RecursiveNestedCollection
#Region "PropertyDescriptor for BaseClass"
    Friend Class BaseClassDescriptor : Inherits CustomTypeDescriptor
        Private instance As BaseClass

        Public Sub New(ByVal instance As BaseClass)
            MyBase.New()
            Me.instance = instance
            If Me.instance Is Nothing Then
                Throw New ArgumentException("instance null!!!")
            End If
        End Sub

        Public Overrides Function GetProperties() As PropertyDescriptorCollection
            Return GetProperties(Nothing)
        End Function

        Public Overrides Function GetProperties(ByVal attributes As Attribute()) As PropertyDescriptorCollection
            Dim retProperties As List(Of PropertyDescriptor) = New List(Of PropertyDescriptor)()

            ' Data
            For Each attr As KeyValuePair(Of String, MyData) In instance.Data
                retProperties.Add(New BaseClassMyDataPropertyDescriptor(attr.Key))
            Next

            ' Children
            For Each child As KeyValuePair(Of String, List(Of BaseClass)) In instance.ChildTables
                retProperties.Add(New BaseClassChildrenPropertyDescriptor(child.Key))
            Next

            Return New PropertyDescriptorCollection(retProperties.ToArray())
        End Function
    End Class

    Friend Class BaseClassDescriptorProvider : Inherits TypeDescriptionProvider
        Public Overrides Function GetExtendedTypeDescriptor(ByVal instance As Object) As ICustomTypeDescriptor
            Debug.Print("BaseClassDescriptorProvider.GetExtendedTypeDescriptor( {0} )", (CType(instance, BaseClass)).fieldStr)
            Return New BaseClassDescriptor(CType(IIf(TypeOf instance Is BaseClass, instance, Nothing), BaseClass))
        End Function
    End Class
#End Region

#Region "PropertyDescriptor for ChildTables"
    Friend Class BaseClassChildrenPropertyDescriptor : Inherits PropertyDescriptor
        Public Sub New(ByVal name As String)
            MyBase.New(name, New Attribute() {})
        End Sub

        Public Overrides Function CanResetValue(ByVal component As Object) As Boolean
            Return False
        End Function

        Public Overrides ReadOnly Property ComponentType() As Type
            Get
                Return GetType(BaseClass)
            End Get
        End Property

        Public Overrides ReadOnly Property IsReadOnly() As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
            Return False
        End Function

        Public Overrides Sub ResetValue(ByVal component As Object)
            Throw New NotImplementedException("The method or operation is not implemented.")
        End Sub

        Public Overrides ReadOnly Property PropertyType() As Type
            Get
                Return GetType(List(Of BaseClass))
            End Get
        End Property

        Public Overrides Function GetValue(ByVal component As Object) As Object
            Dim retVal As List(Of BaseClass)

            If (CType(component, BaseClass)).ChildTables.ContainsKey(Name) Then
                retVal = (CType(component, BaseClass)).ChildTables(Name)
            Else
                retVal = New List(Of BaseClass)()
            End If


            Return retVal
        End Function

        Public Overrides Sub SetValue(ByVal component As Object, ByVal value As Object)
            CType(component, BaseClass).Data(Name) = CType(value, MyData)
        End Sub
    End Class

#End Region

#Region "PropertyDescriptor for Data"
    Friend Class BaseClassMyDataPropertyDescriptor : Inherits PropertyDescriptor
        Public Sub New(ByVal name As String)
            MyBase.New(name, New Attribute() {})
        End Sub

        Public Overrides Function CanResetValue(ByVal component As Object) As Boolean
            Return False
        End Function

        Public Overrides ReadOnly Property ComponentType() As Type
            Get
                Return GetType(BaseClass)
            End Get
        End Property

        Public Overrides ReadOnly Property IsReadOnly() As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
            Return False
        End Function

        Public Overrides Sub ResetValue(ByVal component As Object)
            Throw New NotImplementedException("The method or operation is not implemented.")
        End Sub

        Public Overrides ReadOnly Property PropertyType() As Type
            Get
                Return GetType(String)
            End Get
        End Property

        Public Overrides Function GetValue(ByVal component As Object) As Object
            Return (CType(component, BaseClass)).Data(Name).Value
        End Function


        Public Overrides Sub SetValue(ByVal component As Object, ByVal value As Object)
            CType(component, BaseClass).ChildTables(Name) = TryCast(value, List(Of BaseClass))
        End Sub
    End Class

#End Region
End Namespace

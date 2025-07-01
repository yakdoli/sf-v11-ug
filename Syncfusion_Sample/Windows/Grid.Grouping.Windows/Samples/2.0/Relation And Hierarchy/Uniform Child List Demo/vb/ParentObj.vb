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
Imports System.ComponentModel
Imports System.Text

Namespace UniformChildList_2005
    Public Class ParentObj : Implements INotifyPropertyChanged

        Private f1, f2 As String
        Private f3 As Integer
        Private childObj As BindingList(Of ChildObj) = New BindingList(Of ChildObj)()


        Public Sub New(ByVal f1 As String, ByVal f2 As String, ByVal f3 As Integer, ByVal ParamArray c As ChildObj())
            Me.f1 = f1
            Me.f2 = f2
            Me.f3 = f3
            For Each i As ChildObj In c
                childObj.Add(i)
            Next i
        End Sub

        Public Property Field1() As String
            Get
                Return f1
            End Get
            Set(ByVal value As String)
                If f1 <> value Then
                    f1 = value
                    RaisePropertyChanged("Field1")
                End If
            End Set
        End Property


        Public Property Field2() As String
            Get
                Return f2
            End Get
            Set(ByVal value As String)
                If f2 <> value Then
                    f2 = value
                    RaisePropertyChanged("Field2")
                End If
            End Set
        End Property


        Public Property Field3() As Integer
            Get
                Return f3
            End Get
            Set(ByVal value As Integer)
                If f3 <> value Then
                    f3 = value
                    RaisePropertyChanged("Field3")
                End If
            End Set
        End Property

        Public ReadOnly Property Child() As BindingList(Of ChildObj)
            Get
                Return childObj
            End Get
        End Property

        Sub RaisePropertyChanged(ByVal name As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
        End Sub 'RaisePropertyChanged 

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    End Class
End Namespace

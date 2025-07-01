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



'/ <summary>
'/		A strongly-typed collection of <see cref="Country"/> objects.
'/ </summary>
<Serializable()>  _
Public Class CountriesCollection
    Inherits ArrayList
    
    Default Public Shadows Property Item(index As Integer) As Country
        Get
            Return CType(MyBase.Item(index), Country)
        End Get
        Set
            MyBase.Item(index) = Value
        End Set
    End Property
    
    
    Public Shared Function CreateDefaultCollection() As CountriesCollection
        Dim countries As New CountriesCollection()
        countries.Add(New Country("USA", "United States"))
        countries.Add(New Country("CA", "Canada"))
        countries.Add(New Country("UK", "United Kingdom"))
        
        Return countries
    End Function 'CreateDefaultCollection
    
    
    Public Overrides ReadOnly Property IsReadOnly() As Boolean
        Get
            Return False
        End Get
    End Property
    
    
    Public Overrides ReadOnly Property IsFixedSize() As Boolean
        Get
            Return False
        End Get
    End Property
End Class 'CountriesCollection 


<Serializable()>  _
Public Class Country
    Private _code As String
    Private _name As String
    
    
    Public Sub New()
    End Sub 'New
    
    
    Public Sub New(strCode As String, strName As String)
        Me._code = strCode
        Me._name = strName
    End Sub 'New
    
    
    <Browsable(True)>  _
    Public Property CountryCode() As String
        Get
            Return _code
        End Get
        Set
            _code = value
        End Set
    End Property
    
    
    <Browsable(True)>  _
    Public Property Name() As String
        
        Get
            Return _name
        End Get
        Set
            _name = value
        End Set
    End Property
    
    
    Public Overrides Function ToString() As String
        Return Me._name + "(" + Me._code + ")"
    End Function 'ToString
End Class 'Country
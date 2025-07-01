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
'/		A strongly-typed collection of <see cref="USState"/> objects.
'/ </summary>
<Serializable()>  _
Public Class USStatesCollection
    Inherits ArrayList
    
    Default Public Shadows Property Item(index As Integer) As USState
        Get
            Return CType(MyBase.Item(index), USState)
        End Get
        Set
            MyBase.Item(index) = Value
        End Set
    End Property
    
    
    Public Shared Function CreateDefaultCollection() As USStatesCollection
        Dim states As New USStatesCollection()
        states.Add(New USState("AL", "Alabama"))
        states.Add(New USState("AK", "Alaska"))
        states.Add(New USState("AZ", "Arizona"))
        states.Add(New USState("AR", "Arkansas"))
        states.Add(New USState("CA", "California"))
        states.Add(New USState("CO", "Colorado"))
        states.Add(New USState("CT", "Connecticut"))
        states.Add(New USState("DC", "D.C."))
        states.Add(New USState("DE", "Delaware"))
        states.Add(New USState("FL", "Florida"))
        states.Add(New USState("GA", "Georgia"))
        states.Add(New USState("HI", "Hawaii"))
        states.Add(New USState("ID", "Idaho"))
        states.Add(New USState("IL", "Illinois"))
        states.Add(New USState("IN", "Indiana"))
        states.Add(New USState("IA", "Iowa"))
        states.Add(New USState("KS", "Kansas"))
        states.Add(New USState("KY", "Kentucky"))
        states.Add(New USState("LA", "Louisiana"))
        states.Add(New USState("ME", "Maine"))
        states.Add(New USState("MD", "Maryland"))
        states.Add(New USState("MA", "Massachusetts"))
        states.Add(New USState("MI", "Michigan"))
        states.Add(New USState("MN", "Minnesota"))
        states.Add(New USState("MS", "Mississippi"))
        states.Add(New USState("MO", "Missouri"))
        states.Add(New USState("MT", "Montana"))
        states.Add(New USState("NE", "Nebraska"))
        states.Add(New USState("NV", "Nevada"))
        states.Add(New USState("NH", "New Hampshire"))
        states.Add(New USState("NJ", "New Jersey"))
        states.Add(New USState("NM", "New Mexico"))
        states.Add(New USState("NY", "New York"))
        states.Add(New USState("NC", "North Carolina"))
        states.Add(New USState("ND", "North Dakota"))
        states.Add(New USState("OH", "Ohio"))
        states.Add(New USState("OK", "Oklahoma"))
        states.Add(New USState("OR", "Oregon"))
        states.Add(New USState("PA", "Pennsylvania"))
        states.Add(New USState("RI", "Rhode Island"))
        states.Add(New USState("SC", "South Carolina"))
        states.Add(New USState("SD", "South Dakota"))
        states.Add(New USState("TN", "Tennessee"))
        states.Add(New USState("TX", "Texas"))
        states.Add(New USState("UT", "Utah"))
        states.Add(New USState("VT", "Vermont"))
        states.Add(New USState("VA", "Virginia"))
        states.Add(New USState("WA", "Washington"))
        states.Add(New USState("WV", "West Virginia"))
        states.Add(New USState("WI", "Wisconsin"))
        states.Add(New USState("WY", "Wyoming"))
        states.Add(New USState("BC", "British Columbia"))
        states.Add(New USState("MB", "Manitoba"))
        states.Add(New USState("NB", "New Brunswick"))
        states.Add(New USState("NL", "Newfoundland and Labrador"))
        states.Add(New USState("NT", "Northwest Territories"))
        states.Add(New USState("NS", "Nova Scotia"))
        states.Add(New USState("NU", "Nunavut"))
        states.Add(New USState("ON", "Ontario"))
        states.Add(New USState("PE", "Prince Edward Island"))
        states.Add(New USState("QC", "Quebec"))
        states.Add(New USState("SK", "Saskatchewan"))
        states.Add(New USState("YT", "Yukon Territories"))
        
        Return states
    End Function 'CreateDefaultCollection
    
    
    Public Overrides ReadOnly Property IsReadOnly() As Boolean
        Get
            Return True
        End Get
    End Property
    
    
    Public Overrides ReadOnly Property IsFixedSize() As Boolean
        Get
            Return True
        End Get
    End Property
End Class 'USStatesCollection 


<Serializable()>  _
Public Class USState
    Private _code As String
    Private _name As String
    
    
    Public Sub New()
    End Sub 'New
    
    
    Public Sub New(key As String, name As String)
        Me._code = key
        Me._name = name
    End Sub 'New
    
    
    <Browsable(True)>  _
    Public Property Key() As String
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
End Class 'USState
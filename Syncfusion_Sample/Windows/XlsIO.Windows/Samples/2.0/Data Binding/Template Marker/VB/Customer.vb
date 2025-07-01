Imports System.Drawing
Namespace EssentialXlsIOSamples
    Class Customer

#Region "Members"
        Private m_salesPerson As String
        Private m_salesJanJune As String
        Private m_salesJulyDec As String
        Private m_change As Integer
#End Region

#Region "Prperties"
        Public Property SalesPerson() As String
            Get
                Return m_salesPerson
            End Get
            Set(ByVal value As String)
                m_salesPerson = value
            End Set
        End Property

        Public Property SalesJanJune() As String
            Get
                Return m_salesJanJune
            End Get
            Set(ByVal value As String)
                m_salesJanJune = value
            End Set
        End Property
        Public Property SalesJulyDec() As String
            Get
                Return m_salesJulyDec
            End Get
            Set(ByVal value As String)
                m_salesJulyDec = value
            End Set
        End Property

        Public Property Change() As Integer
            Get
                Return m_change
            End Get
            Set(ByVal value As Integer)
                m_change = value
            End Set
        End Property

#End Region

#Region "Intialization"
        Public Sub New()
        End Sub
        Public Sub New(ByVal name As String, ByVal juneToJuly As String, ByVal julyToDec As String, ByVal change As Integer)
            Me.m_salesPerson = name
            Me.m_salesJanJune = juneToJuly
            Me.m_salesJulyDec = julyToDec
            Me.m_change = change
        End Sub
#End Region

    End Class
End Namespace

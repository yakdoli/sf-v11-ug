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
        countries.Add(New Country("US", "United States"))
        countries.Add(New Country("CA", "Canada"))
        countries.Add(New Country("AF", "Afghanistan"))
        countries.Add(New Country("AL", "Albania"))
        countries.Add(New Country("DZ", "Algeria"))
        countries.Add(New Country("AS", "American Samoa"))
        countries.Add(New Country("AD", "Andorra"))
        countries.Add(New Country("AO", "Angola"))
        countries.Add(New Country("AI", "Anguilla"))
        countries.Add(New Country("AQ", "Antarctica"))
        countries.Add(New Country("AG", "Antigua and Barbuda"))
        countries.Add(New Country("AR", "Argentina"))
        countries.Add(New Country("AM", "Armenia"))
        countries.Add(New Country("AW", "Aruba"))
        countries.Add(New Country("AU", "Australia"))
        countries.Add(New Country("AT", "Austria"))
        countries.Add(New Country("AZ", "Azerbaijan"))
        countries.Add(New Country("BS", "Bahamas"))
        countries.Add(New Country("BH", "Bahrain"))
        countries.Add(New Country("BD", "Bangladesh"))
        countries.Add(New Country("BB", "Barbados"))
        countries.Add(New Country("BY", "Belarus"))
        countries.Add(New Country("BE", "Belgium"))
        countries.Add(New Country("BZ", "Belize"))
        countries.Add(New Country("BJ", "Benin"))
        countries.Add(New Country("BM", "Bermuda"))
        countries.Add(New Country("BT", "Bhutan"))
        countries.Add(New Country("BO", "Bolivia"))
        countries.Add(New Country("BA", "Bosnia and Herzegovina"))
        countries.Add(New Country("BW", "Botswana"))
        countries.Add(New Country("BV", "Bouvet Island"))
        countries.Add(New Country("BR", "Brazil"))
        countries.Add(New Country("IO", "British Indian Ocean Territory"))
        countries.Add(New Country("BN", "Brunei Darussalam"))
        countries.Add(New Country("BG", "Bulgaria"))
        countries.Add(New Country("BF", "Burkina Faso"))
        countries.Add(New Country("BI", "Burundi"))
        countries.Add(New Country("KH", "Cambodia"))
        countries.Add(New Country("CM", "Cameroon"))
        countries.Add(New Country("CV", "Cape Verde"))
        countries.Add(New Country("KY", "Cayman Islands"))
        countries.Add(New Country("CF", "Central African Republic"))
        countries.Add(New Country("TD", "Chad"))
        countries.Add(New Country("CL", "Chile"))
        countries.Add(New Country("CN", "China"))
        countries.Add(New Country("CX", "Christmas Island"))
        countries.Add(New Country("CC", "Cocos (Keeling) Islands"))
        countries.Add(New Country("CO", "Colombia"))
        countries.Add(New Country("KM", "Comoros"))
        countries.Add(New Country("CG", "Congo"))
        countries.Add(New Country("CK", "Cook Islands"))
        countries.Add(New Country("CR", "Costa Rica"))
        countries.Add(New Country("CI", "Cote D'Ivoire (Ivory Coast)"))
        countries.Add(New Country("HR", "Croatia (Hrvatska)"))
        countries.Add(New Country("CU", "Cuba"))
        countries.Add(New Country("CY", "Cyprus"))
        countries.Add(New Country("CZ", "Czech Republic"))
        countries.Add(New Country("DK", "Denmark"))
        countries.Add(New Country("DJ", "Djibouti"))
        countries.Add(New Country("DM", "Dominica"))
        countries.Add(New Country("DO", "Dominican Republic"))
        countries.Add(New Country("TP", "East Timor"))
        countries.Add(New Country("EC", "Ecuador"))
        countries.Add(New Country("EG", "Egypt"))
        countries.Add(New Country("SV", "El Salvador"))
        countries.Add(New Country("GQ", "Equatorial Guinea"))
        countries.Add(New Country("ER", "Eritrea"))
        countries.Add(New Country("EE", "Estonia"))
        countries.Add(New Country("ET", "Ethiopia"))
        countries.Add(New Country("FK", "Falkland Islands (Malvinas)"))
        countries.Add(New Country("FO", "Faroe Islands"))
        countries.Add(New Country("FJ", "Fiji"))
        countries.Add(New Country("FI", "Finland"))
        countries.Add(New Country("FR", "France"))
        countries.Add(New Country("GF", "French Guiana"))
        countries.Add(New Country("PF", "French Polynesia"))
        countries.Add(New Country("TF", "French Southern Territories"))
        countries.Add(New Country("GA", "Gabon"))
        countries.Add(New Country("GM", "Gambia"))
        countries.Add(New Country("GZ", "Gaza"))
        countries.Add(New Country("GE", "Georgia"))
        countries.Add(New Country("DE", "Germany"))
        countries.Add(New Country("GH", "Ghana"))
        countries.Add(New Country("GI", "Gibraltar"))
        countries.Add(New Country("GR", "Greece"))
        countries.Add(New Country("GL", "Greenland"))
        countries.Add(New Country("GD", "Grenada"))
        countries.Add(New Country("GP", "Guadeloupe"))
        countries.Add(New Country("GU", "Guam"))
        countries.Add(New Country("GT", "Guatemala"))
        countries.Add(New Country("GN", "Guinea"))
        countries.Add(New Country("GW", "Guinea-Bissau"))
        countries.Add(New Country("GY", "Guyana"))
        countries.Add(New Country("HT", "Haiti"))
        countries.Add(New Country("HM", "Heard and McDonald Islands"))
        countries.Add(New Country("HN", "Honduras"))
        countries.Add(New Country("HK", "Hong Kong"))
        countries.Add(New Country("HU", "Hungary"))
        countries.Add(New Country("IS", "Iceland"))
        countries.Add(New Country("IN", "India"))
        countries.Add(New Country("ID", "Indonesia"))
        countries.Add(New Country("IR", "Iran"))
        countries.Add(New Country("IQ", "Iraq"))
        countries.Add(New Country("IE", "Ireland"))
        countries.Add(New Country("IL", "Israel"))
        countries.Add(New Country("IT", "Italy"))
        countries.Add(New Country("JM", "Jamaica"))
        countries.Add(New Country("JP", "Japan"))
        countries.Add(New Country("JO", "Jordan"))
        countries.Add(New Country("KZ", "Kazakhstan"))
        countries.Add(New Country("KE", "Kenya"))
        countries.Add(New Country("KI", "Kiribati"))
        countries.Add(New Country("KP", "Korea (North)"))
        countries.Add(New Country("KR", "Korea (South)"))
        countries.Add(New Country("KW", "Kuwait"))
        countries.Add(New Country("KG", "Kyrgyzstan"))
        countries.Add(New Country("LA", "Laos"))
        countries.Add(New Country("LV", "Latvia"))
        countries.Add(New Country("LB", "Lebanon"))
        countries.Add(New Country("LS", "Lesotho"))
        countries.Add(New Country("LR", "Liberia"))
        countries.Add(New Country("LY", "Libya"))
        countries.Add(New Country("LI", "Liechtenstein"))
        countries.Add(New Country("LT", "Lithuania"))
        countries.Add(New Country("LU", "Luxembourg"))
        countries.Add(New Country("MO", "Macau"))
        countries.Add(New Country("MK", "Macedonia"))
        countries.Add(New Country("MG", "Madagascar"))
        countries.Add(New Country("MW", "Malawi"))
        countries.Add(New Country("MY", "Malaysia"))
        countries.Add(New Country("MV", "Maldives"))
        countries.Add(New Country("ML", "Mali"))
        countries.Add(New Country("MT", "Malta"))
        countries.Add(New Country("MH", "Marshall Islands"))
        countries.Add(New Country("MQ", "Martinique"))
        countries.Add(New Country("MR", "Mauritania"))
        countries.Add(New Country("MU", "Mauritius"))
        countries.Add(New Country("YT", "Mayotte"))
        countries.Add(New Country("MX", "Mexico"))
        countries.Add(New Country("FM", "Micronesia"))
        countries.Add(New Country("MD", "Moldova"))
        countries.Add(New Country("MC", "Monaco"))
        countries.Add(New Country("MN", "Mongolia"))
        countries.Add(New Country("MS", "Montserrat"))
        countries.Add(New Country("MA", "Morocco"))
        countries.Add(New Country("MZ", "Mozambique"))
        countries.Add(New Country("MM", "Myanmar"))
        countries.Add(New Country("NA", "Namibia"))
        countries.Add(New Country("NR", "Nauru"))
        countries.Add(New Country("NP", "Nepal"))
        countries.Add(New Country("NL", "Netherlands"))
        countries.Add(New Country("AN", "Netherlands Antilles"))
        countries.Add(New Country("NC", "New Caledonia"))
        countries.Add(New Country("NZ", "New Zealand"))
        countries.Add(New Country("NI", "Nicaragua"))
        countries.Add(New Country("NE", "Niger"))
        countries.Add(New Country("NG", "Nigeria"))
        countries.Add(New Country("NU", "Niue"))
        countries.Add(New Country("NF", "Norfolk Island"))
        countries.Add(New Country("MP", "Northern Mariana Islands"))
        countries.Add(New Country("NO", "Norway"))
        countries.Add(New Country("OM", "Oman"))
        countries.Add(New Country("PK", "Pakistan"))
        countries.Add(New Country("PW", "Palau"))
        countries.Add(New Country("PA", "Panama"))
        countries.Add(New Country("PG", "Papua New Guinea"))
        countries.Add(New Country("PY", "Paraguay"))
        countries.Add(New Country("PE", "Peru"))
        countries.Add(New Country("PH", "Philippines"))
        countries.Add(New Country("PN", "Pitcairn"))
        countries.Add(New Country("PL", "Poland"))
        countries.Add(New Country("PT", "Portugal"))
        countries.Add(New Country("PR", "Puerto Rico"))
        countries.Add(New Country("QA", "Qatar"))
        countries.Add(New Country("RE", "Reunion"))
        countries.Add(New Country("RO", "Romania"))
        countries.Add(New Country("RU", "Russian Federation"))
        countries.Add(New Country("RW", "Rwanda"))
        countries.Add(New Country("KN", "Saint Kitts and Nevis"))
        countries.Add(New Country("LC", "Saint Lucia"))
        countries.Add(New Country("VC", "Saint Vincent and the Grenadines"))
        countries.Add(New Country("WS", "Samoa"))
        countries.Add(New Country("SM", "San Marino"))
        countries.Add(New Country("ST", "Sao Tome and Principe"))
        countries.Add(New Country("SA", "Saudi Arabia"))
        countries.Add(New Country("SN", "Senegal"))
        countries.Add(New Country("SC", "Seychelles"))
        countries.Add(New Country("SL", "Sierra Leone"))
        countries.Add(New Country("SG", "Singapore"))
        countries.Add(New Country("SK", "Slovak Republic"))
        countries.Add(New Country("SI", "Slovenia"))
        countries.Add(New Country("SB", "Solomon Islands"))
        countries.Add(New Country("SO", "Somalia"))
        countries.Add(New Country("ZA", "South Africa"))
        countries.Add(New Country("ES", "Spain"))
        countries.Add(New Country("LK", "Sri Lanka"))
        countries.Add(New Country("SH", "St. Helena"))
        countries.Add(New Country("PM", "St. Pierre and Miquelon"))
        countries.Add(New Country("SD", "Sudan"))
        countries.Add(New Country("SR", "Suriname"))
        countries.Add(New Country("SJ", "Svalbard and Jan Mayen Islands"))
        countries.Add(New Country("SZ", "Swaziland"))
        countries.Add(New Country("SE", "Sweden"))
        countries.Add(New Country("CH", "Switzerland"))
        countries.Add(New Country("SY", "Syria"))
        countries.Add(New Country("TW", "Taiwan"))
        countries.Add(New Country("TJ", "Tajikistan"))
        countries.Add(New Country("TZ", "Tanzania"))
        countries.Add(New Country("TH", "Thailand"))
        countries.Add(New Country("TG", "Togo"))
        countries.Add(New Country("TK", "Tokelau"))
        countries.Add(New Country("TO", "Tonga"))
        countries.Add(New Country("TT", "Trinidad and Tobago"))
        countries.Add(New Country("TN", "Tunisia"))
        countries.Add(New Country("TR", "Turkey"))
        countries.Add(New Country("TM", "Turkmenistan"))
        countries.Add(New Country("TC", "Turks and Caicos Islands"))
        countries.Add(New Country("TV", "Tuvalu"))
        countries.Add(New Country("UG", "Uganda"))
        countries.Add(New Country("UA", "Ukraine"))
        countries.Add(New Country("AE", "United Arab Emirates"))
        countries.Add(New Country("GB", "United Kingdom"))
        countries.Add(New Country("UY", "Uruguay"))
        countries.Add(New Country("UM", "US Minor Outlying Islands"))
        countries.Add(New Country("UZ", "Uzbekistan"))
        countries.Add(New Country("VU", "Vanuatu"))
        countries.Add(New Country("VA", "Vatican City State (Holy See)"))
        countries.Add(New Country("VE", "Venezuela"))
        countries.Add(New Country("VN", "Viet Nam"))
        countries.Add(New Country("VG", "Virgin Islands (British)"))
        countries.Add(New Country("VI", "Virgin Islands (U.S.)"))
        countries.Add(New Country("WF", "Wallis and Futuna Islands"))
        countries.Add(New Country("WB", "West Bank"))
        countries.Add(New Country("EH", "Western Sahara"))
        countries.Add(New Country("YE", "Yemen"))
        countries.Add(New Country("YU", "Yugoslavia"))
        countries.Add(New Country("ZR", "Zaire"))
        countries.Add(New Country("ZM", "Zambia"))
        countries.Add(New Country("ZW", "Zimbabwe"))
        
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
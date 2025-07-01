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


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.MetroForm
Imports Syncfusion.GridHelperClasses

Namespace ForeignKeyReference
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
    Public Class Form1 : Inherits Syncfusion.Windows.Forms.MetroForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
        Private usStates As DataTable = New DataTable("USStates")
        Private WithEvents gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
        Private WithEvents panel1 As System.Windows.Forms.Panel
        Private WithEvents radHelper As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Private WithEvents radManual As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Private countries As DataTable = New DataTable("Countries")

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            PopulateUSStates()
            PopulateCountries()
            InitializeComponent()
            Try
                Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch ex As Exception

            End Try


            SetupManualRelation()


            Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro

        End Sub

        Private Function GetIconFile(ByVal bitmapName As String) As String
            For n As Integer = 0 To 9
                If System.IO.File.Exists(bitmapName) Then
                    Return bitmapName
                End If

                bitmapName = "..\" & bitmapName
            Next n

            Return bitmapName
        End Function


#Region "DataTables"

        Private Function CreateMainTable() As DataTable
            Dim table As DataTable = New DataTable()
            table.Columns.Add("Id", GetType(String))
            table.Columns.Add("Country", GetType(String))
            table.Columns.Add("State", GetType(String))

            ' and then add a few rows:
            For i As Integer = 0 To 49
                table.Rows.Add(table.NewRow())
                table.Rows(i)(0) = i
                table.Rows(i)(1) = countries.Rows(i Mod 8)("CountryCode").ToString()
                table.Rows(i)(2) = usStates.Rows(i Mod 8)("Key").ToString()
            Next i
            Return table
        End Function

        Private Sub PopulateUSStates()
            usStates.Columns.Add("Key")
            usStates.Columns.Add("Name")
            usStates.Rows.Add(New Object() {"AL", "Alabama"})
            usStates.Rows.Add(New Object() {"AK", "Alaska"})
            usStates.Rows.Add(New Object() {"AZ", "Arizona"})
            usStates.Rows.Add(New Object() {"AR", "Arkansas"})
            usStates.Rows.Add(New Object() {"CA", "California"})
            usStates.Rows.Add(New Object() {"CO", "Colorado"})
            usStates.Rows.Add(New Object() {"CT", "Connecticut"})
            usStates.Rows.Add(New Object() {"DC", "D.C."})
            usStates.Rows.Add(New Object() {"DE", "Delaware"})
            usStates.Rows.Add(New Object() {"FL", "Florida"})
            usStates.Rows.Add(New Object() {"GA", "Georgia"})
            usStates.Rows.Add(New Object() {"HI", "Hawaii"})
            usStates.Rows.Add(New Object() {"ID", "Idaho"})
            usStates.Rows.Add(New Object() {"IL", "Illinois"})
            usStates.Rows.Add(New Object() {"IN", "Indiana"})
            usStates.Rows.Add(New Object() {"IA", "Iowa"})
            usStates.Rows.Add(New Object() {"KS", "Kansas"})
            usStates.Rows.Add(New Object() {"KY", "Kentucky"})
            usStates.Rows.Add(New Object() {"LA", "Louisiana"})
            usStates.Rows.Add(New Object() {"ME", "Maine"})
            usStates.Rows.Add(New Object() {"MD", "Maryland"})
            usStates.Rows.Add(New Object() {"MA", "Massachusetts"})
            usStates.Rows.Add(New Object() {"MI", "Michigan"})
            usStates.Rows.Add(New Object() {"MN", "Minnesota"})
            usStates.Rows.Add(New Object() {"MS", "Mississippi"})
            usStates.Rows.Add(New Object() {"MO", "Missouri"})
            usStates.Rows.Add(New Object() {"MT", "Montana"})
            usStates.Rows.Add(New Object() {"NE", "Nebraska"})
            usStates.Rows.Add(New Object() {"NV", "Nevada"})
            usStates.Rows.Add(New Object() {"NH", "New Hampshire"})
            usStates.Rows.Add(New Object() {"NJ", "New Jersey"})
            usStates.Rows.Add(New Object() {"NM", "New Mexico"})
            usStates.Rows.Add(New Object() {"NY", "New York"})
            usStates.Rows.Add(New Object() {"NC", "North Carolina"})
            usStates.Rows.Add(New Object() {"ND", "North Dakota"})
            usStates.Rows.Add(New Object() {"OH", "Ohio"})
            usStates.Rows.Add(New Object() {"OK", "Oklahoma"})
            usStates.Rows.Add(New Object() {"OR", "Oregon"})
            usStates.Rows.Add(New Object() {"PA", "Pennsylvania"})
            usStates.Rows.Add(New Object() {"RI", "Rhode Island"})
            usStates.Rows.Add(New Object() {"SC", "South Carolina"})
            usStates.Rows.Add(New Object() {"SD", "South Dakota"})
            usStates.Rows.Add(New Object() {"TN", "Tennessee"})
            usStates.Rows.Add(New Object() {"TX", "Texas"})
            usStates.Rows.Add(New Object() {"UT", "Utah"})
            usStates.Rows.Add(New Object() {"VT", "Vermont"})
            usStates.Rows.Add(New Object() {"VA", "Virginia"})
            usStates.Rows.Add(New Object() {"WA", "Washington"})
            usStates.Rows.Add(New Object() {"WV", "West Virginia"})
            usStates.Rows.Add(New Object() {"WI", "Wisconsin"})
            usStates.Rows.Add(New Object() {"WY", "Wyoming"})
            usStates.Rows.Add(New Object() {"BC", "British Columbia"})
            usStates.Rows.Add(New Object() {"MB", "Manitoba"})
            usStates.Rows.Add(New Object() {"NB", "New Brunswick"})
            usStates.Rows.Add(New Object() {"NL", "Newfoundland and Labrador"})
            usStates.Rows.Add(New Object() {"NT", "Northwest Territories"})
            usStates.Rows.Add(New Object() {"NS", "Nova Scotia"})
            usStates.Rows.Add(New Object() {"NU", "Nunavut"})
            usStates.Rows.Add(New Object() {"ON", "Ontario"})
            usStates.Rows.Add(New Object() {"PE", "Prince Edward Island"})
            usStates.Rows.Add(New Object() {"QC", "Quebec"})
            usStates.Rows.Add(New Object() {"SK", "Saskatchewan"})
            usStates.Rows.Add(New Object() {"YT", "Yukon Territories"})
        End Sub

        Private Sub PopulateCountries()
            countries.Columns.Add("CountryCode")
            countries.Columns.Add("CountryName")
            countries.Rows.Add(New Object() {"US", "United States"})
            countries.Rows.Add(New Object() {"CA", "Canada"})
            countries.Rows.Add(New Object() {"AF", "Afghanistan"})
            countries.Rows.Add(New Object() {"AL", "Albania"})
            countries.Rows.Add(New Object() {"DZ", "Algeria"})
            countries.Rows.Add(New Object() {"AS", "American Samoa"})
            countries.Rows.Add(New Object() {"AD", "Andorra"})
            countries.Rows.Add(New Object() {"AO", "Angola"})
            countries.Rows.Add(New Object() {"AI", "Anguilla"})
            countries.Rows.Add(New Object() {"AQ", "Antarctica"})
            countries.Rows.Add(New Object() {"AG", "Antigua and Barbuda"})
            countries.Rows.Add(New Object() {"AR", "Argentina"})
            countries.Rows.Add(New Object() {"AM", "Armenia"})
            countries.Rows.Add(New Object() {"AW", "Aruba"})
            countries.Rows.Add(New Object() {"AU", "Australia"})
            countries.Rows.Add(New Object() {"AT", "Austria"})
            countries.Rows.Add(New Object() {"AZ", "Azerbaijan"})
            countries.Rows.Add(New Object() {"BS", "Bahamas"})
            countries.Rows.Add(New Object() {"BH", "Bahrain"})
            countries.Rows.Add(New Object() {"BD", "Bangladesh"})
            countries.Rows.Add(New Object() {"BB", "Barbados"})
            countries.Rows.Add(New Object() {"BY", "Belarus"})
            countries.Rows.Add(New Object() {"BE", "Belgium"})
            countries.Rows.Add(New Object() {"BZ", "Belize"})
            countries.Rows.Add(New Object() {"BJ", "Benin"})
            countries.Rows.Add(New Object() {"BM", "Bermuda"})
            countries.Rows.Add(New Object() {"BT", "Bhutan"})
            countries.Rows.Add(New Object() {"BO", "Bolivia"})
            countries.Rows.Add(New Object() {"BA", "Bosnia and Herzegovina"})
            countries.Rows.Add(New Object() {"BW", "Botswana"})
            countries.Rows.Add(New Object() {"BV", "Bouvet Island"})
            countries.Rows.Add(New Object() {"BR", "Brazil"})
            countries.Rows.Add(New Object() {"IO", "British Indian Ocean Territory"})
            countries.Rows.Add(New Object() {"BN", "Brunei Darussalam"})
            countries.Rows.Add(New Object() {"BG", "Bulgaria"})
            countries.Rows.Add(New Object() {"BF", "Burkina Faso"})
            countries.Rows.Add(New Object() {"BI", "Burundi"})
            countries.Rows.Add(New Object() {"KH", "Cambodia"})
            countries.Rows.Add(New Object() {"CM", "Cameroon"})
            countries.Rows.Add(New Object() {"CV", "Cape Verde"})
            countries.Rows.Add(New Object() {"KY", "Cayman Islands"})
            countries.Rows.Add(New Object() {"CF", "Central African Republic"})
            countries.Rows.Add(New Object() {"TD", "Chad"})
            countries.Rows.Add(New Object() {"CL", "Chile"})
            countries.Rows.Add(New Object() {"CN", "China"})
            countries.Rows.Add(New Object() {"CX", "Christmas Island"})
            countries.Rows.Add(New Object() {"CC", "Cocos (Keeling) Islands"})
            countries.Rows.Add(New Object() {"CO", "Colombia"})
            countries.Rows.Add(New Object() {"KM", "Comoros"})
            countries.Rows.Add(New Object() {"CG", "Congo"})
            countries.Rows.Add(New Object() {"CK", "Cook Islands"})
            countries.Rows.Add(New Object() {"CR", "Costa Rica"})
            countries.Rows.Add(New Object() {"CI", "Cote D'Ivoire (Ivory Coast)"})
            countries.Rows.Add(New Object() {"HR", "Croatia (Hrvatska)"})
            countries.Rows.Add(New Object() {"CU", "Cuba"})
            countries.Rows.Add(New Object() {"CY", "Cyprus"})
            countries.Rows.Add(New Object() {"CZ", "Czech Republic"})
            countries.Rows.Add(New Object() {"DK", "Denmark"})
            countries.Rows.Add(New Object() {"DJ", "Djibouti"})
            countries.Rows.Add(New Object() {"DM", "Dominica"})
            countries.Rows.Add(New Object() {"DO", "Dominican Republic"})
            countries.Rows.Add(New Object() {"TP", "East Timor"})
            countries.Rows.Add(New Object() {"EC", "Ecuador"})
            countries.Rows.Add(New Object() {"EG", "Egypt"})
            countries.Rows.Add(New Object() {"SV", "El Salvador"})
            countries.Rows.Add(New Object() {"GQ", "Equatorial Guinea"})
            countries.Rows.Add(New Object() {"ER", "Eritrea"})
            countries.Rows.Add(New Object() {"EE", "Estonia"})
            countries.Rows.Add(New Object() {"ET", "Ethiopia"})
            countries.Rows.Add(New Object() {"FK", "Falkland Islands (Malvinas)"})
            countries.Rows.Add(New Object() {"FO", "Faroe Islands"})
            countries.Rows.Add(New Object() {"FJ", "Fiji"})
            countries.Rows.Add(New Object() {"FI", "Finland"})
            countries.Rows.Add(New Object() {"FR", "France"})
            countries.Rows.Add(New Object() {"GF", "French Guiana"})
            countries.Rows.Add(New Object() {"PF", "French Polynesia"})
            countries.Rows.Add(New Object() {"TF", "French Southern Territories"})
            countries.Rows.Add(New Object() {"GA", "Gabon"})
            countries.Rows.Add(New Object() {"GM", "Gambia"})
            countries.Rows.Add(New Object() {"GZ", "Gaza"})
            countries.Rows.Add(New Object() {"GE", "Georgia"})
            countries.Rows.Add(New Object() {"DE", "Germany"})
            countries.Rows.Add(New Object() {"GH", "Ghana"})
            countries.Rows.Add(New Object() {"GI", "Gibraltar"})
            countries.Rows.Add(New Object() {"GR", "Greece"})
            countries.Rows.Add(New Object() {"GL", "Greenland"})
            countries.Rows.Add(New Object() {"GD", "Grenada"})
            countries.Rows.Add(New Object() {"GP", "Guadeloupe"})
            countries.Rows.Add(New Object() {"GU", "Guam"})
            countries.Rows.Add(New Object() {"GT", "Guatemala"})
            countries.Rows.Add(New Object() {"GN", "Guinea"})
            countries.Rows.Add(New Object() {"GW", "Guinea-Bissau"})
            countries.Rows.Add(New Object() {"GY", "Guyana"})
            countries.Rows.Add(New Object() {"HT", "Haiti"})
            countries.Rows.Add(New Object() {"HM", "Heard and McDonald Islands"})
            countries.Rows.Add(New Object() {"HN", "Honduras"})
            countries.Rows.Add(New Object() {"HK", "Hong Kong"})
            countries.Rows.Add(New Object() {"HU", "Hungary"})
            countries.Rows.Add(New Object() {"IS", "Iceland"})
            countries.Rows.Add(New Object() {"IN", "India"})
            countries.Rows.Add(New Object() {"ID", "Indonesia"})
            countries.Rows.Add(New Object() {"IR", "Iran"})
            countries.Rows.Add(New Object() {"IQ", "Iraq"})
            countries.Rows.Add(New Object() {"IE", "Ireland"})
            countries.Rows.Add(New Object() {"IL", "Israel"})
            countries.Rows.Add(New Object() {"IT", "Italy"})
            countries.Rows.Add(New Object() {"JM", "Jamaica"})
            countries.Rows.Add(New Object() {"JP", "Japan"})
            countries.Rows.Add(New Object() {"JO", "Jordan"})
            countries.Rows.Add(New Object() {"KZ", "Kazakhstan"})
            countries.Rows.Add(New Object() {"KE", "Kenya"})
            countries.Rows.Add(New Object() {"KI", "Kiribati"})
            countries.Rows.Add(New Object() {"KP", "Korea (North)"})
            countries.Rows.Add(New Object() {"KR", "Korea (South)"})
            countries.Rows.Add(New Object() {"KW", "Kuwait"})
            countries.Rows.Add(New Object() {"KG", "Kyrgyzstan"})
            countries.Rows.Add(New Object() {"LA", "Laos"})
            countries.Rows.Add(New Object() {"LV", "Latvia"})
            countries.Rows.Add(New Object() {"LB", "Lebanon"})
            countries.Rows.Add(New Object() {"LS", "Lesotho"})
            countries.Rows.Add(New Object() {"LR", "Liberia"})
            countries.Rows.Add(New Object() {"LY", "Libya"})
            countries.Rows.Add(New Object() {"LI", "Liechtenstein"})
            countries.Rows.Add(New Object() {"LT", "Lithuania"})
            countries.Rows.Add(New Object() {"LU", "Luxembourg"})
            countries.Rows.Add(New Object() {"MO", "Macau"})
            countries.Rows.Add(New Object() {"MK", "Macedonia"})
            countries.Rows.Add(New Object() {"MG", "Madagascar"})
            countries.Rows.Add(New Object() {"MW", "Malawi"})
            countries.Rows.Add(New Object() {"MY", "Malaysia"})
            countries.Rows.Add(New Object() {"MV", "Maldives"})
            countries.Rows.Add(New Object() {"ML", "Mali"})
            countries.Rows.Add(New Object() {"MT", "Malta"})
            countries.Rows.Add(New Object() {"MH", "Marshall Islands"})
            countries.Rows.Add(New Object() {"MQ", "Martinique"})
            countries.Rows.Add(New Object() {"MR", "Mauritania"})
            countries.Rows.Add(New Object() {"MU", "Mauritius"})
            countries.Rows.Add(New Object() {"YT", "Mayotte"})
            countries.Rows.Add(New Object() {"MX", "Mexico"})
            countries.Rows.Add(New Object() {"FM", "Micronesia"})
            countries.Rows.Add(New Object() {"MD", "Moldova"})
            countries.Rows.Add(New Object() {"MC", "Monaco"})
            countries.Rows.Add(New Object() {"MN", "Mongolia"})
            countries.Rows.Add(New Object() {"MS", "Montserrat"})
            countries.Rows.Add(New Object() {"MA", "Morocco"})
            countries.Rows.Add(New Object() {"MZ", "Mozambique"})
            countries.Rows.Add(New Object() {"MM", "Myanmar"})
            countries.Rows.Add(New Object() {"NA", "Namibia"})
            countries.Rows.Add(New Object() {"NR", "Nauru"})
            countries.Rows.Add(New Object() {"NP", "Nepal"})
            countries.Rows.Add(New Object() {"NL", "Netherlands"})
            countries.Rows.Add(New Object() {"AN", "Netherlands Antilles"})
            countries.Rows.Add(New Object() {"NC", "New Caledonia"})
            countries.Rows.Add(New Object() {"NZ", "New Zealand"})
            countries.Rows.Add(New Object() {"NI", "Nicaragua"})
            countries.Rows.Add(New Object() {"NE", "Niger"})
            countries.Rows.Add(New Object() {"NG", "Nigeria"})
            countries.Rows.Add(New Object() {"NU", "Niue"})
            countries.Rows.Add(New Object() {"NF", "Norfolk Island"})
            countries.Rows.Add(New Object() {"MP", "Northern Mariana Islands"})
            countries.Rows.Add(New Object() {"NO", "Norway"})
            countries.Rows.Add(New Object() {"OM", "Oman"})
            countries.Rows.Add(New Object() {"PK", "Pakistan"})
            countries.Rows.Add(New Object() {"PW", "Palau"})
            countries.Rows.Add(New Object() {"PA", "Panama"})
            countries.Rows.Add(New Object() {"PG", "Papua New Guinea"})
            countries.Rows.Add(New Object() {"PY", "Paraguay"})
            countries.Rows.Add(New Object() {"PE", "Peru"})
            countries.Rows.Add(New Object() {"PH", "Philippines"})
            countries.Rows.Add(New Object() {"PN", "Pitcairn"})
            countries.Rows.Add(New Object() {"PL", "Poland"})
            countries.Rows.Add(New Object() {"PT", "Portugal"})
            countries.Rows.Add(New Object() {"PR", "Puerto Rico"})
            countries.Rows.Add(New Object() {"QA", "Qatar"})
            countries.Rows.Add(New Object() {"RE", "Reunion"})
            countries.Rows.Add(New Object() {"RO", "Romania"})
            countries.Rows.Add(New Object() {"RU", "Russian Federation"})
            countries.Rows.Add(New Object() {"RW", "Rwanda"})
            countries.Rows.Add(New Object() {"KN", "Saint Kitts and Nevis"})
            countries.Rows.Add(New Object() {"LC", "Saint Lucia"})
            countries.Rows.Add(New Object() {"VC", "Saint Vincent and the Grenadines"})
            countries.Rows.Add(New Object() {"WS", "Samoa"})
            countries.Rows.Add(New Object() {"SM", "San Marino"})
            countries.Rows.Add(New Object() {"ST", "Sao Tome and Principe"})
            countries.Rows.Add(New Object() {"SA", "Saudi Arabia"})
            countries.Rows.Add(New Object() {"SN", "Senegal"})
            countries.Rows.Add(New Object() {"SC", "Seychelles"})
            countries.Rows.Add(New Object() {"SL", "Sierra Leone"})
            countries.Rows.Add(New Object() {"SG", "Singapore"})
            countries.Rows.Add(New Object() {"SK", "Slovak Republic"})
            countries.Rows.Add(New Object() {"SI", "Slovenia"})
            countries.Rows.Add(New Object() {"SB", "Solomon Islands"})
            countries.Rows.Add(New Object() {"SO", "Somalia"})
            countries.Rows.Add(New Object() {"ZA", "South Africa"})
            countries.Rows.Add(New Object() {"ES", "Spain"})
            countries.Rows.Add(New Object() {"LK", "Sri Lanka"})
            countries.Rows.Add(New Object() {"SH", "St. Helena"})
            countries.Rows.Add(New Object() {"PM", "St. Pierre and Miquelon"})
            countries.Rows.Add(New Object() {"SD", "Sudan"})
            countries.Rows.Add(New Object() {"SR", "Suriname"})
            countries.Rows.Add(New Object() {"SJ", "Svalbard and Jan Mayen Islands"})
            countries.Rows.Add(New Object() {"SZ", "Swaziland"})
            countries.Rows.Add(New Object() {"SE", "Sweden"})
            countries.Rows.Add(New Object() {"CH", "Switzerland"})
            countries.Rows.Add(New Object() {"SY", "Syria"})
            countries.Rows.Add(New Object() {"TW", "Taiwan"})
            countries.Rows.Add(New Object() {"TJ", "Tajikistan"})
            countries.Rows.Add(New Object() {"TZ", "Tanzania"})
            countries.Rows.Add(New Object() {"TH", "Thailand"})
            countries.Rows.Add(New Object() {"TG", "Togo"})
            countries.Rows.Add(New Object() {"TK", "Tokelau"})
            countries.Rows.Add(New Object() {"TO", "Tonga"})
            countries.Rows.Add(New Object() {"TT", "Trinidad and Tobago"})
            countries.Rows.Add(New Object() {"TN", "Tunisia"})
            countries.Rows.Add(New Object() {"TR", "Turkey"})
            countries.Rows.Add(New Object() {"TM", "Turkmenistan"})
            countries.Rows.Add(New Object() {"TC", "Turks and Caicos Islands"})
            countries.Rows.Add(New Object() {"TV", "Tuvalu"})
            countries.Rows.Add(New Object() {"UG", "Uganda"})
            countries.Rows.Add(New Object() {"UA", "Ukraine"})
            countries.Rows.Add(New Object() {"AE", "United Arab Emirates"})
            countries.Rows.Add(New Object() {"GB", "United Kingdom"})
            countries.Rows.Add(New Object() {"UY", "Uruguay"})
            countries.Rows.Add(New Object() {"UM", "US Minor Outlying Islands"})
            countries.Rows.Add(New Object() {"UZ", "Uzbekistan"})
            countries.Rows.Add(New Object() {"VU", "Vanuatu"})
            countries.Rows.Add(New Object() {"VA", "Vatican City State (Holy See)"})
            countries.Rows.Add(New Object() {"VE", "Venezuela"})
            countries.Rows.Add(New Object() {"VN", "Viet Nam"})
            countries.Rows.Add(New Object() {"VG", "Virgin Islands (British)"})
            countries.Rows.Add(New Object() {"VI", "Virgin Islands (U.S.)"})
            countries.Rows.Add(New Object() {"WF", "Wallis and Futuna Islands"})
            countries.Rows.Add(New Object() {"WB", "West Bank"})
            countries.Rows.Add(New Object() {"EH", "Western Sahara"})
            countries.Rows.Add(New Object() {"YE", "Yemen"})
            countries.Rows.Add(New Object() {"YU", "Yugoslavia"})
            countries.Rows.Add(New Object() {"ZR", "Zaire"})
            countries.Rows.Add(New Object() {"ZM", "Zambia"})
            countries.Rows.Add(New Object() {"ZW", "Zimbabwe"})
        End Sub
#End Region

        Private Sub SetupManualRelation()
            gridGroupingControl1.DataSource = Nothing
            gridGroupingControl1.DataMember = ""

            gridGroupingControl1.TableDescriptor.Relations.Clear()
            Dim c As Integer = gridGroupingControl1.Engine.SourceListSet.Count
            gridGroupingControl1.Engine.SourceListSet.Add("Countries", countries.DefaultView)

            Me.gridGroupingControl1.Engine.SourceListSet.Add("USStates", usStates.DefaultView)

            Dim mainTd As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor


            Dim usStatesRd As GridRelationDescriptor = New GridRelationDescriptor()
            usStatesRd.Name = "State"
            usStatesRd.RelationKind = RelationKind.ForeignKeyReference
            usStatesRd.ChildTableName = "USStates" ' SourceListSet name for lookup
            usStatesRd.RelationKeys.Add("State", "Key")
            usStatesRd.ChildTableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(255, 245, 227)
            usStatesRd.ChildTableDescriptor.VisibleColumns.Add("Name")
            usStatesRd.ChildTableDescriptor.SortedColumns.Add("Name")
            usStatesRd.ChildTableDescriptor.AllowEdit = False
            usStatesRd.ChildTableDescriptor.AllowNew = False ' Make pencil icon disappear, users can't modify states.
            mainTd.Relations.Add(usStatesRd)

            Dim countriesRd As GridRelationDescriptor = New GridRelationDescriptor()

            countriesRd.RelationKind = RelationKind.ForeignKeyReference
            countriesRd.ChildTableName = "Countries" ' SourceListSet name for lookup
            countriesRd.RelationKeys.Add("Country", "CountryCode")
            countriesRd.ChildTableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(255, 245, 227)
            countriesRd.ChildTableDescriptor.AllowEdit = True
            countriesRd.ChildTableDescriptor.AllowNew = True ' Make pencil icon appear, allow user to add countries (these setting will be overriden by CountriesCollection.IsReadOnly / CountriesCollection.IsFixedSize properties if they are true).
            mainTd.Relations.Add(countriesRd)

            gridGroupingControl1.DataSource = CreateMainTable()
        End Sub
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.radHelper = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radManual = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.radHelper, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radManual, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.IntelliMousePanning = True
            Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 12)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.Size = New System.Drawing.Size(505, 365)
            Me.gridGroupingControl1.TabIndex = 1
            Me.gridGroupingControl1.TableDescriptor.AllowNew = False
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
            Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
            Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            '
            'panel1
            '
            Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel1.Controls.Add(Me.radHelper)
            Me.panel1.Controls.Add(Me.radManual)
            Me.panel1.Location = New System.Drawing.Point(534, 12)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(165, 176)
            Me.panel1.TabIndex = 8
            '
            'radHelper
            '
            Me.radHelper.DrawFocusRectangle = False
            Me.radHelper.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radHelper.ForeColor = System.Drawing.Color.DimGray
            Me.radHelper.Location = New System.Drawing.Point(19, 42)
            Me.radHelper.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.radHelper.Name = "radHelper"
            Me.radHelper.Size = New System.Drawing.Size(143, 23)
            Me.radHelper.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radHelper.TabIndex = 1
            Me.radHelper.TabStop = False
            Me.radHelper.Text = "Use ForeignKeyHelper"
            Me.radHelper.ThemesEnabled = False
            '
            'radManual
            '
            Me.radManual.Checked = True
            Me.radManual.DrawFocusRectangle = False
            Me.radManual.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radManual.ForeColor = System.Drawing.Color.DimGray
            Me.radManual.Location = New System.Drawing.Point(19, 106)
            Me.radManual.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.radManual.Name = "radManual"
            Me.radManual.Size = New System.Drawing.Size(113, 23)
            Me.radManual.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radManual.TabIndex = 2
            Me.radManual.Text = "Manual Relation"
            Me.radManual.ThemesEnabled = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(729, 389)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.DropShadow = True
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Foreign-Key Reference Demo"
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.radHelper, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radManual, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub

        Private Sub radHelper_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radHelper.CheckChanged
            If radHelper.Checked Then
                gridGroupingControl1.DataSource = Nothing
                gridGroupingControl1.DataMember = ""
                gridGroupingControl1.TableDescriptor.Relations.Clear()
                gridGroupingControl1.DataSource = CreateMainTable()
                GridForeignKeyHelper.SetupForeignTableLookUp(gridGroupingControl1, "Country", countries, "CountryCode", "CountryName")
                gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("State")
            End If
        End Sub

        Private Sub radManual_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radManual.CheckChanged
            If radManual.Checked Then
                SetupManualRelation()
            End If
        End Sub
    End Class
End Namespace

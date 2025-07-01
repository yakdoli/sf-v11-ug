::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Through MultiDropdownModel {#through-multidropdownmodel style="tab-stops: 0pt"}

 

1.   Create a model in the application (Refer to [[Getting Started\>Adding a Model to the Application]{style="COLOR: blue"}]{.underline}).

2.   Create the MultiColumnDropDown control in the view.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View \[[ASPX]{style="TEXT-TRANSFORM: uppercase"}\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().MultiColumnDropDown\<[Student]{style="COLOR: #2b91af"}\>([\"Multidropdown\"]{style="COLOR: #a31515"},([MultiColumnDropDownModel]{style="COLOR: #2b91af"}) ViewData\[[\"dropdown\"]{style="COLOR: #a31515"}\]) [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View ]{style="FONT-FAMILY: 'Courier New'"}[\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [@(]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[new]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ [HtmlString]{style="COLOR: #2b91af"}(]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[Html.Syncfusion().MultiColumnDropDown\<[Student]{style="COLOR: #2b91af"}\>([\"Multidropdown\"]{style="COLOR: #a31515"},([MultiColumnDropDownModel]{style="COLOR: #2b91af"}) ViewData\[[\"dropdown\"]{style="COLOR: #a31515"}\])]{style="FONT-FAMILY: 'Courier New'"}[.]{style="FONT-FAMILY: 'Courier New'"}[ToString())[)]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

3.   Create an instance to MultiColumnDropDownModel and assign a data source to the model.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [// Create instance to MultiColumnDropDownModel and assign properties.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                 |
| [            [MultiColumnDropDownModel]{style="COLOR: #2b91af"} dropdown = [new]{style="COLOR: blue"} [MultiColumnDropDownModel]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                 |
| [                Datasource = [new]{style="COLOR: blue"} [StudentDataContext]{style="COLOR: #2b91af"}().JSONStudent.Skip(0).Take(30).ToList(),]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                                                 |
| [                Text = [\"\--Select\--\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                 |
| [                DisplayExpression = [new]{style="COLOR: blue"} [int]{style="COLOR: blue"}\[3\] { 2, 3, 5 },]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                                 |
| [                Width = 500]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                 |
| [            };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

4.   To display the pop-up panel when the page loads, use the **InitiallyPopupShown** property.

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [// Create instance to MultiColumnDropDownModel and assign properties.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                 |
| [            [MultiColumnDropDownModel]{style="COLOR: #2b91af"} dropdown = [new]{style="COLOR: blue"} [MultiColumnDropDownModel]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                 |
| [                Datasource = [new]{style="COLOR: blue"} [StudentDataContext]{style="COLOR: #2b91af"}().JSONStudent.Skip(0).Take(30).ToList(),]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                                                 |
| [                DisplayExpression = [new]{style="COLOR: blue"} [int]{style="COLOR: blue"}\[3\] { 2, 3, 5 },]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                                 |
| [                Width = 500,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                 |
| [                AutoFormat = [Skins]{style="COLOR: #2b91af"}.Office2007Black,]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                 |
| [                **InitiallyPopupShown=[true]{style="COLOR: blue"}**]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                 |
| [            };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

5.   Specify the default text box value by using the **Text** property.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [// Create instance to MultiColumnDropDownModel and assign properties.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                 |
| [            [MultiColumnDropDownModel]{style="COLOR: #2b91af"} dropdown = [new]{style="COLOR: blue"} [MultiColumnDropDownModel]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                 |
| [                Datasource = [new]{style="COLOR: blue"} [StudentDataContext]{style="COLOR: #2b91af"}().JSONStudent.Skip(0).Take(30).ToList(),]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                                                 |
| [                **Text = [\"\--Select\--\"]{style="COLOR: #a31515"},**]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                 |
| [                DisplayExpression = [new]{style="COLOR: blue"} [int]{style="COLOR: blue"}\[3\] { 2, 3, 5 },]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                                 |
| [                Width = 500,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                 |
| [                AutoFormat = [Skins]{style="COLOR: #2b91af"}.Office2007Black,]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                 |
| [                InitiallyPopupShown=[true]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                 |
| [            };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

6.   Pass the model to the view using **ViewData()**.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [// Pass the MultiColumnDropDownModel to the view using ViewData()]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                             |
| [            ViewData\[[\"dropdown\"]{style="COLOR: #a31515"}\] = dropdown;]{style="FONT-FAMILY: 'Courier New'"}                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

7.   Run the application. The multicolumn pop-up panel will open when the page loads and  will appear as shown below.

 

 

![](ImagesExt/image58_282.jpg){border="0"}

Figure 317: Multicolumn Drop-down on Initial Page Load

**[]{style="COLOR: black"}** 

[]{#related-topics}
:::

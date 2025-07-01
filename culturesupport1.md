::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Culture Support {#culture-support style="tab-stops: 0pt"}

DateTimeEdit control provides globalization support through the Culture property.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DateTimeEdit]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"dateTimeEdit\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Height]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"25\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Width]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"200\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: red"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [                         DateTime]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"07/15/2010\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Pattern]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"LongDate\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ CultureInfo]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"en-US\"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'"}**                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [Syncfusion.Windows.Shared.[DateTimeEdit]{style="COLOR: #2b91af"} dateTimeEdit = [new]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                         |
| [                          Syncfusion.Windows.Shared.[DateTimeEdit]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                         |
| [dateTimeEdit.Width = 200;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                         |
| [dateTimeEdit.Height = 25;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                         |
| [dateTimeEdit.DateTime = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2010, 07, 05);]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                         |
| [dateTimeEdit.Pattern = [DateTimePattern]{style="COLOR: #2b91af"}.LongDate;]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                         |
| [dateTimeEdit.CultureInfo = [new]{style="COLOR: blue"} [CultureInfo]{style="COLOR: #2b91af"}([\"en-US\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image30_262.png){border="0"}

Figure 279: Culture property set en-US

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[XAML\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DateTimeEdit]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"dateTimeEdit\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Height]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"25\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Width]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"200\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: red"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [                         DateTime]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"07/15/2010\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Pattern]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"LongDate\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ CultureInfo]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"fr-FR\"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [Syncfusion.Windows.Shared.[DateTimeEdit]{style="COLOR: #2b91af"} dateTimeEdit = [new]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                         |
| [                          Syncfusion.Windows.Shared.[DateTimeEdit]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                         |
| [dateTimeEdit.Width = 200;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                         |
| [dateTimeEdit.Height = 25;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                         |
| [dateTimeEdit.DateTime = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2010, 07, 05);]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                         |
| [dateTimeEdit.Pattern = [DateTimePattern]{style="COLOR: #2b91af"}.LongDate;]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                         |
| [dateTimeEdit.CultureInfo = [new]{style="COLOR: blue"} [CultureInfo]{style="COLOR: #2b91af"}([\"fr-FR\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image30_263.png){border="0"}

Figure 280: Culture property set to fr-FR

 

As you have seen in these samples whenever you change the Culture property the Date is displayed based on the Culture.

 

[]{#related-topics}
:::

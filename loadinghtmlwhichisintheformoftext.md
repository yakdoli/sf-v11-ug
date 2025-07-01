::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Loading HTML Which Is In the Form Of Text {#loading-html-which-is-in-the-form-of-text style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The HTML code sometimes can be directly written and stored as a string. The HTML code available in the form of string is loaded into the HTMLUI Control by using the **LoadFromString** method and the HTML contents will be displayed in the HTMLUI control.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                 |
|                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                       |
|                                                                                                                                                                                |
| [// Load HTML Document from String.]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                         |
|                                                                                                                                                                                |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ htmlCode =[\"\<HTML\>]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                |
| [\<HEAD\>]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                 |
|                                                                                                                                                                                |
| [\<TITLE\>HI\</TITLE\>]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                    |
|                                                                                                                                                                                |
| [\</HEAD\>]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                |
|                                                                                                                                                                                |
| [\<BODY bgcolor=[\'#ffffff\']{style="COLOR: #a31515"}\>]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                   |
|                                                                                                                                                                                |
| [\<INPUT type=[\'button\']{style="COLOR: #a31515"} id=[\'btn\']{style="COLOR: #a31515"}/\>\</INPUT\>]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                      |
|                                                                                                                                                                                |
| [\</BODY\>]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                |
|                                                                                                                                                                                |
| [\</HTML\>[\";]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                   |
|                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[.htmluiControl1.LoadFromString(htmlCode);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}         |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                     |
| [\'  Load HTML Document from String]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                     |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ htmlCode [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = [\"\<HTML\>]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                            |
|                                                                                                                                                                                                                                                                                                     |
| [\<HEAD\>]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                     |
| [\<TITLE\>HI[\</]{style="COLOR: #6464b9"}[TITLE]{style="COLOR: #844646"}[\>]{style="COLOR: #6464b9"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                     |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: #6464b9; FONT-SIZE: 9pt"}[HEAD]{style="FONT-FAMILY: 'Courier New'; COLOR: #844646; FONT-SIZE: 9pt"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: #6464b9; FONT-SIZE: 9pt"}                                                                         |
|                                                                                                                                                                                                                                                                                                     |
| [\<BODY bgcolor=[\'#ffffff\'\>]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                     |
| [\<INPUT type=[\'button\' id=\'btn\'/\>\</INPUT\>]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                     |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: #6464b9; FONT-SIZE: 9pt"}[BODY]{style="FONT-FAMILY: 'Courier New'; COLOR: #844646; FONT-SIZE: 9pt"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: #6464b9; FONT-SIZE: 9pt"}                                                                         |
|                                                                                                                                                                                                                                                                                                     |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: #6464b9; FONT-SIZE: 9pt"}[HTML]{style="FONT-FAMILY: 'Courier New'; COLOR: #844646; FONT-SIZE: 9pt"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: #6464b9; FONT-SIZE: 9pt"}[\"]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                                                                                     |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[.HtmluiControl1.LoadFromString(htmlCode)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::

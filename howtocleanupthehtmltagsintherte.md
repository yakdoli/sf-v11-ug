::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to Clean up the HTML tags in the RTE {#how-to-clean-up-the-html-tags-in-the-rte style="tab-stops: 0pt"}

To enable the XHTML in you RTE, follow the steps given below:

1.   Create a model in the application

2.   Create a strongly typed view

3.   Add the below code snippet in the View page:

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                      |
| [\[ASPX\]]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                      |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().RichTextEditor([\"RTE\"]{style="COLOR: #a31515"}).EnableXHTML([true]{style="COLOR: blue"})[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                               |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                           |
| [\[Razor\]]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                           |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[Html.Syncfusion().RichTextEditor([\"RTE\"]{style="COLOR: #a31515"}).EnableXHTML([true]{style="COLOR: blue"})                          ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                           |
| [    .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                           |
| [       ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                           |
| [   [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

4.   Build and run the application.

 

Properties

 

There is only one property that is used to implement XHTML in the RTE:

+---------------------------------------------------+-----------------------------------------------------------------------------------------+---------------------------------------------+--------------------------------------------------+-----------------------------------------+
| Property[]{style="FONT-SIZE: 11pt"}               | Description[]{style="FONT-SIZE: 11pt"}                                                  | Type of Property[]{style="FONT-SIZE: 11pt"} | Value it accepts[]{style="FONT-SIZE: 11pt"}      | Dependencies[]{style="FONT-SIZE: 11pt"} |
+---------------------------------------------------+-----------------------------------------------------------------------------------------+---------------------------------------------+--------------------------------------------------+-----------------------------------------+
| ShowInsertFormElements[]{style="FONT-SIZE: 11pt"} | Allows you to show the Insert Form Element option in the RTE[]{style="FONT-SIZE: 11pt"} | bool                                        | True                                             | NA[]{style="FONT-SIZE: 11pt"}           |
|                                                   |                                                                                         |                                             |                                                  |                                         |
|                                                   |                                                                                         |                                             | False                                            |                                         |
|                                                   |                                                                                         |                                             |                                                  |                                         |
|                                                   |                                                                                         |                                             | Default value is True[]{style="FONT-SIZE: 11pt"} |                                         |
+---------------------------------------------------+-----------------------------------------------------------------------------------------+---------------------------------------------+--------------------------------------------------+-----------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

 

[]{#related-topics}
:::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### []{#p178}[]{#_Filter_and_FilterIndex}Filter and FilterIndex        

 

The **Filter** property is used for filtering the file types shown in the File Dialog box. The **FilterIndex** property is used to indicate which file type to be shown initially, if more than one file type is assigned to the filter property.

 

Following code explains the usage of both Filter and FilterIndex property.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                             |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[FileUploadControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [x]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[Name]{style="COLOR: red"}[=\"FileUpload1\"]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                             |
| [Filter]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Image Files(\*.gif;\*.jpg;\*.jpeg;\*.png)\|\*.gif;\*.jpg;\*.jpeg;\*.png\|AllFiles(\*.\*)\|\*.\*\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [FilterIndex]{style="COLOR: red"}[=\"1\"/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                           |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [FileUploadControl]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ fileupload = [FileUploadControl]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                          |
| [fileupload.Filter = [\"Image Files(\*.gif;\*.jpg;\*.jpeg;\*.png)\|\*.gif;\*.jpg;\*.jpeg;\*.png\|AllFiles(\*.\*)\|\*.\*\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| [fileupload.FilterIndex = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

In the above code snippet, the Filter property is set to two file types, one is \"Images\" file type and another is \"All Files\" file type. Setting the FilterIndex property set to 1, indicates which Image file type will be initially visible in the File Dialog box.

 

[]{#related-topics}
:::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Hiding Columns

[]{#p183} 

It is possible hide the columns, using the **ColumnsToHide** property. By default, seven columns will be visible for displaying information about the files being uploaded. This property is of type Array ColumnNames: here ColumnNames is an enumeration which consists of the following details.

 

[·      ]{style="FONT-FAMILY: Symbol"}ColumnNames.FileSize

[·      ]{style="FONT-FAMILY: Symbol"}ColumnNames.FileName

[·      ]{style="FONT-FAMILY: Symbol"}ColumnNames.Progress

[·      ]{style="FONT-FAMILY: Symbol"}ColumnNames.Remove

[·      ]{style="FONT-FAMILY: Symbol"}ColumnNames.Cancel

[·      ]{style="FONT-FAMILY: Symbol"}ColumnNames.Status

[·      ]{style="FONT-FAMILY: Symbol"}ColumnNames.SizeUploaded.

 

The following code snippet illustrates its usage.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                      |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                     |
| [FileUploadControl]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ fileupload = [FileUploadControl]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                     |
| [ColumnNames\[\] columnnames = { ColumnNames.FileSize, ColumnNames.FileName, ColumnNames.Progress, ColumnNames.Remove };]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                     |
| [fileupload.ColumnsToHide = columnnames;]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](../ImagesExt/image261_306.jpg){border="0"}

 

Figure 377: Hiding Columns in the FileUpload Control

[]{#related-topics}
:::

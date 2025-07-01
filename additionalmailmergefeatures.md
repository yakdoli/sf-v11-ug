::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=2b05f541-f80e-42ac-8b96-dff440a7da54){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e2c289d7-8c9b-4618-b7f6-d294912e35ae){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Mail Merge](ms-xhelp:///?Id=71291c1d-369c-4264-9215-95fe5c7b6e10){.d2h_breadcrumbsNormal}
:::

### Additional Mail Merge Features {#additional-mail-merge-features style="tab-stops: 0pt"}

 

Using Mapped Fields

 

The MailMerge class allows to automatically map between names of fields in your data source and names of mail merge fields in the document. To perform this, use the **MailMerge.MappedDataFields** property that returns a MappedDataFields object. MappedDataFields is a collection of string keys into string values. The keys are the names of mail merge fields in the document and the values are the names of fields in your data source. The class provides all properties and methods typical for a regular .NET collection such as Add, Clear, Remove, and so on.

 

The following example illustrates how to add a mapping when a merge field in a document and a data field in a data source have different names.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\] ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                     |
|                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                            |
|                                                                                                                                                                                     |
| [doc.MailMerge.MappedDataFields.Add([\"FieldName_InDocument\"]{style="COLOR: #a31515"}, [\"FieldName_InDataSource\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\] ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                  |
|                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                         |
|                                                                                                                                                                                  |
| [doc.MailMerge.MappedDataFields.Add([\"FieldName_InDocument\"]{style="COLOR: maroon"}, [\"FieldName_InDataSource\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**Obtaining Merge Field Names**

 

You can get the collection of the merge field names available in the document by using the **MailMerge.GetFieldNames** method. This returns an array of string that contains the names.

 

The following example illustrates how to get the names of all the merge fields in a document.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\] ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                      |
|                                                                                                                                                      |
|                                                                                                                                                      |
|                                                                                                                                                      |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\[\] fieldNames = doc.MailMerge.GetMergeFieldNames();]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\] ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                        |
|                                                                                                                                                                                                        |
|                                                                                                                                                                                                        |
|                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ fieldNames [As]{style="COLOR: blue"} [String]{style="COLOR: blue"}() = doc.MailMerge.GetMergeFieldNames()]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**Obtaining Merge Field Group Names**

 

You can get the collection of the Merge Field Group names available in the document by using the **MailMerge.GetMergeGroupNames** method. This returns an array of string that contains the names.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\] ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                       |
|                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                              |
|                                                                                                                                                       |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\[\] groupNames =  doc.MailMerge.GetMergeGroupNames() ]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                  |
|                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ filednames [As]{style="COLOR: blue"} [String]{style="COLOR: blue"}() = doc.MailMerge.GetMergeFieldNames(groupName)]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**Obtaining Merge Fields for a Specific Group**

 

You can get the collection of the Merge Fields for a specific group in the document by using the **doc.MailMerge.GetMergeFieldNames(String groupName)** method. This returns an array of string that contains the field names.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\] ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                               |
|                                                                                                                                                               |
|                                                                                                                                                               |
|                                                                                                                                                               |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\[\] filednames = doc.MailMerge.GetMergeFieldNames(groupName);]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                  |
|                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ filednames [As]{style="COLOR: blue"} [String]{style="COLOR: blue"}() = doc.MailMerge.GetMergeFieldNames(groupName)]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Removing Empty Paragraphs

 

To remove paragraphs that contain empty mail merge fields from the document, set the **doc.MailMerge.RemoveEmptyParagraphs** to **True**.

 

The following example illustrates how to remove paragraphs that contain empty mail merge fields.

 

+----------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                           |
|                                                                                                          |
|                                                                                                          |
|                                                                                                          |
| [doc.MailMerge.RemoveEmptyParagraphs = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                          |
|                                                                                                         |
|                                                                                                         |
|                                                                                                         |
| [doc.MailMerge.RemoveEmptyParagraphs = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------+

 

Removing Empty Groups

 

To remove empty groups from the document during mail merge, set the **document.MailMerge.RemoveEmptyGroup** to **True**. The default value of RemoveEmptyGroup is false.

 

The following example illustrates how to remove empty groups from the document.

[]{style="FONT-FAMILY: 'Verdana','sans-serif'"} 

+----------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                           |
|                                                                                                          |
|                                                                                                          |
|                                                                                                          |
| [document.MailMerge.RemoveEmptyGroup = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                          |
|                                                                                                         |
|                                                                                                         |
|                                                                                                         |
| [document.MailMerge.RemoveEmptyGroup = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------+

 

Clear Fields

 

To remove empty mail merge fields from the document, set **MailMerge.ClearField** property to **True**.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                       |
|                                                                                                                                                                                                                      |
| []{style="COLOR: black"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                      |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: teal"}([\"Sample.doc\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                      |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\[\] fieldname ={ [\"FirstName\"]{style="COLOR: maroon"}, [\"LastName\"]{style="COLOR: maroon"} };]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                      |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\[\] fieldvalues ={ [\"John\"]{style="COLOR: maroon"}, [\"David\"]{style="COLOR: maroon"} ,};]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                      |
| [doc.MailMerge.ClearFields = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                      |
| [doc.MailMerge.Execute(fieldname, fieldvalues);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                         |
|                                                                                                                                                                                                                            |
| []{style="COLOR: black"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} WordDocument = [New]{style="COLOR: blue"} WordDocument([\"Sample.doc\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                            |
| [Dim fieldname As String() = {\"FirstName\", \"LastName\"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                            |
| [Dim fieldvalues As String() = {\"John\", \"David\"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                            |
| [doc.MailMerge.ClearFields = [false]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                            |
| [doc.MailMerge.Execute(fieldname, fieldvalues)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p84}[]{#_Security} 

[]{#related-topics}
::::

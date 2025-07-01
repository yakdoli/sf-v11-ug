::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=5fff6d7c-bc30-4c3d-ad89-85b2b23e4cf8){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=985c525e-c4c8-40ea-8222-130fe9b88fd7){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=b13bdbaa-4c11-4a19-ba3a-3401037013af){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Deploying Essential DocIO](ms-xhelp:///?Id=292813fa-54b4-42a4-8f0d-0291dc5221fb){.d2h_breadcrumbsNormal}
:::

### WPF {#wpf style="tab-stops: 0pt"}

[]{#p18} 

Now, you have created a WPF application (refer [Creating Platform Application](ms-xhelp:///?Id=78286af6-eb2c-4c81-aa63-ed667b9d74f8)). This section covers the following:

 

[·      ]{style="FONT-FAMILY: Symbol"}Deploying Essential DocIO in a WPF Application

[·      ]{style="FONT-FAMILY: Symbol"}Creating a Word Document

 

Deploying Essential DocIO in a WPF Application

 

The following steps will guide you to deploy Essential DocIO:

 

1.   Go to **Solution Explorer** of the application you have created. Right-click **Reference** folder and then click **Add References**.

 

2.   Add the below mentioned assemblies as references in the application,

 

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Core.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Compression.Base.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.DocIO.Base.dll

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image24_1.jpg){border="0"}Note: There is no toolbox support for DocIO in WPF application.
:::

 

Essential DocIO is now deployed in the WPF application.

 

Creating a Word Document

 

In this section, you will learn how to create a simple Word document with \"Hello World\" written on the first paragraph of the first section.

 

1.   Include the following namespaces in your application.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Syncfusion.DocIO.DLS** (using Syncfusion.DocIO.DLS)

[·      ]{style="FONT-FAMILY: Symbol"}**Syncfusion.DocIO** (using Syncfusion.DocIO)

 

2.   Instantiate the **WordDocument** class.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                           |
|                                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                 |
|                                                                                                                                                                                          |
| [// Create a new Word document. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                      |
|                                                                                                                                                                                          |
| [// This document has no section and no paragraph by default.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                         |
|                                                                                                                                                                                          |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ document = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                               |
|                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                         |
|                                                                                                                  |
| [\' Create a new Word document. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                              |
|                                                                                                                  |
| [\' This document has no section and no paragraph by default.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                  |
| [Dim document As WordDocument = New WordDocument()]{style="FONT-FAMILY: 'Courier New'"}                          |
+------------------------------------------------------------------------------------------------------------------+

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image24_1.jpg){border="0"}Note: The WordDocument class represents the Word documents created in memory. This is the memory representation of the Word document written to disk.
:::

 

3.   Add a section to the newly created Word document by using the following code.

 

+----------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                         |
|                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                   |
|                                                                                                                                        |
| [// Add a new section to the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                              |
|                                                                                                                                        |
| [IWSection]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ section = document.AddSection();]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                        |
|                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                  |
|                                                                                           |
| [\' Add a new section to the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                           |
| [Dim section As IWSection = document.AddSection()]{style="FONT-FAMILY: 'Courier New'"}    |
+-------------------------------------------------------------------------------------------+

 

4.   Add a paragraph to the newly created section in the Word document by using the following code.

 

+---------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                              |
|                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                    |
|                                                                                                                                             |
| [// Add a new paragraph to the section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                  |
|                                                                                                                                             |
| [IWParagraph]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                          |
|                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                    |
|                                                                                             |
| [\' Add a new paragraph to the section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}  |
|                                                                                             |
| [Dim paragraph As IWParagraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------+

 

5.   Add a paragraph to the newly created section in the Word document by using the following code.

 

+---------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                          |
|                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                |
|                                                                                                         |
| [// Insert text into the paragraph.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                  |
|                                                                                                         |
| [paragraph.AppendText([\"Hello World!\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                     |
|                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                   |
|                                                                                        |
| [\' Insert text into the paragraph.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                        |
| [paragraph.AppendText(\"Hello World!\")]{style="FONT-FAMILY: 'Courier New'"}           |
+----------------------------------------------------------------------------------------+

 

6.   Finally, save the Word document. The following code example illustrates how to do this.

 

+------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                           |
|                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                 |
|                                                                                                                                          |
| [// Saving the document to disk.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                      |
|                                                                                                                                          |
| [document.Save([\"Sample.doc\"]{style="COLOR: #a31515"}, [FormatType]{style="COLOR: #2b91af"}.Doc);]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                  |
|                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                            |
|                                                                                     |
| [\' Saving the document to disk.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                     |
| [document.Save(\"Sample.doc\", FormatType.Doc)]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------+

 

The sample Word document created through the above procedure is shown below.

 

![](ImagesExt/image24_19.jpg){border="0"}

Figure 19: Word Document

 

A Word document is created in the WPF application.

 

[]{#related-topics}
::::::

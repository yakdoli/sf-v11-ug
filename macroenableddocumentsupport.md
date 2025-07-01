::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=743c99d4-6def-4487-8630-0f62728800d1){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=9075f0ab-b874-4df8-a7b6-072f6524ea7e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Word Document](ms-xhelp:///?Id=d4b2bc62-8cff-43ca-bbb3-bdd5cc1553de){.d2h_breadcrumbsNormal}
:::

### Macro-enabled Document Support {#macro-enabled-document-support style="tab-stops: 0pt"}

 

A macro is a piece of Visual Basic (VB) programming code that is embedded in a word file to automate repetitive tasks. Essential DocIO provides support for manipulating Microsoft Word macro-enabled documents (\*.docm) and Microsoft Word macro-enabled templates (\*.dotm) of Word 2007 and Word 2010 formats.

 

Microsoft Word macro-enabled format files can be created with the following format type enumerations while saving the WordDocument object:

 

[·      ]{style="FONT-FAMILY: Symbol"}Word2007Docm - Microsoft Word 2007 macro enabled document format.

[·      ]{style="FONT-FAMILY: Symbol"}Word2007Dotm - Microsoft Word 2007 macro enabled template format.

[·      ]{style="FONT-FAMILY: Symbol"}Word2010Docm - Microsoft Word 2010 macro enabled document format.

[·      ]{style="FONT-FAMILY: Symbol"}Word2010Dotm - Microsoft Word 2010 macro enabled template format.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image24_1.jpg){border="0"}Note: The macros present in the input macro-enabled document will be preserved as it is in the output macro-enabled document. However, Essential DocIO does not have support to create or edit macro commands in the macro-enabled documents.
:::

 

Use Case Scenario

 

Using this feature you can preserve the macros present in the input macro-enabled document during conversion to another macro-enabled document (\*.docm to \*.docm, \*.dotm to \*.dotm, \*.docm to \*.dotm, and vice versa). ****

 

The following code illustrates how to open and save a Word macro-enabled document.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                      |
|                                                                                                                                                                                     |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ doc = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                     |
| [//Opens the Word macro-enabled document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                        |
|                                                                                                                                                                                     |
| [doc.Open([\"SourceDocument.docm\"]{style="COLOR: #a31515"}, [FormatType]{style="COLOR: #2b91af"}.Automatic);]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                     |
| [//Saves as the Word macro-enabled document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                     |
|                                                                                                                                                                                     |
| [doc.Save([\"OutDocument.docm\"]{style="COLOR: #a31515"}, [FormatType]{style="COLOR: #2b91af"}.Word2007Docm);]{style="FONT-FAMILY: 'Courier New'"}                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="DISPLAY: none; FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                   |
|                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                      |
| ['Opens the Word macro-enabled document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                          |
|                                                                                                                                                                      |
| [doc.Open([\"SourceDocument.docm\"]{style="COLOR: maroon"}, [FormatType]{style="COLOR: #2b91af"}.Automatic)]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                      |
| ['Saves as the Word macro-enabled document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                       |
|                                                                                                                                                                      |
| [doc.Save([\"OutDocument.docm\"]{style="COLOR: maroon"}, [FormatType]{style="COLOR: #2b91af"}.Word2007Docm)]{style="FONT-FAMILY: 'Courier New'"}                     |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The following code illustrates how to open a Word macro-enabled document and save it as macro free document.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                      |
|                                                                                                                                                                                     |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ doc = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                     |
| [//Opens the Word macro-enabled document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                        |
|                                                                                                                                                                                     |
| [doc.Open([\"SourceDocument.docm\"]{style="COLOR: #a31515"}, [FormatType]{style="COLOR: #2b91af"}.Automatic);]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                                     |
| [//Determines whether the document has Macros.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[ ]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                     |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (doc.HasMacros)]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                     |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                     |
| [    [//Removes the macro commands present in the macro-enabled document.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                     |
| [    doc.RemoveMacros();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                     |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                     |
| [//Saves as the macro free Word document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                        |
|                                                                                                                                                                                     |
| [doc.Save([\"OutDocument.docx\"]{style="COLOR: #a31515"}, [FormatType]{style="COLOR: #2b91af"}.Word2007);]{style="FONT-FAMILY: 'Courier New'"}                                      |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="DISPLAY: none; FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                             |
|                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [WordDocument]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                |
| ['Opens the Word macro-enabled document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                    |
|                                                                                                                                                                                                |
| [doc.Open([\"SourceDocument.docm\"]{style="COLOR: maroon"}, [FormatType]{style="COLOR: #2b91af"}.Automatic)]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                                |
| ['Determines whether the document has Macros.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                               |
|                                                                                                                                                                                                |
| [If]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc.HasMacros[ Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                |
| [    ]{style="FONT-FAMILY: 'Courier New'"}['Removes the macro commands present in the macro-enabled document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                               |
|                                                                                                                                                                                                |
| [    ]{style="FONT-FAMILY: 'Courier New'"}[doc.RemoveMacros()]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                |
| ['Saves as the macro free Word document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                    |
|                                                                                                                                                                                                |
| [doc.Save([\"OutDocument.docx\"]{style="COLOR: maroon"}, [FormatType]{style="COLOR: #2b91af"}.Word2007)]{style="FONT-FAMILY: 'Courier New'"}                                                   |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image24_1.jpg){border="0"}Note: Now macros will not be cloned/imported to the destination macro-enabled document while cloning/importing a macro-enabled document. If the macros are present in the destination macro-enabled document, then it will be preserved as it is in the macro-enabled document.
:::

 

Samples Link

 

To view samples:

 

1.   Open the Syncfusion's Dashboard.

2.   Select **Reporting** Edition, and then click **ASP.NET.**

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image24_1.jpg){border="0"}Note: You can select required platform under Reporting Edition.
:::

3.   Click **Run Samples,** and then click **DocIo** at the bottom.

4.   Navigate to **View** \> **Macro Preservation**.

 

[]{#related-topics}
:::::::

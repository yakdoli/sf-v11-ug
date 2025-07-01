::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=f3c66e28-a2aa-4906-8e2c-17a9d80d9538){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=743c99d4-6def-4487-8630-0f62728800d1){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Word Document](ms-xhelp:///?Id=d4b2bc62-8cff-43ca-bbb3-bdd5cc1553de){.d2h_breadcrumbsNormal}
:::

### Docx Support {#docx-support style="tab-stops: 0pt"}

 

Essential DocIO provides support for creating Microsoft Word 2007 format and Microsoft Word 2010 format files from scratch by using the DocIO API. Word 2007 and Word 2010 format files are created with the same API as that of .doc files, except the format type in which they are saved and opened.

 

The following code illustrates how to create a Word 2007 format document.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                       |
| []{style="COLOR: black"}                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                       |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = [new]{style="COLOR: blue"} WordDocument();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                                                       |
| [//Add a new section to the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                       |
| [IWSection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ section = document.AddSection();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                                                       |
| [//Adding a new paragraph to the section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                          |
|                                                                                                                                                                                                                                                       |
| [IWParagraph]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ paragraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                                                       |
| [//Insert Text into the paragraph.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                                       |
| [paragraph.AppendText( \"Hello World!\" );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                                       |
| [//Saves the document in Word 2007 format type.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                    |
|                                                                                                                                                                                                                                                       |
| [doc.Save([\"OutDocument.docx\"]{style="COLOR: maroon"}, ]{style="FONT-FAMILY: 'Courier New'"}[FormatType]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Word2007]{style="FONT-FAMILY: 'Courier New'"}[);]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                      |
| []{style="COLOR: black"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                                                      |
| [\'Add a new section to the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                      |
| [Dim section As IWSection = document.AddSection()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                                                                      |
| [\'Adding a new paragraph to the section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                         |
|                                                                                                                                                                                                                                                      |
| [Dim paragraph As IWParagraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                                                      |
| [\'Insert Text into the paragraph.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                      |
| [paragraph.AppendText(\"Hello World!\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                      |
| [\'Saves the document in Word 2007 format type.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                   |
|                                                                                                                                                                                                                                                      |
| [doc.Save([\"OutDocument.docx\"]{style="COLOR: maroon"}, ]{style="FONT-FAMILY: 'Courier New'"}[FormatType]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Word2007]{style="FONT-FAMILY: 'Courier New'"}[)]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: The format type option "Docx" specifies the Microsoft Word 2007 format and its usage is deprecated, we recommend you to make use of Word2007 or Word2010.
:::

 

The following code illustrates how to open a Word 2010 format document and save it.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                  |
| []{style="COLOR: black"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                  |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = [new]{style="COLOR: blue"} WordDocument();]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                                                  |
| [//Opens the Word 2010 format document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                       |
|                                                                                                                                                                                                                                                  |
| [document.Open(filename, [FormatType]{style="COLOR: #2b91af"}.Automatic);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                                                  |
| [//Adding a new paragraph to the last section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                |
|                                                                                                                                                                                                                                                  |
| [IWParagraph]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ paragraph = document.LastSection.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                                                  |
| [//Insert Text into the paragraph.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                            |
|                                                                                                                                                                                                                                                  |
| [paragraph.AppendText( \"Creating Word 2010 format document!\" );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                                                                  |
| [//Saves the document in Word 2010 format type.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                               |
|                                                                                                                                                                                                                                                  |
| [doc.Save([\"Sample.docx\"]{style="COLOR: maroon"}, ]{style="FONT-FAMILY: 'Courier New'"}[FormatType]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Word2010]{style="FONT-FAMILY: 'Courier New'"}[);]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                              |
|                                                                                                                                                                                                                                                 |
| []{style="COLOR: black"}                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                                                 |
| [\']{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[Opens the Word 2010 format document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                  |
|                                                                                                                                                                                                                                                 |
| [document.Open(filename, [FormatType]{style="COLOR: #2b91af"}.Automatic);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                                                 |
| [\'Adding a new paragraph to the last section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                               |
|                                                                                                                                                                                                                                                 |
| [Dim paragraph As IWParagraph = document.LastSection.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                                 |
| [\'Insert Text into the paragraph.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                 |
| [paragraph.AppendText(\"Creating Word 2010 format document!\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                                                                 |
| [\'Saves the document in Word 2007 format type.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                              |
|                                                                                                                                                                                                                                                 |
| [doc.Save([\"Sample.docx\"]{style="COLOR: maroon"}, ]{style="FONT-FAMILY: 'Courier New'"}[FormatType]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Word2010]{style="FONT-FAMILY: 'Courier New'"}[)]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

DocIO also has the ability to save the doc files into docx format (i.e, Microsoft Word 2007 format and Microsoft Word 2010 format files). All the elements supported by .Doc are supported in .Docx.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                        |
| []{style="COLOR: black"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                        |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ doc = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                                                                        |
| [doc.Open([\"SourceDocument.doc\"]{style="COLOR: #a31515"}, [FormatType]{style="COLOR: #2b91af"}.Doc);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                                        |
| [doc.Save([\"OutDocument.docx\"]{style="COLOR: #a31515"}, ]{style="FONT-FAMILY: 'Courier New'"}[FormatType]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Word2007]{style="FONT-FAMILY: 'Courier New'"}[);]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                      |
| []{style="COLOR: black"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                                                      |
| [doc.Open([\"SourceDocument.doc\"]{style="COLOR: maroon"}, FormatType.Doc)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                                                      |
| [doc.Save([\"OutDocument.docx\"]{style="COLOR: maroon"}, ]{style="FONT-FAMILY: 'Courier New'"}[FormatType]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Word2007]{style="FONT-FAMILY: 'Courier New'"}[)]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Essential DocIO provides support for reading Word 2007 / Word 2010 files. Currently we do have only a limited support. Docx files can be read with same API as that of .doc files, except the format it is opened.

 

The following code illustrates how to read a Docx file.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\] ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                          |
| [WordDocument doc = [new]{style="COLOR: blue"} WordDocument([\"C:\\\\sample.docx\"]{style="COLOR: maroon"}, ]{style="FONT-FAMILY: 'Courier New'"}[FormatType]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Word2007]{style="FONT-FAMILY: 'Courier New'"}[);]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\] ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument([\"c:\\\\sample.docx\"]{style="COLOR: maroon"}, ]{style="FONT-FAMILY: 'Courier New'"}[FormatType]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[.Word2007]{style="FONT-FAMILY: 'Courier New'"}[)]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Word 2010 Support](ms-xhelp:///?Id=72f976f4-e110-4f71-9b55-8d6362d87ca1){style="TEXT-DECORATION: none"}
:::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=41178bf6-e8e5-4eaf-a650-b7c95f241600){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c2ca950d-8cd2-48b2-a01e-da4d67e037bd){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}
:::

## Docx Support {#docx-support style="tab-stops: 0pt"}

 

Microsoft introduced the .docx file format in its new Office and Word applications to replace the commonly used doc format. Essential DocIO now provides support for.docx files. Docx files are created using the same APIs as for .doc files using Essential DocIO. Essential DocIO provides support for:

 

[·      ]{style="FONT-FAMILY: Symbol"}Creating a .docx file from scratch

[·      ]{style="FONT-FAMILY: Symbol"}Read/Modify a .docx file

 

Creating a .docx file

To create a .docx file:

1.   Create a word document using Essential DocIO APIs.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                           |
|                                                                                                                                                                                          |
|                                                                                                                                                                                          |
|                                                                                                                                                                                          |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ document = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| [//Add a new section to the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                 |
|                                                                                                                                                                                          |
| [IWSection]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ section = document.AddSection();]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                          |
| [//Adding a new paragraph to the section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                             |
|                                                                                                                                                                                          |
| [IWParagraph]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                          |
| [//Insert Text into the paragraph]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                                          |
| [paragraph.AppendText( [\"Hello World!\"]{style="COLOR: #a31515"} );]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   Create an instance of SaveFile dialog.

 

The following lines of code create an instance of SaveFile Dialog and set the properties and display the Save dialog on the screen.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                         |
|                                                                                                                                                                                        |
|                                                                                                                                                                                        |
|                                                                                                                                                                                        |
| [SaveFileDialog]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ sfd = [new]{style="COLOR: blue"} [SaveFileDialog]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                        |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                        |
| [   Filter = [\"Docx files (\*.docx)\|\*.docx\|All files (\*.\*)\|\*.\*\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                        |
| [   DefaultExt = [\".docx\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                        |
| [   FilterIndex = 1]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                        |
| [};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                        |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (sfd.ShowDialog() == [true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                          |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

3.   Save the document as .docx format.

 

The following code snippet will save the Word document.

 

+---------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                |
|                                                                                                               |
|                                                                                                               |
|                                                                                                               |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                               |
| [   [using]{style="COLOR: blue"} (Stream stream = sfd.OpenFile())]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                               |
| [   {]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                               |
| [      document.Save(stream, [FormatType]{style="COLOR: #2b91af"}.Docx);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                               |
| [   }]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                               |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
+---------------------------------------------------------------------------------------------------------------+

 

4.   Run the application. The .doc file is converted to .docx file.

 

The same can be achieved using the VB.Net code as well.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                        |
|                                                                                                                                                                           |
|                                                                                                                                                                           |
|                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ document [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                           |
| [\'Add a new section to the document. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                 |
|                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ section [As]{style="COLOR: blue"} IWSection = document.AddSection()]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                           |
| [Adding a new paragraph to the section. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                               |
|                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ paragraph [As]{style="COLOR: blue"} IWParagraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                           |
| [\'Insert Text into the paragraph ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                     |
|                                                                                                                                                                           |
| [paragraph.AppendText([\"Hello World!\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ sfd [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} SaveFileDialog()]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                           |
| [If]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ sfd.ShowDialog() = [True]{style="COLOR: blue"} [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                           |
| [  [Using]{style="COLOR: blue"} stream [As]{style="COLOR: blue"} Stream = sfd.OpenFile()]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                           |
| [       document.Save(stream, FormatType.Docx)]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                           |
| [   [End]{style="COLOR: blue"} [Using]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                           |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Saving a .doc File as .docx

DocIO also has the ability to save the doc files into .docx format (i.e, Microsoft Word 2007 files format). All the elements supported by .Doc are supported in Docx. Some of the supported elements are listed below.

1.   Creating an instance of Word document.

The following code snippet creates an instance of the word document and opens the word document named SourceDocument.doc. The FormatType.Doc specifies that the document is of type Word 97-2003.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                           |
|                                                                                                                                                                                          |
|                                                                                                                                                                                          |
|                                                                                                                                                                                          |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ document = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| [document.Open("SourceDocument.doc", [FormatType]{style="COLOR: #2b91af"}.Doc);]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                          |
| [SaveFileDialog]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ sfd = [new]{style="COLOR: blue"} [SaveFileDialog]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                          |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                          |
| [   Filter = [\"Docx files (\*.docx)\|\*.docx\|All files (\*.\*)\|\*.\*\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                          |
| [   DefaultExt = [\".docx\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                          |
| [   FilterIndex = 1]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                          |
| [};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 14pt"} 

2.   Save the document as .docx format.

 

The following code snippet will display the Save dialog on the screen and save the Word document.

+-----------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**        |
|                                                                       |
|                                                                       |
|                                                                       |
| if (sfd.ShowDialog() == true)                                         |
|                                                                       |
| {                                                                     |
|                                                                       |
|    using (Stream stream = sfd.OpenFile())                             |
|                                                                       |
|    {                                                                  |
|                                                                       |
|       document.Save(stream, FormatType.Docx);                         |
|                                                                       |
|    }                                                                  |
|                                                                       |
| }                                                                     |
+-----------------------------------------------------------------------+

3.   Run the application. The .doc file is converted to .docx file.

The same can be achieved using the VB.Net code as well.

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                        |
|                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ document [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                           |
| [document.Open([\"SourceDocument.doc\"]{style="COLOR: #a31515"}, FormatType.Doc)]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ sfd [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} SaveFileDialog()]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                           |
| [If]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ sfd.ShowDialog() = [True]{style="COLOR: blue"} [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                           |
| [   [Using]{style="COLOR: blue"} stream [As]{style="COLOR: blue"} Stream = sfd.OpenFile()]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                           |
| [       document.Save(stream, FormatType.Docx)]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                           |
| [   [End]{style="COLOR: blue"} [Using]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                           |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Reading/Modifying .docx File

Once a file is saved into .docx format, Essential DocIO provides support for reading and modifying .docx files. Docx files can be read using the same API as that of .doc files; except for the format in which it is opened.

The control uses the following API to read the .docx format.

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                         |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ doc = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: #2b91af"}([\"sample.docx\"]{style="COLOR: #a31515"}, [FormatType]{style="COLOR: #2b91af"}.Docx);]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                             |
|                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument([\"sample.docx\"]{style="COLOR: #a31515"}, FormatType.Docx)]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 14pt"} 

Run the file. You will be able to open and edit a .docx file.

[]{#related-topics}
::::

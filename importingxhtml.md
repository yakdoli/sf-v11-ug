::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Importing XHTML {#importing-xhtml style="tab-stops: 0pt"}

 

Essential DocIO supports inserting XHTML formatted strings in the Word document. There are two different usage scenarios namely:

 

[·      ]{style="FONT-FAMILY: Symbol"}Insert HTML Document

[·      ]{style="FONT-FAMILY: Symbol"}Insert HTML Formatted String

 

Insert HTML Document

 

This option enables to insert a whole HTML document with the following limitations:

 

[·      ]{style="FONT-FAMILY: Symbol"}XHTML 1.0 Strict is preferred; XHTML 1.0 Transitional is also acceptable.

[·      ]{style="FONT-FAMILY: Symbol"}There is an option to validate against either XHTML Strict or Transitional schema. By default the given html string is validated against XHTML 1.0 Transitional schema and an exception is thrown, if the html is found to be non-complaint. However, you can set this property on the document object to either, validate against XHTML Transitional schema or, Strict schema.

[·      ]{style="FONT-FAMILY: Symbol"}If a block element is not supported, then its style would still be parsed and applied to the supported child elements inside.

[·      ]{style="FONT-FAMILY: Symbol"}All the limitations are documented in Appendix 1 and 2.

 

The following code illustrates inserting a HTML string into a section of the Word document.

 

+-----------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**              |
|                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                             |
| [//Inserting some XHTML]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}  |
|                                                                             |
| [section.Body.InsertXHTML(HtmlString);]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------+

 

The **InsertXHTML** method has two overloads that specify the start paragraph item index and the end paragraph item index. The inserted XHTML adds several Word paragraphs, internally (with several possible paragraph items like lists and so on), and tables inside the Textbody of the Word document (Textbody is the container for paragraphs and tables in the Word object model).\
\

It is also possible to check if the given XHTML string is valid or not by using the **WTextBody.IsValidXHTML** method. Refer to Appendix 1 and 2 for the list of supported tags and attributes.

 

Also, you can open the HTML file directly from the Word document constructor, and convert the HTML file into a Word document.

 

The following code illustrates opening a **XHTML** document and saving it as a Word document by using DocIO.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                          |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ document = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: teal"}(String filename, [FormatType]{style="COLOR: teal"} formattype, XHTMLValidationType XHTMLvalidationtype);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                          |
| [document.Save(\"sample.doc\");]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Support for partial path of an image:

[]{style="FONT-WEIGHT: normal"} 

Currently EssentialDocIO provides support for **the** partial path of an image onl**y when directly loading the HTML file into the W**ord document using document.Open() method.

 

The following are the two overloaded methods.

[]{style="FONT-WEIGHT: normal"} 

[·      ]{style="FONT-FAMILY: Symbol"}Document.open(string fileName, FormatType formatType, XHTMLValidationType validationType, string baseUrl)

[·      ]{style="FONT-FAMILY: Symbol"}Document.open(Stream stream, FormatType formatType, XHTMLValidationType validationType, string baseUrl)

 

The following code illustrates loading the HTML file containing the partial path of an image.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                   |
| [//Creating a new instance for the Word document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                   |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ document = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                                                                   |
| [//Setting the base folder path]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                   |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ basePath=[@\"C:\\InputFolder\\\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                                                                                                   |
| [//Opening the html file along with the base path of the html file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                   |
| [document.Open([Path]{style="COLOR: #2b91af"} .Combine (basePath ,[\"Input.html\"]{style="COLOR: #a31515"}), Syncfusion.DocIO.[FormatType]{style="COLOR: #2b91af"}.Automatic, [XHTMLValidationType]{style="COLOR: #2b91af"}.None, basePath);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                   |
| [//Saving the document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                   |
| [document.Save(\"sample.doc\");]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                   |
| [            ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Insert Formatted Text Snippet

 

This option enables to insert XHTML formatted text inside Word paragraphs with the following limitations:

 

[·      ]{style="FONT-FAMILY: Symbol"}The content will be placed inside a \<p\> tag, to validate against the XHTML schemas as explained before.

[·      ]{style="FONT-FAMILY: Symbol"}This html snippet cannot contain any block elements like div, and so on, and will result in an exception being thrown otherwise. The only exception to this case is a single \<p\> tag.

[·      ]{style="FONT-FAMILY: Symbol"}Among the supported XHTML tags, only the inline tags can be used for formatting text.

 

The following code illustrates appending a HTML formatted string into a paragraph.

 

+----------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                               |
|                                                                                              |
| []{style="COLOR: black"}                                                                     |
|                                                                                              |
| [//Adding a new paragraph to the section.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                              |
| [IWParagraph paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                              |
| [paragraph.AppendXHTML(htmlstring);]{style="FONT-FAMILY: 'Courier New'"}                     |
+----------------------------------------------------------------------------------------------+

 

The following references enable to validate the HTML string for XHTML compliance.

 

[·      ]{style="FONT-FAMILY: Symbol"}http://www.w3schools.com/tags/default.asp

[·      ]{style="FONT-FAMILY: Symbol"}http://validator.w3.org/check

 

Appendix 1 -- Imported HTML Tags\
\

::: {align="center"}
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| HTML Element      | Style Attributes specific to this element (In addition to standard style attributes) | Non-Style Attributes supported (These attributes are applied directly to the element) | Limitations                                                      |
+===================+======================================================================================+=======================================================================================+==================================================================+
| b                 | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| big               | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| br                | \-                                                                                   | clear                                                                                 | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| sub               | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| sup               | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| em                | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| font              | \-                                                                                   | face                                                                                  | The attribute value *normal* and *bigger* are not supported.     |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | size                                                                                  |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | color                                                                                 |                                                                  |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| h1,h2,h3,h4,h5,h6 | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| i                 | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| li                | \-                                                                                   | \-                                                                                    |                                                                  |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| p                 | \-                                                                                   | align                                                                                 | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| pre               | \-                                                                                   | \-                                                                                    | Font style will be changed as courier. Space cannot be inserted. |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| s                 | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| small             | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| strike            | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| strong            | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| table             |                                                                                      | border                                                                                | \-                                                               |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | border-color                                                                          |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | cellpadding                                                                           |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | cellspacing                                                                           |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | background-color                                                                      |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | bgcolor                                                                               |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | align                                                                                 |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | width                                                                                 |                                                                  |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| td                | width, vertical-align                                                                | width                                                                                 | \-                                                               |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | rowspan                                                                               |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | colspan                                                                               |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | align                                                                                 |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | valign                                                                                |                                                                  |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| th                | width, vertical-align                                                                | width                                                                                 | \-                                                               |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | rowspan                                                                               |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | colspan                                                                               |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | align                                                                                 |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | valign                                                                                |                                                                  |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| tr                | \-                                                                                   | height                                                                                | \-                                                               |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | align                                                                                 |                                                                  |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| tt                | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| u                 | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| ul                | \-                                                                                   | \-                                                                                    | -.                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| img               | \-                                                                                   | height                                                                                | Currently Partial Image path is not supported.                   |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | width                                                                                 |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | src                                                                                   |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | align                                                                                 |                                                                  |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| div               | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| blockquote        | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| a                 | \-                                                                                   | href                                                                                  | \-                                                               |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | target                                                                                |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | id                                                                                    |                                                                  |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | name                                                                                  |                                                                  |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| tboby             | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| thead             | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| tfoot             | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| style             | \-                                                                                   | \-                                                                                    | \-                                                               |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
| body              | \-                                                                                   | Vlink                                                                                 | \-                                                               |
|                   |                                                                                      |                                                                                       |                                                                  |
|                   |                                                                                      | link                                                                                  |                                                                  |
+-------------------+--------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------+------------------------------------------------------------------+
:::

 

Appendix 2 - Standard Style Attributes

 

::: {align="center"}
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Standard Style Attributes (These style attributes are supported by all supported XHTML elements) | Limitations                                                                                                                                                   |
+==================================================================================================+===============================================================================================================================================================+
| font-family                                                                                      | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| font-size                                                                                        | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| font-style                                                                                       | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| font-weight                                                                                      | Different levels of bold are not supported as Word does n't support bold level.                                                                               |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| text-align                                                                                       | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| text-decoration                                                                                  | Only underline and strike through are supported.                                                                                                              |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| color                                                                                            | In the body and font, elements and foreground color can be set using either hexidecimal format (#RRGGBB) or one of 16 predefined  case-sensitive color names. |
|                                                                                                  |                                                                                                                                                               |
|                                                                                                  | In the color property of the style attribute, foreground color can be set using hexadecimal format (#RRGGBB).                                                 |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| line-height or height                                                                            | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| background-color                                                                                 | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| margin                                                                                           | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| margin-left, margin-bottom, margin-top, margin-right                                             | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| text-indent                                                                                      | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| border-bottom, border-top, border-right, border-left                                             | The border color has to be specified in hexadecimal format (#RRGGBB).                                                                                         |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| border-color                                                                                     | The border color has to be specified in hexadecimal format (#RRGGBB).                                                                                         |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| border-left-color, border-right-color, border-top-color, border-bottom-color                     | The border color has to be specified in hexadecimal format (#RRGGBB).                                                                                         |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| border-width                                                                                     | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| border-left-width, border-right-width, border-bottom-width, border-top-width                     | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| border-style                                                                                     | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| border-left-style, border-right-style, border-top-style, border-bottom-style                     | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| page-break-before                                                                                | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| page-break-after                                                                                 | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| padding                                                                                          | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| padding-left                                                                                     | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| padding-right                                                                                    | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| padding-bottom                                                                                   | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| padding-top                                                                                      | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| line-height                                                                                      | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| letter-spacing                                                                                   | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| text-transform                                                                                   | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| white-space                                                                                      | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| list-style-image                                                                                 | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| list-style-type                                                                                  | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| outline                                                                                          | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| outline-style                                                                                    | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| outline-width                                                                                    | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| outline-color                                                                                    | \-                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{#_Find_and_Replace}[]{#p74} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image24_1.jpg){border="0"}Notes: Currently inserting XHtml formatted string in the Word document is not supported in Silverlight application.

 
:::

[]{#related-topics}
::::::

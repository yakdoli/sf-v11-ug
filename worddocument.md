::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=532b012e-eb4f-4a9d-9658-35549651c515){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=ba19bc5c-afa8-482b-8067-8538d49f969b){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}
:::

## Word Document {#word-document style="tab-stops: 0pt"}

 

You can open, modify and create Microsoft Word documents by using the **WordDocument** class. WordDocument class models the structure of a Microsoft Word document.

 

Creating a Word Document

 

To create a new document, use the **EnsureMinimal** method. This method creates a document with an empty section, and adds empty paragraphs to the newly created section.

 

Opening a Word Document

 

DocIO also gives you an opportunity to open existing documents, or read data from streams saved in the following FormatType variants.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Doc**: Microsoft Word File Format

[·      ]{style="FONT-FAMILY: Symbol"}**Txt**: Text File Format

[·      ]{style="FONT-FAMILY: Symbol"}**Docx**: Word 2007 File Format

[·      ]{style="FONT-FAMILY: Symbol"}**Dot**: Word Template Format

[·      ]{style="FONT-FAMILY: Symbol"}**HTML**: HTML Format

[·      ]{style="FONT-FAMILY: Symbol"}**RTF**: Rich Text Format

[·      ]{style="FONT-FAMILY: Symbol"}**Docm** -- Word Macro-enabled Document Format

[·      ]{style="FONT-FAMILY: Symbol"}**Dotm** -- Word Macro-enabled Template Format

[·      ]{style="FONT-FAMILY: Symbol"}**Dotx** -- Word Open xml Template Format

 

To open a document, use the **Open** method. There are several overloads for this method.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Open(string fileName)**: opens Word document

[·      ]{style="FONT-FAMILY: Symbol"}**Open(string fileName, FormatType formatType)**: opens the document with specified format type (.doc, .xml or .txt file)

[·      ]{style="FONT-FAMILY: Symbol"}**Open(Stream stream, FormatType formatType)**: opens the document from the stream which has the specified format type

 

To save a document back to the Word document format use the **Save** method. There are several overloads for this method.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Save(string fileName)**: saves to file in Microsoft Word format

[·      ]{style="FONT-FAMILY: Symbol"}**Save(string fileName, FormatType formatType)**: saves the document to file in .xml or Microsoft Word format

[·      ]{style="FONT-FAMILY: Symbol"}**Save(Stream stream, FormatType formatType)**: saves the document into stream in .xml or Microsoft Word format

[·      ]{style="FONT-FAMILY: Symbol"}**Save(string fileName, FormatType formatType, HttpResponse response, HttpContentDisposition contentDisposition)**: saves the document into the client browser

 

To open the document which is already opened in Word, use the **OpenReadOnly** method to open the document in the read-only mode.

 

[·      ]{style="FONT-FAMILY: Symbol"}OpenReadOnly(string fileName, FormatType formatType): opens the document in the read-only mode

 

Public Properties

 

::: {align="center"}
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Property                              | Description                                                                                                                                                                   |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Background                            | Gets document\'s background.                                                                                                                                                  |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Bookmarks                             | Gets document bookmarks.                                                                                                                                                      |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Built-inDocumentProperties            | Gets document built-in properties object.                                                                                                                                     |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ChildEntities                         | Gets the child entities.                                                                                                                                                      |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| CustomDocumentProperties              | Gets document custom properties object.                                                                                                                                       |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| EndnoteNumberFormat                   | Gets or sets endnote numbering format.                                                                                                                                        |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| EndnotePosition                       | Gets or sets endnote position in the document.                                                                                                                                |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| EntityType                            | Gets the type of the entity.                                                                                                                                                  |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FootnoteNumberFormat                  | Gets or sets footnote numbering format.                                                                                                                                       |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FootnotePosition                      | Gets or sets footnote position in the document.                                                                                                                               |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| InitialEndnoteNumber                  | Gets or sets the initial endnote number.                                                                                                                                      |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| InitialFootnoteNumber                 | Gets or sets the initial footnote number.                                                                                                                                     |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| LastParagraph                         | Gets last section object.                                                                                                                                                     |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| LastSection                           | Gets last section of the document.                                                                                                                                            |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ListStyles                            | Gets document list styles.                                                                                                                                                    |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| MailMerge                             | Gets mail merge engine.                                                                                                                                                       |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ProtectionType                        | Gets or sets the type of protection of the document.                                                                                                                          |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| RestartIndexForEndnote                | Gets or sets the restart index for endnote.                                                                                                                                   |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| RestartIndexForFootnotes              | Gets or sets the restart index for footnotes.                                                                                                                                 |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Sections                              | Gets document sections.                                                                                                                                                       |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Styles                                | Gets document styles.                                                                                                                                                         |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| TextBoxes                             | Gets or sets textbox items of main document.                                                                                                                                  |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ThrowExceptionsForUnsupportedElements | Gets or sets whether to throw exceptions for unsupported elements.                                                                                                            |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ViewSetup                             | Gets view setup options in MSWord.                                                                                                                                            |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Watermark                             | Gets or sets document\'s watermark.                                                                                                                                           |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FontSubtitutionTable                  | Gets or sets a dictionary object which represents the font substitution table. The key should be the font name and the value should be its corresponding alternate font name. |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| HasMacros                             | Determines whether the document has Macros.                                                                                                                                   |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| AttachedTemplate                      | Gets the attached template.                                                                                                                                                   |
|                                       |                                                                                                                                                                               |
|                                       |                                                                                                                                                                               |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| UpdateStylesOnOpen                    | Gets or sets a value indicating whether to automatically update the styles of a document from the attached template each time the document is opened.                         |
|                                       |                                                                                                                                                                               |
|                                       |                                                                                                                                                                               |
+---------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

Public Constructors

 

::: {align="center"}
+--------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------+
| Name                                                   | Description                                                                                                             |
+--------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------+
| WordDocument.WordDocument ()                           | Initializes a new instance of the WordDocument class.                                                                   |
|                                                        |                                                                                                                         |
|                                                        |                                                                                                                         |
+--------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------+
| WordDocument.WordDocument (Stream)                     | Initializes a new instance of the WordDocument class from the stream.                                                   |
|                                                        |                                                                                                                         |
|                                                        |                                                                                                                         |
+--------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------+
| WordDocument.WordDocument (Stream, FormatType, string) | Initializes a new instance of the WordDocument class from the stream of specified type, protected with password.        |
|                                                        |                                                                                                                         |
|                                                        |                                                                                                                         |
+--------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------+
| WordDocument.WordDocument (Stream, string)             | Initializes a new instance of the WordDocument class from the Word document's stream, which is protected with password. |
|                                                        |                                                                                                                         |
|                                                        |                                                                                                                         |
+--------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------+
| WordDocument.WordDocument (string)                     | Initializes a new instance of the WordDocument class from Word document.                                                |
|                                                        |                                                                                                                         |
|                                                        |                                                                                                                         |
+--------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------+
| WordDocument.WordDocument (string, FormatType, string) | Initializes a new instance of the WordDocument class from existing file of specified type protected with password.      |
|                                                        |                                                                                                                         |
|                                                        |                                                                                                                         |
+--------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------+
| WordDocument.WordDocument (string, string)             | Initializes a new instance of the WordDocument class from existing Word document, which is protected with password.     |
+--------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------+
:::

 

Public Methods

 

::: {align="center"}
  ------------------------ --------------------------------------------------------------------------------------
  Name                     Description
  AddListStyle             Adds new list style to document.  
  AddParagraphStyle        Adds new paragraph style to the document.  
  AddSection               Adds new section to document.  
  Clone                    Clones itself.  
  CreateParagraph          Creates the paragraph.  
  CreateParagraphItem      Creates new paragraph item instance.  
  EnsureMinimal            Adds one empty section to the document and one empty paragraph to created section.  
  Find                     Finds the first entry of specified string.
  FindAll                  Finds all entries of specified string.
  GetText                  Gets the document\'s text.  
  ImportContent            Imports all content into document.  
  ImportSection            Imports section into document.  
  Open                     Opens doc file.
  OpenTxt                  Opens the document in text format.  
  OpenXml                  Opens the document in xml format.
  Replace                  Replaces all entries of given string.
  Save                     Saves WordDocument instance to the specified file format.
  OpenReadOnly             Open the document in ReadOnly mode.
  UpdateDocumentFields()   Updates the fields present in the document.
  RemoveMacros             Removes the macros in the document
  ------------------------ --------------------------------------------------------------------------------------
:::

 

The following example illustrates how to use the Open and Save methods.

 

+--------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                           |
|                                                                                                                          |
|                                                                                                                          |
|                                                                                                                          |
| [//Open the Word document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                             |
|                                                                                                                          |
| [WordDocument sourceDoc = [new]{style="COLOR: blue"} WordDocument();]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                          |
| [sourceDoc.Open([\"SourceDocument.doc\"]{style="COLOR: maroon"}, FormatType.Doc);]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                          |
| [//Create a new word document with one section and one paragraph]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}      |
|                                                                                                                          |
| [WordDocument doc = [new]{style="COLOR: blue"} WordDocument();]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                          |
| [doc.EnsureMinimal();]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                          |
| [//Clone the content of source document to the newly created document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                          |
| [doc = sourceDoc.Clone();]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                          |
| [//Save the document as xml]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                           |
|                                                                                                                          |
| [doc.Save([\"Document.doc\"]{style="COLOR: maroon"}, FormatType.Doc);]{style="FONT-FAMILY: 'Courier New'"}               |
+--------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                       |
|                                                                                                                          |
|                                                                                                                          |
|                                                                                                                          |
| [\'Open the Word document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                             |
|                                                                                                                          |
| [Dim sourceDoc As WordDocument = New WordDocument()]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                   |
|                                                                                                                          |
| [sourceDoc.Open(\"SourceDocument.doc\", FormatType.Doc)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}               |
|                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                     |
|                                                                                                                          |
| [\'Create a new word document with one section and one paragraph]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}      |
|                                                                                                                          |
| [Dim doc As WordDocument = New WordDocument()]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                         |
|                                                                                                                          |
| [doc.EnsureMinimal()]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                  |
|                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                     |
|                                                                                                                          |
| [\'Clone the content of source document to the newly created document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                          |
| [doc = sourceDoc.Clone()]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                              |
|                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                     |
|                                                                                                                          |
| [\'Save the document as xml]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                           |
|                                                                                                                          |
| [doc.Save(\"Document.doc\", FormatType.Doc)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                           |
|                                                                                                                          |
| []{style="COLOR: black"}                                                                                                 |
+--------------------------------------------------------------------------------------------------------------------------+

 

For More Information Refer:

 

[[Document Properties]{.UGHyperlink}](ms-xhelp:///?Id=ba19bc5c-afa8-482b-8067-8538d49f969b)[,]{.UGHyperlink} [[Document Background]{.UGHyperlink}](ms-xhelp:///?Id=f3c66e28-a2aa-4906-8e2c-17a9d80d9538), [[Docx Support]{.UGHyperlink}](ms-xhelp:///?Id=557db164-3f96-46ca-bdde-ee63b381764e), [[Stream Support]{.UGHyperlink}](ms-xhelp:///?Id=743c99d4-6def-4487-8630-0f62728800d1)[]{.UGHyperlink}

[[]{style="TEXT-DECORATION: none"}]{.UGHyperlink} 

[[]{style="TEXT-DECORATION: none"}]{.UGHyperlink} 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Document Properties](ms-xhelp:///?Id=ba19bc5c-afa8-482b-8067-8538d49f969b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Document Background](ms-xhelp:///?Id=f3c66e28-a2aa-4906-8e2c-17a9d80d9538){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Docx Support](ms-xhelp:///?Id=557db164-3f96-46ca-bdde-ee63b381764e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Stream Support](ms-xhelp:///?Id=743c99d4-6def-4487-8630-0f62728800d1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Macro-enabled Document Support](ms-xhelp:///?Id=32b546e9-9d95-42a6-a35c-9acc3f9939bc){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Track Changes](ms-xhelp:///?Id=9075f0ab-b874-4df8-a7b6-072f6524ea7e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Font Substitution for Word Documents](ms-xhelp:///?Id=a210ada1-25c4-4966-be29-993b303c7694){style="TEXT-DECORATION: none"}
:::::::

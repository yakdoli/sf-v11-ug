::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Merge Field {#merge-field style="tab-stops: 0pt"}

 

**WMergeField** class represents a merge field in the Word document. To add a merge field in Microsoft Word, open the **Insert** menu, click **Field**, and then click **MergeField**. Merge field is suitable for mail merge because it is easy to set the user\'s data inside it.

 

[·      ]{style="FONT-FAMILY: Symbol"}**FieldName**: defines the name of the field

[·      ]{style="FONT-FAMILY: Symbol"}**TextBefore** and **TextAfter**: define the text that is displayed before and after the merge field

[·      ]{style="FONT-FAMILY: Symbol"}**NumberFormat** and **DateFormat**: define the number and date format respectively

 

These properties are used during mail merge. NumberFormat and DateFormat properties do not have an equivalent in Word MergeField.

 

**Class Hierarchy**

 

WTextRange

             \|

       WField

              \|   

             WMergeField

 

**Public Constructor**

 

::: {align="center"}
  ----------------------------------------- ------------------------------------------------------
  Name                                      Description
  WMergeField.WMergeField (IWordDocument)   Initializes a new instance of the WMergeField class.
  ----------------------------------------- ------------------------------------------------------
:::

 

Public Properties

 

::: {align="center"}
  -------------- ---------------------------------------------
  Name           Description
  DateFormat     Gets the date format.  
  EntityType     Gets the type of the entity.  
  FieldName      Gets or sets field name.
  NumberFormat   Gets the number format.  
  Prefix         Gets the prefix of merge field.
  TextAfter      Gets or sets the text after merge field.  
  TextBefore     Gets or sets the text before merge field.  
  -------------- ---------------------------------------------
:::

 

The following example illustrates how to add the a merge field to the header and footer of the document.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                 |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                           |
|                                                                                                                                                                |
| [IWSection]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ section = doc.AddSection();]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                |
| [IWParagraph]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ paragraph = section.AddParagraph();]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                |
| [paragraph.AppendText([\"Testing writing Merge Fields into Header\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [section.PageSetup.DifferentFirstPage = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                |
| [section.PageSetup.DifferentOddAndEvenPages = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                |
| [paragraph = [new]{style="COLOR: blue"} [WParagraph]{style="COLOR: #2b91af"}(doc);]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                |
| [paragraph.AppendText([\"\[ FIRST PAGE Header \]\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                |
| [section.HeadersFooters.FirstPageHeader.Paragraphs.Add(paragraph);]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                |
| [paragraph = [new]{style="COLOR: blue"} [WParagraph]{style="COLOR: #2b91af"}(doc);]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                |
| [paragraph.AppendField([\"Field\'s Name\"]{style="COLOR: #a31515"}, [FieldType]{style="COLOR: #2b91af"}.FieldMergeField);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                |
| [section.HeadersFooters.FirstPageHeader.Paragraphs.Add(paragraph);]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [paragraph = [new]{style="COLOR: blue"} [WParagraph]{style="COLOR: #2b91af"}(doc);]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                |
| [paragraph.AppendText([\"\[ FIRST PAGE Footer \]\\r\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                |
| [section.HeadersFooters.FirstPageFooter.Paragraphs.Add(paragraph);]{style="FONT-FAMILY: 'Courier New'"}                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------+

*[]{style="COLOR: red"}* 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                    |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                  |
|                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ section [As]{style="COLOR: blue"} IWSection = doc.AddSection()]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ paragraph [As]{style="COLOR: blue"} IWParagraph = section.AddParagraph()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                       |
| [paragraph.AppendText([\"Testing writing Merge Fields into Header\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                       |
| [section.PageSetup.DifferentFirstPage = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                       |
| [section.PageSetup.DifferentOddAndEvenPages = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                       |
| [paragraph = [New]{style="COLOR: blue"} WParagraph(doc)]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                       |
| [paragraph.AppendText([\"\[ FIRST PAGE Header \]\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                       |
| [section.HeadersFooters.FirstPageHeader.Paragraphs.Add(paragraph)]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                       |
| [paragraph = [New]{style="COLOR: blue"} WParagraph(doc)]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                       |
| [paragraph.AppendField([\"Field\'s Name\"]{style="COLOR: #a31515"}, FieldType.FieldMergeField)]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                       |
| [section.HeadersFooters.FirstPageHeader.Paragraphs.Add(paragraph)]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                       |
| [paragraph = [New]{style="COLOR: blue"} WParagraph(doc)]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                       |
| [paragraph.AppendText([\"\[ FIRST PAGE Footer \]\"]{style="COLOR: #a31515"} & Constants.vbCr)]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                       |
| [section.HeadersFooters.FirstPageFooter.Paragraphs.Add(paragraph) ]{style="FONT-FAMILY: 'Courier New'"}                                                               |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::::

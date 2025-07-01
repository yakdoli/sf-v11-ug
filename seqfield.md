::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Seq Field {#seq-field style="tab-stops: 0pt"}

 

**WSeqField** class represents a sequence field type in the Word document. To add a sequence field in Microsoft Word, open **Insert** menu, click **Field**, and then click **Seq**. You can find information about the sequence field in the following location: [http://office.microsoft.com/en-us/word/HP051861901033.aspx]{style="COLOR: black"}.

 

You can use the **NumberFormat** property to set the numbering format for the fields, and the **CaptionName** property to set the name of the caption.

 

**Public Constructor**

 

::: {align="center"}
  ------------------------------------- ----------------------------------------------------
  Name                                  Description
  WSeqField.WSeqField (IWordDocument)   Initializes a new instance of the WSeqField class.
  ------------------------------------- ----------------------------------------------------
:::

 

Public Properties

 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------------+
| Name                              | Description                                                                    |
+-----------------------------------+--------------------------------------------------------------------------------+
| CaptionName                       | Gets or sets caption name.                                                     |
+-----------------------------------+--------------------------------------------------------------------------------+
| EntityType                        | Gets the type of the entity.                                                   |
+-----------------------------------+--------------------------------------------------------------------------------+
| FormattingString                  | Gets the formatting string.                                                    |
+-----------------------------------+--------------------------------------------------------------------------------+
| NumberFormat                      | Gets or sets the type of caption numbering. It includes the following options. |
|                                   |                                                                                |
|                                   |                                                                                |
|                                   |                                                                                |
|                                   | Number                                                                         |
|                                   |                                                                                |
|                                   | Roman                                                                          |
|                                   |                                                                                |
|                                   | Alphabetic                                                                     |
+-----------------------------------+--------------------------------------------------------------------------------+
:::

[]{style="COLOR: red"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                               |
| [WSeqField]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ field = ( [WSeqField]{style="COLOR: #2b91af"} )paragraph.AppendField([\"Sequence Field\"]{style="COLOR: #a31515"}, [FieldType]{style="COLOR: #2b91af"}.FieldSequence );]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                               |
| [field.CaptionName = [\"Sequence Field\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                               |
| [field.NumberFormat = [CaptionNumberingFormat]{style="COLOR: #2b91af"}.Alphabetic;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ field [As]{style="COLOR: blue"} WSeqField = [CType]{style="COLOR: blue"}(paragraph.AppendField([\"Sequence Field\"]{style="COLOR: #a31515"}, FieldType.FieldSequence), WSeqField)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                |
| [field.CaptionName = [\"Sequence Field\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                |
| [field.NumberFormat = CaptionNumberingFormat.Alphabetic]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::::

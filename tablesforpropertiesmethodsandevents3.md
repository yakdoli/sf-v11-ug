::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Tables for Properties, Methods, and Events {#tables-for-properties-methods-and-events style="tab-stops: 0pt"}

Properties

 

The following table illustrates the properties under **GridColumn**, which is relevant to **CellEditType** functionality.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

::: {align="center"}
+-----------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+------------------------------------------------+------------------------------------------------------------------------------+--------------+
| Name                  | Description                                                                                                                                             | Type of property | Data type                                      | Value it accepts                                                             | Dependency   |
+=======================+=========================================================================================================================================================+==================+================================================+==============================================================================+==============+
| CellEditType          | Used to set the **CellEditType** of the specified column.                                                                                               | Server-side      | CellEditType                                   | [CellEditType]{style="COLOR: #2b91af"}.StringEdit,                           | AllowEditing |
|                       |                                                                                                                                                         |                  |                                                |                                                                              |              |
|                       |                                                                                                                                                         |                  |                                                | [CellEditType]{style="COLOR: #2b91af"}[.]{style="COLOR: gray"}BooleanEdit,   |              |
|                       |                                                                                                                                                         |                  |                                                |                                                                              |              |
|                       |                                                                                                                                                         |                  |                                                | [CellEditType]{style="COLOR: #2b91af"}[.]{style="COLOR: gray"} DropdownEdit, |              |
|                       |                                                                                                                                                         |                  |                                                |                                                                              |              |
|                       |                                                                                                                                                         |                  |                                                | [CellEditType]{style="COLOR: #2b91af"}[.]{style="COLOR: gray"} DateTimeEdit, |              |
|                       |                                                                                                                                                         |                  |                                                |                                                                              |              |
|                       |                                                                                                                                                         |                  |                                                | [CellEditType]{style="COLOR: #2b91af"}[.]{style="COLOR: gray"} MaskEdit,     |              |
|                       |                                                                                                                                                         |                  |                                                |                                                                              |              |
|                       |                                                                                                                                                         |                  |                                                | [CellEditType]{style="COLOR: #2b91af"}[.]{style="COLOR: gray"} PercentEdit,  |              |
|                       |                                                                                                                                                         |                  |                                                |                                                                              |              |
|                       |                                                                                                                                                         |                  |                                                | [CellEditType]{style="COLOR: #2b91af"}[.]{style="COLOR: gray"} NumericEdit   |              |
+-----------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+------------------------------------------------+------------------------------------------------------------------------------+--------------+
| NumericEditParams     | Used to set **NumericEditParams** when the **CellEditType** is NumericEdit.                                                                             | Server-side      | [NumericTextBoxModel]{style="COLOR: #2b91af"}  | [NumericTextBoxModel]{style="COLOR: #2b91af"} Object                         | CellEditType |
|                       |                                                                                                                                                         |                  |                                                |                                                                              |              |
|                       |                                                                                                                                                         |                  |                                                |                                                                              |              |
|                       |                                                                                                                                                         |                  |                                                |                                                                              |              |
|                       |                                                                                                                                                         |                  |                                                |                                                                              |              |
+-----------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+------------------------------------------------+------------------------------------------------------------------------------+--------------+
| PercentEditParams     | Used to set **PercentEditParams** when the **CellEditType** is **PercentEdit**.                                                                         | Server-side      | [PercentTextBoxModel]{style="COLOR: #2b91af"}  | [PercentTextBoxModel]{style="COLOR: #2b91af"} Object                         | CellEditType |
|                       |                                                                                                                                                         |                  |                                                |                                                                              |              |
|                       |                                                                                                                                                         |                  |                                                |                                                                              |              |
+-----------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+------------------------------------------------+------------------------------------------------------------------------------+--------------+
| MaskEditParams        | Used to set **MaskEditParams** when the **CellEditType** is **MaskEdit**.                                                                               | Server-side      | [MaskEditTextBoxModel]{style="COLOR: #2b91af"} | [MaskEditTextBoxModel]{style="COLOR: #2b91af"} Object                        | CellEditType |
+-----------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+------------------------------------------------+------------------------------------------------------------------------------+--------------+
| AllowFormatinEditMode | Used to set the **AllowFormatinEditMode**. If any format is applied to the column, then when editing, it decides whether the format is required or not. | Server-side      | [Boolean]{style="COLOR: #2b91af"}              | True/false[]{style="COLOR: #2b91af"}                                         | AllowEditing |
+-----------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------+------------------+------------------------------------------------+------------------------------------------------------------------------------+--------------+
:::

***[]{style="LAYOUT-GRID-MODE: line; FONT-FAMILY: 'Calibri','sans-serif'"}*** 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image58_6.jpg){border="0"}Note: Refer to Tools MVC\>NumericTextbox UG to set NumericEditParams

Refer to Tools MVC\>PercentTextbox UG to set PercentEditParams

Refer to Tools MVC\>MaskEditTextbox UG to set MaskEditParams
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

The following table illustrates the CellEditType option usages and controls.

 

::: {align="center"}
  CellEditType                       Control           Usage
  ---------------------------------- ----------------- -----------------------------------------------------------------------------------------
  CellEditType.StringEdit(Default)   Textbox           Used to edit any string valued column.
  CellEditType.BooleanEdit           Checkbox          Used to specify true or  false by checking and unchecking respectively.
  CellEditType.DropdownEdit          DropdownList      Used to select from a list of values in the column.
  CellEditType.NumericEdit           NumericTextbox    Used to edit integers, double or decimals.
  CellEditType.PercentEdit           PercentTextbox    Used to edit integer, double or decimal with display string appended to percent symbol.
  CellEditType.MaskEdit              MaskEditTextbox   Used to mask any common string to the column.
  CellEditType.DateTimeEdit          Datepicker        Used to directly set the date.
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Link

To view the samples:

1.   Open the **ASP.NET MVC** Sample Browser from the dashboard. (Refer to the Samples and Location[ ]{style="COLOR: #00487e"}chapter)

2.   Navigate to **Grid**\>**Editing**\>**Cell Edit Type** demo.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

**[]{style="COLOR: black"}** 

[]{#related-topics}
::::::

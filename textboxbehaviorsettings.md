::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### TextBox Behavior Settings {#textbox-behavior-settings style="tab-stops: 0pt"}

 

Multiple line entries and Password entry

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The textbox can be used as single line entry textbox or can be made to display multiple lines of text. **TextMode** property can be used to set to one of the modes. When it is used in multiline mode, the number of rows that should be visible (when the text exceeds, automatically scrollbar will appear) can be set using **Rows** property.

 

It could also be used in password mode, where the input text will be masked using circular dots.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------+
|                                   |                                                                                                                        |
|                                   |                                                                                                                        |
| Property                          | Description                                                                                                            |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------+
| Rows                              | Specifies the number of lines to display in a multi-line textbox.                                                      |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------+
| TextMode                          | Specifies the mode in which the textbox can be used. Default value is SingleLine. The options included are as follows: |
|                                   |                                                                                                                        |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}SingleLine                                                                       |
|                                   |                                                                                                                        |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}MultiLine                                                                        |
|                                   |                                                                                                                        |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Password                                                                         |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Programmatically these properties can be set as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                    |
|                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                          |
|                                                                                                                     |
| [AutoCompleteTextBox1.TextMode = [TextBoxMode]{style="COLOR: teal"}.MultiLine;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                     |
| [AutoCompleteTextBox1.Rows = 3;]{style="FONT-FAMILY: 'Courier New'"}                                                |
+---------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                       |
|                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                             |
|                                                                                                                                                        |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AutoCompleteTextBox1.TextMode = TextBoxMode.MultiLine]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                        |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AutoCompleteTextBox1.Rows = 3]{style="FONT-FAMILY: 'Courier New'"}                         |
+--------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Setting character limits

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The maximum character length inside the textbox can be specified by setting the **MaxLength** property, which allows to specify limits to the values entered in the textbox.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ----------- -----------------------------------------------------------------------------------
  Property    Description
  MaxLength   Specifies the maximum number of characters that should be allowed in the textbox.
  ----------- -----------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**ReadOnly** property when enabled does not allows to edit the textbox entries.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ---------- ----------------------------------------------------------------------------------
  Property   Description
  ReadOnly   Specifies whether the text in the textbox can be edited. Default value is False.
  ---------- ----------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Programmatically these properties can be set as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                   |
|                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                         |
|                                                                                                    |
| [AutoCompleteTextBox1.MaxLength = 5;]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                    |
| [AutoCompleteTextBox1.ReadOnly = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                             |
|                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                   |
|                                                                                                                                                              |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AutoCompleteTextBox1.MaxLength = 5]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                              |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AutoCompleteTextBox1.ReadOnly = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::::

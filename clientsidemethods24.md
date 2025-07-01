::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Client Side Methods {#client-side-methods style="tab-stops: 0pt"}

The MaskEdit text box control supports rich set of client-side methods to control its behavior.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt; FONT-WEIGHT: normal"} 

Methods

+---------------------+-----------------+-----------------+--------------------------------------------+
| Name                | Parameters      | Return type     | Description                                |
+---------------------+-----------------+-----------------+--------------------------------------------+
| get_StrippedValue   | NA              | string          | Returns the textbox value without literals |
+---------------------+-----------------+-----------------+--------------------------------------------+
| get_UnstrippedValue | NA              | string          | Returns the textbox value with literals    |
|                     |                 |                 |                                            |
|                     |                 |                 |                                            |
+---------------------+-----------------+-----------------+--------------------------------------------+
| get_Value           | NA              | string          | Returns the textbox value as it is         |
+---------------------+-----------------+-----------------+--------------------------------------------+
| get_WaterMarkText   | NA              | string          | Returns the current watermark text         |
+---------------------+-----------------+-----------------+--------------------------------------------+
| set_WaterMarkText   | string          | \-              | Sets the watermark text to the textbox     |
+---------------------+-----------------+-----------------+--------------------------------------------+
| Clear               | NA              | \-              | Clears the textbox                         |
|                     |                 |                 |                                            |
|                     |                 |                 |                                            |
+---------------------+-----------------+-----------------+--------------------------------------------+

 

The following steps, guides you in using the client side methods:

1.   In **View**, invoke the MaskEdit text box helper with the control ID as first argument.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**  

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                             |
|                                                                                                                                                                                |
| [  ]{style="FONT-FAMILY: 'Courier New'"} [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [{                                ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                |
| [      Html.Syncfusion().MaskEditTextBox([\"myMaskEdit\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                |
| **[.Mask([\"999-99-999\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                |
| [       }[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                |
| **[ \[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                           |
|                                                                                                                                                                                |
| [    ]{style="FONT-FAMILY: 'Courier New'"} [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} []{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                |
| [      Html.Syncfusion().MaskEditTextBox([\"myMaskEdit\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                |
| **[.Mask([\"999-99-999\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

2.     In JavaScript, use the methods as they are given in the following code:

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**  

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}** [ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                                    |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [script]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"} [ [type]{style="COLOR: red"} [=\"text/javascript\"\>]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                    |
| [        [function]{style="COLOR: blue"} Get_Values() {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                                                    |
| [            [var]{style="COLOR: blue"} value = \$find([\"myMaskEdit\"]{style="COLOR: maroon"}).get_Value();]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                                                    |
| [            [var]{style="COLOR: blue"} unstrippedValue = \$find([\"myMaskEdit\"]{style="COLOR: maroon"}).get_UnstrippedValue();]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                                                    |
| [            [var]{style="COLOR: blue"} strippedValue = \$find([\"myMaskEdit\"]{style="COLOR: maroon"}).get_StrippedValue();]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                    |
| [        [function]{style="COLOR: blue"} WaterMarkText() {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                                    |
| [            [var]{style="COLOR: blue"} waterMark = \$find([\"myMaskEdit\"]{style="COLOR: maroon"}).get_WaterMarkText();]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                                                    |
| [            \$find([\"myMaskEdit\"]{style="COLOR: maroon"}).set_WaterMarkText([\"EnterValue\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                    |
| [        [function]{style="COLOR: blue"} Clear() {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                                    |
| [            \$find([\"myMaskEdit\"]{style="COLOR: maroon"}).Clear();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                    |
| [       [\</]{style="COLOR: blue"}[script]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

3.   Build and run the application.

 

 

[]{#related-topics}
:::

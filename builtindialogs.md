::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Built-in Dialogs {#built-in-dialogs style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Essential Tools Window Control provides built-in dialogs for alert, confirm, and prompt boxes. The syntax of these boxes are mentioned below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------+
| **[\[JS\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                       |
|                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                             |
|                                                                                                                        |
| [SFAlert( sText, sCaption, nWidth, nHeight );]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                        |
| [SFPrompt( sText, fnCallbackFunction, sCaption, sDefaultValue, nWidth, nHeight );]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                        |
| [SFConfirm( sText, fnCallbackFunction, sCaption, nWidth, nHeight );]{style="FONT-FAMILY: 'Courier New'"}               |
+------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image72_1.jpg){border="0"}Note: These parameters are nullable.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

For example, the following code snippet can be used to display the boxes.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[input]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [type]{style="COLOR: red"}[=\"button\"]{style="COLOR: blue"} [onclick]{style="COLOR: red"}[=\"onbuttonclick(0)\"]{style="COLOR: blue"} [value]{style="COLOR: red"}[=\"SFAlert\"]{style="COLOR: blue"} [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[input]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [type]{style="COLOR: red"}[=\"button\"]{style="COLOR: blue"} [onclick]{style="COLOR: red"}[=\"onbuttonclick(1)\"]{style="COLOR: blue"} [value]{style="COLOR: red"}[=\"SFPrompt\"]{style="COLOR: blue"} [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                                                                                                                                                                                          |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[input]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [type]{style="COLOR: red"}[=\"button\"]{style="COLOR: blue"} [onclick]{style="COLOR: red"}[=\"onbuttonclick(2)\"]{style="COLOR: blue"} [value]{style="COLOR: red"}[=\"SFConfirm\"]{style="COLOR: blue"} [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[JS\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                       |
|                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                             |
|                                                                                                                                                        |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ onbuttonclick(nIdx)]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                        |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                        |
| [    [var]{style="COLOR: blue"} sText = document.getElementById( [\"dialogtext\"]{style="COLOR: maroon"} ).value;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                        |
| [    [if]{style="COLOR: blue"}( nIdx == 0 )]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                        |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                        |
| [        SFAlert( sText, [\"Warning\"]{style="COLOR: maroon"} );]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                        |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                        |
| [    [else]{style="COLOR: blue"} [if]{style="COLOR: blue"}( nIdx == 1 )]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                        |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                        |
| [        SFPrompt( sText, fnCallback,[\"Enter a number\"]{style="COLOR: maroon"} );]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                        |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                        |
| [    [else]{style="COLOR: blue"} [if]{style="COLOR: blue"}( nIdx == 2 )]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                        |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                        |
| [        SFConfirm( sText, fnCallback, [\"Confirm\"]{style="COLOR: maroon"} );]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                        |
| [    }    ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                        |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
+--------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The return value of the prompt / confirm dialog boxes can be found as shown below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------+
| **[\[JS\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                    |
|                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                     |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ fnCallback( arg )]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                     |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                     |
| [    SFAlert( [\"return value: \"]{style="COLOR: maroon"} + arg );]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                     |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
+---------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::

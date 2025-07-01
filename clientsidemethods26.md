::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Client Side Methods {#client-side-methods style="tab-stops: 0pt"}

The Numeric text box control supports a rich set of client-side methods to control its behavior.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt; FONT-WEIGHT: normal"} 

Methods

  ---------- --------------------------------------------------- ------------- ---------------------------------------------------------
  Name       Parameters                                          Return type   Description
  getValue   NA                                                  String        Returns the current value of the text box as string
  setValue   Value (the value to be displayed in the text box)   NA            Sets the value of the text box with the specified value
  ---------- --------------------------------------------------- ------------- ---------------------------------------------------------

 

The following steps guide you in using the client side methods:

1.   In **View**, invoke the Numeric text box helper with control ID as the first argument.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**  

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                       |
|                                                                                                                                                                                          |
| [  ]{style="FONT-FAMILY: 'Courier New'"} [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [{                                ]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                          |
| [    Html.MobSyncfusion().NumericTextbox([\"myNumeric\")]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                          |
| [                          .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                          |
| [       }[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                          |
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                      |
|                                                                                                                                                                                          |
| [    ]{style="FONT-FAMILY: 'Courier New'"} [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} []{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                          |
| [           Html.MobSyncfusion().NumericTextbox([\"myNumeric\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                          |
| [                          .Render();       [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

2.     In JavaScript, use the methods as they are given in the following code:

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**  

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                           |
|                                                                                                                                                                                                                                    |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [script]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"} [ [type]{style="COLOR: red"} [=\"text/javascript\"\>]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                    |
| [        [function]{style="COLOR: blue"} Value() {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                                                    |
| [            [var]{style="COLOR: blue"} numericObj = \$find([\"myNumeric\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                    |
| [            [var]{style="COLOR: blue"} currentValue = numericObj.getValue();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                    |
| [            numericObj.setValue(100);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                                                    |
| [        }    ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                    |
| [       [\</]{style="COLOR: blue"}[script]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

3.   Build and run the application.

[]{#related-topics}
:::

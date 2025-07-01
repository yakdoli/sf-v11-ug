::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Client Side Events {#client-side-events style="tab-stops: 0pt"}

 

The MaskEdit text box control supports the client-side event handling.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt; FONT-WEIGHT: normal"} 

Events

  ----------------------- ------------------------------------------------------------------------------------------------------------------------------- ----------- ----------------
  Name                    Description                                                                                                                     Arguments   Reference Link
  ClientSideFocusIn       Event triggers when the [MaskEdit]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}text box gains focus            inst,args   \-
   ClientSideFocusOut     Event triggers when the [MaskEdit]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}text box loses focus            inst,args   \-
  ClientSideValueChange   Event triggers when the value of the [MaskEdit]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}text box changes   inst,args   \-
  ----------------------- ------------------------------------------------------------------------------------------------------------------------------- ----------- ----------------

 

Using Builder

The following steps, explains how to handle the client-side events through the Builder:

1.   In **View**, invoke the MaskEdit text box helper followed by the **ClientSideFocusIn**, **ClientSideFocusOut** and **ClientSideValueChange** methods with desired handlers as arguments.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                |
|                                                                                                                                                                   |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [{]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                   |
| [          Html.MobSyncfusion().MaskEditTextBox([\"myMask\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                   |
| [             .Mask([\"(999)999-9999\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                   |
| **[             .ClientSideFocusIn([\"OnFocusIn\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                                   |
| **[             .ClientSideFocusOut([\"OnFocusOut\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                   |
| **[             .ClientSideValueChange([\"OnValueChange\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                   |
| [                              .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                   |
| [                          }[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                   |
| [      []{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                   |
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                               |
|                                                                                                                                                                   |
| [    [\@{]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                   |
| [            Html.MobSyncfusion().MaskEditTextBox([\"myMask\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                   |
| [            .Mask([\"(999)999-9999\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                   |
| **[            .ClientSideFocusIn([\"OnFocusIn\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                   |
| **[            .ClientSideFocusOut([\"OnFocusOut\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                   |
| **[            .ClientSideValueChange([\"OnValueChange\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                   |
| [                              .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                   |
| [    [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   Define the call back methods in the script to handle the specified events.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**  

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[JavaScript\]]{style="FONT-FAMILY: 'Courier New'"}** [ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                                    |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [script]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"} [ [type]{style="COLOR: red"} [=\"text/javascript\"\>]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                    |
| [        [function]{style="COLOR: blue"} OnFocusIn(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                    |
| [            [//inst      - instance of numeric text box client-side object]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                                    |
| [            [//args:]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                                    |
| [            [//  \_value   - current value of the numeric text box]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                    |
| [        [function]{style="COLOR: blue"} OnFocusOut(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                    |
| [            [//inst      - instance of numeric text box client-side object]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                                    |
| [            [//args:]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                                    |
| [            [//  \_value   - current value of the numeric text box]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                                    |
| [        }      ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                    |
| [        [function]{style="COLOR: blue"} OnValueChange(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                                    |
| [            [//inst      - instance of numeric text box client-side object]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                                    |
| [            [//args:]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                                    |
| [            [//  \_value   - current value of the numeric text box]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                                    |
| [        }        ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                    |
| [       [\</]{style="COLOR: blue"}[script]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**  

3.   Run the application.

**[]{style="FONT-SIZE: 12pt"}**  

**[Using Properties Model      ]{style="FONT-SIZE: 12pt"}**

The following steps will explain how to handle the client-side events through the Properties model:

1.   In the **Controller**, create an instance of **MaskEditTextBoxModel**; define the **ClientSideFocusIn, ClientSideFocusOut** and **ClientSideValueChange** properties and pass the instance through the view-specific data to the view.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}** [ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                         |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| [            [MaskEditTextBoxModel]{style="COLOR: #2b91af"} myModel = [new]{style="COLOR: blue"}[MaskEditTextBoxModel]{style="COLOR: #2b91af"} ();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                         |
| [                     myModel.Mask = [\"999-99-999\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                         |
| [            **myModel.ClientSideFocusIn = [\"OnFocusIn\"]{style="COLOR: #a31515"};**]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                         |
| **[            myModel.ClientSideFocusOut = [\"OnFocusOut\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                         |
| **[            myModel.ClientSideValueChange = [\"OnValueChange\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}** []{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                                         |
| [            ViewData\[[\"myMask\"]{style="COLOR: #a31515"}\] = myModel;]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                         |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"} []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   In **View**, invoke the MaskEdit textbox helper with the ViewData key as the first argument.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                             |
|                                                                                                                                                                                |
| [  ]{style="FONT-FAMILY: 'Courier New'"} [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [{                                ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                |
| [    Html.MobSyncfusion().MaskEditTextbox([\"myMask\")]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                |
| [                          .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                |
| [       }[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                |
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                            |
|                                                                                                                                                                                |
| [    ]{style="FONT-FAMILY: 'Courier New'"} [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} []{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                |
| [           Html.MobSyncfusion().MaskEditTextbox([\"myMask\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                |
| [                          .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                |
| [       [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                           |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

3.   Define the call back methods in the script to handle the specified events.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**  

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}** [ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                                    |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [script]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"} [ [type]{style="COLOR: red"} [=\"text/javascript\"\>]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                    |
| [        [function]{style="COLOR: blue"} OnFocusIn(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                    |
| [            [//inst      - instance of numeric textbox client side object]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                                                    |
| [            [//args:]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                                    |
| [            [//  \_value   - current value of the numeric textbox]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                    |
| [        [function]{style="COLOR: blue"} OnFocusOut(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                    |
| [            [//inst      - instance of numeric textbox client side object]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                                                    |
| [            [//args:]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                                    |
| [            [//  \_value   - current value of the numeric textbox]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                    |
| [        [function]{style="COLOR: blue"} OnValueChange(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                                    |
| [            [//inst      - instance of numeric textbox client side object]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                                                    |
| [            [//args:]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                                    |
| [            [//  \_value   - current value of the numeric textbox]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                    |
| [        }        ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                    |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [script]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"} [\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} []{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**  

4.   Run the application.

 

[]{#related-topics}
:::

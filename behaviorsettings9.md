::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Behavior Settings {#behavior-settings style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The behavior of the jQueryUIDialog is controlled by using the following properties.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
|                                   |                                                                                                             |
|                                   |                                                                                                             |
| Property                          | Description                                                                                                 |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| HeaderText                        | Sets the dialog title in the jQueryUIDialog in string format.                                               |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| AutoOpen                          | Opens the dialog control automatically during page load. The default value is false.                        |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| CloseOnEsc                        | Closes the dialog control on pressing the escape button. The default value is true.                         |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| Draggable                         | Enables to drag the jQueryUIDialog. The default value is true.                                              |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| Resizable                         | Enables to resize the jQueryUIDialog. The default value is true.                                            |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| Modal                             | Sets the jQueryUIDialog as a modal dialog. Its background will be inaccessable. The default value is false. |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| Stack                             | Stacks all the dialogs. The default value is true.                                                          |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| ZIndex                            | Sets the ZIndex of the jQueryUIDialog. The default value is 1000.                                           |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| Show                              | Sets the effects to be shown when the dialog is displayed.                                                  |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| Hide                              | Sets the effects to be shown when the dialog is hidden.                                                     |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| DialogPosition                    | Sets the dialog position of the jQueryUIDialog control at run time.                                         |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| EnablePostback                    | Allows the controls inside the jQueryUIDialog to initiate postback.                                         |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[jQueryUIDialog]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [ID]{style="COLOR: red"}[=\"JQueryUIDialog1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} [EnablePostback]{style="COLOR: red"}[=\"true\" ]{style="COLOR: blue"}[HeaderText]{style="COLOR: red"}[=\"DialgTitle\"]{style="COLOR: blue"} [AutoOpen]{style="COLOR: red"}[=\"true\"]{style="COLOR: blue"} [CloseOnEsc]{style="COLOR: red"}[=\"true\"]{style="COLOR: blue"} [Draggable]{style="COLOR: red"}[=\"true\"]{style="COLOR: blue"} [Resizable]{style="COLOR: red"}[=\"true\"]{style="COLOR: blue"}                        [Modal]{style="COLOR: red"}[=\"true\"]{style="COLOR: blue"} [Stack]{style="COLOR: red"}[=\"true\"]{style="COLOR: blue"} [ZIndex]{style="COLOR: red"}[=\"1001\"]{style="COLOR: blue"} [Show]{style="COLOR: red"}[=\"Blind\"]{style="COLOR: blue"} [Hide]{style="COLOR: red"}[=\"Slide\"]{style="COLOR: blue"} [DialogPosition]{style="COLOR: red"}[=\"MiddleCenter\"\>]{style="COLOR: blue"}                        [\<]{style="COLOR: blue"}[DialogContent]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"} This is a Dialog Content[\</]{style="COLOR: blue"}[DialogContent]{style="COLOR: #a31515"}[\>\</]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[jQueryUIDialog]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

+--------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                             |
|                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                          |
|                                                                                                              |
| [jQueryUIDialog1.AutoOpen = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                              |
| [jQueryUIDialog1.HeaderText = [\"DialogTitle\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                              |
| [jQueryUIDialog1.CloseOnEsc = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                              |
| [jQueryUIDialog1.Draggable = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                              |
| [jQueryUIDialog1.Resizable = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                              |
| [jQueryUIDialog1.Modal = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                              |
| [jQueryUIDialog1.Stack = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                              |
| [jQueryUIDialog1.Show = DialogEffects.Blind;]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                              |
| [jQueryUIDialog1.Hide = DialogEffects.Slide;]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                              |
| [jQueryUIDialog1.DialogPosition = DialogPosition.MiddleCenter;]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                              |
| [JQueryUIDialog1.EnablePostback = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}          |
+--------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

+--------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                             |
|                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                          |
|                                                                                                              |
| [jQueryUIDialog1.AutoOpen = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                              |
| [jQueryUIDialog1.HeaderText = [\"DialogTitle\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                              |
| [jQueryUIDialog1.CloseOnEsc = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                              |
| [jQueryUIDialog1.Draggable = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                              |
| [jQueryUIDialog1.Resizable = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                              |
| [jQueryUIDialog1.Modal = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                              |
| [jQueryUIDialog1.Stack = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                              |
| [jQueryUIDialog1.Show = DialogEffects.Blind]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                              |
| [jQueryUIDialog1.Hide = DialogEffects.Slide]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                              |
| [jQueryUIDialog1.DialogPosition = DialogPosition.MiddleCenter]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                              |
| [JQueryUIDialog1.EnablePostback = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}          |
+--------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The position of the jQueryUIDialog control is set by using the following property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  --------------- --------------------------------------------------------------------------------------------------------------------------
  Property        Description
  PixelPosition   sets the positon of the dialog control in pixels. Index to use the DialogPosition property will be set to PixelPosition.
  --------------- --------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                |
|                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                             |
|                                                                                                                                                                                 |
| [jQueryUIDialog1.DialogPosition = DialogPosition.PixelPosition;]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                 |
| [int]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\[\] arr = [new]{style="COLOR: blue"} [int]{style="COLOR: blue"}\[2\] { 220, 400 };]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                 |
| [jQueryUIDialogPosition.PixelPosition = arr;]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                      |
|                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                       |
| [jQueryUIDialog1.DialogPosition = DialogPosition.PixelPosition]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ arr [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"}() = [New]{style="COLOR: blue"} [Integer]{style="COLOR: blue"}(2) {220, 400}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                       |
| [jQueryUIDialogPosition.PixelPosition = arr]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::::

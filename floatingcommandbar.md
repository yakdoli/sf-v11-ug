::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### [        ]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}Floating CommandBar {#floating-commandbar style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

By default, CommandBars can be floated on the form by dragging the gripper on the CommandBar. The properties that enable floating of CommandBars and customization of their settings are discussed below.

[]{style="COLOR: #15428b"} 

Table 5: CommandBar

::: {align="center"}
  --------------------- -------------------------------------------------------------
  CommandBar Property   Description
  DisableFloating       Indicates whether the CommandBar is allowed to float.
  FloatModeWrapping     Indicates whether the CommandBar should wrap when floating.
  FloatBounds           Gets / sets the bounds of a floating CommandBar.
  Floating              Returns the current dock / float state of the CommandBar.
  --------------------- -------------------------------------------------------------
:::

[]{style="COLOR: #15428b"} 

The float state of the CommandBar can be disabled by setting the **DisableFloating** property to \'True\'.

 

Setting **FloatModeWrapping** property to \'True\', wraps a floating CommandBar when it is resized to less than it\'s maximum length. The DisableFloating property must be set to \'False\' for this.

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                         |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                   |
|                                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.commandBar1.DisableFloating = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.commandBar1.FloatModeWrapping = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.commandBar1.FloatBounds = [new]{style="COLOR: blue"} System.Drawing.[Rectangle]{style="COLOR: teal"}(419, 303, 183, 47);]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                           |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                         |
|                                                                                                                                                                                              |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.commandBar1.DisableFloating = [False]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                              |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.commandBar1.FloatModeWrapping = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                              |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.commandBar1.FloatBounds = [New]{style="COLOR: blue"} System.Drawing.Rectangle(419, 303, 183, 47)]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

![](ImagesExt/image76_13.jpg){border="0"}

[]{style="COLOR: #15428b"} 

Figure 12: CommandBar in Float State

**[]{style="COLOR: #15428b"}** 

A sample which demonstrates the Floating CommandBar is available in the below sample installation path.

 

..My Documents\\Syncfusion\\EssentialStudio\\***Version Number***\\Windows\\Tools.Windows\\Samples\\2.0\\CommandBars Package\\CommandBars

[]{style="COLOR: #15428b"} 

See Also

[]{style="COLOR: #15428b"} 

[Docking CommandBar]{.UGHyperlink}[]{.UGHyperlink}

[]{#related-topics}
::::

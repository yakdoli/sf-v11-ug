::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Behavior Settings {#behavior-settings style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Behavior Settings

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The popup window can be initially displayed when the **InitiallyShown** property is enabled. This shows the popup by default until clicking anywhere on the page.

 

The popup control can be associated with any parent control, i.e., it can be popped up along any of the control in that page, by setting the **ParentControlID** property to the id of that parent control.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  -------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
           Property          Description
  InitiallyShown             Specifies whether to show the popup initially. Default value is false.
  ParentControlID            Client side id of the element to which PopupContainer is bound. With this property set, when you call ShowPopup in the client, the *PositionHorizontal* and *PositionVertical* properties will dictate how the popup will be positioned.
  -------------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                  |
|                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                        |
|                                                                                                                   |
| [PopupControlContainer1.InitiallyShown = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                   |
| [PopupControlContainer1.ParentControlID = [\"div1\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                            |
|                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                  |
|                                                                                                                                                                             |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PopupControlContainer1.InitiallyShown = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                             |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PopupControlContainer1.ParentControlID = [\"div1\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Popup Alignment

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The alignment can be set for the popup control relative to the parent control using the **PopupHorizontal** and **PopupVertical** properties.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                                          |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------+
| PositionHorizontal                | The horizontal position relative to the parent control. Default value is Near. The options included are as follows:  |
|                                   |                                                                                                                      |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Near                                                                           |
|                                   |                                                                                                                      |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Far                                                                            |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------+
| PositionVertical                  | The vertical position relative to the parent control. Default value is Bottom. The options included are as follows:  |
|                                   |                                                                                                                      |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Bottom                                                                         |
|                                   |                                                                                                                      |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Top                                                                            |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                      |
|                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                            |
|                                                                                                                                       |
| [PopupControlContainer1.PositionHorizontal = [PopupPositionHorizontal]{style="COLOR: teal"}.Far;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                       |
| [PopupControlContainer1.PositionVertical = [PopupPositionVertical]{style="COLOR: teal"}.Bottom;]{style="FONT-FAMILY: 'Courier New'"}  |
+---------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                         |
|                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                               |
|                                                                                                                                                                          |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PopupControlContainer1.PositionHorizontal = PopupPositionHorizontal.Far]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                          |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PopupControlContainer1.PositionVertical = PopupPositionVertical.Bottom]{style="FONT-FAMILY: 'Courier New'"}  |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Text and Content Alignment

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The contents inside the popup control can be aligned by using the **Direction** and the **HorizontalAlign** properties. Direction allows you to specify the direction in which the text should be displayed inside the popup control and the HorizontalAlign allows you to set how the contents inside the control should be aligned.

**GroupingText** when set, appears on the top of the popup control. While applying Direction property to the control, the grouping text will also change it\'s text flow.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                                     |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------+
| Direction                         | Specifies the direction of the text in the panel. Default value is NotSet. The options included are as follows: |
|                                   |                                                                                                                 |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}NotSet                                                                    |
|                                   |                                                                                                                 |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}LeftToRight                                                               |
|                                   |                                                                                                                 |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}RightToLeft                                                               |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------+
| GroupingText                      | Specifies the head text for the control.                                                                        |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------+
| HorizontalAlign                   | Specifies the alignment for the content. Default value is NotSet. The options included are as follows:          |
|                                   |                                                                                                                 |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}NotSet                                                                    |
|                                   |                                                                                                                 |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Left                                                                      |
|                                   |                                                                                                                 |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Center                                                                    |
|                                   |                                                                                                                 |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Right                                                                     |
|                                   |                                                                                                                 |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Justify                                                                   |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                              |
|                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                    |
|                                                                                                                               |
| [PopupControlContainer1.HorizontalAlign = [HorizontalAlign]{style="COLOR: teal"}.Left;]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                               |
| [PopupControlContainer1.Direction = [ContentDirection]{style="COLOR: teal"}.LeftToRight;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                               |
| [PopupControlContainer1.GroupingText = [\"Header Text\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}         |
+-------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                |
|                                                                                                                                                                                 |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                      |
|                                                                                                                                                                                 |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PopupControlContainer1.HorizontalAlign = HorizontalAlign.Left]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                 |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PopupControlContainer1.Direction = ContentDirection.LeftToRight]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                 |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PopupControlContainer1.GroupingText = [\"Header Text\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Scrollbars

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Scrollbars can be set for the control, to allow scrolling through the contents, when the contents exceeds the height or width of the control. There are options that could be chosen to apply scrollbars as required.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+-------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                           |
+-----------------------------------+-------------------------------------------------------------------------------------------------------+
| ScrollBars                        | Specifies the type of scroll bars to set. Default value is None. The options included are as follows: |
|                                   |                                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}None                                                            |
|                                   |                                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Horizontal                                                      |
|                                   |                                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Vertical                                                        |
|                                   |                                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Both                                                            |
|                                   |                                                                                                       |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Auto                                                            |
+-----------------------------------+-------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                      |
|                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                            |
|                                                                                                                       |
| [PopupControlContainer1.ScrollBars = [ScrollBars]{style="COLOR: teal"}.Vertical;]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                   |
|                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                         |
|                                                                                                                                                                                                    |
| **[Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PopupControlContainer1]{style="FONT-FAMILY: 'Courier New'"}**[.ScrollBars = ScrollBars.Vertical]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::::::

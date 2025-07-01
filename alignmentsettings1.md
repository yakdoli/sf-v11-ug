::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Alignment Settings {#alignment-settings style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Setting the parent control

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The waiting popup can be set to any html element or to the browser window using **PositionParent** property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                                                                      |
+-----------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------+
| PositionParent                    | Specifies whether to position the popup relative to the screen or to the control. Default value is Element. The options included are as follows: |
|                                   |                                                                                                                                                  |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Element                                                                                                    |
|                                   |                                                                                                                                                  |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Screen                                                                                                     |
+-----------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                       |
|                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                             |
|                                                                                                                        |
| [WaitingPopup1.PositionParent = [PopupPositionType]{style="COLOR: teal"}.Element;]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                          |
|                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                |
|                                                                                                                                                           |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ WaitingPopup1.PositionParent = PopupPositionType.Element]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Aligning popup to the parent control

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The position of the popup can be set to one of the pre-defined options, such that the popup element will be aligned to that position with respect to the parent control. Setting **Alignment**, will align the popup control with respect to the browser, when parent is set as **Screen**, and it\'ll be aligned relative to the parent control, when set to **Element**.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+-------------------------------------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                                                         |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------------------------------+
| Alignment                         | Specifies the alignment of the popup relative to the parent control. Default value is TopLeft. The options included are as follows: |
|                                   |                                                                                                                                     |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}TopLeft                                                                                       |
|                                   |                                                                                                                                     |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}TopCenter                                                                                     |
|                                   |                                                                                                                                     |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}TopRight                                                                                      |
|                                   |                                                                                                                                     |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}BottomLeft                                                                                    |
|                                   |                                                                                                                                     |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}BottomCenter                                                                                  |
|                                   |                                                                                                                                     |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}BottomRight                                                                                   |
|                                   |                                                                                                                                     |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}MiddleLeft                                                                                    |
|                                   |                                                                                                                                     |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}MiddleCenter                                                                                  |
|                                   |                                                                                                                                     |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}MiddleRight                                                                                   |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The distance along the X and Y axis from the control can be set using the **OffsetX** and **OffsetY** properties.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ---------- --------------------------------------------------------------------------------------------
  Property   Description
  OffSetX    Specifies the distance from the X axis while aligning,  in pixel. The default value is 0.
  OffSetY    Specifies the distance from the Y axis while aligning,  in pixels. The default value is 0.
  ---------- --------------------------------------------------------------------------------------------
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

The alignment and offset properties can be set through code as given below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                    |
|                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                          |
|                                                                                                                     |
| [WaitingPopup1.OffsetX = 50;]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                     |
| [WaitingPopup1.OffsetY = 20;]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                     |
| [WaitingPopup1.Alignment = [PopupAlignType]{style="COLOR: teal"}.MiddleCentre;]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                       |
|                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                             |
|                                                                                                                                                        |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ WaitingPopup1.OffsetX = 50]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                        |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ WaitingPopup1.OffsetY = 20]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                        |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ WaitingPopup1.Alignment = PopupAlignType.MiddleCentre]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black"} 

Content Alignment

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Text can be set for the control through **GroupingText** property which will appear on top of the control.

The contents inside the control can be aligned by using the **HorizontalAlign** property and the flow direction of the contents can be changed using the **Direction** property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                                 |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| Direction                         | Specifies the text flow direction. Default value is NotSet. The options included are as follows:            |
|                                   |                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}NotSet                                                                |
|                                   |                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}LeftToRight                                                           |
|                                   |                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}RightToLeft                                                           |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| GroupingText                      | Specifies the groupbox text around the popup control\'s content.                                            |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
| HorizontalAlign                   | Specifies the alignment of the popup content. Default value is NotSet. The options included are as follows: |
|                                   |                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Left                                                                  |
|                                   |                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Center                                                                |
|                                   |                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Right                                                                 |
|                                   |                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Justify                                                               |
+-----------------------------------+-------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Programmatically the properties can be set as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                      |
|                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                            |
|                                                                                                                       |
| [WaitingPopup1.Direction = [ContentDirection]{style="COLOR: teal"}.RightToLeft;]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                       |
| [WaitingPopup1.GroupingText = [\"Process Loading\....\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                       |
| [WaitingPopup1.HorizontalAlign = [HorizontalAlign]{style="COLOR: teal"}.Center;]{style="FONT-FAMILY: 'Courier New'"}  |
+-----------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                |
|                                                                                                                                                                                 |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                      |
|                                                                                                                                                                                 |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ WaitingPopup1.Direction = ContentDirection.RightToLeft]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                 |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ WaitingPopup1.GroupingText = [\"Process Loading\....\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                 |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ WaitingPopup1.HorizontalAlign = HorizontalAlign.Center]{style="FONT-FAMILY: 'Courier New'"}                         |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::::::

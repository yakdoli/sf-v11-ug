::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Transition Effects {#transition-effects style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Transition and slide effects can be applied to enhance and provide a rich interface for the groupbar item on expand and collapse.

The transition effects can be set for expand and collapse action of a parent item. These effects can be applied just by setting the **ExpandTransition** and **CollapseTransition** to one of the effects.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                |
+-----------------------------------+--------------------------------------------------------------------------------------------+
| ExpandTransition                  | Specifies the transition effect for expand animation. The options included are as follows: |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}None                                                 |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Fade                                                 |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Dissolve                                             |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Pixelate                                             |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}WipeDown                                             |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}WipeLeft                                             |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}WipeRight                                            |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}WipeUp                                               |
+-----------------------------------+--------------------------------------------------------------------------------------------+
| CollapseTransition                | Specifies the visual effect during item collapse. The options included are as follows:     |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}None                                                 |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Fade                                                 |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Dissolve                                             |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Pixelate                                             |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}WipeDown                                             |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}WipeLeft                                             |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}WipeRight                                            |
|                                   |                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}WipeUp                                               |
+-----------------------------------+--------------------------------------------------------------------------------------------+
:::

*[]{style="COLOR: black; FONT-SIZE: 8pt"}* 

The visual effect can be enhanced for expand and collapse animation by setting the **ExpandType** and **CollapseType** properties respectively.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                                |
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
| ExpandSlideType                   | Specifies the type of slide effect used on expanding an item. The options included are as follows:         |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}None                                                                 |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Exponentialaccelerate                                                |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Exponentialdecelerate                                                |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Quadraticaccelerate                                                  |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Quadraticdecelerate                                                  |
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
| CollapseSlideType                 | Specifies to use the type of slide effect used on collapsing an item. The options included are as follows: |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}None                                                                 |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Exponentialaccelerate                                                |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Exponentialdecelerate                                                |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Quadraticaccelerate                                                  |
|                                   |                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Quadraticdecelerate                                                  |
+-----------------------------------+------------------------------------------------------------------------------------------------------------+
:::

*[]{style="COLOR: black; FONT-SIZE: 8pt"}* 

Duration can be set for the expand and collapse action using the **ExpandDuration** and **CollapseDuration** properties.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------ --------------------------------------------------------------------------------------
  Property           Description
  CollapseDuration   Specifies the duration of collapse animation, in milliseconds. Default value is 100.
  ExpandDuration     Specifies the duration of expand animation, in milliseconds. Default value is 100.
  ------------------ --------------------------------------------------------------------------------------
:::

 

[]{#related-topics}
::::::

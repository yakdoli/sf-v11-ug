::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Rotation Types {#rotation-types style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The Rotator control implements four types of rotation.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+-----------------------------------------------------------------------------+
| Property                          | Description                                                                 |
+-----------------------------------+-----------------------------------------------------------------------------+
| RotationType                      | Specifies the type of rotation to use. The options included are as follows: |
|                                   |                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}ContentScroll                         |
|                                   |                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}SmoothScroll                          |
|                                   |                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}RandomSlide                           |
|                                   |                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}SlideShow                             |
+-----------------------------------+-----------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**ContentScroll**: this is the default RotationType

This type scrolls the slides continuously with the same speed.

[·      ]{style="FONT-FAMILY: Symbol"}**SmoothScroll**: this type of scroll will have a transition of speed from high while starting to slow while ending

We can change the speed of SmoothScroll using the **SmoothScrollSpeed** property.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image72_1.jpg){border="0"}Note: To see the effect of ContentScroll and SmoothScroll rotation types, we must specify the interval speed greater than 0 using ScrollInterval property.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**RandomSlide**: this type will display a single slide randomly every time a page is refreshed

[·      ]{style="FONT-FAMILY: Symbol"}**SlideShow**: the slide shows can also be performed by setting **RotationType** to **SlideShow**

We can set the **HideEffect** and **ShowEffect** property to any style transition types.

[]{#p462} 

[]{#related-topics}
:::::

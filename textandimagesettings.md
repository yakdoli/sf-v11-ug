::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Text and Image Settings {#text-and-image-settings style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Different images can be set for a parent item, enabling to change image during item expand and collapse. These images can be set using the **CollapseImageURL** and **ExpandImageURL** properties in the Designer dialog for the respective parent items.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+----------------------------------------------------------+
|                                   |                                                          |
|                                   |                                                          |
| Property                          | Description                                              |
+-----------------------------------+----------------------------------------------------------+
| CollapseImageURL                  | Specifies path of the image to be used on item collapse. |
+-----------------------------------+----------------------------------------------------------+
| ExpandImageURL                    | Specifies path of the image to be used on item expand.   |
+-----------------------------------+----------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **ImageBaseUrl** allows you to specify the path from where the images have to be obtained. By default it is set to \'images\' folder. This property must be set to display the expand / collapse images.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  -------------- ---------------------------------------------------------------------
  Property       Description
  ImageBaseURL   Specifies the path where the images used in the control are stored.
  -------------- ---------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Image and the text position can be aligned relative to each other by specifying the **TextPosition** property which allows to set how the image and the text has to be displayed. This can be set for the entire control which enables all the items to inherit the values, else can be set for individual items by setting it in the Designer dialog.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black"} 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                                  |
+-----------------------------------+--------------------------------------------------------------------------------------------------------------+
| TextPosition                      | Specifies the orientation of the text and image relative to each other. The options included are as follows: |
|                                   |                                                                                                              |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}TextOverImage                                                          |
|                                   |                                                                                                              |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}ImageOverText                                                          |
|                                   |                                                                                                              |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}ImageLeftTextRight                                                     |
|                                   |                                                                                                              |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}TextLeftImageRight                                                     |
+-----------------------------------+--------------------------------------------------------------------------------------------------------------+
:::

[]{#related-topics}
::::::

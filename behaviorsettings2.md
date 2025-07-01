::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Behavior Settings {#behavior-settings style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Text settings for browser and the control

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Custom text can be displayed on the browser window by setting the text to the **StatusBarText** property.

The **GroupingText** allows you to enter some text like a caption to the callback panel when the text is set to this property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------+
|                                   |                                                                  |
|                                   |                                                                  |
| Property                          | Description                                                      |
+-----------------------------------+------------------------------------------------------------------+
| GroupingText                      | Specifies the groupbox text around the control\'s contents.      |
+-----------------------------------+------------------------------------------------------------------+
| StatusBarText                     | Specifies the text to display on the status bar during callback. |
+-----------------------------------+------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Alignment Settings

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To change the direction in which the data is displayed, the **Direction** property can be set, which displays the entire contents (i.e., along with the GroupingText and ShowLoadingIndicatorOnCallback if set) inside the callback panel in the specified direction.

 

To align only the controls placed inside callback panel, the **Horizontal** property can be set.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------------------------------------------------+
|                                   |                                                                                                                    |
|                                   |                                                                                                                    |
| Property                          | Description                                                                                                        |
+-----------------------------------+--------------------------------------------------------------------------------------------------------------------+
| Direction                         | Specifies direction for the text in the panel. Default value is NotSet. The options included are as follows:       |
|                                   |                                                                                                                    |
|                                   |                                                                                                                    |
|                                   |                                                                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}NotSet                                                                       |
|                                   |                                                                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}LeftToRight                                                                  |
|                                   |                                                                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}RightToLeft                                                                  |
+-----------------------------------+--------------------------------------------------------------------------------------------------------------------+
| HorizontalAlign                   | Specifies whether to align the content horizontally. Default value is NotSet. The options included are as follows: |
|                                   |                                                                                                                    |
|                                   |                                                                                                                    |
|                                   |                                                                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}NotSet                                                                       |
|                                   |                                                                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Left                                                                         |
|                                   |                                                                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Right                                                                        |
|                                   |                                                                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Center                                                                       |
|                                   |                                                                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Justify                                                                      |
+-----------------------------------+--------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

ScrollBar settings

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Scrollbars can be displayed for the control automatically when the contents exceed the height of the callback panel by setting the **Scrollbars** property to one of the options.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
|                                   |                                                                                                                                                                             |
|                                   |                                                                                                                                                                             |
| Property                          | Description                                                                                                                                                                 |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ScrollBars                        | Specifies whether to include scroll bars automatically for the panel when the text exceeds the panel\'s height. Default value is None. The options included are as follows: |
|                                   |                                                                                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}None                                                                                                                                  |
|                                   |                                                                                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Horizontal                                                                                                                            |
|                                   |                                                                                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Vertical                                                                                                                              |
|                                   |                                                                                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Both                                                                                                                                  |
|                                   |                                                                                                                                                                             |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Auto                                                                                                                                  |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

[]{#related-topics}
::::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Color Calculation Logic {#color-calculation-logic style="tab-stops: 0pt"}

 

[·      ]{style="FONT-FAMILY: Symbol"}Based on the ColorWeightValuePath specified in the HMC, the range of values in the bound data source, is determined. Let us say for example, this range is 200 to 1200.

[·      ]{style="FONT-FAMILY: Symbol"}Then the item with the \"200\" value is rendered in the LowestWeightColor color and the item with the \"1200\" value is rendered in the HightestWeightColor color.

[·      ]{style="FONT-FAMILY: Symbol"}The MedianWeight property (which is actually a percentage value ranging from 0 to 100) is then used to determine the color for the items near the median value. By default, this has a value of 50. So, in the example above, items with values closer to 700, will be rendered in the MedianWeightColor color.

[·      ]{style="FONT-FAMILY: Symbol"}The rest of the items will be rendered with colors closer to one of the above 3 defined colors, based on their position in the range.

 

You can easily let your end-users change the \"MedianWeight\" property by binding it to a Slider.

[]{#related-topics}
:::

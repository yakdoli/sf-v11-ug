::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Renko Chart {#renko-chart style="tab-stops: 0pt"}

Renko charting method is thought to have acquired its name from \"renga\", which is the Japanese word for bricks. Renko charts were introduced by Steve Nison. Renko (bricks) are drawn equal in size for a determined amount. A brick is drawn in the direction of the prior move only if the prices move by a minimum amount. If the prices change by the determined amount or more, a new brick is drawn. If the prices change by less than the determined amount (specified by ReversalAmount), the new price is ignored. The default value of the ReversalAmount is 1.

If the new closing price penetrates the previous bricks closing price in the opposite direction a trend reversal highlighted by the change in color of the bricks happens. Use the PriceUpColor to indicate the bullish trend and PriceDownColor to indicate the bearish trend.

Since a Renko chart isolates the underlying trends by filtering out the minor ups and downs, Renko charts are excellent in determining support and resistance levels.                    

Renko charts can be created through two ways:

[·      ]{style="FONT-FAMILY: Symbol"}Builder

[·      ]{style="FONT-FAMILY: Symbol"}ChartModel

 

Chart Details

 

::: {align="center"}
+------------------------------+--------------------------+
| Details                                                 |
+------------------------------+--------------------------+
| Number of Y values per point | 1                        |
+------------------------------+--------------------------+
| Number of Series             | One                      |
+------------------------------+--------------------------+
| Cannot be Combined with      | Pie chart and Bar chart. |
+------------------------------+--------------------------+
:::

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Builder](ms-xhelp:///?Id=1f2fc5b5-2c23-44b5-9daa-408acc061757){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ChartModel](ms-xhelp:///?Id=646536b9-b96c-4e89-9a88-44c7a0047a55){style="TEXT-DECORATION: none"}
::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=569cfbeb-ee66-4900-b752-86e85184f614){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=fe1c5e9f-061d-48da-ba34-4040dec2923f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI WPF](ms-xhelp:///?Id=41e3d586-d922-4a01-8272-679fe4ae7343){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential OLAP Chart for WPF](ms-xhelp:///?Id=4d89e52f-a14a-4da7-a710-b908bfbede08){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=0e27a1d4-bb4f-4a17-82f3-57cc29db3716){.d2h_breadcrumbsNormal}
:::

### OlapChart Elements {#olapchart-elements style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

The OlapChart WPF contains the following elements:

 

1.   ***OlapArea*** -- Represents the ChartArea, which contains the ChartSeries and the ChartAxes.

2.   ***ChartSeries*** -- Representation of points in a series according to the selected chart type.

3.   ***ChartAxes*** -- Rectangular co-ordinate system in which the points are plotted. There are two types of axis available namely, ***PrimaryAxis*** and ***SecondaryAxis***.

4.   ***GridLines*** -- Grid lines are the lines, which help to visualize the series separation or the series value comparison. There are two types of grid lines available in chart namely, Horizontal GridLines and Vertical GridLines.

5.   ***Legend*** -- The Legend displays an entry for each data series added to the Chart control. The Chart Legend is positioned within the Chart control (but outside the ChartArea), by default. However, if the Chart Legend is set to the Floating mode, the Chart Legend can be positioned anywhere inside the Chart control.

6.   ***ChartHeader*** -- **** Displays the title for the OlapChart.****

7.   ***Segments*** -- **** If a series is divided into small portions, then those portions are known as segments. The segments are found in Stacking bar, Stacking100 bar, Pie, Stacking column, and Stacking100 column type of charts.****

8.   ***AdornmentInfo*** -- **** AdornmentInfo contains the information for styling and customizing the chart series and axis.****

9.   ***Expanders*** -- **** The small '+' sign in the *OlapLabelPanel* is known as expander. It is used to drill up/down the multiple levels of data rendered in the OlapChart.****

10.  ***Tooltip*** -- **** The small information pop-up is used to represent the key information about a series or a data point.

 

The following illustrations describe the various parts of an OlapChart:

![](ImagesExt/image37_20.jpg){border="0"}

Figure 18: Simple OlapChart[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}** 

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}** 

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}** 

![](ImagesExt/image37_21.jpg){border="0"}

Figure 19: OlapChart and OlapArea portions[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

![](ImagesExt/image37_22.jpg){border="0"}

Figure 20: Various parts of an OlapChart[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}

***[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}*** 

***[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}*** 

***[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}*** 

***[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}*** 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

![](ImagesExt/image37_23.jpg){border="0"}

Figure 21: Simple Bar OlapChart[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

![](ImagesExt/image37_24.jpg){border="0"}

Figure 22: Primary axis and secondary axis in a Bar type chart

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image37_1.jpg){border="0"}Note: In bar chart, stacking bar, and stacking100 bar charts, the vertical axis (Y-Axis) is the primary axis and the horizontal axis (X-Axis) is the secondary axis.
:::

 

![](ImagesExt/image37_25.jpg){border="0"}

Figure 23: Series in a Line chart[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}** 

***[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}*** 

***[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}*** 

***[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}*** 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

![](ImagesExt/image37_26.jpg){border="0"}

 

Figure 24: Segments in a pie chart[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
[![](ImagesExt/image37_1.jpg){border="0"}]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}Note: Pie chart renders in a single series with many segments.
:::

 

![](ImagesExt/image37_27.jpg){border="0"}

Figure 25: An OlapChart with single level drill down

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}** 

![](ImagesExt/image37_28.jpg){border="0"}

Figure 26: An OlapChart with Chart area header and Series tooltip

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
::::::

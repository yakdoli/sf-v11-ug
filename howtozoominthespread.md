::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=85b223d9-7f74-46b9-9d0a-3b8136e84d55){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=965b97e3-170d-4c8f-887d-1f675cd0bdcf){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
## How to Zoom in the Spreadsheet Control {#how-to-zoom-in-the-spreadsheet-control style="TEXT-ALIGN: justify; tab-stops: 0pt"}

You can access all grid control-related properties by using the **ActiveSpreadsheetGrid** property in the **SpreadsheetControl.GridProperties** class. By using that, you can also change the zoom level of the active spreadsheet grid. The **ZoomScale** property is used to change the zoom level of the grid control. By increasing the **ZoomScale** of the spreadsheet grid, you can see a close-up view of the cells. By decreasing the **ZoomScale**, you can see more cells in the view.

 

The following code shows how to change the zoom scale of the active grid.

**** 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                       |
|                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.spreadsheetControl.GridProperties.ActiveSpreadsheetGrid.ZoomScale = 1.5;]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image20_56.jpg){border="0"}

Figure 51: Zoom In

 

![](ImagesExt/image20_57.jpg){border="0"}

Figure 52: Zoom Out

 

 

[]{#related-topics}
:::

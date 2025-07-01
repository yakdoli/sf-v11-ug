::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=f6e5b97a-d626-4c24-96ef-624b3e2d96b5){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=47d016e5-eb6b-4b30-ad97-e6b380d35644){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
### Through Visual Studio {#through-visual-studio style="tab-stops: 0pt"}

Following are the steps to add the Spreadsheet control to a Silverlight application using VisualStudio.

 

1.   Create a new Silverlight application in Visual Studio.

2.   In Visual Studio Toolbox, click **Syncfusion Silverlight Toolbox** tab.

 

 

![](ImagesExt/image20_12.jpg){border="0"}

Figure 10: ToolBox

 

3.   Drag **SpreadsheetControl** to the Designer area.

4.   Customize the properties of SpreadsheetControl using **Properties** window.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image20_0.jpg){border="0"} Note: To add the SpreadsheetRibbon control to your application, drag SpreadsheetRibbon to the Designer area and set the Spreadsheet contol as DataContext as shown the following code.
:::

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XMAL\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                     |
| [\<[syncfusion]{style="COLOR: #a31515"}:[SpreadsheetRibbon]{style="COLOR: #a31515"}[ DataContext]{style="COLOR: red"}=\"{[Binding]{style="COLOR: #a31515"}[ ElementName]{style="COLOR: red"}=spreadsheetControl1}\"/\>]{style="FONT-FAMILY: 'Courier New'"}[]{style="COLOR: black"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::

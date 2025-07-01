::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=7cb7fd88-2571-4400-97d9-e03497700a02){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=56de71da-0699-46e9-b7ac-82ebc8097411){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
## Enable the On-Demand Calculation in PivotGrid Control {#enable-the-on-demand-calculation-in-pivotgrid-control style="TEXT-ALIGN: justify; LINE-HEIGHT: 115%; tab-stops: 0pt"}

The following code snippet illustrates how to enable the On-Demand calculation and to disable the auto-sizing option in the PivotGrid control for a better performance:

[]{style="COLOR: #c00000"} 

+-------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                              |
|                                                                                                                               |
| [pivotGridControl1.AutoSizeOption = [GridAutoSizeOption]{style="COLOR: #2b91af"}.None;]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                               |
| [pivotGridControl1.PivotEngine.EnableOnDemandCalculations = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                      |
|                                                                                                                                                                       |
| [pivotGridControl1.AutoSizeOption = [GridAutoSizeOption]{style="COLOR: #2b91af"}.None]{style="FONT-FAMILY: 'Courier New'"} **[]{style="FONT-FAMILY: 'Courier New'"}** |
|                                                                                                                                                                       |
| [pivotGridControl1.PivotEngine.EnableOnDemandCalculations = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                          |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::

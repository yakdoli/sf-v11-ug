::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=4a32cbf8-1c41-479c-a46d-08ae8c9ce606){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=b0ba9f3e-6268-435b-8e36-fcb33fde49f1){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
### Drill Position {#drill-position style="tab-stops: 0pt"}

The drill position feature enables the user to drill only the current position of a selected member in the OlapReport. This will exclude the drilled data of the selected member in other positions by using an MDX query.

 

Use Case Scenarios

This feature is useful when the objective of analysis is to view the drilled data only in the current position of the selected member.[]{style="COLOR: #c00000"}

[]{style="COLOR: #c00000"} 

Adding Drill Position to an Application

Adding the drill position feature to an application is described in the following code snippet:

 

+--------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                               |
|                                                                                                                                |
| [dataManager.CurrentReport.DrillType = [DrillType]{style="COLOR: #2b91af"}.DrillPosition;]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

+-------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                              |
|                                                                                                                               |
| [dataManager.CurrentReport.DrillType = [DrillType]{style="COLOR: #2b91af"}.DrillPosition]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::

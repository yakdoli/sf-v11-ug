::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=ba856406-24a8-4486-a3fc-45ab6a5455ec){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=dcca7d0e-e24a-4431-922f-8dac4a628b1d){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
### Disable Drill Up/Down {#disable-drill-updown style="tab-stops: 0pt"}

The Drill Up/Down can be disabled by hiding the expanders in the OlapChart. This can be done by using the following code:

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                     |
|                                                                                                                                                                                      |
| [// Hide Expanders]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                      |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.OlapChart1.OlapDataManager.CurrentReport.ShowExpanders = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                  |
|                                                                                                                                                                                   |
| [\' Hide Expanders]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.OlapChart1.OlapDataManager.CurrentReport.ShowExpanders = [False]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-WEIGHT: normal"} 

 

Table 12: ShowExpandersProperty

::: {align="center"}
  --------------- --------------------------------------- ------------- ----------- ----------------
  Property        Description                             Type          Data type   Reference link
  ShowExpanders   Enables/disables the expander option.   Server side   boolean     \-
  --------------- --------------------------------------- ------------- ----------- ----------------
:::

 

Sample Link

A sample demo is available at the following link:

[]{#_Toolbar}**..\\Syncfusion\\EssentialStudio\\\<VersionNumber\>\\BI\\Web\\OlapChart.Web\\Samples\\3.5\\Appearance\\** **Expanders Visibility Demo**

 

[]{#related-topics}
::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=25def5b4-9f79-4d59-8550-125771080740){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=4a32cbf8-1c41-479c-a46d-08ae8c9ce606){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
## Drill Up/Down {#drill-updown style="tab-stops: 0pt"}

This is the basic feature of the OlapGrid control through which the amount of information can be limited. It allows you to drill down to access the detailed level of data, or drill up to see the summarized data using the expanders present in the grid. The expander here refers to the plus/minus sign present in the grid followed by a member.

       ![Description: C:\\Users\\dwarageshmb\\Desktop\\Doc Images\\OlapGrid Web\\Plus.png](ImagesExt/image46_26.jpg){border="0"}  or ![](ImagesExt/image46_27.png){border="0"} Drill down to view data in detail

       ![Description: Minus](ImagesExt/image46_28.jpg){border="0"}  or ![](ImagesExt/image46_29.png){border="0"} Collapse to view the summarized data

 

Drill up/down can be done in two different ways. They are:

1.   Drill Member

2.   Drill Position

 

This can be selected based on our analysis requirements.

 

**Event Support**

Table 10: DrillUpDownClick Event

::: {align="center"}
+------------------+---------------------------------------------------------------------------------------------------+---------------------+---------------------+
| Event            | Description                                                                                       | Arguments           |  Type               |
|                  |                                                                                                   |                     |                     |
|                  |                                                                                                   |                     |                     |
+------------------+---------------------------------------------------------------------------------------------------+---------------------+---------------------+
| DrillUpDownClick | Handles the Drill-Up/Down event when the **IsAsyncReqData** property of OLAP Grid is set to False | PivotCellDescriptor | DrillUpDownEventArg |
+------------------+---------------------------------------------------------------------------------------------------+---------------------+---------------------+
:::

 

Sample Link

A sample is available in the following locations:

Windows XP:

..\\Syncfusion\\EssentialStudio\\\<VersionNumber\>\\BI\\Web\\OlapGrid.Web\\Samples\\3.5\\Data Relation\\Drill Types Demo

Windows 7/Vista:

C:\\Users\\\<UserName\>\\AppData\\Local\\Syncfusion\\EssentialStudio\\x.x.x.x\\BI\\Web\\OlapGrid.Web\\Samples\\3.5\\Data Relation\\Drill Types Demo

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Drill Member](ms-xhelp:///?Id=4a32cbf8-1c41-479c-a46d-08ae8c9ce606){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Drill Position](ms-xhelp:///?Id=1313fe02-8b2b-43ff-a430-5d0988e69aed){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Disable Drill Up/Down](ms-xhelp:///?Id=b0ba9f3e-6268-435b-8e36-fcb33fde49f1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Drill from All Level](ms-xhelp:///?Id=b4bffe4f-dd9c-492c-a3bb-4db97cb5d508){style="TEXT-DECORATION: none"}
::::

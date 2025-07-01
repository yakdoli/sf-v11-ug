::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=c629bf00-ff1a-4baf-921f-74aec2ebb72d){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=46911898-8f49-4490-bb47-20343ba5c547){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
### Drill from All Level {#drill-from-all-level style="tab-stops: 0pt"}

This feature enables you to display the "All" level type member in the OlapChart. This member behaves as parent to other members in its hierarchy by controlling their visibility through expander.

 

Properties

Table 13: Property Table

::: {align="center"}
  ------------------ ------------------------------------------------------------------------ ------------- ----------- -----------------
  Property           Description                                                              Type          Data Type   Reference links
  ShowLevelTypeAll   Specifies whether members with level type as All has to be displayed.    Server Side   Boolean     NA
  ------------------ ------------------------------------------------------------------------ ------------- ----------- -----------------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Displaying \"All\" Level Type Member

To display the "All" level type member, set the *ShowLevelTypeAll* property to *true*. By default this is set to *false*.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                     |
| [OlapDataManager]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ DataManager = [new]{style="COLOR: blue"} [OlapDataManager]{style="COLOR: #2b91af"}() { ShowLevelTypeAll = [true]{style="COLOR: blue"}};]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                     |
| [OlapDataManager]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ DataManager = [New]{style="COLOR: blue"} [OlapDataManager]{style="COLOR: #2b91af"}() { ShowLevelTypeAll = [True]{style="COLOR: blue"} }]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![Description: C:\\Users\\labuser\\Desktop\\IUE\\AllMember.png](ImagesExt/image48_40.jpg){border="0"}

Figure 37: Member with Level type as All is displayed.

 

Sample Link

 

A demo of this feature is available in the following location:

 

**Windows XP:**

*..\\Syncfusion\\EssentialStudio\\x.x.x.x\\BI\\Web\\OlapChart.Web\\Samples\\3.5\\Defining Reports\\Reports In Code*

 

**Windows 7/Vista:**

*C:\\Users\\\<UserName\>\\AppData\\Local\\Syncfusion\\EssentialStudio\\x.x.x.x\\BI\\Web\\* *OlapChart.Web\\Samples\\3.5\\Defining Reports\\Reports In Code[]{style="COLOR: #c00000"}*

 

[]{#related-topics}
::::

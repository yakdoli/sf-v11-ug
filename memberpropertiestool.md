::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=04deaa32-a4d0-4937-b1f6-d21fb056ef06){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=093e1646-b7bd-43f1-8278-171f38e5319c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
### Member Properties Tooltip {#member-properties-tooltip style="tab-stops: 0pt"}

To display member properties through the header ToolTip, the following property of the OLAP grid should be set to **true**:

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                   |
|                                                                                                                                                                    |
| [// To Display Member Properties in ToolTip]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                     |
|                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.OlapGrid1.ShowMemberPropertiesToolTip = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                |
|                                                                                                                                                                 |
| [\' To Display Member Properties in ToolTip]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                  |
|                                                                                                                                                                 |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.OlapGrid1.ShowMemberPropertiesToolTip = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image46_40.png){border="0"}

 

Figure 29: OLAP Grid Displaying Member Properties through the Header ToolTip

 

Table16: Properties

::: {align="center"}
  ----------------------------- ------------------------------------------------------------------------------------------------------ ------------- ----------------
  Property                      Description                                                                                            Type          Data Type
  MemberProperty                On passing the member name as a string, it renders the control accordingly with the respective data.   Server side   MemberProperty
  ShowMemberPropertiesToolTip   Gets or sets a value to include member properties on the header ToolTip.                               Server side   boolean
  ----------------------------- ------------------------------------------------------------------------------------------------------ ------------- ----------------
:::

 

[]{#related-topics}
::::

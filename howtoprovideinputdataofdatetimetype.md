::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=88708ccb-845d-4aaf-b302-12bd761d5f47){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=192f86f3-c198-4711-9041-a1fe4b927ab5){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=1b226732-e1b8-4c4e-ba8f-146df1770f24){.d2h_breadcrumbsNormal}
:::

## How to provide input data of DateTime type? {#how-to-provide-input-data-of-datetime-type style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

The Start Date and Time can be expressed using an instance of the **DateTime** class. If you want to add days, the **AddDays()** method can be used along with that instance. **AddHours()** and **AddMinutes()** can be used for adding any number of hours and minutes.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                           |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                     |
|                                                                                                                                                                                          |
| [DateTime]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ start = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2006, 11, 1);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| [ChartSeries]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ series = [this]{style="COLOR: blue"}.ChartWebControl1.Model.NewSeries("");]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                          |
| [series.Points.Add(start.AddDays(7), 363);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                          |
| [series.Points.Add(start.AddDays(14), 417);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                       |
|                                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                 |
|                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ start [As]{style="COLOR: blue"} DateTime = [New]{style="COLOR: blue"} DateTime(2006, 11, 1)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| [ChartSeries series = [Me]{style="COLOR: blue"}.ChartWebControl1.Model.NewSeries([""]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                          |
| [series.Points.Add(start.AddDays(7), 363)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                          |
| [series.Points.Add(start.AddDays(14), 417)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p283} 

[]{#related-topics}
::::

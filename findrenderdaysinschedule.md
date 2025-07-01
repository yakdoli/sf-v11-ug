::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=6453461f-35be-4ea8-aeca-5a57a5489ddb){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=78a0c5b7-e376-4493-9a80-a9d77465dc53){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Schedule]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How to](ms-xhelp:///?Id=6453461f-35be-4ea8-aeca-5a57a5489ddb){.d2h_breadcrumbsNormal}
:::

## Find RenderDays in Schedule? {#find-renderdays-in-schedule style="tab-stops: 0pt"}

 

You can make use of the "GetRenderDays" method of Schedule to get the days that are rendered in Schedule. GetRenderDays ( ) method takes the StartDate of Schedule as argument and it returns the array of days (DateTime Collection) rendered in Schedule. Based on the schedule type, rendering of days from Schedule will be different. For example, if schedule view is "Day", it will return  a single day, for "Week" view, it  will return days of the week, and for "Month", it will return days of the month in which Schedule is rendered.

 The below code snippet illustrates this:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                             |
| [      var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ startdate = [new]{style="COLOR: blue"} [DateTime]{style="COLOR: #2b91af"}(2010, 12, 10);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                             |
| [      [var]{style="COLOR: blue"} m_dtRenderDays = [this]{style="COLOR: blue"}.Schedule1.GetRenderDays(startdate);]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                             |
| [      [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} i = 0; i \< m_dtRenderDays.Length; i++)]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                             |
| [      {  ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                             |
| [            Label1.Text += [\"\\n\"]{style="COLOR: #a31515"} + [Convert]{style="COLOR: #2b91af"}.ToString(m_dtRenderDays\[i\]);]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                             |
| [     }]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                             |
| [         [Dim]{style="COLOR: blue"} startdate = [New]{style="COLOR: blue"} DateTime(2010, 12, 10)]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                             |
| [        [Dim]{style="COLOR: blue"} m_dtRenderDays = [Me]{style="COLOR: blue"}.Schedule1.GetRenderDays(startdate)]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                             |
| [        [For]{style="COLOR: blue"} i [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = 0 [To]{style="COLOR: blue"} m_dtRenderDays.Length - 1]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                             |
| [          Label1.Text += Constants.vbLf + Convert.ToString(m_dtRenderDays(i))]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                             |
| [        [Next]{style="COLOR: blue"} i]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::

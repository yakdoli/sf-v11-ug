::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=45e9c155-3501-4a39-a61d-c0ed9dba78c6){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=71be4933-8bcf-4d29-a2e7-5cc4543ae59f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Controls and Components](ms-xhelp:///?Id=f0af2fff-6f00-4ca4-85a6-54e41ac5dc96){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[TimePicker Control](ms-xhelp:///?Id=1a1de4ee-d424-4020-be0c-c7a526b2197a){.d2h_breadcrumbsNormal}
:::

### Concepts and Features of the TimePicker Control {#concepts-and-features-of-the-timepicker-control style="tab-stops: 0pt"}

 

Properties

+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+
| **Name**              | **Type**                                 | **Description**                                                                            |
+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+
| Value                 | DateTime?                                | Gets/sets the value for the time picker.                                                   |
+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+
| MinValue              | DateTime                                 | Gets/sets the minimum time that can be selected in the time picker.                        |
|                       |                                          |                                                                                            |
|                       | Default: Today                           |                                                                                            |
+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+
| MaxValue              | DateTime                                 | Gets/sets the maximum time that can be selected in the time picker.                        |
|                       |                                          |                                                                                            |
|                       | Default: Today                           |                                                                                            |
+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+
| Format                | String                                   | Gets/sets the Format option for the time picker.                                           |
|                       |                                          |                                                                                            |
|                       | Default: DateTimeFormat.ShortTimePattern |                                                                                            |
|                       |                                          |                                                                                            |
|                       |  "h:mm tt"                               |                                                                                            |
+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+
| Enable                | Bool                                     | Gets/sets the bool value indicating whether to enable/disable the time picker.             |
|                       |                                          |                                                                                            |
|                       | Default: true                            |                                                                                            |
+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+
| MinuteInterval        | Int                                      | Defines the interval for minutes.                                                          |
|                       |                                          |                                                                                            |
|                       | Default: 15                              |                                                                                            |
+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+
| SecondInterval        | Int                                      | Defines the interval for seconds.                                                          |
|                       |                                          |                                                                                            |
|                       | Default: 15                              |                                                                                            |
+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+
| AutoFormat            | Enum Skins                               | Gets/sets AutoFormat.                                                                      |
|                       |                                          |                                                                                            |
|                       | Default: Office2007Blue                  |                                                                                            |
+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+
| ClientSideEvents      | Class                                    | Gets/sets the client-side event functions for the TimePicker control.                      |
|                       |                                          |                                                                                            |
|                       |                                          |                                                                                            |
+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+
| HtmlAttributes        | IDictionary\<string,object\>             | Defines the HTML attributes for the TimePicker control.                                    |
+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+
| LiveUpdate            | Boolean                                  | Gets/sets the Boolean value indicating whether to update the value on the mouseover event. |
|                       |                                          |                                                                                            |
|                       | Default: true                            |                                                                                            |
+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+
| OpenOn                | String:                                  | Define the trigger event for loading the time picker.                                      |
|                       |                                          |                                                                                            |
|                       | Default: mouseover                       |                                                                                            |
+-----------------------+------------------------------------------+--------------------------------------------------------------------------------------------+

 

The various features of the TimePicker control are invariably associated with the properties of the control. This section will help you understand the use of these properties in detail, and will help you on how to implement, disable, or customize them in the control.

The features of the TimePicker control are:

1.  Value and format

2.  Minimum value and maximum value

3.  Minute interval and second interval

4.  Live update

5.  Enable and AutoFormat

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Value and Format](ms-xhelp:///?Id=82ef3c0d-36b8-443e-a3a6-c95680933d4f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Minimum and Maximum Value](ms-xhelp:///?Id=dbc08208-b611-4c7d-a642-8a335a087529){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Minute and Seconds Interval](ms-xhelp:///?Id=bbab3b1e-c427-4df5-8e28-14404ef081fd){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Live Update](ms-xhelp:///?Id=a3d619a2-70e5-441d-a799-2fa87cf47c66){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Enable](ms-xhelp:///?Id=974d1e92-e942-4334-b56f-6ec7d72e2c3b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}AutoFormat](ms-xhelp:///?Id=80d0b7fe-b210-4610-9821-599cf7b75a63){style="TEXT-DECORATION: none"}
::::

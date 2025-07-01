::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=f1e8b398-a06f-4f86-bd77-bdae5b5fd2a3){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e7c65c84-3014-407e-8a82-441d705a6217){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential Mobile MVC](ms-xhelp:///?Id=74df42e3-5434-4590-9be6-3ae2f911cbbc){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential Chart]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Concepts and Features](ms-xhelp:///?Id=3ad70cf2-cd29-4b18-a1b2-a2e64b23e565){.d2h_breadcrumbsNormal}
:::

## Chart Data {#chart-data style="tab-stops: 0pt"}

Built-in support for data binding

Essential Chart has built-in support for binding to IEnumerable.

The ChartSeries,data points and the axis labels are the ones that can be databound.

 

Series properties

  -------- ------------------------------------------------------------------------------------------------------------------- ---------------------- ------------------ ------------
  Name     Description                                                                                                         Type of the property   Value it accepts   Dependency
  BindTo   This property allows you to get or set the data source of the series and fields that are used to render the axes.   ChartAdvDataBind       ChartAdvDataBind   NA
  -------- ------------------------------------------------------------------------------------------------------------------- ---------------------- ------------------ ------------

 

ChartAdvDataBind Properties

+-------------+-----------------------------------------------------------------------+----------------------+------------------+------------------------------------------------------------------------------------------------------+
| Name        | Description                                                           | Type of the property | Value it accepts | Dependency                                                                                           |
+-------------+-----------------------------------------------------------------------+----------------------+------------------+------------------------------------------------------------------------------------------------------+
| DataSource  | This property allows you to get or set the data source of the series. | IEnumerable          | IEnumerable      | NA                                                                                                   |
+-------------+-----------------------------------------------------------------------+----------------------+------------------+------------------------------------------------------------------------------------------------------+
| XName       | Allows you to get or set the field name of the X axis.                | String               | Any string value | Depends on DataSource---                                                                             |
|             |                                                                       |                      |                  |                                                                                                      |
|             |                                                                       |                      |                  | DataSource should be set and the field name should be the same as any entry in the IEnumerable list. |
+-------------+-----------------------------------------------------------------------+----------------------+------------------+------------------------------------------------------------------------------------------------------+
| YNames      | Allows you to get or set the field names of the Y axis.               | String\[\]           | Any string array | Depends on DataSource\--\                                                                            |
|             |                                                                       |                      |                  | DataSource should be set and the field name should be the same as any entry in the IEnumerable list. |
+-------------+-----------------------------------------------------------------------+----------------------+------------------+------------------------------------------------------------------------------------------------------+

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Chart Data Binding with IEnumerables](ms-xhelp:///?Id=e7c65c84-3014-407e-8a82-441d705a6217){style="TEXT-DECORATION: none"}
::::

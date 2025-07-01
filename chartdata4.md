::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=5bd3a6a3-9c99-486d-ac97-eac2a5b9f453){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=6d64c50d-e49d-4681-9cb2-4d3215e22f3f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential Chart in HTML 5]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Concepts and Features](ms-xhelp:///?Id=67645206-a62c-4d69-9ad4-52c865a681a5){.d2h_breadcrumbsNormal}
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

[![](button.gif){border="0" align="absMiddle"}Chart Data Binding with IEnumerables](ms-xhelp:///?Id=6d64c50d-e49d-4681-9cb2-4d3215e22f3f){style="TEXT-DECORATION: none"}
::::

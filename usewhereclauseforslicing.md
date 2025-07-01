::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=381852ea-8913-4771-8507-0eb92d259bff){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=cdc6202d-a2ef-4943-aea5-26bc6a4bb4cd){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Common](ms-xhelp:///?Id=51cb28d1-f201-4ea8-9963-a8afa451f64c){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts](ms-xhelp:///?Id=c4af561c-5904-4dc4-8eaf-ec1e14451e92){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[OlapDataManager](ms-xhelp:///?Id=65363287-fc82-49a7-8562-b30b6191f994){.d2h_breadcrumbsNormal}
:::

### UseWhereClauseForSlicing {#usewhereclauseforslicing style="tab-stops: 0pt"}

The UseWhereClauseForSlicing property facilitates the user to decide whether the MDX query parser engine should consider 'Where' or 'Select' clause for slicing data.

Use Case Scenarios

While slicing dimensions with a specific range of measures using 'Select' clause in MDX query, an exception is thrown. This can be resolved by using the 'Where' clause for slicing.

**Example:**[ ]{style="COLOR: #4f6228"}Slicing the Date dimension from months of 2002 to months of 2003 will throw an exception when 'Select' clause is used.[ ]{style="COLOR: #4f6228"}

Properties

Table 6: Property Table

+----------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+-----------------------------------+-----------------------------+
| Property                                           | Description                                                                                                                                                   | Type                                   | Data Type                         | Reference links             |
+----------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+-----------------------------------+-----------------------------+
| UseWhereClauseForSlicing[]{style="COLOR: #c00000"} | Enables the user to decide whether the MDX Query Parser Engine should consider the 'Where' or 'Select' clause for slicing operation[]{style="COLOR: #c00000"} | Server side[ ]{style="COLOR: #c00000"} | Boolean[]{style="COLOR: #c00000"} | []{style="COLOR: #c00000"}  |
|                                                    |                                                                                                                                                               |                                        |                                   |                             |
|                                                    |                                                                                                                                                               |                                        |                                   | \-\-\--                     |
+----------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+-----------------------------------+-----------------------------+

 

Adding UseWhereClauseForSlicing property to an Application:

[[Refer to]{.underline} ]{.MsoHyperlink}[[5.22]{style="FONT-FAMILY: 'Arial','sans-serif'"}](ms-xhelp:///?Id=7567ed2f-2066-44df-a1ca-869cc2fbfce3)

[]{#related-topics}
::::

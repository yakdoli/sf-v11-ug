::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=388944f5-5b2b-429f-8761-af0302bb4fba){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=6fdea626-423a-43ce-8de4-aba6818b4822){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Calculate](ms-xhelp:///?Id=2ea52c7f-a332-43bd-9ca7-2ea0898ff54e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=91222e44-d3ca-4392-8f0f-41bd2ae3dd3f){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Function Reference Section](ms-xhelp:///?Id=64c2cb3d-2548-4fe4-b0d1-0c2249ee26c8){.d2h_breadcrumbsNormal}
:::

### LOGEST {#logest style="tab-stops: 0pt"}

 

This feature enables you to calculate predicted exponential growth using existing data.  This calculates and returns an array of values used for the regression analysis. Logest calculates and returns an array of values that is used in regression analysis.

 

Table 13: Method Table

::: {align="center"}
+-----------+------------------------------------------+--------------------------------+------------+-------------+-----------------+
| Method    | Description                              | Parameters                     | Type       | Return Type | Reference links |
+-----------+------------------------------------------+--------------------------------+------------+-------------+-----------------+
| Logest()  | Calculates Logest for an array of cells. | known_y\'s, known_x\'s, const, | **Method** | String      | N/A             |
|           |                                          |                                |            |             |                 |
|           |                                          | stats                          |            |             |                 |
+===========+==========================================+================================+============+=============+=================+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

The following is the formula to calculate Logest for an array of cells in a column:

\[Syntax\]

 

=LOGEST(known_y\'s, \[known_x\'s\], \[const\], \[stats\])

 

Known_y\'s : A set of y-values you already know in a relationship, where y = b\*m\^x.

 

Known_x\'s : An optional set of x-values that you may already know in a relationship, where y = b\*m\^x.

 

Const  :  A logical value specifying whether to force the constant b to equal 1.

 

Stats  : A logical value specifying whether to return additional regression statistics.

 

\[Code\]

 

**=** Logest(B2:B7,A2:A7,TRUE,FALSE)

 

[]{#related-topics}
:::::

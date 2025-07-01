::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=cb0d01c2-7520-493f-8783-22ab9a90955e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=8b1b1446-273f-41ea-92a9-b7488c21548a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Calculate](ms-xhelp:///?Id=2ea52c7f-a332-43bd-9ca7-2ea0898ff54e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=91222e44-d3ca-4392-8f0f-41bd2ae3dd3f){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Function Reference Section](ms-xhelp:///?Id=64c2cb3d-2548-4fe4-b0d1-0c2249ee26c8){.d2h_breadcrumbsNormal}
:::

### GROWTH {#growth style="tab-stops: 0pt"}

 

This feature enables you to calculate predicted exponential growth using existing data.  This calculates and returns an array of values used for the regression analysis. Growth enables you to perform a regression analysis.

     Table 2: Method Table

::: {align="center"}
  Method     Description                                    Parameters                                                                                                    Type     Return Type   Reference links
  ---------- ---------------------------------------------- ------------------------------------------------------------------------------------------------------------- -------- ------------- -----------------
  Growth()   Calculates the Growth for an array of cells.   [Known y's, Known x's, new_x\'s]{style="FONT-FAMILY: 'Microsoft Sans Serif','sans-serif'; FONT-SIZE: 11pt"}   Method   String        N/A
:::

 

The following is the formula to calculate Growth for an array of cells in a column:

\[Syntax\]

 

[=GROWTH(known_y\'s, \[known_x\'s\], \[new_x\'s\], ]{style="COLOR: #454545"}

[]{style="COLOR: #454545"} 

**[Known_y\'s]{style="COLOR: #454545"}**[: A set of y-values you already know in a relationship, where y = b\*m\^x.]{style="COLOR: #454545"}

[]{style="COLOR: #454545"} 

Known_x\'s: An optional set of x-values that you may already know in the relationship, where y = b\*m\^x.

 

**[New_x\'s:]{style="COLOR: #454545"}**[ New x-values for which you want GROWTH to return corresponding y-values.]{style="COLOR: #454545"}

[]{style="COLOR: #454545"} 

[]{style="COLOR: #454545"} 

\[Code\]

 

**=**Growth(B2:B7,A2:A7,C6:C7)

 

[]{#related-topics}
:::::

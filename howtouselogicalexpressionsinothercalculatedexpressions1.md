::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=8dc5d2a5-e003-4788-bedd-9b725498e415){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=63668c53-a00d-44de-892d-e4ba35b7ae76){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Calculate](ms-xhelp:///?Id=2ea52c7f-a332-43bd-9ca7-2ea0898ff54e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=6a744fdb-392c-403e-ae82-cca67f13dd9d){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[CalcQuick](ms-xhelp:///?Id=d81c6839-82d8-44a5-8794-fd7f2b300828){.d2h_breadcrumbsNormal}
:::

### How To Use Logical Expressions In Other Calculated Expressions? {#how-to-use-logical-expressions-in-other-calculated-expressions style="tab-stops: 0pt"}

 

Logical expressions return a True or False value. If you use a logical expression as part of a calculation, then,

 

[·      ]{style="FONT-FAMILY: Symbol"}A True is replaced with 1.

[·      ]{style="FONT-FAMILY: Symbol"}A False is replaced with 0 as the whole expression is evaluated.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

This allows you to easily write and compute formulas that involve logical conditions.

 

Consider the following expression:

 

(\[Cost\] \< 100) \* 1 + (\[Cost\] \>= 100) \* (\[Cost\] \< 200) \* 3 + (\[Cost\] \>= 200) \* (\[Cost\] \< 300) \* 5 + (\[Cost \> 300) \* 7

 

Depending upon the value of cost, this expression returns 1, 3, 5 or 7. This is an example of using a linear combination of logical expressions that times other values.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image18_1.jpg){border="0"}Note: The logical conditions are mutually exclusive[,]{style="COLOR: red"} but~~[,]{style="COLOR: red"}~~ when taken as a whole, cover all possible values of cost. It has the effect of assigning a unique value depending upon the input value.

 
:::

[]{#related-topics}
:::::

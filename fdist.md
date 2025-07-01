::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=425ec2bd-1e19-4b6b-82e8-7fee5b89ee12){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c9ac28db-33bc-44a8-b7b0-a25ebb23b2f2){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Calculate](ms-xhelp:///?Id=2ea52c7f-a332-43bd-9ca7-2ea0898ff54e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=91222e44-d3ca-4392-8f0f-41bd2ae3dd3f){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Function Reference Section](ms-xhelp:///?Id=64c2cb3d-2548-4fe4-b0d1-0c2249ee26c8){.d2h_breadcrumbsNormal}
:::

### FDIST {#fdist style="tab-stops: 0pt"}

 

Returns the**[ ]{style="COLOR: red"}**F probability distribution.

 

**Syntax**

\
**FDIST(x, degrees_freedom1, degrees_freedom2)**

 

where:

**x** is the value at which to evaluate the function.

**degrees_freedom1** is the numerator degrees of freedom.

**degrees_freedom2**[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}is the denominator degrees of freedom.

 

**Remarks**

 

[·      ]{style="FONT-FAMILY: Symbol"}All arguments must be numeric.

[·      ]{style="FONT-FAMILY: Symbol"}X must be \>= 0.

[·      ]{style="FONT-FAMILY: Symbol"}Both degrees_freedom1 and degrees_freedom2 must be \>= 1 and \< 10\^10.

[·      ]{style="FONT-FAMILY: Symbol"}FDIST is calculated as follows:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

FDIST=P( F\>x )

 

where:

**F** is a random variable that has an F distribution with degrees_freedom1 and degrees_freedom2 degrees of freedom.

[]{#p115} 

[]{#related-topics}
::::

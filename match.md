::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=117b9e91-6249-45a9-ae2e-57c345d4a150){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=217ab8f1-0c19-4b62-9cb6-3561d77142d0){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Calculate](ms-xhelp:///?Id=2ea52c7f-a332-43bd-9ca7-2ea0898ff54e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=91222e44-d3ca-4392-8f0f-41bd2ae3dd3f){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Function Reference Section](ms-xhelp:///?Id=64c2cb3d-2548-4fe4-b0d1-0c2249ee26c8){.d2h_breadcrumbsNormal}
:::

### Match {#match style="tab-stops: 0pt"}

The **Match** function searches for a specified value in an array and returns the relative position of that item.

 

**Syntax:**

**Match( value, array, match_type )**

 

**where,**

[·      ]{style="FONT-FAMILY: Symbol"}this value is the value you want to search in the array.

[·      ]{style="FONT-FAMILY: Symbol"}array is a range of cells that contains the value you want to search.

[·      ]{style="FONT-FAMILY: Symbol"}match_type is the type of match you want to perform.

 

match_type accepts the following values:

 

[·      ]{style="FONT-FAMILY: Symbol"}1 - The Match function will find the largest value that is less than or equal to the specified value. Ensure that the array is sorted in ascending order.

 

[·      ]{style="FONT-FAMILY: Symbol"}0 - The Match function will find the first value that is equal to the specified value. The array can be sorted in any order.

 

[·      ]{style="FONT-FAMILY: Symbol"}- 1 -  The Match function will find the smallest value that is greater than or equal to the specified value. Ensure that the array is sorted in descending order.

 

Note:

[·      ]{style="FONT-FAMILY: Symbol"}The Match function does not distinguish between uppercase and lowercase when searching.

[·      ]{style="FONT-FAMILY: Symbol"}If the Match function does not find a match, it returns #N/A error.

[·      ]{style="FONT-FAMILY: Symbol"}match_type is optional.  The Match Function assumes match_type as 1 when the parametter is omitted.

[·      ]{style="FONT-FAMILY: Symbol"}If the match_type parameter is 0 and a text value, then you can use wildcards in the value parameter.

 

**Where,**

 

       \*    -   matches any sequence of characters

 

       ?    -     matches any single character

 

[]{#related-topics}
::::

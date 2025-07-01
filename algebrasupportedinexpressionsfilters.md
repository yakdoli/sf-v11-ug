::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=73a96147-a358-4bdc-9ebe-4c88dff72728){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=bfb16001-cfb0-4acb-bfb4-64f7d21463fd){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grouping](ms-xhelp:///?Id=37faf36d-c8f0-4c7d-90e1-39deecb620a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c4c7c491-8a85-4ab1-829b-adb3b3ed1a4c){.d2h_breadcrumbsNormal}
:::

## Algebra Supported In Expressions / Filters {#algebra-supported-in-expressions-filters style="tab-stops: 0pt"}

 

Expressions can be any well-formed algebraic combination of the following:

 

[·      ]{style="FONT-FAMILY: Symbol"}Property (column) names enclosed with square brackets (\[ \])

[·      ]{style="FONT-FAMILY: Symbol"}Numerical constants and literals

[·      ]{style="FONT-FAMILY: Symbol"}Algebraic and logical operators

 

The computations are performed as listed below, with level one operations done first.

 

[·      ]{style="FONT-FAMILY: Symbol"}\*, /: multiplication, division

[·      ]{style="FONT-FAMILY: Symbol"}+, -: addition, subtraction

[·      ]{style="FONT-FAMILY: Symbol"}\<, \>, =, \<=, \>=, \<\>: less than, greater than, equal, less than or equal, greater than or equal, not equal

[·      ]{style="FONT-FAMILY: Symbol"}match, like, in, between

[·      ]{style="FONT-FAMILY: Symbol"}or, and, or

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image25_1.jpg){border="0"}Note
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
1\. Alpha constants used with match and like should be enclosed in apostrophes (\').

2\. Logical operators return \"1\", if the logical expression is True and return \"0\", if the logical expression is False.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Given below is some more information on special logical operators:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Match**-Returns 1 if there is any occurrence of the right-hand argument in the left-hand argument.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Example

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

\[CompanyName\] match \'RTR\' returns 0 for any record whose CompanyName field does not contain RTR anywhere in the string.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Like**-Checks if the field starts exactly as specified in the right-hand argument.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Example

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

\[CompanyName\] like \'RTR\' returns 1 for any record whose CompanyName field is exactly \'RTR\'. You can use an asterisk as a wildcard. \[CompanyName\] like \'RTR\*\' returns 1 for any record whose CompanyName field starts with \'RTR\'. \[CompanyName\] like \'\*RTR\' returns 1 for any record whose CompanyName field ends with \'RTR\'.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**In**-Checks if the field value is any of the values listed in the right-hand operand. The collection of items used as the right-hand should be separated by commas and enclosed within braces({ }).

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Example

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

\[code\] in {1,10,21}, returns 1 for any record whose code field contains 1 or 10 or 21. \[CompanyName\] in {RTR,MAS} returns 1 for any record whose CompanyName field is RTR or MAS.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![](ImagesExt/image25_26.jpg){border="0"} Note that spaces that are significant in the list, i.e. {RTR,MAS} is not the same as {RTR, MAS}.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

[·      ]{style="FONT-FAMILY: Symbol"}**Between**-Checks if a date field value between the two values is listed in the right-hand operand.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Example

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

\[date\] between {2/25/2004, 3/2/2004} returns 1 for any record whose date field is greater than or equal to 2/25/2004 and less than 3/2/2004. To represent the current date, use the token TODAY. To represent DateTime.MinValue, leave the first argument empty. To represent **DateTime.MaxValue**, leave the second argument empty.

 

Custom Functions

 

Essential Grouping lets you add custom functions to your code that can then be used in expressions.

 

Following are the limitations on the use of custom functions:

 

[·      ]{style="FONT-FAMILY: Symbol"}You cannot use custom functions in algebraic expressions.

[·      ]{style="FONT-FAMILY: Symbol"}They must be used stand-alone in a simple expression that consists of only the function name and its argument list.

[·      ]{style="FONT-FAMILY: Symbol"}The argument list can be any number of arguments separated by a delimiter.

 

[]{#related-topics}
::::::

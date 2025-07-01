::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=ae3545fe-822a-47ab-a6bb-b0b88da9520a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=9a39ef87-812d-4216-bddd-29b0d71e1e5c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Calculate](ms-xhelp:///?Id=2ea52c7f-a332-43bd-9ca7-2ea0898ff54e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=91222e44-d3ca-4392-8f0f-41bd2ae3dd3f){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Supported Algebra](ms-xhelp:///?Id=ae3545fe-822a-47ab-a6bb-b0b88da9520a){.d2h_breadcrumbsNormal}
:::

### Operators {#operators style="tab-stops: 0pt"}

 

The following is a list of the operators which are supported by Essential Calculate.

 

Unary Arithmetic Operator

[]{style="FONT-SIZE: 9pt"} 

[-         Unary Minus Sign]{style="FONT-SIZE: 9pt"}

[]{style="FONT-SIZE: 9pt"} 

Binary Arithmetic Operators

[]{style="FONT-SIZE: 9pt"} 

[+        Addition]{style="FONT-SIZE: 9pt"}

[-         Subtraction]{style="FONT-SIZE: 9pt"}

[\*         Multiplication]{style="FONT-SIZE: 9pt"}

[/         Division]{style="FONT-SIZE: 9pt"}

[\^        Exponentiation]{style="FONT-SIZE: 9pt"}

 

Binary Literal Operator

[]{style="FONT-SIZE: 9pt"} 

[&        Concatenation]{style="FONT-SIZE: 9pt"}

[]{style="FONT-SIZE: 9pt"} 

Binary Logical Operators

[]{style="FONT-SIZE: 9pt"} 

[\<        Less Than ]{style="FONT-SIZE: 9pt"}

[\>        Greater Than]{style="FONT-SIZE: 9pt"}

[=         Equal To]{style="FONT-SIZE: 9pt"}

[\<=       Less Than Or Equal]{style="FONT-SIZE: 9pt"}

[\>=       Greater Than Or Equal]{style="FONT-SIZE: 9pt"}

[\<\>       Not Equal]{style="FONT-SIZE: 9pt"}

[]{style="FONT-SIZE: 9pt"} 

[All operations are subject to the following hierarchy of operations. The level 1 operations are done first, followed by level 2, and so on. Within the same level, the operations are performed from left to right in the order in which they are encountered during the parsing of the formula.]{style="FONT-SIZE: 9pt"}

[]{style="FONT-SIZE: 9pt"} 

1.   - (Unary Minus)

2.   \*    /

3.   +    -

4.   \<   \>    =    \<=    \>=    \<\>

5.   & (Concatenation)

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

If you want to change the default operators precedence, then use parentheses to explicitly indicate the operation order.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Examples

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   Formulas                Computed Value

2.   = 6 / 2 + 1                     4

3.   = 6 / (2 + 1)                   2

4.   = 2 + 4 / 2                     4

5.   = (2 + 4) / 2                   3

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Logical operations return specific values: True or False. If you need specific numerical values associated with any logical expression, then use the logical expression as the first argument in the Formula Library IF-function, with the second argument being the numerical value of True and the third argument being the numerical value of False. If you use a well-formed logical expression in a larger calculation, True evaluates to numerical 1 and False evaluates to numerical 0 for use in the calculations.

[]{#p49} 

[]{#related-topics}
::::

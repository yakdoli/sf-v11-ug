::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=9a39ef87-812d-4216-bddd-29b0d71e1e5c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=81903d16-11db-44a1-91b7-7d6ebaaf1629){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Calculate](ms-xhelp:///?Id=2ea52c7f-a332-43bd-9ca7-2ea0898ff54e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=91222e44-d3ca-4392-8f0f-41bd2ae3dd3f){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Supported Algebra](ms-xhelp:///?Id=ae3545fe-822a-47ab-a6bb-b0b88da9520a){.d2h_breadcrumbsNormal}
:::

### Equal Sign, the Formula Character {#equal-sign-the-formula-character style="tab-stops: 0pt"}

 

To indicate that a particular string should be treated as a formula, you must start the string with a special character, **CalcEngine.FormulaCharacter**. This property is static (Shared in VB), so you can change the formula character within your code. It\'s default value is the equal sign, (=).

 

In general, in order for Essential Calculate to recognize a string as containing a formula; the string is required to start with the CalcEngine.FormulaCharacter. There is one exception though, if you explicitly call a CalcEngine **Parse** method like **CalcEngine.ParseFormula** or **CalcEngine.ParseAndComputeFormula**, including the formula character as the first character in the passed string, it is optional.

 

[]{#related-topics}
::::

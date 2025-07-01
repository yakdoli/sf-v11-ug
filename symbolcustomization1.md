::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=26b6dc70-7ca4-458b-89bf-66c1a18829ae){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=64cd2996-655d-4435-872a-2398126c0533){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential Chart in HTML 5]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Concepts and Features](ms-xhelp:///?Id=67645206-a62c-4d69-9ad4-52c865a681a5){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Customization](ms-xhelp:///?Id=26b6dc70-7ca4-458b-89bf-66c1a18829ae){.d2h_breadcrumbsNormal}
:::

### Symbol Customization {#symbol-customization style="tab-stops: 0pt"}

 Symbols rendered in the series data points can be customized by using this property

::: {align="center"}
+----------------------+--------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------+
| ChartLegend Property | Description                                                                                                        | Type of Property | Value it accepts   | Dependencies                      |
+----------------------+--------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------+
| Visible              | Gets or sets if the Symbol is visible or not.                                                                      | bool             | True               | NA                                |
|                      |                                                                                                                    |                  |                    |                                   |
|                      |                                                                                                                    |                  | False              |                                   |
+----------------------+--------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------+
| Shape                | Gets or sets the shape of the Symbol.                                                                              | SymbolShape      | SymbolShape.Circle | Visible---                        |
|                      |                                                                                                                    |                  |                    |                                   |
|                      |                                                                                                                    |                  | SymbolShape.Cross  | Only applies if Symbol is visible |
|                      |                                                                                                                    |                  |                    |                                   |
|                      |                                                                                                                    |                  | .                  |                                   |
|                      |                                                                                                                    |                  |                    |                                   |
|                      |                                                                                                                    |                  | .                  |                                   |
|                      |                                                                                                                    |                  |                    |                                   |
|                      |                                                                                                                    |                  | .                  |                                   |
|                      |                                                                                                                    |                  |                    |                                   |
|                      |                                                                                                                    |                  | SymbolShape.Wedge  |                                   |
+----------------------+--------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------+
| Size                 | Gets or sets the size of symbol                                                                                    | Size             | SizeObject         | Visible---                        |
|                      |                                                                                                                    |                  |                    |                                   |
|                      |                                                                                                                    |                  |                    | Only applies if Symbol is visible |
+----------------------+--------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------+
| Style                | Gets or sets the style of the Symbol which include the border, interior, line cap, line join, opacity, and shadow. | Style            | StyleObject        | Visible---                        |
|                      |                                                                                                                    |                  |                    |                                   |
|                      |                                                                                                                    |                  |                    | Only applies if Symbol is visible |
+----------------------+--------------------------------------------------------------------------------------------------------------------+------------------+--------------------+-----------------------------------+
:::

 

Chart with legend can be created through two ways:

[·      ]{style="FONT-FAMILY: Symbol"}Builder

[·      ]{style="FONT-FAMILY: Symbol"}ChartModel

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Using Builder](ms-xhelp:///?Id=a40246bc-e0ee-417a-ba75-482622bee42a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Using ChartModel](ms-xhelp:///?Id=867cb355-b9ea-4f38-b398-262e3afcf1a5){style="TEXT-DECORATION: none"}
:::::

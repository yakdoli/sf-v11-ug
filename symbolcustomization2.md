::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=72dea207-ef3c-4cea-a08f-ec523f8743d7){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f1426935-35f9-4f63-b6a6-58fd5c48bf18){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential Mobile MVC](ms-xhelp:///?Id=74df42e3-5434-4590-9be6-3ae2f911cbbc){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Essential Chart]{.d2h_breadcrumbsContentsOnly} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Concepts and Features](ms-xhelp:///?Id=3ad70cf2-cd29-4b18-a1b2-a2e64b23e565){.d2h_breadcrumbsNormal} [ \> ]{.d2h_breadcrumbsLinkSeparator} [Customization](ms-xhelp:///?Id=72dea207-ef3c-4cea-a08f-ec523f8743d7){.d2h_breadcrumbsNormal}
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

[![](button.gif){border="0" align="absMiddle"}Using Builder](ms-xhelp:///?Id=6386cdad-ef00-4da6-8e2c-789b9559a3b6){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Using ChartModel](ms-xhelp:///?Id=92c8eb4a-aff5-491a-83e1-15406da37291){style="TEXT-DECORATION: none"}
:::::

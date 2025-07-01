::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3fe7ca83-e7af-4fe7-874f-6393146bb2e1){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=7d097cda-153b-4eba-bdde-e0244ce78e99){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Edit]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=172af5c9-ec0f-43e6-8f45-f7e19f885c88){.d2h_breadcrumbsNormal}
:::

## How To Get a Count Of the Number Of Occurrences Of a String In the Edit Control {#how-to-get-a-count-of-the-number-of-occurrences-of-a-string-in-the-edit-control style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

You can get a count of the number of occurrences of a string in the Edit Control using the **Matches** method of the **Regex** class.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                          |
|                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                    |
|                                                                                                                                                                                                                         |
| [Regex]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ r = [new]{style="COLOR: blue"} [Regex]{style="COLOR: teal"}(searchText, [RegexOptions]{style="COLOR: teal"}.IgnoreCase);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                         |
| [MatchCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ma = r.Matches([this]{style="COLOR: blue"}.editControl1.Text);]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                         |
| [return]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ma.Count;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                  |
|                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                |
|                                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ r [As]{style="COLOR: blue"} Regex = [New]{style="COLOR: blue"} Regex(pattern, RegexOptions.IgnoreCase)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ma [As]{style="COLOR: blue"} MatchCollection = r.Matches([Me]{style="COLOR: blue"}.editControl1.Text)]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                     |
| [return]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ma.Count]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p192} 

[]{#related-topics}
::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=4d21b99c-3339-4de6-9bcf-e56c25c44299){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=182d3d69-7810-4e44-bea6-a542f73d3476){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=28ff22ed-2523-4bf9-8f6c-4d94f7bcabcc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[GridControl](ms-xhelp:///?Id=89bf6d1f-a0f2-4d1f-add6-545cce1c52f0){.d2h_breadcrumbsNormal}
:::

### How to save the contents of a Grid in memory rather than a file system to export to another grid {#how-to-save-the-contents-of-a-grid-in-memory-rather-than-a-file-system-to-export-to-another-grid style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

 You can save the contents of a grid in memory rather than writing to a file system. This can be done using the **SaveSoap** or **SaveBinary** method of GridControl. The below code snippet illustrates how this can be done.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                        |
|                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                  |
|                                                                                                                                       |
| [MemoryStream s = [new]{style="COLOR: blue"} MemoryStream();]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                       |
| [gridControl1.Model.SaveSoap(s); [// or gridControl1.Model.SaveBinary(s);]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                       |
| [s.Position = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                       |
| [gridControl1.Model = [GridModel]{style="COLOR: teal"}.LoadSoap(s);]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                       |
| [gridControl2.Model = [GridModel]{style="COLOR: teal"}.LoadSoap(s);]{style="FONT-FAMILY: 'Courier New'"}                              |
+---------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                              |
|                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ s [As]{style="COLOR: blue"} MemoryStream = [New]{style="COLOR: blue"} MemoryStream()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                   |
| [gridControl1.Model.SaveSoap(s) [\' or gridControl1.Model.SaveBinary(s);]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                   |
| [s.Position = 0]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                   |
| [gridControl1.Model = GridModel.LoadSoap(s)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                   |
| [gridControl2.Model = GridModel.LoadSoap(s)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p563} 

 

[]{#related-topics}
::::

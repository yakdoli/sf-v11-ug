::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=67d53637-edad-4baf-a8ca-47a6422d31b2){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=3085d954-d16d-4b86-8aff-7ef43ee06d8a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){.d2h_breadcrumbsNormal}
:::

## SymbolPalette {#symbolpalette style="tab-stops: 0pt"}

[]{#p93}The SymbolPalette control displays node shapes and allows you to drag and drop symbols onto diagrams. It supports grouping and filtering symbols. It allows you to classify items as groups so they can be navigated easily. Also, custom shapes can be added to the SymbolPalette.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Methods for SymbolGroups in SymbolPalette:

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Table 78: Methods Table

+----------------------------+----------------------------------------------------------+-------------+-----------------------------------------------------------------------+--------------------------------------------------------------------------------------------------------+
| Name                       | Parameters                                               | Return Type | Description                                                           | Reference Links                                                                                        |
+----------------------------+----------------------------------------------------------+-------------+-----------------------------------------------------------------------+--------------------------------------------------------------------------------------------------------+
| Add(SymbolPaletteGroup)    | SymbolPaletteGroup                                       | Void        | Adds the SymbolPaletteGroup to the SymbolPalette.                     | [**[Symbol Groups]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=30e03545-af78-4c8c-aadd-9753e3037808) |
|                            |                                                          |             |                                                                       |                                                                                                        |
|                            |                                                          |             |                                                                       |                                                                                                        |
+----------------------------+----------------------------------------------------------+-------------+-----------------------------------------------------------------------+--------------------------------------------------------------------------------------------------------+
| Remove(SymbolPaletteGroup) | SymbolPaletteGroup                                       | Void        | Removes the SymbolPaletteGroup from SymbolPalette.                    | [**[Symbol Groups]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=21b8eb08-0823-4f8b-9761-34ee211ba346) |
|                            |                                                          |             |                                                                       |                                                                                                        |
|                            |                                                          |             |                                                                       |                                                                                                        |
+----------------------------+----------------------------------------------------------+-------------+-----------------------------------------------------------------------+--------------------------------------------------------------------------------------------------------+
| RemoveAt(int)              | Int                                                      | Void        | Removes the SymbolPaletteGroup from SymbolPalette at the given index. | [**[Symbol Groups]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=e790ccb5-2590-411f-96de-a90a2aae9389) |
|                            |                                                          |             |                                                                       |                                                                                                        |
|                            |                                                          |             |                                                                       |                                                                                                        |
+----------------------------+----------------------------------------------------------+-------------+-----------------------------------------------------------------------+--------------------------------------------------------------------------------------------------------+
| Clear()                    | [Null]{style="COLOR: #1f497d"}[]{style="COLOR: #1f497d"} | Void        | Clears all the SymbolPaletteGroups from the SymbolPalette.            | [**[Symbol Groups]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=9eef4133-7da3-4c17-a048-f5288af76744) |
|                            |                                                          |             |                                                                       |                                                                                                        |
|                            |                                                          |             |                                                                       |                                                                                                        |
+----------------------------+----------------------------------------------------------+-------------+-----------------------------------------------------------------------+--------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Methods for SymbolFilters in SymbolPalette:

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Table 79: Methods Table

+-----------------------------+----------------------+-------------+------------------------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Name                        | Parameters           | Return Type | Description                                                            | Reference Links                                                                                                                                                                                             |
+-----------------------------+----------------------+-------------+------------------------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Add(SymbolPaletteFilter)    | SymbolPaletteFilter  | Void        | Adds the SymbolPaletteFilter to the SymbolPalette.                     | [**[Symbol Filters]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=2bfa12de-acd6-4f09-b2fd-181bd8eed66a)                                                                                                     |
|                             |                      |             |                                                                        |                                                                                                                                                                                                             |
|                             |                      |             |                                                                        |                                                                                                                                                                                                             |
+-----------------------------+----------------------+-------------+------------------------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Remove(SymbolPaletteFilter) | SymbolPaletteFilter  | Void        | Removes the SymbolPaletteFilter from SymbolPalette.                    | [**[Symbol Filters]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=e5a26ec4-1d33-4adb-a141-3faae855f892)                                                                                                     |
|                             |                      |             |                                                                        |                                                                                                                                                                                                             |
|                             |                      |             |                                                                        |                                                                                                                                                                                                             |
+-----------------------------+----------------------+-------------+------------------------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| RemoveAt(int)               | Int                  | Void        | Removes the SymbolPaletteFilter from SymbolPalette at the given index. | [**[Symbol Filters]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=7c10b224-a4ea-4fc9-9001-14a1ae81e83b)[[\_Symbol_Groups]{style="COLOR: windowtext"}](ms-xhelp:///?Id=7c10b224-a4ea-4fc9-9001-14a1ae81e83b) |
|                             |                      |             |                                                                        |                                                                                                                                                                                                             |
|                             |                      |             |                                                                        |                                                                                                                                                                                                             |
+-----------------------------+----------------------+-------------+------------------------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Clear()                     | Null                 | Void        | Clears all the SymbolPaletteFilter from the SymbolPalette.             | [**[Symbol Filters]{style="COLOR: windowtext"}**](ms-xhelp:///?Id=74dcb068-628c-4fc3-99f9-3079bf14015b)                                                                                                     |
|                             |                      |             |                                                                        |                                                                                                                                                                                                             |
|                             |                      |             |                                                                        |                                                                                                                                                                                                             |
+-----------------------------+----------------------+-------------+------------------------------------------------------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Enable/Disable SymbolPalette](ms-xhelp:///?Id=3085d954-d16d-4b86-8aff-7ef43ee06d8a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Preview for Symbol Palette Item](ms-xhelp:///?Id=b07c04ea-6e77-46db-8493-9f2f0fe32699){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Symbol Filters](ms-xhelp:///?Id=33949a71-9199-4f98-903c-80fed4e8f37e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Symbol Groups](ms-xhelp:///?Id=ad18bcc8-c661-4ea1-83cc-9b5b349b9e02){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Symbol Designer](ms-xhelp:///?Id=4b8071fc-f6f9-4e36-9f3f-452bf4291f3b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SymbolPalette Item](ms-xhelp:///?Id=378b16e9-6e42-4ccd-b305-6e452b607778){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Customize the SymbolPalette](ms-xhelp:///?Id=56c90dc7-f5c6-44bc-9ca6-edbeeb709630){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SymbolPalette Serialization](ms-xhelp:///?Id=eae13d2b-35cd-48de-a709-b2072a0c747e){style="TEXT-DECORATION: none"}
::::

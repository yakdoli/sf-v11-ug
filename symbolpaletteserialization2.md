::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=56c90dc7-f5c6-44bc-9ca6-edbeeb709630){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=b91cb914-8160-463a-ab4e-d5d234c7f84f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[SymbolPalette](ms-xhelp:///?Id=20dbf28d-6928-4d19-a722-5f6779ab36c2){.d2h_breadcrumbsNormal}
:::

### SymbolPalette Serialization {#symbolpalette-serialization style="tab-stops: 0pt"}

Serialization is the process of saving and retrieving the SymbolPalette groups and items. Essential Diagram WPF supports saving the SymbolPalette as an XAML file. This load and save feature allows you to save the SymbolPalette for future use. You can continue working on their page by loading the appropriate XAML file.

SymbolPaletteSerialization feature provides an option to save and load the SymbolPalette, SymbolPalette groups, elements and items in diagram control. So any item can be customised and imported onto the SymbolPalette.

 

[·     ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 10.5pt"}[User can easily Save/Load the SymbolPalette]{style="COLOR: black"}[]{style="FONT-SIZE: 10.5pt"}

[·     ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 10.5pt"}[User can Save/Load the SymbolPaletteGroup]{style="COLOR: black"}[]{style="FONT-SIZE: 10.5pt"}

[·     ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 10.5pt"}[User can Save/Load the SymbolPaletteItem]{style="COLOR: black"}[]{style="FONT-SIZE: 10.5pt"}

[]{style="FONT-SIZE: 10.5pt"} 

Methods

+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+--------------------+-------------+-----------------+
| Method                 | Description                                                                                                                                     | Parameters         | Return Type | Reference links |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+--------------------+-------------+-----------------+
| SaveSymbolPalette      | Displays the save dialog box to save the entire SymbolPallete(including all SymbolPalette groups) into XAML file.                               | NA                 | Void        | NA              |
|                        |                                                                                                                                                 |                    |             |                 |
|                        |                                                                                                                                                 |                    |             |                 |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+--------------------+-------------+-----------------+
| LoadSymbolPalette      | The existing SymbolPallete groups will be cleared and new groups will be added from selected Xaml file.                                         | NA                 | Void        | NA              |
|                        |                                                                                                                                                 |                    |             |                 |
|                        |                                                                                                                                                 |                    |             |                 |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+--------------------+-------------+-----------------+
| SaveSymbolPaletteGroup | Saves the Symbol Palette Group into Xaml file using the given  SymbolPaletteGroup parameter.                                                    | SymbolPaletteGroup | Void        | NA              |
|                        |                                                                                                                                                 |                    |             |                 |
|                        |                                                                                                                                                 |                    |             |                 |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+--------------------+-------------+-----------------+
| LoadSymbolPaletteGroup | Displays the Load Dialogue Box to load the Symbol Palette Group from the selected Xaml file.                                                    | NA                 | Void        | NA              |
|                        |                                                                                                                                                 |                    |             |                 |
|                        |                                                                                                                                                 |                    |             |                 |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+--------------------+-------------+-----------------+
| SaveSymbolPaletteItem  | Saves the Symbol Palette Item into Xaml file using the given SymbolPaletteItem parameter.                                                       | SymbolPaletteItem  | Void        | NA              |
|                        |                                                                                                                                                 |                    |             |                 |
|                        |                                                                                                                                                 |                    |             |                 |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+--------------------+-------------+-----------------+
| LoadSymbolPaletteItem  | Loads the SymbolPalette Item from the Xaml file. The Items are loaded in any given Symbol Palette Group using the SymbolPaletteGroup parameter. | SymbolPaletteGroup | Void        | NA              |
|                        |                                                                                                                                                 |                    |             |                 |
|                        |                                                                                                                                                 |                    |             |                 |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+--------------------+-------------+-----------------+

 

[]{#related-topics}
::::

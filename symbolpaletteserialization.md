::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=91c7368f-f820-4d5d-9df0-ac4ea30460ce){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=73625037-af42-41e3-b4e8-c4748660d89e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=d592a058-dcc0-44a4-994e-e7901da8db52){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Symbol Palette](ms-xhelp:///?Id=1beb97d8-d59c-47be-ad18-730d53d299b4){.d2h_breadcrumbsNormal}
:::

### SymbolPaletteSerialization {#symbolpaletteserialization style="tab-stops: 0pt"}

Serialization is the process of saving and retrieving the SymbolPalette groups and items. Essential Diagram WPF supports saving the SymbolPalette as a XAML file. This load and save feature allows you to save the SymbolPalette for future use. You can continue working on their page by loading the appropriate XAML file.

SymbolPaletteSerialization feature provides an option to save and load the SymbolPalette, SymbolPalette groups, elements and items in diagram control. So any item can be customised and imported onto the SymbolPalette.

 

[[·     ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 10.5pt"}]{.apple-style-span}[[User can easily Save/Load the SymbolPalette]{style="COLOR: black"}]{.apple-style-span}[[]{style="FONT-SIZE: 10.5pt"}]{.apple-style-span}

[[·     ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 10.5pt"}]{.apple-style-span}[[User can Save/Load the SymbolPaletteGroup]{style="COLOR: black"}]{.apple-style-span}[[]{style="FONT-SIZE: 10.5pt"}]{.apple-style-span}

[[·     ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 10.5pt"}]{.apple-style-span}[[User can Save/Load the SymbolPaletteItem]{style="COLOR: black"}]{.apple-style-span}[[]{style="FONT-SIZE: 10.5pt"}]{.apple-style-span}

 

::: {align="center"}
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
| SaveSymbolPaletteGroup | Saves the Symbol Palette Group into Xaml file using the given  SymbolPaletteGroup parameter                                                     | SymbolPaletteGroup | Void        | NA              |
|                        |                                                                                                                                                 |                    |             |                 |
|                        |                                                                                                                                                 |                    |             |                 |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+--------------------+-------------+-----------------+
| LoadSymbolPaletteGroup | Displays the Load Dialogue Box to load the Symbol Palette Group from the selected Xaml file.                                                    | NA                 | Void        | NA              |
|                        |                                                                                                                                                 |                    |             |                 |
|                        |                                                                                                                                                 |                    |             |                 |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+--------------------+-------------+-----------------+
| SaveSymbolPaletteItem  | Saves the Symbol Palette Item into Xaml file using the given SymbolPaletteItem parameter.                                                       | NA                 | Void        | NA              |
|                        |                                                                                                                                                 |                    |             |                 |
|                        |                                                                                                                                                 |                    |             |                 |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+--------------------+-------------+-----------------+
| LoadSymbolPaletteItem  | Loads the SymbolPalette Item from the Xaml file. The Items are loaded in any given Symbol Palette Group using the SymbolPaletteGroup parameter. | NA                 | Void        | NA              |
|                        |                                                                                                                                                 |                    |             |                 |
|                        |                                                                                                                                                 |                    |             |                 |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------------+--------------------+-------------+-----------------+
:::

 

 

[]{#related-topics}
:::::

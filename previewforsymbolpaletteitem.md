::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=50a488e2-8cc0-4e18-8aa4-aed9a1188736){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e7f5b924-31f9-4cc3-90a3-306989e31487){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=d592a058-dcc0-44a4-994e-e7901da8db52){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Symbol Palette](ms-xhelp:///?Id=1beb97d8-d59c-47be-ad18-730d53d299b4){.d2h_breadcrumbsNormal}
:::

### Preview for Symbol Palette Item {#preview-for-symbol-palette-item style="tab-stops: 0pt"}

Essential Diagram for Silverlight provides preview support for [[Symbol Palette. When you drag an item from Symbol Palette to Diagram View, Preview of the dragged item will be displayed. You can enable or disable the preview support. You can also customize the preview.  ]{style="COLOR: black"}]{.apple-style-span}

 

Use Case Scenario

[[This feature displays a preview of the item you drag from Symbol Palette, thus enables you to identify the item you are dragging from the symbol palette to Diagram view.]{style="COLOR: black"}]{.apple-style-span}[[]{style="COLOR: #4f81bd"}]{.apple-style-span}

 

Properties

[]{style="FONT-SIZE: 11pt"} 

Table 15: Property Table**[]{style="COLOR: #4f81bd"}**

::: {align="center"}
+-------------------------------------------------------------+----------------------------------------------------------------+---------------------------------------------------------+--------------------------------------------------------------+--------------------------------------------------------------------+
| **Property** []{style="LINE-HEIGHT: 115%; FONT-SIZE: 11pt"} | **Description** []{style="LINE-HEIGHT: 115%; FONT-SIZE: 11pt"} | **Type** []{style="LINE-HEIGHT: 115%; FONT-SIZE: 11pt"} | **Data Type** []{style="LINE-HEIGHT: 115%; FONT-SIZE: 11pt"} | **Reference links** []{style="LINE-HEIGHT: 115%; FONT-SIZE: 11pt"} |
+-------------------------------------------------------------+----------------------------------------------------------------+---------------------------------------------------------+--------------------------------------------------------------+--------------------------------------------------------------------+
| ShowPreview                                                 | Gets or sets a value indicating whether preview is enabled.    | Dependency property                                     | Boolean                                                      | NA                                                                 |
|                                                             |                                                                |                                                         |                                                              |                                                                    |
|                                                             | The default value is true.                                     |                                                         |                                                              |                                                                    |
+-------------------------------------------------------------+----------------------------------------------------------------+---------------------------------------------------------+--------------------------------------------------------------+--------------------------------------------------------------------+
|                                                             |                                                                |                                                         |                                                              |                                                                    |
|                                                             |                                                                |                                                         |                                                              |                                                                    |
| PreviewBrush[]{style="FONT-SIZE: 11pt"}                     | Gets or sets a value for preview content.                      | Dependency property                                     | Brush                                                        | NA                                                                 |
+-------------------------------------------------------------+----------------------------------------------------------------+---------------------------------------------------------+--------------------------------------------------------------+--------------------------------------------------------------------+
| PreviewSize                                                 | Gets or sets the size of the preview brush.                    | Dependency property                                     | Size                                                         | NA                                                                 |
|                                                             |                                                                |                                                         |                                                              |                                                                    |
|                                                             |                                                                |                                                         |                                                              |                                                                    |
+-------------------------------------------------------------+----------------------------------------------------------------+---------------------------------------------------------+--------------------------------------------------------------+--------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

Enabling Preview Support

 

To enable preview for the dragged item from Symbol Palette, set the *ShowPreview* property of *SymbolPalette* to true. To disable preview set this to false. By default this is set to true. 

Following code example illustrates how to enable preview support: 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                          |
|                                                                                                                                                                                                           |
| [      DiagramControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ diagramControl1 = [new]{style="COLOR: blue"} [DiagramControl]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                           |
| [diagramControl1.SymbolPalette.ShowPreview = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                              |
| [       ]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramControl1 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} DiagramControl()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                              |
| [      diagramControl1.SymbolPalette.ShowPreview = [true]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[ ]{style="BORDER-BOTTOM: windowtext 1pt; BORDER-LEFT: windowtext 1pt; PADDING-BOTTOM: 0pt; PADDING-LEFT: 0pt; LAYOUT-GRID-MODE: line; PADDING-RIGHT: 0pt; FONT-FAMILY: 'Times New Roman','serif'; BACKGROUND: black; COLOR: black; FONT-SIZE: 1pt; BORDER-TOP: windowtext 1pt; BORDER-RIGHT: windowtext 1pt; PADDING-TOP: 0pt"}![Description: Description: C:\\Users\\jeganr\\Desktop\\New Images\\New Images\\Preview.png](ImagesExt/image62_153.png){border="0"}

Figure 147: Preview for Symbol Palette Item[]{style="BORDER-BOTTOM: windowtext 1pt; BORDER-LEFT: windowtext 1pt; PADDING-BOTTOM: 0pt; PADDING-LEFT: 0pt; LAYOUT-GRID-MODE: line; PADDING-RIGHT: 0pt; FONT-FAMILY: 'Times New Roman','serif'; BACKGROUND: black; COLOR: black; FONT-SIZE: 1pt; BORDER-TOP: windowtext 1pt; BORDER-RIGHT: windowtext 1pt; PADDING-TOP: 0pt"}

[]{style="BORDER-BOTTOM: windowtext 1pt; BORDER-LEFT: windowtext 1pt; PADDING-BOTTOM: 0pt; PADDING-LEFT: 0pt; LAYOUT-GRID-MODE: line; PADDING-RIGHT: 0pt; FONT-FAMILY: 'Times New Roman','serif'; BACKGROUND: black; COLOR: black; FONT-SIZE: 1pt; BORDER-TOP: windowtext 1pt; BORDER-RIGHT: windowtext 1pt; PADDING-TOP: 0pt"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

Change the preview content using PreviewBrush

You can customize the preview content using the *PreviewBrush* property of *SymbolPaletteItem*

Following code example illustrates how to customize preview content:

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                               |
| [       ]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[DiagramControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ diagramControl1 = [new]{style="COLOR: blue"} [DiagramControl]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                               |
| [      (diagramControl1.SymbolPalette.SymbolGroups\[0\].Items\[0\] [as    ]{style="COLOR: blue"}[SymbolPaletteItem]{style="COLOR: #2b91af"}).PreviewBrush = [Brushes]{style="COLOR: #2b91af"}.CornflowerBlue;]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                              |
| [       ]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}[Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramControl1 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} DiagramControl()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                              |
| [      TryCast(diagramControl1.SymbolPalette.SymbolGroups(0).Items(0),  SymbolPaletteItem).PreviewBrush = Brushes.CornflowerBlue]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                     |
|                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                       |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: #e36c0a; FONT-SIZE: 11pt"}** 

[ ]{style="BORDER-BOTTOM: windowtext 1pt; BORDER-LEFT: windowtext 1pt; PADDING-BOTTOM: 0pt; PADDING-LEFT: 0pt; LAYOUT-GRID-MODE: line; PADDING-RIGHT: 0pt; FONT-FAMILY: 'Times New Roman','serif'; BACKGROUND: black; COLOR: black; FONT-SIZE: 1pt; BORDER-TOP: windowtext 1pt; BORDER-RIGHT: windowtext 1pt; PADDING-TOP: 0pt"}![Description: Description: C:\\Users\\jeganr\\Desktop\\New Images\\New Images\\PreviewBrush.png](ImagesExt/image62_154.png){border="0"}

Figure 148: Customized Preview

 

[Changing the size of the PreviewBrush]{.Heading2Char}

**\**
You can customize the size of the preview content using the PreviewSize property of SymbolPaletteItem

The following code illustrates how to customize the size of the preview content:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [\                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[DiagramControl]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: #2b91af"}[[ ]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: black"}]{.apple-converted-space}[diagramControl1 =[ ]{.apple-converted-space}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: black"}[new]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: blue"}[[ ]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: black"}]{.apple-converted-space}[DiagramControl]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: #2b91af"}[();\ |
| ]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: #f0f0f0; COLOR: black"}[\                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| (diagramControl1.SymbolPalette.SymbolGroups\[0\].Items\[0\] [as]{style="COLOR: blue"} [SymbolPaletteItem]{style="COLOR: #2b91af"}).PreviewBrush = [new]{style="COLOR: blue"} [SolidColorBrush]{style="COLOR: #2b91af"}([Colors]{style="COLOR: #2b91af"}.Blue);\                                                                                                                                                                                                                                                                                                                                                                                   |
| \                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| (diagramControl1.SymbolPalette.SymbolGroups\[0\].Items\[0\] [as]{style="COLOR: blue"} [SymbolPaletteItem]{style="COLOR: #2b91af"}).PreviewSize = [new]{style="COLOR: blue"} [Size]{style="COLOR: #2b91af"}(100, 100);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                                                                                                                           |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                                                      |
| [\                                                                                                                                                                                                                                   |
| ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ diagramControl1 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} DiagramControl()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                      |
| [TryCast(diagramControl1.SymbolPalette.SymbolGroups(0).Items(0), SymbolPaletteItem).PreviewBrush = [New]{style="COLOR: blue"} SolidColorBrush(Colors.Blue)]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                      |
| [TryCast(diagramControl1.SymbolPalette.SymbolGroups(0).Items(0), SymbolPaletteItem).PreviewSize = [New]{style="COLOR: blue"} Size(100, 100)]{style="FONT-FAMILY: 'Courier New'"}                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![Description: Description: C:\\Users\\jeganr\\Desktop\\New Images\\New Images\\PreviewBrush.png](ImagesExt/image62_154.png){border="0"}

Figure 149: Customized Preview

**[]{style="COLOR: #e36c0a"}** 

 

**[]{style="COLOR: #e36c0a"}** 

 

[]{#related-topics}
:::::

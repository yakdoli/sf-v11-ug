::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=38fb4152-db5d-4408-8371-6caa1ccc682a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=7c49f7ec-c075-4124-bbe7-e86233755f5f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pdf](ms-xhelp:///?Id=22756092-3da5-4797-9514-dab0617c6902){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=ca78a5c9-c63a-4368-878c-fa18338e0b19){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[PDF Editing](ms-xhelp:///?Id=143c0997-6cd3-4daa-9060-6be730784dc4){.d2h_breadcrumbsNormal}
:::

### How To Add Watermarks Or Stamps In an Existing Document? {#how-to-add-watermarks-or-stamps-in-an-existing-document style="tab-stops: 0pt"}

 

You can add watermarks or stamps in an existing document by adding transparent images or text on the pages. The following code example illustrates this.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                       |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ lDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}(txtUrl.Text);]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                                                                       |
| [PdfFont]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ font = [new]{style="COLOR: blue"} [PdfStandardFont]{style="COLOR: teal"}([PdfFontFamily]{style="COLOR: teal"}.Helvetica, 36f);]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                       |
| [foreach]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([PdfPageBase]{style="COLOR: teal"} lPage [in]{style="COLOR: blue"} lDoc.Pages)]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                                                                       |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                       |
| [PdfGraphics]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ g = lPage.Graphics;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                                       |
| [PdfGraphicsState]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ state = g.Save();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                                                       |
| [g.SetTransparency(0.25f);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                       |
| [g.RotateTransform(-40);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                       |
| [g.DrawString([\"Stamping text\"]{style="COLOR: maroon"}, font, [PdfPens]{style="COLOR: teal"}.Red, [PdfBrushes]{style="COLOR: teal"}.Red, [new]{style="COLOR: blue"} [PointF]{style="COLOR: teal"}(-150, 450));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                       |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                       |
| [lDoc.Save([\"Sample.pdf\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                             |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ lDoc [As]{style="COLOR: blue"} PdfLoadedDocument = [New]{style="COLOR: blue"} PdfLoadedDocument(txtUrl.Text)]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ font [As]{style="COLOR: blue"} PdfFont = [New]{style="COLOR: blue"} PdfStandardFont(PdfFontFamily.Helvetica, 36.0F)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ lPage [As]{style="COLOR: blue"} PdfPageBase]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                                  |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Each]{style="COLOR: blue"} lPage [In]{style="COLOR: blue"} lDoc.Pages]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ g [As]{style="COLOR: blue"} PdfGraphics = lPage.Graphics]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ state [As]{style="COLOR: blue"} PdfGraphicsState = g.Save()]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                                  |
| [      g.SetTransparency(0.25f)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                                  |
| [      g.RotateTransform(-40)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                  |
| [      g.DrawString([\"Stamping text\"]{style="COLOR: maroon"},font,PdfPens.Red,PdfBrushes.Red,[New]{style="COLOR: blue"} PointF(-150,450))]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                                  |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                          |
|                                                                                                                                                                                                                  |
| [lDoc.Save([\"Sample.pdf\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
::::

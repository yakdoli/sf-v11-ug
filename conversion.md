::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=830bfab2-bf77-4845-bc33-4b15be1e5184){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=39b8b7d5-49f4-4f25-99cc-5f73502e23e4){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}
:::

## Conversion {#conversion style="tab-stops: 0pt"}

 

[]{#p87}DocIO provides support to convert a Word document into an image of type Bitmap or EMF. It enables to easily convert a single specified page, group of pages or a whole document into image format.

 

The following overloads of the RenderAsImages method that can be used to convert a Word document into an image.

 

[·      ]{style="FONT-FAMILY: Symbol"}**WordDocument.RenderAsImages(imageType)**-This is used to convert the whole document into an image.

[·      ]{style="FONT-FAMILY: Symbol"}**WordDocument.RenderAsImages(pageIndex, imageFormat)**-This is used to render/convert a particular page of the document into an image; it returns the resultant image of type Stream.

[·      ]{style="FONT-FAMILY: Symbol"}**WordDocument.RenderAsImages(pageIndex, imageType)**-This is used to render/convert a particular page of the document into an image; it returns the resultant image of type Image.

[·      ]{style="FONT-FAMILY: Symbol"}**WordDocument.RenderAsImages(pageIndex, noOfPages, imageType)**-This is used to render/convert multiple number of pages in the document, starting from the specified page index. It returns the resultant image of type Image\[\] array.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                     |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
|                                                                                                                                                                                    |
| [Image]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[\[\] images = document.RenderAsImages(ImageType.Metafile);]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                    |
| [Stream]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ stream = document.RenderAsImages(0, [ImageFormat]{style="COLOR: #2b91af"}.Emf);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                    |
| [Image]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ image = document.RenderAsImages(5, ImageType.Metafile);]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                    |
| [// This converts pages 2,3,4 in the document into images.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                      |
|                                                                                                                                                                                    |
| [Image]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[\[\] images = document.RenderAsImages(1, 3, ImageType.Metafile);]{style="FONT-FAMILY: 'Courier New'"}                  |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                            |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                       |
|                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ images() [As]{style="COLOR: blue"} Image = document.RenderAsImages(ImageType.Metafile)]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ stream [As]{style="COLOR: blue"} Stream = document.RenderAsImages(0, ImageFormat.Emf)]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ image [As]{style="COLOR: blue"} Image = document.RenderAsImages(5, ImageType.Metafile)]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                           |
| [\' This converts pages 2,3,4 in the document into images.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                             |
|                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ images() [As]{style="COLOR: blue"} Image = document.RenderAsImages(1, 3, ImageType.Metafile)]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note:
:::

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN: 9pt 0pt 9pt 18pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
***[·    ]{style="FONT-FAMILY: Symbol"}***Parameter \"pageIndex\" is a zero based index.

***[·    ]{style="FONT-FAMILY: Symbol"}***Layouting of pages in DocIO is not the same as layouting of pages in Word. The total number of pages and layouting of the elements tend to vary.

***[·    ]{style="FONT-FAMILY: Symbol"}***Currently Doc to Image conversion is not supported in Silverlight application.
:::

 

For More Information Refer:

 

[[Doc To RTF]{.UGHyperlink}](ms-xhelp:///?Id=39b8b7d5-49f4-4f25-99cc-5f73502e23e4), [[Doc To HTML]{.UGHyperlink}](ms-xhelp:///?Id=39b8b7d5-49f4-4f25-99cc-5f73502e23e4), [[[[Doc to PDF]{style="COLOR: blue"}]{.underline}](ms-xhelp:///?Id=bfab51b5-a6ff-477f-b687-e232fed1351a)]{.UGHyperlink}

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Doc to RTF](ms-xhelp:///?Id=39b8b7d5-49f4-4f25-99cc-5f73502e23e4){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Doc to HTML](ms-xhelp:///?Id=bfab51b5-a6ff-477f-b687-e232fed1351a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Doc to PDF](ms-xhelp:///?Id=0d329b33-6836-4156-8525-0a27036606c3){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}RTF to Doc](ms-xhelp:///?Id=d319004c-2e35-4a3b-a678-f20ff87d563f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Doc to EPub](ms-xhelp:///?Id=41178bf6-e8e5-4eaf-a650-b7c95f241600){style="TEXT-DECORATION: none"}
::::::

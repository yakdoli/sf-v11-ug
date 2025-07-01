::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Conversion of HTML to PDF using Gecko Rendering Engine {#conversion-of-html-to-pdf-using-gecko-rendering-engine style="tab-stops: 0pt"}

 

The following code snippets explain the conversion of HTML to PDF using the Gecko Rendering Engine.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                    |
| [//Initializing the Gecko Rendering Engine]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                    |
| [GeckoHtmlRendererControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ renderer = [new]{style="COLOR: blue"} [GeckoHtmlRendererControl]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                    |
| [//Initialzing the html converter]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                    |
| [HtmlConverter]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ converter = [new]{style="COLOR: blue"} [HtmlConverter]{style="COLOR: #2b91af"}(renderer);]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                    |
| [//Converting html to pdf]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                    |
| [HtmlToPdfResult]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ result = converter.Convert(txtUrl.Text, [ImageType]{style="COLOR: #2b91af"}.Metafile, width, height, [AspectRatio]{style="COLOR: #2b91af"}.KeepWidth);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                    |
| [//Rendering the image in the PDF document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                    |
| [result.Render(document);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[   ]{style="BACKGROUND: white; COLOR: black"}

Limitations

 

1.   Formatting / styles created using dynamic scripts will not be rendered in the resultant PDF.

2.   Other features in HTML to PDF conversion such as hyperlinks will not be available for conversion using Gecko rendering engine. However, the page breaks are supported but we can't explicitly control the page break.[ ]{style="BACKGROUND: white; COLOR: black"}

[]{#related-topics}
:::

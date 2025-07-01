::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How To Improve Performance? {#how-to-improve-performance style="tab-stops: 0pt"}

 

Performance is the one of the initial requirements of Essential PDF. This section describes performance tips that help using the product in the most appropriate way.

 

**Text and Font**

 

[·      ]{style="FONT-FAMILY: Symbol"}It is good to use PdfStandardFont during text output than Unicode characters. Standard fonts take less space in the file than other fonts.

[·      ]{style="FONT-FAMILY: Symbol"}If PdfTrueType font is used, and it is not expected to use Unicode characters, switching off the Unicode support will reduce the size of the output PDF file. Support of Unicode by PdfTrueTypeFont is specified in the constructor.

[·      ]{style="FONT-FAMILY: Symbol"}Do not enable RightToLeft property of PdfStringFormat, if right-to-left language is not used. Setting this property to true enables a special RTL engine that decreases the text layouting speed.

 

Compression and File Structure

 

Changing these can change the resulting file size, however it can increase the time spent on saving.

 

**Compression** is responsible for compressing internal data streams in PDF. You might be surprised by the number of streams in an ordinary PDF document. High quality compression involves longer file saves, but requires less space.

 

If **CrossReferenceType** property is specified by CrossReferenceStream, the cross-reference is represented by cross-reference stream. It may reduce the file size, especially if compression is turned on, but increases the file generation time.

 

 

[]{#related-topics}
:::

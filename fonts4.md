::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Fonts {#fonts style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**PdfFont** is the base class for all the fonts. The design of the fonts is similar to Microsoft.NET fonts. Fonts are immutable objects, i.e., they cannot be modified, once created.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: There are special constructors that are used to create a new font from a prototype font, but with different settings.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following are the features of the PDF fonts:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}PDF font objects do not have any size; the size is set only during text printing. This provides the advantage of being able to use the same fonts with different sizes.

[·      ]{style="FONT-FAMILY: Symbol"}There are no Underline and Strikeout font styles in PDF. Underline and Strikeout font styles are emulated by drawing a line.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

As mentioned above, all the fonts derived from PdfFonts are immutable. However, there are capabilities for fonts caching. It means, if there are two similar fonts that have different sizes and Underline or Strikeout styles, just one font object will be stored in the PDF file. So, if a lot of similar fonts with different sizes, and Underline or Strikeout styles are created, there is a huge benefit from the fonts caching in terms of speed and memory usage.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: Fonts caching works for all font types that are supported.
:::

 

The following are the classes derived from PdfFont.

 

1\. PdfStandardFont

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

PdfStandardFont represents a font that is recognized by any Adobe Reader. It supports 14 types of fonts.

 

The following are some of the fonts supported by this class.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Times-Roman (Regular, Bold, Italic, Bold Italic)

[·      ]{style="FONT-FAMILY: Symbol"}Helvetica (Regular, Bold, Italic, Bold Italic)

[·      ]{style="FONT-FAMILY: Symbol"}Courier (Regular, Bold, Italic, Bold Italic)

[·      ]{style="FONT-FAMILY: Symbol"}Symbol

[·      ]{style="FONT-FAMILY: Symbol"}ZapfDingbats

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: Fonts that belong to this type do not support Unicode symbols. They take very less memory space, and it is suggested to use these fonts only when ASCII text has to be printed.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

2\. PdfTrueTypeFont

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

PdfTrueTypeFont fonts are created from TrueType fonts. The PdfTrueTypeFont fonts are created either from the System.Drawing.Font class or TTF file (a file containing the information about TrueType font). There are a variety of constructors that can enable to create fonts with different settings. This class is used to embed the specified font in the PDF document.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: There is a unicode parameter in some of the constructors that indicate whether the font should support unicode symbols. The fonts created from a TTF file support unicode symbols, by default. If there is no need to use Unicode symbols, it is suggested to set the unicode parameter to False. Fonts that do not support Unicode takes less memory space in the file.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Right To Left Support

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Unicode TrueType fonts created from the System.Drawing.Font class are used for RTL text output. Also, the languages with symbols substitution (like Arabic) are supported. To enable RTL and characters substitution, set **RightToLeft** property to ***True*** in the **PdfStringFormat** class.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note:

 
:::

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN: 9pt 0pt 9pt 18pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
***[·    ]{style="FONT-FAMILY: Symbol"}***RightToLeft property does not change the text alignment. It just enables the RTL engine and prints the text in RTL order. Use the Alignment property of PdfStringFormat to set the horizontal alignment of the text.

***[·    ]{style="FONT-FAMILY: Symbol"}***Do not enable this feature if RTL support is not needed, because RTL support reduces the text printing speed.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

CJK Fonts

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

There is a set of standard PDF fonts that support Chinese, Japanese and Korean characters. These fonts are supported through the **PdfCjkStandardFont** class. Although creating such fonts is similar to the PdfStandardFont, it requires the following families in addition:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}HanyangSystemsGothicMedium

[·      ]{style="FONT-FAMILY: Symbol"}HanyangSystemsShinMyeongJoMedium

[·      ]{style="FONT-FAMILY: Symbol"}HeiseiKakuGothicW5

[·      ]{style="FONT-FAMILY: Symbol"}HeiseiMinchoW3

[·      ]{style="FONT-FAMILY: Symbol"}MonotypeHeiMedium

[·      ]{style="FONT-FAMILY: Symbol"}MonotypeSungLight

[·      ]{style="FONT-FAMILY: Symbol"}SinoTypeSongLight

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Text Measuring

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **MeasureString** method of the PdfFont class calculates the size of the text, number of lines that fit in the bounds, and number of characters in the text.

 

 

[]{#related-topics}
:::::::::

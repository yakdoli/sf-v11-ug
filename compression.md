::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Compression {#compression style="tab-stops: 0pt"}

 

Compression is the process of reducing the size of data in order to save space or transmission time.

 

For data transmission, compression can be performed on any of the following depending on a number of factors:

 

[·      ]{style="FONT-FAMILY: Symbol"}Just the data content, or

[·      ]{style="FONT-FAMILY: Symbol"}Entire transmission unit.

 

Content compression

 

Content compression involves following:

 

[·      ]{style="FONT-FAMILY: Symbol"}Removing all extra space characters

[·      ]{style="FONT-FAMILY: Symbol"}Inserting a single repeat character to indicate a string of repeated characters

[·      ]{style="FONT-FAMILY: Symbol"}Substituting smaller bit strings for frequently occurring characters

 

Advantages of Content compression

 

[·      ]{style="FONT-FAMILY: Symbol"}Reduces a text file to 50 percent of its original size

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: Compression is performed by a program that uses a formula or algorithm to determine how to compress or decompress data. The algorithm is one of the critical factors to determine the compression quality. This is elaborated below.
:::

 

Controlling the Compression Levels

 

Essential PDF controls the compression level of the document by using the **PdfCompressionLevel** class with the help of the LZW and zlib/deflate compression algorithms. Both LZW and Flate algorithms compress either binary data or ASCII text and always produces the binary data.

 

The following compression levels are supported by Essential PDF:

 

[·      ]{style="FONT-FAMILY: Symbol"}**None**-Packs without compression

[·      ]{style="FONT-FAMILY: Symbol"}**BestSpeed**-Performs high speed compression; reduction of data size is lesser

[·      ]{style="FONT-FAMILY: Symbol"}**BelowNormal**-Performs compression that is rated between Normal and BestSpeed compressions

[·      ]{style="FONT-FAMILY: Symbol"}**Normal**-Performs compression at normal speed; normal reduction of data size

[·      ]{style="FONT-FAMILY: Symbol"}**AboveNormal**-Performs enhanced compression compared to the normal compression; time consumption exceeds the normal compression

[·      ]{style="FONT-FAMILY: Symbol"}**Best**-Performs the best compression; time consuming

 

 

[]{#related-topics}
::::

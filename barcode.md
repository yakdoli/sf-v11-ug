::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Barcode {#barcode style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Bar codes provide a simple and inexpensive method of encoding text information that is easily read by inexpensive electronic readers. A bar code consists of a series of parallel, adjacent bars and spaces. Predefined bar and space patterns or \"symbologies\" are used to encode small strings of character data into a printed symbol.

 

The basic structure of a bar code consists of a leading and trailing quiet zone, a start pattern, one or more data characters, optionally one or two check characters, and a stop pattern. Essential PDF supports 1D / linear barcodes and 2D barcode.

 

1D / Linear Barcodes

 

Following codes are the 1D / linear barcodes. This section also includes details of each code with coding examples.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Code39

[·      ]{style="FONT-FAMILY: Symbol"}Code39Extended

[·      ]{style="FONT-FAMILY: Symbol"}Code11

[·      ]{style="FONT-FAMILY: Symbol"}Codabar

[·      ]{style="FONT-FAMILY: Symbol"}Code32

[·      ]{style="FONT-FAMILY: Symbol"}Code93

[·      ]{style="FONT-FAMILY: Symbol"}Code93Extended

[·      ]{style="FONT-FAMILY: Symbol"}Code128

[·      ]{style="FONT-FAMILY: Symbol"}Code128A

[·      ]{style="FONT-FAMILY: Symbol"}Code128B

[·      ]{style="FONT-FAMILY: Symbol"}Code128C

 

Code39

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The Code 39 character set includes the digits 0-9, the letters A-Z (upper case only), and the following symbols: space, minus (-), plus (+), period (.), dollar sign (\$), slash (/), and percent (%). A special start / stop character is placed at the beginning and end of each barcode. The barcode may be of any length, although more than 25 characters really begin to push the bounds. Code 39 is just about the only type of barcode in common use that does not require a checksum.

 

The following code example illustrates how to draw Code39 Barcode.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                   |
|                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                             |
|                                                                                                                                                                    |
| [// Drawing Code39 barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                      |
|                                                                                                                                                                    |
| [PdfCode39Barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ barcode = new [PdfCode39Barcode]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                               |
|                                                                                                                                                                    |
| [// Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                               |
|                                                                                                                                                                    |
| [barcode.BarHeight = 45;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                    |
| [barcode.Text = \"CODE39\$\";]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                               |
|                                                                                                                                                                    |
| [// Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                             |
|                                                                                                                                                                    |
| [barcode.Draw(page, new PointF(25, 70 ));]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                            |
|                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                          |
|                                                                                                                                                                                                 |
| [\' Drawing Code39 barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                   |
|                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ barcode [As]{style="COLOR: blue"} PdfCode39Barcode = [New]{style="COLOR: blue"} PdfCode39Barcode()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                            |
|                                                                                                                                                                                                 |
| [\' Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                            |
|                                                                                                                                                                                                 |
| [barcode.BarHeight = 45]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                 |
| [barcode.Text = \"CODE39\$\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                            |
|                                                                                                                                                                                                 |
| [\' Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                          |
|                                                                                                                                                                                                 |
| [barcode.Draw(page, [New]{style="COLOR: blue"} PointF(25, 70))]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

ExtendedCode39

 

Code 39 Extended is an extended version of Code 39 that supports the ASCII character set. So with Code 39 Extended, you can also code the 26 lower letters (a-z) and the special characters you have on your keyboard.

 

The following code example illustrates how to draw Code39Extended barcode.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                      |
|                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                |
|                                                                                                                                                                                       |
| [// Drawing Code39Extended barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                 |
|                                                                                                                                                                                       |
| [PdfCode39ExtendedBarcode]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ barcodeExt = new [PdfCode39ExtendedBarcode]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                       |
| [barcodeExt.TextAlignment = PdfBarcodeTextAlignment.Left;]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                       |
| [barcodeExt.Text = \"CODE39Ext\"[;]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                       |
| [//Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                 |
|                                                                                                                                                                                       |
| [barcodeExt.Draw(page, new PointF(25, 200));]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                               |
|                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                                             |
|                                                                                                                                                                                                                    |
| [\' Drawing Code39Extended barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                              |
|                                                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ barcodeExt [As]{style="COLOR: blue"} PdfCode39ExtendedBarcode = [New]{style="COLOR: blue"} PdfCode39ExtendedBarcode()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                    |
| [barcodeExt.TextAlignment = PdfBarcodeTextAlignment.Left]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                    |
| [barcodeExt.Text = \"CODE39Ext\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                    |
| [\'Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                              |
|                                                                                                                                                                                                                    |
| [barcodeExt.Draw(page, [New]{style="COLOR: blue"} PointF(25, 200))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Code 11

 

Code 11 is used primarily for labeling telecommunications equipment. The character set includes the digits 0 to 9, a dash ( - ), and a start / stop code. Each character is encoded with three bars and two spaces. Of these five elements, there may be two wide and three narrow elements, or one wide and four narrow elements. 

 

The following code example illustrates how to draw Code 11 Barcode.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                     |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                               |
|                                                                                                                                                                      |
| [// Drawing Code 11 barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                       |
|                                                                                                                                                                      |
| [PdfCode11Barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ barcode11 = new [PdfCode11Barcode]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                      |
| [barcode11.Text = \"012345678\";]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                      |
| [barcode11.EncodeStartStopSymbols = true;]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                      |
| [ //Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                               |
|                                                                                                                                                                      |
| [barcode11.Draw(page, new PointF(25, 300));]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                              |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                            |
|                                                                                                                                                                                                   |
| [\' Drawing Code 11 barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                    |
|                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ barcode11 [As]{style="COLOR: blue"} PdfCode11Barcode = [New]{style="COLOR: blue"} PdfCode11Barcode()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| [barcode11.Text = \"012345678\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                   |
| [barcode11.EncodeStartStopSymbols = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                   |
| [ [\'Printing barcode on to the Pdf.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                   |
| [barcode11.Draw(page, [New]{style="COLOR: blue"} PointF(25, 300))]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black; FONT-SIZE: 8pt"} 

CodaBar

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

CodaBar is a variable length symbology that performs encoding of the following 20 characters:

            0123456789-\$:/.+ABCD.

 

CodaBar uses the characters, A, B, C and D, only as start and stop characters. Codabar is used in libraries, blood banks, the overnight package delivery industry, and a variety of other information processing applications.

 

The following code example illustrates how to draw Codabar barcode.

[]{style="COLOR: black; FONT-SIZE: 8pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                 |
| [ // Drawing Codabar barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                 |
| [PdfCodabarBarcode]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[codabar = [new]{style="COLOR: blue"}[ ]{style="COLOR: green"}[PdfCodabarBarcode]{style="COLOR: teal"}[();]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                 |
| [codabar.Text = \"0123\";     [      ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                 |
| [//Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                 |
| [codabar.Draw(page, new PointF(25, 400));]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                              |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                            |
|                                                                                                                                                                                                   |
| [ [\' Drawing Codabar barcode]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ codabar [As]{style="COLOR: blue"} PdfCodabarBarcode = [New]{style="COLOR: blue"} PdfCodabarBarcode()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| [codabar.Text = \"0123\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                   |
| [\'Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                             |
|                                                                                                                                                                                                   |
| [codabar.Draw(page, [New]{style="COLOR: blue"} PointF(25, 400))]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Code 32

 

It is mainly used for coding pharmaceuticals, cosmetics and dietetics. Code 32 is mainly used to encode pharmaceutical products in Italy. Code 32 is used to encode Italian Pharmacode, which has the following structure:

 

[·      ]{style="FONT-FAMILY: Symbol"}\'A\' character (ASCII 65), which is not really encoded

[·      ]{style="FONT-FAMILY: Symbol"}8 digits for Pharmacode (It generally begins / is prefixed with 0)

[·      ]{style="FONT-FAMILY: Symbol"}1 digit for Checksum module 10, which is automatically calculated by Barcode Professional

 

The value to be encoded (that is passed to Barcode Professional), must be 8 digits pharmacode (prefix it with \'0\' if necessary), because the 9th digit (the checksum) is automatically calculated by Barcode Professional products.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                         |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                   |
|                                                                                                                                                                                          |
| [PdfCode32Barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ code32 = [new]{style="COLOR: blue"} [PdfCode32Barcode]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [code32.Font = font;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [// Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                                          |
| [code32.BarHeight = 45;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                          |
| [code32.Text = [\"01234567\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                          |
| [code32.TextDisplayLocation = [TextLocation]{style="COLOR: teal"}.Bottom;]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                          |
| [code32.EnableCheckDigit = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                          |
| [code32.ShowCheckDigit = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [//Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                    |
|                                                                                                                                                                                          |
| [code32.Draw(page, [new]{style="COLOR: blue"} [PointF]{style="COLOR: teal"}(25, 500));]{style="FONT-FAMILY: 'Courier New'"}                                                              |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                        |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                      |
|                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ code32 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfCode32Barcode()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                             |
| [code32.Font = font]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                             |
| [\' Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                        |
|                                                                                                                                                                             |
| [code32.BarHeight = 45]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                             |
| [code32.Text = [\"01234567\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                             |
| [code32.TextDisplayLocation = TextLocation.Bottom]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                             |
| [code32.EnableCheckDigit = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                             |
| [code32.ShowCheckDigit = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                         |
|                                                                                                                                                                             |
| [\'Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                       |
|                                                                                                                                                                             |
| [code32.Draw(page, [New]{style="COLOR: blue"} PointF(25, 500))]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Code93

 

Code 93 was designed to complement and improve upon Code 39. It can represent the full ASCII character set by using combinations of 2 characters. Code 93 is a continuous, variable-length symbology and produces denser code.

 

[·      ]{style="FONT-FAMILY: Symbol"}The Standard Mode (default implementation) can encode uppercase letters (A through Z), digits (0 through 9), and special characters like the **\***, **-**, **\$**, **%**, (Space), **.**, **/**, and **+**.

[·      ]{style="FONT-FAMILY: Symbol"}The Full ASCII Mode or Extended Version can encode all 128 ASCII characters.

 

The asterisk (\*) is not a true encodable character, but is the start and stop \'symbol\' for Code 93.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                         |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                       |
|                                                                                                                                                                                          |
| [PdfCode93Barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ code93 = [new]{style="COLOR: blue"} [PdfCode93Barcode]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                          |
| [// Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                                          |
| [code93.BarHeight = 45;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                          |
| [code93.Text = [\"ABC 123456789\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                          |
| [//Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                    |
|                                                                                                                                                                                          |
| [code93.Draw(page, [new]{style="COLOR: blue"} [PointF]{style="COLOR: teal"}(25, 600));]{style="FONT-FAMILY: 'Courier New'"}                                                              |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                        |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                      |
|                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ code93 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfCode93Barcode()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                             |
| [\' Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                        |
|                                                                                                                                                                             |
| [code93.BarHeight = 45]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                             |
| [code93.Text = [\"ABC 123456789\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                             |
| [\'Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                       |
|                                                                                                                                                                             |
| [code93.Draw(page, [New]{style="COLOR: blue"} PointF(25, 600))]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Code93Extended

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                            |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                                      |
|                                                                                                                                                                                                             |
| [PdfCode93ExtendedBarcode]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ code93ext = [new]{style="COLOR: blue"} [PdfCode93ExtendedBarcode]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                             |
| [//Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                         |
|                                                                                                                                                                                                             |
| [code93ext.BarHeight = 45;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                             |
| [code93ext.EncodeStartStopSymbols = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                             |
| [code93ext.Text = [\"(abc) 123456789\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                             |
| [//Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                       |
|                                                                                                                                                                                                             |
| [page = doc.Pages.Add();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                             |
| [code93ext.Draw(page, [new]{style="COLOR: blue"} [PointF]{style="COLOR: teal"}(25, 50));]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                   |
|                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                 |
|                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ code93ext [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfCode93ExtendedBarcode()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                        |
| [\'Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                    |
|                                                                                                                                                                                        |
| [code93ext.BarHeight = 45]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                        |
| [code93ext.EncodeStartStopSymbols = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                        |
| [code93ext.Text = [\"(abc) 123456789\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                                                  |
|                                                                                                                                                                                        |
| [\'Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                  |
|                                                                                                                                                                                        |
| [page = doc.Pages.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                        |
| [code93ext.Draw(page, [New]{style="COLOR: blue"} PointF(25, 50))]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Code128

 

Code 128 is a variable length, high density, alphanumeric, linear bar code symbology, capable of encoding the full 128-character ASCII character set and extended character sets. This Symbology includes a checksum digit for verification, and the barcode may also be verified character-by-character verifying the parity of each data byte.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Code 128 Code Sets

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

[·      ]{style="FONT-FAMILY: Symbol"}Code Set A (or Chars Set A) includes all of the standard upper case U.S. alphanumeric keyboard characters and punctuation characters together with the control characters, (i.e. characters with ASCII values from 0 to 95 inclusive), and seven special characters.

[·      ]{style="FONT-FAMILY: Symbol"}Code Set B (or Chars Set B) includes all of the standard upper case alphanumeric keyboard characters and punctuation characters together with the lower case alphabetic characters (i.e. characters with ASCII values from 32 to 127 inclusive), and seven special characters.

[·      ]{style="FONT-FAMILY: Symbol"}Code Set C (or Chars Set C) includes the set of 100 digit pairs from 00 to 99 inclusive, as well as three special characters. This allows numeric data to be encoded as two data digits per symbol character, at effectively twice the density of standard data.

 

Code 128 Special characters

 

The last seven characters of Code Sets A and B (character values 96 - 102) and the last three characters of Code Set C (character values 100 - 102) are special non-data characters with no ASCII character equivalents, which have particular significance to the bar code reading device.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image22_2.jpg){border="0"}Note: If you specify that the data must be encoded by using Char Set C, then the number of characters after it must be even.
:::

 

Code128A

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                  |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                            |
|                                                                                                                                                                                                   |
| [PdfCode128ABarcode]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ barcode128A = [new]{style="COLOR: blue"} [PdfCode128ABarcode]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| [// Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                                                   |
| [barcode128A.BarHeight = 45;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                   |
| [barcode128A.Text = [\"ABCD 12345\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                   |
| [barcode128A.EnableCheckDigit = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                   |
| [barcode128A.EncodeStartStopSymbols = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                   |
| [barcode128A.ShowCheckDigit = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| [//Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                             |
|                                                                                                                                                                                                   |
| [barcode128A.Draw(page, [new]{style="COLOR: blue"} [PointF]{style="COLOR: teal"}(25, 135));]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                               |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                             |
|                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ barcode128A [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfCode128ABarcode()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                    |
| [\' Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                               |
|                                                                                                                                                                                    |
| [barcode128A.BarHeight = 45]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                    |
| [barcode128A.Text = [\"ABCD 12345\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                    |
| [barcode128A.EnableCheckDigit = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                    |
| [barcode128A.EncodeStartStopSymbols = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                    |
| [barcode128A.ShowCheckDigit = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                |
|                                                                                                                                                                                    |
| [\'Printing barcode on to the Pdf.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                              |
|                                                                                                                                                                                    |
| [barcode128A.Draw(page, [New]{style="COLOR: blue"} PointF(25, 135))]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Code128B

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                  |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                            |
|                                                                                                                                                                                                   |
| [PdfCode128BBarcode]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ barcode128B = [new]{style="COLOR: blue"} [PdfCode128BBarcode]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| [// Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                                                   |
| [barcode128B.BarHeight = 45;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                   |
| [barcode128B.Text = [\"12345 abcd\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                   |
| [barcode128B.EnableCheckDigit = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                   |
| [barcode128B.EncodeStartStopSymbols = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                   |
| [barcode128B.ShowCheckDigit = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                               |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                             |
|                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ barcode128B [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfCode128BBarcode()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                    |
| [\' Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                               |
|                                                                                                                                                                                    |
| [barcode128B.BarHeight = 45]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                    |
| [barcode128B.Text = [\"12345 abcd\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                    |
| [barcode128B.EnableCheckDigit = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                    |
| [barcode128B.EncodeStartStopSymbols = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                    |
| [barcode128B.ShowCheckDigit = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Code128C

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                  |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                            |
|                                                                                                                                                                                                   |
| [PdfCode128CBarcode]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ barcode128C = [new]{style="COLOR: blue"} [PdfCode128CBarcode]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| [// Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                                                   |
| [barcode128C.BarHeight = 45;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                   |
| [barcode128C.Text = [\"001122334455\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                   |
| [barcode128C.EnableCheckDigit = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                   |
| [barcode128C.EncodeStartStopSymbols = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                   |
| [barcode128C.ShowCheckDigit = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                               |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                             |
|                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ barcode128C [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfCode128CBarcode()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                    |
| [\' Setting height of the barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                               |
|                                                                                                                                                                                    |
| [barcode128C.BarHeight = 45]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                    |
| [barcode128C.Text = [\"001122334455\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                    |
| [barcode128C.EnableCheckDigit = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                    |
| [barcode128C.EncodeStartStopSymbols = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                    |
| [barcode128C.ShowCheckDigit = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2D Barcode

 

DataMatrix Barcode

 

DataMatrix barcode is a two dimensional barcode that consists of a grid of dark and light dots or blocks forming square or rectangular symbol. The data encoded in the barcode can either be number or alphanumeric. The **PdfDataMatrixBarcode** class available in Syncfusion.Pdf.Barcode namespace sets the suitable encoding type and size for the input data. However, the size, encoding type and dimension of individual blocks can also be set using the properties.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}By default, the width of the quiet zone on all four sides of the barcode is equal to the dimension of the blocks.

 
:::

Use case scenario

 

The DataMatrix bar codes are widely used in printed media such as labels and letters. It can be read easily by a bar code reader and also by mobile phones.

 

[**[Properties, Methods and Events]{style="COLOR: black"}**]{.apple-style-span}

Properties

Table 1: Properties Table

::: {align="center"}
  Property []{style="FONT-SIZE: 11pt"}    Description []{style="FONT-SIZE: 11pt"}                               Data Type []{style="FONT-SIZE: 11pt"}
  --------------------------------------- --------------------------------------------------------------------- --------------------------------------------------
  Encoding[]{style="FONT-SIZE: 11pt"}     Gets or sets the encoding type.[]{style="FONT-SIZE: 11pt"}            PdfDataMatrixEncoding[]{style="FONT-SIZE: 11pt"}
  Size[]{style="FONT-SIZE: 11pt"}         Gets or sets the size of the symbol.[]{style="FONT-SIZE: 11pt"}       PdfDataMatrixSize[]{style="FONT-SIZE: 11pt"}
  Text[]{style="FONT-SIZE: 11pt"}         Gets or sets the data.[]{style="FONT-SIZE: 11pt"}                     String[]{style="FONT-SIZE: 11pt"}
  XDimension[]{style="FONT-SIZE: 11pt"}   Gets or sets the dimension of the blocks[]{style="FONT-SIZE: 11pt"}   float[]{style="FONT-SIZE: 11pt"}
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

Methods

Table 2:Methods Table

::: {align="center"}
  Method    Description                 Parameters          Return Type
  --------- --------------------------- ------------------- -------------
  Draw      Draws barcode in PdfPage    (PdfPage, PointF)   Void
  ToImage   Converts barcode to Image   None                Image
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

The following code snippet illustrates how to draw a DataMatrix barcode:

**** 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                    |
| [// Create a DataMatrix barcode.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                    |
| [PdfDataMatrixBarcode]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ dataMatrix = [new]{style="COLOR: blue"} [PdfDataMatrixBarcode]{style="COLOR: #2b91af"}([\"Syncfusion\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                    |
| [// Set the dimension.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                    |
| [dataMatrix.XDimension = 3;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                    |
| [// Set the encoding.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                                    |
| [dataMatrix.Encoding = [PdfDataMatrixEncoding]{style="COLOR: #2b91af"}.ASCII;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                    |
| [// Choose the matrix size.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                                    |
| [dataMatrix.Size = [PdfDataMatrixSize]{style="COLOR: #2b91af"}.Size12x12;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                    |
| [// Draw the barcode on PdfPage.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                    |
| [dataMatrix.Draw(page, [PointF]{style="COLOR: #2b91af"}.Empty);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**** 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [\' Create a DataMatrix barcode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dataMatrix [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfDataMatrixBarcode([\"Syncfusion\"]{style="COLOR: darkred"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [\' Set the dimension]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                             |
| [dataMatrix.XDimension = 3]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [\' Set the encoding]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                             |
| [dataMatrix.Encoding = PdfDataMatrixEncoding.ASCII]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [\' Choose the matrix size]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                             |
| [dataMatrix.Size = PdfDataMatrixSize.Size12x12]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [\' Draw the barcode on PdfPage]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                             |
| [dataMatrix.Draw(page, PointF.Empty)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Barcode as Image

 

Barcode that is generated by using Essential PDF is simultaneously converted to an image. The following code example illustrates this.

 

+---------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                            |
|                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                      |
|                                                                                                                                             |
| [Image]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ img = barcode.ToImage();]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                             |
| [img.Save([\"Code38Barcode.png\"]{style="COLOR: #a31515"}, [ImageFormat]{style="COLOR: #2b91af"}.Png);]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                     |
|                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                   |
|                                                                                                                                                          |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ img [As]{style="COLOR: blue"} Image = barcode.ToImage()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                          |
| [img.Save([\"Code38Barcode.png\"]{style="COLOR: maroon"}, ImageFormat.Png)]{style="FONT-FAMILY: 'Courier New'"}                                          |
+----------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Encoding Text {#encoding-text style="tab-stops: 0pt"}

 

Edit Control facilitates saving the contents of a file in any desired encoding and new line style. This can be accomplished by using the below given method.

 

::: {align="center"}
  --------------------- --------------------------------------
  Edit Control Method   Description
  SaveFile              Saves content to the specified file.
  --------------------- --------------------------------------
:::

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.SaveFile([\"EditControl\"]{style="COLOR: maroon"}, [Encoding]{style="COLOR: teal"}.Unicode, Syncfusion.IO.[NewLineStyle]{style="COLOR: teal"}.Mac);]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                            |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                          |
|                                                                                                                                                                                                               |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.SaveFile([\"EditControl\"]{style="COLOR: maroon"}, Encoding.Unicode, Syncfusion.IO.NewLineStyle.Mac)]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Edit Control supports all the encoding styles supported by the **System.Text.Encoding** enumerator. The below given methods can be used to get / set the encoding style for the text in the Edit Control.

 

::: {align="center"}
+-----------------------------------+----------------------------------------------------------+
| Edit Control Method               | Description                                              |
+-----------------------------------+----------------------------------------------------------+
| GetEncoding                       | Gets the current text encoding.                          |
+-----------------------------------+----------------------------------------------------------+
| SetEncoding                       | Sets the current text encoding. The options provided are |
|                                   |                                                          |
|                                   |                                                          |
|                                   |                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}ASCII              |
|                                   |                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}BigEndianUnicode   |
|                                   |                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Default            |
|                                   |                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}UTF32              |
|                                   |                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}UTF7               |
|                                   |                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}UTF8               |
|                                   |                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Unicode            |
+-----------------------------------+----------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                 |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                           |
|                                                                                                                                                                |
| [// Gets the current text encoding.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                         |
|                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.GetEncoding();]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [// Sets the current text encoding.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                         |
|                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.SetEncoding([Encoding]{style="COLOR: teal"}.ASCII);]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                   |
|                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                 |
|                                                                                                                                      |
| [\' Gets the current text encoding.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                               |
|                                                                                                                                      |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.GetEncoding()]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                      |
| [// Sets the current text encoding.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                               |
|                                                                                                                                      |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.SetEncoding(Encoding.ASCII)]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------+

 

It also supports all the new line styles supported by the **Syncfusion.IO.NewLineStyle** enumerator - **Windows**, **Mac**, **Unix** and **Control**.

 

::: {align="center"}
  -------------------------------- -------------
           New Line Styles         Description
  Windows                          \\r\\n
  Mac                              \\r
  Unix                             \\n\\r
  Control                          \\n
  -------------------------------- -------------
:::

 

The **SaveFilewithDataLoss** and **SaveStreamWithDataLoss** events are fired whenever there is a data loss while saving the file by using the specified encoding format. Files or streams can be corrupted if you have some Unicode characters that cannot be saved using the specified encoding format. For example, if you have a file or stream that contains some specific characters of German language, and if you try to save it using ASCII encoding, then data loss will occur. If the save operation is not canceled here, characters will be saved incorrectly.

 

[]{#p59} 

[]{#related-topics}
::::::

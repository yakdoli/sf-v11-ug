::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Merge PDF {#merge-pdf style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Essential PDF supports the merging of multiple PDF documents. It can merge multiple documents from stream as well as the files stored on the disk.

 

The following merging techniques are discussed in this section:

 

[·      ]{style="FONT-FAMILY: Symbol"}Merging Multiple Documents from Disk

[·      ]{style="FONT-FAMILY: Symbol"}Merging Multiple Documents from Stream

[·      ]{style="FONT-FAMILY: Symbol"}Merging Two Files using Append method

[·      ]{style="FONT-FAMILY: Symbol"}Merging pages of different Documents

 

Merging Multiple Documents from Disk

 

The following code example illustrates how to merge multiple documents.

 

+------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                   |
|                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                               |
|                                                                                                                                    |
| [// Create a string array of source files which are to be merged.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}               |
|                                                                                                                                    |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\[\] source = { source1, source2 };]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                    |
| [// Merge PDFDocument.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                          |
|                                                                                                                                    |
| [PdfDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Merge(destination, source);]{style="FONT-FAMILY: 'Courier New'"}   |
+------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                 |
|                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                      |
| [\' Create a string array of source files which are to be merged.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                 |
|                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ source [As]{style="COLOR: blue"} [String]{style="COLOR: blue"}() = { source1, source2 }]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                 |
|                                                                                                                                                                                      |
| [\' Merge PDFDocument.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                            |
|                                                                                                                                                                                      |
| [PdfDocument.Merge(destination, source)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[Merge Multiple Documents from Stream]{style="FONT-SIZE: 9pt"}

[]{style="FONT-SIZE: 9pt"} 

It is also possible to merge multiple PDF documents from stream. The following code example illustrates this.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                   |
|                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                               |
|                                                                                                                                    |
| [Stream]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[\[\] streams = { stream1,stream2}; ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                    |
| [PdfDocumentBase]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Merge(doc, streams);]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                    |
| [doc.Save([\"sample.pdf\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                           |
+------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                         |
|                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ streams As [Stream]{style="COLOR: teal"}() = {stream1, stream2}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                              |
| [PdfDocumentBase]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Merge(doc, streams)]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                              |
| [doc.Save(\"sample.pdf\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Merging two Files using Append method

 

You can also merge two files, by appending one file after another. The following code example illustrates this.

 

+----------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                           |
|                                                                            |
| [                  ]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                            |
| [// Append PDFDocument.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                            |
| [doc1.Append(doc2);]{style="FONT-FAMILY: 'Courier New'"}                   |
+----------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                       |
|                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                            |
| [\' Append PDFDocument.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                            |
| [doc1.Append(doc2)]{style="FONT-FAMILY: 'Courier New'"}                    |
+----------------------------------------------------------------------------+

 

Merging pages of different Documents

 

Yet another way of merging will be, to import all the pages from one document to another. The following code example illustrates this.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                               |
|                                                                                                |
| [                 ]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                |
| [//Import all the pages to another document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                |
| [doc2.ImportPageRange(doc2, 0, doc.Pages.Count);]{style="FONT-FAMILY: 'Courier New'"}          |
+------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                           |
|                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                |
| [\'Import all the pages to another document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                |
| [doc2.ImportPageRange(doc2, 0, doc.Pages.Count)]{style="FONT-FAMILY: 'Courier New'"}           |
+------------------------------------------------------------------------------------------------+

 

 

 

[]{#related-topics}
:::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=140f4dec-03ab-4e17-b119-6f568dc67847){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=95fbf7ca-4e0b-4e3c-bd5b-19e8ee9bf55b){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential XlsIO](ms-xhelp:///?Id=b01a1b50-1d7d-40c0-bc83-af67e57c9005){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=702d1cd4-b827-4e46-83f2-e25d649fc6e6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Advanced](ms-xhelp:///?Id=bc97b4a0-6ec2-4fb4-bdb2-dd1c9dbb3431){.d2h_breadcrumbsNormal}
:::

### How to zip files using the Syncfusion.Compression.Zip namespace? {#how-to-zip-files-using-the-syncfusion.compression.zip-namespace style="tab-stops: 0pt"}

 

You can use the AddFile method of ZipArchive object to compress files by using XlsIO. Following code example illustrates how to use this method.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                           |
|                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                            |
| [Syncfusion.Compression.Zip.[ZipArchive]{style="COLOR: teal"} zipArchive = [new]{style="COLOR: blue"} Syncfusion.Compression.Zip.[ZipArchive]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                            |
| [zipArchive.DefaultCompressionLevel = Syncfusion.Compression.[CompressionLevel]{style="COLOR: teal"}.Best;]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                       |
|                                                                                                                                                                                                            |
| [// Add the file you want to zip.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                       |
|                                                                                                                                                                                                            |
| [zipArchive.AddFile([\"..\\..Form1.cs\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                       |
|                                                                                                                                                                                                            |
| [// Zip file name and location.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                         |
|                                                                                                                                                                                                            |
| [zipArchive.Save([\"SyncfusionCompressFileSample.zip\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                            |
| [zipArchive.Close();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                 |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ zipArchive [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} Syncfusion.Compression.Zip.ZipArchive()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                      |
| [zipArchive.DefaultCompressionLevel = Syncfusion.Compression.CompressionLevel.Best ]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                 |
|                                                                                                                                                                                                      |
| [\' Add the file you want to zip.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                 |
|                                                                                                                                                                                                      |
| [zipArchive.AddFile([\"..\\..Form1.cs\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                 |
|                                                                                                                                                                                                      |
| [\' Zip file name and location.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                   |
|                                                                                                                                                                                                      |
| [zipArchive.Save([\"SyncfusionCompressFileSample.zip\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                      |
| [zipArchive.Close()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

For compressing directories, you can make use of the **AddDirectory** method. The AddDirectory method adds an empty directory file to a ZipArchive. If you want to add all the files inside the directory, then you should manually add these files by using the **AddItem** method.\
\
For example, you can use the following code to add the file from the local drive.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                    |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ fileName = [@\"C:\\Form1.cs\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                    |
| [Syncfusion.Compression.Zip.[ZipArchive]{style="COLOR: teal"} zipArchive = [new]{style="COLOR: blue"} Syncfusion.Compression.Zip.[ZipArchive]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                                                                                                                    |
| [zipArchive.DefaultCompressionLevel = Syncfusion.Compression.[CompressionLevel]{style="COLOR: teal"}.Best;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                    |
| [Stream stream = [new]{style="COLOR: blue"} FileStream(fileName, FileMode.Open, FileAccess.Read);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                    |
| [FileAttributes attributes = File.GetAttributes(fileName);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                    |
| [Syncfusion.Compression.Zip.[ZipArchiveItem]{style="COLOR: teal"} item = [new]{style="COLOR: blue"} Syncfusion.Compression.Zip.[ZipArchiveItem]{style="COLOR: teal"}([\"Form1.cs\"]{style="COLOR: maroon"}, stream, [true]{style="COLOR: blue"}, attributes);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                    |
| [zipArchive.AddItem(item);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                    |
| [zipArchive.Save([@\"c:\\\\SyncfusionCompressFileSample.zip\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                    |
| [zipArchive.Close();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                          |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ fileName [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = [\"C:\\Form1.cs\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ zipArchive [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} Syncfusion.Compression.Zip.ZipArchive()]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                                                                                                          |
| [zipArchive.DefaultCompressionLevel = Syncfusion.Compression.CompressionLevel.Best ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ stream [As]{style="COLOR: blue"} IO.Stream = [New]{style="COLOR: blue"} IO.FileStream(fileName, FileMode.Open, FileAccess.Read)]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ attributes [As]{style="COLOR: blue"} IO.FileAttributes = File.GetAttributes(fileName)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ item [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} Syncfusion.Compression.Zip.ZipArchiveItem([\"Form1.cs\"]{style="COLOR: maroon"}, stream, [True]{style="COLOR: blue"}, attributes)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                          |
| [zipArchive.AddItem(item) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                          |
| [zipArchive.Save([\"c:\\\\SyncfusionCompressFileSample.zip\"]{style="COLOR: maroon"}) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                          |
| [zipArchive.Close()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                 |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=8ef9d2c2-2bd6-4ae1-a447-f56108a8fb77){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=6000407e-84fa-40a2-8fe6-f3c40022a241){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Maps]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=11705b50-1209-46fb-bfde-18237d32998e){.d2h_breadcrumbsNormal}
:::

## Importing and Exporting Map Elements {#importing-and-exporting-map-elements style="tab-stops: 0pt"}

Map Elements---Symbols, Labels, Shapes and Paths can be saved in a XML and Image file. Only the XML file can be imported and if changes are needed it can be done and the Map Elements can be exported.

 

Property

::: {align="center"}
  ------------------------ ----------------------------------------------------------- ------------ ----------- -----------------
  Property                 Description                                                 Type         Data Type   Reference links
  **EnableImageCapture**   Enables to save the portion of the map in an image format   Dependency   Boolean     NA
  ------------------------ ----------------------------------------------------------- ------------ ----------- -----------------
:::

 

Methods

::: {align="center"}
  ---------- ------------------------------------------------------------------------ ----------------- ------------- -----------------
  Methods    Description                                                              Parameters        Return Type   Reference links
  **Save**   Save the Map Elements in a XML and Image format with save file dialog.   NA                NA            NA
  **Save**   Save as per the Parameter Filename                                       String Filename   NA            NA
  **Load**   Loads the Map Elements from a XML file with Open file dialog.            NA                NA            NA
  **Load**   Loads the Map Elements from the given XML file                           String FileName   NA            NA
  ---------- ------------------------------------------------------------------------ ----------------- ------------- -----------------
:::

 

Saving through the Save dialog box

Save the Map Elements in a XML and Image format. When calling the Save method, a save file dialog will be open. In that dialog we can specify the file name and format (Xml / Image) of the map. Then the map will be saved with given file format with the given name. For image file the following formats are supported:

[·      ]{style="FONT-FAMILY: Symbol"}Tiff

[·      ]{style="FONT-FAMILY: Symbol"}Gif

[·      ]{style="FONT-FAMILY: Symbol"}Jpg

[·      ]{style="FONT-FAMILY: Symbol"}Bmp

[·      ]{style="FONT-FAMILY: Symbol"}Png

 

+-------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                |
|                                                                                                                                                 |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.Map.Save();]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------+

 

Save through the File name

Save as per the Parameter Filename. When you call the Save method with the filename as a parameter as shown in the code snippet, the map will be saved in the appropriate file name. Format will be determined based on the extension of the file name. For example if we give file name as "Maps.xml" then the map will be saved as xml file.  If we give the file name as "Maps.tiff" then the map will be saved as tiff image file. For image file the following formats are supported:

[·      ]{style="FONT-FAMILY: Symbol"}Tiff

[·      ]{style="FONT-FAMILY: Symbol"}Gif

[·      ]{style="FONT-FAMILY: Symbol"}Jpg

[·      ]{style="FONT-FAMILY: Symbol"}Bmp

[·      ]{style="FONT-FAMILY: Symbol"}Png

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                             |
|                                                                                                                                                              |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.Map.Save("D:\\Map.xml");]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image29_21.png){border="0"}

Figure 18: Save Dailog Box**[]{style="COLOR: #e36c0a"}**

 

Loading through the Open dialog box

Loads the Map Elements from a XML file. When calling the Load method without any parameter in it, an open file dialog box will be opened. The open dialog shows the list of Xml file which will be available in the current directory. We can choose the Xml file which is saved already by the Map control.

+-------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                |
|                                                                                                                                                 |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.Map.Load();]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------+

 

Loads through the File name

Loads the Map Elements from the given XML file.  For example if the location is given as "D:\\Maps.xml" then the map will be loaded to the given location. Xml file will only be desterilized. Image files cannot be desterilized.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                             |
|                                                                                                                                                              |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.Map.Load("D:\\Map.xml");]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="COLOR: #e36c0a"}** 

**[]{style="COLOR: #e36c0a"}** 

![](ImagesExt/image29_22.png){border="0"}

Figure 19: Load**[]{style="COLOR: #e36c0a"}**

Saving the Portion of Map as Image

To save the portion of the map as an image, set the EnableMouseCapture Property as true for the  Map Control  as shown in the following code snippet and select the portion from the map.

 

+-------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                          |
|                                                                                                                                           |
| [  mapControl.EnableImageCapture = [true]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------+

![](ImagesExt/image29_23.png){border="0"}

Figure 20: Save as Image

 

[]{#related-topics}
::::::

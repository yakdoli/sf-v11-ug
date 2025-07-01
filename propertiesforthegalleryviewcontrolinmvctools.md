::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Properties for the GalleryView Control in MVC Tools {#properties-for-the-galleryview-control-in-mvc-tools style="tab-stops: 0pt"}

 

  -------------- --------------------------------------------------------------------------- ------------- ---------------
  **Property**   **Description**                                                             **Type**      **Data Type**
   ItemHeight    Specifies the height of the images used in the GalleryView control.         Server-side   Unit
  ItemWidth      Specifies the width of the images used in the GalleryView control.          Server-side   Unit
  Height         Specifies the height of the gallery items area.                             Server-side   Unit
  Width          Specifies the width of the GalleryView control.                             Server-side   Unit
  ItemsToShow    Specifies the number of items to be displayed in the GalleryView control.   Server-side   int
  PopupHeight    Specifies the height of the drop-down.                                      Server-side   Unit
  -------------- --------------------------------------------------------------------------- ------------- ---------------

 

**Using Builder**

1.   In the **view**, invoke the **GalleryView** helper with the control ID as an argument.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [  ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [\<%]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[=]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[Html.Syncfusion().GalleryView([\"gallery1\"]{style="COLOR: #a31515"}).Height(Unit.Pixel(100)).Width(Unit.Pixel(100)).ItemHeight(Unit.Pixe(30)).ItemWidth(Unit.Pixel(30)).PopupHeight(Unit.Pixel(100))[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                           |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                |
| [  ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                |
| **[@]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}**[ {]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                |
| [ Html.Syncfusion().GalleryView([\"gallery1\"]{style="COLOR: #a31515"}).Height(Unit.Pixel(100)).Width(Unit.Pixel(100)).ItemHeight(Unit.Pixe(30)).ItemWidth(Unit.Pixel(30)).PopupHeight(Unit.Pixel(100)).Render();}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[]{style="FONT-FAMILY: 'Courier New'"}** |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   Build and run the application.[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}

 

Using Model

1.  In the **view**, invoke the **GalleryView** helper with the control ID as an argument.**[]{style="FONT-SIZE: 9pt"}**

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                        |
| [  ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                        |
| [\<%]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[=]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[Html.Syncfusion().GalleryView([\"gallery1\"]{style="COLOR: #a31515"},([GalleryViewModel]{style="COLOR: #2b91af"})Model)[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                             |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                       |
|                                                                                                                                                                                                           |
| [  ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                     |
|                                                                                                                                                                                                           |
| [@]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[{]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                          |
|                                                                                                                                                                                                           |
| [ Html.Syncfusion().GalleryView([\"gallery1\"]{style="COLOR: #a31515"},([GalleryViewModel]{style="COLOR: #2b91af"})Model[)]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.  Create an instance for the GalleryView control through **GalleryViewModel**.

**[]{style="FONT-FAMILY: 'Times New Roman','serif'"}** 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[Controller]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                |
| [public]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ [ActionResult]{style="COLOR: #2b91af"} ThroughModel( [GalleryViewModel]{style="COLOR: #2b91af"} model)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}               |
|                                                                                                                                                                                                                                                |
| [        {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                |
| [            ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[model.AutoFormat = [Skins]{style="COLOR: #2b91af"}.Almond;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                   |
|                                                                                                                                                                                                                                                |
| [            [GalleryViewItem]{style="COLOR: #2b91af"} item = [new]{style="COLOR: blue"} [GalleryViewItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                        |
|                                                                                                                                                                                                                                                |
| [            item.ImageUrl = Url.Content([\"\~/Content/images/GalleryView/Heading1.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                          |
|                                                                                                                                                                                                                                                |
| [            [GalleryViewItem]{style="COLOR: #2b91af"} item2 = [new]{style="COLOR: blue"} [GalleryViewItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                       |
|                                                                                                                                                                                                                                                |
| [            item2.ImageUrl = Url.Content([\"\~/Content/images/GalleryView/Heading2.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                         |
|                                                                                                                                                                                                                                                |
| [            [GalleryViewItem]{style="COLOR: #2b91af"} item3 = [new]{style="COLOR: blue"} [GalleryViewItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                       |
|                                                                                                                                                                                                                                                |
| [            item3.ImageUrl = Url.Content( [\"\~/Content/images/GalleryView/Heading3.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                        |
|                                                                                                                                                                                                                                                |
| [            [GalleryViewItem]{style="COLOR: #2b91af"} item4 = [new]{style="COLOR: blue"} [GalleryViewItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                       |
|                                                                                                                                                                                                                                                |
| [            item4.ImageUrl = Url.Content( [\"\~/Content/images/GalleryView/Intense.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                         |
|                                                                                                                                                                                                                                                |
| [            [GalleryViewItem]{style="COLOR: #2b91af"} item5 = [new]{style="COLOR: blue"} [GalleryViewItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                       |
|                                                                                                                                                                                                                                                |
| [           ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                |
| [          ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                |
| [            item5.ImageUrl = Url.Content( [\"\~/Content/images/GalleryView/Heading1.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                        |
|                                                                                                                                                                                                                                                |
| [            [GalleryViewItem]{style="COLOR: #2b91af"} item6 = [new]{style="COLOR: blue"} [GalleryViewItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                       |
|                                                                                                                                                                                                                                                |
| [            item6.ImageUrl =  Url.Content( [\"\~/Content/images/GalleryView/Heading2.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                       |
|                                                                                                                                                                                                                                                |
| [            [GalleryViewItem]{style="COLOR: #2b91af"} item7 = [new]{style="COLOR: blue"} [GalleryViewItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                       |
|                                                                                                                                                                                                                                                |
| [            item7.ImageUrl =  Url.Content( [\"\~/Content/images/GalleryView/Heading3.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                       |
|                                                                                                                                                                                                                                                |
| [            [GalleryViewItem]{style="COLOR: #2b91af"} item8 = [new]{style="COLOR: blue"} [GalleryViewItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                       |
|                                                                                                                                                                                                                                                |
| [            item8.ImageUrl = Url.Content( [\"\~/Content/images/GalleryView/Intense.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                         |
|                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                |
| [            [GalleryViewExtraItem]{style="COLOR: #2b91af"} extraitem = [new]{style="COLOR: blue"} [GalleryViewExtraItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                         |
|                                                                                                                                                                                                                                                |
| [            extraitem.Text = [\"extraitem\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                       |
|                                                                                                                                                                                                                                                |
| [            extraitem.ImageUrl = Url.Content([\"\~/Content/images/GalleryView/FontColor16.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                  |
|                                                                                                                                                                                                                                                |
| [            [GalleryViewExtraItem]{style="COLOR: #2b91af"} extraitem2 = [new]{style="COLOR: blue"} [GalleryViewExtraItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                        |
|                                                                                                                                                                                                                                                |
| [            extraitem2.Text = [\"extratiem\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                      |
|                                                                                                                                                                                                                                                |
| [            extraitem2.ImageUrl = Url.Content([\"\~/Content/images/GalleryView/Sort16.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                      |
|                                                                                                                                                                                                                                                |
| [            ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                                |
| [            model.Items = [new]{style="COLOR: blue"} [List]{style="COLOR: #2b91af"}\<[GalleryViewItem]{style="COLOR: #2b91af"}\>() {item, item2,item3, item4, item5, item6, item7, item8 };]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                |
| [            model.ExtraItem = [new]{style="COLOR: blue"} [List]{style="COLOR: #2b91af"}\<[GalleryViewExtraItem]{style="COLOR: #2b91af"}\>() {extraitem, extraitem2 };]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                       |
|                                                                                                                                                                                                                                                |
| [            ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                                |
| [            model.PopUpHeight = [Unit]{style="COLOR: #2b91af"}.Pixel(100);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                  |
|                                                                                                                                                                                                                                                |
| [            model.ItemsToShow = 5;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                          |
|                                                                                                                                                                                                                                                |
| [            model.Width = [Unit]{style="COLOR: #2b91af"}.Pixel(200);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                        |
|                                                                                                                                                                                                                                                |
| [            [return]{style="COLOR: blue"} View(model);]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                      |
|                                                                                                                                                                                                                                                |
| [        }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                     |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

3.  Build and run the application.

[]{#related-topics}
:::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=e1ae74bf-e554-492f-880e-7a0f2ed75f95){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=48dc68ab-be1b-4c12-a95e-28617293fd2c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Maps]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=11705b50-1209-46fb-bfde-18237d32998e){.d2h_breadcrumbsNormal}
:::

## ToolTips {#tooltips style="tab-stops: 0pt"}

ToolTips will be shown when during mouse over on the shape in Maps control. ToolTips can be shown through the AttributesItemSource of the ShapeFileLayer. AttributesItemSource is the IEnumerable collection. AttributesDataMapping will be mapped with AttributesItemSource to show the ToolTip for the Maps WPF.

The following code snippet will demonstrate how to create the ToolTips for the Maps WPF.

![Description: C:\\Users\\karthikeyanp\\Pictures\\shape8.png](ImagesExt/image29_29.jpg){border="0"}

Figure 26: ToolTips

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}**                                                                   |
|                                                                                                                                                                                        |
| [using]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ System;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                       |
|                                                                                                                                                                                        |
| [using]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ System.Collections.Generic;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                   |
|                                                                                                                                                                                        |
| [using]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ System.Linq;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                  |
|                                                                                                                                                                                        |
| [using]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ System.Text;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                  |
|                                                                                                                                                                                        |
| [namespace]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ ToolTipDemo]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                               |
|                                                                                                                                                                                        |
| [{]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                   |
|                                                                                                                                                                                        |
| [   [public]{style="COLOR: blue"} [class]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                 |
|                                                                                                                                                                                        |
| [    {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                               |
|                                                                                                                                                                                        |
| [       [public]{style="COLOR: blue"} MapToolTips()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                  |
|                                                                                                                                                                                        |
| [       { }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                          |
|                                                                                                                                                                                        |
| [       [public]{style="COLOR: blue"} [string]{style="COLOR: blue"} NAME { [get]{style="COLOR: blue"}; [set]{style="COLOR: blue"}; }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                        |
| [    }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                               |
|                                                                                                                                                                                        |
| [}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                   |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}**                                                                                               |
|                                                                                                                                                                                                                    |
| [using]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ System;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                   |
|                                                                                                                                                                                                                    |
| [using]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ System.Collections.Generic;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                               |
|                                                                                                                                                                                                                    |
| [using]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ System.Linq;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                              |
|                                                                                                                                                                                                                    |
| [using]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ System.Text;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                              |
|                                                                                                                                                                                                                    |
| [using]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ System.Collections.ObjectModel;]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                           |
|                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                |
|                                                                                                                                                                                                                    |
| [namespace]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[ ToolTipDemo]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                           |
|                                                                                                                                                                                                                    |
| [{]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                               |
|                                                                                                                                                                                                                    |
| [    [class]{style="COLOR: blue"} [MapToolTip]{style="COLOR: #2b91af"} : [ObservableCollection]{style="COLOR: #2b91af"}\<[MapToolTips]{style="COLOR: #2b91af"}\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                    |
| [    {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                           |
|                                                                                                                                                                                                                    |
| [        [public]{style="COLOR: blue"} MapToolTip()]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                              |
|                                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                    |
| [            Add([new]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"} { NAME = [\"Essex\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                               |
|                                                                                                                                                                                                                    |
| [            Add([new]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"} { NAME = [\"Berkshire\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                           |
|                                                                                                                                                                                                                    |
| [            Add([new]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"} { NAME = [\"Franklin\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                            |
|                                                                                                                                                                                                                    |
| [            Add([new]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"} { NAME = [\"Middlesex\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                           |
|                                                                                                                                                                                                                    |
| [            Add([new]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"} { NAME = [\"Worcester\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                           |
|                                                                                                                                                                                                                    |
| [            Add([new]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"} { NAME = [\"Hampshire\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                           |
|                                                                                                                                                                                                                    |
| [            Add([new]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"} { NAME = [\"Suffolk\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                             |
|                                                                                                                                                                                                                    |
| [            Add([new]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"} { NAME = [\"Plymouth\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                            |
|                                                                                                                                                                                                                    |
| [            Add([new]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"} { NAME = [\"Norfolk\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                             |
|                                                                                                                                                                                                                    |
| [            Add([new]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"} { NAME = [\"Briscol\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                             |
|                                                                                                                                                                                                                    |
| [            Add([new]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"} { NAME = [\"Branstable\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                          |
|                                                                                                                                                                                                                    |
| [            Add([new]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"} { NAME = [\"Dukes\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                               |
|                                                                                                                                                                                                                    |
| [            Add([new]{style="COLOR: blue"} [MapToolTips]{style="COLOR: #2b91af"} { NAME = [\"Nantucket\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                           |
|                                                                                                                                                                                                                    |
| [           ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                     |
|                                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                       |
|                                                                                                                                                                                                                    |
| [    }]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                           |
|                                                                                                                                                                                                                    |
| [}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

         

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}**                                                                                          |
|                                                                                                                                                                                                               |
| [            this]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[.shapeControl.AttributesDataMapping = [\"NAME;\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                               |
| [            [this]{style="COLOR: blue"}.shapeControl.AttributesItemsSource = [new]{style="COLOR: blue"} [MapToolTip]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Note:

To define multiple AttributesDataMapping elements, the elements can be separated by a semi- colon. AttributesItemSource elements value and the property of the class which is to be binded with AttributesItemSource should be the same. To enable the ToolTips with this method ShowAttributesToolTip property must be set as true.

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}**                                                                                  |
|                                                                                                                                                                                                       |
| [            this]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[.shapeControl.ShowAttributesToolTip = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Alternative way to Show the ToolTip

Load a shape file from the location. If a .dbf file with same name is available in the same location ToolTip will be displayed automatically If a shape file is loaded with Uri property, add a .dbf file with the same name of the shape file in the same location, and change its property "Copy to Directory" as Always Copy. Then the ToolTip for the corresponding shape file will be displayed automatically.

 

 

[]{#related-topics}
::::

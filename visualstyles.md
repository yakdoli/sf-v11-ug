::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Visual Styles {#visual-styles style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

The Visual appearance of the menus can be defined by using various Visual Styles and Themes.

 

Themes define the look and feel of the whole menu and it also changes the behavior of the menu. Themes can be enabled by setting **ThemesEnabled** property of mainFrameBarManager to true.

[]{style="COLOR: #15428b"} 

![](ImagesExt/image76_819.jpg){border="0"}

**[]{style="COLOR: #15428b"}** 

Figure 832: No Themes

**[]{style="COLOR: #15428b"}** 

![](ImagesExt/image76_820.jpg){border="0"}

**[]{style="COLOR: #15428b"}** 

Figure 833: XP Theme

**[]{style="COLOR: #15428b"}** 

   Supported GUI styles

 

The supported Visual styles are:

[  ]{style="COLOR: #15428b"}

[·      ]{style="FONT-FAMILY: Symbol"}**Office 2003 look**: This can enabled by setting **Style** to Office2003.

[]{style="COLOR: #15428b"} 

![](ImagesExt/image76_821.jpg){border="0"}

***[]{style="COLOR: #15428b"}*** 

Figure 834: Office 2003 Visual Style

[]{style="COLOR: #15428b"} 

[·      ]{style="FONT-FAMILY: Symbol"}**OfficeXP look**: This can enabled by setting **Style** to OfficeXP.

[]{style="COLOR: #15428b"} 

![](ImagesExt/image76_822.jpg){border="0"}

***[]{style="COLOR: #15428b"}*** 

Figure 835: Office XP Visual style

 

[·      ]{style="FONT-FAMILY: Symbol"}**VS2005 look:** This can enabled by setting Style to VS2005.

[]{style="COLOR: #15428b"} 

![](ImagesExt/image76_823.jpg){border="0"}

***[]{style="COLOR: #15428b"}*** 

Figure 836: VS 2005 Visual Style

**[]{style="COLOR: #15428b"}** 

[·      ]{style="FONT-FAMILY: Symbol"}**Office 2007 look**: This can enabled by setting **Style** to Office2007.

[]{style="COLOR: #15428b"} 

![](ImagesExt/image76_824.jpg){border="0"}

***[]{style="COLOR: #15428b"}*** 

Figure 837: Office 2007 Visual Style

**[]{style="COLOR: #15428b"}** 

[·      ]{style="FONT-FAMILY: Symbol"}**Office 2007 Outlook**: This can enabled by setting **Style** to Office2007Outlook.

[]{style="COLOR: #15428b"} 

![](ImagesExt/image76_825.jpg){border="0"}

 

Figure 838: Office 2007 Outlook Visual Style

**[]{style="COLOR: #15428b"}** 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                              |
|                                                                                                                                                                             |
| [   ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.mainFrameBarManager1.Style = [VisualStyle]{style="COLOR: teal"}.Office2003;  ]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                              |
|                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                 |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.mainFrameBarManager1.Style = VisualStyle.Office2003]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

Office 2007 Themes

**[]{style="COLOR: #15428b"}** 

You can also specify the color schemes for Office 2007 visual styles. They can be blue, silver and black.

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image76_1.jpg){border="0"}Note: The property ThemesEnabled must be set to true and the property Style must be set to either Office2007 or Office2007Outlook.
:::

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                       |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.mainFrameBarManager1.Style = [VisualStyle]{style="COLOR: teal"}.Office2007;  ]{style="FONT-FAMILY: 'Courier New'"}[   ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                      |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.mainFrameBarManager1.Office2007Theme = [Office2007ColorScheme]{style="COLOR: teal"}.Blue;]{style="FONT-FAMILY: 'Courier New'"}                              |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                            |
|                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                               |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.mainFrameBarManager1.Style = VisualStyle.Office2007]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                               |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.mainFrameBarManager1.Office2007Theme = Office2007ColorScheme.Blue]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="COLOR: #15428b"}** 

![](ImagesExt/image76_826.jpg){border="0"}

**[]{style="COLOR: #15428b"}** 

Figure 839: Office 2007 Blue Theme

**[]{style="COLOR: #15428b"}** 

![](ImagesExt/image76_827.jpg){border="0"}

**[]{style="COLOR: #15428b"}** 

Figure 840: Office 2007 Silver Theme

**[]{style="COLOR: #15428b"}** 

![](ImagesExt/image76_828.jpg){border="0"}

**[]{style="COLOR: #15428b"}** 

Figure 841: Office 2007 Black Theme

**[]{style="COLOR: #15428b"}** 

Custom Colors

[]{style="COLOR: #15428b"} 

We can also apply custom colors to the MainFrameBarManager by setting Office2007Theme to \"Managed\" and specifying the custom color through the **ApplyManagedColors** method as follows.

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                |
|                                                                                                                                                                                                               |
| []{style="COLOR: #15428b"}                                                                                                                                                                                    |
|                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.mainFrameBarManager1.Office2007Theme = Syncfusion.Windows.Forms.[Office2007Theme]{style="COLOR: teal"}.Managed;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| [Office2007Colors]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.ApplyManagedColors([this]{style="COLOR: blue"}, [Color]{style="COLOR: teal"}.Crimson);]{style="FONT-FAMILY: 'Courier New'"}              |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                          |
|                                                                                                                                                                                                             |
| []{style="COLOR: #15428b"}                                                                                                                                                                                  |
|                                                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.mainFrameBarManager1.Office2007Theme = Syncfusion.Windows.Forms.[Office2007Theme]{style="COLOR: teal"}.Managed;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                             |
| [Office2007Colors.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ApplyManagedColors([Me]{style="COLOR: blue"}, [Color]{style="COLOR: black"}.Crimson)]{style="FONT-FAMILY: 'Courier New'"}             |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

![](ImagesExt/image76_698.jpg){border="0"}

[]{style="COLOR: #15428b"} 

Figure 842: Custom Color = \"Crimson\"

[]{#_Customize_Dialog_Appearance} 

[]{#related-topics}
::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to display the SplashPanel along with the mouse pointer {#how-to-display-the-splashpanel-along-with-the-mouse-pointer style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

 

Set the [[DesktopAlignment]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_Alignment_Settings_1)[ ]{.UGHyperlink}property of the SplashPanel to ***Custom***, and call the **ShowSplash** method, by passing the pointer position as the parameter as follows.

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                  |
|                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                 |
| [Point]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pt = [Point]{style="COLOR: #2b91af"}.Empty;]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                                 |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[( SplashPanel1.DesktopAlignment == [SplashAlignment]{style="COLOR: #2b91af"}.Custom)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                 |
| [pt = [Control]{style="COLOR: #2b91af"}.MousePosition;]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                 |
| [SplashPanel1 .ShowSplash(pt, [this]{style="COLOR: blue"}, [true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                                                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                             |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                            |
|                                                                                                                                                                                |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pt [As]{style="COLOR: blue"} Point = Point.Empty]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                |
| [If]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ SplashPanel1.DesktopAlignment = SplashAlignment.Custom [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                |
| [pt = Control.MousePosition]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                |
| [SplashPanel1.ShowSplash(pt, [Me]{style="COLOR: blue"}, [True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

 

[]{#related-topics}
:::

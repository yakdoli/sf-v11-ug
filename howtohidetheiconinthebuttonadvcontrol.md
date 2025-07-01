::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to hide the icon in the ButtonAdv control? {#how-to-hide-the-icon-in-the-buttonadv-control style="tab-stops: 0pt"}

The icon in the ButtonAdv control can be hidden by using the IconWidth and IconHeight properties. It is described with the help of the following code snippet:

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sync]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ButtonAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ Label]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Hello World\" ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[IconWidth]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"0\" ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[IconHeight]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"0\"   /\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                |
|                                                                                                                                                                                 |
| [ButtonAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ button = [new]{style="COLOR: blue"} [ButtonAdv]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                 |
| [button.Label = [\"Hello World\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                 |
| [button.IconHeight = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                 |
| [button.IconWidth = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image30_65.jpg){border="0"}

Figure 61: ButtonAdv control without Image

 

[]{#related-topics}
:::

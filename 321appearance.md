::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### 3.2.1 Appearance {#appearance style="tab-stops: 0pt"}

The RouteLink Button control supports built-in themes that provide great visual appeal that are suitable for various layouts. It supports the following four built-in Syncfusion themes to enhance the look and feel:

[·      ]{style="FONT-FAMILY: Symbol"} [BlueLight]{style="FONT-FAMILY: 'Arial','sans-serif'"}

[·      ]{style="FONT-FAMILY: Symbol"} [DarkNight]{style="FONT-FAMILY: 'Arial','sans-serif'"}

[·      ]{style="FONT-FAMILY: Symbol"} [MetroBlue]{style="FONT-FAMILY: 'Arial','sans-serif'"}

[·      ]{style="FONT-FAMILY: Symbol"} [Spinach]{style="FONT-FAMILY: 'Arial','sans-serif'"}

Properties

+---------------------------------------------------------------------------+------------------------------------------------------------+----------------------------------+----------------------------------+-----------------------------------+
| Name                                                                      | Description                                                | Type of the Property             | Value it Accepts                 | Dependency                        |
+---------------------------------------------------------------------------+------------------------------------------------------------+----------------------------------+----------------------------------+-----------------------------------+
| []{style="FONT-WEIGHT: normal"}                                           | [To define syncfusion themes]{style="FONT-WEIGHT: normal"} | enum                             | MobSkins.BlueLight,              | [NA]{style="FONT-WEIGHT: normal"} |
|                                                                           |                                                            |                                  |                                  |                                   |
| []{style="FONT-WEIGHT: normal"}                                           |                                                            | []{style="FONT-WEIGHT: normal"}  | MobSkins.DarkNight,              |                                   |
|                                                                           |                                                            |                                  |                                  |                                   |
| []{style="FONT-WEIGHT: normal"}                                           |                                                            |                                  | MobSkins.MetroBlue,              |                                   |
|                                                                           |                                                            |                                  |                                  |                                   |
| [AutoFormat]{style="FONT-WEIGHT: normal"} []{style="FONT-WEIGHT: normal"} |                                                            |                                  | MobSkins.Spinach                 |                                   |
|                                                                           |                                                            |                                  |                                  |                                   |
| []{style="FONT-WEIGHT: normal"}                                           |                                                            |                                  | []{style="FONT-WEIGHT: normal"}  |                                   |
|                                                                           |                                                            |                                  |                                  |                                   |
| []{style="FONT-WEIGHT: normal"}                                           |                                                            |                                  |                                  |                                   |
|                                                                           |                                                            |                                  |                                  |                                   |
| []{style="FONT-WEIGHT: normal"}                                           |                                                            |                                  |                                  |                                   |
+---------------------------------------------------------------------------+------------------------------------------------------------+----------------------------------+----------------------------------+-----------------------------------+

 

Using Builder

The following steps explain the appearance customization of the RouteLink Button control using Builder.

 

1.   In the **view**, invoke the RouteLink Button helper with the text of the button as first argument followed by the **AutoFormat** method with the desired theme as its argument.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [ Html.MobSyncfusion().RouteLink([\"RouteLink\"]{style="COLOR: #a31515"}, [\"Button\"]{style="COLOR: #a31515"}).AutoFormat([MobSkins]{style="COLOR: #2b91af"}.Spinach)[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} []{style="FONT-FAMILY: 'Courier New'"} [Html.MobSyncfusion().RouteLink([\"RouteLink\"]{style="COLOR: #a31515"}, [\"Button\"]{style="COLOR: #a31515"}).AutoFormat([MobSkins]{style="COLOR: #2b91af"}.Spinach)]{style="FONT-FAMILY: 'Courier New'"} [.]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} [Render();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"} []{style="FONT-FAMILY: 'Courier New'"} [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   Build and run the application.

The output is shown in the following screenshot.[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"}

![Description: C:\\Users\\thivyak\\Desktop\\route.png](ImagesExt/image103_94.jpg){border="0"}

Figure 218:  RouteLink Button---AutoFormat Property

 

If users click the route link button, the theme will be applied to the control. The following screenshot shows how the theme is applied to the control.

 

![Description: C:\\Users\\thivyak\\Desktop\\routeac.png](ImagesExt/image103_95.jpg){border="0"}

Figure 219: RouteLinkButton while Clicking

 

[]{#related-topics}
:::

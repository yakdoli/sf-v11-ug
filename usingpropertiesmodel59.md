::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Properties Model {#using-properties-model style="tab-stops: 0pt"}

The following steps, explains about the Button settings in Header control using the *Properties* model:

1.   In the **Controller**, create an instance of **MobHeaderModel**, define the LeftButton propertiesandRightButton properties and pass the instance through **ViewData** to **View** as given below:**

*[[ []{style="TEXT-DECORATION: none"} ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}]{.underline}*  

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                |
|                                                                                                                                                                         |
| [        [public]{style="COLOR: blue"}[ActionResult]{style="COLOR: #2b91af"} CoreFeatures()]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                         |
| [            [MobHeaderModel]{style="COLOR: #2b91af"} model = [new]{style="COLOR: blue"}[MobHeaderModel]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                         |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                         |
| [                TargetId = [\"targetHeader\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                         |
| [                Title = [\"Select an action\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                         |
| [                AutoFormat = [MobSkins]{style="COLOR: #2b91af"}.MetroBlue,]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                         |
| [                ClientSideOnCreate = [\"onCreate\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                         |
| [                LeftButton = [new]{style="COLOR: blue"}[LeftButton]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                         |
| [                {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                         |
| [                    Caption = [\"Back\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                         |
| [                    ShowButton = [true]{style="COLOR: blue"},]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                         |
| [                    ClientSideOnClick = [\"onLeftClick\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                         |
| [                },]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                         |
| [                RightButton = [new]{style="COLOR: blue"}[RightButton]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                         |
| [                {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                         |
| [                    Caption = [\"Forward\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                         |
| [                    ShowButton = [true]{style="COLOR: blue"},]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                         |
| [                    ClientSideOnClick = [\"onRightClick\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                         |
| [                }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                         |
| [            };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                         |
| [            ViewData\[[\"Header\"]{style="COLOR: #a31515"}\] = model;]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                         |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                              |
|                                                                                                                                                                         |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

2.   In **View**, invoke the Header helper with the **ViewData** key as the first argument.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                |
|                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                        |
|                                                                                                                                                                                                                   |
| [                [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.MobSyncfusion().Header([\"Header\"]{style="COLOR: #a31515"})[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                   |
|                                                                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                            |
|                                                                                                                                                                                                       |
| [    [@]{style="BACKGROUND: yellow"}Html.MobSyncfusion().Header([\"Header\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

3.   Build and run the application.

 

The output is displayed in the following screenshot:

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

![](ImagesExt/image103_124.jpg){border="0"}

Figure 50: Header Control with Buttons

 

[]{#related-topics}
:::

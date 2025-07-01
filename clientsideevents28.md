::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Client-Side Events {#client-side-events style="tab-stops: 0pt"}

The Button control supports the Client-Side event handling.

[]{style="COLOR: black"} 

Use Case Scenarios

The Button control allows for easy customization of the events to be handled on the button.

[]{style="COLOR: black"} 

Adding Client-Side Events to an Application

The Client-Side events can be customized by two ways in button.

[·      ]{style="FONT-FAMILY: Symbol"}Using Builder

[·      ]{style="FONT-FAMILY: Symbol"}Using Properties Model

 

Using Builder

The following steps guide in handling client side events through builder.

1.   In View, invoke the normal Button helper with the button id as the first argument followed by the **ClientSideOnClick** and **ClientSideOnLoad** methods.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                  |
|                                                                                                                                                                         |
| [        [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().Button([\"myButton\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                         |
| [        .Text([\"Save\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                         |
| [        .Skin([Skins]{style="COLOR: #2b91af"}.Almond)]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                         |
| [        .ImageUrl([\"Content/icon_save.png\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                         |
| [        .ContentType([ContentTypes]{style="COLOR: #2b91af"}.TextAndImage)]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                         |
| **[        .ClientSideOnClick([\"OnClick\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                             |
|                                                                                                                                                                         |
| **[        .ClientSideOnLoad([\"OnLoaded\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                             |
|                                                                                                                                                                         |
| [        [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                |
|                                                                                                                                                                         |
| [        [\@{]{style="BACKGROUND: yellow"}[ ]{style="COLOR: blue"}Html.Syncfusion().Button([\"myButton\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                         |
| [        .Text([\"Save\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                         |
| [        .Skin([Skins]{style="COLOR: #2b91af"}.Almond)]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                         |
| [        .ImageUrl([\"Content/icon_save.png\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                         |
| [        .ContentType([ContentTypes]{style="COLOR: #2b91af"}.TextAndImage)]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                         |
| **[        .ClientSideOnClick([\"OnClick\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                             |
|                                                                                                                                                                         |
| **[        .ClientSideOnLoad([\"OnLoaded\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                             |
|                                                                                                                                                                         |
| **[        ]{style="FONT-FAMILY: 'Courier New'"}**[.Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                         |
| [        [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   In Javascript, use the methods to enable and disable an item as follows.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                                   |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [type]{style="COLOR: red"}[=\"text/javascript\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                                   |
| [        [function]{style="COLOR: blue"} OnLoaded(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                   |
| [            [// inst - Instance of the button object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                                   |
| [            [// args :    args.\_currentItem   - clickeded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                                   |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                   |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                   |
| [        [function]{style="COLOR: blue"} OnClick(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                   |
| [            [// inst - instance of the button object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                                   |
| [            [//args :    args.\_currentItem   - loaded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                                                                                                   |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                   |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                   |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

Using Builder

[]{style="COLOR: black"} 

The following steps guide you in handling the Client-Side events through the Builder.

1.   In Controller, create an object for the **ButtonModel** class and set the **ClientSideOnLoad**, and **ClientSideOnClick** properties. Assign this model class to view data.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                 |
|                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                               |
|                                                                                                                                                                          |
| [        [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                          |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                          |
| [            [ButtonModel]{style="COLOR: #2b91af"} buttonModel = [new]{style="COLOR: blue"} [ButtonModel]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                          |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                          |
| [                Text = [\"Save\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                          |
| [                ImageUrl = [\"Content/icon_save.png\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                          |
| [                Skin = [Skins]{style="COLOR: #2b91af"}.Almond,]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                          |
| [                ContentType = [ContentTypes]{style="COLOR: #2b91af"}.TextAndImage,]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                          |
| [                ImagePosition = [ImagePositions]{style="COLOR: #2b91af"}.Right,]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                          |
| **[                ClientSideOnClick = [\"OnClick\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}**                                                     |
|                                                                                                                                                                          |
| **[                ClientSideOnLoad = [\"OnLoaded\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}**                                                      |
|                                                                                                                                                                          |
| [            };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                          |
| [            ViewData\[[\"ButtonModel\"]{style="COLOR: #a31515"}\] = buttonModel;]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                          |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                          |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

 

2.   In **View**, invoke the normal **Button** helper with the button id as the first argument followed by the view data of the **ButtonModel** class.

 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                         |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Button([\"btnNormal\"]{style="COLOR: #a31515"},([ButtonModel]{style="COLOR: #2b91af"})ViewData\[[\"ButtonModel\"]{style="COLOR: #a31515"}\]) [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                                                                                              |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Button([\"btnNormal\"]{style="COLOR: #a31515"},([ButtonModel]{style="COLOR: #2b91af"})ViewData\[[\"ButtonModel\"]{style="COLOR: #a31515"}\]).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                                                                                                     |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

3.   In **Javascript**, define the function to handle the specified events.

 

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                                   |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [type]{style="COLOR: red"}[=\"text/javascript\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                                   |
| [        [function]{style="COLOR: blue"} OnLoaded(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                   |
| [            [// inst - Instance of the button object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                                   |
| [            [// args :    args.\_currentItem   - clickeded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                                   |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                   |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                   |
| [        [function]{style="COLOR: blue"} OnClick(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                   |
| [            [// inst - Instance of the button object]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                   |
| [            [// args :    args.\_currentItem   - loaded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                                                   |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                   |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                   |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Events

The following table illustrates the events of button control.

[]{style="COLOR: black"} 

::: {align="center"}
  Event               Description                                                     Arguments   Type     Reference links
  ------------------- --------------------------------------------------------------- ----------- -------- -----------------
  ClientSideOnLoded   This event is raised immediately when the button gets loaded.   inst,args   Client   \-
  ClientSideOnClick   This event is raised when a button is clicked.                  inst,args   Client   \-
:::

[]{style="COLOR: black"} 

Sample Link

To view the samples, follow the steps below:

1.   Open the Tools sample browser from the dashboard. (Refer to the [Samples and Location]{.UGHyperlink}[ ]{.UGHyperlink}chapter)

2.   Navigate to **Tools.Mvc -\> Button -\> Client-Side API**.

 

[]{#related-topics}
::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Client-Side Events {#client-side-events style="tab-stops: 0pt"}

The Toggle-Button supports the Client-Side event handling.

[]{style="COLOR: black"} 

Use Case Scenarios

[It allows for easy customization of the events to be handled on the Toggle-Button.  ]{style="COLOR: black"}

[]{style="COLOR: black"} 

Adding Client-Side Events to an Application

The Client-Side events can be customized by two ways in Toggle-Button.

[·      ]{style="FONT-FAMILY: Symbol"}Using Builder

[·      ]{style="FONT-FAMILY: Symbol"}Using Properties Model

[]{style="COLOR: black"} 

**[Using Builder]{style="COLOR: black"}**

[]{style="COLOR: black"} 

The following steps guides in handling the Client-Side events through Builder.

[]{style="COLOR: black"} 

1.   In View, invoke the normal ToggleButton helper with the button id as the first argument followed by the **ClientSideOnChecked, ClientSideOnUnChecked, ClientSideOnClick** and **ClientSideOnLoad** methods.

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                              |
|                                                                                                                                                                                     |
| [        [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().ToggleButton([\"myToggleButton\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                     |
| [        .Text([\"Save\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                     |
| [        .IsChecked = [true]{style="COLOR: blue"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                     |
| [        .ImageUrl([\"Content/icon_save.png\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                     |
| [        .ContentType([ContentTypes]{style="COLOR: #2b91af"}.TextAndImage)]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                     |
| **[        .ClientSideOnClick([\"OnClick\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                         |
|                                                                                                                                                                                     |
| **[        .ClientSideOnLoad([\"OnLoaded\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                         |
|                                                                                                                                                                                     |
| **[        .ClientSideOnChecked([\"OnCheck\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                       |
|                                                                                                                                                                                     |
| **[        .ClientSideOnUnChecked([\"OnUnCheck\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                   |
|                                                                                                                                                                                     |
| [        [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                            |
|                                                                                                                                                                                     |
| [        [\@{]{style="BACKGROUND: yellow"}[ ]{style="COLOR: blue"}Html.Syncfusion().ToggleButton([\"myToggleButton\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                     |
| [        .Text([\"Save\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                     |
| [        .IsChecked = [true]{style="COLOR: blue"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                     |
| [        .ImageUrl([\"Content/icon_save.png\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                     |
| [        .ContentType([ContentTypes]{style="COLOR: #2b91af"}.TextAndImage)]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                     |
| **[        .ClientSideOnClick([\"OnClick\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                         |
|                                                                                                                                                                                     |
| **[        .ClientSideOnLoad([\"OnLoaded\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                         |
|                                                                                                                                                                                     |
| **[        .ClientSideOnChecked([\"OnCheck\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                       |
|                                                                                                                                                                                     |
| **[        .ClientSideOnUnChecked([\"OnUnCheck\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                   |
|                                                                                                                                                                                     |
| **[        .]{style="FONT-FAMILY: 'Courier New'"}**[Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                     |
| [        [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

2.   In Javascript, use the methods to enable and disable an item as follow[s.]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"}

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                                 |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [type]{style="COLOR: red"}[=\"text/javascript\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnLoaded(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                                 |
| [            [// inst - instance of button object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                 |
| [            [// args :    args.\_currentItem   - clickeded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnClick(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                 |
| [            [// inst - instance of button object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                 |
| [            [// args :    args.\_currentItem   - loaded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnCheck(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                 |
| [            [// inst - instance of button object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                 |
| [            [// args :    args.\_currentItem   - clickeded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnUnCheck(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                                 |
| [            [// inst - instance of button object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                 |
| [            [// args :    args.\_currentItem   - loaded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Using Properties Model

The following steps guides in handling the Client-Side events through the Properties model.

 

1.   In Controller, create an object for the ToggleButtonModel class and set the **ClientSideOnChecked, ClientSideOnUnChecked, ClientSideOnLoad**, and **ClientSideOnClick** properties. Assign this model class to view data.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                   |
|                                                                                                                                                                                            |
| [        [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                            |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                            |
| [            [ToggleButtonModel]{style="COLOR: #2b91af"} toggleButtonModel = [new]{style="COLOR: blue"} [ToggleButtonModel]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                            |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                            |
| [                Text = [\"Save\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                            |
| [                ImageUrl = [\"Content/icon_save.png\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                            |
| [                ContentType = [ContentTypes]{style="COLOR: #2b91af"}.TextAndImage,]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                            |
| [                ImagePosition = [ImagePositions]{style="COLOR: #2b91af"}.Right,]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                            |
| **[                ClientSideOnClick = [\"OnClick\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}**                                                                       |
|                                                                                                                                                                                            |
| **[                ClientSideOnLoad = [\"OnLoaded\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}**                                                                        |
|                                                                                                                                                                                            |
| **[                ClientSideOnChecked = [\"OnCheck\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}**                                                                     |
|                                                                                                                                                                                            |
| **[                ClientSideOnUnChecked = [\"OnUnCheck\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}**                                                                  |
|                                                                                                                                                                                            |
| [            };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                            |
| [            ViewData\[[\"ToggleButtonModel\"]{style="COLOR: #a31515"}\] = toggleButtonModel;]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                            |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                            |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                 |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

2.   In View, invoke the ToggleButton helper with the button id as the first argument followed by the view data of the **ToggleButtonModel** class.

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().ToggleButton([\"btnToggle\"]{style="COLOR: #a31515"},([ToggleButtonModel]{style="COLOR: #2b91af"})ViewData\[[\"ToggleButtonModel\"]{style="COLOR: #a31515"}\]) [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                                                                                                                |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                   |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().ToggleButton([\"btnToggle\"]{style="COLOR: #a31515"},([ToggleButtonModel]{style="COLOR: #2b91af"})ViewData\[[\"ToggleButtonModel\"]{style="COLOR: #a31515"}\]).Render(); [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                                                                                                                        |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

3.   In Javascript, define the function to handle the specified events.

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                                 |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [type]{style="COLOR: red"}[=\"text/javascript\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnLoaded(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                                 |
| [            [// inst - instance of button object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                 |
| [            [// args :    args.\_currentItem   - clickeded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnClick(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                 |
| [            [// inst - instance of button object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                 |
| [            [// args :    args.\_currentItem   - loaded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnCheck(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                 |
| [            [// inst - instance of button object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                 |
| [            [// args :    args.\_currentItem   - clickeded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnUnCheck(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                                 |
| [            [// inst - instance of button object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                 |
| [            [// args :    args.\_currentItem   - loaded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Events

The following table illustrates the events which describes the events of the Toggle-Button.

 

  Event                                           Description                                                                                       Arguments                             Type                                Reference links
  ----------------------------------------------- ------------------------------------------------------------------------------------------------- ------------------------------------- ----------------------------------- -----------------------------
  ClientSideOnLoded[]{style="COLOR: #c00000"}     This event is raised immediately when the Toggle-Button gets loaded.[]{style="COLOR: #c00000"}    inst,args[]{style="COLOR: #c00000"}   [Client ]{style="COLOR: #c00000"}   [-]{style="COLOR: #c00000"}
  ClientSideOnClick                               This event is raised when the Toggle-Button is clicked.                                           inst,args                             [Client]{style="COLOR: #c00000"}    [-]{style="COLOR: #c00000"}
  ClientSideOnChecked[]{style="COLOR: #c00000"}   This event is raised immediately when the Toggle-Button gets checked.[]{style="COLOR: #c00000"}   inst,args[]{style="COLOR: #c00000"}   [Client ]{style="COLOR: #c00000"}   [-]{style="COLOR: #c00000"}
  ClientSideOnUnChecked                           This event is raised immediately when the Toggle-Button gets unchecked.                           inst,args                             [Client]{style="COLOR: #c00000"}    [-]{style="COLOR: #c00000"}

[]{style="COLOR: black"} 

Sample Link

To view the samples, follow the steps below.

1.   Open the Tools sample browser from the dashboard. (Refer to the Samples and Location chapter)

2.   Navigate to **Tools.Mvc -\> Button -\> Client-Side API.**

 

[]{#related-topics}
:::

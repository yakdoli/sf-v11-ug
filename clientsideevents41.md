::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Client-Side Events {#client-side-events style="tab-stops: 0pt"}

The Split-Button supports Client-Side event handling.

 

Use Case Scenarios

It allows for easy customization of the events to be handled on the split-button.

 

Adding Client-Side Events[ ]{style="COLOR: red"}to an Application

The Client-Side events can be customized by two ways in the Split-Button.

[·      ]{style="FONT-FAMILY: Symbol"}Using Builder

[·      ]{style="FONT-FAMILY: Symbol"}Using Properties Model

 

Using Builder

The following steps guides you in handling the Client-Side events through the Builder.

1.   In **View**, invoke the normal **SplitButton** helper with the button id as the first argument followed by the **ClientSideOnChecked, ClientSideOnUnChecked, ClientSideOnClick** and **ClientSideOnLoad** methods.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                            |
|                                                                                                                                                                                   |
| [        [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().SplitButton([\"mySplitButton\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                   |
| [        .Text([\"Save\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                   |
| [        .ImageUrl([\"Content/icon_save.png\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                   |
| [        .ContentType([ContentTypes]{style="COLOR: #2b91af"}.TextAndImage)]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                   |
| **[        .ClientSideOnClick([\"OnClick\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                       |
|                                                                                                                                                                                   |
| **[        .ClientSideOnLoad([\"OnLoaded\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                       |
|                                                                                                                                                                                   |
| **[        .ClientSideOnMenuItemClick([\"OnItemClick\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                           |
|                                                                                                                                                                                   |
| **[        .ClientSideOnMouseOut([\"OnMouseOut\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                 |
|                                                                                                                                                                                   |
| **[        .ClientSideOnMouseOver([\"OnMouseOver\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                               |
|                                                                                                                                                                                   |
| [        [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                          |
|                                                                                                                                                                                   |
| [        [\@{]{style="BACKGROUND: yellow"}[ ]{style="COLOR: blue"}Html.Syncfusion().SplitButton([\"mySplitButton\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                   |
| [        .Text([\"Save\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                   |
| [        .ImageUrl([\"Content/icon_save.png\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                   |
| [        .ContentType([ContentTypes]{style="COLOR: #2b91af"}.TextAndImage)]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                   |
| **[        .ClientSideOnClick([\"OnClick\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                       |
|                                                                                                                                                                                   |
| **[        .ClientSideOnLoad([\"OnLoaded\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                       |
|                                                                                                                                                                                   |
| **[        .ClientSideOnMenuItemClick([\"OnItemClick\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                           |
|                                                                                                                                                                                   |
| **[        .ClientSideOnMouseOut([\"OnMouseOut\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                 |
|                                                                                                                                                                                   |
| **[        .ClientSideOnMouseOver([\"OnMouseOver\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                               |
|                                                                                                                                                                                   |
| [        .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                   |
| [        [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   In Javascript, use the methods to enable and disable an item as follows.

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
| [            [//args :    args.\_currentItem   - clickeded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnClick(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                 |
| [            [// inst - instance of button object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                 |
| [            [//args :    args.\_currentItem   - loaded button ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - button id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnMouseOver(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                       |
|                                                                                                                                                                                                                                 |
| [            [//inst - instance of menu object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                   |
|                                                                                                                                                                                                                                 |
| [            [//args :    args.\_currentItem   - current drop-down item]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                           |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - drop-down item id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_text          - text of the current drop-down item                  ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}             |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                               |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnMouseOut(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                        |
|                                                                                                                                                                                                                                 |
| [            [//inst - instance of menu object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                   |
|                                                                                                                                                                                                                                 |
| [            [//args :    args.\_currentItem   - current drop-down item ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                          |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - drop-down id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                     |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_text          - text of the current drop-down item ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                              |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                               |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnItemClick(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                       |
|                                                                                                                                                                                                                                 |
| [            [//inst - instance of drop-down item object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                         |
|                                                                                                                                                                                                                                 |
| [            [//args :    args.\_currentItem   - current drop-down item ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                          |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - drop-down id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                     |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_text          - text of the current drop-down item ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                              |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                               |
|                                                                                                                                                                                                                                 |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Using Builder

The following steps guide in handling client side events through builder.

 

1.   In **Controller**, create an object for the **SplitButtonModel** class and set **ClientSideOnChecked, ClientSideOnUnChecked, ClientSideOnLoad**, and **ClientSideOnClick** properties. Assign this model class to view data.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                |
|                                                                                                                                                                                         |
| [        [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                         |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| [            [SplitButtonModel]{style="COLOR: #2b91af"} splitButtonModel = [new]{style="COLOR: blue"} [SplitButtonModel]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                         |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                         |
| [                Text = [\"Save\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                         |
| [                ImageUrl = [\"Content/icon_save.png\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                         |
| [                ContentType = [ContentTypes]{style="COLOR: #2b91af"}.TextAndImage,]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                         |
| [                ImagePosition = [ImagePositions]{style="COLOR: #2b91af"}.Right,]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                         |
| **[                ClientSideOnClick = [\"OnClick\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}**                                                                    |
|                                                                                                                                                                                         |
| **[                ClientSideOnLoad = [\"OnLoaded\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}**                                                                     |
|                                                                                                                                                                                         |
| **[                ClientSideOnMenuItemClick = [\"OnItemClick\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}**                                                        |
|                                                                                                                                                                                         |
| **[                ClientSideOnMouseOut = [\"OnMouseOut\",]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}**                                                              |
|                                                                                                                                                                                         |
| **[                ClientSideOnMouseOver = [\"OnMouseOver\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}**                                                             |
|                                                                                                                                                                                         |
| [            };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                         |
| [            ViewData\[[\"SplitButtonModel\"]{style="COLOR: #a31515"}\] = splitButtonModel;]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                         |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                         |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                              |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

2.   In **View**, invoke the normal **SplitButton** helper with the button id as the first argument followed by the view data of the **SplitButtonModel** class.

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                       |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().SplitButton([\"btnSplit\"]{style="COLOR: #a31515"},([SplitButtonModel]{style="COLOR: #2b91af"})ViewData\[[\"SplitButtonModel\"]{style="COLOR: #a31515"}\]) [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                                                                                                            |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                               |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().SplitButton([\"btnSplit\"]{style="COLOR: #a31515"},([SplitButtonModel]{style="COLOR: #2b91af"})ViewData\[[\"SplitButtonModel\"]{style="COLOR: #a31515"}\]).Render(); [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"} 

3.   In **Javascript**, define the function to handle specified events.

 

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
| [        [function]{style="COLOR: blue"} OnMouseOver(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                       |
|                                                                                                                                                                                                                                 |
| [            [// inst - instance of menu object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                  |
|                                                                                                                                                                                                                                 |
| [            [// args :    args.\_currentItem   - current drop-down item.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                         |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - drop-down item id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_text          - text of the current drop-down item                  ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}             |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                               |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnMouseOut(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                        |
|                                                                                                                                                                                                                                 |
| [            [//inst - instance of menu object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                   |
|                                                                                                                                                                                                                                 |
| [            [//args :    args.\_currentItem   - current drop-down item ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                          |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - drop-down id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                     |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_text          - text of the current drop-down item ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                              |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                               |
|                                                                                                                                                                                                                                 |
| [        [function]{style="COLOR: blue"} OnItemClick(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                       |
|                                                                                                                                                                                                                                 |
| [            [// inst - instance of drop-down item object.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                        |
|                                                                                                                                                                                                                                 |
| [            [//args :    args.\_currentItem   - current drop-down item ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                          |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_id            - drop-down id]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                     |
|                                                                                                                                                                                                                                 |
| [            [//          args.\_text          - text of the current drop-down item ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                              |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                               |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                 |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Events

The following table illustrates events of the Split-Button.

 

 

 

  Event                       Description                                                           Arguments   Type     Reference links
  --------------------------- --------------------------------------------------------------------- ----------- -------- -----------------
  ClientSideOnLoded           This event is raised immediately when the Split-Button gets loaded.   inst,args   Client   \-
  ClientSideOnClick           This event is raised when the Split-Button is clicked.                inst,args   Client   \-
  ClientSideOnMenuItemClick   This event is raised when the menu item is clicked.                   inst,args   Client   \-
  ClientSideOnMouseOver       This event is raised on mouse over a menu item.                       inst,args   Client   \-
  ClientSideOnMouseOut        This event is raised on mouse over a menu item.                       inst,args   Client   \-

[]{style="COLOR: black"} 

Sample Link

To view the samples, follow the steps below.

1.   Open the Tools sample browser from the dashboard. (Refer to the Samples and Location chapter)

2.   Navigate to **Tools.Mvc -\> Button -\> Client-Side API**.

[]{style="COLOR: black"} 

[]{#related-topics}
:::

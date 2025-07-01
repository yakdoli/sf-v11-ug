::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Properties Model      {#using-properties-model style="tab-stops: 0pt"}

The following steps guide in handling client side events through the Properties model.

1.   In Controller, create an instance of MobToolbarModel, define the **ClientSideOnCreate**,and  **ClientSideOnClick** events and pass the instance through **ViewData** to **View** as given below.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                  |
| [ [public]{style="COLOR: blue"}[ActionResult]{style="COLOR: #2b91af"} ClientSideEvents()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                  |
| [ {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                  |
| [  [MobToolbarModel]{style="COLOR: #2b91af"} model = [new]{style="COLOR: blue"}[MobToolbarModel]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                                                                  |
| [  {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                  |
| [   ClientSideEvents = [new]{style="COLOR: blue"}[ToolbarEvents]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                  |
| [   {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                  |
| [     ClientSideOnClick = [\"onClick\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                  |
| [     ClientSideOnCreate = [\"onCreate\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                  |
| [   },]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                  |
| [   Items = [new]{style="COLOR: blue"}[List]{style="COLOR: #2b91af"}\<[ToolbarItem]{style="COLOR: #2b91af"}\>()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                                                                  |
| [   {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                  |
| [     [new]{style="COLOR: blue"}[ToolbarItem]{style="COLOR: #2b91af"}() { Value=[\"New\"]{style="COLOR: #a31515"}, Text=[\"New\"]{style="COLOR: #a31515"}, ImageUrl=[\"\~/Content/Toolbar/Images/new.png\"]{style="COLOR: #a31515"}},]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                  |
| [     [new]{style="COLOR: blue"}[ToolbarItem]{style="COLOR: #2b91af"}() { Value=[\"Open\"]{style="COLOR: #a31515"}, Text=[\"Open\"]{style="COLOR: #a31515"}, ImageUrl=[\"\~/Content/Toolbar/Images/open.png\"]{style="COLOR: #a31515"}},]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                  |
| [     [new]{style="COLOR: blue"}[ToolbarItem]{style="COLOR: #2b91af"}() { Value=[\"Save\"]{style="COLOR: #a31515"}, Text=[\"Save\"]{style="COLOR: #a31515"}, ImageUrl=[\"\~/Content/Toolbar/Images/save.png\"]{style="COLOR: #a31515"}},]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                  |
| [     [new]{style="COLOR: blue"}[ToolbarItem]{style="COLOR: #2b91af"}() { Value=[\"Print\"]{style="COLOR: #a31515"}, Text=[\"Print\"]{style="COLOR: #a31515"}, ImageUrl=[\"\~/Content/Toolbar/Images/print.png\"]{style="COLOR: #a31515"}},]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                  |
| [     [new]{style="COLOR: blue"}[ToolbarItem]{style="COLOR: #2b91af"}() { IsSeparator=[true]{style="COLOR: blue"} },]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                  |
| [     [new]{style="COLOR: blue"}[ToolbarItem]{style="COLOR: #2b91af"}() { Value=[\"Cut\"]{style="COLOR: #a31515"}, Text=[\"Cut\"]{style="COLOR: #a31515"}, ImageUrl=[\"\~/Content/Toolbar/Images/Cut.png\"]{style="COLOR: #a31515"}}]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                  |
| [   }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                  |
| [  };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                  |
| [  ViewData\[[\"[EventsToolbar]{#OLE_LINK1}\"]{style="COLOR: #a31515"}\] = model;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                  |
| [  [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                  |
| [ }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   In **View**, invoke the Toolbar helper with the ViewData key as the first argument.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                      |
| [ \<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.MobSyncfusion().Toolbar([\"EventsToolbar\"]{style="COLOR: #a31515"})[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"} []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                    |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                |
|                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                         |
|                                                                                                                    |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} []{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                    |
| [   Html.MobSyncfusion().Toolbar([\"EventsToolbar\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                    |
| [   .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                    |
| [ [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} **[]{style="FONT-FAMILY: 'Courier New'"}**  |
+--------------------------------------------------------------------------------------------------------------------+

 

3.   Define the call back methods in the script to handle the specified events.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**  

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                  |
|                                                                                                                                                                           |
| [    [\<]{style="COLOR: blue"}[script]{style="COLOR: maroon"}[type]{style="COLOR: red"}[=\"text/javascript\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| [        [function]{style="COLOR: blue"} onCreate(inst) {]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                           |
| [            [//inst - Toolbar object]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| [        [function]{style="COLOR: blue"} onClick(inst, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                           |
| [            [//inst - instance of Toolbar object]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                           |
| [            [//args :    args.element   - current Toolbar item ]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                           |
| [            [//          args.value            - Toolbar id]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                           |
| [            [//          args.text          - text of the current Toolbar item ]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                           |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| [    [\</]{style="COLOR: blue"}[script]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**  

4.   Run the application.

 

[]{#related-topics}
:::

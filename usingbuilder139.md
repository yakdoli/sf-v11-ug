::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Builder {#using-builder style="tab-stops: 0pt"}

The following steps explain the appearance of Toolbar control using Builder.

1.   In **View**, invoke the Toolbar helper with the Control ID as first argument followed by the AutoFormat method with the desired theme as the argument.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                 |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                 |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.MobSyncfusion().Toolbar([\"ApperanceToolbar\"]{style="COLOR: #a31515"})[]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                 |
| [   .AutoFormat([MobSkins]{style="COLOR: #2b91af"}.DarkNight)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                                 |
| [   .Items(items =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                 |
| [   {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                 |
| [                   items.Add().Value([\"New\"]{style="COLOR: #a31515"}).Text([\"New\"]{style="COLOR: #a31515"}).ImageUrl([\"\~/Content/Toolbar/Images/new.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                                                                                                 |
| [                   items.Add().Value([\"Open\"]{style="COLOR: #a31515"}).Text([\"Open\"]{style="COLOR: #a31515"}).ImageUrl([\"\~/Content/Toolbar/Images/open.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                                                                                                 |
| [                   items.Add().Value([\"Save\"]{style="COLOR: #a31515"}).Text([\"Save\"]{style="COLOR: #a31515"}).ImageUrl([\"\~/Content/Toolbar/Images/save.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                                                                                                 |
| [                   items.Add().Value([\"Print\"]{style="COLOR: #a31515"}).Text([\"Print\"]{style="COLOR: #a31515"}).ImageUrl([\"\~/Content/Toolbar/Images/print.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                 |
| [items.Add().IsSeparator([true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                 |
| [                   items.Add().Value([\"Cut\"]{style="COLOR: #a31515"}).Text([\"Cut\"]{style="COLOR: #a31515"}).ImageUrl([\"\~/Content/Toolbar/Images/Cut.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                                                                                                 |
| [   })[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                 |
|                                                                                                                                                                                                                                     |
| [ [\@{]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                                                     |
| [   Html.MobSyncfusion().Toolbar([\"ApperanceToolbar\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                                                     |
| [   .AutoFormat([MobSkins]{style="COLOR: #2b91af"}.DarkNight)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                                     |
| [   .Items(items =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                     |
| [   {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                     |
| [items.Add().Value([\"New\"]{style="COLOR: #a31515"}).Text([\"New\"]{style="COLOR: #a31515"}).ImageUrl([\"\~/Content/Toolbar/Images/new.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                                                     |
| [                items.Add().Value([\"Open\"]{style="COLOR: #a31515"}).Text([\"Open\"]{style="COLOR: #a31515"}).ImageUrl([\"\~/Content/Toolbar/Images/open.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                     |
| [                items.Add().Value([\"Save\"]{style="COLOR: #a31515"}).Text([\"Save\"]{style="COLOR: #a31515"}).ImageUrl([\"\~/Content/Toolbar/Images/save.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                     |
| [                items.Add().Value([\"Print\"]{style="COLOR: #a31515"}).Text([\"Print\"]{style="COLOR: #a31515"}).ImageUrl([\"\~/Content/Toolbar/Images/print.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                     |
| [items.Add().IsSeparator([true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                                     |
| [                items.Add().Value([\"Cut\"]{style="COLOR: #a31515"}).Text([\"Cut\"]{style="COLOR: #a31515"}).ImageUrl([\"\~/Content/Toolbar/Images/Cut.png\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                                                     |
| [   })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                     |
| [   .Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

2.   Build and run the application.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}**  

[]{#related-topics}
:::

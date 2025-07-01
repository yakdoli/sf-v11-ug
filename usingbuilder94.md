::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Builder {#using-builder style="tab-stops: 0pt"}

The following steps explain how to implement an item type for the listbox control:

1.   In **View**, invoke the Listbox Helper with the control ID as the first argument and configure the ListBox item with the specified item type, using the **ItemType()**.

[]{style="FONT-FAMILY: 'Courier New'"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                       |
| [    ]{style="FONT-FAMILY: 'Courier New'"} [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [ Html.MobSyncfusion().ListBox([\"list\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                       |
| [           .Items(items =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                       |
| [           {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                       |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [                  .Text([\"A\"]{style="COLOR: #a31515"}).**ItemType([ItemType]{style="COLOR: #2b91af"}.Divider);**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                                                                       |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [                   .Text([\"Android\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                                       |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [                  .Text([\"E\"]{style="COLOR: #a31515"}).**ItemType([ItemType]{style="COLOR: #2b91af"}.Divider);**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                                                                       |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [                  .Text([\"Eclipse\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                       |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [                  .Text([\"L\"]{style="COLOR: #a31515"}).**ItemType([ItemType]{style="COLOR: #2b91af"}.Divider);**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                                                                       |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [                  .Text([\"Linux\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                       |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [                  .Text([\"S\"]{style="COLOR: #a31515"}).**ItemType([ItemType]{style="COLOR: #2b91af"}.Divider);**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                                                                       |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [                   .Text([\"Solaris\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                                       |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [                  .Text([\"U\"]{style="COLOR: #a31515"}).**ItemType([ItemType]{style="COLOR: #2b91af"}.Divider);**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                                                                       |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [                   .Text([\"Ubuntu\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                       |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [                   .Text([\"Unix\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                       |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [                  .Text([\"W\"]{style="COLOR: #a31515"}).**ItemType([ItemType]{style="COLOR: #2b91af"}.Divider);**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                                                                       |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [                   .Text([\"Windows\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                                       |
| [           })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                       |
| [     ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                       |
| [    [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                      |
|                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                               |
|                                                                                                                                                          |
| [    [\@{]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                          |
| [        ]{style="FONT-FAMILY: 'Courier New'"} [Html.MobSyncfusion().ListBox([\"list\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                          |
| [           .Items(items =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                          |
| [           {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                          |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                          |
| [                  .Text([\"A\"]{style="COLOR: #a31515"}).**ItemType([ItemType]{style="COLOR: #2b91af"}.Divider);**]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                          |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                          |
| [                   .Text([\"Android\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                          |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                          |
| [                  .Text([\"E\"]{style="COLOR: #a31515"}).**ItemType([ItemType]{style="COLOR: #2b91af"}.Divider);**]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                          |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                          |
| [                  .Text([\"Eclipse\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                          |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                          |
| [                  .Text([\"L\"]{style="COLOR: #a31515"}).**ItemType([ItemType]{style="COLOR: #2b91af"}.Divider);**]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                          |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                          |
| [                  .Text([\"Linux\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                          |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                          |
| [                  .Text([\"S\"]{style="COLOR: #a31515"}).**ItemType([ItemType]{style="COLOR: #2b91af"}.Divider);**]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                          |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                          |
| [                   .Text([\"Solaris\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                          |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                          |
| [                  .Text([\"U\"]{style="COLOR: #a31515"}).**ItemType([ItemType]{style="COLOR: #2b91af"}.Divider);**]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                          |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                          |
| [                   .Text([\"Ubuntu\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                          |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                          |
| [                   .Text([\"Unix\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                          |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                          |
| [                  .Text([\"W\"]{style="COLOR: #a31515"}).**ItemType([ItemType]{style="COLOR: #2b91af"}.Divider);**]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                          |
| [               items.Add()]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                          |
| [                   .Text([\"Windows\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                          |
| [           })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                          |
| [.Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                          |
| [    [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
+----------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

2.   Build and run the application.

 

[ ![Description: C:\\Users\\krishnarajd\\Desktop\\div.png](ImagesExt/image103_134.jpg){border="0"} ]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

Figure 62: Listbox - Divider[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

 

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}**  

[]{#related-topics}
:::

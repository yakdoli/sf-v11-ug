::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Properties Model {#using-properties-model style="tab-stops: 0pt"}

The following steps explain the addition of animations to the Listbox using the Properties model;

1.   In the **Controller**, create an instance of **MobListboxModel**, add the ListItemCollection, configure the list item with the specified item type using the ItemType property and pass the instance through **View Specific Data** to **View** as given below:**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**

*[[ []{style="TEXT-DECORATION: none"} ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}]{.underline}*  

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}**                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                      |
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                      |
| [        ]{style="FONT-FAMILY: 'Courier New'"} [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [ [ActionResult]{style="COLOR: #2b91af"} ListBox()]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                                                                      |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                      |
| [            [MobListBoxModel]{style="COLOR: #2b91af"} list = [new]{style="COLOR: blue"}[MobListBoxModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                                                      |
| [            list.ListStyle = [ListStyle]{style="COLOR: #2b91af"}.Numbered;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                                                      |
| [            list.ListItemStyle = [ListItemStyle]{style="COLOR: #2b91af"}.Option;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection = [new]{style="COLOR: blue"}[List]{style="COLOR: #2b91af"}\<[ListBoxItem]{style="COLOR: #2b91af"}\>();]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"A\"]{style="COLOR: #a31515"}, **ItemType= [ItemType]{style="COLOR: #2b91af"}.Divider** });]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                                                      |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                      |
| [                Text = [\"Android\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                      |
| [                Items = [new]{style="COLOR: blue"}[List]{style="COLOR: #2b91af"}\<[ListBoxItem]{style="COLOR: #2b91af"}\>()]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                                                                      |
| [                {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                      |
| [                    [new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}(){ Text=[\"Android 1.0\"]{style="COLOR: #a31515"}},]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                                                                      |
| [                    [new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}(){ Text=[\"Android 2.0\"]{style="COLOR: #a31515"}}]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                                                                      |
| [                }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                      |
| [            });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"E\"]{style="COLOR: #a31515"}, **ItemType = [ItemType]{style="COLOR: #2b91af"}.Divider** });]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Eclipse\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"L\"]{style="COLOR: #a31515"}, **ItemType = [ItemType]{style="COLOR: #2b91af"}.Divider** });]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Linux\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"S\"]{style="COLOR: #a31515"}, **ItemType = [ItemType]{style="COLOR: #2b91af"}.Divider** });]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Solaris\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"U\"]{style="COLOR: #a31515"}, **ItemType = [ItemType]{style="COLOR: #2b91af"}.Divider** });]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Ubuntu\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Unix\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"W\"]{style="COLOR: #a31515"}, **ItemType = [ItemType]{style="COLOR: #2b91af"}.Divider** });]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                      |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                                                      |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                      |
| [                Text = [\"Windows\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                      |
| [                Items = [new]{style="COLOR: blue"}[List]{style="COLOR: #2b91af"}\<[ListBoxItem]{style="COLOR: #2b91af"}\>()]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                                                                      |
| [                {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                      |
| [                    [new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}(){ Text=[\"Windows XP\"]{style="COLOR: #a31515"}},]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                                                                      |
| [                    [new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}(){ Text=[\"Windows Vista\"]{style="COLOR: #a31515"}},]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                                                                      |
| [                    [new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}(){ Text=[\"Windows 7\"]{style="COLOR: #a31515"}}]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                                      |
| [                }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                      |
| [            });]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                      |
| [            ViewData\[[\"list\"]{style="COLOR: #a31515"}\] = list;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                                                                      |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                      |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                               |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

2.   In View, invoke the listbox helper with the view data key as the control ID[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                             |
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                             |
| [        ]{style="FONT-FAMILY: 'Courier New'"} [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [ Html.MobSyncfusion().ListBox([\"list\"]{style="COLOR: #a31515"}) [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="BACKGROUND: yellow"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                    |
| [    [\@{]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} [Html.MobSyncfusion().ListBox([\"list\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} [.Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                         |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="BACKGROUND: yellow"} 

[]{style="BACKGROUND: yellow"} 

3.   Build and run the application.

 

[ ![Description: C:\\Users\\krishnarajd\\Desktop\\div.png](ImagesExt/image103_134.jpg){border="0"} ]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

Figure 63: Listbox - Divider[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

 

[]{#related-topics}
:::

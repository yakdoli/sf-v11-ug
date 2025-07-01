::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Properties Model {#using-properties-model style="tab-stops: 0pt"}

The following steps explain how to set the styles for the Listbox control:

1.   In the **Controller**, create an instance of **MobListboxModel**, define the ListStyle and the ListItemStyle and pass the instance through **View Specific Data** to **View** as given below.**

*[[ []{style="TEXT-DECORATION: none"} ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}]{.underline}*  

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                        |
|                                                                                                                                                                                                   |
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                          |
|                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                        |
|                                                                                                                                                                                                   |
| [        ]{style="FONT-FAMILY: 'Courier New'"} [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [ [ActionResult]{style="COLOR: #2b91af"} ListBox()]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                   |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                   |
| [            [MobListBoxModel]{style="COLOR: #2b91af"} list = [new]{style="COLOR: blue"}[MobListBoxModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                   |
| [            **list.ListStyle = [ListStyle]{style="COLOR: #2b91af"}.Numbered;**]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                   |
| **[            list.ListItemStyle = [ListItemStyle]{style="COLOR: #2b91af"}.Option;]{style="FONT-FAMILY: 'Courier New'"}**                                                                        |
|                                                                                                                                                                                                   |
| [            list.ItemsCollection = [new]{style="COLOR: blue"}[List]{style="COLOR: #2b91af"}\<[ListBoxItem]{style="COLOR: #2b91af"}\>();]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                   |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Windows 7\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Linux\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                   |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Ubuntu\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                   |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Solaris\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                   |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Android\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                   |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Eclipse\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                   |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Unix\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                   |
| [            ViewData\[[\"list\"]{style="COLOR: #a31515"}\] = list;]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                   |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                   |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

2.   In View, invoke the listbox helper with the view data key as the control ID[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                             |
| [        ]{style="FONT-FAMILY: 'Courier New'"} [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [ Html.MobSyncfusion().ListBox([\"list\"]{style="COLOR: #a31515"}) [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                      |
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

3.   Build and run the application.

The output is displayed in the following screenshot:

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[ ![Description: C:\\Users\\krishnarajd\\Desktop\\lsty.png](ImagesExt/image103_129.jpg){border="0"} ]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

Figure6: Numbered List[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

 

 

[]{#related-topics}
:::

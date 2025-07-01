::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Properties Model {#using-properties-model style="tab-stops: 0pt"}

The following steps explain the addition of a Listbox to an application using the Properties model.

1.   In the Controller, create an instance of the **MobListboxModel**, add the list items, define the properties and pass the instance through **View Specific Data** to **View** as given below.**

*[[ []{style="TEXT-DECORATION: none"} ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}]{.underline}*  

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
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
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Eclipse\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                   |
| [            list.ItemsCollection.Add([new]{style="COLOR: blue"}[ListBoxItem]{style="COLOR: #2b91af"}() { Text = [\"Unix\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                   |
| [            ViewData\[[\"lbCore\"]{style="COLOR: #a31515"}\] = list;]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                   |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                   |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

2.   In View, invoke the listbox helper with the view data key as the control ID[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                           |
| [    ]{style="FONT-FAMILY: 'Courier New'"} [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [ Html.MobSyncfusion().ListBox([\"lbCore\"]{style="COLOR: #a31515"}) [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                    |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="BACKGROUND: yellow"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                      |
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                      |
| [    [\@{]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} [Html.MobSyncfusion().ListBox([\"lbCore\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} [.Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                           |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="BACKGROUND: yellow"} 

3.   Build and run the application.

The output is shown in the following screenshot.

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[ ![Description: C:\\Users\\krishnarajd\\Desktop\\lb1.png](ImagesExt/image103_128.jpg){border="0"} ]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

Figure 56: Listbox

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

A sample that demonstrates a basic Listbox control can be downloaded from the following link.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[[Listbox]{.UGHyperlink}](http://files.syncfusion.com/Support/Tools_MVC/v8.3.0.20/Test_Dialog.zip) [ -- ]{.UGHyperlink} [[ASPX]{.UGHyperlink}](http://files2.syncfusion.com/Support/ToolsMobileMVC/9.4.0.62/Listbox/ASPXApplication.zip) [ Application]{.UGHyperlink}

[ []{style="TEXT-DECORATION: none"} ]{.UGHyperlink} 

[[Listbox]{.UGHyperlink}](http://files.syncfusion.com/Support/Tools_MVC/v8.3.0.20/Test_Dialog.zip) [ -- ]{.UGHyperlink} [[Razor]{.UGHyperlink}](http://files2.syncfusion.com/Support/ToolsMobileMVC/9.4.0.62/Listbox/RazorApplication.zip) [ Application]{.UGHyperlink}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[]{#related-topics}
:::

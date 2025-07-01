::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Creating MenuAdv by Using C#

Open Visual Studio.

 On the File menu, select New, and then select Project. The New Project dialog box is displayed.

 

![Description: C:\\Documents and Settings\\labuser\\My Documents\\SL tools correct image.png](../ImagesExt/image261_45.png){border="0"}

 

Figure 914:  Creating a New Silverlight Project

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

In the **New Project** dialog window, select **Silverlight Application**, in the **Name** field, type the name of the project, and then click **OK**.

 

![](../ImagesExt/image261_46.png){border="0"}

Figure 915: Creating a New Silverlight Application[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

In the **Solution Explorer**, right-click the **References** folder, and click **Add Reference**.

Add the **Syncfusion.Shared.Silverlight** assembly to the project References folder.

         

![](../ImagesExt/image261_47.png){border="0"}

Figure 916: Adding Reference to the Project

 

Add the **Syncfusion.Shared.Silverlight** reference in XAML and C#,  as shown in the following code snippets.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                             |
| [xmlns]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"clr-namespace:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                             |
| [Syncfusion.Windows.Shared;assembly=Syncfusion.Shared.Silverlight]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

 

 

 

+---------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                           |
| [using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Windows.Shared;]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------+

 

 

 

Click and open C# file and add MenuAdv to application.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                          |
| [MenuAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ menu = [new]{style="COLOR: blue"} [MenuAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                                                          |
| [LayoutRoot.Children.Add(menu);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [MenuItemAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ file = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                                          |
| [file.Header = [\"File\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [MenuItemAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ edit = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                                          |
| [edit.Header = [\"Edit\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [MenuItemAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ newfile = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                                                          |
| [newfile.Header = [\"New\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                                                                          |
| [BitmapImage]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ img1 = [new]{style="COLOR: blue"} [BitmapImage]{style="COLOR: #2b91af"}([new ]{style="COLOR: blue"}[Uri]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                          |
| [([@\"/MenuControlDemo;component/Images/NewIcon.jpg\"]{style="COLOR: #a31515"},[UriKind]{style="COLOR: #2b91af"}.Relative));]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                                                          |
| [Image]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ newImg = [new]{style="COLOR: blue"} [Image]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                                          |
| [newImg.Source = img1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                          |
| [newfile.Icon = newImg;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                          |
| [file.Items.Add(newfile);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [MenuItemAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ copyfile = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                                                                                                                                          |
| [copyfile.Header = [\"Copy\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                                          |
| [BitmapImage]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ img2 = [new]{style="COLOR: blue"} [BitmapImage]{style="COLOR: #2b91af"}([new ]{style="COLOR: blue"}[Uri]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                          |
| [([@\"/MenuControlDemo;component/Images/CopyIcon.jpg\",]{style="COLOR: #a31515"}[UriKind]{style="COLOR: #2b91af"}.Relative));]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                                                          |
| [Image]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ copyImg = [new]{style="COLOR: blue"} [Image]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                                                          |
| [copyImg.Source = img2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                          |
| [copyfile.Icon = copyImg;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                          |
| [file.Items.Add(copyfile);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [MenuItemAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ cutfile = [new]{style="COLOR: blue"} [MenuItemAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                                                          |
| [cutfile.Header = [\"Cut\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                                                                          |
| [BitmapImage]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ img3 = [new]{style="COLOR: blue"} [BitmapImage]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} [Uri]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                          |
| [([@\"/MenuControlDemo;component/Images/CutIcon.jpg\"]{style="COLOR: #a31515"}, [UriKind]{style="COLOR: #2b91af"}.Relative));]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                                                          |
| [Image]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ cutImg = [new]{style="COLOR: blue"} [Image]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                                          |
| [cutImg.Source = img3;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                          |
| [cutfile.Icon = cutImg;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                          |
| [file.Items.Add(cutfile);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [menu.Items.Add(file);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                          |
| [menu.Items.Add(edit);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                           |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

 

 

 

 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[![Description: Description: Createusingc#](../ImagesExt/image261_812.png){border="0"}]{style="COLOR: black"}[]{style="COLOR: black"}**

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

**[]{style="COLOR: black"}** 

 

 

 Figure 917: MenuAdv Created Using C#

 

[]{#related-topics}
:::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Button with menu items {#button-with-menu-items style="tab-stops: 0pt"}

The button can be rendered with sub-menu items. The following code snippets will help you to do so.

 

::: {align="center"}
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ButtonAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [ID]{style="COLOR: red"}[=\"Button1\"]{style="COLOR: blue"} [ImageUrl]{style="COLOR: red"}[=\"Img/Save16.png\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} [CustomClass]{style="COLOR: red"}[=\"buttonback\" ]{style="COLOR: blue"}[Text]{style="COLOR: red"}[=\"Save the text\"]{style="COLOR: blue"} [DisplayType]{style="COLOR: red"}[=\"ImageBeforeText\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [  \<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Items]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [     \<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ButtonAdvItem]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [Text]{style="COLOR: red"}[=\"SaveAs\"]{style="COLOR: blue"} [ImageUrl]{style="COLOR: red"}[=\"Img/Save16.png\"]{style="COLOR: blue"} [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [     [\<]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[ButtonAdvItem]{style="COLOR: #a31515"} [Text]{style="COLOR: red"}[=\"Open\"]{style="COLOR: blue"} [ImageUrl]{style="COLOR: red"}[=\"Img/Open.png\"]{style="COLOR: blue"} [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [  [\</]{style="COLOR: blue"}[Items]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ButtonAdv]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                         |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

::: {align="center"}
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| [        [ButtonAdv]{style="COLOR: #2b91af"} ButtonAdvance = [new]{style="COLOR: blue"} [ButtonAdv]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                           |
| [        ButtonAdvance.ID = [\"Button2\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                           |
| [        ButtonAdvance.ImageUrl = [\"Img/Save16.png\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                           |
| [        ButtonAdvance.CustomClass = [\"buttonback\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                           |
| [        ButtonAdvance.DisplayType = Syncfusion.Web.UI.WebControls.Shared.[DisplayType]{style="COLOR: #2b91af"}.ImageBeforeText;]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                           |
| [        ButtonAdvance.Text = [\"Save\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| [        [ButtonAdvItem]{style="COLOR: #2b91af"} ButtonItem = [new]{style="COLOR: blue"} [ButtonAdvItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                           |
| [        ButtonItem.Text = [\"Save As\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                           |
| [        ButtonItem.ImageUrl = [\"Img/Save16.png\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                           |
| [        ButtonAdvance.Items.Add(ButtonItem);]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| [        [ButtonAdvItem]{style="COLOR: #2b91af"} ButtonItem1 = [new]{style="COLOR: blue"} [ButtonAdvItem]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                           |
| [        ButtonItem1.Text = [\"Open\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                           |
| [        ButtonItem1.ImageUrl = [\"Img/Open.png\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                           |
| [        ButtonAdvance.Items.Add(ButtonItem1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                           |
| [        form1.Controls.Add(ButtonAdvance);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

 

 

::: {align="center"}
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[VB\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ButtonAdvance [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} ButtonAdv]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ButtonItem [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} ButtonAdvItem]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ButtonItem1 [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} ButtonAdvItem]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                             |
| [ButtonAdvance.ID = [\"Button2\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                             |
| [ButtonAdvance.ImageUrl = [\"Img/Save16.png\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                             |
| [ButtonAdvance.CustomClass = [\"buttonback\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                             |
| [ButtonAdvance.Text = [\"Save\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                             |
| [ButtonAdvance.DisplayType = Syncfusion.Web.UI.WebControls.Shared.DisplayType.ImageBeforeText]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                             |
| [ButtonItem.Text = [\"Save As\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                             |
| [ButtonItem.ImageUrl = [\"Img/Save16.png\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}                                                                                                                      |
|                                                                                                                                                                             |
| [ButtonItem1.Text = [\"Open\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                             |
| [ButtonItem1.ImageUrl = [\"Img/Open.png\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}                                                                                                                      |
|                                                                                                                                                                             |
| [ButtonAdvance.Items.Add(ButtonItem)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                             |
| [ButtonAdvance.Items.Add(ButtonItem1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.Controls.Add(ButtonAdvance)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

Build and run the application to see the following output generated.

 

![Description: C:\\Documents and Settings\\vigneshtr\\Desktop\\UGimage\\menu.PNG](ImagesExt/image72_238.png){border="0"}

Figure 159: Button with sub-menu items

 

[]{#related-topics}
::::::

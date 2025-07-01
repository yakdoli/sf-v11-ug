::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to dynamically create a Form and add it to a Tab {#how-to-dynamically-create-a-form-and-add-it-to-a-tab style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

[]{style="COLOR: #15428b"} 

Here is a code sample which demonstrates how you could dynamically create a Form and add that form to a new Tab.

[           ]{style="COLOR: #15428b"}

+--------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                 |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [//Form2 is the dynamically created form in your project that needs to be added to a Tab.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}     |
|                                                                                                                                                  |
| [//Create the form and set it's TopLevel property to false to enable setting it's parent.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}     |
|                                                                                                                                                  |
| [Form2 frm2 = [new]{style="COLOR: blue"} Form2();]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                  |
| [frm2.TopLevel = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                  |
| [//Create the new tab which will display Form2TabPageAdv newtab = new TabPageExt(\"FORM_2\");]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                  |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.tabControlAdv1.Controls.Add(newtab);]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                  |
| [//Set the parent of Form2 to be the new tab and display the form in the newly created tab.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}   |
|                                                                                                                                                  |
| [frm2.Parent = newtab;]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                  |
| [frm2.Visible = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                  |
| [frm2.Dock = [DockStyle]{style="COLOR: teal"}.Fill;]{style="FONT-FAMILY: 'Courier New'"}                                                         |
+--------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                  |
|                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                       |
| [\'Form2 is the dynamically created form in your project that needs to be added to a Tab.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                          |
|                                                                                                                                                                                                                       |
| [\'Create the form and set it's TopLevel property to false to enable setting it's parent.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                          |
|                                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ frm2 [As]{style="COLOR: blue"} Form2 = [New]{style="COLOR: blue"} Form2()]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                       |
| [frm2.TopLevel = [False]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                       |
| [\'Create the new tab which will display Form2.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                    |
|                                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Newtab [As]{style="COLOR: blue"} TabPageAdv = [New]{style="COLOR: blue"} TabPageExt([\"FORM_2\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                       |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.tabControlAdv1.Controls.Add(Newtab) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                                       |
| [\'Set the parent of Form2 parent to be the new tab and display the form in the newly created tab.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                 |
|                                                                                                                                                                                                                       |
| [frm2.Parent = Newtab]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                                       |
| [frm2.Visible = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                       |
| [frm2.Dock = DockStyle.Fill]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#p893} 

[]{#related-topics}
:::

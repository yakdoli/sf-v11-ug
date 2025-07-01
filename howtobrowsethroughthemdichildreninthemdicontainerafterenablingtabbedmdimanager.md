::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to browse through the MDIChildren in the MDIContainer after enabling TabbedMDIManager {#how-to-browse-through-the-mdichildren-in-the-mdicontainer-after-enabling-tabbedmdimanager style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

[]{style="COLOR: #15428b"} 

You should not use the MDIContainer form's MDIChildren property to browse through the MDIChildren. This is because the TabbedMDI framework introduces some additional MDIChildren into your MDIContainer that are not part of your application logic.

 

You should instead use the TabbedMDIManager\'s **MDIChildren** property to get a list of the MDIChildren, as follows:

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                      |
|                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                       |
| [// In your MDIContainer Form.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                     |
|                                                                                                                                                                                                                       |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} ParseMDIChildren()]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                                       |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                       |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ children = [String]{style="COLOR: teal"}.Empty;]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                                       |
| [foreach]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[([Form]{style="COLOR: teal"} form [in]{style="COLOR: blue"} [this]{style="COLOR: blue"}.tabbedMDIManager.MdiChildren)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                       |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                       |
| [children += form.Text + [\"\\r\\n\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                                                       |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                       |
| [MessageBox]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Show(children); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                       |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]\                                                                                                                                                                                                 |
| ]{style="FONT-FAMILY: 'Courier New'"}**[\                                                                                                                                                                      |
| [\' In your MDIContainer Form.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} ParseMDIChildren()]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ children [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = [String]{style="COLOR: blue"}.Empty]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ form [As]{style="COLOR: blue"} Form]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Each]{style="COLOR: blue"} Form [In]{style="COLOR: blue"} [Me]{style="COLOR: blue"}.tabbedMDIManager.MdiChildren]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                |
| [children += Form.Text + [\"\\r\\n\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                        |
|                                                                                                                                                                                                                |
| [MessageBox.Show(children)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                                                |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#p934} 

[]{#related-topics}
:::

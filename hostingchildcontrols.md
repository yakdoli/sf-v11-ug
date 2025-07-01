::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Hosting Child Controls[]{#p24} {#hosting-child-controls style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

Child controls can be easily hosted by the CommandBar through designer as well as through code. This can be done by selecting the client controls from the toolbox and dropping it onto the particular CommandBar. The control will be resized to fit the CommandBar\'s client bounds.

 

A CommandBar can host a single control / multiple controls. This can be done as follows.

 

Single Control

[]{style="COLOR: #15428b"} 

You can drag-and-drop the single client control onto the CommandBar.

**[]{style="COLOR: #15428b"}** 

Multiple Controls

[]{style="COLOR: #15428b"} 

To accommodate multiple controls, place the controls within a Panel control and set it to be the CommandBar\'s client.

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                              |
|                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                        |
|                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.commandBar1.Controls.Add([this]{style="COLOR: blue"}.panel1);]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 8pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                     |
|                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                   |
|                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.commandBar1.Controls.Add([Me]{style="COLOR: blue"}.panel1)]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 8pt"} 

![](ImagesExt/image76_26.jpg){border="0"}

**[]{style="COLOR: #15428b"}** 

Figure 26: CommandBar Hosting Multiple Controls (Label and ComboBox)

[]{style="COLOR: #15428b"} 

The method associated with the above property is given below.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  ------------------------ -------------------------------------------------------------------------------------------
  Method                   Description
  CalcChildControlBounds   Calculates the client control bounds for the specified CommandBar size and dock position.
  ------------------------ -------------------------------------------------------------------------------------------
:::

[]{#related-topics}
::::

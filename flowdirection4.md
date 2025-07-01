::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### FlowDirection {#flowdirection style="tab-stops: 0pt"}

[]{#p141} 

The *FlowDirection* property specifies the flow direction for the control. It can be set to one of the following values:

         

[·      ]{style="FONT-FAMILY: Symbol"}LeftToRight

[·      ]{style="FONT-FAMILY: Symbol"}RightToLeft

 

The following code illustrates this:

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[NumericUpDown]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"NumericUIpDown\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ FlowDirection]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"LeftToRight\" /\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                  |
|                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                 |
| [NumericUpDown numericUpDown = [new]{style="COLOR: blue"} NumericUpDown();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                 |
| [numericUpDown.FlowDirection = EnumFlowDirection.LeftToRight;   ]{style="FONT-FAMILY: 'Courier New'"}           |
+-----------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image78_29.png){border="0"}

Figure 29: FlowDirection = \"LeftToRight\"

 

![](ImagesExt/image78_31.png){border="0"}

 

Figure 30: FlowDirection = \"RightToLeft\"

 

 

[]{#related-topics}
:::

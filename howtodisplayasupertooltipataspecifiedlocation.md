::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to display a SuperToolTip at a specified location? {#how-to-display-a-supertooltip-at-a-specified-location style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

**[]{style="COLOR: #15428b"}** 

The Show method can be used if the ToolTip is to be displayed at a specified location and for a particular time.

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                           |
| []{style="COLOR: #15428b"}                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                           |
| [Syncfusion.Windows.Forms.Tools.[SuperToolTip]{style="COLOR: teal"} s1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                                           |
| [Syncfusion.Windows.Forms.Tools.[ToolTipInfo]{style="COLOR: teal"} t1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                                                                                           |
| [s1 = [new]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.[SuperToolTip]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                                                           |
| [t1 = [new]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.[ToolTipInfo]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                                                                           |
| [t1.BackColor = System.Drawing.[Color]{style="COLOR: teal"}.Cyan;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                           |
| [t1.ForeColor = System.Drawing.[Color]{style="COLOR: teal"}.Chocolate;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                                                                                           |
| [t1.Body.Text = [\"Sample text for the SuperToolTip Body.\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                                                                           |
| [System.Drawing.[Point]{style="COLOR: teal"} pt1 = [new]{style="COLOR: blue"} System.Drawing.[Point]{style="COLOR: teal"}([this]{style="COLOR: blue"}.button1.Location.X + 20, [this]{style="COLOR: blue"}.button1.Location.Y + 30);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                           |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.s1.Show(t1, [this]{style="COLOR: blue"}.PointToScreen(pt1), 500);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                         |
| []{style="COLOR: black"}                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ s1 [As]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.SuperToolTip]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ t1 [As]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.ToolTipInfo]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                         |
| [s1 = [New]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.SuperToolTip ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                         |
| [t1 = [New]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.ToolTipInfo ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                         |
| [t1.BackColor = System.Drawing.Color.Cyan ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                         |
| [t1.ForeColor = System.Drawing.Color.Chocolate ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                         |
| [t1.Body.Text = [\"Sample text for the SuperToolTip Body.\"]{style="COLOR: maroon"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pt1 [As]{style="COLOR: blue"} System.Drawing.Point = [New]{style="COLOR: blue"} System.Drawing.Point([Me]{style="COLOR: blue"}.button1.Location.X + 20, [Me]{style="COLOR: blue"}.button1.Location.Y + 30)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                         |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.s1.Show(t1, [Me]{style="COLOR: blue"}.PointToScreen(pt1), 500)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="COLOR: #15428b"}** 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN: 9pt 0pt 9pt 18pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image76_1.jpg){border="0"} Note: A SuperToolTip can be hidden by calling the SuperToolTip.Hide() method.
:::

[]{style="COLOR: #15428b"} 

See Also

[]{style="COLOR: #15428b"} 

[[PopupToolTip Event]{.UGHyperlink}](../../../../../../../../Documents%20and%20Settings/sylviap/Desktop/Tools%20-%20Part%202.docx#_SuperToolTip_Events)[]{.UGHyperlink}

 

[]{#related-topics}
::::

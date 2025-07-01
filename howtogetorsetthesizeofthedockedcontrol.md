::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to get or set the size of the docked control? {#how-to-get-or-set-the-size-of-the-docked-control style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

The below methods lets you get or set the size of the control.

**[]{style="COLOR: #15428b"}** 

::: {align="center"}
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Methods                           | Description                                                                                                                                                                             |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| GetControlSize                    | Gets the size of the docked or the floating control, by passing the control as a parameter to this method. The parameters are,                                                          |
|                                   |                                                                                                                                                                                         |
|                                   |                                                                                                                                                                                         |
|                                   |                                                                                                                                                                                         |
|                                   | *Ctrl* - Indicates the docking window.                                                                                                                                                  |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| SetControlSize                    | Sets the new size (width, Height) for the docked or the floating control, by passing the control as a parameter to this method. The default value of size is Empty. The parameters are, |
|                                   |                                                                                                                                                                                         |
|                                   |                                                                                                                                                                                         |
|                                   |                                                                                                                                                                                         |
|                                   | *Ctrl[ ]{style="FONT-FAMILY: 'Segoe UI','sans-serif'"}*- Indicates the docking window.                                                                                                  |
|                                   |                                                                                                                                                                                         |
|                                   | *Size* - Specifies the new size for the control.                                                                                                                                        |
+-----------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

**[]{style="COLOR: #15428b"}** 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                              |
|                                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                    |
|                                                                                                                                                                                                                                             |
| [//Get the size of docked or Floating control using the GetControlSize method]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                            |
|                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.GetControlSize([this]{style="COLOR: blue"}.panel2);]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                             |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Write([\"Size\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.dockingManager1.GetControlSize([this]{style="COLOR: blue"}.panel2));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [//Set the size of docked or Floating control using the GetControlSize method]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                            |
|                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SetControlSize([this]{style="COLOR: blue"}.panel1, [new]{style="COLOR: blue"} [Size]{style="COLOR: teal"}(100, 50));]{style="FONT-FAMILY: 'Courier New'"}          |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                     |
|                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                        |
| [\'Get the size of docked or Floating control using the GetControlSize method]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                       |
|                                                                                                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.GetControlSize([Me]{style="COLOR: blue"}.panel2)]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                        |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Write([\"Size\"]{style="COLOR: maroon"} + [Me]{style="COLOR: blue"}.dockingManager1.GetControlSize([Me]{style="COLOR: blue"}.panel2))]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                        |
| [\'Set the size of docked or Floating control using the GetControlSize method]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                       |
|                                                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SetControlSize([this]{style="COLOR: blue"}.panel1, [new]{style="COLOR: blue"} [Size]{style="COLOR: black"}(100, 50));]{style="FONT-FAMILY: 'Courier New'"}    |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p129} 

[]{#related-topics}
::::

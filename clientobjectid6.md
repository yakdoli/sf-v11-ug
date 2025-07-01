::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### ClientObjectID {#clientobjectid style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The ClientObjectID can be used to access the control\'s object model on the client side.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

ClientObjectID can be effectively used to refer the control\'s objects when used with MasterPages and UserControls. By default, a client object id is computed by concatenating \'\_sf\' and the control\'s **ID** property. However in the case of hosting the control in a MasterPage or UserControl, the computed client object id is very unintuitive. To make things simpler you can specify a custom value on this property and access the client side object model using that value.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ---------------- ------------------------------------------------------------------------
  Property         Description
  ClientObjectID   Specifies the user defined id for accessing the object on client side.
  ---------------- ------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Here, to access the object model, the default way of invoking using \_sf is used.

[  ]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}

+---------------------------------------------------------------------------------------------------------------+
| **[\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                            |
|                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                           |
|                                                                                                               |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ShowPopUp()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                               |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                               |
| [    \_sfPopup1.ShowPopup()]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                               |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
+---------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Here, the ClientObjectID is set as popup which is used to access the client side method.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------+
| **[\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                            |
|                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                           |
|                                                                                                               |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ShowPopUp()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                               |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                               |
| [    popup.ShowPopup()]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                               |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
+---------------------------------------------------------------------------------------------------------------+

 

[]{#p577} 

[]{#related-topics}
::::

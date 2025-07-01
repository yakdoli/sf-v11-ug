::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Dragging Style {#dragging-style style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Styles can be chosen from the options provided for the dragging and docking actions. Set the respective properties to the required option to apply the styles for drag and dock actions.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black"} 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------+
| Property                          | Description                                                        |
+-----------------------------------+--------------------------------------------------------------------+
| DraggingStyle                     | Specifies the dragging style. The options included are as follows: |
|                                   |                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Original                     |
|                                   |                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}GhostCopy                    |
|                                   |                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}SolidOutline                 |
|                                   |                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}DashedOutline                |
|                                   |                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}TransparentRectangle         |
|                                   |                                                                    |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}None                         |
+-----------------------------------+--------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black"} 

The HTML view of the dragging styles property settings and the code snippets are given below:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DragDropManager]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [ID]{style="COLOR: red"}[=\"DragDropManager1\"]{style="COLOR: blue"} [ClientSideOnDragEnd]{style="COLOR: red"}[=\"OnDragEnd(this)\"]{style="COLOR: blue"}[ClientSideOnDrag]{style="COLOR: red"}[=\"OnDrag(this)\"]{style="COLOR: blue"} [ClientSideOnDragStart]{style="COLOR: red"}[=\"OnDragStart(this)\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} [AutoPostBackOnDrop]{style="COLOR: red"}[=\"True\"]{style="COLOR: blue"} [OnDrop]{style="COLOR: red"}[=\"DragDropManager1_Drop\"]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [DraggingStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"GhostCopy\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                             |
|                                                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                   |
|                                                                                                                                                                                                              |
| [DragDropManager1.DraggingStyle = Syncfusion.Web.UI.WebControls.Shared.[DragDropManager]{style="COLOR: #2b91af"}.[DraggingStyleType]{style="COLOR: #2b91af"}.GhostCopy;]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                   |
|                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                    |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ DragDropManager1.DraggingStyle = Syncfusion.Web.UI.WebControls.Shared.DragDropManager.DraggingStyleType.GhostCopy]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following output is generated.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![](ImagesExt/image72_540.png){border="0"}

***[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}*** 

Figure 411: Dragging Style set to \"GhostCopy\"

 

[]{#related-topics}
::::

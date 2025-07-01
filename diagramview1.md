::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=257eba82-820d-47ba-8f91-64dadc21eb0b){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=073cc1ff-dd2c-49f6-a3a0-b093db8a5d1d){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){.d2h_breadcrumbsNormal}
:::

## Diagram View {#diagram-view style="tab-stops: 0pt"}

[]{#p75}The Diagram View is responsible for bringing the objects and data which are added into the view through the model. In other words, it deals with the visual representation of data. Zooming and panning are done with respect to the view.

 

Table 59: Property Table[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}

+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| Property                 | Description                                                                                                | Type of the property                   | Value it accepts     | Any other dependencies/ sub properties associated |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| IsZoomEnabled            | Gets or sets a value indicating whether zoom is enabled or not.                                            | Dependency property                    | Boolean(True/False)  | No                                                |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          | Default valueis True.                                                                                      |                                        |                      |                                                   |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| IsPanEnabled             | Gets or sets a value indicating whether pan is enabled or not.                                             | Dependency property                    | Boolean(True/False)  | No                                                |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          | Default valueis False.                                                                                     |                                        |                      |                                                   |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| ZoomFactor               | Gets or sets a factor for the zoom.                                                                        | Dependency property                    | Double               | No                                                |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          | Default value is 0.2.                                                                                      |                                        |                      |                                                   |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| Bounds                   | Gets or sets the bounds value which specifies the position of the root node in case of tree layout.        | CLR [property]{style="COLOR: #1f497d"} | Thickness            | No                                                |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| IsPageEditable           | Gets or sets a value indicating whether page is enabled or not.                                            | Dependency property                    | Boolean(True/False)  | No                                                |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          | Default value is True.                                                                                     |                                        |                      |                                                   |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| ShowVerticalRulers       | Gets or sets a value indicating whether vertical rulers are displayed or not.                              | Dependency property                    | Boolean(True/False)  | No                                                |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          | Default value is True.                                                                                     |                                        |                      |                                                   |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| ShowHorizontalRulers     | Gets or sets a value indicating whether horizontal rulers are displayed or not.                            | Dependency property                    | Boolean(True/False)  | No                                                |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          | Default value is True.                                                                                     |                                        |                      |                                                   |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| ShowVerticalGridLine     | Gets or sets a value indicating whether vertical grid lines are displayed or not.                          | Dependency property                    | Boolean(True/False)  | No                                                |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          | Default value is True.                                                                                     |                                        |                      |                                                   |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| ShowHorizontalGridLine   | Gets or sets a value indicating whether horizontal grid lines are displayed or not.                        | Dependency property                    | Boolean(True/False)  | No                                                |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          | Default value is True.                                                                                     |                                        |                      |                                                   |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| PortVisibility           | Gets or sets a value indicating whether all ports of all the nodes on the page are visible or not.         | Dependency property                    | Visibility.Visible   | No                                                |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        | Visibility.Collapsed |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          | If  individual node's PortVisibility is set, then the node's PortVisibility property will take precedence. |                                        | Visibility.Hidden    |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          | Default value isVisibility.Visible                                                                         |                                        |                      |                                                   |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| Page                     | Gets or sets the DiagramPage.                                                                              | Dependency property                    | Panel                | No                                                |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          |                                                                                                            |                                        |                      |                                                   |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| NodeContextMenu          | Gets or sets context menu for the node.                                                                    | Dependency property                    | ContextMenu          | No                                                |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| LineConnectorContextMenu | Gets or sets context menu for line connector.                                                              | Dependency property                    | ContextMenu          | No                                                |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| UndoRedoEnabled          | Gets or sets a value indicating whether undo redo is enabled or not.                                       | Dependency property                    | Boolean(True/False)  | No                                                |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| IsCutEnabled             | Gets or sets a value indicating whether cut command is enabled.                                            | Dependency property                    | Boolean(True/False)  | No                                                |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          | Default value is True.                                                                                     |                                        |                      |                                                   |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| IsCopyEnabled            | Gets or sets a value copy command is enabled.                                                              | Dependency property                    | Boolean(True/False)  | No                                                |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          | Default value is True.                                                                                     |                                        |                      |                                                   |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+
| IsPasteEnabled           | Gets or sets a value indicating whether paste command is enabled.                                          | Dependency property                    | Boolean(True/False)  | No                                                |
|                          |                                                                                                            |                                        |                      |                                                   |
|                          | Default value is True.                                                                                     |                                        |                      |                                                   |
+--------------------------+------------------------------------------------------------------------------------------------------------+----------------------------------------+----------------------+---------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Window]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Class]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"WpfApplication1.Window1\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ xmlns]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [xmlns]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"http://schemas.microsoft.com/winfx/2006/xaml\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Title]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"EssentialDiagramWPF\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Height]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"400\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Width]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"600\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [xmlns]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"clr-namespace:Syncfusion.Windows.Diagram;assembly=Syncfusion.Diagram.WPF\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ xmlns]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[local]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"clr-namespace:WpfApplication1\"\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [    ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Grid]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"diagramgrid\"\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [        ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ IsSymbolPaletteEnabled]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"True\"\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [            ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramControl.View]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [                ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramView]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ \>\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramView]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [            ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramControl.View]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [        ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [    ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Grid]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Window]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                         |
|                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                               |
|                                                                                                                                                                                        |
| [DiagramControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ dc = [new]{style="COLOR: blue"} [DiagramControl]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                        |
| [dc.IsSymbolPaletteEnabled = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                        |
| [DiagramView]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ view = [new]{style="COLOR: blue"} [DiagramView]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                        |
| [view.Bounds = [new]{style="COLOR: blue"} [Thickness]{style="COLOR: #2b91af"}(0, 0, 1000, 1000);]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                        |
| [dc.View = view;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                        |
| [diagramgrid.Children.Add(dc);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                  |
|                                                                                                                                                                                                 |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                        |
|                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [DiagramControl]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
| [dc.IsSymbolPaletteEnabled = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ view [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} [DiagramView]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                 |
| [view.Bounds = [New]{style="COLOR: blue"} Thickness(0, 0, 1000, 1000)]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                 |
| [dc.View = view]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                                 |
| [diagramgrid.Children.Add(dc)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The drawing area has many properties that can be used to customize a view.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

See Also

[·      ]{style="FONT-FAMILY: Symbol"}[[Create Rulers]{.UGHyperlink}](ms-xhelp:///?Id=cb4cd63b-1c88-49b3-b489-08f41796954a) Refer **Concepts and Features -\> Diagram View -\> Create Rulers**

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}[[Specify Bounds]{.UGHyperlink}](ms-xhelp:///?Id=3a8c90d1-1f38-4064-8f29-b1c63b9f1a07) Refer **Concepts and Features -\> Diagram View -\> Specify Bounds**[]{style="FONT-SIZE: 12pt"}

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}[[Panning]{.UGHyperlink}](ms-xhelp:///?Id=9eef4133-7da3-4c17-a048-f5288af76744) Refer **Concepts and Features -\> Diagram View -\> Panning**[]{style="FONT-SIZE: 12pt"}

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}[[Zoom Commands]{.UGHyperlink}](ms-xhelp:///?Id=137e357f-58c1-463b-9fb1-c42a058a7844) Refer **Concepts and Features -\> Diagram View -\> Zoom Commands**[]{style="FONT-SIZE: 12pt"}

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}[[Create Page]{.UGHyperlink}](ms-xhelp:///?Id=5e315309-1b32-4a88-9009-1259bc026c30) Refer **Concepts and Features -\> Diagram View -\> Create Page**[]{style="FONT-SIZE: 12pt"}

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}[[Page Editing option]{.UGHyperlink}](ms-xhelp:///?Id=db1e5fa1-3628-4ec5-b358-cb4b6d4e1a06) Refer **Concepts and Features -\> Diagram View -\> Page Editing option**[]{style="FONT-SIZE: 12pt"}

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}[[Grid Lines]{.UGHyperlink}](ms-xhelp:///?Id=a7967f1f-f6da-4b09-ac65-84ba40aa705d) Refer **Concepts and Features -\> Diagram View -\> Grid Lines**[]{style="FONT-SIZE: 12pt"}

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}[[Customize the ContextMenu of Nodes and LineConnectors]{.UGHyperlink}](ms-xhelp:///?Id=137e357f-58c1-463b-9fb1-c42a058a7844) Refer **Concepts and Features -\> General -\> Customize the ContextMenu of Nodes and LineConnectors**[]{style="FONT-SIZE: 12pt"}

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}[[Undo and Redo Command.]{.UGHyperlink}](ms-xhelp:///?Id=30e03545-af78-4c8c-aadd-9753e3037808) Refer **Concepts and Features -\> Diagram View -\> Undo and Redo Command.**[]{style="FONT-SIZE: 12pt"}

[]{style="FONT-SIZE: 12pt"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Create Rulers](ms-xhelp:///?Id=073cc1ff-dd2c-49f6-a3a0-b093db8a5d1d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Specify Bounds](ms-xhelp:///?Id=aa0cd31d-6131-4397-ab13-096e0cf9678f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Panning](ms-xhelp:///?Id=40d7c311-055b-4183-b514-c12a6fefe954){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Creating Page](ms-xhelp:///?Id=2ca7d658-0ebe-4703-bf54-9ac692fa4e32){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Page editing option](ms-xhelp:///?Id=05260c89-170e-4ce0-9338-d157d8deb5aa){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Fit-to-Page Support](ms-xhelp:///?Id=db97db51-8f05-4854-86e1-a2f42f3c6b16){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Table Layout for Selected Nodes](ms-xhelp:///?Id=b9a21487-3090-42ad-81f7-3c7a3edff78c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PageMargin](ms-xhelp:///?Id=a44a1546-ebe8-49da-ad8b-4473a181a9a0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Virtualization for DiagramControl](ms-xhelp:///?Id=94dbbf59-212f-4502-98bd-8b0f15ffbb92){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Measurement Units](ms-xhelp:///?Id=648d95ce-2948-4d34-87bd-22bb5f4039ef){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Grid Lines](ms-xhelp:///?Id=1b83a311-0f25-4831-8df1-24b142ec023b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Snap to Grid](ms-xhelp:///?Id=843e8e19-4660-48f8-8fa2-ec8913a0af83){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Zoom Commands](ms-xhelp:///?Id=a645c69a-6589-4ffa-9eec-0139137852f8){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Nudge Commands](ms-xhelp:///?Id=19974bd3-9d98-46e6-b7a3-87ed0acedf0b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Clipboard Commands](ms-xhelp:///?Id=7688f7a3-d759-4397-97d6-a0829d3fc009){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Z-order Commands](ms-xhelp:///?Id=cde87d07-832c-4556-8912-bf546cb0c13e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Alignment Commands](ms-xhelp:///?Id=4bf11a8e-778b-4672-8309-82197d43c0fd){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Spacing Commands](ms-xhelp:///?Id=5a76490d-f338-42d2-9d3d-82a57d23b682){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Delete Command](ms-xhelp:///?Id=f544b85d-f8b2-4cf3-91c2-a64d8686d8b2){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Sizing Commands](ms-xhelp:///?Id=cf89cd3c-0f1d-4d04-be61-36d1ef36866e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Undo and Redo Command](ms-xhelp:///?Id=fe8bf5cb-e430-4da3-9b20-35607cd2aaf0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Printing Enhancements for Diagram Page](ms-xhelp:///?Id=eebfc06c-5e1c-48c3-a4bb-328da4d5b506){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Drawing Tools](ms-xhelp:///?Id=d1c34d98-f9d4-4922-a37a-0d18566562c1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Export diagram in image format](ms-xhelp:///?Id=e9afdf82-2747-471d-bd99-dc8cc36ade0d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Export to Clipboard](ms-xhelp:///?Id=ac0a9231-49bd-41d7-8c09-fd7afaca6722){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SizeToContent](ms-xhelp:///?Id=04456f03-972f-4987-a719-84108a3863cd){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Touch Support](ms-xhelp:///?Id=658d62fd-5635-4571-9c60-2259c3e8b2f1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Overview Control](ms-xhelp:///?Id=67d53637-edad-4baf-a8ca-47a6422d31b2){style="TEXT-DECORATION: none"}
::::

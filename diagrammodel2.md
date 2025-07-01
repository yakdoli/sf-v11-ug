::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=6483aa7a-cb65-41e1-ac59-237a6766e2f8){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=b2b659fa-334b-440a-aff9-3fef9a48744c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){.d2h_breadcrumbsNormal}
:::

## Diagram Model {#diagram-model style="tab-stops: 0pt"}

[]{#p66}A model represents data for an application and contains the logic for adding, accessing, and manipulating the data. Nodes and connectors are added to the Diagram control using the **Model** property. A predefined layout can be applied using the **LayoutType** property of the DiagramModel. The position of the nodes can be manually specified.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

See Also

[·      ]{style="FONT-FAMILY: Symbol"}[[Bind data to Diagram Control]{.UGHyperlink}](ms-xhelp:///?Id=1ad21bbe-ae0d-40c5-ad8a-8d61c68c5cfe) Refer Concepts and Features -\> Diagram Model -\> Bind data to Diagram Control

[·      ]{style="FONT-FAMILY: Symbol"}[[Tree Spacing]{.UGHyperlink}](ms-xhelp:///?Id=31bf8a87-da8e-44a0-89a3-44d220744708) Refer Concepts and Features -\> Diagram Model -\> Tree Spacing

[·      ]{style="FONT-FAMILY: Symbol"}[[Tree Orientation]{.UGHyperlink}](ms-xhelp:///?Id=4646236a-8347-492a-8d8e-13ff7dacf63c) Refer Concepts and Features -\> Diagram Model -\> Tree Orientation[]{style="COLOR: black"}

[·      ]{style="FONT-FAMILY: Symbol"}[[Table Expand Mode]{.UGHyperlink}](ms-xhelp:///?Id=cb4cd63b-1c88-49b3-b489-08f41796954a) Refer Concepts and Features -\> Diagram Model -\> Table Expand Mode

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Table 51: Methods Table[]{style="COLOR: black"}

+-------------------------+----------------------------------------+-------------+-----------------------------------------+----------------------------------------------------------------------------------------------------------+
| Name                    | Parameters                             | Return Type | Description                             | Reference Links                                                                                          |
+-------------------------+----------------------------------------+-------------+-----------------------------------------+----------------------------------------------------------------------------------------------------------+
| Nodes.Add(object)       | object,                                | Void        | To add a node into the Model.           | [[Add a Node]{style="COLOR: windowtext"}](ms-xhelp:///?Id=bafc978f-05a1-445d-8cd5-2c4f5feea59f)          |
|                         |                                        |             |                                         |                                                                                                          |
|                         | object should be of type Node          |             |                                         |                                                                                                          |
+-------------------------+----------------------------------------+-------------+-----------------------------------------+----------------------------------------------------------------------------------------------------------+
| Connections.Add(object) | object,                                | Void        | To add a line connector into the Model. | [[Add a LineConnector]{style="COLOR: windowtext"}](ms-xhelp:///?Id=480922e1-e5ef-4a21-b268-dc3ba1fa9f95) |
|                         |                                        |             |                                         |                                                                                                          |
|                         | object should be of type LineConnector |             |                                         |                                                                                                          |
+-------------------------+----------------------------------------+-------------+-----------------------------------------+----------------------------------------------------------------------------------------------------------+
| Layers.Add(Layer)       | Layer                                  | Void        | To add a layer into the model.          | [[Add a Layer]{style="COLOR: windowtext"}](ms-xhelp:///?Id=bafc978f-05a1-445d-8cd5-2c4f5feea59f)         |
+-------------------------+----------------------------------------+-------------+-----------------------------------------+----------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Layout Spacing](ms-xhelp:///?Id=b2b659fa-334b-440a-aff9-3fef9a48744c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Pictorial Representation of Spacing Properties](ms-xhelp:///?Id=08ef656e-072c-4d03-8b49-ed5ec9ab1140){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Tree Orientation](ms-xhelp:///?Id=1f1ec7d5-2d2d-425b-967f-f948519bdde0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Clear Nodes and Connections](ms-xhelp:///?Id=afdc37a1-6c20-408e-b8f8-718076562ebe){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Bind Data to Diagram Control](ms-xhelp:///?Id=c11656c0-694c-4ee8-9d1e-a4f3e99dfe9f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Cyclic path in Hierarchical-Tree Layout](ms-xhelp:///?Id=3dfe2db8-ca0c-4aa0-bc63-40e33090d3e1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Table Expand Mode](ms-xhelp:///?Id=0391fbec-7ac7-4a5e-ae66-4e017edda60b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Row Count and Column Count](ms-xhelp:///?Id=21fbbe3a-3947-41d1-85e8-75decbe9fcd4){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Enable Table Layout with Varied Node Sizes](ms-xhelp:///?Id=257eba82-820d-47ba-8f91-64dadc21eb0b){style="TEXT-DECORATION: none"}
::::

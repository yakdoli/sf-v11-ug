::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=65ab0770-da90-4ef6-aec2-62cc65aaec75){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=ff09070f-eda8-4479-b311-71c8cee47a81){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){.d2h_breadcrumbsNormal}
:::

## Connection Port {#connection-port style="tab-stops: 0pt"}

[]{#p51}Essential Diagram WPF provides the ability to define custom ports for making connections. The **ConnectionPort** class can be used for defining custom ports on the nodes. Any number of ports can be defined on a node. By default every node has a center port.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

ConnectionPort has the following properties:

 

Table 43: Property Table[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}

+-------------+---------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------+---------------------------------------------------+
| Property    | Description                                                                                                                     | Type of the property                   | Value it accepts   | Any other dependencies/ sub properties associated |
+-------------+---------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------+---------------------------------------------------+
| Left        | Gets or sets the position of the port in the x coordinate.                                                                      | Dependency property                    | Double             | No                                                |
|             |                                                                                                                                 |                                        |                    |                                                   |
|             |                                                                                                                                 |                                        |                    |                                                   |
|             |                                                                                                                                 |                                        |                    |                                                   |
|             | Default value: 0                                                                                                                |                                        |                    |                                                   |
+-------------+---------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------+---------------------------------------------------+
| Top         | Gets or sets the position of the port in the y coordinate.                                                                      | Dependency property                    | Double             | No                                                |
|             |                                                                                                                                 |                                        |                    |                                                   |
|             |                                                                                                                                 |                                        |                    |                                                   |
|             |                                                                                                                                 |                                        |                    |                                                   |
|             | Default value: 0                                                                                                                |                                        |                    |                                                   |
+-------------+---------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------+---------------------------------------------------+
| Node        | The Node property specifies the container of the port.                                                                          | CLR [property]{style="COLOR: #1f497d"} | Node               | No                                                |
+-------------+---------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------+---------------------------------------------------+
| PortShape   | The PortShape property specifies the shape to be used for the port. Three types of shapes are provided: Arrow, Circle, Diamond. | CLR [property]{style="COLOR: #1f497d"} | PortShapes.None    | No                                                |
|             |                                                                                                                                 |                                        |                    |                                                   |
|             |                                                                                                                                 |                                        | PortShapes.Arrow   |                                                   |
|             |                                                                                                                                 |                                        |                    |                                                   |
|             | Default Value is PortShapes.Diamond                                                                                             |                                        | PortShapes.Diamond |                                                   |
|             |                                                                                                                                 |                                        |                    |                                                   |
|             |                                                                                                                                 |                                        | PortShapes.Circle  |                                                   |
+-------------+---------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------+---------------------------------------------------+
| PortStyle   | The PortStyle property provides option for the customization of the ports.                                                      | CLR [property]{style="COLOR: #1f497d"} | PortStyle          | No                                                |
+-------------+---------------------------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------+---------------------------------------------------+

 

Node properties related to Connection Ports are:

 

Table 44: Property Table[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}

+----------------+----------------------------------------------------------------------------------------+----------------------+-----------------------+---------------------------------------------------+
| Property       | Description                                                                            | Type of the property | Value it accepts      | Any other dependencies/ sub properties associated |
+----------------+----------------------------------------------------------------------------------------+----------------------+-----------------------+---------------------------------------------------+
| PortVisibility | Gets or sets a value indicating whether all the ports of  the node are visible or not. | Dependency property  | Visibility.Hidden     | No                                                |
|                |                                                                                        |                      |                       |                                                   |
|                |                                                                                        |                      | Visibility.Collapsed  |                                                   |
|                |                                                                                        |                      |                       |                                                   |
|                | Default value isVisibility.Visible                                                     |                      | Visibility.Visible    |                                                   |
+----------------+----------------------------------------------------------------------------------------+----------------------+-----------------------+---------------------------------------------------+
| AllowPortDrag  | Gets or sets a value indicating whether the ports can be dragged or not.               | Dependency property  | Boolean (true/ false) | No                                                |
|                |                                                                                        |                      |                       |                                                   |
|                |                                                                                        |                      |                       |                                                   |
|                |                                                                                        |                      |                       |                                                   |
|                | Default value is True.                                                                 |                      |                       |                                                   |
+----------------+----------------------------------------------------------------------------------------+----------------------+-----------------------+---------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

 

LineConnector properties related to Connection Port are:

 

Table 45: Property Table[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}

+--------------------+------------------------------------------------------------------------------------------------------------------------------+----------------------+------------------+---------------------------------------------------+
| Property           | Description                                                                                                                  | Type of the property | Value it accepts | Any other dependencies/ sub properties associated |
+--------------------+------------------------------------------------------------------------------------------------------------------------------+----------------------+------------------+---------------------------------------------------+
| ConnectionHeadPort | Gets or sets the head port of the connection.                                                                                | Dependency property  | ConnectionPort   | No                                                |
|                    |                                                                                                                              |                      |                  |                                                   |
|                    | While dpecifying the CoonectionHeadPort, the node containing the port should be specified as the HeadNode of the connection. |                      |                  |                                                   |
|                    |                                                                                                                              |                      |                  |                                                   |
|                    | Default value is Null.                                                                                                       |                      |                  |                                                   |
+--------------------+------------------------------------------------------------------------------------------------------------------------------+----------------------+------------------+---------------------------------------------------+
| ConnectionTailPort | Gets or sets the head port of the connection.                                                                                | Dependency property  | ConnectionPort   | No                                                |
|                    |                                                                                                                              |                      |                  |                                                   |
|                    | While dpecifying the CoonectionTailPort, the node containing the port should be specified as the TailNode of the connection. |                      |                  |                                                   |
|                    |                                                                                                                              |                      |                  |                                                   |
|                    | Default value is Null.                                                                                                       |                      |                  |                                                   |
+--------------------+------------------------------------------------------------------------------------------------------------------------------+----------------------+------------------+---------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}[[Create Connection Port]{.UGHyperlink}](ms-xhelp:///?Id=03199071-9ceb-4737-a215-dd9710638996) Refer Concepts and Features -\> Connection Port -\> Create Connection Port

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}[[PortShape]{.UGHyperlink}](ms-xhelp:///?Id=9353c214-5e24-4cc0-b751-f69e460c1088) Refer Concepts and Features -\> Connection Port -\> PortShape[]{style="FONT-SIZE: 12pt"}

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}[[PortStyle]{.UGHyperlink}](ms-xhelp:///?Id=9353c214-5e24-4cc0-b751-f69e460c1088) Refer Concepts and Features -\> Connection Port -\> PortStyle[]{style="FONT-SIZE: 12pt"}

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}[[PortVisibility]{.UGHyperlink}](ms-xhelp:///?Id=df9a5a6c-f9c2-4bb0-a5e6-a885bb7ce9a4) Refer Concepts and Features -\> Connection Port -\> PortVisibility[]{style="FONT-SIZE: 12pt"}

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}[[AllowPortDrag]{.UGHyperlink}](ms-xhelp:///?Id=9353c214-5e24-4cc0-b751-f69e460c1088) Refer Concepts and Features -\> Connection Port -\> AllowPortDrag[]{style="FONT-SIZE: 12pt"}

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 12pt"}[[Connections to Port]{.UGHyperlink}](ms-xhelp:///?Id=df9a5a6c-f9c2-4bb0-a5e6-a885bb7ce9a4) Refer Concepts and Features -\> Connection Port -\> Connections to Port[]{style="FONT-SIZE: 12pt"}

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Create Connection Port](ms-xhelp:///?Id=ff09070f-eda8-4479-b311-71c8cee47a81){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PortShape](ms-xhelp:///?Id=fdc2bbf2-d218-44e6-ade9-7e4c5d922faf){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Customize PortStyle](ms-xhelp:///?Id=a4b57dc2-8482-422a-9f9e-040177916d28){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PortVisibility](ms-xhelp:///?Id=52724efb-5180-4de6-8edf-350f32985114){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}AllowPortDrag](ms-xhelp:///?Id=60994e1c-fa1d-47e6-aec9-33915c2dc518){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Connections to Port](ms-xhelp:///?Id=a57b4fb4-fd68-47a4-8470-5dacafd9aad3){style="TEXT-DECORATION: none"}
::::

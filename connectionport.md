::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=1e27f91a-a23c-44ea-b788-d2ff60d711f9){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=20919af9-f8fb-420b-8759-2de6c8baf779){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=d592a058-dcc0-44a4-994e-e7901da8db52){.d2h_breadcrumbsNormal}
:::

## Connection Port {#connection-port style="tab-stops: 0pt"}

 

[]{#p51}[\
]{style="FONT-SIZE: 12pt"}Essential Diagram Silverlight provides the ability to define custom ports for making connections. The **ConnectionPort** class can be used for defining custom ports on the nodes. Any number of ports can be defined on a node. By default, every node has a center port.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

ConnectionPort has the following properties

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------+-------------------------------------------------------------------------------------------------------------------------------------+----------------------+--------------------+---------------------------------------------------+
| Property    | Description                                                                                                                         | Type of the property | Value it accepts   | Any other dependencies/ sub properties associated |
+-------------+-------------------------------------------------------------------------------------------------------------------------------------+----------------------+--------------------+---------------------------------------------------+
| Left        | Gets or sets the position of the port in the x coordinate.                                                                          | Dependency property  | Double             | No                                                |
|             |                                                                                                                                     |                      |                    |                                                   |
|             |                                                                                                                                     |                      |                    |                                                   |
|             |                                                                                                                                     |                      |                    |                                                   |
|             | Default value: 0                                                                                                                    |                      |                    |                                                   |
+-------------+-------------------------------------------------------------------------------------------------------------------------------------+----------------------+--------------------+---------------------------------------------------+
| Top         | Gets or sets the position of the port in the y coordinate.                                                                          | Dependency property  | Double             | No                                                |
|             |                                                                                                                                     |                      |                    |                                                   |
|             |                                                                                                                                     |                      |                    |                                                   |
|             |                                                                                                                                     |                      |                    |                                                   |
|             | Default value: 0                                                                                                                    |                      |                    |                                                   |
+-------------+-------------------------------------------------------------------------------------------------------------------------------------+----------------------+--------------------+---------------------------------------------------+
| Node        | The Node property specifies the container of the port                                                                               | CLR Property         | Node               | No                                                |
+-------------+-------------------------------------------------------------------------------------------------------------------------------------+----------------------+--------------------+---------------------------------------------------+
| PortShape   | The PortShape property specifies the shape to be used for the port. Three types of shapes are provided: Arrow, Circle, and Diamond. | CLR Property         | PortShapes.None    | No                                                |
|             |                                                                                                                                     |                      |                    |                                                   |
|             |                                                                                                                                     |                      | PortShapes.Arrow   |                                                   |
|             |                                                                                                                                     |                      |                    |                                                   |
|             | Default Value: PortShapes.Diamond                                                                                                   |                      | PortShapes.Diamond |                                                   |
|             |                                                                                                                                     |                      |                    |                                                   |
|             |                                                                                                                                     |                      | PortShapes.Circle  |                                                   |
+-------------+-------------------------------------------------------------------------------------------------------------------------------------+----------------------+--------------------+---------------------------------------------------+
| PortStyle   | The PortStyle property provides option for the customization of the ports.                                                          | CLR Property         | PortStyle          | No                                                |
+-------------+-------------------------------------------------------------------------------------------------------------------------------------+----------------------+--------------------+---------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Node properties related to Connection Ports are:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------+---------------------------------------------------------------------------------------+----------------------+-----------------------+---------------------------------------------------+
| Property       | Description                                                                           | Type of the property | Value it accepts      | Any other dependencies/ sub properties associated |
+----------------+---------------------------------------------------------------------------------------+----------------------+-----------------------+---------------------------------------------------+
| PortVisibility | Gets or sets a value indicating whether all the ports of the node are visible or not. | Dependency property  | Visibility.Hidden     | No                                                |
|                |                                                                                       |                      |                       |                                                   |
|                |                                                                                       |                      | Visibility.Collapsed  |                                                   |
|                |                                                                                       |                      |                       |                                                   |
|                | Default value: Visibility.Visible                                                     |                      | Visibility.Visible    |                                                   |
+----------------+---------------------------------------------------------------------------------------+----------------------+-----------------------+---------------------------------------------------+
| AllowPortDrag  | Gets or sets a value indicating whether the ports can be dragged or not.              | Dependency property  | Boolean (true/ false) | No                                                |
|                |                                                                                       |                      |                       |                                                   |
|                |                                                                                       |                      |                       |                                                   |
|                |                                                                                       |                      |                       |                                                   |
|                | Default value: True                                                                   |                      |                       |                                                   |
+----------------+---------------------------------------------------------------------------------------+----------------------+-----------------------+---------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

LineConnector properties related to Connection Port are:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------+------------------------------------------------------------------------------------------------------------------------------+----------------------+------------------+---------------------------------------------------+
| Property           | Description                                                                                                                  | Type of the property | Value it accepts | Any other dependencies/ sub properties associated |
+--------------------+------------------------------------------------------------------------------------------------------------------------------+----------------------+------------------+---------------------------------------------------+
| ConnectionHeadPort | Gets or sets the head port of the connection.                                                                                | Dependency property  | ConnectionPort   | No                                                |
|                    |                                                                                                                              |                      |                  |                                                   |
|                    | While specifying the CoonectionHeadPort, the node containing the port should be specified as the HeadNode of the connection. |                      |                  |                                                   |
|                    |                                                                                                                              |                      |                  |                                                   |
|                    | Default value: Null                                                                                                          |                      |                  |                                                   |
+--------------------+------------------------------------------------------------------------------------------------------------------------------+----------------------+------------------+---------------------------------------------------+
| ConnectionTailPort | Gets or sets the head port of the connection.                                                                                | Dependency property  | ConnectionPort   | No                                                |
|                    |                                                                                                                              |                      |                  |                                                   |
|                    | While specifying the CoonectionTailPort, the node containing the port should be specified as the TailNode of the connection. |                      |                  |                                                   |
|                    |                                                                                                                              |                      |                  |                                                   |
|                    | Default value: Null                                                                                                          |                      |                  |                                                   |
+--------------------+------------------------------------------------------------------------------------------------------------------------------+----------------------+------------------+---------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[Create Connection Port]{.UGHyperlink}[]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[PortShape]{.UGHyperlink}[]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[PortStyle]{.UGHyperlink}[]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[PortVisibility]{.UGHyperlink}[]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[AllowPortDrag]{.UGHyperlink}[]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[Connections to Port]{.UGHyperlink}[]{.UGHyperlink}

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Creating Connection Port](ms-xhelp:///?Id=20919af9-f8fb-420b-8759-2de6c8baf779){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PortShape](ms-xhelp:///?Id=ad005dad-4928-496c-b68c-0a1a9feb6605){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Customizing PortStyle](ms-xhelp:///?Id=baa3d9bf-75ab-4ef6-834c-9ac59ca94eab){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PortVisibility](ms-xhelp:///?Id=e9c34fef-0655-4550-b888-c579c9382f97){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}AllowPortDrag](ms-xhelp:///?Id=05453b6a-35c7-4e9f-8b8c-fa2230dc4b6c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Connections to Port](ms-xhelp:///?Id=6f4a0e5e-48dc-4dc3-87e7-705426cf4ec2){style="TEXT-DECORATION: none"}
::::

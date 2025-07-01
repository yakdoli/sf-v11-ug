::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c6c2af95-e1a7-4f02-8270-3914b3c53e2b){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){.d2h_breadcrumbsNormal}
:::

## Nodes {#nodes style="tab-stops: 0pt"}

Nodes are graphical objects that can be placed on the page. It is usually used to represent visual data to be placed on the page.

[\
]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}Table 15: Property Table[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}

+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| Property                   | Description                                                                                                   | Type of the property                   | Value it Accept                | Any other dependencies/ sub properties associated |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| IsLabelEditable            | Gets or sets a value indicating whether node\'s label can be edited or not. The default value is set to true. | Dependency property                    | Boolean (true/ false)          | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| Label                      | Gets or sets the node label.                                                                                  | Dependency property                    | string                         | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelVisibility            | Gets or sets the label visibility.                                                                            | Dependency property                    | Visibility.Hidden              | No                                                |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | Visibility.Collapsed           |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | Visibility.Visible             |                                                   |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelHorizontalAlignment   | Specifies the horizontal alignment for the node label.                                                        | Dependency property                    | HorizontalAlignment.Center     | No                                                |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | HorizontalAlignment.Left       |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | HorizontalAlignment.Right      |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | HorizontalAlignment.Stretch    |                                                   |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelVerticalAlignment     | Specifies the vertical alignment for the node label.                                                          | Dependency property                    | VerticalAlignment.Bottom       | No                                                |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | VerticalAlignment.Center       |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | VerticalAlignment.Stretch      |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | VerticalAlignment.Top          |                                                   |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| HorizontalContentAlignment | Specifies the horizontal alignment for the node content.                                                      | Dependency property                    | HorizontalAlignment.Center     | No                                                |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | HorizontalAlignment.Left       |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | HorizontalAlignment.Right      |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | HorizontalAlignment.Stretch    |                                                   |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| VerticalContentAlignment   | Specifies the vertical alignment for the node content.                                                        | Dependency property                    | VerticalAlignment.Bottom       | No                                                |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | VerticalAlignment.Center       |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | VerticalAlignment.Stretch      |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | VerticalAlignment.Top          |                                                   |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelAngle                 | Gets or sets the angle of the node label.                                                                     | Dependency property                    | double                         | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| Shape                      | Specifies the shape of the node.                                                                              | Dependency property                    | Shapes                         | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| CustomPathStyle            | Gets or sets the CustomPathStyle for the node.                                                                | Dependency property                    | Style                          | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| Level                      | Gets or sets the node level.                                                                                  | Dependency property                    | int                            | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| OffsetX                    | Gets or sets the offset x value of the node.                                                                  | CLR [property]{style="COLOR: #1f497d"} | double                         | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| OffsetY                    | Gets or sets the offset y value of the node.                                                                  | CLR [property]{style="COLOR: #1f497d"} | double                         | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| Content                    | Gets or sets the node\'s content.                                                                             | Dependency property                    | object                         | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| AllowMove                  | Gets or sets a value indicating whether node can be moved or not. The default value is set to true.           | Dependency property                    | Boolean (true/ false)          | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| AllowSelect                | Gets or sets a value indicating whether node can be selected or not. The default value is set to true.        | Dependency property                    | Boolean (true/ false)          | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| AllowRotate                | Gets or sets a value indicating whether node can be rotated or not. The default value is set to true.         | Dependency property                    | Boolean (true/ false)          | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| AllowResize                | Gets or sets a value indicating whether node can be resized or not. The default value is set to true.         | Dependency property                    | Boolean (true/ false)          | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelTextTrimming          | Gets or sets the text trimming style. Default value is CharacterEllipsis.                                     | Dependency property                    | TextTrimming.CharacterEllipsis | No                                                |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | TextTrimming.None              |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | TextTrimming.WordEllipsis      |                                                   |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelForeground            | Gets or sets the foreground of the label. Default value is Black.                                             | Dependency property                    | Brush                          | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelBackground            | Gets or sets the background of the label. Default value is White.                                             | Dependency property                    | Brush                          | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelFontStyle             | Gets or sets the background of the label. Default value is White.                                             | Dependency property                    | FontStyle                      | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelFontFamily            | Gets or sets the font family of the label. Default value is Arial.                                            | Dependency property                    | FontFamily                     | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelTextAlignment         | Gets or sets the text alignment of the label. Default value is Center.                                        | Dependency property                    | TextAlignment.Center           | No                                                |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | TextAlignment.Justify          |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | TextAlignment.Left             |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | TextAlignment.Right            |                                                   |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelFontSize              | Gets or sets the font size of the label. Default value is 11.                                                 | Dependency property                    | Double                         | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelFontWeight            | Gets or sets the font weight of the label. Default value is SemiBold.                                         | Dependency property                    | FontWeight                     | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelTextWrapping          | Gets or sets the text wrapping of the label. Default value is NoWrap.                                         | Dependency property                    | TextWrapping.NoWrap            | No                                                |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | TextWrapping.Wrap              |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        | TextWrapping.WrapWithOverflow  |                                                   |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelWidth                 | Gets or sets the width of the label. Default value is node's width.                                           | Dependency property                    | Double                         | No                                                |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| IsLabelDragable            | Gets or sets the Label of Node is Dragging or Not.                                                            | Dependency  property                   | bool(true/false)               | False                                             |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+
| LabelDisplacement          | Gets or sets the different between the Original position and the Current position of the Node's Label.        | Dependency  property                   | Point                          | Point(0,0)                                        |
|                            |                                                                                                               |                                        |                                |                                                   |
|                            |                                                                                                               |                                        |                                |                                                   |
+----------------------------+---------------------------------------------------------------------------------------------------------------+----------------------------------------+--------------------------------+---------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Table 16:Methods Table[]{style="COLOR: black"}

  --------------------------- ---------------- ------------- --------------------------- -------------------------------------------------------------------------------------------------------------
  Name                        Parameters       Return Type   Description                 Reference Links
  Ports.Add(ConnectionPort)   ConnectionPort   void          To add a port to the node   [[Create Connection Port]{style="COLOR: windowtext"}](ms-xhelp:///?Id=5ff18338-2f26-4cdc-94d4-1b1ce31f9f5a)
  --------------------------- ---------------- ------------- --------------------------- -------------------------------------------------------------------------------------------------------------

[]{style="COLOR: black"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}[[Node Shapes]{.UGHyperlink}](ms-xhelp:///?Id=5ff18338-2f26-4cdc-94d4-1b1ce31f9f5a) Refer **Concepts and Features -\> Nodes-\> Node Shapes**[]{style="COLOR: black"}

[·      ]{style="FONT-FAMILY: Symbol"}[[Custom Shape]{.UGHyperlink}](ms-xhelp:///?Id=9c6b11bd-859e-44b4-b19e-b91adaf5aefa) Refer **Concepts and Features -\> Nodes -\> Node Shapes -\> Custom Shape**[]{style="COLOR: black"}

[·      ]{style="FONT-FAMILY: Symbol"}[[Node Position]{.UGHyperlink}](ms-xhelp:///?Id=48ebfdae-67dc-4fce-a339-96b687590276) Refer **Concepts and Features -\> Nodes -\> Node Position**[]{style="COLOR: black"}

[·      ]{style="FONT-FAMILY: Symbol"}[[Node Content]{.UGHyperlink}](ms-xhelp:///?Id=0ef96a0c-baf7-49cd-999a-bc387528f4f6) Refer **Concepts and Features -\> Nodes -\> Node Content**[]{style="COLOR: black"}

[·      ]{style="FONT-FAMILY: Symbol"}[[Node Label]{.UGHyperlink}](ms-xhelp:///?Id=a61c5b27-730a-4df4-890a-fe72ccbbadd8)[ ]{style="COLOR: black"}Refer **Concepts and Features -\> Nodes -\> Node Label**[]{style="COLOR: black"}

[·      ]{style="FONT-FAMILY: Symbol"}[[Customize the label of Nodes and LineConnectors]{.UGHyperlink}](ms-xhelp:///?Id=71b9a086-4aee-405a-800c-64c2810e3239) Refer **Concepts and Features -\> General -\> Customize the label of Nodes and LineConnectors**[]{style="COLOR: black"}

[·      ]{style="FONT-FAMILY: Symbol"}[[Customize the ContextMenu of Nodes and LineConnectors]{.UGHyperlink}](ms-xhelp:///?Id=000d3e1b-f8a1-4511-8d8d-43c14e5522ca) Refer **Concepts and Features -\> General -\> Customize the contextMenu of Nodes and LineConnectors**[]{style="COLOR: black"}

[]{#p20} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Create Node](ms-xhelp:///?Id=c6c2af95-e1a7-4f02-8270-3914b3c53e2b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Shapes](ms-xhelp:///?Id=37e935e8-b2a1-400c-a464-5a1941995118){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Content](ms-xhelp:///?Id=e15618ee-4749-45a8-a9e0-52762ce78dc6){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Position](ms-xhelp:///?Id=1613b997-365f-4e46-b17d-54bc3325d4d4){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Rotate](ms-xhelp:///?Id=24936f13-8f50-4912-a435-c59dccd95411){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Resize](ms-xhelp:///?Id=de56fb5a-ed83-41aa-9494-794a637f544a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Label](ms-xhelp:///?Id=f3da4d18-83a5-42bf-acd3-cefee4485d39){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Gripper](ms-xhelp:///?Id=d5afd035-6256-4ca4-a178-c43f7541aa40){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Selection](ms-xhelp:///?Id=05aa071a-8166-46ab-98f1-61d2007abf8e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Select and Move Nodes](ms-xhelp:///?Id=8e93c3f1-e314-4450-9b02-fb31ed43a0dc){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Customize the Label, Context Menu for Nodes](ms-xhelp:///?Id=2cbd194c-1962-40a9-8982-8de0c59cbdda){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Resize Handler Customization](ms-xhelp:///?Id=c329fa7e-4e39-415d-8c4a-6b0862ab3b40){style="TEXT-DECORATION: none"}
::::

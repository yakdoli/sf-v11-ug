::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d592a058-dcc0-44a4-994e-e7901da8db52){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=2a3eb437-e1d2-440b-b823-a944477ca3f2){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=d592a058-dcc0-44a4-994e-e7901da8db52){.d2h_breadcrumbsNormal}
:::

## Nodes {#nodes style="tab-stops: 0pt"}

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

Nodes are graphical objects that can be placed on the page; it is usually used to represent visual data to be placed on the page.

[\
]{style="FONT-SIZE: 9pt"}Properties

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| Property                   | Description                                                                                                       | Type of the property | Value it Accept               | Any other dependencies/ sub properties associated |
+============================+===================================================================================================================+======================+===============================+===================================================+
| IsLabelEditable            | Gets or sets a value indicating whether the node\'s label can be edited or not. The default value is set to true. | Dependency property  |  Boolean(true/ false)         | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| Label                      | Gets or sets the node label                                                                                       | Dependency property  | string                        | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| LabelVisibility            | Gets or sets the label visibility                                                                                 | Dependency property  |                               | No                                                |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | Visibility.Hidden             |                                                   |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | Visibility.Collapsed          |                                                   |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | Visibility.Visible            |                                                   |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| LabelHorizontalAlignment   | Specifies the horizontal alignment for the node label                                                             | Dependency property  | HorizontalAlignment.Center    | No                                                |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | HorizontalAlignment.Left      |                                                   |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | HorizontalAlignment.Right     |                                                   |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | HorizontalAlignment.Stretch   |                                                   |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| LabelVerticalAlignment     | Specifies the vertical alignment for the node label                                                               | Dependency property  | VerticalAlignment.Bottom      | No                                                |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | VerticalAlignment.Center      |                                                   |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | VerticalAlignment.Stretch     |                                                   |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | VerticalAlignment.Top         |                                                   |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| HorizontalContentAlignment | Specifies the horizontal alignment for the node content                                                           | Dependency property  | HorizontalAlignment.Center    | No                                                |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | HorizontalAlignment.Left      |                                                   |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | HorizontalAlignment.Right     |                                                   |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | HorizontalAlignment.Stretch   |                                                   |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| VerticalContentAlignment   | Specifies the vertical alignment for the node content                                                             | Dependency property  | VerticalAlignment.Bottom      | No                                                |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | VerticalAlignment.Center      |                                                   |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | VerticalAlignment.Stretch     |                                                   |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | VerticalAlignment.Top         |                                                   |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| LabelAngle                 | Gets or sets the angle of the node label                                                                          | Dependency property  | double                        | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| Shape                      | Specifies the shape of the node                                                                                   | Dependency property  | Shapes                        | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| CustomPathStyle            | Gets or sets the CustomPathStyle for the node                                                                     | Dependency property  | Style                         | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| Level                      | Gets or sets the node level                                                                                       | Dependency property  | int                           | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| OffsetX                    | Gets or sets the offset x value of the node                                                                       | CLR Property         | double                        | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| OffsetY                    | Gets or sets the offset y value of the node                                                                       | CLR Property         | double                        | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| Content                    | Gets or sets the node\'s content                                                                                  | Dependency property  | object                        | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| AllowMove                  | Gets or sets a value indicating whether the node can be moved or not. The default value is set to true.           | Dependency property  | Boolean (true/ false)         | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| AllowSelect                | Gets or sets a value indicating whether the node can be selected or not. The default value is set to true.        | Dependency property  | Boolean (true/ false)         | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| AllowRotate                | Gets or sets a value indicating whether the node can be rotated or not. The default value is set to true.         | Dependency property  | Boolean (true/ false)         | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| AllowResize                | Gets or sets a value indicating whether the node can be resized or not. The default value is set to true.         | Dependency property  | Boolean (true/ false)         | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| LabelForeground            | Gets or sets the foreground of the label. Default value is Black.                                                 | Dependency property  | Brush                         | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| LabelBackground            | Gets or sets the background of the label. The default value is White.                                             | Dependency property  | Brush                         | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| LabelFontStyle             | Gets or sets the background of the label. The default value is White.                                             | Dependency property  | FontStyle                     | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| LabelFontFamily            | Gets or sets the font family of the label. The default value is Arial.                                            | Dependency property  | FontFamily                    | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| LabelFontSize              | Gets or sets the font size of the label. The default value is 11.                                                 | Dependency property  | Double                        | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| LabelFontWeight            | Gets or sets the font weight of the label. The default value is SemiBold.                                         | Dependency property  | FontWeight                    | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| LabelTextWrapping          | Gets or sets the text wrapping of the label. The default value is NoWrap.                                         | Dependency property  | TextWrapping.NoWrap           | No                                                |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | TextWrapping.Wrap             |                                                   |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      | TextWrapping.WrapWithOverflow |                                                   |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| LabelWidth                 | Gets or sets the width of the label. The default value is node's width.                                           | Dependency property  | Double                        | No                                                |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| IsLabelDragable            | Gets or sets the Label of Node is Dragging or Not.                                                                | Dependency  property | bool(true/false)              | False                                             |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      |                               |                                                   |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+
| LabelDisplacement          | Gets or sets the different between the Original position and the Current position of the Node's Label.            | Dependency  property | Point                         | Point(0,0)                                        |
|                            |                                                                                                                   |                      |                               |                                                   |
|                            |                                                                                                                   |                      |                               |                                                   |
+----------------------------+-------------------------------------------------------------------------------------------------------------------+----------------------+-------------------------------+---------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[[Custom Shapes]{style="COLOR: blue"}]{.UGHyperlink}

[[[·      ]{style="COLOR: blue; TEXT-DECORATION: none; text-underline: none"}]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[AllowRotate property]{.UGHyperlink}[]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[AllowMove property]{.UGHyperlink}[]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[AllowSelect property]{.UGHyperlink}[]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[AllowResize property]{.UGHyperlink}[]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[Customize the label of Nodes and LineConnectors]{.UGHyperlink}[]{.UGHyperlink}

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Creating Node](ms-xhelp:///?Id=2a3eb437-e1d2-440b-b823-a944477ca3f2){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Shapes](ms-xhelp:///?Id=5cd6ebf2-1860-42b4-9eff-75417525c8a3){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Content](ms-xhelp:///?Id=7bdaa4e0-e5bb-41b7-944a-dfc6e9ecdbc1){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Position](ms-xhelp:///?Id=a522b0f0-ded7-4553-900f-0e60c837e66e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Rotate](ms-xhelp:///?Id=94206b0d-1e3a-4e26-9226-b9ca1498b09b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Resize](ms-xhelp:///?Id=94ec5d3e-1eb1-4c8e-b7c3-bfdffc59b290){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Label](ms-xhelp:///?Id=94b901c4-8202-482f-a473-bc5ab0377a64){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Node Selection](ms-xhelp:///?Id=025cfb9d-9520-4a5e-8c3e-b57eb9329e9f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Selecting, Moving, Deleting Nodes](ms-xhelp:///?Id=125ecd43-bcdc-49a9-abce-f98ad8ad6d31){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Customizing the Label for Nodes](ms-xhelp:///?Id=2bda2291-e02e-445c-b906-0004165eb447){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Resize Handler Customization](ms-xhelp:///?Id=bdc7b8ff-33f7-4e6f-9ec9-d64dc9cf2a26){style="TEXT-DECORATION: none"}
::::

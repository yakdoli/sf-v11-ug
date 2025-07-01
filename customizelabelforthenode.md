::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=f8b38393-9fdd-4a85-a51d-ebc5ae11fdf1){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c7ae1b55-3b10-4b74-889d-cf088e9eca27){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=04839cdf-94fc-4d24-9f6b-119fdbd7bbfb){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Nodes](ms-xhelp:///?Id=1707ce52-b3af-4e98-81bf-f419bfe59d33){.d2h_breadcrumbsNormal}
:::

### Customize Label for the Node {#customize-label-for-the-node style="tab-stops: 0pt"}

Node labels are equipped with multiline support, i.e. you can specify the labels to span multiple lines by specifying the width of the label.

Vertical and horizontal alignments of a label are specified using the **LabelVerticalAlignment** and **LabelHorizontalAlignment** properties. By default, **LabelVerticalAlignment** is set to **Middle** and **LabelHorizontalAlignment** is set to **Center**.

The labels of the nodes are customized by the following properties. The user can specify the color and other font properties of the labels. Also, several other customization properties have been added for the labels. These are tabulated below.

Properties

+--------------------------+--------------------------------------------------------------------------------------+----------------------+----------------------------+---------------------------------------------------+
| Property                 | Description                                                                          | Type of the Property | Value it Accepts           | Any Other Dependencies/ Sub-Properties Associated |
+==========================+======================================================================================+======================+============================+===================================================+
| LabelHorizontalAlignment | Specifies the horizontal alignment for the node label.                               | Server side          | HorizontalAlignment.Center | No                                                |
|                          |                                                                                      |                      |                            |                                                   |
|                          |                                                                                      |                      | HorizontalAlignment.Left   |                                                   |
|                          |                                                                                      |                      |                            |                                                   |
|                          |                                                                                      |                      | HorizontalAlignment.Right  |                                                   |
+--------------------------+--------------------------------------------------------------------------------------+----------------------+----------------------------+---------------------------------------------------+
| LabelVerticalAlignment   | Specifies the vertical alignment for the node label.                                 | Server side          | VerticalAlignment.Bottom   | No                                                |
|                          |                                                                                      |                      |                            |                                                   |
|                          |                                                                                      |                      | VerticalAlignment.Center   |                                                   |
|                          |                                                                                      |                      |                            |                                                   |
|                          |                                                                                      |                      | VerticalAlignment.Top      |                                                   |
+--------------------------+--------------------------------------------------------------------------------------+----------------------+----------------------------+---------------------------------------------------+
| LabelFontColor           | Gets or sets the color of the label. The default value is black.                     | Server side          | String                     | No                                                |
+--------------------------+--------------------------------------------------------------------------------------+----------------------+----------------------------+---------------------------------------------------+
| LabelFontFamily          | Gets or sets the font family of the label. The default value is Arial.               | Server side          | FontFamily                 | No                                                |
+--------------------------+--------------------------------------------------------------------------------------+----------------------+----------------------------+---------------------------------------------------+
| LabelFontSize            | Gets or sets the font size of the label. The default value is 11.                    | Server side          | Double                     | No                                                |
+--------------------------+--------------------------------------------------------------------------------------+----------------------+----------------------------+---------------------------------------------------+
| LabelBackground          | Gets or sets the background of the label. The default value is Transparent.          | Server side          | string                     | No                                                |
+--------------------------+--------------------------------------------------------------------------------------+----------------------+----------------------------+---------------------------------------------------+
| LabelBorderColor         | Gets or sets the border color of the label. The default value is Transparent.        | Server side          | String                     | No                                                |
+--------------------------+--------------------------------------------------------------------------------------+----------------------+----------------------------+---------------------------------------------------+
| LabelBorderWidth         | Gets or sets the border width of the label. The default value is Transparent.        | Server side          | Int                        | No                                                |
+--------------------------+--------------------------------------------------------------------------------------+----------------------+----------------------------+---------------------------------------------------+
| LabelWidth               | Gets or sets the width of the label. The default value is the node's width.          | Server side          | Double                     | No                                                |
+--------------------------+--------------------------------------------------------------------------------------+----------------------+----------------------------+---------------------------------------------------+
| LabelHeight              | Gets or sets the height of the label. The default value is the  node's label height. | Server side          | Double                     | No                                                |
+--------------------------+--------------------------------------------------------------------------------------+----------------------+----------------------------+---------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The following code snippet illustrates the implementation of the properties mentioned in the table above.

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Using Builder](ms-xhelp:///?Id=2d22b15b-3f45-406f-ba68-94b24ae01b74){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Using Properties Model](ms-xhelp:///?Id=1dd81107-09b6-4559-badb-900e56827fa4){style="TEXT-DECORATION: none"}
::::

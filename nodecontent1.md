::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=37e935e8-b2a1-400c-a464-5a1941995118){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=1613b997-365f-4e46-b17d-54bc3325d4d4){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8625d466-6e21-495a-b811-4ecee754da81){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Nodes](ms-xhelp:///?Id=7e75e8aa-0313-4d05-b2e7-d5794d3d90fd){.d2h_breadcrumbsNormal}
:::

### Node Content {#node-content style="tab-stops: 0pt"}

Node is used to visually represent any UIElements using **Content** property. You can host any content inside the node using the **Content** property. Node supports control template too, by defined template for the nodes, business object can be assigned as Node's Content and the template will look after how to present the business object.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image82_8.jpg){border="0"} Note:[ ]{style="FONT-FAMILY: 'Cambria','serif'; FONT-SIZE: 14pt"}A Node can have both Content and Shape at the same time, doing so Content will be placed over the Shape.
:::

 

Table 18: Property Table**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}**

+----------------------------+----------------------------------------------------------+----------------------+-----------------------------+-----------------------------------------------------+
| Property                   | Description                                              | Type of the property | Value it Accept             | Any other dependencies/ sub properties associated   |
+----------------------------+----------------------------------------------------------+----------------------+-----------------------------+-----------------------------------------------------+
| Content                    | Gets or sets the node\'s content.                        | Dependency property  | object                      | No[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 8pt"} |
+----------------------------+----------------------------------------------------------+----------------------+-----------------------------+-----------------------------------------------------+
| HorizontalContentAlignment | Specifies the horizontal alignment for the node content. | Dependency property  | HorizontalAlignment.Center  | No                                                  |
|                            |                                                          |                      |                             |                                                     |
|                            |                                                          |                      | HorizontalAlignment.Left    |                                                     |
|                            |                                                          |                      |                             |                                                     |
|                            |                                                          |                      | HorizontalAlignment.Right   |                                                     |
|                            |                                                          |                      |                             |                                                     |
|                            |                                                          |                      | HorizontalAlignment.Stretch |                                                     |
+----------------------------+----------------------------------------------------------+----------------------+-----------------------------+-----------------------------------------------------+
| VerticalContentAlignment   | Specifies the vertical alignment for the node content.   | Dependency property  | VerticalAlignment.Bottom    | No                                                  |
|                            |                                                          |                      |                             |                                                     |
|                            |                                                          |                      | VerticalAlignment.Center    |                                                     |
|                            |                                                          |                      |                             |                                                     |
|                            |                                                          |                      | VerticalAlignment.Stretch   |                                                     |
|                            |                                                          |                      |                             |                                                     |
|                            |                                                          |                      | VerticalAlignment.Top       |                                                     |
+----------------------------+----------------------------------------------------------+----------------------+-----------------------------+-----------------------------------------------------+

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}UIElement Content](ms-xhelp:///?Id=728df5d1-c251-4e0c-ad13-517a4e117762){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Business-Object Content with ContentTemplate](ms-xhelp:///?Id=46f755b4-ea80-4976-ae7b-f6db7f3de0e0){style="TEXT-DECORATION: none"}
:::::

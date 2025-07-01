::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=e267a5ac-ad32-40a9-bee7-30f82b790ffb){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=ba5b98de-a445-4e65-9221-81d9e8cd9217){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=696f5666-8b81-4685-9bd9-12198f06f3ad){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[UserInteraction](ms-xhelp:///?Id=0c3ea2f6-e05d-4162-9e06-d6af6a893c70){.d2h_breadcrumbsNormal}
:::

### ContextMenu {#contextmenu style="tab-stops: 0pt"}

[Essential Chart for ASP.NET MVC supports the Context Menu. The Context Menu contains the following options]{.BodyText1Char}[:]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

 

[·      ]{style="FONT-FAMILY: Symbol"}Save the chart

[·      ]{style="FONT-FAMILY: Symbol"}Print the chart

[·      ]{style="FONT-FAMILY: Symbol"}Change the legend position

[·      ]{style="FONT-FAMILY: Symbol"}Enable chart 3D effect

[·      ]{style="FONT-FAMILY: Symbol"}Change the chart type

[  ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

Properties:

::: {align="center"}
+-----------------+--------------------------------------------------------+-------------------------------------------------------+------------------------------------------------------+--------------------------------------------------+
| Property        | Description                                            | Property Type                                         | Value it Accepts                                     | Any Other Dependencies/Sub-properties Associated |
+=================+========================================================+=======================================================+======================================================+==================================================+
| ShowContextMenu | Set this property to true, to enable the context menu. | [bool]{style="COLOR: blue"}                           | [True]{style="COLOR: blue"}                          | [NA]{style="COLOR: #558ed5"}                     |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       | []{style="COLOR: blue"}                              |                                                  |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       | [false]{style="COLOR: blue"}                         |                                                  |
+-----------------+--------------------------------------------------------+-------------------------------------------------------+------------------------------------------------------+--------------------------------------------------+
| ContextMenuItem | To add ContextMenu items manually.                     | [List]{style="COLOR: #2b91af"}[]{style="COLOR: blue"} |                                                      | [NA]{style="COLOR: #558ed5"}                     |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       | [ContextMenuItem]{style="COLOR: #2b91af"}.ChartTypes |                                                  |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       | [ContextMenuItem]{style="COLOR: #2b91af"}.Enable3D   |                                                  |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       | [ContextMenuItem]{style="COLOR: #2b91af"}.Legend     |                                                  |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       | [ContextMenuItem]{style="COLOR: #2b91af"}.Print      |                                                  |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       |                                                      |                                                  |
|                 |                                                        |                                                       | [ContextMenuItem]{style="COLOR: #2b91af"}.Save       |                                                  |
+-----------------+--------------------------------------------------------+-------------------------------------------------------+------------------------------------------------------+--------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Enabling the ContextMenu](ms-xhelp:///?Id=752f37d6-24d7-4b7b-8340-a3e6df76cafc){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Customizing the ContextMenu](ms-xhelp:///?Id=c1073788-7432-42e1-a9e3-e2f13fcfe934){style="TEXT-DECORATION: none"}
:::::

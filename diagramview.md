::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=10fbc83b-0bdf-443b-b31f-d353dd6c2b9e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=7fe65cbc-845e-433d-af71-2e3a49b0aec3){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=d592a058-dcc0-44a4-994e-e7901da8db52){.d2h_breadcrumbsNormal}
:::

## Diagram View {#diagram-view style="tab-stops: 0pt"}

 

[]{#p75}The Diagram View is responsible for bringing the objects and the data, which are added into the view through the model. In other words, it deals with the visual representation of data. The following code can be used to add the view.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Properties

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------+-----------------------------------------------------------------------------------------------------------+----------------------+----------------------+---------------------------------------------------+
| Property             | Description                                                                                               | Type of the property | Value it accepts     | Any other dependencies/ sub properties associated |
+======================+===========================================================================================================+======================+======================+===================================================+
| Bounds               | Gets or sets the bounds value which specifies the position of the root node in case of tree layout.       | CLR Property         | Thickness            | No                                                |
+----------------------+-----------------------------------------------------------------------------------------------------------+----------------------+----------------------+---------------------------------------------------+
| IsPageEditable       | Gets or sets a value indicating whether the page is enabled or not.                                       | Dependency property  | Boolean(True/False)  | No                                                |
|                      |                                                                                                           |                      |                      |                                                   |
|                      | Default value: True                                                                                       |                      |                      |                                                   |
+----------------------+-----------------------------------------------------------------------------------------------------------+----------------------+----------------------+---------------------------------------------------+
| ShowVerticalRulers   | Gets or sets a value indicating whether vertical rulers are displayed or not.                             | Dependency property  | Boolean(True/False)  | No                                                |
|                      |                                                                                                           |                      |                      |                                                   |
|                      |                                                                                                           |                      |                      |                                                   |
|                      |                                                                                                           |                      |                      |                                                   |
|                      | Default value: True                                                                                       |                      |                      |                                                   |
+----------------------+-----------------------------------------------------------------------------------------------------------+----------------------+----------------------+---------------------------------------------------+
| ShowHorizontalRulers | Gets or sets a value indicating whether horizontal rulers are displayed or not.                           | Dependency property  | Boolean(True/False)  | No                                                |
|                      |                                                                                                           |                      |                      |                                                   |
|                      |                                                                                                           |                      |                      |                                                   |
|                      |                                                                                                           |                      |                      |                                                   |
|                      | Default value: True                                                                                       |                      |                      |                                                   |
+----------------------+-----------------------------------------------------------------------------------------------------------+----------------------+----------------------+---------------------------------------------------+
| PortVisibility       | Gets or sets a value indicating whether all the ports of all the nodes on the page are visible or not.    | Dependency property  | Visibility.Visible   | No                                                |
|                      |                                                                                                           |                      |                      |                                                   |
|                      |                                                                                                           |                      | Visibility.Collapsed |                                                   |
|                      |                                                                                                           |                      |                      |                                                   |
|                      | If individual node's PortVisibility is set, then the node's PortVisibility property will take precedence. |                      | Visibility.Hidden    |                                                   |
|                      |                                                                                                           |                      |                      |                                                   |
|                      |                                                                                                           |                      |                      |                                                   |
|                      |                                                                                                           |                      |                      |                                                   |
|                      | Default value: Visibility.Visible                                                                         |                      |                      |                                                   |
+----------------------+-----------------------------------------------------------------------------------------------------------+----------------------+----------------------+---------------------------------------------------+
| Page                 | Gets or sets the DiagramPage.                                                                             | Dependency property  | Panel                | No                                                |
|                      |                                                                                                           |                      |                      |                                                   |
|                      |                                                                                                           |                      |                      |                                                   |
+----------------------+-----------------------------------------------------------------------------------------------------------+----------------------+----------------------+---------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[UserControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Class]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"SilverlightApplication1.MainPage\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ xmlns]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [xmlns]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"http://schemas.microsoft.com/winfx/2006/xaml\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[  Height]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"400\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Width]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"600\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [xmlns]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"clr-namespace:Syncfusion.Windows.Diagram;assembly=Syncfusion.Diagram.Silverlight\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ xmlns]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[local]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"clr-namespace:SilverlightApplication1\"\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [    ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Grid]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"diagramgrid\"\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [        ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ IsSymbolPaletteEnabled]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"True\"\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [            ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramControl.View]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [                ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramView]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ \>\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramView]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [            ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramControl.View]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [        ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfdiagram]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DiagramControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [    ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Grid]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[UserControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                      |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

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

The drawing area has many properties that can be used to customize a view.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[Create Rulers]{.UGHyperlink}[]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[Specify Bounds]{.UGHyperlink}[]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[Create Page]{.UGHyperlink}[]{.UGHyperlink}

[[·      ]{style="FONT-FAMILY: Symbol; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}[Page Editing option]{.UGHyperlink}[]{.UGHyperlink}

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Creating Rulers](ms-xhelp:///?Id=7fe65cbc-845e-433d-af71-2e3a49b0aec3){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Specifying Bounds](ms-xhelp:///?Id=74672e8b-f615-4462-afa8-14780af07f2b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Panning](ms-xhelp:///?Id=9f4dc060-89ce-4cec-bb23-07828c10a0b4){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Creating a Page](ms-xhelp:///?Id=ee0bf144-9604-4798-af7c-28b057a80a7c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Page editing option](ms-xhelp:///?Id=e926c04d-1026-4938-bd7a-dc2fdff334de){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}PageMargin](ms-xhelp:///?Id=ecf604fa-b5ef-446c-854e-5768cd826840){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}GridLines](ms-xhelp:///?Id=dc0b3ae6-e0d0-4cdf-a589-7afa9211409f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Overview](ms-xhelp:///?Id=213839f0-fb7a-48db-a943-51208df35829){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Snap to Grid](ms-xhelp:///?Id=b46723ea-9d3f-4062-be06-6f0e91f36dc6){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Measurement Units](ms-xhelp:///?Id=e3782856-bda0-4f07-90fa-77c05d088006){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Clipboard Commands](ms-xhelp:///?Id=d2460eb9-f14d-4c07-87b2-57dc1adc8afc){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Nudge Commands](ms-xhelp:///?Id=0b602687-076c-4472-8a24-45fd16b219b3){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Z-order Commands](ms-xhelp:///?Id=5dacd6fa-5cdd-4267-afdf-800cbdb8de63){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Alignment Commands](ms-xhelp:///?Id=1a78070b-3a99-4502-8525-416962af559d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Spacing Commands](ms-xhelp:///?Id=6b0f5d77-d14a-4c26-86b0-c9caf2bc476f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Sizing Commands](ms-xhelp:///?Id=770d0b2f-bde7-4d89-8531-61a73253fa43){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Undo and Redo Commands](ms-xhelp:///?Id=b8c5c470-094d-4453-b8cf-01de159ebf57){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Printing Support for Diagram Page](ms-xhelp:///?Id=15b08410-6d71-4410-a5b6-11f4557233da){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}DrawingTools](ms-xhelp:///?Id=21702e11-4540-45d5-80d0-7569cbaade1c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Virtualization for Diagram Control](ms-xhelp:///?Id=3c508088-5bd2-4e01-abfe-fa909a27cf8c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SizeToContent](ms-xhelp:///?Id=5436ff6f-7570-4239-a8ec-3f526f0f54a2){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Support to Delete Nodes and Connectors](ms-xhelp:///?Id=cdf951a8-0f11-456c-a215-677debf46f87){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Zooming Support](ms-xhelp:///?Id=6a56827f-25ed-4447-a7ca-1ef6a5a28d85){style="TEXT-DECORATION: none"}
::::

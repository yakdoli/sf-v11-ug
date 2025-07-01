::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=00c3d576-47d2-4803-9fd5-5d6c7482afef){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=605276b2-3e40-4626-aa02-1ebbfd1171d5){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=bb4a5b35-2631-4a2a-9fa8-2159cc7204f4){.d2h_breadcrumbsNormal}
:::

## How To Detect Whether a New Symbol Or Shape Has Been Added / Removed From A Diagram {#how-to-detect-whether-a-new-symbol-or-shape-has-been-added-removed-from-a-diagram style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

You can make use of the **Diagram.Model.EventSink.NodeCollectionChanged** to detect whether a new node (symbol, shape or link) has been added/removed from a diagram. The event\'s **CollectionExEventArgs** argument provides information about the node ensuing the add / remove operation.

 

The following code snippet updates a label with information on the type of the node that is added/deleted from the diagram.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                          |
|                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                    |
|                                                                                                                                                                                                         |
| [diagram1.Model.EventSink.NodeCollectionChanged += [new]{style="COLOR: blue"} [CollectionExEventHandler]{style="COLOR: #2b91af"}(EventSink_NodeCollectionChanged);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                    |
|                                                                                                                                                                                                         |
| [//ChildrenChangeComplete Event]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                      |
|                                                                                                                                                                                                         |
| [//Update Label2 depending on whether a Shape is added or deleted from the Diagram]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                   |
|                                                                                                                                                                                                         |
| [ [private]{style="COLOR: blue"} [void]{style="COLOR: blue"} EventSink_NodeCollectionChanged([CollectionExEventArgs]{style="COLOR: #2b91af"} evtArgs)]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                         |
| [ {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                         |
| [            [Node]{style="COLOR: #2b91af"} n = evtArgs.Element [as]{style="COLOR: blue"} [Node]{style="COLOR: #2b91af"};]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                         |
| [            [//ChangeType specifies whether the Collection change is Insertion/Removal]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                         |
| [            [if]{style="COLOR: blue"} (evtArgs.ChangeType == [CollectionExChangeType]{style="COLOR: #2b91af"}.Insert)]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                                                         |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                         |
| [                [this]{style="COLOR: blue"}.label2.ForeColor = [Color]{style="COLOR: #2b91af"}.Blue;]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                         |
| [                [//Gets the Name of the inserted element]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                         |
| [                [this]{style="COLOR: blue"}.label2.Text = [\"Last Node Added : \"]{style="COLOR: #a31515"} + n.Name.ToString();]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                                                         |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                         |
| [            [else]{style="COLOR: blue"} [if]{style="COLOR: blue"} (evtArgs.ChangeType == [CollectionExChangeType]{style="COLOR: #2b91af"}.Remove)]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                                                                         |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                         |
| [                [this]{style="COLOR: blue"}.label2.ForeColor = [Color]{style="COLOR: #2b91af"}.Red;]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                         |
| [                [//Gets the Name of the removed element]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                         |
| [                [this]{style="COLOR: blue"}.label2.Text = [\"Last Node Removed : \"]{style="COLOR: #a31515"} + n.Name.ToString();]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                         |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                         |
| [ }        ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                            |
| [EventSink.NodeCollectionChanged += [new]{style="COLOR: blue"} [CollectionExEventHandler]{style="COLOR: #2b91af"}(EventSink_NodeCollectionChanged)]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.Diagram1.Model.EventSink.NodeCollectionChanged+=[New]{style="COLOR: blue"} [CollectionExEventHandler]{style="COLOR: #2b91af"}(EventSink_NodeCollectionChanged)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [ [\'ChildrenChangeComplete Event]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                            |
| [ [\'Update Label2 depending on whether a Shape is added or deleted from the Diagram]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                                                                            |
| [ [Private]{style="COLOR: blue"} [Sub]{style="COLOR: blue"} Model_ChildrenChangeComplete([ByVal]{style="COLOR: blue"} evtArgs [As]{style="COLOR: blue"} CollectionExEventArgs)]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                                                                            |
| [        [Dim]{style="COLOR: blue"} n [As]{style="COLOR: blue"} Node = [TryCast]{style="COLOR: blue"}(evtArgs.Element, Node)]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                                            |
| [        \'[ChangeType specifies whether the Collection change is Insertion/Removal]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                                                                            |
| [        [If]{style="COLOR: blue"} evtArgs.ChangeType = CollectionExChangeType.Insert [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [            [Me]{style="COLOR: blue"}.label2.ForeColor = Color.Blue]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [            \'[Gets the Name of the inserted element]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                                                            |
| [            [Me]{style="COLOR: blue"}.label2.Text = [\"Last Node Added: \"]{style="COLOR: #a31515"} + n.Name.ToString()]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                                                                            |
| [        [ElseIf]{style="COLOR: blue"} evtArgs.ChangeType = CollectionExChangeType.Remove [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                                            |
| [            [Me]{style="COLOR: blue"}.label2.ForeColor = Color.Red]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [            \'[Gets the Name of the removed element]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                                                                            |
| [            [Me]{style="COLOR: blue"}.label2.Text = [\"Last Node Removed: \"]{style="COLOR: #a31515"} + n.Name.ToString()]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                                                            |
| [        [End]{style="COLOR: blue"} [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                                                                            |
| [    [End]{style="COLOR: blue"} [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p81} 

 

[]{#related-topics}
::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Automatic Outlining {#automatic-outlining style="tab-stops: 0pt"}

 

**Outlining** can be performed by having appropriate \"lexem\", \"split\", and \"extension\" tag entries in the configuration file. Refer to the [Configuration Settings]{.UGHyperlink} topic for more information regarding the configuration file.

 

Essential Edit provides Visual Studio-like support for collapsing and expanding blocks of code through the use of Collapsers (plus-minus buttons). Sections of code which form the outlining blocks can be specified by using the configuration settings. The outlining blocks can be specified for code as well as for plain text.

 

Setting the **ShowOutliningCollapsers** property to **True**, will enable Automatic Outlining. Edit provides the following APIs to support Outlining.

 

::: {align="center"}
  ---------------------- ----------------------------------------------------------------------------------
  Edit Control Method    Description
  Collapse               Collapses all regions in currently selected area or in the current line.
  Expand                 Expands all collapsed regions in currently selected area or in the current line.
  SwitchCollapsingOn     Turns on collapse and collapse all option.
  SwitchCollapsingOff    Turns off collapse option.
  CollapseAll            Collapses all regions.
  ExpandAll              Expands all collapsed regions.
  ToggleLineCollapsing   Toggles collapse option for current line.
  ---------------------- ----------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                    |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                              |
|                                                                                                                                                                   |
| [// Enabling Automatic Outlining.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                              |
|                                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.ShowOutliningCollapsers = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                              |
|                                                                                                                                                                   |
| [// Collapses all regions in currently selected area or in the current line.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                   |
|                                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.Collapse();]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                   |
| [// Expands all collapsed regions in currently selected area or in the current line.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                           |
|                                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.Expand();]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                   |
| [// Turns on collapse and collapse all option.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                 |
|                                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.SwitchCollapsingOff();]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                   |
| [// Turns off collapse option.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                 |
|                                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.SwitchCollapsingOn();]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                   |
| [// Collapses all regions.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                     |
|                                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.CollapseAll();]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                   |
| [// Expands all collapsed regions.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                             |
|                                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.ExpandAll();]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                   |
| [// Toggles collapse option for current line.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                  |
|                                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.ToggleLineCollapsing();]{style="FONT-FAMILY: 'Courier New'"}                                |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                             |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [\' Enabling Automatic Outlining.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                           |
|                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.ShowOutliningCollapsers = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                           |
|                                                                                                                                                                |
| [\' Collapses all regions in currently selected area or in the current line.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                |
|                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.Collapse()]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [\' Expands all collapsed regions in currently selected area or in the current line.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                        |
|                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.Expand()]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [\' Turns on collapse and collapse all option.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                              |
|                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.SwitchCollapsingOff()]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [\' Turns off collapse option.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                              |
|                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.SwitchCollapsingOn()]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [\' Collapses all regions.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                  |
|                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.CollapseAll()]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [\' Expands all collapsed regions.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                          |
|                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.ExpandAll()]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                |
| [\' Toggles collapse option for current line.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                               |
|                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.ToggleLineCollapsing()]{style="FONT-FAMILY: 'Courier New'"}                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**Outlining Operations**

[]{style="COLOR: red"} 

The Edit Control supports the following events to handle the various Outlining operations.

 

::: {align="center"}
  ------------------------- ------------------------------------------------
  Edit Control Event        Description
  OutliningBeforeCollapse   Occurs before the region is about to collapse.
  OutliningBeforeExpand     Occurs before the region is about to expand.
  OutliningCollapse         Occurs when the region collapses.
  OutliningExpand           Occurs when the region expands.
  CollapsedAll              Occurs when CollapseAll method was called.
  ExpandedAll               Occurs when ExpandedAll method was called.
  CollapsingAll             Occurs when CollapseAll method is called.
  ExpandingAll              Occurs when ExpandAll method is called.
  ------------------------- ------------------------------------------------
:::

 

The above events can be canceled, and can be used to optionally cancel the Outlining Collapse and Expand operations respectively. They are discussed in detail in the Edit Control Events section.

 

The Custom Outlining Demo sample demonstrates how the outlining feature can be used on any custom file or plain text, and not necessarily on programming language code samples. This sample is available in the following location.

 

***..\\My Documents\\Syncfusion\\EssentialStudio\\Version Number\\Windows\\Edit.Windows\\Samples\\2.0\\Text Formatting\\CustomOutliningDemo***

 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Outlining Tooltip](ms-xhelp:///?Id=60bf07e8-567d-4408-86df-822707dd8db5){style="TEXT-DECORATION: none"}
:::::

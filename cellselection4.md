::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=6d0f6184-515a-4a8f-80a9-5358b139580e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=8af49356-7cd9-429a-bc57-468aa85b8967){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pivot Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4ac202a5-4d9d-4bd8-8592-31692c415d53){.d2h_breadcrumbsNormal}
:::

## Cell Selection {#cell-selection style="tab-stops: 0pt"}

The PivotGrid for Windows Forms supports  cell selection where you can select grid value cells similar to Microsoft Excel. On cell selection, an event called *PivotGridSelectionChanged* will be triggered and the *PivotGridSelectionChangedEventArgs* will return an *IEnumerable* collection of column, row and value of the corresponding selected cell.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Use Case Scenarios

Using the cell selection support, you can select the cells that can be copied to clipboard or notepad. You can perform custom operation on cell selection and also bind any control based on the selected cell values.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Adding Cell Selection

The following code snippets show how to create a PivotGrid and specify cell selection.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                |
| [// Instantiating PivotGridControl]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                                                                |
| [PivotGridControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pivotGridControl1 = [new]{style="COLOR: blue"} [PivotGridControl]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                                                                |
| [// Adding PivotRows]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                                |
| [pivotGridControl1.PivotRows.Add([new]{style="COLOR: blue"} [PivotItem]{style="COLOR: #2b91af"} { FieldHeader = [\"Product\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                                                                |
| [pivotGridControl1.PivotColumns.Add([new]{style="COLOR: blue"} [PivotItem]{style="COLOR: #2b91af"} { FieldHeader = [\"Date\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                                                                |
| [// Adding PivotColumns]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                                                                |
| [pivotGridControl1.PivotColumns.Add([new]{style="COLOR: blue"} [PivotItem]{style="COLOR: #2b91af"} { FieldHeader = [\"Country\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                                                                                |
| [pivotGridControl1.PivotColumns.Add([new]{style="COLOR: blue"} [PivotItem]{style="COLOR: #2b91af"} { FieldHeader = [\"State\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                                                                                |
| [// Adding PivotCalculations]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                                                                |
| [pivotGridControl1.PivotCalculations.Add([new]{style="COLOR: blue"} [PivotComputationInfo]{style="COLOR: #2b91af"} { FieldName=[\"Amount\"]{style="COLOR: #a31515"} , Format=[\"C\"]{style="COLOR: #a31515"}});]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                                                                                |
| [pivotGridControl1.PivotCalculations.Add([new]{style="COLOR: blue"} [PivotComputationInfo]{style="COLOR: #2b91af"} { FieldName = [\"Quantity\"]{style="COLOR: #a31515"}, Format = [\"#,##0\"]{style="COLOR: #a31515"} });]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                |
| [// Enabling cell selection]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}**[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                       |
|                                                                                                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.pivotGridControl1.AllowSelection = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #c00000"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                            |
|                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                        |
|                                                                                                                                                                                                             |
| [\' Instantiating PivotGridControl]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pivotGridControl1 [As]{style="COLOR: blue"} PivotGridControl = [New]{style="COLOR: blue"} PivotGridControl()]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                             |
| [\' Adding PivotRows]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                             |
| [pivotGridControl1.PivotRows.Add([New]{style="COLOR: blue"} PivotItem [With]{style="COLOR: blue"} {.FieldHeader = \"Product\"})]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                             |
| [pivotGridControl1.PivotColumns.Add([New]{style="COLOR: blue"} PivotItem [With]{style="COLOR: blue"} {.FieldHeader = \"Date\"})]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                             |
| [\' Adding PivotColumns]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                             |
| [pivotGridControl1.PivotColumns.Add([New]{style="COLOR: blue"} PivotItem [With]{style="COLOR: blue"} {.FieldHeader = \"Country\"})]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                                             |
| [pivotGridControl1.PivotColumns.Add([New]{style="COLOR: blue"} PivotItem [With]{style="COLOR: blue"} {.FieldHeader = \"State\"})]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                             |
| [\' Adding PivotCalculations]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                             |
| [pivotGridControl1.PivotCalculations.Add([New]{style="COLOR: blue"} PivotComputationInfo [With]{style="COLOR: blue"} {.FieldName=\"Amount\", .Format=\"C\"})]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                             |
| [pivotGridControl1.PivotCalculations.Add([New]{style="COLOR: blue"} PivotComputationInfo [With]{style="COLOR: blue"} {.FieldName = \"Quantity\", .Format = \"#,##0\"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                             |
| [\' Enabling cell selection]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.pivotGridControl1.AllowSelection = [False]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![Description: C:\\Users\\dwarageshmb\\Desktop\\Vol 4 Docs\\Images\\PivotGrid Cell Selection.png](ImagesExt/image109_15.jpg){border="0"}

Figure 13: PivotGrid Cell Selection

 

[]{#related-topics}
::::

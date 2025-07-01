::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=5ceb9fef-00ca-4795-840d-76fc3d87091c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=64c2cb3d-2548-4fe4-b0d1-0c2249ee26c8){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Calculate](ms-xhelp:///?Id=2ea52c7f-a332-43bd-9ca7-2ea0898ff54e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=91222e44-d3ca-4392-8f0f-41bd2ae3dd3f){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Inside CalcEngine](ms-xhelp:///?Id=62aefe41-8f1a-4067-a820-8a2339080e94){.d2h_breadcrumbsNormal}
:::

### Error Messages {#error-messages style="tab-stops: 0pt"}

 

The error messages that are displayed by Essential Calculate can be found in this string array in the **CalcEngine**. After a CalcEngine object has been created, you can change the text of these messages by changing the array values.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                       |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                 |
|                                                                                                                                                                                                                      |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [string]{style="COLOR: blue"}\[\] FormulaErrorStrings = [new]{style="COLOR: blue"} [string]{style="COLOR: blue"}\[\]]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                      |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                      |
| [        [\"binary operators cannot start an expression\"]{style="COLOR: maroon"},        [//0]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                      |
| [        [\"cannot parse\"]{style="COLOR: maroon"},                                       [//1]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                      |
| [        [\"bad library\"]{style="COLOR: maroon"},                                        [//2]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                      |
| [        [\"invalid char in front of\"]{style="COLOR: maroon"},                           [//3]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                      |
| [        [\"number contains 2 decimal points\"]{style="COLOR: maroon"},                   [//4]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                      |
| [        [\"expression cannot end with an operator\"]{style="COLOR: maroon"},             [//5]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                      |
| [        [\"invalid characters following an operator\"]{style="COLOR: maroon"},           [//6]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                      |
| [        [\"invalid character in number\"]{style="COLOR: maroon"},                        [//7]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                      |
| [        [\"mismatched parentheses\"]{style="COLOR: maroon"},                             [//8]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                      |
| [        [\"unknown formula name\"]{style="COLOR: maroon"},                               [//9]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                      |
| [        [\"requires a single argument\"]{style="COLOR: maroon"},                         [//10]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"requires 3 arguments\"]{style="COLOR: maroon"},                               [//11]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"invalid Math argument\"]{style="COLOR: maroon"},                              [//12]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"requires 2 arguments\"]{style="COLOR: maroon"},                               [//13]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"#NAME?\"]{style="COLOR: maroon"},                                             [//14]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"too complex\"]{style="COLOR: maroon"},                                        [//15]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"circular reference: \"]{style="COLOR: maroon"},                               [//16]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"missing formula\"]{style="COLOR: maroon"},                                    [//17]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"improper formula\"]{style="COLOR: maroon"},                                   [//18]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"invalid expression\"]{style="COLOR: maroon"},                                 [//19]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"cell empty\"]{style="COLOR: maroon"},                                         [//20]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"bad formula\"]{style="COLOR: maroon"},                                        [//21]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"empty expression\"]{style="COLOR: maroon"},                                   [//22]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"\"]{style="COLOR: maroon"},                                                   [//23]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"mismatched string quotes\"]{style="COLOR: maroon"},                           [//24]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"wrong number of arguments\"]{style="COLOR: maroon"},                          [//25]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"invalid arguments\"]{style="COLOR: maroon"},                                  [//26]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"iterations do not converge\"]{style="COLOR: maroon"},                         [//27]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                      |
| [        [\"Control named \'{0}\' is already registered\"]{style="COLOR: maroon"}           [//28]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                                                      |
| [};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::

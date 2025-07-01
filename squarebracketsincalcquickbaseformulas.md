::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=be26a731-22f1-4972-8d48-61c69bce19c1){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=84b2eac6-089a-426c-92a1-8ab6b5acbd89){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Calculate](ms-xhelp:///?Id=2ea52c7f-a332-43bd-9ca7-2ea0898ff54e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=91222e44-d3ca-4392-8f0f-41bd2ae3dd3f){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Supported Algebra](ms-xhelp:///?Id=ae3545fe-822a-47ab-a6bb-b0b88da9520a){.d2h_breadcrumbsNormal}
:::

### Square Brackets in CalcQuickBase Formulas {#square-brackets-in-calcquickbase-formulas style="tab-stops: 0pt"}

 

If you are using a **CalcQuickBase** object to add calculation support to your business object, then you must use strings as indexers on the CalcQuickBase instance to get and set values. These strings are referred to as the value\'s Name. If you need to use a Name in a formula, then you should enclose the string within brackets, \[ \]. In step three of the code below, four names A, B, C, and D are registered. Notice that the formula entered in step two uses the values from A and B by enclosing these names in brackets.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                               |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                         |
|                                                                                                                                                                                              |
| [// 1) Instantiates a CalcQuickBase object.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                               |
|                                                                                                                                                                                              |
| [calculator = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[New]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ CalcQuickBase();]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                         |
|                                                                                                                                                                                              |
| [// 2) Populate your controls.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                            |
|                                                                                                                                                                                              |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.textBoxA.Text = [\"12\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                              |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.textBoxB.Text = [\"3\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                              |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.textBoxC.Text = [\"= \[A\] + 2 \* \[B\]\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                         |
|                                                                                                                                                                                              |
| [// Must enter formula names before turning on calculations.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                              |
|                                                                                                                                                                                              |
| [// 3) Assigns formula object names.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                      |
|                                                                                                                                                                                              |
| [calculator([\"A\"]{style="COLOR: maroon"}) = [this]{style="COLOR: blue"}.textBoxA.Text;]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                              |
| [calculator([\"B\"]{style="COLOR: maroon"}) = [this]{style="COLOR: blue"}.textBoxB.Text;]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                              |
| [calculator([\"C\"]{style="COLOR: maroon"}) = [this]{style="COLOR: blue"}.textBoxC.Text;]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                              |
| [calculator([\"D\"]{style="COLOR: maroon"}) = [this]{style="COLOR: blue"}.textBoxD.Text;]{style="FONT-FAMILY: 'Courier New'"}                                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                              |
|                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                        |
|                                                                                                                                                                                             |
| [\' 1) Instantiates a CalcQuickBase object.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                              |
|                                                                                                                                                                                             |
| [calculator = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[New]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ CalcQuickBase()]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                        |
|                                                                                                                                                                                             |
| [\' 2) Populate your controls.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                           |
|                                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.textBoxA.Text = [\"12\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.textBoxB.Text = [\"3\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.textBoxC.Text = [\"= \[A\] + 2 \* \[B\]\"]{style="COLOR: maroon"}[   ]{style="COLOR: black"} ]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                        |
|                                                                                                                                                                                             |
| [\' Must enter formula names before turning on calculations.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                             |
|                                                                                                                                                                                             |
| [\' 3) Assigns formula object names.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                                             |
| [calculator([\"A\"]{style="COLOR: maroon"}) = [Me]{style="COLOR: blue"}.textBoxA.Text]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                             |
| [calculator([\"B\"]{style="COLOR: maroon"}) = [Me]{style="COLOR: blue"}.textBoxB.Text]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                             |
| [calculator([\"C\"]{style="COLOR: maroon"}) = [Me]{style="COLOR: blue"}.textBoxC.Text]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                             |
| [calculator([\"D\"]{style="COLOR: maroon"}) = [Me]{style="COLOR: blue"}.textBoxD.Text]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p50} 

 

[]{#related-topics}
::::

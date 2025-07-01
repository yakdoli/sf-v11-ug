::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=172af5c9-ec0f-43e6-8f45-f7e19f885c88){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=3b90d03b-c88c-42a8-9c82-a0118542195d){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Edit]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=172af5c9-ec0f-43e6-8f45-f7e19f885c88){.d2h_breadcrumbsNormal}
:::

## How To Access the Text Associated With Individual Lines In the Selected Text Region Of the Edit Control {#how-to-access-the-text-associated-with-individual-lines-in-the-selected-text-region-of-the-edit-control style="tab-stops: 0pt"}

 

The below given code snippet illustrates how you can access the text associated with individual lines in the selected text region of the Edit Control.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                         |
|                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                   |
|                                                                                                                                                                                        |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ cleanedSQL = [\"\"]{style="COLOR: maroon"}; ]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                        |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([this]{style="COLOR: blue"}.editControl1.SelectedText != [\"\"]{style="COLOR: maroon"}) ]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                        |
| [{ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                        |
| [// Get the start and end points of the selection ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                  |
|                                                                                                                                                                                        |
| [CoordinatePoint start = [this]{style="COLOR: blue"}.editControl1.Selection.Top; ]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                        |
| [CoordinatePoint end = [this]{style="COLOR: blue"}.editControl1.Selection.Bottom; ]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                        |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ lineText = [\"\"]{style="COLOR: maroon"}; ]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                                        |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} i=start.VirtualLine; i\<=end.VirtualLine; i++) ]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                                        |
| [{ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                        |
| [// Get the line object ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                            |
|                                                                                                                                                                                        |
| [ILexemLine]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ lexemLine = [this]{style="COLOR: blue"}.editControl1.GetLine(i); ]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                        |
| [// Get the tokens in each line object and append them to get the line text ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                        |
|                                                                                                                                                                                        |
| [foreach]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([ILexem]{style="COLOR: teal"} lexem [in]{style="COLOR: blue"} lexemLine.LineLexems) ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                        |
| [{ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                        |
| [lineText += lexem.Text;  ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                        |
| [} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                        |
| [// Store each of these line text  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                 |
|                                                                                                                                                                                        |
| [cleanedSQL += lineText + [\"\\n\"]{style="COLOR: maroon"}; ]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                        |
| [lineText=[\"\"]{style="COLOR: maroon"}; ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                        |
| [} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                        |
| [} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                            |
|                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                          |
|                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ cleanedSQL [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = [\"\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                                                               |
| [If]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Me]{style="COLOR: blue"}.editControl1.SelectedText \<\> [\"\"]{style="COLOR: maroon"} [Then]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                                                                               |
| [\' Get the start and end points of the selection ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                         |
|                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ start [As]{style="COLOR: blue"} CoordinatePoint = [Me]{style="COLOR: blue"}.editControl1.Selection.Top]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [end]{style="COLOR: blue"} [As]{style="COLOR: blue"} CoordinatePoint = [Me]{style="COLOR: blue"}.editControl1.Selection.Bottom  ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ lineText [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = [\"\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                                                               |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i = start.VirtualLine [To]{style="COLOR: blue"} i\<- 1 [Step]{style="COLOR: blue"} =[end]{style="COLOR: blue"}.VirtualLine ]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                                               |
| [\' Get the line object ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                   |
|                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ lexemLine [As]{style="COLOR: blue"} ILexemLine = [Me]{style="COLOR: blue"}.editControl1.GetLine(i)]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                          |
|                                                                                                                                                                                                                               |
| [\' Get the tokens in each line object and append them to get the line text ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                               |
|                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ lexem [As]{style="COLOR: blue"} ILexem]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                               |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Each]{style="COLOR: blue"} lexem [In]{style="COLOR: blue"} lexemLine.LineLexems ]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                               |
| [lineText += lexem.Text ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                                               |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                          |
|                                                                                                                                                                                                                               |
| [\' Store each of these line text  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                        |
|                                                                                                                                                                                                                               |
| [cleanedSQL += lineText + [\"\\n\"]{style="COLOR: maroon"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                               |
| [lineText=[\"\"]{style="COLOR: maroon"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                               |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                                                               |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [If]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p183} 

[]{#related-topics}
::::

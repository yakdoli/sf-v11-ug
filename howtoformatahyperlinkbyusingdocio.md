::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=276adbbf-60b3-4298-8705-347f71b08c38){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e726f384-edc9-405a-aad8-6ba0b5904a07){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=82ce5b36-6d4b-438d-b8f8-cf8bbfb1678f){.d2h_breadcrumbsNormal}
:::

## How to format a Hyperlink by using DocIO? {#how-to-format-a-hyperlink-by-using-docio style="tab-stops: 0pt"}

 

Some details about the fields. Each field consists of the following.

 

[·      ]{style="FONT-FAMILY: Symbol"}Field, which defines field properties (not formatting)

[·      ]{style="FONT-FAMILY: Symbol"}FieldMark (FieldSeparator mark)

[·      ]{style="FONT-FAMILY: Symbol"}Text of the Field (WTextTange)

[·      ]{style="FONT-FAMILY: Symbol"}FieldMark (FieldEnd mark)

 

If you want to set formatting for the field text, you have to find **WTextRange(s)** between the field separator and field text to set the CharacterFormat for them.

 

The following code illustrates how to format the hyperlink text.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                           |
|                                                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                 |
|                                                                                                                                                                                                          |
| [doc.LastParagraph.AppendHyperlink([\"www.google.com\"]{style="COLOR: maroon"}, [\"google\"]{style="COLOR: maroon"}, [HyperlinkType]{style="COLOR: teal"}.WebLink);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                          |
| [ [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} i = 0, cnt = doc.LastParagraph.Items.Count; i \< cnt; i++)]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                          |
| [ {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                          |
| [     [if]{style="COLOR: blue"} (doc.LastParagraph.Items\[i\] [is]{style="COLOR: blue"} [WTextRange]{style="COLOR: teal"})]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                          |
| [     {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                          |
| [         [WTextRange]{style="COLOR: teal"} text = doc.LastParagraph.Items\[i\] [as]{style="COLOR: blue"} [WTextRange]{style="COLOR: teal"};]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                          |
| [         text.CharacterFormat.FontSize = 33f;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                          |
| [     }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                          |
| [ }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
| [doc.LastParagraph.AppendHyperlink([\"www.google.com\"]{style="COLOR: maroon"}, [\"google\"]{style="COLOR: maroon"}, HyperlinkType.WebLink)]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = 0, cnt [As]{style="COLOR: blue"} [Integer]{style="COLOR: blue"} = doc.LastParagraph.Items.Count]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                           |
| [While]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i \< cnt]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                                           |
| [If]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [TypeOf]{style="COLOR: blue"} doc.LastParagraph.Items(i) [Is]{style="COLOR: blue"} WTextRange [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                                                                                           |
| [     [Dim]{style="COLOR: blue"} text [As]{style="COLOR: blue"} WTextRange = [TryCast]{style="COLOR: blue"}(doc.LastParagraph.Items(i), WTextRange)]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                                                                                           |
| [     text.CharacterFormat.FontSize = 33.0F]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                           |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                                                           |
| [i += 1]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                           |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [While]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image24_1.jpg){border="0"}Note:  Following is the order in the paragraph.
:::

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN: 9pt 0pt 9pt 18pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
1)  WField object

2)  Field separator

3)  Text to display

4)  Field end[]{#_How_to_format_1}
:::

[]{#related-topics}
::::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=9075f0ab-b874-4df8-a7b6-072f6524ea7e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e7b4f267-a55a-4dff-9f7f-45ea32df6ecb){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Word Document](ms-xhelp:///?Id=d4b2bc62-8cff-43ca-bbb3-bdd5cc1553de){.d2h_breadcrumbsNormal}
:::

### Font Substitution for Word Documents {#font-substitution-for-word-documents style="tab-stops: 0pt"}

Font substitution is the process of using an alternate font for fonts that are not installed in the system. MS Word renders the text based on alternate font defined, if the actual font is not installed in the system. MS Word displays the actual font name of the text in the font dialog box, but the text will be rendered based on the alternate font.  Below screen shot illustrates the "Arial (W1)" font is substituted by the alternate font "Gabriola" in MS Word document.

 

![Description: C:\\Users\\gunasekarant\\Desktop\\Screenshot2.PNG](ImagesExt/image24_30.png){border="0"}

Figure 31: MS Word document with "Gabriola" as alternate font for "Arial (W1)".

 

![Description: C:\\Users\\gunasekarant\\Desktop\\Screenshot3.PNG](ImagesExt/image24_31.png){border="0"}

Figure 32[: MS Word Font Substitution Table]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image24_1.jpg){border="0"}Note: In some cases MS Word preserves the alternate font based the information stored in the application cache. To overcome this case close all the open instances of MS Word and re-instantiate the document.
:::

 

The following code snippets illustrate how to access the font substitution table.

 

+----------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                 |
|                                                                                                                |
| [// Updating alternate font name in font substitution table]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                |
| [if (document.FontSubstitutionTable.ContainsKey(\"Arial (W1)\"))]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                |
| [    document.FontSubstitutionTable\[\"Arial (W1)\"\] = \"Gabriola\";]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                |
| [else]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                |
| [    document.FontSubstitutionTable.Add(\"Arial (W1)\", \"Gabriola\");]{style="FONT-FAMILY: 'Courier New'"}    |
+----------------------------------------------------------------------------------------------------------------+

[]{style="DISPLAY: none; FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

 

[]{style="DISPLAY: none; FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                               |
|                                                                                                                                                  |
| [\' Updating alternate font name in font substitution table]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                   |
|                                                                                                                                                  |
| [If document.FontSubstitutionTable.ContainsKey(\"Arial (W1)\") Then]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                  |
| [    ]{style="FONT-FAMILY: 'Courier New'"}[document.FontSubstitutionTable(\"Arial (W1)\") = \"Gabriola\"]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                  |
| [Else]{style="FONT-FAMILY: 'Courier New'"}                                                                                                       |
|                                                                                                                                                  |
| [    ]{style="FONT-FAMILY: 'Courier New'"}[document.FontSubstitutionTable.Add(\"Arial (W1)\", \"Gabriola\")]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                  |
| [End If]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::::

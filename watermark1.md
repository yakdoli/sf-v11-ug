::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=23f1da80-7f82-4816-9e39-5bb21329fd44){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=0c3ea2f6-e05d-4162-9e06-d6af6a893c70){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=696f5666-8b81-4685-9bd9-12198f06f3ad){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Appearance](ms-xhelp:///?Id=201bbd07-95b2-469b-a2b4-b7ebc85043f2){.d2h_breadcrumbsNormal}
:::

### Watermark {#watermark style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Essential Chart supports the Watermark feature by using which you can show text, image, or both as a Watermark inside the ChartArea.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Properties

::: {align="center"}
+---------------------+-------------------------------------------------------------------------+--------------------------------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| Property            | Description                                                             | Property Type                                          | Value it Accepts                                                          | Any Other Dependencies/Sub-properties Associated |
+=====================+=========================================================================+========================================================+===========================================================================+==================================================+
| Text                | Used to display the text as a Watermark.                                | [string]{style="COLOR: blue"}                          | [string]{style="COLOR: blue"}                                             | [NA]{style="COLOR: #558ed5"}                     |
+---------------------+-------------------------------------------------------------------------+--------------------------------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| Image               | Used to display the image as a Watermark.                               | [Image]{style="COLOR: #2b91af"}                        | [Image]{style="COLOR: #2b91af"}                                           | [NA]{style="COLOR: #558ed5"}                     |
+---------------------+-------------------------------------------------------------------------+--------------------------------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| Font                | Sets the font style for the Watermark text.                             | [Font]{style="COLOR: #2b91af"}[]{style="COLOR: blue"}  | [Font]{style="COLOR: #2b91af"}[]{style="COLOR: blue"}                     | [NA]{style="COLOR: #558ed5"}                     |
+---------------------+-------------------------------------------------------------------------+--------------------------------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| HorizontalAlignment | Sets the Watermark horizontally in the ChartArea.                       | [enum]{style="COLOR: blue"}                            | [ChartAlignment]{style="COLOR: #2b91af"}.Center                           | [NA]{style="COLOR: #558ed5"}                     |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        | [ChartAlignment]{style="COLOR: #2b91af"}.Far                              |                                                  |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        | [ChartAlignment]{style="COLOR: #2b91af"}.Near[]{style="COLOR: blue"}      |                                                  |
+---------------------+-------------------------------------------------------------------------+--------------------------------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| VerticalAlignment   | Sets the Watermark vertically in the ChartArea.                         | [enum]{style="COLOR: blue"}[]{style="COLOR: #2b91af"}  | [ChartAlignment]{style="COLOR: #2b91af"}.Center                           | [NA]{style="COLOR: #558ed5"}                     |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        | [ChartAlignment]{style="COLOR: #2b91af"}.Far                              |                                                  |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        | [ChartAlignment]{style="COLOR: #2b91af"}.Near[]{style="COLOR: blue"}      |                                                  |
+---------------------+-------------------------------------------------------------------------+--------------------------------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| ImageSize           | Sets the image size for the Watermark.                                  | [Size]{style="COLOR: #2b91af"}                         | [Size]{style="COLOR: #2b91af"}[]{style="COLOR: blue"}                     | [NA]{style="COLOR: #558ed5"}                     |
+---------------------+-------------------------------------------------------------------------+--------------------------------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| Margin              | Sets the margin for the Watermark.                                      | [ChartThickness]{style="COLOR: #2b91af"}               | [ChartThickness]{style="COLOR: #2b91af"}[]{style="COLOR: blue"}           | [NA]{style="COLOR: #558ed5"}                     |
+---------------------+-------------------------------------------------------------------------+--------------------------------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| Opacity             | Sets the opacity of the Watermark.                                      | [float]{style="COLOR: blue"}[]{style="COLOR: #2b91af"} | [float]{style="COLOR: blue"}                                              | [NA]{style="COLOR: #558ed5"}                     |
+---------------------+-------------------------------------------------------------------------+--------------------------------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| ZOrder              | Used to specify if a Watermark should be shown on the top of the chart. | [enum]{style="COLOR: blue"}[]{style="COLOR: #2b91af"}  | [ChartWaterMarkOrder]{style="COLOR: #2b91af"}.Behind                      | [NA]{style="COLOR: #558ed5"}                     |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        |                                                                           |                                                  |
|                     |                                                                         |                                                        | [ChartWaterMarkOrder]{style="COLOR: #2b91af"}.Over[]{style="COLOR: blue"} |                                                  |
+---------------------+-------------------------------------------------------------------------+--------------------------------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
| TextColor           | Sets the color for the Watermark text.                                  | System.Drawing.[Color]{style="COLOR: #2b91af"}         | System.Drawing.[Color]{style="COLOR: #2b91af"}[]{style="COLOR: blue"}     | [NA]{style="COLOR: #558ed5"}                     |
+---------------------+-------------------------------------------------------------------------+--------------------------------------------------------+---------------------------------------------------------------------------+--------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 

The Watermark text can be customized through two ways:

[·      ]{style="FONT-FAMILY: Symbol"}Builder

[·      ]{style="FONT-FAMILY: Symbol"}ChartModel

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Builder](ms-xhelp:///?Id=d70cfb2c-eefc-4792-a240-444b68bf3c89){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ChartModel](ms-xhelp:///?Id=906e9beb-4a8b-4e92-8976-f636aae2f63e){style="TEXT-DECORATION: none"}
:::::

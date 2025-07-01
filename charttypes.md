::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=64680480-9dab-436d-a830-99d51d191aa1){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=b5388c29-bc8f-40f6-adff-3fcfa90e9b7f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=100687ce-82f2-4424-9d16-0949ea76cf15){.d2h_breadcrumbsNormal}
:::

## Chart Types {#chart-types style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Essential Chart includes a comprehensive set of more than 35 Chart types for all your business needs. Each one is highly and easily configurable with built-in support for creating stunning visual effects.

Chart types are specified on each **ChartSeries** through the **Type** property. All the chart types are required to have at least one **X** and one **Y** value. Certain chart types need more than one **Y** value.

The following table narrates the minimum and maximum number of series and number of y values required by each type of chart supported by Essential Chart.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
  ---------------------------------------------------------------------------------------------------------------- -------------------------- -------------------------- -----------------------------
  Chart Type                                                                                                       Minimum Number of Series   Maximum Number of Series   Number of Y Values Required
  [[Area Charts]{.UGHyperlink}](ms-xhelp:///?Id=d834657a-72d4-4708-ba64-765b92f7c9ea)[]{.UGHyperlink}              1                          Unlimited                  1
  [[Bar Chart]{.UGHyperlink}](ms-xhelp:///?Id=d834657a-72d4-4708-ba64-765b92f7c9ea)[]{.UGHyperlink}                1                          Unlimited                  1
  [[Box And Whisker Chart]{.UGHyperlink}](ms-xhelp:///?Id=d834657a-72d4-4708-ba64-765b92f7c9ea)[]{.UGHyperlink}    1                          Unlimited                  5
  [[Bubble Chart]{.UGHyperlink}](ms-xhelp:///?Id=d834657a-72d4-4708-ba64-765b92f7c9ea)[]{.UGHyperlink}             1                          Unlimited                  2
  [[Candle Chart]{.UGHyperlink}](ms-xhelp:///?Id=dc49e876-360c-4b3e-bf87-688523008727)[]{.UGHyperlink}             1                          Unlimited                  4
  [[Column Chart]{.UGHyperlink}](ms-xhelp:///?Id=e00c01e2-54ec-409e-ae1b-ed46f9d987ab)[]{.UGHyperlink}             1                          Unlimited                  1
  [[Column Range Chart]{.UGHyperlink}](ms-xhelp:///?Id=5776d24e-f729-4ece-9a96-efb7b05943ec)[]{.UGHyperlink}       1                          Unlimited                  2
  [[Combination Chart]{.UGHyperlink}](ms-xhelp:///?Id=9d0ded83-6933-413c-9183-433486870970)[]{.UGHyperlink}        2                          Unlimited                  1
  [[Funnel Chart]{.UGHyperlink}](ms-xhelp:///?Id=9d0ded83-6933-413c-9183-433486870970)[]{.UGHyperlink}             1                          1                          1
  [[Gantt Chart]{.UGHyperlink}](ms-xhelp:///?Id=9d0ded83-6933-413c-9183-433486870970)[]{.UGHyperlink}              1                          Unlimited                  2
  [[Hi Lo Chart]{.UGHyperlink}](ms-xhelp:///?Id=9d0ded83-6933-413c-9183-433486870970)[]{.UGHyperlink}              1                          Unlimited                  4
  [[Hi Lo Open Close Chart]{.UGHyperlink}](ms-xhelp:///?Id=9d0ded83-6933-413c-9183-433486870970)[]{.UGHyperlink}   1                          Unlimited                  4
  [[Histogram Chart]{.UGHyperlink}](ms-xhelp:///?Id=da2915a1-4f35-4b69-a2e0-635a4e67a067)[]{.UGHyperlink}          1                          Unlimited                  1
  [[Heat Map Chart]{.UGHyperlink}](ms-xhelp:///?Id=d8e4aaec-91d5-454f-a250-4642d4599367)[]{.UGHyperlink}           1                          1                          2
  [[Kagi Chart]{.UGHyperlink}](ms-xhelp:///?Id=9e813a7f-6747-4300-b980-b458dcc012ac)[]{.UGHyperlink}               1                          Unlimited                  1
  [[Line Chart]{.UGHyperlink}](ms-xhelp:///?Id=1da6790d-863b-4667-8c2d-878bfdb84ee2)[]{.UGHyperlink}               1                          Unlimited                  1
  [[Pie Chart]{.UGHyperlink}](ms-xhelp:///?Id=0c6d9018-89a4-4f6b-a708-650ca1fce7c2)[]{.UGHyperlink}                1                          1                          1
  [[Point And Figure Chart]{.UGHyperlink}](ms-xhelp:///?Id=4f122927-97da-49d1-a1bb-10c8e69e0b58)[]{.UGHyperlink}   1                          Unlimited                  2
  [[Polar Chart]{.UGHyperlink}](ms-xhelp:///?Id=4ad015d1-9db4-405b-8ed1-77043983b1b9)[]{.UGHyperlink}              1                          Unlimited                  1
  [[Pyramid Chart]{.UGHyperlink}](ms-xhelp:///?Id=7a4bd133-0828-48b7-b08e-2b8eedbc775a)[]{.UGHyperlink}            1                          1                          1
  [[Radar Chart]{.UGHyperlink}](ms-xhelp:///?Id=8e825423-c9d8-4278-9f65-d727235f20bb)[]{.UGHyperlink}              1                          Unlimited                  1
  [[Renko Chart]{.UGHyperlink}](ms-xhelp:///?Id=8e825423-c9d8-4278-9f65-d727235f20bb)[]{.UGHyperlink}              1                          Unlimited                  1
  [[Rotated Spline Chart]{.UGHyperlink}](ms-xhelp:///?Id=02c48029-8edc-423d-82e0-b41ed27cc680)[]{.UGHyperlink}     1                          Unlimited                  1
  [[Scatter Chart]{.UGHyperlink}](ms-xhelp:///?Id=7a4bd133-0828-48b7-b08e-2b8eedbc775a)[]{.UGHyperlink}            1                          Unlimited                  1
  [[Spline Area Chart]{.UGHyperlink}](ms-xhelp:///?Id=02c48029-8edc-423d-82e0-b41ed27cc680)[]{.UGHyperlink}        1                          Unlimited                  1
  [[Spline Chart]{.UGHyperlink}](ms-xhelp:///?Id=3a8c90d1-1f38-4064-8f29-b1c63b9f1a07)[]{.UGHyperlink}             1                          Unlimited                  1
  [[Stacking Area Chart]{.UGHyperlink}](ms-xhelp:///?Id=4ede39a6-fb75-46ef-bd31-dd13a418807a)[]{.UGHyperlink}      2                          Unlimited                  1
  [[Stacking Bar Chart]{.UGHyperlink}](ms-xhelp:///?Id=137e357f-58c1-463b-9fb1-c42a058a7844)[]{.UGHyperlink}       2                          Unlimited                  1
  [[Stacking Column Chart]{.UGHyperlink}](ms-xhelp:///?Id=137e357f-58c1-463b-9fb1-c42a058a7844)[]{.UGHyperlink}    2                          Unlimited                  1
  [[Step Area Chart]{.UGHyperlink}](ms-xhelp:///?Id=557f9901-85d9-4ff4-98b6-b9ba3d3ad482)[]{.UGHyperlink}          1                          Unlimited                  1
  [[Step Line Chart]{.UGHyperlink}](ms-xhelp:///?Id=a7967f1f-f6da-4b09-ac65-84ba40aa705d)[]{.UGHyperlink}          1                          Unlimited                  1
  [[Three Line Break Chart]{.UGHyperlink}](ms-xhelp:///?Id=557f9901-85d9-4ff4-98b6-b9ba3d3ad482)[]{.UGHyperlink}   1                          Unlimited                  1
  [[Tornado Chart]{.UGHyperlink}](ms-xhelp:///?Id=30e03545-af78-4c8c-aadd-9753e3037808)[]{.UGHyperlink}            1                          Unlimited                  2
  ---------------------------------------------------------------------------------------------------------------- -------------------------- -------------------------- -----------------------------
:::

[]{#p29} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Line Charts](ms-xhelp:///?Id=b5388c29-bc8f-40f6-adff-3fcfa90e9b7f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Bar Charts](ms-xhelp:///?Id=56f5f2de-512e-4b71-9fa4-53fe41b58a5d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Column Charts](ms-xhelp:///?Id=02942db6-c085-4688-a553-f530b48779a9){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Area Charts](ms-xhelp:///?Id=00bfe11f-6685-427d-a27f-4f2c7d981e55){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Accumulation Charts](ms-xhelp:///?Id=e2f32b98-0035-47d9-9093-331845201a55){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}XY Charts (Bubble and Scatter)](ms-xhelp:///?Id=0993d333-7791-467b-871b-2f17ae64c441){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Financial Charts](ms-xhelp:///?Id=dd546448-9994-4706-83a0-94b7ea1abf6c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Polar and Radar Chart](ms-xhelp:///?Id=d1cf2ab8-f315-4c0f-9e5f-29aee2e8c91b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Combination Chart](ms-xhelp:///?Id=e95c92cc-4e4c-405a-a7bb-13bac10963c3){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Heat Map Chart](ms-xhelp:///?Id=82c5d204-873e-4eef-9cb3-19199bcc1de5){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Stacking Charts](ms-xhelp:///?Id=032e4bce-83b0-4763-b62d-ca74096d062e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Step Charts](ms-xhelp:///?Id=1d2d6f9c-7f9d-467b-a389-594bd5d36d70){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Sparkline Chart in Web Chart](ms-xhelp:///?Id=b55ff242-875f-4822-9de4-058f6bd99d36){style="TEXT-DECORATION: none"}
:::::

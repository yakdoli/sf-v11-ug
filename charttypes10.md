::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=372b5b83-fed0-46d4-831c-b84fe8c18abb){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=39d092a4-3ba0-495b-b5ca-36721a162e2c){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Business Intelligence Edition](ms-xhelp:///?Id=fdf33dd8-62b2-47b9-ad7b-fc50e590bca5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Silverlight](ms-xhelp:///?Id=c006b39c-6aa2-4637-b7de-3e7b6cb3f9f9){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential BI Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=372b5b83-fed0-46d4-831c-b84fe8c18abb){.d2h_breadcrumbsNormal}
:::

## Chart Types {#chart-types style="tab-stops: 0pt"}

Essential BI OLAP Chart for Silverlight supports the following chart types, each of which has a unique way of displaying data.

Use Case Scenarios

The user can choose any type of chart to visualize data among the available chart types. There are 20 chart types available for selectionfor example, when doing a comparison analysis  several charts can be displayed in Sales and Marketing dashboards.

Specifying the Chart Type for Chart in an Application

There are 20 chart types available andyou can use the OlapChartType property to set the expected chart type. Previously, this property was a ChartType. However, the ChartType property will exist but it will be obsolete. The main advantage of the new OlapChartType property is that you no longer need to call DataBind method after changing from one chart type to another. The following code snippets and images illustrate this in detail.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

For more information refer:

[[Getting Started]{.UGHyperlink}](ms-xhelp:///?Id=ecc923f3-5552-498e-b06c-296a873aba68)[]{.UGHyperlink}

[]{style="FONT-FAMILY: 'Arial','sans-serif'"} 

 

Table 14: OlapChartType Property

 

::: {align="center"}
+---------------+--------------------------------------------------+---------------------+------------------+-----------------+
| Property      | Description                                      | Type                | Data Type        | Reference links |
+===============+==================================================+=====================+==================+=================+
| OlapChartType | Is used for selecting the particular chart type. | Dependency Property | OlapChartType,   |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | Column           |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | Bar              |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | Area             |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | Line             |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | Spline           |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | Scatter          |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | Pie              |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | StackingColumn   |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | StackingCoIum100 |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | StackingBar      |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | StackingBarl00   |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | StackingArea     |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | StepArea         |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | SplineArea       |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | StepLine         |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | RotatedSpline    |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | Radar            |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | Polar            |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | Funnel           |                 |
|               |                                                  |                     |                  |                 |
|               |                                                  |                     | Pyramid          |                 |
+---------------+--------------------------------------------------+---------------------+------------------+-----------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Link

To view the sample, go the sample installed location.

1.   Run the sample. Or run the BI Silverlight samples, by clicking the "Run locally installed samples" from the drop-down in the **Silverlight** ComboBox-button found in the  DashBoard under the **BI Tab**.

2\. **..\\..\\Syncfusion\\BI\\Silverlight\\Syncfusion.OlapChart.Silverlight.Samples\\Syncfusion.OlapChart.Silverlight.Samples\\Samples**

3.   Now, navigate to **OlapChart** tab in the sample browser.

 

Now, select the **Chart Gallery Demo** sample

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Column Chart](ms-xhelp:///?Id=39d092a4-3ba0-495b-b5ca-36721a162e2c){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Bar Chart](ms-xhelp:///?Id=881b7977-95ca-4444-b808-169a49ffb7ac){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Area Chart](ms-xhelp:///?Id=f93e96d1-559e-4585-b8fe-c2c0433b019e){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Line Chart](ms-xhelp:///?Id=ecd646c6-56cd-4ff4-a1f6-e0810c714ab6){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Spline Chart](ms-xhelp:///?Id=c3da8747-a492-4e2c-afab-eafcf9dcc837){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Scatter Chart](ms-xhelp:///?Id=22e8b6e9-bc90-4651-bcb6-c4bdaa953054){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Pie Chart](ms-xhelp:///?Id=9e0755e2-60fb-46f8-ab13-1a5583f31106){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}StackingColumn Chart](ms-xhelp:///?Id=43256cef-5a83-42e1-ac53-f314b9966203){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}StackingColumn100 Chart](ms-xhelp:///?Id=c20d8991-c366-4112-bb2d-c915ad84ccfc){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}StackingBar Chart](ms-xhelp:///?Id=3992d6c2-85c2-406a-95a0-6326963b9c14){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}StackingBar100 Chart](ms-xhelp:///?Id=96314738-5eca-4fcb-9637-c1378200c8bc){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}StackingArea Chart](ms-xhelp:///?Id=10ceb967-5833-4b44-98eb-18ad766cabe8){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}StepArea Chart](ms-xhelp:///?Id=7054bb38-aceb-4fe1-b158-cd87be7354df){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}SplineArea Chart](ms-xhelp:///?Id=38f852c6-f842-47f8-8dc8-4bfc6b0e072d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}StepLine Chart](ms-xhelp:///?Id=ca9496bd-cf94-4be9-b5f2-1287ed180ae2){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}RotatedSpline Chart](ms-xhelp:///?Id=99cae561-3022-44da-a118-4a228d51e8e0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Radar Chart](ms-xhelp:///?Id=feb25155-6aa9-4553-bd57-17bc2394b60d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Polar Chart](ms-xhelp:///?Id=3eb07e54-3cff-4107-9fb7-4d8763ba205f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Funnel Chart](ms-xhelp:///?Id=a9e9a7c3-5fa3-465f-a203-a4182601c147){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Pyramid Chart](ms-xhelp:///?Id=a3b26093-e420-44ec-b626-dbe6c2060d3f){style="TEXT-DECORATION: none"}
:::::

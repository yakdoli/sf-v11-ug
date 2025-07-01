::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Builder {#builder style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The steps to create a chart with the zooming feature through Builder are as follows:

 

Step 1:

Controller:

Add the code displayed below in the HomeController.cs file. **ChartParams** class is used to get the post parameter values for the chart. Hence, it is used as a parameter in the post action. Then, it is passed to the view through the ViewData.

 

::: {style="BORDER-BOTTOM: #c8c8c8 1pt solid; BORDER-LEFT: #c8c8c8 1pt solid; PADDING-BOTTOM: 1pt; MARGIN-TOP: 0pt; PADDING-LEFT: 4pt; PADDING-RIGHT: 4pt; MARGIN-BOTTOM: 0pt; BACKGROUND: #f0f0f0; BORDER-TOP: #c8c8c8 1pt solid; BORDER-RIGHT: #c8c8c8 1pt solid; PADDING-TOP: 1pt"}
[using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ System;]{style="FONT-FAMILY: 'Courier New'"}

[using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ System.Collections.Generic;]{style="FONT-FAMILY: 'Courier New'"}

[using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ System.Linq;]{style="FONT-FAMILY: 'Courier New'"}

[using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ System.Web;]{style="FONT-FAMILY: 'Courier New'"}

[using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ System.Web.Mvc;]{style="FONT-FAMILY: 'Courier New'"}

[using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Mvc.Shared;]{style="FONT-FAMILY: 'Courier New'"}

[using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Mvc.Chart;]{style="FONT-FAMILY: 'Courier New'"}

[using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Windows.Forms.Chart;]{style="FONT-FAMILY: 'Courier New'"}

[using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Drawing;]{style="FONT-FAMILY: 'Courier New'"}

[using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ System.Drawing;]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

[namespace]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Sample.Controllers]{style="FONT-FAMILY: 'Courier New'"}

[{]{style="FONT-FAMILY: 'Courier New'"}

[    \[[HandleError]{style="COLOR: #2b91af"}\]]{style="FONT-FAMILY: 'Courier New'"}

[    [public]{style="COLOR: blue"} [class]{style="COLOR: blue"} [HomeController]{style="COLOR: #2b91af"} : [Controller]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'"}

[    {]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

[        [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}

[        {]{style="FONT-FAMILY: 'Courier New'"}

[            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}

[        }]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

[        \[[AcceptVerbs]{style="COLOR: #2b91af"}([HttpVerbs]{style="COLOR: #2b91af"}.Post)\]]{style="FONT-FAMILY: 'Courier New'"}

[        [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Index([MVCChartModel]{style="COLOR: #2b91af"} chartModel, [ChartParams]{style="COLOR: #2b91af"} param)]{style="FONT-FAMILY: 'Courier New'"}

[        {]{style="FONT-FAMILY: 'Courier New'"}

[//Passing the chart post parameter values to the view]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}

[            ViewData\[[\"ChartParamsData\"]{style="COLOR: #a31515"}\] = param;]{style="FONT-FAMILY: 'Courier New'"}

[            [return]{style="COLOR: blue"} PartialView([\"PartialView\"]{style="COLOR: #a31515"}, [this]{style="COLOR: blue"}.ViewData);]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

[        }]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

[        ]{style="FONT-FAMILY: 'Courier New'"}

[    }]{style="FONT-FAMILY: 'Courier New'"}

[}]{style="FONT-FAMILY: 'Courier New'"}
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Step 2:

View:

Add the code displayed below in the Index file.[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

::: {style="BORDER-BOTTOM: #c8c8c8 1pt solid; BORDER-LEFT: #c8c8c8 1pt solid; PADDING-BOTTOM: 1pt; MARGIN-TOP: 0pt; PADDING-LEFT: 4pt; PADDING-RIGHT: 4pt; MARGIN-BOTTOM: 0pt; BACKGROUND: #f0f0f0; BORDER-TOP: #c8c8c8 1pt solid; BORDER-RIGHT: #c8c8c8 1pt solid; PADDING-TOP: 1pt"}
[View\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} 

[\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Page]{style="COLOR: #a31515"} [Language]{style="COLOR: red"}[=\"C#\"]{style="COLOR: blue"} [MasterPageFile]{style="COLOR: red"}[=\"\~/Views/Shared/Site.Master\"]{style="COLOR: blue"} [Inherits]{style="COLOR: red"}[=\"System.Web.Mvc.ViewPage\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} 

[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[asp]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Content]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [ID]{style="COLOR: red"}[=\"Content1\"]{style="COLOR: blue"} [ContentPlaceHolderID]{style="COLOR: red"}[=\"TitleContent\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}

[    Chart Zooming]{style="FONT-FAMILY: 'Courier New'"}

[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[asp]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Content]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}

[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[asp]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Content]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ [ID]{style="COLOR: red"}[=\"Content2\"]{style="COLOR: blue"} [ContentPlaceHolderID]{style="COLOR: red"}[=\"MainContent\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}

[   [\<%]{style="BACKGROUND: yellow"}[\--Rendering the Chart Control through partial view\--]{style="COLOR: green"}[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}

[          [\<%]{style="BACKGROUND: yellow"}Html.RenderPartial([\"PartialView\"]{style="COLOR: #a31515"}, [this]{style="COLOR: blue"}.ViewData); [%\>]{style="BACKGROUND: yellow"} ]{style="FONT-FAMILY: 'Courier New'"}

[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[asp]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Content]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

::: {style="BORDER-BOTTOM: #c8c8c8 1pt solid; BORDER-LEFT: #c8c8c8 1pt solid; PADDING-BOTTOM: 1pt; MARGIN-TOP: 0pt; PADDING-LEFT: 4pt; PADDING-RIGHT: 4pt; MARGIN-BOTTOM: 0pt; BACKGROUND: #f0f0f0; BORDER-TOP: #c8c8c8 1pt solid; BORDER-RIGHT: #c8c8c8 1pt solid; PADDING-TOP: 1pt"}
[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} 

[\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}

[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} 

[Layout=\"\~/Views/Shared/\_Layout.cshtml\";]{style="FONT-FAMILY: 'Courier New'"}

[ViewBag.Title= = "Chart Zooming";]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

[}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}

[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} 

[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[div]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}

[   [@\*]{style="BACKGROUND: yellow"}[\--Rendering the Chart Control through partial view\--]{style="COLOR: green"}[\*@]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} 

[          [@]{style="BACKGROUND: yellow"}Html.RenderPartial([\"PartialView\"]{style="COLOR: #a31515"}, [this]{style="COLOR: blue"}.ViewData)]{style="FONT-FAMILY: 'Courier New'"}

[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[div]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Step 3:

PartialView:

Create a Partial View named **"PartialView.ascx"**, and add the code displayed below in it.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

::: {style="BORDER-BOTTOM: #c8c8c8 1pt solid; BORDER-LEFT: #c8c8c8 1pt solid; PADDING-BOTTOM: 1pt; MARGIN-TOP: 0pt; PADDING-LEFT: 4pt; PADDING-RIGHT: 4pt; MARGIN-BOTTOM: 0pt; BACKGROUND: #f0f0f0; BORDER-TOP: #c8c8c8 1pt solid; BORDER-RIGHT: #c8c8c8 1pt solid; PADDING-TOP: 1pt"}
[View\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} 

[\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[@]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Control]{style="COLOR: #a31515"} [Language]{style="COLOR: red"}[=\"C#\"]{style="COLOR: blue"} [Inherits]{style="COLOR: red"}[=\"System.Web.Mvc.ViewUserControl\"]{style="COLOR: blue"} [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} 

[ [\<%]{style="BACKGROUND: yellow"}[\--Rendering the Chart COntrol\--]{style="COLOR: green"}[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}

[    [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Chart([\"chart_Model\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}

[//Enabling x-axis and y-axis zooming]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}

[    .EnableXZooming([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}

[    .EnableYZooming([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}

[    .ChartSeriesSkins([ChartSeriesSkins]{style="COLOR: #2b91af"}.Pastel)]{style="FONT-FAMILY: 'Courier New'"}

[    .Series(series=\>{]{style="FONT-FAMILY: 'Courier New'"}

[//Adding the chart series points]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}

[        series.Add().Points(points =\>]{style="FONT-FAMILY: 'Courier New'"}

[        {]{style="FONT-FAMILY: 'Courier New'"}

[            points.Add().X(1997).YValues([new]{style="COLOR: blue"} [double]{style="COLOR: blue"}\[\] { 437 });]{style="FONT-FAMILY: 'Courier New'"}

[            points.Add().X(1999).YValues([new]{style="COLOR: blue"} [double]{style="COLOR: blue"}\[\] { 411 });]{style="FONT-FAMILY: 'Courier New'"}

[            points.Add().X(2003).YValues([new]{style="COLOR: blue"} [double]{style="COLOR: blue"}\[\] { 466 });]{style="FONT-FAMILY: 'Courier New'"}

[            points.Add().X(2005).YValues([new]{style="COLOR: blue"} [double]{style="COLOR: blue"}\[\] { 422 });]{style="FONT-FAMILY: 'Courier New'"}

[            points.Add().X(2009).YValues([new]{style="COLOR: blue"} [double]{style="COLOR: blue"}\[\] { 622 });]{style="FONT-FAMILY: 'Courier New'"}

[        }).Name([\"Saab\"]{style="COLOR: #a31515"}).Type(Syncfusion.Windows.Forms.Chart.[ChartSeriesType]{style="COLOR: #2b91af"}.Area);]{style="FONT-FAMILY: 'Courier New'"}

[  ]{style="FONT-FAMILY: 'Courier New'"}

[    }).PrimaryXAxis(xaxis=\>{]{style="FONT-FAMILY: 'Courier New'"}

[        [ChartParams]{style="COLOR: #2b91af"} ChartParams = [new]{style="COLOR: blue"} [ChartParams]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}

[        ChartParams = ([ChartParams]{style="COLOR: #2b91af"})ViewData\[[\"ChartParamsData\"]{style="COLOR: #a31515"}\];]{style="FONT-FAMILY: 'Courier New'"}

[        xaxis]{style="FONT-FAMILY: 'Courier New'"}

[            .Range(range =\>]{style="FONT-FAMILY: 'Courier New'"}

[            {]{style="FONT-FAMILY: 'Courier New'"}

[                range.Max(2012).Min(1995).Interval(5);]{style="FONT-FAMILY: 'Courier New'"}

[            })]{style="FONT-FAMILY: 'Courier New'"}

[        .Title([\" Year \"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

[        xaxis.LineType(line =\> line.ForeColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.DarkGray)).GridLineType(gridline =\> gridline.ForeColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.DarkGray)).Title([\"Year\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}

[})]{style="FONT-FAMILY: 'Courier New'"}

[        .PrimaryYAxis(yaxis =\>]{style="FONT-FAMILY: 'Courier New'"}

[        {]{style="FONT-FAMILY: 'Courier New'"}

[            [ChartParams]{style="COLOR: #2b91af"} ChartParams = [new]{style="COLOR: blue"} [ChartParams]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}

[            ChartParams = ([ChartParams]{style="COLOR: #2b91af"})ViewData\[[\"ChartParamsData\"]{style="COLOR: #a31515"}\];]{style="FONT-FAMILY: 'Courier New'"}

[            yaxis.Title([\"Market Volume \"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}

[            .Range(range =\>]{style="FONT-FAMILY: 'Courier New'"}

[                {]{style="FONT-FAMILY: 'Courier New'"}

[                    range.Max(800).Min(0).Interval(500);]{style="FONT-FAMILY: 'Courier New'"}

[                });]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

[            yaxis.LineType(line =\> line.ForeColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.DarkGray)).GridLineType(gridline =\> gridline.ForeColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.DarkGray)).Title([\"Market Volume\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}

[        })]{style="FONT-FAMILY: 'Courier New'"}

[        .ChartParamsArgs(([ChartParams]{style="COLOR: #2b91af"})ViewData\[[\"ChartParamsData\"]{style="COLOR: #a31515"}\])]{style="FONT-FAMILY: 'Courier New'"}

[        .Text([\"Sales Volume Comparison\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}

[        .Font([new]{style="COLOR: blue"} System.Drawing.[Font]{style="COLOR: #2b91af"}([\"Verdana\"]{style="COLOR: #a31515"}, 12, System.Drawing.[FontStyle]{style="COLOR: #2b91af"}.Bold))]{style="FONT-FAMILY: 'Courier New'"}

[        .BorderAppearance(ba =\> ba.SkinStyle(Syncfusion.Windows.Forms.Chart.[ChartBorderSkinStyle]{style="COLOR: #2b91af"}.Emboss))]{style="FONT-FAMILY: 'Courier New'"}

[        .Size([new]{style="COLOR: blue"} System.Drawing.[Size]{style="COLOR: #2b91af"}(450, 350))]{style="FONT-FAMILY: 'Courier New'"}

[        .Skins([ChartModelSkins]{style="COLOR: #2b91af"}.Office2007Blue)]{style="FONT-FAMILY: 'Courier New'"}

[        .ChartSeriesSkins([ChartSeriesSkins]{style="COLOR: #2b91af"}.GrayScale)]{style="FONT-FAMILY: 'Courier New'"}

[        ]{style="FONT-FAMILY: 'Courier New'"}

[        [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

::: {style="BORDER-BOTTOM: #c8c8c8 1pt solid; BORDER-LEFT: #c8c8c8 1pt solid; PADDING-BOTTOM: 1pt; MARGIN-TOP: 0pt; PADDING-LEFT: 4pt; PADDING-RIGHT: 4pt; MARGIN-BOTTOM: 0pt; BACKGROUND: #f0f0f0; BORDER-TOP: #c8c8c8 1pt solid; BORDER-RIGHT: #c8c8c8 1pt solid; PADDING-TOP: 1pt"}
[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} 

[ [@\*]{style="BACKGROUND: yellow"}[\--Rendering the Chart COntrol\--]{style="COLOR: green"}[\*@]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} 

[    [\@{]{style="BACKGROUND: yellow"} Html.Chart([\"chart_Model\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}

[//Enabling x-axis and y-axis zooming]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}

[    .EnableXZooming([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}

[    .EnableYZooming([true]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}

[    .ChartSeriesSkins([ChartSeriesSkins]{style="COLOR: #2b91af"}.Pastel)]{style="FONT-FAMILY: 'Courier New'"}

[    .Series(series=\>{]{style="FONT-FAMILY: 'Courier New'"}

[//Adding the chart series points]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}

[        series.Add().Points(points =\>]{style="FONT-FAMILY: 'Courier New'"}

[        {]{style="FONT-FAMILY: 'Courier New'"}

[            points.Add().X(1997).YValues([new]{style="COLOR: blue"} [double]{style="COLOR: blue"}\[\] { 437 });]{style="FONT-FAMILY: 'Courier New'"}

[            points.Add().X(1999).YValues([new]{style="COLOR: blue"} [double]{style="COLOR: blue"}\[\] { 411 });]{style="FONT-FAMILY: 'Courier New'"}

[            points.Add().X(2003).YValues([new]{style="COLOR: blue"} [double]{style="COLOR: blue"}\[\] { 466 });]{style="FONT-FAMILY: 'Courier New'"}

[            points.Add().X(2005).YValues([new]{style="COLOR: blue"} [double]{style="COLOR: blue"}\[\] { 422 });]{style="FONT-FAMILY: 'Courier New'"}

[            points.Add().X(2009).YValues([new]{style="COLOR: blue"} [double]{style="COLOR: blue"}\[\] { 622 });]{style="FONT-FAMILY: 'Courier New'"}

[        }).Name([\"Saab\"]{style="COLOR: #a31515"}).Type(Syncfusion.Windows.Forms.Chart.[ChartSeriesType]{style="COLOR: #2b91af"}.Area);]{style="FONT-FAMILY: 'Courier New'"}

[  ]{style="FONT-FAMILY: 'Courier New'"}

[    }).PrimaryXAxis(xaxis=\>{]{style="FONT-FAMILY: 'Courier New'"}

[        [ChartParams]{style="COLOR: #2b91af"} ChartParams = [new]{style="COLOR: blue"} [ChartParams]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}

[        ChartParams = ([ChartParams]{style="COLOR: #2b91af"})ViewData\[[\"ChartParamsData\"]{style="COLOR: #a31515"}\];]{style="FONT-FAMILY: 'Courier New'"}

[        xaxis]{style="FONT-FAMILY: 'Courier New'"}

[            .Range(range =\>]{style="FONT-FAMILY: 'Courier New'"}

[            {]{style="FONT-FAMILY: 'Courier New'"}

[                range.Max(2012).Min(1995).Interval(5);]{style="FONT-FAMILY: 'Courier New'"}

[            })]{style="FONT-FAMILY: 'Courier New'"}

[        .Title([\" Year \"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

[        xaxis.LineType(line =\> line.ForeColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.DarkGray)).GridLineType(gridline =\> gridline.ForeColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.DarkGray)).Title([\"Year\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}

[})]{style="FONT-FAMILY: 'Courier New'"}

[        .PrimaryYAxis(yaxis =\>]{style="FONT-FAMILY: 'Courier New'"}

[        {]{style="FONT-FAMILY: 'Courier New'"}

[            [ChartParams]{style="COLOR: #2b91af"} ChartParams = [new]{style="COLOR: blue"} [ChartParams]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}

[            ChartParams = ([ChartParams]{style="COLOR: #2b91af"})ViewData\[[\"ChartParamsData\"]{style="COLOR: #a31515"}\];]{style="FONT-FAMILY: 'Courier New'"}

[            yaxis.Title([\"Market Volume \"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}

[            .Range(range =\>]{style="FONT-FAMILY: 'Courier New'"}

[                {]{style="FONT-FAMILY: 'Courier New'"}

[                    range.Max(800).Min(0).Interval(500);]{style="FONT-FAMILY: 'Courier New'"}

[                });]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

[            yaxis.LineType(line =\> line.ForeColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.DarkGray)).GridLineType(gridline =\> gridline.ForeColor(System.Drawing.[Color]{style="COLOR: #2b91af"}.DarkGray)).Title([\"Market Volume\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}

[        })]{style="FONT-FAMILY: 'Courier New'"}

[        .ChartParamsArgs(([ChartParams]{style="COLOR: #2b91af"})ViewData\[[\"ChartParamsData\"]{style="COLOR: #a31515"}\])]{style="FONT-FAMILY: 'Courier New'"}

[        .Text([\"Sales Volume Comparison\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}

[        .Font([new]{style="COLOR: blue"} System.Drawing.[Font]{style="COLOR: #2b91af"}([\"Verdana\"]{style="COLOR: #a31515"}, 12, System.Drawing.[FontStyle]{style="COLOR: #2b91af"}.Bold))]{style="FONT-FAMILY: 'Courier New'"}

[        .BorderAppearance(ba =\> ba.SkinStyle(Syncfusion.Windows.Forms.Chart.[ChartBorderSkinStyle]{style="COLOR: #2b91af"}.Emboss))]{style="FONT-FAMILY: 'Courier New'"}

[        .Size([new]{style="COLOR: blue"} System.Drawing.[Size]{style="COLOR: #2b91af"}(450, 350))]{style="FONT-FAMILY: 'Courier New'"}

[        .Skins([ChartModelSkins]{style="COLOR: #2b91af"}.Office2007Blue)]{style="FONT-FAMILY: 'Courier New'"}

[        .ChartSeriesSkins([ChartSeriesSkins]{style="COLOR: #2b91af"}.GrayScale)]{style="FONT-FAMILY: 'Courier New'"}

[        .Render();]{style="FONT-FAMILY: 'Courier New'"}

[        ]{style="FONT-FAMILY: 'Courier New'"}

[        [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}
:::

Step 4:

Run the code, to get the following output:

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

![Description: C:\\Users\\krishnarajd\\Desktop\\b4_Zooming.png](ImagesExt/image69_228.png){border="0"}

Figure 316: Before Zooming

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

![Description: C:\\Users\\krishnarajd\\Desktop\\after_zooming.png](ImagesExt/image69_229.jpg){border="0"}

Figure 317: After Zooming

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{#related-topics}
::::::::

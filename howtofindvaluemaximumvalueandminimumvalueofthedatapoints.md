::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=90ae803c-f07f-442d-94f1-8b4d1c9c3680){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=27983efb-90a4-4443-be20-01c7a33e41af){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Frequently Asked Questions](ms-xhelp:///?Id=1b226732-e1b8-4c4e-ba8f-146df1770f24){.d2h_breadcrumbsNormal}
:::

## How to find value, maximum value and minimum value of the data points? {#how-to-find-value-maximum-value-and-minimum-value-of-the-data-points style="tab-stops: 0pt"}

[   ]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}

Essential Chart has **FindValue**, **FindMaximumValue** and **FindMinimumValue** methods that can return the corresponding chart data point values depending upon the parameter(s) passed to them.

 

All these methods are overloaded.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Find Value

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+-------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Methods                                   | Description                                                                                                                                                     |
+-------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindValue(Double)                         | It should return the first chart point in the collection that has a specified first Y-value. The search always should start at the beginning of the collection. |
+-------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindValue(Double, String)\                | It should return the first chart point in the collection with the specified X or Y-value.                                                                       |
| \                                         |                                                                                                                                                                 |
+-------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindValue(Double, String,index )\         | It should return the first chart point with the specified X or Y-value, and should start the search at the specified index.                                     |
| \                                         |                                                                                                                                                                 |
+-------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindValue(Double, String, Index, Index )\ | It should return the first chart point with the specified X or Y-value, and should start and end the search at the specified index.                             |
| \                                         |                                                                                                                                                                 |
+-------------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                |
|                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                          |
|                                                                                                                                                                                               |
| [dbl = [Int64]{style="COLOR: #2b91af"}.Parse(txBxValue.Text);]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                               |
| [ChartPoint]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ dp1 = [this]{style="COLOR: blue"}.ChartWebControl1.Series\[0\].Summary.FindValue(dbl);]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                  |
|                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                |
|                                                                                                                                                                                                                     |
| [dbl = Int64.Parse(txBxValue.Text)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dp1 [As]{style="COLOR: blue"} ChartPoint = [Me]{style="COLOR: blue"}.ChartWebControl1.Series(0).Summary.FindValue(dbl)]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

FindMaximumValue

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[                   Methods                   ]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** | **[Description]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}**                                                                           |
+-----------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindMaxValue()\                                                                                                       | It should return the first chart point in the collection with a maximum first Y-value. The search always should start at the beginning of the collection.     |
| \                                                                                                                     |                                                                                                                                                               |
+-----------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindMaxValue(String)\                                                                                                 | It should return the first chart point in the collection with the maximum specified value. The search always should start at the beginning of the collection. |
| \                                                                                                                     |                                                                                                                                                               |
+-----------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindMaxValue(String, index)\                                                                                          | It should return the first chart point with a maximum value. The search should start at the specified index.                                                  |
| \                                                                                                                     |                                                                                                                                                               |
+-----------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindMaxValue(String, Index , Index)\                                                                                  | It should return the first chart point with a maximum value. The search should start and end at the specified index.                                          |
| \                                                                                                                     |                                                                                                                                                               |
+-----------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                      |
|                                                                                                                                                                                                                                               |
| [String]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ str = txBxString.Text;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                                               |
| [staIndx = [Int32]{style="COLOR: #2b91af"}.Parse(txBxIndex.Text);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [endIndx = [Int32]{style="COLOR: #2b91af"}.Parse(textBox1.Text);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                                               |
| [ChartPoint]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ dp4 = [this]{style="COLOR: blue"}.ChartWebControl1.Series\[0\].Summary.FindMinValue(str, [ref]{style="COLOR: blue"} staIndx, endIndx);]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ str [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = txBxString.Text]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                                                     |
| [staIndx = Int32.Parse(txBxIndex.Text)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                     |
| [endIndx = Int32.Parse(textBox1.Text)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dp4 [As]{style="COLOR: blue"} ChartPoint = [Me]{style="COLOR: blue"}.ChartWebControl1.Series(0).Summary.FindMinValue(str, [ref]{style="COLOR: blue"} staIndx, endIndx)]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

FindMinimumvalue

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+--------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Methods                              | Description                                                                                                                                                                                          |
+--------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindMinValue()\                      | It should return the first chart point in the collection that has a first Y-value that is equal to the series\' minimum Y1 value. The search always should start at the beginning of the collection. |
| \                                    |                                                                                                                                                                                                      |
+--------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindMinValue(String)\                | It should return the first chart point in the collection that has an X or Y-value that is equal to the series\' minimum value. The search always should start at the beginning of the collection.    |
| \                                    |                                                                                                                                                                                                      |
+--------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindMinValue(String, index)\         | It should return the first Chart point with a minimum value. The search should start at the specified index.                                                                                         |
| \                                    |                                                                                                                                                                                                      |
+--------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| FindMinValue(String, Index , Index)\ | It should return the first Chart point with a minimum value. The search should start and end at the specified index.                                                                                 |
| \                                    |                                                                                                                                                                                                      |
+--------------------------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                      |
|                                                                                                                                                                                                                                               |
| [String]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ str = txBxString.Text;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                                               |
| [staIndx = [Int32]{style="COLOR: #2b91af"}.Parse(txBxIndex.Text);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                               |
| [endIndx = [Int32]{style="COLOR: #2b91af"}.Parse(textBox1.Text);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                                               |
| [ChartPoint]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ dp4 = [this]{style="COLOR: blue"}.ChartWebControl1.Series\[0\].Summary.FindMaxValue(str, [ref]{style="COLOR: blue"} staIndx, endIndx);]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                       |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ str [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = txBxString.Text]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                                                          |
| [staIndx = Int32.Parse(txBxIndex.Text)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                                          |
| [endIndx = Int32.Parse(textBox1.Text)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dp4 [As]{style="COLOR: blue"} ChartPoint = [Me]{style="COLOR: blue"}.ChartWebControl1.Series(0).Summary.FindMaxValue(str, staIndx, endIndx)]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::::::

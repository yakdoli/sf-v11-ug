::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### []{#_Creating_PercentTextBox_using_1}Creating PercentTextBox using C#

To create a PercentTextBox using Visual Studio in C#:

1.   Open Visual Studio, On the **File** menu click New -\> Project. This opens the New Project Dialog box as shown below

 

![Description: C:\\Documents and Settings\\labuser\\My Documents\\SL tools correct image.png](../ImagesExt/image261_45.png){border="0"}

Figure 212: Open New Project

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

2.   Select Silverlight Application in the Project Dialog window and type the name of the project in the name field. Click OK.

![](../ImagesExt/image261_46.png){border="0"}

Figure 213: New Project Dialog

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

3.   Add the following Reference with the sample project.

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Shared.Silverlight.dll

 

![](../ImagesExt/image261_47.png){border="0"}

Figure 214: Solution Explorer

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

4.   Click and Open C# file. Add PercentTextBox to your application.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                     |
|                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                         |
|                                                                                                                                                                                                    |
| [PercentTextBox]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ percentTextBox = [new]{style="COLOR: blue"} [PercentTextBox]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                    |
| [percentTextBox.Width = 150;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                    |
| [percentTextBox.Height = 25;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

![](../ImagesExt/image261_173.png){border="0"}

Figure 215: PercentTextBox

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](../ImagesExt/image261_3.jpg){border="0"}Note:

If you do not set any PercentValue to PercentTextBox then the default value will be as follows...

If UseNullOption set toTtrue then,

    Value of NullValue property will be the default value.

Otherwise

  Zero will be the default value (based on the MinValue and MaxValue the default value will change).
:::

See Also

[Creating PercentTextBox using XAML]{.UGHyperlink}[]{.UGHyperlink}

[Creating PercentTextBox by using Blend]{.UGHyperlink}[]{.UGHyperlink}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
::::

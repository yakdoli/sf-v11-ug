::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Options in Regular Mode {#options-in-regular-mode style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

ProgressBar control when used in WaitingMode, the following properties can be set.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Text

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Text can be displayed on the control. To display the required text, set the **ProgressBarText** property to that text.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ----------------- ----------------------------------------------------
  Property          Description
  ProgressBarText   Specifies the text to be displayed on the control.
  ----------------- ----------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                    |
|                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                 |
|                                                                                                                     |
| [ProgressBar1.ProgressBarText = [\"Loading page\...\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                              |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                           |
|                                                                                                                                                                               |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ProgressBar1.ProgressBarText = [\"Loading page\...\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Progress Value

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **TextStyle** property allows you to either display the progress value in percentage or in numerical value. To display the text make sure that the **TextVisible** property is enabled which controls the visibility of the text.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+----------------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                                    |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------+
| ProgressPercentage                | Specifies the value, relative to which the control percentage value increases.                                 |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------+
| TextStyle                         | Specifies how to display the progress value. Default value is Percentage. The options included are as follows: |
|                                   |                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Percentage                                                               |
|                                   |                                                                                                                |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}Value                                                                    |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------+
| TextVisible                       | Gets/sets the boolean value, whether the progress bar text should be visible. Default value is true.           |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                     |
|                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                  |
|                                                                                                                      |
| [ProgressBar1.TextStyle = [TextStyle]{style="COLOR: teal"}.Value;]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                      |
| [ProgressBar1.TextVisible = [TextVisible]{style="COLOR: teal"}.True;]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                      |
| [ProgressBar1.ProgressBarText = [\"Loading page\...\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                      |
| [ProgressBar1.ProgressStyle = [ProgressStyle]{style="COLOR: teal"}.WaitingMode;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                      |
| [ProgressBar1.Frequency = 10;]{style="FONT-FAMILY: 'Courier New'"}                                                   |
|                                                                                                                      |
| [ProgressBar1.ProgressPercentage = 100;]{style="FONT-FAMILY: 'Courier New'"}                                         |
+----------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                              |
|                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                           |
|                                                                                                                                                                               |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ProgressBar1.TextStyle = TextStyle.Value]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                               |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ProgressBar1.TextVisible = TextVisible.True]{style="FONT-FAMILY: 'Courier New'"}                                  |
|                                                                                                                                                                               |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ProgressBar1.ProgressBarText = [\"Loading page\...\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                               |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ProgressBar1.ProgressStyle = ProgressStyle.WaitingMode]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                               |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ProgressBar1.Frequency = 10]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                               |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ProgressBar1.ProgressPercentage = 100]{style="FONT-FAMILY: 'Courier New'"}                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Refreshing the control

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The control can be updated every time after the specified **Frequency** interval. This updates and refreshes the content without postback.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------------------------------------------+
|                                   |                                                                                                              |
|                                   |                                                                                                              |
| Property                          | Description                                                                                                  |
+-----------------------------------+--------------------------------------------------------------------------------------------------------------+
| Frequency                         | Specifies the frequency in which the control should update itself without a postback. Default value is 1000. |
+-----------------------------------+--------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                      |
|                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                   |
|                                                                       |
| [ProgressBar1.Frequency = 2000;]{style="FONT-FAMILY: 'Courier New'"}  |
+-----------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                               |
|                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                            |
|                                                                                                                                |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ProgressBar1.Frequency = 2000]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::::

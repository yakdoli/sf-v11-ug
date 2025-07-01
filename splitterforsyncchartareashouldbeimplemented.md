::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Splitter for SyncChartArea should be implemented {#splitter-for-syncchartarea-should-be-implemented style="tab-stops: 0pt"}

Essential Chart WPF is now enhanced with **Splitter for** **SyncChartArea**. This is useful to differentiate the implementation of more than one Chart Area.

 

Property Details

The following table contains the property details.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Table 11: Property Table

::: {align="center"}
  -------------------- --------------------------------------- --------------------- -------------------------------------
  Name of Property     Description                             Type of Property      Value It Accepts
  SplitterVisibility   Sets the visibility for the splitter.   Dependency Property   Enum of the type SplitterVisibility
  SplitterWidth        Sets the width for the Splitter.        Dependency Property   Double
  SplitterStroke       Sets the stroke for the splitter.       Dependency Property   Brush
  SplitterColor        Sets the color for the splitter.        Dependency Property   Brush
  -------------------- --------------------------------------- --------------------- -------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Adding Splitter for SyncChartArea

Add Splitter for SyncChartArea, by using the following code.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\] ]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sfChart]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[SyncChartAreas]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"syncChart\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ SplitterVisiblity]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"ShowAlways\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: red"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [SplitterStroke]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Red\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ SplitterColor]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Blue\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ SplitterWidth]{style="COLOR: red"}[=\"2\"]{style="COLOR: blue"}[ ]{style="COLOR: red"}[/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\] ]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                           |
|                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                  |
|                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.SyncChart.SplitterVisibility = SplitterVisibility.ShowAlways;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                             |
| [            [this]{style="COLOR: blue"}.SyncChart.SplitterStroke = [Brushes]{style="COLOR: #2b91af"}.Red;]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                             |
| [            [this]{style="COLOR: blue"}.SyncChart.SplitterColor = [Brushes]{style="COLOR: #2b91af"}.Blue;]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                             |
| [            [this]{style="COLOR: blue"}.SyncChart.SplitterWidth = 2;]{style="FONT-FAMILY: 'Courier New'"}                                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p44} 

 

[]{#related-topics}
::::

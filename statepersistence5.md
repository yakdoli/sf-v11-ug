::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### State Persistence {#state-persistence style="tab-stops: 0pt"}

This feature enables the user to maintain the collapsed or expanded state in the PivotGrid when pivot schema is changed.

Use Case Scenarios

The user can maintain collapsed or expanded states and save/load these settings dynamically in the PivotGrid control.

The following image shows state persistence in the PivotGrid control:

[ ]{style="BORDER-BOTTOM: black 1pt; BORDER-LEFT: black 1pt; PADDING-BOTTOM: 0pt; PADDING-LEFT: 0pt; LAYOUT-GRID-MODE: line; PADDING-RIGHT: 0pt; FONT-FAMILY: 'Times New Roman','serif'; BACKGROUND: black; COLOR: black; FONT-SIZE: 0pt; BORDER-TOP: black 1pt; BORDER-RIGHT: black 1pt; PADDING-TOP: 0pt"} ![Description: D:\\Diana\\2012\\2012_Vol 1\\Mkt Content 2012\\StatePersistenceDemo2.png](ImagesExt/image42_35.png){border="0"}

Figure 33 PivotGrid with collapsed/expanded states

 

*[]{style="FONT-SIZE: 9pt"}*  

Properties

Table 7: Property Table

::: {align="center"}
  ------------------------- ------------------------------------------------------------------------------------------------------------ ------------ ----------- -----------------
  Property                  Description                                                                                                  Type         Data Type   Reference links
  StatePersistenceEnabled   Gets or sets a value indicating whether to maintain/show collapsed cells when pivot schema getting changed   Dependency   Boolean     \-
  ------------------------- ------------------------------------------------------------------------------------------------------------ ------------ ----------- -----------------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Link

The user can find a sample in the following location:

**SystemDrive:\\Users\\\<user_name\>\\AppData\\Local\\Syncfusion\\EssentialStudio\\\<version_number\>\\BI\\WPF\\** **PivotAnalysis.Wpf\\Samples\\Appearance\\State Persistence Demo**

 

Adding State Persistence to an Application

The user can enable or disable the state persistence by using the following code snippets in an application:

+---------------------------------------------------------------------------------------------------------------+
| [      **\[C#\]**]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                               |
| [      pivotGrid1.StatePersistenceEnabled = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                               |
|                                                                                                               |
+---------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------+
| [      **\[VB\]**]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                              |
| [      pivotGrid1.StatePersistenceEnabled = [true]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                              |
|                                                                                                              |
+--------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::

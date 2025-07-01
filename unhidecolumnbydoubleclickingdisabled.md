::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Unhide Column by Double-Clicking Disabled {#unhide-column-by-double-clicking-disabled style="tab-stops: 0pt"}

Essential Grid has changed the unhide column operation to emulate the behavior found in Microsoft Excel. Previously, hidden columns could be shown by double-clicking a row. This behavior has been disabled so that applications created using Essential Grid will be similar to the hide/unhide behavior found in Microsoft Excel.

 

 

Properties

 

*[Table ]{style="FONT-SIZE: 9pt"}[2]{style="FONT-SIZE: 9pt"}[: Property Table]{style="FONT-SIZE: 9pt"}*

::: {align="center"}
  ---------------------- --------------------------------------------------------------------------------- ---------- --------------- ---------------------
  **Property**           **Description**                                                                   **Type**   **Data Type**   **Reference links**
  UnHideColsOnDblClick   Indicates whether to allow unhide the hidden columns when double click the row.   Property   Boolean         N/A.
  ---------------------- --------------------------------------------------------------------------------- ---------- --------------- ---------------------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Link

A demo of this feature is available in the following location:

***..\\..\\AppData\\Local\\Syncfusion\\EssentialStudio\\{Installed Version}\\Windows\\Grid.Windows\\Samples\\2.0\\Grid Layout\\Hide Rows and Columns Demo***

**** 

**** 

Disabling Unhide Column by Double-Clicking

To disable unhide column by double- clicking, set the *UnHideColsOnDblClick* property to true. By default this is set to true.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                              |
|                                                                                                                                                                               |
| [     //Disables unhide column when ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[double clicking as found in Excel.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                                               |
| [            [this]{style="COLOR: blue"}.gridControl1.UnHideColsOnDblClick = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                              |
|                                                                                                                                                                                                                             |
| [     \'Disables unhide column when double clicking as found in Excel.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                   |
|                                                                                                                                                                                                                             |
| [            ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridControl1.UnHideColsOnDblClick = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}** 

 

 

[]{#related-topics}
::::

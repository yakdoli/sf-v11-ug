::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Maximizing WindowControl by Double-clicking

Silverlight WindowControl can be maximized by double-clicking the title bar.

Use Case Scenarios

WindowControl is usually maximized by clicking the Maximize button on the title bar. Now, users can maximize WindowControl by double-clicking WindowControls' title bar just like any desktop window.

Events

MouseDoubleClick

The MouseDoubleClick event can be used, as shown in the following code snippet.

**** 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                     |
|                                                                                                                                                                      |
| [WindowControl]{style="FONT-FAMILY: Consolas; COLOR: #2b91af"}[ window = [new]{style="COLOR: blue"} [WindowControl]{style="COLOR: #2b91af"}();\                      |
| window.MouseDoubleClick += [new]{style="COLOR: blue"} [MouseButtonEventHandler]{style="COLOR: #2b91af"}(window_MouseDoubleClick);]{style="FONT-FAMILY: Consolas"}    |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: Consolas"}                                                                                                                                    |
|                                                                                                                                                                      |
| [void]{style="FONT-FAMILY: Consolas; COLOR: blue"}[ window_MouseDoubleClick([object]{style="COLOR: blue"} sender, [MouseButtonEventArgs]{style="COLOR: #2b91af"} e)\ |
| {\                                                                                                                                                                   |
|    [// Perform an action here.]{style="COLOR: green"}\                                                                                                               |
| }]{style="FONT-FAMILY: Consolas"}                                                                                                                                    |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: Consolas"}                                                                                                                                    |
|                                                                                                                                                                      |
|                                                                                                                                                                      |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The MouseDoubleClick event is described in the following tabulation:

Table 58: Event Table

  Event              Description                                       Arguments                          Type                      Reference links
  ------------------ ------------------------------------------------- ---------------------------------- ------------------------- -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  MouseDoubleClick   Occurs when the mouse button is double-clicked.   Object and MouseButtonEventArgs.   MouseButtonEventhandler   [[MouseDoubleClick]{style="COLOR: blue"}](../../../../../../../../Documents%20and%20Settings/riaj/Desktop/styling%20for%20ui%20silverlight/tools%20silverlight/tools%20part%202.docx#_Events)[]{style="COLOR: black"}

 

Sample Link

A sample application that describes the Maximizing WindowControl by Double-clicking feature in WindowControl is distributed along with the Essential Tools installation. To access the sample application:

Open the Syncfusion Dashboard.

Click **User Interface**.

Click the **Silverlight** drop-down list, and then select **Locally Installed Samples**.

Navigate to **Tools** -\> **Window** -\> **Window Demo**.

 

[]{#related-topics}
:::

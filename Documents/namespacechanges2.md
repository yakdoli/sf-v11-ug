::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=5d0c5df5-8d33-483a-aaad-28a3f33fc5dc){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f7457810-02b6-4071-9c65-75bbc62bdd09){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
## []{#p9}Namespace Changes

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

In order to maintain consistent namespace and enable code sharing between our WPF and Silverlight controls, namespace for Silverlight controls has been modified similar to WPF. The following are changes done to namespace of Tools Silverlight controls from 8.1.0.x release.

 

 

::: {align="center"}
+----------------------------------------+-----------------------------------+
| Old Namespace                          | New  Namespace                    |
+----------------------------------------+-----------------------------------+
| Syncfusion.Silverlight.Tools.Controls  | Syncfusion.Windows.Tools.Controls |
+----------------------------------------+                                   |
| Syncfusion.Silverlight.DockingManager  |                                   |
+----------------------------------------+                                   |
| Syncfusion.Silverlight.Ribbon          |                                   |
+----------------------------------------+-----------------------------------+
| Syncfusion.Silverlight.Shared          | Syncfusion.Windows.Shared         |
+----------------------------------------+-----------------------------------+
:::

 

 

Following controls have been moved from Tools Silverlight assembly to Shared Silverlight assembly in order for the users to use it with different products with Shared Silverlight reference itself.

[·      ]{style="FONT-FAMILY: Symbol"}DoubleTextBox

[·      ]{style="FONT-FAMILY: Symbol"}MaskedTextBox

[·      ]{style="FONT-FAMILY: Symbol"}IntegerTextBox

[·      ]{style="FONT-FAMILY: Symbol"}CurrencyTextBox

[·      ]{style="FONT-FAMILY: Symbol"}PercentTextBox

Namespace for the above mentioned editor controls will be as follows.

 

+-------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                  |
|                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                          |
|                                                                                                                                     |
| [xmlns:Syncfusion=\"Syncfusion.Windows.Tools.Controls;assembly=Syncfusion.Shared.Silverlight\"]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+--------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                               |
|                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                     |
|                                                                                |
| [using Syncfusion.Windows.Tools.Controls;]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{#related-topics}
::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to Get the Individual Docked control\'s Properties? {#how-to-get-the-individual-docked-controls-properties style="tab-stops: 0pt"}

To check whether a control (in this case it\'s a listbox) is floating or docked, you could use the code snippet given below.

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.IsFloating(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.listBox1);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.IsFloating(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.listBox1);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

To get the Dock location

[       ]{style="COLOR: #15428b"}

1.   Add a listview and a docking manager in your form.

 

2.   Enable the listview as a docked control.

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                     |
|                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                |
|                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SetEnableDocking([this]{style="COLOR: blue"}.listView1,[true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                             |
|                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                       |
|                                                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SetEnableDocking([Me]{style="COLOR: blue"}.listView1, [True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

3.   Now add the below given code in your form\'s constructor.

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                        |
|                                                                                                                                                                                                       |
| []{style="COLOR: green; FONT-SIZE: 8pt"}                                                                                                                                                              |
|                                                                                                                                                                                                       |
| [//listView1 is the dockable control. We could get it\'s dock properties by accessing DockHost and DockHostController.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                             |
|                                                                                                                                                                                                       |
| [Syncfusion.Windows.Forms.Tools.DockHost dhost = [this]{style="COLOR: blue"}.listView1.Parent [as]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.DockHost;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                       |
| [Syncfusion.Windows.Forms.Tools.DockHostController dhc = dhost.InternalController [as]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                       |
| [Syncfusion.Windows.Forms.Tools.DockHostController;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                       |
| [//The DockInfo object will give all the information about docked control.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                         |
|                                                                                                                                                                                                       |
| [Syncfusion.Windows.Forms.Tools.DockInfo di = dhc.GetSerCurrentDI();]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                       |
| [MessageBox.Show(di.rcDockArea.ToString());]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\' listView1 is the dockable control. We could get it\'s dock properties by accessing DockHost and DockHostController.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dhost [As]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.DockHost = [CType]{style="COLOR: blue"}(IIf([TypeOf]{style="COLOR: blue"} [Me]{style="COLOR: blue"}.listView1.Parent [Is]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.DockHost, [Me]{style="COLOR: blue"}.listView1.Parent, [Nothing]{style="COLOR: blue"}), Syncfusion.Windows.Forms.Tools.DockHost)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dhc [As]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.DockHostController = [CType]{style="COLOR: blue"}(IIf([TypeOf]{style="COLOR: blue"} dhost.InternalController [Is]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.DockHostController, dhost.InternalController, [Nothing]{style="COLOR: blue"}), Syncfusion.Windows.Forms.Tools.DockHostController)]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [\' The DockInfo object will give all the information about docked control.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ di [As]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.DockInfo = dhc.GetSerCurrentDI()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [MessageBox.Show(di.rcDockArea.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                           |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

[·      ]{style="FONT-FAMILY: Symbol"}Just before you close a docked / floating control, access the control's parent and cast this to type Syncfusion.Windows.Forms.Tools.DockHost. 

[·      ]{style="FONT-FAMILY: Symbol"}Now access the DockHost\'s InternalController and get it's current serialization info using the **GetSerCurrInfo()** method. This will fetch an object of type Syncfusion.Windows.Forms.Tools.DockInfo. The **DockInfo.DockingStyle **member gives the dock position of the particular control with respect to the host form and the **DockInfo.rcDockArea** member returns the control bounds. 

[·      ]{style="FONT-FAMILY: Symbol"}If the control is floating, then DockingStyle will be equal to Syncfusion.Windows.Forms.Tools.DockingStyle.Fill. You can serialize this information against the control's name and later upon loading, appropriately use either the DockingManager.DockControl() / FloatControl() method, based on the serialized DockingStyle / rcbounds values, to set the control's dock state.

[]{#related-topics}
:::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to get individual floating controls properties? {#how-to-get-individual-floating-controls-properties style="tab-stops: 0pt"}

 

To get the x,y coordinates if it is floating

[]{style="COLOR: #15428b"} 

1.   Add a list view and a docking manager to your form.

2.   Enable the listview as a dock control.

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                     |
|                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                           |
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

3.   Set the control as a non-dockable floating window.

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                 |
|                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                       |
|                                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SetFloatOnly([this]{style="COLOR: blue"}.listView1,[true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                        |
|                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                  |
|                                                                                                                                                                                           |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SetFloatOnly([Me]{style="COLOR: blue"}.listView1,[True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

4.   Determine whether the control is floating using the DockingManager.IsFloating() method. 

[]{style="COLOR: #15428b"} 

[·      ]{style="FONT-FAMILY: Symbol"}If true, then the control is being hosted in a subclass of the Form type and this host form can be retrieved through the control's **TopLevelControl** property. 

[·      ]{style="FONT-FAMILY: Symbol"}Once you have the top level form, just use the **Control.Location** property on that form to get it's x and y co-ordinates.

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                         |
|                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                               |
|                                                                                                                                                                        |
| [// Get the FloatingForm object to get location of control.FloatingForm is a Form derived class.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                    |
|                                                                                                                                                                        |
| [DockHost dhost = [this]{style="COLOR: blue"}.listView1.Parent [as]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.DockHost;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                        |
| [FloatingForm floatfrm = dhost.ParentForm [as]{style="COLOR: blue"} FloatingForm;]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                        |
| [MessageBox.Show(floatfrm.Location.ToString());]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [\' Get the FloatingForm object to get location of control.FloatingForm is a Form derived class.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dhost [As]{style="COLOR: blue"} DockHost = [CType]{style="COLOR: blue"}(IIf([TypeOf]{style="COLOR: blue"} [Me]{style="COLOR: blue"}.listView1.Parent [Is]{style="COLOR: blue"} Syncfusion.Windows.Forms.Tools.DockHost, [Me]{style="COLOR: blue"}.listView1.Parent, [Nothing]{style="COLOR: blue"}), Syncfusion.Windows.Forms.Tools.DockHost)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ floatfrm [As]{style="COLOR: blue"} FloatingForm = [CType]{style="COLOR: blue"}(IIf([TypeOf]{style="COLOR: blue"} dhost.ParentForm [Is]{style="COLOR: blue"} FloatingForm, dhost.ParentForm, [Nothing]{style="COLOR: blue"}), FloatingForm)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [MessageBox.Show(floatfrm.Location.ToString())]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::

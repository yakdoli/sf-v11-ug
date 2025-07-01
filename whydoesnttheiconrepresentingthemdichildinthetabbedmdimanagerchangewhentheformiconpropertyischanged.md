::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Why doesn\'t the Icon representing the MDIChild in the TabbedMDIManager change when the Form.Icon property is changed? {#why-doesnt-the-icon-representing-the-mdichild-in-the-tabbedmdimanager-change-when-the-form.icon-property-is-changed style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

 

The form does not throw an event when the Icon gets updated. So, update the Icon in the TabbedMDIManager manually after updating the Icon in the form, as follows:

[]{style="FONT-SIZE: 8pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                |
|                                                                                                                                                                 |
| [\                                                                                                                                                              |
| // Get the tab control corresponding to your form in the TabbedMDIManager. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                  |
|                                                                                                                                                                 |
| [MDITabPanel mdiTabPanel = [this]{style="COLOR: blue"}.tabbedMDIManager.GetTabHostFromForm(mdiChildForm).MDITabPanel;]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                 |
| [// Get the tab page showing the icon. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                      |
|                                                                                                                                                                 |
| [TabPageExt tabPage = mdiTabPanel.GetTabPageExtFromForm(mdiChildForm);]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                 |
| [// The new icon.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                            |
|                                                                                                                                                                 |
| [Icon]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ico = mdiChildForm.Icon;]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                 |
| [// Get the image with the preferred size.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                   |
|                                                                                                                                                                 |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (ico.Size != mdiTabPanel.ImageList.ImageSize)]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                 |
| [// This will try to retrieve an image of the preferred size, if not found, it will create a zoomed version.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                                 |
| [ico = [new]{style="COLOR: blue"} [Icon]{style="COLOR: teal"}(ico, mdiTabPanel.ImageList.ImageSize);]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                 |
| [// Change the icon in the tab control to the new one. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                      |
|                                                                                                                                                                 |
| [mdiTabPanel.ImageList.Images\[tabPage.ImageIndex\] = ico.ToBitmap();]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                 |
| [// Update the tab control. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                 |
|                                                                                                                                                                 |
| [mdiTabPanel.Invalidate();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                 |
| [mdiTabPanel.Update();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                     |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [\' Get the tab control corresponding to your form in the TabbedMDIManager. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                          |
|                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ mdiTabPanel [As]{style="COLOR: blue"} MDITabPanel = [Me]{style="COLOR: blue"}.tabbedMDIManager.GetTabHostFromForm(mdiChildForm).MDITabPanel]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                          |
| [\' Get the tab page showing the icon. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                               |
|                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ tabPage [As]{style="COLOR: blue"} TabPageExt = mdiTabPanel.GetTabPageExtFromForm(mdiChildForm)]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                                                                          |
| [\' The new icon.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ico [As]{style="COLOR: blue"} Icon = mdiChildForm.Icon]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                                                          |
| [\' Get the image with the preferred size.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                            |
|                                                                                                                                                                                                                                          |
| [If]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ico.Size \<\> mdiTabPanel.ImageList.ImageSize [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                                                          |
| [\' This will try to retrieve an image of the preferred size, if not found, it will create a zoomed version.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                          |
|                                                                                                                                                                                                                                          |
| [ico = [New]{style="COLOR: blue"} Icon(ico, mdiTabPanel.ImageList.ImageSize)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                                                          |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [\' Change the icon in the tab control to the new one. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                               |
|                                                                                                                                                                                                                                          |
| [mdiTabPanel.ImageList.Images(tabPage.ImageIndex) = ico.ToBitmap()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                                          |
| [\' Update the tab control. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                          |
|                                                                                                                                                                                                                                          |
| [mdiTabPanel.Invalidate()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                          |
| [mdiTabPanel.Update()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#p939} 

[]{#related-topics}
:::

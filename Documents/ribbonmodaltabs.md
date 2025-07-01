::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Ribbon Modal Tabs[]{style="COLOR: black"}

  Modal Tab in Ribbon Control displays a collection of commands that will be used only in a temporary mode. At this point, the core tabs will be disabled.

 

Use Case Scenarios   

Print Preview is a Modal Tab which displays Print Preview related commands until you close the Modal Tab.

 

![Description: C:\\Users\\sureshkumarc\\Desktop\\modal Tabs\\SL\\NormalTab1.png](../ImagesExt/image261_586.jpg){border="0"}

 

Figure 668: Ribbon with core Tabs

 

 

 

 

 

 

 

 

![Description: C:\\Users\\sureshkumarc\\Desktop\\modal Tabs\\SL\\ModalTab.png](../ImagesExt/image261_587.jpg){border="0"}

Figure 669: Ribbon with Modal Tab

 

Adding Modal Tabs to an Application

You can add the Modal Tab in an application by adding Ribbon Tabs in **ModalTabCollection** property in the Ribbon. You can also add all Ribbon Tabs that you want to use as a Modal Tab into **ModalTabCollection** property.

This is illustrated in the code given below.*[]{style="COLOR: #4e84c4; FONT-SIZE: 16pt"}*

**** 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [            ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Ribbon.ModalTabCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ \>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [                ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ModalTabCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ \>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [                    ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[RibbonTab]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ Caption]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Print Preview\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [                                                 Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"printpreviewtab\"\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [                        ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[RibbonBar]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ Header]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Sample Bar\"\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [                            ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[RibbonButton]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ Label]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Close Tab\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[                                                  ]{style="FONT-FAMILY: 'Courier New'; COLOR: red"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [                                         Click]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"CloseModalTab_Click\"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [                        ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[RibbonBar]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [                    ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[RibbonTab]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [                ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ModalTabCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [            ]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Ribbon.ModalTabCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

After adding this collection in Ribbon, you can then handle the Modal Tab visibility by using the following methods at any time.

Tables for properties, methods

Properties

Table 17: ModalTabCollection Table

  -------------------- ----------------------------------------------------------------------- ---------------------- -------------------- -----------------
  Property             Description                                                             Type                   Data Type            Default Value
  ModalTabCollection   Used to store the collection of Ribbon Tabs as Modal Tabs Collection.    Dependency Property   ModalTabCollection   Null Collection
  -------------------- ----------------------------------------------------------------------- ---------------------- -------------------- -----------------

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

**Methods**

Table 18: ShowModalTab Table

+--------------+-------------------------------------------------------------------------------------+-------------------------------------------------------------------------------------+-------------+------------------------------------------------+
| Method       | Description                                                                         | Parameters                                                                          | Return Type | Reference links                                |
+--------------+-------------------------------------------------------------------------------------+-------------------------------------------------------------------------------------+-------------+------------------------------------------------+
| ShowModalTab | This method will show the specific Modal Tab in the Ribbon from ModalTabCollection. | (string arg1)                                                                       | bool        | [How to Show a ModalTab?]{style="COLOR: blue"} |
|              |                                                                                     |                                                                                     |             |                                                |
|              |                                                                                     |                                                                                     |             |                                                |
|              |                                                                                     |                                                                                     |             |                                                |
|              |                                                                                     |  arg1- Name of the Ribbon Tab to be displayed as Modal Tab from ModalTabCollection. |             |                                                |
+==============+=====================================================================================+=====================================================================================+=============+================================================+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Table 19: CloseModalTabs Table

  **Method**       **Description**                                                             **Parameters**   **Return Type**   **Reference links**
  ---------------- --------------------------------------------------------------------------- ---------------- ----------------- ----------------------------------------------------------------------------------------------------
  CloseModalTabs   CloseModalTabs method will close the opened Modal Tabs in Ribbon control.    No Params       bool               [How to close ModalTabs?]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}

[]{#_How_to_handle}\

How to handle Modal Tabs in Ribbon?

You can add Ribbon Tabs that you want to display as Modal Tabs to **ModalTabCollection** property in Ribbon Control. The **ShowModalTab** and **CloseModalTabs** methods handle Modal Tabs in Ribbon control. You can display any Modal Tab from the **ModalTabCollection property** whenever required.

 

You can call **ShowModalTab** method to show the specific Modal Tab in Ribbon. This can be done from any event of core Ribbon Tab element.

 

This is illustrated in the code given below.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                      |
|                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                       |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} ShowModalTabBtn_Click([object]{style="COLOR: blue"} sender, [RoutedEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                       |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                       |
| [            [this]{style="COLOR: blue"}.MyRibbon.ShowModalTab([\"printpreviewtab\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                                       |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**CloseModalTabs** method will close the currently opened Modal Tab in Ribbon control. This method should be called in any event of currently displaying Modal Tab element.

This is illustrated in the code given below.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                       |
|                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                        |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} CloseModalTabBtn_Click([object]{style="COLOR: blue"} sender, [RoutedEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                        |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                        |
| [            [this]{style="COLOR: blue"}.MyRibbon.CloseModalTabs();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                        |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

 

Sample Link

[Syncfusion.Tools.SilverlightSamples ]{.UGHyperlink}[[à]{style="FONT-FAMILY: Wingdings"}]{.UGHyperlink}[ Ribbon ]{.UGHyperlink}[[à]{style="FONT-FAMILY: Wingdings"}]{.UGHyperlink}[ Modal Tabs]{.UGHyperlink}

[]{#related-topics}
:::

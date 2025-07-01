::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Properties

 

**[]{style="FONT-FAMILY: 'Myriad Pro','sans-serif'"}** 

Table 91:Properties of ToolBarAdv

::: {align="center"}
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| Property                   | Description                                                                                       | Type                | Data Type                               | Reference links |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| Band                       | Gets or sets a value indicating where the ToolBarAdv should be placed in the ToolBarTrayAdv.      | Dependency Property | Int                                     | NA              |
|                            |                                                                                                   |                     |                                         |                 |
|                            |                                                                                                   |                     |                                         |                 |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| BandIndex                  | Gets or sets the band index number indicating the position of the ToolBarAdv on the band.         | Dependency Property | Int                                     | NA              |
|                            |                                                                                                   |                     |                                         |                 |
|                            |                                                                                                   |                     |                                         |                 |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| ToolBarName                | Gets or sets the name of the ToolBarAdv.                                                          | Dependency Property | String                                  | NA              |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| GripperVisibility          | Gets or sets a value indicating whether gripper can be visible.                                   | Dependency Property | Bool                                    | NA              |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| FloatingBarLocation        | Gets or sets the location for the floating ToolBarAdv.                                            | Dependency Property | Point                                   | NA              |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| ControlsResourceDictionary | Gets or sets resource dictionary in which ToolBarAdv will look up for framework element's styles. | Dependency Property | Resource Dictionary                     | NA              |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| IsOverflowOpen             | Gets or sets a value indicating whether overflow popup is open.                                   | Dependency Property | Bool                                    | NA              |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| ToolBarItemInfoCollection  | Gets or sets the items to be displayed in the Add or Remove Buttons popup.                        | Dependency Property | ObservableCollection\<ToolBarIteminfo\> | NA              |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| IsoverflowItem             | Gets or sets a value indicating whether an item can be displayed in overflow panel.               | Attached Property   | Bool                                    | NA              |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| OverflowMode               | Gets or sets an overflow mode for a specified item.                                               | Attached Property   | OverflowMode                            | NA              |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| Icon                       | Gets or sets an icon for specified item to be displayed in the Add or Remove Buttons menu.        | Attached Property   | ImageSource                             | NA              |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| Label                      | Gets or sets a label for specified item to be displayed in the Add or Remove Buttons menu.        | Attached Property   | String                                  | NA              |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
| IsAvailable                | Gets or sets a value indicating whether a specified item should be hidden.                        | Attached Property   |  Boolean                                | NA              |
+----------------------------+---------------------------------------------------------------------------------------------------+---------------------+-----------------------------------------+-----------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Table 92: ToolBarTrayAdv

::: {align="center"}
  ------------- ---------------------------------------------------------------- --------------------------- ------------------------------------ -----------------
  Property      Description                                                      Type                        Data Type                            Reference links
  IsLocked      Gets or Sets a value indicating whether ToolBarTray is locked.   Dependency property         bool                                 NA
  Orientation   Gets or Sets the orientation of the ToolBarAdv.                  Dependency property         Orientation                          NA
  ToolBars      Gets or sets toolbars.                                           Dependency property         ObservableCollection\<ToolBarAdv\>   NA
  ------------- ---------------------------------------------------------------- --------------------------- ------------------------------------ -----------------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Table 93: ToolBarManager

::: {align="center"}
+----------------------+----------------------------------------------------------------------------------------+---------------------+----------------+-----------------+
| Property             | Description                                                                            | Type                | Data Type      | Reference links |
+----------------------+----------------------------------------------------------------------------------------+---------------------+----------------+-----------------+
|                      | Gets or sets ToolBarTrayAdv which has to be displayed at the Top of ToolBarManager.    | Dependency Property | ToolBarTrayAdv | NA              |
|                      |                                                                                        |                     |                |                 |
| TopToolBarTray       |                                                                                        |                     |                |                 |
+----------------------+----------------------------------------------------------------------------------------+---------------------+----------------+-----------------+
| BottomToolBarTray    | Gets or sets ToolBarTrayAdv which has to be displayed at the bottom of ToolBarManager. | Dependency Property | ToolBarTrayAdv | NA              |
+----------------------+----------------------------------------------------------------------------------------+---------------------+----------------+-----------------+
| LeftToolBarTray      | Gets or sets ToolBarTrayAdv which has to be displayed at the left of ToolBarManager.   | Dependency Property | ToolBarTrayAdv | NA              |
+----------------------+----------------------------------------------------------------------------------------+---------------------+----------------+-----------------+
| RightToolBarTray     | Gets or sets ToolBarTrayAdv which has to be displayed at the right of ToolBarManager.  | Dependency Property | ToolBarTrayAdv | NA              |
+----------------------+----------------------------------------------------------------------------------------+---------------------+----------------+-----------------+
| CanDockAtTop         | Gets or sets a value indicating whether toolbar can be docked at the top.              | Dependency Property | bool           | NA              |
+----------------------+----------------------------------------------------------------------------------------+---------------------+----------------+-----------------+
| CanDockAtBottom      | Gets or sets a value indicating whether toolbar can be docked at the bottom.           | Dependency Property | bool           | NA              |
+----------------------+----------------------------------------------------------------------------------------+---------------------+----------------+-----------------+
| CanDockAtLeft        | Gets or sets a value indicating whether toolbar can be docked at the left.             | Dependency Property | bool           | NA              |
+----------------------+----------------------------------------------------------------------------------------+---------------------+----------------+-----------------+
| CanDockAtRight       | Gets or sets a value indicating whether toolbar can be docked at the right.            | Dependency Property | bool           | NA              |
+----------------------+----------------------------------------------------------------------------------------+---------------------+----------------+-----------------+
| Content              | Gets or sets the content of the ToolBarManager.                                        | Dependency Property | UIElement      | NA              |
+----------------------+----------------------------------------------------------------------------------------+---------------------+----------------+-----------------+
| FloatingToolBarStyle | Gets or sets a style of floating tool bar                                              | Dependency Property | Style          | NA              |
+----------------------+----------------------------------------------------------------------------------------+---------------------+----------------+-----------------+
| ToolBarState         | Gets or sets the state of the toolbar.                                                 | Attached Property   | ToolBarState   | NA              |
|                      |                                                                                        |                     |                |                 |
|                      |                                                                                        |                     |                |                 |
+----------------------+----------------------------------------------------------------------------------------+---------------------+----------------+-----------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[]{#related-topics}
::::::

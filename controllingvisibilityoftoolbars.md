::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### [Controlling Visibility of Toolbars]{style="FONT-WEIGHT: normal"} {#controlling-visibility-of-toolbars style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To control the visibility of the various toolbars, the appropriate **ShowToolbarXXX** property must be set.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  --------------------- --------------------------------------------------------------------------------------------
  Property              Description
  ShowDesignToolbar     Gets / sets the boolean value to show / hide the Design toolbar. Default value is True.
  ShowEditToolBar       Gets / sets the boolean value to show / hide the Edit toolbar. Default value is True.
  ShowFormatToolBar     Gets / sets the boolean value to show / hide the Format toolbar. Default value is True.
  ShowHelpToolBar       Gets / sets the boolean value to show / hide the Help toolbar. Default value is False.
  ShowInsertToolBar     Gets / sets the boolean value to show / hide the Insert toolbar. Default value is True.
  ShowStandardToolBar   Gets / sets the boolean value to show / hide the Standard toolbar. Default value is False.
  ShowStyleToolBar      Gets / sets the boolean value to show / hide the Style toolbar. Default value is True.
  ShowTableToolbar      Gets / sets the boolean value to show / hide the Table toolbar. Default value is True.
  ShowToolsToolBar      Gets / sets the boolean value to show / hide the Tools toolbar. Default value is False.
  --------------------- --------------------------------------------------------------------------------------------
:::

 

Controlling Visibility of Toolbar icons

Toolbar icons can be customized using code behind by accessing the items of the Toolbars, in order to enable/disable the visibility.

[Programmatically, the Toolbar icons can be customized as given in the following codes:]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                           |
|  [//ToolBars\[3\] refers \'Insert\' Toolbar of the RichTextEditor control.\                                                                                                                                                                                               |
| ]{style="FONT-FAMILY: 'Courier New'"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'"}[RichTextEditor1.ToolBars\[3\].Items\[0\].Visible = false;// Item\[0\] refers \'smiley\' icon.\                                        |
| ]{style="FONT-FAMILY: 'Courier New'"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'"}[RichTextEditor1.ToolBars\[3\].Items\[3\].Visible = false;// Item\[3\] refers \'pagebreak\' icon.]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                        |
| [\'ToolBars\[3\] refers \'Insert\' Toolbar of the RichTextEditor control.\                                                                                                                                                                                             |
| ]{style="FONT-FAMILY: 'Courier New'"}[Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'"}[RichTextEditor1.ToolBars\[3\].Items\[0\].Visible = false \'Item\[0\] refers \'smiley\' icon.\                                        |
| ]{style="FONT-FAMILY: 'Courier New'"}[Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'"}[RichTextEditor1.ToolBars\[3\].Items\[3\].Visible = false \'Item\[3\] refers \'pagebreak\' icon.]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[cc1]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[RichTextEditor]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [ID]{style="COLOR: red"}[=\"RichTextEditor1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\" ]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[OnClientLoad]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"CustomizeIcons()]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[Toolbar icons can be customized using Java script function as given in the following code:]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[ \[JavaScript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ CustomizeIcons() ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ RTE_id = [\'\<%=this.RTE.ClientID%\>\']{style="COLOR: #a31515"};[//Retrieves the id of RTE control]{style="COLOR: green"}            document.getElementById(RTE_id+[\'\_Insert\_\_InsertSmiley\']{style="COLOR: #a31515"}).style.display = [\'none\']{style="COLOR: #a31515"}; [//Hides the smiley icon of Insert toolbar]{style="COLOR: green"}            document.getElementById(RTE_id+[\'\_Insert\_\_InsertPageBreak\']{style="COLOR: #a31515"}).style.display = [\'none\']{style="COLOR: #a31515"}; [//Hides the Pagebreak icon of Insert toolbar]{style="COLOR: green"}            ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

See Also

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[Toolbar Commands]{.UGHyperlink}[]{.UGHyperlink}

 

[]{#related-topics}
::::

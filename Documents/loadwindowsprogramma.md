::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Load windows programmatically in a particular layout

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Any complex layout can be created in your DockingManager framework. You have to specify whether a control should be docked, floating, autohidden or hidden through **DockState** property.  The position (Left, Right, Top, Bottom or Tabbed) where it should be docked should also be specified using **SideInDockedMode** and **SideInFloatingMode** property.

If you want to dock a control to the side of other control, you have to specify the target window's WindowName. It can be set through **TargetNameInFloatMode** and **TargetNameInDockedMode** properties.

Refer also:

*[[ ]{style="FONT-SIZE: 14pt"}]{.underline}*

**[Methods]{.UGHyperlink}

*[[[]{style="TEXT-DECORATION: none"}]{style="FONT-SIZE: 14pt"}]{.underline}* 

  --------------------- ----------------------------------------------------------- ------------------ -------------- ------------------------------------------------------------------------
  Method                Description                                                 Return Type        Parameters     Reference
  ActivateWindow        Activates a specified window.                               void               Window name    How to activate a particular window
  GetWindow             Gets the window.                                            Window             UIElement      How to get docking window from instance of the given element
  IsInSameTabbedGroup   Determines whether two elements are in same tabbed group.   bool- True/False   Two Elements   How to determine whether any two controls are in the same tabbed group
  GetTabControl         Gets the tab control for an element.                        CustomTabControl   Element        How to get the tabbed docking group details
  --------------------- ----------------------------------------------------------- ------------------ -------------- ------------------------------------------------------------------------

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Creating Dock Controls Using DockingManager through XAML*[[]{style="FONT-SIZE: 14pt"}]{.underline}*

**[:**]{style="FONT-SIZE: 14pt"}

[[]{.UGHyperlink}[Creating Dock Controls Using DockingManager through C#]{.UGHyperlink}[]{.UGHyperlink}]{.UGHyperlink}[]{.UGHyperlink}[]{.UGHyperlink}

[[]{.UGHyperlink}[Nested Docking]{.UGHyperlink}[]{.UGHyperlink}]{.UGHyperlink}[]{.UGHyperlink}[]{.UGHyperlink}

[[]{.UGHyperlink}[Tabbed Docking]{.UGHyperlink}[]{.UGHyperlink}]{.UGHyperlink}[]{.UGHyperlink}[]{.UGHyperlink}

[[]{.UGHyperlink}[Nested Floating]{.UGHyperlink}[]{.UGHyperlink}]{.UGHyperlink}[]{.UGHyperlink}[]{.UGHyperlink}

[[]{.UGHyperlink}[DockFill Mode]{.UGHyperlink}[]{.UGHyperlink}]{.UGHyperlink}[]{.UGHyperlink}[]{.UGHyperlink}

[[]{.UGHyperlink}[Autohide and Hide]{.UGHyperlink}[]{.UGHyperlink}]{.UGHyperlink}[]{.UGHyperlink}[]{.UGHyperlink}

[[]{.UGHyperlink}[Tabbed Floating]{.UGHyperlink}[]{.UGHyperlink}]{.UGHyperlink}[]{.UGHyperlink}[]{.UGHyperlink}

[]{#related-topics}
:::

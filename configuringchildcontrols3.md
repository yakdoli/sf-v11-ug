::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Configuring Child Controls {#configuring-child-controls style="tab-stops: 0pt"}

[]{#p831} 

The following settings can be used to configure the Child controls of the GridLayout Manager.

[]{style="COLOR: #15428b"} 

ParticipateInLayout

[]{style="COLOR: #15428b"} 

To prevent a Child control from being laid out using the GridLayout Manager, the below given property can be used.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  ------------------------ -----------------------------------------------------------------------------------------------------------------
  Child Control Property   Description
  ParticipateInLayout      Specifies whether the Child control should participate in the GridLayout. The default value is set to \'True\'.
  ------------------------ -----------------------------------------------------------------------------------------------------------------
:::

[]{style="COLOR: #15428b"} 

The methods associated with the above property are given below.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  ------------------------ -------------------------------------------------------------
  Methods                  Description
  GetParticipateInLayout   Indicates whether the component is in the layout list.
  SetParticipateInLayout   Adds or removes the specified control from the layout list.
  ------------------------ -------------------------------------------------------------
:::

[]{style="COLOR: #15428b"} 

The following code can be used to add or remove the control from the GridLayout list programmatically.

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                      |
|                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                |
|                                                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridLayout1.SetParticipateInLayout([this]{style="COLOR: blue"}.button1,[false]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                             |
|                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                           |
|                                                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.gridLayout1.SetParticipateInLayout([Me]{style="COLOR: blue"}.button1,[False]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

See Also

[]{style="COLOR: #15428b"} 

[Configuring GridLayout]{.UGHyperlink}[, ]{.UGHyperlink}[Rearranging the Controls laid out by GridLayout]{.UGHyperlink}[, ]{.UGHyperlink}[[GridLayout - Configuring Child Controls]{.UGHyperlink}]()[]{.UGHyperlink}

[]{#related-topics}
:::::

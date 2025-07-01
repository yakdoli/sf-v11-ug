::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Behavior Settings {#behavior-settings style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Parent item settings

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

While expanding a groupbar parent item, you can set the control to collapse all the other open parent items, expanding only a single, currently selected parent item. To apply this behavior to the control, the **ExpandSingleGroup** property must be set to **True**.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------- ---------------------------------------------------------------------------------------
  GroupBar Property   Description
  ExpandSingleGroup   Specifies if only a single group should be expanded at a time. Default value is True.
  ------------------- ---------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Space settings for parent items

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To set default space between the parent items, the **DefaultTopItemSpacing** property can be set with the value which has to be applied as the space between the items.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ----------------------- ------------------------------------------------------------
  GroupBar Property       Description
  DefaultTopItemSpacing   Specifies the default spacing between the top level items.
  ----------------------- ------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Item States

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The states of the items can be handled and customized as you require it to be displayed in the Designer dialog by setting it for the required items.

 

The **Expanded** property when set, expands that item by default. By setting the **Disabled** property, the item will not respond to the user actions. The **Selected** property when set for an item, it will be selected by default.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------------ ----------------------------------------------------------------------------------------
  GroupBar Item Property   Description
  Disabled                 Gets/sets the boolean value to disable the state of an item. Default value is false.
  Expanded                 Gets/sets the boolean value, to expand the groupbar structure. Default value is false.
  Selected                 Gets/sets the boolean value to set the focus on the item. Default value is false.
  ------------------------ ----------------------------------------------------------------------------------------
:::

 

[]{#related-topics}
::::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Visual Inheritance Support {#visual-inheritance-support style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

XP Menus supports Visual Inheritance during design-time, which means you can set up XP Menus in a form and also continue to set up in the form derived from it. The corresponding components like the BarManager and toolbar should however be protected or public for this to be supported. In the derived form\'s designer, you can add new bar items to the bar manager and then add these items to the toolbar, submenu etc.

 

These are things you can do in a derived form in Visual Inheritance mode.

[]{style="COLOR: #15428b"} 

[·      ]{style="FONT-FAMILY: Symbol"}Add new BarItems created in the derived form to any toolbar, ParentBarItem, anywhere.

[·      ]{style="FONT-FAMILY: Symbol"}Reposition the existing BarItems within a toolbar or ParentBarItem.

[·      ]{style="FONT-FAMILY: Symbol"}Remove an existing group setting and add a new group setting.

[]{style="COLOR: #15428b"} 

These are the **limitations** of Visual Inheritance mode.

[]{style="COLOR: #15428b"} 

[·      ]{style="FONT-FAMILY: Symbol"}Cannot add menu items created in a base form to any bars/submenus in a derived form.

[·      ]{style="FONT-FAMILY: Symbol"}When the items in a base form\'s toolbar/submenu are repositioned, any previous repositioning that occurred in the derived form will be lost and the results may be unpredictable.

[]{#related-topics}
:::

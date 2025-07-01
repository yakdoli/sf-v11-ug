::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Customization of Navigation {#customization-of-navigation style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The customization of this default navigation can be done by using the properties, methods and events mentioned below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Properties

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following table lists the properties associated with this feature.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ----------------------- ------------ ------------------------------------------------------------------------------------------------------ ----------------- ----------------------
  Property                Type         Description                                                                                            Value Accepted    Property Syntax
  IncrementKey            Dependency   Increase the pointer value.                                                                            Key               Propertyname=Key.key
  DecrementKey            Dependency   Decrease the pointer value.                                                                            Key               Propertyname=Key.key
  PointerSelectionBrush   Dependency   Allows differentiation of the pointer when it is focused and unfocused by changing the border color.   SolidColorBrush   Propertyname=color
  ----------------------- ------------ ------------------------------------------------------------------------------------------------------ ----------------- ----------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Methods

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following table lists the methods associated with this feature.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ----------- -----------------------------------------------
  Method      Description
  KeyDown     Changes the value with appropriate key press.
  GotFocus    Selection is made when pointer gets focus.
  LostFocus   Pointer loses focus.
  ----------- -----------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Events

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

The following table lists the events associated with this feature.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------------------ --------------- ------------------------------------------------------- --------------------------- -----------------------------------
  Event                          Event Trigger   Method Handling Event                                   Event Argument              Purpose
  PointerSelectionBrushChanged   OnGotFocus      CircularPointer_GotFocus and LinearPointer\_ GotFocus   (object, RoutedEventArgs)   Highlights the pointer selection.
  IncreamentKeyChanged           OnKeyDown       CircularPointer_KeyDown and LinearPointer_KeyDown       (object, KeyEventArgs)      Changes the Pointer value.
  DecreamentKeyChanged           OnKeyDown       CircularPointer_KeyDown and LinearPointer_KeyDown       (object, KeyEventArgs)      Changes the Pointer value.
  ------------------------------ --------------- ------------------------------------------------------- --------------------------- -----------------------------------
:::

 

[]{#p97} 

 

[]{#related-topics}
::::::

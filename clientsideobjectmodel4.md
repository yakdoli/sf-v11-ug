::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Client-Side Object Model {#client-side-object-model style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Client-Side Object Methods

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

::: {align="center"}
  --------------- ------------- ------------ ----------------------------------------------
  Method          Parameter     ReturnType   Description
  IsPopupShown    \-            bool         Specifies whether popup container is shown.
  SetChecked      oItem, bVal                Specifies whether item must be checked
  IsPopupHidden   \-            bool         Specifies whether popup container is hidden.
  ShowPopup       \-            \-           Shows popup container.
  HidePopup       \-            \-           Hides popup container.
  SetText         string        \-           Sets the control text.
  GetText         \-            string       Gets the control text.
  --------------- ------------- ------------ ----------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Client Event Data

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ---------- ------------- -------------------------------------------------------
  Property   Type          Description
  TextEl     HTMLElement   Represents HTML text box element
  PopupEl    HTMLElement   Represents HTML popup container.
  Button     HTMLElement   Represents HTML button element.
  Instance   object        Represents MultiselectionDropDown client-side object.
  Event      object        Represents event.
  Text       string        Specifies the text in textbox.
  OldText    string        Specifies the old text in textbox before change.
  ---------- ------------- -------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Sample

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

MultiSelectionDropDown.OnItemCheckChanged Event

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------+
| **[\[Javascript\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                              |
|                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}                                                   |
|                                                                                                                       |
| [function OnItemChecked(Odata)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                   |
|                                                                                                                       |
| [{ ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                              |
|                                                                                                                       |
| [    selIdx=\"CurrentItem Index:\"+Odata.CheckChangedItem.Index;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                       |
| [    DisplayDatas(\"CheckedItem\",selIdx);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                       |
|                                                                                                                       |
| [    selText=\"Selected Books:\"+Odata.NewText;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                  |
|                                                                                                                       |
| [    DisplayDatas(\"TextItem\",selText);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                         |
|                                                                                                                       |
| [      ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                          |
|                                                                                                                       |
| [}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                               |
+-----------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::::

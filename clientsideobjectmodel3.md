::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Client-Side Object Model {#client-side-object-model style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  --------------- ------------ ------------- ----------------------------------------------
  Method          Parameters   Return Type   Description
  IsPopupShown    \-           bool          Specifies whether popup container is shown.
  IsPopupHidden   \-           bool          Specifies whether popup container is hidden.
  ShowPopup       \-           \-            Shows popup container.
  HidePopup       \-           \-            Hides popup container.
  SetText         string       \-            Sets the control text.
  GetText         \-           string        Gets the control text.
  --------------- ------------ ------------- ----------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

ClienEventData Object Properties

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ---------- ------------- -----------------------------------------------------------------------------------------------------------------
  Property   Type          Description
  TextEl     HTMLElement   Represents HTML text box element.
  PopupEl    HTMLElement   Represents HTML popup container.
  Button     HTMLElement   Represents HTML button element.
  Instance   object        Represents MultiColumnDropDownCombo client-side object.
  Event      object        Represents event.
  Text       string        Specifies the text in textbox.
  OldText    string        Specifies the old text in textbox before change (it is only for **ClientSideOnTextChanged** client side event).
  ---------- ------------- -----------------------------------------------------------------------------------------------------------------
:::

 

[]{#related-topics}
:::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Maximum and Minimum Validation {#maximum-and-minimum-validation style="tab-stops: 0pt"}

 

The UpDown control supports maximum and minimum validation. If MaxValidation or MinValidation is set to OnLostFocus, then the value in the UpDown control will be validated when the UpDown control loses focus. After validation, if the value of the UpDown control is greater than MaxValue or lesser than MinValue, the value of the Value property will automatically be set to MaxValue or MinValue respectively.

If MaxValidation or MinValidation is set to OnKeyPress, then the value in the UpDown control will be validated when editing the value in the UpDown control. After validation, if the value of the Value property is greater than MaxValue or lesser than MinValue, users will not be able to edit the UpDown control.

If the MaxValueOnExceedMaxDigit property is enabled and MaxValidation is set to OnKeyPress, then MaxValue will be assigned to the Value property when the value is greater than MaxValue. However, if the MaxValueOnExceedMaxDigit property is disabled, you will not be able to enter text in the UpDown control when the value is greater than MaxValue.

Similarly, if the MinValueOnExceedMinDigit property is enabled and MinValidation is set to OnKeyPress, then MinValue will be assigned to the Value property when the value is lesser than MinValue. However, if the MinValueOnExceedMinDigit property is disabled, you will not be able to enter text in the UpDown control when the value is lesser than MinValue.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Using MaxValidation and MinValidation

MaxValidation and MinValidation can be set for the UpDown control, as shown in the following code snippets.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[UpDown]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"upDown\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ MaxValue]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"100\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ MinValue]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"0\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ MaxValidation]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"OnLostFocus\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ MinValidation]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"OnKeyPress\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ MaxValueOnExceedMaxDigit]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"True\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ MinValueOnExceedMinDigit]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"True\"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                           |
|                                                                                                                                                                            |
| [UpDown]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ upDown = [new]{style="COLOR: blue"} [UpDown]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                            |
| [upDown.MaxValue = 100;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                            |
| [upDown.MinValue = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                            |
| [upDown.MaxValidation = [MaxValidation]{style="COLOR: #2b91af"}.OnLostFocus;]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                            |
| [upDown.MinValidation = [MinValidation]{style="COLOR: #2b91af"}.OnKeyPress;]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                            |
| [upDown.MaxValueOnExceedMaxDigit = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                            |
| [upDown.MinValueOnExceedMinDigit = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: Consolas"}                                                                                                                                          |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Tables for Properties, and Events

Properties

Table 38: Properties Table

  -------------------------- ---------------------------------------------------------------------------------------------------------------------------------------------------- -------------------- --------------- -----------------
  Property                   Description                                                                                                                                          Type                 Data Type       Reference links
  MaxValidation              Gets or sets MaxValidation.                                                                                                                          DependencyProperty   MaxValidation   Not applicable
  MinValidation              Gets or sets MinValidation.                                                                                                                          DependencyProperty   MinValidation   Not applicable
  MaxValueOnExceedMaxDigit   Gets or sets a value that indicates whether to assign MaxValue to the Value property when the value of the Value property exceeds MaxValue.          DependencyProperty   bool            Not applicable
  MinValueOnExceedMinDigit   Gets or sets a value that indicates whether to assign MinValue to the Value property when the value of the Value property is lesser than MinValue.   DependencyProperty   bool            Not applicable
  -------------------------- ---------------------------------------------------------------------------------------------------------------------------------------------------- -------------------- --------------- -----------------

 

Events

Table 39: Events Table

+----------------------+---------------------------------------+-------------------------------------+-------------------------+-----------------+
| Event                | Description                           | Arguments                           | Type                    | Reference links |
+----------------------+---------------------------------------+-------------------------------------+-------------------------+-----------------+
| MinValidationChanged | Occurs when MinValidation is changed. | DependencyObject and                | PropertyChangedCallback | Not applicable  |
|                      |                                       |                                     |                         |                 |
|                      |                                       | DependencyPropertyChangedEventArgs. |                         |                 |
+----------------------+---------------------------------------+-------------------------------------+-------------------------+-----------------+
| MaxValidationChanged | Occurs when MaxValidation is changed. | DependencyObject and                | PropertyChangedCallback | Not applicable  |
|                      |                                       |                                     |                         |                 |
|                      |                                       | DependencyPropertyChangedEventArgs. |                         |                 |
+======================+=======================================+=====================================+=========================+=================+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

[]{#related-topics}
:::

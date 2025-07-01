::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=14ff78aa-20af-4785-b978-5459def89b31){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=40709056-b517-45c5-abf9-a46912a82d0a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pdf](ms-xhelp:///?Id=22756092-3da5-4797-9514-dab0617c6902){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=b2064337-afd6-4241-aa41-868a5489a8dd){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[PDF Form](ms-xhelp:///?Id=6810af81-86b3-43ff-8491-672a44cde746){.d2h_breadcrumbsNormal}
:::

### Form Fields {#form-fields style="tab-stops: 0pt"}

 

An interactive form is a collection of fields for gathering information interactively from the user. A PDF document may contain any number of fields appearing on any combination of pages, all of which makes up a single global interactive form spanning the entire document. Arbitrary subsets of these fields can be imported or exported from the document.

 

You can change the form\'s properties, add new fields or remove existing fields. Also you can flatten the loaded field by using the Flatten property.

 

This section covers the following:

 

[·      ]{style="FONT-FAMILY: Symbol"}Form Fields Creation

[·      ]{style="FONT-FAMILY: Symbol"}Editing Form Fields

 

Form Fields Creation

 

The following classes are used to create Form Fields.

 

::: {align="center"}
  ------------------------- -----------------------------------------------------------------
  Class                     Description
  PdfButtonField            Creates Button (Submit Button and Reset button can be created).
  PdfCheckBoxField          Creates Check Box.
  PdfComboBoxField          Creates Combo Box.
  PdfListFieldItem          Creates list items from Combo Box and List Box.
  PdfListBoxField           Creates List Box.
  PdfTextBoxField           Creates Text Box.
  PdfRadioButtonListField   Creates Radio button list.
  PdfRadioButtonListItem    Creates Radio button list item.
  ------------------------- -----------------------------------------------------------------
:::

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

Button field

 

A button field represents an interactive control on the screen that the user can manipulate using the mouse. PdfButtonField class is used to create Buttons fields.

 

The most important feature of PDF form is the ability to send entered data to a server. To perform this action you should create an action of SubmitAction type, and specify a valid data processing script URL. The action must be assigned to a MouseUp action of the submit button.

 

![](ImagesExt/image22_0.jpg){border="0"} ResetAction is used to restore the default values of the fields or simply clear them.

 

The following code example illustrates how to create a button field.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                     |
| [// Creating a Button ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                                     |
| [PdfButtonField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ button = [new]{style="COLOR: blue"} [PdfButtonField]{style="COLOR: teal"}(page, [\"Click\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                                                                     |
| [button.Bounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}(0, 420, 90, 20);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                                     |
| [button.Text = [\"Click\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                     |
| [loadedDoc.Form.Fields.Add(button);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                     |
| [// Creating Submit action button]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                     |
| [PdfSubmitAction]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ submitAction = [new]{style="COLOR: blue"} [PdfSubmitAction]{style="COLOR: teal"}([\"http://stevex.net/dump.php\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                     |
| [submitAction.DataFormat = [SubmitDataFormat]{style="COLOR: teal"}.Html;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                     |
| [//Create submit button to transfer the values in the form]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                       |
|                                                                                                                                                                                                                                                     |
| [PdfButtonField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ submitButton = [new]{style="COLOR: blue"} [PdfButtonField]{style="COLOR: teal"}(page, [\"submitButton\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                                                                     |
| [submitButton.Bounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}(100, 420, 90, 20);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                                                     |
| [submitButton.Font = font;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                     |
| [submitButton.Text = [\"Submit\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                     |
| [// Assigning the submit action]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                                     |
| [submitButton.Actions.MouseUp = submitAction;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                     |
| [// Adding the Field            ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                                     |
| [loadedDoc.Form.Fields.Add(submitButton);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                           |
| [\' Creating a Button ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ button [As]{style="COLOR: blue"} PdfButtonField = [New]{style="COLOR: blue"} PdfButtonField(page, [\"Click\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                                                                           |
| [button.Bounds = [New]{style="COLOR: blue"} RectangleF(0, 420, 90, 20)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                                                           |
| [button.Text = [\"Click\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                                                                           |
| [loadedDoc.Form.Fields.Add(button)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                           |
| [\' Creating Submit action button]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ submitAction [As]{style="COLOR: blue"} PdfSubmitAction = [New]{style="COLOR: blue"} PdfSubmitAction([\"http://stevex.net/dump.php\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                           |
| [submitAction.DataFormat = SubmitDataFormat.Html]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                           |
| [\'Create submit button to transfer the values in the form]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                             |
|                                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ submitButton [As]{style="COLOR: blue"} PdfButtonField = [New]{style="COLOR: blue"} PdfButtonField(page, [\"submitButton\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                                                                           |
| [submitButton.Bounds = [New]{style="COLOR: blue"} RectangleF(100, 420, 90, 20)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                                                                           |
| [submitButton.Font = font]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                           |
| [submitButton.Text = [\"Submit\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                           |
| [\' Assigning the submit action]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                                           |
| [submitButton.Actions.MouseUp = submitAction]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                           |
| [\' Adding the Field            ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                                           |
| [loadedDoc.Form.Fields.Add(submitButton)        ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Essential PDF enables to add a Print Button to the form. Clicking the print button, initializes a print dialog. The following code example illustrates this.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                        |
|                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                       |
| [// Create a print button]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                          |
|                                                                                                                                                                                                       |
| [PdfButtonField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ print = [new]{style="COLOR: blue"} PdfButtonField(page, [\"print\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                       |
| [print.Bounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: #2b91af"}(200, 25, 90, 15);]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                       |
| [print.Text = [\"Print\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                       |
| [print.AddPrintAction();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [\'Create a print button]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                       |
|                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ print [As]{style="COLOR: blue"} PdfButtonField = [New]{style="COLOR: blue"} PdfButtonField(page, [\"print\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                   |
| [print.Bounds = [New]{style="COLOR: blue"} RectangleF(200, 25, 90, 15)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                                   |
| [print.Text = [\"Print\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                                                   |
| [print.AddPrintAction()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Check Box Field

 

A check box field represents one or more check boxes that toggle between two states, ON and OFF. The check box state is manipulated by the user using the mouse or keyboard[. ]{style="FONT-FAMILY: 'EDJOL N+ Minion Pro'; COLOR: black"}

 

**PdfCheckBoxField** class is used to create a check box in PDF forms. You can customize the check box style by using properties such as **BorderStyle**, **HighlightMode**, **BorderWidth** and so on.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                    |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [//Create a check box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                          |
|                                                                                                                                                                                                                                   |
| [PdfCheckBoxField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ checkBox = [new]{style="COLOR: blue"} [PdfCheckBoxField]{style="COLOR: teal"}(page, [\".NET\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                   |
| [//Set properties]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                              |
|                                                                                                                                                                                                                                   |
| [checkBox.Bounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}(100, 290, 20, 20);]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                                   |
| [checkBox.HighlightMode = [PdfHighlightMode]{style="COLOR: teal"}.Push;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                                   |
| [checkBox.BorderStyle = [PdfBorderStyle]{style="COLOR: teal"}.Beveled;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                   |
| [//Set the value for the check box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                             |
|                                                                                                                                                                                                                                   |
| [checkBox.Checked = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                                                   |
| [g.DrawString([\".NET\"]{style="COLOR: maroon"}, font, brush, [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}(150, 290, 180, 20));]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                                                                   |
| [loadedDoc.Form.Fields.Add(checkBox);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                      |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                         |
| [\'Create a check box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                |
|                                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ checkBox [As]{style="COLOR: blue"} PdfCheckBoxField = [New]{style="COLOR: blue"} PdfCheckBoxField(page, [\".NET\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                         |
| [\'Set properties]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                    |
|                                                                                                                                                                                                                                         |
| [checkBox.Bounds = [New]{style="COLOR: blue"} RectangleF(100, 290, 20, 20)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                                                         |
| [checkBox.HighlightMode = PdfHighlightMode.Push]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                                         |
| [checkBox.BorderStyle = PdfBorderStyle.Beveled]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                         |
| [\'Set the value for the check box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| [checkBox.Checked = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                                         |
| [g.DrawString([\".NET\"]{style="COLOR: maroon"},font,brush,[New]{style="COLOR: blue"} RectangleF(150,290,180,20))]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                                                         |
| [loadedDoc.Form.Fields.Add(checkBox)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

PdfComboBox Field

 

A combo box represents a drop-down list, optionally accompanied by an editable text box in which the user can type a value other than the predefined choices. PdfComboBoxField class is used to create a combo box field in PDF forms. You can add list of items to the combo box by using the PdfListFieldItem class.

 

   The following code example illustrates this.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                 |
| [//Create a combo box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                 |
| [PdfComboBoxField]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ positionComboBox = [new]{style="COLOR: blue"} [PdfComboBoxField]{style="COLOR: #2b91af"}(page, [\"positionComboBox\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [//Set properties]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [positionComboBox.Bounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: #2b91af"}(100, 115, 200, 20);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                                                                 |
| [positionComboBox.Font = font;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                 |
| [// Setting the combobox as editable]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                 |
| [positionComboBox.Editable = [true]{style="COLOR: blue"};            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [//Add combobox to document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                 |
| [loadedDoc.Form.Fields.Add(positionComboBox);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                 |
| [//Create the field item to be added in the combobox]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                 |
| [PdfListFieldItem]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ item1 = [new]{style="COLOR: blue"} [PdfListFieldItem]{style="COLOR: #2b91af"}([\"Developer\"]{style="COLOR: #a31515"}, [\"Developer\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                                                                                 |
| [PdfListFieldItem]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ item2 = [new]{style="COLOR: blue"} [PdfListFieldItem]{style="COLOR: #2b91af"}([\"Accountant\"]{style="COLOR: #a31515"}, [\"Accountant\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                 |
| [//Add the items in combo box.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                 |
| [positionComboBox.Items.Add(item1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                 |
| [positionComboBox.Items.Add(item2);  ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                               |
| [\'Create a combo box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ positionComboBox [As]{style="COLOR: blue"} PdfComboBoxField = [New]{style="COLOR: blue"} PdfComboBoxField(page, [\"positionComboBox\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                               |
| [\'Set properties]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                               |
| [positionComboBox.Bounds = [New]{style="COLOR: blue"} RectangleF(100, 115, 200, 20)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                                                                               |
| [positionComboBox.Font = font]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                               |
| [\' Setting the combobox as editable]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                               |
| [positionComboBox.Editable = [True]{style="COLOR: blue"}            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                               |
| [\'Add combobox to document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                               |
| [loadedDoc.Form.Fields.Add(positionComboBox)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                               |
| [\'Create the field item to be added in the combobox]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ item1 [As]{style="COLOR: blue"} PdfListFieldItem = [New]{style="COLOR: blue"} PdfListFieldItem([\"Developer\"]{style="COLOR: maroon"}, [\"Developer\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ item2 [As]{style="COLOR: blue"} PdfListFieldItem = [New]{style="COLOR: blue"} PdfListFieldItem([\"Accountant\"]{style="COLOR: maroon"}, [\"Accountant\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                               |
| [\'Add the items in combobox.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                               |
| [positionComboBox.Items.Add(item1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                               |
| [positionComboBox.Items.Add(item2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

PdfListBoxField

 

A scrollable List Box contains several text items, one or more of which may be selected as the field value. **PdfListBoxField** is used to create the ListBox field in PDF forms.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                         |
|                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                        |
| [//Create list box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                        |
| [PdfListBoxField]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ listBox = [new]{style="COLOR: blue"} [PdfListBoxField]{style="COLOR: #2b91af"}(page, [\"list1\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                        |
| [//Set the properties.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                              |
|                                                                                                                                                                                                                                        |
| [listBox.Bounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: #2b91af"}(100, 350, 100, 50);]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                                        |
| [listBox.HighlightMode = [PdfHighlightMode]{style="COLOR: #2b91af"}.Outline;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                        |
| [//Add the items to the list box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                    |
|                                                                                                                                                                                                                                        |
| [listBox.Items.Add([new]{style="COLOR: blue"} [PdfListFieldItem]{style="COLOR: #2b91af"}([\"English\"]{style="COLOR: #a31515"}, [\"English\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                                        |
| [listBox.Items.Add([new]{style="COLOR: blue"} [PdfListFieldItem]{style="COLOR: #2b91af"}([\"French\"]{style="COLOR: #a31515"}, [\"French\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                                        |
| [listBox.Items.Add([new]{style="COLOR: blue"} [PdfListFieldItem]{style="COLOR: #2b91af"}([\"German\"]{style="COLOR: #a31515"}, [\"German\"]{style="COLOR: #a31515"}));]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                        |
| [//Select the item]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                        |
| [listBox.SelectedIndex = 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                        |
| [//Set the multiselect option]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                       |
|                                                                                                                                                                                                                                        |
| [listBox.MultiSelect = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                                        |
| [loadedDoc.Form.Fields.Add(listBox);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                    |
|                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                       |
| [\'Create list box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ listBox [As]{style="COLOR: blue"} PdfListBoxField = [New]{style="COLOR: blue"} PdfListBoxField(page, [\"list1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                       |
| [\'Set the properties.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                             |
|                                                                                                                                                                                                                                       |
| [listBox.Bounds = [New]{style="COLOR: blue"} RectangleF(100, 350, 100, 50)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                                       |
| [listBox.HighlightMode = PdfHighlightMode.Outline]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                       |
| [\'Add the items to the list box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                   |
|                                                                                                                                                                                                                                       |
| [listBox.Items.Add([New]{style="COLOR: blue"} PdfListFieldItem([\"English\"]{style="COLOR: maroon"},[\"English\"]{style="COLOR: maroon"}))]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                                       |
| [listBox.Items.Add([New]{style="COLOR: blue"} PdfListFieldItem([\"French\"]{style="COLOR: maroon"},[\"French\"]{style="COLOR: maroon"}))]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                                                       |
| [listBox.Items.Add([New]{style="COLOR: blue"} PdfListFieldItem([\"German\"]{style="COLOR: maroon"},[\"German\"]{style="COLOR: maroon"}))]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                       |
| [\'Select the item]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                       |
| [listBox.SelectedIndex = 2]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                       |
| [\'Set the multiselect option]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                      |
|                                                                                                                                                                                                                                       |
| [listBox.MultiSelect = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                                       |
| [loadedDoc.Form.Fields.Add(listBox)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: You can create multiple options from the ListBox by setting the MultiSelect option to True.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

TextBox field

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

A text field is a box or space in which the user can enter text through the keyboard. The text can be restricted to a single line or permitted to span multiple lines, depending on the setting of the Multiline flag. **PdfTextBoxField** class is used to create a textbox field in PDF forms. This class also provides support to create password and multilined text boxes.

 

  The following code example illustrates this.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [//Create a text box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                            |
| [PdfTextBoxField]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ firstNameTextBox = [new]{style="COLOR: blue"} [PdfTextBoxField]{style="COLOR: #2b91af"}(page, [\"firstNameTextBox\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [//Set properties]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                            |
| [firstNameTextBox.Bounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: #2b91af"}(100, 20, 200, 20);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                                                            |
| [firstNameTextBox.Font = font;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                            |
| [firstNameTextBox.Password = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                            |
| [firstNameTextBox.Multiline = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                            |
| [//Add the text box in document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                            |
| [loadedDoc.Form.Fields.Add(firstNameTextBox);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                           |
| [\'Create a text box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ firstNameTextBox [As]{style="COLOR: blue"} PdfTextBoxField = [New]{style="COLOR: blue"} PdfTextBoxField(page, [\"firstNameTextBox\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                           |
| [\'Set properties]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                           |
| [firstNameTextBox.Bounds = [New]{style="COLOR: blue"} RectangleF(100, 20, 200, 20)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                                                           |
| [firstNameTextBox.Font = font]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                           |
| [firstNameTextBox.Password = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                           |
| [firstNameTextBox.Multiline = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                           |
| [\'Add the text box in document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                                           |
| [loadedDoc.Form.Fields.Add(firstNameTextBox)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Radio Button field

 

Radio button fields contain a set of related buttons that can each be set to ON or OFF. Typically, at most, one radio button in a set can be ON at any given time, and selecting any one of the buttons automatically de-selects all the others.[ ]{style="FONT-FAMILY: 'EDJOL N+ Minion Pro'; COLOR: black"}PdfRadioButtonListField class is used to create a radio button in the PDF Forms. You can create the radio button list items by using the PdfRadioButtonListItem class.

 

The following code example illustrates how to create radio buttons.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                            |
| [ //Create a Radio button]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                            |
| [PdfRadioButtonListField]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ employeesRadioList = [new]{style="COLOR: blue"} [PdfRadioButtonListField]{style="COLOR: #2b91af"}(page, [\"employeesRadioList\"]{style="COLOR: #a31515"});            ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                            |
| [loadedDoc.Form.Fields.Add(employeesRadioList);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                            |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                            |
| [ [//Create radio button items ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                            |
| [PdfRadioButtonListItem]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ radioItem1 = [new]{style="COLOR: blue"} [PdfRadioButtonListItem]{style="COLOR: #2b91af"}([\"1-9\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                                                                                                                            |
| [radioItem1.Bounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: #2b91af"}(100, 140, 20, 20);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                                                                                            |
| [g.DrawString([\"1-9\"]{style="COLOR: #a31515"}, font, brush, [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: #2b91af"}(150, 145, 180, 20));]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                            |
| [PdfRadioButtonListItem]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ radioItem2 = [new]{style="COLOR: blue"} [PdfRadioButtonListItem]{style="COLOR: #2b91af"}([\"10-49\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                                                                                                            |
| [radioItem2.Bounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: #2b91af"}(100, 170, 20, 20);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                                                                                                                            |
| [g.DrawString([\"10-49\"]{style="COLOR: #a31515"}, font, brush, [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: #2b91af"}(150, 175, 180, 20));           ]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                            |
| [ [//add the items to radio button group]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                            |
| [employeesRadioList.Items.Add(radioItem1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                            |
| [employeesRadioList.Items.Add(radioItem2);            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                               |
| [\'Create a Radio button]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ employeesRadioList [As]{style="COLOR: blue"} PdfRadioButtonListField = [New]{style="COLOR: blue"} PdfRadioButtonListField(page, [\"employeesRadioList\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                               |
| [loadedDoc.Form.Fields.Add(employeesRadioList)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                               |
| [\'Create radio button items ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ radioItem1 [As]{style="COLOR: blue"} PdfRadioButtonListItem = [New]{style="COLOR: blue"} PdfRadioButtonListItem([\"1-9\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                                                                                                               |
| [radioItem1.Bounds = [New]{style="COLOR: blue"} RectangleF(100, 140, 20, 20)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                                               |
| [g.DrawString([\"1-9\"]{style="COLOR: maroon"},font,brush,[New]{style="COLOR: blue"} RectangleF(150,145,180,20))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ radioItem2 [As]{style="COLOR: blue"} PdfRadioButtonListItem = [New]{style="COLOR: blue"} PdfRadioButtonListItem([\"10-49\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                                                                                                               |
| [radioItem2.Bounds = [New]{style="COLOR: blue"} RectangleF(100, 170, 20, 20)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                                               |
| [g.DrawString([\"10-49\"]{style="COLOR: maroon"},font,brush,[New]{style="COLOR: blue"} RectangleF(150,175,180,20))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                               |
| [\'add the items to radio button group]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                               |
| [employeesRadioList.Items.Add(radioItem1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                               |
| [employeesRadioList.Items.Add(radioItem2)        ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Signature fields

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

A signature field is a form field that contains a [digital signature]{style="COLOR: black"}[. ]{style="FONT-FAMILY: 'EDJOL N+ Minion Pro'; COLOR: black"}**PdfSignatureField** class is used to create signature fields in PDF forms. **PdfSignature** class enables to sign the signature field with the given certificate.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                      |
|                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Times New Roman','serif'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                       |
| [PdfSignatureField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ field = [new]{style="COLOR: blue"} [PdfSignatureField]{style="COLOR: teal"}(page, [\"Signature\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                       |
| [field.Bounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}(0, 0, 90, 20);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                                                       |
| [field.BackColor = [new]{style="COLOR: blue"} [PdfColor]{style="COLOR: teal"}([Color]{style="COLOR: teal"}.Red);]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                                       |
| [field.BorderColor = [new]{style="COLOR: blue"} [PdfColor]{style="COLOR: teal"}([Color]{style="COLOR: teal"}.Red);]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                                                                       |
| [field.Signature = [new]{style="COLOR: blue"} PdfSignature();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                                       |
| [field.Signature.Certificate = certificate;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                                       |
| [field.Signature.Reason = [\"Reason\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                                       |
| [document.Form.Fields.Add(field);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                    |
|                                                                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                              |
|                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ field [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfSignatureField(page, [\"Signature\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                         |
| [field.Bounds = [New]{style="COLOR: blue"} RectangleF(0, 0, 90, 20)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                         |
| [field.BackColor = [New]{style="COLOR: blue"} PdfColor(Color.Red)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                         |
| [field.BorderColor = [New]{style="COLOR: blue"} PdfColor(Color.Red)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                         |
| [field.Signature = [New]{style="COLOR: blue"} PdfSignature()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                         |
| [field.Signature.Certificate = certificate]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                         |
| [field.Signature.Reason = [\"Reason\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                         |
| [document.Form.Fields.Add(field)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: For more details on public members, see class reference documentation for pdf.
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Editing Form Fields

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

**PdfLoadedForm** class contains collection of loaded fields, represented by the **PdfLoadedFormFieldCollection** class, and inherited from the **PdfFieldCollection** class. The base class for each loaded field is represented by the **PdfLoadedField** class and inherited from the **PdfField** class.

 

The following loaded fields are supported in the library:

 

[·      ]{style="FONT-FAMILY: Symbol"}Button fields

[o  ]{style="FONT-FAMILY: 'Courier New'"}Push button field, represented by **PdfLoadedButtonField** class

[o  ]{style="FONT-FAMILY: 'Courier New'"}Check Box field, represented by **PdfLoadedCheckBoxField** class

[o  ]{style="FONT-FAMILY: 'Courier New'"}Radio button field, represented by **PdfLoadedRadioButtonListField** class

[·      ]{style="FONT-FAMILY: Symbol"}Text fields

[o  ]{style="FONT-FAMILY: 'Courier New'"}Text field, represented by **PdfLoadedTextBoxField** class

[·      ]{style="FONT-FAMILY: Symbol"}Choice fields

[o  ]{style="FONT-FAMILY: 'Courier New'"}List Box field, represented by **PdfLoadedListBoxField** class

[o  ]{style="FONT-FAMILY: 'Courier New'"}Combo Box field, represented by **PdfLoadedComboBoxField** class

[·      ]{style="FONT-FAMILY: Symbol"}Signature fields

[o  ]{style="FONT-FAMILY: 'Courier New'"}Signature field, represented by **PdfLoadedSignatureField** class

 

You can access each field by using its index or field name. The following code example illustrates this.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                      |
| [PdfLoadedTextBoxField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ field = form.Fields\[[\"fieldname\"]{style="COLOR: maroon"}\] [as]{style="COLOR: blue"} [PdfLoadedTextBoxField]{style="COLOR: teal"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                      |
| [PdfLoadedTextBoxField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldField = form.Fields\[ 0 \] [as]{style="COLOR: blue"} [PdfLoadedTextBoxField]{style="COLOR: teal"}; ]{style="FONT-FAMILY: 'Courier New'"}                                 |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ field [As]{style="COLOR: blue"} PdfLoadedTextBoxField = form.Fields\[[\"fieldname\"]{style="COLOR: maroon"}\] [as]{style="COLOR: blue"} PdfLoadedTextBoxField]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ field [As]{style="COLOR: blue"} PdfLoadedTextBoxField =  form.Fields( 0 ) [as]{style="COLOR: blue"} PdfLoadedTextBoxField ]{style="FONT-FAMILY: 'Courier New'"}                                    |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Essential PDF enables you to retrieve the bounds and value of the field, change the field location and size, and modify its value. Also you can get or set another available property.

 

The following code example illustrates how to change the bounds and value of the field.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                       |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                 |
|                                                                                                                                                                                                                      |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldDoc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: teal"}(filename); ]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                                      |
| [PdfLoadedForm]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ form = ldDoc.Form; ]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [PdfLoadedTextBoxField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldField = form.Fields\[ 0 \] [as]{style="COLOR: blue"} [PdfLoadedTextBoxField]{style="COLOR: teal"}; ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [RectangleF]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ newBounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}( 100, 100, 50, 50 ); ]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [ldField.Bounds = newBounds; ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                      |
| [ldField.SpellCheck = [true]{style="COLOR: blue"}; ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                      |
| [ldField.Text = [\"New text of the field.\"]{style="COLOR: maroon"}; ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                                      |
| [ldField.Password = [false]{style="COLOR: blue"}; ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [ldDoc.Save( newFileName ); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                      |
| [ldDoc.Close(); ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                        |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                      |
|                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldDoc [As]{style="COLOR: blue"} PdfLoadedDocument = [New]{style="COLOR: blue"} PdfLoadedDocument(filename)]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ form [As]{style="COLOR: blue"} PdfLoadedForm = ldDoc.Form]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldField [As]{style="COLOR: blue"} PdfLoadedTextBoxField =  form.Fields( 0 ) [as]{style="COLOR: blue"} PdfLoadedTextBoxField ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ NewBounds [As]{style="COLOR: blue"} RectangleF = [New]{style="COLOR: blue"} RectangleF(100, 100, 50, 50)]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                           |
| [ldField.Bounds = NewBounds ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                                           |
| [ldField.SpellCheck = [True]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                           |
| [ldField.Text = [\"New text of the field.\"]{style="COLOR: maroon"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                           |
| [ldField.Password = [False]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                           |
| [ldDoc.Save(NewFileName) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                                           |
| [ldDoc.Close()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::::::

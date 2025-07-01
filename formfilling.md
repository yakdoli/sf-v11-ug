::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=2184a333-d2f2-44af-bcdb-2e63ee8971a5){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=2b6a7d69-810d-44e0-aca8-fc3a5e75a9da){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pdf](ms-xhelp:///?Id=22756092-3da5-4797-9514-dab0617c6902){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=b2064337-afd6-4241-aa41-868a5489a8dd){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[PDF Form](ms-xhelp:///?Id=6810af81-86b3-43ff-8491-672a44cde746){.d2h_breadcrumbsNormal}
:::

### Form Filling {#form-filling style="tab-stops: 0pt"}

 

Essential PDF provides support to fill AcroForm fields. You can fill the form field value either by using its field name or field index.

 

The following code example illustrates how to fill various loaded fields by using Essential PDF.

 

**Filling the Text Box Field**

 

The following code illustrates how to fill the Text Box Field.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                    |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [PdfLoadedTextBoxField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ldField = form.Fields\[0\] [as]{style="COLOR: blue"} [PdfLoadedTextBoxField]{style="COLOR: teal"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                   |
| [RectangleF]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ newBounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}(100, 100, 50, 50);]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                                   |
| [ldField.Bounds = newBounds;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                   |
| [ldField.SpellCheck = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                   |
| [ldField.Text = [\"New text of the field.\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                   |
| [ldField.Password = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                   |
| [ldField.BorderStyle = [PdfBorderStyle]{style="COLOR: teal"}.Dashed;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                       |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ldField [As]{style="COLOR: blue"} PdfLoadedTextBoxField = form.Fields( 0 ) [as]{style="COLOR: blue"} PdfLoadedTextBoxField ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ NewBounds [As]{style="COLOR: blue"} RectangleF = [New]{style="COLOR: blue"} RectangleF(100, 100, 50, 50)]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                          |
| [ldField.Bounds = NewBounds ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                                          |
| [ldField.SpellCheck = [True]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                          |
| [ldField.Text = [\"New text of the field.\"]{style="COLOR: maroon"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                          |
| [ldField.Password = [False]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                          |
| [ldField.BorderStyle = PdfBorderStyle.Dashed]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**Formatting the text box**

 

The following table lists some of the properties of the TextBoxField.

 

::: {align="center"}
+-----------------------------------+-----------------------------------------------------------------------------------------+
| TextBoxField Property             | Description                                                                             |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| BackColor                         | Gets or sets the back color of the field.                                               |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| BorderColor                       | Gets or sets the border color for the field.                                            |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| BorderStyle                       | Gets or sets the border style for the field.                                            |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| Border                            | Gets or sets the width of the field border.                                             |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| ForeColor                         | Gets or sets the fore color for the field.                                              |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| HighlightMode                     | Gets or sets the highlight mode of the field. It includes the following options.        |
|                                   |                                                                                         |
|                                   |                                                                                         |
|                                   |                                                                                         |
|                                   | *Invert*                                                                                |
|                                   |                                                                                         |
|                                   | *Outline*                                                                               |
|                                   |                                                                                         |
|                                   | *Push*                                                                                  |
|                                   |                                                                                         |
|                                   | *NoHighlighting*                                                                        |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| TextAlignment                     | Gets or sets the alignment of the text in the field. It includes the following options. |
|                                   |                                                                                         |
|                                   |                                                                                         |
|                                   |                                                                                         |
|                                   | *Center*                                                                                |
|                                   |                                                                                         |
|                                   | *Left*                                                                                  |
|                                   |                                                                                         |
|                                   | *Right*                                                                                 |
|                                   |                                                                                         |
|                                   | *Justify*                                                                               |
+-----------------------------------+-----------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                        |
|                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                       |
| [PdfLoadedTextBoxField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ txt = frm.Fields\[i\] [as]{style="COLOR: blue"} [PdfLoadedTextBoxField]{style="COLOR: teal"};]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                                                                       |
| [txt.BorderColor = [Color]{style="COLOR: teal"}.SteelBlue;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                       |
| [txt.BorderStyle = [PdfBorderStyle]{style="COLOR: teal"}.Solid;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                       |
| [txt.BorderWidth = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                                       |
| [txt.BackColor = [new]{style="COLOR: blue"} [PdfColor]{style="COLOR: teal"}([Color]{style="COLOR: teal"}.AliceBlue );]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                       |
| [txt.ForeColor = [new]{style="COLOR: blue"} [PdfColor]{style="COLOR: teal"}([Color]{style="COLOR: teal"}.Navy );]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                                       |
| [txt.HighlightMode = [PdfHighlightMode]{style="COLOR: teal"}.Invert;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                       |
| [txt.TextAlignment = [PdfTextAlignment]{style="COLOR: teal"}.Right;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                       |
| [Font]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ f = [new]{style="COLOR: blue"} [Font]{style="COLOR: teal"}([\"Arial\"]{style="COLOR: maroon"}, 18f);]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                       |
| [PdfTrueTypeFont]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ txtfnt = [new]{style="COLOR: blue"} [PdfTrueTypeFont]{style="COLOR: teal"}(f, [false]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                       |
| [txt.Font = txtfnt;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                      |
|                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ txt [As]{style="COLOR: blue"} PdfLoadedTextBoxField = [TryCast]{style="COLOR: blue"}(frm.Fields(i), PdfLoadedTextBoxField)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                         |
| [txt.BorderColor = Color.SteelBlue]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                         |
| [txt.BorderStyle = PdfBorderStyle.Solid]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                              |
|                                                                                                                                                                                                                         |
| [txt.BorderWidth = 1]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                                         |
| [txt.BackColor = [New]{style="COLOR: blue"} PdfColor(Color.AliceBlue)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                         |
| [txt.ForeColor = [New]{style="COLOR: blue"} PdfColor(Color.Navy)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                         |
| [txt.HighlightMode = PdfHighlightMode.Invert]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                                         |
| [txt.TextAlignment = PdfTextAlignment.Right]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ f [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} Font([\"Arial\"]{style="COLOR: maroon"}, 18.0F)]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ txtfnt [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfTrueTypeFont(f, [False]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                         |
| [txt.Font = txtfnt]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

![](ImagesExt/image22_73.jpg){border="0"}

Figure 62: BorderColor = \"SteelBlue\"; BorderStyle = \"Solid\"; BorderWidth = \"1\"; BackColor = \"AliceBlue\"; ForeColor = \"Navy\"

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Filling the Combo Box Field

 

The following code illustrates how to fill the ComboBox Field.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                               |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                              |
| [//fill combo box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                         |
|                                                                                                                                                                                              |
| [PdfLoadedComboBoxField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ combo = ([PdfLoadedComboBoxField]{style="COLOR: teal"})doc.Form.Fields\[1\];]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                              |
| [combo.SelectedIndex = 3;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                             |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                |
| [\'fill combo box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                           |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ combo [As]{style="COLOR: blue"} PdfLoadedComboBoxField = [CType]{style="COLOR: blue"}(doc.Form.Fields(1), PdfLoadedComboBoxField)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                |
| [combo.SelectedIndex = 3]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Filling the Radio Button Field

 

The following code illustrates how to fill the Radio Button Field.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                             |
|                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                            |
| [//Fill radio button]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                    |
|                                                                                                                                                                                                            |
| [PdfLoadedRadioButtonListField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ radio = ([PdfLoadedRadioButtonListField]{style="COLOR: teal"})doc.Form.Fields\[2\];]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                            |
| [radio.SelectedIndex = 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                           |
|                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                              |
| [\'Fill radio button]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ radio [As]{style="COLOR: blue"} PdfLoadedRadioButtonListField = [CType]{style="COLOR: blue"}(doc.Form.Fields(2), PdfLoadedRadioButtonListField)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                              |
| [radio.SelectedIndex = 1]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Filling the List Box Field

 

The following code illustrates how to fill the List Box Field.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                            |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                           |
| [//fill list box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                       |
|                                                                                                                                                                                           |
| [PdfLoadedListBoxField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ list = ([PdfLoadedListBoxField]{style="COLOR: teal"})doc.Form.Fields\[3\];]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                           |
| [list.SelectedIndex = 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                          |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [\'fill list box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                         |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ list [As]{style="COLOR: blue"} PdfLoadedListBoxField = [CType]{style="COLOR: blue"}(doc.Form.Fields(3), PdfLoadedListBoxField)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                             |
| [list.SelectedIndex = 2]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Filling the Check Box Field

 

The following code illustrates how to fill the Check Box Field.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                        |
|                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                       |
| [//Fill check box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                  |
|                                                                                                                                                                                                                       |
| [PdfLoadedCheckBoxField]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ loadField = form.Fields\[4\] [as]{style="COLOR: blue"} [PdfLoadedCheckBoxField]{style="COLOR: teal"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                  |
|                                                                                                                                                                                                                       |
| [//Check the first item in the checkbox group]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                      |
|                                                                                                                                                                                                                       |
| [loadField.Items\[0\].Checked = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                  |
|                                                                                                                                                                                                                       |
| [//check the checkbox if it is not grouped.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                        |
|                                                                                                                                                                                                                       |
| [loadField.Checked = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                          |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                             |
| [\'Fill check box]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ loadField [As]{style="COLOR: blue"} PdfLoadedCheckBoxField =  form.Fields(4) [as]{style="COLOR: blue"} PdfLoadedCheckBoxField ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [\'Check the first item in the checkbox group]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                            |
|                                                                                                                                                                                                                             |
| [loadField.Items(0).Checked = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [\'check the checkbox if it is not grouped.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                              |
|                                                                                                                                                                                                                             |
| [loadField.Checked = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Filling the Signature Field

 

The following code illustrates how to fill the Signature Field.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                       |
|                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                      |
| [PdfLoadedSignatureField ]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[sigField = ldoc.Form.Fields\[0\] as [PdfLoadedSignatureField]{style="COLOR: teal"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                      |
| [sigField.Signature = new [PdfSignature]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                      |
| [sigField.Signature.Certificate = certificate;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                      |
| [sigField.Signature.Reason = \"Reason\";]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [sigField As ]{style="COLOR: black"}[PdfLoadedSignatureField]{style="COLOR: teal"}[ = TryCast(ldoc.Form.Fields(0), ]{style="COLOR: black"}[PdfLoadedSignatureField]{style="COLOR: teal"}[)]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                                                                                                                                |
| [sigField.Signature = New PdfSignature()]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                |
| [sigField.Signature.Certificate = certificate]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                |
| [sigField.Signature.Reason = \"Reason\"]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                     |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

You can also enumerate the fields and fill them. The following code example illustrates how to enumerate the text fields.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                               |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [PdfLoadedForm]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ form = doc.Form;]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [PdfLoadedFormFieldCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ fields = form.Fields;]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ( i = 0; i \< doc.Form.Fields.Count; i++)]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                                                |
| [ {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                |
| [       [if]{style="COLOR: blue"} (doc.Form.Fields\[i\] [is]{style="COLOR: blue"} [PdfLoadedTextBoxField]{style="COLOR: teal"})]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                |
| [       {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                |
| [              [PdfLoadedTextBoxField]{style="COLOR: teal"} textBox = ([PdfLoadedTextBoxField]{style="COLOR: teal"})doc.Form.Fields\[i\];]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                |
| [              textBox.Text = [\"Text\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                |
| [ }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                           |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ form [As]{style="COLOR: blue"} PdfLoadedForm = doc.Form]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ fields [As]{style="COLOR: blue"} PdfLoadedFormFieldCollection = form.Fields]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                |
| [For]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i = 0 [To]{style="COLOR: blue"}  doc.Form.Fields.Count- 1  [Step]{style="COLOR: blue"}  i + 1]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                                                                |
| [       [If]{style="COLOR: blue"} [TypeOf]{style="COLOR: blue"} doc.Form.Fields(i) [Is]{style="COLOR: blue"} PdfLoadedTextBoxField [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ textBox [As]{style="COLOR: blue"} PdfLoadedTextBoxField = [CType]{style="COLOR: blue"}(doc.Form.Fields(i), PdfLoadedTextBoxField)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                |
| [               textBox.Text = [\"Text\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                                |
| [       [End]{style="COLOR: blue"} [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                |
| [Next]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 Form Fields

 

TryGetField:

 

Loaded field from the PdfLoadedFormFieldCollection provides TryGetField method to obtain the form fields. It is used to get the field value from the given field name. It specifies whether the particular field is loaded or not by returning the boolean value.

 

Syntax:

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                   |
|                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                  |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [bool]{style="COLOR: blue"} TryGetField([string]{style="COLOR: blue"} fieldName,[out]{style="COLOR: blue"} PdfLoadedField field)]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}**                                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [Function]{style="COLOR: blue"} TryGetField(fieldName [As]{style="COLOR: blue"} [String]{style="COLOR: blue"}, [ByRef]{style="COLOR: blue"} field [As]{style="COLOR: blue"} PdfLoadedField) [As]{style="COLOR: blue"} [Boolean]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}[]{style="FONT-SIZE: 9pt"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Example:

 

[The following code example illustrates how to get the form field with the given field name. ]{style="FONT-SIZE: 9pt"}

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                    |
| [// Load the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                    |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ doc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: #2b91af"}([@\"..\\..\\Data\\Form.pdf\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                    |
| [// Load the form from the loaded document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                     |
|                                                                                                                                                                                                                                                    |
| [PdfLoadedForm]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ form = doc.Form;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                                                                    |
| [// Load the form field collections from the form.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                              |
|                                                                                                                                                                                                                                                    |
| [PdfLoadedFormFieldCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ field = [new]{style="COLOR: blue"} [PdfLoadedFormFieldCollection]{style="COLOR: #2b91af"}(form);]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                                                    |
| [PdfLoadedField]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ m_field = [null]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                                    |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ fieldValue = [string]{style="COLOR: blue"}.Empty;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                                    |
| [// TryGetField Method.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                    |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (field.TryGetField([\"f1-1\"]{style="COLOR: #a31515"}, [out]{style="COLOR: blue"} m_field))]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                                                    |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                    |
| [    (m_field [as]{style="COLOR: blue"} [PdfLoadedTextBoxField]{style="COLOR: #2b91af"}).Text = [\"1\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                                                    |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                            |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                            |
|                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                               |
| [\' Load the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                     |
|                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfLoadedDocument([\"..\\..\\Data\\Form.pdf\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                               |
| [\' Load the form from the loaded document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                |
|                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ form [As]{style="COLOR: blue"} PdfLoadedForm = doc.Form]{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                                                                                                                               |
| [\' Load the form field collections from the form.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ field [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfLoadedFormFieldCollection(Form)]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ m_field [As]{style="COLOR: blue"} PdfLoadedField = [Nothing]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                               |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ fieldValue [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = [String]{style="COLOR: blue"}.Empty]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                               |
| [\' TryGetField Method.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                    |
|                                                                                                                                                                                                                               |
| [If]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ field.TryGetField([\"f1-1\"]{style="COLOR: #a31515"}, m_field) [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                                               |
| [  TryCast]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[(m_field, PdfLoadedTextBoxField).Text = [\"1\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                                               |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

TryGetValue:

 

Loaded field from the PdfLoadedFormFieldCollection provides TryGetValue method to obtain the field values. It is used to get the field value from the given field name. It specifies whether the particular field returns true or false value.

 

Example - For a check box field, it returns a value whether it is checked or not.

 

**Syntax:**

[]{style="FONT-FAMILY: 'Verdana','sans-serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                        |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [bool]{style="COLOR: blue"} TryGetValue ([string]{style="COLOR: blue"} fieldName, [out]{style="COLOR: blue"} [string]{style="COLOR: blue"} fieldValue)]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                          |
| [Public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Function]{style="COLOR: blue"} TryGetValue(fieldName [As]{style="COLOR: blue"} [String]{style="COLOR: blue"}, [ByRef]{style="COLOR: blue"} fieldValue [As]{style="COLOR: blue"} [string]{style="COLOR: blue"}) [As]{style="COLOR: blue"} [Boolean]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Example:

 

The following code example illustrates how to get the form field with the given field name.

 

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                             |
|                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                            |
| [// Load the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                            |
| [PdfLoadedDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ doc = [new]{style="COLOR: blue"} [PdfLoadedDocument]{style="COLOR: #2b91af"}([@\"Form.pdf\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                                                            |
| [// Load the form from the loaded document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                             |
|                                                                                                                                                                                                                                            |
| [PdfLoadedForm]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ form = doc.Form;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                            |
| [// Load the form field collections from the form.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                      |
|                                                                                                                                                                                                                                            |
| [PdfLoadedFormFieldCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ field = [new]{style="COLOR: blue"} [PdfLoadedFormFieldCollection]{style="COLOR: #2b91af"}(form);]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                                                            |
| [PdfLoadedField]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ m_field = [null]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                            |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ fieldValue = [string]{style="COLOR: blue"}.Empty;]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                            |
| [// TryGetValue Method.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                            |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (field.TryGetValue([\"f1-2\"]{style="COLOR: #a31515"}, [out]{style="COLOR: blue"} fieldValue) && fieldValue == [\"\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                            |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                            |
| [    (form.Fields\[[\"f1-2\"]{style="COLOR: #a31515"}\] [as]{style="COLOR: blue"} [PdfLoadedTextBoxField]{style="COLOR: #2b91af"}).Text = [\"2\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                                            |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                      |
| [\' Load the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfLoadedDocument([\"Form.pdf\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                                                                      |
| [\' Load the form from the loaded document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ form [As]{style="COLOR: blue"} PdfLoadedForm = doc.Form]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                                                                      |
| [\' Load the form field collections from the form.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ field [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfLoadedFormFieldCollection(Form)]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ m_field [As]{style="COLOR: blue"} PdfLoadedField = [Nothing]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ fieldValue [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = [String]{style="COLOR: blue"}.Empty]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                                                                                      |
| [\' TryGetValue Method.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                      |
| [If]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ field.TryGetValue([\"f1-2\"]{style="COLOR: #a31515"}, fieldValue) [AndAlso]{style="COLOR: blue"} fieldValue = [\"\"]{style="COLOR: #a31515"} [Then]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                      |
| [  [TryCast]{style="COLOR: blue"}(form.Fields([\"f1-2\"]{style="COLOR: #a31515"}), PdfLoadedTextBoxField).Text = [\"2\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                                                                                                      |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [If]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p100} 

[]{#related-topics}
:::::

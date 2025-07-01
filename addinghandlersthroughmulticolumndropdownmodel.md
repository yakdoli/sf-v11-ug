::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Adding Handlers through MultiColumnDropDownModel {#adding-handlers-through-multicolumndropdownmodel style="tab-stops: 0pt"}

 

Configure the **MultiColumnDropDownModel** as shown below to add the handlers.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [// Create instance to MultiColumnDropDown model and assign properties.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                                 |
| [            [MultiColumnDropDownModel]{style="COLOR: #2b91af"} dropdown = [new]{style="COLOR: blue"} [MultiColumnDropDownModel]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                             |
|                                                                                                                                                                                                 |
| [                Datasource = [new]{style="COLOR: blue"} [StudentDataContext]{style="COLOR: #2b91af"}().JSONStudent.Skip(0).Take(30).ToList(),]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                                                 |
| [                Text = [\"\--Select\--\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                 |
| [                DisplayExpression = [new]{style="COLOR: blue"} [int]{style="COLOR: blue"}\[3\] { 2, 3, 5 },]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                                 |
| [                Width = 500,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                 |
| [                AutoFormat = [Skins]{style="COLOR: #2b91af"}.Office2007Black,]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                 |
| [                InitiallyPopupShown=[true]{style="COLOR: blue"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                 |
| [                **ClientSideOnBeforePopupShown = [\"OnBeforePopup\"]{style="COLOR: #a31515"},**]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                 |
| **[                ClientSideOnPopupHidden = [\"popupHidden\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}**                                                                  |
|                                                                                                                                                                                                 |
| **[                ClientSideOnPopupShown = [\"popupShown\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}**                                                                    |
|                                                                                                                                                                                                 |
| **[                ClientSideOnSelect = [\"onRecordSelect\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}**                                                                    |
|                                                                                                                                                                                                 |
| **[                ClientSideOnTextChanged = [\"onTextChanged\"]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}**                                                                 |
|                                                                                                                                                                                                 |
| [            };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[JavaScript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                       |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[script]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [type]{style="COLOR: red"}[=\"text/javascript\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                |
| [       [function]{style="COLOR: blue"} OnBeforePopup(sender, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                                |
| [            [//     args.get_SelectedRow() contains the selected record object (JSON).]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                                                |
| [            [//     args.get_DisplayValue() contains the display value. ]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                                                |
| [            [//     args.get_SelectedValue() contains the selected value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                                                |
| [            [//     args.\_SelectedRow returns the selected record object (JSON).]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                |
| [            [//     args.\_DisplayValue returns the display value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                                |
| [            [//     args.\_SelectedValue returns the selected Value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                |
| [   [function]{style="COLOR: blue"} popupHidden(sender, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                                |
| [       [//     args.get_SelectedRow() contains the selected record object (JSON).]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                |
| [       [//     args.get_DisplayValue() contains the display value. ]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                                |
| [       [//     args.get_SelectedValue() contains the selected value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                |
| [       [//     args.\_SelectedRow returns the selected record object (JSON).]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                                                |
| [       [//     args.\_DisplayValue returns the display value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                |
| [       [//     args.\_SelectedValue returns the selected value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                                |
| [   }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                |
| [   [function]{style="COLOR: blue"} popupShown(sender, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                                |
| [       [//     args.get_SelectedRow() contains the selected record object (JSON).]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                |
| [       [//     args.get_DisplayValue() contains the display value. ]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                                |
| [       [//     args.get_SelectedValue() contains the selected value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                |
| [       [//     args.\_SelectedRow returns the selected record object (JSON).]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                                                |
| [       [//     args.\_DisplayValue returns the display value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                |
| [       [//     args.\_SelectedValue returns the selected value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                                |
| [   }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                |
| [   [function]{style="COLOR: blue"} onRecordSelect(sender, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                                                |
| [       [//     args.get_SelectedRow() contains the selected record object (JSON).]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                |
| [       [//     args.get_DisplayValue() contains the display value. ]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                                |
| [       [//     args.get_SelectedValue() contains the selected value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                |
| [       [//     args.\_SelectedRow returns the selected record object (JSON).]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                                                |
| [       [//     args.\_DisplayValue returns the display value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                |
| [       [//     args.\_SelectedValue returns the selected value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                                |
| [   }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                |
| [   [function]{style="COLOR: blue"} onTextChanged(sender, args) {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                                                |
| [       [//     args.get_SelectedRow() contains the selected record object (JSON).]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                |
| [       [//     args.get_DisplayValue() contains the display value. ]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                           |
|                                                                                                                                                                                                                                |
| [       [//     args.get_SelectedValue() contains the selected value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                |
| [       [//     args.\_SelectedRow returns the selected record object (JSON).]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                                                |
| [       [//     args.\_DisplayValue returns the display value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                |
| [       [//     args.\_SelectedValue returns the selected value.]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                                |
| [   }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                |
| [   [\</]{style="COLOR: blue"}[script]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::

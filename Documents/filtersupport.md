::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Filter Support

Filter support is used to filter the matched list of items from the data source. It depends on the text entered in the AutoComplete textbox. AutoComplete allows you to filter the items using **IsFilter** property.

 

Adding Filter Support to an Application

If **IsFilter** property is set as True, once you enter the text in AutoComplete textbox the matched list of items will be displayed in the drop-down list. If this property is set as False, the matched list of items will not be displayed in the drop-down list, instead all the items will be displayed.

The code given below illustrates the usage of **IsFilter** property set to True.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[AutoComplete]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"AutoComplete1\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ IsFilter]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"true\"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                       |
| [AutoComplete]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ autoComplete1 = [new]{style="COLOR: blue"} [AutoComplete]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'"}[autoComplete1]{style="FONT-FAMILY: 'Courier New'"}[.IsFilter = [true]{style="COLOR: #2b91af"};]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Tables for property, and Event

 

Properties

           Table 9: Properties Table for Filter

  ---------- --------------------------------------------------------- -------------------- ------------ -----------------
  Property   Description                                               Type                 Data Type    Reference links
  IsFilter   Gets or sets the value of IsFilter in the AutoComplete.   DependencyProperty   bool(true)   
  ---------- --------------------------------------------------------- -------------------- ------------ -----------------

 

 

**Events**

Table 10: Events Table for Filter

+-----------------+----------------------------------------------------------------------+------------------------------------+-------------------+---------------------------------+
| Event           | Description                                                          | Arguments                          | Type              | Reference links                 |
+-----------------+----------------------------------------------------------------------+------------------------------------+-------------------+-------------------+-------------+
| IsFilterChanged |  When the value of IsFilter is changed this event will be triggered. | DependencyObject,                  | DependencyPropertyChangedCallBack     |             |
|                 |                                                                      |                                    |                                       |             |
|                 | It cannot be cancelled.                                              | DependencyPropertyChangedEventArgs |                                       |             |
+=================+======================================================================+====================================+===================+===================+=============+
|                 |                                                                      |                                    |                   |                   |             |
+-----------------+----------------------------------------------------------------------+------------------------------------+-------------------+-------------------+-------------+

 

Sample Link

SilverlightSampleBrowser-\> Tools -\> Editors -\> AutoComplete Demo

[]{#related-topics}
:::

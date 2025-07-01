::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Selection Mode Support {#selection-mode-support style="tab-stops: 0pt"}

AutoComplete supports two kinds of Selection Mode namely Single and Multiple. You can select the Mode using the **SelectionMode** property.

When the SelectionMode property is set as Single, only one item can be selected at a time. The following image illustrates the Single selection mode.

 

![Description: C:\\Users\\Dhileep\\Desktop\\Vol4-Documentation\\ScreenShots\\WPF-AC\\SingleSelection.png](ImagesExt/image30_30.png){border="0"}

Figure 26: SelectionMode-Single

 

When the SelectionMode is set as Multiple, you can select multiple items by using the SeparatorChar property to separate the selected items. By default the SeparatorChar is ";". This allows you to select multiple items by using the SelectionMode property. Once an item is selected the Separatorchar is to be entered in the text box to select the next item.

The following image illustrates the Multiple selection mode.

 

![Description: C:\\Users\\Dhileep\\Desktop\\Vol4-Documentation\\ScreenShots\\WPF-AC\\MultipleSelection.png](ImagesExt/image30_31.png){border="0"}

Figure 27: SelectionMode---Multiple

 

When the SelectionMode is set as Extended, you can select multiple items at a time by pressing the Ctrl key. While selecting the multiple items, the selected items will be separated by the SeparatorChar automatically.

The following image illustrates the Multiple selection mode.

![Description: C:\\Users\\Dhileep\\Desktop\\Vol4-Documentation\\ScreenShots\\WPF-AC\\ExtendedSelection.png](ImagesExt/image30_32.png){border="0"}

Figure 28: SelectionMode---Extended

 

Adding Single, Multiple & Extended Selection Support to an Application

The **Selectionmode** property is used to attain these functionalities by setting its value as Single or Multiple or Extended. By default its value is Single. The following code snippet is used to set the **SelectionMode** property.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[XAML\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[AutoComplete]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"AutoComplete2\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ SelectionMode]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"Multiple\"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}**[]{style="FONT-FAMILY: 'Courier New'"}** |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                           |
| [AutoComplete]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ autoComplete1 = [new]{style="COLOR: blue"} [AutoComplete]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                   |
|                                                                                                                                                                                                                                                           |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'"}[autoComplete2]{style="FONT-FAMILY: 'Courier New'"}[.SelectionMode = [SelectionMode]{style="COLOR: #2b91af"}.Multiple;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Tables for properties, and events

Property

Table 7: Property Table for Selection Mode

::: {align="center"}
  --------------- ----------------------------------------------------- -------------------- ----------------------- -----------------
  Property        Description                                           Type                 Data Type               Reference links
  SelectionMode   Gets or Sets the SelectionMode of the AutoComplete.   DependencyProperty   SelectionMode(Single)   
  --------------- ----------------------------------------------------- -------------------- ----------------------- -----------------
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Events

Table 8: Event Table for Selection Mode

::: {align="center"}
+----------------------+----------------------------------------------------------------------------------+------------------------------------+-----------------------------------+-----------------+
| Event                | Description                                                                      | Arguments                          | Type                              | Reference links |
+----------------------+----------------------------------------------------------------------------------+------------------------------------+-----------------------------------+-----------------+
| SelectionModeChanged |  When the SelectionMode property value is changed, this event will be triggered. | DependencyObject,                  | DependencyPropertyChangedCallBack |                 |
|                      |                                                                                  |                                    |                                   |                 |
|                      | It cannot be cancelled.                                                          | DependencyPropertyChangedEventArgs |                                   |                 |
+======================+==================================================================================+====================================+===================================+=================+
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Sample Link

WPF Sample Browser-\> Tools -\> Editors -\> AutoComplete Demo

 

[]{#related-topics}
:::::

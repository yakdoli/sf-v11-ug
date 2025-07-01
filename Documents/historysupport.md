::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### History Support

History support in AutoComplete means, reusage of the items which are already used in the AutoComplete textbox. AutoComplete allows you to enable this history support by setting the value of the **IsHistory** property as True. AutoComplete guides you to select an item from the list of items which are added to the history, by using the drop-down button to open the drop-down list.

 

Adding History Support to an Application

Items can be added to the history using the **AddToHistory(String str)** and **AddToHistory(Object obj)** methods, only if that items are present in the data source used with the AutoComplete. Also, it supports to save the history while closing the application and to load the history while opening the application using the **SaveHistory()** and **LoadHistory()** methods.

The below mentioned code snippet can be used to attain these functionalities.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                    |
| [AutoComplete]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ autoComplete1 = [new]{style="COLOR: blue"} [AutoComplete]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                                                                                    |
| [autoComplete1]{style="FONT-FAMILY: 'Courier New'"}[.Loaded += [new]{style="COLOR: blue"} [RoutedEventHandler]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                                                                                                                    |
| [(]{style="FONT-FAMILY: 'Courier New'"}[autoComplete1]{style="FONT-FAMILY: 'Courier New'"}[\_Loaded);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                    |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'"}[autoComplete1]{style="FONT-FAMILY: 'Courier New'"}[\_Loaded([object]{style="COLOR: blue"} sender, [RoutedEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                    |
| [            [if]{style="COLOR: blue"} (]{style="FONT-FAMILY: 'Courier New'"}[autoComplete1]{style="FONT-FAMILY: 'Courier New'"}[!= [null]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
|                                                                                                                                                                                                                                                                                    |
| [                ]{style="FONT-FAMILY: 'Courier New'"}[autoComplete1]{style="FONT-FAMILY: 'Courier New'"}[.LoadHistory();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                    |
| [autoComplete1]{style="FONT-FAMILY: 'Courier New'"}[.SelectionChanged +=]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                    |
| [   new]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [SelectionChangedEventHandler]{style="COLOR: #2b91af"}(]{style="FONT-FAMILY: 'Courier New'"}[autoComplete1]{style="FONT-FAMILY: 'Courier New'"}[\_SelectionChanged);]{style="FONT-FAMILY: 'Courier New'"}               |
|                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                    |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} ]{style="FONT-FAMILY: 'Courier New'"}[autoComplete1]{style="FONT-FAMILY: 'Courier New'"}[\_SelectionChanged([object]{style="COLOR: blue"} sender, ]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                                                    |
| [                                             [SelectionChangedEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                    |
| [     ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[autoComplete1]{style="FONT-FAMILY: 'Courier New'"}[.AddHistory(]{style="FONT-FAMILY: 'Courier New'"}[autoComplete1]{style="FONT-FAMILY: 'Courier New'"}[.SelectedItem);]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                                                                                    |
| [     ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[autoComplete1]{style="FONT-FAMILY: 'Courier New'"}[.SaveHistory();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                 |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Tables for properties, and methods,

 

Properties

Table 11: Property Table for History support

  ----------- ---------------------------------------------------------- -------------------- ------------ -----------------
  Property    Description                                                Type                 Data Type    Reference links
  IsHistory   Gets or sets the value of IsHistory of the AutoComplete.   DependencyProperty   bool(true)   
  ----------- ---------------------------------------------------------- -------------------- ------------ -----------------

 

Methods

Table 12: MethodsTable for History

+-------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+-----------+-------------+-----------------+
| Method            | Description                                                                                                                                                                                                     | Parameters                                              | Type      | Return Type | Reference links |
+-------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+-----------+-------------+-----------------+
| AddHistory()      | It should be called to add an item to the history.                                                                                                                                                              | (String str)                                            | NA.       | Void        |                 |
|                   |                                                                                                                                                                                                                 |                                                         |           |             |                 |
|                   | It can be called at any time.                                                                                                                                                                                   |                                                         |           |             |                 |
|                   |                                                                                                                                                                                                                 |                                                         |           |             |                 |
|                   | This method will add an input string to the history list if IsHistoryEnabled property is set as Ture and these items will only be displayed in the History list which can be opened using the drop-down button. | The input string must be there in linked Custom Source. |           |             |                 |
+-------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+-----------+-------------+-----------------+
| AddHistory()      | It should be called to add an item to the history.                                                                                                                                                              | (Object obj)                                            | NA.       | Void        |                 |
|                   |                                                                                                                                                                                                                 |                                                         |           |             |                 |
|                   | It can be called at any time.                                                                                                                                                                                   |                                                         |           |             |                 |
|                   |                                                                                                                                                                                                                 |                                                         |           |             |                 |
|                   | This method will add the input object to the history list if IsHistoryEnabled property is set as Ture. These items will only be displayed in the History list which can be opened using the drop-down button.   | The input object must be there in linked Custom Source. |           |             |                 |
+-------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+-----------+-------------+-----------------+
| SaveHistory()     | It should be called if you want to save the history before closing the application.                                                                                                                             |                                                         | NA        | Void        |                 |
|                   |                                                                                                                                                                                                                 |                                                         |           |             |                 |
|                   | It can be called while closing the application.                                                                                                                                                                 |                                                         |           |             |                 |
|                   |                                                                                                                                                                                                                 |                                                         |           |             |                 |
|                   | This method will save the History list in an isolated storage.                                                                                                                                                  |                                                         |           |             |                 |
+-------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+-----------+-------------+-----------------+
| LoadHistory()     | It should be called if you want to load the history while loading the application which is already saved.                                                                                                       |                                                         | NA        | Void        |                 |
|                   |                                                                                                                                                                                                                 |                                                         |           |             |                 |
|                   | It can be called while loading the application.                                                                                                                                                                 |                                                         |           |             |                 |
|                   |                                                                                                                                                                                                                 |                                                         |           |             |                 |
|                   | This method will load the history list from an isolated storage to be used in the application.                                                                                                                  |                                                         |           |             |                 |
+-------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+-----------+-------------+-----------------+
| ClearAllHistory() | This should be called if you want to clear all the saved history.                                                                                                                                               |                                                         | NA        | Void        |                 |
|                   |                                                                                                                                                                                                                 |                                                         |           |             |                 |
|                   | It can be called at any time.                                                                                                                                                                                   |                                                         |           |             |                 |
|                   |                                                                                                                                                                                                                 |                                                         |           |             |                 |
|                   | This method will clear the entire history list loaded from an isolated storage.                                                                                                                                 |                                                         |           |             |                 |
+===================+=================================================================================================================================================================================================================+=========================================================+===========+=============+=================+

 

 

Sample Link

SilverlightSampleBrowser-\> Tools -\> Editors -\> AutoComplete Demo

[]{#related-topics}
:::

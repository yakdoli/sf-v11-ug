::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ButtonAdv Members {#buttonadv-members style="tab-stops: 0pt"}

Properties

+------------------+-------------+---------------------+----------------------------------------------------------------------------------+---------------+---------------------------------------------------------------------------+
| Name             | Type        | Value it accepts    | Description                                                                      | Default Value | Reference Link                                                            |
+------------------+-------------+---------------------+----------------------------------------------------------------------------------+---------------+---------------------------------------------------------------------------+
| Label            | String      | String              | The Label Property of this element can be set to any string value                | Null          | [Label](ms-xhelp:///?Id=2bfa12de-acd6-4f09-b2fd-181bd8eed66a)             |
|                  |             |                     |                                                                                  |               |                                                                           |
|                  |             |                     |                                                                                  |               |                                                                           |
+------------------+-------------+---------------------+----------------------------------------------------------------------------------+---------------+---------------------------------------------------------------------------+
| SizeMode         | SizeMode    | Normal,             | Represents the Size of the element, that can be Normal, Small or Large           | Normal        | [SizeMode](ms-xhelp:///?Id=e5a26ec4-1d33-4adb-a141-3faae855f892)          |
|                  |             |                     |                                                                                  |               |                                                                           |
|                  |             | Small,        Large |                                                                                  |               |                                                                           |
+------------------+-------------+---------------------+----------------------------------------------------------------------------------+---------------+---------------------------------------------------------------------------+
| SmallIcon        | ImageSource | Image URL           | Represents the Image displayed in the element, when size form is Small or Normal | \-            | [SmallIcon](ms-xhelp:///?Id=7c10b224-a4ea-4fc9-9001-14a1ae81e83b)         |
+------------------+-------------+---------------------+----------------------------------------------------------------------------------+---------------+---------------------------------------------------------------------------+
| LargeIcon        | ImageSource | Image URL           | Represents the Image displayed in the element, when size form is Large           | Null          | [LargeIcon](ms-xhelp:///?Id=7c10b224-a4ea-4fc9-9001-14a1ae81e83b)         |
+------------------+-------------+---------------------+----------------------------------------------------------------------------------+---------------+---------------------------------------------------------------------------+
| IsCheckable      | Boolean     | True or False       | Button will act as a Checkable item if true                                      | False         | [Checkable Support](ms-xhelp:///?Id=8c8e64fd-3f7c-49b7-9da4-ead03a407645) |
+------------------+-------------+---------------------+----------------------------------------------------------------------------------+---------------+---------------------------------------------------------------------------+
| IsChecked        | Boolean     | True or False       | Represents the Checked state of the element                                      | False         | [Checkable Support](ms-xhelp:///?Id=8c8e64fd-3f7c-49b7-9da4-ead03a407645) |
+------------------+-------------+---------------------+----------------------------------------------------------------------------------+---------------+---------------------------------------------------------------------------+
| IsMultiline      | Boolean     | True or False       | Represents whether the Label displayed in two line or not                        | True          | [MultiLine Support](ms-xhelp:///?Id=b0ff40c1-1de5-47db-a178-653b0a5beaa4) |
+------------------+-------------+---------------------+----------------------------------------------------------------------------------+---------------+---------------------------------------------------------------------------+
| Command          | ICommand    | ICommand            | Represents the command to invoke when the button is pressed                      | Null          | [Command Binding](ms-xhelp:///?Id=b19f910c-29e3-4e73-86a2-575122081468)   |
+------------------+-------------+---------------------+----------------------------------------------------------------------------------+---------------+---------------------------------------------------------------------------+
| CommandParameter | Object      | Object              | Represents the parameter to pass the Command property.                           | Null          | [Command Binding](ms-xhelp:///?Id=b19f910c-29e3-4e73-86a2-575122081468)   |
+------------------+-------------+---------------------+----------------------------------------------------------------------------------+---------------+---------------------------------------------------------------------------+
| IconWidth        | double      | double              | Represents the width of the icon.                                                | 16.0          | [IconSize](ms-xhelp:///?Id=09734a55-89d7-4174-884a-f6b1811a0889)          |
+------------------+-------------+---------------------+----------------------------------------------------------------------------------+---------------+---------------------------------------------------------------------------+
| IconHeight       | double      | double              | Represents the height of the icon.                                               | 16.0          | [IconSize](ms-xhelp:///?Id=09734a55-89d7-4174-884a-f6b1811a0889)          |
+------------------+-------------+---------------------+----------------------------------------------------------------------------------+---------------+---------------------------------------------------------------------------+

 

Events

  --------- -------------------- ---------------------- ------------------------------------ -----------------------------------------------------------------
  Name      Event Type           Event Args Parameter   Description                          Reference Link
  Click     RoutedEventHandler   RoutedEvent Args       Occurs when ButtonAdv is pressed.    [Click](ms-xhelp:///?Id=69a3ad9d-15da-416d-ab28-b7fa302757d4)
  Checked   RoutedEventHandler   RoutedEventArgs        Occurs when the Button is Checked.   [Checked](ms-xhelp:///?Id=69a3ad9d-15da-416d-ab28-b7fa302757d4)
  --------- -------------------- ---------------------- ------------------------------------ -----------------------------------------------------------------

 

[]{#related-topics}
:::

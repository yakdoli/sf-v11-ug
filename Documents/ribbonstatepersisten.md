::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Ribbon State Persistence

State Persistence is the combined process of Serialization and Deserialization. Serialization is the process of converting the state of an object to a format in which it can be persisted as a file in the memory. The serialized format contains the object\'s state information. Deserialization is the complement process of Serialization, which converts into the object from the stored state information.

Silverlight Ribbon control has a fully built-in Serialization support to serialize the entire Ribbon control states. You can save and load the Ribbon States at any time while running the application and also at the time of application exit and start.

You can persist Ribbon Control states separately as follows:

 

1.   Quick Access Tool Bar

a.         Quick Access Tool Bar Items

b.         Quick Access Tool Bar State ( Above Ribbon, Below Ribbon)

 

2.   Ribbon

a.         Ribbon State (Normal, Hide)

 

3.   Ribbon Window

a.         Window Width

b.         Window Height

c.         Window Left

d.         Window Top

5.  

Use Case Scenarios

The Ribbon State Persistence feature helps users to load the state of the Ribbon control that existed when the application was closed. State Persistence feature gives a more consistent workflow for an application that is executed for a long time.

 

Tables for Properties and Methods

Properties

Table 20: AutoPersist Table

::: {align="center"}
+-------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+-------------+-------------+---------------+
| Property    | Description                                                                                                                                                             | Type        | Data Type   | Default Value |
+=============+=========================================================================================================================================================================+=============+=============+===============+
| AutoPersist | This property will enable/disable the state persistence in Ribbon control. This property is available individually for Quick Access Tool Bar, Ribbon and Ribbon Window. | Dependency  | bool        | False         |
|             |                                                                                                                                                                         |             |             |               |
|             |                                                                                                                                                                         | Property    |             |               |
+-------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------+-------------+-------------+---------------+
:::

 

Table 21: PersistElements Table

::: {align="center"}
  ----------------- ------------------------------------------------------------------------------------------------- ------ ---------------------------------------- ---------------
  Property          Description                                                                                       Type   Data Type                                Default Value
  PersistElements   This property has a collection of Ribbon elements, which are used to persist states at runtime.   CLR    ObservableCollection\<RibbonElements\>   Null
  ----------------- ------------------------------------------------------------------------------------------------- ------ ---------------------------------------- ---------------
:::

 

You can enable State Persistence in Ribbon control by setting the AutoPersist property to "True". You can customize the State Persistence in Ribbon, Quick Access Tool Bar and Ribbon Window elements by using the AutoPersist property.

 

Methods

Table 22: SaveRibbonState Table

+-------------------+----------------------------------------------------------------+-----------------------------------------------------------------------------------------------------+-----------------+
| Method            | Description                                                    | Parameters                                                                                          | Return Type     |
+-------------------+----------------------------------------------------------------+-----------------------------------------------------------------------------------------------------+-----------------+
| SaveRibbonState() | This method will save the current state of the Ribbon control. | (+2 Overloads)                                                                                      | void            |
|                   |                                                                |                                                                                                     |                 |
|                   |                                                                | No Params                                                                                           |                 |
|                   |                                                                |                                                                                                     |                 |
|                   |                                                                | (IsolatedStorageFile arg1, string arg2)                                                             |                 |
|                   |                                                                |                                                                                                     |                 |
|                   |                                                                |                                                                                                     |                 |
|                   |                                                                |                                                                                                     |                 |
|                   |                                                                | arg1 -- This parameter is used to mention the custom Isolated Storage file.                         |                 |
|                   |                                                                |                                                                                                     |                 |
|                   |                                                                |                                                                                                     |                 |
|                   |                                                                |                                                                                                     |                 |
|                   |                                                                | arg2 -- This is the file name in the Isolated Storage file, which is used to save the Ribbon state. |                 |
|                   |                                                                |                                                                                                     |                 |
|                   |                                                                |                                                                                                     |                 |
|                   |                                                                |                                                                                                     |                 |
|                   |                                                                |                                                                                                     |                 |
+-------------------+----------------------------------------------------------------+-----------------------------------------------------------------------------------------------------+-----------------+

 

Table 23: LoadRibbonState Table

+-------------------+------------------------------------------------------+------------------------------------------------------------------------------------------------+-----------------+
| Method            | Description                                          | Parameters                                                                                     | Return Type     |
+===================+======================================================+================================================================================================+=================+
| LoadRibbonState() | This method will load the saved state of the Ribbon. | (+2 Overloads)                                                                                 | void            |
|                   |                                                      |                                                                                                |                 |
|                   |                                                      | No Params                                                                                      |                 |
|                   |                                                      |                                                                                                |                 |
|                   |                                                      | (IsolatedStorageFile arg1, string arg2)                                                        |                 |
|                   |                                                      |                                                                                                |                 |
|                   |                                                      |                                                                                                |                 |
|                   |                                                      |                                                                                                |                 |
|                   |                                                      | arg1-- This parameter is used to mention the custom Isolated Storage file.                     |                 |
|                   |                                                      |                                                                                                |                 |
|                   |                                                      |                                                                                                |                 |
|                   |                                                      |                                                                                                |                 |
|                   |                                                      | arg2 -- This is the file name in the Isolated Storage file, which has the stored Ribbon state. |                 |
|                   |                                                      |                                                                                                |                 |
|                   |                                                      |                                                                                                |                 |
+-------------------+------------------------------------------------------+------------------------------------------------------------------------------------------------+-----------------+

 

 

 

 

 

 

 

 

Table 24: ResetRibbonState Table

  -------------------- ----------------------------------------------------------------------------- ------------ -------------
  Method               Description                                                                   Parameters   Return Type
  ResetRibbonState()   ResetRibbonState method will load the initial state of the Ribbon elements.   No Params     void
  -------------------- ----------------------------------------------------------------------------- ------------ -------------

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"}** 

Table 25: DeleteRibbonState Table

+---------------------+--------------------------------------------------+------------------------------------------------------------------------------------+-----------------+
| Method              | Description                                      | Parameters                                                                         | Return Type     |
+---------------------+--------------------------------------------------+------------------------------------------------------------------------------------+-----------------+
| DeleteRibbonState() | It will delete the saved state file from memory. | (+2 Overloads)                                                                     |  void           |
|                     |                                                  |                                                                                    |                 |
|                     |                                                  |     1. No params                                                                   |                 |
|                     |                                                  |                                                                                    |                 |
|                     |                                                  |     2.(IsolatedStorageFile arg1,                                                   |                 |
|                     |                                                  |                                                                                    |                 |
|                     |                                                  |                   string arg2)                                                     |                 |
|                     |                                                  |                                                                                    |                 |
|                     |                                                  |                                                                                    |                 |
|                     |                                                  |                                                                                    |                 |
|                     |                                                  | arg1-- This parameter is used to mention the custom Isolated Storage file.         |                 |
|                     |                                                  |                                                                                    |                 |
|                     |                                                  |                                                                                    |                 |
|                     |                                                  |                                                                                    |                 |
|                     |                                                  | arg2 -- This is the file name in the Isolated Storage file, which wants to delete. |                 |
+---------------------+--------------------------------------------------+------------------------------------------------------------------------------------+-----------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"}** 

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"}** 

Sample Link

To access a sample:

6.   1. Click Start -\> All Programs -\> Syncfusion -\> Essential Studio x.x.x.x -\> Dashboard.

7.   2. Click the Silverlight drop-down list, and then select Run Locally Installed Samples.

8.   3. In the sample browser, expand Ribbon, and then select Ribbon Customization Demo.

 

More:

[ ]{#related-topics}

[![](../button.gif){border="0" align="absMiddle"}Using State Persistence in the Application](ms-xhelp:///?Id=756711b8-ad47-4eb8-84ac-f1f07082ea42){style="TEXT-DECORATION: none"}

[![](../button.gif){border="0" align="absMiddle"}Utility Methods](ms-xhelp:///?Id=24acab5e-46da-4566-97db-36d0ffc46621){style="TEXT-DECORATION: none"}
:::::

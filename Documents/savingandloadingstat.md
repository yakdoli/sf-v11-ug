::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Saving and Loading states

 

Any complex docking layouts can be saved and loaded at any time. DockingManager identifies individual windows with the attached **WindowName** property. A new WindowName is created in the form of GUID, if the property is not specified. This works within one application session. For example, if the application is closed and the user loads the state back, the layout will not be generated until the name of the window is different from the xml file that is stored already. But if you want to persist layout information between the user\'s visits to your website, you would have to explicitly assign each window its own WindowName in the following manner.

You can save or load the states of the docking elements from the isolated storage. It is handled in two ways:

 

[·      ]{style="FONT-FAMILY: Symbol"}Layout can be serialized and stored in Isolated Storage.

[·      ]{style="FONT-FAMILY: Symbol"}Layout can be serialized into a string.

 

The above two methods are handled with the help of SaveDockState **overloaded** method,

 

1.   Layout can be serialized into a string containing the XML

 

The state of the DockingManager child items layout can be serialized into a string containing XML at any time. This can be done by calling the **dockingManager1.SaveDockState()** method where dockingManager1 is an object of the DockingManager control. After the state is read from the xml file,it can be returned in the form of string by calling the **dockingManager1.LoadState** method. Here, all the windows are returned to the positions they were in, when the first call was made.

The following code illustrates how to save or load the states from the isolated storage.

 

+-------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                          |
|                                                                                                                               |
| [//Saves state in Isolated Storage ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager.SaveDockState();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                          |
|                                                                                                                               |
| [//Loads state from isolated storage]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager.LoadDockState();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 14pt"} 

2.   Layout can be serialized into a string

 

DockingManager enables the user to save the layout, which is in the form of string under any location like database. This can be achieved by calling the **SaveDockState(out state),** where state is string. All the windows are returned to the position by calling the **LoadDockState(state)**.

+---------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                          |
|                                                                                                                                                               |
| [//Saves state in string]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager.SaveDockState([out]{style="COLOR: blue"} state);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                               |
| [//Loads state from string]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager.LoadDockState(state);]{style="FONT-FAMILY: 'Courier New'"}                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 14pt"} 

**InitializeControlOnLoad** will be fired when there is no instance for a control while loading states.

Refer Also,

[[]{.UGHyperlink}[Create instance if the live instance is missing while dock state load.]{.UGHyperlink}[]{.UGHyperlink}]{.UGHyperlink}[]{.UGHyperlink}[]{.UGHyperlink}

[]{style="FONT-SIZE: 14pt"} 

[]{#related-topics}
:::

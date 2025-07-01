::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Dock State Persistence {#dock-state-persistence style="tab-stops: 0pt"}

[]{#p79}[]{style="FONT-SIZE: 8pt"} 

The docking behavior can be saved in the following formats.

[]{style="COLOR: #15428b"} 

[·      ]{style="FONT-FAMILY: Symbol"}Binary Format

[·      ]{style="FONT-FAMILY: Symbol"}XML Format

[·      ]{style="FONT-FAMILY: Symbol"}IsolatedStorage medium

[·      ]{style="FONT-FAMILY: Symbol"}MemoryStream

[·      ]{style="FONT-FAMILY: Symbol"}PersistState property

[]{style="COLOR: #15428b"} 

The docking windows framework has a fully built-in serialization feature that provides automatic serialization of the form\'s docking state. In addition to this automatic dock state persistence during application termination and start, multiple intermediate docking states can be saved or loaded anytime using the programmatic API. The serialization mechanism is implemented using the standardized Syncfusion.Windows.Forms.AppStateSerializer component that acts as a central coordinator of all the Essential Tools components and provides the option to read / write to different media such as the default Isolated Storage, XML file, XML stream, Binary file, Binary stream and the Windows Registry.

**[]{style="COLOR: navy"}** 

Persisting Dock State in default storage

[]{style="FONT-SIZE: 8pt"} 

The dock state of a control can be persisted by setting the **PersistState** property of Docking manager. This information is stored in the Isolated storage.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  ----------------------------- ------------------------------------------------------------------------------------------------------
  DockingClientPanel Property   Description
  PersistState                  Gets or sets a value indicating whether the application\'s docking window state should be persisted.
  ----------------------------- ------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-SIZE: 8pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                            |
|                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                  |
|                                                                                                                                                           |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.PersistState = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                     |
|                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                               |
|                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.PersistState = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 8pt"} 

The DockingManager has built-in support for dock state serialization that can be enabled or disabled using the PersistState property. When the PersistState property is set to True, closing the form and hosting the docking windows will force the DockingManager to capture the current docking layout and serialize it using the Essential Studio AppStateSerializer serialization.

 

The default serialization option is Isolated storage and the System.IO.IsolatedStorage routines normally store application specific encrypted entries under the \'C:\\Documents and Settings\\\[USER name\]\\Local Settings\\Application Data\\IsolatedStorage\\\' folder. All of the Essential Tools framework components use the \'**Syncfusion.Runtime.Serialization.AppStateSerializer\'** class in the Shared library for Read/Write. The AppStateSerializer is fully documented and can be initialized for different persistence mediums such as XML / Binary files, XML / Binary streams, and the Win32 Registry using its API.

 

The default auto serialization implementation for the DockingManager uses a single instance of the AppStateSerializer that you can access through the **AppStateSerializer.GetSingleton()** method and reinitialize if necessary. But this single reinitialization should be done within the application's Main method before the first instance gets a chance to be created. Another option would be to use a custom instance of the AppStateSerializer and pass this to application-level invocations of the DockingManager\'s LoadDockState / SaveDockState routines.

[]{style="FONT-FAMILY: 'Verdana','sans-serif'; FONT-SIZE: 8pt"} 

LoadDockState and SaveDockState methods

[]{style="COLOR: #15428b"} 

LoadDockState

[]{style="COLOR: #15428b"} 

::: {align="center"}
+-----------------------------------+---------------------------------------------------------------------------------------------------------------------------+
| Methods                           | Description                                                                                                               |
+-----------------------------------+---------------------------------------------------------------------------------------------------------------------------+
| LoadDockState                     | Reads the persisted dockstate from the Isolated Storage.                                                                  |
+-----------------------------------+---------------------------------------------------------------------------------------------------------------------------+
| LoadDockState (Overloaded)        | Reads a previously serialized dockstate using the AppStateSerializer object. Parameter is,                                |
|                                   |                                                                                                                           |
|                                   |                                                                                                                           |
|                                   |                                                                                                                           |
|                                   | *Serializer[ - ]{style="COLOR: black; FONT-SIZE: 8pt"}*An instance of AppStateSerializer class.                           |
+-----------------------------------+---------------------------------------------------------------------------------------------------------------------------+
| LoadDockState (Overloaded)        | Reads a previously serialized dockstate for the specified dockable control and applies the new state. The parameters are, |
|                                   |                                                                                                                           |
|                                   |                                                                                                                           |
|                                   |                                                                                                                           |
|                                   | *Serializer[ - ]{style="COLOR: black; FONT-SIZE: 8pt"}*An instance of AppStateSerializer class.                           |
|                                   |                                                                                                                           |
|                                   | *Ctrl[ ]{style="COLOR: black; FONT-SIZE: 8pt"}*- Indicates the docked control.                                            |
+-----------------------------------+---------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                 |
|                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                       |
|                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LoadDockState();]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LoadDockState(serializer);]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LoadDockState(serializer, [this]{style="COLOR: blue"}.listBox1);]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                          |
|                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                    |
|                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LoadDockState(serializer)]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LoadDockState();]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LoadDockState(serializer, [this]{style="COLOR: blue"}.listBox1)]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

SaveDockState

[]{style="COLOR: #15428b"} 

::: {align="center"}
+-----------------------------------+-------------------------------------------------------------------------------------------------+
| Methods                           | Description                                                                                     |
+-----------------------------------+-------------------------------------------------------------------------------------------------+
| SaveDockState                     | Saves the current dockstate to Isolated Storage.                                                |
+-----------------------------------+-------------------------------------------------------------------------------------------------+
| SaveDockState (Overloaded)        | Saves the current dockstate information to the specified AppStateSerializer. Parameter is,      |
|                                   |                                                                                                 |
|                                   |                                                                                                 |
|                                   |                                                                                                 |
|                                   | *Serializer[ - ]{style="COLOR: black; FONT-SIZE: 8pt"}*An instance of AppStateSerializer class. |
+-----------------------------------+-------------------------------------------------------------------------------------------------+
| LoadDockState (Overloaded)        | Saves the dockstate information for the specified dockable control. The parameters are,         |
|                                   |                                                                                                 |
|                                   |                                                                                                 |
|                                   |                                                                                                 |
|                                   | *Serializer[ - ]{style="COLOR: black; FONT-SIZE: 8pt"}*An instance of AppStateSerializer class. |
|                                   |                                                                                                 |
|                                   | *Ctrl[ ]{style="COLOR: black; FONT-SIZE: 8pt"}*- Indicates the docked control.                  |
+-----------------------------------+-------------------------------------------------------------------------------------------------+
:::

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                 |
|                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                       |
|                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SaveDockState();]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SaveDockState(serializer);]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SaveDockState(serializer, [this]{style="COLOR: blue"}.listBox1);]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                          |
|                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                    |
|                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SaveDockState()]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SaveDockState(serializer)]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SaveDockState(serializer, [this]{style="COLOR: blue"}.listBox1)]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

Persisting Dock state in XML file

[]{style="COLOR: #15428b"} 

When the DockingManager\'s PersistState property is set, it will save the dock state into default persistence medium, \'IsolatedStorage\'. To store the dock state to some other medium like XML, it could be done as follows:

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                          |
|                                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                |
|                                                                                                                                                                                         |
| [using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Runtime.Serialization;]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                         |
| [// Persist the dock state into XML File named Dock1.xml. Use this line in the constructor of Control which hosts the dockinglayout ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                                                         |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ form1()]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                         |
| [{ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                         |
| [AppStateSerializer.InitializeSingleton(SerializeMode.XMLFile,[\"Dock1\"]{style="COLOR: maroon"}); ]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                     |
|                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                               |
|                                                                                                                                                                                        |
| [Imports ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Syncfusion.Runtime.Serialization]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                        |
| [\' Persist the dock state into XML File named Dock1.xml.Use this line in the constructor of Control which hosts the dockinglayout ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                                                        |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} [New]{style="COLOR: blue"}()]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                        |
| [        AppStateSerializer.InitializeSingleton(SerializeMode.XMLFile, [\"Dock1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                        |
| [End Sub()]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                           |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 8pt"} 

Persisting Dock State in Memory Stream

[]{style="COLOR: #15428b"} 

To persist docking information in a database, we need to serialize the state into a memory stream. After which the stream is written into the database. The field to where the dock state is saved is binary.

[]{style="COLOR: #15428b"} 

Storing State

**[]{style="FONT-SIZE: 8pt"}** 

+---------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                    |
|                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                          |
|                                                                                                                                                   |
| [// Saving dockstate to memory stream  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                        |
|                                                                                                                                                   |
| [MemoryStream ms = [new]{style="COLOR: blue"} MemoryStream();]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                   |
| [AppStateSerializer aser = [new]{style="COLOR: blue"} AppStateSerializer(SerializeMode.BinaryFmtStream, ms);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SaveDockState(aser);]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                   |
| [aser.PersistNow();]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                   |
| [//Code to store the memory stream into database. Depends upon the database.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                |
|                                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                          |
|                                                                                                                                                                                                                                   |
| [\' Saving dockstate to memory stream  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                        |
|                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ms [As]{style="COLOR: blue"} MemoryStream = [New]{style="COLOR: blue"} MemoryStream()]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ aser [As]{style="COLOR: blue"} AppStateSerializer = [New]{style="COLOR: blue"} AppStateSerializer(SerializeMode.BinaryFmtStream, ms)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SaveDockState(aser) ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                                   |
| [aser.PersistNow() ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                   |
| [\'Code to store the memory stream into database. Depends upon the database.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                   |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="COLOR: #15428b"}** 

Retrieving State

**[]{style="FONT-SIZE: 8pt"}** 

+---------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                    |
|                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                          |
|                                                                                                                                                   |
| [//Code to retrieve data(stream) from database]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                 |
|                                                                                                                                                   |
| [MemoryStream ms = [new]{style="COLOR: blue"} MemoryStream(val);]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                   |
| [ms.Position = 0;]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                   |
| [AppStateSerializer aser = [new]{style="COLOR: blue"} AppStateSerializer(SerializeMode.BinaryFmtStream, ms);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LoadDockState(aser);]{style="FONT-FAMILY: 'Courier New'"}                |
+---------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                |
|                                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                          |
|                                                                                                                                                                                                                                   |
| [\'Code to retrieve data(stream) from database]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                 |
|                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ms [As]{style="COLOR: blue"} MemoryStream = [New]{style="COLOR: blue"} MemoryStream(value)]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                                                   |
| [ms.Position = 0]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ aser [As]{style="COLOR: blue"} AppStateSerializer = [New]{style="COLOR: blue"} AppStateSerializer(SerializeMode.BinaryFmtStream, ms)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LoadDockState(aser)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 8pt"} 

To serialize in **Binary Format**, use the below code.

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                        |
| [// To Save]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                        |
| [AppStateSerializer serializer =]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ new]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AppStateSerializer(SerializeMode.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[BinaryFile[, \"myfile\");]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[dockingManager1[.]{style="COLOR: black"}SaveDockState[(serializer);]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                                                                                                                                        |
| [serializer.PersistNow();]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                        |
| [// To Load]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                        |
| [AppStateSerializer serializer = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[new]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AppStateSerializer(SerializeMode.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[BinaryFile[, \"myfile\");]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[dockingManager1[.]{style="COLOR: black"}LoadDockState[(serializer);]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                            |
| [\' To Save]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ serializer ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As New]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AppStateSerializer(SerializeMode.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[BinaryFile[, \"myfile\")]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[dockingManager1[.]{style="COLOR: black"}SaveDockState[(serializer)]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                            |
| [serializer.PersistNow()]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                            |
| [\' To Load]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ serializer ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As New]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AppStateSerializer(SerializeMode.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[BinaryFile[, \"myfile\")]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[dockingManager1[.]{style="COLOR: black"}LoadDockState[(serializer)]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

To serialize in **Isolated Storage** medium, use the below code.

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                             |
| [// To Save]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                             |
| [AppStateSerializer serializer =]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ new]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AppStateSerializer(SerializeMode.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[IsolatedStorage[, \"myfile\");]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[dockingManager1[.]{style="COLOR: black"}SaveDockState[(serializer);]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                                                                                                                                                             |
| [serializer.PersistNow();]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                             |
| [// To Load]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                             |
| [AppStateSerializer serializer = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[new]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AppStateSerializer(SerializeMode.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[IsolatedStorage[, \"myfile\");]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[dockingManager1[.]{style="COLOR: black"}LoadDockState[(serializer);]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                 |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                 |
| [\' To Save]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ serializer ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As New]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AppStateSerializer(SerializeMode.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[IsolatedStorage[, \"myfile\")]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                 |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[dockingManager1[.]{style="COLOR: black"}SaveDockState[(serializer)]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                 |
| [serializer.PersistNow()]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                 |
| [\' To Load]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ serializer ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As New]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AppStateSerializer(SerializeMode.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[IsolatedStorage[, \"myfile\")]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                 |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[dockingManager1[.]{style="COLOR: black"}LoadDockState[(serializer)]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

**LoadDesignerDockState()** - The dock state that is set through visual designer can be restored by calling LoadDesignerDockState method.

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                         |
|                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                               |
|                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LoadDesignerDockState();]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+-------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                  |
|                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                            |
|                                                                                                                                     |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LoadDesignerDockState()]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

**GetSerializedControls -** Calling the GetSerializedControls method will return the serialized control collection enumerator in the specified serializer. This can be done through code as follows.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  ------------ ------------------------------------------
  Parameter    Description
  Serializer   An instance of AppStateSerializer class.
  ------------ ------------------------------------------
:::

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                              |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.GetSerializedControls(serializer);]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                                             |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Write([\"Serialized controls :\"]{style="COLOR: maroon"} + [this]{style="COLOR: blue"}.dockingManager1.GetSerializedControls(serializer));]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                       |
|                                                                                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                 |
|                                                                                                                                                                                                                                          |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.GetSerializedControls(serializer)]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                                          |
| [Console]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.Write([\"Serialized controls :\"]{style="COLOR: maroon"} + [Me]{style="COLOR: blue"}.dockingManager1.GetSerializedControls(serializer))]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

See Also

[]{style="COLOR: #15428b"} 

[ProvidePersistenceID Event]{.UGHyperlink}[, ]{.UGHyperlink}[How to avoid flickering while loading dock state?]{.UGHyperlink}[, ]{.UGHyperlink}

[How to serialize or deserialize the docking state for a docked control on loading the application?]{.UGHyperlink}[]{.UGHyperlink}

[[]{style="TEXT-DECORATION: none"}]{.UGHyperlink} 

[[]{style="TEXT-DECORATION: none"}]{.UGHyperlink} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
[[Note: ]{style="COLOR: windowtext; FONT-SIZE: 9pt; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}PersistState property mechanism assumes that the DockingManger is hosted on a form and captures the docking layout on the host form's closing event. When DockingManager is hosted on a UserControl, LoadDockState and SaveDockState methods have to be called explicitly, on the Load and Closed events of the form that hosts the UserControl.

 

[[]{style="COLOR: windowtext; FONT-SIZE: 9pt; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink} 
:::

[]{#related-topics}
::::::::

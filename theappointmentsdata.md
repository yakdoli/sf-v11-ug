::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### The Appointments Data {#the-appointments-data style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Here are the ScheduleData base classes that provide the Appointments data used by ScheduleControl. For code details of deriving these ScheduleData base classes to implement a data provider for the ScheduleControl, please see the SimpleScheduleDataProvider code file that ships as part of the ScheduleSample sample.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

ScheduleAppointment Class

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**ScheduleAppointment** is the class that defines the objects that represent appointments in the Schedule Control. This class implements **IScheduleAppointment** to provide an object to hold the concrete data associated with appointments. You can either derive this class or implement IScheduleAppointment yourself to extend or modify the information managed by the ScheduleAppointment class. Here are the properties exposed in ScheduleAppointment.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**UniqueID**: gets or sets a unique integer associated with this item

 

[·      ]{style="FONT-FAMILY: Symbol"}**Owner**: gets or sets an integer that can be used to identify the owner (if any) of this item

 

[·      ]{style="FONT-FAMILY: Symbol"}**StartTime**: gets or sets the start time for this item

 

[·      ]{style="FONT-FAMILY: Symbol"}**EndTime**: gets or sets the end time for this item

 

[·      ]{style="FONT-FAMILY: Symbol"}**Subject**: gets or sets a text string identifying the topic of this item

 

[·      ]{style="FONT-FAMILY: Symbol"}**Content**: gets or sets a text string holding the details or comments for this appointment item

 

[·      ]{style="FONT-FAMILY: Symbol"}**AllDay**: gets or sets whether this appointment is an all-day appointment

 

[·      ]{style="FONT-FAMILY: Symbol"}**LabelValue**: gets or sets an integer categorizer value for this item

 

[·      ]{style="FONT-FAMILY: Symbol"}**MarkerValue**: gets or sets an integer categorizer value for this item

 

[·      ]{style="FONT-FAMILY: Symbol"}**Reminder**: gets or sets whether you want a reminder event raised when the StartTime of this item gets close

 

[·      ]{style="FONT-FAMILY: Symbol"}**ReminderValue**: gets or sets the type of reminder event raised when the StartTime of this item gets close

 

[·      ]{style="FONT-FAMILY: Symbol"}**LocationValue**: gets or sets a string associated with this item

 

[·      ]{style="FONT-FAMILY: Symbol"}**Version**: gets in integer format the version number (used to support data format versioning)

 

[·      ]{style="FONT-FAMILY: Symbol"}**Tag**: gets or sets an arbitrary object associated with this item

 

[·      ]{style="FONT-FAMILY: Symbol"}**Dirty**: gets or sets whether this item has been modified

 

[·      ]{style="FONT-FAMILY: Symbol"}**IgnoreChanges**: gets or sets whether changes to this item affect the Dirty property

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

ScheduleAppointmentList Class

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**ScheduleAppointmentList** is a collection of IScheduleAppointments that serves as the data for the Schedule Control. This class is a wrapper class for an ArrayList and implements **IComparer** to order this list by the item\'s StartTime. If two items start at the same time, then the EndTime is used as well to determine the order. Longer appointments rank higher. Here are the properties and methods exposed in ScheduleAppointmentList.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                          |
|                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Gets or sets the i-th IScheduleAppointment in this list.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                     |
|                                                                                                                                                                                                                                         |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [IScheduleAppointment]{style="COLOR: teal"} [this]{style="COLOR: blue"}\[[int]{style="COLOR: blue"} i\];]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                         |
| [              ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Gets the number of IScheduleAppointments in this list.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                       |
|                                                                                                                                                                                                                                         |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [int]{style="COLOR: blue"} Count]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                                                         |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Sorts this list on the IScheduleAppointment.StartTime property.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                              |
|                                                                                                                                                                                                                                         |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [void]{style="COLOR: blue"} SortStartTime()]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                                                         |
| [               ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Adds an IScheduleAppointment to this list.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                   |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ item - The IScheduleAppointment to be added.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                 |
|                                                                                                                                                                                                                                         |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [void]{style="COLOR: blue"} Add(IScheduleAppointment item)]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                                                                         |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Inserts an IScheduleAppointment into this list.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                              |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ index - The position in the list where the item is to be inserted. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                          |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ item - The IScheduleAppointment to be inserted. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                             |
|                                                                                                                                                                                                                                         |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [void]{style="COLOR: blue"} Insert([int]{style="COLOR: blue"} index, IScheduleAppointment item)]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                                                                                         |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Removes an IScheduleAppointment from this list.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                              |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ item - The IScheduleAppointment to be removed. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                              |
|                                                                                                                                                                                                                                         |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [void]{style="COLOR: blue"} Remove(IScheduleAppointment item)]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                                                                         |
| [               ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Removes an IScheduleAppointment from this list.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                              |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ index - The position of the item to be removed.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                              |
|                                                                                                                                                                                                                                         |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [void]{style="COLOR: blue"} RemoveAt([int]{style="COLOR: blue"} index)]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                                                                                         |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Returns the position of the specified item within this list.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                 |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ item - The search item. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                                                                                         |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [int]{style="COLOR: blue"} IndexOf(IScheduleAppointment item)]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                                                                         |
| [               ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                         |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Returns a new ScheduleAppointment populated with default values.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                             |
|                                                                                                                                                                                                                                         |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [IScheduleAppointment]{style="COLOR: teal"} NewScheduleAppointment()  ]{style="FONT-FAMILY: 'Courier New'"}                                   |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

ScheduleDataProvider Class

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

**ScheduleDataProvider** has two functional roles.

One is to implement **IScheduleDataProvider** in a virtual manner so that derived classes can provide concrete implementations through virtual overrides. The IScheduleDataProvider virtual methods exposed in ScheduleDataProvider have empty implementations, so you are required to derive this class to use it.

The second role is to provide the **DropList** data. For this second role, the ScheduleDataProvider does provide concrete implementations for the virtual methods it exposes. So, in your derived class, you would have populated droplists without doing further work, though you can choose to customize these droplists through virtual overrides. Here is a list of the stub methods exposed by ScheduleDataProvider in its first role.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                           |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Return an IScheduleAppointmentList holding the schedule items for the given date. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                             |
|                                                                                                                                                                                                                                                                                           |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [IScheduleAppointmentList]{style="COLOR: teal"} GetScheduleForDay(DateTime day)]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                                                                                           |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                           |
| [//// Return an IScheduleAppointmentList holding the schedule items between the given dates.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                           |
|                                                                                                                                                                                                                                                                                           |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [IScheduleAppointmentList]{style="COLOR: teal"} GetSchedule(DateTime startDate, [DateTime]{style="COLOR: teal"} endDate)]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                           |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Return an IScheduleAppointmentList holding the schedule items for a particular owner on the given date. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                       |
|                                                                                                                                                                                                                                                                                           |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [IScheduleAppointmentList]{style="COLOR: teal"} GetScheduleForDay(DateTime day, [int]{style="COLOR: blue"} owner)]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                                                                                                           |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                           |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Return an IScheduleAppointmentList holding the schedule items for a particular owner between the given dates.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                  |
|                                                                                                                                                                                                                                                                                           |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [IScheduleAppointmentList]{style="COLOR: teal"} GetSchedule(DateTime startDate, [DateTime]{style="COLOR: teal"} endDate, [int]{style="COLOR: blue"} owner)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                           |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                           |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Saves any modified ScheduleAppointments.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                       |
|                                                                                                                                                                                                                                                                                           |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [void]{style="COLOR: blue"} CommitChanges()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                                                                                           |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                           |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Gets or sets whether CommitChanges is called when the ScheduleControl is disposed.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                             |
|                                                                                                                                                                                                                                                                                           |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [SaveOnCloseBehavior]{style="COLOR: teal"} SaveOnCloseBehaviorAction]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                                                                                           |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                           |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Gets or sets whether data source is modified or not.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                           |
|                                                                                                                                                                                                                                                                                           |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [bool]{style="COLOR: blue"} IsDirty]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                                                                                                           |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                           |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Returns a new ScheduleAppointment populated with default values.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                               |
|                                                                                                                                                                                                                                                                                           |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [IScheduleAppointment]{style="COLOR: teal"} NewScheduleAppointment()]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                                                                                                           |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                           |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Adds a ScheduleAppointment to the list.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                        |
|                                                                                                                                                                                                                                                                                           |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [void]{style="COLOR: blue"} AddItem(IScheduleAppointment item)]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                                                                                           |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                           |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Removes a ScheduleAppointment from the list. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                  |
|                                                                                                                                                                                                                                                                                           |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [void]{style="COLOR: blue"} RemoveItem(IScheduleAppointment item)]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Here are the methods and properties used as part of the ScheduleDataProvider\'s second role, providing the DropList data. The following is the actual implementation code which gives an indication of the exposed functionality.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                              |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Provides default droplists for entering IScheduleAppointment data. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                              |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ You can override this method to provide customized droplists.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                    |
|                                                                                                                                                                                                                                             |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [void]{style="COLOR: blue"} InitLists()]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [labelList = [new]{style="COLOR: blue"} [ListObjectList]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                                             |
| [labelList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(0,[\"None\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                                             |
| [labelList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(1,[\"Important\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.FromArgb(255,128,64)));]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                                                                             |
| [labelList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(2,[\"Business\"]{style="COLOR: maroon"},  [Color]{style="COLOR: teal"}.FromArgb(86,152,233)));]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                                                                             |
| [labelList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(3,[\"Personal\"]{style="COLOR: maroon"},  [Color]{style="COLOR: teal"}.FromArgb(57,210,53)));]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                                                                             |
| [labelList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(4,[\"Vacation\"]{style="COLOR: maroon"},  [Color]{style="COLOR: teal"}.FromArgb(199,198,182)));]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                                             |
| [labelList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(5,[\"Must Attend\"]{style="COLOR: maroon"},  [Color]{style="COLOR: teal"}.FromArgb(255,128,0)));]{style="FONT-FAMILY: 'Courier New'"}                           |
|                                                                                                                                                                                                                                             |
| [labelList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(6,[\"Travel Required\"]{style="COLOR: maroon"},  [Color]{style="COLOR: teal"}.FromArgb(0,255,255)));]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                                                             |
| [labelList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(7,[\"Needs Preparation\"]{style="COLOR: maroon"},  [Color]{style="COLOR: teal"}.FromArgb(171,171,88)));]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                                             |
| [labelList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(8,[\"Birthday\"]{style="COLOR: maroon"},  [Color]{style="COLOR: teal"}.FromArgb(186,117,255)));]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                                             |
| [labelList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(9,[\"Anniversary\"]{style="COLOR: maroon"},  [Color]{style="COLOR: teal"}.FromArgb(255,128,64)));]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                                             |
| [labelList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(10,[\"Phone Call\"]{style="COLOR: maroon"},  [Color]{style="COLOR: teal"}.FromArgb(255,128,64)));]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [markerList = [new]{style="COLOR: blue"} [ListObjectList]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [//same as no Mark Color]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                             |
| [markerList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(0,[\"Free\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.FromArgb(50, [Color]{style="COLOR: teal"}.RoyalBlue)));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                             |
| [markerList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(1,[\"Tentative\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.FromArgb(255, 206, 206)));]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                                             |
| [markerList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(2,[\"Busy\"]{style="COLOR: maroon"},  [Color]{style="COLOR: teal"}.FromArgb(0,0,242)));]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                                                                                             |
| [markerList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(3,[\"Out of Office\"]{style="COLOR: maroon"},  [Color]{style="COLOR: teal"}.FromArgb(128, 0 ,64)));]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [reminderList = [new]{style="COLOR: blue"} [ListObjectList]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                                                                             |
| [reminderList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(0,[\"0 minutes\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                                                             |
| [reminderList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(1,[\"5 minutes\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                                                             |
| [reminderList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(2,[\"10 minutes\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                                                             |
| [reminderList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(3,[\"15 minutes\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                                                             |
| [reminderList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(4,[\"30 minutes\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                                                             |
| [reminderList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(5,[\"1 hour\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                                                             |
| [reminderList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(6,[\"2 hours\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                                                             |
| [reminderList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(7,[\"3 hours\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                                                             |
| [reminderList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(8,[\"4 hours\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                                                             |
| [              ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.locationList = [new]{style="COLOR: blue"} [ListObjectList]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                                             |
| [locationList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(0,[\"\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                                             |
| [locationList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(1,[\"RoomB\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                                                                             |
| [locationList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(2,[\"RoomC\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                                                                             |
| [locationList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(3,[\"RoomD\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                                                                             |
| [locationList.Add([new]{style="COLOR: blue"} [ListObject]{style="COLOR: teal"}(4,[\"RoomE\"]{style="COLOR: maroon"}, [Color]{style="COLOR: teal"}.White)); ]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Returns the list for the LabelValue options.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                     |
|                                                                                                                                                                                                                                             |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [ILookUpObjectList]{style="COLOR: teal"} GetLabels()]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [   [return]{style="COLOR: blue"} LabelList;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Gets or sets the list for the LabelList options.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                 |
|                                                                                                                                                                                                                                             |
| [protected]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ListObjectList]{style="COLOR: teal"} LabelList]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [   [get]{style="COLOR: blue"}{[return]{style="COLOR: blue"} labelList;}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                             |
| [   [set]{style="COLOR: blue"}{labelList = [value]{style="COLOR: blue"};}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Returns the list for the ReminderValue options.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                  |
|                                                                                                                                                                                                                                             |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [ILookUpObjectList]{style="COLOR: teal"} GetReminders()]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [   [return]{style="COLOR: blue"} ReminderList;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Gets or sets the list for the ReminderValue options.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                             |
|                                                                                                                                                                                                                                             |
| [protected]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ListObjectList]{style="COLOR: teal"} ReminderList]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [   [get]{style="COLOR: blue"}{[return]{style="COLOR: blue"} reminderList;}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                                             |
| [   [set]{style="COLOR: blue"}{reminderList = [value]{style="COLOR: blue"};}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Returns the list for the MarkerValue options.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                    |
|                                                                                                                                                                                                                                             |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [ILookUpObjectList]{style="COLOR: teal"} GetMarkers()]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [   [return]{style="COLOR: blue"} MarkerList;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Gets or sets the list for the MarkerValue options.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                               |
|                                                                                                                                                                                                                                             |
| [protected]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ListObjectList]{style="COLOR: teal"} MarkerList]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [   [get]{style="COLOR: blue"}{[return]{style="COLOR: blue"} markerList;}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                             |
| [   [set]{style="COLOR: blue"}{markerList = [value]{style="COLOR: blue"};}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Returns the list for the LocationValue options.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                  |
|                                                                                                                                                                                                                                             |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [ILookUpObjectList]{style="COLOR: teal"} GetLocations()]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [   [return]{style="COLOR: blue"} LocationList;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                        |
|                                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [               ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Gets or sets the list for the LocationValue options.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                             |
|                                                                                                                                                                                                                                             |
| [protected]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ListObjectList]{style="COLOR: teal"} LocationList]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [   [get]{style="COLOR: blue"}{[return]{style="COLOR: blue"} locationList;}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                                             |
| [   [set]{style="COLOR: blue"}{locationList = [value]{style="COLOR: blue"};}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Returns the list for the Owner options.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                          |
|                                                                                                                                                                                                                                             |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [ILookUpObjectList]{style="COLOR: teal"} GetOwners()]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [return]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ OwnerList;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Gets or sets the list for the Owner options.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                     |
|                                                                                                                                                                                                                                             |
| [protected]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ListObjectList]{style="COLOR: teal"} OwnerList]{style="FONT-FAMILY: 'Courier New'"}                                                                                          |
|                                                                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                             |
| [   [get]{style="COLOR: blue"}{[return]{style="COLOR: blue"} ownerList;}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                             |
| [   [set]{style="COLOR: blue"}{ownerList = [value]{style="COLOR: blue"};}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p17} 

[]{#related-topics}
:::

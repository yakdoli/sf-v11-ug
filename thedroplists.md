::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### The DropLists {#the-droplists style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The second type of data required of the ScheduleControl is the **DropList** data. You have seen a concrete implementation of providing this DropList data in the [The Appointments Data]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"} discussion. Two classes that can provide such data are listed below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**ListObjectClass**

The **ListObject** is a wrapper class for list choices that can have a ValueMember, DisplayMember and ColorMember associated with them. The class is an implementation of the **IListObject** that exposes the IListObject functionality as virtual members. This allows you to implement the IListObject by deriving the ListObject and overriding virtual properties. Here are the properties exposed by this class.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                     |
|                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                               |
|                                                                                                                                                                                    |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ An integer that is stored in the data objects to represent this object.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                                                    |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [int]{style="COLOR: blue"} ValueMember]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                    |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                    |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ A string that is used when this object is displayed.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                    |
|                                                                                                                                                                                    |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [string]{style="COLOR: blue"} DisplayMember]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                                                    |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                    |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ A color associated with this object.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                    |
|                                                                                                                                                                                    |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [virtual]{style="COLOR: blue"} [Color]{style="COLOR: teal"} ColorMember]{style="FONT-FAMILY: 'Courier New'"}            |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**ListObjectList**

The **ListObjectList** is a strongly-typed ArrayList that holds a collection of ListObjects. The class is derived from ArrayList and implements both **ITypedList** and **IlistListObjectList**. Here are the properties and methods exposed in this class.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                              |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Returns the property descriptors for each property in ListObject.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[\</returns\>]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"} |
|                                                                                                                                                                                                                                             |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [PropertyDescriptorCollection]{style="COLOR: teal"} GetItemProperties(PropertyDescriptor\[\] listAccessors)]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                                                             |
| [               ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Returns a list name]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[\</returns\>]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}                                               |
|                                                                                                                                                                                                                                             |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [string]{style="COLOR: blue"} GetListName(PropertyDescriptor\[\] listAccessors)]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                                             |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                             |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Gets or sets the i-th item in the list.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                          |
|                                                                                                                                                                                                                                             |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [new]{style="COLOR: blue"} [ILookUpObject]{style="COLOR: teal"} [this]{style="COLOR: blue"}\[[int]{style="COLOR: blue"} i\]]{style="FONT-FAMILY: 'Courier New'"}                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p18}[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 12pt"} 

[]{#related-topics}
:::

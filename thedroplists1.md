::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### The DropLists {#the-droplists style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Two of the five data interfaces work directly with the **DropList** data. Here are the two interfaces.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**ILookUpObject Interface**

**ILookUpObject** is part of the data support to provide the DropList data. This interface defines the object that may appear in a droplist.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                           |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                     |
|                                                                                                                                                                                          |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Defines items that can be included in a ILookUpObjectList.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                    |
|                                                                                                                                                                                          |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Choice lists within the ScheduleControl are used to provide possible ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}         |
|                                                                                                                                                                                          |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ schedule item information like location or a reminder. ILookUpObject ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}         |
|                                                                                                                                                                                          |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ allows such list items to have a ValueMember / DisplayMember associated with ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                                                          |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ the choices as well as a color that will be used in drop-downs showing these]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}  |
|                                                                                                                                                                                          |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ lists. Value members are normally the values serialized to data stores.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}       |
|                                                                                                                                                                                          |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [interface]{style="COLOR: blue"} [ILookUpObject]{style="COLOR: teal"} ]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                          |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                          |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ The value member associated with this item.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                   |
|                                                                                                                                                                                          |
| [int]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ValueMember {[get]{style="COLOR: blue"}; [set]{style="COLOR: blue"};}]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ The display member associated with this item.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                 |
|                                                                                                                                                                                          |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ DisplayMember {[get]{style="COLOR: blue"}; [set]{style="COLOR: blue"};}]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                          |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ A color associated with this item.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                            |
|                                                                                                                                                                                          |
| [Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ ColorMember {[get]{style="COLOR: blue"}; [set]{style="COLOR: blue"};}]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                          |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**ILookUpObjectList** **Interface**

**ILookUpObjectList** is the wrapper for this list of objects that may appear in a droplist.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                           |
| [\                                                                                                                                                                                                                                                                                                                        |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Collection of ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[\<see cref=\"ILookUpObject\"/\>]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ items.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                                                                                                                                                                                           |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [interface]{style="COLOR: blue"} [ILookUpObjectList]{style="COLOR: teal"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                           |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                           |
| [///]{style="FONT-FAMILY: 'Courier New'; COLOR: gray"}[ Indexer that returns a ILookUpObject object.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                           |
| [ILookUpObject]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ [this]{style="COLOR: blue"}\[[int]{style="COLOR: blue"} i\] {[get]{style="COLOR: blue"}; [set]{style="COLOR: blue"};}]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                                                                                                                                           |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::

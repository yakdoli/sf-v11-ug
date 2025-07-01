::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### The ICalcData Interface {#the-icalcdata-interface style="tab-stops: 0pt"}

 

**ICalcData** has three methods and one event. This interface allows the **CalcEngine** class in Essential Calculate to communicate with arbitrary data sources that implement this interface.

 

[·      ]{style="FONT-FAMILY: Symbol"}**GetValueRowCol**-Returns the data value of a specified row and column

[·      ]{style="FONT-FAMILY: Symbol"}**SetValueRowCol**-Sets the data value of a specified row and column

[·      ]{style="FONT-FAMILY: Symbol"}**WireParentObject**-A callback to the data object that occurs as the CalcEngine is being created. The purpose is to give the data object a chance to do any initialization steps it may need, such as subscribe to events to handle changes in data notifications.

[·      ]{style="FONT-FAMILY: Symbol"}**ValueChanged**-An event that is raised whenever data changes. The ICalcData implementer raises this event when the data changes. The CalcEngine listens to this event and accordingly reacts to data changes. It is through this event that formulas are processed and dependencies are tracked by the CalcEngine.

[]{#p38} 

[]{#related-topics}
:::

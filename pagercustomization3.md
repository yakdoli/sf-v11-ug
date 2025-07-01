::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Pager Customization {#pager-customization style="tab-stops: 0pt"}

[·      ]{style="FONT-FAMILY: Symbol"}To change the page size, use the **PageSize** property. [   ]{style="FONT-FAMILY: Consolas; COLOR: #2b91af; FONT-SIZE: 9.5pt"}

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[Controller]{style="FONT-FAMILY: 'Courier New'"}**[ ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                              |
| [GridPropertiesModel]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[\<[Order]{style="COLOR: #2b91af"}\> gridModel = [new]{style="COLOR: blue"} [GridPropertiesModel]{style="COLOR: #2b91af"}\<[Order]{style="COLOR: #2b91af"}\>()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                              |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                              |
| **[                ]{style="FONT-FAMILY: 'Courier New'"}**[ActionMode = ActionMode.JSON,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                                                                                                              |
| [                Caption = [\"Orders Details\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                                              |
| [                AllowPaging = [true]{style="COLOR: blue"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                              |
| **[                PageSize=20]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                              |
| [            };]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                      |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[·      ]{style="FONT-FAMILY: Symbol"}To change the number of visible pages counted in the pager bar, use the **PageCount** property.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[Controller]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                              |
| [GridPropertiesModel]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[\<[Order]{style="COLOR: #2b91af"}\> gridModel = [new]{style="COLOR: blue"} [GridPropertiesModel]{style="COLOR: #2b91af"}\<[Order]{style="COLOR: #2b91af"}\>()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                              |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                              |
| [               ActionMode = ActionMode.JSON,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                              |
| [                Caption = [\"Orders Details\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                                              |
| [                AllowPaging = [true]{style="COLOR: blue"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                              |
| **[                PageCount=5]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                              |
| [            };]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                      |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[·      ]{style="FONT-FAMILY: Symbol"}If you want to render the grid with initial paging, use the **CurrentPage** property.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[Controller]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                              |
| [GridPropertiesModel]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[\<[Order]{style="COLOR: #2b91af"}\> gridModel = [new]{style="COLOR: blue"} [GridPropertiesModel]{style="COLOR: #2b91af"}\<[Order]{style="COLOR: #2b91af"}\>()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                              |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                              |
| [                ActionMode = ActionMode.JSON,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                              |
| [                Caption = [\"Orders Details\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                                              |
| [                AllowPaging = [true]{style="COLOR: blue"},]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                              |
| [                CurrentPage=3]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                              |
| [            };]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}                                                                                                                                                      |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

Tables for Properties and Methods

 

Properties

 

+--------------------------------------+-----------------------------------------------+-----------------+--------------------------------------+
| **Property**                         | **Description**                               | **Type**        | **Data type**                        |
+--------------------------------------+-----------------------------------------------+-----------------+--------------------------------------+
| ActionMode[]{style="COLOR: #c00000"} | Gets or sets the **ActionMode** for the grid. | **Server-side** | ActionMode[]{style="COLOR: #c00000"} |
|                                      |                                               |                 |                                      |
|                                      | \                                             |                 |                                      |
|                                      | **Possible Values:**                          |                 |                                      |
|                                      |                                               |                 |                                      |
|                                      | ActionMode.JSON                               |                 |                                      |
|                                      |                                               |                 |                                      |
|                                      | ActionMode.Server                             |                 |                                      |
|                                      |                                               |                 |                                      |
|                                      |                                               |                 |                                      |
|                                      |                                               |                 |                                      |
|                                      | **Default value:**                            |                 |                                      |
|                                      |                                               |                 |                                      |
|                                      | ActionMode.Server                             |                 |                                      |
+--------------------------------------+-----------------------------------------------+-----------------+--------------------------------------+

*[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 9pt"}* 

Methods

*[]{style="LINE-HEIGHT: 115%; FONT-SIZE: 9pt"}* 

+-------------------------------------------------------------+------------------------------------------------------------------+-----------------------------------------------------------------+-----------------------------------------------------------+------------------------------------------------------------------+
| **[Method ]{style="COLOR: black"}**[]{style="COLOR: black"} | **[Description ]{style="COLOR: black"}**[]{style="COLOR: black"} | **[Parameters ]{style="COLOR: black"}**[]{style="COLOR: black"} | **[Type ]{style="COLOR: black"}**[]{style="COLOR: black"} | **[Return type ]{style="COLOR: black"}**[]{style="COLOR: black"} |
+-------------------------------------------------------------+------------------------------------------------------------------+-----------------------------------------------------------------+-----------------------------------------------------------+------------------------------------------------------------------+
| [ActionMode]{style="COLOR: black"}                          | Gets the **ActionMode** for the grid.                            | (ActionMode mode)                                               | **Server-side**                                           | Void                                                             |
|                                                             |                                                                  |                                                                 |                                                           |                                                                  |
|                                                             |                                                                  | **Possible Values:**                                            |                                                           |                                                                  |
|                                                             |                                                                  |                                                                 |                                                           |                                                                  |
|                                                             |                                                                  | ActionMode.JSON                                                 |                                                           |                                                                  |
|                                                             |                                                                  |                                                                 |                                                           |                                                                  |
|                                                             |                                                                  | ActionMode.Server                                               |                                                           |                                                                  |
|                                                             |                                                                  |                                                                 |                                                           |                                                                  |
|                                                             |                                                                  |                                                                 |                                                           |                                                                  |
|                                                             |                                                                  |                                                                 |                                                           |                                                                  |
|                                                             |                                                                  | **Default value:**                                              |                                                           |                                                                  |
|                                                             |                                                                  |                                                                 |                                                           |                                                                  |
|                                                             |                                                                  | ActionMode.Server                                               |                                                           |                                                                  |
+=============================================================+==================================================================+=================================================================+===========================================================+==================================================================+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Link

To view the samples, follow the steps below:

1.   Open the **ASP.NET MVC** sample browser from the dashboard. (Refer to the Samples and Location chapter)

2.   Navigate to **Grid**\>**Paging**\>**JSON Mode**.

 

[]{#related-topics}
:::

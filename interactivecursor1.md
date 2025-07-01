::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3bfd42f0-8404-43a0-ab15-04339098724b){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=6ebb1818-ba28-4765-a17f-b54de9f06f7a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=696f5666-8b81-4685-9bd9-12198f06f3ad){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[UserInteraction](ms-xhelp:///?Id=0c3ea2f6-e05d-4162-9e06-d6af6a893c70){.d2h_breadcrumbsNormal}
:::

### Interactive Cursor {#interactive-cursor style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The Interactive Cursor feature allows you to position the mouse pointer on a specific data point in a series and provides you a hint on its x and y values by a horizontal and vertical line passing through the data point and intersecting the x and y axis. These lines can be dragged around to position them at specific data points.

Interactive Cursor can be implemented by creating an instance of ChartInteractiveCursor with the **ChartSeries** as its input. Then, add the instance to the Interactive Cursors collection, as shown below.

Features

You can click and drag the Interactive cursor to the point for which you want to identify the corresponding xvalue or yvalue even after zooming.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Properties:

For Chart Interactive Cursor, in the server-side the following properties are available, to set the color, x position, and yposition properties of the interactive cursor:

[  ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

::: {align="center"}
+-------------+-------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------+------------------------------------------------+---------------------------------------------------+
| Property    | Description                                                                                                                         | Property Type                                  | Value it Accepts                               | Any Other Dependencies/Sub-properties Associated  |
+=============+=====================================================================================================================================+================================================+================================================+===================================================+
| Color       | It specifies the Interactive cursor color that is to be rendered.                                                                   | System.Drawing.[Color]{style="COLOR: #2b91af"} | System.Drawing.[Color]{style="COLOR: #2b91af"} | Dependent on the ShowInteractiveCursors property. |
+-------------+-------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------+------------------------------------------------+---------------------------------------------------+
| XPosition   | It selects the X -- Index from the sorted points (sorting by using XValues) and also changes the YPosition according to this value. | [int]{style="COLOR: blue"}                     | [int]{style="COLOR: blue"}                     | Dependent on the ShowInteractiveCursors property. |
+-------------+-------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------+------------------------------------------------+---------------------------------------------------+
| YPosition   | It selects the Y -- Index from the sorted points (sorting by using YValues) and also changes the XPosition according to this value. | [int]{style="COLOR: blue"}                     | [int]{style="COLOR: blue"}                     | Dependent on the ShowInteractiveCursors property. |
|             |                                                                                                                                     |                                                |                                                |                                                   |
|             |                                                                                                                                     |                                                |                                                |                                                   |
+-------------+-------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------+------------------------------------------------+---------------------------------------------------+
:::

 

Client-side Methods:

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

Chart MVC also provides the client-side function to set the Interactive cursor properties such as color, style, and width and to also get these properties.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

::: {align="center"}
  Name                      Parameters                                                           Return Type   Description[]{style="COLOR: black"}
  ------------------------- -------------------------------------------------------------------- ------------- ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  get_InterCursorProperty   InteractiveCursorIndex -- int(datatype)                              Jsondata      It is used to get the specified interactive Cursor properties such as color, style, and width.
  cursorColor               Color -- string(datatype), InteractiveCursorIndex -- int(datatype)   None          It is used to set the specified interactive cursor color.
  cursorWidth               Width -- int(datatype), InteractiveCursorIndex -- int(datatype)      none          It is used to set the specified Interactive cursor width
  cursorStyle               Style -- string(datatype), InteractiveCursorIndex -- int(datatype)   none          It is used to set the specified Interactive cursor style.
  horizontalNext            InteractiveCursorIndex                                               none          It is used to move the specified Interactive Cursor horizontally to the next position, i.e., right.
  horizontalPrev            InteractiveCursorIndex                                               none          It is used to move the specified Interactive Cursor horizontally to the previous position, i.e., left.
  verticalNext              InteractiveCursorIndex                                               none          It is used to move the specified Interactive Cursor vertically to the next position, i.e., up.
  verticalPrev              InteractiveCursorIndex                                               none          It is used to move the specified Interactive Cursor vertically to the previous position, i.e., down.
  CursorAreaPointTally      InteractiveCursorIndex                                               none          If the Interactive cursor is in an invisible region of the ChartArea, then this function moves the ChartArea to the position where the specified Interactive cursor is present.
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The following are the uses of the get_InterCursorproperty function. It returns jsondata, which contains the CursorStyle, CursorWidth, and CursorColor properties. By this you can get all the Interactive cursor properties.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| \[js\]                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                        |
| [                ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}[var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ chart = \$find([\"Chart_Model\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                        |
| [                [var]{style="COLOR: blue"} Property = chart.get_InterCursorProperty(InteractiveCursorIndex);]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                        |
| [                \$([\'#CursorStyle\']{style="COLOR: #a31515"}).val(Property.CursorStyle);]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                        |
| [                \$([\'#CursorWidth\']{style="COLOR: #a31515"}).val(Property.CursorWidth);]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                                                        |
| [                \$([\'#Color\']{style="COLOR: #a31515"}).val(Property.CursorColor);]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                                                                        |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The following are the uses of the cursorColor, cursorWidth, and cursorStyle functions. These functions change the **color, width,** and **style** of the Interactive Cursor in the **chart** object respectively.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| \[js\]                                                                                                                                                                 |
|                                                                                                                                                                        |
| [                [var]{style="COLOR: blue"} color = \$get([\"Color\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                                                        |
| [                var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Width = \$get([\"CursorWidth\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                        |
| [                var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Style = \$get([\"CursorStyle\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                        |
| [                [var]{style="COLOR: blue"} chart = \$find([\"Chart_Model\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                        |
| [                chart.cursorColor(color.value, InteractiveCursorIndex);]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                        |
| [                chart.cursorWidth(Width.value, InteractiveCursorIndex);]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                        |
| [                chart.cursorStyle(Style.value, InteractiveCursorIndex);]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                                                        |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The following are the uses of the horizontalNext function, which moves the specified Interactive Cursor horizontally to the next position, i.e., right.

+---------------------------------------------------------------------------------------------------------------------------------------------+
| \[js\]                                                                                                                                      |
|                                                                                                                                             |
| [                [var]{style="COLOR: blue"} chart = \$find([\"Chart_Model\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                             |
| [                chart.horizontalNext(InteractiveCursorIndex);]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                             |
| []{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                             |
+---------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The following are the uses of the horizontalPrev function, which moves the specified Interactive Cursor horizontally to the previous position, i.e., left.

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| \[js\]                                                                                                                                                                                     |
|                                                                                                                                                                                            |
| [           ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}[     [var]{style="COLOR: blue"} chart = \$find([\"Chart_Model\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                            |
| [                chart.horizontalPrev(InteractiveCursorIndex);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                         |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The following are the uses of the verticalNext function, which moves the specified Interactive Cursor vertically to the next position, i.e., up.

+---------------------------------------------------------------------------------------------------------------------------------------------+
| \[js\]                                                                                                                                      |
|                                                                                                                                             |
| [                [var]{style="COLOR: blue"} chart = \$find([\"Chart_Model\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                             |
| [                chart.verticalNext(InteractiveCursorIndex);]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                             |
| []{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                             |
+---------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The following are the uses of the verticalPrev function, which moves the specified Interactive Cursor vertically to the previous position, i.e., right.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------+
| \[js\][]{style="FONT-SIZE: 9pt"}                                                                                                                 |
|                                                                                                                                                  |
| [                [var]{style="COLOR: blue"} chart = \$find([\"Chart_Model\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                  |
| [                chart.verticalPrev(InteractiveCursorIndex);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The following are the uses of the CursorAreaPointTally function, which moves the ChartArea to the position where the Interactive cursor is present.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+---------------------------------------------------------------------------------------------------------------------------------------------+
| \[js\]                                                                                                                                      |
|                                                                                                                                             |
| [                [var]{style="COLOR: blue"} chart = \$find([\"Chart_Model\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                             |
| [                chart.CursorAreaPointTally(InteractiveCursorIndex);]{style="FONT-FAMILY: 'Courier New'"}                                   |
|                                                                                                                                             |
| []{style="FONT-FAMILY: 'Calibri','sans-serif'"}                                                                                             |
+---------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The Interactive Cursor can be added to the ChartModel through two ways:

[·      ]{style="FONT-FAMILY: Symbol"}Builder

[·      ]{style="FONT-FAMILY: Symbol"}ChartModel

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Builder](ms-xhelp:///?Id=162609ff-4423-4f8b-842a-6b85a9800a6d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ChartModel](ms-xhelp:///?Id=da06303a-7e2d-4aee-aae1-63286866f9ab){style="TEXT-DECORATION: none"}
::::::

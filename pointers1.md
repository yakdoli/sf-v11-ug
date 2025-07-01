::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Pointers {#pointers style="tab-stops: 0pt"}

 

Linear Pointers are scale indicator that points to a value along a scale. Linear Pointers are highly customizable. Linaer Pointers can be added to the linear scale using different parameters to present the scales. The parameters with description are listed below.

 

PointerNeedleType

Two types of pointers are available. They are:

[·      ]{style="FONT-FAMILY: Symbol"}LinearBar Pointer

[·      ]{style="FONT-FAMILY: Symbol"}LinearMarker Pointer

 

i\) LinearBar pointers can be customized using **BarStyle** property; following are the in-built styles available for the BarStyle property:

The styles are listed below.

[·      ]{style="FONT-FAMILY: Symbol"}Rectangle

[·      ]{style="FONT-FAMILY: Symbol"}Thermometer

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

ii\) LinearMarker can be customized using e **MarkerStyle** property; following are the in-built styles available for the MarkerStyle property:

[·      ]{style="FONT-FAMILY: Symbol"}Diamond

[·      ]{style="FONT-FAMILY: Symbol"}Ellipse

[·      ]{style="FONT-FAMILY: Symbol"}Pentagon

[·      ]{style="FONT-FAMILY: Symbol"}Rectangle

[·      ]{style="FONT-FAMILY: Symbol"}Trapezoid

[·      ]{style="FONT-FAMILY: Symbol"}Triangle

 

Location of the Marker can be controlled using **PointerPlacement** property. Length and Width of the pointer can be controlled using its **PointerLength** and  **PointerWidth** property.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Linear Bar and Marker pointers can be added at a time.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Linear Bar Pointer Properties

 

::: {align="center"}
+-----------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| Property        | Description                                | Type of Property                                       | Value It Accepts                                                                                                                                               | Any other dependencies/Sub properties associated |
+-----------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| BarStyle        | Sets the Style of the Bar Pointer.         | [enum]{style="COLOR: blue"}                            | [BarStyle]{style="COLOR: #2b91af"}.Rectangle                                                                                                                   | NA                                               |
|                 |                                            |                                                        |                                                                                                                                                                |                                                  |
|                 |                                            |                                                        |                                                                                                                                                                |                                                  |
|                 |                                            |                                                        |                                                                                                                                                                |                                                  |
|                 |                                            |                                                        | [BarStyle]{style="COLOR: #2b91af"}.Thermometer                                                                                                                 |                                                  |
+-----------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| PointerWidth    | Sets the Width of the Pointer.             | [double]{style="COLOR: blue"}                          | [double]{style="COLOR: blue"}                                                                                                                                  | NA                                               |
+-----------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| BackgroundBrush | Sets the background brush for the pointer. | System.Windows.Media.[Brushes]{style="COLOR: #2b91af"} | Refer to the following Link for  Value for the Brushes class                                                                                                   | NA                                               |
|                 |                                            |                                                        |                                                                                                                                                                |                                                  |
|                 |                                            |                                                        | [[Brushes]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}](http://msdn.microsoft.com/en-us/library/system.windows.media.brushes.aspx) |                                                  |
+-----------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| BorderBrush     | Sets the border brush for the pointer.     | System.Windows.Media.[Brushes]{style="COLOR: #2b91af"} | Refer to the following Link for  Value for the Brushes class                                                                                                   | NA                                               |
|                 |                                            |                                                        |                                                                                                                                                                |                                                  |
|                 |                                            |                                                        | [[Brushes]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}](http://msdn.microsoft.com/en-us/library/system.windows.media.brushes.aspx) |                                                  |
+-----------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| BorderWidth     | Sets the border width of the pointer.      | [double]{style="COLOR: blue"}                          | [double]{style="COLOR: blue"}                                                                                                                                  | NA                                               |
+-----------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| Value           | Sets the Value for the Pointer.            | [double]{style="COLOR: blue"}                          | [double]{style="COLOR: blue"}                                                                                                                                  | NA                                               |
+-----------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
:::

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

Linear Marker Pointer Properties

 

::: {align="center"}
+------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| Property         | Description                                | Type of Property                                       | Value It Accepts                                                                                                                                               | Any other dependencies/Sub properties associated |
+------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| PointerLength    | Sets the length of the Pointer.            | [double]{style="COLOR: blue"}                          | [double]{style="COLOR: blue"}                                                                                                                                  | NA                                               |
+------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| PointerWidth     | Sets the Width of the Pointer.             | [double]{style="COLOR: blue"}                          | [double]{style="COLOR: blue"}                                                                                                                                  | NA                                               |
+------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| BackgroundBrush  | Sets the background brush for the pointer. | System.Windows.Media.[Brushes]{style="COLOR: #2b91af"} | Refer to the below Link for  Value for the Brushes class                                                                                                       | NA                                               |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        | [[Brushes]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}](http://msdn.microsoft.com/en-us/library/system.windows.media.brushes.aspx) |                                                  |
+------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| BorderBrush      | Sets the border brush for the pointer.     | System.Windows.Media.[Brushes]{style="COLOR: #2b91af"} | Refer to the below Link for  Value for the Brushes class                                                                                                       | NA                                               |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        | [[Brushes]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}](http://msdn.microsoft.com/en-us/library/system.windows.media.brushes.aspx) |                                                  |
+------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| BorderWidth      | Sets the border width of the pointer.      | [double]{style="COLOR: blue"}                          | [double]{style="COLOR: blue"}                                                                                                                                  | NA                                               |
+------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| PointerPlacement | Sets the position of the Marker.           | [enum]{style="COLOR: blue"}                            | [ScalePlacement]{style="COLOR: #2b91af"}.Cross                                                                                                                 | NA                                               |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        | [ScalePlacement]{style="COLOR: #2b91af"}.Inside                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        | [ScalePlacement]{style="COLOR: #2b91af"}.Outside                                                                                                               |                                                  |
+------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| MarkerStyle      | Sets the Marker style.                     | [enum]{style="COLOR: blue"}                            | [MarkerStyle]{style="COLOR: #2b91af"}.Diamond                                                                                                                  | NA                                               |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        | [MarkerStyle]{style="COLOR: #2b91af"}.Ellipse                                                                                                                  |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        | [MarkerStyle]{style="COLOR: #2b91af"}.Pentagon                                                                                                                 |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        | [MarkerStyle]{style="COLOR: #2b91af"}.Rectangle                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        | [MarkerStyle]{style="COLOR: #2b91af"}.Trapezoid                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        |                                                                                                                                                                |                                                  |
|                  |                                            |                                                        | [MarkerStyle]{style="COLOR: #2b91af"}.Triangle                                                                                                                 |                                                  |
+------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
| Value            | Sets the Value for the Pointer             | [double]{style="COLOR: blue"}                          | [double]{style="COLOR: blue"}                                                                                                                                  | NA                                               |
+------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+--------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Through View Customization](ms-xhelp:///?Id=af6f9967-03cd-4dbe-878a-09653fd92302){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Through LinearGaugeModel](ms-xhelp:///?Id=48cd43a4-098d-4e74-bda4-02f1dcf91459){style="TEXT-DECORATION: none"}
:::::

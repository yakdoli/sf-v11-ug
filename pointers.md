::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Pointers {#pointers style="tab-stops: 0pt"}

 

Circular Pointers are scale indicator that points to a value along a scale. Circular Pointers are highly customizable. Circular Pointers can be added to the circular scale using different parameters to present the scales.

 

PointerNeedleType

Two types of pointer needles are available. They are:

[·      ]{style="FONT-FAMILY: Symbol"}Needle

[·      ]{style="FONT-FAMILY: Symbol"}Marker

The types listed above are considered as the shapes of the pointers. They have broad classifications of types.

Needles can be customized using the **NeedleStyle** property; following are the in-built styles available for the NeedleStyle property:

The styles are listed below.

[·      ]{style="FONT-FAMILY: Symbol"}Arrow

[·      ]{style="FONT-FAMILY: Symbol"}Rectangle

[·      ]{style="FONT-FAMILY: Symbol"}Trapezoid

[·      ]{style="FONT-FAMILY: Symbol"}Triangle

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

 Marker can be customized using the **MarkerStyle** property; following are the in-built styles available for the MarkerStyle property:

[·      ]{style="FONT-FAMILY: Symbol"}Diamond

[·      ]{style="FONT-FAMILY: Symbol"}Ellipse

[·      ]{style="FONT-FAMILY: Symbol"}Pentagon

[·      ]{style="FONT-FAMILY: Symbol"}Rectangle

[·      ]{style="FONT-FAMILY: Symbol"}Trapezoid

[·      ]{style="FONT-FAMILY: Symbol"}Triangle

 

Location of the Marker can be controlled using the **PointerPlacement** property. Length and Width of the pointer can be controlled using its **PointerLength** and  **PointerWidth** property.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Properties:

Some of the major attributes using which pointers can be customized using some of the major properties are listed below.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

::: {align="center"}
+-------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| Property          | Description                                | Type of Property                                       | Value It Accepts                                                                                                                                               | Any other dependencies/Sub properties associated        |
+-------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| PointerLength     | Sets the Length of the Pointer.            | [double]{style="COLOR: blue"}                          | [double]{style="COLOR: blue"}                                                                                                                                  | NA                                                      |
+-------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| PointerWidth      | Sets the Width of the Pointer.             | [double]{style="COLOR: blue"}                          | [double]{style="COLOR: blue"}                                                                                                                                  | NA                                                      |
+-------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| BackgroundBrush   | Sets the background brush for the pointer. | System.Windows.Media.[Brushes]{style="COLOR: #2b91af"} | Refer to the below Link for  Value for the Brushes class                                                                                                       | NA                                                      |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        | [[Brushes]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}](http://msdn.microsoft.com/en-us/library/system.windows.media.brushes.aspx) |                                                         |
+-------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| BorderBrush       | Sets the border brush for the pointer.     | System.Windows.Media.[Brushes]{style="COLOR: #2b91af"} | Refer to the below Link for  Value for the Brushes class                                                                                                       | NA                                                      |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        | [[Brushes]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}](http://msdn.microsoft.com/en-us/library/system.windows.media.brushes.aspx) |                                                         |
+-------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| BorderWidth       | Sets the border width of the pointer.      | [double]{style="COLOR: blue"}                          | [double]{style="COLOR: blue"}                                                                                                                                  | NA                                                      |
+-------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| PointerNeedleType | Sets the pointer needle type.              | [enum]{style="COLOR: blue"}                            | [PointerNeedleType]{style="COLOR: #2b91af"}.Needle                                                                                                             | NA                                                      |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        | [PointerNeedleType]{style="COLOR: #2b91af"}.Marker                                                                                                             |                                                         |
+-------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| NeedleStyle       | Sets the pointer style.                    | [enum]{style="COLOR: blue"}                            | [NeedleStyle]{style="COLOR: #2b91af"}.Arrow                                                                                                                    | Dependency                                              |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                | (Sets only when the PointerNeedleType is set to Needle) |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        | [NeedleStyle]{style="COLOR: #2b91af"}.Rectangle                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        | [NeedleStyle]{style="COLOR: #2b91af"}.Trapezoid                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        | [NeedleStyle]{style="COLOR: #2b91af"}.Triangle                                                                                                                 |                                                         |
+-------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| PointerPlacement  | Sets the position of the Marker.           | [enum]{style="COLOR: blue"}                            | [ScalePlacement]{style="COLOR: #2b91af"}.Cross                                                                                                                 | Dependency                                              |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                | (Sets only when the PointerNeedleType is set to Marker) |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        | [ScalePlacement]{style="COLOR: #2b91af"}.Inside                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        | [ScalePlacement]{style="COLOR: #2b91af"}.Outside                                                                                                               |                                                         |
+-------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
| MarkerStyle       | Sets the Marker style.                     | [enum]{style="COLOR: blue"}                            | [MarkerStyle]{style="COLOR: #2b91af"}.Diamond                                                                                                                  | Dependency                                              |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                | (Sets only when the PointerNeedleType is set to Marker) |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        | [MarkerStyle]{style="COLOR: #2b91af"}.Ellipse                                                                                                                  |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        | [MarkerStyle]{style="COLOR: #2b91af"}.Pentagon                                                                                                                 |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        | [MarkerStyle]{style="COLOR: #2b91af"}.Rectangle                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        | [MarkerStyle]{style="COLOR: #2b91af"}.Trapezoid                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        |                                                                                                                                                                |                                                         |
|                   |                                            |                                                        | [MarkerStyle]{style="COLOR: #2b91af"}.Triangle                                                                                                                 |                                                         |
+-------------------+--------------------------------------------+--------------------------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Through View Customization](ms-xhelp:///?Id=a3885845-efab-45bb-ad3d-cdcba5cb87d0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Through CircularGaugeModel](ms-xhelp:///?Id=f95352f3-b46b-4844-9d3b-e8ae38fe4f69){style="TEXT-DECORATION: none"}
::::

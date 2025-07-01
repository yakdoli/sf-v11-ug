::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### 3D Annotation {#d-annotation style="tab-stops: 0pt"}

 

3D Annotations are the means by which 3D artwork is represented in a PDF document. Essential PDF can embed the 3D files (u3d) in PDF files. It provides a way to interact with the user by using the mouse and keyboard.

 

You can control the annotation with the help of the following classes.

 

[·      ]{style="FONT-FAMILY: Symbol"}Pdf3DAnnotation

[·      ]{style="FONT-FAMILY: Symbol"}Pdf3DView

[·      ]{style="FONT-FAMILY: Symbol"}Pdf3DProjection

[·      ]{style="FONT-FAMILY: Symbol"}Pdf3DActivation

[·      ]{style="FONT-FAMILY: Symbol"}Pdf3DBackground

[·      ]{style="FONT-FAMILY: Symbol"}Pdf3DRenderMode

[·      ]{style="FONT-FAMILY: Symbol"}Pdf3DLighting

[·      ]{style="FONT-FAMILY: Symbol"}Pdf3DCrossSection

 

**Pdf3DAnnotation**

 

Pdf3DAnnotation specifies parameters to be applied to the virtual camera associated with a 3D annotation. These parameters include orientation and position of the camera, details regarding the projection of camera coordinates onto the target coordinate system of the annotation, and a description of the background on which the artwork is to be drawn.

 

The following code example illustrates how to embed a 3D file.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                           |
| [// Pdf 3D Annotation]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                           |
| [Pdf3DAnnotation]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ annotation = [new]{style="COLOR: blue"}  [Pdf3DAnnotation]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} [RectangleF]{style="COLOR: #2b91af"}(10, 270, 270, 150), [@\"..\\..\\Data\\box.u3d\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                    |
| [\' Pdf 3D Annotation]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ annotation [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DAnnotation = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DAnnotation([New]{style="COLOR: blue"} RectangleF(10, 270, 270, 150), [\"..\\..\\Data\\box.u3d\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**Pdf3DView**

 

Pdf3DView class specifies parameters to be applied to the virtual camera associated with a 3D annotation. These parameters include orientation and position of the camera, details regarding the projection of camera coordinates onto the target coordinate system of the annotation, and a description of the background on which the artwork is to be drawn.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                               |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                         |
|                                                                                                                                                                                |
| [// Pdf 3D View]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                             |
|                                                                                                                                                                                |
| [Pdf3DView]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ view = [new]{style="COLOR: blue"} [Pdf3DView]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                |
| [view.ExternalName = [\"Default View\"]{style="COLOR: #a31515"};            ]{style="FONT-FAMILY: 'Courier New'"}                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                 |
|                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                      |
| [\' Pdf 3D View]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ view [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DView = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DView()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                      |
| [view.ExternalName = [\"Default View\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**Pdf3DProjection**

 

Pdf3DProjection defines the mapping of 3D camera coordinates onto the target coordinate system of the annotation. Using this class, you can specify the type of Projection which determines how objects are projected onto the near plane and scaled. The possible values are **Orthographic** projection and **Perspective** projection.

 

Pdf3DProjection supports both near and far clipping. This type of clipping defines a near plane and far plane. Objects or parts of objects that are beyond the far plane or closer to the camera than the near plane, are not drawn.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                 |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                  |
| [Pdf3DView]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ view = [new]{style="COLOR: blue"} [Pdf3DView]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                  |
| [Pdf3DProjection]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ projection = [new]{style="COLOR: blue"} [Pdf3DProjection]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                  |
| [projection.ProjectionType = [Pdf3DProjectionType]{style="COLOR: #2b91af"}.Perspective;]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                  |
| [projection.FieldOfView = 10;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                  |
| [projection.ClipStyle = [Pdf3DProjectionClipStyle]{style="COLOR: #2b91af"}.ExplicitNearFar;]{style="FONT-FAMILY: 'Courier New'"}                                                                 |
|                                                                                                                                                                                                  |
| [projection.NearClipDistance = 10;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                  |
| [view.Projection = projection;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ view [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DView = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DView()]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ projection [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DProjection = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DProjection()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                        |
| [projection.ProjectionType = Pdf3DProjectionType.Perspective]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                                                        |
| [projection.FieldOfView = 10]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                        |
| [projection.ClipStyle = Pdf3DProjectionClipStyle.ExplicitNearFar]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                        |
| [projection.NearClipDistance = 10]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                        |
| [view.Projection = projection]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: You can set the near or far distance by using the NearClipDistance property. If you want to set the clipping distance explicitly, you have to set the ClipStyle property to ExplicitNearFar.
:::

 

Pdf3DActivation

 

Pdf3DActivation class determines when a 3D annotation is active or when it is inactive. 3D artwork is activated in one of the following three states with the help of Pdf3DActivationMode class.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**ExplicitActivation**-Initial state of the annotation is deactivated. If you want to activate the annotation by clicking it, then you can use the explicit annotation.

[·      ]{style="FONT-FAMILY: Symbol"}**PageOpen**-Annotation is activated while opening the pdf document page

[·      ]{style="FONT-FAMILY: Symbol"}**PageVisible**-Annotation is activated when the page is visible

 

You can show or hide the toolbar by using the **ShowToolbar** property.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                 |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                  |
| [// Creating instance for Pdf3DActivation class]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                               |
|                                                                                                                                                                                                  |
| [Pdf3DActivation]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ activation = [new]{style="COLOR: blue"} [Pdf3DActivation]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                             |
|                                                                                                                                                                                                  |
| [// Setting Activation Mode as PageVisible]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                    |
|                                                                                                                                                                                                  |
| [activation.ActivationMode = [Pdf3DActivationMode]{style="COLOR: #2b91af"}.PageVisible;]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                             |
|                                                                                                                                                                                                  |
| [// Showing the Toolbar]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                       |
|                                                                                                                                                                                                  |
| [activation.ShowToolbar = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                             |
|                                                                                                                                                                                                  |
| [// Setting Deactivation Mode as PageVisible]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                  |
|                                                                                                                                                                                                  |
| [activation.DeactivationMode = [Pdf3DDeactivationMode]{style="COLOR: #2b91af"}.ExplicitDeactivation;]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                  |
| [// Assigning the Activation to the Pdf3DAnnotation]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                           |
|                                                                                                                                                                                                  |
| [annotation.Activation = activation;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| [\' Creating instance for Pdf3DActivation class]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                     |
|                                                                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ activation [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DActivation = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DActivation()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| [\' Setting Activation Mode as PageVisible]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                          |
|                                                                                                                                                                                                                                                        |
| [activation.ActivationMode = Pdf3DActivationMode.PageVisible]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| [\' Showing the Toolbar]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                        |
| [activation.ShowToolbar = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| [\' Setting Deactivation Mode as PageVisible]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                        |
|                                                                                                                                                                                                                                                        |
| [activation.DeactivationMode = Pdf3DDeactivationMode.ExplicitDeactivation]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                        |
| [\' Assigning the Activation to the Pdf3DAnnotation]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                 |
|                                                                                                                                                                                                                                                        |
| [annotation.Activation = activation]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: You can also set the deactivation mode by using the Pdf3DDeactivationMode class.
:::

 

**Pdf3DBackground**

 

Pdf3DBackground defines the background over which the 3D artwork is to be drawn. You can apply background color to the entire annotation by enabling the **ApplyToEntireAnnotation** property. If set to ***False***, the background should apply only to the rectangle that is specified by the 3D view box of the annotation. Default value is ***False***.

 

The following code example illustrates this.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                    |
|                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                     |
| [PdfColor]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ color = [new]{style="COLOR: blue"} [PdfColor]{style="COLOR: #2b91af"}([Color]{style="COLOR: #2b91af"}.Silver);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                                              |
|                                                                                                                                                                                                                     |
| [Pdf3DBackground]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ background = [new]{style="COLOR: blue"} [Pdf3DBackground]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                     |
| [background.Color = color;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                     |
| [background.ApplyToEntireAnnotation = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                     |
| [// Setting Background color to current view.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                    |
|                                                                                                                                                                                                                     |
| [view.Background = background;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ color [As]{style="COLOR: blue"} Syncfusion.Pdf.Graphics.PdfColor = [New]{style="COLOR: blue"} Syncfusion.Pdf.Graphics.PdfColor(color.Silver)]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ background [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DBackground = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DBackground()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                        |
| [background.Color = color]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                        |
| [background.ApplyToEntireAnnotation = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                        |
| [\' Setting Background color to current view.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                       |
|                                                                                                                                                                                                                                                        |
| [view.Background = background]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

Pdf3DRenderMode

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

You can specify the rendering style for the 3D artwork by using the Pdf3DRenderMode class. For example, surfaces may be filled with opaque colors, they may be stroked as a \"wireframe\", or the artwork may be rendered with special lighting effects.

 

The following are the rendering styles supported by the Pdf3DRenderMode class.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Solid

[·      ]{style="FONT-FAMILY: Symbol"}SolidWireframe

[·      ]{style="FONT-FAMILY: Symbol"}Transparent

[·      ]{style="FONT-FAMILY: Symbol"}TransparentWireframe

[·      ]{style="FONT-FAMILY: Symbol"}BoundingBox

[·      ]{style="FONT-FAMILY: Symbol"}TansparentBoundingBox

[·      ]{style="FONT-FAMILY: Symbol"}TransparentBoundingBoxOutline

[·      ]{style="FONT-FAMILY: Symbol"}Wireframe

[·      ]{style="FONT-FAMILY: Symbol"}ShadedWireframe

[·      ]{style="FONT-FAMILY: Symbol"}HiddenWireframe

[·      ]{style="FONT-FAMILY: Symbol"}Vertices

[·      ]{style="FONT-FAMILY: Symbol"}ShadedVertices

[·      ]{style="FONT-FAMILY: Symbol"}Illustration

[·      ]{style="FONT-FAMILY: Symbol"}SolidOutline

[·      ]{style="FONT-FAMILY: Symbol"}ShadedIllustration

 

Apart from using the Style property, you can also change the rendering style by using the following properties.

 

[·      ]{style="FONT-FAMILY: Symbol"}**AuxilaryColor**: PdfColor name that specifies the auxiliary color to be used when rendering the 3D image. The first entry in the array is a color space; the subsequent entries are values specifying color values in that color space.

[·      ]{style="FONT-FAMILY: Symbol"}**FaceColor**: PdfColor name that specifies the face color to be used when rendering the 3D image. This entry is relevant only when the Style property is set to Illustration.

[·      ]{style="FONT-FAMILY: Symbol"}**Opacity**: Number specifying the opacity of the added transparency applied by some render modes using a standard additive blend. Default value is ***0.5***.

[·      ]{style="FONT-FAMILY: Symbol"}**CreaseValue**: Number specifying the angle in degrees to be used as the crease value while determining silhouette edges. Default value is ***45***.

 

The following code example illustrates this.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                 |
|                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                           |
|                                                                                                                                                                                                  |
| [Pdf3DRendermode]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ rendermode = [new]{style="COLOR: blue"} [Pdf3DRendermode]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                  |
| [rendermode.Style = [Pdf3DRenderStyle]{style="COLOR: #2b91af"}.Solid;]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                  |
| [view.RenderMode = renderMode;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rendermode [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DRendermode = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DRendermode()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                        |
| [rendermode.Style = Pdf3DRenderStyle.Solid]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                                        |
| [view.RenderMode = renderMode]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Pdf3DLighting

 

Pdf3DLighting class specifies the lighting to be applied to the 3D artwork. The following lighting effects are supported by the Pdf3DLighting class.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Artwork

[·      ]{style="FONT-FAMILY: Symbol"}None

[·      ]{style="FONT-FAMILY: Symbol"}White

[·      ]{style="FONT-FAMILY: Symbol"}Day

[·      ]{style="FONT-FAMILY: Symbol"}Night

[·      ]{style="FONT-FAMILY: Symbol"}Hard

[·      ]{style="FONT-FAMILY: Symbol"}Primary

[·      ]{style="FONT-FAMILY: Symbol"}Blue

[·      ]{style="FONT-FAMILY: Symbol"}Red

[·      ]{style="FONT-FAMILY: Symbol"}Cube

[·      ]{style="FONT-FAMILY: Symbol"}CAD

[·      ]{style="FONT-FAMILY: Symbol"}Headlamp

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}**                                                                                                                                                           |
|                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}                                                                                                                                                     |
|                                                                                                                                                                                                                            |
| [Pdf3DLighting]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af; FONT-SIZE: 9pt"}[ lighting = [new]{style="COLOR: blue"} [Pdf3DLighting]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                            |
| [lighting.Style = [Pdf3DLightingStyle]{style="COLOR: #2b91af"}.CAD;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                   |
|                                                                                                                                                                                                                            |
| [view.LightingScheme = lightingScheme;]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ lighting [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DLighting = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DLighting()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                  |
| [lighting.Style = Pdf3DLightingStyle.CAD]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                                                                  |
| [view.LightingScheme = lightingScheme]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Pdf3DCrossSection

 

Pdf3DCrossSection specifies how a portion of the 3D artwork is clipped for the purpose of showing artwork cross sections. The following code example illustrates this.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                   |
|                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}                                                                                                                                             |
|                                                                                                                                                                                                    |
| [Pdf3DCrossSection]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ csection = [new]{style="COLOR: blue"} [Pdf3DCrossSection]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                    |
| [csection.IntersectionColor = color;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                    |
| [csection.IntersectionIsVisible = 50;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                    |
| [view.CrossSections = csection;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ csection [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DCrossSection = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.Pdf3DCrossSection()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                          |
| [csection.IntersectionColor = color]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                          |
| [csection.IntersectionIsVisible = 50]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                                          |
| [view.CrossSections = csection]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#related-topics}
:::::

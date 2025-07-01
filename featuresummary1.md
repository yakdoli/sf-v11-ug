::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=743bc749-6de7-45e6-a48c-e31a6d830437){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=f9aa55fb-f8cf-43da-a8be-de231dc0d949){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET](ms-xhelp:///?Id=25c35330-c127-4dad-9a92-ed79dc7261a6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=3d72ef03-8b3b-4fa5-bca1-3f5b0ace1f3b){.d2h_breadcrumbsNormal}
:::

## Feature Summary[]{style="FONT-SIZE: 10pt"} {#feature-summary style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The important features of Essential Diagram are listed below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Retained-mode interface for 2D interactive graphics.

[·      ]{style="FONT-FAMILY: Symbol"}Hierarchical node structure supporting nesting.

[·      ]{style="FONT-FAMILY: Symbol"}Clearly separates data, presentation and user interaction into separate models, views and controller components.

[·      ]{style="FONT-FAMILY: Symbol"}Supports extending model, view and controller components.

[·      ]{style="FONT-FAMILY: Symbol"}Provides mix and match model, view and controller components for custom functionality.

[·      ]{style="FONT-FAMILY: Symbol"}Supports Matrix Transformations: Translate (Move), Rotate and Scale.

[·      ]{style="FONT-FAMILY: Symbol"}Shape nodes are the graphical objects that can be drawn onto the diagram area by activating one of several drawing tools such as the RectangleTool, RoundRectTool, EllipseTool, LineTool, PolylineTool, OrthogonallineTool, BezierTool, CurveTool, ArcTool and PolygonTool.

[·      ]{style="FONT-FAMILY: Symbol"}DecoratorShape can be added at the head and tail of Connectors. The shapes include arrows, circles, diamonds, crosses, squares and custom decorators.

[·      ]{style="FONT-FAMILY: Symbol"}**Diagram Export**: Essential Diagram offers capabilities to export the diagram representation into various formats. The formats include Bitmaps with support for multiple formats, enhanced metafiles and SVG files.

[·      ]{style="FONT-FAMILY: Symbol"}**Text Nodes**: Essential Diagram supports rendering Textnodes and RichTextnodes, and offers full text formatting through sufficient properties.

[·      ]{style="FONT-FAMILY: Symbol"}Text editing and text rotation are also supported.

[·      ]{style="FONT-FAMILY: Symbol"}Group[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black; FONT-SIZE: 8pt"}nodes[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black; FONT-SIZE: 8pt"}are the Containers for child nodes and are extended with text labels.

[·      ]{style="FONT-FAMILY: Symbol"}Link nodes are directional symbols with two connection ports.

[·      ]{style="FONT-FAMILY: Symbol"}Command Architecture provides Undo / Redo operations with Macro commands.

[·      ]{style="FONT-FAMILY: Symbol"}Grouping / UnGrouping of nodes can be supported by sufficient APIs.

[·      ]{style="FONT-FAMILY: Symbol"}Layer is a collection of nodes that share a common set of default properties and the same Z-order relative to other layers.

[·      ]{style="FONT-FAMILY: Symbol"}Hit testing is supported.

[·      ]{style="FONT-FAMILY: Symbol"}**Coordinate Conversion**: a view is set inside a window and has bounds that are measured in device coordinates

[·      ]{style="FONT-FAMILY: Symbol"}Essential Diagram renders the node in coordinates that are apt to the Model coordinates through Matrix conversions. Several methods are available to achieve the required coordinate conversions.

[·      ]{style="FONT-FAMILY: Symbol"}Zooming, scrolling, and panning are supported and can be achieved using sufficient interactive diagram tools.

[·      ]{style="FONT-FAMILY: Symbol"}**Grid**: the drawing area of the Diagram control can be rendered with Grid lines or points and the nodes drawn could also be snapped to Grid.

[·      ]{style="FONT-FAMILY: Symbol"}**Units**: Real-world logical units (e.g. Metric units, English units).

[·      ]{style="FONT-FAMILY: Symbol"}**Automatic Line Routing and Line Bridging**: while a link is drawn between two nodes by enabling the LineRoutingEnabled property of that link and the diagram view, if any other node is found in between them, the line will be automatically re-routed around those nodes

[·      ]{style="FONT-FAMILY: Symbol"}Enabling the LineBridging property, will make the links jump over as per their Z-order priority.

[·      ]{style="FONT-FAMILY: Symbol"}**Editing Line Segments**: the line segments between the lines can be edited interactively.

[·      ]{style="FONT-FAMILY: Symbol"}**Print and Print Preview**: the PrintDialog class enables the user to set the printer to be used, and allows to define the pages and the number of copies that should be printed, while the PrintPreviewDialog class provides an overview of the document, i.e., of the appearance as to how the document will appear when printed which is shown or invoked by using the ShowDialog method.

[·      ]{style="FONT-FAMILY: Symbol"}**Headers and Footers**: Essential Diagram features support for the addition of culture specific headers and footers for a diagram.

[·      ]{style="FONT-FAMILY: Symbol"}PaletteGroupBar[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black; FONT-SIZE: 8pt"}control is a WinForm control that can be added to the Visual Studio .NET toolbox, displays list symbols in a symbol palette as icons, allows user to drag symbols onto diagrams, supports multiple symbol palettes at a time, has a user interface similar to Microsoft Outlook bar, and it is implemented based on the Syncfusion GroupBar and GroupView controls.

[·      ]{style="FONT-FAMILY: Symbol"}PropertyEditor[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black; FONT-SIZE: 8pt"}control is a WinForm control that can be added to the Visual Studio .NET toolbox, allows users to view and edit the properties of one or more nodes in a diagram, and it is implemented based on the Microsoft .NET PropertyGrid control.

[·      ]{style="FONT-FAMILY: Symbol"}Symbol Designer is a utility for creating palettes of symbols and highly advanced symbols.

[·      ]{style="FONT-FAMILY: Symbol"}The control is known for its best features of being highly customizable and extensible. Customization has been made easier, and custom UI tools can be easily created and registered.

[·      ]{style="FONT-FAMILY: Symbol"}Visio-Like symbol creation is supported by importing Visio stencil files (\*.vss files).

[·      ]{style="FONT-FAMILY: Symbol"}Layout Managers define the base class for creating custom layout managers that enable the positioning of diagram nodes and abstracting the layout algorithm from the rest of the diagram data.

[·      ]{style="FONT-FAMILY: Symbol"}Built-in serialization support for loading and saving diagrams.

[·      ]{style="FONT-FAMILY: Symbol"}Diagram interactivity through Client-Side Image Maps, JavaScript and Server-Side events.

[·      ]{style="FONT-FAMILY: Symbol"}Session State Management used to maintain the values that need to be persisted for the duration of a user\'s session.

[·      ]{style="FONT-FAMILY: Symbol"}View State Management persists the state across the postback calls.

[·      ]{style="FONT-FAMILY: Symbol"}Essential Diagram for ASP.NET integrates AJAX technology to a deeper level, and allows for optimized transfers between the client and server to provide a smooth interaction experience when loading a large set of nodes into the Diagram.

[·      ]{style="FONT-FAMILY: Symbol"}Client-Side Node Interaction: you can get the diagram node information easily through client-side scripting.

[·      ]{style="FONT-FAMILY: Symbol"}Also, there is improved selection behavior of irregular shapes by optimizing the hit-test algorithm on the client-side. Selected Nodes list can also be accessed through the client-side script.

[]{#related-topics}
::::

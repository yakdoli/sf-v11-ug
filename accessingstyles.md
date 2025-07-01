::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Accessing Styles {#accessing-styles style="tab-stops: 0pt"}

 

You can access the collection of styles defined in the document by using the **Styles** property. This collection holds both the built-in and user-defined styles in a document. A particular style can be obtained by its name or index.

 

The following example illustrates how to access the collection of styles defined in the document.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                               |
|                                                                                                                                                                                                              |
| []{style="COLOR: black"}                                                                                                                                                                                     |
|                                                                                                                                                                                                              |
| [// Get a collection of styles defined in the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                   |
|                                                                                                                                                                                                              |
| [IStyleCollection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ coll = document.Styles;]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                              |
| [// Access particular style.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                              |
|                                                                                                                                                                                                              |
| [IStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ style= coll.FindByName([string]{style="COLOR: blue"} Stylename ) ;]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                              |
| [IStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ style= coll.FindByName([string]{style="COLOR: blue"} Stylename,[StyleType]{style="COLOR: teal"} styleType) ;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                              |
| [IStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ style1=coll\[0\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                |
|                                                                                                                                                                                                                   |
| []{style="COLOR: black"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                   |
| [\' Get a collection of styles defined in the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                        |
|                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ coll [As]{style="COLOR: blue"} IStyleCollection = document.Styles]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [\' Access particular style.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                   |
|                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ style [As]{style="COLOR: blue"} IStyle= coll.FindByName([String]{style="COLOR: blue"} Stylename)]{style="FONT-FAMILY: 'Courier New'"}                     |
|                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ style [As]{style="COLOR: blue"} IStyle= coll.FindByName([String]{style="COLOR: blue"} Stylename,StyleType styleType)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ style1 [As]{style="COLOR: blue"} IStyle = coll(0)]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::

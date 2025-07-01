::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Adding StyleManager {#adding-stylemanager style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Arial','sans-serif'"} 

**StyleManager** is a new CSS resource manager that helps in registering CSS files, which enable Minification, Compression and Combination of CSS resources for ASP.NET MVC web applications. The files in StyleManager resources are set to be combined, minified, and compressed (either gzip or deflate, depending on your browser) before sending to browser. All are done using a single HTTP request per resource set.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[ ]{style="FONT-FAMILY: 'Times New Roman','serif'"}Add the StyleManager extension method in the HEAD tag of the View pages (in most cases, it is reasonable to call it within the Site.Master page). Use the **Register** method to register the Grid component.[]{style="FONT-FAMILY: 'Times New Roman','serif'"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[ASPX\]]{style="FONT-FAMILY: 'Arial','sans-serif'"}**[]{style="FONT-FAMILY: 'Arial','sans-serif'"}                                                            |
|                                                                                                                                                                       |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().StyleManager()\                   |
|         .Register(styleSheet =\> \                                                                                                                                    |
|             {\                                                                                                                                                        |
|                 styleSheet.Add([ComponentType]{style="COLOR: #2b91af"}.Chart);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Times New Roman','serif'"} |
|                                                                                                                                                                       |
| [            })  [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"}           |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::

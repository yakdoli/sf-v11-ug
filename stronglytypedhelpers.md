::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Strongly Typed helpers {#strongly-typed-helpers style="tab-stops: 0pt"}

MaskEdit textbox supports strongly typed HTML helpers, which uses lambda expressions in reference models or view models passed to a view template.The helper allows you to define the name and value of the MaskEdit text box from the model.

The following steps explain the use of the strongly typed helpers to create MaskEdit textbox:[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

1.   In the **Controller**, pass the model to the View.[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                            |
|                                                                                                                                                                                     |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                     |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                     |
| [            ]{style="FONT-FAMILY: 'Courier New'"} [Northwind]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"} [ data = SqlCE;            ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                     |
| [            [return]{style="COLOR: blue"} View(data.Employees);]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                     |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                     |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                             |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**  

2.   Create a strongly typed view. (Please refer to the Creating a Strongly Typed View section for more details.)

3.   In View, invoke the strongly typed MaskEdit textbox helper with the lambda expression to set the default value.

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                   |
| [  ]{style="FONT-FAMILY: 'Courier New'"} [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} [Html.MobSyncfusion().MaskEditTextBoxFor(model=\>model.HomePhone)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                   |
| **[.Mask([\"(999)999-9999\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}** [ [%\>]{style="BACKGROUND: yellow"} ]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                                                                   |
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                   |
| [    ]{style="FONT-FAMILY: 'Courier New'"} [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [ Html.MobSyncfusion().MaskEditTextBoxFor(model=\>model.HomePhone)]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                                                                                                   |
| **[.Mask([\"(999)999-9999\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}** [         [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}               |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

4.   Build and run the application.

[]{#related-topics}
:::

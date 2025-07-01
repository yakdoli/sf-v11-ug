::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Strongly typed HTML Helpers {#strongly-typed-html-helpers style="tab-stops: 0pt"}

Mask Edit textbox supports strongly typed HTML helpers, which use lambda expressions to reference models or view models passed to a view template.The helper allows you to define the name and value of the mask edit text box from the Model.

The following steps explain the use of the strongly typed helpers to create mask edit textbox.

1.   In the Controller, pass model to the **View**.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

+------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[Controller\]**                                                                                                                             |
|                                                                                                                                                |
|                                                                                                                                                |
|                                                                                                                                                |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                |
| [            [Northwind]{style="COLOR: #2b91af"} data = SqlCE;]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                |
| [            [//pass the model to the view]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                |
| [            [return]{style="COLOR: blue"} View(data.Employees);]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                |
| [  }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                        |
+------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   Create a strongly typed view. Refer [strongly typed view]{.UGHyperlink} for more details. In the Controller, pass model to the View.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[Controller\]**                                                                                                                             |
|                                                                                                                                                |
|                                                                                                                                                |
|                                                                                                                                                |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                |
| [            [Northwind]{style="COLOR: #2b91af"} data = SqlCE;]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                |
| [            [//pass the model to the view]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                         |
|                                                                                                                                                |
| [            [return]{style="COLOR: blue"} View(data.Employees);]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                |
| [  }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                        |
+------------------------------------------------------------------------------------------------------------------------------------------------+

 

3.   Create a strongly typed view. Refer to [strongly typed view]{.UGHyperlink} for more details. In **View**, invoke the **mask edit** textbox with lambda expression to set the default value.

4. 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[ASPX\]**                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                             |
| [\<%]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[=]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[Html.Syncfusion().MaskEditTextBoxFor(model=\>model.HomePhone)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                             |
| **[.Mask([\"(999)999-9999\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[ [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                              |
|                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                                                     |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[cshtml\]**                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
| [\@{]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[ Html.Syncfusion().MaskEditTextBoxFor(model=\>model.HomePhone)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                               |
|                                                                                                                                                                                                                                                           |
| **[.Mask([\"(999)999-9999\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[.Render();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[ [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                                                   |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

5.   Build and run the application.

You can observe [that the mask edit textbox is created with the ID 'HomePhone' and value of the HomePhone. The output is shown in the]{.BodyText1Char} following screenshot.

 

![Description: C:\\Work Place\\Work Trunk\\features\\SF4718\\MaskEditTextbox\\Concepts_features\\strongly_typed_helpers.png](ImagesExt/image56_159.png){border="0"}

Figure 146: Mask edit textbox

***[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}*** 

[]{#related-topics}
:::

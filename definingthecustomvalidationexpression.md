::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Defining the Custom Validation Expression {#defining-the-custom-validation-expression style="tab-stops: 0pt"}

Client side validator supports custom validation expression. The expression can be normal regex expressions.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}** 

Properties

  ---------------------------- --------------------------------------------------------------------------- -------------------------------------------------------------------------------------------------- ----------------------- ------------
  Name                         Description                                                                 Type of property                                                                                   Value it accepts        Dependency
  CustomValidationExpression   Used to define the validation expression i.e. the reference of validation   [[string]{style="COLOR: windowtext; TEXT-DECORATION: none; text-underline: none"}]{.UGHyperlink}   Any regex expressions   NA
  ---------------------------- --------------------------------------------------------------------------- -------------------------------------------------------------------------------------------------- ----------------------- ------------

*[[]{style="TEXT-DECORATION: none"}]{.underline}* 

Using Builder

The following steps explain the definition of the custom validation expression for the client side valditor using Builder.

1.   In **View**, create an input field (which is to be validated) and invoke the validator helper with the ID of the input field as the first argument followed by the **ValidationExpression** method with desired expression as argument.

 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                   |
|                                                                                                                                                                                                          |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                               |
|                                                                                                                                                                                                          |
| [Single Digit No.:[\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.TextBox([\"numeric\"]{style="COLOR: #a31515"})[%\>]{style="BACKGROUND: yellow"}    ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                          |
| [                        [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().Validator([\"numeric\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                                          |
| [    **.CustomValidationExpression([\"\^\[0-9\]\$\"]{style="COLOR: #a31515"})**[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                  |
|                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                |
|                                                                                                                                                                                           |
| [Single Digit No.:[@]{style="BACKGROUND: yellow"}Html.TextBox([\"numeric\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                           |
| [                        [\@{]{style="BACKGROUND: yellow"}[ ]{style="COLOR: blue"}Html.Syncfusion().Validator([\"numeric\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                           |
| [    **.CustomValidationExpression([\"\^\[0-9\]\$\"]{style="COLOR: #a31515"}).**Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

2.   Build and run the application.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}** 

Using Properties Model

The following steps explain defining the custom validation expression for the client side valditor using properties model.

1.   In the Controller, create an instance of **ValidatorModel**, define the **ValidationExpression** property and pass the instance through **view specific data** to **View** as given below.

 

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                    |
|                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                  |
|                                                                                                                                                                             |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                             |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                             |
| [            [//create an instance of ValidatorModel]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                             |
| [            [ValidatorModel]{style="COLOR: #2b91af"} myModel = [new]{style="COLOR: blue"} [ValidatorModel]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                             |
| [            **myModel**.**CustomValidationExpression** = **[\"\^\[0-9\]\$\"]{style="COLOR: #a31515"}**;]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                             |
| [            [//pass the instance through view data to the view]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                             |
| [            ViewData\[[\"validatorModel\"]{style="COLOR: #a31515"}\] = myModel;]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                             |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                             |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                  |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   In **View**, create an input field (which is to be validated) and invoke the validator helper with the id of the input field as the first argument and the view data key as the second argument.

 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                              |
| [Single Digit No:  [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.TextBox(\"[numeric]{style="COLOR: #a31515"}\")[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                                                                                                                              |
| [                            [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().Validator(\"[numeric]{style="COLOR: #a31515"} \",\"[validatorModel]{style="COLOR: #a31515"}\")[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                   |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                      |
| [Single Digit No:  [@]{style="BACKGROUND: yellow"}Html.TextBox(\"[numeric]{style="COLOR: #a31515"}\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                                                                                                      |
| [                            [\@{]{style="BACKGROUND: yellow"}[ ]{style="COLOR: blue"}Html.Syncfusion().Validator(\"[numeric]{style="COLOR: #a31515"} \",\"[validatorModel]{style="COLOR: #a31515"}\").Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                           |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

3.   Build and run the application.

 

Now the validator validates the textbox for a single digit number on focus out.

[]{#related-topics}
:::

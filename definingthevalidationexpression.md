::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Defining the Validation Expression {#defining-the-validation-expression style="tab-stops: 0pt"}

Client-side Validator has a few in-built validation expressions. The in-built validation expressions are as follows:

[·      ]{style="FONT-FAMILY: Symbol"}Date

[·      ]{style="FONT-FAMILY: Symbol"}Email

[·      ]{style="FONT-FAMILY: Symbol"}IPAddress

[·      ]{style="FONT-FAMILY: Symbol"}Number

[·      ]{style="FONT-FAMILY: Symbol"}Postal Code

[·      ]{style="FONT-FAMILY: Symbol"}Time

[·      ]{style="FONT-FAMILY: Symbol"}URL

[·      ]{style="FONT-FAMILY: Symbol"}USDate

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}** 

Properties

+----------------------+---------------------------------------------------------------------------------------------------+----------------------+--------------------------------------------------------------------------------------------+-------------+
| Name                 | Description                                                                                       | Type of the property | Value it accepts                                                                           | Dependency  |
+----------------------+---------------------------------------------------------------------------------------------------+----------------------+--------------------------------------------------------------------------------------------+-------------+
| ValidationExpression | Used to set one of the eight pre -defined validation expressions i.e. the reference of validation | enum                 | [ValidatorModel]{style="COLOR: #2b91af"}.[Expressions]{style="COLOR: #2b91af"} .Date,      | NA          |
|                      |                                                                                                   |                      |                                                                                            |             |
|                      |                                                                                                   |                      | [ValidatorModel]{style="COLOR: #2b91af"}.[Expressions]{style="COLOR: #2b91af"}.Email,      |             |
|                      |                                                                                                   |                      |                                                                                            |             |
|                      |                                                                                                   |                      | [ValidatorModel]{style="COLOR: #2b91af"}.[Expressions]{style="COLOR: #2b91af"}.IPAddress,  |             |
|                      |                                                                                                   |                      |                                                                                            |             |
|                      |                                                                                                   |                      | [ValidatorModel]{style="COLOR: #2b91af"}.[Expressions]{style="COLOR: #2b91af"}.Number,     |             |
|                      |                                                                                                   |                      |                                                                                            |             |
|                      |                                                                                                   |                      | [ValidatorModel]{style="COLOR: #2b91af"}.[Expressions]{style="COLOR: #2b91af"}.PostalCode, |             |
|                      |                                                                                                   |                      |                                                                                            |             |
|                      |                                                                                                   |                      | [ValidatorModel]{style="COLOR: #2b91af"}.[Expressions]{style="COLOR: #2b91af"}.Time,       |             |
|                      |                                                                                                   |                      |                                                                                            |             |
|                      |                                                                                                   |                      | [ValidatorModel]{style="COLOR: #2b91af"}.[Expressions]{style="COLOR: #2b91af"}.URL,        |             |
|                      |                                                                                                   |                      |                                                                                            |             |
|                      |                                                                                                   |                      | [ValidatorModel]{style="COLOR: #2b91af"}.[Expressions]{style="COLOR: #2b91af"}.USDate      |             |
+----------------------+---------------------------------------------------------------------------------------------------+----------------------+--------------------------------------------------------------------------------------------+-------------+

*[[]{style="TEXT-DECORATION: none"}]{.underline}* 

Using Builder

The following steps explain the definition of the validation expression for the client side valditor using Builder.

1.   In **View**, create an input field (which is to be validated) and invoke the validator helper with the id of the input field as the first argument followed by the **ValidationExpression** method with the desired expression as argument.

 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                         |
|                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                     |
|                                                                                                                                                                                                                                |
| [EmailAddress: [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.TextBox([\"EmailAddress\"]{style="COLOR: #a31515"})[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                                |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Validator([\"EmailAddress\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                |
| **[.ValidationExpression([ValidatorModel]{style="COLOR: #2b91af"}.[Expressions]{style="COLOR: #2b91af"}.Email)]{style="FONT-FAMILY: 'Courier New'"}**[%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}             |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                  |
| [EmailAddress: [@]{style="BACKGROUND: yellow"}Html.TextBox([\"EmailAddress\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                                                                  |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ Html.Syncfusion().Validator([\"EmailAddress\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                                                                                  |
| **[.ValidationExpression([ValidatorModel]{style="COLOR: #2b91af"}.[Expressions]{style="COLOR: #2b91af"}.Email).]{style="FONT-FAMILY: 'Courier New'"}**[Render();]{style="FONT-FAMILY: 'Courier New'"}[}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} |
|                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                       |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

 

 

2.   Build and run the application.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}** 

Using Properties Model

The following steps explain the definition of the validation expression for the client side valditor using the Properties model.

 

1.   In the **Controller**, create an instance of **ValidatorModel**, define the **ValidationExpression** property and pass the instance through view specific data to view as given below.

 

 

 

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
| [            myModel.ValidationExpression = [ValidatorModel]{style="COLOR: #2b91af"}.[Expressions]{style="COLOR: #2b91af"}.Email;]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                             |
| [            [//pass the instance through view data to the view]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                             |
| [            ViewData\[[\"validatorModel\"]{style="COLOR: #a31515"}\] = myModel;]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                             |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                             |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                  |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   In **View**, create an input field (which is to be validated) and invoke the validator helper with the ID of the input field as the first argument and the view data key as the second argument.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                               |
| [EmailAddress:  [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().TextBox(\"[EmailAddress]{style="COLOR: #a31515"}\")[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                                          |
|                                                                                                                                                                                                                                                                               |
| [                         [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().Validator(\"[EmailAddress]{style="COLOR: #a31515"}\",\"[validatorModel]{style="COLOR: #a31515"}\")[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[View\[cshtml\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                       |
| [EmailAddress:  [@]{style="BACKGROUND: yellow"}Html.Syncfusion().TextBox(\"[EmailAddress]{style="COLOR: #a31515"}\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                                                                       |
| [                         [\@{]{style="BACKGROUND: yellow"}[ ]{style="COLOR: blue"}Html.Syncfusion().Validator(\"[EmailAddress]{style="COLOR: #a31515"}\",\"[validatorModel]{style="COLOR: #a31515"}\").Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} 

3.   Build and run the application.

 

 

[]{#related-topics}
:::

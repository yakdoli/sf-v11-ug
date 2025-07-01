::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Enabling Auto-Post-Back   {#enabling-auto-post-back style="tab-stops: 0pt"}

[The rating control supports auto-post-back so that server-side actions can be called when a value changes. This is useful when performing database updates and parallel actions based on rating value.]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

**[Properties]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**

  --------------- ----------------------------------------------------------------------------------------------------------- ---------------------- ---------------------- -------------------------------------
  **Name**        **Description**                                                                                             **Type of property**   **Value it accepts**   **Dependency**
  AutoPostBack    When set, this property sends a post request to the action defined by RequestMapper when a value changes.   bool                   True/False             NA
  RequestMapper   Defines the action name to which the post request is to be made.                                            string                 Action name            Mandatory when AutoPostBack is set.
  --------------- ----------------------------------------------------------------------------------------------------------- ---------------------- ---------------------- -------------------------------------

*[[[]{style="TEXT-DECORATION: none"}]{style="FONT-FAMILY: 'Calibri','sans-serif'"}]{.underline}* 

Using Builder

The following steps explain how to enable auto-post-back using Builder.

1.   In **View**, invoke the rating helper followed by the **AutoPostBack** and **RequestMapper** methods with the desired options as arguments.[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[ASPX\]**                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                |
| [\<%]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[=]{style="FONT-FAMILY: Consolas; COLOR: blue; FONT-SIZE: 9.5pt"}[Html.Syncfusion().Rating([\"myRating\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                |
| [.**AutoPostBack([true]{style="COLOR: blue"})**]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                                |
| **[.RequestMapper([\"Home/Index\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[ [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                           |
|                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **View\[csht ml\]**                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                 |
| [\@{]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}[ Html.Syncfusion().Rating([\"myRating\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                  |
|                                                                                                                                                                                                                                                                 |
| [.**AutoPostBack([true]{style="COLOR: blue"})**]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                               |
|                                                                                                                                                                                                                                                                 |
| **[.RequestMapper([\"Home/Index\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**[.Render();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}[ [}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"}                                                                                                                                                                                         |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} 

2.   In the controller, define the post action.[]{style="FONT-FAMILY: 'Courier New'"}

[]{style="FONT-FAMILY: 'Courier New'"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ** \[Controller\]**                                                                                                                                                    |
|                                                                                                                                                                        |
| [//Post Action for Rating auto post back]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                         |
|                                                                                                                                                                        |
| [\[[AcceptVerbs]{style="COLOR: #2b91af"}([HttpVerbs]{style="COLOR: #2b91af"}.Post)\]]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                        |
| [        [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Index([RatingParams]{style="COLOR: #2b91af"} param)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                        |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                        |
| [            [/\*\-\-\-\-\-\-\-\-\-\--]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                        |
| [             Your Code]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                             |
|                                                                                                                                                                        |
| [             \-\-\-\-\-\-\-\-\-\-\-\--\*/]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                          |
|                                                                                                                                                                        |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                        |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

3.   Build and run the application.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 12pt"}** 

Using Properties Model

The following steps explain how to enable auto-post-back through the properties model.

1.   In the controller, create an instance of **RatingModel**.

2.   Reset the **AutoPostBack** and **RequestMapper** properties and pass the instance through the view-specific data to the view.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ** \[Controller\]**[]{style="COLOR: blue"}                                                                                                                                                                         |
|                                                                                                                                                                                                                    |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                    |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                                    |
| [//Creating an instance of RatingModel.]{style="FONT-FAMILY: Consolas; COLOR: green; FONT-SIZE: 9.5pt"}[           \                                                                                               |
| [RatingModel]{style="COLOR: #2b91af"} myModel = [new]{style="COLOR: blue"} [RatingModel]{style="COLOR: #2b91af"}();                      ]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                                                    |
| [            **myModel.AutoPostBack = [true]{style="COLOR: blue"};**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                    |
| **[            myModel.RequestMapper = [\"Home/Index\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}**                                                                                            |
|                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                    |
| [            ]{style="FONT-FAMILY: 'Courier New'"}[//Passing the instance through the view data to the view.]{style="FONT-FAMILY: Consolas; COLOR: green; FONT-SIZE: 9.5pt"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                    |
| [ViewData\[[\"myRating\"]{style="COLOR: #a31515"}\] = myModel;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                |
|                                                                                                                                                                                                                    |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                    |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
|                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'"} 

3.   In **View**, invoke the rating helper with the view data key as the control ID.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ** View\[ASPX\]**                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Rating([\"myRating\"]{style="COLOR: #a31515"}) [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                           |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ** View\[cshtml\]**                                                                                                                                                                                           |
|                                                                                                                                                                                                               |
| [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[ Html.Syncfusion().Rating([\"myRating\"]{style="COLOR: #a31515"}).Render();[}]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
|                                                                                                                                                                                                               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

4.   In Controller, define the post action.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ** \[Controller\]**                                                                                                                                                    |
|                                                                                                                                                                        |
| [//Post action for the rating auto-post-back]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                     |
|                                                                                                                                                                        |
| [\[[AcceptVerbs]{style="COLOR: #2b91af"}([HttpVerbs]{style="COLOR: #2b91af"}.Post)\]]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                        |
| [        [public]{style="COLOR: blue"} [ActionResult]{style="COLOR: #2b91af"} Index([RatingParams]{style="COLOR: #2b91af"} param)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                        |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                        |
| [            [/\*\-\-\-\-\-\-\-\-\-\--]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                        |
| [             Your Code]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                             |
|                                                                                                                                                                        |
| [             \-\-\-\-\-\-\-\-\-\-\-\--\*/]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                          |
|                                                                                                                                                                        |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                        |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                        |
| *[[]{style="TEXT-DECORATION: none"}]{.underline}*                                                                                                                      |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

*[[]{style="TEXT-DECORATION: none"}]{.underline}* 

5.   Build and run the application.

The **RatingParams** class has two properties namely:

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentValue** -- Returns the current value of the rating.

[·      ]{style="FONT-FAMILY: Symbol"}**CustomData** -- Is user-defined additional data that can be sent upon a post request.

To learn more about CustomData, refer to the [Client-Side Methods]{.UGHyperlink} section.

[]{#related-topics}
:::

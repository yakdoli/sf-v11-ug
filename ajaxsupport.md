::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### AJAX Support {#ajax-support style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

AutoCompleteTextBox control has built in AJAX support that allows to refresh the data using Callbacks. The various client events that are invoked during the callback process are as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+----------------------------------------+-----------------------------------------------------------------------------------------+
|                                        |                                                                                         |
|                                        |                                                                                         |
| Property                               | Description                                                                             |
+----------------------------------------+-----------------------------------------------------------------------------------------+
| AfterCallbackResponseProcessedScript   | Specifies the script that will be executed after callback result gets processed.        |
+----------------------------------------+-----------------------------------------------------------------------------------------+
| AfterCallbackScript                    | Specifies the script that will be executed after callback result is sent to the server. |
+----------------------------------------+-----------------------------------------------------------------------------------------+
| AutoPostBack                           | Specifies whether to postback the page when text is modified. Default value is False.   |
+----------------------------------------+-----------------------------------------------------------------------------------------+
| BeforeCallbackResponseProcessingScript | Specifies the script that will be executed before callback result gets processed.       |
+----------------------------------------+-----------------------------------------------------------------------------------------+
| BeforeCallbackScript                   | Specifies the script that will be executed before a callback result gets processed.     |
+----------------------------------------+-----------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

To trigger the ajax client events, follow the below given steps.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   Create an application using data binding. For details, see [Creating AutoCompleteTextBox]{.UGHyperlink}.

2.   Define the script functions that should be executed and performed when the client functions are invoked.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[javascript\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                          |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                               |
|                                                                                                                                                                                                                   |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ BeforeScript()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                                                   |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                   |
| [    document.getElementById([\'display\']{style="COLOR: maroon"}).value+=[\"BeforeCallbackScript event is fired\"]{style="COLOR: maroon"}+[\"\\n\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                   |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                   |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ AfterScript()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                   |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                   |
| [    document.getElementById([\'display\']{style="COLOR: maroon"}).value+=[\"AfterCallbackScript event is fired\"]{style="COLOR: maroon"}+[\"\\n\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                   |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

3.   Set the respective functions to the required client events.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[aspx\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[cc1]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[autocompletetextbox]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [id]{style="COLOR: red"}[=\"AutoCompleteTextBox1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} [datakeyfield]{style="COLOR: red"}[=\"Name\" ]{style="COLOR: blue"}[rows]{style="COLOR: red"}[=\"2\"]{style="COLOR: blue"} [textmode]{style="COLOR: red"}[=\"SingleLine\" ]{style="COLOR: blue"}[columns]{style="COLOR: red"}[=\"200\"]{style="COLOR: blue"} [datasourceid]{style="COLOR: red"}[=\"AccessDataSource2\" ]{style="COLOR: blue"}[aftercallbackscript]{style="COLOR: red"}[=\"AfterScript(this)\"]{style="COLOR: blue"} [beforecallbackscript]{style="COLOR: red"}[=\"BeforeScript(this)\" ]{style="COLOR: blue"}[precallbackscript]{style="COLOR: red"}[=\"PreCallbackScript(this)\"]{style="COLOR: blue"} [postcallbackscript]{style="COLOR: red"}[=\"PostCallbackScript(this)\"\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[\--template definitions\--]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[%\>]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [\</]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[cc1]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[autocompletetextbox]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[textarea]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [id]{style="COLOR: red"}[=\"display\"]{style="COLOR: blue"} [rows]{style="COLOR: red"}[=\"1\"]{style="COLOR: blue"} [cols]{style="COLOR: red"}[=\"1\"]{style="COLOR: blue"} [style]{style="COLOR: red"}[=\"width: 200px; height: 200px;\"\>\</]{style="COLOR: blue"}[textarea]{style="COLOR: maroon"}[\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

4.   Build and run the application. When the text is selected from the dropdown, the client events will be invoked displaying the names of the fired events.

 

::: {align="center"}
  --------------- -----------------------------------------------------------------------------
  Properties      Description
  StatusBarText   Specifies the text to display on the browser\'s status bar during callback.
  --------------- -----------------------------------------------------------------------------
:::

 

::: {align="center"}
  ------------------ ----------------------------------------------------------------------------------
  Properties         Description
  CausesValidation   Specifies whether the control causes validation to fire. Default value is False.
  ValidationGroup    Specifies the group to be validated when the control causes a postback.
  ------------------ ----------------------------------------------------------------------------------
:::

 

::: {align="center"}
  ---------------------------------------- ---------------------------------------------------------------------------------------
  Properties                               Description
  AfterCallbackResponseProcessedScript     Specifies the script that will be executed after callback result gets processed.
  AutoPostBack                             Specifies whether to postback the page when text is modified. Default value is False.
  BeforeCallbackResponseProcessingScript   Specifies the script that will be executed before callback result gets processed.
  PostCallbackScript                       Specifies the script function to be executed after callback.
  PreCallbackScript                        Specifies the script function to be executed before callback.
  ---------------------------------------- ---------------------------------------------------------------------------------------
:::

 

::: {align="center"}
  ----------------- ------------------------------------------------------------------------------------
  Properties        Description
  DataColumnIndex   Specifies the column index for selecting the data in Template scenario.
  DataKeyField      Specifies the field to be displayed in the drop-down.
  DataMember        Specifies the table to bind to.
  DataSourceID      Specifies the id of the datasource to populate the values in AutoComplete control.
  ----------------- ------------------------------------------------------------------------------------
:::

 

How do i specify which column data should be displayed in the textbox when more than 1 column is there? Irrespective of what I give in the DataKeyField property, the first column data is only displayed in the textbox. Is it suppose to work that way?

Is Columns used for only setting the width or any other purpose? If width can be set using this, when I give some value and enter multiple entries in the textbox, I am unable to find any width restriction.

When ReadOnly is set, unable to set focus on the control.

Tags appear initially when TextMode is set to Multiline. (Only once in the application, the ctrl was breaking when MultiLine was set.

Why css styles are not applied, when its set through stylesheet?

[]{#p33} 

[]{#related-topics}
::::::::

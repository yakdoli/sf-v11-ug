::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### AJAX Support {#ajax-support style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The RichTextEditor control, by default, fires it\'s server-side events using AJAX style callbacks. So, when the user clicks the **Update** or **Cancel** button, a callback will be triggered, which will result in the appropriate server-side event. This behavior can be changed to use postbacks instead using the **EnableCallbacks** property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ----------------- --------------------------------------------------------------------------------
  AJAX Property     Description
  EnableCallbacks   Specifies whether to use callbacks or postbacks to trigger server-side events.
  ----------------- --------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

When callbacks are turned on, the various client-side events that will be triggered and the properties through which you can setup listeners for those events are given below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black"} 

::: {align="center"}
  --------------------------------------- -----------------------------------------------------------------------------------------------------------
  Client-Side Event                       Description
  BeforeCallbackScript                    Specifies the client side script to execute before the callback  request is sent to the server.
  AfterCallbackScript                     Specifies the client side script that will be executed after the  callback request is sent to the server.
  BeforeCallbackResponseProcessedScript   Specifies the client side script to be executed before the callback request gets processed.
  AfterCallbackResponseProcessedScript    Specifies the client side script to be executed after the callback request gets processed.
  --------------------------------------- -----------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Note that the RichTextEditor\'s client side object exposes a **Refresh** method. When calling this method via JavaScript, the following server-side event will be triggered.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------- ---------------------------------------------------------------
  Server-Side Event   Description
  CallbackRefresh     Triggered when the client object\'s Refresh method is called.
  ------------------- ---------------------------------------------------------------
:::

 

[]{#p140} 

[]{#related-topics}
::::::

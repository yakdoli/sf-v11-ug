::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Callback script events invoke sequence[]{style="FONT-SIZE: 10pt"} {#callback-script-events-invoke-sequence style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The sequence in which the client-side events will be triggered when Callback is called is as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   **BeforeCallbackScript**: gets executed before a callback is generated on the client

28.  **AfterCallbackScript**: gets executed after a callback has been invoked

29.  **BeforeCallbackResponseProcessingScript**: gets executed in the callback return event handler on client, before the returned value is processed

30.  **AfterCallbackResponseProcessedScript**: gets executed in the callback return event handler on the client

 

[]{#related-topics}
:::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Client-side method {#client-side-method style="tab-stops: 0pt"}

There is only one client-side method that can be implemented for the Rating control:

::: {align="center"}
  **Name of the method**   **Parameters of the method**   **Return type**              **Descriptions**
  ------------------------ ------------------------------ ---------------------------- ----------------------------------------------------------
  Reset                    NA                             [NA]{style="COLOR: black"}   [Resets the rating value to zero.]{style="COLOR: black"}
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

You can use the client-side method using the following code:

 

**ASPX Code**

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Rating]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[ [ID]{style="COLOR: red"}[=\"Rating1\"]{style="COLOR: blue"} [runat]{style="COLOR: red"}[=\"server\"]{style="COLOR: blue"} [ClientObjectId]{style="COLOR: red"}[=\"ratingObj\"]{style="COLOR: blue"} [/\>]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------+
| [\[JavaScript\]]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                  |
| [function]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ updateData() {]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                  |
| [            [//code used to reset the rating]{style="COLOR: darkgreen"}]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                  |
| [            ratingObj.Reset();]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                  |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                           |
+------------------------------------------------------------------------------------------------------------------+

[[[]{style="TEXT-DECORATION: none"}]{style="COLOR: blue"}]{.underline} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
::::

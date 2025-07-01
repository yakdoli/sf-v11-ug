::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Render New Captcha [i]{style="TEXT-TRANSFORM: uppercase"}mage [a]{style="TEXT-TRANSFORM: uppercase"}fter [p]{style="TEXT-TRANSFORM: uppercase"}artial [P]{style="TEXT-TRANSFORM: uppercase"}ost back {#render-new-captcha-image-after-partial-post-back style="tab-stops: 0pt"}

After partial post back, the encrypted code for generating the captcha control image will be null. You can regenerate the image using the *RenderNewChallenge* method.

 

Table 1: Method Table

::: {align="center"}
+-------------------------------------------------------------------+----------------------------+------------+-------------+-------------+-----------------+
| Method                                                            | Description                | Parameters | Type        | Return Type | Reference links |
+-------------------------------------------------------------------+----------------------------+------------+-------------+-------------+-----------------+
| [`RenderNewChallenge`]{style="FONT-FAMILY: 'Arial','sans-serif'"} | Renders new captcha image. | NA         | Server side | void        | NA              |
|                                                                   |                            |            |             |             |                 |
|                                                                   |                            |            |             |             |                 |
+===================================================================+============================+============+=============+=============+=================+
:::

**[]{style="COLOR: #e36c0a"}** 

The following code illustrates how to render captcha image using the *RenderNewChallenge* method:

**[]{style="COLOR: #e36c0a"}** 

+-----------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                       |
| [Captcha2.RenderNewChallenge()]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                |
+-----------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} 

**[]{style="COLOR: #e36c0a"}** 

 

 

[]{#related-topics}
::::

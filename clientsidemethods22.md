::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Client-Side Methods  {#client-side-methods style="tab-stops: 0pt"}

The Tab control supports client-side methods handling to modify the control's behavior.

Select

The *select* method is used to select a tab, similar to selecting it by clicking.

+-----------------------------------------------------------------------+
| **\[JavaScript\]**                                                    |
|                                                                       |
|  \$(\"#myTab\").tabs(\'select\',2);                                   |
+-----------------------------------------------------------------------+

 

The second argument is the index (zero-based) of the tab to be selected.

 

Remove

The *remove* method is used to remove the particular tab using its index.

+-----------------------------------------------------------------------+
| **\[JavaScript\]**                                                    |
|                                                                       |
|  \$(\"#myTab\").tabs (remove,2);                                      |
+-----------------------------------------------------------------------+

 

The second argument is the index (zero-based) of the tab to be removed.

 

Enable

 The *enable* method is used to enable the disabled tab using its index.

+-----------------------------------------------------------------------+
| **\[JavaScript\]**                                                    |
|                                                                       |
|  \$(\"#myTab\").tabs(enable,2);                                       |
+-----------------------------------------------------------------------+

 

The second argument is the index (zero-based) of the tab to be removed.

 

Enabling Multiple Tabs

 

To enable more than one tab at the same time reset the disabled property as given in the following code.

+-----------------------------------------------------------------------+
| **\[JavaScript\]**                                                    |
|                                                                       |
|  \$(\'#myTab).tabs(\"option\", \"disabled\",\[\]);.                   |
+-----------------------------------------------------------------------+

 

Disable

 The *disable* method is used to disable the particular tab using its index.

+-----------------------------------------------------------------------+
| **\[JavaScript\]**                                                    |
|                                                                       |
|  \$(\"#myTab\").tabs(disable,2);                                      |
+-----------------------------------------------------------------------+

 

The second argument is the index (zero-based) of the tab to be removed.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: The selected tab cannot be disabled.
:::

 

Disabling Multiple Tabs

Using array of indexes we can disable multiple tabs. Refer to the following code to disable more than one tab at the same time.

+-----------------------------------------------------------------------+
| **\[JavaScript\]**                                                    |
|                                                                       |
|  \$(\'#myTab).tabs(\"option\",\"disabled\", \[1, 2, 3\]);             |
+-----------------------------------------------------------------------+

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: Similarly, you can use all the client-side methods of Jquery tabs in Essential Tools for MVC Tab control. For more details, refer to the following link.
:::

***[]{style="FONT-SIZE: 9pt"}*** 

[[http://docs.jquery.com/UI/Tabs#methods]{.UGHyperlink}](http://docs.jquery.com/UI/Tabs#methods)[]{.UGHyperlink}

 

 

[]{#related-topics}
:::::

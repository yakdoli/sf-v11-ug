::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Step 2-Registering the Method with the CalcEngine {#step-2-registering-the-method-with-the-calcengine style="tab-stops: 0pt"}

 

The second step for adding your own formula is to register your method with the **CalcEngine** object. This is done with the **AddFunction** method. This method accepts the string that is used when you reference the function in a spreadsheet formula, and the second argument is a delegate for which you pass your method. The only requirement here is that the function name should start with an alpha character and should only contain alpha-numeric characters. Additionally, the string cannot be the name of any existing library function.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                  |
|                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                            |
|                                                                                                                                                                                                                 |
| [// Add formula name Mymin to the Library.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                   |
|                                                                                                                                                                                                                 |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.engine.AddFunction([\"Mymin\"]{style="COLOR: maroon"}, [new]{style="COLOR: blue"} LibraryFunction(ComputeMymin));]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                    |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                              |
|                                                                                                                                                                                                   |
| [\' Add formula name Mymin to the Library.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.engine.AddFunction([\"Mymin\"]{style="COLOR: maroon"}, [AddressOf]{style="COLOR: blue"} ComputeMymin)]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

By convention, within the Essential Calculate library, the C# implementation method for each of the library functions that are shipped with the word \"Compute\" is named and followed by the name of the library function. The above code confirms to this convention, with the function name being \'Mymin\' and the method name being \'ComputeMymin\'. Our library functions are public members of the **CalcEngine** class, so that you can access them directly if it serves your purpose. Additionally, if you own the source code version, you can see implementation details that may be of use to you if you try to implement many custom library methods on your own.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image18_1.jpg){border="0"}Note: Once this is done, you can use your custom method in the same manner as the default library functions.
:::

 

[]{#related-topics}
::::

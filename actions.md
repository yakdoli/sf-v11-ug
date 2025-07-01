::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Actions {#actions style="tab-stops: 0pt"}

 

Essential PDF supports different actions triggered by different events and user interaction. There are a lot of possible actions such as playing a particular sound or movie, launching an application or URI, and so on.

 

Essential PDF supports the following types of actions.

 

[·      ]{style="FONT-FAMILY: Symbol"}**PdfSoundAction,** which plays the specified music file

[·      ]{style="FONT-FAMILY: Symbol"}**PdfUriAction** that launches the specified URI

[·      ]{style="FONT-FAMILY: Symbol"}**PdfGoToAction** that goes to the specified page of the document

[·      ]{style="FONT-FAMILY: Symbol"}**PdfJavaScriptAction**, which executes specified PDF javascript code

[·      ]{style="FONT-FAMILY: Symbol"}**PdfLaunchAction** that launches the application or opens the document

[·      ]{style="FONT-FAMILY: Symbol"}**PdfNamedAction**, which goes to the named destination: next, previous, first or last page

[·      ]{style="FONT-FAMILY: Symbol"}**PdfSubmitAction**, which submits the data that is entered into the PDF form

[·      ]{style="FONT-FAMILY: Symbol"}**PdfResetAction** that resets the fields of the PDF form

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                          |
| [PdfUriAction]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ uriAction = [new]{style="COLOR: blue"} [PdfUriAction]{style="COLOR: teal"}([\"http://www.google.com\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                          |
| [PdfDestination]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ dest = [new]{style="COLOR: blue"} [PdfDestination]{style="COLOR: teal"}(page, [new]{style="COLOR: blue"} [Point]{style="COLOR: teal"}(0, 100));]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                          |
| [PdfGoToAction]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ goToAction = [new]{style="COLOR: blue"} [PdfGoToAction]{style="COLOR: teal"}(page);]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                                                                          |
| [goToAction.Destination = dest;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                          |
| [uriAction.Next = goToAction;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                          |
| [PdfJavaScriptAction]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ javaAction = [new]{style="COLOR: blue"} [PdfJavaScriptAction]{style="COLOR: teal"}([\"app.alert(\\\"Hello \\\")\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                          |
| [goToAction.Next = javaAction;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                          |
| [document.Actions.AfterOpen = soundAction;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ uriAction [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.PdfUriAction = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.PdfUriAction([\"http://www.google.com\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dest [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.PdfDestination = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.PdfDestination(page, [New]{style="COLOR: blue"} Point(0, 100))]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ goToAction [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.PdfGoToAction = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.PdfGoToAction(page)]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                                                                                                                                      |
| [goToAction.Destination = dest]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                      |
| [uriAction.Next = goToAction]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ javaAction [As]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.PdfJavaScriptAction = [New]{style="COLOR: blue"} Syncfusion.Pdf.Interactive.PdfJavaScriptAction([\"app.alert(\"\"Hello \"\")\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                      |
| [goToAction.Next = javaAction]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                      |
| [document.Actions.AfterOpen = soundAction]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: Next property of an action is used to specify the queue of actions as illustrated in the preceding example.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   Following are the actions for Document Object:

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b"}** 

[·      ]{style="FONT-FAMILY: Symbol"}**AfterOpen** action to be performed after the document is opened

[·      ]{style="FONT-FAMILY: Symbol"}**AfterPrint** action to be performed after the document is printed

[·      ]{style="FONT-FAMILY: Symbol"}**AfterSave** action to be performed after the document is saved

[·      ]{style="FONT-FAMILY: Symbol"}**BeforeClose** action to be performed before the document is closed

[·      ]{style="FONT-FAMILY: Symbol"}**BeforePrint** action to be performed before the document is printed

[·      ]{style="FONT-FAMILY: Symbol"}**BeforeSave** action to be performed before the document is saved

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

2.   Following are the actions for Annotation Object:

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**GotFocus** action to be performed when the annotation gets focus

[·      ]{style="FONT-FAMILY: Symbol"}**LostFocus** action to be performed when the annotation loses focus

[·      ]{style="FONT-FAMILY: Symbol"}**MouseEnter** action to be performed when the cursor enters the active area of the annotation

[·      ]{style="FONT-FAMILY: Symbol"}**MouseLeave** action to be performed when the cursor leaves the active area of the annotation

[·      ]{style="FONT-FAMILY: Symbol"}**MouseDown** action to be performed when the mouse button is pressed inside the active area of the annotation

[·      ]{style="FONT-FAMILY: Symbol"}**MouseUp** action to be performed when the mouse button is released inside the active area of the annotation

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

3.   Following are the actions for Form Field Object:

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Calculate** javascript action to be performed to recalculate the value of the field

[·      ]{style="FONT-FAMILY: Symbol"}**Format** javascript action to be performed before the field is formatted to display the value

[·      ]{style="FONT-FAMILY: Symbol"}**Validate** javascript action to be performed when the value of the field is changed

[·      ]{style="FONT-FAMILY: Symbol"}**KeyPressed** javascript action to be performed when the user types, key-stroke into a text field or combo box, or modifies the selection in a scrollable list box

 

Additionally, the fields support all the actions that are supported by annotations.

 

[]{#related-topics}
::::

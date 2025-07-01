::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Fields Updating Engine {#fields-updating-engine style="tab-stops: 0pt"}

Field in a Word document is a placeholder of data that might change on field update.  A field contains field code, field separator, field result and field end. The field code contains information about how the field result is to be calculated and updated. The field result specifies the resultant value of the field. Field updating engine calculates the resultant value based on the field code information and updates the field result with the new value.

The supported fields are:

[·      ]{style="FONT-FAMILY: Symbol"}= (formula field)

[·      ]{style="FONT-FAMILY: Symbol"}DATE

[·      ]{style="FONT-FAMILY: Symbol"}TIME

[·      ]{style="FONT-FAMILY: Symbol"}DOCVARIABLE

[·      ]{style="FONT-FAMILY: Symbol"}DOCPROPERTY

[·      ]{style="FONT-FAMILY: Symbol"}COMPARE

[·      ]{style="FONT-FAMILY: Symbol"}IF

[·      ]{style="FONT-FAMILY: Symbol"}NEXTIF

[·      ]{style="FONT-FAMILY: Symbol"}MERGEREC

[·      ]{style="FONT-FAMILY: Symbol"}MERGESEQ

[·      ]{style="FONT-FAMILY: Symbol"}SECTION

 

= (formula field)

This field is an expression that contains any combination of numbers, bookmarks that refer to numbers, fields resulting in numbers, and the available operators and functions. The expression can refer to values in a table and values returned by functions.

 

DATE and TIME

This field displays the current date-time, in the format specified by date-time picture switch.

 

Syntax

{ DATE \[\\@ \"Date-Time Picture\"\] }

{ TIME \[\\@ \"Date-Time Picture\"\] }

 

DOCVARIABLE

This field displays the value of the specified document variable.

 

Syntax

{DOCVARIABLE \"Name"}

 

DOCPROPERTY

This field displays the value of the specified document property.

 

Syntax

{DOCPROPERTY \"Name"}

 

COMPARE

This field compares the two expressions and displays the result \"1\" if the result of comparison is true or \"0\" (zero) if the comparison is false.

 

Syntax

{ COMPARE Expression1 Operator Expression2 }

 

IF

This field compares the two expressions and displays the true text if the result of comparison is true or displays the false text if the result of comparison is false.

 

Syntax

{ IF Expression1 Operator Expression2 TrueText FalseText }

 

NEXTIF

This field compares two expressions. If the comparison result is true, the next data record is merged into the current merge document. If the comparison result is false, the next data record is merged into a new merge document.

 

Syntax

{ NEXTIF Expression1 Operator Expression2 }

 

MERGESEQ

This field numbers all the merged records of a mail merge. The number may be different from the value that is inserted by the MERGEREC field.

 

Syntax

{ MERGESEQ }

 

MERGEREC

This field displays the ordinal position of the current data record in a merged document. The number reflects any sorting or filtering that you applied to the data source before the merge.

 

Syntax

{ MERGEREC }

 

SECTION

This field displays the number of the current section.

 

Syntax

{ SECTION }

 

The following example illustrates how to update the fields present in the document.

+-----------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                      |
|                                                                                                     |
| [// Opening the word document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                   |
|                                                                                                     |
| [WordDocument document = new WordDocument(\"Input.doc\");]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                     |
| [// Updating the fields present in the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                     |
| [document.UpdateDocumentFields();]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                     |
| [// Saving the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                         |
|                                                                                                     |
| [document.Save(\"Sample.doc\", FormatType.Doc);]{style="FONT-FAMILY: 'Courier New'"}                |
+-----------------------------------------------------------------------------------------------------+

[]{style="DISPLAY: none; FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

 

[]{style="DISPLAY: none; FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                        |
|                                                                                                                                           |
| [\' Opening the Word document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                         |
|                                                                                                                                           |
| [Dim document As WordDocument = New WordDocument(\"Input.doc\")]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                           |
|                                                                                                                                           |
|                                                                                                                                           |
| [\' Updating the fields present in the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                           |
| [document.UpdateDocumentFields()]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                           |
| [\' Saving the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                               |
|                                                                                                                                           |
| [document.Save(\"Sample.doc\", FormatType.Doc)]{style="FONT-FAMILY: 'Courier New'"}                                                       |
+-------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::

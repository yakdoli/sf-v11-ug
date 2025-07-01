::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Shapes {#shapes style="tab-stops: 0pt"}

 

Shape is a subdocument of the Word document. Shape is a general name for a group of elements. Shapes can be added to the document with the help of Microsoft Word. The AutoShapes combo box lists the group of shapes. Picture and TextBox are shapes too.

 

Every shape is represented in Word Document with a special shape marker (among text block) and a block of information about the shape, which is situated in the other part of the document.

 

DocIO has four classes which represent shapes.

 

[·      ]{style="FONT-FAMILY: Symbol"}ShapeObject

[·      ]{style="FONT-FAMILY: Symbol"}InlineShapeObject

[·      ]{style="FONT-FAMILY: Symbol"}WPicture

[·      ]{style="FONT-FAMILY: Symbol"}WTextBox

 

You have full access to the WPicture and WTextBox classes, i.e., you can read, modify, and create pictures and text boxes. Other shapes are only preserved by DocIO (user cannot create or modify them).

 

ShapeObject and InlineShapeObject

 

ShapeObject class represents all types of Word document shapes except pictures and text boxes.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: ShapeObject and InlineShapeObject classes are \"read only\" classes. You cannot modify shapes. An exception to this is the picture and textbox shape. All shapes except pictures and textbox shapes are only preserved.
:::

 

ShapeObject class has only one public property -- **EntityType**. This property defines the type of the entity, and returns the EntityType.Shape for this class.

 

InlineShapeObject represent[s]{style="COLOR: red"} all the inline shape objects (except inline textboxes and pictures). Inline shape objects are shape objects which have Inline with text layout.

 

Class Hierarchy

 

ParagraphItem

               \|

            ShapeObject

                   \|             

              InlineShapeObject

 

ShapeObject Public Property

 

::: {align="center"}
  ------------ ------------------------------
  **Name**     **Description**
  EntityType   Gets the type of the entity.
  ------------ ------------------------------
:::

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Picture](ms-xhelp:///?Id=e1c5df76-311f-48c5-8b5f-c6667b70b55f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}TextBox](ms-xhelp:///?Id=4556dcf6-7025-4877-b11d-3209359faa85){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Comment](ms-xhelp:///?Id=5f969b19-b4cf-4ec6-95b6-52777ad0e7c0){style="TEXT-DECORATION: none"}
:::::

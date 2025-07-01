::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Lists {#lists style="tab-stops: 0pt"}

 

Lists in the Essential PDF are used to list out the items in a collection in some order to provide readability. There are two kinds of lists. They are:

 

[·      ]{style="FONT-FAMILY: Symbol"}**Ordered list**, which is represented by the PdfOrderedList class

[·      ]{style="FONT-FAMILY: Symbol"}**Unordered list**, which is represented by the PdfUnorderedList class

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Base class for the preceding classes is the **PdfList** class, which contains an item collection represented by the **PdfListItemCollection** class. The items from the collection are represented by the **PdfListItem** class.

 

**Ordered List**

 

**PdfOrderedList** class represents an ordered list.

 

**Initialize Lists**

 

You can create new instances of the PdfOrderedList class by using the following constructors.

 

[·      ]{style="FONT-FAMILY: Symbol"}**PdfOrderedList()**: Creates list with default settings

[·      ]{style="FONT-FAMILY: Symbol"}**PdfOrderedList(PdfListItemCollection items)**: Creates list with the specified collection of items

[·      ]{style="FONT-FAMILY: Symbol"}**PdfOrderedList(PdfOrderedMarker marker)**: Creates list with the specified marker

[·      ]{style="FONT-FAMILY: Symbol"}**PdfOrderedList(PdfListItemCollection items, PdfOrderedMarker marker)**: Creates list with the specified items collection and marker

[·      ]{style="FONT-FAMILY: Symbol"}**PdfOrderedList(string text)**: creates list from the specified text. It splits text by using the \"\\n\" symbol and creates a collection of items.

[·      ]{style="FONT-FAMILY: Symbol"}**PdfOrderedList(string text, PdfOrderedMarker marker)**: Creates list from the specified text and with specified marker. It splits text by using the \"\\n\" symbol and creates a collection of items.

 

List Marker

 

Ordered list has ordered markers that are represented by the **PdfOrderedMarker** class. To create a new instance of the ordered marker, use the following constructors.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**PdfOrderedMarker(PdfNumberStyle style, PdfFont font)**: Creates marker by using the PdfNumberStyle and specified font

[·      ]{style="FONT-FAMILY: Symbol"}**PdfOrderedMarker (PdfNumberStyle style, string finalizer, PdfFont font)**: Creates marker with number style, font, finalizer, and the specified symbol that follows after number.  Default value for finalizer is \'.\'.

[·      ]{style="FONT-FAMILY: Symbol"}**PdfOrderedMarker (PdfNumberStyle style, string delimiter, string finalizer, PdfFont font)**: Creates marker with the number style, font, finalizer, delimiter, and the specified symbol located between numbers. It is used when the **MarkerHierarchy** property of the PdfOrderedList class is set ***True***. Default value for delimiter is \'.\'.

 

Default list marker has **Number** style.

 

Features

 

Also, PdfOrderedList enables you to use numbering hierarchy, which means if you have an ordered list and one of its item has an ordered sublist, marker of it will contain the number of its parent item. This number is split by the delimiter.

 

To use numbering hierarchy, just set the **MarkerHierarchy** property of the PdfOrderedList class to ***True***. Default value is ***False***.

 

Unordered List

 

**PdfUnorderedList** class represents an unordered list.

 

Initialize Lists

 

You can create a new instance of the PdfUnorderedList class by using the following constructors.

 

[·      ]{style="FONT-FAMILY: Symbol"}**PdfUnorderedList()**: Creates list with default settings

[·      ]{style="FONT-FAMILY: Symbol"}**PdfUnorderedList(PdfListItemCollection items)**: Creates list with the specified collection of items

[·      ]{style="FONT-FAMILY: Symbol"}**PdfUnorderedList(PdfUnorderedMarker marker)**: Creates list with the specified marker

[·      ]{style="FONT-FAMILY: Symbol"}**PdfUnorderedList(PdfListItemCollection items, PdfUnorderedMarker marker)**: Creates list with the specified items collection and marker

[·      ]{style="FONT-FAMILY: Symbol"}**PdfUnorderedList (string text)**: Creates list from the specified text. It splits the text by using the \"\\n\" symbol and creates a collection of items.

[·      ]{style="FONT-FAMILY: Symbol"}**PdfUnorderedList (string text, PdfUnorderedMarker marker)**: Creates list from the specified text and with the specified marker. It splits text by using the \"\\n\" symbol and creates a collection of items.

 

List Marker

 

Unordered list has an unordered marker that is represented by the **PdfUnorderedMarker** class. Unordered marker has the marker style represented by the **PdfUnorderedMarkerStyle** class. The following marker styles are supported.

 

[·      ]{style="FONT-FAMILY: Symbol"}None

[·      ]{style="FONT-FAMILY: Symbol"}Disk

[·      ]{style="FONT-FAMILY: Symbol"}Square

[·      ]{style="FONT-FAMILY: Symbol"}Asterisk

[·      ]{style="FONT-FAMILY: Symbol"}Circle

[·      ]{style="FONT-FAMILY: Symbol"}CustomString

[·      ]{style="FONT-FAMILY: Symbol"}CustomImage

[·      ]{style="FONT-FAMILY: Symbol"}CustomTemplate

 

Default list marker has **Disk** style.

To use the **CustomString**, **CustomImage** or **CustomTemplate** style, you must set the **Text**, **Image** or **Template** property of the PdfUnorderedMarker class respectively.

 

Drawing Lists

 

There are a lot of **Draw** overloads that enable you to draw lists on a series of pages or on a PdfGraphics page.

 

Events

 

Each list raises the following four events:

 

[·      ]{style="FONT-FAMILY: Symbol"}**BeginPageLayout** event is raised when the list starts layouting on page

[·      ]{style="FONT-FAMILY: Symbol"}**EndPageLayout** event is raised when the list completes layouting on the page

[·      ]{style="FONT-FAMILY: Symbol"}**BeginItemLayout** event is raised when the item starts layouting

[·      ]{style="FONT-FAMILY: Symbol"}**EndItemLayout** event is raised when the item completes layouting

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image22_2.jpg){border="0"}Note: You should add the Syncfusion.Pdf.List namespace to work with lists.
:::

 

 

[]{#related-topics}
::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Embed Field {#embed-field style="tab-stops: 0pt"}

[]{#p46} 

**WEmbedField** class represents an embed field type in the Word document. Word does not allow to create an embed field type manually (using Microsoft Word interface). This field is used when the document has embedded objects. This field usually points to the container in the document which encloses the embedded object.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image24_1.jpg){border="0"}Note: Modification of WEmbedField properties can cause document corruption or incorrect document preservation. DocIO preserves only fields of this type.
:::

 

**Class Hierarchy**

 

WTextRange

            \|

            WField

                        \|

                       WEmbedField

 

**Public Property**

 

::: {align="center"}
  ------------ --------------------------------
  Name         Description
  EntityType   Gets the type of the entity.  
  ------------ --------------------------------
:::

[]{#related-topics}
:::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Custom Cell Types {#custom-cell-types style="tab-stops: 0pt"}

 

Essential Grid allows you to create custom derived controls to use additional cell types. This requires a cellmodel class and a cellrenderer class. The cellmodel class creates the actual cell control while the cellrenderer class handles the UI requirements of the cell control. The custom cell type can be created by  registering the cellmodel to the corresponding grid by naming this cell type. It can be enabled by assigning its name to the style.CellType property.

In general, the built-in cell types are also constructed only in this way. Every such cell type has its own cell model and renderer classes in the code base. These cell model and renderer classes originate from GridCellModelBase and GridCellRendererBase classes. These two classes define the basic functionality for a cell type.

Examples of custom cell types are discussed in later sections.

 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Custom Drop-down Cells](ms-xhelp:///?Id=fa701434-8594-48a2-a4e8-1e1618267f02){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Data Template Cells](ms-xhelp:///?Id=e931124e-9ac5-478f-b369-25efaa6a65cb){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Rich Text Box Cells](ms-xhelp:///?Id=28ab07e1-b2db-4ad6-bc91-331425517e3f){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Chart Cells](ms-xhelp:///?Id=c8d5b1be-16c9-4759-881d-e9df91d48523){style="TEXT-DECORATION: none"}
:::

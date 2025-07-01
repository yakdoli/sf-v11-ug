::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Virtual Grids {#virtual-grids style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Essential Grid[ ]{style="COLOR: black; FONT-SIZE: 1pt"}supports complete separation between the **datasource** and the grid. In a virtual grid, no cell data is stored in the **GridStyleInfo** objects or any other internal grid storage. All information is provided on demand through handled events. For example, whenever Essential Grid needs a row count for a grid, it fires a **QueryRowCount** event. In your handler, you must provide the row count from your datasource. Virtual grids can display large amounts of data extremely fast. There is no need to perform the time-consuming task of populating the grid.

 

To implement a Read-only virtual grid, you\'ll need to handle three events. To remove the Read-only limitation, you will have to handle a fourth event. In addition to these four events, there are other events that you may want to handle depending upon the behavior you are trying to implement. We will first discuss the required events and then discuss the optional events that you can handle to affect virtual grid behavior. You can also work through the virtual grid tutorial to see an implementation of a simple virtual grid.

 

The events are discussed under the below sections:

 

[]{#p304} 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Required Events](ms-xhelp:///?Id=01a61e51-3f33-4b6c-b1bc-05e1b4356aa6){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Optional Events](ms-xhelp:///?Id=90f4279a-89dc-4c5c-8b76-e5abbe614d80){style="TEXT-DECORATION: none"}
:::

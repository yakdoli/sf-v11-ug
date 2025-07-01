::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Deriving a Cell Control {#deriving-a-cell-control style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Derived cell controls can be used to add cells that have a special functionality. You can employ such controls to produce special behavior like a masked edit control, a draggable button or a tree node within a grid cell. Being able to extend a cell behavior through the derived cell controls makes Essential Grid very adaptable.

 

There are two classes involved in defining the cell architecture within Essential Grid. **GridCellModelBase** serves as the base class for the first class which is involved in the cell model. **GridCellRendererBase** is the base class for the second class which is involved in defining a cell control, the cell renderer. For example, the Static cell control is defined in the **GridStaticCellModel** and **GridStaticCellRenderer** classes which are derived from these base classes. So, whether the cell control is a text box, a combo box or a NumericUpDown cell, the behavior is accomplished through these two classes which are derived from GridCellModelBase and GridCellRendererBase.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

In the next sections, you will learn how to derive a cell control from the

***C:\\Syncfusion\\EssentialStudio\\VersionNumber\\Windows\\Grid.Windows\\Samples\\\[Version Number\]\\CustomCellTypes\\DerivedCellControlTutorial***  sample.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Also,  ***C:\\Syncfusion\\EssentialStudio\\VersionNumber\\Windows\\Grid.Windows\\Samples\\\[Version Number\]\\CustomCellTypes\\DropDownFormAndUserControlSample***  sample illustrates how to add your own cell controls. It has two derived cell controls, one drops a modal form when a cell button is pressed, and the other is displays a pop up UserControl when a cell button is pressed.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Among the samples shipped with Grid control, there are several that provide custom cell types. The following table lists some of the samples.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  ------------------------ ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Sample                   Description
  ExcelSelectionMarker     Has a derived **celltype** that displays in a cell a BMP that is stored in the **GridStyleInfo.Tag** for that cell.
  GridDataBoundImageCell   Has two cell-derived cell types. Both display picture data stored in a database in a grid cell. One displays the picture directly in the grid cell with several choices regarding how the image is fit to the cell. The second celltype is a drop-down cell that displays a picture box when you click the cell.
  VirtTreeGrid             Has an expandable tree node cell with an indentation property. This celltype is used in this example to make the grid have collapsible rows, and generally functions as a multicolumn tree control.
  3.   LinkLabelCells      4.   Has a **LinkLabel**-derived cell type. This cell type allows you to place a link in a **GridCell**, and then launch the link in a browser window by clicking the link.
  CellButtons              Shows two different types of derived cell controls with buttons. The first is an ellipsis cell that displays further information when you click the button. This particular cell uses a bitmap button to display the ellipsis. The second custom cell type in this sample is a bar of three buttons that display different drag effects as you mouse down and drag.
  Drop-down grid           Shows how you can drop a new grid in a cell. This sample is useful as it shows how to pass keystrokes onto the control that is embedded in the grid. For example, you may want the dropped grid to handle the ARROW keys, but not have the ARROW keys move to another cell in the parent grid.
  CalendarCells            Shows how you can drop a Windows Forms **DateTimePicker** in a cell.
  SliderCells              Shows how you can drop a Windows Forms Slider Control in a cell.
  RepeaterUserControl      Shows how you can use a derived cell control in a grid to create a repeater control used to edit DataTables.
  ------------------------ ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

See Also

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

 

[]{#p90} 

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}GridCellModelBase](ms-xhelp:///?Id=e86a23cc-d72b-484a-9628-f752649a6ef8){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}GridCellRendererBase](ms-xhelp:///?Id=96e4c32e-a0f5-48a1-91c9-0db84749ce57){style="TEXT-DECORATION: none"}
::::

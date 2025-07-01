::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### GridCellRendererBase {#gridcellrendererbase style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The class derived from the **GridCellRendererBase** handles the drawing of the cell and the user interaction aspect of the cell architecture. It takes care of things like the handling of the mouse and keyboard messages. Some of the virtual members you might override are listed in the following table.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
  --------------------------------------------------------------------------------------------------- -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Virtual Method                                                                                      Description
  OnInitialize(int rowIndex, int colIndex)                                                            Override this method if you need to do any initialization for the current cell. One primary use of this method is to move state information from the **GridStyleInfo** object to the cell control that handles active editing of the cell. For example, if your custom control is a checked list box control, you will  use this method to check the selected items in the embedded checked list box from information stored in the cell\'s style object.
  OnDraw(Graphics g, Rectangle clientRectangle, int rowIndex, int colIndex, GridStyleInfo style)      Called to draw the contents of the client bounds for the cell, for example, the text for a static cell. If your cell has an active state, then normally there are two paths through **OnDraw**. One path draws the active cell and the other handles the drawing of the cell when it is not active. Override it when you want to draw the content of your cell.
  OnKeyDown(KeyEventArgs e)                                                                           Called when the user presses a key.
  OnKeyUp(KeyEventArgs e)                                                                             Called when the user releases a key.
  OnKeyPress(KeyPressEventArgs e)                                                                     Called for a user key press.
  OnHitTest(int rowIndex, int colIndex, MouseEventArgs mouseEventArgs, IMouseController controller)   Override the **OnHitTest** in your derived cell renderer if you want to catch mouse events. If you want your renderer class to handle mouse actions like **OnMouseDown** or **OnMouseMove**, this OnHitTest should return a non-zero value. Otherwise, your mouse methods will not be called.
  OnMouseHoverLeave(int rowIndex, int colIndex, EventArgs e)                                          Called when your cell renderer has indicated in its OnHitTest override that it wants to receive mouse events, and that the user is moving the mouse out of the cell.
  OnMouseHover(int rowIndex, int colIndex, MouseEventArgs e)                                          Called when your cell renderer has indicated in its OnHitTest override that it wants to receive mouse events, and that the user is moving the mouse over the cell.
  OnMouseHoverEnter(int rowIndex, int colIndex)                                                       Called when your cell renderer has indicated in its OnHitTest override that it wants to receive mouse events, and that the user has moved the mouse into the cell.
  OnMouseDown(int rowIndex, int colIndex, MouseEventArgs e)                                           Called when your cell renderer has indicated in its OnHitTest override that it wants to receive mouse events, and that the user has pressed a mouse button.
  --------------------------------------------------------------------------------------------------- -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

These are only a few of the many virtual methods available to you. For a complete list, take a look at the Essential Grid Class Reference.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

In general, you probably will not derive directly from the base class, but instead from an existing Essential Grid derived class such as **GridStaticCellModel**.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

For a sample implementation of a derived cell control that is based on the existing Static cell control, take a look at the sample in the following path: ***C:\\Syncfusion\\EssentialStudio\\VersionNumber\\Windows\\Grid.Windows\\Samples\\\[Version Number\]\\CustomCellTypes\\DropDownFormAndUserControlSample***. It shows two implementations of drop-downs. One drops a modal form by deriving **GridStaticCellModel** and **GridStaticCellRenderer**. The other drops a **UserControl** using popup architecture that handles focus issues by deriving **GridDropDownCellModel** and **GridDropDownCellRenderer**.

 

[]{#p92} 

 

[]{#related-topics}
::::

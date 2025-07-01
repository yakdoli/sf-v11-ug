::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=8eafe2de-0a87-4f85-a0c7-5c1778098596){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=274d1d61-9e05-49c5-b342-4e032fc4daa1){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Silverlight](ms-xhelp:///?Id=66221bd1-ba2e-43c2-94a7-618f50e01d24){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=8126789d-b192-4c3c-9e36-f0119f12b8b9){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grid Control](ms-xhelp:///?Id=103363c3-4afe-437d-9f1e-5976ee438b68){.d2h_breadcrumbsNormal}
:::

### Serialization Support {#serialization-support style="tab-stops: 0pt"}

Essential GridControl supports Serialization. The whole grid can be serialized and deserialized at runtime.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Use Case Scenarios

Serialization can be implemented for the applications which need to save its data and structure after the application is closed. Serialization supports to save the structure and data of the GridControl to an XML file and it can be loaded at any time.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Adding Serialization to an Application

The following sample application explains the implementation of the Serialization support to GirdControl.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

1.   Create an application

      Create a Silverlight application and add the GridControl to it.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

2.   Call the Serialization support methods

**[      ]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}**In the application, create three buttons. The first button to call the **Serialize()** method, the second button to make changes to the Grid and the third button is to call the **Deserialize()** method. The following code snippet explains the implementation of Serialization.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

+-------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                        |
|                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                              |
|                                                                                                                         |
| **[// To Serialize the GridControl.]{style="FONT-FAMILY: 'Courier New'; COLOR: #078b0a"}**                              |
|                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.grid.Model.Serialize();]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                         |
| **[// To Deserialize the GridControl.]{style="FONT-FAMILY: 'Courier New'; COLOR: #078b0a"}**                            |
|                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.grid.Model.Deserialize();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
+-------------------------------------------------------------------------------------------------------------------------+

 

3.   Run the application

Run the application. Click the Serialize button which opens as **SaveAs** dialog to serialize the initial load; it creates an XML file. Click the second button **ModifyGridStyle** to make some changes in the GridControl. Now click the **Deserialize** button which opens an Open dialog box to restore the old settings of the GridControl.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Supported Properties for Serialization

The following Properties are Serialized in the GridControl.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}RowCount

[·      ]{style="FONT-FAMILY: Symbol"}ColCount

[·      ]{style="FONT-FAMILY: Symbol"}ActivateCurrentCellBehavior

[·      ]{style="FONT-FAMILY: Symbol"}AllowSelection

[·      ]{style="FONT-FAMILY: Symbol"}AllowSelectionOnShiftTab

[·      ]{style="FONT-FAMILY: Symbol"}ColumnSizer

[·      ]{style="FONT-FAMILY: Symbol"}CurrentCellBorder

[·      ]{style="FONT-FAMILY: Symbol"}CurrentCellBorderWidth

[·      ]{style="FONT-FAMILY: Symbol"}DataObjectConsumerOptions

[·      ]{style="FONT-FAMILY: Symbol"}DrawSelectionOptions

[·      ]{style="FONT-FAMILY: Symbol"}ExcelLikeCurrentCell

[·      ]{style="FONT-FAMILY: Symbol"}ExcelLikeSelectionFrame

[·      ]{style="FONT-FAMILY: Symbol"}HighlightSelectionBorder

[·      ]{style="FONT-FAMILY: Symbol"}HighlightSelectionBorderWidth

[·      ]{style="FONT-FAMILY: Symbol"}ListBoxModeAllowUIElementClick

[·      ]{style="FONT-FAMILY: Symbol"}ListBoxSelectionMode

[·      ]{style="FONT-FAMILY: Symbol"}MaxLength

[·      ]{style="FONT-FAMILY: Symbol"}ScrollFrozen

[·      ]{style="FONT-FAMILY: Symbol"}ShowCurrentCell

[·      ]{style="FONT-FAMILY: Symbol"}WrapCell

[·      ]{style="FONT-FAMILY: Symbol"}WrapCellBehavior

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Methods

Table 16: Serialization Support Table

  Method                  Description                                                                                                                            Parameters       Type      Return Type
  ----------------------- -------------------------------------------------------------------------------------------------------------------------------------- ---------------- --------- -------------
  Serialize()             A virtual method called to Serialize the GridControl. It stores the settings in an xml file named as specified in its parameter.       NA               public    void
  Deserialize()           A virtual method called to Deserialize the GridControl. It restores the settings in an xml file named as specified in its parameter.   NA               public    void
  SerializeToStream()     Serialize the Grid to Stream.                                                                                                          Stream stream    public    void
  SerializeAsString()     Serialize the Grid  as String.                                                                                                         NA               public    string 
  DeserializeFromStream   Deserialize from the given TextReader.                                                                                                 Stream stream    public    void
  DeserializeFromString   Deserialize from the given String content.                                                                                             string content   public    void

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

Sample Link

Refer to the samples in the shipped Sample Browser.

Go to Essential Studio WPF Sample Browser [à]{style="FONT-FAMILY: Wingdings"} Grid [à]{style="FONT-FAMILY: Wingdings"} Serialization [à]{style="FONT-FAMILY: Wingdings"}GridControl Serialization Demo

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

 

[]{#related-topics}
::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=a097ba0e-ef19-4ec7-9d37-734151b4ae8b){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e9aeb59d-d6ab-4862-87f7-4f169b1d763e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=094c35c7-db8e-4341-9619-16644b2a4e34){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grid WPF Controls](ms-xhelp:///?Id=1249c159-5431-465a-b1af-1cf1e5e90ac8){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grid Control](ms-xhelp:///?Id=7b54a403-0e9e-4539-948b-dbe0726ed273){.d2h_breadcrumbsNormal}
:::

### Serialization Support {#serialization-support style="tab-stops: 0pt"}

Essential GridControl supports Serialization. The whole grid can be serialized and deserialized at run-time.

Use Case Scenarios

Serialization can be implemented for the applications which need to save its data and structure after the application is closed. Serialization supports to save the structure and data of the GridControl to an XML file and it can be loaded at any time.

 

Adding Serialization to an Application

The following sample application explains the implementation of the Serialization support to GirdControl.

**[]{style="COLOR: #15428b"}** 

1.   Create an application

Create a WPF application and add the GridControl to it.

**[]{style="COLOR: #15428b"}** 

2.   Call the Serialization support methods

 

In the application, create three buttons. The first button to call the Serialize() method, the second button to make changes to the Grid and the third button is to call the Deserialize() method. The following code snippet explains the implementation of Serialization.

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}** 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                     |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}                                                                                                                                           |
|                                                                                                                                                                                                   |
| [// To Serialize the GridControl.]{style="FONT-FAMILY: 'Courier New'; COLOR: #009e47"}                                                                                                            |
|                                                                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.grid.Model.Serialize([\"Data.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                        |
|                                                                                                                                                                                                   |
| [// To Deserialize the GridControl.]{style="FONT-FAMILY: 'Courier New'; COLOR: #009e47"}                                                                                                          |
|                                                                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9.5pt"}[.grid.Model.Deserialize([\"Data.xml\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                   |
|                                                                                                                                                                                                   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

3.   Run the application

Run the application. Click the Serialize button to serialize the initial load; this creates an XML file and saves it. Click the second button ModifyGridStyle to make some changes in the GridControl. Now click the Deserialize button which restores the old settings of the GridControl.

**[]{style="COLOR: #15428b"}** 

**[]{style="COLOR: #15428b"}** 

Supported Properties for Serialization

The following properties are Serialized in the GridControl.

**[]{style="COLOR: #15428b"}** 

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

**[]{style="COLOR: #15428b"}** 

Methods

Table 39: Serialization Support Table

::: {align="center"}
  Method                  Description                                                                                                                            Parameters              Type      Return Type
  ----------------------- -------------------------------------------------------------------------------------------------------------------------------------- ----------------------- --------- -------------
  Serialize()             A virtual method called to Serialize the GridControl. It stores the settings in an xml file named as specified in its parameter.       string  fileName        public    void
  Deserialize()           A virtual method called to Deserialize the GridControl. It restores the settings in an xml file named as specified in its parameter.   string  fileName        public    void
  SerializeToStream()     Serializes the Grid to Stream.                                                                                                         TextWriter textWriter   public    void
  SerializeAsString()     Serializes the Grid as String.                                                                                                         NA                      public    string 
  DeserializeFromStream   Deserializes from the given TextReader.                                                                                                TextReader textReader   public    void
  DeserializeFromString   Deserializes from the given String content.                                                                                            string content          public    void
:::

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"}** 

Sample Link

1.   Refer to the samples in the shipped Sample Browser.

2.   Go to Essential Studio WPF Sample Browser [à]{style="FONT-FAMILY: Wingdings"} Grid [à]{style="FONT-FAMILY: Wingdings"} Serialization [à]{style="FONT-FAMILY: Wingdings"}GridControl Serialization Demo

***[]{style="COLOR: #15428b"}*** 

[]{#related-topics}
:::::

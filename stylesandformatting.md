::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=9202533e-a9c3-47c0-9762-dad7bcfdc47a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=b4e6a0de-f2a4-41d4-8e20-2b69555a0cfb){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Paragraph](ms-xhelp:///?Id=2ca51ad2-2f2e-40ba-9220-4c0bdf3eba1b){.d2h_breadcrumbsNormal}
:::

### Styles and Formatting {#styles-and-formatting style="tab-stops: 0pt"}

 

[]{#p66}Every word document contains a number of styles. They are as follows.

 

[·      ]{style="FONT-FAMILY: Symbol"}Character Style

[·      ]{style="FONT-FAMILY: Symbol"}Paragraph Style

[·      ]{style="FONT-FAMILY: Symbol"}Table Style

 

In Word document style hierarchy, there is also a base style, **Normal**.

 

DocIO has three classes which represent Word styles.

 

[·      ]{style="FONT-FAMILY: Symbol"}**CharacterStyle**: represents Word character style

[·      ]{style="FONT-FAMILY: Symbol"}**WParagraphStyle**: represents Word paragraph style

[·      ]{style="FONT-FAMILY: Symbol"}**ListStyle**: represents list properties in the Word paragraph style

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: DocIO does not support table styles.
:::

 

DocIO gives user an opportunity to add user-defined paragraph and list styles to the document. For details, see [WParagraphStyle.](ms-xhelp:///?Id=5cae42e5-3458-4608-9b2c-653a75175b48)

 

Collection of DocIO character and paragraph styles is accessible through the **WordDocument.Styles** property. Collection of list styles is accessible through the **WordDocument.ListStyles** property.

 

DocIO **Style** class is a base class for the CharacterStyle and WParagraphStyle classes. Style is an abstract class. **CharacterFormat** property of Style class defines character formatting. This property returns the object of WCharacterFormat type. **Name** property specifies the name of the style. **BaseStyle** property defines the base style (style inherits formatting of base style). User can apply one of the built-in Word styles by using the **WParagraph.ApplyStyle** method. The built-in styles are accessible through the **BuiltinStyle** enumeration.

 

**Public Properties**

 

::: {align="center"}
  ----------------- --------------------------------
  Name              Description
  CharacterFormat   Gets the character format.    
  Name              Gets or sets style name.  
  StyleType         Gets the type of the style.  
  ----------------- --------------------------------
:::

 

Public Methods

 

::: {align="center"}
  ---------------- -------------------------------------
  Name             Description
  ApplyBaseStyle   Apply base style for current style.
  Clone            Clones itself.
  ---------------- -------------------------------------
:::

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Accessing Styles](ms-xhelp:///?Id=e8454723-67b5-4419-b378-67f478bfeca0){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Character Styles and Formats](ms-xhelp:///?Id=94dfb696-b7a6-488a-b758-d977737f9588){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Paragraph Styles](ms-xhelp:///?Id=5cae42e5-3458-4608-9b2c-653a75175b48){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Paragraph Formats](ms-xhelp:///?Id=044bea7a-9921-4e67-b528-6ded19bff386){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Lists](ms-xhelp:///?Id=821554c3-c2c1-43bb-ba40-689c0d9aa4fb){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Text Box Format](ms-xhelp:///?Id=b0a82974-88d0-4521-8612-b27354a25daf){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Importing XHTML](ms-xhelp:///?Id=08c457a7-2a6e-41d6-9964-11d2e8aeda87){style="TEXT-DECORATION: none"}
:::::::

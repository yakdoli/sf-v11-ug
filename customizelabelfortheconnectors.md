::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=4d97c0ec-3280-443d-902d-427b26c85a63){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=0eb13979-5bb8-4da0-91b8-6f938dd6abb9){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=04839cdf-94fc-4d24-9f6b-119fdbd7bbfb){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Line Connector](ms-xhelp:///?Id=c7ae1b55-3b10-4b74-889d-cf088e9eca27){.d2h_breadcrumbsNormal}
:::

### Customize Label for the Connectors {#customize-label-for-the-connectors style="tab-stops: 0pt"}

The labels of the connectors are customized by the following properties, i.e. the user can specify the font color of the label. Also, several other customization properties have been added for the labels. These are tabulated below:

Properties

  Property           Description                                                                            Type of the Property   Value it Accepts   Any Other Dependencies/Sub-Properties Associated
  ------------------ -------------------------------------------------------------------------------------- ---------------------- ------------------ --------------------------------------------------
  LabelFontColor     Gets or sets the color of the label. The default value is black.                       Server side            String             No
  LabelFontFamily    Gets or sets the font family of the label. The default value is Arial.                 Server side            FontFamily         No
  LabelFontSize      Gets or sets the font size of the label. The default value is 11.                      Server side            Double             No
  LabelBackground    Gets or sets the background of the label. The default value is Transparent.            Server side            string             No (This is not supported in SVG Mode)
  LabelBorderColor   Gets or sets the border color of the label. The default value is Transparent.          Server side            String             No (This is not supported in SVG Mode)
  LabelBorderWidth   Gets or sets the border width of the label. The default value is Transparent.          Server side            Int                No (This is not supported in SVG Mode)
  LabelWidth         Gets or sets the width of the label. The default value is the node's width.            Server side            Double             No (This is not supported in SVG Mode)
  LabelHeight        Gets or sets the height of the label. The default value is the  node's label height.   Server side            Double             No (This is not supported in SVG Mode)

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

The following code snippet illustrates the implementation of the properties mentioned in the table above.

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Using Builder](ms-xhelp:///?Id=be4015a2-6e31-48f4-9faf-eb4c1df9a790){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Using Properties model](ms-xhelp:///?Id=74dcf35c-1bde-47a1-ae64-87d41cc69559){style="TEXT-DECORATION: none"}
::::

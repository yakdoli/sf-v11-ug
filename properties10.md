::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=3bbc8d2e-a9ed-455d-85ce-4f20c14f6bac){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=64134642-ef72-46f0-aa2a-27fa78e7a1a4){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Controls and Components](ms-xhelp:///?Id=f0af2fff-6f00-4ca4-85a6-54e41ac5dc96){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Toggle-Button Control](ms-xhelp:///?Id=3bbc8d2e-a9ed-455d-85ce-4f20c14f6bac){.d2h_breadcrumbsNormal}
:::

### Properties {#properties style="tab-stops: 0pt"}

The following table illustrates the properties of the Toggle-Button control.

 

+---------------+-----------------------------------------------------------------------+----------------------+----------------+---------------------------------------------------------------------+-------------+
| Name          | Description                                                           | Type of the property | Data Type      | Value it accepts                                                    | Dependency  |
+---------------+-----------------------------------------------------------------------+----------------------+----------------+---------------------------------------------------------------------+-------------+
| ContentType   | Specifies the field that provides the content of the button.          | Server side          | ContentTypes   | [ContentTypes]{style="COLOR: #2b91af"}.TextOnly                     | NA          |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [ContentTypes]{style="COLOR: #2b91af"}.ImageOnly                    |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [ContentTypes]{style="COLOR: #2b91af"}.TextAndImage                 |             |
+---------------+-----------------------------------------------------------------------+----------------------+----------------+---------------------------------------------------------------------+-------------+
| ImagePosition | Specifies the field that provides the position of the button's image. | Server side          | ImagePositions | [ImagePositions]{style="COLOR: #2b91af"}.Left                       | ContentType |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [ImagePositions]{style="COLOR: #2b91af"}.Right                      |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [ImagePositions]{style="COLOR: #2b91af"}.Top                        |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [ImagePositions]{style="COLOR: #2b91af"}.Bottom                     |             |
+---------------+-----------------------------------------------------------------------+----------------------+----------------+---------------------------------------------------------------------+-------------+
| Skin          | Specifies the field that provides the appearance of the button.       | Server side          | Enum           | [Skins.Almond]{style="COLOR: #2b91af"}                              | NA          |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [Skins.Blend]{style="COLOR: #2b91af"}                               |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [Skins.Blueberry]{style="COLOR: #2b91af"}                           |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [Skins.Marble]{style="COLOR: #2b91af"}                              |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [Skins.Midnight]{style="COLOR: #2b91af"}                            |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [Skins.Monochrome]{style="COLOR: #2b91af"}                          |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [Skins.Office2007Black]{style="COLOR: #2b91af"}                     |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [Skins.Office2007Blue]{style="COLOR: #2b91af"}                      |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [Skins.Office2007Silver]{style="COLOR: #2b91af"}                    |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [Skins.Olive]{style="COLOR: #2b91af"}                               |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [Skins.Sandune]{style="COLOR: #2b91af"}                             |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [Skins.Turquoise]{style="COLOR: #2b91af"}                           |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [Skins.Vista]{style="COLOR: #2b91af"}                               |             |
|               |                                                                       |                      |                |                                                                     |             |
|               |                                                                       |                      |                | [Skins.VS2010]{style="COLOR: #2b91af"}                              |             |
+---------------+-----------------------------------------------------------------------+----------------------+----------------+---------------------------------------------------------------------+-------------+
| Height        | Defines the height of the button.                                     | Server side          | Unit           | [Unit.]{style="COLOR: #2b91af"}Pixel(100)[]{style="COLOR: #2b91af"} | NA          |
+---------------+-----------------------------------------------------------------------+----------------------+----------------+---------------------------------------------------------------------+-------------+
| Width         | Defines the width of the button.                                      | Server side          | Unit           | [Unit.]{style="COLOR: #2b91af"}Pixel(100)[]{style="COLOR: #2b91af"} | NA          |
+---------------+-----------------------------------------------------------------------+----------------------+----------------+---------------------------------------------------------------------+-------------+
| IsChecked     | Defines the checked state of the button.                              | Server side          | Bool           | [True/false]{style="COLOR: #2b91af"}                                | NA          |
+---------------+-----------------------------------------------------------------------+----------------------+----------------+---------------------------------------------------------------------+-------------+

 

[]{#related-topics}
::::

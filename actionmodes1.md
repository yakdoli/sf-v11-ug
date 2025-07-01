::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=45772664-2e19-4523-9f80-67c80a02ab5e){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=a923be25-d7f4-4073-8b16-a28900e13079){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Mobile MVC](ms-xhelp:///?Id=74df42e3-5434-4590-9be6-3ae2f911cbbc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=45772664-2e19-4523-9f80-67c80a02ab5e){.d2h_breadcrumbsNormal}
:::

## ActionModes {#actionmodes style="tab-stops: 0pt"}

The Grid control handles data presentation operations like paging and sorting, or you can perform those operations. But this mode of action for the Grid control is decided using the **ActionMode** property whose options are described in the following table.

Essential Grid supports two kinds of **ActionModes**.

Properties

::: {align="center"}
+--------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-------------------------------+
| **Property** | **Description**                                                                                                                                                                     | **Type of Property** | **Value it Accepts**                           | **Dependency**                |
+--------------+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+----------------------+------------------------------------------------+-------------------------------+
| ActionMode   | Used to set the action mode of the control.                                                                                                                                         | enum                 | [MobActionMode]{style="COLOR: #2b91af"}.Server |  NA[]{style="COLOR: #2b91af"} |
|              |                                                                                                                                                                                     |                      |                                                |                               |
|              | Server---All the operations like sorting and grouping are handled by Essential Grid itself (by default).                                                                            |                      |                                                |                               |
|              |                                                                                                                                                                                     |                      |                                                |                               |
|              | JSON (JavaScript Object Notation)---you can perform all the grid operations. The performance of these operations in this mode will be much faster when compared to the server mode. |                      | [MobActionMode]{style="COLOR: #2b91af"}.JSON   |                               |
+==============+=====================================================================================================================================================================================+======================+================================================+===============================+
:::

 

Methods

::: {align="center"}
  **Method**         **Parameters**   **Return type**       **Descriptions**
  ------------------ ---------------- --------------------- -----------------------------------------
  ActionMode(enum)   actionMode       MobGridBuilder\<T\>   Used to set the action mode to control.
:::

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Server Mode](ms-xhelp:///?Id=a923be25-d7f4-4073-8b16-a28900e13079){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}JSON Mode](ms-xhelp:///?Id=9f772443-b0fd-4c0e-aa10-302e654e4205){style="TEXT-DECORATION: none"}
::::::

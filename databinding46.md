::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Databinding {#databinding style="tab-stops: 0pt"}

This feature allows you to bind the data source to the listbox control.

Properties

 

+-------------+---------------------------------+----------------------+----------------------------------------------------------------------------------------------------+-------------+
| Name        | Description                     | Type of the property | Value it accepts                                                                                   | Dependency  |
+-------------+---------------------------------+----------------------+----------------------------------------------------------------------------------------------------+-------------+
| ActionMode  | Used to specify the Action mode | enum                 | [ActionMode]{style="COLOR: #2b91af"}.Server,                                                       | NA          |
|             |                                 |                      |                                                                                                    |             |
|             |                                 |                      | [ActionMode]{style="COLOR: #2b91af"}.Json,                                                         |             |
|             |                                 |                      |                                                                                                    |             |
|             |                                 |                      | [ActionMode]{style="COLOR: #2b91af"}.[WebService]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |             |
|             |                                 |                      |                                                                                                    |             |
|             |                                 |                      |                                                                                                    |             |
+-------------+---------------------------------+----------------------+----------------------------------------------------------------------------------------------------+-------------+

 

Methods

  -------------------- ------------------------------ -------------------------------- ----------------------------- -----------------
  Name of the method   Parameters of the method       Return type                      Descriptions                  Reference links
  BindDataSource       Action\<ListBoxItemBuilder\>   ListBoxItemBuilderBuilder\<T\>   Used to bind the datasource    NA
  -------------------- ------------------------------ -------------------------------- ----------------------------- -----------------

 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Server Mode](ms-xhelp:///?Id=5b27bd1c-a824-4de2-b7dc-4a0253797319){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}JSON Mode](ms-xhelp:///?Id=38ba4015-9b53-47f1-96ad-61a7a73891f4){style="TEXT-DECORATION: none"}
:::

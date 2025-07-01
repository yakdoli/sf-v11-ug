::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Using Builder {#using-builder style="tab-stops: 0pt"}

The following steps explain how you can bind the data source through the webservice.

1.   In **View**, invoke the Listbox Helper with the control ID as the first argument and set the WebService URL for the webservice binding.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: Column mapping can be  done as in the JSON mode.
:::

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [    ]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} [\<%]{style="FONT-FAMILY: Consolas; BACKGROUND: yellow; FONT-SIZE: 9.5pt"} [ Html.MobSyncfusion().ListBox([\"lbDatabinding\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"} |
|                                                                                                                                                                                                                                                                  |
| **[              .ActionMode([ActionMode]{style="COLOR: #2b91af"}.WebService)]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                |
|                                                                                                                                                                                                                                                                  |
| **[              .WebServiceUrl([\"/Models/Orders.svc/RenderData\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                 |
|                                                                                                                                                                                                                                                                  |
| [              .Items(item =\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                  |
| [              {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                  |
| [                  **item.Add()**]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                  |
| **[                      .Text([\"\${Text}\"]{style="COLOR: #a31515"}).ImageUrl([\"\${ImageUrl}\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                  |
|                                                                                                                                                                                                                                                                  |
| **[                      .Children([\"Children\"]{style="COLOR: #a31515"}, ch =\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                            |
|                                                                                                                                                                                                                                                                  |
| **[                      {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                  |
| **[                          ch.Add().Text([\"\${Text}\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                           |
|                                                                                                                                                                                                                                                                  |
| **[                              .Children([\"Street\"]{style="COLOR: #a31515"}, ch1 =\>]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                     |
|                                                                                                                                                                                                                                                                  |
| **[                                {]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                  |
| **[                                    ch1.Add().Text([\"\${Text}\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                               |
|                                                                                                                                                                                                                                                                  |
| **[                                 });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                  |
| **[                       });]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                  |
| [               })]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                  |
| [               .Render();]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                  |
| [    [%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: Consolas; FONT-SIZE: 9.5pt"}                                                                                                                                                                                                              |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[                       ]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[Razor\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                       |
|                                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                           |
| [    ]{style="FONT-FAMILY: 'Courier New'"} [\@{]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"} [ Html.MobSyncfusion().ListBox([\"lbDatabinding\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                           |
| **[              .ActionMode([ActionMode]{style="COLOR: #2b91af"}.WebService)]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                      |
|                                                                                                                                                                                                                           |
| **[              .WebServiceUrl([\"/Models/Orders.svc/RenderData\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                                       |
|                                                                                                                                                                                                                           |
| [              .Items(item =\>]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                                           |
| [              {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                                           |
| [                  **item.Add()**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                           |
| **[                      .Text([\"\${Text}\"]{style="COLOR: #a31515"}).ImageUrl([\"\${ImageUrl}\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                        |
|                                                                                                                                                                                                                           |
| **[                      .Children([\"Children\"]{style="COLOR: #a31515"}, ch =\>]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                  |
|                                                                                                                                                                                                                           |
| **[                      {]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                         |
|                                                                                                                                                                                                                           |
| **[                          ch.Add().Text([\"\${Text}\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                 |
|                                                                                                                                                                                                                           |
| **[                              .Children([\"Street\"]{style="COLOR: #a31515"}, ch1 =\>]{style="FONT-FAMILY: 'Courier New'"}**                                                                                           |
|                                                                                                                                                                                                                           |
| **[                                {]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                               |
|                                                                                                                                                                                                                           |
| **[                                    ch1.Add().Text([\"\${Text}\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}**                                                                                     |
|                                                                                                                                                                                                                           |
| **[                                 });]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                            |
|                                                                                                                                                                                                                           |
| **[                       });]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                      |
|                                                                                                                                                                                                                           |
| [               })]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                   |
|                                                                                                                                                                                                                           |
| [               .Render();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                           |
|                                                                                                                                                                                                                           |
| [}]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}                                                                                                                                                               |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

2.   Create a web method **(RenderData)** for binding the listbox to the webservice using the object datasource. The webservice method should return the ListBoxWebService object.

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [    ]{style="FONT-FAMILY: 'Courier New'"} []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                   |
| **[\[Orders.svc\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                          |
|                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                        |
|                                                                                                                                                                                                   |
| [\[[OperationContract]{style="COLOR: #2b91af"}\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                             |
|                                                                                                                                                                                                   |
| [        [public]{style="COLOR: blue"}[ListBoxWebService]{style="COLOR: #2b91af"} RenderData([ListBoxParams]{style="COLOR: #2b91af"} webParams)]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                   |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                   |
| [            [ListBoxWebService]{style="COLOR: #2b91af"} sdf = [new]{style="COLOR: blue"}[ListBoxWebService]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                   |
| [            [List]{style="COLOR: #2b91af"}\<[Countries]{style="COLOR: #2b91af"}\> \_Datasrc = [this]{style="COLOR: blue"}.RenderDataSource().ToList();]{style="FONT-FAMILY: 'Courier New'"}      |
|                                                                                                                                                                                                   |
| [            [IEnumerable]{style="COLOR: #2b91af"}\<[DTO]{style="COLOR: #2b91af"}\> data = [from]{style="COLOR: blue"} o [in]{style="COLOR: blue"} \_Datasrc]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| [                                    [select]{style="COLOR: blue"}[new]{style="COLOR: blue"}[DTO]{style="COLOR: #2b91af"}]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                                   |
| [                                    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                   |
| [                                        Text = o.Text,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                   |
| [                                        Children = o.Children]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                   |
| [                                    };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| [            [return]{style="COLOR: blue"} data.ListBoxWebServiceAction\<[DTO]{style="COLOR: #2b91af"}\>();]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                                   |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}**  

3.   Build and run the application.

 

 

[ ![Description: C:\\Users\\krishnarajd\\Desktop\\ldb.png](ImagesExt/image103_140.jpg){border="0"} ]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

Figure 67: Listbox - Jsonbinding[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

 

[]{#related-topics}
::::

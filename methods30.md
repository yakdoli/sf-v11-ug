::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Methods {#methods style="tab-stops: 0pt"}

Table 2: Methods Table

::: {align="center"}
+-----------------+-----------------------------------------------------------------------+----------------------------------------+-------------+-------------+
| Method          | Description                                                           | Parameters                             | Type        | Return Type |
+-----------------+-----------------------------------------------------------------------+----------------------------------------+-------------+-------------+
| Load            | This method is used to load PDF to the viewer                         | Overloads:                             | N/A         | Void        |
|                 |                                                                       |                                        |             |             |
|                 |                                                                       | 1\) (string filePath)                  |             |             |
|                 |                                                                       |                                        |             |             |
|                 |                                                                       | 2\) (string filePath, string password) |             |             |
|                 |                                                                       |                                        |             |             |
|                 |                                                                       | 3\) (PdfLoadedDocument doc)            |             |             |
|                 |                                                                       |                                        |             |             |
|                 |                                                                       | 4\) (Stream file)                      |             |             |
+-----------------+-----------------------------------------------------------------------+----------------------------------------+-------------+-------------+
| Unload          | Unloads the loaded PDF                                                | \-                                     | N/A         | Void        |
+-----------------+-----------------------------------------------------------------------+----------------------------------------+-------------+-------------+
| Dispose         | Unloads the document and releases the resources used by the component | \-                                     | N/A         | Void        |
+-----------------+-----------------------------------------------------------------------+----------------------------------------+-------------+-------------+
| ExportAsImage   | Converts the page to raster image                                     | Overloads:                             | N/A         | Bitmap      |
|                 |                                                                       |                                        |             |             |
|                 |                                                                       | 1\) (int pageIndex)                    |             |             |
|                 |                                                                       |                                        |             |             |
|                 |                                                                       | 2\) (int startIndex, int endIndex)     |             |             |
+-----------------+-----------------------------------------------------------------------+----------------------------------------+-------------+-------------+
| GoToPageAtIndex | Navigates to the mentioned page                                       | 1\) (int index)                        | N/A         | Void        |
+=================+=======================================================================+========================================+=============+=============+
:::

 

[]{#related-topics}
::::

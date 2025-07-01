::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### High Frequency Updates {#high-frequency-updates style="tab-stops: 0pt"}

This section illustrates an example that let you know how to handle high frequency updates using grid while keeping the CPU usage at a minimum level. It uses a simple data source with few double-valued columns. It changes random cell values and also does record insertions and removals, using a timer event.

 

The following code illustrates changing of random cell values:

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} timer_Tick([object]{style="COLOR: blue"} sender, [EventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                                                |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                |
| [\...\...\...\...\...\.....]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                                                |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([int]{style="COLOR: blue"} i = 0; i \< numberOfChangesEachTimer; i++)]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                                |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                |
| [                [int]{style="COLOR: blue"} recNum = rand.Next(table.Rows.Count - 1);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                                |
| [                [int]{style="COLOR: blue"} col = rand.Next(table.Columns.Count - 1) + 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                |
| [                [DataRow]{style="COLOR: #2b91af"} drow = table.Rows\[recNum\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                                                                                                |
| [                [if]{style="COLOR: blue"} (drow.RowState != [DataRowState]{style="COLOR: #2b91af"}.Deleted && !(drow\[col\] [is]{style="COLOR: blue"} [DBNull]{style="COLOR: #2b91af"}))]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                |
| [                {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                |
| [                    [double]{style="COLOR: blue"} value = ([int]{style="COLOR: blue"})([Convert]{style="COLOR: #2b91af"}.ToDouble(drow\[col\]) \* (rand.Next(50) / 100.0f + 0.8));]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                                                |
| [                    [//Console.WriteLine(\"{0}, {1}: {2}\", recNum, col, value);]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                                                                |
| [                    drow\[col\] = value;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                 |
|                                                                                                                                                                                                                                |
| [                }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                |
| [           }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

The following code illustrates record insertions and removals:

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                           |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} timer_Tick([object]{style="COLOR: blue"} sender, [EventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                      |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                      |
| [\...\...\...\...\...\.....]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                      |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (toggleInsertRemove \> 0 && (timerCount % insertRemoveModulus) == 0)]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                                      |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                                      |
| [                icount = ++icount % (toggleInsertRemove \* 2);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                      |
| [                shouldInsert = icount \< toggleInsertRemove;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [                [if]{style="COLOR: blue"} (shouldInsert)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                      |
| [                {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                      |
| [                    [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} ri = 0; ri \< insertRemoveCount; ri++)]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                                      |
| [                    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                      |
| [                        [int]{style="COLOR: blue"} recNum = rand.Next([Math]{style="COLOR: #2b91af"}.Min(30, table.Rows.Count));]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [                        [double]{style="COLOR: blue"} next = rand.Next(100);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [                        [object]{style="COLOR: blue"}\[\] values = [new]{style="COLOR: blue"} [object]{style="COLOR: blue"}\[table.Columns.Count\];]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                      |
| [                        values\[0\] = [\"H\"]{style="COLOR: #a31515"} + ti.ToString([\"00000\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                                      |
| [                        [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} n = 1; n \< table.Columns.Count; n++)]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                      |
| [                            values\[n\] = next + n;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [                        [DataRow]{style="COLOR: #2b91af"} drow = table.NewRow();]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                      |
| [                        drow.ItemArray = values;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                      |
| [                        table.Rows.InsertAt(drow, recNum);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [                        ti++;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                      |
| [                    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                      |
| [                }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                      |
| [                [else]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                      |
| [                {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                      |
| [                    [for]{style="COLOR: blue"} ([int]{style="COLOR: blue"} ri = 0; ri \< insertRemoveCount; ri++)]{style="FONT-FAMILY: 'Courier New'"}                                                              |
|                                                                                                                                                                                                                      |
| [                    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                      |
| [                        [int]{style="COLOR: blue"} recNum = 5; [//rand.Next(m_set.Count - 1);]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                      |
| [                        [int]{style="COLOR: blue"} rowNum = recNum + 1;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [                        [// Underlying data structure (this could be a data table or whatever structure]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                      |
| [                        [// you use behind a virtual grid).]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                 |
|                                                                                                                                                                                                                      |
| [                        [if]{style="COLOR: blue"} (table.Rows.Count \> 10)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                      |
| [                            table.Rows.RemoveAt(recNum);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                      |
| [                    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                          |
|                                                                                                                                                                                                                      |
| [                }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                      |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                                      |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image28_3.jpg){border="0"}Note: For complete code of this example, refer the following browser sample:
:::

 

\...\\My Documents\\Syncfusion\\EssentialStudio\\\<Version Number\>\\WPF\\Grid.WPF\\ Samples\\3.5\\WindowsSamples\\Grid Data Control -- Advanced\\Trader Grid Test Demo

 

 

[]{#related-topics}
::::

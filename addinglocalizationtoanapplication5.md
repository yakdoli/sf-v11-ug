::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=a3434b05-f84a-42fa-aeb1-613383549729){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=2fb753aa-21fe-4994-b90a-eaca7912db7e){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
### Adding Localization to an Application {#adding-localization-to-an-application style="tab-stops: 0pt"}

Localization can be achieved by following the steps given below:

[1.    ]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}OlapGrid localization is fully based on the resource (.resx) file generation. Prepare a translated version of the strings tabulated below and update it in the resource (.resx) file.

 

::: {align="center"}
  ----------------------------------- -------------------------------
  **Localization Key**                **Strings to be Localized**
  Dialog_AddNew                       Add New
  Dialog_BackColor                    Back Color
  Dialog_Between                      Between
  Dialog_BorderColor                  Border Color
  Dialog_BorderStyle                  Border Style
  Dialog_BorderWidth                  Border Width
  Dialog_Cancel                       Cancel
  Dialog_Condition                    Condition
  Dialog_ConditionalFormatting        Conditional Formatting
  Dialog_ConditionType                Condition Type
  Dialog_EditCondition                Edit Condition
  Dialog_Equal                        Equal
  Dialog_Font                         Font
  Dialog_FontSize                     Font Size
  Dialog_Format                       Format
  Dialog_Greater                      Greater
  Dialog_Lesser                       Lesser
  Dialog_Measure                      Measure
  Dialog_NotBetween                   Not Between
  Dialog_NotEqual                     Not Equal
  Dialog_Ok                           OK
  Dialog_Operand                      Operand
  Dialog_Padding                      Padding
  Dialog_Remove                       Remove
  Dialog_Reset                        Reset
  Dialog_Style                        Style
  ToolTip_ApplyFormatting             Apply Formatting
  ToolTip_ClearFormatting             Clear Formatting
  ToolTip_Column                      Column
  ToolTip_ExcelLikeLayout             Excel Like Layout
  ToolTip_NormalLayout                Normal Layout
  ToolTip_NormalTopSummaryLayout      Normal Top Summary Layout
  ToolTip_NoSummariesLayout           No Summaries Layout
  ToolTip_Row                         Row
  ToolTip_ShowHideHeaderCellToolTip   Show/Hide Header Cell ToolTip
  ToolTip_ShowHideValueCellToolTip    Show/Hide Value Cell ToolTip
  ToolTip_Value                       Value
  ----------------------------------- -------------------------------
:::

 

[2.    ]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}Name the resource file as **OlapGrid.*\<locale string representation\>*.resx**. For example, French culture can be written as **OlapGrid.fr-FR.resx** and place the resource file in the **App_GlobalResources** folder of the Web site.

[3.    ]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}Change the culture setting of the Web page through OlapDataManger by using the following code:

**** 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                       |
|                                                                                                                                                                                                        |
| [var]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ olapDataManager = [new]{style="COLOR: blue"} [OlapDataManager]{style="COLOR: #2b91af"}(connectionString);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                        |
| [olapDataManager.Culture = [new]{style="COLOR: blue"} System.Globalization.[CultureInfo]{style="COLOR: #2b91af"}([\"fr-FR\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                                                                                                        |
| [olapDataManager.OverrideDefaultFormatStrings = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.OlapGrid1.OlapDataManager = olapDataManager;]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.OlapGrid1.DataBind();]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 10.5pt"}                                |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                      |
|                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ olapDataManager = [New ]{style="COLOR: blue"}[OlapDataManager]{style="COLOR: #2b91af"}(connectionString)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                       |
| [olapDataManager.Culture = [New]{style="COLOR: blue"} System.Globalization.[CultureInfo]{style="COLOR: #2b91af"}([\"fr-FR\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                                                                                                       |
| [olapDataManager.OverrideDefaultFormatStrings = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                                       |
| [Me.OlapGrid1.OlapDataManager = olapDataManager]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                       |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.OlapGrid1.DataBind()]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: Consolas; FONT-SIZE: 10.5pt"}                                  |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::

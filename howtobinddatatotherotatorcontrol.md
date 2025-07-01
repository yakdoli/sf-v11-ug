::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=d59aa359-d359-4cda-ad16-3c118a09c4e5){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c51a8919-d734-4742-8ac6-53542d96decc){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Tools]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Controls and Components](ms-xhelp:///?Id=f0af2fff-6f00-4ca4-85a6-54e41ac5dc96){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Rotator Control](ms-xhelp:///?Id=b69813ba-6bea-49a4-9aca-e67b01ab394a){.d2h_breadcrumbsNormal}
:::

### How to bind data to the Rotator control? {#how-to-bind-data-to-the-rotator-control style="tab-stops: 0pt"}

The Rotator provides extensive data binding support to populate Rotator items so that the columns of a table can be mapped to the Rotator properties, namely Text and ImageUrl.

 The Data Binding feature helps users to plug-in data from a DataTable or DataSet to the Rotator.

[]{style="COLOR: black"} 

Enabling Data Binding in Rotator control

[Data Binding in the Rotator can be customized by using two ways, namely:]{style="COLOR: black"}

[·      ]{style="FONT-FAMILY: Symbol"}RotatorBuilder

[·      ]{style="FONT-FAMILY: Symbol"}RotatorModel

[]{style="COLOR: black"} 

Using RotatorBuilder

[To customize Data Binding in the Rotator by using RotatorBuilder:]{style="COLOR: black"}

1.   In the[ ]{style="COLOR: black"}**Controller**, pass the data to the[ ]{style="COLOR: black"}**View**[ ]{style="COLOR: black"}page.

[]{style="COLOR: black"} 

+------------------------------------------------------------------------------------------------------------------------------------------------+
| **[ \[Controller\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                      |
|                                                                                                                                                |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                |
| [            [Northwind]{style="COLOR: #2b91af"} data = SqlCE;]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                |
| [            [// Passing the data to the View.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                |
| [            [return]{style="COLOR: blue"} View(data.RotatorData);]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                |
| [  }  ]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-SIZE: 12pt"}                                                                         |
+------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"}[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 12pt"} 

[2.   ]{style="COLOR: black"}Create a Strongly Typed View.[]{style="COLOR: black"}

[3.   In the]{style="COLOR: black"}[ ]{style="COLOR: black"}**[View]{style="COLOR: black"}**[, invoke the]{style="COLOR: black"}[ ]{style="COLOR: black"}**[Rotator]{style="COLOR: black"}**[ ]{style="COLOR: black"}[helper with the control ID.]{style="COLOR: black"}

[4.   Set the]{style="COLOR: black"}[ ]{style="COLOR: black"}**[DataSource]{style="COLOR: black"}[ ]{style="COLOR: black"}**[and]{style="COLOR: black"}**[ ]{style="COLOR: black"}[BindTo]{style="COLOR: black"}[ ]{style="COLOR: black"}**[methods.]{style="COLOR: black"}

[]{style="COLOR: black"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                        |
|                                                                                                                                                                                                                           |
| [\<%]{style="FONT-FAMILY: 'Courier New'; BACKGROUND: yellow"}[=]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Html.Syncfusion().Rotator([\"myRotator\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                           |
| [.**DataSource(Model)**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                                           |
| **[.BindTo(bind=\>]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                 |
|                                                                                                                                                                                                                           |
| **[bind.Text([\"Text\"]{style="COLOR: #a31515"})    ]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                               |
|                                                                                                                                                                                                                           |
| **[                  .ImageUrl([\"ImagePath\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}**[)[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"}                                    |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

5.   Build and run the application.

[]{style="COLOR: black"} 

[]{style="COLOR: black"} 

Using RotatorModel

[To customize Data Binding in the Rotator by using RotatorModel:]{style="COLOR: black"}

1.   In the[ ]{style="COLOR: black"}**Controller**, create an object for the[ ]{style="COLOR: black"}**RotatorModel**[ ]{style="COLOR: black"}class.

2.   Set the[ ]{style="COLOR: black"}**DataSource**[ ]{style="COLOR: black"}and[ ]{style="COLOR: black"}**BindTo**[ ]{style="COLOR: black"}properties.

3.   Pass the[ ]{style="COLOR: black"}**RotatorModel**[ ]{style="COLOR: black"}class to the[ ]{style="COLOR: black"}**ViewData**.

[]{style="COLOR: black"} 

::: {align="center"}
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [      **\[Controller\]**]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [ActionResult]{style="COLOR: #2b91af"} Index()]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
|                                                                                                                                                                                |
| [            [Northwind]{style="COLOR: #2b91af"} context = SqlCE;]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                |
| [            [RotatorFields]{style="COLOR: #2b91af"} rotatorFields = [new]{style="COLOR: blue"} [RotatorFields]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                |
| [            {                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                |
| [                Text = [\"Text\"]{style="COLOR: #a31515"},]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                |
| [                ImageUrl = [\"ImageUrl\"]{style="COLOR: #a31515"}             ]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                |
| [            };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                |
| [            [RotatorModel]{style="COLOR: #2b91af"} rotatorModel = [new]{style="COLOR: blue"} [RotatorModel]{style="COLOR: #2b91af"}()]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                |
| [                DataSource = context.RotatorData.ToList(),]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                |
| [                BindTo = rotatorFields,]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                |
| [            };]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                |
| [            ViewData\[[\"myRotatorModel\"]{style="COLOR: #a31515"}\] = rotatorModel;]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                |
| [            [return]{style="COLOR: blue"} View();]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
|                                                                                                                                                                                |
| [  }  ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="COLOR: black"}[]{style="FONT-FAMILY: 'Times New Roman','serif'; COLOR: black; FONT-SIZE: 12pt"} 

4.   In the[ ]{style="COLOR: black"}**View**, invoke the[ ]{style="COLOR: black"}**Rotator**[ ]{style="COLOR: black"}helper with the control ID.

5.   From the[ ]{style="COLOR: black"}**ViewData**, assign the[ ]{style="COLOR: black"}**RotatorModel[ ]{style="COLOR: black"}**class to the[ ]{style="COLOR: black"}**Rotator**[ ]{style="COLOR: black"}helper.

[]{style="COLOR: black"} 

::: {align="center"}
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[ASPX\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                              |
| [        [\<%]{style="BACKGROUND: yellow"}[=]{style="COLOR: blue"}Html.Syncfusion().Rotator([\"myRotator\"]{style="COLOR: #a31515"}, ([RotatorModel]{style="COLOR: #2b91af"})ViewData\[[\"myRotatorModel\"]{style="COLOR: #a31515"}\])[%\>]{style="BACKGROUND: yellow"}]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="COLOR: black"} 

6.   Build and run the application.

[]{style="COLOR: black"} 

[]{style="COLOR: black"} 

Properties

[The properties used for data binding in the Rotator are described in the following tabulation:* *]{style="COLOR: black"}

[]{style="FONT-STYLE: normal; COLOR: black"}[]{style="COLOR: black"} 

::: {align="center"}
  ------------ --------------------------------------------------------------------------------------------- ------------- --------------- -----------------
  Name         Description                                                                                   Type          Data Type       Reference links
  DataSource   Gets or sets the data source, which is used to populate the Rotator with the Rotator items.   Server-side   IEnumerable     Not applicable
  BindTo       Maps the Rotator fields to their respective columns from the data source.                     Server-side   RotatorFields   Not applicable
  Text         Gets or sets the text column name.                                                            Server-side   string          Not applicable
  ImageUrl     Gets or sets the image path column name.                                                      Server-side   string          Not applicable
  ------------ --------------------------------------------------------------------------------------------- ------------- --------------- -----------------
:::

 

[]{#related-topics}
:::::::

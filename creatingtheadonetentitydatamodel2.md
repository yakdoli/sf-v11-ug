::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=763897ae-b83d-4e24-b6d8-3c6d3660f55c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=75c95c92-5a38-4ad9-8507-5147b495fcb0){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How to](ms-xhelp:///?Id=0d8a7383-ca49-43db-8609-dca7963c87ab){.d2h_breadcrumbsNormal}
:::

## Creating the ADO.NET Entity Data Model {#creating-the-ado.net-entity-data-model style="tab-stops: 0pt"}

In order to use the Entity Framework, you need to create an Entity Data Model. You can take advantage of the Visual Studio *Entity Data Model Wizard* to generate an Entity Data Model from a database automatically.

To do so, follow these six steps:

1.   Right-click the **Models** folder in the **Solution Explorer** window and select the menu option **Add, New Item**.

2.   In the **Add New Item** dialog, select the **Data** category (see Figure 340).

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

![](ImagesExt/image58_298.jpg){border="0"}

[]{#_Ref266195843}[Figure]{#_Ref266195856} 340: Creating a New Entity Data Model

 

3.   Select the **ADO.NET Entity Data Model** template, give the Entity Data Model the name **PubsDBModel.edmx**, and click the **Add** button. Clicking the **Add** button launches the Data Model Wizard.

4.   In the **Choose Model Contents** step, choose the **Generate from database** option and click the **Next** button (see Figure 341).

 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

![](ImagesExt/image58_299.jpg){border="0"}

[Figure]{#_Ref266195902} 341: Choosing Model Contents

 

5.   In the **Choose Your Data Connection** step, select the **Pubs.mdf** database connection, enter the entities connection settings name **PubsEntities**, and click the **Next** button (see Figure 342).

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 12pt"} 

![](ImagesExt/image58_300.jpg){border="0"}

[Figure]{#_Ref266195926} 342: Choose Your Data Connection

 

6.   In the **Choose Your Database Objects** step, select all the database tables and click the **Finish** button (see Figure 343).

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

![](ImagesExt/image58_301.jpg){border="0"}

[Figure]{#_Ref266195991} 343: Choose Your Database Objects

 

When you are finished, you will be able to find the following image.

 

 

![](ImagesExt/image58_302.jpg){border="0"}

Figure 344: PubsDbEntity Model

 

[]{#related-topics}
::::

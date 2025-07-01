::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=6746596b-faa6-4d9f-8a3a-03a11aa084dd){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=bda76730-fc81-4b1e-9551-b76ee30f0da1){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Diagram]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[How do I](ms-xhelp:///?Id=d217e351-1033-4004-81d7-d400a51e195d){.d2h_breadcrumbsNormal}
:::

## Create the ADO.NET Entity Data Model {#create-the-ado.net-entity-data-model style="tab-stops: 0pt"}

In order to use the Entity Framework, you need to create an Entity Data Model. You can take advantage of the Visual Studio *Entity Data Model Wizard* to generate an Entity Data Model from a database automatically.

 

To create the ADO.NET Entity Data Model:

1.   Right-click the **Models** folder in the **Solution Explorer** window and select the menu option **Add New Item**.

2.   In the **Add New Item** dialog, select the **Data category** (see Figure 152).

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

![Description: C:\\Users\\maithiliyk\\Desktop\\Capture.PNG](ImagesExt/image70_149.png){border="0"}

[Figure]{#_Ref316465816} 152: Creating a New Entity Data Model

[[]{style="FONT-STYLE: normal; FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"}]{.MsoSubtleEmphasis} 

3.   Select the **ADO.NET Entity Data Model** template, give the Entity Data Model the name **DiagramDBModel.edmx**, and click **Add**. Clicking **Add** launches the **Data Model Wizard**.

4.   In the **Choose Model Contents** step, choose the **Generate from a database** option and click **Next** (see Figure 153).

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

![](ImagesExt/image70_150.png){border="0"}

[]{#_Ref316465750}[Figure]{#_Ref316465757} 153: Choose Model Contents Step

[[]{style="FONT-STYLE: normal; FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"}]{.MsoSubtleEmphasis} 

5.   In the **Choose Your Data Connection** step, select the **DiagramDB.mdf** database connection, enter the entities connection settings name **DiagramDBEntities**, and click N**ext** (see Figure 154).

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

![Description: C:\\Users\\maithiliyk\\Desktop\\Capture.PNG](ImagesExt/image70_151.png){border="0"}

[Figure]{#_Ref316466133} 154: Choose Your Data Connection[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}

[[]{style="FONT-STYLE: normal; FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"}]{.MsoSubtleEmphasis} 

6.   In the **Choose Your Database Objects** step, select the database **DiagramTable** and click **Finish** (see Figure 155).

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

![Description: C:\\Users\\maithiliyk\\Desktop\\Capture.PNG](ImagesExt/image70_152.png){border="0"}

[Figure]{#_Ref316466146} 155: Choose Your Database Objects

[[]{style="FONT-STYLE: normal; FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"}]{.MsoSubtleEmphasis} 

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'"}** 

When you have completed, you should have something like this:

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

![Description: C:\\Users\\maithiliyk\\Desktop\\Capture.PNG](ImagesExt/image70_153.png){border="0"}

Figure 156: DiagramDBEntity Model

[]{#related-topics}
::::

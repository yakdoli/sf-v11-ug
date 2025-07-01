::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=bd675b38-0d6f-4cd3-bd10-3fda4d316f9c){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c0a3e418-fc0c-4115-9643-310912a817be){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Pdf](ms-xhelp:///?Id=22756092-3da5-4797-9514-dab0617c6902){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=35112f6d-24b4-4034-acbe-0ca336e68481){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Deployment Requirements](ms-xhelp:///?Id=a3656bf5-89ea-4bd8-b655-c01ee68c2c1d){.d2h_breadcrumbsNormal}
:::

### Web Application deployment {#web-application-deployment style="tab-stops: 0pt"}

 

Web application by default is deployed in full trust mode. This section discusses the deployment in medium or partial trust scenarios.

 

Deploying in Medium Trust or Partial Trust Scenarios

 

There are two such scenarios in which Syncfusion assemblies might be deployed.

 

**Example 1**

 

If the Syncfusion Assemblies are in **GAC** (Global Assembly Cache), and the **Web Application** is running in ***medium*** trust, then the Syncfusion assemblies actually runs in full trust. Hence this scenario is fully supported and there are no additional steps necessary for deployment.

 

**Example 2**

 

Say, the Syncfusion Assemblies are present in the application\'s **bin** folder and the **Web Application** is running in ***medium*** trust, then the Syncfusion assemblies will run in medium trust.

 

Essential PDF allows to work in medium trust by using following assemblies.

 

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Core.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Compression.Base.dll

[·      ]{style="FONT-FAMILY: Symbol"}Syncfusion.Pdf.Web.dll

 

However following features are not currently supported under this scenario.

 

[·      ]{style="FONT-FAMILY: Symbol"}Digital Signature (including) PdfSignatureField and PdfLoadedSignature Fields.

[·      ]{style="FONT-FAMILY: Symbol"}PDF/A

[·      ]{style="FONT-FAMILY: Symbol"}PdfHtmlTextElement

[·      ]{style="FONT-FAMILY: Symbol"}Images

[o  ]{style="FONT-FAMILY: 'Courier New'"}Metafile

[o  ]{style="FONT-FAMILY: 'Courier New'"}RtfToImage

[·      ]{style="FONT-FAMILY: Symbol"}Fonts

[o  ]{style="FONT-FAMILY: 'Courier New'"}PdfTrueTypeFont

[·      ]{style="FONT-FAMILY: Symbol"}RTL Support

[·      ]{style="FONT-FAMILY: Symbol"}Html To PDF

 

[]{#related-topics}
::::

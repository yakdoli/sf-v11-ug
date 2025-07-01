::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=e2c289d7-8c9b-4618-b7f6-d294912e35ae){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=40fa4de2-c2cf-4de2-b478-32fe4a79387b){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Security](ms-xhelp:///?Id=e2c289d7-8c9b-4618-b7f6-d294912e35ae){.d2h_breadcrumbsNormal}
:::

### Encryption and Decryption {#encryption-and-decryption style="tab-stops: 0pt"}

 

**Encryption** is a method of protecting the Word document. It is based on a password, which converts it into a form that cannot be understood. It restricts anonymous users from accessing a document.

 

**Decryption** is the process of converting encrypted data, back into its original form so that data can be read from the document. A password for encrypting a Word document is set in Microsoft Word through the **Security** tab in the **Options** dialog box.

 

The following example illustrates how to encrypt and decrypt a Word document.

 

+----------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                             |
|                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                            |
| [//Encrypting the Word document with password.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                          |
|                                                                                                                            |
| [document.EncryptDocument(password);]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                            |
| [// Opening the encrypted Workbook.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                     |
|                                                                                                                            |
| [WordDocument document = [new]{style="COLOR: blue"} WordDocument(filename, password);]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                          |
|                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                         |
|                                                                                                                                                                                             |
| [\'Encrypting the Word document with password.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                           |
|                                                                                                                                                                                             |
| [document.EncryptDocument(password)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                             |
| [\'Opening the encrypted Workbook.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                       |
|                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ document [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument(filename, password)]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

Encryption and Decryption Samples Installation Location:

To Locate the Encrypt and Decrypt samples:

\\DocIO.WPF\\Samples\\3.5\\WindowsSamples\\Prepare\\Encrypt and Decrypt

 

Viewing Encryption and Decryption samples:

 

1.   Click **Start**\--\>**All Programs**\--\>**Syncfusion**\--\>**Essential Studio \<version number\>** \--\>**Dashboard**.

2.   Open **Reporting** edition samples. Click the drop-down button of **WPF** platform and select the **Explore samples** option.

 

For more information refer to section [[2.2 Samples and Location]{.UGHyperlink}](ms-xhelp:///?Id=7feab346-9261-489f-996b-8c455c2a2caa).

 

[]{#related-topics}
::::

::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Signing {#signing style="tab-stops: 0pt"}

 

A digital signature is an electronic signature that is used to authenticate the identity of the sender of a message or the signer of a document, and to ensure that the original content of the message or document that has been sent is unchanged.

 

Digital signatures are easily transportable, cannot be imitated by someone else, and can be automatically time-stamped. It has the ability to ensure that once the original signed message is received, the sender cannot easily repudiate it later.

 

A digital signature is used to authenticate the identity of a user and the document\'s contents. It stores information about the signer and the state of the document at the moment of signing.

 

**PdfSignature**

 

It is a base class that provides the functionality to create either visible or invisible signature on the page. To create an invisible signature, just set the signature size to zero. Later, the visibility of the signature is verified by using the Visible property. PdfSignature contains information about signer, signing location, signing reason, and so on. The following table lists the public properties of this class.

 

::: {align="center"}
  --------------------- ---------------------------------------------------------------------------------------------------------------------------------------------------
  Name                  Description
  Appearance            Gets the signature appearance.
  Bounds                Gets or sets bounds of signature.
  Certificate           Gets signing certificate.
  Certificated          Gets or sets a value indicating certificate document or not. Note: Works only with Adobe Reader 7.0.8 or higher.
  ContactInfo           Gets or sets information provided by the signer to enable a recipient to contact the signer to verify the signature; for example, a phone number.
  DocumentPermissions   Gets or sets the permission for certificated document.
  Field                 Gets pdf signature field.
  Location              Gets or sets signature location on the page.
  LocationInfo          Gets or sets the physical location of the signing.
  Reason                Gets or sets the reason of signing.
  Visible               Gets a value indicating whether the signature is visible or not.
  TimeStampServer       Sets the timestamp for the signature.
  --------------------- ---------------------------------------------------------------------------------------------------------------------------------------------------
:::

 

Features

 

[·      ]{style="FONT-FAMILY: Symbol"}**Appearance**: PdfAppearance allows you to draw and create custom appearance on the PdfSignature field.

[·      ]{style="FONT-FAMILY: Symbol"}**Certificated**: Allows document recipients to know, if any changes have been made, contrary to the author\'s intent.

[·      ]{style="FONT-FAMILY: Symbol"}**DocumentPermissions**: Allows you to set permissions on certificated document with help of the PdfCertificationFlags.

[·      ]{style="FONT-FAMILY: Symbol"}**Visible / Invisible Signature**: Allows you to create visible or invisible signatures by enabling the **Visible** property.

[·      ]{style="FONT-FAMILY: Symbol"}**TimeStampServer** : Allows you to include timestamp for the digital signature.

 

PdfCertificate

 

When you use digital signatures, each user is given a digital certificate. This certificate is actually a small file on a disk or on another device, such as a smart card. Each certificate contains a unique code, and the certificate imprints this code on each signature you create with it. This means that all of your signatures can be traced back to your certificate, and the certificate itself can be traced back to you. In this way, digital signatures identify you through a clear chain of ownership.

 

It is a class that provides the functionality to use certificates for PdfSignature from PFX files or local Certification Storage. Certificates in local storage are found by using static methods **FindByIssuer**, **FindBySubject**, **FindBySerialId**. Also, there is the **GetCertificates** static method, which allows to get an array of all certificates from the local storage.

 

**Standard Signature**

 

**PdfCertificate** class is used for getting the certificates from disk and **PdfSignature** class is used to sign a document with the given certificate. PdfSignature class has methods and properties that allow to set the signature information such as reason, location information, bounds where the signature has to be placed, and contact information.

 

The following code example illustrates this.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                             |
| [PdfCertificate]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ pdfCert = [new]{style="COLOR: blue"} [PdfCertificate]{style="COLOR: teal"}([\"PDF.pfx\"]{style="COLOR: maroon"}, [\"111\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                             |
| [// Find certificate by Issuer.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                             |
| [PdfCertificate]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ findByIssuer = [PdfCertificate]{style="COLOR: teal"}.FindByIssuer(sType, pdfCert.IssuerName);]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                             |
| [// Draw the signature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                             |
| [PdfSignature]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ signature = [new]{style="COLOR: blue"} [PdfSignature]{style="COLOR: teal"}(page, pdfCert, [\"Signature\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                                                             |
| [signature.Bounds = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}(0, 0, 250, 100);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                             |
| [// Set Signature info.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                             |
| [signature.Reason = [\"I am author of this document.\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}[ ]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                 |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfCert [As]{style="COLOR: blue"} PdfCertificate = [New]{style="COLOR: blue"} PdfCertificate([\"PDF.pfx\"]{style="COLOR: maroon"}, [\"111\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                   |
| [\' Find certificate by Issuer.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ findByIssuer [As]{style="COLOR: blue"} PdfCertificate = PdfCertificate.FindByIssuer(sType, pdfCert.IssuerName)]{style="FONT-FAMILY: 'Courier New'"}                                                       |
|                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                   |
| [\' Draw the signature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ signature [As]{style="COLOR: blue"} PdfSignature = [New]{style="COLOR: blue"} PdfSignature(page, pdfCert, [\"Signature\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                                                                   |
| [signature.Bounds = [New]{style="COLOR: blue"} RectangleF(0, 0, 250, 100)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                   |
| [\' Set Signature info.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                   |
| [signature.Reason = [\"I am author of this document.\"]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon; FONT-SIZE: 9pt"}                                                                          |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

Author Signature

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

By default, documents are signed with standard signature types. **Certificated** property of PdfSignature is used to create an author signature. When signed with this type of signature, any modification after signing will be detected, and hence does not provide support to add multiple signatures.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: This implementation of certification will only work in Acrobat 7 and higher versions.
:::

 

The following code example illustrates this.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                           |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [PdfSignature]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ signature = [new]{style="COLOR: blue"} [PdfSignature]{style="COLOR: teal"}(page, pdfCert, [\"Signature\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                          |
| [// Setting the certified signature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                  |
|                                                                                                                                                                                                                                          |
| [signature.Certificated = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                             |
|                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ signature [As]{style="COLOR: blue"} PdfSignature = [New]{style="COLOR: blue"} PdfSignature(page, pdfCert, [\"Signature\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                |
| [\' Setting the certified signature.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                        |
|                                                                                                                                                                                                                                                |
| [signature.Certificated = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}                                                                                  |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Timestamp in digital signature

 

Essential PDF supports addition of timestamp in  digital signatures. The date and time at which the document is signed can be added as a part of the signature. Timestamps are easier to verify when they're associated with a timestamp authority's trusted certificate. Including a timestamp helps to establish exactly when the document is signed and reduces the chances of an invalid signature. The timestamp can be obtained from a third-party timestamp authority or from the certificate authority that issued the digital ID.

Timestamps appear in the signature field and in the Signature Properties dialog box. If the timestamp is included, the certificate will appear in the **Date/Time** tab of the **Signature Properties** dialog box. If no timestamp is added the signature field displays the local time of the computer at the moment of signing.

To apply timestamp using Essential PDF, the **TimeStampServer** property of the **PdfSignature** class has to be used. The parameters for the TimeStampMethod are the URI of digital server, username and password. ****

The following code illustrates the method for adding timestamp in the digital signature.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                      |
| [//Get certificate. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                      |
| [PdfCertificate]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ pdfCert = [new]{style="COLOR: blue"} [PdfCertificate]{style="COLOR: teal"}([@\"..\\..\\Data\\PDF.pfx\"]{style="COLOR: maroon"}, [\"syncfusion\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                      |
| [//Sign the document with timestamp.      ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                      |
| [PdfSignature]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ signature = [new]{style="COLOR: blue"} [PdfSignature]{style="COLOR: teal"}(page, pdfCert, [\"Signature\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                      |
| [//Add time stamp using the server URI and credentials.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                      |
| [signature.TimeStampServer = [new]{style="COLOR: blue"} [TimeStampServer]{style="COLOR: #2b91af"}(]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                              |
|                                                                                                                                                                                                                                                                                      |
| [                [new]{style="COLOR: blue"} [Uri]{style="COLOR: #2b91af"}([\"http://digistamp.syncfusion.com\"]{style="COLOR: #a31515"}),[\"user\"]{style="COLOR: #a31515"}, [\"123456\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                      |
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}**                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                      |
| [\'Get certificate. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pdfCert [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfCertificate([\"..\\..\\Data\\PDF.pfx\"]{style="COLOR: darkred"}, [\"syncfusion\"]{style="COLOR: darkred"})]{style="FONT-FAMILY: 'Courier New'"}              |
|                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                      |
| [\'Sign the document with timestamp.      ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ signature [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfSignature(page, pdfCert, [\"Signature\"]{style="COLOR: darkred"})]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                      |
| [\'Add time stamp using the server URI and credentials.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                                                                                      |
| [signature.TimeStampServer = [New]{style="COLOR: blue"} TimeStampServer([New]{style="COLOR: blue"} Uri([\"http://digistamp.syncfusion.com\"]{style="COLOR: darkred"}),[\"user\"]{style="COLOR: darkred"}, [\"123456\"]{style="COLOR: darkred"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Multiple Signatures

 

You can add multiple signatures to the document with incremental updates by using standard signatures.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note: Currently only self-created and third-party .pfx certificates are supported.
:::

[]{#p59} 

[]{#related-topics}
::::::

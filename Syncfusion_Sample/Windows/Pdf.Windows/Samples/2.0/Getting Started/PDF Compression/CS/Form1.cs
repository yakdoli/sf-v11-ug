using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

namespace PDF_Compression
{
    public partial class Form1 : Form
    {
        # region Fields
        private PointF point;
        private PdfPage page;
        private SizeF size;
        private PdfLayoutFormat format;
        private int quality;
        # endregion

        # region Constructor
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = string.Empty;
            this.comboBox1.SelectedIndex = 2;
            this.comboBox2.SelectedIndex = 2;
        }
        # endregion

        # region Events
        private void button1_Click(object sender, EventArgs e)
        {
            quality = GetTargetQuality(this.comboBox2.SelectedItem.ToString());

            // Create a new instance of PdfDocument class.
            PdfDocument document = new PdfDocument();
            document.Compression = (PdfCompressionLevel)Enum.Parse(typeof(PdfCompressionLevel), this.comboBox1.SelectedItem.ToString(), true);

            # region Text and Image content

            // Add a new page to the document.
            page = document.Pages.Add();

            // Get page size
            size = page.GetClientSize();

            format = new PdfLayoutFormat();
            format.Layout = PdfLayoutType.Paginate;

            PdfBitmap image = PdfImage.FromFile(GetFullTemplatePath("Enterprise.png", true)) as PdfBitmap;

            // Draw image.
            PdfLayoutResult result = DrawImage(image);

            // Recalculate position for the next element.
            ReCalculateElements(result);

            // Read text content
            StreamReader reader = new StreamReader(GetFullTemplatePath("Text1.txt", false));
            string text = reader.ReadToEnd();

            // Draw text
            result = DrawText(text);

            // Recalculate position and continue updating PDF.
            ReCalculateElements(result);

            result = DrawText("Essential Studio User Interface Edition");

            ReCalculateElements(result);

            image = PdfImage.FromFile(GetFullTemplatePath("ui.bmp", true)) as PdfBitmap;
            result = DrawImage(image);

            ReCalculateElements(result);

            text = "Essential Studio User Interface Edition includes everything you need to build industry standard user interfaces. This studio lets you quickly and easily " +
            "build enterprise class desktop and Web applications with docking managers, Microsoft Office style controls, menus, business charts, Visio like diagramming, the fastest .NET " +
            "grid control on the market, and much more. You can design Web applications using over 60 AJAX enabled controls or frameworks with complete documentation and samples " +
            "and easily add advanced jQuery UI features to your Web applications. This suite includes high performance Grid, Docking and Menu frameworks, data binding controls, " +
            "Scheduler, Data Visualization Chart, Gauge, Diagram, and more for any .NET platform: Silverlight, ASP.NET MVC, ASP.NET, WPF, and Windows Forms. ";
            result = DrawText(text);

            ReCalculateElements(result);

            result = DrawText("Essential Studio Reporting Edition");

            ReCalculateElements(result);

            image = PdfImage.FromFile(GetFullTemplatePath("report.bmp", true)) as PdfBitmap;
            result = DrawImage(image);

            ReCalculateElements(result);

            text = "Provide business users with the reports they need, in the formats they prefer. Essential Studio Reporting Edition provides .NET components to read " +
                "and write Excel, Word, and PDF documents and enables your applications to be over 100x faster than office automation. Create advanced reports or " +
                "integrate document-based reporting into your Windows and Web applications easily. Available for Silverlight, ASP.NET MVC, ASP.NET, WPF, and Windows Forms. ";

            result = DrawText(text);

            ReCalculateElements(result);

            result = DrawText("Essential Studio Business Intelligence Edition");

            ReCalculateElements(result);

            image = PdfImage.FromFile(GetFullTemplatePath("bi.bmp", true)) as PdfBitmap;
            result = DrawImage(image);

            ReCalculateElements(result);

            text = "Integrate BI analysis into your Windows and Web applications with ease. With Essential Studio Business Intelligence Edition, you can easily build WPF, " +
                "Silver-light, and ASP.NET business intelligence applications. Creating executive dash­boards for the most demanding users is painless with Syncfusion " +
                "BI Client, Chart, Gauge, Grid and PivotGrid. Works with both OLAP data and relational data. ";
            
            result = DrawText(text);

            ReCalculateElements(result);

            reader = new StreamReader(GetFullTemplatePath("Text2.txt", false));
            text = reader.ReadToEnd();
            result = DrawText(text);

            ReCalculateElements(result);

            image = PdfImage.FromFile(GetFullTemplatePath("laptop.png", true)) as PdfBitmap;
            result = DrawImage(image);

            ReCalculateElements(result);

            reader = new StreamReader(GetFullTemplatePath("Text3.txt", false));
            text = reader.ReadToEnd();
            result = DrawText(text);

            ReCalculateElements(result);

            image = PdfImage.FromFile(GetFullTemplatePath("final.png", true)) as PdfBitmap;
            result = DrawImage(image);

            # endregion

            // Save and close the document.
            document.Save("Sample.pdf");
            document.Close(true);

            reader = new StreamReader("Sample.pdf");

            // Update the text box.
            this.textBox1.Text += "Generated Filesize: " + reader.BaseStream.Length.ToString() + " bytes" + Environment.NewLine;
            this.textBox1.Text += "Done!";

            reader.Close();
            reader.Dispose();

            //Message box confirmation to view the created PDF document.
            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample.pdf");
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
        }
        #endregion

        # region Helpher methods
        /// <summary>
        /// Draw text using PdfTextElement class.
        /// </summary>
        private PdfLayoutResult DrawText(string text)
        {
            // Initialize PdfTextElement.
            PdfTextElement element = new PdfTextElement(text);

            // Set Font.
            element.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 10f);

            // Set String format
            element.StringFormat = new PdfStringFormat(PdfTextAlignment.Justify);

            // Draw and return PdfTextLayoutResult.
            return element.Draw(page, point, size.Width, format);
        }

        /// <summary>
        /// Draw image using PdfBitmap class.
        /// </summary>
        private PdfLayoutResult DrawImage(PdfBitmap image)
        {
            // Set quality.
            image.Quality = quality;
            
            // Draw and return PdfLayoutResult.
            return image.Draw(page, point, format);
        }
        
        /// <summary>
        /// Parse the image compression level to get the quality.
        /// </summary>
        private int GetTargetQuality(string p)
        {
            int quality = 100;

            switch (p)
            {
                case "Minimum":
                    quality = 20;
                    break;

                case "Low":
                    quality = 40;
                    break;

                case "Medium":
                    quality = 60;
                    break;

                case "High":
                    quality = 80;
                    break;

                case "Maximum":
                default:
                    quality = 100;
                    break;
            }

            return quality;
        }

        /// <summary>
        /// Position for the next element.
        /// </summary>
        private void ReCalculateElements(PdfLayoutResult result)
        {
            if (result != null)
            {
                page = result.Page;
                point = new PointF(result.Bounds.X, result.Bounds.Y + result.Bounds.Height + 20);
                // if the current element reaches the bottom of current page, add a new page.
                if (point.Y > size.Height - page.Section.PageSettings.Margins.Bottom)
                {
                    point = PointF.Empty;
                    page = page.Section.Pages.Add();
                }
            }
        }

        /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName, bool image)
        {
            string fullPath = @"..\..\..\..\..\..\..\..\..\Common\";
            string folder = image ? "Images" : "Data";

            return string.Format(@"{0}{1}\PDF\{2}", fullPath, folder, fileName);
        }

        # endregion
    }
}
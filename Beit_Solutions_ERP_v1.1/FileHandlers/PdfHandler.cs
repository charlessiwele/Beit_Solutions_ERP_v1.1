using ZetPDF.Pdf;
using ZetPDF.Drawing;
using ZetPDF.Drawing.Layout;
using System.Diagnostics;
using System.IO;

namespace Beit_Solutions_ERP_v1._1.FileHandlers
{
    class PdfHandler:Base
    {
        public void SetQuoteContent(string filename, string text)
        {
            DataConnectionHandlers.ConnectBusiness ConnectBusiness = new DataConnectionHandlers.ConnectBusiness();
            Objects.Business ObjectType = new Objects.Business();
            var businessObject = ConnectBusiness.SelectList(ObjectType, 0)[0];

            PdfDocument document = new PdfDocument();

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font1 = new XFont("Times New Roman", 15, XFontStyle.Bold);
            XFont font2 = new XFont("Times New Roman", 10, XFontStyle.Bold);
            XTextFormatter tf = new XTextFormatter(gfx); ;

            XRect rect1 = new XRect(50, 160, 500, 100);
            XRect rect2 = new XRect(50, 270, 500, 500);
            gfx.DrawRectangle(XBrushes.SeaShell, rect1);
            gfx.DrawRectangle(XBrushes.SeaShell, rect2);

            //DrawPng(gfx, 1, imgPath);
            DrawImageScaled(gfx, 1, businessObject.BusinessLogo);

            tf.DrawString("Quotation\n\n\n\n" + System.DateTime.Now.ToLongDateString(), font1, XBrushes.Black, rect1, XStringFormats.TopLeft);
            tf.DrawString(text, font2, XBrushes.Black, rect2, XStringFormats.TopLeft);

            // Save the document...
            filename = "Quotes/" + filename;
            filename  = Path.Combine(Directory.GetCurrentDirectory(), filename);
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        }

        public void SetInvoiceContent(string filename, string text)
        {
            DataConnectionHandlers.ConnectBusiness ConnectBusiness = new DataConnectionHandlers.ConnectBusiness();
            Objects.Business ObjectType = new Objects.Business();
            var businessObject = ConnectBusiness.SelectList(ObjectType, 0)[0];

            PdfDocument document = new PdfDocument();

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font1 = new XFont("Times New Roman", 15, XFontStyle.Bold);
            XFont font2 = new XFont("Times New Roman", 10, XFontStyle.Bold);
            XTextFormatter tf = new XTextFormatter(gfx); ;

            XRect rect1 = new XRect(50, 160, 500, 100);
            XRect rect2 = new XRect(50, 270, 500, 500);
            gfx.DrawRectangle(XBrushes.SeaShell, rect1);
            gfx.DrawRectangle(XBrushes.SeaShell, rect2);

            //DrawPng(gfx, 1, imgPath);
            DrawImageScaled(gfx, 1, businessObject.BusinessLogo);

            tf.DrawString("Invoice\n\n\n\n" + System.DateTime.Now.ToLongDateString(), font1, XBrushes.Black, rect1, XStringFormats.TopLeft);
            tf.DrawString(text, font2, XBrushes.Black, rect2, XStringFormats.TopLeft);

            // Save the document...
            filename = "Invoices/" + filename;
            filename = Path.Combine(Directory.GetCurrentDirectory(), filename);

            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        }


        /// <summary>
        /// Draws an image scaled.
        /// </summary>
        public void DrawImageScaled(XGraphics gfx, int number, string imgPath)
        {
//            BeginBox(gfx, number, "DrawImage (scaled)");
            XImage image = XImage.FromFile(imgPath);

            gfx.DrawImage(image, 50, 50, 500, 100);

  //          EndBox(gfx);
        }
    }
}

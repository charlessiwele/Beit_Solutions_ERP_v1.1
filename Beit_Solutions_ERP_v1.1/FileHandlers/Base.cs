using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZetPDF.Drawing;
using ZetPDF.Pdf;

namespace Beit_Solutions_ERP_v1._1.FileHandlers
{
    public class Base
    {
        protected XColor backColor;
        protected XColor backColor2;
        protected XColor shadowColor;
        protected double borderWidth;
        protected XPen borderPen;

        protected Base()
        {
            this.backColor = XColors.Ivory;
            this.backColor2 = XColors.WhiteSmoke;

            this.backColor = XColor.FromArgb(212, 224, 240);
            this.backColor2 = XColor.FromArgb(253, 254, 254);

            this.shadowColor = XColors.Gainsboro;
            this.borderWidth = 4.5;
            this.borderPen = new XPen(XColor.FromArgb(94, 118, 151), this.borderWidth);//new XPen(XColors.SteelBlue, this.borderWidth);
        }

        /// <summary>
        /// Draws the page title and footer.
        /// </summary>
        public void DrawTitle(PdfPage page, XGraphics gfx, string title)
        {
            // Create a temporary file
            string filename = String.Format("{0}_tempfile.pdf", Guid.NewGuid().ToString("D").ToUpper());
            s_document = new PdfDocument();
            s_document.Info.Title = "ZetPDF XGraphic Sample";
            s_document.Info.Author = "Document author";
            s_document.Info.Subject = "Created with code snippets that show the use of graphical functions";
            s_document.Info.Keywords = "ZetPDF, XGraphics";

            XRect rect = new XRect(new XPoint(), gfx.PageSize);
            rect.Inflate(-10, -15);
            XFont font = new XFont("Verdana", 14, XFontStyle.Bold);
            gfx.DrawString(title, font, XBrushes.MidnightBlue, rect, XStringFormats.TopCenter);

            rect.Offset(0, 5);
            font = new XFont("Verdana", 8, XFontStyle.Italic);
            XStringFormat format = new XStringFormat();
            format.Alignment = XStringAlignment.Near;
            format.LineAlignment = XLineAlignment.Far;
            gfx.DrawString("Created with " + ZetPDF.ProductVersionInfo.Producer, font, XBrushes.DarkOrchid, rect, format);

            font = new XFont("Verdana", 8);
            format.Alignment = XStringAlignment.Center;
            gfx.DrawString(s_document.PageCount.ToString(), font, XBrushes.DarkOrchid, rect, format);

            s_document.Outlines.Add(title, page, true);
        }

        /// <summary>
        /// Draws a sample box.
        /// </summary>
        public void BeginBox(XGraphics gfx, int number, string title)
        {
            const int dEllipse = 15;
            XRect rect = new XRect(0, 20, 300, 200);
            if (number % 2 == 0)
                rect.X = 300 - 5;
            rect.Y = 40 + ((number - 1) / 2) * (200 - 5);
            rect.Inflate(-10, -10);
            XRect rect2 = rect;
            rect2.Offset(this.borderWidth, this.borderWidth);
            gfx.DrawRoundedRectangle(new XSolidBrush(this.shadowColor), rect2, new XSize(dEllipse + 8, dEllipse + 8));
            XLinearGradientBrush brush = new XLinearGradientBrush(rect, this.backColor, this.backColor2, XLinearGradientMode.Vertical);
            gfx.DrawRoundedRectangle(this.borderPen, brush, rect, new XSize(dEllipse, dEllipse));
            rect.Inflate(-5, -5);

            XFont font = new XFont("Verdana", 12, XFontStyle.Regular);
            gfx.DrawString(title, font, XBrushes.Navy, rect, XStringFormats.TopCenter);

            rect.Inflate(-10, -5);
            rect.Y += 20;
            rect.Height -= 20;
            //gfx.DrawRectangle(XPens.Red, rect);

            this.state = gfx.Save();
            gfx.TranslateTransform(rect.X, rect.Y);
        }

        public void EndBox(XGraphics gfx)
        {
            gfx.Restore(this.state);
        }

        XGraphicsState state;
        internal static PdfDocument s_document;
    }
}

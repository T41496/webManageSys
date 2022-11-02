using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webTRON_Management_Software.Utils
{
   public class Printer
    {


       // public static float panelWidth{get;set;}
        //public static float panelHeight{get;set;}

        PrintPreviewDialog printPreview = new PrintPreviewDialog();
        PrintDocument printdocument = new PrintDocument();
        float panelWidth;
        float panelHeight;
        Panel Obj;
        public Printer(float width,float height, Panel p) {
            panelWidth = width;
            panelHeight = height;
            Obj = p;
        }
    
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            getPrintArea(pnl);
            printPreview.Document = printdocument;
            printdocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreview.ShowDialog();
        }

        Bitmap memorying;
        private void getPrintArea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pageArea.Width / 2) - panelWidth / 2, Obj.Location.Y);
        }
    }
}

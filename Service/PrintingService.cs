using System.Drawing.Printing;
using System.Windows.Forms;

namespace Service
{
    public class PrintingService
    {
        public void Print(PrintDialog printDialog, PrintDocument document)
        {
            printDialog.Document = document;
            if (!string.IsNullOrWhiteSpace(document.PrinterSettings.PrinterName))
                printDialog.PrinterSettings = document.PrinterSettings;
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                document.PrinterSettings = printDialog.PrinterSettings;
                document.Print();
            }
        }
    }
}

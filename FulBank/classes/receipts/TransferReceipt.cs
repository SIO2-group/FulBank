using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion;
using System.IO;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.OfficeChartToImageConverter;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;

namespace Fulbank.classes
{
    class TransferReceipt
    {
        public string Date;
        public string Heure;
        public string UserId;
        public string Name;
        public string Firstname;
        public string Terminal;
        public string AccountFrom;
        public string AccountTo;
        public string Bid;
        public string BName;
        public string Amount;


        public TransferReceipt(string date, string heure, string userId, string name, string firstname, string terminal, string accountFrom, string accountTo, string amount)
        {
            Date = date;
            Heure = heure;
            UserId = userId;
            Name = name;
            Firstname = firstname;
            Terminal = terminal;
            Amount = amount;
            AccountFrom = accountFrom;
            AccountTo = accountTo;


        }

        public void buildReceipt()
        {
            WordDocument document = new WordDocument();
            Stream docStream = File.OpenRead("receipt/templates/transfer_template.docx");
            document.Open(docStream, FormatType.Docx);
            docStream.Dispose();

            document.Replace("<Date>", Date, true, true);
            document.Replace("<Heure>", Heure, true, true);
            document.Replace("<UserId>", UserId, true, true);
            document.Replace("<Name>", Name, true, true);
            document.Replace("<Firstname>", Firstname, true, true);
            document.Replace("<Terminal>", Terminal, true, true);
            document.Replace("<AccountFrom>", AccountFrom, true, true);
            document.Replace("<AccountTo>", AccountTo, true, true);
            document.Replace("<Amount>", Amount, true, true);

            
            document.ChartToImageConverter = new ChartToImageConverter();
            DocToPDFConverter converter = new DocToPDFConverter();
            PdfDocument pdfdocument = converter.ConvertToPDF(document);
            string name = "receipt/generated/tr_" + DateTime.Now.ToString("yyyy''MM''dd'_'HH''mm''ss") + ".pdf";
            pdfdocument.Save(name);
            docStream.Dispose();

            System.Diagnostics.Process.Start(name);
        }

    }
}

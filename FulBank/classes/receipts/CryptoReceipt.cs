using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.OfficeChartToImageConverter;
using Syncfusion.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulbank.classes.receipts
{
    class CryptoReceipt
    {
        public string Date;
        public string Heure;
        public string ID_OP;
        public string UserId;
        public string Name;
        public string Firstname;
        public string Terminal;
        public string Type;
        public string Crypto;
        public string Unitaire;
        public string Quantity;
        public string Amount;


        public CryptoReceipt(string date, string heure, string userId, string name, string firstname, string terminal, string type, string crypto, string unitaire, string quantity, string amount)
        {
            Date = date;
            Heure = heure;
            UserId = userId;
            Name = name;
            Firstname = firstname;
            Terminal = terminal;
            Type = type;
            Crypto = crypto;
            Unitaire = unitaire;
            Quantity = quantity;
            Amount = amount;
        }

        public void buildReceipt()
        {
            WordDocument document = new WordDocument();
            Stream docStream = File.OpenRead("receipt/templates/crypto_trade_template.docx");
            document.Open(docStream, FormatType.Docx);
            docStream.Dispose();

            document.Replace("<Date>", Date, true, true);
            document.Replace("<Heure>", Heure, true, true);
          
            document.Replace("<UserId>", UserId, true, true);
            document.Replace("<Name>", Name, true, true);
            document.Replace("<Firstname>", Firstname, true, true);
            document.Replace("<Terminal>", Terminal, true, true);
            document.Replace("<Type>", Type, true, true);
            document.Replace("<Crypto>", Crypto, true, true);
            document.Replace("<Unitaire>", Unitaire, true, true);
            document.Replace("<Quantity>", Quantity, true, true);
            document.Replace("<Amount>", Amount, true, true);

            // docStream = File.Create("receipt/generated/op_" + DateTime.Now.ToString("yyyy''MM''dd'_'HH''mm''ss") + ".pdf");
            document.ChartToImageConverter = new ChartToImageConverter();
            DocToPDFConverter converter = new DocToPDFConverter();
            PdfDocument pdfdocument = converter.ConvertToPDF(document);
            string name = Path.GetDirectoryName(Application.ExecutablePath) + "/receipt/generated/cr_" + DateTime.Now.ToString("yyyy''MM''dd'_'HH''mm''ss") + ".pdf";
            pdfdocument.Save(name);
            docStream.Dispose();
            pdfdocument.Close(true);

            System.Diagnostics.Process.Start(name);
        }
    }
}

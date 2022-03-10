using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion;
using System.IO;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.OfficeChartToImageConverter;
using Syncfusion.Pdf;
using System.Threading;
using System.Windows.Forms;

namespace Fulbank.classes
{
    class OperationReceipt
    {
        public string Date;
        public string Heure;
        public string ID_OP;
        public string UserId;
        public string Name;
        public string Firstname;
        public string Terminal;
        public string Type;
        public string Amount;


        public OperationReceipt(string date, string heure, string id_op, string userId, string name, string firstname, string terminal, string type, string amount)
        {
            Date = date;
            Heure = heure;
            ID_OP = id_op;
            UserId = userId;
            Name = name;
            Firstname = firstname;
            Terminal = terminal;
            Type = type;
            Amount = amount;
        }

        public void buildReceipt()
        {
            WordDocument document = new WordDocument();
            Stream docStream = File.OpenRead("receipt/templates/operation_template.docx");
            document.Open(docStream, FormatType.Docx);
            docStream.Dispose();

            document.Replace("<Date>", Date, true, true);
            document.Replace("<Heure>", Heure, true, true);
            document.Replace("<ID_OP>", ID_OP, true, true);
            document.Replace("<UserId>", UserId, true, true);
            document.Replace("<Name>", Name, true, true);
            document.Replace("<Firstname>", Firstname, true, true);
            document.Replace("<Terminal>", Terminal, true, true);
            document.Replace("<Type>", Type, true, true);
            document.Replace("<Amount>", Amount, true, true);

            MessageBox.Show(Building);


         // docStream = File.Create("receipt/generated/op_" + DateTime.Now.ToString("yyyy''MM''dd'_'HH''mm''ss") + ".pdf");
            document.ChartToImageConverter = new ChartToImageConverter();
            DocToPDFConverter converter = new DocToPDFConverter();
            PdfDocument pdfdocument = converter.ConvertToPDF(document);
            string name = Path.GetDirectoryName(Application.ExecutablePath) + "/receipt/generated/op_" + DateTime.Now.ToString("yyyy''MM''dd'_'HH''mm''ss") + ".pdf";
            pdfdocument.Save(name);
            docStream.Dispose();
            pdfdocument.Close(true);

            System.Diagnostics.Process.Start(name);
        }

    }
}

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

namespace Fulbank.classes
{
    class OperationReceipt
    {
        public string Date;
        public string UserId;
        public string PostalCode;
        public string City;
        public string Building;
        public string Type;
        public string Amount;


        public OperationReceipt(string date, string userId, string postalCode, string city, string building, string type, string amount)
        {
            Date = date;
            UserId = userId;
            PostalCode = postalCode;
            City = city;
            Building = building;
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
            document.Replace("<UserId>", UserId, true, true);
            document.Replace("<PostalCode>", PostalCode, true, true);
            document.Replace("<City>", City, true, true);
            document.Replace("<Building>", Building, true, true);
            document.Replace("<Type>", Type, true, true);
            document.Replace("<Amount>", Amount, true, true);


         // docStream = File.Create("receipt/generated/op_" + DateTime.Now.ToString("yyyy''MM''dd'_'HH''mm''ss") + ".pdf");
            document.ChartToImageConverter = new ChartToImageConverter();
            DocToPDFConverter converter = new DocToPDFConverter();
            PdfDocument pdfdocument = converter.ConvertToPDF(document);
            pdfdocument.Save("receipt/generated/op_" + DateTime.Now.ToString("yyyy''MM''dd'_'HH''mm''ss") + ".pdf");
            docStream.Dispose();
        }

    }
}

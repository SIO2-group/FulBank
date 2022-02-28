using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion;
using System.IO;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;

namespace Fulbank.classes
{
    class TransferReceipt
    {
        public string Date;
        public string UserId;
        public string PostalCode;
        public string City;
        public string Building;
        public string BId;
        public string BName;
        public string Amount;


        public TransferReceipt(string date, string userId, string postalCode, string city, string building, string amount)
        {
            Date = date;
            UserId = userId;
            PostalCode = postalCode;
            City = city;
            Building = building;
            Amount = amount;
        }

        public void buildReceipt()
        {
            WordDocument document = new WordDocument();
            Stream docStream = File.OpenRead("receipt/templates/transaction_template.docx");
            document.Open(docStream, FormatType.Docx);
            docStream.Dispose();

            document.Replace("<Date>", Date, true, true);
            document.Replace("<UserId>", UserId, true, true);
            document.Replace("<PostalCode>", PostalCode, true, true);
            document.Replace("<City>", City, true, true);
            document.Replace("<Building>", Building, true, true);
            document.Replace("<Amount>", Amount, true, true);

            docStream = File.Create("receipt/generated/tr_" + DateTime.Now.ToString("yyyy''MM''dd'_'HH''mm''ss") + ".pdf");
            document.Save(docStream, FormatType.Docx);
            docStream.Dispose();
        }

    }
}

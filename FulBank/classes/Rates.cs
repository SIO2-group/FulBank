using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fulbank.classes
{
    // RootRates myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Rates {

        [JsonPropertyName("AUD")]
        public string AUD;

        [JsonPropertyName("BGN")]
        public string BGN;

        [JsonPropertyName("BRL")]
        public string BRL;

        [JsonPropertyName("CAD")]
        public string CAD;

        [JsonPropertyName("CHF")]
        public string CHF;

        [JsonPropertyName("CNY")]
        public string CNY;

        [JsonPropertyName("CZK")]
        public string CZK;

        [JsonPropertyName("DKK")]
        public string DKK;

        [JsonPropertyName("EUR")]
        public string EUR;

        [JsonPropertyName("GBP")]
        public string GBP;

        [JsonPropertyName("HKD")]
        public string HKD;

        [JsonPropertyName("HRK")]
        public string HRK;

        [JsonPropertyName("HUF")]
        public string HUF;

        [JsonPropertyName("IDR")]
        public string IDR;

        [JsonPropertyName("ILS")]
        public string ILS;

        [JsonPropertyName("INR")]
        public string INR;

        [JsonPropertyName("ISK")]
        public string ISK;

        [JsonPropertyName("JPY")]
        public string JPY;

        [JsonPropertyName("KRW")]
        public string KRW;

        [JsonPropertyName("MXN")]
        public string MXN;

        [JsonPropertyName("MYR")]
        public string MYR;

        [JsonPropertyName("NOK")]
        public string NOK;

        [JsonPropertyName("NZD")]
        public string NZD;

        [JsonPropertyName("PHP")]
        public string PHP;

        [JsonPropertyName("PLN")]
        public string PLN;

        [JsonPropertyName("RON")]
        public string RON;

        [JsonPropertyName("RUB")]
        public string RUB;

        [JsonPropertyName("SEK")]
        public string SEK;

        [JsonPropertyName("SGD")]
        public string SGD;

        [JsonPropertyName("THB")]
        public string THB;

        [JsonPropertyName("TRY")]
        public string TRY;

        [JsonPropertyName("ZAR")]
        public string ZAR;

    }

    public class RootRates
    {
        [JsonPropertyName("amount")]
        public double Amount;

        [JsonPropertyName("base")]
        public string Base;

        [JsonPropertyName("date")]
        public string Date;

        [JsonPropertyName("rates")]
        public Rates Rates;

    }


}

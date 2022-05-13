using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fulbank.classes
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Cryptocurrency>(myJsonResponse); 

    ///<summary>Class Cryptocurrency contains the Crypto's data (id, symbol, name, rank, price)
    ///</summary>
    public class Cryptocurrency
    {
        public string id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public string nameid { get; set; }
        public int rank { get; set; }
        public string price_usd { get; set; }
        public double percent_change_24h { get; set; }
        public double percent_change_1h { get; set; }
        public double percent_change_7d { get; set; }
        public string price_btc { get; set; }
        public string market_cap_usd { get; set; }
        public double volume24 { get; set; }
        public double volume24a { get; set; }
        public string csupply { get; set; }
        public string tsupply { get; set; }
        public string msupply { get; set; }
        public string price_eur { get; set; }
    }

    public class Info
    {
        public int coins_num { get; set; }
        public int time { get; set; }
    }

    public class Root
    {
        public List<Cryptocurrency> data { get; set; }
        public Info info { get; set; }

        public Dictionary<string, Cryptocurrency> getCrypto()
        {
            Dictionary<string, Cryptocurrency> dictionary = new Dictionary<string, Cryptocurrency>();
            foreach(Cryptocurrency crypto in data)
            {
                dictionary.Add(crypto.symbol, crypto);
            }
            return dictionary;
        }
    }




}

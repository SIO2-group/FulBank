using Fulbank.classes;
using FulBank;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulbank.pages.Crypto
{
    public partial class FormCryptocurrency : Form
    {
        Root Cryptocurrencies = new Root();
        public static Dictionary<string, Cryptocurrency> cryptos;
        public static Dictionary<string, Panel> crypto_panels;
        public FormCryptocurrency()
        {
            crypto_panels = new Dictionary<string, Panel>();
            InitializeComponent();
            CryptoLoad();
            DisplayAll(crypto_panels);
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private void FormCryptocurrency_Load(object sender, EventArgs e)
        {
            
        }

        public void CryptoLoad()
        {
            WebRequest request = HttpWebRequest.Create("https://api.coinlore.net/api/tickers/?start=0"); // &limit=25
            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string btc_json = reader.ReadToEnd();
            Cryptocurrencies = JsonConvert.DeserializeObject<Root>(btc_json);
            cryptos = Cryptocurrencies.getCrypto();
            //path of the crypto api
            foreach (Cryptocurrency crypto in Cryptocurrencies.data)
            {
                double price_usd = double.Parse(crypto.price_usd.Replace(".",","));
                double eur = double.Parse(FormMain.ConversionRates.Rates.EUR.Replace(".", ","));
                double value_eur = double.Parse((price_usd * eur).ToString());
                crypto.price_eur = Math.Round(value_eur, 2).ToString();


                Panel PanelCrypto = new Panel();

                TextBox Change7dPercent = new TextBox();
                TextBox Change1hPercent = new TextBox();
                TextBox Change24hPercent = new TextBox();
                TextBox CryptoName = new TextBox();
                TextBox CryptoSymbol = new TextBox();
                TextBox CryptoValue = new TextBox();
                Button TradeBtn = new Button();
                Color color24h = new Color();
                string sign24h = "";
                string sign1h = "";
                string sign7d = "";
                if (crypto.percent_change_24h > 0)
                {
                    color24h = System.Drawing.Color.ForestGreen;
                    sign24h = "+";
                }
                else
                {
                    color24h = System.Drawing.Color.Red;
                }
                Color color1h = new Color();
                if (crypto.percent_change_1h > 0)
                {
                    color1h = System.Drawing.Color.ForestGreen;
                    sign1h = "+";
                }
                else
                {
                    color1h = System.Drawing.Color.Red;
                }
                Color color7d = new Color();
                if (crypto.percent_change_7d > 0)
                {
                    color7d = System.Drawing.Color.ForestGreen;
                    sign7d = "+";
                }
                else
                {
                    color7d = System.Drawing.Color.Red;
                }
                // 
                // PanelCrypto
                // 
                PanelCrypto.BackColor = System.Drawing.SystemColors.Window;
                PanelCrypto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                PanelCrypto.Controls.Add(Change7dPercent);
                PanelCrypto.Controls.Add(Change1hPercent);
                PanelCrypto.Controls.Add(Change24hPercent);
                PanelCrypto.Controls.Add(CryptoName);
                PanelCrypto.Controls.Add(CryptoSymbol);
                PanelCrypto.Controls.Add(CryptoValue);
                PanelCrypto.Controls.Add(TradeBtn);
                PanelCrypto.Location = new System.Drawing.Point(30, 5);
                PanelCrypto.Name = "PanelCrypto";
                PanelCrypto.Size = new System.Drawing.Size(700, 44);
                PanelCrypto.TabIndex = 2;

                crypto_panels.Add(("panel_" + crypto.name + "_" + crypto.symbol).ToLower(), PanelCrypto);
                // 
                // CryptoName
                // 
                CryptoName.Anchor = System.Windows.Forms.AnchorStyles.Left;
                CryptoName.BackColor = System.Drawing.SystemColors.Window;
                CryptoName.BorderStyle = System.Windows.Forms.BorderStyle.None;
                CryptoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                CryptoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(28)))), ((int)(((byte)(125)))));
                CryptoName.Location = new System.Drawing.Point(75, 8);
                CryptoName.Name = "CryptoName";
                CryptoName.Size = new System.Drawing.Size(139, 25);
                CryptoName.TabIndex = 1;
                CryptoName.Text = crypto.name;
                CryptoName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                CryptoName.ReadOnly = true;
                CryptoName.ShortcutsEnabled = false;
                CryptoName.TabStop = false;
                // 
                // CryptoSymbol
                // 
                CryptoSymbol.Anchor = System.Windows.Forms.AnchorStyles.Left;
                CryptoSymbol.BackColor = System.Drawing.SystemColors.Window;
                CryptoSymbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
                CryptoSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                CryptoSymbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(28)))), ((int)(((byte)(125)))));
                CryptoSymbol.Location = new System.Drawing.Point(3, 8);
                CryptoSymbol.Name = "CryptoSymbol";
                CryptoSymbol.ReadOnly = true;
                CryptoSymbol.ShortcutsEnabled = false;
                CryptoSymbol.TabStop = false;
                CryptoSymbol.Size = new System.Drawing.Size(80, 25);
                CryptoSymbol.TabIndex = 0;
                CryptoSymbol.Text = crypto.symbol;
                CryptoSymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                CryptoSymbol.WordWrap = false;
                //
                // CryptoValue
                //
                CryptoValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
                CryptoValue.BackColor = System.Drawing.SystemColors.Window;
                CryptoValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
                CryptoValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                CryptoValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(28)))), ((int)(((byte)(125)))));
                CryptoValue.Location = new System.Drawing.Point(240, 8);
                CryptoValue.Name = "CryptoValue";
                CryptoValue.ReadOnly = true;
                CryptoValue.ShortcutsEnabled = false;
                CryptoValue.TabStop = false;
                CryptoValue.Size = new System.Drawing.Size(150, 25);
                CryptoValue.TabIndex = 0;
                CryptoValue.Text = crypto.price_eur;
                CryptoValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                CryptoSymbol.WordWrap = false;
                // 
                // Change24hPercent
                // 
                Change24hPercent.Anchor = System.Windows.Forms.AnchorStyles.Left;
                Change24hPercent.BackColor = System.Drawing.SystemColors.Window;
                Change24hPercent.BorderStyle = System.Windows.Forms.BorderStyle.None;
                Change24hPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Change24hPercent.ForeColor = color24h;
                Change24hPercent.Location = new System.Drawing.Point(370, 8);
                Change24hPercent.Name = "Change24hPercent";
                Change24hPercent.Size = new System.Drawing.Size(85, 25);
                Change24hPercent.TabIndex = 3;
                Change24hPercent.Text = sign24h + crypto.percent_change_24h.ToString() + "%";
                Change24hPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                Change24hPercent.ReadOnly = true;
                Change24hPercent.ShortcutsEnabled = false;
                Change24hPercent.TabStop = false;
                // 
                // Change1hPercent
                // 
                Change1hPercent.Anchor = System.Windows.Forms.AnchorStyles.Left;
                Change1hPercent.BackColor = System.Drawing.SystemColors.Window;
                Change1hPercent.BorderStyle = System.Windows.Forms.BorderStyle.None;
                Change1hPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Change1hPercent.ForeColor = color1h;
                Change1hPercent.Location = new System.Drawing.Point(450, 8);
                Change1hPercent.Name = "Change1hPercent";
                Change1hPercent.Size = new System.Drawing.Size(90, 25);
                Change1hPercent.TabIndex = 5;
                Change1hPercent.Text = sign1h + crypto.percent_change_1h.ToString() + "%";
                Change1hPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                Change1hPercent.ReadOnly = true;
                Change1hPercent.ShortcutsEnabled = false;
                Change1hPercent.TabStop = false;
                // 
                // Change7dPercent
                // 
                Change7dPercent.Anchor = System.Windows.Forms.AnchorStyles.Left;
                Change7dPercent.BackColor = System.Drawing.SystemColors.Window;
                Change7dPercent.BorderStyle = System.Windows.Forms.BorderStyle.None;
                Change7dPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Change7dPercent.ForeColor = color7d;
                Change7dPercent.Location = new System.Drawing.Point(530, 8);
                Change7dPercent.Name = "Change7dPercent";
                Change7dPercent.Size = new System.Drawing.Size(80, 25);
                Change7dPercent.TabIndex = 7;
                Change7dPercent.Text = sign7d + crypto.percent_change_7d.ToString() + "%";
                Change7dPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                Change7dPercent.ReadOnly = true;
                Change7dPercent.ShortcutsEnabled = false;
                Change7dPercent.TabStop = false;
                this.PanelCryptos.Controls.Add(PanelCrypto);
                //
                // Trade Button
                //
                TradeBtn.BackColor = System.Drawing.Color.Plum;
                TradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                TradeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                TradeBtn.Location = new System.Drawing.Point(620, 6);
                TradeBtn.Name = "Btn" + crypto.symbol;
                TradeBtn.Size = new System.Drawing.Size(70, 29);
                TradeBtn.TabIndex = 1;
                TradeBtn.Text = "Trade";
                TradeBtn.UseVisualStyleBackColor = false;
                TradeBtn.Click += delegate (object sender, EventArgs e)
                { TradeBtn_Click(sender, e, crypto); };

                PanelCrypto.Hide();
            }
        }

        private void TradeBtn_Click(object sender, EventArgs e, Cryptocurrency crypto)
        {
            new FormCryptoOperation(crypto).Show();
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            new FormWallets().Show();
        }

        private void PanelCryptos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonSearchCrypto_Click(object sender, EventArgs e)
        {
            var results = from result in crypto_panels
                          where Regex.IsMatch(result.Key, TextSearchCrypto.Text.ToLower())
                          select result;
            HideAll();
            DisplaySearch(results);
        }

        private void DisplayAll(Dictionary<string, Panel> dico)
        {
            int y = 5;
            foreach (var item in dico)
            {
                item.Value.Location = new System.Drawing.Point(30, y);
                item.Value.Show();
                y += 60;
            }
        }

        private void DisplaySearch(IEnumerable<KeyValuePair<string, Panel>> dico)
        {
            int y = 5;
            foreach (var item in dico)
            {
                item.Value.Location = new System.Drawing.Point(30, y);
                item.Value.Show();
                y += 60;
            }
        }

        private void HideAll()
        {
            foreach (var item in crypto_panels)
            {
                item.Value.Hide();
            }
        }

        private void DollarBtn_Click(object sender, EventArgs e)
        {
            HideAll();
        }
    }
}

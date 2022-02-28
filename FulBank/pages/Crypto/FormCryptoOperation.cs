using Fulbank.classes;
using FulBank;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulbank.pages.Crypto
{
    public partial class FormCryptoOperation : Form
    {
        Cryptocurrency crypto = new Cryptocurrency();
        Cryptowallet wallet = new Cryptowallet();
        Account cheque = new Account();
                
        public FormCryptoOperation(Cryptocurrency aCrypto)
        {
            InitializeComponent();
            crypto = aCrypto;
        }

        private void FormTrade_Load(object sender, EventArgs e)
        {                    
            TxtUnitPrice.Text = crypto.price_eur.Replace(".", ",");
            FormMain.user.getWalletsDico().TryGetValue(crypto.symbol, out Cryptowallet awallet);
            TxtOwnedCurrency.Text = awallet.GetAmount().ToString();
            FormMain.user.getAccountsDico().TryGetValue("COMPTE CHEQUE", out Account acheque);
            txtAccountBalance.Text = acheque.Get_Balance().ToString();
        }

        private void TxtUnitsToTrade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(float.TryParse(TxtUnitsToTrade.Text.Replace(".",","), out float result))
                {
                    if (!String.IsNullOrEmpty(TxtUnitsToTrade.Text) && result > 0)
                    {
                        TxtTotalPrice.Text = (float.Parse(TxtUnitPrice.Text) * result).ToString();
                    }
                }

            }
            catch
            {
                
            }

        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TxtUnitsToTrade.Text.Replace(".", ","), out float result))
            {
                if (String.IsNullOrEmpty(TxtUnitsToTrade.Text) || result <= 0)
                {
                    MessageBox.Show("Entrez un nombre positif");
                }
                else if (float.Parse(TxtUnitsToTrade.Text) > float.Parse(TxtOwnedCurrency.Text))
                {
                    MessageBox.Show("Vous ne possédez pas assez de monnaie");
                }
                else
                {
                    FormMain.user.getAccountsDico().TryGetValue("COMPTE CHEQUE", out Account cheque);
                    cheque.CryptoSell(TxtTotalPrice.Text);
                    wallet.sellCrypto(float.Parse(TxtUnitsToTrade.Text.Replace(",", ".")));
                }
            }
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TxtUnitsToTrade.Text.Replace(".", ","), out float result))
            {
                if (String.IsNullOrEmpty(TxtUnitsToTrade.Text) || result <= 0)
                {
                    MessageBox.Show("Entrez un nombre positif");
                }
                else if (float.Parse(TxtTotalPrice.Text) > cheque.Get_Balance())
                {
                    MessageBox.Show("Vous ne possédez pas assez d'argent");
                }
                else
                {
                    if (FormMain.user.getAccountsDico().TryGetValue(crypto.symbol, out Account acc))
                    {
                        cheque.CryptoBuy(TxtTotalPrice.Text);
                        wallet.BuyCrypto(float.Parse(TxtUnitsToTrade.Text.Replace(",", ".")));
                        MessageBox.Show("Vous venez d'acheter " + TxtUnitsToTrade.Text + " " + wallet.GetSymbol() + " pour " + TxtTotalPrice.Text + " €");
                    }
                    else
                    {
                        Cryptowallet newWallet = new Cryptowallet(crypto.symbol, 0);
                        FormMain.user.GetWallets().Add(newWallet);
                        FormMain.dbConnexion.Open();
                        string commandText = @"INSERT INTO cryptowallet (CW_UID, CW_C_SYMBOL) VALUES('" + FormMain.user.Get_Id() + "','" + crypto.symbol + "')";
                        MySqlCommand cmdCredit = new MySqlCommand(commandText, FormMain.dbConnexion);
                        cmdCredit.ExecuteNonQuery();
                        FormMain.dbConnexion.Close();
                        cheque.CryptoBuy(TxtTotalPrice.Text);
                        newWallet.BuyCrypto(float.Parse(TxtUnitsToTrade.Text.Replace(",", ".")));
                        MessageBox.Show("Vous venez d'acheter " + TxtUnitsToTrade.Text + " " + crypto.symbol + " pour " + TxtTotalPrice.Text + " €");
                    }
                }
            }
            
        }

        private void TxtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtOwnedCurrency_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelUnitPrice_Click(object sender, EventArgs e)
        {

        }

        private void LabelOwnedCurrency_Click(object sender, EventArgs e)
        {

        }

        private void Label_Click(object sender, EventArgs e)
        {

        }
    }
}

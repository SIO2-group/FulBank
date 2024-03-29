﻿using Fulbank.classes;
using Fulbank.classes.receipts;
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
            FormMain.user.getAccountsDico().TryGetValue("COMPTE CHEQUE", out Account comptecheque);
            cheque = comptecheque;

            TxtUnitPrice.Text = crypto.price_eur.Replace(".", ",");

            if(FormMain.user.getWalletsDico().TryGetValue(crypto.symbol, out Cryptowallet awallet)){ 
                TxtOwnedCurrency.Text = awallet.GetAmount().ToString();
                wallet = awallet;

            }
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
                    cheque.CryptoSell(TxtTotalPrice.Text);
                    wallet.sellCrypto(float.Parse(TxtUnitsToTrade.Text.Replace(",", ".")), crypto);
                    CryptoReceipt receipt = new CryptoReceipt(DateTime.Now.ToString("ddd' 'dd' 'MMM' 'yyyy"), DateTime.Now.ToString("HH':'mm':'ss"), FormMain.user.Get_Id().ToString(), FormMain.user.Get_Name().ToString(), FormMain.user.Get_Firstname().ToString(), FormMain.thisTerminal.getId(), "VENTE", crypto.name, crypto.price_eur, TxtUnitsToTrade.Text, TxtTotalPrice.Text);
                    receipt.buildReceipt();
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
                    MessageBox.Show("Vous avez " + cheque.Get_Balance() + "euros et cela coute " + TxtTotalPrice.Text);
                    MessageBox.Show("Vous ne possédez pas assez d'argent");
                }
                else
                {
                    if (FormMain.user.getWalletsDico().TryGetValue(crypto.symbol, out Cryptowallet acc))
                    {
                        cheque.CryptoBuy(TxtTotalPrice.Text);
                        wallet.BuyCrypto(float.Parse(TxtUnitsToTrade.Text.Replace(",", ".")), crypto);
                        CryptoReceipt receipt = new CryptoReceipt(DateTime.Now.ToString("ddd' 'dd' 'MMM' 'yyyy"), DateTime.Now.ToString("HH':'mm':'ss"), FormMain.user.Get_Id().ToString(), FormMain.user.Get_Name().ToString(), FormMain.user.Get_Firstname().ToString(), FormMain.thisTerminal.getId(), "ACHAT", crypto.name, crypto.price_eur, TxtUnitsToTrade.Text, TxtTotalPrice.Text);
                        receipt.buildReceipt();
                        MessageBox.Show("Vous venez d'acheter " + TxtUnitsToTrade.Text + " " + wallet.GetSymbol() + " pour " + TxtTotalPrice.Text + " €");
                    }
                    else
                    {
                        FormMain.dbConnexion.Open();
                        string commandText = @"INSERT INTO cryptowallet (CW_UID, CW_C_SYMBOL) VALUES(?id_user,?symbol); SELECT LAST_INSERT_ID();";
                        MySqlCommand cmdCredit = new MySqlCommand(commandText, FormMain.dbConnexion);
                        cmdCredit.Parameters.AddWithValue("id_user", FormMain.user.Get_Id());
                        cmdCredit.Parameters.AddWithValue("symbol", crypto.symbol);
                        int cw_id = int.Parse(cmdCredit.ExecuteScalar().ToString());
                        FormMain.dbConnexion.Close();

                        Cryptowallet newWallet = new Cryptowallet(cw_id, crypto.symbol, 0);
                        FormMain.user.GetWallets().Add(newWallet);

                        cheque.CryptoBuy(TxtTotalPrice.Text);
                        newWallet.BuyCrypto(float.Parse(TxtUnitsToTrade.Text.Replace(",", ".")), crypto);
                        MessageBox.Show("Vous venez d'acheter " + TxtUnitsToTrade.Text + " " + crypto.symbol + " pour " + TxtTotalPrice.Text + " €");

                        CryptoReceipt receipt = new CryptoReceipt(DateTime.Now.ToString("ddd' 'dd' 'MMM' 'yyyy"), DateTime.Now.ToString("HH':'mm':'ss"), FormMain.user.Get_Id().ToString(), FormMain.user.Get_Name().ToString(), FormMain.user.Get_Firstname().ToString(), FormMain.thisTerminal.getId(), "ACHAT", crypto.name, crypto.price_eur, TxtUnitsToTrade.Text, TxtTotalPrice.Text);
                        receipt.buildReceipt();
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

using FulBank;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.classes
{
    ///<summary>Class Cryptowallet contains the Cryptowallet's data (symbol, amount)
    ///</summary>
    public class Cryptowallet
    {
        private int _id;
        private string _symbol;
        private float _amount;

        ///<summary>Public Cryptowallet is the constructor of the Cryptowallet class
        ///</summary>
        public Cryptowallet(int id, string symbol, float amount)
        {
            _id = id;
            _symbol = symbol;
            _amount = amount;
        }

        public Cryptowallet()
        {

        }
        public string GetSymbol()
        {
            return _symbol;
        }
        public float GetAmount()
        {
            return _amount;
        }
        public void sellCrypto(float amount, Cryptocurrency crypto)
        {
            FormMain.dbConnexion.Open();
            string commandText = @"UPDATE cryptowallet SET CW_AMOUNT = CW_AMOUNT - '" + amount + "' WHERE CW_UID = '"+ FormMain.user.Get_Id() +"'";
            MySqlCommand cmdCredit = new MySqlCommand(commandText, FormMain.dbConnexion);
            cmdCredit.ExecuteNonQuery();

            string cmdText = @"INSERT INTO crypto_trade(`WALLET_ID`, `TRADE_TYPE`, `CURRENCY_VALUE`, `CURRENCY_AMOUNT`, `TOTAL_PRICE`, `TRADE_DATE`) 
                            VALUES (?wallet, ?type,?value,?amount,?total,?date)";
            MySqlCommand cmd = new MySqlCommand(cmdText, FormMain.dbConnexion);
            cmd.Parameters.AddWithValue("wallet", this._id);
            cmd.Parameters.AddWithValue("type", 0);
            cmd.Parameters.AddWithValue("value", crypto.price_eur.Replace(",","."));
            cmd.Parameters.AddWithValue("amount", amount);
            cmd.Parameters.AddWithValue("total", (amount * double.Parse(crypto.price_eur)));
            cmd.Parameters.AddWithValue("date", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            cmd.ExecuteNonQuery();
            FormMain.dbConnexion.Close();

            _amount -= amount;
        }
        public void BuyCrypto(float amount, Cryptocurrency crypto)
        {
            FormMain.dbConnexion.Open();
            string commandText = @"UPDATE cryptowallet SET CW_AMOUNT = CW_AMOUNT + '" + amount + "' WHERE CW_UID = '" + FormMain.user.Get_Id() + "'";
            MySqlCommand cmdCredit = new MySqlCommand(commandText, FormMain.dbConnexion);
            cmdCredit.ExecuteNonQuery();

            string cmdText = @"INSERT INTO crypto_trade(`WALLET_ID`, `TRADE_TYPE`, `CURRENCY_VALUE`, `CURRENCY_AMOUNT`, `TOTAL_PRICE`, `TRADE_DATE`) 
                            VALUES (?wallet, ?type,?value,?amount,?total,?date)";
            MySqlCommand cmd = new MySqlCommand(cmdText, FormMain.dbConnexion);
            cmd.Parameters.AddWithValue("wallet", this._id);
            cmd.Parameters.AddWithValue("type", 1);
            cmd.Parameters.AddWithValue("value", crypto.price_eur.Replace(",", "."));
            cmd.Parameters.AddWithValue("amount", amount);
            cmd.Parameters.AddWithValue("total", (amount * double.Parse(crypto.price_eur)));
            cmd.Parameters.AddWithValue("date", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            cmd.ExecuteNonQuery();
            FormMain.dbConnexion.Close();

            _amount += amount;

        }

        public int getId()
        {
            return this._id;
        }
    }
}

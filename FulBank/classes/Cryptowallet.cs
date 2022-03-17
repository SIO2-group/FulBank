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
        private string _symbol;
        private float _amount;

        ///<summary>Public Cryptowallet is the constructor of the Cryptowallet class
        ///</summary>
        public Cryptowallet(string symbol, float amount)
        {
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
        public void sellCrypto(float amount)
        {
            FormMain.dbConnexion.Open();
            string commandText = @"UPDATE cryptowallet SET CW_AMOUNT = CW_AMOUNT - '" + amount + "' WHERE CW_UID = '"+ FormMain.user.Get_Id() +"'";
            MySqlCommand cmdCredit = new MySqlCommand(commandText, FormMain.dbConnexion);
            cmdCredit.ExecuteNonQuery();
            FormMain.dbConnexion.Close();
            _amount -= amount;
        }
        public void BuyCrypto(float amount)
        {
            FormMain.dbConnexion.Open();
            string commandText = @"UPDATE cryptowallet SET CW_AMOUNT = CW_AMOUNT + '" + amount + "' WHERE CW_UID = '" + FormMain.user.Get_Id() + "'";
            MySqlCommand cmdCredit = new MySqlCommand(commandText, FormMain.dbConnexion);
            cmdCredit.ExecuteNonQuery();
            FormMain.dbConnexion.Close();
            _amount += amount;

        }
        public void SendCrypto(string Id, float amount)
        {
            _amount -= amount;
        }
    }
}

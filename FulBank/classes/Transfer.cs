using FulBank;
using MySql.Data.MySqlClient;
using System;


namespace Fulbank.classes
{
    public class Transfer
    {
        private double _amount;
        private Account _accountFrom;
        private Account _accountTo;
        private Beneficiary _beneficiary;
        private DateTime _date;

        public Transfer(double amount, DateTime date, Account accountFrom, Account accountTo)
        {
            _amount = amount;
            _accountFrom = accountFrom;
            _accountTo = accountTo;
            _date = date;
            _beneficiary = new Beneficiary();
        }

        public Transfer(double amount, DateTime date, Account accountFrom, Account accountTo, Beneficiary aBeneficiary)
        {
            _amount = amount;
            _accountFrom = accountFrom;
            _accountTo = accountTo;
            _beneficiary = aBeneficiary;
            _date = date;
        }


        internal void sendToAccount()
        {
            FormMain.dbConnexion.Open();
            string terminalId = FormMain.thisTerminal.getId();

            string commandTextTransferSend = "INSERT INTO transaction(T_ID_ACCOUNT_TO, T_ID_ACCOUNT_FROM, T_AMOUNT, T_DATE, T_TL_ID) VALUES('" + _accountTo.Get_Id() + "', '" + _accountFrom.Get_Id() + "','" + _amount + "', '" + _date.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "', '" + terminalId + "' )";
            MySqlCommand cmdGetUserAccounts = new MySqlCommand(commandTextTransferSend, FormMain.dbConnexion);
            cmdGetUserAccounts.ExecuteNonQuery();
            _accountFrom.OperationDebit(_amount);

            string commandText = "UPDATE `account` SET `A_BALANCE` = `A_BALANCE` - " + _amount + " WHERE `A_ID` = " + _accountFrom.Get_Id();
            MySqlCommand cmd = new MySqlCommand(commandText, FormMain.dbConnexion);
            cmd.ExecuteNonQuery();
            _accountTo.OperationDeposit(_amount);

            string commandText2 = "UPDATE `account` SET `A_BALANCE` = `A_BALANCE` + " + _amount + " WHERE `A_ID` = " + _accountTo.Get_Id();
            MySqlCommand cmd2 = new MySqlCommand(commandText2, FormMain.dbConnexion);
            cmd2.ExecuteNonQuery();

            FormMain.dbConnexion.Close();
        }

        internal void sendToBeneficiary()
        {
            FormMain.dbConnexion.Open();
            string terminalId = FormMain.thisTerminal.getId();

            string commandTextTransferSend = "INSERT INTO transaction(T_ID_ACCOUNT_TO, T_ID_ACCOUNT_FROM, T_AMOUNT, T_DATE, T_TL_ID) VALUES('" + _beneficiary.getBeneficiaryId() + "', '" + _accountFrom.Get_Id() + "','" + _amount + "', '" + _date.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "', '" + terminalId + "' )";
            MySqlCommand cmdGetUserAccounts = new MySqlCommand(commandTextTransferSend, FormMain.dbConnexion);
            cmdGetUserAccounts.ExecuteNonQuery();

            string commandText = "UPDATE `account` SET `A_BALANCE` = `A_BALANCE` - " + _amount + " WHERE `A_ID` = " + _accountFrom.Get_Id();
            MySqlCommand cmd = new MySqlCommand(commandText, FormMain.dbConnexion);
            cmd.ExecuteNonQuery();
            _accountFrom.OperationDebit(_amount);

            string commandText2 = "UPDATE `account` SET `A_BALANCE` = `A_BALANCE` + " + _amount + " WHERE `A_ID` = " + _beneficiary.getBeneficiaryId();
            MySqlCommand cmd2 = new MySqlCommand(commandText2, FormMain.dbConnexion);
            cmd2.ExecuteNonQuery();

            Console.Write(commandTextTransferSend);

            FormMain.dbConnexion.Close();
        }

        public double getAmount()
        {
            return _amount;
        }

        public Account getAccountFrom()
        {
            return _accountFrom;
        }
        public Account getAccountTo()
        {
            return _accountTo;
        }
        public Beneficiary getBeneficiaryTo()
        {
            return _beneficiary;
        }

        public DateTime getDate()
        {
            return _date;
        }

    }

}

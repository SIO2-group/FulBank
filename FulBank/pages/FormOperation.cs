using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fulbank.classes;
using MySql.Data.MySqlClient;
using FulBank;

namespace Fulbank.pages
{
    public partial class FormOperation : Form
    {
       
        private User user; static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        //MySqlConnection dbConnexion = FormMain.getConnexion();

        public FormOperation(User aUser)
        {
            InitializeComponent();
            user = aUser;
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private void FormOperation_Load(object sender, EventArgs e)
        {

        }

        

        private void buttonDebit_Click(object sender, EventArgs e)
        {
            Account cheque = new Account();
            foreach (Account compte in user.GetAccounts())
            {
                if (compte.Get_AccountType().Get_Label() == "COMPTE CHEQUE")
                {
                    cheque = compte;
                }
            }


            double balance = cheque.Get_Balance();
            

            if (!String.IsNullOrWhiteSpace(OperationValue.Text) && double.Parse(OperationValue.Text) > 0)
            {

                double amount = double.Parse(OperationValue.Text);
                double result = balance - amount;


                if (result > cheque.Get_Limit())
                {
                    dbConnexion.Open();
                    string commandTexttestDebit = "UPDATE account SET A_BALANCE = '" + result + "'WHERE A_ID_ACCOUNTTYPE = 1 AND A_ID_USER ='" + user.Get_Id() + "'";
                    MySqlCommand cmdtestDebit = new MySqlCommand(commandTexttestDebit, dbConnexion);
                    MySqlDataReader drDebit = cmdtestDebit.ExecuteReader();
                    cheque.Debit(amount);
                    MessageBox.Show("Retrait de " + amount + " € effectué");

                    dbConnexion.Close();
                    dbConnexion.Open();
                    string commandTextInsert = "INSERT INTO operation(`OP_AMOUNT`, `OP_ISDEBIT`, OP_ID_TERMINAL, OP_ID_ACCOUNT, `OP_DATE`) VALUES(" + amount + ",1, 1,'" + cheque.Get_Id() + "','" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "' )";
                    MySqlCommand cmdtestInsert = new MySqlCommand(commandTextInsert, dbConnexion);
                    cmdtestInsert.ExecuteNonQuery();
                    dbConnexion.Close();
                }
                else
                {
                    MessageBox.Show("Vous dépassez votre limite de découvert");
                }

            }
            else
            {
                MessageBox.Show("Saisissez un montant positif");
            }
           

        }

        private void Operation_TextChanged(object sender, EventArgs e)
        {
            
           
            

        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            Account cheque = new Account();
            foreach(Account compte in user.GetAccounts())
            {
                if(compte.Get_AccountType().Get_Label() == "COMPTE CHEQUE")
                {
                    cheque = compte;
                }
            }

                double balance = cheque.Get_Balance();
           if (!String.IsNullOrWhiteSpace(OperationValue.Text) && double.Parse(OperationValue.Text) > 0)
            {

                double amount = double.Parse(OperationValue.Text);

                double result = balance + amount;

            if (result < cheque.Get_AccountType().Get_Limit())
            {

                dbConnexion.Open();
                string commandTexttestDeposit = "UPDATE account SET A_BALANCE = '" + result + "'WHERE A_ID_ACCOUNTTYPE = 1 AND A_ID_USER ='" + user.Get_Id() + "'";
                MySqlCommand cmdtestDeposit = new MySqlCommand(commandTexttestDeposit, dbConnexion);
                MySqlDataReader drDeposit = cmdtestDeposit.ExecuteReader();
                cheque.Deposit(amount);
                MessageBox.Show("Dépôt de " + amount + " € effectué");
                dbConnexion.Close();

                dbConnexion.Open();
                string commandTextInsert = "INSERT INTO operation(`OP_AMOUNT`, `OP_ISDEBIT`, OP_ID_TERMINAL, OP_ID_ACCOUNT, `OP_DATE`) VALUES(" + amount + ",0, 1,'" + cheque.Get_Id() + "','" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "' )";
                MySqlCommand cmdtestInsert = new MySqlCommand(commandTextInsert, dbConnexion);
                cmdtestInsert.ExecuteNonQuery();
                dbConnexion.Close();

                
            }
            else
            {
                MessageBox.Show("Vous dépassez le plafond de votre compte");
            }
           }
           else
            {
                MessageBox.Show("Saisissez un montant positif");
            }
        }

        private void buttonOperationHistory_Click(object sender, EventArgs e)
        {
            FormMain.ListFormMenu[3].BringToFront();
        }
    }
    }


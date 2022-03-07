﻿using System;
using System.Windows.Forms;
using Fulbank.classes;
using MySql.Data.MySqlClient;
using FulBank;

namespace Fulbank.pages
{
    public partial class FormOperation : Form
    {

        public FormOperation()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private void FormOperation_Load(object sender, EventArgs e)
        {

        }



        private void buttonDebit_Click(object sender, EventArgs e)
        {
            FormMain.user.getAccountsDico().TryGetValue("COMPTE CHEQUE", out Account cheque);

            double balance = cheque.Get_Balance();

            if (!String.IsNullOrWhiteSpace(OperationValue.Text.Replace(".",",")) && double.Parse(OperationValue.Text.Replace(".",",")) > 0)
            {

                double amount = double.Parse(OperationValue.Text.Replace(".", ","));
                double result = balance - amount;


                if (result > cheque.Get_Limit())
                {
                    FormMain.dbConnexion.Open();

                    string commandTexttestDebit = "UPDATE account SET A_BALANCE = '" + result.ToString().Replace(",",".") + "' WHERE A_ID_ACCOUNTTYPE = 1 AND A_ID_USER ='" + FormMain.user.Get_Id() + "'";
                    MySqlCommand cmdtestDebit = new MySqlCommand(commandTexttestDebit, FormMain.dbConnexion);
                    MySqlDataReader drDebit = cmdtestDebit.ExecuteReader();
                    FormMain.dbConnexion.Close();
                    cheque.OperationDebit(amount);

                    string terminalId = FormMain.thisTerminal.getId();
                    FormMain.dbConnexion.Open();
                    MessageBox.Show(terminalId);
                    string commandTextInsert = "INSERT INTO operation(`OP_AMOUNT`, `OP_ISDEBIT`, OP_ID_TERMINAL, OP_ID_ACCOUNT, `OP_DATE`) VALUES(" + amount + ",1, '"+terminalId+"','" + cheque.Get_Id() + "','" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "' )";
                    MySqlCommand cmdtestInsert = new MySqlCommand(commandTextInsert, FormMain.dbConnexion);
                    cmdtestInsert.ExecuteNonQuery();
                    FormMain.dbConnexion.Close();


                    OperationReceipt receipt = new OperationReceipt(DateTime.Now.ToString("ddd' 'dd' 'MMM' 'yyyy' 'HH':'mm':'ss"), FormMain.user.Get_Id().ToString(), FormMain.thisTerminal.getCP(), FormMain.thisTerminal.getCity(), FormMain.thisTerminal.getBuilding(), "DÉBIT", amount.ToString());
                    receipt.buildReceipt();

                    MessageBox.Show("Retrait de " + amount + " € effectué");

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
            FormMain.user.getAccountsDico().TryGetValue("COMPTE CHEQUE", out Account cheque);
            double balance = cheque.Get_Balance();
           if (!String.IsNullOrWhiteSpace(OperationValue.Text) && double.Parse(OperationValue.Text) > 0)
            {

                double amount = double.Parse(OperationValue.Text);

                double result = balance + amount;

            if (result < cheque.Get_AccountType().Get_Limit())
            {

                FormMain.dbConnexion.Open();

                string commandTexttestDeposit = "UPDATE account SET A_BALANCE = '" + result.ToString().Replace(",",".") + "' WHERE A_ID_ACCOUNTTYPE = 1 AND A_ID_USER ='" + FormMain.user.Get_Id() + "'";
                MySqlCommand cmdtestDeposit = new MySqlCommand(commandTexttestDeposit, FormMain.dbConnexion);
                MySqlDataReader drDeposit = cmdtestDeposit.ExecuteReader();
                cheque.OperationDeposit(amount);

                FormMain.dbConnexion.Close();
                string terminalId = FormMain.thisTerminal.getId();
                FormMain.dbConnexion.Open();
                string commandTextInsert = "INSERT INTO operation(`OP_AMOUNT`, `OP_ISDEBIT`, OP_ID_TERMINAL, OP_ID_ACCOUNT, `OP_DATE`) VALUES(" + amount + ",0,'" + terminalId + "' ,'" + cheque.Get_Id() + "','" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "' )";
                MySqlCommand cmdtestInsert = new MySqlCommand(commandTextInsert, FormMain.dbConnexion);
                cmdtestInsert.ExecuteNonQuery();
                FormMain.dbConnexion.Close();

                OperationReceipt receipt = new OperationReceipt(DateTime.Now.ToString("ddd' 'dd' 'MMM' 'yyyy' 'HH':'mm':'ss"), FormMain.user.Get_Id().ToString(), FormMain.thisTerminal.getCP(), FormMain.thisTerminal.getCity(), FormMain.thisTerminal.getBuilding(), "DÉPOT", amount.ToString());
                receipt.buildReceipt();

                MessageBox.Show("Dépôt de " + amount + " € effectué");
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

        private void OperationValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

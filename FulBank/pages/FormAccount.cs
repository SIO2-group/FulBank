﻿using Fulbank.classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fulbank.pages
{
    public partial class FormAccount : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        // MySqlConnection dbConnexion = FormMain.getConnexion();
        private User user;
        List<Panel> panelsAccounts = new List<Panel>();
        public FormAccount(User AUser)
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            user = AUser;
            AccountsLoad();
        }

        private void panelAccounts_Paint(object sender, PaintEventArgs e)
        {

        }


        public void AccountsLoad()
        {
            panelsAccounts.Add(panelAccount1);
            panelsAccounts.Add(panelAccount2);
            panelsAccounts.Add(panelAccount3);
            panelsAccounts.Add(panelAccount4);
            int i = 0;
            foreach(Account account in user.GetAccounts())
            {
                    switch (i)
                    {
                        case 0:
                            UserAccountName.Text = account.Get_AccountType().Get_Label() ;
                            AccountOwner.Text = user.Get_Name() + "  " + user.Get_Firstname();
                            AccountNumber.Text = account.Get_Id().ToString();
                            AccountBalance.Text = account.Get_Balance().ToString();
                            break;
                        case 1:
                            UserAccountName.Text = account.Get_AccountType().Get_Label();
                            AccountOwner.Text = user.Get_Name() + "  " + user.Get_Firstname();
                            AccountNumber.Text = account.Get_Id().ToString();
                            AccountBalance.Text = account.Get_Balance().ToString();
                        break;
                        case 2:
                            UserAccountName.Text = account.Get_AccountType().Get_Label();
                            AccountOwner.Text = user.Get_Name() + "  " + user.Get_Firstname();
                            AccountNumber.Text = account.Get_Id().ToString();
                            AccountBalance.Text = account.Get_Balance().ToString();
                        break;
                        case 3:
                            UserAccountName.Text = account.Get_AccountType().Get_Label();
                            AccountOwner.Text = user.Get_Name() + "  " + user.Get_Firstname();
                            AccountNumber.Text = account.Get_Id().ToString();
                            AccountBalance.Text = account.Get_Balance().ToString();
                        break;
                        default: MessageBox.Show("aucun compte assigné à l'utilisateur");
                            break;
                    }

                i++;
            }
        }
    }
}
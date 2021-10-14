using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Fulbank.pages
{
    public partial class FormAccount : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        // MySqlConnection dbConnexion = FormMain.getConnexion();
        private string _userId;
        List<Panel> panelsAccounts = new List<Panel>();
        public FormAccount(string AnUserId)
        {
            InitializeComponent();
            _userId = AnUserId;
            this.Text = String.Empty;
            this.ControlBox = false;
            AccountsLoad();
        }

        private void panelAccounts_Paint(object sender, PaintEventArgs e)
        {
            
        }


        public void AccountsLoad()
        {
            dbConnexion.Open();
            panelsAccounts.Add(panelAccount1);
            panelsAccounts.Add(panelAccount2);
            panelsAccounts.Add(panelAccount3);
            panelsAccounts.Add(panelAccount4);
            string commandTextCompte = "SELECT Count(*) FROM user INNER JOIN own ON user.P_ID = own.P_ID INNER JOIN account ON own.A_ID = account.A_ID WHERE user.P_ID ='" + _userId + "'";
            MySqlCommand cmdCompte = new MySqlCommand(commandTextCompte, dbConnexion);
            int compte = int.Parse(cmdCompte.ExecuteScalar().ToString());
            int i = 0;

            dbConnexion.Close();
            dbConnexion.Open();

            string commandTextTestUser = "SELECT A_NAME, P_NAME, account.A_ID, A_BALANCE FROM user INNER JOIN own ON user.P_ID = own.P_ID INNER JOIN account ON own.A_ID = account.A_ID WHERE user.P_ID ='" + _userId + "'";
            MySqlCommand cmdUser = new MySqlCommand(commandTextTestUser, dbConnexion);
            MySqlDataReader dr = cmdUser.ExecuteReader();
            do
            {
                panelsAccounts[i].Show();
                if (dr.Read())
                {
                    switch (i)
                    {
                        case 0:
                            UserAccountName.Text = dr[0].ToString();
                            AccountOwner.Text = dr[1].ToString();
                            AccountNumber.Text = dr[2].ToString();
                            AccountBalance.Text = dr[3].ToString();
                            break;
                        case 1:
                            UserAccountName2.Text = dr[0].ToString();
                            AccountOwner2.Text = dr[1].ToString();
                            AccountNumber2.Text = dr[2].ToString();
                            AccountBalance2.Text = dr[3].ToString();
                            break;
                        case 2:
                            UserAccountName3.Text = dr[0].ToString();
                            AccountOwner3.Text = dr[1].ToString();
                            AccountNumber3.Text = dr[2].ToString();
                            AccountBalance3.Text = dr[3].ToString();
                            break;
                        case 3:
                            UserAccountName4.Text = dr[0].ToString();
                            AccountOwner4.Text = dr[1].ToString();
                            AccountNumber4.Text = dr[2].ToString();
                            AccountBalance4.Text = dr[3].ToString();
                            break;
                    }


                }
                else
                {
                    MessageBox.Show("auccun compte assigné à l'utilisateur");
                }

                i = i + 1;
            } while (i != compte);

            dbConnexion.Close();
        }
    }
}

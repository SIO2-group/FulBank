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
using FulBank;
using MySql.Data.MySqlClient;

namespace Fulbank.pages
{
    public partial class FormOperationHistory : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        public FormOperationHistory()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private void FormOperationHistory_Load(object sender, EventArgs e)
        {
            //go through the accounts of the connected user
            foreach (Account account in FormMain.user.GetAccounts())
            {
                //runs through the operations related to the account
                foreach (Operation op in account.getOperation())
                {
                    string result = "";
                    if (op.Get_debit() == true)
                    {
                        result = "Débit";

                    }
                    else
                    {
                        result = "Crédit";
                       
                    }
                    //adding an operation
                    dgvOperation.Rows.Add(result,op.Get_amount(), op.Get_date());
                
                }
            }
            foreach(DataGridViewRow row in dgvOperation.Rows)
            {
                if(row.Cells[0].Value.ToString() == "Débit")
                {
                    row.Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    row.Cells[1].Style.ForeColor = Color.ForestGreen;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvOperation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        
    }
}

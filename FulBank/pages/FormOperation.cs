using Fulbank.classes;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Fulbank.pages
{
    public partial class FormOperation : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        // MySqlConnection dbConnexion = FormMain.getConnexion();
        private User user;
        public FormOperation(User AUser)
        {
            InitializeComponent();
            user = AUser;
            this.Text = String.Empty;
            this.ControlBox = false;

        }

        private void FormOperation_Load(object sender, EventArgs e)
        {

        }


        private void buttonDebit_Click(object sender, EventArgs e)
        {
            dbConnexion.Open();
            dbConnexion.Close();
        }

        private void OperationValue_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(OperationValue.Text) && OperationValue.Text == "0.00")
            {
                OperationValue.Text = "0.00";
            }
        }
    }
}

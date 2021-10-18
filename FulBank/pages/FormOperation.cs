using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Fulbank.pages
{
    public partial class FormOperation : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        // MySqlConnection dbConnexion = FormMain.getConnexion();
        private string _userId;
        public FormOperation(string AnUserId)
        {
            InitializeComponent();
            _userId = AnUserId;
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private void FormOperation_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDebit_Click(object sender, EventArgs e)
        {
            dbConnexion.Open();
            dbConnexion.Close();
        }
    }
}

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
        private User user;
        public FormOperationHistory(User aUser)
        {
            InitializeComponent();
            user = aUser;
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private void FormOperationHistory_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dbConnexion.Open();
            
        }
    }
}

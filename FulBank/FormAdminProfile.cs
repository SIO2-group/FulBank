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
using System.Text.RegularExpressions;

namespace Fulbank.pages
{
    public partial class FormAdminProfile : Form
    {
        private string _userId;
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        public FormAdminProfile(string userId)
        {
            InitializeComponent();
            this.Text = String.Empty;
            _userId = userId;
        }

        private void FormAdminProfile_Load(object sender, EventArgs e)
        {

        }
    }
}

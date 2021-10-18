using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Fulbank.pages
{
    public partial class FormAdminProfile : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        // MySqlConnection dbConnexion = FormMain.getConnexion();
        private string _userId;
        public FormAdminProfile(string aUserId)
        {
            InitializeComponent();
            _userId = aUserId;
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private void PanelAdminProfile_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

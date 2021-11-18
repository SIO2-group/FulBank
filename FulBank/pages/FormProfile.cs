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
using Form = System.Windows.Forms.Form;

namespace Fulbank.pages
{
    public partial class FormProfile : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        // MySqlConnection dbConnexion = FormMain.getConnexion();
        private User user;
        List<Panel> panelsAccounts = new List<Panel>();
        
        public FormProfile(User AUser)
        {
            InitializeComponent();
            user = AUser;
            this.Text = String.Empty;
            this.ControlBox = false;
            
        }

        private void OwnerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfilePhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Profile_Load(object sender, EventArgs e)
        {
            OwnerName.Text = user.Get_Name() + "  " + user.Get_Firstname();
            ProfilePhoneNumber.Text = user.Get_phone();
            ProfileAdress.Text = user.Get_address();
            ProfileLandlineNumber.Text = user.Get_homePhone();
            ProfileMail.Text = user.Get_email();

        }

        private void BtnChangePhone_Click(object sender, EventArgs e)
        {
            new FormChangePhone(user).Show();
        }

        private void BtnChangeAdress_Click(object sender, EventArgs e)
        {
            new FormChangeAdress(user).Show();
        }

        private void BtnChangeLandLine_Click(object sender, EventArgs e)
        {
            new FormChangeLandLine(user).Show();
        }

        private void BtnChangeMail_Click(object sender, EventArgs e)
        {
            new FormChangeMail(user).Show();
        }

        private void PanelUserProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            
        }
    }
}

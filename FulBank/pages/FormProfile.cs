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
       
        List<Panel> panelsAccounts = new List<Panel>();
        
        public FormProfile()
        {
            InitializeComponent();
           
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
            OwnerName.Text =FormMain.user.Get_Name() + "  " +FormMain.user.Get_Firstname();
            ProfilePhoneNumber.Text =FormMain.user.Get_phone();
            ProfileAdress.Text =FormMain.user.Get_address();
            ProfileLandlineNumber.Text =FormMain.user.Get_homePhone();
            ProfileMail.Text =FormMain.user.Get_email();

        }

        private void BtnChangePhone_Click(object sender, EventArgs e)
        {
            new FormChangePhone().Show();
        }

        private void BtnChangeAdress_Click(object sender, EventArgs e)
        {
            new FormChangeAdress().Show();
        }

        private void BtnChangeLandLine_Click(object sender, EventArgs e)
        {
            new FormChangeLandLine().Show();
        }

        private void BtnChangeMail_Click(object sender, EventArgs e)
        {
            new FormChangeMail().Show();
        }

        private void PanelUserProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            OwnerName.Text = FormMain.user.Get_Name() + "  " + FormMain.user.Get_Firstname();
            ProfilePhoneNumber.Text = FormMain.user.Get_phone();
            ProfileAdress.Text = FormMain.user.Get_address();
            ProfileLandlineNumber.Text = FormMain.user.Get_homePhone();
            ProfileMail.Text = FormMain.user.Get_email();

        }

        private void BtnChangePassWord_Click(object sender, EventArgs e)
        {
            new FormChangePassword().Show();
        }
    }
}

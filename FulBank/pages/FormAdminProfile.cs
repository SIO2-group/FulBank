using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using FulBank;

namespace Fulbank.pages
{
    public partial class FormAdminProfile : Form
    {
        public FormAdminProfile()
        {
            InitializeComponent();
           
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private void PanelAdminProfile_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}

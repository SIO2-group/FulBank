using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulbank
{
    public partial class FormAdmin : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int Index;

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            PanelAdminProfile.BringToFront();
        }

        private void MenuCreateAccount_Click(object sender, EventArgs e)
        {
            PanelAdminCreate.Show();
            PanelAdminCreate.BringToFront();
            PanelAdminProfile.Hide();
        }

        private void MenuProfil_Click(object sender, EventArgs e)
        {
            PanelAdminCreate.Hide();
            PanelAdminProfile.Show();
            PanelAdminProfile.BringToFront();
        }


    }
}

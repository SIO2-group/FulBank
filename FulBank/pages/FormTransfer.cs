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

namespace Fulbank.pages
{
    public partial class FormTransfer : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        // MySqlConnection dbConnexion = FormMain.getConnexion();
        private User user;
        List<Panel> panelsAccounts = new List<Panel>();
        private const int CB_SETCUEBANNER = 0x1703;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

        public FormTransfer(User AUser)
        {
            InitializeComponent();
           user = AUser;
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            SendMessage(this.ComboAccountsFrom.Handle, CB_SETCUEBANNER, 0, "Depuis le compte");
            SendMessage(this.ComboAccountsTo.Handle, CB_SETCUEBANNER, 0, "Vers le compte");
        }

        private void ComboAccountsFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboAccountsTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAddBeneficiary_Click(object sender, EventArgs e)
        {
            new FormAddBeneficiary(user).Show();
        }
    }
}

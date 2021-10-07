using Fulbank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FulBank
{

    public partial class FormMain: System.Windows.Forms.Form
    {
        private string _userId;
        public FormMain(string userId)
        {
            InitializeComponent();
            _userId = userId;
        }
        

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void MenuAccounts_Click(object sender, EventArgs e)
        {

        }
    }
}
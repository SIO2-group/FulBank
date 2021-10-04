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
<<<<<<< HEAD:FulBank/FormMain.cs
    public partial class FormMain: System.Windows.Forms.Form
    {
        public FormMain()
=======
    public partial class Form: System.Windows.Forms.Form
    {
        public Form()
>>>>>>> 97108627a8fb3289aaf9e738b3e384e153c3544e:FulBank/FormPrincipal.cs
        {
            InitializeComponent();
            FormConnexion form2 = new FormConnexion();
        }

        private void MenuComptes_Click(object sender, EventArgs e)
        {
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
    }
}
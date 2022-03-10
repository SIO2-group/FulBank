using Fulbank.classes;
using FulBank;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fulbank.pages
{
    public partial class FormAccount : Form
    {
        static string dsnConnexion = "server=localhost;database=fulbank;uid=root;password='';SSL MODE='None'"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnexion = new MySqlConnection(dsnConnexion);
        List<Panel> panelList = new List<Panel>();
        // MySqlConnection dbConnexion = FormMain.getConnexion();
        public FormAccount()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            AccountsLoad();
        }

        private void panelAccounts_Paint(object sender, PaintEventArgs e)
        {

        }


        public void AccountsLoad()
        {     
            int i = 25;
            int y = 25;
            foreach(Panel panel in panelList)
            {
                panelAccounts.Controls.Remove(panel);
            }
            panelList.Clear();
            foreach(Account account in FormMain.user.GetAccounts())
            {
                Panel panelAccount1 = new System.Windows.Forms.Panel();
                Label label1 = new System.Windows.Forms.Label();
                TextBox UserAccountName = new System.Windows.Forms.TextBox();
                TextBox AccountOwner = new System.Windows.Forms.TextBox();
                TextBox AccountNumber = new System.Windows.Forms.TextBox();
                TextBox AccountBalance = new System.Windows.Forms.TextBox();
                // 
                // panelAccount1
                // 
                panelAccount1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
                panelAccount1.Controls.Add( label1);
                panelAccount1.Controls.Add( UserAccountName);
                panelAccount1.Controls.Add( AccountOwner);
                panelAccount1.Controls.Add( AccountNumber);
                panelAccount1.Controls.Add( AccountBalance);
                panelAccount1.Location = new System.Drawing.Point(43, y);
                panelAccount1.Name = "panelAccount_"+i;
                panelAccount1.Size = new System.Drawing.Size(614, 85);
                panelAccount1.TabIndex = 14;
                panelAccount1.Paint += new System.Windows.Forms.PaintEventHandler( panelAccount1_Paint);

                panelAccounts.Controls.Add(panelAccount1);
                panelList.Add(panelAccount1);
                // 
                // label1
                // 
                 label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
                 label1.AutoSize = true;
                 label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                 label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
                 label1.Location = new System.Drawing.Point(548, 16);
                 label1.Name = "label_"+i;
                 label1.Size = new System.Drawing.Size(49, 54);
                 label1.TabIndex = 14;
                 label1.Text = "€";
                // 
                // UserAccountName
                // 
                 UserAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
                 UserAccountName.BorderStyle = System.Windows.Forms.BorderStyle.None;
                 UserAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                 UserAccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
                 UserAccountName.Location = new System.Drawing.Point(13, 3);
                 UserAccountName.Name = "UserAccountName_" + i;
                 UserAccountName.ReadOnly = true;
                 UserAccountName.Size = new System.Drawing.Size(220, 23);
                 UserAccountName.TabIndex = 3;
                 UserAccountName.TabStop = false;
                 UserAccountName.Text = account.Get_AccountType().Get_Label();
                // 
                // AccountOwner
                // 
                 AccountOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
                 AccountOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
                 AccountOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                 AccountOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
                 AccountOwner.Location = new System.Drawing.Point(13, 32);
                 AccountOwner.Name = "AccountOwner_" + i;
                 AccountOwner.ReadOnly = true;
                 AccountOwner.Size = new System.Drawing.Size(156, 16);
                 AccountOwner.TabIndex = 13;
                 AccountOwner.TabStop = false;
                 AccountOwner.Text = FormMain.user.Get_Name()+" "+FormMain.user.Get_Firstname();
                 AccountOwner.TextChanged += new System.EventHandler( AccountOwner_TextChanged);
                // 
                // AccountNumber
                // 
                 AccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
                 AccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
                 AccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                 AccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
                 AccountNumber.Location = new System.Drawing.Point(13, 54);
                 AccountNumber.Name = "AccountNumber_" + i;
                 AccountNumber.ReadOnly = true;
                 AccountNumber.Size = new System.Drawing.Size(165, 16);
                 AccountNumber.TabIndex = 12;
                 AccountNumber.TabStop = false;
                 AccountNumber.Text = account.Get_Id().ToString();
                // 
                // AccountBalance
                // 
                 AccountBalance.Anchor = System.Windows.Forms.AnchorStyles.Right;
                 AccountBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
                 AccountBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
                 AccountBalance.Cursor = System.Windows.Forms.Cursors.Default;
                 AccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                 AccountBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
                 AccountBalance.Location = new System.Drawing.Point(239, 17);
                 AccountBalance.Name = "AccountBalance_" + i;
                 AccountBalance.ReadOnly = true;
                 AccountBalance.ShortcutsEnabled = false;
                 AccountBalance.Size = new System.Drawing.Size(308, 53);
                 AccountBalance.TabIndex = 11;
                 AccountBalance.Text = account.Get_Balance().ToString();
                 AccountBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

                y += 100;
                i++;
            }
        }

        private void panelAccount1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            AccountsLoad();
        }

        private void AccountOwner_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

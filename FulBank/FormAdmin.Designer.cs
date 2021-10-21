
namespace Fulbank
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.MenuProfil = new System.Windows.Forms.Button();
            this.MenuTerminalConfig = new System.Windows.Forms.Button();
            this.MenuCreateAccount = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.panelMenu.Controls.Add(this.MenuProfil);
            this.panelMenu.Controls.Add(this.MenuTerminalConfig);
            this.panelMenu.Controls.Add(this.MenuCreateAccount);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(213, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // MenuProfil
            // 
            this.MenuProfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuProfil.FlatAppearance.BorderSize = 0;
            this.MenuProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProfil.ForeColor = System.Drawing.Color.White;
            this.MenuProfil.Location = new System.Drawing.Point(0, 200);
            this.MenuProfil.Name = "MenuProfil";
            this.MenuProfil.Size = new System.Drawing.Size(213, 60);
            this.MenuProfil.TabIndex = 7;
            this.MenuProfil.Text = "Mon Profil";
            this.MenuProfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuProfil.UseVisualStyleBackColor = true;
            this.MenuProfil.Click += new System.EventHandler(this.MenuProfil_Click);
            // 
            // MenuTerminalConfig
            // 
            this.MenuTerminalConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTerminalConfig.FlatAppearance.BorderSize = 0;
            this.MenuTerminalConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuTerminalConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTerminalConfig.ForeColor = System.Drawing.Color.White;
            this.MenuTerminalConfig.Location = new System.Drawing.Point(0, 140);
            this.MenuTerminalConfig.Name = "MenuTerminalConfig";
            this.MenuTerminalConfig.Size = new System.Drawing.Size(213, 60);
            this.MenuTerminalConfig.TabIndex = 6;
            this.MenuTerminalConfig.Text = "Configuration Borne";
            this.MenuTerminalConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuTerminalConfig.UseVisualStyleBackColor = true;
            this.MenuTerminalConfig.Click += new System.EventHandler(this.MenuTerminalConfig_Click);
            // 
            // MenuCreateAccount
            // 
            this.MenuCreateAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuCreateAccount.FlatAppearance.BorderSize = 0;
            this.MenuCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCreateAccount.ForeColor = System.Drawing.Color.White;
            this.MenuCreateAccount.Location = new System.Drawing.Point(0, 80);
            this.MenuCreateAccount.Name = "MenuCreateAccount";
            this.MenuCreateAccount.Size = new System.Drawing.Size(213, 60);
            this.MenuCreateAccount.TabIndex = 1;
            this.MenuCreateAccount.Text = "Crée un compte";
            this.MenuCreateAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuCreateAccount.UseVisualStyleBackColor = true;
            this.MenuCreateAccount.Click += new System.EventHandler(this.MenuCreateAccount_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.CausesValidation = false;
            this.panelLogo.Controls.Add(this.textBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(213, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CausesValidation = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.MaxLength = 5;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(213, 80);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ADMIN";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(213, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 80);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(213, 80);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(587, 370);
            this.panelAdmin.TabIndex = 3;
            this.panelAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdmin_Paint);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(816, 491);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button MenuCreateAccount;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button MenuTerminalConfig;
        private System.Windows.Forms.Button MenuProfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAdmin;
    }
}
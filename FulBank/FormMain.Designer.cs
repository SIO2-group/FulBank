namespace FulBank
{
    partial class FormMain
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
            this.MenuCrypto = new System.Windows.Forms.Button();
            this.MenuOperations = new System.Windows.Forms.Button();
            this.MenuVirement = new System.Windows.Forms.Button();
            this.MenuComptes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.panelMenu.Controls.Add(this.MenuProfil);
            this.panelMenu.Controls.Add(this.MenuCrypto);
            this.panelMenu.Controls.Add(this.MenuOperations);
            this.panelMenu.Controls.Add(this.MenuVirement);
            this.panelMenu.Controls.Add(this.MenuComptes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(213, 492);
            this.panelMenu.TabIndex = 0;
            // 
            // MenuProfil
            // 
            this.MenuProfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuProfil.FlatAppearance.BorderSize = 0;
            this.MenuProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProfil.ForeColor = System.Drawing.Color.White;
            this.MenuProfil.Location = new System.Drawing.Point(0, 320);
            this.MenuProfil.Name = "MenuProfil";
            this.MenuProfil.Size = new System.Drawing.Size(213, 60);
            this.MenuProfil.TabIndex = 5;
            this.MenuProfil.Text = "Mon Profil";
            this.MenuProfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuProfil.UseVisualStyleBackColor = true;
            // 
            // MenuCrypto
            // 
            this.MenuCrypto.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuCrypto.FlatAppearance.BorderSize = 0;
            this.MenuCrypto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuCrypto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCrypto.ForeColor = System.Drawing.Color.White;
            this.MenuCrypto.Location = new System.Drawing.Point(0, 260);
            this.MenuCrypto.Name = "MenuCrypto";
            this.MenuCrypto.Size = new System.Drawing.Size(213, 60);
            this.MenuCrypto.TabIndex = 4;
            this.MenuCrypto.Text = "Cryptomonnaies";
            this.MenuCrypto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuCrypto.UseVisualStyleBackColor = true;
            // 
            // MenuOperations
            // 
            this.MenuOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuOperations.FlatAppearance.BorderSize = 0;
            this.MenuOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuOperations.ForeColor = System.Drawing.Color.White;
            this.MenuOperations.Location = new System.Drawing.Point(0, 200);
            this.MenuOperations.Name = "MenuOperations";
            this.MenuOperations.Size = new System.Drawing.Size(213, 60);
            this.MenuOperations.TabIndex = 3;
            this.MenuOperations.Text = "Retrait / Dépot";
            this.MenuOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuOperations.UseVisualStyleBackColor = true;
            // 
            // MenuVirement
            // 
            this.MenuVirement.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuVirement.FlatAppearance.BorderSize = 0;
            this.MenuVirement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuVirement.ForeColor = System.Drawing.Color.White;
            this.MenuVirement.Location = new System.Drawing.Point(0, 140);
            this.MenuVirement.Name = "MenuVirement";
            this.MenuVirement.Size = new System.Drawing.Size(213, 60);
            this.MenuVirement.TabIndex = 2;
            this.MenuVirement.Text = "Virements";
            this.MenuVirement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuVirement.UseVisualStyleBackColor = true;
            // 
            // MenuComptes
            // 
            this.MenuComptes.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuComptes.FlatAppearance.BorderSize = 0;
            this.MenuComptes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuComptes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuComptes.ForeColor = System.Drawing.Color.White;
            this.MenuComptes.Image = global::Fulbank.Properties.Resources.logo_comptes;
            this.MenuComptes.Location = new System.Drawing.Point(0, 80);
            this.MenuComptes.Name = "MenuComptes";
            this.MenuComptes.Size = new System.Drawing.Size(213, 60);
            this.MenuComptes.TabIndex = 1;
            this.MenuComptes.Text = "Mes Comptes";
            this.MenuComptes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuComptes.UseVisualStyleBackColor = true;
            this.MenuComptes.Click += new System.EventHandler(this.MenuComptes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.panelLogo.BackgroundImage = global::Fulbank.Properties.Resources.FULBANK;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.CausesValidation = false;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(213, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 492);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(988, 533);
            this.Name = "FormMain";
            this.Text = "Fulbank - Main";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button MenuComptes;
        private System.Windows.Forms.Button MenuProfil;
        private System.Windows.Forms.Button MenuCrypto;
        private System.Windows.Forms.Button MenuOperations;
        private System.Windows.Forms.Button MenuVirement;
    }
}
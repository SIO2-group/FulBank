﻿namespace FulBank
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.MenuProfil = new System.Windows.Forms.Button();
            this.MenuCrypto = new System.Windows.Forms.Button();
            this.MenuOperations = new System.Windows.Forms.Button();
            this.MenuVirement = new System.Windows.Forms.Button();
            this.MenuAccounts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureLogout = new System.Windows.Forms.PictureBox();
            this.LabelSection = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.panelMenu.Controls.Add(this.panel6);
            this.panelMenu.Controls.Add(this.MenuProfil);
            this.panelMenu.Controls.Add(this.MenuCrypto);
            this.panelMenu.Controls.Add(this.MenuOperations);
            this.panelMenu.Controls.Add(this.MenuVirement);
            this.panelMenu.Controls.Add(this.MenuAccounts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(213, 548);
            this.panelMenu.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(213, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(756, 468);
            this.panel6.TabIndex = 17;
            // 
            // MenuProfil
            // 
            this.MenuProfil.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.MenuProfil.Click += new System.EventHandler(this.MenuProfil_Click);
            // 
            // MenuCrypto
            // 
            this.MenuCrypto.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.MenuCrypto.Click += new System.EventHandler(this.MenuCrypto_Click);
            // 
            // MenuOperations
            // 
            this.MenuOperations.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.MenuOperations.Click += new System.EventHandler(this.MenuOperations_Click);
            // 
            // MenuVirement
            // 
            this.MenuVirement.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.MenuVirement.Click += new System.EventHandler(this.MenuVirement_Click);
            // 
            // MenuAccounts
            // 
            this.MenuAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuAccounts.FlatAppearance.BorderSize = 0;
            this.MenuAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAccounts.ForeColor = System.Drawing.Color.White;
            this.MenuAccounts.Image = global::Fulbank.Properties.Resources.logo_comptes;
            this.MenuAccounts.Location = new System.Drawing.Point(0, 80);
            this.MenuAccounts.Name = "MenuAccounts";
            this.MenuAccounts.Size = new System.Drawing.Size(213, 60);
            this.MenuAccounts.TabIndex = 1;
            this.MenuAccounts.Text = "Mes Comptes";
            this.MenuAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuAccounts.UseVisualStyleBackColor = true;
            this.MenuAccounts.Click += new System.EventHandler(this.MenuAccounts_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.PictureLogout);
            this.panel1.Controls.Add(this.LabelSection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(213, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 80);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PictureLogout
            // 
            this.PictureLogout.BackgroundImage = global::Fulbank.Properties.Resources.Logout;
            this.PictureLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureLogout.Location = new System.Drawing.Point(710, 13);
            this.PictureLogout.Name = "PictureLogout";
            this.PictureLogout.Size = new System.Drawing.Size(53, 55);
            this.PictureLogout.TabIndex = 1;
            this.PictureLogout.TabStop = false;
            this.PictureLogout.Click += new System.EventHandler(this.PictureLogout_Click);
            // 
            // LabelSection
            // 
            this.LabelSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSection.AutoSize = true;
            this.LabelSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSection.Location = new System.Drawing.Point(252, 21);
            this.LabelSection.Name = "LabelSection";
            this.LabelSection.Size = new System.Drawing.Size(221, 42);
            this.LabelSection.TabIndex = 0;
            this.LabelSection.Text = "Titre section";
            this.LabelSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelSection.Click += new System.EventHandler(this.LabelSection_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(213, 80);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(775, 468);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(988, 548);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(988, 533);
            this.Name = "FormMain";
            this.Text = "Fulbank - Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button MenuAccounts;
        private System.Windows.Forms.Button MenuProfil;
        private System.Windows.Forms.Button MenuCrypto;
        private System.Windows.Forms.Button MenuOperations;
        private System.Windows.Forms.Button MenuVirement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox PictureLogout;
        private System.Windows.Forms.Label LabelSection;
    }
}
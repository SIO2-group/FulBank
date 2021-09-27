
namespace Fulbank
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.MenuComptes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.panelMenu.Controls.Add(this.MenuComptes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 584);
            this.panelMenu.TabIndex = 0;
            // 
            // MenuComptes
            // 
            this.MenuComptes.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuComptes.FlatAppearance.BorderSize = 0;
            this.MenuComptes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuComptes.ForeColor = System.Drawing.Color.White;
            this.MenuComptes.Image = global::Fulbank.Properties.Resources.logo_comptes;
            this.MenuComptes.Location = new System.Drawing.Point(0, 80);
            this.MenuComptes.Name = "MenuComptes";
            this.MenuComptes.Size = new System.Drawing.Size(220, 60);
            this.MenuComptes.TabIndex = 1;
            this.MenuComptes.Text = "Mes Comptes";
            this.MenuComptes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuComptes.UseVisualStyleBackColor = true;
            this.MenuComptes.Click += new System.EventHandler(this.MenuComptes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 584);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button MenuComptes;
    }
}


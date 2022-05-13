
namespace Fulbank
{
    partial class FormConnexion
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
            this.TextUsername = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.LabelConnexion = new System.Windows.Forms.Label();
            this.ButtonValider = new System.Windows.Forms.Button();
            this.CheckboxShowPassword = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TextUsername
            // 
            this.TextUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUsername.Location = new System.Drawing.Point(309, 172);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.Size = new System.Drawing.Size(221, 23);
            this.TextUsername.TabIndex = 0;
            this.TextUsername.TextChanged += new System.EventHandler(this.TextUsername_TextChanged);
            // 
            // TextPassword
            // 
            this.TextPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.Location = new System.Drawing.Point(309, 233);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(221, 23);
            this.TextPassword.TabIndex = 1;
            this.TextPassword.UseSystemPasswordChar = true;
            this.TextPassword.TextChanged += new System.EventHandler(this.TextPassword_TextChanged);
            // 
            // LabelConnexion
            // 
            this.LabelConnexion.AutoSize = true;
            this.LabelConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.LabelConnexion.Location = new System.Drawing.Point(239, 68);
            this.LabelConnexion.Name = "LabelConnexion";
            this.LabelConnexion.Size = new System.Drawing.Size(363, 63);
            this.LabelConnexion.TabIndex = 2;
            this.LabelConnexion.Text = "CONNEXION";
            // 
            // ButtonValider
            // 
            this.ButtonValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ButtonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonValider.Location = new System.Drawing.Point(309, 286);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.Size = new System.Drawing.Size(221, 33);
            this.ButtonValider.TabIndex = 3;
            this.ButtonValider.Text = "Valider";
            this.ButtonValider.UseVisualStyleBackColor = false;
            this.ButtonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // CheckboxShowPassword
            // 
            this.CheckboxShowPassword.AutoSize = true;
            this.CheckboxShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxShowPassword.Location = new System.Drawing.Point(309, 259);
            this.CheckboxShowPassword.Name = "CheckboxShowPassword";
            this.CheckboxShowPassword.Size = new System.Drawing.Size(164, 21);
            this.CheckboxShowPassword.TabIndex = 5;
            this.CheckboxShowPassword.Text = "Afficher mot de passe";
            this.CheckboxShowPassword.UseVisualStyleBackColor = true;
            this.CheckboxShowPassword.CheckedChanged += new System.EventHandler(this.CheckboxShowPassword_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(304, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Identifiant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(304, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mot de Passe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.panel1.BackgroundImage = global::Fulbank.Properties.Resources.logofulbank;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 420);
            this.panel1.TabIndex = 10;
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckboxShowPassword);
            this.Controls.Add(this.ButtonValider);
            this.Controls.Add(this.LabelConnexion);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextUsername);
            this.Name = "FormConnexion";
            this.Text = "FormConnexion";
            this.Load += new System.EventHandler(this.FormConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextUsername;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label LabelConnexion;
        private System.Windows.Forms.Button ButtonValider;
        private System.Windows.Forms.CheckBox CheckboxShowPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}
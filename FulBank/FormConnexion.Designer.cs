
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
            this.SuspendLayout();
            // 
            // TextUsername
            // 
            this.TextUsername.Location = new System.Drawing.Point(337, 147);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.Size = new System.Drawing.Size(221, 20);
            this.TextUsername.TabIndex = 0;
            this.TextUsername.TextChanged += new System.EventHandler(this.TextUsername_TextChanged);
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(337, 199);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(221, 20);
            this.TextPassword.TabIndex = 1;
            this.TextPassword.UseSystemPasswordChar = true;
            // 
            // LabelConnexion
            // 
            this.LabelConnexion.AutoSize = true;
            this.LabelConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConnexion.Location = new System.Drawing.Point(304, 69);
            this.LabelConnexion.Name = "LabelConnexion";
            this.LabelConnexion.Size = new System.Drawing.Size(307, 52);
            this.LabelConnexion.TabIndex = 2;
            this.LabelConnexion.Text = "CONNEXION";
            // 
            // ButtonValider
            // 
            this.ButtonValider.Location = new System.Drawing.Point(404, 260);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.Size = new System.Drawing.Size(75, 23);
            this.ButtonValider.TabIndex = 3;
            this.ButtonValider.Text = "Valider";
            this.ButtonValider.UseVisualStyleBackColor = true;
            this.ButtonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 492);
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
    }
}
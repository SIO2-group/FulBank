
namespace Fulbank.pages
{
    partial class FormAdminProfile
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
            this.PanelAdminProfile = new System.Windows.Forms.Panel();
            this.ProfilePanelPassword = new System.Windows.Forms.Panel();
            this.ProfilePassword = new System.Windows.Forms.TextBox();
            this.ProfilePasswordTitle = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.OwnerName = new System.Windows.Forms.TextBox();
            this.BtnChangePassWord = new System.Windows.Forms.Button();
            this.PanelAdminProfile.SuspendLayout();
            this.ProfilePanelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAdminProfile
            // 
            this.PanelAdminProfile.AutoScroll = true;
            this.PanelAdminProfile.BackColor = System.Drawing.Color.White;
            this.PanelAdminProfile.Controls.Add(this.ProfilePanelPassword);
            this.PanelAdminProfile.Controls.Add(this.textBox10);
            this.PanelAdminProfile.Controls.Add(this.OwnerName);
            this.PanelAdminProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAdminProfile.Location = new System.Drawing.Point(0, 0);
            this.PanelAdminProfile.Name = "PanelAdminProfile";
            this.PanelAdminProfile.Size = new System.Drawing.Size(656, 405);
            this.PanelAdminProfile.TabIndex = 4;
            this.PanelAdminProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelAdminProfile_Paint);
            // 
            // ProfilePanelPassword
            // 
            this.ProfilePanelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfilePanelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePanelPassword.Controls.Add(this.BtnChangePassWord);
            this.ProfilePanelPassword.Controls.Add(this.ProfilePassword);
            this.ProfilePanelPassword.Controls.Add(this.ProfilePasswordTitle);
            this.ProfilePanelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfilePanelPassword.Location = new System.Drawing.Point(38, 148);
            this.ProfilePanelPassword.Name = "ProfilePanelPassword";
            this.ProfilePanelPassword.Size = new System.Drawing.Size(481, 33);
            this.ProfilePanelPassword.TabIndex = 6;
            // 
            // ProfilePassword
            // 
            this.ProfilePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfilePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfilePassword.Location = new System.Drawing.Point(127, 3);
            this.ProfilePassword.Multiline = true;
            this.ProfilePassword.Name = "ProfilePassword";
            this.ProfilePassword.Size = new System.Drawing.Size(142, 24);
            this.ProfilePassword.TabIndex = 4;
            // 
            // ProfilePasswordTitle
            // 
            this.ProfilePasswordTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfilePasswordTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfilePasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilePasswordTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfilePasswordTitle.Location = new System.Drawing.Point(3, 6);
            this.ProfilePasswordTitle.Multiline = true;
            this.ProfilePasswordTitle.Name = "ProfilePasswordTitle";
            this.ProfilePasswordTitle.Size = new System.Drawing.Size(142, 27);
            this.ProfilePasswordTitle.TabIndex = 3;
            this.ProfilePasswordTitle.Text = "Mot de passe :";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Window;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.textBox10.Location = new System.Drawing.Point(38, 114);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(181, 19);
            this.textBox10.TabIndex = 7;
            this.textBox10.Text = "Sécurité";
            // 
            // OwnerName
            // 
            this.OwnerName.BackColor = System.Drawing.SystemColors.Window;
            this.OwnerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.OwnerName.Location = new System.Drawing.Point(38, 54);
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Size = new System.Drawing.Size(181, 19);
            this.OwnerName.TabIndex = 0;
            this.OwnerName.Text = "{{nom du propriétaire}}";
            // 
            // BtnChangePassWord
            // 
            this.BtnChangePassWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangePassWord.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnChangePassWord.FlatAppearance.BorderSize = 0;
            this.BtnChangePassWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangePassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangePassWord.Location = new System.Drawing.Point(427, 0);
            this.BtnChangePassWord.Margin = new System.Windows.Forms.Padding(0);
            this.BtnChangePassWord.Name = "BtnChangePassWord";
            this.BtnChangePassWord.Size = new System.Drawing.Size(52, 31);
            this.BtnChangePassWord.TabIndex = 9;
            this.BtnChangePassWord.Text = ">";
            this.BtnChangePassWord.UseVisualStyleBackColor = true;
            this.BtnChangePassWord.Click += new System.EventHandler(this.BtnChangePassWord_Click);
            // 
            // FormAdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 405);
            this.Controls.Add(this.PanelAdminProfile);
            this.Name = "FormAdminProfile";
            this.Text = "FormAdminProfile";
            this.Load += new System.EventHandler(this.FormAdminProfile_Load);
            this.PanelAdminProfile.ResumeLayout(false);
            this.PanelAdminProfile.PerformLayout();
            this.ProfilePanelPassword.ResumeLayout(false);
            this.ProfilePanelPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAdminProfile;
        private System.Windows.Forms.Panel ProfilePanelPassword;
        private System.Windows.Forms.TextBox ProfilePassword;
        private System.Windows.Forms.TextBox ProfilePasswordTitle;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox OwnerName;
        private System.Windows.Forms.Button BtnChangePassWord;
    }
}

namespace Fulbank.pages
{
    partial class FormChangePassword
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
            this.buttonReturn = new System.Windows.Forms.Button();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.textNewPassword = new System.Windows.Forms.TextBox();
            this.textOldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InvalidPassword = new System.Windows.Forms.Label();
            this.InvalidPasswordConfirmation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(15, 221);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(94, 32);
            this.buttonReturn.TabIndex = 23;
            this.buttonReturn.Text = "Annuler";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.btnNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassword.Location = new System.Drawing.Point(138, 221);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(94, 32);
            this.btnNewPassword.TabIndex = 22;
            this.btnNewPassword.Text = "Modifier";
            this.btnNewPassword.UseVisualStyleBackColor = false;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            // 
            // textNewPassword
            // 
            this.textNewPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textNewPassword.Location = new System.Drawing.Point(40, 113);
            this.textNewPassword.Name = "textNewPassword";
            this.textNewPassword.PasswordChar = '*';
            this.textNewPassword.Size = new System.Drawing.Size(136, 20);
            this.textNewPassword.TabIndex = 21;
            // 
            // textOldPassword
            // 
            this.textOldPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textOldPassword.Location = new System.Drawing.Point(40, 48);
            this.textOldPassword.Name = "textOldPassword";
            this.textOldPassword.PasswordChar = '*';
            this.textOldPassword.Size = new System.Drawing.Size(136, 20);
            this.textOldPassword.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Entrez votre nouveau mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Entrez votre ancien mot de passe";
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.textConfirmPassword.Location = new System.Drawing.Point(40, 185);
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.PasswordChar = '*';
            this.textConfirmPassword.Size = new System.Drawing.Size(136, 20);
            this.textConfirmPassword.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(37, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Confirmez votre nouveau mot de passe";
            // 
            // InvalidPassword
            // 
            this.InvalidPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvalidPassword.AutoSize = true;
            this.InvalidPassword.ForeColor = System.Drawing.Color.Red;
            this.InvalidPassword.Location = new System.Drawing.Point(182, 116);
            this.InvalidPassword.Name = "InvalidPassword";
            this.InvalidPassword.Size = new System.Drawing.Size(142, 13);
            this.InvalidPassword.TabIndex = 27;
            this.InvalidPassword.Text = "Mot de passe non conforme!";
            this.InvalidPassword.Visible = false;
            // 
            // InvalidPasswordConfirmation
            // 
            this.InvalidPasswordConfirmation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvalidPasswordConfirmation.AutoSize = true;
            this.InvalidPasswordConfirmation.ForeColor = System.Drawing.Color.Red;
            this.InvalidPasswordConfirmation.Location = new System.Drawing.Point(189, 185);
            this.InvalidPasswordConfirmation.Name = "InvalidPasswordConfirmation";
            this.InvalidPasswordConfirmation.Size = new System.Drawing.Size(135, 13);
            this.InvalidPasswordConfirmation.TabIndex = 28;
            this.InvalidPasswordConfirmation.Text = "Confirmation non identique!";
            this.InvalidPasswordConfirmation.Visible = false;
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 265);
            this.Controls.Add(this.InvalidPasswordConfirmation);
            this.Controls.Add(this.InvalidPassword);
            this.Controls.Add(this.textConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.btnNewPassword);
            this.Controls.Add(this.textNewPassword);
            this.Controls.Add(this.textOldPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChangePassword";
            this.Text = "FormChangePassword";
            this.Load += new System.EventHandler(this.FormChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button btnNewPassword;
        private System.Windows.Forms.TextBox textNewPassword;
        private System.Windows.Forms.TextBox textOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label InvalidPassword;
        private System.Windows.Forms.Label InvalidPasswordConfirmation;
    }
}
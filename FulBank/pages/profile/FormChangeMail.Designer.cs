
namespace Fulbank.pages
{
    partial class FormChangeMail
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
            this.btnNewMail = new System.Windows.Forms.Button();
            this.textNewMail = new System.Windows.Forms.TextBox();
            this.textOldMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InvalidMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(84, 162);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(94, 32);
            this.buttonReturn.TabIndex = 17;
            this.buttonReturn.Text = "Annuler";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // btnNewMail
            // 
            this.btnNewMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.btnNewMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMail.Location = new System.Drawing.Point(273, 162);
            this.btnNewMail.Name = "btnNewMail";
            this.btnNewMail.Size = new System.Drawing.Size(94, 32);
            this.btnNewMail.TabIndex = 16;
            this.btnNewMail.Text = "Modifier";
            this.btnNewMail.UseVisualStyleBackColor = false;
            this.btnNewMail.Click += new System.EventHandler(this.btnNewMail_Click);
            // 
            // textNewMail
            // 
            this.textNewMail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textNewMail.Location = new System.Drawing.Point(262, 94);
            this.textNewMail.Name = "textNewMail";
            this.textNewMail.Size = new System.Drawing.Size(124, 20);
            this.textNewMail.TabIndex = 15;
            // 
            // textOldMail
            // 
            this.textOldMail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textOldMail.Location = new System.Drawing.Point(69, 94);
            this.textOldMail.Name = "textOldMail";
            this.textOldMail.ReadOnly = true;
            this.textOldMail.Size = new System.Drawing.Size(124, 20);
            this.textOldMail.TabIndex = 14;
            this.textOldMail.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(259, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nouvelle Adresse Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(66, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adresse Mail Actuelle";
            // 
            // InvalidMail
            // 
            this.InvalidMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvalidMail.AutoSize = true;
            this.InvalidMail.ForeColor = System.Drawing.Color.Red;
            this.InvalidMail.Location = new System.Drawing.Point(259, 117);
            this.InvalidMail.Name = "InvalidMail";
            this.InvalidMail.Size = new System.Drawing.Size(108, 13);
            this.InvalidMail.TabIndex = 25;
            this.InvalidMail.Text = "Adresse mail invalide!";
            this.InvalidMail.Visible = false;
            // 
            // FormChangeMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 251);
            this.Controls.Add(this.InvalidMail);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.btnNewMail);
            this.Controls.Add(this.textNewMail);
            this.Controls.Add(this.textOldMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChangeMail";
            this.Text = "FormChangeMail";
            this.Load += new System.EventHandler(this.FormChangeMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button btnNewMail;
        private System.Windows.Forms.TextBox textNewMail;
        private System.Windows.Forms.TextBox textOldMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InvalidMail;
    }
}
﻿
namespace Fulbank.pages
{
    partial class FormChangePhone
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textOldPhone = new System.Windows.Forms.TextBox();
            this.textNewPhone = new System.Windows.Forms.TextBox();
            this.btnNewPhone = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.InvalidPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(54, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Téléphone Actuel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(229, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nouveau Téléphone";
            // 
            // textOldPhone
            // 
            this.textOldPhone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textOldPhone.Location = new System.Drawing.Point(57, 94);
            this.textOldPhone.Name = "textOldPhone";
            this.textOldPhone.ReadOnly = true;
            this.textOldPhone.Size = new System.Drawing.Size(124, 20);
            this.textOldPhone.TabIndex = 2;
            this.textOldPhone.TabStop = false;
            // 
            // textNewPhone
            // 
            this.textNewPhone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textNewPhone.Location = new System.Drawing.Point(232, 94);
            this.textNewPhone.Name = "textNewPhone";
            this.textNewPhone.Size = new System.Drawing.Size(124, 20);
            this.textNewPhone.TabIndex = 3;
            // 
            // btnNewPhone
            // 
            this.btnNewPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.btnNewPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPhone.Location = new System.Drawing.Point(241, 155);
            this.btnNewPhone.Name = "btnNewPhone";
            this.btnNewPhone.Size = new System.Drawing.Size(94, 32);
            this.btnNewPhone.TabIndex = 4;
            this.btnNewPhone.Text = "Modifier";
            this.btnNewPhone.UseVisualStyleBackColor = false;
            this.btnNewPhone.Click += new System.EventHandler(this.btnNewPhone_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(71, 155);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(94, 32);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.Text = "Annuler";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // InvalidPhone
            // 
            this.InvalidPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvalidPhone.AutoSize = true;
            this.InvalidPhone.ForeColor = System.Drawing.Color.Red;
            this.InvalidPhone.Location = new System.Drawing.Point(228, 117);
            this.InvalidPhone.Name = "InvalidPhone";
            this.InvalidPhone.Size = new System.Drawing.Size(129, 13);
            this.InvalidPhone.TabIndex = 23;
            this.InvalidPhone.Text = "Téléphone non conforme!";
            this.InvalidPhone.Visible = false;
            // 
            // FormChangePhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 240);
            this.Controls.Add(this.InvalidPhone);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.btnNewPhone);
            this.Controls.Add(this.textNewPhone);
            this.Controls.Add(this.textOldPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChangePhone";
            this.Text = "FormChangePhone";
            this.Load += new System.EventHandler(this.FormChangePhone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOldPhone;
        private System.Windows.Forms.TextBox textNewPhone;
        private System.Windows.Forms.Button btnNewPhone;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label InvalidPhone;
    }
}
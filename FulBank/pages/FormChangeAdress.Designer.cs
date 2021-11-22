
namespace Fulbank.pages
{
    partial class FormChangeAdress
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
            this.btnNewAdress = new System.Windows.Forms.Button();
            this.textNewAdress = new System.Windows.Forms.TextBox();
            this.textOldAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(48, 26);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(67, 22);
            this.buttonReturn.TabIndex = 11;
            this.buttonReturn.Text = "Retour";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // btnNewAdress
            // 
            this.btnNewAdress.Location = new System.Drawing.Point(250, 176);
            this.btnNewAdress.Name = "btnNewAdress";
            this.btnNewAdress.Size = new System.Drawing.Size(94, 32);
            this.btnNewAdress.TabIndex = 10;
            this.btnNewAdress.Text = "Modifier";
            this.btnNewAdress.UseVisualStyleBackColor = true;
            this.btnNewAdress.Click += new System.EventHandler(this.btnNewAdress_Click);
            // 
            // textNewAdress
            // 
            this.textNewAdress.Location = new System.Drawing.Point(250, 108);
            this.textNewAdress.Name = "textNewAdress";
            this.textNewAdress.Size = new System.Drawing.Size(136, 20);
            this.textNewAdress.TabIndex = 9;
            // 
            // textOldAdress
            // 
            this.textOldAdress.Enabled = false;
            this.textOldAdress.Location = new System.Drawing.Point(57, 108);
            this.textOldAdress.Name = "textOldAdress";
            this.textOldAdress.Size = new System.Drawing.Size(124, 20);
            this.textOldAdress.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nouvelle Adresse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adresse Actuelle";
            // 
            // FormChangeAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 258);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.btnNewAdress);
            this.Controls.Add(this.textNewAdress);
            this.Controls.Add(this.textOldAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChangeAdress";
            this.Text = "FormChangeAdress";
            this.Load += new System.EventHandler(this.FormChangeAdress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button btnNewAdress;
        private System.Windows.Forms.TextBox textNewAdress;
        private System.Windows.Forms.TextBox textOldAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
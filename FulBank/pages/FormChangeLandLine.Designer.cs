
namespace Fulbank.pages
{
    partial class FormChangeLandLine
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
            this.btnNewLandLine = new System.Windows.Forms.Button();
            this.textNewLandLine = new System.Windows.Forms.TextBox();
            this.textOldLandLine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(65, 25);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(67, 22);
            this.buttonReturn.TabIndex = 17;
            this.buttonReturn.Text = "Retour";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // btnNewLandLine
            // 
            this.btnNewLandLine.Location = new System.Drawing.Point(258, 182);
            this.btnNewLandLine.Name = "btnNewLandLine";
            this.btnNewLandLine.Size = new System.Drawing.Size(94, 32);
            this.btnNewLandLine.TabIndex = 16;
            this.btnNewLandLine.Text = "Modifier";
            this.btnNewLandLine.UseVisualStyleBackColor = true;
            this.btnNewLandLine.Click += new System.EventHandler(this.btnNewLandLine_Click);
            // 
            // textNewLandLine
            // 
            this.textNewLandLine.Location = new System.Drawing.Point(258, 114);
            this.textNewLandLine.Name = "textNewLandLine";
            this.textNewLandLine.Size = new System.Drawing.Size(136, 20);
            this.textNewLandLine.TabIndex = 15;
            this.textNewLandLine.TextChanged += new System.EventHandler(this.textNewLandLine_TextChanged);
            // 
            // textOldLandLine
            // 
            this.textOldLandLine.Enabled = false;
            this.textOldLandLine.Location = new System.Drawing.Point(65, 114);
            this.textOldLandLine.Name = "textOldLandLine";
            this.textOldLandLine.Size = new System.Drawing.Size(124, 20);
            this.textOldLandLine.TabIndex = 14;
            this.textOldLandLine.TextChanged += new System.EventHandler(this.textOldLandLine_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nouveau Téléphone Fixe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Téléphone Fixe Actuel";
            // 
            // FormChangeLandLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 259);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.btnNewLandLine);
            this.Controls.Add(this.textNewLandLine);
            this.Controls.Add(this.textOldLandLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChangeLandLine";
            this.Text = "FormChangeLandLine";
            this.Load += new System.EventHandler(this.FormLandLine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button btnNewLandLine;
        private System.Windows.Forms.TextBox textNewLandLine;
        private System.Windows.Forms.TextBox textOldLandLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
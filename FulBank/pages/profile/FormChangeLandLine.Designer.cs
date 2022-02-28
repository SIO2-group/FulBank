
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
            this.InvalidLandline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(79, 160);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(94, 32);
            this.buttonReturn.TabIndex = 17;
            this.buttonReturn.Text = "Annuler";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // btnNewLandLine
            // 
            this.btnNewLandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.btnNewLandLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewLandLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLandLine.Location = new System.Drawing.Point(272, 160);
            this.btnNewLandLine.Name = "btnNewLandLine";
            this.btnNewLandLine.Size = new System.Drawing.Size(94, 32);
            this.btnNewLandLine.TabIndex = 16;
            this.btnNewLandLine.Text = "Modifier";
            this.btnNewLandLine.UseVisualStyleBackColor = false;
            this.btnNewLandLine.Click += new System.EventHandler(this.btnNewLandLine_Click);
            // 
            // textNewLandLine
            // 
            this.textNewLandLine.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textNewLandLine.Location = new System.Drawing.Point(259, 93);
            this.textNewLandLine.Name = "textNewLandLine";
            this.textNewLandLine.Size = new System.Drawing.Size(124, 20);
            this.textNewLandLine.TabIndex = 15;
            this.textNewLandLine.TextChanged += new System.EventHandler(this.textNewLandLine_TextChanged);
            // 
            // textOldLandLine
            // 
            this.textOldLandLine.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textOldLandLine.Location = new System.Drawing.Point(66, 93);
            this.textOldLandLine.Name = "textOldLandLine";
            this.textOldLandLine.ReadOnly = true;
            this.textOldLandLine.Size = new System.Drawing.Size(124, 20);
            this.textOldLandLine.TabIndex = 14;
            this.textOldLandLine.TabStop = false;
            this.textOldLandLine.TextChanged += new System.EventHandler(this.textOldLandLine_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(256, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nouveau Téléphone Fixe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(63, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Téléphone Fixe Actuel";
            // 
            // InvalidLandline
            // 
            this.InvalidLandline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvalidLandline.AutoSize = true;
            this.InvalidLandline.ForeColor = System.Drawing.Color.Red;
            this.InvalidLandline.Location = new System.Drawing.Point(256, 116);
            this.InvalidLandline.Name = "InvalidLandline";
            this.InvalidLandline.Size = new System.Drawing.Size(129, 13);
            this.InvalidLandline.TabIndex = 24;
            this.InvalidLandline.Text = "Téléphone non conforme!";
            this.InvalidLandline.Visible = false;
            // 
            // FormChangeLandLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 259);
            this.Controls.Add(this.InvalidLandline);
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
        private System.Windows.Forms.Label InvalidLandline;
    }
}
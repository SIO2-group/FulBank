
namespace Fulbank.pages.Crypto
{
    partial class FormTrade
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
            this.labelAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.TxtTo = new System.Windows.Forms.TextBox();
            this.TxtOwnedCurrency = new System.Windows.Forms.TextBox();
            this.BtnTrade = new System.Windows.Forms.Button();
            this.labelOwnedCurrency = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.ComboBox();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(52, 177);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(157, 13);
            this.labelAmount.TabIndex = 19;
            this.labelAmount.Text = "Argent de votre compte courant";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(55, 195);
            this.txtAmount.MaxLength = 10;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(130, 20);
            this.txtAmount.TabIndex = 18;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(52, 125);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(47, 13);
            this.labelTo.TabIndex = 17;
            this.labelTo.Text = "Prix total";
            // 
            // TxtTo
            // 
            this.TxtTo.Location = new System.Drawing.Point(55, 143);
            this.TxtTo.MaxLength = 20;
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.Size = new System.Drawing.Size(130, 20);
            this.TxtTo.TabIndex = 15;
            // 
            // TxtOwnedCurrency
            // 
            this.TxtOwnedCurrency.Location = new System.Drawing.Point(55, 92);
            this.TxtOwnedCurrency.MaxLength = 10;
            this.TxtOwnedCurrency.Name = "TxtOwnedCurrency";
            this.TxtOwnedCurrency.Size = new System.Drawing.Size(130, 20);
            this.TxtOwnedCurrency.TabIndex = 14;
            this.TxtOwnedCurrency.Text = "0";
            // 
            // BtnTrade
            // 
            this.BtnTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.BtnTrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrade.ForeColor = System.Drawing.Color.White;
            this.BtnTrade.Location = new System.Drawing.Point(55, 231);
            this.BtnTrade.Name = "BtnTrade";
            this.BtnTrade.Size = new System.Drawing.Size(130, 41);
            this.BtnTrade.TabIndex = 13;
            this.BtnTrade.Text = "Envoyer";
            this.BtnTrade.UseVisualStyleBackColor = false;
            // 
            // labelOwnedCurrency
            // 
            this.labelOwnedCurrency.AutoSize = true;
            this.labelOwnedCurrency.Location = new System.Drawing.Point(52, 74);
            this.labelOwnedCurrency.Name = "labelOwnedCurrency";
            this.labelOwnedCurrency.Size = new System.Drawing.Size(97, 13);
            this.labelOwnedCurrency.TabIndex = 16;
            this.labelOwnedCurrency.Text = "Unitées possédées";
            // 
            // txtCurrency
            // 
            this.txtCurrency.FormattingEnabled = true;
            this.txtCurrency.Location = new System.Drawing.Point(55, 41);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(121, 21);
            this.txtCurrency.TabIndex = 20;
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(55, 20);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(35, 13);
            this.labelCurrency.TabIndex = 21;
            this.labelCurrency.Text = "label2";
            // 
            // FormTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 284);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelOwnedCurrency);
            this.Controls.Add(this.TxtTo);
            this.Controls.Add(this.TxtOwnedCurrency);
            this.Controls.Add(this.BtnTrade);
            this.Name = "FormTrade";
            this.Text = "FormTrade";
            this.Load += new System.EventHandler(this.FormTrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox TxtTo;
        private System.Windows.Forms.TextBox TxtOwnedCurrency;
        private System.Windows.Forms.Button BtnTrade;
        private System.Windows.Forms.Label labelOwnedCurrency;
        private System.Windows.Forms.ComboBox txtCurrency;
        private System.Windows.Forms.Label labelCurrency;
    }
}
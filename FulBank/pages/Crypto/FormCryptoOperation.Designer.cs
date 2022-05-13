
namespace Fulbank.pages.Crypto
{
    partial class FormCryptoOperation
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
            this.BtnSell = new System.Windows.Forms.Button();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.TxtUnitPrice = new System.Windows.Forms.TextBox();
            this.TxtOwnedCurrency = new System.Windows.Forms.TextBox();
            this.TxtUnitsToTrade = new System.Windows.Forms.TextBox();
            this.TxtTotalPrice = new System.Windows.Forms.TextBox();
            this.LabelUnitPrice = new System.Windows.Forms.Label();
            this.LabelOwnedCurrency = new System.Windows.Forms.Label();
            this.labelUnitsToExchange = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.labelAccountBalance = new System.Windows.Forms.Label();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSell
            // 
            this.BtnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.BtnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSell.ForeColor = System.Drawing.Color.White;
            this.BtnSell.Location = new System.Drawing.Point(27, 225);
            this.BtnSell.Name = "BtnSell";
            this.BtnSell.Size = new System.Drawing.Size(130, 41);
            this.BtnSell.TabIndex = 0;
            this.BtnSell.Text = "Vendre";
            this.BtnSell.UseVisualStyleBackColor = false;
            this.BtnSell.Click += new System.EventHandler(this.BtnSell_Click);
            // 
            // BtnBuy
            // 
            this.BtnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.BtnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuy.ForeColor = System.Drawing.Color.White;
            this.BtnBuy.Location = new System.Drawing.Point(217, 225);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(130, 41);
            this.BtnBuy.TabIndex = 1;
            this.BtnBuy.Text = "Acheter";
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.Enabled = false;
            this.TxtUnitPrice.Location = new System.Drawing.Point(27, 95);
            this.TxtUnitPrice.MaxLength = 20;
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.Size = new System.Drawing.Size(130, 20);
            this.TxtUnitPrice.TabIndex = 2;
            this.TxtUnitPrice.TextChanged += new System.EventHandler(this.TxtUnitPrice_TextChanged);
            // 
            // TxtOwnedCurrency
            // 
            this.TxtOwnedCurrency.Enabled = false;
            this.TxtOwnedCurrency.Location = new System.Drawing.Point(217, 95);
            this.TxtOwnedCurrency.MaxLength = 10;
            this.TxtOwnedCurrency.Name = "TxtOwnedCurrency";
            this.TxtOwnedCurrency.Size = new System.Drawing.Size(130, 20);
            this.TxtOwnedCurrency.TabIndex = 3;
            this.TxtOwnedCurrency.Text = "0";
            this.TxtOwnedCurrency.TextChanged += new System.EventHandler(this.TxtOwnedCurrency_TextChanged);
            // 
            // TxtUnitsToTrade
            // 
            this.TxtUnitsToTrade.Location = new System.Drawing.Point(27, 146);
            this.TxtUnitsToTrade.MaxLength = 10;
            this.TxtUnitsToTrade.Name = "TxtUnitsToTrade";
            this.TxtUnitsToTrade.Size = new System.Drawing.Size(130, 20);
            this.TxtUnitsToTrade.TabIndex = 4;
            this.TxtUnitsToTrade.TextChanged += new System.EventHandler(this.TxtUnitsToTrade_TextChanged);
            // 
            // TxtTotalPrice
            // 
            this.TxtTotalPrice.Enabled = false;
            this.TxtTotalPrice.Location = new System.Drawing.Point(217, 146);
            this.TxtTotalPrice.MaxLength = 20;
            this.TxtTotalPrice.Name = "TxtTotalPrice";
            this.TxtTotalPrice.Size = new System.Drawing.Size(130, 20);
            this.TxtTotalPrice.TabIndex = 5;
            this.TxtTotalPrice.TextChanged += new System.EventHandler(this.TxtTotalPrice_TextChanged);
            // 
            // LabelUnitPrice
            // 
            this.LabelUnitPrice.AutoSize = true;
            this.LabelUnitPrice.Location = new System.Drawing.Point(24, 77);
            this.LabelUnitPrice.Name = "LabelUnitPrice";
            this.LabelUnitPrice.Size = new System.Drawing.Size(72, 15);
            this.LabelUnitPrice.TabIndex = 6;
            this.LabelUnitPrice.Text = "Prix unitaire";
            this.LabelUnitPrice.Click += new System.EventHandler(this.LabelUnitPrice_Click);
            // 
            // LabelOwnedCurrency
            // 
            this.LabelOwnedCurrency.AutoSize = true;
            this.LabelOwnedCurrency.Location = new System.Drawing.Point(214, 77);
            this.LabelOwnedCurrency.Name = "LabelOwnedCurrency";
            this.LabelOwnedCurrency.Size = new System.Drawing.Size(112, 15);
            this.LabelOwnedCurrency.TabIndex = 7;
            this.LabelOwnedCurrency.Text = "Unitées possédées";
            this.LabelOwnedCurrency.Click += new System.EventHandler(this.LabelOwnedCurrency_Click);
            // 
            // labelUnitsToExchange
            // 
            this.labelUnitsToExchange.AutoSize = true;
            this.labelUnitsToExchange.Location = new System.Drawing.Point(24, 128);
            this.labelUnitsToExchange.Name = "labelUnitsToExchange";
            this.labelUnitsToExchange.Size = new System.Drawing.Size(114, 15);
            this.labelUnitsToExchange.TabIndex = 8;
            this.labelUnitsToExchange.Text = "Unitées à échanger";
            this.labelUnitsToExchange.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(214, 128);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(54, 15);
            this.labelTotalPrice.TabIndex = 9;
            this.labelTotalPrice.Text = "Prix total";
            this.labelTotalPrice.Click += new System.EventHandler(this.label2_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.Label.Location = new System.Drawing.Point(22, 18);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(340, 29);
            this.Label.TabIndex = 10;
            this.Label.Text = "Échangez vos crypomonnaires";
            this.Label.Click += new System.EventHandler(this.Label_Click);
            // 
            // labelAccountBalance
            // 
            this.labelAccountBalance.AutoSize = true;
            this.labelAccountBalance.Location = new System.Drawing.Point(83, 181);
            this.labelAccountBalance.Name = "labelAccountBalance";
            this.labelAccountBalance.Size = new System.Drawing.Size(176, 15);
            this.labelAccountBalance.TabIndex = 12;
            this.labelAccountBalance.Text = "Argent de votre compte courant";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Enabled = false;
            this.txtAccountBalance.Location = new System.Drawing.Point(109, 199);
            this.txtAccountBalance.MaxLength = 10;
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(130, 20);
            this.txtAccountBalance.TabIndex = 11;
            // 
            // FormCryptoOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(380, 290);
            this.Controls.Add(this.labelAccountBalance);
            this.Controls.Add(this.txtAccountBalance);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelUnitsToExchange);
            this.Controls.Add(this.LabelOwnedCurrency);
            this.Controls.Add(this.LabelUnitPrice);
            this.Controls.Add(this.TxtTotalPrice);
            this.Controls.Add(this.TxtUnitsToTrade);
            this.Controls.Add(this.TxtOwnedCurrency);
            this.Controls.Add(this.TxtUnitPrice);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.BtnSell);
            this.Name = "FormCryptoOperation";
            this.Text = "FormTrade";
            this.Load += new System.EventHandler(this.FormTrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSell;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.TextBox TxtUnitPrice;
        private System.Windows.Forms.TextBox TxtOwnedCurrency;
        private System.Windows.Forms.TextBox TxtUnitsToTrade;
        private System.Windows.Forms.TextBox TxtTotalPrice;
        private System.Windows.Forms.Label LabelUnitPrice;
        private System.Windows.Forms.Label LabelOwnedCurrency;
        private System.Windows.Forms.Label labelUnitsToExchange;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label labelAccountBalance;
        private System.Windows.Forms.TextBox txtAccountBalance;
    }
}
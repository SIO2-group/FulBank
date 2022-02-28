
namespace Fulbank.pages.Crypto
{
    partial class FormWallets
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
            this.dgvWallets = new System.Windows.Forms.DataGridView();
            this.SYMBOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNITPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALVALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWallets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWallets
            // 
            this.dgvWallets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SYMBOL,
            this.NAME,
            this.AMOUNT,
            this.UNITPRICE,
            this.TOTALVALUE});
            this.dgvWallets.Location = new System.Drawing.Point(31, 106);
            this.dgvWallets.Name = "dgvWallets";
            this.dgvWallets.RowHeadersWidth = 45;
            this.dgvWallets.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWallets.Size = new System.Drawing.Size(637, 256);
            this.dgvWallets.TabIndex = 0;
            this.dgvWallets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWallets_CellContentClick);
            // 
            // SYMBOL
            // 
            this.SYMBOL.FillWeight = 50.53099F;
            this.SYMBOL.HeaderText = "Symbole";
            this.SYMBOL.MinimumWidth = 6;
            this.SYMBOL.Name = "SYMBOL";
            // 
            // NAME
            // 
            this.NAME.FillWeight = 115.0391F;
            this.NAME.HeaderText = "Nom";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            // 
            // AMOUNT
            // 
            this.AMOUNT.FillWeight = 77.7202F;
            this.AMOUNT.HeaderText = "Quantité";
            this.AMOUNT.MinimumWidth = 6;
            this.AMOUNT.Name = "AMOUNT";
            // 
            // UNITPRICE
            // 
            this.UNITPRICE.FillWeight = 111.6259F;
            this.UNITPRICE.HeaderText = "Prix unitaire";
            this.UNITPRICE.MinimumWidth = 6;
            this.UNITPRICE.Name = "UNITPRICE";
            // 
            // TOTALVALUE
            // 
            this.TOTALVALUE.FillWeight = 145.0838F;
            this.TOTALVALUE.HeaderText = "Valeur totale";
            this.TOTALVALUE.MinimumWidth = 6;
            this.TOTALVALUE.Name = "TOTALVALUE";
            // 
            // FormWallets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 385);
            this.Controls.Add(this.dgvWallets);
            this.Name = "FormWallets";
            this.Text = "FormWallets";
            this.Load += new System.EventHandler(this.FormWallets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWallets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWallets;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYMBOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNITPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALVALUE;
    }
}
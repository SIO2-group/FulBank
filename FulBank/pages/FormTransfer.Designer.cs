
namespace Fulbank.pages
{
    partial class FormTransfer
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
            this.ComboAccountsFrom = new System.Windows.Forms.ComboBox();
            this.ComboAccountsTo = new System.Windows.Forms.ComboBox();
            this.TransferValue = new PlaceholderTextBox.PlaceholderTextBox();
            this.ButtonTransferHistory = new System.Windows.Forms.Button();
            this.ButtonAddBeneficiary = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "€";
            // 
            // ComboAccountsFrom
            // 
            this.ComboAccountsFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ComboAccountsFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboAccountsFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboAccountsFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboAccountsFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ComboAccountsFrom.FormattingEnabled = true;
            this.ComboAccountsFrom.Items.AddRange(new object[] {
            "salade ",
            "tomate ",
            "oignons"});
            this.ComboAccountsFrom.Location = new System.Drawing.Point(99, 218);
            this.ComboAccountsFrom.Name = "ComboAccountsFrom";
            this.ComboAccountsFrom.Size = new System.Drawing.Size(263, 30);
            this.ComboAccountsFrom.TabIndex = 7;
            this.ComboAccountsFrom.SelectedIndexChanged += new System.EventHandler(this.ComboAccountsFrom_SelectedIndexChanged);
            // 
            // ComboAccountsTo
            // 
            this.ComboAccountsTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ComboAccountsTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboAccountsTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboAccountsTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboAccountsTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ComboAccountsTo.FormattingEnabled = true;
            this.ComboAccountsTo.Items.AddRange(new object[] {
            "salade ",
            "tomate ",
            "oignons"});
            this.ComboAccountsTo.Location = new System.Drawing.Point(418, 218);
            this.ComboAccountsTo.Name = "ComboAccountsTo";
            this.ComboAccountsTo.Size = new System.Drawing.Size(263, 30);
            this.ComboAccountsTo.TabIndex = 8;
            this.ComboAccountsTo.SelectedIndexChanged += new System.EventHandler(this.ComboAccountsTo_SelectedIndexChanged);
            // 
            // TransferValue
            // 
            this.TransferValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransferValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferValue.Location = new System.Drawing.Point(99, 119);
            this.TransferValue.Name = "TransferValue";
            this.TransferValue.PlaceholderText = "0.00";
            this.TransferValue.Size = new System.Drawing.Size(331, 57);
            this.TransferValue.TabIndex = 9;
            this.TransferValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonTransferHistory
            // 
            this.ButtonTransferHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ButtonTransferHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTransferHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTransferHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ButtonTransferHistory.Location = new System.Drawing.Point(99, 269);
            this.ButtonTransferHistory.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTransferHistory.Name = "ButtonTransferHistory";
            this.ButtonTransferHistory.Size = new System.Drawing.Size(263, 30);
            this.ButtonTransferHistory.TabIndex = 10;
            this.ButtonTransferHistory.Text = "Historique de virement";
            this.ButtonTransferHistory.UseVisualStyleBackColor = false;
            this.ButtonTransferHistory.Click += new System.EventHandler(this.ButtonTransferHistory_Click);
            // 
            // ButtonAddBeneficiary
            // 
            this.ButtonAddBeneficiary.AutoEllipsis = true;
            this.ButtonAddBeneficiary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ButtonAddBeneficiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddBeneficiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddBeneficiary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ButtonAddBeneficiary.Location = new System.Drawing.Point(418, 269);
            this.ButtonAddBeneficiary.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddBeneficiary.Name = "ButtonAddBeneficiary";
            this.ButtonAddBeneficiary.Size = new System.Drawing.Size(263, 30);
            this.ButtonAddBeneficiary.TabIndex = 11;
            this.ButtonAddBeneficiary.Text = "Ajouter un bénéficiaire";
            this.ButtonAddBeneficiary.UseVisualStyleBackColor = false;
            this.ButtonAddBeneficiary.Click += new System.EventHandler(this.ButtonAddBeneficiary_Click);
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.buttonTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.buttonTransfer.Location = new System.Drawing.Point(322, 323);
            this.buttonTransfer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(159, 60);
            this.buttonTransfer.TabIndex = 12;
            this.buttonTransfer.Text = "Effectuer le \r\nvirement";
            this.buttonTransfer.UseVisualStyleBackColor = false;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // FormTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboAccountsFrom);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.ButtonAddBeneficiary);
            this.Controls.Add(this.ButtonTransferHistory);
            this.Controls.Add(this.TransferValue);
            this.Controls.Add(this.ComboAccountsTo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTransfer";
            this.Text = "FormTransfer";
            this.Load += new System.EventHandler(this.FormTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboAccountsFrom;
        private System.Windows.Forms.ComboBox ComboAccountsTo;
        private PlaceholderTextBox.PlaceholderTextBox TransferValue;
        private System.Windows.Forms.Button ButtonTransferHistory;
        private System.Windows.Forms.Button ButtonAddBeneficiary;
        private System.Windows.Forms.Button buttonTransfer;
    }
}
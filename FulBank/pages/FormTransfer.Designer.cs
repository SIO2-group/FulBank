
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
            this.placeholderTextBoxTransferValue = new PlaceholderTextBox.PlaceholderTextBox();
            this.ButtonTransferHistory = new System.Windows.Forms.Button();
            this.ButtonAddBeneficiary = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            this.ComboAccountsFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboAccountsFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboAccountsFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboAccountsFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboAccountsFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ComboAccountsFrom.FormattingEnabled = true;
            this.ComboAccountsFrom.Items.AddRange(new object[] {
            "salade ",
            "tomate ",
            "oignons"});
            this.ComboAccountsFrom.Location = new System.Drawing.Point(0, 0);
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
            // placeholderTextBoxTransferValue
            // 
            this.placeholderTextBoxTransferValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placeholderTextBoxTransferValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBoxTransferValue.Location = new System.Drawing.Point(99, 121);
            this.placeholderTextBoxTransferValue.Name = "placeholderTextBoxTransferValue";
            this.placeholderTextBoxTransferValue.PlaceholderText = "0.00";
            this.placeholderTextBoxTransferValue.Size = new System.Drawing.Size(331, 57);
            this.placeholderTextBoxTransferValue.TabIndex = 9;
            this.placeholderTextBoxTransferValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.button1.Location = new System.Drawing.Point(322, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 60);
            this.button1.TabIndex = 12;
            this.button1.Text = "Effectuer le \r\nvirement";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.ComboAccountsFrom);
            this.panel1.Location = new System.Drawing.Point(99, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 30);
            this.panel1.TabIndex = 13;
            // 
            // FormTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonAddBeneficiary);
            this.Controls.Add(this.ButtonTransferHistory);
            this.Controls.Add(this.placeholderTextBoxTransferValue);
            this.Controls.Add(this.ComboAccountsTo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTransfer";
            this.Text = "FormTransfer";
            this.Load += new System.EventHandler(this.FormTransfer_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboAccountsFrom;
        private System.Windows.Forms.ComboBox ComboAccountsTo;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBoxTransferValue;
        private System.Windows.Forms.Button ButtonTransferHistory;
        private System.Windows.Forms.Button ButtonAddBeneficiary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}
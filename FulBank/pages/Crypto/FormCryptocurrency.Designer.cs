
namespace Fulbank.pages.Crypto
{
    partial class FormCryptocurrency
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
            this.TextSearchCrypto = new PlaceholderTextBox.PlaceholderTextBox();
            this.btnWallet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelCryptos = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonSearchCrypto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextSearchCrypto
            // 
            this.TextSearchCrypto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchCrypto.Location = new System.Drawing.Point(492, 15);
            this.TextSearchCrypto.Name = "TextSearchCrypto";
            this.TextSearchCrypto.PlaceholderText = "ex : Bitcoin";
            this.TextSearchCrypto.Size = new System.Drawing.Size(144, 29);
            this.TextSearchCrypto.TabIndex = 0;
            // 
            // btnWallet
            // 
            this.btnWallet.BackColor = System.Drawing.SystemColors.Window;
            this.btnWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWallet.Location = new System.Drawing.Point(24, 15);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Size = new System.Drawing.Size(137, 28);
            this.btnWallet.TabIndex = 1;
            this.btnWallet.Text = "Mes portefeuilles";
            this.btnWallet.UseVisualStyleBackColor = false;
            this.btnWallet.Click += new System.EventHandler(this.btnWallet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Symbole";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valeur (EUR)";
            // 
            // PanelCryptos
            // 
            this.PanelCryptos.AutoScroll = true;
            this.PanelCryptos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelCryptos.Location = new System.Drawing.Point(0, 76);
            this.PanelCryptos.Name = "PanelCryptos";
            this.PanelCryptos.Size = new System.Drawing.Size(800, 374);
            this.PanelCryptos.TabIndex = 6;
            this.PanelCryptos.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCryptos_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "24h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "1h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = " 7j";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(167, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Historique";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ButtonSearchCrypto
            // 
            this.ButtonSearchCrypto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearchCrypto.Location = new System.Drawing.Point(639, 15);
            this.ButtonSearchCrypto.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSearchCrypto.Name = "ButtonSearchCrypto";
            this.ButtonSearchCrypto.Size = new System.Drawing.Size(93, 29);
            this.ButtonSearchCrypto.TabIndex = 11;
            this.ButtonSearchCrypto.Text = "rechercher";
            this.ButtonSearchCrypto.UseVisualStyleBackColor = true;
            this.ButtonSearchCrypto.Click += new System.EventHandler(this.ButtonSearchCrypto_Click);
            // 
            // FormCryptocurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonSearchCrypto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PanelCryptos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWallet);
            this.Controls.Add(this.TextSearchCrypto);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(28)))), ((int)(((byte)(125)))));
            this.Name = "FormCryptocurrency";
            this.ShowIcon = false;
            this.Text = "FormCryptocurrency";
            this.Load += new System.EventHandler(this.FormCryptocurrency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceholderTextBox.PlaceholderTextBox TextSearchCrypto;
        private System.Windows.Forms.Button btnWallet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelCryptos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonSearchCrypto;
    }
}
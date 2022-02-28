
namespace Fulbank.pages
{
    partial class FormTerminalConf
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
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelBuilding = new System.Windows.Forms.Label();
            this.textBoxBuilding = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.buttonSetIni = new System.Windows.Forms.Button();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textPostalCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxIp
            // 
            this.textBoxIp.Enabled = false;
            this.textBoxIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIp.Location = new System.Drawing.Point(249, 73);
            this.textBoxIp.MaxLength = 15;
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(147, 24);
            this.textBoxIp.TabIndex = 0;
            this.textBoxIp.TextChanged += new System.EventHandler(this.textBoxIp_TextChanged);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(249, 52);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(76, 15);
            this.labelIP.TabIndex = 1;
            this.labelIP.Text = "Adresse Ipv4";
            // 
            // labelBuilding
            // 
            this.labelBuilding.AutoSize = true;
            this.labelBuilding.Location = new System.Drawing.Point(71, 132);
            this.labelBuilding.Name = "labelBuilding";
            this.labelBuilding.Size = new System.Drawing.Size(56, 15);
            this.labelBuilding.TabIndex = 3;
            this.labelBuilding.Text = "Bâtiment";
            // 
            // textBoxBuilding
            // 
            this.textBoxBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuilding.Location = new System.Drawing.Point(71, 153);
            this.textBoxBuilding.MaxLength = 15;
            this.textBoxBuilding.Name = "textBoxBuilding";
            this.textBoxBuilding.Size = new System.Drawing.Size(147, 24);
            this.textBoxBuilding.TabIndex = 2;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(71, 52);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(30, 15);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "Ville";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.Location = new System.Drawing.Point(71, 73);
            this.textBoxCity.MaxLength = 15;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(147, 24);
            this.textBoxCity.TabIndex = 4;
            // 
            // buttonSetIni
            // 
            this.buttonSetIni.Location = new System.Drawing.Point(161, 199);
            this.buttonSetIni.Name = "buttonSetIni";
            this.buttonSetIni.Size = new System.Drawing.Size(144, 25);
            this.buttonSetIni.TabIndex = 6;
            this.buttonSetIni.Text = "Créer / Modifier";
            this.buttonSetIni.UseVisualStyleBackColor = true;
            this.buttonSetIni.Click += new System.EventHandler(this.buttonSetIni_Click);
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(249, 132);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(73, 15);
            this.labelPostalCode.TabIndex = 8;
            this.labelPostalCode.Text = "Code Postal";
            // 
            // textPostalCode
            // 
            this.textPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPostalCode.Location = new System.Drawing.Point(249, 153);
            this.textPostalCode.MaxLength = 15;
            this.textPostalCode.Name = "textPostalCode";
            this.textPostalCode.Size = new System.Drawing.Size(147, 24);
            this.textPostalCode.TabIndex = 7;
            // 
            // FormTerminalConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 250);
            this.ControlBox = false;
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.textPostalCode);
            this.Controls.Add(this.buttonSetIni);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelBuilding);
            this.Controls.Add(this.textBoxBuilding);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textBoxIp);
            this.Name = "FormTerminalConf";
            this.Text = "TerminalConf";
            this.Load += new System.EventHandler(this.TerminalConf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelBuilding;
        private System.Windows.Forms.TextBox textBoxBuilding;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button buttonSetIni;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textPostalCode;
    }
}
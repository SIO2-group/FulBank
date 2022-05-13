
namespace Fulbank.pages
{
    partial class FormAccount
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
            this.panelAccounts = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.panelAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAccounts
            // 
            this.panelAccounts.AutoScroll = true;
            this.panelAccounts.BackColor = System.Drawing.SystemColors.Window;
            this.panelAccounts.Controls.Add(this.btnReload);
            this.panelAccounts.Location = new System.Drawing.Point(0, 0);
            this.panelAccounts.Margin = new System.Windows.Forms.Padding(0);
            this.panelAccounts.Name = "panelAccounts";
            this.panelAccounts.Size = new System.Drawing.Size(800, 450);
            this.panelAccounts.TabIndex = 18;
            this.panelAccounts.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAccounts_Paint);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.Window;
            this.btnReload.BackgroundImage = global::Fulbank.Properties.Resources.pngtree_reload_icon__line_style_vector_illustration_png_image_314770;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.Transparent;
            this.btnReload.Location = new System.Drawing.Point(706, 22);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(40, 40);
            this.btnReload.TabIndex = 17;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccount";
            this.Text = "FormAccount";
            this.panelAccounts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAccounts;
        private System.Windows.Forms.Button btnReload;
    }
}
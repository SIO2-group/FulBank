
namespace Fulbank.pages
{
    partial class FormProfile
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
            this.PanelUserProfile = new System.Windows.Forms.Panel();
            this.ProfilePanelPassword = new System.Windows.Forms.Panel();
            this.BtnChangePassWord = new System.Windows.Forms.Button();
            this.ProfilePasswordTitle = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.ProfilePanelMail = new System.Windows.Forms.Panel();
            this.BtnChangeMail = new System.Windows.Forms.Button();
            this.ProfileMail = new System.Windows.Forms.TextBox();
            this.ProfileMailTitle = new System.Windows.Forms.TextBox();
            this.ProfilePanelLandline = new System.Windows.Forms.Panel();
            this.BtnChangeLandLine = new System.Windows.Forms.Button();
            this.ProfileLandlineNumber = new System.Windows.Forms.TextBox();
            this.ProfileLandlineTitle = new System.Windows.Forms.TextBox();
            this.ProfilePanelAdress = new System.Windows.Forms.Panel();
            this.BtnChangeAdress = new System.Windows.Forms.Button();
            this.ProfileAdress = new System.Windows.Forms.TextBox();
            this.ProfileAdressTitle = new System.Windows.Forms.TextBox();
            this.ProfilePanelPhone = new System.Windows.Forms.Panel();
            this.BtnChangePhone = new System.Windows.Forms.Button();
            this.ProfilePhoneNumber = new System.Windows.Forms.TextBox();
            this.ProfilePhoneTitle = new System.Windows.Forms.TextBox();
            this.ProfileCategory = new System.Windows.Forms.TextBox();
            this.OwnerName = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.PanelUserProfile.SuspendLayout();
            this.ProfilePanelPassword.SuspendLayout();
            this.ProfilePanelMail.SuspendLayout();
            this.ProfilePanelLandline.SuspendLayout();
            this.ProfilePanelAdress.SuspendLayout();
            this.ProfilePanelPhone.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelUserProfile
            // 
            this.PanelUserProfile.AutoScroll = true;
            this.PanelUserProfile.BackColor = System.Drawing.Color.White;
            this.PanelUserProfile.Controls.Add(this.btnReload);
            this.PanelUserProfile.Controls.Add(this.ProfilePanelPassword);
            this.PanelUserProfile.Controls.Add(this.textBox10);
            this.PanelUserProfile.Controls.Add(this.ProfilePanelMail);
            this.PanelUserProfile.Controls.Add(this.ProfilePanelLandline);
            this.PanelUserProfile.Controls.Add(this.ProfilePanelAdress);
            this.PanelUserProfile.Controls.Add(this.ProfilePanelPhone);
            this.PanelUserProfile.Controls.Add(this.ProfileCategory);
            this.PanelUserProfile.Controls.Add(this.OwnerName);
            this.PanelUserProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelUserProfile.Location = new System.Drawing.Point(0, 0);
            this.PanelUserProfile.Name = "PanelUserProfile";
            this.PanelUserProfile.Size = new System.Drawing.Size(800, 450);
            this.PanelUserProfile.TabIndex = 5;
            this.PanelUserProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelUserProfile_Paint);
            // 
            // ProfilePanelPassword
            // 
            this.ProfilePanelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfilePanelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePanelPassword.Controls.Add(this.BtnChangePassWord);
            this.ProfilePanelPassword.Controls.Add(this.ProfilePasswordTitle);
            this.ProfilePanelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfilePanelPassword.Location = new System.Drawing.Point(38, 318);
            this.ProfilePanelPassword.Name = "ProfilePanelPassword";
            this.ProfilePanelPassword.Size = new System.Drawing.Size(481, 33);
            this.ProfilePanelPassword.TabIndex = 6;
            // 
            // BtnChangePassWord
            // 
            this.BtnChangePassWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangePassWord.FlatAppearance.BorderSize = 0;
            this.BtnChangePassWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangePassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangePassWord.Location = new System.Drawing.Point(447, -2);
            this.BtnChangePassWord.Margin = new System.Windows.Forms.Padding(0);
            this.BtnChangePassWord.Name = "BtnChangePassWord";
            this.BtnChangePassWord.Size = new System.Drawing.Size(33, 33);
            this.BtnChangePassWord.TabIndex = 8;
            this.BtnChangePassWord.Text = ">";
            this.BtnChangePassWord.UseVisualStyleBackColor = true;
            this.BtnChangePassWord.Click += new System.EventHandler(this.BtnChangePassWord_Click);
            // 
            // ProfilePasswordTitle
            // 
            this.ProfilePasswordTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfilePasswordTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfilePasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilePasswordTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfilePasswordTitle.Location = new System.Drawing.Point(3, 6);
            this.ProfilePasswordTitle.Multiline = true;
            this.ProfilePasswordTitle.Name = "ProfilePasswordTitle";
            this.ProfilePasswordTitle.ReadOnly = true;
            this.ProfilePasswordTitle.Size = new System.Drawing.Size(217, 27);
            this.ProfilePasswordTitle.TabIndex = 3;
            this.ProfilePasswordTitle.Text = "Changer votre mot de passe :";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Window;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.textBox10.Location = new System.Drawing.Point(38, 292);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(181, 19);
            this.textBox10.TabIndex = 7;
            this.textBox10.Text = "Sécurité";
            // 
            // ProfilePanelMail
            // 
            this.ProfilePanelMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfilePanelMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePanelMail.Controls.Add(this.BtnChangeMail);
            this.ProfilePanelMail.Controls.Add(this.ProfileMail);
            this.ProfilePanelMail.Controls.Add(this.ProfileMailTitle);
            this.ProfilePanelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilePanelMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfilePanelMail.Location = new System.Drawing.Point(38, 235);
            this.ProfilePanelMail.Name = "ProfilePanelMail";
            this.ProfilePanelMail.Size = new System.Drawing.Size(481, 33);
            this.ProfilePanelMail.TabIndex = 5;
            // 
            // BtnChangeMail
            // 
            this.BtnChangeMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangeMail.FlatAppearance.BorderSize = 0;
            this.BtnChangeMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeMail.Location = new System.Drawing.Point(446, 0);
            this.BtnChangeMail.Margin = new System.Windows.Forms.Padding(0);
            this.BtnChangeMail.Name = "BtnChangeMail";
            this.BtnChangeMail.Size = new System.Drawing.Size(33, 33);
            this.BtnChangeMail.TabIndex = 8;
            this.BtnChangeMail.Text = ">";
            this.BtnChangeMail.UseVisualStyleBackColor = true;
            this.BtnChangeMail.Click += new System.EventHandler(this.BtnChangeMail_Click);
            // 
            // ProfileMail
            // 
            this.ProfileMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfileMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfileMail.Enabled = false;
            this.ProfileMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfileMail.Location = new System.Drawing.Point(112, 6);
            this.ProfileMail.Multiline = true;
            this.ProfileMail.Name = "ProfileMail";
            this.ProfileMail.Size = new System.Drawing.Size(207, 21);
            this.ProfileMail.TabIndex = 4;
            // 
            // ProfileMailTitle
            // 
            this.ProfileMailTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfileMailTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfileMailTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileMailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfileMailTitle.Location = new System.Drawing.Point(3, 6);
            this.ProfileMailTitle.Multiline = true;
            this.ProfileMailTitle.Name = "ProfileMailTitle";
            this.ProfileMailTitle.ReadOnly = true;
            this.ProfileMailTitle.Size = new System.Drawing.Size(121, 27);
            this.ProfileMailTitle.TabIndex = 3;
            this.ProfileMailTitle.Text = "Adresse mail :";
            // 
            // ProfilePanelLandline
            // 
            this.ProfilePanelLandline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfilePanelLandline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePanelLandline.Controls.Add(this.BtnChangeLandLine);
            this.ProfilePanelLandline.Controls.Add(this.ProfileLandlineNumber);
            this.ProfilePanelLandline.Controls.Add(this.ProfileLandlineTitle);
            this.ProfilePanelLandline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfilePanelLandline.Location = new System.Drawing.Point(38, 185);
            this.ProfilePanelLandline.Name = "ProfilePanelLandline";
            this.ProfilePanelLandline.Size = new System.Drawing.Size(481, 33);
            this.ProfilePanelLandline.TabIndex = 5;
            // 
            // BtnChangeLandLine
            // 
            this.BtnChangeLandLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangeLandLine.FlatAppearance.BorderSize = 0;
            this.BtnChangeLandLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeLandLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeLandLine.Location = new System.Drawing.Point(446, 0);
            this.BtnChangeLandLine.Margin = new System.Windows.Forms.Padding(0);
            this.BtnChangeLandLine.Name = "BtnChangeLandLine";
            this.BtnChangeLandLine.Size = new System.Drawing.Size(33, 33);
            this.BtnChangeLandLine.TabIndex = 7;
            this.BtnChangeLandLine.Text = ">";
            this.BtnChangeLandLine.UseVisualStyleBackColor = true;
            this.BtnChangeLandLine.Click += new System.EventHandler(this.BtnChangeLandLine_Click);
            // 
            // ProfileLandlineNumber
            // 
            this.ProfileLandlineNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfileLandlineNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfileLandlineNumber.Enabled = false;
            this.ProfileLandlineNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLandlineNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfileLandlineNumber.Location = new System.Drawing.Point(125, 6);
            this.ProfileLandlineNumber.Multiline = true;
            this.ProfileLandlineNumber.Name = "ProfileLandlineNumber";
            this.ProfileLandlineNumber.Size = new System.Drawing.Size(142, 22);
            this.ProfileLandlineNumber.TabIndex = 4;
            // 
            // ProfileLandlineTitle
            // 
            this.ProfileLandlineTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfileLandlineTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfileLandlineTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLandlineTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfileLandlineTitle.Location = new System.Drawing.Point(3, 6);
            this.ProfileLandlineTitle.Multiline = true;
            this.ProfileLandlineTitle.Name = "ProfileLandlineTitle";
            this.ProfileLandlineTitle.ReadOnly = true;
            this.ProfileLandlineTitle.Size = new System.Drawing.Size(142, 27);
            this.ProfileLandlineTitle.TabIndex = 3;
            this.ProfileLandlineTitle.Text = "Téléphone fixe :";
            // 
            // ProfilePanelAdress
            // 
            this.ProfilePanelAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfilePanelAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePanelAdress.Controls.Add(this.BtnChangeAdress);
            this.ProfilePanelAdress.Controls.Add(this.ProfileAdress);
            this.ProfilePanelAdress.Controls.Add(this.ProfileAdressTitle);
            this.ProfilePanelAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfilePanelAdress.Location = new System.Drawing.Point(38, 136);
            this.ProfilePanelAdress.Name = "ProfilePanelAdress";
            this.ProfilePanelAdress.Size = new System.Drawing.Size(481, 33);
            this.ProfilePanelAdress.TabIndex = 5;
            // 
            // BtnChangeAdress
            // 
            this.BtnChangeAdress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangeAdress.FlatAppearance.BorderSize = 0;
            this.BtnChangeAdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeAdress.Location = new System.Drawing.Point(447, -1);
            this.BtnChangeAdress.Margin = new System.Windows.Forms.Padding(0);
            this.BtnChangeAdress.Name = "BtnChangeAdress";
            this.BtnChangeAdress.Size = new System.Drawing.Size(33, 33);
            this.BtnChangeAdress.TabIndex = 6;
            this.BtnChangeAdress.Text = ">";
            this.BtnChangeAdress.UseVisualStyleBackColor = true;
            this.BtnChangeAdress.Click += new System.EventHandler(this.BtnChangeAdress_Click);
            // 
            // ProfileAdress
            // 
            this.ProfileAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfileAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfileAdress.Enabled = false;
            this.ProfileAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfileAdress.Location = new System.Drawing.Point(81, 7);
            this.ProfileAdress.Multiline = true;
            this.ProfileAdress.Name = "ProfileAdress";
            this.ProfileAdress.Size = new System.Drawing.Size(247, 21);
            this.ProfileAdress.TabIndex = 5;
            // 
            // ProfileAdressTitle
            // 
            this.ProfileAdressTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfileAdressTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfileAdressTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileAdressTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfileAdressTitle.Location = new System.Drawing.Point(3, 6);
            this.ProfileAdressTitle.Multiline = true;
            this.ProfileAdressTitle.Name = "ProfileAdressTitle";
            this.ProfileAdressTitle.ReadOnly = true;
            this.ProfileAdressTitle.Size = new System.Drawing.Size(142, 27);
            this.ProfileAdressTitle.TabIndex = 3;
            this.ProfileAdressTitle.Text = "Adresse :";
            // 
            // ProfilePanelPhone
            // 
            this.ProfilePanelPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfilePanelPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePanelPhone.Controls.Add(this.BtnChangePhone);
            this.ProfilePanelPhone.Controls.Add(this.ProfilePhoneNumber);
            this.ProfilePanelPhone.Controls.Add(this.ProfilePhoneTitle);
            this.ProfilePanelPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfilePanelPhone.Location = new System.Drawing.Point(38, 87);
            this.ProfilePanelPhone.Name = "ProfilePanelPhone";
            this.ProfilePanelPhone.Size = new System.Drawing.Size(481, 33);
            this.ProfilePanelPhone.TabIndex = 2;
            // 
            // BtnChangePhone
            // 
            this.BtnChangePhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangePhone.FlatAppearance.BorderSize = 0;
            this.BtnChangePhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangePhone.Location = new System.Drawing.Point(446, -1);
            this.BtnChangePhone.Margin = new System.Windows.Forms.Padding(0);
            this.BtnChangePhone.Name = "BtnChangePhone";
            this.BtnChangePhone.Size = new System.Drawing.Size(33, 33);
            this.BtnChangePhone.TabIndex = 5;
            this.BtnChangePhone.Text = ">";
            this.BtnChangePhone.UseVisualStyleBackColor = true;
            this.BtnChangePhone.Click += new System.EventHandler(this.BtnChangePhone_Click);
            // 
            // ProfilePhoneNumber
            // 
            this.ProfilePhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfilePhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfilePhoneNumber.Enabled = false;
            this.ProfilePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilePhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfilePhoneNumber.Location = new System.Drawing.Point(98, 6);
            this.ProfilePhoneNumber.MaxLength = 10;
            this.ProfilePhoneNumber.Multiline = true;
            this.ProfilePhoneNumber.Name = "ProfilePhoneNumber";
            this.ProfilePhoneNumber.Size = new System.Drawing.Size(142, 21);
            this.ProfilePhoneNumber.TabIndex = 4;
            this.ProfilePhoneNumber.TextChanged += new System.EventHandler(this.ProfilePhoneNumber_TextChanged);
            // 
            // ProfilePhoneTitle
            // 
            this.ProfilePhoneTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.ProfilePhoneTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfilePhoneTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilePhoneTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfilePhoneTitle.Location = new System.Drawing.Point(3, 6);
            this.ProfilePhoneTitle.Multiline = true;
            this.ProfilePhoneTitle.Name = "ProfilePhoneTitle";
            this.ProfilePhoneTitle.ReadOnly = true;
            this.ProfilePhoneTitle.Size = new System.Drawing.Size(142, 27);
            this.ProfilePhoneTitle.TabIndex = 3;
            this.ProfilePhoneTitle.Text = "Téléphone :";
            // 
            // ProfileCategory
            // 
            this.ProfileCategory.BackColor = System.Drawing.SystemColors.Window;
            this.ProfileCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfileCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.ProfileCategory.Location = new System.Drawing.Point(38, 60);
            this.ProfileCategory.Name = "ProfileCategory";
            this.ProfileCategory.ReadOnly = true;
            this.ProfileCategory.Size = new System.Drawing.Size(171, 22);
            this.ProfileCategory.TabIndex = 1;
            this.ProfileCategory.Text = "Général";
            // 
            // OwnerName
            // 
            this.OwnerName.BackColor = System.Drawing.SystemColors.Window;
            this.OwnerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.OwnerName.Location = new System.Drawing.Point(38, 22);
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.ReadOnly = true;
            this.OwnerName.Size = new System.Drawing.Size(232, 22);
            this.OwnerName.TabIndex = 0;
            this.OwnerName.Text = "{{nom du propriétaire}}";
            this.OwnerName.TextChanged += new System.EventHandler(this.OwnerName_TextChanged);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.Window;
            this.btnReload.BackgroundImage = global::Fulbank.Properties.Resources.pngtree_reload_icon__line_style_vector_illustration_png_image_314770;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(618, 87);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(35, 33);
            this.btnReload.TabIndex = 18;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelUserProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.PanelUserProfile.ResumeLayout(false);
            this.PanelUserProfile.PerformLayout();
            this.ProfilePanelPassword.ResumeLayout(false);
            this.ProfilePanelPassword.PerformLayout();
            this.ProfilePanelMail.ResumeLayout(false);
            this.ProfilePanelMail.PerformLayout();
            this.ProfilePanelLandline.ResumeLayout(false);
            this.ProfilePanelLandline.PerformLayout();
            this.ProfilePanelAdress.ResumeLayout(false);
            this.ProfilePanelAdress.PerformLayout();
            this.ProfilePanelPhone.ResumeLayout(false);
            this.ProfilePanelPhone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelUserProfile;
        private System.Windows.Forms.Panel ProfilePanelPassword;
        private System.Windows.Forms.TextBox ProfilePasswordTitle;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Panel ProfilePanelMail;
        private System.Windows.Forms.TextBox ProfileMail;
        private System.Windows.Forms.TextBox ProfileMailTitle;
        private System.Windows.Forms.Panel ProfilePanelLandline;
        private System.Windows.Forms.TextBox ProfileLandlineNumber;
        private System.Windows.Forms.TextBox ProfileLandlineTitle;
        private System.Windows.Forms.Panel ProfilePanelAdress;
        private System.Windows.Forms.TextBox ProfileAdress;
        private System.Windows.Forms.TextBox ProfileAdressTitle;
        private System.Windows.Forms.Panel ProfilePanelPhone;
        private System.Windows.Forms.TextBox ProfilePhoneNumber;
        private System.Windows.Forms.TextBox ProfilePhoneTitle;
        private System.Windows.Forms.TextBox ProfileCategory;
        private System.Windows.Forms.TextBox OwnerName;
        private System.Windows.Forms.Button BtnChangePassWord;
        private System.Windows.Forms.Button BtnChangeMail;
        private System.Windows.Forms.Button BtnChangeLandLine;
        private System.Windows.Forms.Button BtnChangeAdress;
        private System.Windows.Forms.Button BtnChangePhone;
        private System.Windows.Forms.Button btnReload;
    }
}

namespace Fulbank.pages
{
    partial class FormAddBeneficiary
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxBeneficiaryId = new System.Windows.Forms.TextBox();
            this.labelAccountId = new System.Windows.Forms.Label();
            this.labelBeneficiaryName = new System.Windows.Forms.Label();
            this.textBoxBeneficiaryName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(65, 138);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 32);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(280, 138);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 32);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxBeneficiaryId
            // 
            this.textBoxBeneficiaryId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxBeneficiaryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBeneficiaryId.Location = new System.Drawing.Point(49, 80);
            this.textBoxBeneficiaryId.Name = "textBoxBeneficiaryId";
            this.textBoxBeneficiaryId.Size = new System.Drawing.Size(125, 20);
            this.textBoxBeneficiaryId.TabIndex = 2;
            this.textBoxBeneficiaryId.TextChanged += new System.EventHandler(this.textBoxBeneficiaryId_TextChanged);
            // 
            // labelAccountId
            // 
            this.labelAccountId.AutoSize = true;
            this.labelAccountId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.labelAccountId.Location = new System.Drawing.Point(46, 60);
            this.labelAccountId.Name = "labelAccountId";
            this.labelAccountId.Size = new System.Drawing.Size(166, 17);
            this.labelAccountId.TabIndex = 3;
            this.labelAccountId.Text = "Identifiant du bénéficiaire";
            // 
            // labelBeneficiaryName
            // 
            this.labelBeneficiaryName.AutoSize = true;
            this.labelBeneficiaryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeneficiaryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.labelBeneficiaryName.Location = new System.Drawing.Point(263, 60);
            this.labelBeneficiaryName.Name = "labelBeneficiaryName";
            this.labelBeneficiaryName.Size = new System.Drawing.Size(122, 17);
            this.labelBeneficiaryName.TabIndex = 5;
            this.labelBeneficiaryName.Text = "Nom personnalisé";
            // 
            // textBoxBeneficiaryName
            // 
            this.textBoxBeneficiaryName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxBeneficiaryName.Location = new System.Drawing.Point(266, 80);
            this.textBoxBeneficiaryName.Name = "textBoxBeneficiaryName";
            this.textBoxBeneficiaryName.Size = new System.Drawing.Size(125, 20);
            this.textBoxBeneficiaryName.TabIndex = 4;
            // 
            // FormAddBeneficiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 199);
            this.Controls.Add(this.labelBeneficiaryName);
            this.Controls.Add(this.textBoxBeneficiaryName);
            this.Controls.Add(this.labelAccountId);
            this.Controls.Add(this.textBoxBeneficiaryId);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormAddBeneficiary";
            this.Text = "FormAddBeneficiary";
            this.Load += new System.EventHandler(this.FormAddBeneficiary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxBeneficiaryId;
        private System.Windows.Forms.Label labelAccountId;
        private System.Windows.Forms.Label labelBeneficiaryName;
        private System.Windows.Forms.TextBox textBoxBeneficiaryName;
    }
}
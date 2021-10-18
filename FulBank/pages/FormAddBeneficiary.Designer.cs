
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
            this.buttonAdd.Location = new System.Drawing.Point(120, 148);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 32);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(248, 148);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 32);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxBeneficiaryId
            // 
            this.textBoxBeneficiaryId.Location = new System.Drawing.Point(44, 81);
            this.textBoxBeneficiaryId.Name = "textBoxBeneficiaryId";
            this.textBoxBeneficiaryId.Size = new System.Drawing.Size(125, 20);
            this.textBoxBeneficiaryId.TabIndex = 2;
            this.textBoxBeneficiaryId.TextChanged += new System.EventHandler(this.textBoxBeneficiaryId_TextChanged);
            // 
            // labelAccountId
            // 
            this.labelAccountId.AutoSize = true;
            this.labelAccountId.Location = new System.Drawing.Point(41, 60);
            this.labelAccountId.Name = "labelAccountId";
            this.labelAccountId.Size = new System.Drawing.Size(188, 15);
            this.labelAccountId.TabIndex = 3;
            this.labelAccountId.Text = "Identifiant du compte bénéficiaire";
            // 
            // labelBeneficiaryName
            // 
            this.labelBeneficiaryName.AutoSize = true;
            this.labelBeneficiaryName.Location = new System.Drawing.Point(248, 60);
            this.labelBeneficiaryName.Name = "labelBeneficiaryName";
            this.labelBeneficiaryName.Size = new System.Drawing.Size(108, 15);
            this.labelBeneficiaryName.TabIndex = 5;
            this.labelBeneficiaryName.Text = "Nom personnalisé";
            // 
            // textBoxBeneficiaryName
            // 
            this.textBoxBeneficiaryName.Location = new System.Drawing.Point(248, 81);
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
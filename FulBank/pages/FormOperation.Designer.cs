
namespace Fulbank.pages
{
    partial class FormOperation
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
            this.buttonDebit = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonOperationHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OperationValue = new PlaceholderTextBox.PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // buttonDebit
            // 
            this.buttonDebit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.buttonDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDebit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.buttonDebit.Location = new System.Drawing.Point(55, 193);
            this.buttonDebit.Name = "buttonDebit";
            this.buttonDebit.Size = new System.Drawing.Size(263, 35);
            this.buttonDebit.TabIndex = 1;
            this.buttonDebit.Text = "Effectuer un Retrait";
            this.buttonDebit.UseVisualStyleBackColor = false;
            this.buttonDebit.Click += new System.EventHandler(this.buttonDebit_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.buttonDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.buttonDeposit.Location = new System.Drawing.Point(464, 193);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(263, 35);
            this.buttonDeposit.TabIndex = 2;
            this.buttonDeposit.Text = "Effectuer un Dépôt";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonOperationHistory
            // 
            this.buttonOperationHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.buttonOperationHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOperationHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperationHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(67)))), ((int)(((byte)(153)))));
            this.buttonOperationHistory.Location = new System.Drawing.Point(311, 276);
            this.buttonOperationHistory.Name = "buttonOperationHistory";
            this.buttonOperationHistory.Size = new System.Drawing.Size(159, 60);
            this.buttonOperationHistory.TabIndex = 3;
            this.buttonOperationHistory.Text = "Historique des Opérations";
            this.buttonOperationHistory.UseVisualStyleBackColor = false;
            this.buttonOperationHistory.Click += new System.EventHandler(this.buttonOperationHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "€";
            // 
            // OperationValue
            // 
            this.OperationValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OperationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationValue.Location = new System.Drawing.Point(168, 92);
            this.OperationValue.Name = "OperationValue";
            this.OperationValue.PlaceholderText = "0.00";
            this.OperationValue.Size = new System.Drawing.Size(257, 46);
            this.OperationValue.TabIndex = 6;
            this.OperationValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(772, 413);
            this.Controls.Add(this.OperationValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOperationHistory);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.buttonDebit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOperation";
            this.Text = "FormOperation";
            this.Load += new System.EventHandler(this.FormOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDebit;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonOperationHistory;
        private System.Windows.Forms.Label label1;
        private PlaceholderTextBox.PlaceholderTextBox OperationValue;
    }
}

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
            this.Operation = new System.Windows.Forms.TextBox();
            this.buttonDebit = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonHistorical = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Operation
            // 
            this.Operation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operation.Location = new System.Drawing.Point(88, 81);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(331, 46);
            this.Operation.TabIndex = 0;
            this.Operation.Text = "0,00";
            this.Operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Operation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonDebit
            // 
            this.buttonDebit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.buttonDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDebit.Location = new System.Drawing.Point(162, 183);
            this.buttonDebit.Name = "buttonDebit";
            this.buttonDebit.Size = new System.Drawing.Size(130, 70);
            this.buttonDebit.TabIndex = 1;
            this.buttonDebit.Text = "Debit";
            this.buttonDebit.UseVisualStyleBackColor = false;
            this.buttonDebit.Click += new System.EventHandler(this.buttonDebit_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.Location = new System.Drawing.Point(481, 183);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(130, 70);
            this.buttonDeposit.TabIndex = 2;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            // 
            // buttonHistorical
            // 
            this.buttonHistorical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(236)))));
            this.buttonHistorical.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistorical.Location = new System.Drawing.Point(314, 298);
            this.buttonHistorical.Name = "buttonHistorical";
            this.buttonHistorical.Size = new System.Drawing.Size(138, 70);
            this.buttonHistorical.TabIndex = 3;
            this.buttonHistorical.Text = "Historical";
            this.buttonHistorical.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "€";
            // 
            // FormOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(772, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHistorical);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.buttonDebit);
            this.Controls.Add(this.Operation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOperation";
            this.Text = "FormOperation";
            this.Load += new System.EventHandler(this.FormOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Operation;
        private System.Windows.Forms.Button buttonDebit;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonHistorical;
        private System.Windows.Forms.Label label1;
    }
}
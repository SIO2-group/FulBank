
namespace Fulbank.pages
{
    partial class FormOperationHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOperation = new System.Windows.Forms.DataGridView();
            this.TypeOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtaOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historique";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvOperation
            // 
            this.dgvOperation.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvOperation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOperation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeOperation,
            this.AccountOperation,
            this.DtaOperation});
            this.dgvOperation.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOperation.Location = new System.Drawing.Point(172, 110);
            this.dgvOperation.Name = "dgvOperation";
            this.dgvOperation.ReadOnly = true;
            this.dgvOperation.RowHeadersVisible = false;
            this.dgvOperation.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvOperation.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOperation.Size = new System.Drawing.Size(437, 300);
            this.dgvOperation.TabIndex = 1;
            this.dgvOperation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperation_CellContentClick);
            // 
            // TypeOperation
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.TypeOperation.DefaultCellStyle = dataGridViewCellStyle2;
            this.TypeOperation.HeaderText = "Type";
            this.TypeOperation.Name = "TypeOperation";
            this.TypeOperation.ReadOnly = true;
            // 
            // AccountOperation
            // 
            this.AccountOperation.HeaderText = "Montant";
            this.AccountOperation.Name = "AccountOperation";
            this.AccountOperation.ReadOnly = true;
            // 
            // DtaOperation
            // 
            this.DtaOperation.HeaderText = "Date";
            this.DtaOperation.Name = "DtaOperation";
            this.DtaOperation.ReadOnly = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // FormOperationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOperation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOperationHistory";
            this.Text = "FormOperationHistory";
            this.Load += new System.EventHandler(this.FormOperationHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOperation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtaOperation;
    }
}
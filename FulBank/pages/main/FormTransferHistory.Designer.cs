﻿
namespace Fulbank.pages
{
    partial class FormTransferHistory
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
            this.DgvTransferHistory = new System.Windows.Forms.DataGridView();
            this.dgvTransferHistoryFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransferHistoryTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransferHistoryAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransferHistoryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTransferHistory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransferHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTransferHistory
            // 
            this.DgvTransferHistory.AllowUserToOrderColumns = true;
            this.DgvTransferHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTransferHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvTransferHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTransferHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTransferHistoryFrom,
            this.dgvTransferHistoryTo,
            this.dgvTransferHistoryAmount,
            this.dgvTransferHistoryDate});
            this.DgvTransferHistory.Location = new System.Drawing.Point(73, 90);
            this.DgvTransferHistory.Name = "DgvTransferHistory";
            this.DgvTransferHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DgvTransferHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTransferHistory.Size = new System.Drawing.Size(640, 348);
            this.DgvTransferHistory.TabIndex = 0;
            // 
            // dgvTransferHistoryFrom
            // 
            this.dgvTransferHistoryFrom.HeaderText = "Depuis le compte";
            this.dgvTransferHistoryFrom.MinimumWidth = 6;
            this.dgvTransferHistoryFrom.Name = "dgvTransferHistoryFrom";
            // 
            // dgvTransferHistoryTo
            // 
            this.dgvTransferHistoryTo.HeaderText = "Vers le compte";
            this.dgvTransferHistoryTo.MinimumWidth = 6;
            this.dgvTransferHistoryTo.Name = "dgvTransferHistoryTo";
            // 
            // dgvTransferHistoryAmount
            // 
            this.dgvTransferHistoryAmount.HeaderText = "Montant";
            this.dgvTransferHistoryAmount.MinimumWidth = 6;
            this.dgvTransferHistoryAmount.Name = "dgvTransferHistoryAmount";
            // 
            // dgvTransferHistoryDate
            // 
            this.dgvTransferHistoryDate.HeaderText = "Date";
            this.dgvTransferHistoryDate.MinimumWidth = 6;
            this.dgvTransferHistoryDate.Name = "dgvTransferHistoryDate";
            // 
            // labelTransferHistory
            // 
            this.labelTransferHistory.AutoSize = true;
            this.labelTransferHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransferHistory.Location = new System.Drawing.Point(273, 37);
            this.labelTransferHistory.Name = "labelTransferHistory";
            this.labelTransferHistory.Size = new System.Drawing.Size(255, 29);
            this.labelTransferHistory.TabIndex = 1;
            this.labelTransferHistory.Text = "Historique de virement";
            // 
            // FormTransferHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTransferHistory);
            this.Controls.Add(this.DgvTransferHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTransferHistory";
            this.Text = "FormTransferHistory";
            this.Load += new System.EventHandler(this.FormTransferHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransferHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTransferHistory;
        private System.Windows.Forms.Label labelTransferHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransferHistoryFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransferHistoryTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransferHistoryAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTransferHistoryDate;
    }
}
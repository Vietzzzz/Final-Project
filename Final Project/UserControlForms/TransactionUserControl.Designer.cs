namespace Final_Project.UserControlForms
{
    partial class TransactionUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txn_datagridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txn_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // txn_datagridview
            // 
            this.txn_datagridview.AllowUserToOrderColumns = true;
            this.txn_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txn_datagridview.Location = new System.Drawing.Point(19, 57);
            this.txn_datagridview.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.txn_datagridview.Name = "txn_datagridview";
            this.txn_datagridview.RowHeadersWidth = 51;
            this.txn_datagridview.RowTemplate.Height = 24;
            this.txn_datagridview.Size = new System.Drawing.Size(945, 475);
            this.txn_datagridview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Import history";
            // 
            // TransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txn_datagridview);
            this.Name = "TransactionUserControl";
            this.Size = new System.Drawing.Size(995, 610);
            ((System.ComponentModel.ISupportInitialize)(this.txn_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView txn_datagridview;
        private System.Windows.Forms.Label label1;
    }
}

namespace Final_Project.UserControlForms
{
    partial class ExportUserControlForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txn_datagridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txn_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Export history";
            // 
            // txn_datagridview
            // 
            this.txn_datagridview.AllowUserToOrderColumns = true;
            this.txn_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txn_datagridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txn_datagridview.Location = new System.Drawing.Point(0, 63);
            this.txn_datagridview.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.txn_datagridview.Name = "txn_datagridview";
            this.txn_datagridview.RowHeadersWidth = 51;
            this.txn_datagridview.RowTemplate.Height = 24;
            this.txn_datagridview.Size = new System.Drawing.Size(1105, 553);
            this.txn_datagridview.TabIndex = 3;
            // 
            // ExportUserControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txn_datagridview);
            this.Controls.Add(this.label1);
            this.Name = "ExportUserControlForm";
            this.Size = new System.Drawing.Size(1105, 616);
            ((System.ComponentModel.ISupportInitialize)(this.txn_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView txn_datagridview;
    }
}

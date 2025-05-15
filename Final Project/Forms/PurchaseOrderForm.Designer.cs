namespace Final_Project.Forms
{
    partial class PurchaseOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderForm));
            this.product_datagridview = new System.Windows.Forms.DataGridView();
            this.supplier_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.error_message_label = new System.Windows.Forms.Label();
            this.fail_label = new System.Windows.Forms.Label();
            this.import_product_labe = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.totalprice_purchase_order = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_datagridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_datagridview
            // 
            this.product_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_datagridview.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_datagridview.Location = new System.Drawing.Point(5, 0);
            this.product_datagridview.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.product_datagridview.Name = "product_datagridview";
            this.product_datagridview.RowHeadersWidth = 51;
            this.product_datagridview.RowTemplate.Height = 24;
            this.product_datagridview.Size = new System.Drawing.Size(872, 285);
            this.product_datagridview.TabIndex = 2;
            // 
            // supplier_textbox
            // 
            this.supplier_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplier_textbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.supplier_textbox.Location = new System.Drawing.Point(701, 22);
            this.supplier_textbox.Multiline = true;
            this.supplier_textbox.Name = "supplier_textbox";
            this.supplier_textbox.Size = new System.Drawing.Size(140, 28);
            this.supplier_textbox.TabIndex = 1;
            this.supplier_textbox.TextChanged += new System.EventHandler(this.supplier_textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(474, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Supplier:";
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.White;
            this.save_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.save_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.save_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(718, 108);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 51);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.error_message_label);
            this.panel2.Controls.Add(this.fail_label);
            this.panel2.Controls.Add(this.import_product_labe);
            this.panel2.Controls.Add(this.delete_button);
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Controls.Add(this.name_textbox);
            this.panel2.Controls.Add(this.totalprice_purchase_order);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.save_button);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.supplier_textbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 175);
            this.panel2.TabIndex = 5;
            // 
            // error_message_label
            // 
            this.error_message_label.AutoSize = true;
            this.error_message_label.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.error_message_label.ForeColor = System.Drawing.Color.Red;
            this.error_message_label.Location = new System.Drawing.Point(39, 139);
            this.error_message_label.Name = "error_message_label";
            this.error_message_label.Size = new System.Drawing.Size(50, 20);
            this.error_message_label.TabIndex = 18;
            this.error_message_label.Text = "label1";
            // 
            // fail_label
            // 
            this.fail_label.BackColor = System.Drawing.Color.Transparent;
            this.fail_label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fail_label.ForeColor = System.Drawing.Color.Red;
            this.fail_label.Image = ((System.Drawing.Image)(resources.GetObject("fail_label.Image")));
            this.fail_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fail_label.Location = new System.Drawing.Point(38, 99);
            this.fail_label.Name = "fail_label";
            this.fail_label.Size = new System.Drawing.Size(185, 40);
            this.fail_label.TabIndex = 17;
            this.fail_label.Text = "Fail To Import!";
            this.fail_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // import_product_labe
            // 
            this.import_product_labe.AutoSize = true;
            this.import_product_labe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.import_product_labe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.import_product_labe.Location = new System.Drawing.Point(39, 9);
            this.import_product_labe.Name = "import_product_labe";
            this.import_product_labe.Size = new System.Drawing.Size(127, 23);
            this.import_product_labe.TabIndex = 10;
            this.import_product_labe.Text = "Import product";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.delete_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.delete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Image = global::Final_Project.Properties.Resources.delete;
            this.delete_button.Location = new System.Drawing.Point(318, 32);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(55, 52);
            this.delete_button.TabIndex = 9;
            this.delete_button.UseVisualStyleBackColor = false;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.add_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Image = global::Final_Project.Properties.Resources.plus;
            this.add_button.Location = new System.Drawing.Point(248, 32);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(55, 52);
            this.add_button.TabIndex = 8;
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.Location = new System.Drawing.Point(39, 41);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(193, 34);
            this.name_textbox.TabIndex = 6;
            // 
            // totalprice_purchase_order
            // 
            this.totalprice_purchase_order.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalprice_purchase_order.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.totalprice_purchase_order.Location = new System.Drawing.Point(701, 64);
            this.totalprice_purchase_order.Name = "totalprice_purchase_order";
            this.totalprice_purchase_order.Size = new System.Drawing.Size(140, 28);
            this.totalprice_purchase_order.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(475, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "need to pay the supplier:";
            // 
            // PurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.product_datagridview);
            this.Name = "PurchaseOrderForm";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrderForm";
            this.Load += new System.EventHandler(this.PurchaseOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_datagridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView product_datagridview;
        private System.Windows.Forms.TextBox supplier_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalprice_purchase_order;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label import_product_labe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error_message_label;
        private System.Windows.Forms.Label fail_label;
    }
}
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Panel();
            this.totalprice_purchase_order = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.import_product_labe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error_message_label = new System.Windows.Forms.Label();
            this.fail_label = new System.Windows.Forms.Label();
            this.success_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.delete_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.Price,
            this.TotalPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(5, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(911, 285);
            this.dataGridView1.TabIndex = 2;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 125;
            // 
            // supplier_textbox
            // 
            this.supplier_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplier_textbox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_textbox.Location = new System.Drawing.Point(756, 19);
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
            this.label1.Location = new System.Drawing.Point(540, 19);
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
            this.save_button.Location = new System.Drawing.Point(756, 108);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 51);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete_button.Controls.Add(this.error_message_label);
            this.delete_button.Controls.Add(this.fail_label);
            this.delete_button.Controls.Add(this.success_label);
            this.delete_button.Controls.Add(this.import_product_labe);
            this.delete_button.Controls.Add(this.button1);
            this.delete_button.Controls.Add(this.add_button);
            this.delete_button.Controls.Add(this.search_button);
            this.delete_button.Controls.Add(this.textBox1);
            this.delete_button.Controls.Add(this.totalprice_purchase_order);
            this.delete_button.Controls.Add(this.label3);
            this.delete_button.Controls.Add(this.save_button);
            this.delete_button.Controls.Add(this.label1);
            this.delete_button.Controls.Add(this.supplier_textbox);
            this.delete_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.delete_button.Location = new System.Drawing.Point(5, 311);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(911, 175);
            this.delete_button.TabIndex = 5;
            // 
            // totalprice_purchase_order
            // 
            this.totalprice_purchase_order.AutoSize = true;
            this.totalprice_purchase_order.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalprice_purchase_order.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.totalprice_purchase_order.Location = new System.Drawing.Point(762, 61);
            this.totalprice_purchase_order.Name = "totalprice_purchase_order";
            this.totalprice_purchase_order.Size = new System.Drawing.Size(75, 28);
            this.totalprice_purchase_order.TabIndex = 5;
            this.totalprice_purchase_order.Text = "hahaha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 34);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Final_Project.Properties.Resources.delete;
            this.button1.Location = new System.Drawing.Point(391, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 52);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.add_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Image = global::Final_Project.Properties.Resources.plus;
            this.add_button.Location = new System.Drawing.Point(321, 28);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(55, 52);
            this.add_button.TabIndex = 8;
            this.add_button.UseVisualStyleBackColor = false;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.search_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.search_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Image = global::Final_Project.Properties.Resources.search;
            this.search_button.Location = new System.Drawing.Point(250, 28);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(55, 52);
            this.search_button.TabIndex = 7;
            this.search_button.UseVisualStyleBackColor = false;
            // 
            // import_product_labe
            // 
            this.import_product_labe.AutoSize = true;
            this.import_product_labe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.import_product_labe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.import_product_labe.Location = new System.Drawing.Point(39, 9);
            this.import_product_labe.Name = "import_product_labe";
            this.import_product_labe.Size = new System.Drawing.Size(127, 23);
            this.import_product_labe.TabIndex = 10;
            this.import_product_labe.Text = "Import product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(541, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "need to pay the supplier:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
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
            this.fail_label.Text = "Fail To Update!";
            this.fail_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // success_label
            // 
            this.success_label.BackColor = System.Drawing.Color.Transparent;
            this.success_label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.success_label.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.success_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.success_label.Location = new System.Drawing.Point(38, 99);
            this.success_label.Name = "success_label";
            this.success_label.Size = new System.Drawing.Size(240, 40);
            this.success_label.TabIndex = 16;
            this.success_label.Text = "Update Successfully!";
            this.success_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 486);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PurchaseOrderForm";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrderForm";
            this.Load += new System.EventHandler(this.PurchaseOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.delete_button.ResumeLayout(false);
            this.delete_button.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.TextBox supplier_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Panel delete_button;
        private System.Windows.Forms.Label totalprice_purchase_order;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label import_product_labe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error_message_label;
        private System.Windows.Forms.Label fail_label;
        private System.Windows.Forms.Label success_label;
    }
}
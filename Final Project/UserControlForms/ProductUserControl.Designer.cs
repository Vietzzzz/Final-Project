namespace Final_Project.UserControlForms
{
    partial class ProductUserControl
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.weight_label = new System.Windows.Forms.Label();
            this.product_infor_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.product_data_gridview = new System.Windows.Forms.DataGridView();
            this.category_label = new System.Windows.Forms.Label();
            this.unit_label = new System.Windows.Forms.Label();
            this.unit_textbox = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.category_textbox = new System.Windows.Forms.TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.price_textbox = new System.Windows.Forms.NumericUpDown();
            this.quantity_textbox = new System.Windows.Forms.NumericUpDown();
            this.weight_textbox = new System.Windows.Forms.NumericUpDown();
            this.delete_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.update_product_button = new System.Windows.Forms.Button();
            this.add_product_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_data_gridview)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price_textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_textbox)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.weight_label.ForeColor = System.Drawing.Color.White;
            this.weight_label.Location = new System.Drawing.Point(299, 161);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(69, 23);
            this.weight_label.TabIndex = 13;
            this.weight_label.Text = "Weight:";
            // 
            // product_infor_label
            // 
            this.product_infor_label.AutoSize = true;
            this.product_infor_label.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.product_infor_label.ForeColor = System.Drawing.Color.Black;
            this.product_infor_label.Location = new System.Drawing.Point(3, 0);
            this.product_infor_label.Margin = new System.Windows.Forms.Padding(3);
            this.product_infor_label.Name = "product_infor_label";
            this.product_infor_label.Size = new System.Drawing.Size(300, 40);
            this.product_infor_label.TabIndex = 0;
            this.product_infor_label.Text = "Product Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.product_data_gridview);
            this.panel1.Controls.Add(this.product_infor_label);
            this.panel1.Location = new System.Drawing.Point(14, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 372);
            this.panel1.TabIndex = 2;
            // 
            // product_data_gridview
            // 
            this.product_data_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_data_gridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.product_data_gridview.Location = new System.Drawing.Point(0, 46);
            this.product_data_gridview.MultiSelect = false;
            this.product_data_gridview.Name = "product_data_gridview";
            this.product_data_gridview.RowHeadersWidth = 51;
            this.product_data_gridview.RowTemplate.Height = 24;
            this.product_data_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_data_gridview.Size = new System.Drawing.Size(959, 326);
            this.product_data_gridview.TabIndex = 1;
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.category_label.ForeColor = System.Drawing.Color.White;
            this.category_label.Location = new System.Drawing.Point(6, 105);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(85, 23);
            this.category_label.TabIndex = 8;
            this.category_label.Text = "Category:";
            this.category_label.Click += new System.EventHandler(this.category_label_Click);
            // 
            // unit_label
            // 
            this.unit_label.AutoSize = true;
            this.unit_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.unit_label.ForeColor = System.Drawing.Color.White;
            this.unit_label.Location = new System.Drawing.Point(6, 161);
            this.unit_label.Name = "unit_label";
            this.unit_label.Size = new System.Drawing.Size(46, 23);
            this.unit_label.TabIndex = 6;
            this.unit_label.Text = "Unit:";
            this.unit_label.Click += new System.EventHandler(this.unit_label_Click);
            // 
            // unit_textbox
            // 
            this.unit_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unit_textbox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.unit_textbox.ForeColor = System.Drawing.Color.Black;
            this.unit_textbox.Location = new System.Drawing.Point(109, 154);
            this.unit_textbox.Multiline = true;
            this.unit_textbox.Name = "unit_textbox";
            this.unit_textbox.Size = new System.Drawing.Size(155, 30);
            this.unit_textbox.TabIndex = 5;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.price_label.ForeColor = System.Drawing.Color.White;
            this.price_label.Location = new System.Drawing.Point(299, 44);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(51, 23);
            this.price_label.TabIndex = 4;
            this.price_label.Text = "Price:";
            this.price_label.Click += new System.EventHandler(this.price_label_Click);
            // 
            // category_textbox
            // 
            this.category_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category_textbox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.category_textbox.ForeColor = System.Drawing.Color.Black;
            this.category_textbox.Location = new System.Drawing.Point(109, 98);
            this.category_textbox.Multiline = true;
            this.category_textbox.Name = "category_textbox";
            this.category_textbox.Size = new System.Drawing.Size(155, 30);
            this.category_textbox.TabIndex = 3;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.quantity_label.ForeColor = System.Drawing.Color.White;
            this.quantity_label.Location = new System.Drawing.Point(299, 105);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(81, 23);
            this.quantity_label.TabIndex = 2;
            this.quantity_label.Text = "Quantity:";
            this.quantity_label.Click += new System.EventHandler(this.quantity_label_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_textbox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.name_textbox.ForeColor = System.Drawing.Color.Black;
            this.name_textbox.Location = new System.Drawing.Point(109, 37);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(155, 30);
            this.name_textbox.TabIndex = 1;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(6, 44);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(60, 23);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.weight_textbox);
            this.panel2.Controls.Add(this.quantity_textbox);
            this.panel2.Controls.Add(this.price_textbox);
            this.panel2.Controls.Add(this.delete_button);
            this.panel2.Controls.Add(this.search_button);
            this.panel2.Controls.Add(this.update_product_button);
            this.panel2.Controls.Add(this.add_product_button);
            this.panel2.Controls.Add(this.weight_label);
            this.panel2.Controls.Add(this.category_label);
            this.panel2.Controls.Add(this.unit_label);
            this.panel2.Controls.Add(this.unit_textbox);
            this.panel2.Controls.Add(this.price_label);
            this.panel2.Controls.Add(this.category_textbox);
            this.panel2.Controls.Add(this.quantity_label);
            this.panel2.Controls.Add(this.name_textbox);
            this.panel2.Controls.Add(this.name_label);
            this.panel2.Location = new System.Drawing.Point(14, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 218);
            this.panel2.TabIndex = 3;
            // 
            // price_textbox
            // 
            this.price_textbox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.price_textbox.ForeColor = System.Drawing.Color.Black;
            this.price_textbox.Location = new System.Drawing.Point(408, 37);
            this.price_textbox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(155, 30);
            this.price_textbox.TabIndex = 17;
            this.price_textbox.ThousandsSeparator = true;
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.quantity_textbox.ForeColor = System.Drawing.Color.Black;
            this.quantity_textbox.Location = new System.Drawing.Point(408, 98);
            this.quantity_textbox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(155, 30);
            this.quantity_textbox.TabIndex = 18;
            this.quantity_textbox.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // weight_textbox
            // 
            this.weight_textbox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.weight_textbox.ForeColor = System.Drawing.Color.Black;
            this.weight_textbox.Location = new System.Drawing.Point(408, 154);
            this.weight_textbox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.weight_textbox.Name = "weight_textbox";
            this.weight_textbox.Size = new System.Drawing.Size(155, 30);
            this.weight_textbox.TabIndex = 19;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.delete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.delete_button.ForeColor = System.Drawing.Color.Black;
            this.delete_button.Image = global::Final_Project.Properties.Resources.ok;
            this.delete_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_button.Location = new System.Drawing.Point(784, 119);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(140, 65);
            this.delete_button.TabIndex = 16;
            this.delete_button.Text = "Delete ";
            this.delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_product_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.search_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.search_button.ForeColor = System.Drawing.Color.Black;
            this.search_button.Image = global::Final_Project.Properties.Resources.search;
            this.search_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_button.Location = new System.Drawing.Point(784, 37);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(140, 65);
            this.search_button.TabIndex = 15;
            this.search_button.Text = "Search";
            this.search_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.search_button.UseVisualStyleBackColor = false;
            // 
            // update_product_button
            // 
            this.update_product_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_product_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_product_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.update_product_button.FlatAppearance.BorderSize = 0;
            this.update_product_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.update_product_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.update_product_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_product_button.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.update_product_button.ForeColor = System.Drawing.Color.Black;
            this.update_product_button.Image = global::Final_Project.Properties.Resources.ok;
            this.update_product_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.update_product_button.Location = new System.Drawing.Point(625, 119);
            this.update_product_button.Name = "update_product_button";
            this.update_product_button.Size = new System.Drawing.Size(140, 65);
            this.update_product_button.TabIndex = 10;
            this.update_product_button.Text = "Update ";
            this.update_product_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_product_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.update_product_button.UseVisualStyleBackColor = false;
            // 
            // add_product_button
            // 
            this.add_product_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_product_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_product_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.add_product_button.FlatAppearance.BorderSize = 0;
            this.add_product_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.add_product_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.add_product_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_product_button.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.add_product_button.ForeColor = System.Drawing.Color.Black;
            this.add_product_button.Image = global::Final_Project.Properties.Resources.ok;
            this.add_product_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_product_button.Location = new System.Drawing.Point(625, 37);
            this.add_product_button.Name = "add_product_button";
            this.add_product_button.Size = new System.Drawing.Size(140, 65);
            this.add_product_button.TabIndex = 10;
            this.add_product_button.Text = "Add ";
            this.add_product_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_product_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.add_product_button.UseVisualStyleBackColor = false;
            this.add_product_button.Click += new System.EventHandler(this.add_product_button_Click);
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(995, 610);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_data_gridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price_textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_textbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button update_product_button;
        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.Label product_infor_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView product_data_gridview;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label unit_label;
        private System.Windows.Forms.TextBox unit_textbox;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.TextBox category_textbox;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button add_product_button;
        private System.Windows.Forms.NumericUpDown weight_textbox;
        private System.Windows.Forms.NumericUpDown quantity_textbox;
        private System.Windows.Forms.NumericUpDown price_textbox;
    }
}

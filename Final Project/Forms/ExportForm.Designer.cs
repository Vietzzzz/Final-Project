﻿namespace Final_Project.Forms
{
    partial class ExportForm
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
            this.product_datagridview = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.error_message_label = new System.Windows.Forms.Label();
            this.import_product_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.create_date_label = new System.Windows.Forms.Label();
            this.totalitem_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalamount_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_datagridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_datagridview
            // 
            this.product_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_datagridview.DefaultCellStyle = dataGridViewCellStyle1;
            this.product_datagridview.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_datagridview.Location = new System.Drawing.Point(0, 0);
            this.product_datagridview.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.product_datagridview.Name = "product_datagridview";
            this.product_datagridview.RowHeadersWidth = 51;
            this.product_datagridview.RowTemplate.Height = 24;
            this.product_datagridview.Size = new System.Drawing.Size(882, 285);
            this.product_datagridview.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.address_textbox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.error_message_label);
            this.panel2.Controls.Add(this.import_product_label);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.delete_button);
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Controls.Add(this.name_textbox);
            this.panel2.Controls.Add(this.save_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 175);
            this.panel2.TabIndex = 6;
            // 
            // address_textbox
            // 
            this.address_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_textbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.address_textbox.Location = new System.Drawing.Point(283, 51);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(140, 30);
            this.address_textbox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(279, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Address";
            // 
            // error_message_label
            // 
            this.error_message_label.AutoSize = true;
            this.error_message_label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.error_message_label.ForeColor = System.Drawing.Color.Brown;
            this.error_message_label.Location = new System.Drawing.Point(17, 140);
            this.error_message_label.Name = "error_message_label";
            this.error_message_label.Size = new System.Drawing.Size(50, 20);
            this.error_message_label.TabIndex = 18;
            this.error_message_label.Text = "label1";
            // 
            // import_product_label
            // 
            this.import_product_label.AutoSize = true;
            this.import_product_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.import_product_label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.import_product_label.Location = new System.Drawing.Point(37, 19);
            this.import_product_label.Name = "import_product_label";
            this.import_product_label.Size = new System.Drawing.Size(124, 23);
            this.import_product_label.TabIndex = 10;
            this.import_product_label.Text = "Export product";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.create_date_label);
            this.panel1.Controls.Add(this.totalitem_label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.totalamount_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.panel1.Location = new System.Drawing.Point(515, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 175);
            this.panel1.TabIndex = 24;
            // 
            // create_date_label
            // 
            this.create_date_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.create_date_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.create_date_label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.create_date_label.Location = new System.Drawing.Point(198, 115);
            this.create_date_label.Name = "create_date_label";
            this.create_date_label.Size = new System.Drawing.Size(140, 23);
            this.create_date_label.TabIndex = 22;
            this.create_date_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalitem_label
            // 
            this.totalitem_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalitem_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalitem_label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.totalitem_label.Location = new System.Drawing.Point(198, 86);
            this.totalitem_label.Name = "totalitem_label";
            this.totalitem_label.Size = new System.Drawing.Size(140, 23);
            this.totalitem_label.TabIndex = 20;
            this.totalitem_label.Text = "0";
            this.totalitem_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(29, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(29, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Amount:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total Items:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalamount_label
            // 
            this.totalamount_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalamount_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalamount_label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.totalamount_label.Location = new System.Drawing.Point(198, 53);
            this.totalamount_label.Name = "totalamount_label";
            this.totalamount_label.Size = new System.Drawing.Size(140, 23);
            this.totalamount_label.TabIndex = 5;
            this.totalamount_label.Text = "0";
            this.totalamount_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Transparent;
            this.delete_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.delete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Image = global::Final_Project.Properties.Resources.delete;
            this.delete_button.Location = new System.Drawing.Point(331, 107);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(55, 52);
            this.delete_button.TabIndex = 9;
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.Transparent;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Image = global::Final_Project.Properties.Resources.plus;
            this.add_button.Location = new System.Drawing.Point(259, 107);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(55, 52);
            this.add_button.TabIndex = 8;
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.Location = new System.Drawing.Point(37, 51);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(193, 34);
            this.name_textbox.TabIndex = 6;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Transparent;
            this.save_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.save_button.FlatAppearance.BorderSize = 0;
            this.save_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.save_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Image = global::Final_Project.Properties.Resources.save;
            this.save_button.Location = new System.Drawing.Point(405, 108);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(55, 52);
            this.save_button.TabIndex = 4;
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.product_datagridview);
            this.Name = "ExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportForm";
            ((System.ComponentModel.ISupportInitialize)(this.product_datagridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView product_datagridview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label error_message_label;
        private System.Windows.Forms.Label import_product_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label create_date_label;
        private System.Windows.Forms.Label totalitem_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalamount_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button save_button;
    }
}
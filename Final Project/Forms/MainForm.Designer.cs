namespace Final_Project.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.company_name = new System.Windows.Forms.Label();
            this.panel_txn = new System.Windows.Forms.Panel();
            this.txn_btn = new System.Windows.Forms.Button();
            this.panel_home = new System.Windows.Forms.Panel();
            this.home_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_product = new System.Windows.Forms.Panel();
            this.product_btn = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.product_usercontrol = new Final_Project.UserControlForms.ProductUserControl();
            this.transaction_usercontrol = new Final_Project.UserControlForms.TransactionUserControl();
            this.home_usercontrol = new Final_Project.UserControlForms.Home();
            this.panel1.SuspendLayout();
            this.panel_txn.SuspendLayout();
            this.panel_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_product.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.company_name);
            this.panel1.Controls.Add(this.panel_txn);
            this.panel1.Controls.Add(this.panel_home);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel_product);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 658);
            this.panel1.TabIndex = 2;
            // 
            // company_name
            // 
            this.company_name.AutoSize = true;
            this.company_name.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_name.ForeColor = System.Drawing.Color.White;
            this.company_name.Location = new System.Drawing.Point(44, 190);
            this.company_name.Name = "company_name";
            this.company_name.Size = new System.Drawing.Size(165, 54);
            this.company_name.TabIndex = 0;
            this.company_name.Text = "Droppii";
            // 
            // panel_txn
            // 
            this.panel_txn.BackColor = System.Drawing.Color.White;
            this.panel_txn.Controls.Add(this.txn_btn);
            this.panel_txn.Location = new System.Drawing.Point(10, 444);
            this.panel_txn.Name = "panel_txn";
            this.panel_txn.Size = new System.Drawing.Size(236, 52);
            this.panel_txn.TabIndex = 3;
            // 
            // txn_btn
            // 
            this.txn_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txn_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.txn_btn.FlatAppearance.BorderSize = 0;
            this.txn_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.txn_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.txn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txn_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txn_btn.ForeColor = System.Drawing.Color.Black;
            this.txn_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txn_btn.Location = new System.Drawing.Point(0, 0);
            this.txn_btn.Name = "txn_btn";
            this.txn_btn.Size = new System.Drawing.Size(236, 52);
            this.txn_btn.TabIndex = 4;
            this.txn_btn.Text = "TRANSACTION";
            this.txn_btn.UseVisualStyleBackColor = true;
            this.txn_btn.Click += new System.EventHandler(this.transaction_button_Click);
            // 
            // panel_home
            // 
            this.panel_home.BackColor = System.Drawing.Color.White;
            this.panel_home.Controls.Add(this.home_btn);
            this.panel_home.Location = new System.Drawing.Point(10, 328);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(236, 52);
            this.panel_home.TabIndex = 1;
            // 
            // home_btn
            // 
            this.home_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home_btn.AutoSize = true;
            this.home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.home_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.Color.Black;
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Location = new System.Drawing.Point(0, 0);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(236, 52);
            this.home_btn.TabIndex = 4;
            this.home_btn.Text = "HOME\r\n";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(49, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel_product
            // 
            this.panel_product.BackColor = System.Drawing.Color.White;
            this.panel_product.Controls.Add(this.product_btn);
            this.panel_product.Location = new System.Drawing.Point(10, 386);
            this.panel_product.Name = "panel_product";
            this.panel_product.Size = new System.Drawing.Size(236, 52);
            this.panel_product.TabIndex = 2;
            // 
            // product_btn
            // 
            this.product_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.product_btn.FlatAppearance.BorderSize = 0;
            this.product_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.product_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.product_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_btn.ForeColor = System.Drawing.Color.Black;
            this.product_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.product_btn.Location = new System.Drawing.Point(0, 0);
            this.product_btn.Name = "product_btn";
            this.product_btn.Size = new System.Drawing.Size(236, 52);
            this.product_btn.TabIndex = 4;
            this.product_btn.Text = "PRODUCT";
            this.product_btn.UseVisualStyleBackColor = true;
            this.product_btn.Click += new System.EventHandler(this.product_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_button.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.exit_button.Location = new System.Drawing.Point(961, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(36, 42);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "X";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exit_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(249, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 42);
            this.panel2.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // product_usercontrol
            // 
            this.product_usercontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_usercontrol.Location = new System.Drawing.Point(249, 42);
            this.product_usercontrol.Name = "product_usercontrol";
            this.product_usercontrol.Size = new System.Drawing.Size(997, 616);
            this.product_usercontrol.TabIndex = 10;
            // 
            // transaction_usercontrol
            // 
            this.transaction_usercontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transaction_usercontrol.Location = new System.Drawing.Point(249, 42);
            this.transaction_usercontrol.Name = "transaction_usercontrol";
            this.transaction_usercontrol.Size = new System.Drawing.Size(997, 616);
            this.transaction_usercontrol.TabIndex = 11;
            // 
            // home_usercontrol
            // 
            this.home_usercontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_usercontrol.Location = new System.Drawing.Point(249, 42);
            this.home_usercontrol.Name = "home_usercontrol";
            this.home_usercontrol.Size = new System.Drawing.Size(997, 616);
            this.home_usercontrol.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 658);
            this.Controls.Add(this.home_usercontrol);
            this.Controls.Add(this.transaction_usercontrol);
            this.Controls.Add(this.product_usercontrol);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_txn.ResumeLayout(false);
            this.panel_home.ResumeLayout(false);
            this.panel_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_product.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label company_name;
        private System.Windows.Forms.Panel panel_txn;
        private System.Windows.Forms.Button txn_btn;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_product;
        private System.Windows.Forms.Button product_btn;
        private System.Windows.Forms.Label exit_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UserControlForms.Home home_usercontrol;
        private UserControlForms.TransactionUserControl transaction_usercontrol;
        private UserControlForms.ProductUserControl product_usercontrol;
    }
}
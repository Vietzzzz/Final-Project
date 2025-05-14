namespace Final_Project.Forms
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.register_button = new System.Windows.Forms.Button();
            this.register_label = new System.Windows.Forms.Label();
            this.company_name = new System.Windows.Forms.Label();
            this.logo_picture_box = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.login_acc_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.register_button);
            this.panel1.Controls.Add(this.register_label);
            this.panel1.Controls.Add(this.company_name);
            this.panel1.Controls.Add(this.logo_picture_box);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 600);
            this.panel1.TabIndex = 8;
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.Color.White;
            this.register_button.FlatAppearance.BorderSize = 0;
            this.register_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_button.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.register_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.register_button.Location = new System.Drawing.Point(71, 523);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(99, 49);
            this.register_button.TabIndex = 5;
            this.register_button.Text = "Signup";
            this.register_button.UseVisualStyleBackColor = false;
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.register_label.ForeColor = System.Drawing.Color.White;
            this.register_label.Location = new System.Drawing.Point(30, 485);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(179, 23);
            this.register_label.TabIndex = 4;
            this.register_label.Text = "Register Your Account";
            // 
            // company_name
            // 
            this.company_name.AutoSize = true;
            this.company_name.BackColor = System.Drawing.Color.Transparent;
            this.company_name.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_name.ForeColor = System.Drawing.Color.White;
            this.company_name.Location = new System.Drawing.Point(40, 241);
            this.company_name.Name = "company_name";
            this.company_name.Size = new System.Drawing.Size(165, 54);
            this.company_name.TabIndex = 3;
            this.company_name.Text = "Droppii";
            // 
            // logo_picture_box
            // 
            this.logo_picture_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo_picture_box.BackColor = System.Drawing.Color.White;
            this.logo_picture_box.Image = global::Final_Project.Properties.Resources.logistics;
            this.logo_picture_box.Location = new System.Drawing.Point(49, 73);
            this.logo_picture_box.Name = "logo_picture_box";
            this.logo_picture_box.Size = new System.Drawing.Size(150, 150);
            this.logo_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo_picture_box.TabIndex = 2;
            this.logo_picture_box.TabStop = false;
            // 
            // exit_button
            // 
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.exit_button.Location = new System.Drawing.Point(714, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(36, 41);
            this.exit_button.TabIndex = 15;
            this.exit_button.Text = "X";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(216)))));
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(295, 523);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(99, 49);
            this.login_button.TabIndex = 14;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_textbox
            // 
            this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_textbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(295, 369);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(292, 30);
            this.password_textbox.TabIndex = 13;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // username_textbox
            // 
            this.username_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_textbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(295, 270);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(292, 30);
            this.username_textbox.TabIndex = 12;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(216)))));
            this.password_label.Location = new System.Drawing.Point(290, 323);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(97, 28);
            this.password_label.TabIndex = 11;
            this.password_label.Text = "Password";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(216)))));
            this.username_label.Location = new System.Drawing.Point(290, 224);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(104, 28);
            this.username_label.TabIndex = 10;
            this.username_label.Text = "Username";
            // 
            // login_acc_label
            // 
            this.login_acc_label.AutoSize = true;
            this.login_acc_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_acc_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(216)))));
            this.login_acc_label.Location = new System.Drawing.Point(286, 108);
            this.login_acc_label.Name = "login_acc_label";
            this.login_acc_label.Size = new System.Drawing.Size(292, 54);
            this.login_acc_label.TabIndex = 9;
            this.login_acc_label.Text = "Login Account";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.login_acc_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.Label company_name;
        private System.Windows.Forms.PictureBox logo_picture_box;
        private System.Windows.Forms.Label exit_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label login_acc_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
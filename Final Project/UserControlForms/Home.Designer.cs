namespace Final_Project.UserControlForms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.feature3_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.feature2_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.feature1_label = new System.Windows.Forms.Label();
            this.why_choose_label = new System.Windows.Forms.Label();
            this.description_content = new System.Windows.Forms.TextBox();
            this.main_function_textbox = new System.Windows.Forms.Label();
            this.description_home = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.panel4);
            this.main_panel.Controls.Add(this.panel3);
            this.main_panel.Controls.Add(this.panel2);
            this.main_panel.Controls.Add(this.panel1);
            this.main_panel.Controls.Add(this.why_choose_label);
            this.main_panel.Controls.Add(this.description_content);
            this.main_panel.Controls.Add(this.main_function_textbox);
            this.main_panel.Controls.Add(this.description_home);
            this.main_panel.Location = new System.Drawing.Point(24, 71);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1060, 538);
            this.main_panel.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(22, 169);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1016, 150);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(623, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tracking real-time inventory";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(266, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Create import/export order";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(86, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product CRUD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.feature3_label);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.panel3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(812, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 150);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final_Project.Properties.Resources.history;
            this.pictureBox3.Location = new System.Drawing.Point(57, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // feature3_label
            // 
            this.feature3_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feature3_label.AutoSize = true;
            this.feature3_label.BackColor = System.Drawing.Color.Transparent;
            this.feature3_label.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.feature3_label.ForeColor = System.Drawing.Color.Black;
            this.feature3_label.Location = new System.Drawing.Point(62, 15);
            this.feature3_label.Name = "feature3_label";
            this.feature3_label.Size = new System.Drawing.Size(119, 25);
            this.feature3_label.TabIndex = 2;
            this.feature3_label.Text = "Track History";
            this.feature3_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.feature2_label);
            this.panel2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(424, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 150);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.high_five;
            this.pictureBox1.Location = new System.Drawing.Point(61, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // feature2_label
            // 
            this.feature2_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feature2_label.AutoSize = true;
            this.feature2_label.BackColor = System.Drawing.Color.Transparent;
            this.feature2_label.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.feature2_label.ForeColor = System.Drawing.Color.Black;
            this.feature2_label.Location = new System.Drawing.Point(45, 15);
            this.feature2_label.Name = "feature2_label";
            this.feature2_label.Size = new System.Drawing.Size(129, 25);
            this.feature2_label.TabIndex = 1;
            this.feature2_label.Text = "Easy for using";
            this.feature2_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.feature1_label);
            this.panel1.Location = new System.Drawing.Point(22, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 150);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.precision;
            this.pictureBox2.Location = new System.Drawing.Point(60, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // feature1_label
            // 
            this.feature1_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feature1_label.AutoSize = true;
            this.feature1_label.BackColor = System.Drawing.Color.Transparent;
            this.feature1_label.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.feature1_label.ForeColor = System.Drawing.Color.Black;
            this.feature1_label.Location = new System.Drawing.Point(11, 13);
            this.feature1_label.Name = "feature1_label";
            this.feature1_label.Size = new System.Drawing.Size(203, 25);
            this.feature1_label.TabIndex = 0;
            this.feature1_label.Text = "Accurate Management";
            this.feature1_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // why_choose_label
            // 
            this.why_choose_label.AutoSize = true;
            this.why_choose_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.why_choose_label.ForeColor = System.Drawing.Color.Black;
            this.why_choose_label.Location = new System.Drawing.Point(17, 338);
            this.why_choose_label.Name = "why_choose_label";
            this.why_choose_label.Size = new System.Drawing.Size(175, 28);
            this.why_choose_label.TabIndex = 3;
            this.why_choose_label.Text = "Why Choose DHV";
            // 
            // description_content
            // 
            this.description_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description_content.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_content.ForeColor = System.Drawing.Color.Black;
            this.description_content.Location = new System.Drawing.Point(22, 50);
            this.description_content.Multiline = true;
            this.description_content.Name = "description_content";
            this.description_content.Size = new System.Drawing.Size(1016, 72);
            this.description_content.TabIndex = 0;
            this.description_content.Text = resources.GetString("description_content.Text");
            // 
            // main_function_textbox
            // 
            this.main_function_textbox.AutoSize = true;
            this.main_function_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_function_textbox.ForeColor = System.Drawing.Color.Black;
            this.main_function_textbox.Location = new System.Drawing.Point(17, 125);
            this.main_function_textbox.Name = "main_function_textbox";
            this.main_function_textbox.Size = new System.Drawing.Size(142, 28);
            this.main_function_textbox.TabIndex = 2;
            this.main_function_textbox.Text = "Main Function";
            // 
            // description_home
            // 
            this.description_home.AutoSize = true;
            this.description_home.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_home.ForeColor = System.Drawing.Color.Black;
            this.description_home.Location = new System.Drawing.Point(17, 10);
            this.description_home.Name = "description_home";
            this.description_home.Size = new System.Drawing.Size(115, 28);
            this.description_home.TabIndex = 0;
            this.description_home.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(376, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome To DHV";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1105, 616);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label feature3_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label feature2_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label feature1_label;
        private System.Windows.Forms.Label why_choose_label;
        private System.Windows.Forms.TextBox description_content;
        private System.Windows.Forms.Label main_function_textbox;
        private System.Windows.Forms.Label description_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

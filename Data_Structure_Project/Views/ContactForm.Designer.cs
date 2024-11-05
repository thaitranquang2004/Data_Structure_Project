namespace Data_Structure_Project.Views
{
    partial class ContactForm
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
            panel_info = new Panel();
            label3 = new Label();
            txt_email = new TextBox();
            txt_mobile = new TextBox();
            label2 = new Label();
            txt_name = new TextBox();
            label1 = new Label();
            tv_show = new TreeView();
            btn_new = new Button();
            btn_edit = new Button();
            btn_cancel = new Button();
            btn_save = new Button();
            btn_export = new Button();
            txt_search = new TextBox();
            label4 = new Label();
            lb_test = new Label();
            panel_info.SuspendLayout();
            SuspendLayout();
            // 
            // panel_info
            // 
            panel_info.Controls.Add(label3);
            panel_info.Controls.Add(txt_email);
            panel_info.Controls.Add(txt_mobile);
            panel_info.Controls.Add(label2);
            panel_info.Controls.Add(txt_name);
            panel_info.Controls.Add(label1);
            panel_info.Location = new Point(248, 12);
            panel_info.Name = "panel_info";
            panel_info.Size = new Size(399, 393);
            panel_info.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 76);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(64, 68);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(173, 23);
            txt_email.TabIndex = 4;
            // 
            // txt_mobile
            // 
            txt_mobile.Location = new Point(64, 39);
            txt_mobile.Name = "txt_mobile";
            txt_mobile.Size = new Size(173, 23);
            txt_mobile.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 47);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Mobile:";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(64, 10);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(173, 23);
            txt_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 18);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // tv_show
            // 
            tv_show.Location = new Point(12, 51);
            tv_show.Name = "tv_show";
            tv_show.Size = new Size(230, 383);
            tv_show.TabIndex = 1;
            // 
            // btn_new
            // 
            btn_new.Location = new Point(248, 411);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(75, 23);
            btn_new.TabIndex = 2;
            btn_new.Text = "New";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(329, 411);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 3;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(410, 411);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 4;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(491, 411);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 5;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_export
            // 
            btn_export.Location = new Point(572, 411);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(75, 23);
            btn_export.TabIndex = 6;
            btn_export.Text = "Export";
            btn_export.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(73, 22);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(169, 23);
            txt_search.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 30);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 8;
            label4.Text = "Search:";
            // 
            // lb_test
            // 
            lb_test.AutoSize = true;
            lb_test.Location = new Point(665, 22);
            lb_test.Name = "lb_test";
            lb_test.Size = new Size(59, 15);
            lb_test.TabIndex = 9;
            lb_test.Text = "Loading...";
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1014, 454);
            Controls.Add(lb_test);
            Controls.Add(label4);
            Controls.Add(txt_search);
            Controls.Add(btn_export);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Controls.Add(btn_edit);
            Controls.Add(btn_new);
            Controls.Add(tv_show);
            Controls.Add(panel_info);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "ContactForm";
            Text = "CONTACT";
            panel_info.ResumeLayout(false);
            panel_info.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_info;
        private TreeView tv_show;
        private Label label3;
        private TextBox txt_email;
        private TextBox txt_mobile;
        private Label label2;
        private TextBox txt_name;
        private Label label1;
        private Button btn_new;
        private Button btn_edit;
        private Button btn_cancel;
        private Button btn_save;
        private Button btn_export;
        private TextBox txt_search;
        private Label label4;
        private Label lb_test;
    }
}
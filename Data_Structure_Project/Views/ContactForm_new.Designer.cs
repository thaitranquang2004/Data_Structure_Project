namespace Data_Structure_Project.Views
{
    partial class ContactForm_new
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            btn_savefile = new Button();
            panel6 = new Panel();
            btn_loadfile = new Button();
            pictureBox2 = new PictureBox();
            label13 = new Label();
            btn_save = new Button();
            panel_info = new Panel();
            ptb_avatar = new DesignControls.roundedPicturebox();
            panel_status = new Panel();
            checkbx_block = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txt_email3 = new TextBox();
            txt_mobile3 = new TextBox();
            txt_email2 = new TextBox();
            txt_mobile2 = new TextBox();
            radi_female = new RadioButton();
            radi_male = new RadioButton();
            label6 = new Label();
            combx_relationship = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txt_address = new TextBox();
            label3 = new Label();
            txt_email = new TextBox();
            txt_mobile = new TextBox();
            label2 = new Label();
            txt_name = new TextBox();
            label12 = new Label();
            txsearch = new TextBox();
            resultContainer = new FlowLayoutPanel();
            timer = new System.Windows.Forms.Timer(components);
            btn_searchnew = new PictureBox();
            panel10 = new Panel();
            btn_editnew = new PictureBox();
            btn_removenew = new PictureBox();
            btn_newcontact = new PictureBox();
            btn_exportBlockNew = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_avatar).BeginInit();
            panel_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_searchnew).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_editnew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_removenew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_newcontact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exportBlockNew).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 47);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_contact_book_20;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pixelate", 20.25F, FontStyle.Bold);
            label1.Location = new Point(56, 6);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 2;
            label1.Text = "CONTACTS";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Gainsboro;
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(label13);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 47);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(182, 529);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_savefile);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 60);
            panel5.TabIndex = 20;
            // 
            // btn_savefile
            // 
            btn_savefile.BackColor = Color.Gainsboro;
            btn_savefile.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_savefile.ForeColor = Color.DimGray;
            btn_savefile.Location = new Point(-13, -8);
            btn_savefile.Name = "btn_savefile";
            btn_savefile.Size = new Size(202, 76);
            btn_savefile.TabIndex = 16;
            btn_savefile.Text = "    SAVE FILE";
            btn_savefile.TextAlign = ContentAlignment.MiddleLeft;
            btn_savefile.UseVisualStyleBackColor = false;
            btn_savefile.Click += btn_savefile_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btn_loadfile);
            panel6.Location = new Point(3, 69);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 60);
            panel6.TabIndex = 20;
            // 
            // btn_loadfile
            // 
            btn_loadfile.BackColor = Color.Gainsboro;
            btn_loadfile.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_loadfile.ForeColor = Color.DimGray;
            btn_loadfile.Location = new Point(-13, -17);
            btn_loadfile.Name = "btn_loadfile";
            btn_loadfile.Size = new Size(202, 85);
            btn_loadfile.TabIndex = 17;
            btn_loadfile.Text = "    LOAD FILE";
            btn_loadfile.TextAlign = ContentAlignment.MiddleLeft;
            btn_loadfile.UseVisualStyleBackColor = false;
            btn_loadfile.Click += btn_loadfile_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo_STU;
            pictureBox2.Location = new Point(13, 136);
            pictureBox2.Margin = new Padding(13, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
            label13.Location = new Point(3, 240);
            label13.Name = "label13";
            label13.Size = new Size(171, 13);
            label13.TabIndex = 22;
            label13.Text = " Tran Quang Thai  Nguyen Dai Tai";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.White;
            btn_save.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_save.ForeColor = Color.Black;
            btn_save.Location = new Point(184, 472);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(70, 39);
            btn_save.TabIndex = 6;
            btn_save.Text = "SAVE";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Visible = false;
            btn_save.Click += btn_save_Click;
            // 
            // panel_info
            // 
            panel_info.BackColor = Color.Gainsboro;
            panel_info.Controls.Add(btn_save);
            panel_info.Controls.Add(ptb_avatar);
            panel_info.Controls.Add(panel_status);
            panel_info.Controls.Add(label10);
            panel_info.Controls.Add(label9);
            panel_info.Controls.Add(label8);
            panel_info.Controls.Add(label7);
            panel_info.Controls.Add(txt_email3);
            panel_info.Controls.Add(txt_mobile3);
            panel_info.Controls.Add(txt_email2);
            panel_info.Controls.Add(txt_mobile2);
            panel_info.Controls.Add(radi_female);
            panel_info.Controls.Add(radi_male);
            panel_info.Controls.Add(label6);
            panel_info.Controls.Add(combx_relationship);
            panel_info.Controls.Add(label5);
            panel_info.Controls.Add(label4);
            panel_info.Controls.Add(txt_address);
            panel_info.Controls.Add(label3);
            panel_info.Controls.Add(txt_email);
            panel_info.Controls.Add(txt_mobile);
            panel_info.Controls.Add(label2);
            panel_info.Controls.Add(txt_name);
            panel_info.Controls.Add(label12);
            panel_info.Location = new Point(197, 46);
            panel_info.Name = "panel_info";
            panel_info.Size = new Size(278, 531);
            panel_info.TabIndex = 20;
            // 
            // ptb_avatar
            // 
            ptb_avatar.Image = Properties.Resources.icons8_user_35;
            ptb_avatar.Location = new Point(211, 13);
            ptb_avatar.Name = "ptb_avatar";
            ptb_avatar.Size = new Size(54, 48);
            ptb_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_avatar.TabIndex = 29;
            ptb_avatar.TabStop = false;
            // 
            // panel_status
            // 
            panel_status.Controls.Add(checkbx_block);
            panel_status.Controls.Add(label11);
            panel_status.Location = new Point(10, 463);
            panel_status.Name = "panel_status";
            panel_status.Size = new Size(142, 38);
            panel_status.TabIndex = 28;
            panel_status.Visible = false;
            // 
            // checkbx_block
            // 
            checkbx_block.AutoSize = true;
            checkbx_block.Location = new Point(77, 12);
            checkbx_block.Name = "checkbx_block";
            checkbx_block.Size = new Size(55, 19);
            checkbx_block.TabIndex = 30;
            checkbx_block.Text = "Block";
            checkbx_block.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label11.Location = new Point(8, 11);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 29;
            label11.Text = "STATUS";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label10.Location = new Point(10, 302);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 27;
            label10.Text = "3rd EMAIL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.Location = new Point(10, 253);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 26;
            label9.Text = "2nd EMAIL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.Location = new Point(10, 155);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 25;
            label8.Text = "3rd MOBILE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(10, 106);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 24;
            label7.Text = "2nd MOBILE";
            // 
            // txt_email3
            // 
            txt_email3.Location = new Point(10, 325);
            txt_email3.Name = "txt_email3";
            txt_email3.Size = new Size(255, 23);
            txt_email3.TabIndex = 23;
            // 
            // txt_mobile3
            // 
            txt_mobile3.Location = new Point(10, 178);
            txt_mobile3.Name = "txt_mobile3";
            txt_mobile3.Size = new Size(255, 23);
            txt_mobile3.TabIndex = 22;
            // 
            // txt_email2
            // 
            txt_email2.Location = new Point(10, 276);
            txt_email2.Name = "txt_email2";
            txt_email2.Size = new Size(255, 23);
            txt_email2.TabIndex = 21;
            // 
            // txt_mobile2
            // 
            txt_mobile2.Location = new Point(10, 129);
            txt_mobile2.Name = "txt_mobile2";
            txt_mobile2.Size = new Size(255, 23);
            txt_mobile2.TabIndex = 20;
            // 
            // radi_female
            // 
            radi_female.AutoSize = true;
            radi_female.Location = new Point(145, 441);
            radi_female.Name = "radi_female";
            radi_female.Size = new Size(63, 19);
            radi_female.TabIndex = 19;
            radi_female.TabStop = true;
            radi_female.Text = "Female";
            radi_female.UseVisualStyleBackColor = true;
            // 
            // radi_male
            // 
            radi_male.AutoSize = true;
            radi_male.Location = new Point(88, 441);
            radi_male.Name = "radi_male";
            radi_male.Size = new Size(51, 19);
            radi_male.TabIndex = 18;
            radi_male.TabStop = true;
            radi_male.Text = "Male";
            radi_male.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(10, 440);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 17;
            label6.Text = "GENDER";
            // 
            // combx_relationship
            // 
            combx_relationship.FormattingEnabled = true;
            combx_relationship.Items.AddRange(new object[] { "Family", "Close Friend", "Friend", "Colleague" });
            combx_relationship.Location = new Point(131, 406);
            combx_relationship.Name = "combx_relationship";
            combx_relationship.Size = new Size(134, 23);
            combx_relationship.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(10, 409);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 15;
            label5.Text = "RELATIONSHIP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(10, 354);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 13;
            label4.Text = "ADDRESS";
            // 
            // txt_address
            // 
            txt_address.Location = new Point(10, 377);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(255, 23);
            txt_address.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(10, 204);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "1st EMAIL";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(10, 227);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(255, 23);
            txt_email.TabIndex = 4;
            // 
            // txt_mobile
            // 
            txt_mobile.Location = new Point(10, 80);
            txt_mobile.Name = "txt_mobile";
            txt_mobile.Size = new Size(255, 23);
            txt_mobile.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(10, 57);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "1st MOBILE";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(10, 29);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(185, 23);
            txt_name.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label12.Location = new Point(10, 6);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 0;
            label12.Text = "NAME ";
            // 
            // txsearch
            // 
            txsearch.BorderStyle = BorderStyle.None;
            txsearch.Location = new Point(3, 12);
            txsearch.Name = "txsearch";
            txsearch.Size = new Size(181, 16);
            txsearch.TabIndex = 22;
            txsearch.TextChanged += txsearch_TextChanged;
            // 
            // resultContainer
            // 
            resultContainer.AutoScroll = true;
            resultContainer.BackColor = Color.White;
            resultContainer.Location = new Point(490, 91);
            resultContainer.Name = "resultContainer";
            resultContainer.Size = new Size(249, 434);
            resultContainer.TabIndex = 23;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1;
            timer.Tick += timer_Tick;
            // 
            // btn_searchnew
            // 
            btn_searchnew.BackColor = Color.Gainsboro;
            btn_searchnew.Image = Properties.Resources.icons8_search_30;
            btn_searchnew.Location = new Point(678, 46);
            btn_searchnew.Name = "btn_searchnew";
            btn_searchnew.Size = new Size(61, 45);
            btn_searchnew.SizeMode = PictureBoxSizeMode.CenterImage;
            btn_searchnew.TabIndex = 25;
            btn_searchnew.TabStop = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(txsearch);
            panel10.Location = new Point(490, 47);
            panel10.Name = "panel10";
            panel10.Size = new Size(187, 42);
            panel10.TabIndex = 26;
            // 
            // btn_editnew
            // 
            btn_editnew.BackColor = Color.Gainsboro;
            btn_editnew.Image = Properties.Resources.icons8_edit_30;
            btn_editnew.Location = new Point(556, 521);
            btn_editnew.Name = "btn_editnew";
            btn_editnew.Size = new Size(62, 56);
            btn_editnew.SizeMode = PictureBoxSizeMode.CenterImage;
            btn_editnew.TabIndex = 25;
            btn_editnew.TabStop = false;
            btn_editnew.Click += btn_editnew_Click;
            // 
            // btn_removenew
            // 
            btn_removenew.BackColor = Color.Gainsboro;
            btn_removenew.Image = Properties.Resources.icons8_delete_30;
            btn_removenew.Location = new Point(618, 521);
            btn_removenew.Name = "btn_removenew";
            btn_removenew.Size = new Size(62, 56);
            btn_removenew.SizeMode = PictureBoxSizeMode.CenterImage;
            btn_removenew.TabIndex = 25;
            btn_removenew.TabStop = false;
            btn_removenew.Click += btn_removenew_Click;
            // 
            // btn_newcontact
            // 
            btn_newcontact.BackColor = Color.Gainsboro;
            btn_newcontact.Image = Properties.Resources.icons8_add_30;
            btn_newcontact.Location = new Point(490, 521);
            btn_newcontact.Name = "btn_newcontact";
            btn_newcontact.Size = new Size(66, 56);
            btn_newcontact.SizeMode = PictureBoxSizeMode.CenterImage;
            btn_newcontact.TabIndex = 27;
            btn_newcontact.TabStop = false;
            btn_newcontact.Click += btn_newcontact_Click;
            // 
            // btn_exportBlockNew
            // 
            btn_exportBlockNew.BackColor = Color.Gainsboro;
            btn_exportBlockNew.Image = Properties.Resources.icons8_export_30;
            btn_exportBlockNew.Location = new Point(678, 521);
            btn_exportBlockNew.Name = "btn_exportBlockNew";
            btn_exportBlockNew.Size = new Size(61, 56);
            btn_exportBlockNew.SizeMode = PictureBoxSizeMode.CenterImage;
            btn_exportBlockNew.TabIndex = 28;
            btn_exportBlockNew.TabStop = false;
            btn_exportBlockNew.Click += btn_exportBlockNew_Click;
            // 
            // ContactForm_new
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(737, 576);
            Controls.Add(btn_exportBlockNew);
            Controls.Add(btn_newcontact);
            Controls.Add(btn_removenew);
            Controls.Add(btn_editnew);
            Controls.Add(panel10);
            Controls.Add(btn_searchnew);
            Controls.Add(resultContainer);
            Controls.Add(panel_info);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ContactForm_new";
            Load += ContactForm_new_Load;
            Click += ContactForm_new_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_info.ResumeLayout(false);
            panel_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_avatar).EndInit();
            panel_status.ResumeLayout(false);
            panel_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_searchnew).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_editnew).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_removenew).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_newcontact).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exportBlockNew).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_save;
        private Button btn_savefile;
        private Button btn_loadfile;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Panel panel_info;
        private Panel panel_status;
        private CheckBox checkbx_block;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txt_email3;
        private TextBox txt_mobile3;
        private TextBox txt_email2;
        private TextBox txt_mobile2;
        private RadioButton radi_female;
        private RadioButton radi_male;
        private Label label6;
        private ComboBox combx_relationship;
        private Label label5;
        private Label label4;
        private TextBox txt_address;
        private Label label3;
        private TextBox txt_email;
        private TextBox txt_mobile;
        private Label label2;
        private TextBox txt_name;
        private Label label12;
        private PictureBox pictureBox2;
        private Label label13;
        private TextBox txsearch;
        private FlowLayoutPanel resultContainer;
        private System.Windows.Forms.Timer timer;
        private PictureBox btn_searchnew;
        private Panel panel10;
        private PictureBox btn_editnew;
        private PictureBox btn_removenew;
        private DesignControls.roundedPicturebox ptb_avatar;
        private PictureBox btn_newcontact;
        private PictureBox btn_exportBlockNew;
    }
}
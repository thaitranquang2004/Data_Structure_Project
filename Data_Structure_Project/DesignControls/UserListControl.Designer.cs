namespace Data_Structure_Project.DesignControls
{
    partial class UserListControl
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
            lbname = new Label();
            lbcontent = new Label();
            avatar = new roundedPicturebox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            SuspendLayout();
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lbname.Location = new Point(68, 7);
            lbname.Name = "lbname";
            lbname.Size = new Size(122, 20);
            lbname.TabIndex = 0;
            lbname.Text = "Complete Name";
            lbname.Click += lbname_Click;
            lbname.MouseLeave += lbname_MouseLeave;
            lbname.MouseHover += lbname_MouseHover;
            // 
            // lbcontent
            // 
            lbcontent.AutoSize = true;
            lbcontent.Font = new Font("Segoe UI", 9.75F);
            lbcontent.Location = new Point(72, 30);
            lbcontent.Name = "lbcontent";
            lbcontent.Size = new Size(53, 17);
            lbcontent.TabIndex = 1;
            lbcontent.Text = "Content";
            lbcontent.Click += lbrelationship_Click;
            lbcontent.MouseLeave += lbrelationship_MouseLeave;
            lbcontent.MouseHover += lbrelationship_MouseHover;
            // 
            // avatar
            // 
            avatar.Image = Properties.Resources.icons8_user_35;
            avatar.Location = new Point(14, 7);
            avatar.Name = "avatar";
            avatar.Size = new Size(42, 40);
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.TabIndex = 2;
            avatar.TabStop = false;
            avatar.Click += roundedPicturebox1_Click;
            avatar.MouseLeave += roundedPicturebox1_MouseLeave;
            avatar.MouseHover += roundedPicturebox1_MouseHover;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 10);
            panel1.TabIndex = 3;
            // 
            // UserListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(avatar);
            Controls.Add(lbcontent);
            Controls.Add(lbname);
            Margin = new Padding(0);
            Name = "UserListControl";
            Size = new Size(232, 54);
            Click += UserListControl_Click;
            MouseLeave += UserListControl_MouseLeave;
            MouseHover += UserListControl_MouseHover;
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbname;
        private Label lbcontent;
        private roundedPicturebox avatar;
        private Panel panel1;
    }
}

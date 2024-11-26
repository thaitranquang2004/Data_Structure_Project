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
            lbrelationship = new Label();
            roundedPicturebox1 = new roundedPicturebox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)roundedPicturebox1).BeginInit();
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
            // lbrelationship
            // 
            lbrelationship.AutoSize = true;
            lbrelationship.Font = new Font("Segoe UI", 9.75F);
            lbrelationship.Location = new Point(72, 30);
            lbrelationship.Name = "lbrelationship";
            lbrelationship.Size = new Size(79, 17);
            lbrelationship.TabIndex = 1;
            lbrelationship.Text = "Relationship";
            lbrelationship.Click += lbrelationship_Click;
            lbrelationship.MouseLeave += lbrelationship_MouseLeave;
            lbrelationship.MouseHover += lbrelationship_MouseHover;
            // 
            // roundedPicturebox1
            // 
            roundedPicturebox1.Image = Properties.Resources.icons8_user_35;
            roundedPicturebox1.Location = new Point(14, 7);
            roundedPicturebox1.Name = "roundedPicturebox1";
            roundedPicturebox1.Size = new Size(42, 40);
            roundedPicturebox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundedPicturebox1.TabIndex = 2;
            roundedPicturebox1.TabStop = false;
            roundedPicturebox1.Click += roundedPicturebox1_Click;
            roundedPicturebox1.MouseLeave += roundedPicturebox1_MouseLeave;
            roundedPicturebox1.MouseHover += roundedPicturebox1_MouseHover;
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
            Controls.Add(roundedPicturebox1);
            Controls.Add(lbrelationship);
            Controls.Add(lbname);
            Margin = new Padding(0);
            Name = "UserListControl";
            Size = new Size(232, 54);
            Click += UserListControl_Click;
            MouseLeave += UserListControl_MouseLeave;
            MouseHover += UserListControl_MouseHover;
            ((System.ComponentModel.ISupportInitialize)roundedPicturebox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbname;
        private Label lbrelationship;
        private roundedPicturebox roundedPicturebox1;
        private Panel panel1;
    }
}

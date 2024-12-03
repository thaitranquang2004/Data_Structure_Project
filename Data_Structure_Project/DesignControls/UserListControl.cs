using Data_Structure_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structure_Project.DesignControls
{
    internal partial class UserListControl : UserControl
    {
        public UserListControl()
        {
            InitializeComponent();
        }

        string temp_id;
        public static string id;

        public void details(Contact d)
        {
            lbname.Text = d.Name.ToUpper();
            lbcontent.Text = d.Relationship;
            temp_id = d.Id.ToString();
            avatar.ImageLocation = d.Avatar;
        }

        public void detailsMobile(Contact d)
        {
            lbname.Text = d.Name.ToUpper();
            lbcontent.Text = d.Mobile + " (1st Mobile)";
            temp_id = d.Id.ToString();
            avatar.ImageLocation = d.Avatar;
        }

        public void detailsMobile2(Contact d)
        {
            lbname.Text = d.Name.ToUpper();
            lbcontent.Text = d.Mobile2 + " (2nd Mobile)";
            temp_id = d.Id.ToString();
            avatar.ImageLocation = d.Avatar;
        }

        public void detailsMobile3(Contact d)
        {
            lbname.Text = d.Name.ToUpper();
            lbcontent.Text = d.Mobile3 + " (3rd Mobile)";
            temp_id = d.Id.ToString();
            avatar.ImageLocation = d.Avatar;
        }

        public void searchResult(string key)
        {
            Contact contact = new Contact();
            lbname.Text = contact.Name;
            lbcontent.Text = contact.Relationship;
        }

        public static bool clicked = false;

        private void UserListControl_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void UserListControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UserListControl_Click(object sender, EventArgs e)
        {
            clicked = true;
            this.BackColor = Color.Silver;
            id = temp_id;
        }

        private void roundedPicturebox1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void roundedPicturebox1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void roundedPicturebox1_Click(object sender, EventArgs e)
        {
            clicked = true;
            this.BackColor = Color.Silver;
            id = temp_id;
        }

        private void lbname_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void lbname_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lbname_Click(object sender, EventArgs e)
        {
            clicked = true;
            this.BackColor = Color.Silver;
            id = temp_id;
        }

        private void lbrelationship_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void lbrelationship_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lbrelationship_Click(object sender, EventArgs e)
        {
            clicked = true;
            this.BackColor = Color.Silver;
            id = temp_id;
        }
    }
}

using Data_Structure_Project.Controls;
using Data_Structure_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structure_Project.Views
{
    public partial class ContactForm : Form
    {
        DSCM<Contact> dscm = new DSCM<Contact>();

        private void reset()
        {
            txt_name.Text = "";
            txt_mobile.Text = "";
            txt_email.Text = "";
        }

        private void loadtreeview()
        {
            tv_show.Nodes.Clear();
            List<Contact> contacts = new List<Contact>();
            contacts = dscm.contact();
            foreach (Contact h in contacts)
            {
                TreeNode root = new TreeNode();
                root.Text = "Ten: " + h.Name;
                TreeNode Node1 = new TreeNode();
                root.Nodes.Add(Node1);
                Node1.Text = "SDT: " + h.Mobile;
                TreeNode Node2 = new TreeNode();
                root.Nodes.Add(Node2);
                Node2.Text = "Email: " + h.Email;
                TreeNode Node3 = new TreeNode();
                root.Nodes.Add(Node3);
                Node3.Text = "Status: " + h.Status.ToString();
                tv_show.Nodes.Add(root);
            }
        }

        public ContactForm()
        {
            InitializeComponent();
            panel_info.Enabled = false;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            reset();
            panel_info.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "") MessageBox.Show("Nhap ten!");
            else if (txt_mobile.Text == "") MessageBox.Show("Nhap sdt!");
            else
            {
                Contact ct = new Contact();
                Random rd = new Random();
                ct.Id = rd.Next(1, 1000);
                ct.Name = txt_name.Text;
                ct.Mobile = txt_mobile.Text;
                ct.Email = txt_email.Text;
                ct.Status = 0;
                dscm.insert(ct);
                lb_test.Text = dscm.xuat();
                panel_info.Enabled = false;
                reset();
                loadtreeview();
            }
            
        }
    }
}

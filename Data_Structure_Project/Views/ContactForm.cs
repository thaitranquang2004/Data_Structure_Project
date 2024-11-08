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
            txt_mobile2.Text = "";
            txt_mobile3.Text = "";
            txt_email.Text = "";
            txt_email2.Text = "";
            txt_email3.Text = "";
            txt_address.Text = "";
            combx_relationship.SelectedIndex = 0;
            radi_female.Checked = false;
            radi_male.Checked = false;
            btn_remove.Visible = false;
            btn_edit.Visible = false;
            txt_search.Text = "";

        }

        private void loadlsbx()
        {
            lsbx_show.Items.Clear();
            foreach (Contact h in dscm.contact())
            {
                lsbx_show.Items.Add(h);
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
            combx_relationship.SelectedIndex = 0;
            radi_male.Checked = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (lsbx_show.SelectedIndex != -1)
            {
                    Contact ct = new Contact();
                    ct.Name = txt_name.Text;
                    ct.Mobile = txt_mobile.Text;
                    ct.Mobile2 = txt_mobile2.Text;
                    ct.Mobile3 = txt_mobile3.Text;
                    ct.Email = txt_email.Text;
                    ct.Email2 = txt_email2.Text;
                    ct.Email3 = txt_email3.Text;
                    ct.Address = txt_address.Text;
                    ct.Relationship = combx_relationship.Text;
                    if (radi_male.Checked) ct.Gender = radi_male.Text;
                    else if (radi_female.Checked) ct.Gender = radi_female.Text;
                    dscm.edit(lsbx_show.SelectedIndex,ct);
                    panel_info.Enabled = false;
                    reset();
                    loadlsbx();
            }
            else
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
                    ct.Mobile2 = txt_mobile2.Text;
                    ct.Mobile3 = txt_mobile3.Text;
                    ct.Email = txt_email.Text;
                    ct.Email2 = txt_email2.Text;
                    ct.Email3 = txt_email3.Text;
                    ct.Address = txt_address.Text;
                    ct.Relationship = combx_relationship.Text;
                    if (radi_male.Checked) ct.Gender = radi_male.Text;
                    else if (radi_female.Checked) ct.Gender = radi_female.Text;
                    ct.Status = 0;
                    dscm.insert(ct);
                    panel_info.Enabled = false;
                    reset();
                    loadlsbx();
                }
            }
            

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            loadlsbx();
            reset();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            dscm.remove(lsbx_show.SelectedIndex);
            reset();
            loadlsbx();
        }

        private void lsbx_show_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_search.Text == "") { 
                btn_remove.Visible = true;
                btn_edit.Visible = true;
            }
            
            if (lsbx_show.SelectedIndex != -1)
            {
                Contact contact = lsbx_show.SelectedItem as Contact;
                txt_name.Text = contact.Name;
                txt_mobile.Text = contact.Mobile;
                txt_mobile2.Text = contact.Mobile2;
                txt_mobile3.Text = contact.Mobile3;
                txt_email.Text = contact.Email;
                txt_email2.Text = contact.Email2;
                txt_email3.Text = contact.Email3;
                txt_address.Text = contact.Address;
                combx_relationship.Text = contact.Relationship;
                if (contact.Gender == "Male") radi_male.Checked = true;
                else radi_female.Checked = true;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            reset();
            panel_info.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            panel_info.Enabled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            reset();
            lsbx_show.Items.Clear();
            foreach (Contact h in dscm.contact())
            {
                if (String.Compare(txt_search.Text, h.Name, true) == 0) lsbx_show.Items.Add(h);
            }
        }
    }
}
